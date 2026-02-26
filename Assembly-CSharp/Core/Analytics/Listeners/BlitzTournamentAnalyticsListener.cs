using System;
using Core.Events;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012C5 RID: 4805
	[Token(Token = "0x20012C5")]
	public class BlitzTournamentAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x06007230 RID: 29232 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001729")]
		protected override string Theme
		{
			[Token(Token = "0x6007230")]
			[Address(RVA = "0xBC39", Offset = "0xBC39", VA = "0xBC39", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007231 RID: 29233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007231")]
		[Address(RVA = "0xBC3A", Offset = "0xBC3A", VA = "0xBC3A", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_BlitzTournamentAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59588 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_BlitzTournamentScope_FinalCombatCompleteEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BaseEventBusEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BlitzTournamentScope_JoinedQueueEventArgs__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_BlitzTournamentAnalyticsListener_FinalCombatCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BlitzTournamentAnalyticsListener_JoinedQueueEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BlitzTournamentAnalyticsListener_LeftQueueEvent__);
		    DAT_ram_00a59588 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x34);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_BlitzTournamentScope_JoinedQueueEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BlitzTournamentAnalyticsListener_JoinedQueueEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BlitzTournamentScope_JoinedQueueEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BlitzTournamentScope_JoinedQueueEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_BlitzTournamentScope_JoinedQueueEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BlitzTournamentScope_JoinedQueueEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x34);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BlitzTournamentAnalyticsListener_LeftQueueEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x34);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417
		                    (System_Action_BlitzTournamentScope_FinalCombatCompleteEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BlitzTournamentAnalyticsListener_FinalCombatCompleteEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BlitzTournamentScope_FinalCombatCompleteEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,
		                       System_Action_BlitzTournamentScope_FinalCombatCompleteEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_BlitzTournamentScope_FinalCombatCompleteEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,
		                         System_Action_BlitzTournamentScope_FinalCombatCompleteEventArgs__TypeInfo);
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

		// Token: 0x06007232 RID: 29234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007232")]
		[Address(RVA = "0xBC3B", Offset = "0xBC3B", VA = "0xBC3B", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_BlitzTournamentAnalyticsListener__Deinit
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
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59589 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28361);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25193);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27813);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23180);
		    DAT_ram_00a59589 = '\x01';
		  }
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  local_4 = *(undefined4 *)(param2 + 0x10);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_27813,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_10 = *(undefined8 *)(param2 + 0x18);
		  uVar2 = func_ii_1081(DAT_ram_00a66968,&local_10);
		  func_ii_2946(param1_00,StringLiteral_28361,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_18 = *(undefined8 *)(param2 + 0x20);
		  uVar2 = func_ii_1081(DAT_ram_00a66968,&local_18);
		  func_ii_2946(param1_00,StringLiteral_25193,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_23180;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8102e5e3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102e5e3:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007233 RID: 29235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007233")]
		[Address(RVA = "0xBC3C", Offset = "0xBC3C", VA = "0xBC3C")]
		private void FinalCombatCompleteEvent(BlitzTournamentScope.FinalCombatCompleteEventArgs e)
		{
		/* --- GHIDRA: FinalCombatCompleteEvent ---
		void Core_Analytics_Listeners_BlitzTournamentAnalyticsListener__FinalCombatCompleteEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a5958a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25074);
		    DAT_ram_00a5958a = '\x01';
		  }
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  uVar2 = 0;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_25074;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8102e6fb;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102e6fb:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar1,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007234 RID: 29236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007234")]
		[Address(RVA = "0xBC3D", Offset = "0xBC3D", VA = "0xBC3D")]
		private void LeftQueueEvent(BaseEventBusEventArgs e)
		{
		/* --- GHIDRA: LeftQueueEvent ---
		void Core_Analytics_Listeners_BlitzTournamentAnalyticsListener__LeftQueueEvent
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
		  
		  if (DAT_ram_00a5958b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24936);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27813);
		    DAT_ram_00a5958b = '\x01';
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
		  local_4 = UnityEngine_UI_Collections_IndexedSet_object___System_Collections_IEnumerable_GetEnumerator
		                      (*(undefined4 *)(param2 + 0x10),0);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_27813,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar1 = 0;
		  Gameplay_Boss_Model_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Price
		            (0,param1_00,*(undefined4 *)(*(int *)(*(int *)(param2 + 0x10) + 8) + 0x10),
		             StringLiteral_26155,0);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_24936;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8102e881;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102e881:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007235 RID: 29237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007235")]
		[Address(RVA = "0xBC3E", Offset = "0xBC3E", VA = "0xBC3E")]
		private void JoinedQueueEvent(BlitzTournamentScope.JoinedQueueEventArgs e)
		{
		}

		// Token: 0x06007236 RID: 29238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007236")]
		[Address(RVA = "0xBC3F", Offset = "0xBC3F", VA = "0xBC3F")]
		public BlitzTournamentAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_BlitzTournamentAnalyticsListener___ctor
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5958c == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_20730);
		    DAT_ram_00a5958c = '\x01';
		  }
		  return StringLiteral_20730;
		}
		*/

		}

		// Token: 0x04003BD9 RID: 15321
		[Token(Token = "0x4003BD9")]
		private const string JOINED_QUEUE = "joined_queue";

		// Token: 0x04003BDA RID: 15322
		[Token(Token = "0x4003BDA")]
		private const string LEFT_QUEUE = "left_queue";

		// Token: 0x04003BDB RID: 15323
		[Token(Token = "0x4003BDB")]
		private const string FINAL_COMBAT_COMPLETE = "final_combat_complete";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_BlitzTournamentAnalyticsListener__get_Theme
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59587 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_BlitzTournamentScope_FinalCombatCompleteEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BaseEventBusEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BlitzTournamentScope_JoinedQueueEventArgs__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_BlitzTournamentAnalyticsListener_FinalCombatCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BlitzTournamentAnalyticsListener_JoinedQueueEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BlitzTournamentAnalyticsListener_LeftQueueEvent__);
		    DAT_ram_00a59587 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x34);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_BlitzTournamentScope_JoinedQueueEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BlitzTournamentAnalyticsListener_JoinedQueueEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BlitzTournamentScope_JoinedQueueEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BlitzTournamentScope_JoinedQueueEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_BlitzTournamentScope_JoinedQueueEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BlitzTournamentScope_JoinedQueueEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x34);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BlitzTournamentAnalyticsListener_LeftQueueEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x34);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417
		                    (System_Action_BlitzTournamentScope_FinalCombatCompleteEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BlitzTournamentAnalyticsListener_FinalCombatCompleteEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BlitzTournamentScope_FinalCombatCompleteEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,
		                       System_Action_BlitzTournamentScope_FinalCombatCompleteEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_BlitzTournamentScope_FinalCombatCompleteEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,
		                         System_Action_BlitzTournamentScope_FinalCombatCompleteEventArgs__TypeInfo);
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
