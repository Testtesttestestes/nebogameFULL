using System;
using System.Collections.Generic;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012CB RID: 4811
	[Token(Token = "0x20012CB")]
	public class CombatAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x06007260 RID: 29280 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700172E")]
		protected override string Theme
		{
			[Token(Token = "0x6007260")]
			[Address(RVA = "0xBC69", Offset = "0xBC69", VA = "0xBC69", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007261 RID: 29281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007261")]
		[Address(RVA = "0xBC6A", Offset = "0xBC6A", VA = "0xBC6A", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_CombatAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a595b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatScope_AttackMonsterEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_CombatScope_KickMonsterEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_CombatScope_CombatEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_CombatScope_CombatFinishedEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_CombatAnalyticsListener_AttackMonsterEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_CombatAnalyticsListener_CombatFinishedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_CombatAnalyticsListener_CombatStartedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_CombatAnalyticsListener_KickMonsterEvent__);
		    DAT_ram_00a595b4 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x2c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_CombatScope_AttackMonsterEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_CombatAnalyticsListener_AttackMonsterEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_CombatScope_AttackMonsterEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_CombatScope_AttackMonsterEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_CombatScope_AttackMonsterEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_CombatScope_AttackMonsterEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x2c);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_CombatScope_CombatEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_CombatAnalyticsListener_CombatStartedEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_CombatScope_CombatEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_CombatScope_CombatEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_CombatScope_CombatEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_CombatScope_CombatEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x2c);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_CombatScope_CombatFinishedEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_CombatAnalyticsListener_CombatFinishedEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_CombatScope_CombatFinishedEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_CombatScope_CombatFinishedEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_CombatScope_CombatFinishedEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_CombatScope_CombatFinishedEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x2c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_CombatScope_KickMonsterEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_CombatAnalyticsListener_KickMonsterEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_CombatScope_KickMonsterEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_CombatScope_KickMonsterEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_CombatScope_KickMonsterEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_CombatScope_KickMonsterEventArgs__TypeInfo);
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

		// Token: 0x06007262 RID: 29282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007262")]
		[Address(RVA = "0xBC6B", Offset = "0xBC6B", VA = "0xBC6B", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_CombatAnalyticsListener__Deinit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined8 local_10;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a595b5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24820);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25863);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21852);
		    DAT_ram_00a595b5 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_CombatAnalyticsListener__CombatStartedEvent
		                        (param1,param2,param1);
		  local_1 = *(undefined1 *)(param2 + 0x28);
		  uVar2 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  func_ii_2946(param1_00,StringLiteral_24820,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_10 = *(undefined8 *)(param2 + 0x20);
		  uVar2 = func_ii_1081(DAT_ram_00a66968,&local_10);
		  func_ii_2946(param1_00,StringLiteral_25863,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_21852;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8103393d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103393d:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007263 RID: 29283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007263")]
		[Address(RVA = "0xBC6C", Offset = "0xBC6C", VA = "0xBC6C")]
		private void CombatFinishedEvent(CombatScope.CombatFinishedEventArgs e)
		{
		/* --- GHIDRA: CombatFinishedEvent ---
		void Core_Analytics_Listeners_CombatAnalyticsListener__CombatFinishedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  int iVar6;
		  
		  if (DAT_ram_00a595b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21853);
		    DAT_ram_00a595b6 = '\x01';
		  }
		  param1_00 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar4 = Core_Analytics_Listeners_CombatAnalyticsListener__CombatStartedEvent(param1,param2,param1)
		  ;
		  uVar1 = StringLiteral_21853;
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x81033c5b;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81033c5b:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_00,uVar3,uVar1,uVar4,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007264 RID: 29284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007264")]
		[Address(RVA = "0xBC6D", Offset = "0xBC6D", VA = "0xBC6D")]
		private void CombatStartedEvent(CombatScope.CombatEventArgs e)
		{
		/* --- GHIDRA: CombatStartedEvent ---
		undefined4
		Core_Analytics_Listeners_CombatAnalyticsListener__CombatStartedEvent
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 local_14;
		  undefined1 local_d;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a595b7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Combat_ProtoRequestCombatCmd_Types_ArenaCombatTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_CombatTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25463);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21854);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25464);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25461);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25462);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19917);
		    DAT_ram_00a595b7 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_4 = *(undefined4 *)(param2 + 0x10);
		  local_8 = 0xffffffff;
		  local_c = Protocol_Combat_CombatTypes_TypeInfo;
		  uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  uVar1 = func_ii_7775(uVar1,0);
		  func_ii_2946(param1_00,StringLiteral_21854,uVar1,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  if (*(int *)(param2 + 0x14) != 0) {
		    local_8 = 0xffffffff;
		    local_c = Protocol_Combat_ProtoRequestCombatCmd_Types_ArenaCombatTypes_TypeInfo;
		    local_4 = *(undefined4 *)(*(int *)(param2 + 0x14) + 8);
		    uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    uVar1 = func_ii_7775(uVar1,0);
		    func_ii_2946(param1_00,StringLiteral_19917,uVar1,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  }
		  piVar3 = *(int **)(param2 + 0x18);
		  if (piVar3 != (int *)0x0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xe0) * 4))
		                      (piVar3,*(undefined4 *)(*piVar3 + 0xe4));
		    local_c = *(undefined4 *)(*(int *)(iVar2 + 8) + 0xc);
		    uVar1 = func_ii_1081(DAT_ram_00a66958,&local_c);
		    func_ii_2946(param1_00,StringLiteral_25462,uVar1,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    uVar1 = Gameplay_ArenaCombat_Model_ArenaCombatModel_AttackRequestedMonster__get_Monster
		                      (*(undefined4 *)(param2 + 0x18),0);
		    local_d = (undefined1)uVar1;
		    uVar1 = func_ii_1081(DAT_ram_00a66944,&local_d);
		    func_ii_2946(param1_00,StringLiteral_25461,uVar1,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    iVar2 = **(int **)(param2 + 0x18);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe0) * 4))
		                      (*(int **)(param2 + 0x18),*(undefined4 *)(iVar2 + 0xe4));
		    uVar1 = AssetContent_GameAssetViewRawImage__set_AssetId(*(undefined4 *)(iVar2 + 8),0);
		    func_ii_2946(param1_00,StringLiteral_25464,uVar1,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    iVar2 = **(int **)(param2 + 0x18);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe0) * 4))
		                      (*(int **)(param2 + 0x18),*(undefined4 *)(iVar2 + 0xe4));
		    local_14 = GAFInternal_Objects_GAFBakedObjectInternal__get_impl(uVar1,0);
		    uVar1 = func_ii_1081(DAT_ram_00a66958,&local_14);
		    func_ii_2946(param1_00,StringLiteral_25463,uVar1,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x06007265 RID: 29285 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007265")]
		[Address(RVA = "0xBC6E", Offset = "0xBC6E", VA = "0xBC6E")]
		private Dictionary<string, object> GetCombatCommonProperties(CombatScope.CombatEventArgs e)
		{
		/* --- GHIDRA: GetCombatCommonProperties ---
		void Core_Analytics_Listeners_CombatAnalyticsListener__GetCombatCommonProperties
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param2_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int iVar7;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a595b8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25463);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25464);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19990);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25461);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25462);
		    DAT_ram_00a595b8 = '\x01';
		  }
		  param2_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  piVar4 = *(int **)(param2 + 0xc);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1f8);
		        goto code_r0x81033d51;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x81033d51:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar7 = **(int **)(iVar5 + 0x14);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                    (*(int **)(iVar5 + 0x14),*(undefined4 *)(iVar7 + 0x104));
		  uVar6 = *(undefined4 *)(iVar5 + 0x28);
		  iVar5 = **(int **)(param2 + 0x10);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe0) * 4))
		                    (*(int **)(param2 + 0x10),*(undefined4 *)(iVar5 + 0xe4));
		  iVar5 = UnityEngine_TextEditingUtilities__set_cursorIndex(uVar3,0);
		  if ((iVar5 != 0) && (iVar5 = Core_Extensions_Dict_ResourceSetExt__GetDelta(iVar5,0), iVar5 == 0))
		  {
		    iVar5 = **(int **)(param2 + 0x10);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe0) * 4))
		                      (*(int **)(param2 + 0x10),*(undefined4 *)(iVar5 + 0xe4));
		    uVar3 = Gameplay_Accounts_Model_Data_BattleAccount__GetArenaLevelCost
		                      (uVar6,*(undefined4 *)(iVar5 + 8),0);
		    Gameplay_Boss_Model_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Price
		              (param1,param2_00,uVar3,StringLiteral_26155,0);
		  }
		  uVar3 = Gameplay_ArenaCombat_Model_ArenaCombatModel_AttackRequestedMonster__get_Monster
		                    (*(undefined4 *)(param2 + 0x10),0);
		  local_1 = (undefined1)uVar3;
		  uVar3 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  func_ii_2946(param2_00,StringLiteral_25461,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  iVar5 = **(int **)(param2 + 0x10);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe0) * 4))
		                    (*(int **)(param2 + 0x10),*(undefined4 *)(iVar5 + 0xe4));
		  local_8 = *(undefined4 *)(*(int *)(iVar5 + 8) + 0xc);
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_8);
		  func_ii_2946(param2_00,StringLiteral_25462,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  iVar5 = **(int **)(param2 + 0x10);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe0) * 4))
		                    (*(int **)(param2 + 0x10),*(undefined4 *)(iVar5 + 0xe4));
		  uVar3 = AssetContent_GameAssetViewRawImage__set_AssetId(*(undefined4 *)(iVar5 + 8),0);
		  func_ii_2946(param2_00,StringLiteral_25464,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  iVar5 = **(int **)(param2 + 0x10);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe0) * 4))
		                    (*(int **)(param2 + 0x10),*(undefined4 *)(iVar5 + 0xe4));
		  local_c = GAFInternal_Objects_GAFBakedObjectInternal__get_impl(uVar3,0);
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_c);
		  func_ii_2946(param2_00,StringLiteral_25463,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  piVar4 = (int *)param1[2];
		  uVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar3 = StringLiteral_19990;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81033f9c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81033f9c:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar4,uVar6,uVar3,param2_00,puVar2[1]);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06007266 RID: 29286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007266")]
		[Address(RVA = "0xBC6F", Offset = "0xBC6F", VA = "0xBC6F")]
		private void AttackMonsterEvent(CombatScope.AttackMonsterEventArgs e)
		{
		/* --- GHIDRA: AttackMonsterEvent ---
		void Core_Analytics_Listeners_CombatAnalyticsListener__AttackMonsterEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param2_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int iVar7;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a595b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25463);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25464);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25461);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25462);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24974);
		    DAT_ram_00a595b9 = '\x01';
		  }
		  param2_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  piVar4 = *(int **)(param2 + 0xc);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1f8);
		        goto code_r0x81034099;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x81034099:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar7 = **(int **)(iVar5 + 0x14);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                    (*(int **)(iVar5 + 0x14),*(undefined4 *)(iVar7 + 0x104));
		  uVar6 = *(undefined4 *)(iVar5 + 0x28);
		  iVar5 = System_Linq_Expressions_Interpreter_InterpretedFrame__GetDebugInfo
		                    (*(undefined4 *)(param2 + 0x10),0);
		  if ((iVar5 != 0) && (iVar5 = Core_Extensions_Dict_ResourceSetExt__GetDelta(iVar5,0), iVar5 == 0))
		  {
		    uVar6 = Gameplay_Accounts_Model_Data_BattleAccount__GetMonsterAttackCost
		                      (uVar6,*(undefined4 *)(*(int *)(param2 + 0x10) + 8),0);
		    Gameplay_Boss_Model_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Price
		              (param1,param2_00,uVar6,StringLiteral_26155,0);
		  }
		  local_1 = *(longlong *)(param2 + 0x18) == 0;
		  uVar6 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  func_ii_2946(param2_00,StringLiteral_25461,uVar6,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_8 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x10) + 8) + 0xc);
		  uVar6 = func_ii_1081(DAT_ram_00a66958,&local_8);
		  func_ii_2946(param2_00,StringLiteral_25462,uVar6,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar6 = AssetContent_GameAssetViewRawImage__set_AssetId
		                    (*(undefined4 *)(*(int *)(param2 + 0x10) + 8),0);
		  func_ii_2946(param2_00,StringLiteral_25464,uVar6,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_c = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x10) + 8) + 0x14);
		  uVar6 = func_ii_1081(DAT_ram_00a66958,&local_c);
		  func_ii_2946(param2_00,StringLiteral_25463,uVar6,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  piVar4 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar6 = StringLiteral_24974;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81034271;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81034271:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar4,uVar3,uVar6,param2_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007267 RID: 29287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007267")]
		[Address(RVA = "0xBC70", Offset = "0xBC70", VA = "0xBC70")]
		private void KickMonsterEvent(CombatScope.KickMonsterEventArgs e)
		{
		}

		// Token: 0x06007268 RID: 29288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007268")]
		[Address(RVA = "0xBC71", Offset = "0xBC71", VA = "0xBC71")]
		public CombatAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_CombatAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a595ba == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_22015);
		    DAT_ram_00a595ba = '\x01';
		  }
		  return StringLiteral_22015;
		}
		*/

		}

		// Token: 0x04003BF7 RID: 15351
		[Token(Token = "0x4003BF7")]
		public const string THEME = "combat";

		// Token: 0x04003BF8 RID: 15352
		[Token(Token = "0x4003BF8")]
		private const string ATTACK_MONSTER = "attack_monster";

		// Token: 0x04003BF9 RID: 15353
		[Token(Token = "0x4003BF9")]
		private const string KICK_MONSTER = "kick_monster";

		// Token: 0x04003BFA RID: 15354
		[Token(Token = "0x4003BFA")]
		public const string COMBAT_STARTED = "combat_started";

		// Token: 0x04003BFB RID: 15355
		[Token(Token = "0x4003BFB")]
		public const string COMBAT_FINISHED = "combat_finished";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_CombatAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a595b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatScope_AttackMonsterEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_CombatScope_KickMonsterEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_CombatScope_CombatEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_CombatScope_CombatFinishedEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_CombatAnalyticsListener_AttackMonsterEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_CombatAnalyticsListener_CombatFinishedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_CombatAnalyticsListener_CombatStartedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_CombatAnalyticsListener_KickMonsterEvent__);
		    DAT_ram_00a595b3 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x2c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_CombatScope_AttackMonsterEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_CombatAnalyticsListener_AttackMonsterEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_CombatScope_AttackMonsterEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_CombatScope_AttackMonsterEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_CombatScope_AttackMonsterEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_CombatScope_AttackMonsterEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x2c);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_CombatScope_CombatEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_CombatAnalyticsListener_CombatStartedEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_CombatScope_CombatEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_CombatScope_CombatEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_CombatScope_CombatEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_CombatScope_CombatEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x2c);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_CombatScope_CombatFinishedEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_CombatAnalyticsListener_CombatFinishedEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_CombatScope_CombatFinishedEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_CombatScope_CombatFinishedEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_CombatScope_CombatFinishedEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_CombatScope_CombatFinishedEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x2c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_CombatScope_KickMonsterEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_CombatAnalyticsListener_KickMonsterEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_CombatScope_KickMonsterEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_CombatScope_KickMonsterEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_CombatScope_KickMonsterEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_CombatScope_KickMonsterEventArgs__TypeInfo);
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
