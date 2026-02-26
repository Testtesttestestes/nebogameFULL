using System;
using Gameplay.VortexRating.Events;
using Gameplay.VortexRating.Model;
using Gameplay.VortexRating.View.GreatPrizesTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.VortexRating.Controller
{
	// Token: 0x0200039B RID: 923
	[Token(Token = "0x200039B")]
	public class GreatPrizesViewMediator : AbstractViewMediator<VortexRatingModel, VortexRatingEvents, VortexRatingController, GreatPrizesView>, IHideableMediator
	{
		// Token: 0x06001578 RID: 5496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001578")]
		[Address(RVA = "0x673A", Offset = "0x673A", VA = "0x673A")]
		public GreatPrizesViewMediator(VortexRatingModel model, VortexRatingEvents events, VortexRatingController controller)
		{
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600157A RID: 5498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038E")]
		private PrizeListElement[] ListElements
		{
			[Token(Token = "0x6001579")]
			[Address(RVA = "0x673B", Offset = "0x673B", VA = "0x673B")]
			get
			{
				return null;
			}
			[Token(Token = "0x600157A")]
			[Address(RVA = "0x673C", Offset = "0x673C", VA = "0x673C")]
			set
			{
			}
		}

		// Token: 0x1700038F RID: 911
		// (set) Token: 0x0600157B RID: 5499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038F")]
		public override GreatPrizesView View
		{
			[Token(Token = "0x600157B")]
			[Address(RVA = "0x673D", Offset = "0x673D", VA = "0x673D", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157C")]
		[Address(RVA = "0x673E", Offset = "0x673E", VA = "0x673E")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_VortexRating_Controller_GreatPrizesViewMediator__Init
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  int param2_00;
		  int param2_01;
		  undefined4 uVar1;
		  undefined4 param3_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a581dc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__GreatPrizesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_RatingPrizeDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_RatingPrizeDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_RatingPrizeDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_RatingTypesDic_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_GreatPrizesViewMediator___c__DisplayClass9_0__FilterSelectedEventHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_VortexRating_Controller_GreatPrizesViewMediator___c__DisplayClass9_0_TypeInfo
		              );
		    DAT_ram_00a581dc = '\x01';
		  }
		  param2_01 = unnamed_function_1417
		                        (
		                        Gameplay_VortexRating_Controller_GreatPrizesViewMediator___c__DisplayClass9_0_TypeInfo
		                        );
		  param2_00 = Protocol_Dic_RatingTypesDic_TypeInfo;
		  if (param2 == (int *)0x0) {
		    *(undefined4 *)(param2_01 + 8) = 0;
		  }
		  else if ((Protocol_Dic_RatingTypesDic_TypeInfo != *param2) ||
		          (*(int **)(param2_01 + 8) = param2, *param2 != param2_00)) {
		    System_Activator__CreateInstance(param2,param2_00);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = *(undefined4 *)(param1[2] + 0x18);
		  uVar1 = unnamed_function_1417(System_Func_RatingPrizeDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_01,
		             Method_Gameplay_VortexRating_Controller_GreatPrizesViewMediator___c__DisplayClass9_0__FilterSelectedEventHandler_b__0__
		             ,0);
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar2,uVar1,Method_System_Linq_Enumerable_Where_RatingPrizeDic___);
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_RatingPrizeDic___);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param3_00 = Core_Extensions_Dict_DictExt__GetRatingTypeDic(*(undefined4 *)(param2_01 + 8),0);
		  uVar1 = Gameplay_VortexRating_View_GreatPrizesTab_GreatPrizesView__get_InVortexButton
		                    (uVar2,uVar1,param3_00,param1);
		  Gameplay_VortexRating_Controller_GreatPrizesViewMediator__get_ListElements(param1,uVar1,param1);
		  Gameplay_VortexRating_Controller_GreatPrizesViewMediator__PrizeListElementClickedEventHandler
		            (param1,*(undefined4 *)(param1[7] + 0x10),param1);
		  return;
		}
		*/

		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157D")]
		[Address(RVA = "0x673F", Offset = "0x673F", VA = "0x673F")]
		private void FilterSelectedEventHandler(object obj)
		{
		/* --- GHIDRA: FilterSelectedEventHandler ---
		void Gameplay_VortexRating_Controller_GreatPrizesViewMediator__FilterSelectedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(*(int *)(param1 + 0x18) + 0x10),0,0);
		  Gameplay_VortexRating_Controller_GreatPrizesViewMediator__PrizeListElementClickedEventHandler
		            (param1,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157E")]
		[Address(RVA = "0x6740", Offset = "0x6740", VA = "0x6740")]
		private void PrizeListElementClickedEventHandler(PrizeListElement element)
		{
		/* --- GHIDRA: PrizeListElementClickedEventHandler ---
		void Gameplay_VortexRating_Controller_GreatPrizesViewMediator__PrizeListElementClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a581dd == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a581dd = '\x01';
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param2 + 0x10),1,0);
		  param1[6] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x18);
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

		// Token: 0x0600157F RID: 5503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157F")]
		[Address(RVA = "0x6741", Offset = "0x6741", VA = "0x6741")]
		private void SelectElement(PrizeListElement element)
		{
		/* --- GHIDRA: SelectElement ---
		void Gameplay_VortexRating_Controller_GreatPrizesViewMediator__SelectElement
		               (int param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a581de == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__Stop__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__TryRun__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__GreatPrizesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_VortexCombat_TypeInfo);
		    DAT_ram_00a581de = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 8) + 8);
		  param2_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  param1_00 = (int *)unnamed_function_1417(Gameplay_VortexCombat_VortexCombat_TypeInfo);
		  Gameplay_VortexCombat_VortexCombat__CheckRunRestrictions
		            (param1_00,param2_00,uVar2,uVar2,0,param1_00);
		  uVar2 = Gameplay_VortexRating_Model_VortexRatingModel__GetTabBarItemData
		                    (*(undefined4 *)(param1 + 8),param1_00);
		  iVar1 = Gameplay_Combat_AbstractCombat_object__object__object__object__object___TryRun
		                    (param1_00,uVar2,
		                     Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__TryRun__
		                    );
		  if (iVar1 != 0) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		    UI_Windows_PopupController__Close(uVar2,2,0);
		    return;
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___SetView
		            (param1_00,
		             Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__Stop__
		            );
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x118) * 4))
		            (param1_00,*(undefined4 *)(*param1_00 + 0x11c));
		  return;
		}
		*/

		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001580")]
		[Address(RVA = "0x6742", Offset = "0x6742", VA = "0x6742")]
		private void InVortexButtonClickedEventHandler()
		{
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001581")]
		[Address(RVA = "0x6743", Offset = "0x6743", VA = "0x6743", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_VortexRating_Controller_GreatPrizesViewMediator__Hide(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a581df == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_VortexRating_Controller_GreatPrizesViewMediator___c_TypeInfo);
		    DAT_ram_00a581df = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_VortexRating_Controller_GreatPrizesViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_VortexRating_Controller_GreatPrizesViewMediator___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04000B6C RID: 2924
		[Token(Token = "0x4000B6C")]
		[FieldOffset(Offset = "0x18")]
		private PrizeListElement _selectedElement;

		// Token: 0x04000B6D RID: 2925
		[Token(Token = "0x4000B6D")]
		[FieldOffset(Offset = "0x1C")]
		private PrizeListElement[] _listElements;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ListElements ---
		void Gameplay_VortexRating_Controller_GreatPrizesViewMediator__get_ListElements
		               (int param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int param1_00;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a581d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PrizeListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_GreatPrizesViewMediator_PrizeListElementClickedEventHandler__
		              );
		    DAT_ram_00a581d9 = '\x01';
		  }
		  iVar7 = *(int *)(param1 + 0x1c);
		  if (0 < *(int *)(iVar7 + 0xc)) {
		    do {
		      iVar8 = *(int *)(iVar7 + iVar4 * 4 + 0x10);
		      uVar5 = unnamed_function_1417(System_Action_PrizeListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar5,param1,
		                 Method_Gameplay_VortexRating_Controller_GreatPrizesViewMediator_PrizeListElementClickedEventHandler__
		                 ,0);
		      if (DAT_ram_00a581bc == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_PrizeListElement__TypeInfo);
		        DAT_ram_00a581bc = '\x01';
		      }
		      iVar3 = *(int *)(iVar8 + 0x24);
		      do {
		        iVar6 = 0;
		        param1_00 = func_ii_7048(iVar3,uVar5,0);
		        uVar2 = System_Action_PrizeListElement__TypeInfo;
		        if ((param1_00 != 0) &&
		           (iVar6 = func_ii_1082(param1_00,System_Action_PrizeListElement__TypeInfo), iVar6 == 0)) {
		          System_Activator__CreateInstance(param1_00,uVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar6 = func_ii_4329(iVar8 + 0x24,iVar6,iVar3);
		        bVar1 = iVar6 != iVar3;
		        iVar3 = iVar6;
		      } while (bVar1);
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(iVar7 + 0xc));
		  }
		  *(int *)(param1 + 0x1c) = param2;
		  if (0 < *(int *)(param2 + 0xc)) {
		    iVar4 = 0;
		    do {
		      iVar7 = *(int *)(param2 + iVar4 * 4 + 0x10);
		      uVar5 = unnamed_function_1417(System_Action_PrizeListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar5,param1,
		                 Method_Gameplay_VortexRating_Controller_GreatPrizesViewMediator_PrizeListElementClickedEventHandler__
		                 ,0);
		      if (DAT_ram_00a581bb == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_PrizeListElement__TypeInfo);
		        DAT_ram_00a581bb = '\x01';
		      }
		      iVar8 = *(int *)(iVar7 + 0x24);
		      do {
		        iVar3 = 0;
		        iVar6 = UnityEngine_UI_Image__set_sprite(iVar8,uVar5,0);
		        uVar2 = System_Action_PrizeListElement__TypeInfo;
		        if ((iVar6 != 0) &&
		           (iVar3 = func_ii_1082(iVar6,System_Action_PrizeListElement__TypeInfo), iVar3 == 0)) {
		          System_Activator__CreateInstance(iVar6,uVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar3 = func_ii_4329(iVar7 + 0x24,iVar3,iVar8);
		        bVar1 = iVar3 != iVar8;
		        iVar8 = iVar3;
		      } while (bVar1);
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(param2 + 0xc));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_ListElements ---
		void Gameplay_VortexRating_Controller_GreatPrizesViewMediator__set_ListElements
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a581da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__GreatPrizesView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_GreatPrizesViewMediator_FilterSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_GreatPrizesViewMediator_InVortexButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a581da = '\x01';
		  }
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar4,0);
		  if (iVar5 != 0) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar5 = *(int *)(iVar5 + 0x1c);
		    uVar4 = unnamed_function_1417(System_Action_object__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_VortexRating_Controller_GreatPrizesViewMediator_FilterSelectedEventHandler__
		               ,0);
		    if (DAT_ram_00a581b7 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		      DAT_ram_00a581b7 = '\x01';
		    }
		    iVar2 = *(int *)(iVar5 + 0x18);
		    do {
		      iVar3 = 0;
		      iVar6 = func_ii_7048(iVar2,uVar4,0);
		      uVar7 = System_Action_object__TypeInfo;
		      if ((iVar6 != 0) && (iVar3 = func_ii_1082(iVar6,System_Action_object__TypeInfo), iVar3 == 0))
		      {
		        System_Activator__CreateInstance(iVar6,uVar7);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar5 + 0x18,iVar3,iVar2);
		      bVar1 = iVar3 != iVar2;
		      iVar2 = iVar3;
		    } while (bVar1);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(*(int *)(iVar5 + 0x20) + 0xb4);
		    uVar4 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar4,param1,
		               Method_Gameplay_VortexRating_Controller_GreatPrizesViewMediator_InVortexButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar7,uVar4,0);
		  }
		  param1[5] = param2;
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar4,0);
		  if (iVar5 != 0) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar5 = *(int *)(iVar5 + 0x1c);
		    uVar4 = unnamed_function_1417(System_Action_object__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_VortexRating_Controller_GreatPrizesViewMediator_FilterSelectedEventHandler__
		               ,0);
		    if (DAT_ram_00a581b6 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		      DAT_ram_00a581b6 = '\x01';
		    }
		    iVar2 = *(int *)(iVar5 + 0x18);
		    do {
		      iVar3 = 0;
		      iVar6 = UnityEngine_UI_Image__set_sprite(iVar2,uVar4,0);
		      uVar7 = System_Action_object__TypeInfo;
		      if ((iVar6 != 0) && (iVar3 = func_ii_1082(iVar6,System_Action_object__TypeInfo), iVar3 == 0))
		      {
		        System_Activator__CreateInstance(iVar6,uVar7);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar5 + 0x18,iVar3,iVar2);
		      bVar1 = iVar3 != iVar2;
		      iVar2 = iVar3;
		    } while (bVar1);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(*(int *)(iVar5 + 0x20) + 0xb4);
		    uVar4 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar4,param1,
		               Method_Gameplay_VortexRating_Controller_GreatPrizesViewMediator_InVortexButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar7,uVar4,0);
		    Gameplay_VortexRating_Controller_GreatPrizesViewMediator__set_View(param1,uVar7);
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar4,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,1,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_VortexRating_Controller_GreatPrizesViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *param2_00;
		  int param1_00;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 param2_01;
		  undefined4 *puVar6;
		  
		  if (DAT_ram_00a581db == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__GreatPrizesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Distinct_uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_RatingPrizeDic__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_RatingPrizeDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_VortexRating_View_GreatPrizesTab_GenericListFilter_ListFilterData___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_VortexRating_View_GreatPrizesTab_GenericListFilter_ListFilterData_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_VortexRating_Controller_GreatPrizesViewMediator___c__Init_b__8_0__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_VortexRating_Controller_GreatPrizesViewMediator___c_TypeInfo);
		    DAT_ram_00a581db = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x20) + 0xb8);
		  param2_01 = *(undefined4 *)(param1[2] + 8);
		  uVar3 = Gameplay_VortexRating_Model_VortexRatingModel__GetTabBarItemData(param1[2],uVar5);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar3 = Core_Money_Money__op_Explicit(uVar3,0);
		  UI_Price_Price__SetColor(uVar5,param2_01,uVar3,0);
		  uVar3 = *(undefined4 *)(param1[2] + 0x18);
		  if (*(int *)(Gameplay_VortexRating_Controller_GreatPrizesViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_VortexRating_Controller_GreatPrizesViewMediator___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)
		            (Gameplay_VortexRating_Controller_GreatPrizesViewMediator___c_TypeInfo + 0x5c);
		  iVar2 = puVar6[1];
		  if (iVar2 == 0) {
		    if (*(int *)(Gameplay_VortexRating_Controller_GreatPrizesViewMediator___c_TypeInfo + 0x74) == 0)
		    {
		      func_ii_306000(Gameplay_VortexRating_Controller_GreatPrizesViewMediator___c_TypeInfo);
		      puVar6 = *(undefined4 **)
		                (Gameplay_VortexRating_Controller_GreatPrizesViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar6;
		    iVar2 = unnamed_function_1417(System_Func_RatingPrizeDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar2,uVar5,
		               Method_Gameplay_VortexRating_Controller_GreatPrizesViewMediator___c__Init_b__8_0__,0)
		    ;
		    *(int *)(*(int *)(Gameplay_VortexRating_Controller_GreatPrizesViewMediator___c_TypeInfo + 0x5c)
		            + 4) = iVar2;
		  }
		  iVar1 = 0;
		  uVar3 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar3,iVar2,Method_System_Linq_Enumerable_Select_RatingPrizeDic__uint___);
		  uVar3 = System_Linq_Enumerable__DefaultIfEmptyIterator___Il2CppFullySharedGenericType_
		                    (uVar3,Method_System_Linq_Enumerable_Distinct_uint___);
		  iVar2 = System_Linq_Enumerable__OrderBy_uint__uint_
		                    (uVar3,Method_System_Linq_Enumerable_ToArray_uint___);
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid
		                               (Gameplay_VortexRating_View_GreatPrizesTab_GenericListFilter_ListFilterData___TypeInfo
		                                ,*(undefined4 *)(iVar2 + 0xc));
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      uVar3 = func_ii_7625(*(undefined4 *)(param1[2] + 0xc),
		                           *(undefined4 *)(iVar2 + iVar1 * 4 + 0x10),0);
		      param1_00 = unnamed_function_1417
		                            (
		                            Gameplay_VortexRating_View_GreatPrizesTab_GenericListFilter_ListFilterData_TypeInfo
		                            );
		      uVar5 = Core_Extensions_Dict_DictExt__GetRatingTypeDic(uVar3,0);
		      *(undefined4 *)(param1_00 + 0xc) = uVar3;
		      *(undefined4 *)(param1_00 + 8) = uVar5;
		      iVar4 = func_ii_1082(param1_00,*(undefined4 *)(*param2_00 + 0x20));
		      if (iVar4 == 0) {
		        uVar3 = func_ii_1083();
		        func_ii_1050(uVar3,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      param2_00[iVar1 + 4] = param1_00;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  iVar1 = *param1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar1 + 0x15c));
		  Gameplay_VortexRating_View_GreatPrizesTab_GenericListFilter__remove_SelectedEvent
		            (*(undefined4 *)(iVar2 + 0x1c),param2_00,iVar1);
		  return;
		}
		*/

}
