using System;
using System.Collections.Generic;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.TeamsTab;
using Il2CppDummyDll;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BB9 RID: 3001
	[Token(Token = "0x2000BB9")]
	public class BossTeamsViewMediator : AbstractBossWindowViewMediator<BossTeamsView>
	{
		// Token: 0x0600499F RID: 18847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600499F")]
		[Address(RVA = "0x9811", Offset = "0x9811", VA = "0x9811")]
		public BossTeamsViewMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_Controller_BossTeamsViewMediator___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a60876 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__List_TeamRewardData___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossTeamsViewMediator_CaptainTeamsReceivedEvent__);
		    DAT_ram_00a60876 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param2 + 0x40);
		  uVar1 = unnamed_function_1417(System_Action_ulong__List_TeamRewardData___TypeInfo);
		  System_Action_ulong__Int32Enum___Invoke
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossTeamsViewMediator_CaptainTeamsReceivedEvent__,0);
		  param1_00 = func_ii_7048(param1_01,uVar1,0);
		  uVar1 = System_Action_ulong__List_TeamRewardData___TypeInfo;
		  if (param1_00 == 0) {
		    *(undefined4 *)(param2 + 0x40) = 0;
		    return;
		  }
		  iVar2 = func_ii_1082(param1_00,System_Action_ulong__List_TeamRewardData___TypeInfo);
		  if (iVar2 == 0) {
		    System_Activator__CreateInstance(param1_00,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(param2 + 0x40) = iVar2;
		  uVar1 = System_Action_ulong__List_TeamRewardData___TypeInfo;
		  iVar2 = func_ii_1082(param1_00,System_Action_ulong__List_TeamRewardData___TypeInfo);
		  if (iVar2 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049A0")]
		[Address(RVA = "0x9812", Offset = "0x9812", VA = "0x9812", Slot = "21")]
		protected override void ResetEvents(BossInstanceEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Boss_Controller_BossTeamsViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a60877 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__List_TeamRewardData___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossTeamsViewMediator_CaptainTeamsReceivedEvent__);
		    DAT_ram_00a60877 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param2 + 0x40);
		  uVar1 = unnamed_function_1417(System_Action_ulong__List_TeamRewardData___TypeInfo);
		  System_Action_ulong__Int32Enum___Invoke
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossTeamsViewMediator_CaptainTeamsReceivedEvent__,0);
		  param1_00 = UnityEngine_UI_Image__set_sprite(param1_01,uVar1,0);
		  uVar1 = System_Action_ulong__List_TeamRewardData___TypeInfo;
		  if (param1_00 == 0) {
		    *(undefined4 *)(param2 + 0x40) = 0;
		    return;
		  }
		  iVar2 = func_ii_1082(param1_00,System_Action_ulong__List_TeamRewardData___TypeInfo);
		  if (iVar2 == 0) {
		    System_Activator__CreateInstance(param1_00,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(param2 + 0x40) = iVar2;
		  uVar1 = System_Action_ulong__List_TeamRewardData___TypeInfo;
		  iVar2 = func_ii_1082(param1_00,System_Action_ulong__List_TeamRewardData___TypeInfo);
		  if (iVar2 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060049A1 RID: 18849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049A1")]
		[Address(RVA = "0x9813", Offset = "0x9813", VA = "0x9813", Slot = "22")]
		protected override void SetupEvents(BossInstanceEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Boss_Controller_BossTeamsViewMediator__SetupEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a60878 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamRewardData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossTeamsViewMediator_ListAdapterOnClickEvent__);
		    DAT_ram_00a60878 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param2 + 0x24);
		  param1_00 = unnamed_function_1417(System_Action_TeamRewardData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_Controller_BossTeamsViewMediator_ListAdapterOnClickEvent__,0);
		  Gameplay_Boss_View_TeamsTab_BossTeamsListAdapter__add_ClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060049A2 RID: 18850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049A2")]
		[Address(RVA = "0x9814", Offset = "0x9814", VA = "0x9814", Slot = "23")]
		protected override void ResetView(BossTeamsView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Boss_Controller_BossTeamsViewMediator__ResetView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  undefined8 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60879 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossTeamsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TeamRewardData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossTeamsViewMediator_ListAdapterOnClickEvent__);
		    DAT_ram_00a60879 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param2 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_TeamRewardData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossTeamsViewMediator_ListAdapterOnClickEvent__,0);
		  Gameplay_Boss_View_TeamsTab_BossTeamsListAdapter__set_Data(param1_00,uVar1,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c)));
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(param1[2] + 8),0);
		  Gameplay_Boss_Controller_BossInstanceController__GetActiveTeamInfo(uVar1,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060049A3 RID: 18851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049A3")]
		[Address(RVA = "0x9815", Offset = "0x9815", VA = "0x9815", Slot = "24")]
		protected override void SetupView(BossTeamsView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Boss_Controller_BossTeamsViewMediator__SetupView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param4;
		  uint *puVar2;
		  undefined8 uVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a6087a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossTeamsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__IndexOf__);
		    DAT_ram_00a6087a = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x1c);
		  uVar3 = Gameplay_Announcements_View_AnnouncementsWindow_AnnouncementsWindowArgs___ctor(param2,0);
		  param4 = System_Collections_Generic_List_ulong___GetRange
		                     (uVar4,uVar3,Method_System_Collections_Generic_List_ulong__IndexOf__);
		  uVar4 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1e0);
		        goto code_r0x81cf0331;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x81cf0331:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,CONCAT44(uVar4,puVar2[1]));
		  uVar3 = Gameplay_Boss_Model_BossInstanceModel__set_MyInvites(*(undefined4 *)(param1 + 8),0);
		  Core_Gameplay_Managers_BossManager__ShowBossRewardingWindow
		            (uVar4,uVar3,*(undefined4 *)(param1 + 0x1c),param4,0);
		  return;
		}
		*/

		}

		// Token: 0x060049A4 RID: 18852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049A4")]
		[Address(RVA = "0x9816", Offset = "0x9816", VA = "0x9816")]
		private void ListAdapterOnClickEvent(TeamRewardData teamRewardData)
		{
		/* --- GHIDRA: ListAdapterOnClickEvent ---
		void Gameplay_Boss_Controller_BossTeamsViewMediator__ListAdapterOnClickEvent
		               (int *param1,undefined8 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a6087b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_TeamRewardData__ulong___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_TeamRewardData___);
		    Mono_Security_ASN1__get_Item(&System_Func_TeamRewardData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_TeamRewardData__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TeamRewardData__AddRange__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TeamRewardData__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamRewardData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_BossPossibleEmptyWindowStateController_WindowStates__set_CurrentState__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossTeamsViewMediator___c__CaptainTeamsReceivedEvent_b__8_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossTeamsViewMediator___c__CaptainTeamsReceivedEvent_b__8_1__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossTeamsViewMediator___c_TypeInfo);
		    DAT_ram_00a6087b = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = param1[6];
		    iVar3 = *(int *)(iVar2 + 0xc);
		    *(undefined4 *)(iVar2 + 0xc) = 0;
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    if (0 < iVar3) {
		      func_ii_2064(*(undefined4 *)(iVar2 + 8),0,iVar3,0);
		      iVar2 = param1[6];
		    }
		    iVar3 = param1[7];
		    *(undefined4 *)(iVar3 + 0xc) = 0;
		    *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		    func_ii_6335(iVar2,param3,Method_System_Collections_Generic_List_TeamRewardData__AddRange__);
		    iVar2 = param1[6];
		    iVar3 = param1[7];
		    if (*(int *)(Gameplay_Boss_Controller_BossTeamsViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Boss_Controller_BossTeamsViewMediator___c_TypeInfo);
		    }
		    puVar4 = *(undefined4 **)(Gameplay_Boss_Controller_BossTeamsViewMediator___c_TypeInfo + 0x5c);
		    param1_00 = puVar4[1];
		    if (param1_00 == 0) {
		      if (*(int *)(Gameplay_Boss_Controller_BossTeamsViewMediator___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Boss_Controller_BossTeamsViewMediator___c_TypeInfo);
		        puVar4 = *(undefined4 **)
		                  (Gameplay_Boss_Controller_BossTeamsViewMediator___c_TypeInfo + 0x5c);
		      }
		      uVar1 = *puVar4;
		      param1_00 = unnamed_function_1417(System_Func_TeamRewardData__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (param1_00,uVar1,
		                 Method_Gameplay_Boss_Controller_BossTeamsViewMediator___c__CaptainTeamsReceivedEvent_b__8_0__
		                 ,0);
		      *(int *)(*(int *)(Gameplay_Boss_Controller_BossTeamsViewMediator___c_TypeInfo + 0x5c) + 4) =
		           param1_00;
		    }
		    uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                      (iVar2,param1_00,Method_System_Linq_Enumerable_Where_TeamRewardData___);
		    if (*(int *)(Gameplay_Boss_Controller_BossTeamsViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Boss_Controller_BossTeamsViewMediator___c_TypeInfo);
		    }
		    puVar4 = *(undefined4 **)(Gameplay_Boss_Controller_BossTeamsViewMediator___c_TypeInfo + 0x5c);
		    iVar2 = puVar4[2];
		    if (iVar2 == 0) {
		      if (*(int *)(Gameplay_Boss_Controller_BossTeamsViewMediator___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Boss_Controller_BossTeamsViewMediator___c_TypeInfo);
		        puVar4 = *(undefined4 **)
		                  (Gameplay_Boss_Controller_BossTeamsViewMediator___c_TypeInfo + 0x5c);
		      }
		      param2_00 = *puVar4;
		      iVar2 = unnamed_function_1417(System_Func_TeamRewardData__ulong__TypeInfo);
		      func_ii_7542(iVar2,param2_00,
		                   Method_Gameplay_Boss_Controller_BossTeamsViewMediator___c__CaptainTeamsReceivedEvent_b__8_1__
		                   ,0);
		      *(int *)(*(int *)(Gameplay_Boss_Controller_BossTeamsViewMediator___c_TypeInfo + 0x5c) + 8) =
		           iVar2;
		    }
		    uVar1 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                      (uVar1,iVar2,Method_System_Linq_Enumerable_Select_TeamRewardData__ulong___);
		    System_Collections_Generic_List_ulong___AddEnumerable
		              (iVar3,uVar1,Method_System_Collections_Generic_List_ulong__AddRange__);
		    iVar3 = *(int *)(param3 + 0xc);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (0 < iVar3) {
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (*(undefined4 *)(iVar2 + 0x28),2,
		                 Method_UI_MonoBehaviourWithStates_BossPossibleEmptyWindowStateController_WindowStates__set_CurrentState__
		                );
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Gameplay_Boss_View_TeamsTab_BossTeamsListAdapter__UpdateViewsHolder
		                (*(undefined4 *)(iVar2 + 0x24),param3,0);
		      return;
		    }
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(iVar2 + 0x28),1,
		               Method_UI_MonoBehaviourWithStates_BossPossibleEmptyWindowStateController_WindowStates__set_CurrentState__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x060049A5 RID: 18853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049A5")]
		[Address(RVA = "0x9817", Offset = "0x9817", VA = "0x9817")]
		private void CaptainTeamsReceivedEvent(ulong captainId, List<TeamRewardData> teams)
		{
		/* --- GHIDRA: CaptainTeamsReceivedEvent ---
		void Gameplay_Boss_Controller_BossTeamsViewMediator__CaptainTeamsReceivedEvent(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6087c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossTeamsViewMediator___c_TypeInfo);
		    DAT_ram_00a6087c = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Boss_Controller_BossTeamsViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Boss_Controller_BossTeamsViewMediator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002810 RID: 10256
		[Token(Token = "0x4002810")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<TeamRewardData> _teamsRewardData;

		// Token: 0x04002811 RID: 10257
		[Token(Token = "0x4002811")]
		[FieldOffset(Offset = "0x1C")]
		private readonly List<ulong> _teamIdsWithAssistants;
	}
}
