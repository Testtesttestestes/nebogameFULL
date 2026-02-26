using System;
using System.Collections.Generic;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012BB RID: 4795
	[Token(Token = "0x20012BB")]
	public class AdAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x060071D5 RID: 29141 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001720")]
		protected override string Theme
		{
			[Token(Token = "0x60071D5")]
			[Address(RVA = "0xBBDE", Offset = "0xBBDE", VA = "0xBBDE", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060071D6 RID: 29142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071D6")]
		[Address(RVA = "0xBBDF", Offset = "0xBBDF", VA = "0xBBDF", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_AdAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59535 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AdScope_AdErrorEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AdScope_AdPlacementEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AdScope_AdEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AdScope_AdTransactionInfoEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AdAnalyticsListener_AdAppRequestEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AdAnalyticsListener_AdErrorEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AdAnalyticsListener_AdPlacementShownEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AdAnalyticsListener_AdProviderRequestEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AdAnalyticsListener_AdTransactionClosedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AdAnalyticsListener_AdWatchedEvent__);
		    DAT_ram_00a59535 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x90);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_AdScope_AdPlacementEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AdAnalyticsListener_AdPlacementShownEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AdScope_AdPlacementEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AdScope_AdPlacementEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_AdScope_AdPlacementEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AdScope_AdPlacementEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x90);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_AdScope_AdEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AdAnalyticsListener_AdWatchedEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AdScope_AdEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AdScope_AdEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_AdScope_AdEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AdScope_AdEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x90);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_AdScope_AdEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AdAnalyticsListener_AdAppRequestEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AdScope_AdEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AdScope_AdEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_AdScope_AdEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AdScope_AdEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x90);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_AdScope_AdEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AdAnalyticsListener_AdProviderRequestEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AdScope_AdEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AdScope_AdEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_AdScope_AdEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AdScope_AdEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x90);
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_AdScope_AdErrorEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AdAnalyticsListener_AdErrorEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AdScope_AdErrorEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AdScope_AdErrorEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar2 = System_Action_AdScope_AdErrorEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AdScope_AdErrorEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x90);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_AdScope_AdPlacementEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AdAnalyticsListener_AdPlacementShownEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AdScope_AdPlacementEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AdScope_AdPlacementEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_AdScope_AdPlacementEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AdScope_AdPlacementEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x90);
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_AdScope_AdTransactionInfoEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AdAnalyticsListener_AdTransactionClosedEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AdScope_AdTransactionInfoEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_AdScope_AdTransactionInfoEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x1c) = iVar3;
		    uVar2 = System_Action_AdScope_AdTransactionInfoEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AdScope_AdTransactionInfoEventArgs__TypeInfo);
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

		// Token: 0x060071D7 RID: 29143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071D7")]
		[Address(RVA = "0xBBE0", Offset = "0xBBE0", VA = "0xBBE0", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_AdAnalyticsListener__Deinit(int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59536 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Services_AdPlacement_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25868);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19707);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26100);
		    DAT_ram_00a59536 = '\x01';
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
		  local_8 = 0xffffffff;
		  local_c = Protocol_Services_AdPlacement_TypeInfo;
		  local_4 = *(undefined4 *)(param2 + 0x10);
		  uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  func_ii_2946(param1_00,StringLiteral_19707,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_10 = *(undefined4 *)(param2 + 0x14);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_10);
		  func_ii_2946(param1_00,StringLiteral_25868,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_26100;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x810249e6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810249e6:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060071D8 RID: 29144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071D8")]
		[Address(RVA = "0xBBE1", Offset = "0xBBE1", VA = "0xBBE1")]
		private void AdPlacementShownEvent(AdScope.AdPlacementEventArgs e)
		{
		/* --- GHIDRA: AdPlacementShownEvent ---
		void Core_Analytics_Listeners_AdAnalyticsListener__AdPlacementShownEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_01;
		  int iVar4;
		  uint uVar5;
		  undefined4 local_10 [2];
		  undefined8 local_8;
		  
		  uVar5 = 0;
		  if (DAT_ram_00a59537 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__ToString__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21028);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27836);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25868);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19709);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27837);
		    DAT_ram_00a59537 = '\x01';
		  }
		  local_8 = 0;
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  Core_Gameplay_Managers_Ad_Statistics_AdTransactionStatisticsInfo__MarkAsClosed
		            (&local_8,*(undefined4 *)(param2 + 0x10),0);
		  uVar1 = System_Nullable_int___GetValueOrDefault(&local_8,Method_System_Nullable_int__ToString__);
		  func_ii_2946(param1_00,StringLiteral_21028,uVar1,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  Core_Gameplay_Managers_Ad_Statistics_AdTransactionStatisticsInfo__get_CallbackDelaySec
		            (local_10,*(undefined4 *)(param2 + 0x10),0);
		  uVar1 = System_Nullable_int___GetValueOrDefault(&local_8,Method_System_Nullable_int__ToString__);
		  func_ii_2946(param1_00,StringLiteral_27837,uVar1,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  func_ii_2946(param1_00,StringLiteral_27836,*(undefined4 *)(*(int *)(param2 + 0x10) + 8),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_10[0] = *(undefined4 *)(*(int *)(param2 + 0x10) + 0x18);
		  uVar1 = func_ii_1081(DAT_ram_00a66958,local_10);
		  func_ii_2946(param1_00,StringLiteral_25868,uVar1,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_19709;
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0xd8);
		        goto code_r0x81024c09;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81024c09:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_01,uVar2,uVar1,param1_00,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x060071D9 RID: 29145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071D9")]
		[Address(RVA = "0xBBE2", Offset = "0xBBE2", VA = "0xBBE2")]
		private void AdTransactionClosedEvent(AdScope.AdTransactionInfoEventArgs e)
		{
		/* --- GHIDRA: AdTransactionClosedEvent ---
		void Core_Analytics_Listeners_AdAnalyticsListener__AdTransactionClosedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a59538 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26199);
		    DAT_ram_00a59538 = '\x01';
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
		  uVar2 = 0;
		  Core_Analytics_Listeners_AdAnalyticsListener__AdWatchedEvent(0,param2,param1_00,0);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_26199;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81024d2b;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81024d2b:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar1,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060071DA RID: 29146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071DA")]
		[Address(RVA = "0xBBE3", Offset = "0xBBE3", VA = "0xBBE3")]
		private void AdProviderRequestEvent(AdScope.AdEventArgs e)
		{
		/* --- GHIDRA: AdProviderRequestEvent ---
		void Core_Analytics_Listeners_AdAnalyticsListener__AdProviderRequestEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a59539 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19856);
		    DAT_ram_00a59539 = '\x01';
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
		  uVar2 = 0;
		  Core_Analytics_Listeners_AdAnalyticsListener__AdWatchedEvent(0,param2,param1_00,0);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_19856;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81024fa4;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81024fa4:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar1,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060071DB RID: 29147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071DB")]
		[Address(RVA = "0xBBE4", Offset = "0xBBE4", VA = "0xBBE4")]
		private void AdAppRequestEvent(AdScope.AdEventArgs e)
		{
		/* --- GHIDRA: AdAppRequestEvent ---
		void Core_Analytics_Listeners_AdAnalyticsListener__AdAppRequestEvent
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
		  
		  if (DAT_ram_00a5953a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22982);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27836);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28326);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22980);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19706);
		    DAT_ram_00a5953a = '\x01';
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
		  Core_Analytics_Listeners_AdAnalyticsListener__AdWatchedEvent(0,param2,param1_00,0);
		  uVar2 = Core_Gameplay_Managers_Ad_Model_AdTransaction__set_Payload
		                    (*(undefined4 *)(param2 + 0x10),0);
		  func_ii_2946(param1_00,StringLiteral_27836,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  func_ii_2946(param1_00,StringLiteral_19706,*(undefined4 *)(*(int *)(param2 + 0x14) + 0xc),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  func_ii_2946(param1_00,StringLiteral_22982,*(undefined4 *)(*(int *)(param2 + 0x14) + 0x14),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_4 = *(undefined4 *)(*(int *)(param2 + 0x14) + 0x10);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  func_ii_2946(param1_00,StringLiteral_22980,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_28326;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81025188;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81025188:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060071DC RID: 29148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071DC")]
		[Address(RVA = "0xBBE5", Offset = "0xBBE5", VA = "0xBBE5")]
		private void AdErrorEvent(AdScope.AdErrorEventArgs e)
		{
		/* --- GHIDRA: AdErrorEvent ---
		void Core_Analytics_Listeners_AdAnalyticsListener__AdErrorEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a5953b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28327);
		    DAT_ram_00a5953b = '\x01';
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
		  uVar2 = 0;
		  Core_Analytics_Listeners_AdAnalyticsListener__AdWatchedEvent(0,param2,param1_00,0);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_28327;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x810252aa;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810252aa:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar1,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060071DD RID: 29149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071DD")]
		[Address(RVA = "0xBBE6", Offset = "0xBBE6", VA = "0xBBE6")]
		private void AdWatchedEvent(AdScope.AdEventArgs e)
		{
		/* --- GHIDRA: AdWatchedEvent ---
		void Core_Analytics_Listeners_AdAnalyticsListener__AdWatchedEvent
		               (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a5953c == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Services_AdPlacement_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_AdSource_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Nullable_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25868);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19707);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19708);
		    DAT_ram_00a5953c = '\x01';
		  }
		  uVar1 = StringLiteral_19707;
		  if (*(int *)(param2 + 0x10) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    local_8 = *(undefined4 *)(*(int *)(param2 + 0x10) + 0xc);
		    local_10 = CONCAT44(0xffffffff,Protocol_Services_AdPlacement_TypeInfo);
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_10,0);
		  }
		  func_ii_2946(param3,uVar1,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar1 = StringLiteral_19708;
		  if (*(int *)(param2 + 0x10) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    local_8 = *(undefined4 *)(*(int *)(param2 + 0x10) + 8);
		    local_10 = CONCAT44(0xffffffff,Protocol_Services_AdSource_TypeInfo);
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_10,0);
		  }
		  func_ii_2946(param3,uVar1,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar1 = StringLiteral_25868;
		  if (*(int *)(param2 + 0x10) == 0) {
		    local_10 = 0;
		  }
		  else {
		    local_10 = 0;
		    System_Data_SqlTypes_SqlInt32___ctor
		              (&local_10,*(undefined4 *)(*(int *)(param2 + 0x10) + 0x10),
		               Method_System_Nullable_uint___ctor__);
		  }
		  uVar2 = func_ii_1081(System_Nullable_uint__TypeInfo,&local_10);
		  func_ii_2946(param3,uVar1,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  return;
		}
		*/

		}

		// Token: 0x060071DE RID: 29150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071DE")]
		[Address(RVA = "0xBBE7", Offset = "0xBBE7", VA = "0xBBE7")]
		private void AppendEventArgs(AdScope.AdEventArgs e, Dictionary<string, object> properties)
		{
		}

		// Token: 0x060071DF RID: 29151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071DF")]
		[Address(RVA = "0xBBE8", Offset = "0xBBE8", VA = "0xBBE8")]
		public AdAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Analytics_Listeners_AdAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5953d == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_19757);
		    DAT_ram_00a5953d = '\x01';
		  }
		  return StringLiteral_19757;
		}
		*/

		}

		// Token: 0x04003BA4 RID: 15268
		[Token(Token = "0x4003BA4")]
		private const string WATCH_SUCCESS = "watch_success";

		// Token: 0x04003BA5 RID: 15269
		[Token(Token = "0x4003BA5")]
		private const string WATCH_ERROR = "watch_error";

		// Token: 0x04003BA6 RID: 15270
		[Token(Token = "0x4003BA6")]
		private const string APP_REQUEST = "app_request";

		// Token: 0x04003BA7 RID: 15271
		[Token(Token = "0x4003BA7")]
		private const string PROVIDER_REQUEST = "provider_request";

		// Token: 0x04003BA8 RID: 15272
		[Token(Token = "0x4003BA8")]
		private const string PLACEMENT_SHOWN = "placement_shown";

		// Token: 0x04003BA9 RID: 15273
		[Token(Token = "0x4003BA9")]
		private const string AD_TRANSACTION_CLOSED = "ad_transaction_closed";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_AdAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59534 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AdScope_AdErrorEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AdScope_AdPlacementEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AdScope_AdEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AdScope_AdTransactionInfoEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AdAnalyticsListener_AdAppRequestEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AdAnalyticsListener_AdErrorEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AdAnalyticsListener_AdPlacementShownEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AdAnalyticsListener_AdProviderRequestEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AdAnalyticsListener_AdTransactionClosedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AdAnalyticsListener_AdWatchedEvent__);
		    DAT_ram_00a59534 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x90);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_AdScope_AdEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AdAnalyticsListener_AdWatchedEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AdScope_AdEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AdScope_AdEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_AdScope_AdEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AdScope_AdEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x90);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_AdScope_AdEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AdAnalyticsListener_AdAppRequestEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AdScope_AdEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AdScope_AdEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_AdScope_AdEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AdScope_AdEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x90);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_AdScope_AdEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AdAnalyticsListener_AdProviderRequestEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AdScope_AdEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AdScope_AdEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_AdScope_AdEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AdScope_AdEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x90);
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_AdScope_AdErrorEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AdAnalyticsListener_AdErrorEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AdScope_AdErrorEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AdScope_AdErrorEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar2 = System_Action_AdScope_AdErrorEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AdScope_AdErrorEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x90);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_AdScope_AdPlacementEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AdAnalyticsListener_AdPlacementShownEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AdScope_AdPlacementEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AdScope_AdPlacementEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_AdScope_AdPlacementEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AdScope_AdPlacementEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x90);
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_AdScope_AdTransactionInfoEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AdAnalyticsListener_AdTransactionClosedEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AdScope_AdTransactionInfoEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_AdScope_AdTransactionInfoEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x1c) = iVar3;
		    uVar2 = System_Action_AdScope_AdTransactionInfoEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AdScope_AdTransactionInfoEventArgs__TypeInfo);
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
