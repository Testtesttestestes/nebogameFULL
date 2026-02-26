using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.GameResources.Loaders
{
	// Token: 0x02000EE5 RID: 3813
	[Token(Token = "0x2000EE5")]
	public class GameAnimationLoader : AbstractGameResourceLoader<GameResourcesManager.AnimationReadyDelegate>
	{
		// Token: 0x06005CAF RID: 23727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CAF")]
		[Address(RVA = "0xA942", Offset = "0xA942", VA = "0xA942", Slot = "5")]
		protected override void CheckIfReady()
		{
		/* --- GHIDRA: CheckIfReady ---
		void Core_GameResources_Loaders_GameAnimationLoader__CheckIfReady(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5acb2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_CancellationToken__UniTaskVoid__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_GameResources_Loaders_GameAnimationLoader_ProcessAssetBundle__);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
		    DAT_ram_00a5acb2 = '\x01';
		  }
		  UnityEngine_InputSystem_Interactions_PressInteraction__Process(*(undefined4 *)(param1 + 0x30),0);
		  param1_00 = unnamed_function_1417(System_Func_CancellationToken__UniTaskVoid__TypeInfo);
		  System_Func_CancellationToken__object___Invoke
		            (param1_00,param1,
		             Method_Core_GameResources_Loaders_GameAnimationLoader_ProcessAssetBundle__,0);
		  param2_00 = func_ii_6977(*(undefined4 *)(*(int *)(param1 + 0x30) + 8),0);
		  if (*(int *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Cysharp_Threading_Tasks_UniTask_TypeInfo);
		  }
		  Cysharp_Threading_Tasks_UniTask__Void(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06005CB0 RID: 23728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB0")]
		[Address(RVA = "0xA943", Offset = "0xA943", VA = "0xA943", Slot = "6")]
		protected override void OnAssetBundleReady()
		{
		/* --- GHIDRA: OnAssetBundleReady ---
		void Core_GameResources_Loaders_GameAnimationLoader__OnAssetBundleReady
		               (undefined1 *param1,uint param2,uint param3,undefined4 param4)
		
		{
		  undefined4 local_30;
		  longlong local_2c;
		  ulonglong local_24;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5acb3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_Start_GameAnimationLoader__ProcessAssetBundle_d__5___
		              );
		    DAT_ram_00a5acb3 = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  local_14 = 0;
		  local_1c = 0;
		  local_24 = (ulonglong)param3;
		  local_30 = 0xffffffff;
		  local_2c = (ulonglong)param2 << 0x20;
		  Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder__Start_DelayedCall__DelayedCallAsync_d__9_
		            (&local_2c,&local_30,
		             Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_Start_GameAnimationLoader__ProcessAssetBundle_d__5___
		            );
		  *param1 = 0;
		  return;
		}
		*/

		}

		// Token: 0x06005CB1 RID: 23729 RVA: 0x000109F8 File Offset: 0x0000EBF8
		[Token(Token = "0x6005CB1")]
		[Address(RVA = "0xA944", Offset = "0xA944", VA = "0xA944")]
		private UniTaskVoid ProcessAssetBundle(CancellationToken cancellationToken)
		{
		/* --- GHIDRA: ProcessAssetBundle ---
		void Core_GameResources_Loaders_GameAnimationLoader__ProcessAssetBundle
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5acb4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_AnimationReadyDelegate__Dispose__
		              );
		    DAT_ram_00a5acb4 = '\x01';
		  }
		  if (*(char *)(param1 + 0x24) == '\0') {
		    Core_GameResources_GameResourceCancellationToken__Cancel(*(undefined4 *)(param1 + 0x30),0);
		    Core_GameResources_AbstractGameResourceLoader_object___AssetBundleSuccessHandler
		              (param1,
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_AnimationReadyDelegate__Dispose__
		              );
		  }
		  return;
		}
		*/

			return default(UniTaskVoid);
		}

		// Token: 0x06005CB2 RID: 23730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB2")]
		[Address(RVA = "0xA945", Offset = "0xA945", VA = "0xA945", Slot = "7")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_GameResources_Loaders_GameAnimationLoader__Dispose(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5acb5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_AnimationReadyDelegate__ReleaseAssetBundle__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5acb5 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x30);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_AnimationReadyDelegate__ReleaseAssetBundle__
		             ,0);
		  Core_GameResources_GameResourceCancellationToken__Init(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06005CB3 RID: 23731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB3")]
		[Address(RVA = "0xA946", Offset = "0xA946", VA = "0xA946", Slot = "8")]
		protected override void ReleaseAssetBundle()
		{
		/* --- GHIDRA: ReleaseAssetBundle ---
		void Core_GameResources_Loaders_GameAnimationLoader__ReleaseAssetBundle
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5acb6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_AnimationReadyDelegate___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourceCancellationToken_TypeInfo);
		    DAT_ram_00a5acb6 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Core_GameResources_GameResourceCancellationToken_TypeInfo);
		  Core_GameResources_GameResourceCancellationToken__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0x30) = param1_00;
		  AssetContent_Loaders_AbstractGameGraphicLoader_object__object___set_IsReady
		            (param1,
		             Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_AnimationReadyDelegate___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06005CB4 RID: 23732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB4")]
		[Address(RVA = "0xA947", Offset = "0xA947", VA = "0xA947")]
		public GameAnimationLoader()
		{
		/* --- GHIDRA: .cctor ---
		void Core_GameResources_Loaders_GameAnimationLoader___cctor(int *param1,undefined4 param2)
		
		{
		  ushort uVar1;
		  undefined8 uVar2;
		  uint uVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  uint *puVar8;
		  undefined4 uVar9;
		  undefined4 *param2_00;
		  int *piVar10;
		  int iVar11;
		  int iVar12;
		  int *piVar13;
		  int *piVar14;
		  int *param2_01;
		  int *piVar15;
		  undefined8 local_38;
		  ushort local_30;
		  undefined8 local_28;
		  int local_20;
		  undefined8 local_18;
		  int local_10;
		  undefined8 local_c;
		  int local_4;
		  
		  if (DAT_ram_00a5acb8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_AssetBundle_LoadAllAssetsAsync_GAFAnimationAsset___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_AssetBundle_LoadAllAssetsAsync_GameObject___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_AssetBundle_LoadAllAssetsAsync_Material___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_AssetBundle_LoadAllAssetsAsync_Texture2D___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_Object_____GameAnimationLoader__ProcessAssetBundle_d__5___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____GetResult__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____get_IsCompleted__);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&GAF_Assets_GAFAnimationAsset_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameResources_Loaders_GameAnimationLoader_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_GAFBakedMovieClip___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_GameObject_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Material_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Texture2D_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Cysharp_Threading_Tasks_UniTask_Object____GetAwaiter__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3135);
		    Mono_Security_ASN1__get_Item(&StringLiteral_383);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3134);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8418);
		    DAT_ram_00a5acb8 = '\x01';
		  }
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  _local_30 = 0;
		  local_38 = 0;
		  piVar10 = (int *)param1[2];
		  iVar11 = *param1;
		  if (iVar11 == 0) {
		    _local_30 = param1[7];
		    local_38 = *(undefined8 *)(param1 + 5);
		    param1[5] = 0;
		    param1[6] = 0;
		    param1[7] = 0;
		    *param1 = -1;
		    piVar13 = (int *)local_38;
		code_r0x812c6fa8:
		    if (piVar13 != (int *)0x0) {
		      uVar1 = local_30;
		      iVar11 = *(int *)(Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____GetResult__ + 0x10)
		      ;
		      if ((*(byte *)(iVar11 + 0xbd) & 1) == 0) {
		        DAT_ram_009d3e38 = 0;
		        iVar11 = import::env::invoke_ii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar11);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x812c7004;
		      }
		      else {
		code_r0x812c7004:
		        iVar11 = *(int *)(*(int *)(iVar11 + 0x60) + 0x14);
		        if ((*(byte *)(iVar11 + 0xbd) & 1) == 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar11 = import::env::invoke_ii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar11);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x812c8d62;
		        }
		        iVar12 = *piVar13;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          uVar3 = 0;
		          do {
		            if (iVar11 == *(int *)(*(int *)(iVar12 + 0x58) + uVar3 * 8)) {
		              puVar4 = (undefined4 *)
		                       (iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar3 * 8 + 4) * 8 + 0xc0);
		              goto code_r0x812c70d5;
		            }
		            uVar3 = uVar3 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar3);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar13,iVar11,0)
		        ;
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x812c70d5:
		          DAT_ram_009d3e38 = 0;
		          iVar11 = import::env::invoke_iiii(*puVar4,piVar13,(int)(short)uVar1,puVar4[1]);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x812c711b;
		        }
		      }
		code_r0x812c8d62:
		      DAT_ram_009d3e38 = 0;
		      uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812c8d6a;
		    }
		code_r0x812c6fad:
		    iVar11 = local_38._4_4_;
		code_r0x812c711b:
		    param1[4] = iVar11;
		    DAT_ram_009d3e38 = 0;
		    iVar12 = import::env::invoke_iii
		                       (s_struct_Uniforms___color__array<v_ram_0000223f + 0x66,piVar10[0xc],0);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 == 1) {
		      uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812c8d6a;
		    }
		    if (iVar12 != 0) goto code_r0x812c8c67;
		    iVar11 = param1[4];
		    if (0 < *(int *)(iVar11 + 0xc)) {
		      iVar12 = 0;
		      do {
		        piVar13 = *(int **)(iVar11 + iVar12 * 4 + 0x10);
		        if (piVar13 != (int *)0x0) {
		          if (((uint)*(byte *)(*piVar13 + 0xb8) <
		               (uint)*(byte *)(UnityEngine_Material_TypeInfo + 0xb8)) ||
		             (*(int *)(*(int *)(*piVar13 + 100) +
		                       (uint)*(byte *)(UnityEngine_Material_TypeInfo + 0xb8) * 4 + -4) !=
		              UnityEngine_Material_TypeInfo)) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar13,
		                       UnityEngine_Material_TypeInfo);
		            iVar11 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar11 != 1) goto code_r0x812c8ea0;
		            uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x812c8d6a;
		          }
		        }
		        if (*(int *)(Core_GameResources_Loaders_GameAnimationLoader_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     Core_GameResources_Loaders_GameAnimationLoader_TypeInfo);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x812c8d6a;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_0000223f + 0x6f,piVar13,
		                   **(undefined4 **)(Core_GameResources_Loaders_GameAnimationLoader_TypeInfo + 0x5c)
		                   ,1,0);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x812c8d6a;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar9 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_0000223f + 0x70,piVar13,0);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x812c8d6a;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar9 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x215,uVar9,0);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x812c8d6a;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_0000223f + 0x71,uVar9,0);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x812c8d6a;
		        }
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x812c8d6a;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3b7,uVar5,0,0);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x812c8d6a;
		        }
		        if (iVar7 == 0) {
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x215,piVar13,0);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            uVar9 = import::env::invoke_iiiiii
		                              (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1d9,
		                               StringLiteral_8418,uVar9,StringLiteral_383,uVar5,0);
		            if (DAT_ram_009d3e38 != 1) {
		              if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vi
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                           OKG_Logs_Debug_TypeInfo);
		                if (DAT_ram_009d3e38 == 1) goto code_r0x812c76db;
		              }
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x310,uVar9,0);
		              if (DAT_ram_009d3e38 != 1) goto code_r0x812c750a;
		            }
		code_r0x812c76db:
		            DAT_ram_009d3e38 = 0;
		            uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          goto code_r0x812c8d6a;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_0000223f + 0x72,piVar13,uVar5,0);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x812c8d6a;
		        }
		code_r0x812c750a:
		        iVar12 = iVar12 + 1;
		      } while (iVar12 < *(int *)(iVar11 + 0xc));
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar9 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_0000223f + 99,piVar10[6],
		                       Method_UnityEngine_AssetBundle_LoadAllAssetsAsync_GameObject___);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 == 1) {
		      uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812c8d6a;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiiiii
		              (s_struct_Uniforms___color__array<v_ram_0000223f + 100,&local_c,uVar9,0,8,param1[3],0)
		    ;
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 == 1) {
		      uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812c8d6a;
		    }
		    local_20 = local_4;
		    local_28 = local_c;
		    if ((*(byte *)(*(int *)(Method_Cysharp_Threading_Tasks_UniTask_Object____GetAwaiter__ + 0x10) +
		                  0xbd) & 1) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii
		                (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,
		                 *(int *)(Method_Cysharp_Threading_Tasks_UniTask_Object____GetAwaiter__ + 0x10));
		      iVar11 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar11 == 1) {
		        uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x812c8d6a;
		      }
		    }
		    _local_30 = local_20;
		    local_38 = local_28;
		    if ((*(byte *)(*(int *)(
		                           Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____get_IsCompleted__
		                           + 0x10) + 0xbd) & 1) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii
		                (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,
		                 *(int *)(Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____get_IsCompleted__
		                         + 0x10));
		      if (DAT_ram_009d3e38 != 1) goto code_r0x812c7653;
		      goto code_r0x812c793d;
		    }
		code_r0x812c7653:
		    if (DAT_ram_00a63c4a == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x812c793d;
		      DAT_ram_00a63c4a = '\x01';
		    }
		    piVar13 = (int *)local_38;
		    if ((int *)local_38 == (int *)0x0) goto code_r0x812c7a77;
		    uVar3 = 0;
		    uVar1 = local_30;
		    iVar11 = *(int *)local_38;
		    if (*(ushort *)(iVar11 + 0xb6) != 0) {
		      do {
		        if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		            *(int *)(*(int *)(iVar11 + 0x58) + uVar3 * 8)) {
		          puVar4 = (undefined4 *)
		                   (iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar3 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x812c7754;
		        }
		        uVar3 = uVar3 + 1;
		      } while (*(ushort *)(iVar11 + 0xb6) != uVar3);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,(int *)local_38,
		                        Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo,0);
		    if (DAT_ram_009d3e38 != 1) {
		code_r0x812c7754:
		      DAT_ram_009d3e38 = 0;
		      iVar11 = import::env::invoke_iiii(*puVar4,piVar13,(int)(short)uVar1,puVar4[1]);
		      if (DAT_ram_009d3e38 != 1) {
		        if (iVar11 != 0) goto code_r0x812c7a72;
		        *param1 = 1;
		        param1[7] = _local_30;
		        *(undefined8 *)(param1 + 5) = local_38;
		        iVar11 = 
		        Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_Object_____GameAnimationLoader__ProcessAssetBundle_d__5___
		        ;
		        if (*(int *)(
		                    Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_Object_____GameAnimationLoader__ProcessAssetBundle_d__5___
		                    + 0x1c) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (0x7ff,&Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunner_TypeInfo);
		          if (DAT_ram_009d3e38 != 1) {
		            if (*(int *)(iVar11 + 0x1c) == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_ii(s_struct_Uniforms___color__vec4<f3_ram_00000856 + 6,iVar11);
		              if (DAT_ram_009d3e38 == 1) goto code_r0x812c7a32;
		            }
		            goto code_r0x812c782d;
		          }
		        }
		        else {
		code_r0x812c782d:
		          piVar13 = param1 + 1;
		          piVar10 = (int *)*piVar13;
		          if (piVar10 == (int *)0x0) {
		            iVar12 = *(int *)(*(int *)(iVar11 + 0x1c) + 8);
		            if ((*(byte *)(iVar12 + 0xbd) & 1) == 0) {
		              DAT_ram_009d3e38 = 0;
		              iVar12 = import::env::invoke_ii
		                                 (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar12);
		              if (DAT_ram_009d3e38 == 1) goto code_r0x812c7a32;
		            }
		            if (*(int *)(iVar12 + 0x74) == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,iVar12)
		              ;
		              if (DAT_ram_009d3e38 == 1) goto code_r0x812c7a32;
		            }
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii
		                      (s_struct_Uniforms___color__array<v_ram_0000223f + 0x6d,param1,piVar13,
		                       *(undefined4 *)(*(int *)(iVar11 + 0x1c) + 4));
		            if (DAT_ram_009d3e38 == 1) goto code_r0x812c7a32;
		            piVar10 = (int *)*piVar13;
		          }
		          uVar3 = 0;
		          iVar12 = *piVar10;
		          if (*(ushort *)(iVar12 + 0xb6) != 0) {
		            do {
		              if (Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunner_TypeInfo ==
		                  *(int *)(*(int *)(iVar12 + 0x58) + uVar3 * 8)) {
		                puVar4 = (undefined4 *)
		                         (iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar3 * 8 + 4) * 8 + 0xc0);
		                goto code_r0x812c79b6;
		              }
		              uVar3 = uVar3 + 1;
		            } while (*(ushort *)(iVar12 + 0xb6) != uVar3);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar4 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar10,
		                              Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunner_TypeInfo,
		                              0);
		          if (DAT_ram_009d3e38 != 1) {
		code_r0x812c79b6:
		            DAT_ram_009d3e38 = 0;
		            uVar9 = import::env::invoke_iii(*puVar4,piVar10,puVar4[1]);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viii
		                        (s_struct_Uniforms___color__array<v_ram_0000223f + 0x6e,&local_38,uVar9,
		                         *(undefined4 *)(*(int *)(iVar11 + 0x1c) + 0x14));
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                return;
		              }
		            }
		          }
		        }
		code_r0x812c7a32:
		        DAT_ram_009d3e38 = 0;
		        uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x812c8d6a;
		      }
		    }
		code_r0x812c793d:
		    DAT_ram_009d3e38 = 0;
		    uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x812c8d6a;
		  }
		  if (iVar11 == 1) {
		    _local_30 = param1[7];
		    local_38 = *(undefined8 *)(param1 + 5);
		    param1[5] = 0;
		    param1[6] = 0;
		    param1[7] = 0;
		    *param1 = -1;
		    piVar13 = (int *)local_38;
		code_r0x812c7a72:
		    if (piVar13 != (int *)0x0) {
		      uVar1 = local_30;
		      iVar11 = *(int *)(Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____GetResult__ + 0x10)
		      ;
		      if ((*(byte *)(iVar11 + 0xbd) & 1) == 0) {
		        DAT_ram_009d3e38 = 0;
		        iVar11 = import::env::invoke_ii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar11);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x812c7ace;
		      }
		      else {
		code_r0x812c7ace:
		        iVar11 = *(int *)(*(int *)(iVar11 + 0x60) + 0x14);
		        if ((*(byte *)(iVar11 + 0xbd) & 1) == 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar11 = import::env::invoke_ii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar11);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x812c8bdb;
		        }
		        iVar12 = *piVar13;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          uVar3 = 0;
		          do {
		            if (iVar11 == *(int *)(*(int *)(iVar12 + 0x58) + uVar3 * 8)) {
		              puVar4 = (undefined4 *)
		                       (iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar3 * 8 + 4) * 8 + 0xc0);
		              goto code_r0x812c7b9f;
		            }
		            uVar3 = uVar3 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar3);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar13,iVar11,0)
		        ;
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x812c7b9f:
		          DAT_ram_009d3e38 = 0;
		          iVar11 = import::env::invoke_iiii(*puVar4,piVar13,(int)(short)uVar1,puVar4[1]);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x812c7be5;
		        }
		      }
		code_r0x812c8bdb:
		      DAT_ram_009d3e38 = 0;
		      uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812c8d6a;
		    }
		code_r0x812c7a77:
		    iVar11 = local_38._4_4_;
		code_r0x812c7be5:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_0000223f + 0x66,piVar10[0xc],0);
		    iVar12 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar12 == 1) {
		      uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812c8d6a;
		    }
		    if (iVar6 != 0) goto code_r0x812c8c67;
		    if (0 < *(int *)(iVar11 + 0xc)) {
		      iVar12 = 0;
		      do {
		        iVar6 = UnityEngine_GameObject_TypeInfo;
		        piVar13 = *(int **)(iVar11 + iVar12 * 4 + 0x10);
		        if (piVar13 == (int *)0x0) {
		          param1[8] = 0;
		        }
		        else if ((UnityEngine_GameObject_TypeInfo != *piVar13) ||
		                (param1[8] = (int)piVar13, *piVar13 != iVar6)) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar13,iVar6);
		          iVar11 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar11 != 1) goto code_r0x812c8ea0;
		          uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x812c8d6a;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar9 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_0000223f + 0x73,piVar13,0);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x812c8d6a;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0xe5,uVar9,
		                           StringLiteral_3134,0);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x812c8d6a;
		        }
		        if (iVar7 != 0) {
		          DAT_ram_009d3e38 = 0;
		          uVar9 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_0000223f + 0x73,param1[8],0);
		          iVar11 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar11 == 1) {
		            uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x812c8d6a;
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar12 = import::env::invoke_iiii
		                             (s_struct_Uniforms___color__array<v_ram_00000aff + 0xe5,uVar9,
		                              StringLiteral_3135,0);
		          iVar11 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar11 == 1) {
		            uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x812c8d6a;
		          }
		          if (iVar12 == 0) goto code_r0x812c8b9c;
		          piVar13 = (int *)0x0;
		          DAT_ram_009d3e38 = 0;
		          iVar12 = import::env::invoke_iii
		                             (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x202,param1[8],
		                              Method_UnityEngine_GameObject_GetComponent_GAFBakedMovieClip___);
		          iVar11 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar11 == 1) {
		            uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x812c8d6a;
		          }
		          param1[9] = iVar12;
		          piVar14 = *(int **)(param1[4] + 0x10);
		          if (piVar14 != (int *)0x0) {
		            if (((uint)*(byte *)(UnityEngine_Material_TypeInfo + 0xb8) <=
		                 (uint)*(byte *)(*piVar14 + 0xb8)) &&
		               (piVar13 = piVar14,
		               *(int *)(*(int *)(*piVar14 + 100) +
		                        (uint)*(byte *)(UnityEngine_Material_TypeInfo + 0xb8) * 4 + -4) !=
		               UnityEngine_Material_TypeInfo)) {
		              piVar13 = (int *)0x0;
		            }
		          }
		          param1[10] = (int)piVar13;
		          DAT_ram_009d3e38 = 0;
		          uVar9 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_0000223f + 99,piVar10[6],
		                             Method_UnityEngine_AssetBundle_LoadAllAssetsAsync_Texture2D___);
		          iVar11 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar11 == 1) {
		            uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x812c8d6a;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiiiii
		                    (s_struct_Uniforms___color__array<v_ram_0000223f + 100,&local_c,uVar9,0,8,
		                     param1[3],0);
		          iVar12 = local_4;
		          uVar2 = local_c;
		          iVar11 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar11 == 1) {
		            uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x812c8d6a;
		          }
		          if ((*(byte *)(*(int *)(Method_Cysharp_Threading_Tasks_UniTask_Object____GetAwaiter__ +
		                                 0x10) + 0xbd) & 1) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,
		                       *(int *)(Method_Cysharp_Threading_Tasks_UniTask_Object____GetAwaiter__ + 0x10
		                               ));
		            iVar11 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar11 == 1) {
		              uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x812c8d6a;
		            }
		          }
		          _local_30 = iVar12;
		          local_38 = uVar2;
		          if ((*(byte *)(*(int *)(
		                                 Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____get_IsCompleted__
		                                 + 0x10) + 0xbd) & 1) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,
		                       *(int *)(
		                               Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____get_IsCompleted__
		                               + 0x10));
		            if (DAT_ram_009d3e38 == 1) goto code_r0x812c816f;
		          }
		          if (DAT_ram_00a63c4a == '\0') {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi(0x7ff,&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x812c816f;
		            DAT_ram_00a63c4a = '\x01';
		          }
		          piVar13 = (int *)local_38;
		          if ((int *)local_38 == (int *)0x0) goto code_r0x812c81ec;
		          uVar3 = 0;
		          uVar1 = local_30;
		          iVar11 = *(int *)local_38;
		          if (*(ushort *)(iVar11 + 0xb6) == 0) goto code_r0x812c8067;
		          goto code_r0x812c802d;
		        }
		        param1[8] = 0;
		        iVar12 = iVar12 + 1;
		      } while (iVar12 < *(int *)(iVar11 + 0xc));
		    }
		  }
		  else {
		    if (iVar11 == 2) {
		      _local_30 = param1[7];
		      local_38 = *(undefined8 *)(param1 + 5);
		      param1[5] = 0;
		      param1[6] = 0;
		      param1[7] = 0;
		      *param1 = -1;
		      piVar13 = (int *)local_38;
		      goto code_r0x812c81e7;
		    }
		    if (iVar11 != 3) {
		      DAT_ram_009d3e38 = 0;
		      uVar9 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_0000223f + 99,piVar10[6],
		                         Method_UnityEngine_AssetBundle_LoadAllAssetsAsync_Material___);
		      iVar11 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar11 == 1) {
		        uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x812c8d6a;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiiiii
		                (s_struct_Uniforms___color__array<v_ram_0000223f + 100,&local_c,uVar9,0,8,param1[3],
		                 0);
		      iVar11 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar11 == 1) {
		        uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x812c8d6a;
		      }
		      local_10 = local_4;
		      local_18 = local_c;
		      if ((*(byte *)(*(int *)(Method_Cysharp_Threading_Tasks_UniTask_Object____GetAwaiter__ + 0x10)
		                    + 0xbd) & 1) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,
		                   *(int *)(Method_Cysharp_Threading_Tasks_UniTask_Object____GetAwaiter__ + 0x10));
		        iVar11 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar11 == 1) {
		          uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x812c8d6a;
		        }
		      }
		      _local_30 = local_10;
		      local_38 = local_18;
		      if ((*(byte *)(*(int *)(
		                             Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____get_IsCompleted__
		                             + 0x10) + 0xbd) & 1) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,
		                   *(int *)(
		                           Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____get_IsCompleted__
		                           + 0x10));
		        if (DAT_ram_009d3e38 != 1) goto code_r0x812c6b9c;
		        goto code_r0x812c6e73;
		      }
		code_r0x812c6b9c:
		      if (DAT_ram_00a63c4a == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(0x7ff,&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x812c6e73;
		        DAT_ram_00a63c4a = '\x01';
		      }
		      piVar13 = (int *)local_38;
		      if ((int *)local_38 == (int *)0x0) goto code_r0x812c6fad;
		      uVar3 = 0;
		      uVar1 = local_30;
		      iVar11 = *(int *)local_38;
		      if (*(ushort *)(iVar11 + 0xb6) != 0) {
		        do {
		          if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		              *(int *)(*(int *)(iVar11 + 0x58) + uVar3 * 8)) {
		            puVar4 = (undefined4 *)
		                     (iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar3 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x812c6c8a;
		          }
		          uVar3 = uVar3 + 1;
		        } while (*(ushort *)(iVar11 + 0xb6) != uVar3);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,(int *)local_38,
		                          Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo,0);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x812c6c8a:
		        DAT_ram_009d3e38 = 0;
		        iVar11 = import::env::invoke_iiii(*puVar4,piVar13,(int)(short)uVar1,puVar4[1]);
		        if (DAT_ram_009d3e38 != 1) {
		          if (iVar11 != 0) goto code_r0x812c6fa8;
		          *param1 = 0;
		          param1[7] = _local_30;
		          *(undefined8 *)(param1 + 5) = local_38;
		          iVar11 = 
		          Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_Object_____GameAnimationLoader__ProcessAssetBundle_d__5___
		          ;
		          if (*(int *)(
		                      Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_Object_____GameAnimationLoader__ProcessAssetBundle_d__5___
		                      + 0x1c) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (0x7ff,&Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunner_TypeInfo)
		            ;
		            if (DAT_ram_009d3e38 != 1) {
		              if (*(int *)(iVar11 + 0x1c) == 0) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_ii(s_struct_Uniforms___color__vec4<f3_ram_00000856 + 6,iVar11);
		                if (DAT_ram_009d3e38 == 1) goto code_r0x812c6f68;
		              }
		              goto code_r0x812c6d63;
		            }
		          }
		          else {
		code_r0x812c6d63:
		            piVar13 = param1 + 1;
		            piVar10 = (int *)*piVar13;
		            if (piVar10 == (int *)0x0) {
		              iVar12 = *(int *)(*(int *)(iVar11 + 0x1c) + 8);
		              if ((*(byte *)(iVar12 + 0xbd) & 1) == 0) {
		                DAT_ram_009d3e38 = 0;
		                iVar12 = import::env::invoke_ii
		                                   (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar12);
		                if (DAT_ram_009d3e38 == 1) goto code_r0x812c6f68;
		              }
		              if (*(int *)(iVar12 + 0x74) == 0) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vi
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,iVar12);
		                if (DAT_ram_009d3e38 == 1) goto code_r0x812c6f68;
		              }
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viii
		                        (s_struct_Uniforms___color__array<v_ram_0000223f + 0x6d,param1,piVar13,
		                         *(undefined4 *)(*(int *)(iVar11 + 0x1c) + 4));
		              if (DAT_ram_009d3e38 == 1) goto code_r0x812c6f68;
		              piVar10 = (int *)*piVar13;
		            }
		            uVar3 = 0;
		            iVar12 = *piVar10;
		            if (*(ushort *)(iVar12 + 0xb6) != 0) {
		              do {
		                if (Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunner_TypeInfo ==
		                    *(int *)(*(int *)(iVar12 + 0x58) + uVar3 * 8)) {
		                  puVar4 = (undefined4 *)
		                           (iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar3 * 8 + 4) * 8 + 0xc0);
		                  goto code_r0x812c6eec;
		                }
		                uVar3 = uVar3 + 1;
		              } while (*(ushort *)(iVar12 + 0xb6) != uVar3);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar4 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar10,
		                                Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunner_TypeInfo
		                                ,0);
		            if (DAT_ram_009d3e38 != 1) {
		code_r0x812c6eec:
		              DAT_ram_009d3e38 = 0;
		              uVar9 = import::env::invoke_iii(*puVar4,piVar10,puVar4[1]);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_viii
		                          (s_struct_Uniforms___color__array<v_ram_0000223f + 0x6e,&local_38,uVar9,
		                           *(undefined4 *)(*(int *)(iVar11 + 0x1c) + 0x14));
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  return;
		                }
		              }
		            }
		          }
		code_r0x812c6f68:
		          DAT_ram_009d3e38 = 0;
		          uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x812c8d6a;
		        }
		      }
		code_r0x812c6e73:
		      DAT_ram_009d3e38 = 0;
		      uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812c8d6a;
		    }
		    _local_30 = param1[7];
		    local_38 = *(undefined8 *)(param1 + 5);
		    param1[5] = 0;
		    param1[6] = 0;
		    param1[7] = 0;
		    *param1 = -1;
		    piVar13 = (int *)local_38;
		code_r0x812c88cb:
		    if (piVar13 != (int *)0x0) {
		      uVar1 = local_30;
		      iVar11 = *(int *)(Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____GetResult__ + 0x10)
		      ;
		      if ((*(byte *)(iVar11 + 0xbd) & 1) == 0) {
		        DAT_ram_009d3e38 = 0;
		        iVar11 = import::env::invoke_ii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar11);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x812c8927;
		      }
		      else {
		code_r0x812c8927:
		        iVar11 = *(int *)(*(int *)(iVar11 + 0x60) + 0x14);
		        if ((*(byte *)(iVar11 + 0xbd) & 1) == 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar11 = import::env::invoke_ii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar11);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x812c8ba9;
		        }
		        iVar12 = *piVar13;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          uVar3 = 0;
		          do {
		            if (iVar11 == *(int *)(*(int *)(iVar12 + 0x58) + uVar3 * 8)) {
		              puVar4 = (undefined4 *)
		                       (iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar3 * 8 + 4) * 8 + 0xc0);
		              goto code_r0x812c89f8;
		            }
		            uVar3 = uVar3 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar3);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar13,iVar11,0)
		        ;
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x812c89f8:
		          DAT_ram_009d3e38 = 0;
		          iVar11 = import::env::invoke_iiii(*puVar4,piVar13,(int)(short)uVar1,puVar4[1]);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x812c8a3e;
		        }
		      }
		code_r0x812c8ba9:
		      DAT_ram_009d3e38 = 0;
		      uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812c8d6a;
		    }
		code_r0x812c88d0:
		    iVar11 = local_38._4_4_;
		code_r0x812c8a3e:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_0000223f + 0x66,piVar10[0xc],0);
		    iVar12 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar12 == 1) {
		      uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812c8d6a;
		    }
		    if (iVar6 != 0) goto code_r0x812c8c67;
		    piVar13 = *(int **)(iVar11 + 0x10);
		    if (piVar13 == (int *)0x0) {
		      piVar13 = (int *)0x0;
		    }
		    else if ((uint)*(byte *)(*piVar13 + 0xb8) <
		             (uint)*(byte *)(GAF_Assets_GAFAnimationAsset_TypeInfo + 0xb8)) {
		      piVar13 = (int *)0x0;
		    }
		    else if (*(int *)(*(int *)(*piVar13 + 100) +
		                      (uint)*(byte *)(GAF_Assets_GAFAnimationAsset_TypeInfo + 0xb8) * 4 + -4) !=
		             GAF_Assets_GAFAnimationAsset_TypeInfo) {
		      piVar13 = (int *)0x0;
		    }
		    iVar12 = param1[9];
		    DAT_ram_009d3e38 = 0;
		    uVar9 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x215,piVar13,0);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 == 1) {
		      uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812c8d6a;
		    }
		    *(undefined4 *)(iVar12 + 0xa4) = uVar9;
		    param2_01 = (int *)param1[9];
		    param2_01[0x27] = param1[10];
		    piVar14 = (int *)0x0;
		    piVar15 = *(int **)(param1[0xb] + 0x10);
		    if ((piVar15 != (int *)0x0) && (piVar14 = piVar15, *piVar15 != UnityEngine_Texture2D_TypeInfo))
		    {
		      piVar14 = (int *)0x0;
		    }
		    param2_01[0x26] = (int)piVar13;
		    param2_01[0x28] = (int)piVar14;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (*(undefined4 *)(*param2_01 + 0x118),param2_01,*(undefined4 *)(*param2_01 + 0x11c));
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 == 1) {
		      uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812c8d6a;
		    }
		    param1[0xb] = 0;
		    param1[9] = 0;
		    param1[10] = 0;
		code_r0x812c8b9c:
		    piVar10[0xb] = param1[8];
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_vii(*(undefined4 *)(*piVar10 + 0xe8),piVar10,*(undefined4 *)(*piVar10 + 0xec))
		  ;
		  iVar11 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar11 == 1) {
		    uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x67,piVar10[0xc],0);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 != 1) {
		code_r0x812c8c67:
		      DAT_ram_009d3e38 = 0;
		      param1[4] = 0;
		      *param1 = -2;
		      if (DAT_ram_00a62c28 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunner_TypeInfo);
		        Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_PlayerLoopHelper_TypeInfo);
		        DAT_ram_00a62c28 = '\x01';
		      }
		      piVar10 = (int *)param1[1];
		      if (piVar10 == (int *)0x0) {
		        return;
		      }
		      uVar3 = 0;
		      iVar11 = *piVar10;
		      if (*(ushort *)(iVar11 + 0xb6) != 0) {
		        do {
		          if (Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunner_TypeInfo ==
		              *(int *)(*(int *)(iVar11 + 0x58) + uVar3 * 8)) {
		            puVar8 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar3 * 8 + 4) * 8 + iVar11 + 200);
		            goto code_r0x812c8d14;
		          }
		          uVar3 = uVar3 + 1;
		        } while (*(ushort *)(iVar11 + 0xb6) != uVar3);
		      }
		      puVar8 = (uint *)func_ii_1080(piVar10,
		                                    Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunner_TypeInfo
		                                    ,1);
		code_r0x812c8d14:
		      uVar9 = (**(code **)((ulonglong)*puVar8 * 4))(piVar10,puVar8[1]);
		      if (*(int *)(Cysharp_Threading_Tasks_PlayerLoopHelper_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Cysharp_Threading_Tasks_PlayerLoopHelper_TypeInfo);
		      }
		      Cysharp_Threading_Tasks_PlayerLoopHelper__ThrowInvalidLoopTiming(0xd,uVar9,0);
		      param1[1] = 0;
		      return;
		    }
		    uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		code_r0x812c8d6a:
		  iVar11 = global_1;
		  iVar12 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar11 == iVar12) {
		    puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar9);
		    DAT_ram_009d3e38 = 0;
		    uVar9 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar12 = import::env::invoke_iii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar9,
		                          *(undefined4 *)*puVar4);
		      iVar11 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar11 != 1) {
		        if (iVar12 != 0) {
		          uVar9 = *puVar4;
		          import::env::__cxa_end_catch();
		          param1[4] = 0;
		          *param1 = -2;
		          unnamed_function_118873(param1 + 1,uVar9);
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x812c8ea0:
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar9 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar9);
		  do {
		    halt_trap();
		  } while( true );
		  while (uVar3 = uVar3 + 1, *(ushort *)(iVar11 + 0xb6) != uVar3) {
		code_r0x812c802d:
		    if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		        *(int *)(*(int *)(iVar11 + 0x58) + uVar3 * 8)) {
		      puVar4 = (undefined4 *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar3 * 8 + 4) * 8 + 0xc0)
		      ;
		      goto code_r0x812c809a;
		    }
		  }
		code_r0x812c8067:
		  DAT_ram_009d3e38 = 0;
		  puVar4 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,(int *)local_38,
		                      Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo,0);
		  if (DAT_ram_009d3e38 != 1) {
		code_r0x812c809a:
		    DAT_ram_009d3e38 = 0;
		    iVar11 = import::env::invoke_iiii(*puVar4,piVar13,(int)(short)uVar1,puVar4[1]);
		    if (DAT_ram_009d3e38 != 1) {
		      if (iVar11 == 0) {
		        *param1 = 2;
		        *(undefined8 *)(param1 + 5) = local_38;
		        param1[7] = _local_30;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_0000223f + 0x74,param1 + 1,&local_38,
		                   param1,
		                   Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_Object_____GameAnimationLoader__ProcessAssetBundle_d__5___
		                  );
		        iVar11 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar11 != 1) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x812c8d6a;
		      }
		code_r0x812c81e7:
		      if (piVar13 != (int *)0x0) {
		        uVar1 = local_30;
		        iVar11 = *(int *)(Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____GetResult__ +
		                         0x10);
		        if ((*(byte *)(iVar11 + 0xbd) & 1) == 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar11 = import::env::invoke_ii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar11);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x812c8243;
		        }
		        else {
		code_r0x812c8243:
		          iVar11 = *(int *)(*(int *)(iVar11 + 0x60) + 0x14);
		          if ((*(byte *)(iVar11 + 0xbd) & 1) == 0) {
		            DAT_ram_009d3e38 = 0;
		            iVar11 = import::env::invoke_ii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar11);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x812c83a1;
		          }
		          iVar12 = *piVar13;
		          if (*(ushort *)(iVar12 + 0xb6) != 0) {
		            uVar3 = 0;
		            do {
		              if (iVar11 == *(int *)(*(int *)(iVar12 + 0x58) + uVar3 * 8)) {
		                puVar4 = (undefined4 *)
		                         (iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar3 * 8 + 4) * 8 + 0xc0);
		                goto code_r0x812c8314;
		              }
		              uVar3 = uVar3 + 1;
		            } while (*(ushort *)(iVar12 + 0xb6) != uVar3);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar4 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar13,iVar11,
		                              0);
		          if (DAT_ram_009d3e38 != 1) {
		code_r0x812c8314:
		            DAT_ram_009d3e38 = 0;
		            iVar11 = import::env::invoke_iiii(*puVar4,piVar13,(int)(short)uVar1,puVar4[1]);
		            if (DAT_ram_009d3e38 != 1) goto code_r0x812c835a;
		          }
		        }
		code_r0x812c83a1:
		        DAT_ram_009d3e38 = 0;
		        uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x812c8d6a;
		      }
		code_r0x812c81ec:
		      iVar11 = local_38._4_4_;
		code_r0x812c835a:
		      param1[0xb] = iVar11;
		      DAT_ram_009d3e38 = 0;
		      iVar12 = import::env::invoke_iii
		                         (s_struct_Uniforms___color__array<v_ram_0000223f + 0x66,piVar10[0xc],0);
		      iVar11 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar11 == 1) {
		        uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x812c8d6a;
		      }
		      if (iVar12 != 0) goto code_r0x812c8c67;
		      DAT_ram_009d3e38 = 0;
		      uVar9 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_0000223f + 99,piVar10[6],
		                         Method_UnityEngine_AssetBundle_LoadAllAssetsAsync_GAFAnimationAsset___);
		      iVar11 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar11 == 1) {
		        uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x812c8d6a;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiiiii
		                (s_struct_Uniforms___color__array<v_ram_0000223f + 100,&local_c,uVar9,0,8,param1[3],
		                 0);
		      iVar11 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar11 == 1) {
		        uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x812c8d6a;
		      }
		      if ((*(byte *)(*(int *)(Method_Cysharp_Threading_Tasks_UniTask_Object____GetAwaiter__ + 0x10)
		                    + 0xbd) & 1) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,
		                   *(int *)(Method_Cysharp_Threading_Tasks_UniTask_Object____GetAwaiter__ + 0x10));
		        iVar11 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar11 == 1) {
		          uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x812c8d6a;
		        }
		      }
		      _local_30 = local_4;
		      local_38 = local_c;
		      if ((*(byte *)(*(int *)(
		                             Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____get_IsCompleted__
		                             + 0x10) + 0xbd) & 1) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,
		                   *(int *)(
		                           Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____get_IsCompleted__
		                           + 0x10));
		        if (DAT_ram_009d3e38 != 1) goto code_r0x812c84f5;
		        goto code_r0x812c87cc;
		      }
		code_r0x812c84f5:
		      if (DAT_ram_00a63c4a == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(0x7ff,&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x812c87cc;
		        DAT_ram_00a63c4a = '\x01';
		      }
		      piVar13 = (int *)local_38;
		      if ((int *)local_38 == (int *)0x0) goto code_r0x812c88d0;
		      uVar3 = 0;
		      uVar1 = local_30;
		      iVar11 = *(int *)local_38;
		      if (*(ushort *)(iVar11 + 0xb6) != 0) {
		        do {
		          if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		              *(int *)(*(int *)(iVar11 + 0x58) + uVar3 * 8)) {
		            puVar4 = (undefined4 *)
		                     (iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar3 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x812c85e3;
		          }
		          uVar3 = uVar3 + 1;
		        } while (*(ushort *)(iVar11 + 0xb6) != uVar3);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,(int *)local_38,
		                          Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo,0);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x812c85e3:
		        DAT_ram_009d3e38 = 0;
		        iVar11 = import::env::invoke_iiii(*puVar4,piVar13,(int)(short)uVar1,puVar4[1]);
		        if (DAT_ram_009d3e38 != 1) {
		          if (iVar11 != 0) goto code_r0x812c88cb;
		          *param1 = 3;
		          param1[7] = _local_30;
		          *(undefined8 *)(param1 + 5) = local_38;
		          iVar11 = 
		          Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_Object_____GameAnimationLoader__ProcessAssetBundle_d__5___
		          ;
		          if (*(int *)(
		                      Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_Object_____GameAnimationLoader__ProcessAssetBundle_d__5___
		                      + 0x1c) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (0x7ff,&Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunner_TypeInfo)
		            ;
		            if (DAT_ram_009d3e38 != 1) {
		              if (*(int *)(iVar11 + 0x1c) == 0) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_ii(s_struct_Uniforms___color__vec4<f3_ram_00000856 + 6,iVar11);
		                if (DAT_ram_009d3e38 == 1) goto code_r0x812c88c1;
		              }
		              goto code_r0x812c86bc;
		            }
		          }
		          else {
		code_r0x812c86bc:
		            piVar13 = param1 + 1;
		            piVar10 = (int *)*piVar13;
		            if (piVar10 == (int *)0x0) {
		              iVar12 = *(int *)(*(int *)(iVar11 + 0x1c) + 8);
		              if ((*(byte *)(iVar12 + 0xbd) & 1) == 0) {
		                DAT_ram_009d3e38 = 0;
		                iVar12 = import::env::invoke_ii
		                                   (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar12);
		                if (DAT_ram_009d3e38 == 1) goto code_r0x812c88c1;
		              }
		              if (*(int *)(iVar12 + 0x74) == 0) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vi
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,iVar12);
		                if (DAT_ram_009d3e38 == 1) goto code_r0x812c88c1;
		              }
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viii
		                        (s_struct_Uniforms___color__array<v_ram_0000223f + 0x6d,param1,piVar13,
		                         *(undefined4 *)(*(int *)(iVar11 + 0x1c) + 4));
		              if (DAT_ram_009d3e38 == 1) goto code_r0x812c88c1;
		              piVar10 = (int *)*piVar13;
		            }
		            uVar3 = 0;
		            iVar12 = *piVar10;
		            if (*(ushort *)(iVar12 + 0xb6) != 0) {
		              do {
		                if (Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunner_TypeInfo ==
		                    *(int *)(*(int *)(iVar12 + 0x58) + uVar3 * 8)) {
		                  puVar4 = (undefined4 *)
		                           (iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar3 * 8 + 4) * 8 + 0xc0);
		                  goto code_r0x812c8845;
		                }
		                uVar3 = uVar3 + 1;
		              } while (*(ushort *)(iVar12 + 0xb6) != uVar3);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar4 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar10,
		                                Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunner_TypeInfo
		                                ,0);
		            if (DAT_ram_009d3e38 != 1) {
		code_r0x812c8845:
		              DAT_ram_009d3e38 = 0;
		              uVar9 = import::env::invoke_iii(*puVar4,piVar10,puVar4[1]);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_viii
		                          (s_struct_Uniforms___color__array<v_ram_0000223f + 0x6e,&local_38,uVar9,
		                           *(undefined4 *)(*(int *)(iVar11 + 0x1c) + 0x14));
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  return;
		                }
		              }
		            }
		          }
		code_r0x812c88c1:
		          DAT_ram_009d3e38 = 0;
		          uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x812c8d6a;
		        }
		      }
		code_r0x812c87cc:
		      DAT_ram_009d3e38 = 0;
		      uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812c8d6a;
		    }
		  }
		code_r0x812c816f:
		  DAT_ram_009d3e38 = 0;
		  uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x812c8d6a;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_GameResources_Loaders_GameAnimationLoader___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5acb7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameResources_Loaders_GameAnimationLoader_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19275);
		    DAT_ram_00a5acb7 = '\x01';
		  }
		  uVar1 = UnityEngine_Shader__TagToID(StringLiteral_19275,0);
		  **(undefined4 **)(Core_GameResources_Loaders_GameAnimationLoader_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04003298 RID: 12952
		[Token(Token = "0x4003298")]
		[FieldOffset(Offset = "0x0")]
		protected static readonly int _straightAlphaInputId;

		// Token: 0x04003299 RID: 12953
		[Token(Token = "0x4003299")]
		[FieldOffset(Offset = "0x2C")]
		protected GameObject _originalGameObject;

		// Token: 0x0400329A RID: 12954
		[Token(Token = "0x400329A")]
		[FieldOffset(Offset = "0x30")]
		protected GameResourceCancellationToken _cancel;
	}
}
