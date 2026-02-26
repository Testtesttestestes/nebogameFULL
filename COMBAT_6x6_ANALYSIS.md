# Анализ основной логики боя на поле 6x6 (по декомпилированному псевдокоду)

## Важно про достоверность
- Репозиторий содержит декомпилированные C#-заглушки с фрагментами GHIDRA, поэтому часть методов имеет искажённые имена вызовов и неполные тела.
- Ключевой вывод: **ядро матчинга/резолва комбинаций находится на сервере** (через `ICombatService` и `Proto*`-события), а клиент отвечает за ввод, визуализацию, очередь анимаций и синхронизацию состояния UI.

## 1) Архитектура боя: кто за что отвечает

### Сервисный слой (серверный протокол)
`ICombatService` задаёт весь контракт онлайн-боя:
- входящие события: `FieldChangedEvent`, `PlayersActionEvent`, `CombatEventsEvent`, `CombatCompleteEvent`, `SwitchTurnEvent`, `SkillsChangedEvent`, `CooldownChangedEvent`, `SpellAppliedEvent`, `EffectsChangedEvent`, и т.д.;
- исходящие команды: `JoinToCombat()`, `PlayerAction(...)`, `RewardsGot()`.

Это означает, что для веб-порта нужно в первую очередь повторить **event-driven pipeline** поверх WebSocket/SignalR/другого транспорта.

### Controller/MVC слой
`CombatController<TModel, TEvents>`:
- подписывается на события `ICombatService`;
- формирует/обновляет модель (`CombatModel`);
- складывает изменения поля в конвейер (`CombatFieldChangesConvItem`);
- отдаёт View-медиатору сигналы через `CombatEvents`.

### View + Mediator
`AbstractCombatViewMediator<...>` и `GameFieldMono/BaseGameFieldMono`:
- принимают пользовательский ввод (drag/tap swap);
- эмитят `SwapEvent`;
- запускают анимации изменения поля и VFX;
- показывают ошибки свапа/подсказки/конец боя.

## 2) Почему именно 6x6
В коде поле параметризовано `XSize/YSize` (`GameFieldGamesData`), но в псевдокоде `BaseGameFieldMono::SetSize` видно:
- шаг сетки `0x58` = **88 px**;
- размеры в world/local space: `(size * 88 - 88)` по каждой оси.

Для 6x6 это даёт:
- индексы: `x,y in [0..5]`;
- физический span по оси: `6*88 - 88 = 440` (между крайними центрами).

Также в преобразовании pointer->cell используется формула с `+44` и делением на `88` (центрирование по половине ячейки), что подтверждает фиксированный тайл-сайз.

## 3) Главный цикл боя (клиент)

### Шаг A. Инициализация
1. Контроллер делает join в бой (`JoinToCombat`).
2. Модель получает `JoinToCombatInfo`, игроков, поле (`GameFieldGamesData.Gems`, размеры, наборы гемов).
3. View инициализирует `GameFieldMono.InitField(...)`, включает input coroutine и подписки на ввод.

### Шаг B. Локальный ввод игрока
1. Игрок выделяет камень/тянет в соседнюю клетку.
2. `BaseGameFieldMono`:
   - вычисляет cell под курсором;
   - ограничивает координаты по границам поля;
   - запускает локальный визуальный swap (`SwapStones`) и выделение (scale/offset).
3. Через mediator/controller отправляется `PlayerAction` типа swap (src/dst).
4. Модель ставит флаг ожидания ответа (`IsAwaitSwapStonesResponse`), чтобы не спамить повторные swap.

### Шаг C. Серверный резолв
После `PlayerAction` сервер присылает события:
- `ProtoFieldChangedEvt` (разрушения/падения/спавн/прочие изменения клетки);
- `ProtoCombatEventsEvt` (боевые эффекты/доп события);
- `ProtoSpellCoolDownChangedEvt`, `ProtoSpellAppliedEvt`, `ProtoEffectsChangedEvt`, `ProtoSkillsChangedEvt`;
- `ProtoSwitchTurnEvt`;
- `ProtoCombatCompleteEvt`.

### Шаг D. Конвейер анимаций
`CombatController` упаковывает изменение в `CombatFieldChangesConvItem{ ChangeType, Data, Duration, Delay }`.
Далее View-медиатор последовательно проигрывает анимации поля, VFX, UI-эффекты. Это критично: логика не «всё сразу», а **очередь** (conveyor), чтобы клиент совпадал с серверной последовательностью.

### Шаг E. Завершение
При `ProtoCombatCompleteEvt`:
- фиксируется game over data;
- запускаются end-эффекты поля;
- показывается окно результата;
- отправляется `RewardsGot()`.

## 4) Что считается “основной логикой поля”

## 4.1 Обмен камней (swap)
Локально:
- выбор камня;
- повторный выбор снимает выделение;
- при swap перекидываются ссылки в 2D-структуре поля;
- визуально перемещаются transform + scale/rotate tween.

Авторитетно:
- валиден swap или нет — решает сервер;
- при ошибке используется `SwapStonesError` и откат/коррекция клиентского вида.

## 4.2 Изменения ячеек (field changes)
По `FieldChangedTypes` задаются `Duration/Delay`.
Из доступного кода явно виден частный случай тайминга: для типа `2` возвращается `0.2f`, иначе `0f` (`GetAnimationTimeByFieldChangeType(int)`).
Также в классе присутствуют константы:
- `DESTROY_DURATION = 0.3f`
- `SHIFТ_AFTER_DESTROY_DURATION = 0.3f`

Это базовые фазы: уничтожение -> сдвиг/осыпание.

## 4.3 Координаты и хранение поля
Поле хранится как 2D структура с линейной адресацией вида:
`index = x * rowCount + y` (по фрагментам обращений к массиву).

Проверки everywhere:
- `x >= 0 && y >= 0`
- `x < ColNum` и `y < RowNum`

Именно это нужно один в один перенести в web-код, иначе будут «фантомные» баги на краях.

## 4.4 Подсказки хода (IdleHint)
`IdleHint.CheckForSwap(...)`:
- перебирает паттерны (`HintPatternSO`);
- проверяет соседей и соответствие `StonesTypes`;
- строго валидирует границы;
- при нахождении валидного потенциального swap сохраняет пару камней для подсветки.

Это клиентская эвристика для UX и не заменяет серверную валидацию действия.

## 4.5 Спеллы/эффекты
Спеллы работают поверх того же event-конвейера:
- выбор спелла -> `SpellTarget` -> `PlayerAction`;
- сервер возвращает `SpellApplied`, `EffectsChanged`, `CooldownChanged`, `SkillsChanged`;
- медиатор обновляет панели/маркеры/эффекты игроков.

## 5) Минимальная web-реплика (рекомендованный порядок портирования)
1. **State-модель**: бой, игроки, turn-state, field 6x6.
2. **Транспорт**: websocket + типизированные DTO для `Proto*` аналогов.
3. **Input**: pointer down/move/up, выбор/деселект/drag swap.
4. **Field renderer**: 6x6 слой, камни, выделение, swap-animation.
5. **Conveyor**: очередь field changes с `duration+delay`.
6. **Turn & timers**: блокировка ввода не в свой ход + `IsAwaitSwapStonesResponse` аналог.
7. **Spells/effects**: кнопки, target-режим, обработка server events.
8. **Hint engine**: перенос `IdleHint` паттернов после стабилизации базовой механики.

## 6) Практический вывод для переноса
- Не переносите «матч-3 резолвер» на клиент как источник истины; оставляйте сервер authoritative.
- Веб-клиент должен быть deterministic player: ввод -> запрос -> проигрывание серверных диффов поля в очереди.
- Для 6x6 зафиксируйте:
  - целочисленные индексы [0..5];
  - tile-size и формулу hit-test;
  - последовательность destroy/fall/spawn и длительности.

Именно такая схема в текущем Unity-клиенте уже заложена архитектурно.
