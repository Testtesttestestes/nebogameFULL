using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.AssetsPrefetch
{
	// Token: 0x02000CB7 RID: 3255
	[Token(Token = "0x2000CB7")]
	public class AssetsPrefetch : IDisposable
	{
		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x06004F5B RID: 20315 RVA: 0x0000E928 File Offset: 0x0000CB28
		// (set) Token: 0x06004F5C RID: 20316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001020")]
		private bool IsDisposed
		{
			[Token(Token = "0x6004F5B")]
			[Address(RVA = "0x9D83", Offset = "0x9D83", VA = "0x9D83")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004F5C")]
			[Address(RVA = "0x9D84", Offset = "0x9D84", VA = "0x9D84")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004F5D RID: 20317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F5D")]
		[Address(RVA = "0x9D85", Offset = "0x9D85", VA = "0x9D85", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_AssetsPrefetch_AssetsPrefetch__Dispose(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int param3_00;
		  
		  if (DAT_ram_00a589be == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AssetDic__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AssetDic__get_Count__);
		    DAT_ram_00a589be = '\x01';
		  }
		  if (*(char *)(param1 + 8) == '\0') {
		    iVar1 = *(int *)(param1 + 0x18) + 1;
		    *(int *)(param1 + 0x18) = iVar1;
		    iVar2 = *(int *)(param1 + 0x10);
		    param3_00 = *(int *)(iVar2 + 0xc);
		    if (param3_00 <= iVar1) {
		      *(undefined4 *)(iVar2 + 0xc) = 0;
		      *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		      if (0 < param3_00) {
		        func_ii_2064(*(undefined4 *)(iVar2 + 8),0,param3_00,0);
		      }
		      Cysharp_Threading_Tasks_UniTaskCompletionSource___ctor(param2,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004F5E RID: 20318 RVA: 0x0000E940 File Offset: 0x0000CB40
		[Token(Token = "0x6004F5E")]
		[Address(RVA = "0x1D7E", Offset = "0x1D7E", VA = "0x1D7E")]
		public UniTask Fetch(AssetDic[] assets)
		{
		/* --- GHIDRA: Fetch ---
		/* WARNING: Removing unreachable block (ram,0x81f3d156) */
		/* WARNING: Removing unreachable block (ram,0x81f3d0e8) */
		
		void Gameplay_AssetsPrefetch_AssetsPrefetch__Fetch
		               (int param1,undefined4 param2,undefined8 *param3,int param4)
		
		{
		  int iVar1;
		  undefined4 param3_00;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  undefined4 *param2_00;
		  int *param2_01;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_4;
		  
		  if ((*(int *)(param4 + 0x1c) == 0) &&
		     (Mono_Security_ASN1__get_Item(&StringLiteral_3352), *(int *)(param4 + 0x1c) == 0)) {
		    System_ReadOnlySpan_char___GetPinnableReference(param4);
		  }
		  local_4 = 0;
		  DAT_ram_009d3e38 = 0;
		  param2_01 = (int *)(param1 + 4);
		  uVar4 = import::env::invoke_iiiii
		                    (s_struct_VertexOutput____builtin_p_ram_000028b3 + 0x27c,param2_01,0,&local_4,0)
		  ;
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else if (*param2_01 == 0) {
		    local_18 = param3[4];
		    local_20 = param3[3];
		    local_28 = param3[2];
		    local_30 = param3[1];
		    local_38 = *param3;
		    DAT_ram_009d3e38 = 0;
		    param3_00 = import::env::invoke_iii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,
		                           *(undefined4 *)(*(int *)(param4 + 0x1c) + 4),&local_38);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiiii
		                (s_struct_VertexOutput____builtin_p_ram_000028b3 + 0x27d,param2_01,param3_00,local_4
		                 ,0,0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) goto code_r0x81f3d200;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		  else {
		code_r0x81f3d200:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s___Scripting__UnityEngine__Animat_ram_00003bae + 0x1a,param2,uVar4,
		               *(undefined4 *)(*(int *)(param4 + 0x1c) + 0x14));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    puVar3 = (undefined4 *)import::env::__cxa_begin_catch(uVar4);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar4,
		                         *(undefined4 *)*puVar3);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        if (iVar2 != 0) {
		          uVar4 = *puVar3;
		          import::env::__cxa_end_catch();
		          func_ii_21539(uVar4,0,0);
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81f3d390;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x81f3d390:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(UniTask);
		}

		// Token: 0x06004F5F RID: 20319 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004F5F")]
		public T[] GetContent<T>() where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06004F60 RID: 20320 RVA: 0x0000E958 File Offset: 0x0000CB58
		[Token(Token = "0x6004F60")]
		public bool TryGetContent<T>(out T[] result) where T : UnityEngine.Object
		{
			return default(bool);
		}

		// Token: 0x06004F61 RID: 20321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F61")]
		[Address(RVA = "0x9D86", Offset = "0x9D86", VA = "0x9D86")]
		private void CheckIfReady(UniTaskCompletionSource completionSource)
		{
		/* --- GHIDRA: CheckIfReady ---
		void Gameplay_AssetsPrefetch_AssetsPrefetch__CheckIfReady
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int param3_00;
		  
		  if (DAT_ram_00a589bf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_GameResources_GameResourcesManager_AnimationReadyDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_GameResources_GameResourcesManager_AudioClipReadyDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourcesManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_GameResources_GameResourcesManager_ResourceFailedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_GameResources_GameResourcesManager_SpriteAtlasReadyDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_GameResources_GameResourcesManager_TextMeshProSpriteAssetReadyDelegate_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_GameResources_GameResourcesManager_TextureReadyDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0__Warm_b__0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0__Warm_b__1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0__Warm_b__2__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0__Warm_b__3__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0__Warm_b__4__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0__Warm_b__5__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0__Warm_b__6__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0__Warm_b__7__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0__Warm_b__8__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0__Warm_b__9__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0_TypeInfo);
		    DAT_ram_00a589bf = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 0xc) = param3;
		  *(int *)(iVar1 + 8) = param1;
		  if (param2 == 0) {
		    if (DAT_ram_00a589be == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AssetDic__Clear__);
		      Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AssetDic__get_Count__);
		      DAT_ram_00a589be = '\x01';
		    }
		    if (*(char *)(param1 + 8) == '\0') {
		      iVar1 = *(int *)(param1 + 0x18) + 1;
		      *(int *)(param1 + 0x18) = iVar1;
		      iVar4 = *(int *)(param1 + 0x10);
		      param3_00 = *(int *)(iVar4 + 0xc);
		      if (param3_00 <= iVar1) {
		        *(undefined4 *)(iVar4 + 0xc) = 0;
		        *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		        if (0 < param3_00) {
		          func_ii_2064(*(undefined4 *)(iVar4 + 8),0,param3_00,0);
		        }
		        Cysharp_Threading_Tasks_UniTaskCompletionSource___ctor(param3,0);
		        return;
		      }
		    }
		  }
		  else {
		    iVar4 = *(int *)(param2 + 0x10);
		    if (iVar4 == 1) {
		      uVar5 = *(undefined4 *)(param2 + 0x14);
		      uVar2 = unnamed_function_1417
		                        (Core_GameResources_GameResourcesManager_TextureReadyDelegate_TypeInfo);
		      Core_GameResources_GameResourcesManager_ResourceFailedDelegate__EndInvoke
		                (uVar2,iVar1,
		                 Method_Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0__Warm_b__0__,0)
		      ;
		      uVar3 = unnamed_function_1417
		                        (Core_GameResources_GameResourcesManager_ResourceFailedDelegate_TypeInfo);
		      Core_GameResources_GameResourcesManager_SpriteAtlasReadyDelegate___ctor
		                (uVar3,iVar1,
		                 Method_Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0__Warm_b__1__,0)
		      ;
		      if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		      }
		      Core_GameResources_GameResourcesManager___cctor(uVar5,uVar2,uVar3,1,0);
		      iVar4 = *(int *)(param2 + 0x10);
		    }
		    if (iVar4 == 2) {
		      uVar5 = *(undefined4 *)(param2 + 0x14);
		      uVar2 = unnamed_function_1417
		                        (Core_GameResources_GameResourcesManager_AnimationReadyDelegate_TypeInfo);
		      Core_GameResources_GameResourcesManager_AudioClipReadyDelegate__EndInvoke
		                (uVar2,iVar1,
		                 Method_Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0__Warm_b__2__,0)
		      ;
		      uVar3 = unnamed_function_1417
		                        (Core_GameResources_GameResourcesManager_ResourceFailedDelegate_TypeInfo);
		      Core_GameResources_GameResourcesManager_SpriteAtlasReadyDelegate___ctor
		                (uVar3,iVar1,
		                 Method_Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0__Warm_b__3__,0)
		      ;
		      if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		      }
		      Core_GameResources_GameResourcesManager__ReleaseTextMeshProSpriteAsset(uVar5,uVar2,uVar3,1,0);
		      iVar4 = *(int *)(param2 + 0x10);
		    }
		    if (iVar4 == 3) {
		      uVar5 = *(undefined4 *)(param2 + 0x14);
		      uVar2 = unnamed_function_1417
		                        (Core_GameResources_GameResourcesManager_AudioClipReadyDelegate_TypeInfo);
		      Core_GameResources_GameResourcesManager_TextMeshProSpriteAssetReadyDelegate__EndInvoke
		                (uVar2,iVar1,
		                 Method_Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0__Warm_b__4__,0)
		      ;
		      uVar3 = unnamed_function_1417
		                        (Core_GameResources_GameResourcesManager_ResourceFailedDelegate_TypeInfo);
		      Core_GameResources_GameResourcesManager_SpriteAtlasReadyDelegate___ctor
		                (uVar3,iVar1,
		                 Method_Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0__Warm_b__5__,0)
		      ;
		      if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		      }
		      Core_GameResources_GameResourcesManager__GetTextMeshProSpriteAsset(uVar5,uVar2,uVar3,1,0);
		      iVar4 = *(int *)(param2 + 0x10);
		    }
		    if (iVar4 == 5) {
		      uVar5 = *(undefined4 *)(param2 + 0x14);
		      uVar2 = unnamed_function_1417
		                        (
		                        Core_GameResources_GameResourcesManager_TextMeshProSpriteAssetReadyDelegate_TypeInfo
		                        );
		      Core_GameResources_GameResourcesManager_SpriteAtlasReadyDelegate__EndInvoke
		                (uVar2,iVar1,
		                 Method_Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0__Warm_b__6__,0)
		      ;
		      uVar3 = unnamed_function_1417
		                        (Core_GameResources_GameResourcesManager_ResourceFailedDelegate_TypeInfo);
		      Core_GameResources_GameResourcesManager_SpriteAtlasReadyDelegate___ctor
		                (uVar3,iVar1,
		                 Method_Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0__Warm_b__7__,0)
		      ;
		      if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		      }
		      Core_GameResources_GameResourcesManager__GetSprite(uVar5,uVar2,uVar3,1,0);
		      iVar4 = *(int *)(param2 + 0x10);
		    }
		    if (iVar4 == 4) {
		      uVar5 = *(undefined4 *)(param2 + 0x14);
		      uVar2 = unnamed_function_1417
		                        (Core_GameResources_GameResourcesManager_SpriteAtlasReadyDelegate_TypeInfo);
		      Core_Gameplay_Managers_DictManager__GetAssetPath
		                (uVar2,iVar1,
		                 Method_Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0__Warm_b__8__,0)
		      ;
		      uVar3 = unnamed_function_1417
		                        (Core_GameResources_GameResourcesManager_ResourceFailedDelegate_TypeInfo);
		      Core_GameResources_GameResourcesManager_SpriteAtlasReadyDelegate___ctor
		                (uVar3,iVar1,
		                 Method_Gameplay_AssetsPrefetch_AssetsPrefetch___c__DisplayClass13_0__Warm_b__9__,0)
		      ;
		      if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		      }
		      Core_GameResources_GameResourcesManager_ResourceFailedDelegate___ctor(uVar5,uVar2,uVar3,1,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004F62 RID: 20322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F62")]
		[Address(RVA = "0x9D87", Offset = "0x9D87", VA = "0x9D87")]
		private void Warm(AssetDic asset, UniTaskCompletionSource completionSource)
		{
		/* --- GHIDRA: Warm ---
		void Gameplay_AssetsPrefetch_AssetsPrefetch__Warm(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a589c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Object___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AssetDic___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AssetDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Object__TypeInfo);
		    DAT_ram_00a589c0 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_AssetDic__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_AssetDic___ctor__);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_Object__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_Object___ctor__);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06004F63 RID: 20323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F63")]
		[Address(RVA = "0x9D88", Offset = "0x9D88", VA = "0x9D88")]
		public AssetsPrefetch()
		{
		}

		// Token: 0x04002B32 RID: 11058
		[Token(Token = "0x4002B32")]
		[FieldOffset(Offset = "0xC")]
		private UniTaskCompletionSource _fetchCompletionSource;

		// Token: 0x04002B33 RID: 11059
		[Token(Token = "0x4002B33")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<AssetDic> _assets;

		// Token: 0x04002B34 RID: 11060
		[Token(Token = "0x4002B34")]
		[FieldOffset(Offset = "0x14")]
		private readonly List<UnityEngine.Object> _content;

		// Token: 0x04002B35 RID: 11061
		[Token(Token = "0x4002B35")]
		[FieldOffset(Offset = "0x18")]
		private int _progress;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IsDisposed ---
		void Gameplay_AssetsPrefetch_AssetsPrefetch__set_IsDisposed(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a589bc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AssetDic__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AssetDic__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AssetDic__get_Current__);
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourcesManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Object__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AssetDic__GetEnumerator__);
		    DAT_ram_00a589bc = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x10),
		             Method_System_Collections_Generic_List_AssetDic__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_AssetDic__MoveNext__);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f56db6;
		    }
		    if (iVar1 == 0) goto code_r0x80f56e0c;
		    uVar2 = local_8._4_4_;
		    if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 Core_GameResources_GameResourcesManager_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1e6,uVar2,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f56db6:
		  iVar4 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar1 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80f56e0c:
		      DAT_ram_009d3e38 = 0;
		      iVar4 = *(int *)(param1 + 0x14);
		      iVar1 = *(int *)(iVar4 + 0xc);
		      *(undefined4 *)(iVar4 + 0xc) = 0;
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      if (0 < iVar1) {
		        func_ii_2064(*(undefined4 *)(iVar4 + 8),0,iVar1,0);
		      }
		      if (*(int *)(param1 + 0xc) != 0) {
		        Cysharp_Threading_Tasks_UniTaskCompletionSource__MarkHandled(*(int *)(param1 + 0xc),0,0);
		      }
		      *(undefined1 *)(param1 + 8) = 1;
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1e7,&local_18);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
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


		/* --- GHIDRA: GetContent<object> ---
		uint Gameplay_AssetsPrefetch_AssetsPrefetch__GetContent_object_(int param1,int *param2,int param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if ((*(int *)(param3 + 0x1c) == 0) &&
		     (Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Object__ToArray__),
		     *(int *)(param3 + 0x1c) == 0)) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		  }
		  uVar1 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                    (*(undefined4 *)(param1 + 0x14),
		                     Method_System_Collections_Generic_List_Object__ToArray__);
		  iVar2 = *(int *)(*(int *)(param3 + 0x1c) + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  if (*(int *)(iVar2 + 0x74) == 0) {
		    func_ii_306000(iVar2);
		  }
		  iVar2 = *(int *)(*(int *)(param3 + 0x1c) + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x5c) + 4);
		  if (iVar2 == 0) {
		    iVar2 = *(int *)(*(int *)(param3 + 0x1c) + 8);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		    }
		    if (*(int *)(iVar2 + 0x74) == 0) {
		      func_ii_306000(iVar2);
		    }
		    iVar3 = *(int *)(param3 + 0x1c);
		    iVar2 = *(int *)(iVar3 + 8);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		      iVar3 = *(int *)(param3 + 0x1c);
		    }
		    uVar4 = **(undefined4 **)(iVar2 + 0x5c);
		    iVar2 = *(int *)(iVar3 + 4);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		    }
		    iVar2 = unnamed_function_1417(iVar2);
		    System_Threading_Tasks_ContinuationTaskFromResultTask___Il2CppFullySharedGenericType___InnerInvoke
		              (iVar2,uVar4,*(undefined4 *)(*(int *)(param3 + 0x1c) + 0xc),
		               *(undefined4 *)(*(int *)(param3 + 0x1c) + 0x10));
		    iVar3 = *(int *)(*(int *)(param3 + 0x1c) + 8);
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      iVar3 = func_ii_1079(iVar3);
		    }
		    *(int *)(*(int *)(iVar3 + 0x5c) + 4) = iVar2;
		    iVar3 = *(int *)(*(int *)(param3 + 0x1c) + 8);
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      func_ii_1079(iVar3);
		    }
		  }
		  uVar1 = System_Array__BinarySearch_RenderChain_VisualChangesProcessor_EntryProcessingInfo_
		                    (uVar1,iVar2,*(undefined4 *)(*(int *)(param3 + 0x1c) + 0x14));
		  iVar2 = *(int *)(*(int *)(param3 + 0x1c) + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  if (*(int *)(iVar2 + 0x74) == 0) {
		    func_ii_306000(iVar2);
		  }
		  iVar2 = *(int *)(*(int *)(param3 + 0x1c) + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x5c) + 8);
		  if (iVar2 == 0) {
		    iVar2 = *(int *)(*(int *)(param3 + 0x1c) + 8);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		    }
		    if (*(int *)(iVar2 + 0x74) == 0) {
		      func_ii_306000(iVar2);
		    }
		    iVar3 = *(int *)(param3 + 0x1c);
		    iVar2 = *(int *)(iVar3 + 8);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		      iVar3 = *(int *)(param3 + 0x1c);
		    }
		    uVar4 = **(undefined4 **)(iVar2 + 0x5c);
		    iVar2 = *(int *)(iVar3 + 0x20);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		    }
		    iVar2 = unnamed_function_1417(iVar2);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar2,uVar4,*(undefined4 *)(*(int *)(param3 + 0x1c) + 0x24),
		               *(undefined4 *)(*(int *)(param3 + 0x1c) + 0x28));
		    iVar3 = *(int *)(*(int *)(param3 + 0x1c) + 8);
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      iVar3 = func_ii_1079(iVar3);
		    }
		    *(int *)(*(int *)(iVar3 + 0x5c) + 8) = iVar2;
		    iVar3 = *(int *)(*(int *)(param3 + 0x1c) + 8);
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      func_ii_1079(iVar3);
		    }
		  }
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar1,iVar2,*(undefined4 *)(*(int *)(param3 + 0x1c) + 0x2c));
		  iVar2 = func_ii_6295(uVar1,*(undefined4 *)(*(int *)(param3 + 0x1c) + 0x34));
		  *param2 = iVar2;
		  return (uint)(*(int *)(iVar2 + 0xc) != 0);
		}
		*/


		/* --- GHIDRA: TryGetContent<object> ---
		undefined4
		Gameplay_AssetsPrefetch_AssetsPrefetch__TryGetContent_object_(undefined8 *param1,int param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined8 uVar2;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar1 = *(int *)(param2 + 0x1c);
		  if (iVar1 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param2);
		    iVar1 = *(int *)(param2 + 0x1c);
		  }
		  uVar2 = *param1;
		  iVar1 = *(int *)(iVar1 + 4);
		  if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		    iVar1 = func_ii_1079(iVar1);
		  }
		  param1_00 = unnamed_function_1417(iVar1);
		  local_10 = uVar2;
		  local_8 = uVar2;
		  System_Threading_Tasks_Task_Nullable_int_____ctor
		            (param1_00,0,&local_10,0x4000,0,*(undefined4 *)(*(int *)(param2 + 0x1c) + 8));
		  return param1_00;
		}
		*/

}
