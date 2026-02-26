using System;
using System.Collections.Generic;
using Core.Events.Scopes;
using Gameplay.Boss.Model;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012C6 RID: 4806
	[Token(Token = "0x20012C6")]
	public class BossAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x06007237 RID: 29239 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700172A")]
		protected override string Theme
		{
			[Token(Token = "0x6007237")]
			[Address(RVA = "0xBC40", Offset = "0xBC40", VA = "0xBC40", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007238 RID: 29240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007238")]
		[Address(RVA = "0xBC41", Offset = "0xBC41", VA = "0xBC41", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_BossAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5958e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossScope_MinionEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BossScope_InviteEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BossScope_AttackBossEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BossAnalyticsListener_AcceptInviteEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BossAnalyticsListener_AttackBossEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BossAnalyticsListener_MinionAttackEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BossAnalyticsListener_MinionKickedEvent__);
		    DAT_ram_00a5958e = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x38);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_BossScope_AttackBossEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_BossAnalyticsListener_AttackBossEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BossScope_AttackBossEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BossScope_AttackBossEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_BossScope_AttackBossEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BossScope_AttackBossEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x38);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_BossScope_MinionEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_BossAnalyticsListener_MinionAttackEvent__,
		             0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BossScope_MinionEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BossScope_MinionEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_BossScope_MinionEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BossScope_MinionEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x38);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_BossScope_MinionEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_BossAnalyticsListener_MinionKickedEvent__,
		             0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BossScope_MinionEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BossScope_MinionEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_BossScope_MinionEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BossScope_MinionEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x38);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_BossScope_InviteEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_BossAnalyticsListener_AcceptInviteEvent__,
		             0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BossScope_InviteEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_BossScope_InviteEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_BossScope_InviteEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BossScope_InviteEventArgs__TypeInfo);
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

		// Token: 0x06007239 RID: 29241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007239")]
		[Address(RVA = "0xBC42", Offset = "0xBC42", VA = "0xBC42", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_BossAnalyticsListener__Deinit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5958f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19669);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21057);
		    DAT_ram_00a5958f = '\x01';
		  }
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  uVar1 = 0;
		  Core_Analytics_Listeners_BossAnalyticsListener__AcceptInviteEvent
		            (0,param1_00,*(undefined4 *)(param2 + 0x10),0);
		  local_8 = *(undefined8 *)(param2 + 0x18);
		  uVar2 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  func_ii_2946(param1_00,StringLiteral_21057,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_19669;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8102ef9e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102ef9e:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600723A RID: 29242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600723A")]
		[Address(RVA = "0xBC43", Offset = "0xBC43", VA = "0xBC43")]
		private void AcceptInviteEvent(BossScope.InviteEventArgs e)
		{
		/* --- GHIDRA: AcceptInviteEvent ---
		void Core_Analytics_Listeners_BossAnalyticsListener__AcceptInviteEvent
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59590 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20735);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20734);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20737);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20732);
		    DAT_ram_00a59590 = '\x01';
		  }
		  if (param3 != 0) {
		    local_8 = Gameplay_Boss_Model_BossInstanceModel__set_MyInvites(param3,0);
		    uVar1 = func_ii_1081(DAT_ram_00a66964,&local_8);
		    func_ii_2946(param2,StringLiteral_20732,uVar1,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    local_c = *(undefined4 *)(*(int *)(*(int *)(param3 + 0x30) + 0x14) + 0xc);
		    uVar1 = func_ii_1081(DAT_ram_00a66958,&local_c);
		    func_ii_2946(param2,StringLiteral_20734,uVar1,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    uVar1 = AssetContent_GameAssetViewRawImage__set_AssetId
		                      (*(undefined4 *)(*(int *)(param3 + 0x30) + 0x14),0);
		    func_ii_2946(param2,StringLiteral_20735,uVar1,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    local_10 = *(undefined4 *)(*(int *)(*(int *)(param3 + 0x30) + 0xc) + 0xc);
		    uVar1 = func_ii_1081(DAT_ram_00a66954,&local_10);
		    func_ii_2946(param2,StringLiteral_20737,uVar1,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600723B RID: 29243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600723B")]
		[Address(RVA = "0xBC44", Offset = "0xBC44", VA = "0xBC44")]
		private void AppendBaseBossProperties(Dictionary<string, object> properties, BossInstanceModel model)
		{
		/* --- GHIDRA: AppendBaseBossProperties ---
		void Core_Analytics_Listeners_BossAnalyticsListener__AppendBaseBossProperties
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59591 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25423);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25421);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25422);
		    DAT_ram_00a59591 = '\x01';
		  }
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  uVar1 = 0;
		  Core_Analytics_Listeners_BossAnalyticsListener__AcceptInviteEvent
		            (0,param1_00,*(undefined4 *)(param2 + 0x10),0);
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x14) + 8) + 0xc);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_25421,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar2 = AssetContent_GameAssetViewRawImage__set_AssetId
		                    (*(undefined4 *)(*(int *)(param2 + 0x14) + 8),0);
		  func_ii_2946(param1_00,StringLiteral_25422,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  piVar5 = *(int **)(param2 + 0xc);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x1f8);
		        goto code_r0x8102f255;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x8102f255:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  iVar7 = **(int **)(iVar6 + 0x14);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                    (*(int **)(iVar6 + 0x14),*(undefined4 *)(iVar7 + 0x104));
		  uVar2 = *(undefined4 *)(iVar6 + 0x28);
		  iVar6 = System_Linq_Expressions_Interpreter_InterpretedFrame__GetDebugInfo
		                    (*(undefined4 *)(param2 + 0x14),0);
		  if ((iVar6 != 0) && (iVar7 = Core_Extensions_Dict_ResourceSetExt__GetDelta(iVar6,0), iVar7 == 0))
		  {
		    uVar2 = Gameplay_Accounts_Model_Data_BattleAccount__GetMonsterAttackCost
		                      (uVar2,*(undefined4 *)(*(int *)(param2 + 0x14) + 8),0);
		    Gameplay_Boss_Model_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Price
		              (iVar6,param1_00,uVar2,StringLiteral_26155,iVar6);
		  }
		  piVar5 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_25423;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x8102f35c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102f35c:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar5,uVar4,uVar2,param1_00,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600723C RID: 29244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600723C")]
		[Address(RVA = "0xBC45", Offset = "0xBC45", VA = "0xBC45")]
		private void MinionKickedEvent(BossScope.MinionEventArgs e)
		{
		/* --- GHIDRA: MinionKickedEvent ---
		void Core_Analytics_Listeners_BossAnalyticsListener__MinionKickedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59592 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25420);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25421);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25422);
		    DAT_ram_00a59592 = '\x01';
		  }
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  uVar1 = 0;
		  Core_Analytics_Listeners_BossAnalyticsListener__AcceptInviteEvent
		            (0,param1_00,*(undefined4 *)(param2 + 0x10),0);
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x14) + 8) + 0xc);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_25421,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar2 = AssetContent_GameAssetViewRawImage__set_AssetId
		                    (*(undefined4 *)(*(int *)(param2 + 0x14) + 8),0);
		  func_ii_2946(param1_00,StringLiteral_25422,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_25420;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8102f504;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102f504:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600723D RID: 29245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600723D")]
		[Address(RVA = "0xBC46", Offset = "0xBC46", VA = "0xBC46")]
		private void MinionAttackEvent(BossScope.MinionEventArgs e)
		{
		/* --- GHIDRA: MinionAttackEvent ---
		void Core_Analytics_Listeners_BossAnalyticsListener__MinionAttackEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  uint *puVar6;
		  longlong lVar7;
		  int param3_00;
		  int iVar8;
		  uint uVar9;
		  int local_24;
		  undefined1 *puStack_20;
		  undefined8 local_1c;
		  float4 local_14;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59593 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossInfo_BossAttackOption__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossInfo_BossAttackOption__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossInfo_BossAttackOption__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInfo_BossAttackOption__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamData_TeamAssistantData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20731);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19991);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19970);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19992);
		    DAT_ram_00a59593 = '\x01';
		  }
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  Core_Analytics_Listeners_BossAnalyticsListener__AcceptInviteEvent
		            (0,param1_00,*(undefined4 *)(param2 + 0x10),0);
		  uVar4 = StringLiteral_19970;
		  iVar8 = *(int *)(*(int *)(param2 + 0x10) + 0x3c);
		  if (iVar8 == 0) {
		    local_14 = -NAN;
		  }
		  else {
		    local_14 = *(float4 *)(*(int *)(iVar8 + 0x14) + 0xc);
		  }
		  uVar1 = func_ii_1081(DAT_ram_00a66954,&local_14);
		  func_ii_2946(param1_00,uVar4,uVar1,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_24,*(undefined4 *)(*(int *)(*(int *)(param2 + 0x10) + 0x30) + 0x28),
		             Method_System_Collections_Generic_List_BossInfo_BossAttackOption__GetEnumerator__);
		  local_8 = local_1c;
		  local_24 = 0;
		  puStack_20 = local_10;
		code_r0x8102f699:
		  DAT_ram_009d3e38 = 0;
		  iVar2 = import::env::invoke_iii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                     Method_System_Collections_Generic_List_Enumerator_BossInfo_BossAttackOption__MoveNext__
		                    );
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x8102f996;
		  }
		  if (iVar2 == 0) goto code_r0x8102f9ec;
		  DAT_ram_009d3e38 = 0;
		  iVar2 = local_8._4_4_;
		  lVar7 = unnamed_function_184054
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x334,local_8._4_4_,0);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 != 1) {
		    if (lVar7 == *(longlong *)(param2 + 0x18)) {
		      param3_00 = 0;
		      iVar8 = *(int *)(iVar2 + 0xc);
		      if (0 < *(int *)(iVar8 + 0xc)) {
		        do {
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22a,iVar8,param3_00
		                             ,
		                             Method_System_Collections_Generic_List_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Item__
		                            );
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x8102f996;
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar3 = UnityEngine_UI_Collections_IndexedSet_object___System_Collections_IEnumerable_GetEnumerator
		                            (uVar4,0);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x8102f996;
		          }
		          if (iVar3 == *(int *)(param2 + 0x20)) {
		            DAT_ram_009d3e38 = 0;
		            uVar4 = com_unity3d_mediation_LevelPlayBannerAd___ctor(uVar4,0);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x337,param3_00,param1_00
		                         ,uVar4,StringLiteral_26155,param3_00);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                local_14 = (float4)CONCAT31(local_14._1_3_,1 < *(int *)(*(int *)(iVar2 + 0xc) + 0xc)
		                                           );
		                uVar4 = import::env::invoke_iii
		                                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,
		                                   DAT_ram_00a66944,&local_14);
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_viiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x84,param1_00,
		                             StringLiteral_19992,uVar4,
		                             Method_System_Collections_Generic_Dictionary_string__object__set_Item__
		                            );
		                  if (DAT_ram_009d3e38 != 1) {
		                    iVar8 = *(int *)(*(int *)(iVar2 + 0xc) + 0xc);
		                    if (iVar8 < 2) break;
		                    DAT_ram_009d3e38 = 0;
		                    local_14 = (float4)((float)(param3_00 + 1) / (float)iVar8);
		                    uVar4 = import::env::invoke_iii
		                                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,
		                                       DAT_ram_00a6696c,&local_14);
		                    if (DAT_ram_009d3e38 != 1) {
		                      DAT_ram_009d3e38 = 0;
		                      import::env::invoke_viiii
		                                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x84,param1_00,
		                                 StringLiteral_19991,uVar4,
		                                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__
		                                );
		                      if (DAT_ram_009d3e38 != 1) break;
		                    }
		                    DAT_ram_009d3e38 = 0;
		                    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                    goto code_r0x8102f996;
		                  }
		                }
		                DAT_ram_009d3e38 = 0;
		                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x8102f996;
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x8102f996;
		          }
		          param3_00 = param3_00 + 1;
		          iVar8 = *(int *)(iVar2 + 0xc);
		        } while (param3_00 < *(int *)(iVar8 + 0xc));
		      }
		    }
		    goto code_r0x8102f699;
		  }
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8102f996:
		  iVar8 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar2) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar2 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_24 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x8102f9ec:
		      DAT_ram_009d3e38 = 0;
		      piVar5 = (int *)param1[2];
		      uVar9 = 0;
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xec));
		      uVar4 = StringLiteral_20731;
		      iVar8 = *piVar5;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        do {
		          if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		              *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		            puVar6 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 + iVar8 + 0xd8);
		            goto code_r0x8102fab9;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		      }
		      puVar6 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102fab9:
		      (**(code **)((ulonglong)*puVar6 * 4))(piVar5,uVar1,uVar4,param1_00,puVar6[1]);
		      return;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x338,&local_24);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 != 1) {
		    import::env::__resumeException(uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600723E RID: 29246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600723E")]
		[Address(RVA = "0xBC47", Offset = "0xBC47", VA = "0xBC47")]
		private void AttackBossEvent(BossScope.AttackBossEventArgs e)
		{
		/* --- GHIDRA: AttackBossEvent ---
		void Core_Analytics_Listeners_BossAnalyticsListener__AttackBossEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Core_Analytics_Listeners_AbstractAnalyticsListener__GetResourceAnalyticsName(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600723F RID: 29247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600723F")]
		[Address(RVA = "0xBC48", Offset = "0xBC48", VA = "0xBC48")]
		public BossAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_BossAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59595 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_21124);
		    DAT_ram_00a59595 = '\x01';
		  }
		  return StringLiteral_21124;
		}
		*/

		}

		// Token: 0x04003BDC RID: 15324
		[Token(Token = "0x4003BDC")]
		private const string ATTACK_BOSS = "boss_attack";

		// Token: 0x04003BDD RID: 15325
		[Token(Token = "0x4003BDD")]
		private const string MINION_ATTACK = "minion_attack";

		// Token: 0x04003BDE RID: 15326
		[Token(Token = "0x4003BDE")]
		private const string MINION_PAYOFF = "minion_payoff";

		// Token: 0x04003BDF RID: 15327
		[Token(Token = "0x4003BDF")]
		private const string ACCEPT_INVITE = "accept_invite";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_BossAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5958d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossScope_MinionEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BossScope_InviteEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BossScope_AttackBossEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BossAnalyticsListener_AcceptInviteEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BossAnalyticsListener_AttackBossEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BossAnalyticsListener_MinionAttackEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BossAnalyticsListener_MinionKickedEvent__);
		    DAT_ram_00a5958d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x38);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_BossScope_AttackBossEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_BossAnalyticsListener_AttackBossEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BossScope_AttackBossEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BossScope_AttackBossEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_BossScope_AttackBossEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BossScope_AttackBossEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x38);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_BossScope_MinionEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_BossAnalyticsListener_MinionAttackEvent__,
		             0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BossScope_MinionEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BossScope_MinionEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_BossScope_MinionEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BossScope_MinionEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x38);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_BossScope_MinionEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_BossAnalyticsListener_MinionKickedEvent__,
		             0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BossScope_MinionEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BossScope_MinionEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_BossScope_MinionEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BossScope_MinionEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x38);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_BossScope_InviteEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_BossAnalyticsListener_AcceptInviteEvent__,
		             0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BossScope_InviteEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_BossScope_InviteEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_BossScope_InviteEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BossScope_InviteEventArgs__TypeInfo);
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
