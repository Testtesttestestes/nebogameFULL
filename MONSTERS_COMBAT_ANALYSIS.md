# Полное описание лобби игрока и объекта игрока (по декомпилированному клиенту)

> Важно: репозиторий декомпилирован, часть тел методов неполная. Поэтому ниже — структурная карта на уровне архитектуры и моделей данных, подтверждаемая явными типами/полями/свойствами.

## 1) Что такое «лобби» в коде

Лобби в клиенте собрано из `UserInterfaceView` + `UserInterfaceButtonsView` и связанных контроллеров/моделей.

### Главные разделы/кнопки лобби
`UserInterfaceButtonsView` содержит основные entry points:
- бой (`CombatButton`)
- аккаунты (`AccountsButton`)
- дейлики (`DailyQuestButton`)
- theme duel (`ThemeDuelButton`)
- игровые события (`GameEventsButton`)
- trade / craft
- small games
- clan
- menu
- chest / bonuses / bank

То есть лобби — это центральный хаб переходов в игровые подсистемы. 【F:Assembly-CSharp/Gameplay/UserInterface/View/UserInterfaceButtonsView.cs†L10-L179】

## 2) Объект игрока: базовая модель

Ключевая сущность — `Core.Data.UserData`.

### Какие данные и сигналы хранит `UserData`
- события изменения игрока: профиль, баланс, ник, опыт, уровень, APR (образ), культ, гендер и т.д.
- базовые поля: `CultDic`, `Gender`, `Apr`, `Experience`, `LicenseCount`, `TreeLevel`, `UserInfo`, `Money`, `Accounts`.

Это делает `UserData` «агрегатом состояния игрока» для UI и gameplay-моделей. 【F:Assembly-CSharp/Core/Data/UserData.cs†L21-L221】【F:Assembly-CSharp/Core/Data/UserData.cs†L343-L446】【F:Assembly-CSharp/Core/Data/UserData.cs†L667-L742】

Дополнительный слой (`Gameplay.User.Model.UserModel`) держит мета-параметры прогресса и статусов:
- прогресс опыта и следующий уровень,
- реген энергии,
- профессия,
- бан-статус,
- доступные культы.
【F:Assembly-CSharp/Gameplay/User/Model/UserModel.cs†L71-L181】【F:Assembly-CSharp/Gameplay/User/Model/UserModel.cs†L97-L126】【F:Assembly-CSharp/Gameplay/User/Model/UserModel.cs†L132-L168】

## 3) Ресурсы и валюта

Валютный слой построен вокруг `ResourceSet`:
- у игрока баланс лежит в `UserData.Money`;
- `UserData` реализует `IBalanceSource` и публикует `BalanceChangedEvent`;
- много сущностей (спеллы/предметы/сервисы) также отдают цены через `ResourceSet`.

Это единый формат для разных валют/ресурсов. 【F:Assembly-CSharp/Core/Data/UserData.cs†L47-L61】【F:Assembly-CSharp/Core/Data/UserData.cs†L716-L729】

## 4) Инвентарь: устройство и контейнеры

Центр инвентаря — `InventoryBaseModel`:
- все предметы: `ArtifactsByArtifactId`
- избранное: `Favorites`
- «новые»: `Fresh`
- сундук: `ChestArtifacts`, `ChestArtifactsByArtikulType`
- сумка: `BagArtifacts`
- экипировка: `Equipment`
- слоты/ёмкость: `BagEmptySlotsNum`, `ChestEmptySlotsNum`, `ChestTotalSlotsNum`, `TotalSlotsAvailable`, `EquipSlotsIds`

Это даёт чёткое разделение: **bag / chest / equipped / special lists**. 【F:Assembly-CSharp/Gameplay/Inventory/Model/InventoryBaseModel.cs†L22-L199】

UI-слой инвентаря также разделён:
- отдельный bag view (`InventoryBagView`),
- отдельное окно сундука (`InventoryChestWindow`, tab bar + bag + grid).
【F:Assembly-CSharp/Gameplay/Inventory/View/Bag/InventoryBagView.cs†L15-L60】【F:Assembly-CSharp/Gameplay/Inventory/View/Chest/InventoryChestWindow.cs†L203-L220】

## 5) Классификация предметов

Базовая модель предмета — `ArtikulData`:
- словарная связка: `Artikul`, `ArtikulTypeDic`, `TypeId`, качество (`ArtikulQuality`)
- предмет может нести заклинания (`Spell`, `Spells`, `AllAttachedSpells`)
- есть флаги типа использования: `IsEquipment`, `IsUserItem`, `IsDollItem`, `IsGolemItem`
- есть требования (`Requirements`, `TargetRequirements`)
- и базовые параметры долговечности/стака.

По сути, это ядро классификации item-системы. 【F:Assembly-CSharp/Core/Data/ArtikulData.cs†L19-L68】【F:Assembly-CSharp/Core/Data/ArtikulData.cs†L100-L170】【F:Assembly-CSharp/Core/Data/ArtikulData.cs†L176-L260】

Дополнительно у табов есть типы фильтрации:
- `All`, `Favorite`, `Fresh`, `ArtikulTypeFilter`.
【F:Assembly-CSharp/Gameplay/Inventory/Model/Tabs/InventoryTabData.cs†L29-L43】

И есть тип источника/слота предмета (`InventorySlotType`):
- `User`, `Drop`, `Shop`, `ManufactureAssistant`, `ThemeDuelShop`, `PortalsShop` и т.д.
【F:Assembly-CSharp/Gameplay/Inventory/Model/InventorySlotType.cs†L8-L34】

## 6) Экипировка героя

### Слоты экипировки
`EquipmentSlotIds` описывает слоты персонажа:
- `RIGHT_HAND`, `LEFT_HAND`, `ARMOR`, `RING`, `AMULET`, `RELIC`, `TALISMAN`, `PET`
- расширенные/доп. слоты: `EXTRA_SLOT_1..3`
- спецслоты вроде `SIGN_OF_STRENGTH`, `VESTMENT`, `SCABBARD`, `TROPHY`.
【F:Assembly-CSharp/Gameplay/Inventory/Model/EquipmentSlotIds.cs†L8-L58】

### Где это отображается
В user-info используется `UserEquipmentView` + `UserEquipmentSlotConfig`, есть отдельный блок `ExtraSlots`. 【F:Assembly-CSharp/Gameplay/UserInfo/View/Equipment/UserEquipmentView.cs†L9-L36】【F:Assembly-CSharp/Gameplay/UserInfo/View/Equipment/UserEquipmentSlotConfig.cs†L10-L34】

## 7) Параметры и «статы» предмета

`ArtifactData` (наследник `ArtikulData`) хранит то, что реально влияет на силу:
- `UserSkills`
- `Power`, `PowerNormalized`, `PowerNormalizedTotal`
- долговечность (`CurrentDurability`, `MaxDurability`)
- требования/пороги (`MinLevel`, `Cult`, `Rank`)
- рыночные/экономические параметры (`Price`, `SellPrice`)
- жизненный цикл (`LifeDurationTime`, временность, restore/forge-флаги)

Именно артефакты, а не UI-образ, являются основным носителем статов в лобби-части кода. 【F:Assembly-CSharp/Core/Data/ArtifactData.cs†L143-L221】【F:Assembly-CSharp/Core/Data/ArtifactData.cs†L409-L567】【F:Assembly-CSharp/Core/Data/ArtifactData.cs†L698-L716】

## 8) Методы работы с предметами (починка и т.п.)

Система действий реализована через `ContextMenu` элементы. В коде явно есть отдельные классы для:
- `EquipArtifactContextMenuElement`
- `RepairUserArtifactContextMenuElement`
- `ReforgeUserArtifactContextMenuElement`
- `RestoreUserArtifactContextMenuElement`
- `DismantleArtifactContextMenuElement`

То есть операции (экипировать/починить/перековать/восстановить/разобрать) выделены как отдельные action-компоненты. 【F:Assembly-CSharp/Gameplay/Inventory/ContextMenu/EquipArtifactContextMenuElement.cs†L10-L29】【F:Assembly-CSharp/Gameplay/Inventory/ContextMenu/RepairUserArtifactContextMenuElement.cs†L10-L29】【F:Assembly-CSharp/Gameplay/Inventory/ContextMenu/ReforgeUserArtifactContextMenuElement.cs†L10-L29】【F:Assembly-CSharp/Gameplay/Inventory/ContextMenu/RestoreUserArtifactContextMenuElement.cs†L10-L29】【F:Assembly-CSharp/Gameplay/Inventory/ContextMenu/DismantleArtifactContextMenuElement.cs†L10-L29】

## 9) Скины/образы (APR): как устроены и где хранятся

В этом клиенте визуальный образ игрока проходит через `AprDicWrapper`/`AprDic`:
- у `UserData` есть текущее поле `Apr`;
- в `UserInfoModel` есть `CurrentSelectedApr` (выбор образа в UI редактирования);
- APR-resources выдаются через `AprDicExt` (asset id для разных представлений: list/info/combat/avatar и т.п.);
- есть признаки special/individual (`IsSpecial`, `IsIndividual`).

Это указывает, что APR в первую очередь слой визуализации/идентичности, а не основной слой предметных статов. 【F:Assembly-CSharp/Core/Data/UserData.cs†L376-L389】【F:Assembly-CSharp/Gameplay/UserInfo/Model/UserInfoModel.cs†L130-L145】【F:Assembly-CSharp/Core/Dict/DictWrappers/Wrappers/AprDicWrapper.cs†L10-L31】【F:Assembly-CSharp/Core/Extensions/Dict/AprDicExt.cs†L14-L54】【F:Assembly-CSharp/Core/Extensions/Dict/AprDicExt.cs†L766-L817】

## 10) Аккаунтная надстройка в лобби

Отдельно от инвентаря есть подсистема аккаунтов (`AccountsModel`), где хранятся/переключаются:
- доступные аккаунты (`AvailAccounts`),
- текущий аккаунт (`CurrentBrowsedAccount`),
- и типы аккаунтов (`BattleAccount`, `ManufactureAccount`, `TradeAccount`),
- плюс интеграция с банком (`Bank`).

Это влияет на лимиты/экономику/режимы в лобби, но не заменяет `UserData` как базовую модель игрока. 【F:Assembly-CSharp/Gameplay/Accounts/Model/AccountsModel.cs†L23-L172】

## 11) Короткий практический вывод

1. **Лобби** — это UI-хаб (`UserInterfaceButtonsView`) + связанные доменные модули.
2. **Игрок** — агрегат `UserData` (профиль, валюта, культура/гендер, APR, аккаунты).
3. **Статы и прогресс силы** в основном идут через **артефакты/экипировку** (`ArtifactData`, `InventoryBaseModel.Equipment`), а не через сам образ APR.
4. **Инвентарь** — многоконтейнерный (bag/chest/equipment/favorites/fresh) с фильтрами и контекстными действиями.
5. **Скины/образы (APR)** — отдельный слой визуальной кастомизации с dictionary-asset резолвом.
