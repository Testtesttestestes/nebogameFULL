using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core.Data;
using Gameplay.Craft.Controller.Filters;
using Gameplay.Craft.Events;
using Gameplay.Craft.Model;
using Gameplay.Craft.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Craft;
using Protocol.Dic;
using Protocol.Main;
using UI.Filters;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Craft.Controller
{
	// Token: 0x020008C8 RID: 2248
	[Token(Token = "0x20008C8")]
	public class CraftViewMediator : AbstractViewMediator<CraftModel, Gameplay.Craft.Events.CraftEvents, CraftController, CraftWindow>
	{
		// Token: 0x060034DD RID: 13533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034DD")]
		[Address(RVA = "0x8506", Offset = "0x8506", VA = "0x8506")]
		public CraftViewMediator(CraftModel model, Gameplay.Craft.Events.CraftEvents events, CraftController controller)
		{
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x060034DE RID: 13534 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A77")]
		private CraftSlotListElement SelectedSlot
		{
			[Token(Token = "0x60034DE")]
			[Address(RVA = "0x8507", Offset = "0x8507", VA = "0x8507")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (set) Token: 0x060034DF RID: 13535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A78")]
		public override CraftWindow View
		{
			[Token(Token = "0x60034DF")]
			[Address(RVA = "0x8508", Offset = "0x8508", VA = "0x8508", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (set) Token: 0x060034E0 RID: 13536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A79")]
		public override Gameplay.Craft.Events.CraftEvents Events
		{
			[Token(Token = "0x60034E0")]
			[Address(RVA = "0x8509", Offset = "0x8509", VA = "0x8509", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (set) Token: 0x060034E1 RID: 13537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A7A")]
		public override CraftController Controller
		{
			[Token(Token = "0x60034E1")]
			[Address(RVA = "0x850A", Offset = "0x850A", VA = "0x850A", Slot = "18")]
			set
			{
			}
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E2")]
		[Address(RVA = "0x850B", Offset = "0x850B", VA = "0x850B")]
		private void Init()
		{
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E3")]
		[Address(RVA = "0x850C", Offset = "0x850C", VA = "0x850C")]
		private void HandleActiveSlot(CraftSlotListElement slot, UserCraftSlotInfo slotInfo)
		{
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E4")]
		[Address(RVA = "0x850D", Offset = "0x850D", VA = "0x850D")]
		private void HandleRecipesView()
		{
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E5")]
		[Address(RVA = "0x850E", Offset = "0x850E", VA = "0x850E")]
		private void HandleCraftSlotsView()
		{
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034E6")]
		[Address(RVA = "0x850F", Offset = "0x850F", VA = "0x850F")]
		private CraftRecipeListElement.CraftRecipeListElementArgs ConstructArgs(CraftSchemeData data)
		{
			return null;
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E7")]
		[Address(RVA = "0x8510", Offset = "0x8510", VA = "0x8510")]
		private void SelectCraftRecipeListElement(CraftRecipeListElement.CraftRecipeListElementArgs args)
		{
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E8")]
		[Address(RVA = "0x8511", Offset = "0x8511", VA = "0x8511")]
		private void SelectCraftSlotListElement(CraftSlotListElement element)
		{
		}

		// Token: 0x060034E9 RID: 13545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E9")]
		[Address(RVA = "0x8512", Offset = "0x8512", VA = "0x8512")]
		private void UpdateRecipeInfo(CraftSchemeData data)
		{
		}

		// Token: 0x060034EA RID: 13546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034EA")]
		[Address(RVA = "0x8513", Offset = "0x8513", VA = "0x8513")]
		private void PopulateFiltersData()
		{
		}

		// Token: 0x060034EB RID: 13547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034EB")]
		[Address(RVA = "0x8514", Offset = "0x8514", VA = "0x8514")]
		private void RedrawRecipesList()
		{
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034EC")]
		[Address(RVA = "0x8515", Offset = "0x8515", VA = "0x8515")]
		private List<CraftSchemeData> FilterCraftSchemes(IList<CraftSchemeData> rawData)
		{
			return null;
		}

		// Token: 0x060034ED RID: 13549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034ED")]
		[Address(RVA = "0x8516", Offset = "0x8516", VA = "0x8516")]
		private void UpdateCounter()
		{
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034EE")]
		[Address(RVA = "0x8517", Offset = "0x8517", VA = "0x8517")]
		private void RedrawCraftSlots()
		{
		}

		// Token: 0x060034EF RID: 13551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034EF")]
		[Address(RVA = "0x8518", Offset = "0x8518", VA = "0x8518")]
		private void FilterCraftSlots()
		{
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034F0")]
		[Address(RVA = "0x8519", Offset = "0x8519", VA = "0x8519")]
		private IEnumerator DelayedRequest(float seconds)
		{
			return null;
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F1")]
		[Address(RVA = "0x851A", Offset = "0x851A", VA = "0x851A")]
		private void ShowValuePicker(int maxValue, int maxEnoughValue)
		{
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F2")]
		[Address(RVA = "0x851B", Offset = "0x851B", VA = "0x851B")]
		private void PickerWindowOnSelectedEvent(uint quantity)
		{
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F3")]
		[Address(RVA = "0x851C", Offset = "0x851C", VA = "0x851C")]
		private void PickerWindowOnClose()
		{
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034F4")]
		[Address(RVA = "0x851D", Offset = "0x851D", VA = "0x851D")]
		public DialogWindow ShowStartCraftingConfirmationWindow(uint schemeId, uint quantity)
		{
			return null;
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034F5")]
		[Address(RVA = "0x851E", Offset = "0x851E", VA = "0x851E")]
		public DialogWindow ShowRentSlotConfirmationWindow(CraftSlotDic craftSlotDic, [Optional] Action callback)
		{
			return null;
		}

		// Token: 0x060034F6 RID: 13558 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034F6")]
		[Address(RVA = "0x851F", Offset = "0x851F", VA = "0x851F")]
		public BaseWindow ShowAccelerateConfirmationWindow()
		{
			return null;
		}

		// Token: 0x060034F7 RID: 13559 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034F7")]
		[Address(RVA = "0x8520", Offset = "0x8520", VA = "0x8520")]
		public DialogWindow ShowSlotExpiredWindow()
		{
			return null;
		}

		// Token: 0x060034F8 RID: 13560 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034F8")]
		[Address(RVA = "0x8521", Offset = "0x8521", VA = "0x8521")]
		private DialogWindow ShowNotAvailableSlotsWindow()
		{
			return null;
		}

		// Token: 0x060034F9 RID: 13561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F9")]
		[Address(RVA = "0x8522", Offset = "0x8522", VA = "0x8522", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034FA")]
		[Address(RVA = "0x8523", Offset = "0x8523", VA = "0x8523")]
		private void UserBalanceChangedEventHandler()
		{
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034FB")]
		[Address(RVA = "0x8524", Offset = "0x8524", VA = "0x8524")]
		private void ProfessionRequestedEventHandler()
		{
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034FC")]
		[Address(RVA = "0x8525", Offset = "0x8525", VA = "0x8525")]
		private void SchemesRequestedEventHandler()
		{
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034FD")]
		[Address(RVA = "0x8526", Offset = "0x8526", VA = "0x8526")]
		private void CraftSlotsRequestedEventHandler()
		{
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034FE")]
		[Address(RVA = "0x8527", Offset = "0x8527", VA = "0x8527")]
		private void SetupTimer()
		{
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034FF")]
		[Address(RVA = "0x8528", Offset = "0x8528", VA = "0x8528")]
		private void ArtifactTakenEventHandler(DropTypes dropType)
		{
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003500")]
		[Address(RVA = "0x8529", Offset = "0x8529", VA = "0x8529")]
		private void ArtifactTakenEventHandler(DropTypes dropType, ArtifactData data)
		{
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003501")]
		[Address(RVA = "0x852A", Offset = "0x852A", VA = "0x852A")]
		private void SchemeChangedEventHandler(UserScheme scheme)
		{
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003502")]
		[Address(RVA = "0x852B", Offset = "0x852B", VA = "0x852B")]
		private void CraftSlotsChangedEventHandler()
		{
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003503")]
		[Address(RVA = "0x852C", Offset = "0x852C", VA = "0x852C")]
		private void CraftRecipeButtonClickedEventHandler(CraftRecipeListElement element)
		{
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003504")]
		[Address(RVA = "0x852D", Offset = "0x852D", VA = "0x852D")]
		private void CraftSlotButtonClickedEventHandler(CraftSlotListElement element)
		{
		}

		// Token: 0x06003505 RID: 13573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003505")]
		[Address(RVA = "0x852E", Offset = "0x852E", VA = "0x852E")]
		private void InChestButtonClickedEventHandler()
		{
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003506")]
		[Address(RVA = "0x852F", Offset = "0x852F", VA = "0x852F")]
		private void TakeButtonClickedEventHandler()
		{
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003507")]
		[Address(RVA = "0x8530", Offset = "0x8530", VA = "0x8530")]
		private void SellAllButtonClickedEventHandler()
		{
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003508")]
		[Address(RVA = "0x8531", Offset = "0x8531", VA = "0x8531")]
		private void RentButtonClickedEventHandler()
		{
		}

		// Token: 0x06003509 RID: 13577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003509")]
		[Address(RVA = "0x8532", Offset = "0x8532", VA = "0x8532")]
		private void AccelerateButtonClickedEventHandler()
		{
		}

		// Token: 0x0600350A RID: 13578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350A")]
		[Address(RVA = "0x8533", Offset = "0x8533", VA = "0x8533")]
		private void CancelButtonClickedEventHandler()
		{
		}

		// Token: 0x0600350B RID: 13579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350B")]
		[Address(RVA = "0x8534", Offset = "0x8534", VA = "0x8534")]
		private void MaxLevelButtonClickedEventHandler()
		{
		}

		// Token: 0x0600350C RID: 13580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350C")]
		[Address(RVA = "0x8535", Offset = "0x8535", VA = "0x8535")]
		private void CraftButtonClickedEventHandler()
		{
		}

		// Token: 0x0600350D RID: 13581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350D")]
		[Address(RVA = "0x8536", Offset = "0x8536", VA = "0x8536")]
		private void PickQuantityToCraft(CraftSlotListElement freeSlot)
		{
		}

		// Token: 0x0600350E RID: 13582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350E")]
		[Address(RVA = "0x8537", Offset = "0x8537", VA = "0x8537")]
		private void DeleteButtonClickedEventHandler()
		{
		}

		// Token: 0x0600350F RID: 13583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350F")]
		[Address(RVA = "0x8538", Offset = "0x8538", VA = "0x8538")]
		private void TabChangedEventHandler()
		{
		}

		// Token: 0x06003510 RID: 13584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003510")]
		[Address(RVA = "0x8539", Offset = "0x8539", VA = "0x8539")]
		private void FiltersViewChangedEventHandler()
		{
		}

		// Token: 0x06003511 RID: 13585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003511")]
		[Address(RVA = "0x853A", Offset = "0x853A", VA = "0x853A")]
		private void CompletedToggleChangedEventHandler()
		{
		}

		// Token: 0x06003515 RID: 13589 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003515")]
		[Address(RVA = "0x853E", Offset = "0x853E", VA = "0x853E")]
		[CompilerGenerated]
		private ArtifactData <SellAllButtonClickedEventHandler>g__GetArtifactData|72_0(ArtifactInfo artifactInfo)
		{
			return null;
		}

		// Token: 0x04001CEC RID: 7404
		[Token(Token = "0x4001CEC")]
		private const string LOCALIZATION_MASTERY_LEVEL = "CRAFT/MASTERY_LEVEL";

		// Token: 0x04001CED RID: 7405
		[Token(Token = "0x4001CED")]
		private const string LOCALIZATION_TIL_NEXT_LEVEL = "CRAFT/TIL_NEXT_LEVEL";

		// Token: 0x04001CEE RID: 7406
		[Token(Token = "0x4001CEE")]
		private const string LOCALIZATION_MAX_LEVEL_ANNOTATION = "CRAFT/MAX_LEVEL_ANNOTATION";

		// Token: 0x04001CEF RID: 7407
		[Token(Token = "0x4001CEF")]
		private const string LOCALIZATION_PRODUCTION = "CRAFT/PRODUCTION";

		// Token: 0x04001CF0 RID: 7408
		[Token(Token = "0x4001CF0")]
		private const string LOCALIZATION_CRAFT = "CRAFT/CRAFT";

		// Token: 0x04001CF1 RID: 7409
		[Token(Token = "0x4001CF1")]
		private const string LOCALIZATION_START_PRODUCTION = "CRAFT/START_PRODUCTION";

		// Token: 0x04001CF2 RID: 7410
		[Token(Token = "0x4001CF2")]
		private const string LOCALIZATION_BUYING_SLOT = "CRAFT/BUYING_SLOT";

		// Token: 0x04001CF3 RID: 7411
		[Token(Token = "0x4001CF3")]
		private const string LOCALIZATION_BUYING_SLOT_ANNOTATION = "CRAFT/BUYING_SLOT_ANNOTATION";

		// Token: 0x04001CF4 RID: 7412
		[Token(Token = "0x4001CF4")]
		private const string LOCALIZATION_ACCELERATE = "BUILDINGS/ACCELERATE_BUTTON";

		// Token: 0x04001CF5 RID: 7413
		[Token(Token = "0x4001CF5")]
		private const string LOCALIZATION_CRAFT_ACCELERATION = "CRAFT/CRAFT_ACCELERATION";

		// Token: 0x04001CF6 RID: 7414
		[Token(Token = "0x4001CF6")]
		private const string LOCALIZATION_CRAFT_ACCELERATION_ANNOTATION = "CRAFT/CRAFT_ACCELERATION_ANNOTATION";

		// Token: 0x04001CF7 RID: 7415
		[Token(Token = "0x4001CF7")]
		private const string LOCALIZATION_SLOT_EXPIRED = "CRAFT/SLOT_EXPIRED";

		// Token: 0x04001CF8 RID: 7416
		[Token(Token = "0x4001CF8")]
		private const string LOCALIZATION_SLOT_EXPIRED_ANNOTATION = "CRAFT/SLOT_EXPIRED_ANNOTATION";

		// Token: 0x04001CF9 RID: 7417
		[Token(Token = "0x4001CF9")]
		private const string LOCALIZATION_MAX_SKILL_LEVEL = "CRAFT/MAX_SKILL_LEVEL";

		// Token: 0x04001CFA RID: 7418
		[Token(Token = "0x4001CFA")]
		private const string LOCALIZATION_MAX_LEVEL_NOTE = "CRAFT/MAX_LEVEL_NOTE";

		// Token: 0x04001CFB RID: 7419
		[Token(Token = "0x4001CFB")]
		private const string LOCALIZATION_MAX_SKILL_LEVEL_ACHIEVED = "CRAFT/MAX_SKILL_LEVEL_ACHIEVED";

		// Token: 0x04001CFC RID: 7420
		[Token(Token = "0x4001CFC")]
		private const int MANUFACTURE_INDEX = 1;

		// Token: 0x04001CFD RID: 7421
		[Token(Token = "0x4001CFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<FilterInfo.FilterType, ICraftFilter> _filters;

		// Token: 0x04001CFE RID: 7422
		[Token(Token = "0x4001CFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly ICraftFilter _achievedFilter;

		// Token: 0x04001CFF RID: 7423
		[Token(Token = "0x4001CFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly CraftFilters.CompletedFilter _completedFilter;

		// Token: 0x04001D00 RID: 7424
		[Token(Token = "0x4001D00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private CraftRecipeListElement.CraftRecipeListElementArgs _selectedArgs;

		// Token: 0x04001D01 RID: 7425
		[Token(Token = "0x4001D01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CraftSpinPickerDialogWindow _pickerWindow;

		// Token: 0x04001D02 RID: 7426
		[Token(Token = "0x4001D02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private List<CraftSlotListElement> _slots;

		// Token: 0x04001D03 RID: 7427
		[Token(Token = "0x4001D03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _selectedSlotIndex;

		// Token: 0x04001D04 RID: 7428
		[Token(Token = "0x4001D04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private uint _selectedSchemeId;

		// Token: 0x04001D05 RID: 7429
		[Token(Token = "0x4001D05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Coroutine _timerRoutine;
	}
}
