using System;
using System.Collections.Generic;
using System.Threading;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Model;
using Core.Gameplay.Managers.Ad.Placements;
using Core.Gameplay.Managers.Ad.Providers;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Services;
using ServicesNamespace;
using Utils;
using Utils.CoroutineUtils;

namespace Core.Gameplay.Managers.Ad.Controller
{
	// Token: 0x02001227 RID: 4647
	[Token(Token = "0x2001227")]
	public abstract class AbstractAdController : AbstractController<AbstractAdModel, AdEvents>, IAdController
	{
		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x06006E00 RID: 28160 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001658")]
		private IAdProvider DefaultProvider
		{
			[Token(Token = "0x6006E00")]
			[Address(RVA = "0xB8B6", Offset = "0xB8B6", VA = "0xB8B6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006E01 RID: 28161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E01")]
		[Address(RVA = "0xB8B7", Offset = "0xB8B7", VA = "0xB8B7", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a7c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_AbstractAdModel__AdEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Threading_CancellationTokenSource_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IAdProvider___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_uint__IAdProvider__TypeInfo)
		    ;
		    DAT_ram_00a5a7c1 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__IAdProvider__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar1,Method_System_Collections_Generic_Dictionary_uint__IAdProvider___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  uVar1 = unnamed_function_1417(System_Threading_CancellationTokenSource_TypeInfo);
		  Gameplay_Combat_Control_Conveyor__Next(uVar1,0);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param3,param4,Method_MVC_AbstractController_AbstractAdModel__AdEvents___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06006E02 RID: 28162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E02")]
		[Address(RVA = "0xB8B8", Offset = "0xB8B8", VA = "0xB8B8")]
		protected AbstractAdController(ServicesService servicesService, AbstractAdModel model, AdEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_3c;
		  undefined8 local_34;
		  undefined4 local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_14;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a7c2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AbstractAdController__InitializeAdProviders_d__7___
		              );
		    DAT_ram_00a5a7c2 = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  local_14 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_3c,0);
		  local_20 = local_34;
		  local_2c = 0xffffffff;
		  local_28 = local_3c;
		  local_18 = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start___Il2CppFullySharedGenericType_
		            (&local_28,&local_2c,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AbstractAdController__InitializeAdProviders_d__7___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06006E03 RID: 28163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E03")]
		[Address(RVA = "0xB8B9", Offset = "0xB8B9", VA = "0xB8B9")]
		private void InitializeAdProviders()
		{
		/* --- GHIDRA: InitializeAdProviders ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__InitializeAdProviders
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a7c3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController_AdAvailabilityChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController_ProviderOnAdClosedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController_ProviderOnAdErrorEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController_ProviderOnAdRewardedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IAdProvider_AdAvailabilityEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IAdProvider_AdErrorEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IAdProvider_AdInfoEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IAdProvider_BaseAdEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IAdProvider__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IAdProvider__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IAdProvider__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IAdProvider__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IAdProvider__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__IAdProvider__GetEnumerator__
		              );
		    DAT_ram_00a5a7c3 = '\x01';
		  }
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x1c),
		                     Method_System_Collections_Generic_Dictionary_uint__IAdProvider__get_Values__);
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_20,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__IAdProvider__GetEnumerator__
		            );
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IAdProvider__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81270333;
		    }
		    if (iVar3 == 0) goto code_r0x81270389;
		    DAT_ram_009d3e38 = 0;
		    piVar5 = local_8._4_4_;
		    uVar2 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_IAdProvider_AdInfoEventData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81270303:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81270333;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar2,param1,
		               Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController_ProviderOnAdRewardedEvent__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81270303;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 0x100);
		          goto code_r0x8126fe30;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo,8);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81270303;
		code_r0x8126fe30:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar4,piVar5,uVar2,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81270303;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_IAdProvider_AdErrorEventData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8127030d:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81270333;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar2,param1,
		               Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController_ProviderOnAdErrorEvent__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8127030d;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 0xf0);
		          goto code_r0x8126ff6d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo,6);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8127030d;
		code_r0x8126ff6d:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar4,piVar5,uVar2,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8127030d;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_IAdProvider_BaseAdEventData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81270317:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81270333;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar2,param1,
		               Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController_ProviderOnAdClosedEvent__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81270317;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 0xd0);
		          goto code_r0x812700aa;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo,2);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81270317;
		code_r0x812700aa:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar4,piVar5,uVar2,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81270317;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_IAdProvider_AdAvailabilityEventData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar2,param1,
		               Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController_AdAvailabilityChangedEventHandler__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 0xe0);
		          goto code_r0x812701e7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo,4);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x812701e7:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar4,piVar5,uVar2,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) break;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_IDisposable_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x812702b8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        System_IDisposable_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x812702b8:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(*puVar4,piVar5,puVar4[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81270333:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x81270389:
		      DAT_ram_009d3e38 = 0;
		      System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		                (*(undefined4 *)(param1 + 0x1c),
		                 Method_System_Collections_Generic_Dictionary_uint__IAdProvider__Clear__);
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0xc,&local_20);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006E04 RID: 28164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E04")]
		[Address(RVA = "0xB8BA", Offset = "0xB8BA", VA = "0xB8BA")]
		private void DestroyAllProviders()
		{
		/* --- GHIDRA: DestroyAllProviders ---
		undefined4
		Core_Gameplay_Managers_Ad_Controller_AbstractAdController__DestroyAllProviders
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *piVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  
		  if (DAT_ram_00a5a7c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_CoroutineUtils_WaitForCallBack_bool___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_CoroutineUtils_WaitForCallBack_bool__TypeInfo);
		    DAT_ram_00a5a7c4 = '\x01';
		  }
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		  if (*(int *)(iVar3 + 0xc) == 0) {
		    uVar4 = unnamed_function_1417(Utils_CoroutineUtils_WaitForCallBack_bool__TypeInfo);
		    UnityEngine_UIElements_VisualElement_VisualElementScheduledItem___Il2CppFullySharedGenericType____ctor
		              (uVar4,0,Method_Utils_CoroutineUtils_WaitForCallBack_bool___ctor__);
		    return uVar4;
		  }
		  if (DAT_ram_00a5a7bf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IAdProvider__get_Item__);
		    DAT_ram_00a5a7bf = '\x01';
		  }
		  iVar3 = param1[7];
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a5a7b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_uint___);
		    DAT_ram_00a5a7b4 = '\x01';
		  }
		  uVar1 = 0;
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		  uVar4 = System_Linq_Enumerable__FirstOrDefault_int_
		                    (uVar4,Method_System_Linq_Enumerable_FirstOrDefault_uint___);
		  piVar2 = (int *)System_Collections_Generic_List_object___get_Item
		                            (iVar3,uVar4,
		                             Method_System_Collections_Generic_Dictionary_uint__IAdProvider__get_Item__
		                            );
		  iVar3 = *piVar2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x118);
		        goto code_r0x8126b25e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar2,Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo,0xb)
		  ;
		code_r0x8126b25e:
		  uVar4 = (**(code **)((ulonglong)*puVar5 * 4))(piVar2,param2,puVar5[1]);
		  return uVar4;
		}
		*/

		}

		// Token: 0x06006E05 RID: 28165
		[Token(Token = "0x6006E05")]
		protected abstract IAdProvider CreateAdProvider(AdSource providerId);

		// Token: 0x06006E06 RID: 28166
		[Token(Token = "0x6006E06")]
		protected abstract void InitializeAdProvidersPreProcess();

		// Token: 0x06006E07 RID: 28167
		[Token(Token = "0x6006E07")]
		protected abstract void InitializeAdProvidersPostProcess();

		// Token: 0x06006E08 RID: 28168 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006E08")]
		[Address(RVA = "0xB8BB", Offset = "0xB8BB", VA = "0xB8BB")]
		private WaitForCallBack<bool> CheckIfAdAvailableByProvider(IAdPlacementData placement)
		{
		/* --- GHIDRA: CheckIfAdAvailableByProvider ---
		undefined4
		Core_Gameplay_Managers_Ad_Controller_AbstractAdController__CheckIfAdAvailableByProvider
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Gameplay_Managers_Ad_Controller_AbstractAdController__DestroyAllProviders
		                    (param1,param2,param2);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06006E09 RID: 28169 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006E09")]
		[Address(RVA = "0xB8BC", Offset = "0xB8BC", VA = "0xB8BC", Slot = "13")]
		public WaitForCallBack<bool> Check(IAdPlacementData placement)
		{
		/* --- GHIDRA: Check ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__Check(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 *puVar5;
		  int *piVar6;
		  int *piVar7;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a7c5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController_PlacementOnBacktimerCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController_ServicesServiceOnTransactionClosedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IAdPlacementData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AdTransactionClosedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IAdPlacementData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IAdPlacementData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IAdPlacementData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IAdPlacementData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__IAdPlacementData__GetEnumerator__
		              );
		    DAT_ram_00a5a7c5 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(iVar2 + 0x10),
		                     Method_System_Collections_Generic_Dictionary_uint__IAdPlacementData__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar3,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__IAdPlacementData__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IAdPlacementData__MoveNext__
		                      );
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812707a5;
		    }
		    if (iVar4 == 0) goto code_r0x812707fb;
		    DAT_ram_009d3e38 = 0;
		    piVar6 = local_8._4_4_;
		    uVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_IAdPlacementData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar3,param1,
		               Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController_PlacementOnBacktimerCompleteEvent__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo == *piVar7) {
		          puVar5 = (undefined4 *)(piVar7[1] * 8 + iVar2 + 200);
		          goto code_r0x81270746;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                        Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x81270746:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar5,piVar6,uVar3,puVar5[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x812707a5:
		  iVar2 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar4) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar4 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		      if (iVar4 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x812707fb:
		      DAT_ram_009d3e38 = 0;
		      iVar2 = param1[6];
		      uVar3 = unnamed_function_1417(System_Action_AdTransactionClosedEvt__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,
		                 Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController_ServicesServiceOnTransactionClosedEvent__
		                 ,0);
		      ServicesNamespace_ServicesService__add_TransactionClosedEvent(iVar2,uVar3,0);
		      System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		                (param1[8],0);
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0xd,&local_18);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
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

			return null;
		}

		// Token: 0x06006E0A RID: 28170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E0A")]
		[Address(RVA = "0xB8BD", Offset = "0xB8BD", VA = "0xB8BD", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__HandleStop
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param2_00;
		  undefined4 param4;
		  int iVar5;
		  undefined4 *puVar6;
		  int *piVar7;
		  undefined8 local_50;
		  undefined8 local_48;
		  undefined8 local_3c;
		  undefined8 local_34;
		  int local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  int *local_18;
		  undefined8 local_14;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a7c6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController_PlacementOnBacktimerCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController_ServicesServiceOnTransactionClosedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IAdPlacementData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AdTransactionClosedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IAdPlacementData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IAdPlacementData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IAdPlacementData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IAdPlacementData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__IAdPlacementData__GetEnumerator__
		              );
		    DAT_ram_00a5a7c6 = '\x01';
		  }
		  local_48 = 0;
		  local_50 = 0;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))(param1,*(undefined4 *)(*param1 + 0x13c));
		  if (DAT_ram_00a5a7c2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AbstractAdController__InitializeAdProviders_d__7___
		              );
		    DAT_ram_00a5a7c2 = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  local_14 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_3c,0);
		  local_20 = local_34;
		  local_2c = -1;
		  local_28 = local_3c;
		  local_18 = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start___Il2CppFullySharedGenericType_
		            (&local_28,&local_2c,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AbstractAdController__InitializeAdProviders_d__7___
		            );
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))(param1,*(undefined4 *)(*param1 + 0x144));
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		  if (*(int *)(iVar3 + 0xc) == 0) {
		    if (*(char *)((int)param1 + 9) == '\0') {
		      *(undefined1 *)((int)param1 + 9) = 1;
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar3 = *(int *)(iVar3 + 8);
		      if (iVar3 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                  (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		      }
		    }
		    return;
		  }
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x108) * 4))
		                        (piVar2,*(undefined4 *)(*piVar2 + 0x10c));
		  iVar3 = *param1;
		  param4 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x110) * 4))
		                     (param1,*(undefined4 *)(iVar3 + 0x114));
		  Core_Gameplay_Managers_Ad_Model_AbstractAdModel__set_CurrentTransaction
		            (uVar4,param2_00,param1,param4,iVar3);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar4 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(iVar3 + 0x10),
		                     Method_System_Collections_Generic_Dictionary_uint__IAdPlacementData__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_50,uVar4,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__IAdPlacementData__GetEnumerator__
		            );
		  local_2c = 0;
		  local_28 = CONCAT44(local_28._4_4_,&local_50);
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_50,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IAdPlacementData__MoveNext__
		                      );
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81270c76;
		    }
		    if (iVar5 == 0) goto code_r0x81270ccc;
		    DAT_ram_009d3e38 = 0;
		    piVar2 = local_48._4_4_;
		    uVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_IAdPlacementData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar4,param1,
		               Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController_PlacementOnBacktimerCompleteEvent__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    iVar3 = *piVar2;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		        if (Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo == *piVar7) {
		          puVar6 = (undefined4 *)(iVar3 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x81270c17;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar6 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar2,
		                        Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x81270c17:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar6,piVar2,uVar4,puVar6[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81270c76:
		  iVar3 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar5) {
		    piVar2 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar5 = *piVar2;
		    DAT_ram_009d3e38 = 0;
		    local_2c = iVar5;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		      if (iVar5 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x81270ccc:
		      DAT_ram_009d3e38 = 0;
		      piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                                (param1,*(undefined4 *)(*param1 + 0x104));
		      iVar3 = *piVar2;
		      uVar4 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x108) * 4))
		                        (piVar2,*(undefined4 *)(iVar3 + 0x10c));
		      Core_Gameplay_Managers_Ad_Controller_AbstractAdController__ValidateInit(param1,uVar4,iVar3);
		      iVar3 = param1[6];
		      uVar4 = unnamed_function_1417(System_Action_AdTransactionClosedEvt__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar4,param1,
		                 Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController_ServicesServiceOnTransactionClosedEvent__
		                 ,0);
		      ServicesNamespace_ServicesService__remove_RefPayEvent(iVar3,uVar4,0);
		      return;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0xe,&local_2c);
		  iVar3 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar3 != 1) {
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

		// Token: 0x06006E0B RID: 28171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E0B")]
		[Address(RVA = "0xB8BE", Offset = "0xB8BE", VA = "0xB8BE", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__HandleRun
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 8);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006E0C RID: 28172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E0C")]
		[Address(RVA = "0xB8BF", Offset = "0xB8BF", VA = "0xB8BF")]
		private void ValidateInit()
		{
		/* --- GHIDRA: ValidateInit ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__ValidateInit
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a5a7c7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController_HandleServiceGetPlacementInfo__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a5a7c7 = '\x01';
		  }
		  param1_01 = param1[6];
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a5a7b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_uint___);
		    DAT_ram_00a5a7b4 = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		  uVar2 = System_Linq_Enumerable__FirstOrDefault_int_
		                    (uVar2,Method_System_Linq_Enumerable_FirstOrDefault_uint___);
		  uVar2 = ServicesNamespace_ServicesService__PayoffBan(param1_01,param2,uVar2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController_HandleServiceGetPlacementInfo__
		             ,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06006E0D RID: 28173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E0D")]
		[Address(RVA = "0xB8C0", Offset = "0xB8C0", VA = "0xB8C0")]
		private void RequestPlacementInfo(IEnumerable<uint> placementIds)
		{
		/* --- GHIDRA: RequestPlacementInfo ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__RequestPlacementInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  uint *puVar7;
		  int *param1_00;
		  undefined4 param4;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a5a7c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AdScope_AdEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_CreateAdPlacementTxCmd_Types_Ans_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_DictionaryExt_ToDebugString_string__string___);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_471);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2828);
		    Mono_Security_ASN1__get_Item(&StringLiteral_449);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3162);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2827);
		    DAT_ram_00a5a7c9 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Services_CreateAdPlacementTxCmd_Types_Ans_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Services_CreateAdPlacementTxCmd_Types_Ans_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,6);
		  *(undefined4 *)(iVar2 + 0x10) = StringLiteral_2828;
		  *(undefined4 *)(iVar2 + 0x14) = *(undefined4 *)(param1_00[6] + 0x24);
		  *(undefined4 *)(iVar2 + 0x18) = StringLiteral_471;
		  *(int *)(iVar2 + 0x1c) = param1_00[4];
		  *(undefined4 *)(iVar2 + 0x20) = StringLiteral_449;
		  uVar3 = Core_Extensions_Dict_DictExt__GetArrayParameter___Il2CppFullySharedGenericType_
		                    (param1_00[5],
		                     Method_Core_Extensions_DictionaryExt_ToDebugString_string__string___);
		  *(undefined4 *)(iVar2 + 0x24) = uVar3;
		  uVar3 = System_Single__ToString(iVar2,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		  iVar2 = *param1;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                    (param1,*(undefined4 *)(iVar2 + 0x104));
		  func_ii_8781(uVar3,param1_00[6],iVar2);
		  iVar4 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                    (param1_00[4],0);
		  iVar2 = OKG_Logs_Debug_TypeInfo;
		  if (iVar4 != 0) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_2827,0);
		    Core_Gameplay_Managers_Ad_Controller_AbstractAdController__ProviderOnAdErrorEvent
		              (iVar2,**(undefined4 **)(DAT_ram_00a66978 + 0x5c),0xffffffff,StringLiteral_3162,iVar2)
		    ;
		    Core_Gameplay_Managers_Ad_Controller_AbstractAdController__CreateCurrentTransaction
		              (param1,iVar2);
		    return;
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(int **)(*(int *)(iVar2 + 0x1c) + 0x14) = param1_00;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x1c);
		  if (iVar2 != 0) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar4 + 0x1c),
		               *(undefined4 *)(iVar2 + 0x14));
		  }
		  if (DAT_ram_00a5a7ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		    DAT_ram_00a5a7ed = '\x01';
		  }
		  iVar2 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  if (iVar2 == 0) {
		    uVar3 = unnamed_function_1417(Core_Application_App_TypeInfo);
		    Core_Application_App__set_FileDownloadLogger(uVar3,uVar3);
		    **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar3;
		    iVar2 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  }
		  iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x90) + 0x10);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a5a7ed == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		      DAT_ram_00a5a7ed = '\x01';
		    }
		    iVar4 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    if (iVar4 == 0) {
		      uVar3 = unnamed_function_1417(Core_Application_App_TypeInfo);
		      Core_Application_App__set_FileDownloadLogger(uVar3,uVar3);
		      **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar3;
		      iVar4 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar8 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param4 = *(undefined4 *)(iVar5 + 0x1c);
		    uVar3 = unnamed_function_1417(Core_Events_Scopes_AdScope_AdEventArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(uVar3,iVar4,uVar8,param4,0);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar3,*(undefined4 *)(iVar2 + 0x14));
		  }
		  if (DAT_ram_00a5a7bf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IAdProvider__get_Item__);
		    DAT_ram_00a5a7bf = '\x01';
		  }
		  iVar2 = param1[7];
		  piVar6 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a5a7b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_uint___);
		    DAT_ram_00a5a7b4 = '\x01';
		  }
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x100) * 4))
		                    (piVar6,*(undefined4 *)(*piVar6 + 0x104));
		  uVar3 = System_Linq_Enumerable__FirstOrDefault_int_
		                    (uVar3,Method_System_Linq_Enumerable_FirstOrDefault_uint___);
		  piVar6 = (int *)System_Collections_Generic_List_object___get_Item
		                            (iVar2,uVar3,
		                             Method_System_Collections_Generic_Dictionary_uint__IAdProvider__get_Item__
		                            );
		  uVar8 = *(undefined4 *)(param1_00[6] + 0x24);
		  uVar1 = 0;
		  uVar3 = Core_Gameplay_Managers_Ad_Controller_AbstractAdController__HandleServiceCreateAdPlacementTx
		                    (param1,param1_00[5],0);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar7 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x110);
		        goto code_r0x81271314;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar7 = (uint *)func_ii_1080(piVar6,Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo,10);
		code_r0x81271314:
		  (**(code **)((ulonglong)*puVar7 * 4))(piVar6,uVar8,uVar3,puVar7[1]);
		  return;
		}
		*/

		/* --- GHIDRA: RequestPlacementInfo ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__RequestPlacementInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  uint *puVar7;
		  int *param1_00;
		  undefined4 param4;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a5a7c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AdScope_AdEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_CreateAdPlacementTxCmd_Types_Ans_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_DictionaryExt_ToDebugString_string__string___);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_471);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2828);
		    Mono_Security_ASN1__get_Item(&StringLiteral_449);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3162);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2827);
		    DAT_ram_00a5a7c9 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Services_CreateAdPlacementTxCmd_Types_Ans_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Services_CreateAdPlacementTxCmd_Types_Ans_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,6);
		  *(undefined4 *)(iVar2 + 0x10) = StringLiteral_2828;
		  *(undefined4 *)(iVar2 + 0x14) = *(undefined4 *)(param1_00[6] + 0x24);
		  *(undefined4 *)(iVar2 + 0x18) = StringLiteral_471;
		  *(int *)(iVar2 + 0x1c) = param1_00[4];
		  *(undefined4 *)(iVar2 + 0x20) = StringLiteral_449;
		  uVar3 = Core_Extensions_Dict_DictExt__GetArrayParameter___Il2CppFullySharedGenericType_
		                    (param1_00[5],
		                     Method_Core_Extensions_DictionaryExt_ToDebugString_string__string___);
		  *(undefined4 *)(iVar2 + 0x24) = uVar3;
		  uVar3 = System_Single__ToString(iVar2,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		  iVar2 = *param1;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                    (param1,*(undefined4 *)(iVar2 + 0x104));
		  func_ii_8781(uVar3,param1_00[6],iVar2);
		  iVar4 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                    (param1_00[4],0);
		  iVar2 = OKG_Logs_Debug_TypeInfo;
		  if (iVar4 != 0) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_2827,0);
		    Core_Gameplay_Managers_Ad_Controller_AbstractAdController__ProviderOnAdErrorEvent
		              (iVar2,**(undefined4 **)(DAT_ram_00a66978 + 0x5c),0xffffffff,StringLiteral_3162,iVar2)
		    ;
		    Core_Gameplay_Managers_Ad_Controller_AbstractAdController__CreateCurrentTransaction
		              (param1,iVar2);
		    return;
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(int **)(*(int *)(iVar2 + 0x1c) + 0x14) = param1_00;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x1c);
		  if (iVar2 != 0) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar4 + 0x1c),
		               *(undefined4 *)(iVar2 + 0x14));
		  }
		  if (DAT_ram_00a5a7ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		    DAT_ram_00a5a7ed = '\x01';
		  }
		  iVar2 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  if (iVar2 == 0) {
		    uVar3 = unnamed_function_1417(Core_Application_App_TypeInfo);
		    Core_Application_App__set_FileDownloadLogger(uVar3,uVar3);
		    **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar3;
		    iVar2 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  }
		  iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x90) + 0x10);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a5a7ed == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		      DAT_ram_00a5a7ed = '\x01';
		    }
		    iVar4 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    if (iVar4 == 0) {
		      uVar3 = unnamed_function_1417(Core_Application_App_TypeInfo);
		      Core_Application_App__set_FileDownloadLogger(uVar3,uVar3);
		      **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar3;
		      iVar4 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar8 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param4 = *(undefined4 *)(iVar5 + 0x1c);
		    uVar3 = unnamed_function_1417(Core_Events_Scopes_AdScope_AdEventArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(uVar3,iVar4,uVar8,param4,0);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar3,*(undefined4 *)(iVar2 + 0x14));
		  }
		  if (DAT_ram_00a5a7bf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IAdProvider__get_Item__);
		    DAT_ram_00a5a7bf = '\x01';
		  }
		  iVar2 = param1[7];
		  piVar6 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a5a7b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_uint___);
		    DAT_ram_00a5a7b4 = '\x01';
		  }
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x100) * 4))
		                    (piVar6,*(undefined4 *)(*piVar6 + 0x104));
		  uVar3 = System_Linq_Enumerable__FirstOrDefault_int_
		                    (uVar3,Method_System_Linq_Enumerable_FirstOrDefault_uint___);
		  piVar6 = (int *)System_Collections_Generic_List_object___get_Item
		                            (iVar2,uVar3,
		                             Method_System_Collections_Generic_Dictionary_uint__IAdProvider__get_Item__
		                            );
		  uVar8 = *(undefined4 *)(param1_00[6] + 0x24);
		  uVar1 = 0;
		  uVar3 = Core_Gameplay_Managers_Ad_Controller_AbstractAdController__HandleServiceCreateAdPlacementTx
		                    (param1,param1_00[5],0);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar7 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x110);
		        goto code_r0x81271314;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar7 = (uint *)func_ii_1080(piVar6,Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo,10);
		code_r0x81271314:
		  (**(code **)((ulonglong)*puVar7 * 4))(piVar6,uVar8,uVar3,puVar7[1]);
		  return;
		}
		*/

		}

		// Token: 0x06006E0E RID: 28174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E0E")]
		[Address(RVA = "0xB8C1", Offset = "0xB8C1", VA = "0xB8C1")]
		private void RequestPlacementInfo(uint placementId)
		{
		}

		// Token: 0x06006E0F RID: 28175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E0F")]
		[Address(RVA = "0xB8C2", Offset = "0xB8C2", VA = "0xB8C2")]
		private void HandleServiceCreateAdPlacementTx(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceCreateAdPlacementTx ---
		undefined4
		Core_Gameplay_Managers_Ad_Controller_AbstractAdController__HandleServiceCreateAdPlacementTx
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param3_00;
		  undefined4 *puVar3;
		  int param1_00;
		  int param1_01;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a7ca == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_string__string___string__string___
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_KeyValuePair_string__string___string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController___c__GetPayloadParameters_b__20_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController___c__GetPayloadParameters_b__20_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Ad_Controller_AbstractAdController___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28176);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2826);
		    DAT_ram_00a5a7ca = '\x01';
		  }
		  local_8 = 0;
		  if (*(int *)(Core_Gameplay_Managers_Ad_Controller_AbstractAdController___c_TypeInfo + 0x74) == 0)
		  {
		    func_ii_306000(Core_Gameplay_Managers_Ad_Controller_AbstractAdController___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)
		            (Core_Gameplay_Managers_Ad_Controller_AbstractAdController___c_TypeInfo + 0x5c);
		  param1_00 = puVar3[1];
		  iVar2 = Core_Gameplay_Managers_Ad_Controller_AbstractAdController___c_TypeInfo;
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Gameplay_Managers_Ad_Controller_AbstractAdController___c_TypeInfo + 0x74) == 0
		       ) {
		      func_ii_306000(Core_Gameplay_Managers_Ad_Controller_AbstractAdController___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Core_Gameplay_Managers_Ad_Controller_AbstractAdController___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    param1_00 = unnamed_function_1417(System_Func_KeyValuePair_string__string___string__TypeInfo);
		    func_ii_7795(param1_00,uVar1,
		                 Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController___c__GetPayloadParameters_b__20_0__
		                 ,0);
		    iVar2 = Core_Gameplay_Managers_Ad_Controller_AbstractAdController___c_TypeInfo;
		    *(int *)(*(int *)(Core_Gameplay_Managers_Ad_Controller_AbstractAdController___c_TypeInfo + 0x5c)
		            + 4) = param1_00;
		  }
		  if (*(int *)(iVar2 + 0x74) == 0) {
		    func_ii_306000(iVar2);
		    iVar2 = Core_Gameplay_Managers_Ad_Controller_AbstractAdController___c_TypeInfo;
		  }
		  puVar3 = *(undefined4 **)(iVar2 + 0x5c);
		  param1_01 = puVar3[2];
		  if (param1_01 == 0) {
		    if (*(int *)(iVar2 + 0x74) == 0) {
		      func_ii_306000(iVar2);
		      puVar3 = *(undefined4 **)
		                (Core_Gameplay_Managers_Ad_Controller_AbstractAdController___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    param1_01 = unnamed_function_1417(System_Func_KeyValuePair_string__string___string__TypeInfo);
		    func_ii_7795(param1_01,uVar1,
		                 Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController___c__GetPayloadParameters_b__20_1__
		                 ,0);
		    *(int *)(*(int *)(Core_Gameplay_Managers_Ad_Controller_AbstractAdController___c_TypeInfo + 0x5c)
		            + 8) = param1_01;
		  }
		  uVar1 = System_Func_KeyValuePair_object__object___object____ctor
		                    (param2,param1_00,param1_01,
		                     Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_string__string___string__string___
		                    );
		  iVar2 = System_Xml_Schema_SchemaInfo__get_Notations
		                    (uVar1,StringLiteral_28176,
		                     Method_System_Collections_Generic_Dictionary_string__string__ContainsKey__);
		  if (iVar2 == 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    local_8 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar2 + 8),0);
		    param3_00 = func_ii_8783(&local_8,0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar1,StringLiteral_28176,param3_00,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  }
		  else {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(StringLiteral_2826,0);
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x06006E10 RID: 28176 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006E10")]
		[Address(RVA = "0xB8C3", Offset = "0xB8C3", VA = "0xB8C3")]
		private Dictionary<string, string> GetPayloadParameters(MapField<string, string> rawPayload)
		{
		/* --- GHIDRA: GetPayloadParameters ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__GetPayloadParameters
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  uint *puVar5;
		  int *piVar6;
		  int iVar7;
		  int *piVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a7cb == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Services_GetAdPlacementsInfoCmd_Types_Ans_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_AdPlacementInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_AdPlacementInfo__GetEnumerator__);
		    DAT_ram_00a5a7cb = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar6 = *(int **)(param2 + 0x20);
		  if ((piVar6 != (int *)0x0) &&
		     (Protocol_Services_GetAdPlacementsInfoCmd_Types_Ans_TypeInfo != *piVar6)) {
		    System_Activator__CreateInstance
		              (piVar6,Protocol_Services_GetAdPlacementsInfoCmd_Types_Ans_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (piVar6[3],
		                              Method_Google_Protobuf_Collections_RepeatedField_AdPlacementInfo__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    do {
		      piVar6 = local_4;
		      iVar7 = *local_4;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		            puVar2 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x81271982;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x81271bcd:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81271bd5;
		      }
		code_r0x81271982:
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iii(*puVar2,piVar6,puVar2[1]);
		      piVar6 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81271bcd;
		      if (iVar7 == 0) {
		        iVar7 = 0;
		        goto code_r0x81271c1e;
		      }
		      iVar7 = *local_4;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_AdPlacementInfo__TypeInfo == *piVar8) {
		            puVar2 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x81271a5c;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_AdPlacementInfo__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x81271bb9:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81271bd5;
		      }
		code_r0x81271a5c:
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iii(*puVar2,piVar6,puVar2[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81271bb9;
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar4 = DAT_ram_009d3e38;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81271bc3;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_0000223f + 0xf,uVar3,iVar7,iVar4);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81271bc3;
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x110),param1,*(undefined4 *)(*param1 + 0x114));
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81271bc3;
		      iVar4 = *(int *)(iVar4 + 0x18);
		    } while (iVar4 == 0);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(iVar4 + 0xc),*(undefined4 *)(iVar4 + 0x20),
		               *(undefined4 *)(iVar7 + 0xc),*(undefined4 *)(iVar4 + 0x14));
		  } while (DAT_ram_009d3e38 != 1);
		code_r0x81271bc3:
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81271bd5:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar7 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar7;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x81271c1e:
		      piVar6 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar4 = *local_4;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar5 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81271c96;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar5 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81271c96:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		      }
		      if (iVar7 == 0) {
		        if (*(char *)((int)param1 + 9) == '\0') {
		          *(undefined1 *)((int)param1 + 9) = 1;
		          iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x114));
		          iVar7 = *(int *)(iVar7 + 8);
		          if (iVar7 != 0) {
		            (**(code **)((ulonglong)*(uint *)(iVar7 + 0xc) * 4))
		                      (*(undefined4 *)(iVar7 + 0x20),*(undefined4 *)(iVar7 + 0x14));
		          }
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x10,&local_c);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
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

			return null;
		}

		// Token: 0x06006E11 RID: 28177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E11")]
		[Address(RVA = "0xB8C4", Offset = "0xB8C4", VA = "0xB8C4")]
		private void HandleServiceGetPlacementInfo(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceGetPlacementInfo ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__HandleServiceGetPlacementInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  func_ii_8781(param1_00,param2,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2 + 0xc),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006E12 RID: 28178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E12")]
		[Address(RVA = "0xB8C5", Offset = "0xB8C5", VA = "0xB8C5")]
		private void UpdatePlacementInfo(AdPlacementInfo info)
		{
		/* --- GHIDRA: UpdatePlacementInfo ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__UpdatePlacementInfo
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int *piVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 param4_00;
		  int iVar8;
		  undefined4 local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a7cc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController_HandleServiceCreateAdPlacementTx__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AdScope_AdEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_AdPlacement_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2833);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2831);
		    Mono_Security_ASN1__get_Item(&StringLiteral_206);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3162);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2832);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27827);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14322);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2834);
		    DAT_ram_00a5a7cc = '\x01';
		  }
		  local_4 = (int *)0x0;
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		  if (*(int *)(iVar3 + 0xc) == 0) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_2832,0);
		  }
		  else {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (DAT_ram_00a5a7b9 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_uint__IAdPlacementData__TryGetValue__
		                );
		      DAT_ram_00a5a7b9 = '\x01';
		    }
		    iVar3 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                      (*(undefined4 *)(iVar3 + 0x10),param2,&local_4,
		                       Method_System_Collections_Generic_Dictionary_uint__IAdPlacementData__TryGetValue__
		                      );
		    local_8 = param2;
		    if (iVar3 == 0) {
		      uVar4 = func_ii_1081(Protocol_Services_AdPlacement_TypeInfo,&local_8);
		      uVar4 = func_ii_4419(StringLiteral_2834,uVar4,0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      func_ii_7109(uVar4,0);
		    }
		    else {
		      uVar4 = func_ii_1081(Protocol_Services_AdPlacement_TypeInfo,&local_8);
		      uVar4 = func_ii_4419(StringLiteral_14322,uVar4,0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      System_Collections_Generic_Dictionary_uint__object___get_Count(uVar4,0);
		      piVar2 = local_4;
		      iVar3 = *local_4;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo ==
		              *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		            puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		            goto code_r0x81271ff6;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      puVar5 = (uint *)func_ii_1080(local_4,
		                                    Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo,4
		                                   );
		code_r0x81271ff6:
		      iVar3 = (**(code **)((ulonglong)*puVar5 * 4))(piVar2,puVar5[1]);
		      if (iVar3 == 0) {
		        local_8 = param2;
		        uVar4 = func_ii_1081(Protocol_Services_AdPlacement_TypeInfo,&local_8);
		        uVar4 = func_ii_4419(StringLiteral_206,uVar4,0);
		        uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_2831,uVar4,0);
		        if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		          func_ii_306000(OKG_Logs_Debug_TypeInfo);
		        }
		        System_Collections_Generic_Dictionary_uint__object___get_Count(uVar4,0);
		        Core_Gameplay_Managers_Ad_Controller_AbstractAdController__ProviderOnAdErrorEvent
		                  (uVar4,**(undefined4 **)(DAT_ram_00a66978 + 0x5c),0xffffffff,StringLiteral_3162,
		                   uVar4);
		      }
		      else {
		        iVar8 = *param1;
		        iVar3 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x100) * 4))
		                          (param1,*(undefined4 *)(iVar8 + 0x104));
		        if (*(int *)(iVar3 + 0x1c) == 0) {
		          Core_Gameplay_Managers_Ad_Controller_AbstractAdController__PlacementOnBacktimerCompleteEvent
		                    (param1,param2,param3,iVar8);
		          if (DAT_ram_00a5a7ed == '\0') {
		            Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		            DAT_ram_00a5a7ed = '\x01';
		          }
		          iVar3 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		          if (iVar3 == 0) {
		            uVar4 = unnamed_function_1417(Core_Application_App_TypeInfo);
		            Core_Application_App__set_FileDownloadLogger(uVar4,uVar4);
		            **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar4;
		            iVar3 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		          }
		          iVar3 = *(int *)(*(int *)(*(int *)(*(int *)(iVar3 + 0x38) + 0x10) + 0x90) + 0xc);
		          if (iVar3 != 0) {
		            if (DAT_ram_00a5a7ed == '\0') {
		              Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		              DAT_ram_00a5a7ed = '\x01';
		            }
		            iVar8 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		            if (iVar8 == 0) {
		              uVar4 = unnamed_function_1417(Core_Application_App_TypeInfo);
		              Core_Application_App__set_FileDownloadLogger(uVar4,uVar4);
		              **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar4;
		              iVar8 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		            }
		            if (DAT_ram_00a6456f == '\0') {
		              Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		              DAT_ram_00a6456f = '\x01';
		            }
		            uVar7 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		            iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x104));
		            param4_00 = *(undefined4 *)(iVar6 + 0x1c);
		            uVar4 = unnamed_function_1417(Core_Events_Scopes_AdScope_AdEventArgs_TypeInfo);
		            Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData
		                      (uVar4,iVar8,uVar7,param4_00,0);
		            (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                      (*(undefined4 *)(iVar3 + 0x20),uVar4,*(undefined4 *)(iVar3 + 0x14));
		          }
		          iVar3 = param1[6];
		          piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                                    (param1,*(undefined4 *)(*param1 + 0x104));
		          if (DAT_ram_00a5a7b4 == '\0') {
		            Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_uint___);
		            DAT_ram_00a5a7b4 = '\x01';
		          }
		          uVar4 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                            (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		          uVar4 = System_Linq_Enumerable__FirstOrDefault_int_
		                            (uVar4,Method_System_Linq_Enumerable_FirstOrDefault_uint___);
		          uVar4 = ServicesNamespace_ServicesService__GetAdPlacementInfo(iVar3,param2,uVar4,param3,0)
		          ;
		          uVar7 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		          UnityEngine_UIElements_VisualElement__get_layout
		                    (uVar7,param1,
		                     Method_Core_Gameplay_Managers_Ad_Controller_AbstractAdController_HandleServiceCreateAdPlacementTx__
		                     ,0);
		          uVar4 = ServicesNamespace_MainService__GetUserStats
		                            (uVar4,uVar7,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__
		                            );
		          Utils_OpToken_int__object___AddHandlers(param1,uVar4,0);
		        }
		        else {
		          iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		          uVar4 = func_ii_4419(StringLiteral_27827,*(undefined4 *)(iVar3 + 0x1c),0);
		          uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_2833,uVar4,0);
		          if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		            func_ii_306000(OKG_Logs_Debug_TypeInfo);
		          }
		          System_Collections_Generic_Dictionary_uint__object___get_Count(uVar4,0);
		        }
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006E13 RID: 28179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E13")]
		[Address(RVA = "0xB8C6", Offset = "0xB8C6", VA = "0xB8C6", Slot = "12")]
		private void ShowAd(uint adPlacementId, uint optionId)
		{
		}

		// Token: 0x06006E14 RID: 28180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E14")]
		[Address(RVA = "0xB8C7", Offset = "0xB8C7", VA = "0xB8C7")]
		private void OnCurrentAdRejected()
		{
		/* --- GHIDRA: OnCurrentAdRejected ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__OnCurrentAdRejected
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a7ce == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2829);
		    DAT_ram_00a5a7ce = '\x01';
		  }
		  uVar2 = func_ii_4419(StringLiteral_2829,param2,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  uVar1 = 0;
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x812725d2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,
		                                Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo,2);
		code_r0x812725d2:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  if (DAT_ram_00a5a7c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&uint___TypeInfo);
		    DAT_ram_00a5a7c8 = '\x01';
		  }
		  iVar4 = Mono_Security_ASN1Convert__ToOid(uint___TypeInfo,1);
		  *(undefined4 *)(iVar4 + 0x10) = uVar2;
		  Core_Gameplay_Managers_Ad_Controller_AbstractAdController__ValidateInit(param1,iVar4,uVar2);
		  return;
		}
		*/

		}

		// Token: 0x06006E15 RID: 28181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E15")]
		[Address(RVA = "0xB8C8", Offset = "0xB8C8", VA = "0xB8C8")]
		private void PlacementOnBacktimerCompleteEvent(IAdPlacementData data)
		{
		/* --- GHIDRA: PlacementOnBacktimerCompleteEvent ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__PlacementOnBacktimerCompleteEvent
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a7cf == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Model_AdTransaction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2825);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22120);
		    DAT_ram_00a5a7cf = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = func_ii_4419(StringLiteral_22120,*(undefined4 *)(iVar1 + 0x1c),0);
		  uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_2825,uVar2,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a5a7b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_uint___);
		    DAT_ram_00a5a7b4 = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		                    (piVar3,*(undefined4 *)(*piVar3 + 0x104));
		  uVar2 = System_Linq_Enumerable__FirstOrDefault_int_
		                    (uVar2,Method_System_Linq_Enumerable_FirstOrDefault_uint___);
		  iVar4 = unnamed_function_1417(Core_Gameplay_Managers_Ad_Model_AdTransaction_TypeInfo);
		  *(undefined4 *)(iVar4 + 0x10) = param3;
		  *(undefined4 *)(iVar4 + 0xc) = param2;
		  *(undefined4 *)(iVar4 + 8) = uVar2;
		  *(int *)(iVar1 + 0x1c) = iVar4;
		  return;
		}
		*/

		}

		// Token: 0x06006E16 RID: 28182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E16")]
		[Address(RVA = "0xB8C9", Offset = "0xB8C9", VA = "0xB8C9")]
		private void CreateCurrentTransaction(AdPlacement adPlacement, uint optionId)
		{
		/* --- GHIDRA: CreateCurrentTransaction ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__CreateCurrentTransaction
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a7d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2824);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22120);
		    DAT_ram_00a5a7d0 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = func_ii_4419(StringLiteral_22120,*(undefined4 *)(iVar1 + 0x1c),0);
		  uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_2824,uVar2,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x1c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06006E17 RID: 28183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E17")]
		[Address(RVA = "0xB8CA", Offset = "0xB8CA", VA = "0xB8CA")]
		private void ClearCurrentTransaction()
		{
		/* --- GHIDRA: ClearCurrentTransaction ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__ClearCurrentTransaction
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5a7d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2830);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2524);
		    Mono_Security_ASN1__get_Item(&StringLiteral_313);
		    DAT_ram_00a5a7d1 = '\x01';
		  }
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (StringLiteral_2830,*(undefined4 *)(param2 + 0xc),StringLiteral_313,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x20);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(param2 + 0xc),
		               *(undefined4 *)(iVar2 + 0x14));
		  }
		  if (DAT_ram_00a5a7ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		    DAT_ram_00a5a7ed = '\x01';
		  }
		  iVar2 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  if (iVar2 == 0) {
		    uVar1 = unnamed_function_1417(Core_Application_App_TypeInfo);
		    Core_Application_App__set_FileDownloadLogger(uVar1,uVar1);
		    **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar1;
		    iVar2 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  }
		  uVar1 = *(undefined4 *)(*(int *)(iVar2 + 0x18) + 0x18);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2524,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar1,0xd,param3_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06006E18 RID: 28184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E18")]
		[Address(RVA = "0xB8CB", Offset = "0xB8CB", VA = "0xB8CB")]
		private void ServicesServiceOnTransactionClosedEvent(AdTransactionClosedEvt evt)
		{
		/* --- GHIDRA: ServicesServiceOnTransactionClosedEvent ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__ServicesServiceOnTransactionClosedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  int param2_00;
		  undefined4 param4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a7d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AdScope_AdErrorEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_AdSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12844);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2915);
		    DAT_ram_00a5a7d2 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 8);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81272848;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo,0
		                               );
		code_r0x81272848:
		  local_4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = func_ii_1081(Protocol_Services_AdSource_TypeInfo,&local_4);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_12844,uVar3,*(undefined4 *)(iVar5 + 0x1c),0);
		  uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_2915,uVar3,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		  if (DAT_ram_00a5a7ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		    DAT_ram_00a5a7ed = '\x01';
		  }
		  iVar5 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  if (iVar5 == 0) {
		    uVar3 = unnamed_function_1417(Core_Application_App_TypeInfo);
		    Core_Application_App__set_FileDownloadLogger(uVar3,uVar3);
		    **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar3;
		    iVar5 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  }
		  iVar6 = *(int *)(*(int *)(*(int *)(*(int *)(iVar5 + 0x38) + 0x10) + 0x90) + 0x18);
		  iVar5 = Core_Application_App_TypeInfo;
		  if (iVar6 != 0) {
		    if (DAT_ram_00a5a7ed == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		      DAT_ram_00a5a7ed = '\x01';
		    }
		    param2_00 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    if (param2_00 == 0) {
		      uVar3 = unnamed_function_1417(Core_Application_App_TypeInfo);
		      Core_Application_App__set_FileDownloadLogger(uVar3,uVar3);
		      **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar3;
		      param2_00 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    iVar5 = **(int **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param4 = *(undefined4 *)(iVar4 + 0x1c);
		    uVar3 = unnamed_function_1417(Core_Events_Scopes_AdScope_AdErrorEventArgs_TypeInfo);
		    Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		              (uVar3,param2_00,iVar5,param4,param2,0);
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		              (*(undefined4 *)(iVar6 + 0x20),uVar3,*(undefined4 *)(iVar6 + 0x14));
		  }
		  Core_Gameplay_Managers_Ad_Controller_AbstractAdController__Core_Gameplay_Managers_Ad_Controller_IAdController_ShowAd
		            (param1,iVar5);
		  Core_Gameplay_Managers_Ad_Controller_AbstractAdController__ProviderOnAdErrorEvent
		            (iVar5,*(undefined4 *)(param2 + 0xc),*(undefined4 *)(param2 + 0x10),
		             *(undefined4 *)(param2 + 0x14),iVar5);
		  return;
		}
		*/

		}

		// Token: 0x06006E19 RID: 28185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E19")]
		[Address(RVA = "0xB8CC", Offset = "0xB8CC", VA = "0xB8CC")]
		private void ProviderOnAdErrorEvent(IAdProvider.AdErrorEventData e)
		{
		/* --- GHIDRA: ProviderOnAdErrorEvent ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__ProviderOnAdErrorEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 local_4;
		  
		  local_4 = param3;
		  if (DAT_ram_00a5a7d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2526);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19699);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2525);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22980);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25362);
		    DAT_ram_00a5a7d3 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar1,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar1,StringLiteral_19699,param2,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar2 = func_ii_4443(&local_4,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar1,StringLiteral_22980,uVar2,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar1,StringLiteral_25362,param4,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  param1_00 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		  UI_Windows_Alert__Show(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2526,1,0,1,0,0,0,0);
		  uVar2 = Core_GameLocalization__GetTranslation(uVar2,uVar1,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2525,1,0,1,0,0,0,0);
		  uVar1 = Core_GameLocalization__GetTranslation(uVar2,uVar1,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  UI_Windows_UnityInstantiator___ctor(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06006E1A RID: 28186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E1A")]
		[Address(RVA = "0xB8CD", Offset = "0xB8CD", VA = "0xB8CD")]
		private void ShowError(string adId, int errorCode, string message)
		{
		/* --- GHIDRA: ShowError ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__ShowError
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x24);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006E1B RID: 28187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E1B")]
		[Address(RVA = "0xB8CE", Offset = "0xB8CE", VA = "0xB8CE")]
		private void AdAvailabilityChangedEventHandler(IAdProvider.AdAvailabilityEventData e)
		{
		/* --- GHIDRA: AdAvailabilityChangedEventHandler ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__AdAvailabilityChangedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param3_00;
		  int *param1_00;
		  int iVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a7d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Services_AdSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6024);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12845);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2914);
		    DAT_ram_00a5a7d4 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 8);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81272b42;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo,0
		                               );
		code_r0x81272b42:
		  local_4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = func_ii_1081(Protocol_Services_AdSource_TypeInfo,&local_4);
		  uVar3 = func_ii_4419(StringLiteral_12845,uVar3,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param3_00 = func_ii_4419(StringLiteral_6024,*(undefined4 *)(iVar4 + 0x1c),0);
		  uVar3 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (StringLiteral_2914,uVar3,param3_00,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		  Core_Gameplay_Managers_Ad_Controller_AbstractAdController__CreateCurrentTransaction(param1,uVar3);
		  return;
		}
		*/

		}

		// Token: 0x06006E1C RID: 28188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E1C")]
		[Address(RVA = "0xB8CF", Offset = "0xB8CF", VA = "0xB8CF")]
		private void ProviderOnAdClosedEvent(IAdProvider.BaseAdEventData e)
		{
		/* --- GHIDRA: ProviderOnAdClosedEvent ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__ProviderOnAdClosedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *param1_00;
		  int iVar7;
		  uint uVar8;
		  undefined4 param4;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a7d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AdScope_AdEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_AdSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19697);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6024);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12845);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12843);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2916);
		    DAT_ram_00a5a7d5 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(int **)(param2 + 8);
		  iVar7 = *param1_00;
		  uVar8 = (uint)*(ushort *)(iVar7 + 0xb6);
		  if (*(int *)(iVar2 + 0x1c) == 0) {
		    if (uVar8 != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81272cf2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (uVar8 != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo
		                                  ,0);
		code_r0x81272cf2:
		    local_4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    uVar4 = func_ii_1081(Protocol_Services_AdSource_TypeInfo,&local_4);
		    uVar4 = func_ii_4419(StringLiteral_12843,uVar4,0);
		    uVar4 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (StringLiteral_2916,uVar4,StringLiteral_19697,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar4,0);
		  }
		  else {
		    if (uVar8 != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81272dbe;
		        }
		        uVar1 = uVar1 + 1;
		      } while (uVar8 != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_Managers_Ad_Providers_IAdProvider_TypeInfo
		                                  ,0);
		code_r0x81272dbe:
		    local_8 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    uVar4 = func_ii_1081(Protocol_Services_AdSource_TypeInfo,&local_8);
		    uVar4 = func_ii_4419(StringLiteral_12845,uVar4,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar5 = func_ii_4419(StringLiteral_6024,*(undefined4 *)(iVar2 + 0x1c),0);
		    uVar4 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (StringLiteral_2916,uVar4,uVar5,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar4,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x14);
		    if (iVar2 != 0) {
		      iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar7 + 0x1c),
		                 *(undefined4 *)(iVar2 + 0x14));
		    }
		    if (DAT_ram_00a5a7ed == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		      DAT_ram_00a5a7ed = '\x01';
		    }
		    iVar2 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    if (iVar2 == 0) {
		      uVar4 = unnamed_function_1417(Core_Application_App_TypeInfo);
		      Core_Application_App__set_FileDownloadLogger(uVar4,uVar4);
		      **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar4;
		      iVar2 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    }
		    iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x90) + 0x14);
		    if (iVar2 != 0) {
		      if (DAT_ram_00a5a7ed == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		        DAT_ram_00a5a7ed = '\x01';
		      }
		      iVar7 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		      if (iVar7 == 0) {
		        uVar4 = unnamed_function_1417(Core_Application_App_TypeInfo);
		        Core_Application_App__set_FileDownloadLogger(uVar4,iVar2);
		        **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar4;
		        iVar7 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		      }
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      uVar5 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param4 = *(undefined4 *)(iVar6 + 0x1c);
		      uVar4 = unnamed_function_1417(Core_Events_Scopes_AdScope_AdEventArgs_TypeInfo);
		      Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(uVar4,iVar7,uVar5,param4,0);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),uVar4,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006E1D RID: 28189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E1D")]
		[Address(RVA = "0xB8D0", Offset = "0xB8D0", VA = "0xB8D0")]
		private void ProviderOnAdRewardedEvent(IAdProvider.AdInfoEventData e)
		{
		/* --- GHIDRA: ProviderOnAdRewardedEvent ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__ProviderOnAdRewardedEvent
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a7d6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Ad_Controller_AbstractAdController___c_TypeInfo);
		    DAT_ram_00a5a7d6 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Ad_Controller_AbstractAdController___c_TypeInfo);
		  **(undefined4 **)(Core_Gameplay_Managers_Ad_Controller_AbstractAdController___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}

		// Token: 0x0400398D RID: 14733
		[Token(Token = "0x400398D")]
		[FieldOffset(Offset = "0x18")]
		private readonly ServicesService _servicesService;

		// Token: 0x0400398E RID: 14734
		[Token(Token = "0x400398E")]
		[FieldOffset(Offset = "0x1C")]
		private readonly Dictionary<uint, IAdProvider> _adProviders;

		// Token: 0x0400398F RID: 14735
		[Token(Token = "0x400398F")]
		[FieldOffset(Offset = "0x20")]
		private readonly CancellationTokenSource _cancellationTokenSource;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_DefaultProvider ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__get_DefaultProvider
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a7c0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_AbstractAdModel__AdEvents__Dispose__);
		    DAT_ram_00a5a7c0 = '\x01';
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_AbstractAdModel__AdEvents__Dispose__);
		  Core_Gameplay_Managers_Ad_Controller_AbstractAdController__InitializeAdProviders(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: Core.Gameplay.Managers.Ad.Controller.IAdController.ShowAd ---
		void Core_Gameplay_Managers_Ad_Controller_AbstractAdController__Core_Gameplay_Managers_Ad_Controller_IAdController_ShowAd
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a5a7cd == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2823);
		    DAT_ram_00a5a7cd = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if ((*(int *)(iVar1 + 0x1c) != 0) &&
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104)),
		     *(int *)(*(int *)(iVar1 + 0x1c) + 0x14) != 0)) {
		    param1_00 = param1[6];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    ServicesNamespace_ServicesService__CreateAdPlacementTx
		              (param1_00,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x1c) + 0x14) + 0x10),0);
		    Core_Gameplay_Managers_Ad_Controller_AbstractAdController__CreateCurrentTransaction
		              (param1,param1);
		    return;
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  func_ii_7830(StringLiteral_2823,0);
		  return;
		}
		*/

}
