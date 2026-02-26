using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Sorting;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.CaptainTab;
using Il2CppDummyDll;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BB4 RID: 2996
	[Token(Token = "0x2000BB4")]
	public class BossTeamEditViewMediator : AbstractBossWindowViewMediator<BossTeamEditView>
	{
		// Token: 0x0600497D RID: 18813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600497D")]
		[Address(RVA = "0x97EF", Offset = "0x97EF", VA = "0x97EF")]
		public BossTeamEditViewMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_Controller_BossTeamEditViewMediator___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a5792d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IList_ulong___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_HandleInviteOrKickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_PossibleAssistantsReceivedEvent__
		              );
		    DAT_ram_00a5792d = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_IList_ulong___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_PossibleAssistantsReceivedEvent__
		             ,0);
		  iVar2 = func_ii_7048(uVar4,uVar1,0);
		  uVar1 = System_Action_IList_ulong___TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x20) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_IList_ulong___TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x20) = iVar3;
		    uVar1 = System_Action_IList_ulong___TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_IList_ulong___TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		  func_ii_6877(uVar1,param1,
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_HandleInviteOrKickEvent__,0)
		  ;
		  iVar2 = func_ii_7048(uVar4,uVar1,0);
		  uVar1 = System_Action_ulong__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x24) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x24) = iVar3;
		    uVar4 = System_Action_ulong__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		    uVar1 = System_Action_ulong__TypeInfo;
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x28);
		  uVar1 = unnamed_function_1417(uVar1);
		  func_ii_6877(uVar1,param1,
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_HandleInviteOrKickEvent__,0)
		  ;
		  iVar2 = func_ii_7048(uVar4,uVar1,0);
		  uVar1 = System_Action_ulong__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x28) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x28) = iVar3;
		    uVar4 = System_Action_ulong__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		    uVar1 = System_Action_ulong__TypeInfo;
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x2c);
		  uVar1 = unnamed_function_1417(uVar1);
		  func_ii_6877(uVar1,param1,
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_HandleInviteOrKickEvent__,0)
		  ;
		  iVar2 = func_ii_7048(uVar4,uVar1,0);
		  uVar1 = System_Action_ulong__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x2c) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(param2 + 0x2c) = iVar3;
		    uVar1 = System_Action_ulong__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		    if (iVar3 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar2,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar2,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600497E RID: 18814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600497E")]
		[Address(RVA = "0x97F0", Offset = "0x97F0", VA = "0x97F0", Slot = "21")]
		protected override void ResetEvents(BossInstanceEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Boss_Controller_BossTeamEditViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a5792e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IList_ulong___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_HandleInviteOrKickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_PossibleAssistantsReceivedEvent__
		              );
		    DAT_ram_00a5792e = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_IList_ulong___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_PossibleAssistantsReceivedEvent__
		             ,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar4,uVar1,0);
		  uVar1 = System_Action_IList_ulong___TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x20) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_IList_ulong___TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x20) = iVar3;
		    uVar1 = System_Action_IList_ulong___TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_IList_ulong___TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		  func_ii_6877(uVar1,param1,
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_HandleInviteOrKickEvent__,0)
		  ;
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar4,uVar1,0);
		  uVar1 = System_Action_ulong__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x24) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x24) = iVar3;
		    uVar4 = System_Action_ulong__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		    uVar1 = System_Action_ulong__TypeInfo;
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x28);
		  uVar1 = unnamed_function_1417(uVar1);
		  func_ii_6877(uVar1,param1,
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_HandleInviteOrKickEvent__,0)
		  ;
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar4,uVar1,0);
		  uVar1 = System_Action_ulong__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x28) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x28) = iVar3;
		    uVar4 = System_Action_ulong__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		    uVar1 = System_Action_ulong__TypeInfo;
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x2c);
		  uVar1 = unnamed_function_1417(uVar1);
		  func_ii_6877(uVar1,param1,
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_HandleInviteOrKickEvent__,0)
		  ;
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar4,uVar1,0);
		  uVar1 = System_Action_ulong__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x2c) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(param2 + 0x2c) = iVar3;
		    uVar1 = System_Action_ulong__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		    if (iVar3 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar2,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar2,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600497F RID: 18815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600497F")]
		[Address(RVA = "0x97F1", Offset = "0x97F1", VA = "0x97F1", Slot = "22")]
		protected override void SetupEvents(BossInstanceEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Boss_Controller_BossTeamEditViewMediator__SetupEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5792f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Sorting_AbstractSortControlView_UserData__remove_ComparerChangedEvent__);
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IGameDataComparer_UserData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TeamData_TeamAssistantData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_CancelButtonClickedHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_ConfirmButtonClickedHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_SortControlOnComparerChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_ViewOnClickOnPossibleAssistantEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_ViewOnClickOnTeamMemberClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5792f = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param2 + 0x2c);
		  uVar1 = unnamed_function_1417(System_Action_UserData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_ViewOnClickOnPossibleAssistantEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter__add_ClickedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param2 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_TeamData_TeamAssistantData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_ViewOnClickOnTeamMemberClickedEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossTeamEditView___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x28) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_ConfirmButtonClickedHandler__,
		             0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x34) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_CancelButtonClickedHandler__,0
		            );
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param2 + 0x30);
		  uVar1 = unnamed_function_1417(System_Action_IGameDataComparer_UserData___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_SortControlOnComparerChangedEvent__
		             ,0);
		  UI_Sorting_AbstractSortControlView___Il2CppFullySharedGenericType___get_SelectedFilter
		            (uVar2,uVar1,
		             Method_UI_Sorting_AbstractSortControlView_UserData__remove_ComparerChangedEvent__);
		  return;
		}
		*/

		}

		// Token: 0x06004980 RID: 18816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004980")]
		[Address(RVA = "0x97F2", Offset = "0x97F2", VA = "0x97F2", Slot = "23")]
		protected override void ResetView(BossTeamEditView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Boss_Controller_BossTeamEditViewMediator__ResetView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57930 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Sorting_AbstractSortControlView_UserData__add_ComparerChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossTeamEditView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IGameDataComparer_UserData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TeamData_TeamAssistantData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_CancelButtonClickedHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_ConfirmButtonClickedHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_SortControlOnComparerChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_ViewOnClickOnPossibleAssistantEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_ViewOnClickOnTeamMemberClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57930 = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__add_AssistantClickedEvent
		            (*(undefined4 *)(param2 + 0x24),param1[6],0);
		  uVar2 = *(undefined4 *)(param2 + 0x2c);
		  uVar1 = unnamed_function_1417(System_Action_UserData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_ViewOnClickOnPossibleAssistantEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter__set_Data(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param2 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_TeamData_TeamAssistantData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_ViewOnClickOnTeamMemberClickedEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossTeamEditView__add_ExitEditModeEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x28) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_ConfirmButtonClickedHandler__,
		             0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x34) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_CancelButtonClickedHandler__,0
		            );
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param2 + 0x30);
		  uVar1 = unnamed_function_1417(System_Action_IGameDataComparer_UserData___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_SortControlOnComparerChangedEvent__
		             ,0);
		  UI_Sorting_AbstractSortControlView___Il2CppFullySharedGenericType___SwitcherValueChangedHandler
		            (uVar2,uVar1,
		             Method_UI_Sorting_AbstractSortControlView_UserData__add_ComparerChangedEvent__);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Boss_Controller_BossInstanceController__HandleStop(uVar1,param1);
		  Gameplay_Boss_Controller_BossCaptainViewMediator__TrySelectLastSavedOptionAndVariant
		            (*(undefined4 *)(param2 + 0x24),*(undefined4 *)(param1[2] + 0x30),0);
		  return;
		}
		*/

		}

		// Token: 0x06004981 RID: 18817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004981")]
		[Address(RVA = "0x97F3", Offset = "0x97F3", VA = "0x97F3", Slot = "24")]
		protected override void SetupView(BossTeamEditView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Boss_Controller_BossTeamEditViewMediator__SetupView
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Boss_Controller_BossTeamEditViewMediator__ResultCallback(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004982 RID: 18818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004982")]
		[Address(RVA = "0x97F4", Offset = "0x97F4", VA = "0x97F4")]
		private void SortControlOnComparerChangedEvent(IGameDataComparer<UserData> comparer)
		{
		/* --- GHIDRA: SortControlOnComparerChangedEvent ---
		/* WARNING: Removing unreachable block (ram,0x80e022ff) */
		/* WARNING: Removing unreachable block (ram,0x80e027c9) */
		
		void Gameplay_Boss_Controller_BossTeamEditViewMediator__SortControlOnComparerChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  int *piVar8;
		  longlong lVar9;
		  longlong lVar10;
		  undefined4 uVar11;
		  undefined4 param2_00;
		  int iVar12;
		  uint uVar13;
		  undefined4 *puVar14;
		  undefined1 auStack_40 [8];
		  int local_38;
		  undefined8 *local_34;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57931 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossTeamEditView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_TeamData_TeamAssistantData__ulong___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_ulong___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_TeamData_TeamAssistantData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_TeamData_TeamAssistantData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_TeamData_TeamAssistantData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_TeamData_TeamAssistantData__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamData_TeamAssistantData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamData_TeamAssistantData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamData_TeamAssistantData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamData_TeamAssistantData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_TeamData_TeamAssistantData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Boss_Controller_BossTeamEditViewMediator_ModifyTeamQueueData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator___c__ConfirmButtonClickedHandler_b__10_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator___c__ConfirmButtonClickedHandler_b__10_1__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo);
		    DAT_ram_00a57931 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  uVar11 = *(undefined4 *)(param1[6] + 0x14);
		  param2_00 = *(undefined4 *)(*(int *)(param1[2] + 0x3c) + 0x14);
		  iVar2 = unnamed_function_1417
		                    (System_Collections_Generic_List_TeamData_TeamAssistantData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_TeamData_TeamAssistantData___ctor__);
		  iVar3 = unnamed_function_1417
		                    (System_Collections_Generic_List_TeamData_TeamAssistantData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar3,Method_System_Collections_Generic_List_TeamData_TeamAssistantData___ctor__);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_30,param2_00,
		             Method_System_Collections_Generic_List_TeamData_TeamAssistantData__GetEnumerator__);
		  local_8 = local_28;
		  local_10 = CONCAT44(puStack_2c,local_30);
		  local_38 = 0;
		  local_34 = &local_10;
		code_r0x80e02078:
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_TeamData_TeamAssistantData__MoveNext__
		                        );
		      iVar12 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar12 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar12 = global_1;
		        goto code_r0x80e0244d;
		      }
		      if (iVar4 == 0) {
		        iVar4 = 7;
		        iVar12 = local_38;
		        goto code_r0x80e02498;
		      }
		      DAT_ram_009d3e38 = 0;
		      piVar6 = local_8._4_4_;
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_30,uVar11,
		                 Method_System_Collections_Generic_List_TeamData_TeamAssistantData__GetEnumerator__)
		      ;
		      iVar12 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar12 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar12 = global_1;
		        goto code_r0x80e0244d;
		      }
		      local_18 = local_28;
		      local_20 = CONCAT44(puStack_2c,local_30);
		      local_30 = 0;
		      puStack_2c = &local_20;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_20,
		                           Method_System_Collections_Generic_List_Enumerator_TeamData_TeamAssistantData__MoveNext__
		                          );
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e02271:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar12 = global_1;
		          iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar12 == iVar4) {
		            piVar8 = (int *)import::env::__cxa_begin_catch(uVar5);
		            local_30 = *piVar8;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_v(0x123);
		            iVar12 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            iVar7 = 0;
		            iVar4 = 0;
		            if (iVar12 != 1) break;
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar12 = global_1;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3bb,&local_30);
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 != 1) goto code_r0x80e0244d;
		          goto code_r0x80e02b8b;
		        }
		        iVar4 = 6;
		        if (iVar7 == 0) break;
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::invoke_iii
		                          (*(undefined4 *)(*local_18._4_4_ + 0xe0),local_18._4_4_,
		                           *(undefined4 *)(*local_18._4_4_ + 0xe4));
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e02271;
		        DAT_ram_009d3e38 = 0;
		        lVar9 = unnamed_function_184054
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x356,uVar5,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e02271;
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::invoke_iii
		                          (*(undefined4 *)(*piVar6 + 0xe0),piVar6,*(undefined4 *)(*piVar6 + 0xe4));
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e02271;
		        DAT_ram_009d3e38 = 0;
		        lVar10 = unnamed_function_184054
		                           (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x356,uVar5,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e02271;
		        iVar4 = 6;
		      } while (lVar9 != lVar10);
		      iVar1 = Method_System_Collections_Generic_List_TeamData_TeamAssistantData__Add__;
		      if (local_30 != 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_30);
		        iVar12 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar12 != 1) goto code_r0x80e02b95;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar12 = global_1;
		        goto code_r0x80e0244d;
		      }
		      if ((iVar4 != 0) &&
		         (((((iVar12 = local_38, iVar4 == 1 || (iVar4 == 2)) || (iVar4 == 3)) ||
		           ((iVar4 == 4 || (iVar4 == 5)))) || (iVar4 != 6)))) goto code_r0x80e02498;
		    } while (iVar7 != 0);
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar13 = *(uint *)(iVar2 + 0xc);
		    if (uVar13 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar13 + 1;
		      *(int **)(*(int *)(iVar2 + 8) + uVar13 * 4 + 0x10) = piVar6;
		      goto code_r0x80e02078;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,piVar6,
		               *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    iVar12 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar12 != 1);
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar12 = global_1;
		code_r0x80e0244d:
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar12) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar12 = *piVar6;
		    iVar4 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_38 = iVar12;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x80e02498:
		      DAT_ram_009d3e38 = 0;
		      if (iVar12 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar12);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar4 != 0) &&
		         ((((iVar4 == 1 || (iVar4 == 2)) ||
		           ((iVar4 == 3 || (((iVar4 == 4 || (iVar4 == 5)) || (iVar4 == 6)))))) || (iVar4 != 7)))) {
		        return;
		      }
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_30,uVar11,
		                 Method_System_Collections_Generic_List_TeamData_TeamAssistantData__GetEnumerator__)
		      ;
		      local_8 = local_28;
		      local_10 = CONCAT44(puStack_2c,local_30);
		      local_38 = 0;
		      local_34 = &local_10;
		code_r0x80e02546:
		      do {
		        do {
		          DAT_ram_009d3e38 = 0;
		          iVar4 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                             Method_System_Collections_Generic_List_Enumerator_TeamData_TeamAssistantData__MoveNext__
		                            );
		          iVar12 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar12 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar12 = global_1;
		            goto code_r0x80e02915;
		          }
		          if (iVar4 == 0) {
		            iVar4 = 0xd;
		            iVar12 = local_38;
		            goto code_r0x80e02960;
		          }
		          DAT_ram_009d3e38 = 0;
		          piVar6 = local_8._4_4_;
		          System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                    (&local_30,param2_00,
		                     Method_System_Collections_Generic_List_TeamData_TeamAssistantData__GetEnumerator__
		                    );
		          iVar12 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar12 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar12 = global_1;
		            goto code_r0x80e02915;
		          }
		          local_18 = local_28;
		          local_20 = CONCAT44(puStack_2c,local_30);
		          local_30 = 0;
		          puStack_2c = &local_20;
		          do {
		            DAT_ram_009d3e38 = 0;
		            iVar7 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_20,
		                               Method_System_Collections_Generic_List_Enumerator_TeamData_TeamAssistantData__MoveNext__
		                              );
		            if (DAT_ram_009d3e38 == 1) {
		code_r0x80e02743:
		              DAT_ram_009d3e38 = 0;
		              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar12 = global_1;
		              iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		              if (iVar12 == iVar4) {
		                piVar8 = (int *)import::env::__cxa_begin_catch(uVar5);
		                iVar12 = *piVar8;
		                DAT_ram_009d3e38 = 0;
		                local_30 = iVar12;
		                import::env::invoke_v(0x123);
		                iVar1 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                iVar7 = 0;
		                iVar4 = 0;
		                if (iVar1 != 1) break;
		                uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                iVar12 = global_1;
		              }
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_ii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3bd,&local_30);
		              iVar4 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar4 == 1) goto code_r0x80e02b8b;
		              goto code_r0x80e02915;
		            }
		            iVar12 = 0;
		            iVar4 = 0xc;
		            if (iVar7 == 0) break;
		            DAT_ram_009d3e38 = 0;
		            uVar11 = import::env::invoke_iii
		                               (*(undefined4 *)(*local_18._4_4_ + 0xe0),local_18._4_4_,
		                                *(undefined4 *)(*local_18._4_4_ + 0xe4));
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80e02743;
		            DAT_ram_009d3e38 = 0;
		            lVar9 = unnamed_function_184054
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x356,uVar11,0);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80e02743;
		            DAT_ram_009d3e38 = 0;
		            uVar11 = import::env::invoke_iii
		                               (*(undefined4 *)(*piVar6 + 0xe0),piVar6,
		                                *(undefined4 *)(*piVar6 + 0xe4));
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80e02743;
		            DAT_ram_009d3e38 = 0;
		            lVar10 = unnamed_function_184054
		                               (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x356,uVar11,0);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80e02743;
		            iVar4 = 0xc;
		          } while (lVar9 != lVar10);
		          iVar1 = Method_System_Collections_Generic_List_TeamData_TeamAssistantData__Add__;
		          if (iVar12 != 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar12);
		            iVar12 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar12 != 1) {
		code_r0x80e02b95:
		              do {
		                halt_trap();
		              } while( true );
		            }
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar12 = global_1;
		            goto code_r0x80e02915;
		          }
		          if ((iVar4 != 0) &&
		             ((((iVar12 = local_38, iVar4 == 1 || (iVar4 == 2)) ||
		               ((((iVar4 == 3 || ((iVar4 == 4 || (iVar4 == 5)))) || (iVar4 == 6)) ||
		                (((iVar4 == 7 || (iVar4 == 8)) || (iVar4 == 9)))))) ||
		              (((iVar4 == 10 || (iVar4 == 0xb)) || (iVar4 != 0xc)))))) goto code_r0x80e02960;
		        } while (iVar7 != 0);
		        *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		        uVar13 = *(uint *)(iVar3 + 0xc);
		        if (uVar13 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		          *(uint *)(iVar3 + 0xc) = uVar13 + 1;
		          *(int **)(*(int *)(iVar3 + 8) + uVar13 * 4 + 0x10) = piVar6;
		          goto code_r0x80e02546;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar3,piVar6,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		        iVar12 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar12 != 1);
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar12 = global_1;
		code_r0x80e02915:
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar4 == iVar12) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		        iVar12 = *piVar6;
		        iVar4 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_38 = iVar12;
		        import::env::invoke_v(0x123);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		code_r0x80e02960:
		          DAT_ram_009d3e38 = 0;
		          if (iVar12 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar12);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if (iVar4 != 0) {
		            if (iVar4 == 1) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar4 == 2) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar4 == 3) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar4 == 4) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar4 == 5) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar4 == 6) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar4 == 7) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar4 == 8) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar4 == 9) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar4 == 10) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar4 == 0xb) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar4 == 0xc) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar4 != 0xd) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		          }
		          if ((*(int *)(iVar3 + 0xc) < 1) && (*(int *)(iVar2 + 0xc) < 1)) {
		            iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x15c));
		            Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter__SetItems
		                      (*(undefined4 *)(iVar2 + 0x2c),0);
		            uVar11 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                               (param1,*(undefined4 *)(*param1 + 0x15c));
		            GAFInternal_Objects_GAFMeshManager__pushSetupRequest(uVar11,0);
		            return;
		          }
		          iVar12 = unnamed_function_1417
		                             (
		                             Gameplay_Boss_Controller_BossTeamEditViewMediator_ModifyTeamQueueData_TypeInfo
		                             );
		          if (*(int *)(Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo + 0x74) == 0)
		          {
		            func_ii_306000(Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo);
		          }
		          puVar14 = *(undefined4 **)
		                     (Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo + 0x5c);
		          iVar4 = puVar14[1];
		          if (iVar4 == 0) {
		            if (*(int *)(Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo + 0x74) == 0
		               ) {
		              func_ii_306000(Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo);
		              puVar14 = *(undefined4 **)
		                         (Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo + 0x5c);
		            }
		            uVar11 = *puVar14;
		            iVar4 = unnamed_function_1417(System_Func_TeamData_TeamAssistantData__ulong__TypeInfo);
		            func_ii_7542(iVar4,uVar11,
		                         Method_Gameplay_Boss_Controller_BossTeamEditViewMediator___c__ConfirmButtonClickedHandler_b__10_0__
		                         ,0);
		            *(int *)(*(int *)(Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo + 0x5c)
		                    + 4) = iVar4;
		          }
		          uVar11 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                             (iVar3,iVar4,
		                              Method_System_Linq_Enumerable_Select_TeamData_TeamAssistantData__ulong___
		                             );
		          uVar11 = System_Linq_Enumerable__ToList_uint_
		                             (uVar11,Method_System_Linq_Enumerable_ToList_ulong___);
		          *(undefined4 *)(iVar12 + 8) = uVar11;
		          if (*(int *)(Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo + 0x74) == 0)
		          {
		            func_ii_306000(Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo);
		          }
		          puVar14 = *(undefined4 **)
		                     (Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo + 0x5c);
		          iVar3 = puVar14[2];
		          if (iVar3 == 0) {
		            if (*(int *)(Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo + 0x74) == 0
		               ) {
		              func_ii_306000(Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo);
		              puVar14 = *(undefined4 **)
		                         (Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo + 0x5c);
		            }
		            uVar11 = *puVar14;
		            iVar3 = unnamed_function_1417(System_Func_TeamData_TeamAssistantData__ulong__TypeInfo);
		            func_ii_7542(iVar3,uVar11,
		                         Method_Gameplay_Boss_Controller_BossTeamEditViewMediator___c__ConfirmButtonClickedHandler_b__10_1__
		                         ,0);
		            *(int *)(*(int *)(Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo + 0x5c)
		                    + 8) = iVar3;
		          }
		          uVar11 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                             (iVar2,iVar3,
		                              Method_System_Linq_Enumerable_Select_TeamData_TeamAssistantData__ulong___
		                             );
		          uVar11 = System_Linq_Enumerable__ToList_uint_
		                             (uVar11,Method_System_Linq_Enumerable_ToList_ulong___);
		          *(undefined4 *)(iVar12 + 0xc) = uVar11;
		          param1[8] = iVar12;
		          Gameplay_Boss_Controller_BossTeamEditViewMediator__ConfirmButtonClickedHandler
		                    (param1,auStack_40);
		          return;
		        }
		        uVar5 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3be,&local_38);
		      goto joined_r0x80e029ba;
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3bc,&local_38);
		joined_r0x80e029ba:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x80e02b8b:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004983 RID: 18819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004983")]
		[Address(RVA = "0x97F5", Offset = "0x97F5", VA = "0x97F5")]
		private void ConfirmButtonClickedHandler()
		{
		/* --- GHIDRA: ConfirmButtonClickedHandler ---
		void Gameplay_Boss_Controller_BossTeamEditViewMediator__ConfirmButtonClickedHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  iVar2 = Gameplay_Boss_Controller_BossTeamEditViewMediator_ModifyTeamQueueData__set_CurrentOperation
		                    (param1[8],param1);
		  if (iVar2 == 0) {
		    uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		    uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter__SetItems(*(undefined4 *)(iVar2 + 0x2c),0)
		    ;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x15c)));
		    GAFInternal_Objects_GAFMeshManager__pushSetupRequest(uVar3,0);
		    return;
		  }
		  iVar2 = *(int *)(param1[8] + 0x10);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c)));
		  if (iVar2 != 1) {
		    Gameplay_Boss_Controller_BossInstanceController__InviteAssistant
		              (uVar3,*(undefined8 *)(param1[8] + 0x18),param1);
		    return;
		  }
		  Gameplay_Boss_Controller_BossInstanceController__TryCreateTeam
		            (uVar3,*(undefined8 *)(param1[8] + 0x18),param1);
		  return;
		}
		*/

		}

		// Token: 0x06004984 RID: 18820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004984")]
		[Address(RVA = "0x97F6", Offset = "0x97F6", VA = "0x97F6")]
		private void HandleModifyQueue()
		{
		}

		// Token: 0x06004985 RID: 18821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004985")]
		[Address(RVA = "0x97F7", Offset = "0x97F7", VA = "0x97F7")]
		private void CancelButtonClickedHandler()
		{
		/* --- GHIDRA: CancelButtonClickedHandler ---
		void Gameplay_Boss_Controller_BossTeamEditViewMediator__CancelButtonClickedHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter__SetItems(*(undefined4 *)(iVar1 + 0x2c),0);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  GAFInternal_Objects_GAFMeshManager__pushSetupRequest(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004986 RID: 18822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004986")]
		[Address(RVA = "0x97F8", Offset = "0x97F8", VA = "0x97F8")]
		private void CloseEditWindow()
		{
		/* --- GHIDRA: CloseEditWindow ---
		void Gameplay_Boss_Controller_BossTeamEditViewMediator__CloseEditWindow
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  if (param2 != 0) {
		    Gameplay_Boss_Controller_BossTeamEditViewMediator__MoveToTeam(param1,param2,param2);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004987 RID: 18823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004987")]
		[Address(RVA = "0x97F9", Offset = "0x97F9", VA = "0x97F9")]
		private void ViewOnClickOnTeamMemberClickedEvent(TeamData.TeamAssistantData assistantData)
		{
		/* --- GHIDRA: ViewOnClickOnTeamMemberClickedEvent ---
		void Gameplay_Boss_Controller_BossTeamEditViewMediator__ViewOnClickOnTeamMemberClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x18);
		  if (DAT_ram_00a57890 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamData_TeamAssistantData__get_Count__);
		    DAT_ram_00a57890 = '\x01';
		  }
		  if (*(int *)(*(int *)(iVar1 + 0x14) + 0xc) < 5) {
		    Gameplay_Boss_Controller_BossTeamEditViewMediator__ViewOnClickOnPossibleAssistantEvent
		              (param1,param2,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004988 RID: 18824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004988")]
		[Address(RVA = "0x97FA", Offset = "0x97FA", VA = "0x97FA")]
		private void ViewOnClickOnPossibleAssistantEvent(UserData userData)
		{
		/* --- GHIDRA: ViewOnClickOnPossibleAssistantEvent ---
		void Gameplay_Boss_Controller_BossTeamEditViewMediator__ViewOnClickOnPossibleAssistantEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined8 param2_00;
		  int param2_01;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57932 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossTeamEditView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_UserData__Remove__);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_TeamInfo_Types_MercenaryInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_TeamInfo_Types_MercenaryInfo__Add__
		              );
		    DAT_ram_00a57932 = '\x01';
		  }
		  param2_01 = *(int *)(param1[6] + 0x34);
		  uVar2 = *(undefined4 *)(param1[2] + 0x3c);
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param2,0);
		  iVar1 = func_ii_7046(uVar2,param2_00,param1);
		  uVar2 = (undefined4)((ulonglong)param2_00 >> 0x20);
		  if (iVar1 == 0) {
		    iVar1 = unnamed_function_1417(Protocol_Boss_TeamInfo_Types_MercenaryInfo_TypeInfo);
		    Protocol_Boss_TeamInfo_Types_MercenaryInfo__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0)
		    ;
		    *(undefined4 *)(iVar1 + 0xc) = *(undefined4 *)(param2 + 0x34);
		  }
		  else {
		    iVar1 = *(int *)(iVar1 + 0x30);
		  }
		  func_ii_6441(*(undefined4 *)(param2_01 + 0x28),iVar1,
		               Method_Google_Protobuf_Collections_RepeatedField_TeamInfo_Types_MercenaryInfo__Add__)
		  ;
		  Gameplay_Boss_Model_TeamData__get_RawTeamInfo(param1[6],param2_01,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x15c)));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__add_AssistantClickedEvent
		            (*(undefined4 *)(iVar1 + 0x24),param1[6],0);
		  func_ii_4876(param1[7],param2,Method_System_Collections_Generic_List_UserData__Remove__);
		  Gameplay_Boss_Controller_BossTeamEditViewMediator__ResultCallback(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004989 RID: 18825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004989")]
		[Address(RVA = "0x97FB", Offset = "0x97FB", VA = "0x97FB")]
		private void MoveToTeam(UserData userData)
		{
		/* --- GHIDRA: MoveToTeam ---
		void Gameplay_Boss_Controller_BossTeamEditViewMediator__MoveToTeam
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param1_00;
		  uint uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a57933 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_First_TeamInfo_Types_MercenaryInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_TeamInfo_Types_MercenaryInfo__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_UserData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_TeamInfo_Types_MercenaryInfo__Remove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator___c__DisplayClass17_0__RemoveFromTeam_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Boss_Controller_BossTeamEditViewMediator___c__DisplayClass17_0_TypeInfo);
		    DAT_ram_00a57933 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Boss_Controller_BossTeamEditViewMediator___c__DisplayClass17_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 8) = param2;
		  iVar3 = *(int *)(param1[6] + 0x34);
		  param1_00 = *(undefined4 *)(iVar3 + 0x28);
		  uVar2 = unnamed_function_1417(System_Func_TeamInfo_Types_MercenaryInfo__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,
		             Method_Gameplay_Boss_Controller_BossTeamEditViewMediator___c__DisplayClass17_0__RemoveFromTeam_b__0__
		             ,0);
		  uVar2 = func_ii_7423(param1_00,uVar2,
		                       Method_System_Linq_Enumerable_First_TeamInfo_Types_MercenaryInfo___);
		  UI_Windows_PopupController__Show_object_
		            (*(undefined4 *)(iVar3 + 0x28),uVar2,
		             Method_Google_Protobuf_Collections_RepeatedField_TeamInfo_Types_MercenaryInfo__Remove__
		            );
		  Gameplay_Boss_Model_TeamData__get_RawTeamInfo(param1[6],iVar3,param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__add_AssistantClickedEvent
		            (*(undefined4 *)(iVar3 + 0x24),param1[6],0);
		  iVar3 = param1[7];
		  iVar5 = **(int **)(iVar1 + 8);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe0) * 4))
		                    (*(int **)(iVar1 + 8),*(undefined4 *)(iVar5 + 0xe4));
		  iVar1 = Method_System_Collections_Generic_List_UserData__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar2;
		    Gameplay_Boss_Controller_BossTeamEditViewMediator__ResultCallback(param1,param1);
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (iVar3,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  Gameplay_Boss_Controller_BossTeamEditViewMediator__ResultCallback(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600498A RID: 18826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600498A")]
		[Address(RVA = "0x97FC", Offset = "0x97FC", VA = "0x97FC")]
		private void RemoveFromTeam(TeamData.TeamAssistantData assistantData)
		{
		/* --- GHIDRA: RemoveFromTeam ---
		void Gameplay_Boss_Controller_BossTeamEditViewMediator__RemoveFromTeam
		               (int param1,longlong param2,undefined4 param3)
		
		{
		  if ((*(int *)(param1 + 0x20) != 0) && (*(longlong *)(*(int *)(param1 + 0x20) + 0x18) == param2)) {
		    Gameplay_Boss_Controller_BossTeamEditViewMediator__ConfirmButtonClickedHandler(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600498B RID: 18827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600498B")]
		[Address(RVA = "0x97FD", Offset = "0x97FD", VA = "0x97FD")]
		private void HandleInviteOrKickEvent(ulong uid)
		{
		/* --- GHIDRA: HandleInviteOrKickEvent ---
		void Gameplay_Boss_Controller_BossTeamEditViewMediator__HandleInviteOrKickEvent
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint in_register_20000024;
		  ulonglong uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  undefined4 uVar9;
		  ulonglong param3_00;
		  ulonglong uVar10;
		  undefined4 uVar11;
		  int *piVar12;
		  int iVar13;
		  uint uVar14;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  uVar1 = (ulonglong)in_register_20000024 << 0x20;
		  if (DAT_ram_00a57934 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossTeamEditView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_ResultCallback__);
		    Mono_Security_ASN1__get_Item(&Core_Cache_CacheResultCallback_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_ICache_ulong__UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ulong__TypeInfo);
		    DAT_ram_00a57934 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_ulong__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_ulong___ctor__);
		  iVar13 = *param2;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    uVar14 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_ulong__TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		        puVar3 = (uint *)(iVar13 + *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e0311b;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		  }
		  uVar1 = uVar1 & 0xffffffff00000000;
		  puVar3 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_ulong__TypeInfo,0);
		code_r0x80e0311b:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x80e03140:
		  do {
		    do {
		      do {
		        piVar8 = local_4;
		        uVar11 = (undefined4)(uVar1 >> 0x20);
		        iVar13 = *local_4;
		        if (*(ushort *)(iVar13 + 0xb6) != 0) {
		          uVar14 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar12) {
		              puVar4 = (undefined4 *)(iVar13 + piVar12[1] * 8 + 0xc0);
		              goto code_r0x80e031e6;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e0322e:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e0344f;
		        }
		code_r0x80e031e6:
		        DAT_ram_009d3e38 = 0;
		        iVar13 = import::env::invoke_iii(*puVar4,piVar8,puVar4[1]);
		        piVar8 = local_4;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e0322e;
		        if (iVar13 == 0) {
		          iVar13 = 0;
		          goto code_r0x80e03498;
		        }
		        iVar13 = *local_4;
		        if (*(ushort *)(iVar13 + 0xb6) != 0) {
		          uVar14 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8);
		            if (System_Collections_Generic_IEnumerator_ulong__TypeInfo == *piVar12) {
		              puVar4 = (undefined4 *)(iVar13 + piVar12[1] * 8 + 0xc0);
		              goto code_r0x80e032d7;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_Generic_IEnumerator_ulong__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e0335c:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e0344f;
		        }
		code_r0x80e032d7:
		        DAT_ram_009d3e38 = 0;
		        uVar1 = CONCAT44(uVar11,puVar4[1]);
		        param3_00 = unnamed_function_184054(*puVar4,piVar8,puVar4[1]);
		        uVar11 = (undefined4)(uVar1 >> 0x20);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e0335c;
		        DAT_ram_009d3e38 = 0;
		        uVar1 = uVar1 & 0xffffffff00000000;
		        uVar10 = unnamed_function_184054
		                           (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x356,
		                            *(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		        iVar13 = DAT_ram_009d3e38;
		        uVar11 = (undefined4)(uVar1 >> 0x20);
		        DAT_ram_009d3e38 = 0;
		        if (iVar13 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e0344f;
		        }
		      } while (param3_00 == uVar10);
		      uVar11 = *(undefined4 *)(*(int *)(param1 + 8) + 0x3c);
		      DAT_ram_009d3e38 = 0;
		      uVar1 = param3_00;
		      iVar6 = unnamed_function_184070
		                        (s_struct_Uniforms___color__array<v_ram_00001b87,uVar11,param3_00,uVar11);
		      iVar7 = DAT_ram_009d3e38;
		      iVar13 = Method_System_Collections_Generic_List_ulong__Add__;
		      uVar11 = (undefined4)(uVar1 >> 0x20);
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e0344f;
		      }
		    } while (iVar6 != 0);
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar14 = *(uint *)(iVar2 + 0xc);
		    if (uVar14 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar14 + 1;
		      *(ulonglong *)(*(int *)(iVar2 + 8) + uVar14 * 8 + 0x10) = param3_00;
		      goto code_r0x80e03140;
		    }
		    DAT_ram_009d3e38 = 0;
		    unnamed_function_184058
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ea,iVar2,param3_00,
		               *(undefined4 *)(*(int *)(*(int *)(iVar13 + 0x10) + 0x60) + 0x38));
		    iVar13 = DAT_ram_009d3e38;
		    uVar11 = (undefined4)(param3_00 >> 0x20);
		    DAT_ram_009d3e38 = 0;
		    uVar1 = param3_00;
		  } while (iVar13 != 1);
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e0344f:
		  iVar13 = global_1;
		  iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar13 == iVar7) {
		    piVar8 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar13 = *piVar8;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar13;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x80e03498:
		      piVar8 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar14 = 0;
		        iVar7 = *local_4;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar14 * 8)) {
		              puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar14 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80e03510;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar14);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e03510:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar8,puVar3[1]);
		      }
		      if (iVar13 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar13);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar13 = *piVar8;
		      if (*(ushort *)(iVar13 + 0xb6) != 0) {
		        uVar14 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 + iVar13 +
		                             0x158);
		            goto code_r0x80e035bb;
		          }
		          uVar14 = uVar14 + 1;
		        } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80e035bb:
		      uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar8,puVar3[1]);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar13 = *piVar8;
		      if (*(ushort *)(iVar13 + 0xb6) != 0) {
		        uVar14 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 + iVar13 +
		                             0x158);
		            goto code_r0x80e03667;
		          }
		          uVar14 = uVar14 + 1;
		        } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80e03667:
		      uVar14 = 0;
		      iVar13 = (**(code **)((ulonglong)*puVar3 * 4))(piVar8,puVar3[1]);
		      piVar8 = (int *)Core_Gameplay_Managers_CacheManager__set_AudioClipCache
		                                (uVar5,*(undefined4 *)(iVar13 + 0x14),0);
		      uVar5 = unnamed_function_1417(Core_Cache_CacheResultCallback_UserData__TypeInfo);
		      Cysharp_Threading_Tasks_UniTaskCompletionSource__get_Task
		                (uVar5,param1,
		                 Method_Gameplay_Boss_Controller_BossTeamEditViewMediator_ResultCallback__,0);
		      uVar9 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                        (iVar2,Method_System_Collections_Generic_List_ulong__ToArray__);
		      iVar2 = *piVar8;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (Core_Cache_ICache_ulong__UserData__TypeInfo ==
		              *(int *)(*(int *)(iVar2 + 0x58) + uVar14 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar14 * 8 + 4) * 8 + iVar2 + 200);
		            goto code_r0x80e03724;
		          }
		          uVar14 = uVar14 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar14);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar8,Core_Cache_ICache_ulong__UserData__TypeInfo,1);
		code_r0x80e03724:
		      (**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar5,CONCAT44(uVar11,uVar9),puVar3[1]);
		      return;
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 1,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600498C RID: 18828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600498C")]
		[Address(RVA = "0x97FE", Offset = "0x97FE", VA = "0x97FE")]
		private void PossibleAssistantsReceivedEvent(IList<ulong> list)
		{
		/* --- GHIDRA: PossibleAssistantsReceivedEvent ---
		void Gameplay_Boss_Controller_BossTeamEditViewMediator__PossibleAssistantsReceivedEvent
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57935 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_UserData___);
		    DAT_ram_00a57935 = '\x01';
		  }
		  if (*(char *)(param1 + 0x24) == '\0') {
		    uVar1 = System_Linq_Enumerable__Select_object__object_
		                      (param3,Method_System_Linq_Enumerable_ToList_UserData___);
		    *(undefined4 *)(param1 + 0x1c) = uVar1;
		    Gameplay_Boss_Controller_BossTeamEditViewMediator__ResultCallback(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600498D RID: 18829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600498D")]
		[Address(RVA = "0x97FF", Offset = "0x97FF", VA = "0x97FF")]
		private void ResultCallback(long operationIndex, params UserData[] data)
		{
		/* --- GHIDRA: ResultCallback ---
		void Gameplay_Boss_Controller_BossTeamEditViewMediator__ResultCallback
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int param1_00;
		  
		  if (DAT_ram_00a57936 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Sorting_AbstractSortControlView_UserData__get_SelectedFilter__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_UserData___);
		    Mono_Security_ASN1__get_Item(&System_Func_UserData__UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_IEnumerableExt_SortGameData_UserData__UserData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_UserData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator___c__RenderPossibleAssistants_b__21_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo);
		    DAT_ram_00a57936 = '\x01';
		  }
		  iVar3 = param1[7];
		  if (*(int *)(iVar3 + 0xc) == 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter__SetItems(*(undefined4 *)(iVar3 + 0x2c),0)
		    ;
		    return;
		  }
		  if (*(int *)(Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo + 0x5c);
		  param1_00 = puVar4[3];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo);
		      puVar4 = *(undefined4 **)
		                (Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar4;
		    param1_00 = unnamed_function_1417(System_Func_UserData__UserData__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (param1_00,uVar2,
		               Method_Gameplay_Boss_Controller_BossTeamEditViewMediator___c__RenderPossibleAssistants_b__21_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Boss_Controller_BossTeamEditViewMediator___c_TypeInfo + 0x5c) + 0xc)
		         = param1_00;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = func_ii_7521(iVar3,param1_00,*(undefined4 *)(*(int *)(iVar1 + 0x30) + 0x28),
		                       Method_Core_Extensions_IEnumerableExt_SortGameData_UserData__UserData___);
		  uVar2 = System_Linq_Enumerable__Select_object__object_
		                    (uVar2,Method_System_Linq_Enumerable_ToList_UserData___);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamEditListAdapter__RemoveItemsFrom
		            (*(undefined4 *)(iVar3 + 0x2c),uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600498E RID: 18830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600498E")]
		[Address(RVA = "0x9800", Offset = "0x9800", VA = "0x9800")]
		private void RenderPossibleAssistants()
		{
		/* --- GHIDRA: RenderPossibleAssistants ---
		void Gameplay_Boss_Controller_BossTeamEditViewMediator__RenderPossibleAssistants
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57937 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossTeamEditView__Dispose__
		              );
		    DAT_ram_00a57937 = '\x01';
		  }
		  if (*(char *)(param1 + 0x24) == '\0') {
		    MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		              (param1,
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossTeamEditView__Dispose__
		              );
		    *(undefined1 *)(param1 + 0x24) = 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600498F RID: 18831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600498F")]
		[Address(RVA = "0x9801", Offset = "0x9801", VA = "0x9801", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x04002800 RID: 10240
		[Token(Token = "0x4002800")]
		[FieldOffset(Offset = "0x18")]
		private TeamData _temporaryTeamData;

		// Token: 0x04002801 RID: 10241
		[Token(Token = "0x4002801")]
		[FieldOffset(Offset = "0x1C")]
		private List<UserData> _possibleAssistantsUserData;

		// Token: 0x04002802 RID: 10242
		[Token(Token = "0x4002802")]
		[FieldOffset(Offset = "0x20")]
		private BossTeamEditViewMediator.ModifyTeamQueueData _modifyQueue;

		// Token: 0x04002803 RID: 10243
		[Token(Token = "0x4002803")]
		[FieldOffset(Offset = "0x24")]
		private bool _isDisposed;

		// Token: 0x02000BB5 RID: 2997
		[Token(Token = "0x2000BB5")]
		private class ModifyTeamQueueData : IEnumerator<ulong>, IEnumerator, IDisposable
		{
			// Token: 0x17000EDE RID: 3806
			// (get) Token: 0x06004990 RID: 18832 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
			// (set) Token: 0x06004991 RID: 18833 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EDE")]
			public BossTeamEditViewMediator.ModifyTeamQueueData.ModifyType CurrentOperation
			{
				[Token(Token = "0x6004990")]
				[Address(RVA = "0x9802", Offset = "0x9802", VA = "0x9802")]
				[CompilerGenerated]
				get
				{
					return (BossTeamEditViewMediator.ModifyTeamQueueData.ModifyType)0;
				}
				[Token(Token = "0x6004991")]
				[Address(RVA = "0x9803", Offset = "0x9803", VA = "0x9803")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06004992 RID: 18834 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
			[Token(Token = "0x6004992")]
			[Address(RVA = "0x9804", Offset = "0x9804", VA = "0x9804", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06004993 RID: 18835 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004993")]
			[Address(RVA = "0x9805", Offset = "0x9805", VA = "0x9805", Slot = "8")]
			public void Reset()
			{
			}

			// Token: 0x17000EDF RID: 3807
			// (get) Token: 0x06004994 RID: 18836 RVA: 0x0000D908 File Offset: 0x0000BB08
			[Token(Token = "0x17000EDF")]
			public ulong Current
			{
				[Token(Token = "0x6004994")]
				[Address(RVA = "0x9806", Offset = "0x9806", VA = "0x9806", Slot = "4")]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x17000EE0 RID: 3808
			// (get) Token: 0x06004995 RID: 18837 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000EE0")]
			private object Current
			{
				[Token(Token = "0x6004995")]
				[Address(RVA = "0x9807", Offset = "0x9807", VA = "0x9807", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x06004996 RID: 18838 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004996")]
			[Address(RVA = "0x9808", Offset = "0x9808", VA = "0x9808", Slot = "5")]
			public void Dispose()
			{
			}

			// Token: 0x06004997 RID: 18839 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004997")]
			[Address(RVA = "0x9809", Offset = "0x9809", VA = "0x9809")]
			public ModifyTeamQueueData()
			{
			}

			// Token: 0x04002804 RID: 10244
			[Token(Token = "0x4002804")]
			[FieldOffset(Offset = "0x8")]
			public List<ulong> UsersToAdd;

			// Token: 0x04002805 RID: 10245
			[Token(Token = "0x4002805")]
			[FieldOffset(Offset = "0xC")]
			public List<ulong> UsersToRemove;

			// Token: 0x04002807 RID: 10247
			[Token(Token = "0x4002807")]
			[FieldOffset(Offset = "0x18")]
			private ulong _current;

			// Token: 0x02000BB6 RID: 2998
			[Token(Token = "0x2000BB6")]
			public enum ModifyType
			{
				// Token: 0x04002809 RID: 10249
				[Token(Token = "0x4002809")]
				ADD = 1,
				// Token: 0x0400280A RID: 10250
				[Token(Token = "0x400280A")]
				REMOVE
			}
		}
	}
}
