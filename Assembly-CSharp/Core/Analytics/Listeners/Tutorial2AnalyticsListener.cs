using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012E4 RID: 4836
	[Token(Token = "0x20012E4")]
	public class Tutorial2AnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x0600730A RID: 29450 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001746")]
		protected override string Theme
		{
			[Token(Token = "0x600730A")]
			[Address(RVA = "0xBD13", Offset = "0xBD13", VA = "0xBD13", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600730B RID: 29451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600730B")]
		[Address(RVA = "0xBD14", Offset = "0xBD14", VA = "0xBD14", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_Tutorial2AnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59640 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatScope_UseSpellArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_CombatScope_ComboEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_Tutorial2AnalyticsListener_ComboEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_Tutorial2AnalyticsListener_TutorialStepFinishEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_Tutorial2AnalyticsListener_TutorialStepStartEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_Tutorial2AnalyticsListener_UseElixirEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_Tutorial2AnalyticsListener_UseSpellEvent__);
		    DAT_ram_00a59640 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x10);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_Tutorial2AnalyticsListener_TutorialStepStartEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x10);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_Tutorial2AnalyticsListener_TutorialStepFinishEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo);
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
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_CombatScope_ComboEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_Tutorial2AnalyticsListener_ComboEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_CombatScope_ComboEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_CombatScope_ComboEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar2 = System_Action_CombatScope_ComboEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_CombatScope_ComboEventArgs__TypeInfo);
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
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_CombatScope_UseSpellArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_Tutorial2AnalyticsListener_UseSpellEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_CombatScope_UseSpellArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_CombatScope_UseSpellArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x1c) = iVar3;
		    uVar2 = System_Action_CombatScope_UseSpellArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_CombatScope_UseSpellArgs__TypeInfo);
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
		  uVar5 = *(undefined4 *)(iVar4 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_CombatScope_UseSpellArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_Tutorial2AnalyticsListener_UseElixirEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_CombatScope_UseSpellArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x20) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_CombatScope_UseSpellArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x20) = iVar3;
		    uVar2 = System_Action_CombatScope_UseSpellArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_CombatScope_UseSpellArgs__TypeInfo);
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

		// Token: 0x0600730C RID: 29452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600730C")]
		[Address(RVA = "0xBD15", Offset = "0xBD15", VA = "0xBD15", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_Tutorial2AnalyticsListener__Deinit
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
		  
		  if (DAT_ram_00a59641 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24497);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28163);
		    DAT_ram_00a59641 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_4 = *(undefined4 *)(param2 + 0x10);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_24497,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_28163;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x810410ad;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810410ad:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600730D RID: 29453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600730D")]
		[Address(RVA = "0xBD16", Offset = "0xBD16", VA = "0xBD16")]
		private void UseElixirEvent(CombatScope.UseSpellArgs e)
		{
		/* --- GHIDRA: UseElixirEvent ---
		void Core_Analytics_Listeners_Tutorial2AnalyticsListener__UseElixirEvent
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
		  
		  if (DAT_ram_00a59642 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28164);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24497);
		    DAT_ram_00a59642 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_4 = *(undefined4 *)(param2 + 0x10);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_24497,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_28164;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x810411de;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810411de:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600730E RID: 29454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600730E")]
		[Address(RVA = "0xBD17", Offset = "0xBD17", VA = "0xBD17")]
		private void UseSpellEvent(CombatScope.UseSpellArgs e)
		{
		/* --- GHIDRA: UseSpellEvent ---
		void Core_Analytics_Listeners_Tutorial2AnalyticsListener__UseSpellEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined1 local_11;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59643 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_StonesTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25681);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24815);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27456);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21851);
		    DAT_ram_00a59643 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_4 = *(undefined4 *)(param2 + 0x10);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  func_ii_2946(param1_00,StringLiteral_25681,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_8 = *(undefined4 *)(param2 + 0x14);
		  local_c = 0xffffffff;
		  local_10 = Protocol_Combat_StonesTypes_TypeInfo;
		  uVar2 = Spine_SkeletonJson__GetFloat(&local_10,0);
		  func_ii_2946(param1_00,StringLiteral_27456,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_11 = *(undefined1 *)(param2 + 0x18);
		  uVar2 = func_ii_1081(DAT_ram_00a66944,&local_11);
		  func_ii_2946(param1_00,StringLiteral_24815,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_21851;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8104139e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8104139e:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600730F RID: 29455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600730F")]
		[Address(RVA = "0xBD18", Offset = "0xBD18", VA = "0xBD18")]
		private void ComboEvent(CombatScope.ComboEventArgs e)
		{
		/* --- GHIDRA: ComboEvent ---
		void Core_Analytics_Listeners_Tutorial2AnalyticsListener__ComboEvent
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
		  
		  if (DAT_ram_00a59644 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27443);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27382);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27440);
		    DAT_ram_00a59644 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  func_ii_2946(param1_00,StringLiteral_27382,*(undefined4 *)(param2 + 0x10),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_4 = *(undefined4 *)(param2 + 0x14);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  func_ii_2946(param1_00,StringLiteral_27440,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_27443;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x810414f0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810414f0:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007310 RID: 29456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007310")]
		[Address(RVA = "0xBD19", Offset = "0xBD19", VA = "0xBD19")]
		private void TutorialStepFinishEvent(Tutorial2Scope.Tutorial2StepEventArgs e)
		{
		/* --- GHIDRA: TutorialStepFinishEvent ---
		void Core_Analytics_Listeners_Tutorial2AnalyticsListener__TutorialStepFinishEvent
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
		  
		  if (DAT_ram_00a59645 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27382);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27440);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27447);
		    DAT_ram_00a59645 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  func_ii_2946(param1_00,StringLiteral_27382,*(undefined4 *)(param2 + 0x10),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_4 = *(undefined4 *)(param2 + 0x14);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  func_ii_2946(param1_00,StringLiteral_27440,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_27447;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81041642;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81041642:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007311 RID: 29457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007311")]
		[Address(RVA = "0xBD1A", Offset = "0xBD1A", VA = "0xBD1A")]
		private void TutorialStepStartEvent(Tutorial2Scope.Tutorial2StepEventArgs e)
		{
		}

		// Token: 0x06007312 RID: 29458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007312")]
		[Address(RVA = "0xBD1B", Offset = "0xBD1B", VA = "0xBD1B")]
		public Tutorial2AnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_Tutorial2AnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59646 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_27923);
		    DAT_ram_00a59646 = '\x01';
		  }
		  return StringLiteral_27923;
		}
		*/

		}

		// Token: 0x04003C3B RID: 15419
		[Token(Token = "0x4003C3B")]
		public const string THEME = "tutorial_details";

		// Token: 0x04003C3C RID: 15420
		[Token(Token = "0x4003C3C")]
		public const string TUTORIAL2_STEP_START = "step_start";

		// Token: 0x04003C3D RID: 15421
		[Token(Token = "0x4003C3D")]
		public const string TUTORIAL2_STEP_FINISH = "step_finish";

		// Token: 0x04003C3E RID: 15422
		[Token(Token = "0x4003C3E")]
		public const string COMBAT_COMBO = "combat_combo";

		// Token: 0x04003C3F RID: 15423
		[Token(Token = "0x4003C3F")]
		public const string USE_SPELL = "use_spell";

		// Token: 0x04003C40 RID: 15424
		[Token(Token = "0x4003C40")]
		public const string USE_ELIXIR = "use_elixir";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_Tutorial2AnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5963f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatScope_UseSpellArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_CombatScope_ComboEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_Tutorial2AnalyticsListener_ComboEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_Tutorial2AnalyticsListener_TutorialStepFinishEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_Tutorial2AnalyticsListener_TutorialStepStartEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_Tutorial2AnalyticsListener_UseElixirEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_Tutorial2AnalyticsListener_UseSpellEvent__);
		    DAT_ram_00a5963f = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x10);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_Tutorial2AnalyticsListener_TutorialStepStartEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x10);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_Tutorial2AnalyticsListener_TutorialStepFinishEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_Tutorial2Scope_Tutorial2StepEventArgs__TypeInfo);
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
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_CombatScope_ComboEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_Tutorial2AnalyticsListener_ComboEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_CombatScope_ComboEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_CombatScope_ComboEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar2 = System_Action_CombatScope_ComboEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_CombatScope_ComboEventArgs__TypeInfo);
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
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_CombatScope_UseSpellArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_Tutorial2AnalyticsListener_UseSpellEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_CombatScope_UseSpellArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_CombatScope_UseSpellArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x1c) = iVar3;
		    uVar2 = System_Action_CombatScope_UseSpellArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_CombatScope_UseSpellArgs__TypeInfo);
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
		  uVar5 = *(undefined4 *)(iVar4 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_CombatScope_UseSpellArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_Tutorial2AnalyticsListener_UseElixirEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_CombatScope_UseSpellArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x20) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_CombatScope_UseSpellArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x20) = iVar3;
		    uVar2 = System_Action_CombatScope_UseSpellArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_CombatScope_UseSpellArgs__TypeInfo);
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
