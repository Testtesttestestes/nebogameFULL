using System;
using System.Collections.Generic;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View;
using Il2CppDummyDll;
using MVC;
using UI.Tabs;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BBB RID: 3003
	[Token(Token = "0x2000BBB")]
	public class BossWindowMediator : AbstractViewMediator<BossInstanceModel, BossInstanceEvents, BossInstanceController, BossWindow>
	{
		// Token: 0x060049AA RID: 18858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049AA")]
		[Address(RVA = "0x981C", Offset = "0x981C", VA = "0x981C")]
		public BossWindowMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_Controller_BossWindowMediator___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a6087f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossWindowMediator_CaptainInvitesChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossWindowMediator_MyTeamsInfoChangedEvent__);
		    DAT_ram_00a6087f = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x30);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Boss_Controller_BossWindowMediator_CaptainInvitesChangedEvent__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x30) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x30) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x34);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Boss_Controller_BossWindowMediator_MyTeamsInfoChangedEvent__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x34) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x34) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x30);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Boss_Controller_BossWindowMediator_CaptainInvitesChangedEvent__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x30) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x30) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x34);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Boss_Controller_BossWindowMediator_MyTeamsInfoChangedEvent__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x34) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x34) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000EE1 RID: 3809
		// (set) Token: 0x060049AB RID: 18859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EE1")]
		public override BossInstanceEvents Events
		{
			[Token(Token = "0x60049AB")]
			[Address(RVA = "0x981D", Offset = "0x981D", VA = "0x981D", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060049AC RID: 18860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049AC")]
		[Address(RVA = "0x981E", Offset = "0x981E", VA = "0x981E")]
		private void MyTeamsInfoChangedEvent()
		{
		/* --- GHIDRA: MyTeamsInfoChangedEvent ---
		void Gameplay_Boss_Controller_BossWindowMediator__MyTeamsInfoChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Boss_Controller_BossWindowMediator__SetupView(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060049AD RID: 18861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049AD")]
		[Address(RVA = "0x981F", Offset = "0x981F", VA = "0x981F")]
		private void CaptainInvitesChangedEvent()
		{
		/* --- GHIDRA: CaptainInvitesChangedEvent ---
		void Gameplay_Boss_Controller_BossWindowMediator__CaptainInvitesChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60880 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossWindow__set_View__
		              );
		    DAT_ram_00a60880 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a60881 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      Mono_Security_ASN1__get_Item
		                (&Method_Gameplay_Boss_Controller_BossWindowMediator_TabBarOnChangeEvent__);
		      DAT_ram_00a60881 = '\x01';
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar2 + 0x3c);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,Method_Gameplay_Boss_Controller_BossWindowMediator_TabBarOnChangeEvent__
		               ,0);
		    UI_Tabs_TabBar__add_ChangeEvent(param1_00,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Boss_Controller_BossWindowMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000EE2 RID: 3810
		// (set) Token: 0x060049AE RID: 18862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EE2")]
		public override BossWindow View
		{
			[Token(Token = "0x60049AE")]
			[Address(RVA = "0x9820", Offset = "0x9820", VA = "0x9820", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060049AF RID: 18863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049AF")]
		[Address(RVA = "0x9821", Offset = "0x9821", VA = "0x9821")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Boss_Controller_BossWindowMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  byte local_8;
		  
		  if (DAT_ram_00a60882 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossWindowMediator_TabBarOnChangeEvent__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__get_Value__);
		    DAT_ram_00a60882 = '\x01';
		  }
		  _local_8 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x3c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Gameplay_Boss_Controller_BossWindowMediator_TabBarOnChangeEvent__,0
		            );
		  UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x3c);
		  uVar2 = Gameplay_Boss_Controller_BossWindowMediator__TabBarOnChangeEvent(param1,&local_8,param1);
		  UI_Tabs_TabBar__HandleSelected(uVar3,uVar2,0);
		  Gameplay_Boss_Controller_BossWindowMediator__SetupView(param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar1 + 0x3c);
		  if (local_8 == 0) {
		    uVar3 = 0;
		  }
		  else {
		    uVar3 = System_Nullable_DefaultEventSystem_FocusBasedEventSequenceContext___get_HasValue
		                      (&local_8,Method_System_Nullable_int__get_Value__);
		  }
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards(uVar2,uVar3,0,0);
		  return;
		}
		*/

		}

		// Token: 0x060049B0 RID: 18864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049B0")]
		[Address(RVA = "0x9822", Offset = "0x9822", VA = "0x9822")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Boss_Controller_BossWindowMediator__SetupView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a60883 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_TabBarItemData___);
		    Mono_Security_ASN1__get_Item(&System_Func_TabBarItemData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossWindowMediator___c__ValidateTabCounters_b__9_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossWindowMediator___c__ValidateTabCounters_b__9_1__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossWindowMediator___c_TypeInfo);
		    DAT_ram_00a60883 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x40);
		  if (*(int *)(Gameplay_Boss_Controller_BossWindowMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Boss_Controller_BossWindowMediator___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Boss_Controller_BossWindowMediator___c_TypeInfo + 0x5c);
		  iVar1 = puVar3[1];
		  if (iVar1 == 0) {
		    if (*(int *)(Gameplay_Boss_Controller_BossWindowMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Boss_Controller_BossWindowMediator___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_Boss_Controller_BossWindowMediator___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar3;
		    iVar1 = unnamed_function_1417(System_Func_TabBarItemData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar1,uVar4,
		               Method_Gameplay_Boss_Controller_BossWindowMediator___c__ValidateTabCounters_b__9_0__,
		               0);
		    *(int *)(*(int *)(Gameplay_Boss_Controller_BossWindowMediator___c_TypeInfo + 0x5c) + 4) = iVar1;
		  }
		  iVar1 = System_Func_object__bool____ctor
		                    (uVar2,iVar1,Method_System_Linq_Enumerable_FirstOrDefault_TabBarItemData___);
		  if (iVar1 != 0) {
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_long__object___MoveNext
		                      (param1[2],0);
		    Core_Extensions_Dict_BossGroupDictExt__GetTitle(iVar1,uVar2,0);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x40);
		  if (*(int *)(Gameplay_Boss_Controller_BossWindowMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Boss_Controller_BossWindowMediator___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Boss_Controller_BossWindowMediator___c_TypeInfo + 0x5c);
		  iVar1 = puVar3[2];
		  if (iVar1 == 0) {
		    if (*(int *)(Gameplay_Boss_Controller_BossWindowMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Boss_Controller_BossWindowMediator___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_Boss_Controller_BossWindowMediator___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar3;
		    iVar1 = unnamed_function_1417(System_Func_TabBarItemData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar1,uVar4,
		               Method_Gameplay_Boss_Controller_BossWindowMediator___c__ValidateTabCounters_b__9_1__,
		               0);
		    *(int *)(*(int *)(Gameplay_Boss_Controller_BossWindowMediator___c_TypeInfo + 0x5c) + 8) = iVar1;
		  }
		  iVar1 = System_Func_object__bool____ctor
		                    (uVar2,iVar1,Method_System_Linq_Enumerable_FirstOrDefault_TabBarItemData___);
		  if (iVar1 != 0) {
		    uVar2 = Gameplay_Boss_Model_BossInstanceModel__get_IsIParticipated(param1[2],0);
		    Core_Extensions_Dict_BossGroupDictExt__GetTitle(iVar1,uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049B1")]
		[Address(RVA = "0x9823", Offset = "0x9823", VA = "0x9823")]
		private void ValidateTabCounters()
		{
		/* --- GHIDRA: ValidateTabCounters ---
		void Gameplay_Boss_Controller_BossWindowMediator__ValidateTabCounters(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a60884 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_BossWindowState__set_CurrentState__);
		    DAT_ram_00a60884 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x3c),0);
		  param2_00 = *(undefined4 *)(iVar1 + 0x14);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x40),param2_00,
		             Method_UI_MonoBehaviourWithStates_BossWindowState__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x060049B2 RID: 18866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049B2")]
		[Address(RVA = "0x9824", Offset = "0x9824", VA = "0x9824")]
		private void TabBarOnChangeEvent()
		{
		/* --- GHIDRA: TabBarOnChangeEvent ---
		int Gameplay_Boss_Controller_BossWindowMediator__TabBarOnChangeEvent
		              (int *param1,undefined8 *param2,undefined4 param3)
		
		{
		  int param1_00;
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  uint uVar6;
		  uint uVar7;
		  undefined8 local_10;
		  int local_8;
		  
		  if (DAT_ram_00a60885 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_BaseWindow_BossWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_View_BossWindowState_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BossWindowState__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BossWindowState___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossWindowState__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossWindowState__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_BossWindowState__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_TabBarItemData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int___ctor__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3629);
		    DAT_ram_00a60885 = '\x01';
		  }
		  *param2 = 0;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_BossWindowState__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_BossWindowState___ctor__);
		  iVar1 = Gameplay_Boss_Model_BossInstanceModel__get_IsEnded(param1[2],0);
		  iVar2 = Method_System_Collections_Generic_List_BossWindowState__Add__;
		  if (iVar1 == 0) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar6 = *(uint *)(param1_00 + 0xc);
		    if (uVar6 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar6 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar6 * 4 + 0x10) = 4;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,4,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  else {
		    iVar1 = Gameplay_Boss_Model_BossInstance__Dispose(param1[2],0);
		    iVar2 = Method_System_Collections_Generic_List_BossWindowState__Add__;
		    if (iVar1 != 0) {
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar7 = *(uint *)(param1_00 + 0xc);
		      iVar1 = *(int *)(param1_00 + 8);
		      uVar6 = *(uint *)(iVar1 + 0xc);
		      if (uVar7 < uVar6) {
		        *(uint *)(param1_00 + 0xc) = uVar7 + 1;
		        *(undefined4 *)(iVar1 + uVar7 * 4 + 0x10) = 1;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		        iVar1 = *(int *)(param1_00 + 8);
		        uVar6 = *(uint *)(iVar1 + 0xc);
		        iVar2 = Method_System_Collections_Generic_List_BossWindowState__Add__;
		      }
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar7 = *(uint *)(param1_00 + 0xc);
		      if (uVar7 < uVar6) {
		        *(uint *)(param1_00 + 0xc) = uVar7 + 1;
		        *(undefined4 *)(iVar1 + uVar7 * 4 + 0x10) = 2;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,2,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		      }
		    }
		    iVar2 = Method_System_Collections_Generic_List_BossWindowState__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar6 = *(uint *)(param1_00 + 0xc);
		    if (uVar6 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar6 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar6 * 4 + 0x10) = 5;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,5,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar2 = Method_System_Collections_Generic_List_BossWindowState__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar7 = *(uint *)(param1_00 + 0xc);
		  iVar1 = *(int *)(param1_00 + 8);
		  uVar6 = *(uint *)(iVar1 + 0xc);
		  if (uVar7 < uVar6) {
		    *(uint *)(param1_00 + 0xc) = uVar7 + 1;
		    *(undefined4 *)(iVar1 + uVar7 * 4 + 0x10) = 3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		    iVar1 = *(int *)(param1_00 + 8);
		    uVar6 = *(uint *)(iVar1 + 0xc);
		    iVar2 = Method_System_Collections_Generic_List_BossWindowState__Add__;
		  }
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar7 = *(uint *)(param1_00 + 0xc);
		  if (uVar7 < uVar6) {
		    *(uint *)(param1_00 + 0xc) = uVar7 + 1;
		    *(undefined4 *)(iVar1 + uVar7 * 4 + 0x10) = 6;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,6,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		    iVar1 = *(int *)(param1_00 + 8);
		    uVar6 = *(uint *)(iVar1 + 0xc);
		    iVar2 = Method_System_Collections_Generic_List_BossWindowState__Add__;
		  }
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar7 = *(uint *)(param1_00 + 0xc);
		  if (uVar7 < uVar6) {
		    *(uint *)(param1_00 + 0xc) = uVar7 + 1;
		    *(undefined4 *)(iVar1 + uVar7 * 4 + 0x10) = 7;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,7,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_TabBarItemData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_TabBarItemData___ctor__);
		  if (0 < *(int *)(param1_00 + 0xc)) {
		    iVar1 = 0;
		    do {
		      iVar3 = System_Linq_Enumerable__ToList_object_
		                        (param1_00,iVar1,
		                         Method_System_Collections_Generic_List_BossWindowState__get_Item__);
		      uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar5 = func_ii_8093(uVar4,Method_UI_Windows_BaseWindow_BossWindowArgs__get_WindowArgs__);
		      if (iVar3 == *(int *)(iVar5 + 0x1c)) {
		        local_10 = 0;
		        System_Data_SqlTypes_SqlInt32___ctor(&local_10,iVar1,Method_System_Nullable_int___ctor__);
		        *param2 = local_10;
		      }
		      iVar5 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		      *(int *)(iVar5 + 0x14) = iVar3;
		      local_10 = CONCAT44(0xffffffff,Gameplay_Boss_View_BossWindowState_TypeInfo);
		      local_8 = iVar3;
		      uVar4 = Spine_SkeletonJson__GetFloat(&local_10,0);
		      uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_3629,uVar4,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar4,1,0,1,0,0,0,0);
		      *(undefined4 *)(iVar5 + 0x10) = uVar4;
		      iVar3 = Method_System_Collections_Generic_List_TabBarItemData__Add__;
		      *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		      uVar6 = *(uint *)(iVar2 + 0xc);
		      if (uVar6 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		        *(uint *)(iVar2 + 0xc) = uVar6 + 1;
		        *(int *)(*(int *)(iVar2 + 8) + uVar6 * 4 + 0x10) = iVar5;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (iVar2,iVar5,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(param1_00 + 0xc));
		  }
		  return iVar2;
		}
		*/

		}

		// Token: 0x060049B3 RID: 18867 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60049B3")]
		[Address(RVA = "0x9825", Offset = "0x9825", VA = "0x9825")]
		private List<TabBarItemData> GetTabBarData(out int? indexOfDefaultTab)
		{
		/* --- GHIDRA: GetTabBarData ---
		void Gameplay_Boss_Controller_BossWindowMediator__GetTabBarData(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60886 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossWindowMediator___c_TypeInfo);
		    DAT_ram_00a60886 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Boss_Controller_BossWindowMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Boss_Controller_BossWindowMediator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return null;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Boss_Controller_BossWindowMediator__set_View(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a60881 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossWindowMediator_TabBarOnChangeEvent__);
		    DAT_ram_00a60881 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(iVar1 + 0x3c);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Boss_Controller_BossWindowMediator_TabBarOnChangeEvent__,0);
		  UI_Tabs_TabBar__add_ChangeEvent(param1_01,param1_00,0);
		  return;
		}
		*/

}
