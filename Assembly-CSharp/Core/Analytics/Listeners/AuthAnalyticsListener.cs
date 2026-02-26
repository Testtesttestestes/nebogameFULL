using System;
using Core.Events.Scopes;
using Il2CppDummyDll;
using Protocol.Auth2;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012C2 RID: 4802
	[Token(Token = "0x20012C2")]
	public class AuthAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x06007208 RID: 29192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001726")]
		protected override string Theme
		{
			[Token(Token = "0x6007208")]
			[Address(RVA = "0xBC11", Offset = "0xBC11", VA = "0xBC11", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007209 RID: 29193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007209")]
		[Address(RVA = "0xBC12", Offset = "0xBC12", VA = "0xBC12", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_AuthAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59562 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AuthScope_RegistrationRequestEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AuthScope_LoginErrorEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AuthScope_BaseAuthEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AuthScope_SyncAccountEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AuthScope_RegisterErrorEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AuthAnalyticsListener_LoginErrorEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AuthAnalyticsListener_LoginEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AuthAnalyticsListener_RegisterEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AuthAnalyticsListener_RegistrationErrorEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AuthAnalyticsListener_RegistrationRequestEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_AuthAnalyticsListener_SyncAccountProcessCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AuthAnalyticsListener_SyncAccountProcessStartEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AuthAnalyticsListener_UserIdChangedEvent__);
		    DAT_ram_00a59562 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 8);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_AuthScope_BaseAuthEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AuthAnalyticsListener_LoginEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AuthScope_BaseAuthEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AuthScope_BaseAuthEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_AuthScope_BaseAuthEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AuthScope_BaseAuthEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 8);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_AuthScope_LoginErrorEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AuthAnalyticsListener_LoginErrorEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AuthScope_LoginErrorEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AuthScope_LoginErrorEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_AuthScope_LoginErrorEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AuthScope_LoginErrorEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 8);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_AuthScope_BaseAuthEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AuthAnalyticsListener_RegisterEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AuthScope_BaseAuthEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AuthScope_BaseAuthEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_AuthScope_BaseAuthEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AuthScope_BaseAuthEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 8);
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_AuthScope_BaseAuthEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AuthAnalyticsListener_UserIdChangedEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AuthScope_BaseAuthEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AuthScope_BaseAuthEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x1c) = iVar3;
		    uVar2 = System_Action_AuthScope_BaseAuthEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AuthScope_BaseAuthEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 8);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_AuthScope_RegistrationRequestEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AuthAnalyticsListener_RegistrationRequestEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AuthScope_RegistrationRequestEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AuthScope_RegistrationRequestEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_AuthScope_RegistrationRequestEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AuthScope_RegistrationRequestEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 8);
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_AuthScope_RegisterErrorEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AuthAnalyticsListener_RegistrationErrorEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AuthScope_RegisterErrorEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AuthScope_RegisterErrorEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar2 = System_Action_AuthScope_RegisterErrorEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AuthScope_RegisterErrorEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 8);
		  uVar5 = *(undefined4 *)(iVar4 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_AuthScope_SyncAccountEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AuthAnalyticsListener_SyncAccountProcessStartEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AuthScope_SyncAccountEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x20) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AuthScope_SyncAccountEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x20) = iVar3;
		    uVar2 = System_Action_AuthScope_SyncAccountEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AuthScope_SyncAccountEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 8);
		  uVar5 = *(undefined4 *)(iVar4 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_AuthScope_SyncAccountEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AuthAnalyticsListener_SyncAccountProcessCompleteEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AuthScope_SyncAccountEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x24) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_AuthScope_SyncAccountEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x24) = iVar3;
		    uVar2 = System_Action_AuthScope_SyncAccountEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AuthScope_SyncAccountEventArgs__TypeInfo);
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

		// Token: 0x0600720A RID: 29194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600720A")]
		[Address(RVA = "0xBC13", Offset = "0xBC13", VA = "0xBC13", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_AuthAnalyticsListener__Deinit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *piVar6;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  int local_c;
		  int *local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59563 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Contains_LoginCmd_Types_Result___);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_IPlatformSigninProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_LoginCmd_Types_Result_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22982);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27760);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21231);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27758);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26029);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22980);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27759);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25767);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25184);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26352);
		    DAT_ram_00a59563 = '\x01';
		  }
		  local_8 = (int *)0x0;
		  iVar2 = Core_Data_RewardData__get_RewardId
		                    (param1[4],*(undefined4 *)(param2 + 0x10),
		                     Method_System_Linq_Enumerable_Contains_LoginCmd_Types_Result___);
		  if (iVar2 == 0) {
		    local_4 = *(undefined4 *)(*(int *)(param2 + 0x14) + 0xc);
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
		    uVar3 = func_ii_4443(&local_4,0);
		    uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_26352,uVar3,0);
		    func_ii_2946(param1_00,uVar3,*(undefined4 *)(*(int *)(param2 + 0x14) + 0x10),
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    local_c = *(int *)(param2 + 0x10);
		    if (local_c == 3) {
		      uVar1 = 0;
		      piVar6 = *(int **)(param2 + 8);
		      iVar2 = *piVar6;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x118);
		            goto code_r0x810295e6;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,0xb);
		code_r0x810295e6:
		      uVar1 = 0;
		      uVar3 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		      uVar3 = System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_object___LoggedManager__Register_d__52_
		                        (uVar3,0);
		      func_ii_2946(param1_00,StringLiteral_21231,uVar3,
		                   Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		      piVar6 = (int *)param1[2];
		      uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xec));
		      uVar3 = StringLiteral_25767;
		      iVar2 = *piVar6;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		              *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd8);
		            goto code_r0x810296b1;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar6,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810296b1:
		      (**(code **)((ulonglong)*puVar5 * 4))(piVar6,uVar4,uVar3,param1_00,puVar5[1]);
		    }
		    else {
		      uVar3 = func_ii_1081(DAT_ram_00a66954,&local_c);
		      func_ii_2946(param1_00,StringLiteral_22980,uVar3,
		                   Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		      local_14 = 0xffffffff;
		      local_18 = Protocol_Auth2_LoginCmd_Types_Result_TypeInfo;
		      local_10 = *(undefined4 *)(param2 + 0x10);
		      uVar3 = Spine_SkeletonJson__GetFloat(&local_18,0);
		      uVar3 = func_ii_7775(uVar3,0);
		      func_ii_2946(param1_00,StringLiteral_22982,uVar3,
		                   Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		      if (*(int *)(param2 + 0x10) == 4) {
		        piVar6 = *(int **)(param2 + 8);
		        iVar2 = *piVar6;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		              puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x128
		                               );
		              goto code_r0x810297b9;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,0xd);
		code_r0x810297b9:
		        iVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		        uVar1 = 0;
		        piVar6 = *(int **)(iVar2 + 0xc);
		        iVar2 = *piVar6;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          do {
		            if (Core_Application_Managers_IPlatformSigninProvider_TypeInfo ==
		                *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		              puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0)
		              ;
		              goto code_r0x8102983e;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar6,
		                                      Core_Application_Managers_IPlatformSigninProvider_TypeInfo,2);
		code_r0x8102983e:
		        iVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		        uVar3 = *(undefined4 *)(iVar2 + 0x14);
		        func_ii_2946(param1_00,StringLiteral_27760,uVar3,
		                     Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		        iVar2 = Utils_JWT___ctor(uVar3,&local_8,0);
		        if (iVar2 == 0) {
		          func_ii_2946(param1_00,StringLiteral_27759,StringLiteral_26029,
		                       Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		          func_ii_2946(param1_00,StringLiteral_27758,StringLiteral_26029,
		                       Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		        }
		        else {
		          uVar3 = Utils_JWT__GetBackTime(local_8,0);
		          local_18 = CONCAT31(local_18._1_3_,(char)uVar3);
		          uVar3 = func_ii_1081(DAT_ram_00a66944,&local_18);
		          func_ii_2946(param1_00,StringLiteral_27759,uVar3,
		                       Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		          uVar3 = (**(code **)((ulonglong)*(uint *)(*local_8 + 0xd8) * 4))
		                            (local_8,*(undefined4 *)(*local_8 + 0xdc));
		          func_ii_2946(param1_00,StringLiteral_27758,uVar3,
		                       Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		        }
		      }
		      piVar6 = (int *)param1[2];
		      uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xec));
		      uVar3 = StringLiteral_25184;
		      iVar2 = *piVar6;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		              *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd8);
		            goto code_r0x810299c6;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar6,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810299c6:
		      (**(code **)((ulonglong)*puVar5 * 4))(piVar6,uVar4,uVar3,param1_00,puVar5[1]);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600720B RID: 29195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600720B")]
		[Address(RVA = "0xBC14", Offset = "0xBC14", VA = "0xBC14")]
		private void LoginErrorEvent(AuthScope.LoginErrorEventArgs e)
		{
		/* --- GHIDRA: LoginErrorEvent ---
		void Core_Analytics_Listeners_AuthAnalyticsListener__LoginErrorEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_01;
		  int iVar4;
		  uint uVar5;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  uVar5 = 0;
		  if (DAT_ram_00a59564 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_RegisterCmd_Types_Result_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22982);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22980);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26367);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26352);
		    DAT_ram_00a59564 = '\x01';
		  }
		  local_4 = *(undefined4 *)(*(int *)(param2 + 0x14) + 0xc);
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  local_8 = *(undefined4 *)(param2 + 0x10);
		  uVar1 = func_ii_1081(DAT_ram_00a66954,&local_8);
		  func_ii_2946(param1_00,StringLiteral_22980,uVar1,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_c = *(undefined4 *)(param2 + 0x10);
		  local_10 = 0xffffffff;
		  local_14 = Protocol_Auth2_RegisterCmd_Types_Result_TypeInfo;
		  uVar1 = Spine_SkeletonJson__GetFloat(&local_14,0);
		  uVar1 = func_ii_7775(uVar1,0);
		  func_ii_2946(param1_00,StringLiteral_22982,uVar1,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar1 = func_ii_4443(&local_4,0);
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_26352,uVar1,0);
		  func_ii_2946(param1_00,uVar1,*(undefined4 *)(*(int *)(param2 + 0x14) + 0x10),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_26367;
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0xd8);
		        goto code_r0x81029bc9;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81029bc9:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_01,uVar2,uVar1,param1_00,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600720C RID: 29196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600720C")]
		[Address(RVA = "0xBC15", Offset = "0xBC15", VA = "0xBC15")]
		private void RegistrationErrorEvent(AuthScope.RegisterErrorEventArgs e)
		{
		/* --- GHIDRA: RegistrationErrorEvent ---
		void Core_Analytics_Listeners_AuthAnalyticsListener__RegistrationErrorEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 local_8;
		  int local_4;
		  
		  if (DAT_ram_00a59565 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25589);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26368);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19893);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23328);
		    DAT_ram_00a59565 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0xe4));
		  func_ii_2946(param1_00,StringLiteral_25589,param2[4],
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_4 = param2[5];
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_19893,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  piVar5 = (int *)param2[3];
		  if (piVar5 != (int *)0x0) {
		    uVar1 = 0;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		          goto code_r0x81029d1a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81029d1a:
		    iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		    if ((iVar6 != 0) &&
		       (iVar6 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(iVar6,0), iVar6 != 0))
		    {
		      piVar5 = (int *)param2[3];
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		            goto code_r0x81029da9;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81029da9:
		      uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		      uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		      iVar6 = Core_Extensions_Dict_DictExt__GetArtikulTypeFiltersByFilterType(uVar2,param2[5],0);
		      if (iVar6 != 0) {
		        local_8 = *(undefined4 *)(iVar6 + 0x10);
		        uVar2 = func_ii_1081(DAT_ram_00a66954,&local_8);
		        func_ii_2946(param1_00,StringLiteral_23328,uVar2,
		                     Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		      }
		    }
		  }
		  piVar5 = (int *)param1[2];
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_26368;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x81029e9f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81029e9f:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600720D RID: 29197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600720D")]
		[Address(RVA = "0xBC16", Offset = "0xBC16", VA = "0xBC16")]
		private void RegistrationRequestEvent(AuthScope.RegistrationRequestEventArgs e)
		{
		/* --- GHIDRA: RegistrationRequestEvent ---
		void Core_Analytics_Listeners_AuthAnalyticsListener__RegistrationRequestEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a59566 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IAuthDataProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23317);
		    DAT_ram_00a59566 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  param1_01 = *(int **)(param2 + 0x10);
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8))
		      {
		        puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81029f60;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x81029f60:
		  uVar2 = 0;
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  uVar4 = func_ii_8783(iVar5 + 8,0);
		  uVar1 = StringLiteral_23317;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x81029ff5;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x81029ff5:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar1,uVar4,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600720E RID: 29198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600720E")]
		[Address(RVA = "0xBC17", Offset = "0xBC17", VA = "0xBC17")]
		private void UserIdChangedEvent(AuthScope.BaseAuthEventArgs e)
		{
		/* --- GHIDRA: UserIdChangedEvent ---
		void Core_Analytics_Listeners_AuthAnalyticsListener__UserIdChangedEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int *param1_00;
		  undefined4 uVar7;
		  undefined4 local_24;
		  undefined4 local_20 [2];
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59567 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IAuthDataProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23317);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26366);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26364);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26363);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26352);
		    DAT_ram_00a59567 = '\x01';
		  }
		  piVar5 = (int *)param2[4];
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8102a0d9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x8102a0d9:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar7 = *(undefined4 *)(*(int *)(iVar6 + 0x34) + 0xc);
		  piVar5 = (int *)param1[2];
		  local_24 = uVar7;
		  if (DAT_ram_00a59528 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    DAT_ram_00a59528 = '\x01';
		  }
		  if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTimeOffset_TypeInfo);
		  }
		  uVar1 = 0;
		  func_ii_13875(local_20,0);
		  local_8 = local_18;
		  local_10 = System_DateTimeOffset__get_Now(&local_10,0);
		  uVar3 = func_ii_1081(DAT_ram_00a66964,&local_10);
		  uVar4 = StringLiteral_26364;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8102a1ed;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,0);
		code_r0x8102a1ed:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar4,uVar3,puVar2[1]);
		  piVar5 = (int *)param1[2];
		  uVar1 = 0;
		  uVar3 = Core_Analytics_Listeners_AbstractAnalyticsListener__GetEmptyProperties(0,0);
		  uVar4 = StringLiteral_26363;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8102a282;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,0);
		code_r0x8102a282:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar4,uVar3,puVar2[1]);
		  piVar5 = (int *)param1[2];
		  uVar1 = 0;
		  local_20[0] = uVar7;
		  uVar4 = func_ii_1081(DAT_ram_00a66954,local_20);
		  uVar7 = StringLiteral_26352;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x8102a328;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x8102a328:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar7,uVar4,puVar2[1]);
		  uVar1 = 0;
		  piVar5 = (int *)param1[2];
		  param1_00 = (int *)param2[4];
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8102a3ae;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x8102a3ae:
		  uVar1 = 0;
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar4 = func_ii_8783(iVar6 + 8,0);
		  uVar7 = StringLiteral_23317;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x8102a443;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x8102a443:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar7,uVar4,puVar2[1]);
		  uVar1 = 0;
		  piVar5 = (int *)param2[4];
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8102a4c2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x8102a4c2:
		  uVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar7 = Core_Gameplay_Tokens_TokenProvider__System_IDisposable_Dispose(uVar7,0);
		  uVar1 = 0;
		  Core_Analytics_Listeners_AuthAnalyticsListener__LoginEvent(param1,uVar7,0);
		  uVar7 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar4 = func_ii_4443(&local_24,0);
		  uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_26352,uVar4,0);
		  piVar5 = (int *)param2[4];
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8102a588;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x8102a588:
		  uVar1 = 0;
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  func_ii_2946(uVar7,uVar4,*(undefined4 *)(*(int *)(iVar6 + 0x34) + 0x10),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  piVar5 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar4 = StringLiteral_26366;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x8102a649;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102a649:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar3,uVar4,uVar7,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600720F RID: 29199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600720F")]
		[Address(RVA = "0xBC18", Offset = "0xBC18", VA = "0xBC18")]
		private void RegisterEvent(AuthScope.BaseAuthEventArgs e)
		{
		/* --- GHIDRA: RegisterEvent ---
		void Core_Analytics_Listeners_AuthAnalyticsListener__RegisterEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  int *param1_00;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59568 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IAuthDataProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23317);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25183);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26352);
		    DAT_ram_00a59568 = '\x01';
		  }
		  piVar6 = (int *)param2[4];
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8102a80b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x8102a80b:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  local_8 = *(undefined4 *)(*(int *)(iVar7 + 0x34) + 0xc);
		  piVar6 = (int *)param1[2];
		  uVar1 = 0;
		  local_4 = local_8;
		  uVar3 = func_ii_1081(DAT_ram_00a66954,&local_8);
		  uVar4 = StringLiteral_26352;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 200);
		        goto code_r0x8102a8c2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x8102a8c2:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar6,uVar4,uVar3,puVar2[1]);
		  uVar1 = 0;
		  piVar6 = (int *)param1[2];
		  param1_00 = (int *)param2[4];
		  iVar7 = *param1_00;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8102a948;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x8102a948:
		  uVar1 = 0;
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = func_ii_8783(iVar7 + 8,0);
		  uVar4 = StringLiteral_23317;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 200);
		        goto code_r0x8102a9dd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x8102a9dd:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar6,uVar4,uVar3,puVar2[1]);
		  uVar1 = 0;
		  piVar6 = (int *)param2[4];
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8102aa5c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x8102aa5c:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar4 = Core_Gameplay_Tokens_TokenProvider__System_IDisposable_Dispose(uVar4,0);
		  uVar1 = 0;
		  Core_Analytics_Listeners_AuthAnalyticsListener__LoginEvent(param1,uVar4,0);
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar3 = func_ii_4443(&local_4,0);
		  uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_26352,uVar3,0);
		  piVar6 = (int *)param2[4];
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8102ab22;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x8102ab22:
		  uVar1 = 0;
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  func_ii_2946(uVar4,uVar3,*(undefined4 *)(*(int *)(iVar7 + 0x34) + 0x10),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  piVar6 = (int *)param1[2];
		  uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar3 = StringLiteral_25183;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd8);
		        goto code_r0x8102abe3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102abe3:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar6,uVar5,uVar3,uVar4,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007210 RID: 29200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007210")]
		[Address(RVA = "0xBC19", Offset = "0xBC19", VA = "0xBC19")]
		private void LoginEvent(AuthScope.BaseAuthEventArgs e)
		{
		/* --- GHIDRA: LoginEvent ---
		void Core_Analytics_Listeners_AuthAnalyticsListener__LoginEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a59569 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24817);
		    DAT_ram_00a59569 = '\x01';
		  }
		  if (param2 != 0) {
		    param1_00 = *(int **)(param1 + 8);
		    local_1 = 1;
		    uVar2 = 0;
		    uVar3 = func_ii_1081(DAT_ram_00a66944,&local_1);
		    uVar1 = StringLiteral_24817;
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8102a72f;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,0);
		code_r0x8102a72f:
		    (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar1,uVar3,puVar4[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007211 RID: 29201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007211")]
		[Address(RVA = "0xBC1A", Offset = "0xBC1A", VA = "0xBC1A")]
		private void SetIsTester(bool value)
		{
		/* --- GHIDRA: SetIsTester ---
		void Core_Analytics_Listeners_AuthAnalyticsListener__SetIsTester
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
		  
		  if (DAT_ram_00a5956a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27547);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26352);
		    DAT_ram_00a5956a = '\x01';
		  }
		  local_4 = 0;
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  if (*(int *)(param2 + 0x20) != 0) {
		    local_4 = *(undefined4 *)(*(int *)(param2 + 0x20) + 0xc);
		    uVar2 = func_ii_4443(&local_4,0);
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_26352,uVar2,0);
		    func_ii_2946(param1_00,uVar2,*(undefined4 *)(*(int *)(param2 + 0x20) + 0x10),
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  }
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_27547;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8102ad62;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102ad62:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007212 RID: 29202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007212")]
		[Address(RVA = "0xBC1B", Offset = "0xBC1B", VA = "0xBC1B")]
		private void SyncAccountProcessStartEvent(AuthScope.SyncAccountEventArgs e)
		{
		/* --- GHIDRA: SyncAccountProcessStartEvent ---
		void Core_Analytics_Listeners_AuthAnalyticsListener__SyncAccountProcessStartEvent
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
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5956b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23317);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27546);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25096);
		    DAT_ram_00a5956b = '\x01';
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
		  local_8 = *(undefined8 *)(param2 + 0x10);
		  uVar2 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  func_ii_2946(param1_00,StringLiteral_23317,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_10 = *(undefined8 *)(param2 + 0x18);
		  uVar2 = func_ii_1081(DAT_ram_00a66968,&local_10);
		  func_ii_2946(param1_00,StringLiteral_25096,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_27546;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8102af00;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102af00:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007213 RID: 29203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007213")]
		[Address(RVA = "0xBC1C", Offset = "0xBC1C", VA = "0xBC1C")]
		private void SyncAccountProcessCompleteEvent(AuthScope.SyncAccountEventArgs e)
		{
		/* --- GHIDRA: SyncAccountProcessCompleteEvent ---
		void Core_Analytics_Listeners_AuthAnalyticsListener__SyncAccountProcessCompleteEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5956c == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_LoginCmd_Types_Result___TypeInfo);
		    DAT_ram_00a5956c = '\x01';
		  }
		  iVar1 = Mono_Security_ASN1Convert__ToOid(Protocol_Auth2_LoginCmd_Types_Result___TypeInfo,2);
		  *(undefined8 *)(iVar1 + 0x10) = 0x100000005;
		  *(int *)(param1 + 0x10) = iVar1;
		  Core_Analytics_Listeners_AbstractAnalyticsListener__GetResourceAnalyticsName(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06007214 RID: 29204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007214")]
		[Address(RVA = "0xBC1D", Offset = "0xBC1D", VA = "0xBC1D")]
		public AuthAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_AuthAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5956d == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_20463);
		    DAT_ram_00a5956d = '\x01';
		  }
		  return StringLiteral_20463;
		}
		*/

		}

		// Token: 0x04003BC0 RID: 15296
		[Token(Token = "0x4003BC0")]
		public const string THEME = "auth";

		// Token: 0x04003BC1 RID: 15297
		[Token(Token = "0x4003BC1")]
		public const string LOGIN = "login";

		// Token: 0x04003BC2 RID: 15298
		[Token(Token = "0x4003BC2")]
		public const string LOGIN_ERROR = "login_error";

		// Token: 0x04003BC3 RID: 15299
		[Token(Token = "0x4003BC3")]
		public const string OLD_CLIENT_LOGIN_ERROR = "old_client_login_error";

		// Token: 0x04003BC4 RID: 15300
		[Token(Token = "0x4003BC4")]
		public const string REGISTRATION = "registration";

		// Token: 0x04003BC5 RID: 15301
		[Token(Token = "0x4003BC5")]
		public const string REGISTRATION_REQUEST = "registration_request";

		// Token: 0x04003BC6 RID: 15302
		[Token(Token = "0x4003BC6")]
		public const string REGISTRATION_ERROR = "registration_error";

		// Token: 0x04003BC7 RID: 15303
		[Token(Token = "0x4003BC7")]
		private const string SYNC_ACCOUNT_PROCESS_START = "sync_account_process_start";

		// Token: 0x04003BC8 RID: 15304
		[Token(Token = "0x4003BC8")]
		private const string SYNC_ACCOUNT_PROCESS_COMPLETE = "sync_account_process_complete";

		// Token: 0x04003BC9 RID: 15305
		[Token(Token = "0x4003BC9")]
		[FieldOffset(Offset = "0x10")]
		private readonly LoginCmd.Types.Result[] _skipLoginErrors;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_AuthAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59561 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AuthScope_RegistrationRequestEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AuthScope_LoginErrorEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AuthScope_BaseAuthEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AuthScope_SyncAccountEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AuthScope_RegisterErrorEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AuthAnalyticsListener_LoginErrorEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AuthAnalyticsListener_LoginEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AuthAnalyticsListener_RegisterEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AuthAnalyticsListener_RegistrationErrorEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AuthAnalyticsListener_RegistrationRequestEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_AuthAnalyticsListener_SyncAccountProcessCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AuthAnalyticsListener_SyncAccountProcessStartEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AuthAnalyticsListener_UserIdChangedEvent__);
		    DAT_ram_00a59561 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 8);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_AuthScope_BaseAuthEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AuthAnalyticsListener_LoginEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AuthScope_BaseAuthEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AuthScope_BaseAuthEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_AuthScope_BaseAuthEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AuthScope_BaseAuthEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 8);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_AuthScope_LoginErrorEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AuthAnalyticsListener_LoginErrorEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AuthScope_LoginErrorEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AuthScope_LoginErrorEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_AuthScope_LoginErrorEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AuthScope_LoginErrorEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 8);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_AuthScope_BaseAuthEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AuthAnalyticsListener_RegisterEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AuthScope_BaseAuthEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AuthScope_BaseAuthEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_AuthScope_BaseAuthEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AuthScope_BaseAuthEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 8);
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_AuthScope_BaseAuthEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_AuthAnalyticsListener_UserIdChangedEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AuthScope_BaseAuthEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AuthScope_BaseAuthEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x1c) = iVar3;
		    uVar2 = System_Action_AuthScope_BaseAuthEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AuthScope_BaseAuthEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 8);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_AuthScope_RegistrationRequestEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AuthAnalyticsListener_RegistrationRequestEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AuthScope_RegistrationRequestEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AuthScope_RegistrationRequestEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_AuthScope_RegistrationRequestEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AuthScope_RegistrationRequestEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 8);
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_AuthScope_RegisterErrorEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AuthAnalyticsListener_RegistrationErrorEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AuthScope_RegisterErrorEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AuthScope_RegisterErrorEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar2 = System_Action_AuthScope_RegisterErrorEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AuthScope_RegisterErrorEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 8);
		  uVar5 = *(undefined4 *)(iVar4 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_AuthScope_SyncAccountEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AuthAnalyticsListener_SyncAccountProcessStartEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AuthScope_SyncAccountEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x20) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_AuthScope_SyncAccountEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x20) = iVar3;
		    uVar2 = System_Action_AuthScope_SyncAccountEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AuthScope_SyncAccountEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 8);
		  uVar5 = *(undefined4 *)(iVar4 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_AuthScope_SyncAccountEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AuthAnalyticsListener_SyncAccountProcessCompleteEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AuthScope_SyncAccountEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x24) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_AuthScope_SyncAccountEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x24) = iVar3;
		    uVar2 = System_Action_AuthScope_SyncAccountEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_AuthScope_SyncAccountEventArgs__TypeInfo);
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
