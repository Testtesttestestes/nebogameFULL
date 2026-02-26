using System;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Model;
using Core.Gameplay.Managers.Ad.Providers;
using Il2CppDummyDll;
using Protocol.Services;
using ServicesNamespace;

namespace Core.Gameplay.Managers.Ad.Controller.WebGL
{
	// Token: 0x0200122B RID: 4651
	[Token(Token = "0x200122B")]
	public class AdController : AbstractAdController
	{
		// Token: 0x06006E26 RID: 28198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E26")]
		[Address(RVA = "0xB8D6", Offset = "0xB8D6", VA = "0xB8D6")]
		public AdController(ServicesService servicesService, AbstractAdModel model, AdEvents events)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Gameplay_Managers_Ad_Controller_WebGL_AdController___ctor
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int local_4;
		  
		  if (DAT_ram_00a5a7da == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Providers_WebglAdProvider_TypeInfo);
		    DAT_ram_00a5a7da = '\x01';
		  }
		  if (param2 == 2) {
		    uVar1 = unnamed_function_1417(Core_Gameplay_Managers_Ad_Providers_WebglAdProvider_TypeInfo);
		    Core_Gameplay_Managers_Ad_Providers_WebglAdProvider__get_ProviderId(uVar1,2,0);
		    return uVar1;
		  }
		  local_4 = param2;
		  uVar1 = unnamed_function_2232(&Protocol_Services_AdSource_TypeInfo);
		  uVar1 = func_ii_1081(uVar1,&local_4);
		  uVar2 = unnamed_function_2232(&StringLiteral_2922);
		  uVar1 = func_ii_4419(uVar2,uVar1,0);
		  uVar2 = unnamed_function_2232(&System_NotSupportedException_TypeInfo);
		  uVar2 = unnamed_function_1417(uVar2);
		  System_Xml_Serialization_XmlReflectionImporter__ImportXmlSerializableMapping(uVar2,uVar1,0);
		  uVar1 = unnamed_function_2232
		                    (&
		                     Method_Core_Gameplay_Managers_Ad_Controller_WebGL_AdController_CreateAdProvider__
		                    );
		  func_ii_1050(uVar2,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006E27 RID: 28199 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006E27")]
		[Address(RVA = "0xB8D7", Offset = "0xB8D7", VA = "0xB8D7", Slot = "14")]
		protected override IAdProvider CreateAdProvider(AdSource providerId)
		{
		/* --- GHIDRA: CreateAdProvider ---
		void Core_Gameplay_Managers_Ad_Controller_WebGL_AdController__CreateAdProvider
		               (int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  undefined4 param2_00;
		  int iVar6;
		  undefined4 *param2_01;
		  int *param1_00;
		  
		  param1_00 = (int *)0x0;
		  if (DAT_ram_00a5a7db == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Model_WebGL_AdModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Wrappers_JsonWrappers_ArrayWrapper_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_Wrappers_JsonWrappers_ArrayWrapper_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_string__AdSource___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_AdSource___);
		    Mono_Security_ASN1__get_Item(&System_Func_string__AdSource__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Controller_WebGL_AdController___c__InitializeAdProvidersPreProcess_b__2_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Ad_Controller_WebGL_AdController___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2913);
		    DAT_ram_00a5a7db = '\x01';
		  }
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  if (piVar1 != (int *)0x0) {
		    if (((uint)*(byte *)(Core_Gameplay_Managers_Ad_Model_WebGL_AdModel_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*piVar1 + 0xb8)) &&
		       (param1_00 = piVar1,
		       *(int *)(*(int *)(*piVar1 + 100) +
		                (uint)*(byte *)(Core_Gameplay_Managers_Ad_Model_WebGL_AdModel_TypeInfo + 0xb8) * 4 +
		               -4) != Core_Gameplay_Managers_Ad_Model_WebGL_AdModel_TypeInfo)) {
		      param1_00 = (int *)0x0;
		    }
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x13,0);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x81274624;
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::invoke_iiii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1e4,StringLiteral_2913,
		                     uVar2,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x812745ea:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,OKG_Logs_Debug_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x812745ea;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xc5,uVar5,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x812745ea;
		    DAT_ram_009d3e38 = 0;
		    piVar1 = (int *)import::env::invoke_ii
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                               Utils_Wrappers_JsonWrappers_ArrayWrapper_string__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x812745f4:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      Core_ExternAppMethods__GetAdSources
		                (piVar1,Method_Utils_Wrappers_JsonWrappers_ArrayWrapper_string___ctor__);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x812745f4;
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::invoke_iiii
		                        (*(undefined4 *)(*piVar1 + 0xe0),piVar1,uVar2,
		                         *(undefined4 *)(*piVar1 + 0xe4));
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x812745fe:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        if (*(int *)(Core_Gameplay_Managers_Ad_Controller_WebGL_AdController___c_TypeInfo + 0x74) ==
		            0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     Core_Gameplay_Managers_Ad_Controller_WebGL_AdController___c_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x812745fe;
		        }
		        puVar4 = *(undefined4 **)
		                  (Core_Gameplay_Managers_Ad_Controller_WebGL_AdController___c_TypeInfo + 0x5c);
		        iVar6 = puVar4[1];
		        if (iVar6 == 0) {
		          if (*(int *)(Core_Gameplay_Managers_Ad_Controller_WebGL_AdController___c_TypeInfo + 0x74)
		              == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       Core_Gameplay_Managers_Ad_Controller_WebGL_AdController___c_TypeInfo);
		            iVar6 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar6 == 1) {
		              uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x81274624;
		            }
		            puVar4 = *(undefined4 **)
		                      (Core_Gameplay_Managers_Ad_Controller_WebGL_AdController___c_TypeInfo + 0x5c);
		          }
		          uVar5 = *puVar4;
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_ii
		                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                             System_Func_string__AdSource__TypeInfo);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x242,iVar6,uVar5,
		                       Method_Core_Gameplay_Managers_Ad_Controller_WebGL_AdController___c__InitializeAdProvidersPreProcess_b__2_0__
		                       ,0);
		            if (DAT_ram_009d3e38 != 1) {
		              *(int *)(*(int *)(Core_Gameplay_Managers_Ad_Controller_WebGL_AdController___c_TypeInfo
		                               + 0x5c) + 4) = iVar6;
		              goto code_r0x81274566;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else {
		code_r0x81274566:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_0000223f + 0x15,uVar2,iVar6,
		                             Method_System_Linq_Enumerable_Select_string__AdSource___);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            uVar2 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_0000223f + 0x16,uVar2,
		                               Method_System_Linq_Enumerable_ToArray_AdSource___);
		            iVar6 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar6 != 1) goto code_r0x81274724;
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		        }
		      }
		    }
		  }
		code_r0x81274624:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar2);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar2,
		                         *(undefined4 *)*puVar4);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 != 1) {
		        if (iVar3 != 0) {
		          piVar1 = (int *)*puVar4;
		          import::env::__cxa_end_catch();
		          uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe8) * 4))
		                            (piVar1,*(undefined4 *)(*piVar1 + 0xec));
		          uVar5 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x110) * 4))
		                            (piVar1,*(undefined4 *)(*piVar1 + 0x114));
		          param2_00 = unnamed_function_2232(&StringLiteral_47);
		          uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                            (uVar2,param2_00,uVar5,0);
		          iVar6 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		          if (*(int *)(iVar6 + 0x74) == 0) {
		            func_ii_306000(iVar6);
		          }
		          func_ii_7109(uVar2,0);
		          uVar2 = unnamed_function_2232(&Protocol_Services_AdSource___TypeInfo);
		          uVar2 = Mono_Security_ASN1Convert__ToOid(uVar2,0);
		code_r0x81274724:
		          Core_Gameplay_Managers_Ad_Model_WebGL_AdModel__get_SupportedAdProviders
		                    (param1_00,uVar2,uVar2);
		          return;
		        }
		        param2_01 = (undefined4 *)unnamed_function_951(4);
		        *param2_01 = *puVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_01,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x812747aa;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x812747aa:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06006E28 RID: 28200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E28")]
		[Address(RVA = "0xB8D8", Offset = "0xB8D8", VA = "0xB8D8", Slot = "15")]
		protected override void InitializeAdProvidersPreProcess()
		{
		}

		// Token: 0x06006E29 RID: 28201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E29")]
		[Address(RVA = "0xB8D9", Offset = "0xB8D9", VA = "0xB8D9", Slot = "16")]
		protected override void InitializeAdProvidersPostProcess()
		{
		/* --- GHIDRA: InitializeAdProvidersPostProcess ---
		void Core_Gameplay_Managers_Ad_Controller_WebGL_AdController__InitializeAdProvidersPostProcess
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a7dc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Ad_Controller_WebGL_AdController___c_TypeInfo);
		    DAT_ram_00a5a7dc = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Ad_Controller_WebGL_AdController___c_TypeInfo);
		  **(undefined4 **)(Core_Gameplay_Managers_Ad_Controller_WebGL_AdController___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}
	}
}
