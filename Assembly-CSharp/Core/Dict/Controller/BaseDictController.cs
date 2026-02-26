using System;
using System.Collections;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Core.Dict.Model;
using Core.Files;
using Core.Gameplay.Managers;
using Il2CppDummyDll;
using MVC;
using UnityEngine;

namespace Core.Dict.Controller
{
	// Token: 0x020010A4 RID: 4260
	[Token(Token = "0x20010A4")]
	public class BaseDictController : AbstractController<DictModel, DictEvents>
	{
		// Token: 0x060062FD RID: 25341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062FD")]
		[Address(RVA = "0xAF0B", Offset = "0xAF0B", VA = "0xAF0B", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: <>n__0 ---
		void Core_Dict_Controller_BaseDictController____n__0(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6075a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_Controller_BaseDictController___c_TypeInfo);
		    DAT_ram_00a6075a = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Dict_Controller_BaseDictController___c_TypeInfo);
		  **(undefined4 **)(Core_Dict_Controller_BaseDictController___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060062FE RID: 25342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062FE")]
		[Address(RVA = "0xAF0C", Offset = "0xAF0C", VA = "0xAF0C")]
		public BaseDictController(DictModel model, DictEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Dict_Controller_BaseDictController___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a60753 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_BaseDictController__HandleRun_d__3___
		              );
		    DAT_ram_00a60753 = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_30,0);
		  local_14 = local_28;
		  local_20 = 0xffffffff;
		  local_1c = local_30;
		  local_c = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_AprInfoWindowMediator__HandleBuyAprConfirmation_d__17_
		            (&local_1c,&local_20,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_BaseDictController__HandleRun_d__3___
		            );
		  return;
		}
		*/

		}

		// Token: 0x060062FF RID: 25343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062FF")]
		[Address(RVA = "0xAF0D", Offset = "0xAF0D", VA = "0xAF0D", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Core_Dict_Controller_BaseDictController__HandleRun
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__BaseDictController__HandleRun_d__3_
		                    (uVar1,param1);
		  Core_Dict_Model_DictModel__get_DownloadPath(param1,uVar1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06006300 RID: 25344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006300")]
		[Address(RVA = "0xAF0E", Offset = "0xAF0E", VA = "0xAF0E")]
		private void AuthManagerOnDictionaryNameChangedEvent(IDictNameSource source)
		{
		/* --- GHIDRA: AuthManagerOnDictionaryNameChangedEvent ---
		void Core_Dict_Controller_BaseDictController__AuthManagerOnDictionaryNameChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  
		  if (DAT_ram_00a60754 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IDictNameSource__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_Controller_BaseDictController_AuthManagerOnDictionaryNameChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IAuthDataProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_IDictNameSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Net_ServicePointManager_TypeInfo);
		    DAT_ram_00a60754 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar4 = *(int **)(iVar2 + 0xc);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81cda0da;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x81cda0da:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  piVar4 = *(int **)(iVar2 + 0x38);
		  uVar1 = 0;
		  param1_00 = unnamed_function_1417(System_Action_IDictNameSource__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Core_Dict_Controller_BaseDictController_AuthManagerOnDictionaryNameChangedEvent__
		             ,0);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_IDictNameSource_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		        goto code_r0x81cda17e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_Managers_IDictNameSource_TypeInfo,1);
		code_r0x81cda17e:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,param1_00,puVar3[1]);
		  if (*(int *)(System_Net_ServicePointManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Net_ServicePointManager_TypeInfo);
		  }
		  System_Net_Security_RemoteCertificateValidationCallback___ctor(0,0);
		  if (param1[7] != 0) {
		    func_ii_7950(param1[7],0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006301 RID: 25345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006301")]
		[Address(RVA = "0xAF0F", Offset = "0xAF0F", VA = "0xAF0F", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Core_Dict_Controller_BaseDictController__HandleStop(int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a60756 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Files_IFileContent_TypeInfo);
		    DAT_ram_00a60756 = '\x01';
		  }
		  local_4 = 0;
		  if ((char)param1[6] == '\0') {
		    uVar1 = 0;
		    iVar4 = *param2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Files_IFileContent_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		          goto code_r0x81cda26d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Core_Files_IFileContent_TypeInfo,1);
		code_r0x81cda26d:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,&local_4,puVar2[1]);
		    if (iVar4 != 0) {
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x120) * 4))
		                        (param1,param2,local_4,*(undefined4 *)(*param1 + 0x124));
		      if (DAT_ram_00a60758 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Core_Dict_Controller_BaseDictController__ProcessDictionaries_d__10_TypeInfo);
		        DAT_ram_00a60758 = '\x01';
		      }
		      iVar4 = unnamed_function_1417
		                        (Core_Dict_Controller_BaseDictController__ProcessDictionaries_d__10_TypeInfo
		                        );
		      *(int **)(iVar4 + 0x14) = param1;
		      *(undefined4 *)(iVar4 + 8) = 0;
		      *(undefined4 *)(iVar4 + 0x10) = uVar3;
		      iVar4 = Utils_CoroutineSource__GetMono(iVar4,0);
		      param1[7] = iVar4;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006302 RID: 25346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006302")]
		[Address(RVA = "0x36DC", Offset = "0x36DC", VA = "0x36DC")]
		private void LoadDict(string path)
		{
		/* --- GHIDRA: LoadDict ---
		undefined4
		Core_Dict_Controller_BaseDictController__LoadDict(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5ace9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt_BinarySearch_ModifierDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_ModifierDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Extensions_Dict_DictExt___c__GetModifier_b__4_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ace9 = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0x48);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[3];
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_ModifierDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_00,uVar1,Method_Core_Extensions_Dict_DictExt___c__GetModifier_b__4_0__,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0xc) = param1_00;
		  }
		  uVar1 = func_ii_8597(&local_4,param1_00,param2,
		                       Method_Core_Extensions_Dict_DictExt_BinarySearch_ModifierDic__uint___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06006303 RID: 25347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006303")]
		[Address(RVA = "0xAF10", Offset = "0xAF10", VA = "0xAF10")]
		private void ParseResultDic(IFileContent content)
		{
		/* --- GHIDRA: ParseResultDic ---
		undefined4
		Core_Dict_Controller_BaseDictController__ParseResultDic
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 *puVar5;
		  undefined4 uVar6;
		  undefined4 param4_00;
		  int iVar7;
		  undefined4 *param2_00;
		  undefined4 param3_00;
		  int local_28;
		  int **local_24;
		  int local_20;
		  int *local_1c;
		  int local_18;
		  int **local_14;
		  undefined4 local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a60757 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&ICSharpCode_SharpZipLib_Zip_Compression_Streams_InflaterInputStream_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IO_MemoryStream_TypeInfo);
		    DAT_ram_00a60757 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = 0;
		  local_c = (int *)0x0;
		  DAT_ram_009d3e38 = 0;
		  local_10 = 0;
		  piVar2 = (int *)import::env::invoke_ii
		                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                             System_IO_MemoryStream_TypeInfo);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x81cda5ac:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar7 = global_1;
		code_r0x81cdab16:
		    iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar4 != iVar7) {
		code_r0x81cdac50:
		      import::env::__resumeException(uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    puVar5 = (undefined4 *)import::env::__cxa_begin_catch(uVar3);
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar6,
		                         *(undefined4 *)*puVar5);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 != 1) {
		        if (iVar4 != 0) {
		          param3_00 = *puVar5;
		          import::env::__cxa_end_catch();
		          uVar6 = unnamed_function_2232(&Core_Files_IFileContent_TypeInfo);
		          uVar6 = Unity_Properties_PropertyMember___ctor(0,uVar6,param2);
		          uVar3 = unnamed_function_2232(&Core_Files_IFileInfo_TypeInfo);
		          param4_00 = unnamed_function_2232(&StringLiteral_5733);
		          iVar7 = unnamed_function_31187(2,uVar3,uVar6,param4_00,&local_10);
		          if (iVar7 == 0) {
		            local_10 = unnamed_function_2232(&StringLiteral_11524);
		          }
		          uVar6 = local_10;
		          uVar3 = unnamed_function_2232(&StringLiteral_5850);
		          uVar6 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                            (uVar3,uVar6,param3_00,0);
		          iVar7 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		          if (*(int *)(iVar7 + 0x74) == 0) {
		            func_ii_306000(iVar7);
		          }
		          func_ii_7830(uVar6,0);
		          return param3;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar5;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81cdacae;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) goto code_r0x81cdac50;
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x14a,piVar2,param3,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81cda5ac;
		    DAT_ram_009d3e38 = 0;
		    local_18 = 0;
		    local_14 = &local_4;
		    local_4 = piVar2;
		    iVar7 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       ICSharpCode_SharpZipLib_Zip_Compression_Streams_InflaterInputStream_TypeInfo)
		    ;
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81cda5bc:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar7 = global_1;
		code_r0x81cda961:
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar4 == iVar7) {
		        piVar2 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar4 = *piVar2;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar4;
		        import::env::invoke_v(0x123);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar7 = global_1;
		          goto code_r0x81cdaae0;
		        }
		code_r0x81cda9ac:
		        piVar2 = local_4;
		        if (local_4 == (int *)0x0) {
		code_r0x81cdaa89:
		          if (iVar4 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return uVar6;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar4);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x81cdacae;
		        }
		        else {
		          uVar1 = 0;
		          iVar7 = *local_4;
		          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		            do {
		              if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		                puVar5 = (undefined4 *)
		                         (iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		                goto code_r0x81cdaa4d;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar5 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                              System_IDisposable_TypeInfo,0);
		          if (DAT_ram_009d3e38 != 1) {
		code_r0x81cdaa4d:
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii(*puVar5,piVar2,puVar5[1]);
		            if (DAT_ram_009d3e38 != 1) goto code_r0x81cdaa89;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar7 = global_1;
		      }
		      else {
		code_r0x81cdaae0:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s___Scripting__UnityEngine__Render_ram_000036af + 0x26,&local_18);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) goto code_r0x81cdaca5;
		      }
		      goto code_r0x81cdab16;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s___Scripting__UnityEngine__Render_ram_000036af + 0x23,iVar7,piVar2,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81cda5bc;
		    DAT_ram_009d3e38 = 0;
		    local_20 = 0;
		    local_1c = &local_8;
		    local_8 = iVar7;
		    piVar2 = (int *)import::env::invoke_ii
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                               System_IO_MemoryStream_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81cda5d0:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar7 = global_1;
		code_r0x81cda7a8:
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar4 != iVar7) {
		code_r0x81cda92f:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s___Scripting__UnityEngine__Render_ram_000036af + 0x25,&local_20);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) goto code_r0x81cdaca5;
		        goto code_r0x81cda961;
		      }
		      piVar2 = (int *)import::env::__cxa_begin_catch(uVar3);
		      local_20 = *piVar2;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_v(0x123);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar7 = global_1;
		        goto code_r0x81cda92f;
		      }
		code_r0x81cda7f3:
		      piVar2 = (int *)*local_1c;
		      if (piVar2 != (int *)0x0) {
		        uVar1 = 0;
		        iVar7 = *piVar2;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar5 = (undefined4 *)
		                       (iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		              goto code_r0x81cda897;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar5 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar2,
		                            System_IDisposable_TypeInfo,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x81cda897:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii(*puVar5,piVar2,puVar5[1]);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x81cda8d3;
		        }
		code_r0x81cda90a:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar7 = global_1;
		        goto code_r0x81cda961;
		      }
		code_r0x81cda8d3:
		      if (local_20 != 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_20);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81cdacae;
		        goto code_r0x81cda90a;
		      }
		      iVar4 = 0;
		      goto code_r0x81cda9ac;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x154,piVar2,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81cda5d0;
		    DAT_ram_009d3e38 = 0;
		    local_28 = 0;
		    local_24 = &local_c;
		    local_c = piVar2;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x31e,local_8,piVar2,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::invoke_iii
		                        (*(undefined4 *)(*local_c + 0x218),local_c,*(undefined4 *)(*local_c + 0x21c)
		                        );
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81cda5ec;
		      }
		code_r0x81cda63d:
		      piVar2 = *local_24;
		      if (piVar2 != (int *)0x0) {
		        uVar1 = 0;
		        iVar7 = *piVar2;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar5 = (undefined4 *)
		                       (iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		              goto code_r0x81cda6e1;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar5 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar2,
		                            System_IDisposable_TypeInfo,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x81cda6e1:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii(*puVar5,piVar2,puVar5[1]);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x81cda71d;
		        }
		code_r0x81cda754:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar7 = global_1;
		        goto code_r0x81cda7a8;
		      }
		code_r0x81cda71d:
		      if (local_28 != 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_28);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81cdacae;
		        goto code_r0x81cda754;
		      }
		      goto code_r0x81cda7f3;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cda5ec:
		    iVar7 = global_1;
		    iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar7 == iVar4) {
		      piVar2 = (int *)import::env::__cxa_begin_catch(uVar3);
		      local_28 = *piVar2;
		      uVar6 = 0;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_v(0x123);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 != 1) goto code_r0x81cda63d;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar7 = global_1;
		    }
		    uVar6 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s___Scripting__UnityEngine__Render_ram_000036af + 0x24,&local_28);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) goto code_r0x81cda7a8;
		  }
		code_r0x81cdaca5:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		code_r0x81cdacae:
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006304 RID: 25348 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006304")]
		[Address(RVA = "0xAF11", Offset = "0xAF11", VA = "0xAF11", Slot = "12")]
		protected virtual byte[] DecompressData(IFileContent content, byte[] compressedData)
		{
		/* --- GHIDRA: DecompressData ---
		int Core_Dict_Controller_BaseDictController__DecompressData
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a60758 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Dict_Controller_BaseDictController__ProcessDictionaries_d__10_TypeInfo);
		    DAT_ram_00a60758 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Core_Dict_Controller_BaseDictController__ProcessDictionaries_d__10_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06006305 RID: 25349 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006305")]
		[Address(RVA = "0xAF12", Offset = "0xAF12", VA = "0xAF12")]
		private IEnumerator ProcessDictionaries(byte[] resultBytes)
		{
		/* --- GHIDRA: ProcessDictionaries ---
		undefined4
		Core_Dict_Controller_BaseDictController__ProcessDictionaries
		          (undefined4 param1,undefined4 param2,int *param3,undefined4 param4,int param5,
		          undefined4 param6)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a60759 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Security_Cryptography_X509Certificates_X509Certificate2_TypeInfo);
		    DAT_ram_00a60759 = '\x01';
		  }
		  if ((param5 != 0) &&
		     (iVar1 = System_Security_Cryptography_X509Certificates_X509Chain___ctor(param4,0),
		     0 < *(int *)(iVar1 + 0xc))) {
		    iVar1 = 0;
		    do {
		      iVar2 = System_Security_Cryptography_X509Certificates_X509Chain___ctor(param4,0);
		      if (*(int *)(iVar2 + iVar1 * 8 + 0x10) != 0x40) {
		        uVar3 = System_Security_Cryptography_X509Certificates_X509Chain___ctor(param4,0);
		        System_Security_Cryptography_X509Certificates_X509ChainPolicy__get_RevocationFlag(uVar3,1,0)
		        ;
		        uVar3 = System_Security_Cryptography_X509Certificates_X509Chain___ctor(param4,0);
		        System_Security_Cryptography_X509Certificates_X509Chain__get_ChainPolicy(uVar3,1,0);
		        iVar2 = System_Security_Cryptography_X509Certificates_X509Chain___ctor(param4,0);
		        local_8 = 0;
		        func_ii_20825(&local_8,0,1,0,0);
		        *(undefined8 *)(iVar2 + 0x20) = local_8;
		        uVar3 = System_Security_Cryptography_X509Certificates_X509Chain___ctor(param4,0);
		        System_Security_Cryptography_X509Certificates_X509ChainPolicy__set_RevocationMode
		                  (uVar3,0xfff,0);
		        if (param3 != (int *)0x0) {
		          if (((uint)*(byte *)(*param3 + 0xb8) <
		               (uint)*(byte *)(
		                              System_Security_Cryptography_X509Certificates_X509Certificate2_TypeInfo
		                              + 0xb8)) ||
		             (*(int *)(*(int *)(*param3 + 100) +
		                       (uint)*(byte *)(
		                                      System_Security_Cryptography_X509Certificates_X509Certificate2_TypeInfo
		                                      + 0xb8) * 4 + -4) !=
		              System_Security_Cryptography_X509Certificates_X509Certificate2_TypeInfo)) {
		            System_Activator__CreateInstance
		                      (param3,
		                       System_Security_Cryptography_X509Certificates_X509Certificate2_TypeInfo);
		            do {
		              halt_trap();
		            } while( true );
		          }
		        }
		        iVar2 = System_Security_Cryptography_X509Certificates_X509ChainPolicy__set_VerificationFlags
		                          (param4,param3,0);
		        if (iVar2 == 0) {
		          return 0;
		        }
		      }
		      iVar1 = iVar1 + 1;
		      iVar2 = System_Security_Cryptography_X509Certificates_X509Chain___ctor(param4,0);
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return 1;
		}
		*/

			return null;
		}

		// Token: 0x06006306 RID: 25350 RVA: 0x00012990 File Offset: 0x00010B90
		[Token(Token = "0x6006306")]
		[Address(RVA = "0xAF13", Offset = "0xAF13", VA = "0xAF13")]
		private bool MyRemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}

		// Token: 0x04003516 RID: 13590
		[Token(Token = "0x4003516")]
		[FieldOffset(Offset = "0x18")]
		private bool _disposed;

		// Token: 0x04003517 RID: 13591
		[Token(Token = "0x4003517")]
		[FieldOffset(Offset = "0x1C")]
		private Coroutine _processDictionariesCoroutine;
	}
}
