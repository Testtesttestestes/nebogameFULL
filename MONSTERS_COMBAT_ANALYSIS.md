# Анализ поведения противников (монстров) в бою

## Контекст
Перед разбором учтён вывод из `COMBAT_6x6_ANALYSIS.md`: в текущей архитектуре клиент в основном реактивный, а authoritative-логика матчинга/боевого резолва находится на сервере.

## 1) Как ходят противники

В обычном (не tutorial) бою клиент не содержит полноценного локального AI противника. Вместо этого:

1. Клиент подписан на события `ICombatService`:
   - `SwitchTurnEvent`
   - `PlayersActionEvent`
   - `FieldChangedEvent`
   - `CombatEventsEvent`
   - `SpellAppliedEvent`
   - `SkillsChangedEvent`
   - `CooldownChangedEvent`
   - `EffectsChangedEvent`
2. Когда приходит событие, `CombatController` обновляет модель и конвейер анимаций (field changes / эффекты / turn state).
3. Таким образом «ход монстра» на клиенте — это проигрывание уже вычисленного сервером результата.

Практически это означает: порядок «кто и как ходит» определяется сервером, клиент только отображает и синхронизирует состояние.

## 2) Как монстр/оппонент использует заклинания

Применение спеллов устроено как командно-событийный цикл:

1. Игрок (или серверно вычисленный оппонент) инициирует `PlayerAction`.
2. Для пользовательского каста клиент формирует `SpellTarget` (какой спелл, какие цели/координаты).
3. Результат применения приходит с сервера событиями:
   - `ProtoSpellAppliedEvt`
   - `ProtoEffectsChangedEvt`
   - `ProtoSpellCoolDownChangedEvt`
   - `ProtoSkillsChangedEvt`
4. `CombatController` применяет эти изменения к модели и UI.

Итого: клиент не «высчитывает» эффекты в одиночку, а применяет серверные диффы.

## 3) Где хранятся заклинания

### Runtime в бою
- У каждого `CombatPlayer` есть список `List<CombatSpellData> Spells`.

### Источник данных спелла
- `CombatSpellData` наследуется от `SpellData`.
- База `SpellData` содержит словарные сущности:
  - `SpellDic` (описание спелла)
  - `SpellLevelDic` (уровневые параметры)
  - `Effects` (набор эффектов)
- Создание боевой версии идёт через `CombatSpellDataFactory` и generic-фабрику `SpellData.Create<T>(...)`.

Следовательно, «что умеет спелл» хранится в словарях/балансных данных, а в бою это обёрнуто в `CombatSpellData`.

## 4) Как устроены способности и особенности спеллов

В `CombatSpellData` есть набор свойств, определяющих поведение в бою:

- ресурсно-статусные:
  - `Cooldown`
  - `Count`
  - `Enabled`
  - `Selectable`
- ограничения/контр-ограничения:
  - `IsUnblockable`
  - `IsBlockedByUserSkill`
- таргетинг и тип поведения:
  - `IsFriendlyTarget`
  - `IsUserBehaviorType`
  - `IsFieldBehaviorType`
  - `IsForceEffect`
- UX-состояние:
  - `Selected`
  - `Visible`

Это важный слой: здесь закодированы «особенности» конкретного боевого спелла на клиенте (валидность выбора, видимость, класс поведения).

## 5) Где в модели отражаются «состояния противника»

В `CombatPlayer` есть общие боевые маркеры, применимые к любому участнику (включая монстра/бота):

- `HasStunned`
- `HasSpellBlocked`
- `Spells`
- `PlayerInfo`, `UserId`, `User`

То есть «монстр» в боевой модели — тот же `CombatPlayer`, отличающийся источником данных и тем, что его действия приходят через серверные события.

## 6) Что относится именно к монстру как к сущности

В портальной ветке:

- есть `IMonsterSource.GetMonster()` — источник данных о монстре;
- `PortalCombatModel` хранит ссылку `MonsterSource`;
- `MonsterData` описывает мету монстра:
  - `MonsterDic`
  - `Backtime`
  - `AttackPrice` / `KickPrice`
  - `Title` / `Description` / `Level`
  - награды (`GetRewards(...)`)

Важно: это в основном мета/экономика/награды, а не локальный AI принятия ходов.

## 7) Единственное место с локальной эмуляцией оппонента

В `TutorialCombatV2` есть `EmulateCombatForTutorialGameService`, где присутствуют:

- `GetOpponentSwaps()`
- `GetAvailUserSwaps()`
- перечислители `_opponentSwaps`, `_turns`, `_skills`, `_field`

Это учебная эмуляция сценария и не равна продовой server-authoritative логике.

## Краткий итог

1. **Противник ходит через серверные события**, не через клиентский AI.
2. **Спеллы живут в `CombatPlayer.Spells`**, а их базовое определение — в `SpellDic/SpellLevelDic/Effects`.
3. **Применение спелла**: действие -> серверный резолв -> `SpellApplied/Effects/Cooldown/Skills` события.
4. **Способности/особенности** представлены набором флагов и статусов `CombatSpellData` + состояниями `CombatPlayer`.
5. Локальная «логика противника» есть только в **tutorial-эмуляторе**.
