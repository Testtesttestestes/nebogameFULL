using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine.U2D;

namespace Core.GameResources
{
	// Token: 0x02000EDB RID: 3803
	[Token(Token = "0x2000EDB")]
	public class AbstractGameSpriteAtlasLoader : AbstractGameResourceLoader<GameResourcesManager.SpriteAtlasReadyDelegate>
	{
		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x06005C84 RID: 23684 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005C85 RID: 23685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012BA")]
		public SpriteAtlas Atlas
		{
			[Token(Token = "0x6005C84")]
			[Address(RVA = "0xA918", Offset = "0xA918", VA = "0xA918")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C85")]
			[Address(RVA = "0xA919", Offset = "0xA919", VA = "0xA919")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005C86 RID: 23686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C86")]
		[Address(RVA = "0xA91A", Offset = "0xA91A", VA = "0xA91A", Slot = "5")]
		protected override void CheckIfReady()
		{
		/* --- GHIDRA: CheckIfReady ---
		void Core_GameResources_AbstractGameSpriteAtlasLoader__CheckIfReady(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a60664 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_CancellationToken__UniTaskVoid__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
		    DAT_ram_00a60664 = '\x01';
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

		// Token: 0x06005C87 RID: 23687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C87")]
		[Address(RVA = "0xA91B", Offset = "0xA91B", VA = "0xA91B", Slot = "6")]
		protected override void OnAssetBundleReady()
		{
		/* --- GHIDRA: OnAssetBundleReady ---
		void Core_GameResources_AbstractGameSpriteAtlasLoader__OnAssetBundleReady
		               (undefined1 *param1,uint param2,uint param3,undefined4 param4)
		
		{
		  undefined4 local_1c;
		  longlong local_18;
		  ulonglong local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a60665 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_Start_AbstractGameSpriteAtlasLoader__ProcessAssetBundle_d__7___
		              );
		    DAT_ram_00a60665 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = (ulonglong)param3;
		  local_1c = 0xffffffff;
		  local_18 = (ulonglong)param2 << 0x20;
		  Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder__Start_AbstractGameAudioClipLoader__ProcessAssetBundle_d__4_
		            (&local_18,&local_1c,
		             Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_Start_AbstractGameSpriteAtlasLoader__ProcessAssetBundle_d__7___
		            );
		  *param1 = 0;
		  return;
		}
		*/

		}

		// Token: 0x06005C88 RID: 23688 RVA: 0x00010980 File Offset: 0x0000EB80
		[Token(Token = "0x6005C88")]
		[Address(RVA = "0xA91C", Offset = "0xA91C", VA = "0xA91C", Slot = "9")]
		protected virtual UniTaskVoid ProcessAssetBundle(CancellationToken cancellationToken)
		{
		/* --- GHIDRA: ProcessAssetBundle ---
		void Core_GameResources_AbstractGameSpriteAtlasLoader__ProcessAssetBundle
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a60666 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_SpriteAtlasReadyDelegate__Dispose__
		              );
		    DAT_ram_00a60666 = '\x01';
		  }
		  if (*(char *)(param1 + 0x24) == '\0') {
		    iVar1 = *(int *)(param1 + 0x30);
		    System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		              (*(undefined4 *)(iVar1 + 8),0);
		    System_Threading_CancellationTokenSource__Cancel(*(undefined4 *)(iVar1 + 8),0);
		    *(undefined4 *)(iVar1 + 8) = 0;
		    Core_GameResources_AbstractGameResourceLoader_object___AssetBundleSuccessHandler
		              (param1,
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_SpriteAtlasReadyDelegate__Dispose__
		              );
		  }
		  return;
		}
		*/

			return default(UniTaskVoid);
		}

		// Token: 0x06005C89 RID: 23689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C89")]
		[Address(RVA = "0xA91D", Offset = "0xA91D", VA = "0xA91D", Slot = "7")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_GameResources_AbstractGameSpriteAtlasLoader__Dispose(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a60667 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_SpriteAtlasReadyDelegate__ReleaseAssetBundle__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a60667 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x30);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_SpriteAtlasReadyDelegate__ReleaseAssetBundle__
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

		// Token: 0x06005C8A RID: 23690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C8A")]
		[Address(RVA = "0xA91E", Offset = "0xA91E", VA = "0xA91E", Slot = "8")]
		protected override void ReleaseAssetBundle()
		{
		/* --- GHIDRA: ReleaseAssetBundle ---
		void Core_GameResources_AbstractGameSpriteAtlasLoader__ReleaseAssetBundle
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60668 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_SpriteAtlasReadyDelegate___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourceCancellationToken_TypeInfo);
		    DAT_ram_00a60668 = '\x01';
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
		             Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_SpriteAtlasReadyDelegate___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06005C8B RID: 23691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C8B")]
		[Address(RVA = "0xA91F", Offset = "0xA91F", VA = "0xA91F")]
		public AbstractGameSpriteAtlasLoader()
		{
		/* --- GHIDRA: .ctor ---
		/* WARNING: Removing unreachable block (ram,0x81cc007e) */
		
		void Core_GameResources_AbstractGameSpriteAtlasLoader___ctor(int *param1,undefined4 param2)
		
		{
		  ushort uVar1;
		  uint uVar2;
		  int *piVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 *param2_00;
		  int *param2_01;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  undefined8 local_2c;
		  int local_24;
		  undefined8 local_20;
		  ushort local_18;
		  undefined8 local_10;
		  int local_8;
		  
		  if (DAT_ram_00a60669 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_AssetBundle_LoadAllAssetsAsync_SpriteAtlas___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_Object_____AbstractGameSpriteAtlasLoader__ProcessAssetBundle_d__7___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____GetResult__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____get_IsCompleted__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_U2D_SpriteAtlas_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Cysharp_Threading_Tasks_UniTask_Object____GetAwaiter__);
		    DAT_ram_00a60669 = '\x01';
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
		    piVar3 = (int *)local_20;
		code_r0x81cbfde1:
		    if (piVar3 == (int *)0x0) {
		code_r0x81cbfde6:
		      iVar7 = local_20._4_4_;
		code_r0x81cbff54:
		      iVar9 = param2_01[0xc];
		      DAT_ram_009d3e38 = 0;
		      iVar5 = System_Collections_Generic_LinkedList_object___AddFirst(*(undefined4 *)(iVar9 + 8),0);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 != 1) {
		        if (iVar5 == 0) {
		          piVar3 = (int *)0x0;
		          if ((*(int *)(iVar7 + 0xc) != 0) &&
		             (piVar10 = *(int **)(iVar7 + 0x10), piVar10 != (int *)0x0)) {
		            if (((uint)*(byte *)(UnityEngine_U2D_SpriteAtlas_TypeInfo + 0xb8) <=
		                 (uint)*(byte *)(*piVar10 + 0xb8)) &&
		               (piVar3 = piVar10,
		               *(int *)(*(int *)(*piVar10 + 100) +
		                        (uint)*(byte *)(UnityEngine_U2D_SpriteAtlas_TypeInfo + 0xb8) * 4 + -4) !=
		               UnityEngine_U2D_SpriteAtlas_TypeInfo)) {
		              piVar3 = (int *)0x0;
		            }
		          }
		          param2_01[0xb] = (int)piVar3;
		          if (piVar3 == (int *)0x0) {
		            *(undefined1 *)((int)param2_01 + 0x25) = 1;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (*(undefined4 *)(*param2_01 + 0xe8),param2_01,*(undefined4 *)(*param2_01 + 0xec)
		                    );
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            iVar7 = param2_01[0xc];
		            *(undefined1 *)(iVar7 + 0x10) = 1;
		            puVar4 = (undefined4 *)(iVar7 + 0xc);
		            iVar7 = *(int *)(iVar7 + 0xc);
		            if (iVar7 == 0) goto code_r0x81cc0137;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii
		                      (*(undefined4 *)(iVar7 + 0xc),*(undefined4 *)(iVar7 + 0x20),
		                       *(undefined4 *)(iVar7 + 0x14));
		            iVar7 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar7 != 1) goto code_r0x81cc0137;
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          goto code_r0x81cc016d;
		        }
		        *(undefined1 *)(iVar9 + 0x10) = 1;
		        puVar4 = (undefined4 *)(iVar9 + 0xc);
		        iVar7 = *(int *)(iVar9 + 0xc);
		        if (iVar7 == 0) {
		code_r0x81cc0137:
		          *puVar4 = 0;
		          *param1 = -2;
		          unnamed_function_118874(param1 + 1);
		          return;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (*(undefined4 *)(iVar7 + 0xc),*(undefined4 *)(iVar7 + 0x20),
		                   *(undefined4 *)(iVar7 + 0x14));
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) goto code_r0x81cc0137;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      uVar1 = local_18;
		      iVar7 = *(int *)(Method_Cysharp_Threading_Tasks_UniTask_Awaiter_Object____GetResult__ + 0x10);
		      if ((*(byte *)(iVar7 + 0xbd) & 1) == 0) {
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_ii(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar7)
		        ;
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81cbfe3d;
		      }
		      else {
		code_r0x81cbfe3d:
		        iVar7 = *(int *)(*(int *)(iVar7 + 0x60) + 0x14);
		        if ((*(byte *)(iVar7 + 0xbd) & 1) == 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar7 = import::env::invoke_ii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar7);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x81cc0151;
		        }
		        iVar8 = *piVar3;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            if (iVar7 == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		              puVar4 = (undefined4 *)
		                       (iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		              goto code_r0x81cbff0e;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar3,iVar7,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x81cbff0e:
		          DAT_ram_009d3e38 = 0;
		          iVar7 = import::env::invoke_iiii(*puVar4,piVar3,(int)(short)uVar1,puVar4[1]);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x81cbff54;
		        }
		      }
		code_r0x81cc0151:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_0000223f + 99,param2_01[6],
		                       Method_UnityEngine_AssetBundle_LoadAllAssetsAsync_SpriteAtlas___);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s___Scripting__UnityEngine__Render_ram_00003671 + 7,&local_2c,uVar6,param1[3],0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
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
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81cc016d;
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
		          if (DAT_ram_009d3e38 != 1) goto code_r0x81cbfbe8;
		        }
		        else {
		code_r0x81cbfbe8:
		          if (DAT_ram_00a63c4a == '\0') {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi(0x7ff,&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x81cbfda1;
		            DAT_ram_00a63c4a = '\x01';
		          }
		          piVar3 = (int *)local_20;
		          if ((int *)local_20 == (int *)0x0) goto code_r0x81cbfde6;
		          uVar2 = 0;
		          uVar1 = local_18;
		          iVar7 = *(int *)local_20;
		          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		            do {
		              if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		                  *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		                puVar4 = (undefined4 *)
		                         (iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		                goto code_r0x81cbfcd6;
		              }
		              uVar2 = uVar2 + 1;
		            } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar4 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,(int *)local_20
		                              ,Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo,0);
		          if (DAT_ram_009d3e38 != 1) {
		code_r0x81cbfcd6:
		            DAT_ram_009d3e38 = 0;
		            iVar7 = import::env::invoke_iiii(*puVar4,piVar3,(int)(short)uVar1,puVar4[1]);
		            if (DAT_ram_009d3e38 != 1) {
		              if (iVar7 != 0) goto code_r0x81cbfde1;
		              *param1 = 0;
		              *(undefined8 *)(param1 + 4) = local_20;
		              param1[6] = _local_18;
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiii
		                        (s___Scripting__UnityEngine__Render_ram_00003671 + 8,param1 + 1,&local_20,
		                         param1,
		                         Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_Object_____AbstractGameSpriteAtlasLoader__ProcessAssetBundle_d__7___
		                        );
		              iVar7 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar7 != 1) {
		                DAT_ram_009d3e38 = 0;
		                return;
		              }
		              uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x81cc016d;
		            }
		          }
		        }
		code_r0x81cbfda1:
		        DAT_ram_009d3e38 = 0;
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		    }
		  }
		code_r0x81cc016d:
		  iVar7 = global_1;
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar8) {
		    puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar6);
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar6,
		                         *(undefined4 *)*puVar4);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 != 1) {
		        if (iVar8 != 0) {
		          uVar6 = *puVar4;
		          import::env::__cxa_end_catch();
		          *param1 = -2;
		          unnamed_function_118873(param1 + 1,uVar6);
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81cc029a;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x81cc029a:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar6);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04003275 RID: 12917
		[Token(Token = "0x4003275")]
		[FieldOffset(Offset = "0x30")]
		protected GameResourceCancellationToken _cancel;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Atlas ---
		void Core_GameResources_AbstractGameSpriteAtlasLoader__set_Atlas(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a60663 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GameResourcesManager_ResourceFailedDelegate__RemoveAt__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GameResourcesManager_SpriteAtlasReadyDelegate__RemoveAt__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GameResourcesManager_SpriteAtlasReadyDelegate__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GameResourcesManager_ResourceFailedDelegate__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GameResourcesManager_ResourceFailedDelegate__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GameResourcesManager_SpriteAtlasReadyDelegate__get_Item__
		              );
		    DAT_ram_00a60663 = '\x01';
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x2c),0);
		  if (iVar1 == 0) {
		    if (*(char *)(param1 + 0x25) != '\0') {
		      iVar1 = *(int *)(param1 + 0x20);
		      iVar2 = *(int *)(iVar1 + 0xc);
		      while (0 < iVar2) {
		        iVar1 = System_Linq_Enumerable__ToList_object_
		                          (iVar1,0,
		                           Method_System_Collections_Generic_List_GameResourcesManager_ResourceFailedDelegate__get_Item__
		                          );
		        UnityEngine_TextCore_Glyph__set_atlasIndex
		                  (*(undefined4 *)(param1 + 0x20),0,
		                   Method_System_Collections_Generic_List_GameResourcesManager_ResourceFailedDelegate__RemoveAt__
		                  );
		        if (iVar1 != 0) {
		          (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                    (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 8),
		                     *(undefined4 *)(iVar1 + 0x14));
		        }
		        iVar1 = *(int *)(param1 + 0x20);
		        iVar2 = *(int *)(iVar1 + 0xc);
		      }
		    }
		  }
		  else {
		    iVar1 = *(int *)(param1 + 0x1c);
		    iVar2 = *(int *)(iVar1 + 0xc);
		    while (0 < iVar2) {
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,0,
		                         Method_System_Collections_Generic_List_GameResourcesManager_SpriteAtlasReadyDelegate__get_Item__
		                        );
		      UnityEngine_TextCore_Glyph__set_atlasIndex
		                (*(undefined4 *)(param1 + 0x1c),0,
		                 Method_System_Collections_Generic_List_GameResourcesManager_SpriteAtlasReadyDelegate__RemoveAt__
		                );
		      if (iVar1 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                  (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x2c),
		                   *(undefined4 *)(param1 + 8),*(undefined4 *)(iVar1 + 0x14));
		      }
		      iVar1 = *(int *)(param1 + 0x1c);
		      iVar2 = *(int *)(iVar1 + 0xc);
		    }
		  }
		  return;
		}
		*/

}
