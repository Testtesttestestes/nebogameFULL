using System;
using Core.Events;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012D9 RID: 4825
	[Token(Token = "0x20012D9")]
	public class PlatformSpecificAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x060072BD RID: 29373 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700173D")]
		protected override string Theme
		{
			[Token(Token = "0x60072BD")]
			[Address(RVA = "0xBCC6", Offset = "0xBCC6", VA = "0xBCC6", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072BE RID: 29374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072BE")]
		[Address(RVA = "0xBCC7", Offset = "0xBCC7", VA = "0xBCC7", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_PlatformSpecificAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59600 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseEventBusEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_PlatformSpecificAnalyticsListener_GdprAgreedEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_PlatformSpecificAnalyticsListener_OnAppsFlyerAppOpenAttributionEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_PlatformSpecificAnalyticsListener_OnAppsFlyerConversionDataFailEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_PlatformSpecificAnalyticsListener_OnAppsFlyerConversionDataSuccessEvent__
		              );
		    DAT_ram_00a59600 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x18);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_PlatformSpecificAnalyticsListener_GdprAgreedEvent__,0);
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
		  iVar4 = *(int *)(iVar1 + 0x18);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_PlatformSpecificAnalyticsListener_OnAppsFlyerAppOpenAttributionEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x18);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_PlatformSpecificAnalyticsListener_OnAppsFlyerConversionDataFailEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x18);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_PlatformSpecificAnalyticsListener_OnAppsFlyerConversionDataSuccessEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo);
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

		// Token: 0x060072BF RID: 29375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072BF")]
		[Address(RVA = "0xBCC8", Offset = "0xBCC8", VA = "0xBCC8", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_PlatformSpecificAnalyticsListener__Deinit
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  int iVar6;
		  
		  if (DAT_ram_00a59601 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19754);
		    DAT_ram_00a59601 = '\x01';
		  }
		  param1_00 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar1 = StringLiteral_19754;
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x8103a58f;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103a58f:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_00,uVar3,uVar1,uVar4,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072C0 RID: 29376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072C0")]
		[Address(RVA = "0xBCC9", Offset = "0xBCC9", VA = "0xBCC9")]
		private void OnAppsFlyerConversionDataFailEvent(PlatformSpecificScope.AppsFlyerEventArgs e)
		{
		/* --- GHIDRA: OnAppsFlyerConversionDataFailEvent ---
		void Core_Analytics_Listeners_PlatformSpecificAnalyticsListener__OnAppsFlyerConversionDataFailEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  uint *puVar7;
		  int *piVar8;
		  int iVar9;
		  uint uVar10;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 uStack_c;
		  undefined4 local_8;
		  undefined4 uStack_4;
		  
		  if (DAT_ram_00a59602 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__object__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__object__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__object__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__object__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__object__get_Value__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19755);
		    DAT_ram_00a59602 = '\x01';
		  }
		  local_8 = 0;
		  uStack_4 = 0;
		  local_10 = 0;
		  uStack_c = 0;
		  local_18 = 0;
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_18,param2[4],
		             Method_System_Collections_Generic_Dictionary_string__object__GetEnumerator__);
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x158,&local_18,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_string__object__MoveNext__
		                      );
		    uVar5 = local_8;
		    uVar3 = uStack_c;
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8103a793;
		    }
		    if (iVar1 == 0) goto code_r0x8103a7e9;
		    piVar4 = (int *)param1[2];
		    iVar9 = *piVar4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8);
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(iVar9 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x8103a72d;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar4,
		                        Core_Analytics_Service_IAnalyticsApi_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x8103a72d:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii(*puVar2,piVar4,uVar3,uVar5,puVar2[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8103a793:
		  iVar9 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar1) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar1 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x8103a7e9:
		      DAT_ram_009d3e38 = 0;
		      piVar4 = (int *)param1[2];
		      uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xec));
		      uVar10 = 0;
		      uVar6 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0xe4));
		      uVar3 = StringLiteral_19755;
		      iVar9 = *piVar4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        do {
		          if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		              *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		            puVar7 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + iVar9 + 0xd8);
		            goto code_r0x8103a89b;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		      }
		      puVar7 = (uint *)func_ii_1080(piVar4,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103a89b:
		      (**(code **)((ulonglong)*puVar7 * 4))(piVar4,uVar5,uVar3,uVar6,puVar7[1]);
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x33d,&local_20);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060072C1 RID: 29377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072C1")]
		[Address(RVA = "0xBCCA", Offset = "0xBCCA", VA = "0xBCCA")]
		private void OnAppsFlyerConversionDataSuccessEvent(PlatformSpecificScope.AppsFlyerEventArgs e)
		{
		/* --- GHIDRA: OnAppsFlyerConversionDataSuccessEvent ---
		void Core_Analytics_Listeners_PlatformSpecificAnalyticsListener__OnAppsFlyerConversionDataSuccessEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  uint *puVar7;
		  int *piVar8;
		  int iVar9;
		  uint uVar10;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 uStack_c;
		  undefined4 local_8;
		  undefined4 uStack_4;
		  
		  if (DAT_ram_00a59603 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__object__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__object__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__object__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__object__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__object__get_Value__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19753);
		    DAT_ram_00a59603 = '\x01';
		  }
		  local_8 = 0;
		  uStack_4 = 0;
		  local_10 = 0;
		  uStack_c = 0;
		  local_18 = 0;
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_18,param2[4],
		             Method_System_Collections_Generic_Dictionary_string__object__GetEnumerator__);
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x158,&local_18,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_string__object__MoveNext__
		                      );
		    uVar5 = local_8;
		    uVar3 = uStack_c;
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8103aaf0;
		    }
		    if (iVar1 == 0) goto code_r0x8103ab46;
		    piVar4 = (int *)param1[2];
		    iVar9 = *piVar4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8);
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(iVar9 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x8103aa8a;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar4,
		                        Core_Analytics_Service_IAnalyticsApi_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x8103aa8a:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii(*puVar2,piVar4,uVar3,uVar5,puVar2[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8103aaf0:
		  iVar9 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar1) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar1 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x8103ab46:
		      DAT_ram_009d3e38 = 0;
		      piVar4 = (int *)param1[2];
		      uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xec));
		      uVar10 = 0;
		      uVar6 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0xe4));
		      uVar3 = StringLiteral_19753;
		      iVar9 = *piVar4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        do {
		          if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		              *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		            puVar7 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + iVar9 + 0xd8);
		            goto code_r0x8103abf8;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		      }
		      puVar7 = (uint *)func_ii_1080(piVar4,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103abf8:
		      (**(code **)((ulonglong)*puVar7 * 4))(piVar4,uVar5,uVar3,uVar6,puVar7[1]);
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x33e,&local_20);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060072C2 RID: 29378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072C2")]
		[Address(RVA = "0xBCCB", Offset = "0xBCCB", VA = "0xBCCB")]
		private void OnAppsFlyerAppOpenAttributionEvent(PlatformSpecificScope.AppsFlyerEventArgs e)
		{
		/* --- GHIDRA: OnAppsFlyerAppOpenAttributionEvent ---
		void Core_Analytics_Listeners_PlatformSpecificAnalyticsListener__OnAppsFlyerAppOpenAttributionEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  int iVar6;
		  
		  if (DAT_ram_00a59604 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23326);
		    DAT_ram_00a59604 = '\x01';
		  }
		  param1_00 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar4 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  uVar1 = StringLiteral_23326;
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x8103ad26;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103ad26:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_00,uVar3,uVar1,uVar4,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072C3 RID: 29379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072C3")]
		[Address(RVA = "0xBCCC", Offset = "0xBCCC", VA = "0xBCCC")]
		private void GdprAgreedEvent(BaseEventBusEventArgs e)
		{
		}

		// Token: 0x060072C4 RID: 29380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072C4")]
		[Address(RVA = "0xBCCD", Offset = "0xBCCD", VA = "0xBCCD")]
		public PlatformSpecificAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_PlatformSpecificAnalyticsListener___ctor
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59605 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_26118);
		    DAT_ram_00a59605 = '\x01';
		  }
		  return StringLiteral_26118;
		}
		*/

		}

		// Token: 0x04003C16 RID: 15382
		[Token(Token = "0x4003C16")]
		private const string GDPR_AGREED = "gdpr_agreed";

		// Token: 0x04003C17 RID: 15383
		[Token(Token = "0x4003C17")]
		private const string AF_CONVERSION_DATA_SUCCESS = "af_conversion_data_success";

		// Token: 0x04003C18 RID: 15384
		[Token(Token = "0x4003C18")]
		private const string AF_CONVERSION_DATA_FAIL = "af_conversion_data_fail";

		// Token: 0x04003C19 RID: 15385
		[Token(Token = "0x4003C19")]
		private const string AF_APP_OPEN_ATTRIBUTION = "af_app_open_attribution";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_PlatformSpecificAnalyticsListener__get_Theme
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a595ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseEventBusEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_PlatformSpecificAnalyticsListener_GdprAgreedEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_PlatformSpecificAnalyticsListener_OnAppsFlyerAppOpenAttributionEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_PlatformSpecificAnalyticsListener_OnAppsFlyerConversionDataFailEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_PlatformSpecificAnalyticsListener_OnAppsFlyerConversionDataSuccessEvent__
		              );
		    DAT_ram_00a595ff = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x18);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_PlatformSpecificAnalyticsListener_GdprAgreedEvent__,0);
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
		  iVar4 = *(int *)(iVar1 + 0x18);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_PlatformSpecificAnalyticsListener_OnAppsFlyerAppOpenAttributionEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x18);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_PlatformSpecificAnalyticsListener_OnAppsFlyerConversionDataFailEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x18);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_PlatformSpecificAnalyticsListener_OnAppsFlyerConversionDataSuccessEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_PlatformSpecificScope_AppsFlyerEventArgs__TypeInfo);
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
