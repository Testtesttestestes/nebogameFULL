using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.GameResources
{
	// Token: 0x02000EDF RID: 3807
	[Token(Token = "0x2000EDF")]
	public abstract class AbstractGameTextureLoader : AbstractGameResourceLoader<GameResourcesManager.TextureReadyDelegate>
	{
		// Token: 0x06005C96 RID: 23702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C96")]
		[Address(RVA = "0xA92A", Offset = "0xA92A", VA = "0xA92A", Slot = "5")]
		protected override void CheckIfReady()
		{
		/* --- GHIDRA: CheckIfReady ---
		void Core_GameResources_AbstractGameTextureLoader__CheckIfReady(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5ac9c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_CancellationToken__UniTaskVoid__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
		    DAT_ram_00a5ac9c = '\x01';
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

		// Token: 0x06005C97 RID: 23703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C97")]
		[Address(RVA = "0xA92B", Offset = "0xA92B", VA = "0xA92B", Slot = "6")]
		protected override void OnAssetBundleReady()
		{
		/* --- GHIDRA: OnAssetBundleReady ---
		void Core_GameResources_AbstractGameTextureLoader__OnAssetBundleReady
		               (undefined1 *param1,uint param2,uint param3,undefined4 param4)
		
		{
		  undefined4 local_1c;
		  longlong local_18;
		  ulonglong local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5ac9d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_Start_AbstractGameTextureLoader__ProcessAssetBundle_d__4___
		              );
		    DAT_ram_00a5ac9d = '\x01';
		  }
		  local_8 = 0;
		  local_10 = (ulonglong)param3;
		  local_1c = 0xffffffff;
		  local_18 = (ulonglong)param2 << 0x20;
		  Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder__Start_AbstractGameTextMeshProSpriteAssetLoader__ProcessAssetBundle_d__6_
		            (&local_18,&local_1c,
		             Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_Start_AbstractGameTextureLoader__ProcessAssetBundle_d__4___
		            );
		  *param1 = 0;
		  return;
		}
		*/

		}

		// Token: 0x06005C98 RID: 23704 RVA: 0x000109B0 File Offset: 0x0000EBB0
		[Token(Token = "0x6005C98")]
		[Address(RVA = "0xA92C", Offset = "0xA92C", VA = "0xA92C", Slot = "9")]
		protected virtual UniTaskVoid ProcessAssetBundle(CancellationToken cancellationToken)
		{
		/* --- GHIDRA: ProcessAssetBundle ---
		void Core_GameResources_AbstractGameTextureLoader__ProcessAssetBundle(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5ac9e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_TextureReadyDelegate__Dispose__
		              );
		    DAT_ram_00a5ac9e = '\x01';
		  }
		  if (*(char *)(param1 + 0x24) == '\0') {
		    Core_GameResources_GameResourceCancellationToken__Cancel(*(undefined4 *)(param1 + 0x30),0);
		    Core_GameResources_AbstractGameResourceLoader_object___AssetBundleSuccessHandler
		              (param1,
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_TextureReadyDelegate__Dispose__
		              );
		  }
		  return;
		}
		*/

			return default(UniTaskVoid);
		}

		// Token: 0x06005C99 RID: 23705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C99")]
		[Address(RVA = "0xA92D", Offset = "0xA92D", VA = "0xA92D", Slot = "7")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_GameResources_AbstractGameTextureLoader__Dispose(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5ac9f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_TextureReadyDelegate__ReleaseAssetBundle__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5ac9f = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x30);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_TextureReadyDelegate__ReleaseAssetBundle__
		             ,0);
		  Core_GameResources_GameResourceCancellationToken__Init(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06005C9A RID: 23706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C9A")]
		[Address(RVA = "0xA92E", Offset = "0xA92E", VA = "0xA92E", Slot = "8")]
		protected override void ReleaseAssetBundle()
		{
		}

		// Token: 0x06005C9B RID: 23707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C9B")]
		[Address(RVA = "0xA92F", Offset = "0xA92F", VA = "0xA92F")]
		protected AbstractGameTextureLoader()
		{
		/* --- GHIDRA: .ctor ---
		/* WARNING: Removing unreachable block (ram,0x812c4a21) */
		
		void Core_GameResources_AbstractGameTextureLoader___ctor(int *param1,undefined4 param2)
		
		{
		  ushort uVar1;
		  uint uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 *param2_00;
		  int *param2_01;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  undefined8 local_28;
		  ushort local_20;
		  undefined8 local_18;
		  int local_10;
		  undefined8 local_c;
		  int local_4;
		  
		  if (DAT_ram_00a5aca1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_AssetBundle_LoadAllAssetsAsync_Texture2D___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_Object_____AbstractGameTextureLoader__ProcessAssetBundle_d__4___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____GetResult__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____get_IsCompleted__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Texture2D_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Cysharp_Threading_Tasks_UniTask_Object____GetAwaiter__);
		    DAT_ram_00a5aca1 = '\x01';
		  }
		  _local_20 = 0;
		  local_28 = 0;
		  param2_01 = (int *)param1[2];
		  if (*param1 == 0) {
		    _local_20 = param1[6];
		    local_28 = *(undefined8 *)(param1 + 4);
		    param1[4] = 0;
		    param1[5] = 0;
		    param1[6] = 0;
		    *param1 = -1;
		    piVar8 = (int *)local_28;
		code_r0x812c4815:
		    if (piVar8 == (int *)0x0) {
		code_r0x812c481a:
		      iVar6 = local_28._4_4_;
		code_r0x812c4988:
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_0000223f + 0x66,param2_01[0xc],0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        if (iVar4 != 0) {
		code_r0x812c4ac5:
		          DAT_ram_009d3e38 = 0;
		          *param1 = -2;
		          unnamed_function_118874(param1 + 1);
		          return;
		        }
		        if (*(int *)(iVar6 + 0xc) == 0) {
		          piVar8 = (int *)0x0;
		        }
		        else {
		          piVar8 = *(int **)(iVar6 + 0x10);
		          if (piVar8 == (int *)0x0) {
		            piVar8 = (int *)0x0;
		          }
		          else if (*piVar8 != UnityEngine_Texture2D_TypeInfo) {
		            piVar8 = (int *)0x0;
		          }
		        }
		        param2_01[0xb] = (int)piVar8;
		        if (piVar8 == (int *)0x0) {
		          *(undefined1 *)((int)param2_01 + 0x25) = 1;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (*(undefined4 *)(*param2_01 + 0xe8),param2_01,*(undefined4 *)(*param2_01 + 0xec));
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_struct_Uniforms___color__array<v_ram_0000223f + 0x67,param2_01[0xc],0);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 != 1) goto code_r0x812c4ac5;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		      }
		    }
		    else {
		      uVar1 = local_20;
		      iVar6 = *(int *)(Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____GetResult__ + 0x10);
		      if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		        DAT_ram_009d3e38 = 0;
		        iVar6 = import::env::invoke_ii(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar6)
		        ;
		        if (DAT_ram_009d3e38 != 1) goto code_r0x812c4871;
		      }
		      else {
		code_r0x812c4871:
		        iVar6 = *(int *)(*(int *)(iVar6 + 0x60) + 0x14);
		        if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_ii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar6);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x812c4ab1;
		        }
		        iVar7 = *piVar8;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            if (iVar6 == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		              puVar3 = (undefined4 *)
		                       (iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		              goto code_r0x812c4942;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar8,iVar6,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x812c4942:
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_iiii(*puVar3,piVar8,(int)(short)uVar1,puVar3[1]);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x812c4988;
		        }
		      }
		code_r0x812c4ab1:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_0000223f + 99,param2_01[6],
		                       Method_UnityEngine_AssetBundle_LoadAllAssetsAsync_Texture2D___);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiiiii
		                (s_struct_Uniforms___color__array<v_ram_0000223f + 100,&local_c,uVar5,0,8,param1[3],
		                 0);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
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
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x812c4aea;
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
		          if (DAT_ram_009d3e38 != 1) goto code_r0x812c461c;
		        }
		        else {
		code_r0x812c461c:
		          if (DAT_ram_00a63c4a == '\0') {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi(0x7ff,&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x812c47d5;
		            DAT_ram_00a63c4a = '\x01';
		          }
		          piVar8 = (int *)local_28;
		          if ((int *)local_28 == (int *)0x0) goto code_r0x812c481a;
		          uVar2 = 0;
		          uVar1 = local_20;
		          iVar6 = *(int *)local_28;
		          if (*(ushort *)(iVar6 + 0xb6) != 0) {
		            do {
		              if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		                  *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		                puVar3 = (undefined4 *)
		                         (iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		                goto code_r0x812c470a;
		              }
		              uVar2 = uVar2 + 1;
		            } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar3 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,(int *)local_28
		                              ,Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo,0);
		          if (DAT_ram_009d3e38 != 1) {
		code_r0x812c470a:
		            DAT_ram_009d3e38 = 0;
		            iVar6 = import::env::invoke_iiii(*puVar3,piVar8,(int)(short)uVar1,puVar3[1]);
		            if (DAT_ram_009d3e38 != 1) {
		              if (iVar6 != 0) goto code_r0x812c4815;
		              *param1 = 0;
		              *(undefined8 *)(param1 + 4) = local_28;
		              param1[6] = _local_20;
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiii
		                        (s_struct_Uniforms___color__array<v_ram_0000223f + 0x65,param1 + 1,&local_28
		                         ,param1,
		                         Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_Object_____AbstractGameTextureLoader__ProcessAssetBundle_d__4___
		                        );
		              iVar6 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar6 != 1) {
		                DAT_ram_009d3e38 = 0;
		                return;
		              }
		              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x812c4aea;
		            }
		          }
		        }
		code_r0x812c47d5:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		    }
		  }
		code_r0x812c4aea:
		  iVar6 = global_1;
		  iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar7) {
		    puVar3 = (undefined4 *)import::env::__cxa_begin_catch(uVar5);
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar5,
		                         *(undefined4 *)*puVar3);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 != 1) {
		        if (iVar7 != 0) {
		          uVar5 = *puVar3;
		          import::env::__cxa_end_catch();
		          *param1 = -2;
		          unnamed_function_118873(param1 + 1,uVar5);
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x812c4c17;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x812c4c17:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04003282 RID: 12930
		[Token(Token = "0x4003282")]
		[FieldOffset(Offset = "0x2C")]
		public Texture2D Texture;

		// Token: 0x04003283 RID: 12931
		[Token(Token = "0x4003283")]
		[FieldOffset(Offset = "0x30")]
		protected GameResourceCancellationToken _cancel;
	}
}
