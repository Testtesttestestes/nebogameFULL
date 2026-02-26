using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Core.GameResources.Loaders
{
	// Token: 0x02000EE3 RID: 3811
	[Token(Token = "0x2000EE3")]
	public abstract class AbstractGameTextMeshProSpriteAssetLoader : AbstractGameResourceLoader<GameResourcesManager.TextMeshProSpriteAssetReadyDelegate>
	{
		// Token: 0x06005CA6 RID: 23718 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005CA6")]
		[Address(RVA = "0x22A9", Offset = "0x22A9", VA = "0x22A9")]
		private static Shader GetShader()
		{
		/* --- GHIDRA: GetShader ---
		void Core_GameResources_Loaders_AbstractGameTextMeshProSpriteAssetLoader__GetShader
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a624d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Material_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a624d4 = '\x01';
		  }
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  if (*(int *)(UnityEngine_Material_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Material_TypeInfo);
		  }
		  UnityEngine_Shader__PropertyToID_Injected(param1,param2,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005CA7 RID: 23719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CA7")]
		[Address(RVA = "0xA93A", Offset = "0xA93A", VA = "0xA93A", Slot = "5")]
		protected override void CheckIfReady()
		{
		/* --- GHIDRA: CheckIfReady ---
		void Core_GameResources_Loaders_AbstractGameTextMeshProSpriteAssetLoader__CheckIfReady
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5acab == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_CancellationToken__UniTaskVoid__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
		    DAT_ram_00a5acab = '\x01';
		  }
		  UnityEngine_InputSystem_Interactions_PressInteraction__Process(param1[0xc],0);
		  param1_00 = unnamed_function_1417(System_Func_CancellationToken__UniTaskVoid__TypeInfo);
		  System_Func_CancellationToken__object___Invoke
		            (param1_00,param1,*(undefined4 *)(*param1 + 0x10c),0);
		  param2_00 = func_ii_6977(*(undefined4 *)(param1[0xc] + 8),0);
		  if (*(int *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Cysharp_Threading_Tasks_UniTask_TypeInfo);
		  }
		  Cysharp_Threading_Tasks_UniTask__Void(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06005CA8 RID: 23720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CA8")]
		[Address(RVA = "0xA93B", Offset = "0xA93B", VA = "0xA93B", Slot = "6")]
		protected override void OnAssetBundleReady()
		{
		/* --- GHIDRA: OnAssetBundleReady ---
		void Core_GameResources_Loaders_AbstractGameTextMeshProSpriteAssetLoader__OnAssetBundleReady
		               (undefined1 *param1,uint param2,uint param3,undefined4 param4)
		
		{
		  undefined4 local_1c;
		  longlong local_18;
		  ulonglong local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5acac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_Start_AbstractGameTextMeshProSpriteAssetLoader__ProcessAssetBundle_d__6___
		              );
		    DAT_ram_00a5acac = '\x01';
		  }
		  local_8 = 0;
		  local_10 = (ulonglong)param3;
		  local_1c = 0xffffffff;
		  local_18 = (ulonglong)param2 << 0x20;
		  Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder__Start_AbstractGameSpriteLoader__ProcessAssetBundle_d__4_
		            (&local_18,&local_1c,
		             Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_Start_AbstractGameTextMeshProSpriteAssetLoader__ProcessAssetBundle_d__6___
		            );
		  *param1 = 0;
		  return;
		}
		*/

		}

		// Token: 0x06005CA9 RID: 23721 RVA: 0x000109E0 File Offset: 0x0000EBE0
		[Token(Token = "0x6005CA9")]
		[Address(RVA = "0xA93C", Offset = "0xA93C", VA = "0xA93C", Slot = "9")]
		protected virtual UniTaskVoid ProcessAssetBundle(CancellationToken cancellationToken)
		{
		/* --- GHIDRA: ProcessAssetBundle ---
		void Core_GameResources_Loaders_AbstractGameTextMeshProSpriteAssetLoader__ProcessAssetBundle
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5acad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_TextMeshProSpriteAssetReadyDelegate__Dispose__
		              );
		    DAT_ram_00a5acad = '\x01';
		  }
		  if (*(char *)(param1 + 0x24) == '\0') {
		    Core_GameResources_GameResourceCancellationToken__Cancel(*(undefined4 *)(param1 + 0x30),0);
		    Core_GameResources_AbstractGameResourceLoader_object___AssetBundleSuccessHandler
		              (param1,
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_TextMeshProSpriteAssetReadyDelegate__Dispose__
		              );
		  }
		  return;
		}
		*/

			return default(UniTaskVoid);
		}

		// Token: 0x06005CAA RID: 23722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CAA")]
		[Address(RVA = "0xA93D", Offset = "0xA93D", VA = "0xA93D", Slot = "7")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_GameResources_Loaders_AbstractGameTextMeshProSpriteAssetLoader__Dispose
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5acae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_TextMeshProSpriteAssetReadyDelegate__ReleaseAssetBundle__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5acae = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x30);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_TextMeshProSpriteAssetReadyDelegate__ReleaseAssetBundle__
		             ,0);
		  Core_GameResources_GameResourceCancellationToken__Init(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06005CAB RID: 23723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CAB")]
		[Address(RVA = "0xA93E", Offset = "0xA93E", VA = "0xA93E", Slot = "8")]
		protected override void ReleaseAssetBundle()
		{
		}

		// Token: 0x06005CAC RID: 23724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CAC")]
		[Address(RVA = "0xA93F", Offset = "0xA93F", VA = "0xA93F")]
		protected AbstractGameTextMeshProSpriteAssetLoader()
		{
		/* --- GHIDRA: .ctor ---
		void Core_GameResources_Loaders_AbstractGameTextMeshProSpriteAssetLoader___ctor
		               (int *param1,undefined4 param2)
		
		{
		  ushort uVar1;
		  uint uVar2;
		  int *piVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  int *piVar6;
		  undefined4 uVar7;
		  undefined4 param2_00;
		  undefined4 *param2_01;
		  int *param2_02;
		  int iVar8;
		  int iVar9;
		  undefined8 local_28;
		  ushort local_20;
		  undefined8 local_18;
		  int local_10;
		  undefined8 local_c;
		  int local_4;
		  
		  if (DAT_ram_00a5acb0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_AssetBundle_LoadAllAssetsAsync_TMP_SpriteAsset___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_Object_____AbstractGameTextMeshProSpriteAssetLoader__ProcessAssetBundle_d__6___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____GetResult__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____get_IsCompleted__);
		    Mono_Security_ASN1__get_Item(&System_Threading_CancellationToken_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_Object___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Material_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&TMPro_TMP_SpriteAsset_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Cysharp_Threading_Tasks_UniTask_Object____GetAwaiter__);
		    DAT_ram_00a5acb0 = '\x01';
		  }
		  _local_20 = 0;
		  local_28 = 0;
		  param2_02 = (int *)param1[2];
		  if (*param1 == 0) {
		    _local_20 = param1[6];
		    local_28 = *(undefined8 *)(param1 + 4);
		    param1[4] = 0;
		    param1[5] = 0;
		    param1[6] = 0;
		    *param1 = -1;
		    piVar3 = (int *)local_28;
		code_r0x812c5f16:
		    if (piVar3 == (int *)0x0) {
		code_r0x812c5f1b:
		      iVar8 = local_28._4_4_;
		code_r0x812c6089:
		      if (*(int *)(System_Threading_CancellationToken_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   System_Threading_CancellationToken_TypeInfo);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x812c63c6;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar5 = func_ii_8047(param1 + 3,0);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        if (iVar5 != 0) goto code_r0x812c64e1;
		        piVar3 = (int *)0x0;
		        if (*(int *)(iVar8 + 0xc) != 0) {
		          DAT_ram_009d3e38 = 0;
		          piVar6 = (int *)import::env::invoke_iii
		                                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0xf4,iVar8,
		                                     Method_System_Linq_Enumerable_First_Object___);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x812c63c6;
		          }
		          if (piVar6 != (int *)0x0) {
		            if (((uint)*(byte *)(TMPro_TMP_SpriteAsset_TypeInfo + 0xb8) <=
		                 (uint)*(byte *)(*piVar6 + 0xb8)) &&
		               (piVar3 = piVar6,
		               *(int *)(*(int *)(*piVar6 + 100) +
		                        (uint)*(byte *)(TMPro_TMP_SpriteAsset_TypeInfo + 0xb8) * 4 + -4) !=
		               TMPro_TMP_SpriteAsset_TypeInfo)) {
		              piVar3 = (int *)0x0;
		            }
		          }
		        }
		        param2_02[0xb] = (int)piVar3;
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x812c63c6;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3e6,piVar3,0,0);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else if (iVar9 == 0) {
		          iVar9 = param2_02[0xb];
		          DAT_ram_009d3e38 = 0;
		          uVar7 = import::env::invoke_ii
		                            (s_struct_Uniforms___color__array<v_ram_0000223f + 0x6a,param1);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            param2_00 = import::env::invoke_ii
		                                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                   UnityEngine_Material_TypeInfo);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viii
		                        (s_struct_Uniforms___color__array<v_ram_0000223f + 0x6b,param2_00,uVar7,0);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_viii
		                          (s_struct_Uniforms___color__array<v_ram_0000223f + 0x6c,param2_00,
		                           *(undefined4 *)(param2_02[0xb] + 0x7c),0);
		                iVar8 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar8 != 1) {
		                  *(undefined4 *)(iVar9 + 0x6c) = param2_00;
		                  goto code_r0x812c631e;
		                }
		                uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x812c63c6;
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		        }
		        else {
		          *(undefined1 *)((int)param2_02 + 0x25) = 1;
		code_r0x812c631e:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (*(undefined4 *)(*param2_02 + 0xe8),param2_02,*(undefined4 *)(*param2_02 + 0xec)
		                    );
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii
		                      (s_struct_Uniforms___color__array<v_ram_0000223f + 0x67,param2_02[0xc],0);
		            iVar8 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar8 != 1) {
		code_r0x812c64e1:
		              DAT_ram_009d3e38 = 0;
		              *param1 = -2;
		              unnamed_function_118874(param1 + 1);
		              return;
		            }
		            uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		        }
		      }
		    }
		    else {
		      uVar1 = local_20;
		      iVar8 = *(int *)(Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____GetResult__ + 0x10);
		      if ((*(byte *)(iVar8 + 0xbd) & 1) == 0) {
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_ii(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar8)
		        ;
		        if (DAT_ram_009d3e38 != 1) goto code_r0x812c5f72;
		      }
		      else {
		code_r0x812c5f72:
		        iVar8 = *(int *)(*(int *)(iVar8 + 0x60) + 0x14);
		        if ((*(byte *)(iVar8 + 0xbd) & 1) == 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar8 = import::env::invoke_ii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar8);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x812c6204;
		        }
		        iVar9 = *piVar3;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            if (iVar8 == *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8)) {
		              puVar4 = (undefined4 *)
		                       (iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		              goto code_r0x812c6043;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar3,iVar8,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x812c6043:
		          DAT_ram_009d3e38 = 0;
		          iVar8 = import::env::invoke_iiii(*puVar4,piVar3,(int)(short)uVar1,puVar4[1]);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x812c6089;
		        }
		      }
		code_r0x812c6204:
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_0000223f + 99,param2_02[6],
		                       Method_UnityEngine_AssetBundle_LoadAllAssetsAsync_TMP_SpriteAsset___);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiiiii
		                (s_struct_Uniforms___color__array<v_ram_0000223f + 100,&local_c,uVar7,0,8,param1[3],
		                 0);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        local_10 = local_4;
		        local_18 = local_c;
		        if ((*(byte *)(*(int *)(Method_Cysharp_Threading_Tasks_UniTask_Object____GetAwaiter__ + 0x10
		                               ) + 0xbd) & 1) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii
		                    (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,
		                     *(int *)(Method_Cysharp_Threading_Tasks_UniTask_Object____GetAwaiter__ + 0x10))
		          ;
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x812c63c6;
		          }
		        }
		        _local_20 = local_10;
		        local_28 = local_18;
		        if ((*(byte *)(*(int *)(
		                               Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____get_IsCompleted__
		                               + 0x10) + 0xbd) & 1) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii
		                    (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,
		                     *(int *)(
		                             Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____get_IsCompleted__
		                             + 0x10));
		          if (DAT_ram_009d3e38 != 1) goto code_r0x812c5d1d;
		        }
		        else {
		code_r0x812c5d1d:
		          if (DAT_ram_00a63c4a == '\0') {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi(0x7ff,&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x812c5ed6;
		            DAT_ram_00a63c4a = '\x01';
		          }
		          piVar3 = (int *)local_28;
		          if ((int *)local_28 == (int *)0x0) goto code_r0x812c5f1b;
		          uVar2 = 0;
		          uVar1 = local_20;
		          iVar8 = *(int *)local_28;
		          if (*(ushort *)(iVar8 + 0xb6) != 0) {
		            do {
		              if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		                  *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		                puVar4 = (undefined4 *)
		                         (iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		                goto code_r0x812c5e0b;
		              }
		              uVar2 = uVar2 + 1;
		            } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar4 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,(int *)local_28
		                              ,Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo,0);
		          if (DAT_ram_009d3e38 != 1) {
		code_r0x812c5e0b:
		            DAT_ram_009d3e38 = 0;
		            iVar8 = import::env::invoke_iiii(*puVar4,piVar3,(int)(short)uVar1,puVar4[1]);
		            if (DAT_ram_009d3e38 != 1) {
		              if (iVar8 != 0) goto code_r0x812c5f16;
		              *param1 = 0;
		              *(undefined8 *)(param1 + 4) = local_28;
		              param1[6] = _local_20;
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiii
		                        (s_struct_Uniforms___color__array<v_ram_0000223f + 0x69,param1 + 1,&local_28
		                         ,param1,
		                         Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_Object_____AbstractGameTextMeshProSpriteAssetLoader__ProcessAssetBundle_d__6___
		                        );
		              iVar8 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar8 != 1) {
		                DAT_ram_009d3e38 = 0;
		                return;
		              }
		              uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x812c63c6;
		            }
		          }
		        }
		code_r0x812c5ed6:
		        DAT_ram_009d3e38 = 0;
		        uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		    }
		  }
		code_r0x812c63c6:
		  iVar8 = global_1;
		  iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar9) {
		    puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar7);
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar7,
		                         *(undefined4 *)*puVar4);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 != 1) {
		        if (iVar9 != 0) {
		          uVar7 = *puVar4;
		          import::env::__cxa_end_catch();
		          *param1 = -2;
		          unnamed_function_118873(param1 + 1,uVar7);
		          return;
		        }
		        param2_01 = (undefined4 *)unnamed_function_951(4);
		        *param2_01 = *puVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_01,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x812c6504;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x812c6504:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar7);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04003290 RID: 12944
		[Token(Token = "0x4003290")]
		[FieldOffset(Offset = "0x0")]
		private static Shader _cachedShader;

		// Token: 0x04003291 RID: 12945
		[Token(Token = "0x4003291")]
		[FieldOffset(Offset = "0x2C")]
		private TMP_SpriteAsset _asset;

		// Token: 0x04003292 RID: 12946
		[Token(Token = "0x4003292")]
		[FieldOffset(Offset = "0x30")]
		private readonly GameResourceCancellationToken _cancel;
	}
}
