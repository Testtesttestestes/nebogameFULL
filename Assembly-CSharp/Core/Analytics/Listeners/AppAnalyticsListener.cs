using System;
using System.Collections.Generic;
using Core.Analytics.Service.Android;
using Core.Events;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012BE RID: 4798
	[Token(Token = "0x20012BE")]
	public class AppAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x060071EB RID: 29163 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001723")]
		protected override string Theme
		{
			[Token(Token = "0x60071EB")]
			[Address(RVA = "0xBBF4", Offset = "0xBBF4", VA = "0xBBF4", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060071EC RID: 29164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071EC")]
		[Address(RVA = "0xBBF5", Offset = "0xBBF5", VA = "0xBBF5", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_AppAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59548 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AppScope_LoadingEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AppScope_UnhandledExceptionEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BaseEventBusEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AppScope_LatencyMonitorArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AppScope_AverageFpsCalculatedEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Action_AppScope_AnswerFromServerReceivedEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AppAnalyticsListener_AnswerFromServerReceivedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AppAnalyticsListener_AppInitCompleteEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AppAnalyticsListener_AppLoadingEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AppAnalyticsListener_AverageFpsCalculatedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AppAnalyticsListener_GameInitCompleteEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AppAnalyticsListener_GameLoadingEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AppAnalyticsListener_InitAppEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AppAnalyticsListener_LatencyMonitorEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AppAnalyticsListener_ServerIdChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AppAnalyticsListener_UnhandledExceptionEvent__);
		    DAT_ram_00a59548 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AppAnalyticsListener_InitAppEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AppAnalyticsListener_AppInitCompleteEvent__,0);
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
		  iVar4 = *(int *)(iVar1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AppAnalyticsListener_ServerIdChangedEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AppAnalyticsListener_GameInitCompleteEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_AppScope_UnhandledExceptionEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AppAnalyticsListener_UnhandledExceptionEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AppScope_UnhandledExceptionEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AppScope_UnhandledExceptionEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar2 = System_Action_AppScope_UnhandledExceptionEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AppScope_UnhandledExceptionEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_AppScope_AverageFpsCalculatedEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AppAnalyticsListener_AverageFpsCalculatedEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AppScope_AverageFpsCalculatedEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AppScope_AverageFpsCalculatedEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x1c) = iVar3;
		    uVar2 = System_Action_AppScope_AverageFpsCalculatedEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AppScope_AverageFpsCalculatedEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_AppScope_AnswerFromServerReceivedEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AppAnalyticsListener_AnswerFromServerReceivedEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AppScope_AnswerFromServerReceivedEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x20) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AppScope_AnswerFromServerReceivedEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x20) = iVar3;
		    uVar2 = System_Action_AppScope_AnswerFromServerReceivedEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AppScope_AnswerFromServerReceivedEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_AppScope_LoadingEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AppAnalyticsListener_AppLoadingEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AppScope_LoadingEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x24) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AppScope_LoadingEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x24) = iVar3;
		    uVar2 = System_Action_AppScope_LoadingEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AppScope_LoadingEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x28);
		  uVar2 = unnamed_function_1417(System_Action_AppScope_LoadingEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AppAnalyticsListener_GameLoadingEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AppScope_LoadingEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x28) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AppScope_LoadingEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x28) = iVar3;
		    uVar2 = System_Action_AppScope_LoadingEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AppScope_LoadingEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x2c);
		  uVar2 = unnamed_function_1417(System_Action_AppScope_LatencyMonitorArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AppAnalyticsListener_LatencyMonitorEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AppScope_LatencyMonitorArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x2c) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_AppScope_LatencyMonitorArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x2c) = iVar3;
		    uVar2 = System_Action_AppScope_LatencyMonitorArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AppScope_LatencyMonitorArgs__TypeInfo);
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

		// Token: 0x060071ED RID: 29165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071ED")]
		[Address(RVA = "0xBBF6", Offset = "0xBBF6", VA = "0xBBF6", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_AppAnalyticsListener__Deinit(int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59549 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_double__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&System_Nullable_double__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27418);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25032);
		    DAT_ram_00a59549 = '\x01';
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
		  if (*(char *)(param2 + 8) != '\0') {
		    local_8 = *(undefined8 *)(param2 + 0x10);
		    local_10 = *(undefined8 *)(param2 + 8);
		    uVar2 = func_ii_1081(System_Nullable_double__TypeInfo,&local_10);
		    func_ii_2946(param1_00,StringLiteral_27418,uVar2,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  }
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_25032;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81026a53;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81026a53:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060071EE RID: 29166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071EE")]
		[Address(RVA = "0xBBF7", Offset = "0xBBF7", VA = "0xBBF7")]
		private void LatencyMonitorEvent(AppScope.LatencyMonitorArgs value)
		{
		/* --- GHIDRA: LatencyMonitorEvent ---
		void Core_Analytics_Listeners_AppAnalyticsListener__LatencyMonitorEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  float4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5954a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26061);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23315);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27428);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27783);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22123);
		    DAT_ram_00a5954a = '\x01';
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
		  func_ii_2946(param1_00,StringLiteral_27428,*(undefined4 *)(param2 + 0x10),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_4 = *(undefined4 *)(param2 + 0x14);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  func_ii_2946(param1_00,StringLiteral_22123,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_8 = *(undefined4 *)(param2 + 0x18);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_8);
		  func_ii_2946(param1_00,StringLiteral_27783,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_c = (float4)((float)*(int *)(param2 + 0x14) / (float)*(int *)(param2 + 0x18));
		  uVar2 = func_ii_1081(DAT_ram_00a6696c,&local_c);
		  func_ii_2946(param1_00,StringLiteral_26061,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_23315;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81026c5b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81026c5b:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060071EF RID: 29167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071EF")]
		[Address(RVA = "0xBBF8", Offset = "0xBBF8", VA = "0xBBF8")]
		private void GameLoadingEvent(AppScope.LoadingEventArgs e)
		{
		/* --- GHIDRA: GameLoadingEvent ---
		void Core_Analytics_Listeners_AppAnalyticsListener__GameLoadingEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  float4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5954b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26061);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19854);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27428);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27783);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22123);
		    DAT_ram_00a5954b = '\x01';
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
		  func_ii_2946(param1_00,StringLiteral_27428,*(undefined4 *)(param2 + 0x10),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_4 = *(undefined4 *)(param2 + 0x14);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  func_ii_2946(param1_00,StringLiteral_22123,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_8 = *(undefined4 *)(param2 + 0x18);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_8);
		  func_ii_2946(param1_00,StringLiteral_27783,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_c = (float4)((float)*(int *)(param2 + 0x14) / (float)*(int *)(param2 + 0x18));
		  uVar2 = func_ii_1081(DAT_ram_00a6696c,&local_c);
		  func_ii_2946(param1_00,StringLiteral_26061,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_19854;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81026e63;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81026e63:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060071F0 RID: 29168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F0")]
		[Address(RVA = "0xBBF9", Offset = "0xBBF9", VA = "0xBBF9")]
		private void AppLoadingEvent(AppScope.LoadingEventArgs e)
		{
		/* --- GHIDRA: AppLoadingEvent ---
		void Core_Analytics_Listeners_AppAnalyticsListener__AppLoadingEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param4;
		  undefined4 *puVar3;
		  int *piVar4;
		  int iVar5;
		  uint uVar6;
		  undefined8 local_20;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5954c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Tuple_short__short___string__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Tuple_short__short___string__get_Keys__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_Tuple_short__short___string__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_Tuple_short__short___string__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_Tuple_short__short___string__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Tuple_short__short___string__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_short__short__get_Item1__);
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_short__short__get_Item2__);
		    DAT_ram_00a5954c = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar1 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (*(undefined4 *)(param1 + 0x18),
		                     Method_System_Collections_Generic_Dictionary_Tuple_short__short___string__get_Keys__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar1,
		             Method_System_Collections_Generic_Dictionary_KeyCollection_Tuple_short__short___string__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x79,&local_10,
		                       Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_Tuple_short__short___string__MoveNext__
		                      );
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8102712c;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		  } while ((*(short *)(local_8._4_4_ + 8) != *(short *)(*(int *)(param2 + 0x10) + 0x10)) ||
		          (*(short *)(local_8._4_4_ + 10) != *(short *)(*(int *)(param2 + 0x10) + 0x12)));
		  piVar4 = *(int **)(param1 + 8);
		  DAT_ram_009d3e38 = 0;
		  uVar1 = import::env::invoke_iiii
		                    (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x2ec,
		                     *(undefined4 *)(param1 + 0x18),local_8._4_4_,
		                     Method_System_Collections_Generic_Dictionary_Tuple_short__short___string__get_Item__
		                    );
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 == 1) {
		    uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    local_20 = *(undefined8 *)(*(int *)(param2 + 0x10) + 0x18);
		    DAT_ram_009d3e38 = 0;
		    param4 = import::env::invoke_iii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66964,
		                        &local_20);
		    if (DAT_ram_009d3e38 != 1) {
		      uVar6 = 0;
		      iVar5 = *piVar4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		            puVar3 = (undefined4 *)
		                     (*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 200);
		            goto code_r0x810270c4;
		          }
		          uVar6 = uVar6 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar4,
		                          Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x810270c4:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii(*puVar3,piVar4,uVar1,param4,puVar3[1]);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		code_r0x8102712c:
		  iVar5 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar1);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x333,&local_18);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 != 1) {
		    import::env::__resumeException(uVar1);
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

		// Token: 0x060071F1 RID: 29169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F1")]
		[Address(RVA = "0xBBFA", Offset = "0xBBFA", VA = "0xBBFA")]
		private void AnswerFromServerReceivedEvent(AppScope.AnswerFromServerReceivedEventArgs e)
		{
		/* --- GHIDRA: AnswerFromServerReceivedEvent ---
		void Core_Analytics_Listeners_AppAnalyticsListener__AnswerFromServerReceivedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  int local_4;
		  
		  if (DAT_ram_00a5954d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23256);
		    DAT_ram_00a5954d = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  if (ABS(*(float *)(param2 + 0x10)) < 2.1474836e+09) {
		    local_4 = (int)*(float *)(param2 + 0x10);
		  }
		  else {
		    local_4 = -0x80000000;
		  }
		  uVar2 = 0;
		  uVar3 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  uVar1 = StringLiteral_23256;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x810272e9;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x810272e9:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar1,uVar3,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060071F2 RID: 29170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F2")]
		[Address(RVA = "0xBBFB", Offset = "0xBBFB", VA = "0xBBFB")]
		private void AverageFpsCalculatedEvent(AppScope.AverageFpsCalculatedEventArgs e)
		{
		/* --- GHIDRA: AverageFpsCalculatedEvent ---
		void Core_Analytics_Listeners_AppAnalyticsListener__AverageFpsCalculatedEvent
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
		  
		  if (DAT_ram_00a5954e == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_NetworkReachability_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27948);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27381);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25362);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24644);
		    DAT_ram_00a5954e = '\x01';
		  }
		  if (param1[5] < 3) {
		    param1[5] = param1[5] + 1;
		    if (DAT_ram_00a59526 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		      Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		      DAT_ram_00a59526 = '\x01';
		    }
		    param1_00 = unnamed_function_1417
		                          (System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Application_TypeInfo);
		    }
		    uVar1 = 0;
		    local_4 = UnityEngine_Application__get_systemLanguage(0);
		    uVar2 = func_ii_1081(UnityEngine_NetworkReachability_TypeInfo,&local_4);
		    func_ii_2946(param1_00,StringLiteral_24644,uVar2,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    func_ii_2946(param1_00,StringLiteral_25362,*(undefined4 *)(param2 + 0x10),
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    func_ii_2946(param1_00,StringLiteral_27381,*(undefined4 *)(param2 + 0x14),
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    param1_01 = (int *)param1[2];
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xec));
		    uVar2 = StringLiteral_27948;
		    iVar5 = *param1_01;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		          goto code_r0x810274d2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810274d2:
		    (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060071F3 RID: 29171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F3")]
		[Address(RVA = "0xBBFC", Offset = "0xBBFC", VA = "0xBBFC")]
		private void UnhandledExceptionEvent(AppScope.UnhandledExceptionEventArgs e)
		{
		/* --- GHIDRA: UnhandledExceptionEvent ---
		void Core_Analytics_Listeners_AppAnalyticsListener__UnhandledExceptionEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a5954f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24602);
		    DAT_ram_00a5954f = '\x01';
		  }
		  Core_Analytics_Listeners_AppAnalyticsListener__InitAppEvent(param1,param1);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
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
		  uVar1 = StringLiteral_24602;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x810275f3;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810275f3:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar1,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060071F4 RID: 29172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F4")]
		[Address(RVA = "0xBBFD", Offset = "0xBBFD", VA = "0xBBFD")]
		private void InitAppEvent(BaseEventBusEventArgs obj)
		{
		/* --- GHIDRA: InitAppEvent ---
		void Core_Analytics_Listeners_AppAnalyticsListener__InitAppEvent(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 local_1c;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59550 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Rendering_GraphicsDeviceType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_SystemLanguage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27609);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27608);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27610);
		    DAT_ram_00a59550 = '\x01';
		  }
		  piVar5 = *(int **)(param1 + 8);
		  if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Application_TypeInfo);
		  }
		  uVar2 = 0;
		  local_4 = UnityEngine_Application__get_isMobilePlatform(0);
		  local_8 = 0xffffffff;
		  local_c = UnityEngine_SystemLanguage_TypeInfo;
		  uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  uVar1 = StringLiteral_27609;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x81027720;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x81027720:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar1,uVar3,puVar4[1]);
		  piVar5 = *(int **)(param1 + 8);
		  uVar2 = 0;
		  local_10 = UnityEngine_SystemInfo__SupportsTextureFormatNative(0);
		  uVar3 = func_ii_1081(DAT_ram_00a66954,&local_10);
		  uVar1 = StringLiteral_27610;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x810277ca;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x810277ca:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar1,uVar3,puVar4[1]);
		  piVar5 = *(int **)(param1 + 8);
		  uVar2 = 0;
		  local_14 = UnityEngine_SystemInfo__GetGraphicsDeviceName(0);
		  local_18 = 0xffffffff;
		  local_1c = UnityEngine_Rendering_GraphicsDeviceType_TypeInfo;
		  uVar3 = Spine_SkeletonJson__GetFloat(&local_1c,0);
		  uVar1 = StringLiteral_27608;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x81027883;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x81027883:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar1,uVar3,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060071F5 RID: 29173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F5")]
		[Address(RVA = "0xBBFE", Offset = "0xBBFE", VA = "0xBBFE")]
		private void SetSystemUserProperties()
		{
		/* --- GHIDRA: SetSystemUserProperties ---
		void Core_Analytics_Listeners_AppAnalyticsListener__SetSystemUserProperties
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a59551 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23316);
		    DAT_ram_00a59551 = '\x01';
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
		  uVar1 = StringLiteral_23316;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8102799b;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102799b:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar1,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060071F6 RID: 29174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F6")]
		[Address(RVA = "0xBBFF", Offset = "0xBBFF", VA = "0xBBFF")]
		private void GameInitCompleteEvent(BaseEventBusEventArgs e)
		{
		/* --- GHIDRA: GameInitCompleteEvent ---
		void Core_Analytics_Listeners_AppAnalyticsListener__GameInitCompleteEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  
		  if (DAT_ram_00a59552 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Threading_SendOrPostCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_AppAnalyticsListener___c__DisplayClass26_0__AppInitCompleteEvent_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Analytics_Listeners_AppAnalyticsListener___c__DisplayClass26_0_TypeInfo);
		    DAT_ram_00a59552 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Core_Analytics_Listeners_AppAnalyticsListener___c__DisplayClass26_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param1;
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar2,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Net_SrvCommand_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Threading_SendOrPostCallback_TypeInfo);
		  func_ii_13894(uVar2,iVar1,
		                Method_Core_Analytics_Listeners_AppAnalyticsListener___c__DisplayClass26_0__AppInitCompleteEvent_b__0__
		                ,0);
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (piVar3,uVar2,0,*(undefined4 *)(iVar1 + 0xec));
		  return;
		}
		*/

		}

		// Token: 0x060071F7 RID: 29175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F7")]
		[Address(RVA = "0xBC00", Offset = "0xBC00", VA = "0xBC00")]
		private void AppInitCompleteEvent(BaseEventBusEventArgs e)
		{
		/* --- GHIDRA: AppInitCompleteEvent ---
		void Core_Analytics_Listeners_AppAnalyticsListener__AppInitCompleteEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  int *param1_00;
		  undefined4 uVar6;
		  int *local_4;
		  
		  if (DAT_ram_00a59553 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26668);
		    DAT_ram_00a59553 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  piVar4 = *(int **)(param2 + 8);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x81027b5f;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,10);
		code_r0x81027b5f:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar2 = 0;
		  piVar4 = *(int **)(iVar5 + 0x10);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xe8);
		        goto code_r0x81027be4;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,
		                                Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                                ,5);
		code_r0x81027be4:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,&local_4,puVar3[1]);
		  piVar4 = local_4;
		  if (iVar5 != 0) {
		    uVar2 = 0;
		    param1_00 = *(int **)(param1 + 8);
		    iVar5 = *local_4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x81027c75;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(local_4,
		                                  Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo
		                                  ,2);
		code_r0x81027c75:
		    iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    uVar1 = StringLiteral_26668;
		    uVar6 = *(undefined4 *)(iVar5 + 0x14);
		    uVar2 = 0;
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 200);
		          goto code_r0x81027d04;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x81027d04:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar1,uVar6,puVar3[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060071F8 RID: 29176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F8")]
		[Address(RVA = "0xBC01", Offset = "0xBC01", VA = "0xBC01")]
		private void ServerIdChangedEvent(BaseEventBusEventArgs e)
		{
		/* --- GHIDRA: ServerIdChangedEvent ---
		void Core_Analytics_Listeners_AppAnalyticsListener__ServerIdChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59554 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Tuple_short__short___string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Tuple_short__short___string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Tuple_short__short___string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_short__short___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Tuple_short__short__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25031);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25029);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25030);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26082);
		    DAT_ram_00a59554 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_Tuple_short__short___string__TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_Tuple_short__short___string___ctor__);
		  uVar1 = unnamed_function_1417(System_Tuple_short__short__TypeInfo);
		  System_Tuple_Guid__object___get_Item2(uVar1,2,1,Method_System_Tuple_short__short___ctor__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,uVar1,StringLiteral_26082,
		             Method_System_Collections_Generic_Dictionary_Tuple_short__short___string__Add__);
		  uVar1 = unnamed_function_1417(System_Tuple_short__short__TypeInfo);
		  System_Tuple_Guid__object___get_Item2(uVar1,0x2a,1,Method_System_Tuple_short__short___ctor__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,uVar1,StringLiteral_25031,
		             Method_System_Collections_Generic_Dictionary_Tuple_short__short___string__Add__);
		  uVar1 = unnamed_function_1417(System_Tuple_short__short__TypeInfo);
		  System_Tuple_Guid__object___get_Item2(uVar1,3,2,Method_System_Tuple_short__short___ctor__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,uVar1,StringLiteral_25030,
		             Method_System_Collections_Generic_Dictionary_Tuple_short__short___string__Add__);
		  uVar1 = unnamed_function_1417(System_Tuple_short__short__TypeInfo);
		  System_Tuple_Guid__object___get_Item2(uVar1,0x18,5,Method_System_Tuple_short__short___ctor__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,uVar1,StringLiteral_25029,
		             Method_System_Collections_Generic_Dictionary_Tuple_short__short___string__Add__);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  Core_Analytics_Listeners_AbstractAnalyticsListener__GetResourceAnalyticsName(param1,param1_00);
		  return;
		}
		*/

		}

		// Token: 0x060071F9 RID: 29177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F9")]
		[Address(RVA = "0xBC02", Offset = "0xBC02", VA = "0xBC02")]
		public AppAnalyticsListener()
		{
		}

		// Token: 0x04003BAE RID: 15278
		[Token(Token = "0x4003BAE")]
		public const string THEME = "app";

		// Token: 0x04003BAF RID: 15279
		[Token(Token = "0x4003BAF")]
		[FieldOffset(Offset = "0x10")]
		private DeviceIDProvider _deviceIDProvider;

		// Token: 0x04003BB0 RID: 15280
		[Token(Token = "0x4003BB0")]
		private const int MaxUnhandledExceptionsNum = 3;

		// Token: 0x04003BB1 RID: 15281
		[Token(Token = "0x4003BB1")]
		[FieldOffset(Offset = "0x14")]
		private int _unhandledExceptionCounter;

		// Token: 0x04003BB2 RID: 15282
		[Token(Token = "0x4003BB2")]
		private const string INIT = "init";

		// Token: 0x04003BB3 RID: 15283
		[Token(Token = "0x4003BB3")]
		public const string APP_LOADING = "app_loading";

		// Token: 0x04003BB4 RID: 15284
		[Token(Token = "0x4003BB4")]
		public const string GAME_LOADING = "game_loading";

		// Token: 0x04003BB5 RID: 15285
		[Token(Token = "0x4003BB5")]
		public const string APP_LOADING_COMPLETE = "app_loading_complete";

		// Token: 0x04003BB6 RID: 15286
		[Token(Token = "0x4003BB6")]
		public const string GAME_LOADING_COMPLETE = "game_loading_complete";

		// Token: 0x04003BB7 RID: 15287
		[Token(Token = "0x4003BB7")]
		private const string UNHANDLED_EXCEPTION = "unhandled_exception";

		// Token: 0x04003BB8 RID: 15288
		[Token(Token = "0x4003BB8")]
		private const string SERVER_ID = "server";

		// Token: 0x04003BB9 RID: 15289
		[Token(Token = "0x4003BB9")]
		private const string LATENCY_MONITOR = "latency_monitor";

		// Token: 0x04003BBA RID: 15290
		[Token(Token = "0x4003BBA")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<Tuple<short, short>, string> _loggingLatencies;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_AppAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59547 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AppScope_LoadingEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AppScope_UnhandledExceptionEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BaseEventBusEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AppScope_LatencyMonitorArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AppScope_AverageFpsCalculatedEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Action_AppScope_AnswerFromServerReceivedEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AppAnalyticsListener_AnswerFromServerReceivedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AppAnalyticsListener_AppInitCompleteEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AppAnalyticsListener_AppLoadingEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AppAnalyticsListener_AverageFpsCalculatedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AppAnalyticsListener_GameInitCompleteEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AppAnalyticsListener_GameLoadingEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AppAnalyticsListener_InitAppEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AppAnalyticsListener_LatencyMonitorEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AppAnalyticsListener_ServerIdChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AppAnalyticsListener_UnhandledExceptionEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_Android_DeviceIDProvider_TypeInfo);
		    DAT_ram_00a59547 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Analytics_Service_Android_DeviceIDProvider_TypeInfo);
		  param1[4] = iVar1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AppAnalyticsListener_InitAppEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AppAnalyticsListener_AppInitCompleteEvent__,0);
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
		  iVar4 = *(int *)(iVar1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AppAnalyticsListener_ServerIdChangedEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AppAnalyticsListener_GameInitCompleteEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_AppScope_UnhandledExceptionEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AppAnalyticsListener_UnhandledExceptionEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AppScope_UnhandledExceptionEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AppScope_UnhandledExceptionEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar2 = System_Action_AppScope_UnhandledExceptionEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AppScope_UnhandledExceptionEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_AppScope_AverageFpsCalculatedEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AppAnalyticsListener_AverageFpsCalculatedEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AppScope_AverageFpsCalculatedEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AppScope_AverageFpsCalculatedEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x1c) = iVar3;
		    uVar2 = System_Action_AppScope_AverageFpsCalculatedEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AppScope_AverageFpsCalculatedEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_AppScope_AnswerFromServerReceivedEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AppAnalyticsListener_AnswerFromServerReceivedEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AppScope_AnswerFromServerReceivedEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x20) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AppScope_AnswerFromServerReceivedEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x20) = iVar3;
		    uVar2 = System_Action_AppScope_AnswerFromServerReceivedEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AppScope_AnswerFromServerReceivedEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_AppScope_LoadingEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AppAnalyticsListener_AppLoadingEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AppScope_LoadingEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x24) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AppScope_LoadingEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x24) = iVar3;
		    uVar2 = System_Action_AppScope_LoadingEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AppScope_LoadingEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x28);
		  uVar2 = unnamed_function_1417(System_Action_AppScope_LoadingEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AppAnalyticsListener_GameLoadingEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AppScope_LoadingEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x28) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AppScope_LoadingEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x28) = iVar3;
		    uVar2 = System_Action_AppScope_LoadingEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AppScope_LoadingEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x2c);
		  uVar2 = unnamed_function_1417(System_Action_AppScope_LatencyMonitorArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AppAnalyticsListener_LatencyMonitorEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AppScope_LatencyMonitorArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x2c) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_AppScope_LatencyMonitorArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x2c) = iVar3;
		    uVar2 = System_Action_AppScope_LatencyMonitorArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AppScope_LatencyMonitorArgs__TypeInfo);
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
