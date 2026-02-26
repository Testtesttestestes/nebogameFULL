using System;
using Gameplay.VortexRating.Events;
using Gameplay.VortexRating.Model;
using Gameplay.VortexRating.View.VoteRewardsTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.VortexRating.Controller
{
	// Token: 0x020003A2 RID: 930
	[Token(Token = "0x20003A2")]
	public class VoteRewardsViewMediator : AbstractViewMediator<VortexRatingModel, VortexRatingEvents, VortexRatingController, VoteRewardsView>, IHideableMediator
	{
		// Token: 0x060015AF RID: 5551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015AF")]
		[Address(RVA = "0x6771", Offset = "0x6771", VA = "0x6771")]
		public VoteRewardsViewMediator(VortexRatingModel model, VortexRatingEvents events, VortexRatingController controller)
		{
		/* --- GHIDRA: <Init>b__11_0 ---
		uint Gameplay_VortexRating_Controller_VoteRewardsViewMediator___Init_b__11_0
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  
		  if (DAT_ram_00a58206 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__get_User__
		              );
		    DAT_ram_00a58206 = '\x01';
		  }
		  uVar1 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(param1 + 0xc),0);
		  if ((longlong)(ulonglong)uVar1 < (longlong)*(int *)(*(int *)(param1 + 0x28) + 0x10)) {
		    uVar1 = 0;
		  }
		  else {
		    uVar1 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(param1 + 0xc),0);
		    uVar1 = (uint)((longlong)(ulonglong)uVar1 <= (longlong)*(int *)(*(int *)(param1 + 0x28) + 0x14))
		    ;
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060015B1 RID: 5553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000393")]
		public GiftListElement[] ListElements
		{
			[Token(Token = "0x60015B0")]
			[Address(RVA = "0x6772", Offset = "0x6772", VA = "0x6772")]
			get
			{
				return null;
			}
			[Token(Token = "0x60015B1")]
			[Address(RVA = "0x6773", Offset = "0x6773", VA = "0x6773")]
			set
			{
			}
		}

		// Token: 0x17000394 RID: 916
		// (set) Token: 0x060015B2 RID: 5554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000394")]
		public override VoteRewardsView View
		{
			[Token(Token = "0x60015B2")]
			[Address(RVA = "0x6774", Offset = "0x6774", VA = "0x6774", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000395 RID: 917
		// (set) Token: 0x060015B3 RID: 5555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000395")]
		public override VortexRatingEvents Events
		{
			[Token(Token = "0x60015B3")]
			[Address(RVA = "0x6775", Offset = "0x6775", VA = "0x6775", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B4")]
		[Address(RVA = "0x6776", Offset = "0x6776", VA = "0x6776")]
		private void GreatTopRequestedEventHandler()
		{
		/* --- GHIDRA: GreatTopRequestedEventHandler ---
		void Gameplay_VortexRating_Controller_VoteRewardsViewMediator__GreatTopRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int param1_00;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a58204 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VoteRewardsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_GiftListElement___);
		    Mono_Security_ASN1__get_Item(&System_Func_GiftListElement__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_VortexRating_Controller_VoteRewardsViewMediator__Init_b__11_0__);
		    DAT_ram_00a58204 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = param1[2];
		  uVar1 = Gameplay_VortexRating_View_VoteRewardsTab_VoteRewardsView__get_SetGiftButton
		                    (uVar1,*(undefined4 *)(iVar5 + 0x10),
		                     *(undefined4 *)(*(int *)(iVar5 + 0xc) + 0x1dc),*(undefined4 *)(iVar5 + 8),0);
		  Gameplay_VortexRating_Controller_VoteRewardsViewMediator__get_ListElements(param1,uVar1,0);
		  iVar5 = param1[6];
		  uVar1 = unnamed_function_1417(System_Func_GiftListElement__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param1,
		             Method_Gameplay_VortexRating_Controller_VoteRewardsViewMediator__Init_b__11_0__,0);
		  iVar5 = func_ii_7423(iVar5,uVar1,Method_System_Linq_Enumerable_First_GiftListElement___);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar5 + 0x30),1,0);
		  param1[7] = iVar5;
		  iVar2 = param1[6];
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar5 = *(int *)(iVar5 + 0x38);
		    do {
		      param1_00 = *(int *)(iVar2 + iVar4 * 4 + 0x10);
		      iVar3 = *(int *)(param1_00 + 0x38);
		      if (DAT_ram_00a581ab == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_UI_MonoBehaviourWithStates_GiftListElement_State__set_CurrentState__);
		        DAT_ram_00a581ab = '\x01';
		      }
		      uVar1 = 2;
		      if (iVar5 != iVar3) {
		        uVar1 = 1;
		      }
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (param1_00,uVar1,
		                 Method_UI_MonoBehaviourWithStates_GiftListElement_State__set_CurrentState__);
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(iVar2 + 0xc));
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  return;
		}
		*/

		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B5")]
		[Address(RVA = "0x6777", Offset = "0x6777", VA = "0x6777")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_VortexRating_Controller_VoteRewardsViewMediator__Init
		               (int param1,int param2,undefined4 param3)
		
		{
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(*(int *)(param1 + 0x1c) + 0x30),0,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param2 + 0x30),1,0);
		  *(int *)(param1 + 0x1c) = param2;
		  return;
		}
		*/

		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B6")]
		[Address(RVA = "0x6778", Offset = "0x6778", VA = "0x6778")]
		private void GiftListElementClickedEventHandler(GiftListElement element)
		{
		/* --- GHIDRA: GiftListElementClickedEventHandler ---
		void Gameplay_VortexRating_Controller_VoteRewardsViewMediator__GiftListElementClickedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param2 + 0x30),1,0);
		  *(int *)(param1 + 0x1c) = param2;
		  return;
		}
		*/

		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B7")]
		[Address(RVA = "0x6779", Offset = "0x6779", VA = "0x6779")]
		private void SelectElement(GiftListElement element)
		{
		/* --- GHIDRA: SelectElement ---
		void Gameplay_VortexRating_Controller_VoteRewardsViewMediator__SelectElement
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_VortexRating_Controller_VortexRatingController__GetGreatTopResultHandler
		            (param1_00,*(undefined4 *)(param1[7] + 0x38),param1);
		  return;
		}
		*/

		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B8")]
		[Address(RVA = "0x677A", Offset = "0x677A", VA = "0x677A")]
		private void SetGiftButtonClickedEventHandler()
		{
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B9")]
		[Address(RVA = "0x677B", Offset = "0x677B", VA = "0x677B")]
		private void GreatSetAssignedEventHandler(uint greatSetId)
		{
		/* --- GHIDRA: GreatSetAssignedEventHandler ---
		void Gameplay_VortexRating_Controller_VoteRewardsViewMediator__GreatSetAssignedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int param1_00;
		  int iVar3;
		  undefined4 param2_00;
		  
		  iVar2 = *(int *)(param1 + 0x18);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      param1_00 = *(int *)(iVar2 + iVar1 * 4 + 0x10);
		      iVar3 = *(int *)(param1_00 + 0x38);
		      if (DAT_ram_00a581ab == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_UI_MonoBehaviourWithStates_GiftListElement_State__set_CurrentState__);
		        DAT_ram_00a581ab = '\x01';
		      }
		      param2_00 = 2;
		      if (param2 != iVar3) {
		        param2_00 = 1;
		      }
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (param1_00,param2_00,
		                 Method_UI_MonoBehaviourWithStates_GiftListElement_State__set_CurrentState__);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015BA")]
		[Address(RVA = "0x677C", Offset = "0x677C", VA = "0x677C")]
		private void AssignGreatSet(uint greatSetId)
		{
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015BB")]
		[Address(RVA = "0x677D", Offset = "0x677D", VA = "0x677D", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		uint Gameplay_VortexRating_Controller_VoteRewardsViewMediator__Hide
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58205 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VoteRewardsView__get_Model__
		              );
		    DAT_ram_00a58205 = '\x01';
		  }
		  return (uint)(*(int *)(param2 + 0x38) == *(int *)(*(int *)(*(int *)(param1 + 8) + 0x10) + 0x18));
		}
		*/

		}

		// Token: 0x04000B7A RID: 2938
		[Token(Token = "0x4000B7A")]
		[FieldOffset(Offset = "0x18")]
		private GiftListElement[] _listElements;

		// Token: 0x04000B7B RID: 2939
		[Token(Token = "0x4000B7B")]
		[FieldOffset(Offset = "0x1C")]
		private GiftListElement _selectedGift;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ListElements ---
		void Gameplay_VortexRating_Controller_VoteRewardsViewMediator__get_ListElements
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
		  if (DAT_ram_00a58201 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GiftListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_VoteRewardsViewMediator_GiftListElementClickedEventHandler__
		              );
		    DAT_ram_00a58201 = '\x01';
		  }
		  iVar7 = *(int *)(param1 + 0x18);
		  if (0 < *(int *)(iVar7 + 0xc)) {
		    do {
		      iVar8 = *(int *)(iVar7 + iVar4 * 4 + 0x10);
		      uVar5 = unnamed_function_1417(System_Action_GiftListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar5,param1,
		                 Method_Gameplay_VortexRating_Controller_VoteRewardsViewMediator_GiftListElementClickedEventHandler__
		                 ,0);
		      if (DAT_ram_00a581aa == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_GiftListElement__TypeInfo);
		        DAT_ram_00a581aa = '\x01';
		      }
		      iVar3 = *(int *)(iVar8 + 0x34);
		      do {
		        iVar6 = 0;
		        param1_00 = func_ii_7048(iVar3,uVar5,0);
		        uVar2 = System_Action_GiftListElement__TypeInfo;
		        if ((param1_00 != 0) &&
		           (iVar6 = func_ii_1082(param1_00,System_Action_GiftListElement__TypeInfo), iVar6 == 0)) {
		          System_Activator__CreateInstance(param1_00,uVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar6 = func_ii_4329(iVar8 + 0x34,iVar6,iVar3);
		        bVar1 = iVar6 != iVar3;
		        iVar3 = iVar6;
		      } while (bVar1);
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(iVar7 + 0xc));
		  }
		  *(int *)(param1 + 0x18) = param2;
		  if (0 < *(int *)(param2 + 0xc)) {
		    iVar4 = 0;
		    do {
		      iVar7 = *(int *)(param2 + iVar4 * 4 + 0x10);
		      uVar5 = unnamed_function_1417(System_Action_GiftListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar5,param1,
		                 Method_Gameplay_VortexRating_Controller_VoteRewardsViewMediator_GiftListElementClickedEventHandler__
		                 ,0);
		      if (DAT_ram_00a581a9 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_GiftListElement__TypeInfo);
		        DAT_ram_00a581a9 = '\x01';
		      }
		      iVar8 = *(int *)(iVar7 + 0x34);
		      do {
		        iVar3 = 0;
		        iVar6 = UnityEngine_UI_Image__set_sprite(iVar8,uVar5,0);
		        uVar2 = System_Action_GiftListElement__TypeInfo;
		        if ((iVar6 != 0) &&
		           (iVar3 = func_ii_1082(iVar6,System_Action_GiftListElement__TypeInfo), iVar3 == 0)) {
		          System_Activator__CreateInstance(iVar6,uVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar3 = func_ii_4329(iVar7 + 0x34,iVar3,iVar8);
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
		void Gameplay_VortexRating_Controller_VoteRewardsViewMediator__set_ListElements
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58202 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VoteRewardsView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_VoteRewardsViewMediator_SetGiftButtonClickedEventHandler__
		              );
		    DAT_ram_00a58202 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_VortexRating_Controller_VoteRewardsViewMediator_SetGiftButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_VortexRating_Controller_VoteRewardsViewMediator_SetGiftButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    Gameplay_VortexRating_Controller_VortexRatingController___ctor(uVar1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_VortexRating_Controller_VoteRewardsViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a58203 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VoteRewardsView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_VoteRewardsViewMediator_GreatSetAssignedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_VoteRewardsViewMediator_GreatTopRequestedEventHandler__
		              );
		    DAT_ram_00a58203 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_VortexRating_Controller_VoteRewardsViewMediator_GreatTopRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,
		                  Method_Gameplay_VortexRating_Controller_VoteRewardsViewMediator_GreatSetAssignedEventHandler__
		                  ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_uint__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x24) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x24) = iVar5;
		      uVar3 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_VortexRating_Controller_VoteRewardsViewMediator_GreatTopRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,
		                  Method_Gameplay_VortexRating_Controller_VoteRewardsViewMediator_GreatSetAssignedEventHandler__
		                  ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_uint__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x24) = 0;
		      return;
		    }
		    iVar5 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x24) = iVar5;
		    uVar3 = System_Action_uint__TypeInfo;
		    iVar1 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_VortexRating_Controller_VoteRewardsViewMediator__set_Events
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_VortexRating_Controller_VoteRewardsViewMediator__GreatTopRequestedEventHandler
		            (param1,param1);
		  return;
		}
		*/

}
