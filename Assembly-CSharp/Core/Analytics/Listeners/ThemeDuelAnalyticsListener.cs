using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012E1 RID: 4833
	[Token(Token = "0x20012E1")]
	public class ThemeDuelAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x060072F7 RID: 29431 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001744")]
		protected override string Theme
		{
			[Token(Token = "0x60072F7")]
			[Address(RVA = "0xBD00", Offset = "0xBD00", VA = "0xBD00", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072F8 RID: 29432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072F8")]
		[Address(RVA = "0xBD01", Offset = "0xBD01", VA = "0xBD01", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_ThemeDuelAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59630 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ThemeDuelScope_BattleFinishedArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ThemeDuelScope_OpenWindowEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ThemeDuelScope_BattleBeginEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ThemeDuelAnalyticsListener_OnBattleBeginEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ThemeDuelAnalyticsListener_OnBattleFinishedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ThemeDuelAnalyticsListener_OnOpenWindowEvent__);
		    DAT_ram_00a59630 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x98);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_ThemeDuelScope_BattleBeginEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ThemeDuelAnalyticsListener_OnBattleBeginEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ThemeDuelScope_BattleBeginEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ThemeDuelScope_BattleBeginEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_ThemeDuelScope_BattleBeginEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ThemeDuelScope_BattleBeginEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x98);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_ThemeDuelScope_BattleFinishedArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ThemeDuelAnalyticsListener_OnBattleFinishedEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ThemeDuelScope_BattleFinishedArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ThemeDuelScope_BattleFinishedArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_ThemeDuelScope_BattleFinishedArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ThemeDuelScope_BattleFinishedArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x98);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_ThemeDuelScope_OpenWindowEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ThemeDuelAnalyticsListener_OnOpenWindowEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ThemeDuelScope_OpenWindowEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_ThemeDuelScope_OpenWindowEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_ThemeDuelScope_OpenWindowEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ThemeDuelScope_OpenWindowEventArgs__TypeInfo);
		    if (iVar4 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060072F9 RID: 29433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072F9")]
		[Address(RVA = "0xBD02", Offset = "0xBD02", VA = "0xBD02", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_ThemeDuelAnalyticsListener__Deinit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59631 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21978);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19944);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23036);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23033);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19801);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20462);
		    DAT_ram_00a59631 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_8 = *(undefined8 *)(param2 + 0x18);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_8);
		  func_ii_2946(param1_00,StringLiteral_19801,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_10 = *(undefined8 *)(param2 + 0x20);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_10);
		  func_ii_2946(param1_00,StringLiteral_20462,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_14 = *(undefined4 *)(param2 + 0x28);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_14);
		  func_ii_2946(param1_00,StringLiteral_19944,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_18 = *(undefined4 *)(param2 + 0x2c);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_18);
		  func_ii_2946(param1_00,StringLiteral_21978,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_20 = *(undefined8 *)(param2 + 0x10);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_20);
		  func_ii_2946(param1_00,StringLiteral_23033,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_23036;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8103f5d1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103f5d1:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072FA RID: 29434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072FA")]
		[Address(RVA = "0xBD03", Offset = "0xBD03", VA = "0xBD03")]
		private void OnBuyItemEvent(ThemeDuelScope.BuyItemEventArgs obj)
		{
		/* --- GHIDRA: OnBuyItemEvent ---
		void Core_Analytics_Listeners_ThemeDuelAnalyticsListener__OnBuyItemEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined8 local_18;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59632 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_WindowOpenReasonSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23272);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23040);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23033);
		    DAT_ram_00a59632 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_4 = *(undefined4 *)(param2 + 0x18);
		  local_8 = 0xffffffff;
		  local_c = UI_Windows_WindowOpenReasonSource_TypeInfo;
		  uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  func_ii_2946(param1_00,StringLiteral_23272,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_18 = *(undefined8 *)(param2 + 0x10);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_18);
		  func_ii_2946(param1_00,StringLiteral_23033,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_23040;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8103f755;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103f755:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072FB RID: 29435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072FB")]
		[Address(RVA = "0xBD04", Offset = "0xBD04", VA = "0xBD04")]
		private void OnOpenWindowEvent(ThemeDuelScope.OpenWindowEventArgs obj)
		{
		/* --- GHIDRA: OnOpenWindowEvent ---
		void Core_Analytics_Listeners_ThemeDuelAnalyticsListener__OnOpenWindowEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 *puVar5;
		  int param1_01;
		  int param1_02;
		  undefined4 uVar6;
		  int *param1_03;
		  int iVar7;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59633 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_int__int___int__int___);
		    Mono_Security_ASN1__get_Item(&System_Func_KeyValuePair_int__int___int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_ThemeDuelAnalyticsListener___c__OnBattleFinishedEvent_b__11_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_ThemeDuelAnalyticsListener___c__OnBattleFinishedEvent_b__11_1__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Listeners_ThemeDuelAnalyticsListener___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28361);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27448);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20486);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23032);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21858);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23033);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27445);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19801);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20462);
		    DAT_ram_00a59633 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_8 = *(undefined8 *)(param2 + 0x18);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_8);
		  func_ii_2946(param1_00,StringLiteral_19801,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_10 = *(undefined8 *)(param2 + 0x20);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_10);
		  func_ii_2946(param1_00,StringLiteral_20462,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar2 = *(undefined4 *)(param2 + 0x28);
		  if (*(int *)(Core_Analytics_Listeners_ThemeDuelAnalyticsListener___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Analytics_Listeners_ThemeDuelAnalyticsListener___c_TypeInfo);
		  }
		  uVar3 = StringLiteral_21858;
		  puVar5 = *(undefined4 **)(Core_Analytics_Listeners_ThemeDuelAnalyticsListener___c_TypeInfo + 0x5c)
		  ;
		  param1_01 = puVar5[1];
		  iVar7 = Core_Analytics_Listeners_ThemeDuelAnalyticsListener___c_TypeInfo;
		  if (param1_01 == 0) {
		    if (*(int *)(Core_Analytics_Listeners_ThemeDuelAnalyticsListener___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Analytics_Listeners_ThemeDuelAnalyticsListener___c_TypeInfo);
		      puVar5 = *(undefined4 **)
		                (Core_Analytics_Listeners_ThemeDuelAnalyticsListener___c_TypeInfo + 0x5c);
		    }
		    uVar6 = *puVar5;
		    param1_01 = unnamed_function_1417(System_Func_KeyValuePair_int__int___int__TypeInfo);
		    System_Data_Listeners_Func_object____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___Invoke
		              (param1_01,uVar6,
		               Method_Core_Analytics_Listeners_ThemeDuelAnalyticsListener___c__OnBattleFinishedEvent_b__11_0__
		               ,0);
		    iVar7 = Core_Analytics_Listeners_ThemeDuelAnalyticsListener___c_TypeInfo;
		    *(int *)(*(int *)(Core_Analytics_Listeners_ThemeDuelAnalyticsListener___c_TypeInfo + 0x5c) + 4)
		         = param1_01;
		  }
		  if (*(int *)(iVar7 + 0x74) == 0) {
		    func_ii_306000(iVar7);
		    iVar7 = Core_Analytics_Listeners_ThemeDuelAnalyticsListener___c_TypeInfo;
		  }
		  puVar5 = *(undefined4 **)(iVar7 + 0x5c);
		  param1_02 = puVar5[2];
		  if (param1_02 == 0) {
		    if (*(int *)(iVar7 + 0x74) == 0) {
		      func_ii_306000(iVar7);
		      puVar5 = *(undefined4 **)
		                (Core_Analytics_Listeners_ThemeDuelAnalyticsListener___c_TypeInfo + 0x5c);
		    }
		    uVar6 = *puVar5;
		    param1_02 = unnamed_function_1417(System_Func_KeyValuePair_int__int___int__TypeInfo);
		    System_Data_Listeners_Func_object____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___Invoke
		              (param1_02,uVar6,
		               Method_Core_Analytics_Listeners_ThemeDuelAnalyticsListener___c__OnBattleFinishedEvent_b__11_1__
		               ,0);
		    *(int *)(*(int *)(Core_Analytics_Listeners_ThemeDuelAnalyticsListener___c_TypeInfo + 0x5c) + 8)
		         = param1_02;
		  }
		  uVar1 = 0;
		  uVar2 = System_Linq_Enumerable__ToDictionary___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar2,param1_01,param1_02,
		                     Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_int__int___int__int___)
		  ;
		  func_ii_2946(param1_00,uVar3,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_14 = *(undefined4 *)(param2 + 0x2c);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_14);
		  func_ii_2946(param1_00,StringLiteral_20486,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_8 = *(undefined8 *)(param2 + 0x30);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_8);
		  func_ii_2946(param1_00,StringLiteral_27448,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_10 = *(undefined8 *)(param2 + 0x10);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_10);
		  func_ii_2946(param1_00,StringLiteral_23033,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_18 = *(undefined4 *)(param2 + 0x38);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_18);
		  func_ii_2946(param1_00,StringLiteral_27445,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_20 = *(undefined8 *)(param2 + 0x40);
		  uVar2 = func_ii_1081(DAT_ram_00a66968,&local_20);
		  func_ii_2946(param1_00,StringLiteral_28361,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_03 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_23032;
		  iVar7 = *param1_03;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd8);
		        goto code_r0x8103fb46;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_03,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103fb46:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_03,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072FC RID: 29436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072FC")]
		[Address(RVA = "0xBD05", Offset = "0xBD05", VA = "0xBD05")]
		private void OnBattleFinishedEvent(ThemeDuelScope.BattleFinishedArgs obj)
		{
		/* --- GHIDRA: OnBattleFinishedEvent ---
		void Core_Analytics_Listeners_ThemeDuelAnalyticsListener__OnBattleFinishedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined4 local_6c;
		  undefined8 local_68;
		  undefined8 local_60;
		  undefined8 local_58;
		  undefined8 local_50;
		  undefined4 local_44;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59634 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20458);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19800);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20460);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20486);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19798);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25863);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19797);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19796);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23033);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20455);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20454);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23031);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20456);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19799);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20462);
		    DAT_ram_00a59634 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_8 = *(undefined8 *)(param2 + 0x18);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_8);
		  func_ii_2946(param1_00,StringLiteral_20462,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_10 = *(undefined8 *)(param2 + 0x20);
		  uVar2 = func_ii_1081(DAT_ram_00a66968,&local_10);
		  func_ii_2946(param1_00,StringLiteral_25863,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_14 = *(undefined4 *)(param2 + 0x28);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_14);
		  func_ii_2946(param1_00,StringLiteral_20486,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_20 = *(undefined8 *)(param2 + 0x10);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_20);
		  func_ii_2946(param1_00,StringLiteral_23033,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_28 = *(undefined8 *)(param2 + 0x38);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_28);
		  func_ii_2946(param1_00,StringLiteral_19798,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_30 = *(undefined8 *)(param2 + 0x30);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_30);
		  func_ii_2946(param1_00,StringLiteral_19796,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_38 = *(undefined8 *)(param2 + 0x40);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_38);
		  func_ii_2946(param1_00,StringLiteral_19799,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_40 = *(undefined8 *)(param2 + 0x48);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_40);
		  func_ii_2946(param1_00,StringLiteral_19800,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_44 = *(undefined4 *)(param2 + 0x50);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_44);
		  func_ii_2946(param1_00,StringLiteral_19797,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_50 = *(undefined8 *)(param2 + 0x60);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_50);
		  func_ii_2946(param1_00,StringLiteral_20456,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_58 = *(undefined8 *)(param2 + 0x58);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_58);
		  func_ii_2946(param1_00,StringLiteral_20454,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_60 = *(undefined8 *)(param2 + 0x68);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_60);
		  func_ii_2946(param1_00,StringLiteral_20458,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_68 = *(undefined8 *)(param2 + 0x70);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_68);
		  func_ii_2946(param1_00,StringLiteral_20460,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_6c = *(undefined4 *)(param2 + 0x78);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_6c);
		  func_ii_2946(param1_00,StringLiteral_20455,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_23031;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8103ff89;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103ff89:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072FD RID: 29437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072FD")]
		[Address(RVA = "0xBD06", Offset = "0xBD06", VA = "0xBD06")]
		private void OnBattleBeginEvent(ThemeDuelScope.BattleBeginEventArgs obj)
		{
		}

		// Token: 0x060072FE RID: 29438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072FE")]
		[Address(RVA = "0xBD07", Offset = "0xBD07", VA = "0xBD07")]
		public ThemeDuelAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Analytics_Listeners_ThemeDuelAnalyticsListener___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59635 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Listeners_ThemeDuelAnalyticsListener___c_TypeInfo);
		    DAT_ram_00a59635 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Analytics_Listeners_ThemeDuelAnalyticsListener___c_TypeInfo);
		  **(undefined4 **)(Core_Analytics_Listeners_ThemeDuelAnalyticsListener___c_TypeInfo + 0x5c) = uVar1
		  ;
		  return;
		}
		*/

		}

		// Token: 0x04003C30 RID: 15408
		[Token(Token = "0x4003C30")]
		private const string EVENT_BATTLE_BEGIN = "event_battle_begin";

		// Token: 0x04003C31 RID: 15409
		[Token(Token = "0x4003C31")]
		private const string EVENT_BATTLE_FINISHED = "event_battle_finished";

		// Token: 0x04003C32 RID: 15410
		[Token(Token = "0x4003C32")]
		private const string EVENT_SHOP = "event_shop";

		// Token: 0x04003C33 RID: 15411
		[Token(Token = "0x4003C33")]
		private const string EVENT_RATING = "event_rating";

		// Token: 0x04003C34 RID: 15412
		[Token(Token = "0x4003C34")]
		private const string EVENT_WINDOW = "event_window";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_ThemeDuelAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5962f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ThemeDuelScope_BattleFinishedArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ThemeDuelScope_BuyItemEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ThemeDuelScope_OpenWindowEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ThemeDuelScope_BattleBeginEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ThemeDuelAnalyticsListener_OnBattleBeginEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ThemeDuelAnalyticsListener_OnBattleFinishedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ThemeDuelAnalyticsListener_OnBuyItemEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ThemeDuelAnalyticsListener_OnOpenWindowEvent__);
		    DAT_ram_00a5962f = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x98);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_ThemeDuelScope_BattleBeginEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ThemeDuelAnalyticsListener_OnBattleBeginEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ThemeDuelScope_BattleBeginEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ThemeDuelScope_BattleBeginEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_ThemeDuelScope_BattleBeginEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ThemeDuelScope_BattleBeginEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x98);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_ThemeDuelScope_BattleFinishedArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ThemeDuelAnalyticsListener_OnBattleFinishedEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ThemeDuelScope_BattleFinishedArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ThemeDuelScope_BattleFinishedArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_ThemeDuelScope_BattleFinishedArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ThemeDuelScope_BattleFinishedArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x98);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_ThemeDuelScope_OpenWindowEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ThemeDuelAnalyticsListener_OnOpenWindowEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ThemeDuelScope_OpenWindowEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ThemeDuelScope_OpenWindowEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_ThemeDuelScope_OpenWindowEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ThemeDuelScope_OpenWindowEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x98);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_ThemeDuelScope_BuyItemEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ThemeDuelAnalyticsListener_OnBuyItemEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ThemeDuelScope_BuyItemEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_ThemeDuelScope_BuyItemEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_ThemeDuelScope_BuyItemEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ThemeDuelScope_BuyItemEventArgs__TypeInfo);
		    if (iVar4 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
