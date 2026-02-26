using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.GameResources.Loaders
{
	// Token: 0x02000EE1 RID: 3809
	[Token(Token = "0x2000EE1")]
	public abstract class AbstractGameAudioClipLoader : AbstractGameResourceLoader<GameResourcesManager.AudioClipReadyDelegate>
	{
		// Token: 0x06005C9E RID: 23710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C9E")]
		[Address(RVA = "0xA932", Offset = "0xA932", VA = "0xA932", Slot = "5")]
		protected override void CheckIfReady()
		{
		/* --- GHIDRA: CheckIfReady ---
		void Core_GameResources_Loaders_AbstractGameAudioClipLoader__CheckIfReady
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5aca3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_CancellationToken__UniTaskVoid__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
		    DAT_ram_00a5aca3 = '\x01';
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

		// Token: 0x06005C9F RID: 23711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C9F")]
		[Address(RVA = "0xA933", Offset = "0xA933", VA = "0xA933", Slot = "6")]
		protected override void OnAssetBundleReady()
		{
		/* --- GHIDRA: OnAssetBundleReady ---
		void Core_GameResources_Loaders_AbstractGameAudioClipLoader__OnAssetBundleReady
		               (undefined1 *param1,uint param2,uint param3,undefined4 param4)
		
		{
		  undefined4 local_1c;
		  longlong local_18;
		  ulonglong local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5aca4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_Start_AbstractGameAudioClipLoader__ProcessAssetBundle_d__4___
		              );
		    DAT_ram_00a5aca4 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = (ulonglong)param3;
		  local_1c = 0xffffffff;
		  local_18 = (ulonglong)param2 << 0x20;
		  Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder__Start_AbstractAssetBundleLoader__LoadFromMemoryAsync_d__25_
		            (&local_18,&local_1c,
		             Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_Start_AbstractGameAudioClipLoader__ProcessAssetBundle_d__4___
		            );
		  *param1 = 0;
		  return;
		}
		*/

		}

		// Token: 0x06005CA0 RID: 23712 RVA: 0x000109C8 File Offset: 0x0000EBC8
		[Token(Token = "0x6005CA0")]
		[Address(RVA = "0xA934", Offset = "0xA934", VA = "0xA934", Slot = "9")]
		protected virtual UniTaskVoid ProcessAssetBundle(CancellationToken cancellationToken)
		{
		/* --- GHIDRA: ProcessAssetBundle ---
		void Core_GameResources_Loaders_AbstractGameAudioClipLoader__ProcessAssetBundle
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5aca5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_AudioClipReadyDelegate__Dispose__
		              );
		    DAT_ram_00a5aca5 = '\x01';
		  }
		  if (*(char *)(param1 + 0x24) == '\0') {
		    Core_GameResources_GameResourceCancellationToken__Cancel(*(undefined4 *)(param1 + 0x30),0);
		    Core_GameResources_AbstractGameResourceLoader_object___AssetBundleSuccessHandler
		              (param1,
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_AudioClipReadyDelegate__Dispose__
		              );
		  }
		  return;
		}
		*/

			return default(UniTaskVoid);
		}

		// Token: 0x06005CA1 RID: 23713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CA1")]
		[Address(RVA = "0xA935", Offset = "0xA935", VA = "0xA935", Slot = "7")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_GameResources_Loaders_AbstractGameAudioClipLoader__Dispose(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5aca6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_AudioClipReadyDelegate__ReleaseAssetBundle__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5aca6 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x30);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_AudioClipReadyDelegate__ReleaseAssetBundle__
		             ,0);
		  Core_GameResources_GameResourceCancellationToken__Init(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06005CA2 RID: 23714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CA2")]
		[Address(RVA = "0xA936", Offset = "0xA936", VA = "0xA936", Slot = "8")]
		protected override void ReleaseAssetBundle()
		{
		}

		// Token: 0x06005CA3 RID: 23715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CA3")]
		[Address(RVA = "0xA937", Offset = "0xA937", VA = "0xA937")]
		protected AbstractGameAudioClipLoader()
		{
		/* --- GHIDRA: .ctor ---
		/* WARNING: Removing unreachable block (ram,0x812c5549) */
		
		void Core_GameResources_Loaders_AbstractGameAudioClipLoader___ctor(int *param1,undefined4 param2)
		
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
		  
		  if (DAT_ram_00a5aca8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_AssetBundle_LoadAllAssetsAsync_AudioClip___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_Object_____AbstractGameAudioClipLoader__ProcessAssetBundle_d__4___
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_AudioClip_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____GetResult__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____get_IsCompleted__);
		    Mono_Security_ASN1__get_Item(&Method_Cysharp_Threading_Tasks_UniTask_Object____GetAwaiter__);
		    DAT_ram_00a5aca8 = '\x01';
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
		code_r0x812c533d:
		    if (piVar8 == (int *)0x0) {
		code_r0x812c5342:
		      iVar6 = local_28._4_4_;
		code_r0x812c54b0:
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
		code_r0x812c55ed:
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
		          else if (*piVar8 != UnityEngine_AudioClip_TypeInfo) {
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
		          if (iVar6 != 1) goto code_r0x812c55ed;
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
		        if (DAT_ram_009d3e38 != 1) goto code_r0x812c5399;
		      }
		      else {
		code_r0x812c5399:
		        iVar6 = *(int *)(*(int *)(iVar6 + 0x60) + 0x14);
		        if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_ii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar6);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x812c55d9;
		        }
		        iVar7 = *piVar8;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            if (iVar6 == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		              puVar3 = (undefined4 *)
		                       (iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		              goto code_r0x812c546a;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar8,iVar6,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x812c546a:
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_iiii(*puVar3,piVar8,(int)(short)uVar1,puVar3[1]);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x812c54b0;
		        }
		      }
		code_r0x812c55d9:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_0000223f + 99,param2_01[6],
		                       Method_UnityEngine_AssetBundle_LoadAllAssetsAsync_AudioClip___);
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
		            goto code_r0x812c5612;
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
		          if (DAT_ram_009d3e38 != 1) goto code_r0x812c5144;
		        }
		        else {
		code_r0x812c5144:
		          if (DAT_ram_00a63c4a == '\0') {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi(0x7ff,&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x812c52fd;
		            DAT_ram_00a63c4a = '\x01';
		          }
		          piVar8 = (int *)local_28;
		          if ((int *)local_28 == (int *)0x0) goto code_r0x812c5342;
		          uVar2 = 0;
		          uVar1 = local_20;
		          iVar6 = *(int *)local_28;
		          if (*(ushort *)(iVar6 + 0xb6) != 0) {
		            do {
		              if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		                  *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		                puVar3 = (undefined4 *)
		                         (iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		                goto code_r0x812c5232;
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
		code_r0x812c5232:
		            DAT_ram_009d3e38 = 0;
		            iVar6 = import::env::invoke_iiii(*puVar3,piVar8,(int)(short)uVar1,puVar3[1]);
		            if (DAT_ram_009d3e38 != 1) {
		              if (iVar6 != 0) goto code_r0x812c533d;
		              *param1 = 0;
		              *(undefined8 *)(param1 + 4) = local_28;
		              param1[6] = _local_20;
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiii
		                        (s_struct_Uniforms___color__array<v_ram_0000223f + 0x68,param1 + 1,&local_28
		                         ,param1,
		                         Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_Object_____AbstractGameAudioClipLoader__ProcessAssetBundle_d__4___
		                        );
		              iVar6 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar6 != 1) {
		                DAT_ram_009d3e38 = 0;
		                return;
		              }
		              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x812c5612;
		            }
		          }
		        }
		code_r0x812c52fd:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		    }
		  }
		code_r0x812c5612:
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
		        if (DAT_ram_009d3e38 != 1) goto code_r0x812c573f;
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
		code_r0x812c573f:
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

		// Token: 0x04003289 RID: 12937
		[Token(Token = "0x4003289")]
		[FieldOffset(Offset = "0x2C")]
		public AudioClip AudioClip;

		// Token: 0x0400328A RID: 12938
		[Token(Token = "0x400328A")]
		[FieldOffset(Offset = "0x30")]
		protected GameResourceCancellationToken _cancel;
	}
}
