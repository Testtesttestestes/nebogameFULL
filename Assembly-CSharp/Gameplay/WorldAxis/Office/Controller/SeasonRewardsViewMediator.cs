using System;
using System.Collections.Generic;
using Gameplay.VortexRating.View.GreatPrizesTab;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Gameplay.WorldAxis.Office.View.Rewards;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Dic;

namespace Gameplay.WorldAxis.Office.Controller
{
	// Token: 0x020002E1 RID: 737
	[Token(Token = "0x20002E1")]
	public class SeasonRewardsViewMediator : AbstractViewMediator<SeasonRewardsModel, WorldAxisOfficeEvents, WorldAxisOfficeController, SeasonRewardsView>, IHideableMediator
	{
		// Token: 0x0600116E RID: 4462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600116E")]
		[Address(RVA = "0x636B", Offset = "0x636B", VA = "0x636B")]
		public SeasonRewardsViewMediator(SeasonRewardsModel model, WorldAxisOfficeEvents events, WorldAxisOfficeController controller)
		{
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000292")]
		private PrizeListElement[] ListElements
		{
			[Token(Token = "0x600116F")]
			[Address(RVA = "0x636C", Offset = "0x636C", VA = "0x636C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001170")]
			[Address(RVA = "0x636D", Offset = "0x636D", VA = "0x636D")]
			set
			{
			}
		}

		// Token: 0x17000293 RID: 659
		// (set) Token: 0x06001171 RID: 4465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000293")]
		public override SeasonRewardsView View
		{
			[Token(Token = "0x6001171")]
			[Address(RVA = "0x636E", Offset = "0x636E", VA = "0x636E", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001172")]
		[Address(RVA = "0x636F", Offset = "0x636F", VA = "0x636F")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator__Init
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58b5b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SeasonRewardsModel__WorldAxisOfficeEvents__WorldAxisOfficeController__SeasonRewardsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_SeasonRewardsView_Tab__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17796);
		    DAT_ram_00a58b5b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x2c),0);
		  iVar4 = *(int *)(iVar1 + 0x14);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar4 == 1) {
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (iVar1,1,Method_UI_MonoBehaviourWithStates_SeasonRewardsView_Tab__set_CurrentState__);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar1 + 0x28);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = UI_Elements_Filters_GenericFilter_GenericFilterView__GetElementByIndex
		                      (*(undefined4 *)(iVar1 + 0x28),0);
		    iVar1 = UI_Elements_Filters_GenericFilter_GenericFilterView__SelectByIndexSilent(uVar3,uVar2,0);
		    Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator__TabBarChangedEventHandler
		              (param1,*(undefined4 *)(iVar1 + 0x24),param1);
		    return;
		  }
		  iVar1 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x2c),0);
		  if (*(int *)(iVar1 + 0x14) == 2) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (uVar2,2,Method_UI_MonoBehaviourWithStates_SeasonRewardsView_Tab__set_CurrentState__);
		    uVar2 = *(undefined4 *)(param1[2] + 0x14);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17796,1,0,1,0,0,0,0);
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = Gameplay_WorldAxis_Office_View_Rewards_SeasonRewardsView__get_TabBar
		                      (param1_00,uVar2,uVar3,0);
		    Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator__get_ListElements
		              (param1,uVar2,param1);
		    Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator__PrizeListElementClickedEventHandler
		              (param1,*(undefined4 *)(param1[7] + 0x10),param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001173 RID: 4467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001173")]
		[Address(RVA = "0x6370", Offset = "0x6370", VA = "0x6370")]
		private void TabBarChangedEventHandler()
		{
		/* --- GHIDRA: TabBarChangedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator__TabBarChangedEventHandler
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a58b5c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SeasonRewardsModel__WorldAxisOfficeEvents__WorldAxisOfficeController__SeasonRewardsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_RatingPrizeDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_RatingPrizeDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_RatingPrizeDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator___c__DisplayClass10_0__PeriodFilterSelectedEventHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator___c__DisplayClass10_0_TypeInfo
		              );
		    DAT_ram_00a58b5c = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator___c__DisplayClass10_0_TypeInfo
		                    );
		  if (param2 != (int *)0x0) {
		    if (*(int *)(*param2 + 0x20) == *(int *)(DAT_ram_00a66958 + 0x20)) {
		      puVar2 = (undefined4 *)func_ii_15774(param2);
		      *(undefined4 *)(iVar1 + 8) = *puVar2;
		      uVar4 = *(undefined4 *)(param1[2] + 0x10);
		      uVar3 = unnamed_function_1417(System_Func_RatingPrizeDic__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (uVar3,iVar1,
		                 Method_Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator___c__DisplayClass10_0__PeriodFilterSelectedEventHandler_b__0__
		                 ,0);
		      uVar3 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                        (uVar4,uVar3,Method_System_Linq_Enumerable_Where_RatingPrizeDic___);
		      uVar3 = func_ii_6295(uVar3,Method_System_Linq_Enumerable_ToArray_RatingPrizeDic___);
		      iVar5 = *(int *)(param1[2] + 0x18);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar1 = UI_Elements_Filters_GenericFilter_GenericFilterView__GetElementByIndex
		                        (*(undefined4 *)(iVar1 + 0x28),0);
		      param3_00 = *(undefined4 *)(*(int *)(iVar5 + iVar1 * 4 + 0x10) + 8);
		      uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar3 = Gameplay_WorldAxis_Office_View_Rewards_SeasonRewardsView__get_TabBar
		                        (uVar4,uVar3,param3_00,0);
		      Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator__get_ListElements
		                (param1,uVar3,param1);
		      Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator__PrizeListElementClickedEventHandler
		                (param1,*(undefined4 *)(param1[7] + 0x10),param1);
		      return;
		    }
		    System_Activator__CreateInstance(param2,DAT_ram_00a66958);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001174 RID: 4468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001174")]
		[Address(RVA = "0x6371", Offset = "0x6371", VA = "0x6371")]
		private void PeriodFilterSelectedEventHandler(object obj)
		{
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001175")]
		[Address(RVA = "0x6372", Offset = "0x6372", VA = "0x6372")]
		private void RenderElements(IList<RatingPrizeDic> prizes, string period)
		{
		/* --- GHIDRA: RenderElements ---
		void Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator__RenderElements
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = Gameplay_WorldAxis_Office_View_Rewards_SeasonRewardsView__get_TabBar
		                    (uVar1,param2,param3,0);
		  Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator__get_ListElements
		            (param1,uVar1,param1);
		  Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator__PrizeListElementClickedEventHandler
		            (param1,*(undefined4 *)(param1[7] + 0x10),param1);
		  return;
		}
		*/

		}

		// Token: 0x06001176 RID: 4470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001176")]
		[Address(RVA = "0x6373", Offset = "0x6373", VA = "0x6373")]
		private void RenderClanElements(IList<RatingPrizeDic> prizes, string period)
		{
		/* --- GHIDRA: RenderClanElements ---
		void Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator__RenderClanElements
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement__set_Prize
		            (*(undefined4 *)(param1 + 0x18),0,0);
		  Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator__PrizeListElementClickedEventHandler
		            (param1,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001177 RID: 4471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001177")]
		[Address(RVA = "0x6374", Offset = "0x6374", VA = "0x6374")]
		private void PrizeListElementClickedEventHandler(PrizeListElement element)
		{
		/* --- GHIDRA: PrizeListElementClickedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator__PrizeListElementClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58b5d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a58b5d = '\x01';
		  }
		  Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement__set_Prize(param2,1,0);
		  param1[6] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x24);
		  uVar3 = *(undefined4 *)(*(int *)(param2 + 0x28) + 0x1c);
		  if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar3,0);
		  piVar2 = (int *)func_ii_7307(param1_00,uVar3,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xf0) * 4))(piVar2,*(undefined4 *)(*piVar2 + 0xf4));
		  return;
		}
		*/

		}

		// Token: 0x06001178 RID: 4472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001178")]
		[Address(RVA = "0x6375", Offset = "0x6375", VA = "0x6375")]
		private void SelectElement(PrizeListElement element)
		{
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001179")]
		[Address(RVA = "0x6376", Offset = "0x6376", VA = "0x6376", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x040008FD RID: 2301
		[Token(Token = "0x40008FD")]
		[FieldOffset(Offset = "0x18")]
		private PrizeListElement _selectedElement;

		// Token: 0x040008FE RID: 2302
		[Token(Token = "0x40008FE")]
		[FieldOffset(Offset = "0x1C")]
		private PrizeListElement[] _listElements;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ListElements ---
		void Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator__get_ListElements
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a58b58 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PrizeListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator_PrizeListElementClickedEventHandler__
		              );
		    DAT_ram_00a58b58 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x1c);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      uVar4 = *(undefined4 *)(iVar3 + iVar1 * 4 + 0x10);
		      uVar2 = unnamed_function_1417(System_Action_PrizeListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar2,param1,
		                 Method_Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator_PrizeListElementClickedEventHandler__
		                 ,0);
		      Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement__add_ElementClickedEvent
		                (uVar4,uVar2,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  *(int *)(param1 + 0x1c) = param2;
		  if (0 < *(int *)(param2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      uVar4 = *(undefined4 *)(param2 + iVar1 * 4 + 0x10);
		      uVar2 = unnamed_function_1417(System_Action_PrizeListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar2,param1,
		                 Method_Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator_PrizeListElementClickedEventHandler__
		                 ,0);
		      Gameplay_VortexRating_View_GreatPrizesTab_GreatPrizesView___ctor(uVar4,uVar2,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(param2 + 0xc));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_ListElements ---
		void Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator__set_ListElements
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58b59 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SeasonRewardsModel__WorldAxisOfficeEvents__WorldAxisOfficeController__SeasonRewardsView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator_PeriodFilterSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator_TabBarChangedEventHandler__
		              );
		    DAT_ram_00a58b59 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x28);
		    uVar1 = unnamed_function_1417(System_Action_object__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator_PeriodFilterSelectedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_GenericFilterView__add_SelectedEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x2c);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator_TabBarChangedEventHandler__
		               ,0);
		    UI_Tabs_TabBar__add_ChangeEvent(uVar3,uVar1,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x28);
		    uVar1 = unnamed_function_1417(System_Action_object__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator_PeriodFilterSelectedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData___ctor
		              (uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x2c);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator_TabBarChangedEventHandler__
		               ,0);
		    UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar1,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator__set_View(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_WorldAxis_Office_Controller_SeasonRewardsViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int *param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a58b5a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SeasonRewardsModel__WorldAxisOfficeEvents__WorldAxisOfficeController__SeasonRewardsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17795);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17797);
		    DAT_ram_00a58b5a = '\x01';
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(UI_Tabs_TabBarItemData___TypeInfo,2);
		  iVar1 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x14) = 1;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17797,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  iVar3 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20));
		  if (iVar3 != 0) {
		    param2_00[4] = iVar1;
		    iVar1 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		    *(undefined4 *)(iVar1 + 0x14) = 2;
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17795,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar1 + 0x10) = uVar2;
		    iVar3 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20));
		    if (iVar3 != 0) {
		      param2_00[5] = iVar1;
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      UI_Tabs_TabBar__HandleSelected(*(undefined4 *)(iVar1 + 0x2c),param2_00,0);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar3 = **(int **)(iVar1 + 0x28);
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe0) * 4))
		                (*(int **)(iVar1 + 0x28),*(undefined4 *)(param1[2] + 0x18),
		                 *(undefined4 *)(iVar3 + 0xe4));
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		                (*(undefined4 *)(iVar1 + 0x2c),0,0,0);
		      return;
		    }
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = func_ii_1083();
		  func_ii_1050(uVar2,0);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
