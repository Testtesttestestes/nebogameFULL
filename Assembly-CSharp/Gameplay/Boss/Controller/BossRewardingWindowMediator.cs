using System;
using System.Collections.Generic;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.Rewarding;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BB0 RID: 2992
	[Token(Token = "0x2000BB0")]
	public class BossRewardingWindowMediator : AbstractViewMediator<BossInstanceModel, BossInstanceEvents, BossInstanceController, BossRewardingWindow>
	{
		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x0600495C RID: 18780 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
		[Token(Token = "0x17000EDA")]
		private ulong CurrentTeamId
		{
			[Token(Token = "0x600495C")]
			[Address(RVA = "0x97CE", Offset = "0x97CE", VA = "0x97CE")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x0600495D RID: 18781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600495D")]
		[Address(RVA = "0x97CF", Offset = "0x97CF", VA = "0x97CF")]
		public BossRewardingWindowMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		/* --- GHIDRA: <ApplyButtonClickHandler>b__17_0 ---
		void Gameplay_Boss_Controller_BossRewardingWindowMediator___ApplyButtonClickHandler_b__17_0
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57922 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossRewardingWindowMediator___c_TypeInfo)
		    ;
		    DAT_ram_00a57922 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Boss_Controller_BossRewardingWindowMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Boss_Controller_BossRewardingWindowMediator___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_Controller_BossRewardingWindowMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57918 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossRewardingWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TeamAndRewardsData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_TeamAndRewardsDataReceivedEvent__
		              );
		    DAT_ram_00a57918 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x48);
		    uVar2 = unnamed_function_1417(System_Action_TeamAndRewardsData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_TeamAndRewardsDataReceivedEvent__
		               ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_TeamAndRewardsData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x48) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_TeamAndRewardsData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x48) = iVar4;
		      uVar2 = System_Action_TeamAndRewardsData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_TeamAndRewardsData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x48);
		    uVar2 = unnamed_function_1417(System_Action_TeamAndRewardsData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_TeamAndRewardsDataReceivedEvent__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_TeamAndRewardsData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x48) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_TeamAndRewardsData__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x48) = iVar4;
		    uVar2 = System_Action_TeamAndRewardsData__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_TeamAndRewardsData__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000EDB RID: 3803
		// (set) Token: 0x0600495E RID: 18782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EDB")]
		public override BossInstanceEvents Events
		{
			[Token(Token = "0x600495E")]
			[Address(RVA = "0x97D0", Offset = "0x97D0", VA = "0x97D0", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600495F RID: 18783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600495F")]
		[Address(RVA = "0x97D1", Offset = "0x97D1", VA = "0x97D1")]
		private void TeamAndRewardsDataReceivedEvent(TeamAndRewardsData data)
		{
		/* --- GHIDRA: TeamAndRewardsDataReceivedEvent ---
		void Gameplay_Boss_Controller_BossRewardingWindowMediator__TeamAndRewardsDataReceivedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  longlong lVar3;
		  int *piVar4;
		  undefined4 *puVar5;
		  undefined4 uVar6;
		  longlong lVar7;
		  uint uVar8;
		  
		  if (DAT_ram_00a57919 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossRewardingWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3659);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3664);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3663);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3662);
		    DAT_ram_00a57919 = '\x01';
		  }
		  lVar7 = *(longlong *)(*(int *)(*(int *)(param2 + 0xc) + 0x34) + 0x20);
		  if (DAT_ram_00a57916 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__get_Item__);
		    DAT_ram_00a57916 = '\x01';
		  }
		  lVar3 = System_Collections_Generic_List_ulong___get_Count
		                    (param1[8],param1[7],Method_System_Collections_Generic_List_ulong__get_Item__);
		  if (lVar3 == lVar7) {
		    param1[6] = param2;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__get_TeamData
		              (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x10),*(undefined4 *)(param1[6] + 0xc),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_Rewarding_BossRewardingCaptainView__get_TeamData
		              (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x14),*(undefined4 *)(param1[6] + 0xc),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_Rewarding_BossRewardingCaptainView__set_TeamData
		              (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x14),*(undefined4 *)(param1[6] + 0x10),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar4 = *(int **)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x14) + 0x14);
		    puVar5 = &StringLiteral_3664;
		    if (*(int *)(param1[6] + 8) != 1) {
		      puVar5 = &StringLiteral_3659;
		    }
		    uVar6 = *puVar5;
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar6,1,0,1,0,0,0,0);
		    iVar1 = *piVar4;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		              (piVar4,uVar6,*(undefined4 *)(iVar1 + 0x2d4));
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__OnDestroy
		              (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x10),*(undefined4 *)(param1[6] + 0x14),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (*(char *)(*(int *)(param1[6] + 0xc) + 0x30) == '\0') {
		      uVar8 = 0;
		    }
		    else {
		      uVar8 = (uint)(*(int *)(param1[6] + 8) == 1);
		    }
		    Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__get_Editable
		              (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x10),uVar8,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x1c),0);
		    if (*(char *)(*(int *)(param1[6] + 0xc) + 0x30) == '\0') {
		      uVar8 = 0;
		    }
		    else {
		      uVar8 = (uint)(*(int *)(param1[6] + 8) == 1);
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar6,uVar8,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x18),0);
		    if (*(char *)(*(int *)(param1[6] + 0xc) + 0x30) == '\0') {
		      uVar8 = 0;
		    }
		    else {
		      uVar8 = (uint)(*(int *)(param1[6] + 8) == 1);
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar6,uVar8,0);
		    if ((*(char *)(*(int *)(param1[6] + 0xc) + 0x30) == '\0') ||
		       (uVar6 = 1, *(int *)(param1[6] + 8) != 1)) {
		      uVar6 = 0;
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x10) + 0x18),0,0);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x10) + 0x1c),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,1,0);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      piVar4 = *(int **)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x10) + 0x1c);
		      puVar5 = &StringLiteral_3663;
		      if (*(int *)(param1[6] + 8) != 1) {
		        puVar5 = &StringLiteral_3662;
		      }
		      uVar2 = *puVar5;
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar2,1,0,1,0,0,0,0);
		      iVar1 = *piVar4;
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		                (piVar4,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		    }
		    else {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x10) + 0x18),1,0);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      UI_Elements_RightPanel_TitleWithLevel__set_Level
		                (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x10) + 0x28),
		                 *(undefined4 *)(param1[2] + 0x34),0);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x10) + 0x1c),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,0,0);
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x2c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,uVar6,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x20),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar6,0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004960 RID: 18784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004960")]
		[Address(RVA = "0x97D2", Offset = "0x97D2", VA = "0x97D2")]
		private void RenderTeamAndRewards(TeamAndRewardsData data)
		{
		/* --- GHIDRA: RenderTeamAndRewards ---
		void Gameplay_Boss_Controller_BossRewardingWindowMediator__RenderTeamAndRewards
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x17000EDC RID: 3804
		// (set) Token: 0x06004961 RID: 18785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EDC")]
		public bool HasChanges
		{
			[Token(Token = "0x6004961")]
			[Address(RVA = "0x97D3", Offset = "0x97D3", VA = "0x97D3")]
			set
			{
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (set) Token: 0x06004962 RID: 18786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EDD")]
		public override BossRewardingWindow View
		{
			[Token(Token = "0x6004962")]
			[Address(RVA = "0x97D4", Offset = "0x97D4", VA = "0x97D4", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004963")]
		[Address(RVA = "0x97D5", Offset = "0x97D5", VA = "0x97D5")]
		private void NextButtonClickHandler()
		{
		/* --- GHIDRA: NextButtonClickHandler ---
		void Gameplay_Boss_Controller_BossRewardingWindowMediator__NextButtonClickHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5791c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__get_Count__);
		    DAT_ram_00a5791c = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x1c) + -1;
		  *(int *)(param1 + 0x1c) = iVar1;
		  if (iVar1 < 0) {
		    *(int *)(param1 + 0x1c) = *(int *)(*(int *)(param1 + 0x20) + 0xc) + -1;
		  }
		  Gameplay_Boss_Controller_BossRewardingWindowMediator__RewardingViewOnSelectedAssistantSlotChangedEvent
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004964 RID: 18788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004964")]
		[Address(RVA = "0x97D6", Offset = "0x97D6", VA = "0x97D6")]
		private void PrevButtonClickHandler()
		{
		/* --- GHIDRA: PrevButtonClickHandler ---
		void Gameplay_Boss_Controller_BossRewardingWindowMediator__PrevButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_Rewarding_BossRewardingCaptainView__set_TeamData
		            (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x14),*(undefined4 *)(param1[6] + 0x10),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__OnDestroy
		            (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x10),*(undefined4 *)(param1[6] + 0x14),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004965 RID: 18789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004965")]
		[Address(RVA = "0x97D7", Offset = "0x97D7", VA = "0x97D7")]
		private void ResetButtonClickHandler()
		{
		/* --- GHIDRA: ResetButtonClickHandler ---
		void Gameplay_Boss_Controller_BossRewardingWindowMediator__ResetButtonClickHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int param1_01;
		  int iVar2;
		  int iVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a5791d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator__ApplyButtonClickHandler_b__17_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_3660);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3658);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3661);
		    DAT_ram_00a5791d = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3661,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3660,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  param1_01 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_01,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar2,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3658,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar1 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossRewardingWindowMediator__ApplyButtonClickHandler_b__17_0__
		             ,0);
		  *(undefined4 *)(iVar3 + 8) = uVar1;
		  *(int *)(iVar2 + 0x14) = iVar3;
		  iVar3 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_01 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar2,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar1 = UI_Windows_DialogWindow__get_OK_LABEL(0);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  iVar3 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_01 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1_00 + 0x24) = param1_01;
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		            (param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004966 RID: 18790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004966")]
		[Address(RVA = "0x97D8", Offset = "0x97D8", VA = "0x97D8")]
		private void ApplyButtonClickHandler()
		{
		/* --- GHIDRA: ApplyButtonClickHandler ---
		/* WARNING: Removing unreachable block (ram,0x80dffe41) */
		
		void Gameplay_Boss_Controller_BossRewardingWindowMediator__ApplyButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  int param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int param2_00;
		  undefined4 uVar7;
		  undefined8 uVar8;
		  int *param2_01;
		  uint uVar9;
		  undefined4 *puVar10;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5791e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_GetTeamRewardsAns_Types_BossRewardInfo__DistributeRewardsCmd_Types_UserReward___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToList_DistributeRewardsCmd_Types_UserReward___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossRewardingCaptainSlotView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossRewardingCaptainSlotView__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossRewardingCaptainSlotView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_GetTeamRewardsAns_Types_BossRewardInfo__DistributeRewardsCmd_Types_UserReward__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_DistributeRewardsCmd_Types_UserReward__Add__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossRewardingCaptainSlotView__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_DistributeRewardsCmd_Types_UserReward___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_DistributeRewardsCmd_Types_UserReward__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator___c__ConfirmApplyRewards_b__18_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossRewardingWindowMediator___c_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_DistributeRewardsCmd_Types_UserReward_TypeInfo);
		    DAT_ram_00a5791e = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar1 = unnamed_function_1417
		                    (System_Collections_Generic_List_DistributeRewardsCmd_Types_UserReward__TypeInfo
		                    );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar1,
		             Method_System_Collections_Generic_List_DistributeRewardsCmd_Types_UserReward___ctor__);
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo__TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo___ctor__)
		  ;
		  uVar8 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar8);
		  uVar7 = (undefined4)((ulonglong)uVar8 >> 0x20);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x3c) + 0x14) + 0x28),
		             Method_System_Collections_Generic_List_BossRewardingCaptainSlotView__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = &local_10;
		  do {
		    while( true ) {
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                           Method_System_Collections_Generic_List_Enumerator_BossRewardingCaptainSlotView__MoveNext__
		                          );
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e0009a;
		        }
		        iVar2 = local_20;
		        if (iVar3 == 0) goto code_r0x80e000e3;
		        piVar5 = local_8._4_4_;
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii
		                          (*(undefined4 *)(*local_8._4_4_ + 0xe0),local_8._4_4_,
		                           *(undefined4 *)(*local_8._4_4_ + 0xe4));
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e0009a;
		        }
		      } while (iVar3 == 0);
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (*(undefined4 *)(*piVar5 + 0xe0),piVar5,*(undefined4 *)(*piVar5 + 0xe4));
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e0009a;
		      }
		      param2_01 = *(int **)(*(int *)(param1[6] + 0xc) + 0x18);
		      iVar2 = *param2_01;
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_iii
		                        (*(undefined4 *)(iVar2 + 0xe0),param2_01,*(undefined4 *)(iVar2 + 0xe4));
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e0009a;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar8 = unnamed_function_184054
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x356,uVar4,0);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e0009a;
		      }
		      *(undefined8 *)(iVar3 + 0x18) = uVar8;
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         Protocol_Boss_DistributeRewardsCmd_Types_UserReward_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e0009a;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iii
		                        (*(undefined4 *)(*piVar5 + 0xe0),piVar5,*(undefined4 *)(*piVar5 + 0xe4));
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e0009a;
		      }
		      *(undefined4 *)(iVar2 + 0x18) = *(undefined4 *)(iVar6 + 0xc);
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iii
		                        (*(undefined4 *)(*piVar5 + 0xe0),piVar5,*(undefined4 *)(*piVar5 + 0xe4));
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e0009a;
		      }
		      *(undefined8 *)(iVar2 + 0x10) = *(undefined8 *)(iVar6 + 0x18);
		      iVar3 = Method_System_Collections_Generic_List_DistributeRewardsCmd_Types_UserReward__Add__;
		      *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		      uVar9 = *(uint *)(iVar1 + 0xc);
		      if (uVar9 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		        *(uint *)(iVar1 + 0xc) = uVar9 + 1;
		        *(int *)(*(int *)(iVar1 + 8) + uVar9 * 4 + 0x10) = iVar2;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar1,iVar2,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e0009a;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_iii
		                        (*(undefined4 *)(*piVar5 + 0xe0),piVar5,*(undefined4 *)(*piVar5 + 0xe4));
		      iVar2 = Method_System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo__Add__;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e0007e;
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar9 = *(uint *)(param1_00 + 0xc);
		      if (*(uint *)(*(int *)(param1_00 + 8) + 0xc) <= uVar9) break;
		      *(uint *)(param1_00 + 0xc) = uVar9 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar9 * 4 + 0x10) = uVar4;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,param1_00,uVar4,
		               *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  } while (DAT_ram_009d3e38 != 1);
		code_r0x80e0007e:
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e0009a:
		  iVar2 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar2 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		code_r0x80e000e3:
		      DAT_ram_009d3e38 = 0;
		      iVar3 = 0;
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar5 = (int *)*param1;
		      uVar8 = CONCAT44(uVar7,piVar5[0x57]);
		      iVar2 = (**(code **)((ulonglong)(uint)piVar5[0x56] * 4))(param1,uVar8);
		      uVar7 = (undefined4)((ulonglong)uVar8 >> 0x20);
		      iVar2 = *(int *)(*(int *)(*(int *)(iVar2 + 0x3c) + 0x10) + 0x14);
		      if (0 < *(int *)(iVar2 + 0xc)) {
		        do {
		          piVar5 = *(int **)(iVar2 + iVar3 * 4 + 0x10);
		          uVar8 = CONCAT44((int)((ulonglong)uVar8 >> 0x20),*(undefined4 *)(*piVar5 + 0xe4));
		          iVar6 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xe0) * 4))(piVar5,uVar8);
		          if (iVar6 != 0) {
		            uVar8 = CONCAT44((int)((ulonglong)uVar8 >> 0x20),*(undefined4 *)(*piVar5 + 0xe4));
		            iVar6 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xe0) * 4))(piVar5,uVar8);
		            uVar7 = (undefined4)((ulonglong)uVar8 >> 0x20);
		            *(undefined8 *)(iVar6 + 0x18) = *(undefined8 *)(piVar5 + 0xc);
		            param2_00 = unnamed_function_1417
		                                  (Protocol_Boss_DistributeRewardsCmd_Types_UserReward_TypeInfo);
		            uVar8 = CONCAT44(uVar7,*(undefined4 *)(*piVar5 + 0xe4));
		            iVar6 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xe0) * 4))(piVar5,uVar8);
		            *(undefined4 *)(param2_00 + 0x18) = *(undefined4 *)(iVar6 + 0xc);
		            uVar8 = CONCAT44((int)((ulonglong)uVar8 >> 0x20),*(undefined4 *)(*piVar5 + 0xe4));
		            iVar6 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xe0) * 4))(piVar5,uVar8);
		            uVar7 = (undefined4)((ulonglong)uVar8 >> 0x20);
		            *(undefined8 *)(param2_00 + 0x10) = *(undefined8 *)(iVar6 + 0x18);
		            iVar6 = 
		            Method_System_Collections_Generic_List_DistributeRewardsCmd_Types_UserReward__Add__;
		            *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		            uVar9 = *(uint *)(iVar1 + 0xc);
		            if (uVar9 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		              *(uint *)(iVar1 + 0xc) = uVar9 + 1;
		              *(int *)(*(int *)(iVar1 + 8) + uVar9 * 4 + 0x10) = param2_00;
		            }
		            else {
		              System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                        (iVar1,param2_00,
		                         *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		            }
		            uVar8 = CONCAT44(uVar7,*(undefined4 *)(*piVar5 + 0xe4));
		            piVar5 = (int *)(**(code **)((ulonglong)*(uint *)(*piVar5 + 0xe0) * 4))(piVar5,uVar8);
		            iVar6 = 
		            Method_System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo__Add__;
		            *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		            uVar9 = *(uint *)(param1_00 + 0xc);
		            if (uVar9 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		              *(uint *)(param1_00 + 0xc) = uVar9 + 1;
		              *(int **)(*(int *)(param1_00 + 8) + uVar9 * 4 + 0x10) = piVar5;
		            }
		            else {
		              uVar8 = CONCAT44((int)((ulonglong)uVar8 >> 0x20),piVar5);
		              System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                        (param1_00,piVar5,
		                         *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		            }
		          }
		          uVar7 = (undefined4)((ulonglong)uVar8 >> 0x20);
		          iVar3 = iVar3 + 1;
		        } while (iVar3 < *(int *)(iVar2 + 0xc));
		      }
		      Gameplay_Boss_Model_TeamAndRewardsData__get_RawRewards(param1[6],param1_00,piVar5);
		      if (*(int *)(Gameplay_Boss_Controller_BossRewardingWindowMediator___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Boss_Controller_BossRewardingWindowMediator___c_TypeInfo);
		      }
		      puVar10 = *(undefined4 **)
		                 (Gameplay_Boss_Controller_BossRewardingWindowMediator___c_TypeInfo + 0x5c);
		      iVar1 = puVar10[1];
		      if (iVar1 == 0) {
		        if (*(int *)(Gameplay_Boss_Controller_BossRewardingWindowMediator___c_TypeInfo + 0x74) == 0)
		        {
		          func_ii_306000(Gameplay_Boss_Controller_BossRewardingWindowMediator___c_TypeInfo);
		          puVar10 = *(undefined4 **)
		                     (Gameplay_Boss_Controller_BossRewardingWindowMediator___c_TypeInfo + 0x5c);
		        }
		        uVar4 = *puVar10;
		        iVar1 = unnamed_function_1417
		                          (
		                          System_Func_GetTeamRewardsAns_Types_BossRewardInfo__DistributeRewardsCmd_Types_UserReward__TypeInfo
		                          );
		        System_Linq_Enumerable__Where_object_
		                  (iVar1,uVar4,
		                   Method_Gameplay_Boss_Controller_BossRewardingWindowMediator___c__ConfirmApplyRewards_b__18_0__
		                   ,0);
		        *(int *)(*(int *)(Gameplay_Boss_Controller_BossRewardingWindowMediator___c_TypeInfo + 0x5c)
		                + 4) = iVar1;
		      }
		      uVar4 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                        (param1_00,iVar1,
		                         Method_System_Linq_Enumerable_Select_GetTeamRewardsAns_Types_BossRewardInfo__DistributeRewardsCmd_Types_UserReward___
		                        );
		      uVar4 = System_Linq_Enumerable__Select_object__object_
		                        (uVar4,
		                         Method_System_Linq_Enumerable_ToList_DistributeRewardsCmd_Types_UserReward___
		                        );
		      uVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x14c)));
		      if (DAT_ram_00a57916 == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__get_Item__);
		        DAT_ram_00a57916 = '\x01';
		      }
		      uVar8 = System_Collections_Generic_List_ulong___get_Count
		                        (param1[8],param1[7],
		                         Method_System_Collections_Generic_List_ulong__get_Item__);
		      Gameplay_Boss_Controller_BossInstanceController__GetTeamInfoAndRewards
		                (uVar7,uVar8,uVar4,uVar4);
		      Gameplay_Boss_Controller_BossRewardingWindowMediator__TeamAndRewardsDataReceivedEvent
		                (param1,param1[6],uVar4);
		      return;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3b4,&local_20);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004967 RID: 18791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004967")]
		[Address(RVA = "0x97D9", Offset = "0x97D9", VA = "0x97D9")]
		private void ConfirmApplyRewards()
		{
		/* --- GHIDRA: ConfirmApplyRewards ---
		void Gameplay_Boss_Controller_BossRewardingWindowMediator__ConfirmApplyRewards
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar3 = *(int **)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x10) + 0x30);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))(piVar3,uVar2,*(undefined4 *)(iVar1 + 0xec));
		  (**(code **)((ulonglong)*(uint *)(*param2 + 0xe8) * 4))(param2,0,*(undefined4 *)(*param2 + 0xec));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  local_8 = 0;
		  local_18 = 0;
		  local_10 = 0;
		  local_20 = 0;
		  Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__SlotOnClickEvent
		            (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x10),&local_20,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_Rewarding_BossRewardingCaptainView__get_SelectionMode
		            (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x14),0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004968 RID: 18792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004968")]
		[Address(RVA = "0x97DA", Offset = "0x97DA", VA = "0x97DA")]
		private void RewardingViewOnCaptainRewardClickEvent(BossRewardingCaptainSlotView bossRewardingCaptainSlotView)
		{
		/* --- GHIDRA: RewardingViewOnCaptainRewardClickEvent ---
		void Gameplay_Boss_Controller_BossRewardingWindowMediator__RewardingViewOnCaptainRewardClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  local_8 = 0;
		  local_18 = 0;
		  local_10 = 0;
		  local_20 = 0;
		  Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__SlotOnClickEvent
		            (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x10),&local_20,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_Rewarding_BossRewardingCaptainView__get_SelectionMode
		            (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x14),0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004969 RID: 18793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004969")]
		[Address(RVA = "0x97DB", Offset = "0x97DB", VA = "0x97DB")]
		private void ResetSelectionMode()
		{
		/* --- GHIDRA: ResetSelectionMode ---
		void Gameplay_Boss_Controller_BossRewardingWindowMediator__ResetSelectionMode
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5791f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5791f = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x14);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  param2_00 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param2,0,0);
		  Gameplay_Boss_View_Rewarding_BossRewardingCaptainView__get_SelectionMode(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600496A RID: 18794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600496A")]
		[Address(RVA = "0x97DC", Offset = "0x97DC", VA = "0x97DC")]
		private void RewardingViewOnSelectedAssistantSlotChangedEvent(BossRewardingAssistantSlotView obj)
		{
		/* --- GHIDRA: RewardingViewOnSelectedAssistantSlotChangedEvent ---
		void Gameplay_Boss_Controller_BossRewardingWindowMediator__RewardingViewOnSelectedAssistantSlotChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param1_00;
		  undefined8 uVar4;
		  int *piVar5;
		  undefined8 local_28;
		  undefined8 local_20;
		  int local_14 [5];
		  
		  if (DAT_ram_00a57920 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__get_Count__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27779);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3665);
		    DAT_ram_00a57920 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar1,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  local_14[0] = param1[7] + 1;
		  uVar2 = func_ii_4443(local_14,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar1,StringLiteral_22118,uVar2,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  local_14[0] = *(int *)(param1[8] + 0xc);
		  uVar2 = func_ii_4443(local_14,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar1,StringLiteral_27779,uVar2,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar4 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar4);
		  uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  piVar5 = *(int **)(*(int *)(iVar3 + 0x3c) + 0x28);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param1_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3665,1,0,1,0,0,0,0);
		  uVar1 = Core_GameLocalization__GetTranslation(param1_00,uVar1,0);
		  iVar3 = *piVar5;
		  uVar4 = CONCAT44(uVar2,uVar1);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar5,uVar4,*(undefined4 *)(iVar3 + 0x2d4));
		  uVar4 = CONCAT44((int)((ulonglong)uVar4 >> 0x20),*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar4);
		  local_14[3] = 0;
		  local_14[4] = 0;
		  local_20 = 0;
		  local_14[1] = 0;
		  local_14[2] = 0;
		  local_28 = 0;
		  uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__SlotOnClickEvent
		            (*(undefined4 *)(*(int *)(iVar3 + 0x3c) + 0x10),&local_28,0);
		  uVar4 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar4);
		  uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  Gameplay_Boss_View_Rewarding_BossRewardingCaptainView__get_SelectionMode
		            (*(undefined4 *)(*(int *)(iVar3 + 0x3c) + 0x14),0,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x14c)));
		  if (DAT_ram_00a57916 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__get_Item__);
		    DAT_ram_00a57916 = '\x01';
		  }
		  uVar4 = System_Collections_Generic_List_ulong___get_Count
		                    (param1[8],param1[7],Method_System_Collections_Generic_List_ulong__get_Item__);
		  Gameplay_Boss_Controller_BossInstanceController__GetRating(uVar2,uVar4,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600496B RID: 18795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600496B")]
		[Address(RVA = "0x97DD", Offset = "0x97DD", VA = "0x97DD")]
		private void RenderCurrentTeam()
		{
		/* --- GHIDRA: RenderCurrentTeam ---
		void Gameplay_Boss_Controller_BossRewardingWindowMediator__RenderCurrentTeam
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  undefined8 param3;
		  undefined4 uVar5;
		  undefined4 param2_00;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  longlong local_20;
		  undefined8 local_18;
		  longlong local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57921 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_TeamData_TeamAssistantData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossRewardingCaptainSlotView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossRewardingCaptainSlotView__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_TeamData_TeamAssistantData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_TeamData_TeamAssistantData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossRewardingCaptainSlotView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_IListExt_GetRandom_GetTeamRewardsAns_Types_BossRewardInfo___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamData_TeamAssistantData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossRewardingCaptainSlotView__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo__Remove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo__TypeInfo);
		    DAT_ram_00a57921 = '\x01';
		  }
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  local_30 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  local_8 = 0;
		  local_38 = 0;
		  local_10 = 0;
		  local_40 = 0;
		  Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__SlotOnClickEvent
		            (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x10),&local_40,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_Rewarding_BossRewardingCaptainView__get_SelectionMode
		            (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x14),0,0);
		  uVar5 = *(undefined4 *)(param1[6] + 0x10);
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo__TypeInfo
		                    );
		  Sirenix_Utilities_LinqExtensions__Convert_object_
		            (uVar2,uVar5,
		             Method_System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo___ctor__)
		  ;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(*(int *)(param1[6] + 0xc) + 0x14),
		             Method_System_Collections_Generic_List_TeamData_TeamAssistantData__GetEnumerator__);
		  local_18 = local_8;
		  local_20 = local_10;
		  local_10 = ZEXT48(&local_20) << 0x20;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_20,
		                       Method_System_Collections_Generic_List_Enumerator_TeamData_TeamAssistantData__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e00a04;
		    }
		    if (iVar3 == 0) goto code_r0x80e00a5a;
		    DAT_ram_009d3e38 = 0;
		    piVar4 = local_18._4_4_;
		    iVar3 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e00a04;
		    }
		    iVar1 = *piVar4;
		    param2_00 = *(undefined4 *)(*(int *)(iVar3 + 0x3c) + 0x10);
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii
		                      (*(undefined4 *)(iVar1 + 0xe0),piVar4,*(undefined4 *)(iVar1 + 0xe4));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e00a04;
		    }
		    DAT_ram_009d3e38 = 0;
		    param3 = unnamed_function_184054
		                       (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x356,uVar5,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e00a04;
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar4 = (int *)unnamed_function_184070
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3b5,param2_00,
		                               param3,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e00a04;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3b6,uVar2,
		                       Method_Core_Extensions_IListExt_GetRandom_GetTeamRewardsAns_Types_BossRewardInfo___
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e00a04;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x389,uVar2,uVar5,
		               Method_System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo__Remove__
		              );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e00a04;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(*piVar4 + 0xe8),piVar4,uVar5,*(undefined4 *)(*piVar4 + 0xec));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e00a04:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_10 = CONCAT44(local_10._4_4_,iVar3);
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80e00a5a:
		      DAT_ram_009d3e38 = 0;
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_30,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x14) + 0x28),
		                 Method_System_Collections_Generic_List_BossRewardingCaptainSlotView__GetEnumerator__
		                );
		      local_10 = ZEXT48(&local_30) << 0x20;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_30,
		                           Method_System_Collections_Generic_List_Enumerator_BossRewardingCaptainSlotView__MoveNext__
		                          );
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e00b85;
		        }
		        if (iVar3 == 0) goto code_r0x80e00c29;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (*(undefined4 *)(*local_28._4_4_ + 0xe8),local_28._4_4_,0,
		                   *(undefined4 *)(*local_28._4_4_ + 0xec));
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar1 != 1);
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e00b85:
		      iVar1 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar3) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar3 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_10 = CONCAT44(local_10._4_4_,iVar3);
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar3 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x80e00c29:
		          DAT_ram_009d3e38 = 0;
		          iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		          uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x20),0);
		          Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                    (uVar2,1,0);
		          return;
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3b8,&local_10);
		      goto joined_r0x80e00c15;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3b7,&local_10);
		joined_r0x80e00c15:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600496C RID: 18796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600496C")]
		[Address(RVA = "0x97DE", Offset = "0x97DE", VA = "0x97DE")]
		private void RandomButtonClickHandler()
		{
		/* --- GHIDRA: RandomButtonClickHandler ---
		void Gameplay_Boss_Controller_BossRewardingWindowMediator__RandomButtonClickHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Boss_Controller_BossRewardingWindowMediator__ApplyButtonClickHandler(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x040027FB RID: 10235
		[Token(Token = "0x40027FB")]
		[FieldOffset(Offset = "0x18")]
		private TeamAndRewardsData _teamAndRewardsData;

		// Token: 0x040027FC RID: 10236
		[Token(Token = "0x40027FC")]
		[FieldOffset(Offset = "0x1C")]
		private int _currentTeamIndex;

		// Token: 0x040027FD RID: 10237
		[Token(Token = "0x40027FD")]
		[FieldOffset(Offset = "0x20")]
		private List<ulong> _teamIds;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CurrentTeamId ---
		void Gameplay_Boss_Controller_BossRewardingWindowMediator__get_CurrentTeamId
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a57917 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossRewardingWindow___ctor__
		              );
		    DAT_ram_00a57917 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossRewardingWindow___ctor__
		            );
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Boss_Controller_BossRewardingWindowMediator__set_Events
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Boss_Controller_BossRewardingWindowMediator__TeamAndRewardsDataReceivedEvent
		            (param1,param2,param2);
		  return;
		}
		*/


		/* --- GHIDRA: set_HasChanges ---
		void Gameplay_Boss_Controller_BossRewardingWindowMediator__set_HasChanges
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5791a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossRewardingWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_BossRewardingCaptainSlotView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BossRewardingAssistantSlotView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_BossRewardingWindow_BossRewardingWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_ApplyButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_NextButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_PrevButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_RandomButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_ResetButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_RewardingViewOnCaptainRewardClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_RewardingViewOnSelectedAssistantSlotChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__get_Count__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5791a = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x10);
		    uVar1 = unnamed_function_1417(System_Action_BossRewardingAssistantSlotView__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_RewardingViewOnSelectedAssistantSlotChangedEvent__
		               ,0);
		    Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__add_SelectedAssistantSlotChangedEvent
		              (uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x14);
		    uVar1 = unnamed_function_1417(System_Action_BossRewardingCaptainSlotView__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_RewardingViewOnCaptainRewardClickEvent__
		               ,0);
		    Gameplay_Boss_View_Rewarding_BossRewardingCaptainView__add_CaptainRewardClickEvent
		              (uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x3c) + 0x1c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_ApplyButtonClickHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x3c) + 0x20) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_ResetButtonClickHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x3c) + 0x18) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_RandomButtonClickHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x3c) + 0x30) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_PrevButtonClickHandler__,
		               0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x3c) + 0x34) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_NextButtonClickHandler__,
		               0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    param1[7] = 0;
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = func_ii_8093(uVar1,
		                         Method_UI_Windows_BaseWindow_BossRewardingWindow_BossRewardingWindowArgs__get_WindowArgs__
		                        );
		    param1[8] = *(int *)(iVar2 + 0x1c);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x10);
		    uVar1 = unnamed_function_1417(System_Action_BossRewardingAssistantSlotView__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_RewardingViewOnSelectedAssistantSlotChangedEvent__
		               ,0);
		    Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__get_StatusLabel(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x14);
		    uVar1 = unnamed_function_1417(System_Action_BossRewardingCaptainSlotView__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_RewardingViewOnCaptainRewardClickEvent__
		               ,0);
		    Gameplay_Boss_View_Rewarding_BossRewardingCaptainView__get_RewardsContainerTitle(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x3c) + 0x1c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_ApplyButtonClickHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x3c) + 0x20) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_ResetButtonClickHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x3c) + 0x18) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_RandomButtonClickHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x3c) + 0x30) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_PrevButtonClickHandler__,
		               0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x3c) + 0x34) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Boss_Controller_BossRewardingWindowMediator_NextButtonClickHandler__,
		               0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Linq_Enumerable__First_object_
		              (*(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x30),(uint)(1 < *(int *)(param1[8] + 0xc)),
		               0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Linq_Enumerable__First_object_
		              (*(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x34),(uint)(1 < *(int *)(param1[8] + 0xc)),
		               0);
		    Gameplay_Boss_Controller_BossRewardingWindowMediator__RewardingViewOnSelectedAssistantSlotChangedEvent
		              (param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Boss_Controller_BossRewardingWindowMediator__set_View(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5791b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__get_Count__);
		    DAT_ram_00a5791b = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x1c) + 1;
		  if (*(int *)(*(int *)(param1 + 0x20) + 0xc) + -1 < iVar1) {
		    iVar1 = 0;
		  }
		  *(int *)(param1 + 0x1c) = iVar1;
		  Gameplay_Boss_Controller_BossRewardingWindowMediator__RewardingViewOnSelectedAssistantSlotChangedEvent
		            (param1,param1);
		  return;
		}
		*/

}
