using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.GameResources
{
	// Token: 0x02000EDD RID: 3805
	[Token(Token = "0x2000EDD")]
	public abstract class AbstractGameSpriteLoader : AbstractGameResourceLoader<GameResourcesManager.SpriteReadyDelegate>
	{
		// Token: 0x06005C8E RID: 23694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C8E")]
		[Address(RVA = "0xA922", Offset = "0xA922", VA = "0xA922", Slot = "5")]
		protected override void CheckIfReady()
		{
		/* --- GHIDRA: CheckIfReady ---
		void Core_GameResources_AbstractGameSpriteLoader__CheckIfReady(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a6066b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_CancellationToken__UniTaskVoid__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
		    DAT_ram_00a6066b = '\x01';
		  }
		  *(undefined1 *)(param1[0xc] + 0x10) = 0;
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

		// Token: 0x06005C8F RID: 23695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C8F")]
		[Address(RVA = "0xA923", Offset = "0xA923", VA = "0xA923", Slot = "6")]
		protected override void OnAssetBundleReady()
		{
		/* --- GHIDRA: OnAssetBundleReady ---
		void Core_GameResources_AbstractGameSpriteLoader__OnAssetBundleReady
		               (undefined1 *param1,uint param2,uint param3,undefined4 param4)
		
		{
		  undefined4 local_1c;
		  longlong local_18;
		  ulonglong local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6066c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_Start_AbstractGameSpriteLoader__ProcessAssetBundle_d__4___
		              );
		    DAT_ram_00a6066c = '\x01';
		  }
		  local_8 = 0;
		  local_10 = (ulonglong)param3;
		  local_1c = 0xffffffff;
		  local_18 = (ulonglong)param2 << 0x20;
		  Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder__Start_AbstractGameSpriteAtlasLoader__ProcessAssetBundle_d__7_
		            (&local_18,&local_1c,
		             Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_Start_AbstractGameSpriteLoader__ProcessAssetBundle_d__4___
		            );
		  *param1 = 0;
		  return;
		}
		*/

		}

		// Token: 0x06005C90 RID: 23696 RVA: 0x00010998 File Offset: 0x0000EB98
		[Token(Token = "0x6005C90")]
		[Address(RVA = "0xA924", Offset = "0xA924", VA = "0xA924", Slot = "9")]
		protected virtual UniTaskVoid ProcessAssetBundle(CancellationToken cancellationToken)
		{
		/* --- GHIDRA: ProcessAssetBundle ---
		void Core_GameResources_AbstractGameSpriteLoader__ProcessAssetBundle(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a6066d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_SpriteReadyDelegate__Dispose__
		              );
		    DAT_ram_00a6066d = '\x01';
		  }
		  if (*(char *)(param1 + 0x24) == '\0') {
		    iVar1 = *(int *)(param1 + 0x30);
		    System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		              (*(undefined4 *)(iVar1 + 8),0);
		    System_Threading_CancellationTokenSource__Cancel(*(undefined4 *)(iVar1 + 8),0);
		    *(undefined4 *)(iVar1 + 8) = 0;
		    Core_GameResources_AbstractGameResourceLoader_object___AssetBundleSuccessHandler
		              (param1,
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_SpriteReadyDelegate__Dispose__
		              );
		  }
		  return;
		}
		*/

			return default(UniTaskVoid);
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C91")]
		[Address(RVA = "0xA925", Offset = "0xA925", VA = "0xA925", Slot = "7")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_GameResources_AbstractGameSpriteLoader__Dispose(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a6066e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_SpriteReadyDelegate__ReleaseAssetBundle__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a6066e = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x30);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_SpriteReadyDelegate__ReleaseAssetBundle__
		             ,0);
		  if (*(char *)(iVar1 + 0x10) != '\0') {
		    (**(code **)((ulonglong)*(uint *)(param1_00 + 0xc) * 4))
		              (*(undefined4 *)(param1_00 + 0x20),*(undefined4 *)(param1_00 + 0x14));
		    return;
		  }
		  *(int *)(iVar1 + 0xc) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06005C92 RID: 23698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C92")]
		[Address(RVA = "0xA926", Offset = "0xA926", VA = "0xA926", Slot = "8")]
		protected override void ReleaseAssetBundle()
		{
		/* --- GHIDRA: ReleaseAssetBundle ---
		void Core_GameResources_AbstractGameSpriteLoader__ReleaseAssetBundle(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6066f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_SpriteReadyDelegate___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourceCancellationToken_TypeInfo);
		    DAT_ram_00a6066f = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_GameResources_GameResourceCancellationToken_TypeInfo);
		  if (DAT_ram_00a6064a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Threading_CancellationTokenSource_TypeInfo);
		    DAT_ram_00a6064a = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Threading_CancellationTokenSource_TypeInfo);
		  Gameplay_Combat_Control_Conveyor__Next(param1_00,0);
		  *(undefined1 *)(iVar1 + 0x10) = 1;
		  *(undefined4 *)(iVar1 + 8) = param1_00;
		  *(int *)(param1 + 0x30) = iVar1;
		  AssetContent_Loaders_AbstractGameGraphicLoader_object__object___set_IsReady
		            (param1,
		             Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_SpriteReadyDelegate___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06005C93 RID: 23699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C93")]
		[Address(RVA = "0xA927", Offset = "0xA927", VA = "0xA927")]
		protected AbstractGameSpriteLoader()
		{
		/* --- GHIDRA: .ctor ---
		/* WARNING: Removing unreachable block (ram,0x81cc0c66) */
		
		void Core_GameResources_AbstractGameSpriteLoader___ctor(int *param1,undefined4 param2)
		
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
		  int iVar8;
		  int *piVar9;
		  undefined8 local_2c;
		  int local_24;
		  undefined8 local_20;
		  ushort local_18;
		  undefined8 local_10;
		  int local_8;
		  
		  if (DAT_ram_00a60670 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_AssetBundle_LoadAllAssetsAsync_Sprite___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_Object_____AbstractGameSpriteLoader__ProcessAssetBundle_d__4___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____GetResult__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____get_IsCompleted__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Sprite_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Cysharp_Threading_Tasks_UniTask_Object____GetAwaiter__);
		    DAT_ram_00a60670 = '\x01';
		  }
		  _local_18 = 0;
		  local_20 = 0;
		  param2_01 = (int *)param1[2];
		  if (*param1 == 0) {
		    _local_18 = param1[6];
		    local_20 = *(undefined8 *)(param1 + 4);
		    param1[4] = 0;
		    param1[5] = 0;
		    param1[6] = 0;
		    *param1 = -1;
		    piVar9 = (int *)local_20;
		code_r0x81cc09ed:
		    if (piVar9 == (int *)0x0) {
		code_r0x81cc09f2:
		      iVar6 = local_20._4_4_;
		code_r0x81cc0b60:
		      iVar8 = param2_01[0xc];
		      DAT_ram_009d3e38 = 0;
		      iVar4 = System_Collections_Generic_LinkedList_object___AddFirst(*(undefined4 *)(iVar8 + 8),0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 != 1) {
		        if (iVar4 == 0) {
		          if (*(int *)(iVar6 + 0xc) == 0) {
		            piVar9 = (int *)0x0;
		          }
		          else {
		            piVar9 = *(int **)(iVar6 + 0x10);
		            if (piVar9 == (int *)0x0) {
		              piVar9 = (int *)0x0;
		            }
		            else if (*piVar9 != UnityEngine_Sprite_TypeInfo) {
		              piVar9 = (int *)0x0;
		            }
		          }
		          param2_01[0xb] = (int)piVar9;
		          if (piVar9 == (int *)0x0) {
		            *(undefined1 *)((int)param2_01 + 0x25) = 1;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (*(undefined4 *)(*param2_01 + 0xe8),param2_01,*(undefined4 *)(*param2_01 + 0xec)
		                    );
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            iVar6 = param2_01[0xc];
		            *(undefined1 *)(iVar6 + 0x10) = 1;
		            puVar3 = (undefined4 *)(iVar6 + 0xc);
		            iVar6 = *(int *)(iVar6 + 0xc);
		            if (iVar6 == 0) goto code_r0x81cc0d1f;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii
		                      (*(undefined4 *)(iVar6 + 0xc),*(undefined4 *)(iVar6 + 0x20),
		                       *(undefined4 *)(iVar6 + 0x14));
		            iVar6 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar6 != 1) goto code_r0x81cc0d1f;
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          goto code_r0x81cc0d55;
		        }
		        *(undefined1 *)(iVar8 + 0x10) = 1;
		        puVar3 = (undefined4 *)(iVar8 + 0xc);
		        iVar6 = *(int *)(iVar8 + 0xc);
		        if (iVar6 == 0) {
		code_r0x81cc0d1f:
		          *puVar3 = 0;
		          *param1 = -2;
		          unnamed_function_118874(param1 + 1);
		          return;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (*(undefined4 *)(iVar6 + 0xc),*(undefined4 *)(iVar6 + 0x20),
		                   *(undefined4 *)(iVar6 + 0x14));
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) goto code_r0x81cc0d1f;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      uVar1 = local_18;
		      iVar6 = *(int *)(Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____GetResult__ + 0x10);
		      if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		        DAT_ram_009d3e38 = 0;
		        iVar6 = import::env::invoke_ii(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar6)
		        ;
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81cc0a49;
		      }
		      else {
		code_r0x81cc0a49:
		        iVar6 = *(int *)(*(int *)(iVar6 + 0x60) + 0x14);
		        if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_ii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar6);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x81cc0d39;
		        }
		        iVar7 = *piVar9;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            if (iVar6 == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		              puVar3 = (undefined4 *)
		                       (iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		              goto code_r0x81cc0b1a;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar9,iVar6,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x81cc0b1a:
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_iiii(*puVar3,piVar9,(int)(short)uVar1,puVar3[1]);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x81cc0b60;
		        }
		      }
		code_r0x81cc0d39:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_0000223f + 99,param2_01[6],
		                       Method_UnityEngine_AssetBundle_LoadAllAssetsAsync_Sprite___);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s___Scripting__UnityEngine__Render_ram_00003671 + 7,&local_2c,uVar5,param1[3],0);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        local_8 = local_24;
		        local_10 = local_2c;
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
		            goto code_r0x81cc0d55;
		          }
		        }
		        _local_18 = local_8;
		        local_20 = local_10;
		        if ((*(byte *)(*(int *)(
		                               Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____get_IsCompleted__
		                               + 0x10) + 0xbd) & 1) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii
		                    (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,
		                     *(int *)(
		                             Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____get_IsCompleted__
		                             + 0x10));
		          if (DAT_ram_009d3e38 != 1) goto code_r0x81cc07f4;
		        }
		        else {
		code_r0x81cc07f4:
		          if (DAT_ram_00a63c4a == '\0') {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi(0x7ff,&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x81cc09ad;
		            DAT_ram_00a63c4a = '\x01';
		          }
		          piVar9 = (int *)local_20;
		          if ((int *)local_20 == (int *)0x0) goto code_r0x81cc09f2;
		          uVar2 = 0;
		          uVar1 = local_18;
		          iVar6 = *(int *)local_20;
		          if (*(ushort *)(iVar6 + 0xb6) != 0) {
		            do {
		              if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		                  *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		                puVar3 = (undefined4 *)
		                         (iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		                goto code_r0x81cc08e2;
		              }
		              uVar2 = uVar2 + 1;
		            } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar3 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,(int *)local_20
		                              ,Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo,0);
		          if (DAT_ram_009d3e38 != 1) {
		code_r0x81cc08e2:
		            DAT_ram_009d3e38 = 0;
		            iVar6 = import::env::invoke_iiii(*puVar3,piVar9,(int)(short)uVar1,puVar3[1]);
		            if (DAT_ram_009d3e38 != 1) {
		              if (iVar6 != 0) goto code_r0x81cc09ed;
		              *param1 = 0;
		              *(undefined8 *)(param1 + 4) = local_20;
		              param1[6] = _local_18;
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiii
		                        (s___Scripting__UnityEngine__Render_ram_00003671 + 9,param1 + 1,&local_20,
		                         param1,
		                         Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_Object_____AbstractGameSpriteLoader__ProcessAssetBundle_d__4___
		                        );
		              iVar6 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar6 != 1) {
		                DAT_ram_009d3e38 = 0;
		                return;
		              }
		              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x81cc0d55;
		            }
		          }
		        }
		code_r0x81cc09ad:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		    }
		  }
		code_r0x81cc0d55:
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
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81cc0e82;
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
		code_r0x81cc0e82:
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

		// Token: 0x0400327B RID: 12923
		[Token(Token = "0x400327B")]
		[FieldOffset(Offset = "0x2C")]
		public Sprite Sprite;

		// Token: 0x0400327C RID: 12924
		[Token(Token = "0x400327C")]
		[FieldOffset(Offset = "0x30")]
		protected GameResourceCancellationToken _cancel;
	}
}
