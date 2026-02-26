using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Gameplay.Managers;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine.U2D;

namespace Gameplay.AssetsPrefetch
{
	// Token: 0x02000CBD RID: 3261
	[Token(Token = "0x2000CBD")]
	public class CombatGemsAssetsPrefetch : IDisposable
	{
		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x06004F80 RID: 20352 RVA: 0x0000E9B8 File Offset: 0x0000CBB8
		// (set) Token: 0x06004F81 RID: 20353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001023")]
		public bool IsDisposed
		{
			[Token(Token = "0x6004F80")]
			[Address(RVA = "0x9D9E", Offset = "0x9D9E", VA = "0x9D9E")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004F81")]
			[Address(RVA = "0x9D9F", Offset = "0x9D9F", VA = "0x9D9F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004F82 RID: 20354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F82")]
		[Address(RVA = "0x9DA0", Offset = "0x9DA0", VA = "0x9DA0", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: <Fetch>b__13_0 ---
		void Gameplay_AssetsPrefetch_CombatGemsAssetsPrefetch___Fetch_b__13_0
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x14) + 1;
		  *(int *)(param1 + 0x14) = iVar1;
		  if ((*(char *)(param1 + 0x1c) == '\0') && (*(int *)(param1 + 0x18) <= iVar1)) {
		    Cysharp_Threading_Tasks_UniTaskCompletionSource___ctor(*(undefined4 *)(param1 + 0xc),0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: Dispose ---
		void Gameplay_AssetsPrefetch_CombatGemsAssetsPrefetch__Dispose
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a589ca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__CombatGemsAssetsPrefetch_GemsSpriteAtlasVo___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_uint__CombatGemsAssetsPrefetch_GemsSpriteAtlasVo__TypeInfo
		              );
		    DAT_ram_00a589ca = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_uint__CombatGemsAssetsPrefetch_GemsSpriteAtlasVo__TypeInfo
		                        );
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_uint__CombatGemsAssetsPrefetch_GemsSpriteAtlasVo___ctor__
		            );
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  *(undefined4 *)(param1 + 8) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06004F83 RID: 20355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F83")]
		[Address(RVA = "0x9DA1", Offset = "0x9DA1", VA = "0x9DA1")]
		public CombatGemsAssetsPrefetch(DictManager dictProvider)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_AssetsPrefetch_CombatGemsAssetsPrefetch___ctor
		              (int param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined1 auStack_10 [4];
		  int local_c;
		  int local_4;
		  
		  if (DAT_ram_00a589cb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__CombatGemsAssetsPrefetch_GemsSpriteAtlasVo__TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_First_KeyValuePair_uint__CombatGemsAssetsPrefetch_GemsSpriteAtlasVo____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_uint__CombatGemsAssetsPrefetch_GemsSpriteAtlasVo__get_Value__
		              );
		    DAT_ram_00a589cb = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0x10),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__CombatGemsAssetsPrefetch_GemsSpriteAtlasVo__TryGetValue__
		                    );
		  if (iVar1 == 0) {
		    System_Linq_Enumerable__Empty___Il2CppFullySharedGenericType_
		              (auStack_10,*(undefined4 *)(param1 + 0x10),
		               Method_System_Linq_Enumerable_First_KeyValuePair_uint__CombatGemsAssetsPrefetch_GemsSpriteAtlasVo____
		              );
		    local_4 = local_c;
		  }
		  *param3 = *(undefined4 *)(local_4 + 0xc);
		  return iVar1;
		}
		*/

		}

		// Token: 0x06004F84 RID: 20356 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		[Token(Token = "0x6004F84")]
		[Address(RVA = "0x9DA2", Offset = "0x9DA2", VA = "0x9DA2")]
		public bool TryGetGemsSpriteAtlas(uint setId, out SpriteAtlas atlas)
		{
		/* --- GHIDRA: TryGetGemsSpriteAtlas ---
		void Gameplay_AssetsPrefetch_CombatGemsAssetsPrefetch__TryGetGemsSpriteAtlas
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if ((*(char *)(param1 + 0x1c) == '\0') && (*(int *)(param1 + 0x18) <= *(int *)(param1 + 0x14))) {
		    Cysharp_Threading_Tasks_UniTaskCompletionSource___ctor(param2,0);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004F85 RID: 20357 RVA: 0x0000E9E8 File Offset: 0x0000CBE8
		[Token(Token = "0x6004F85")]
		[Address(RVA = "0x220A", Offset = "0x220A", VA = "0x220A")]
		public UniTask Fetch()
		{
			return default(UniTask);
		}

		// Token: 0x06004F86 RID: 20358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F86")]
		[Address(RVA = "0x9DA3", Offset = "0x9DA3", VA = "0x9DA3")]
		private void CheckIfReady(UniTaskCompletionSource completionSource)
		{
		/* --- GHIDRA: CheckIfReady ---
		undefined4
		Gameplay_AssetsPrefetch_CombatGemsAssetsPrefetch__CheckIfReady
		          (int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a589cd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_CombatTypeGemSetsDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_CombatTypeGemSetsDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AssetsPrefetch_CombatGemsAssetsPrefetch___c__DisplayClass13_0__Fetch_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_AssetsPrefetch_CombatGemsAssetsPrefetch___c__DisplayClass13_0_TypeInfo);
		    DAT_ram_00a589cd = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_AssetsPrefetch_CombatGemsAssetsPrefetch___c__DisplayClass13_0_TypeInfo
		                        );
		  *(int *)(param2_00 + 8) = param2;
		  if (*(char *)(param2 + 0x14) == '\0') {
		    iVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                      (*(undefined4 *)(param1 + 8),0);
		    param1_00 = *(undefined4 *)(iVar1 + 200);
		    uVar2 = unnamed_function_1417(System_Func_CombatTypeGemSetsDic__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar2,param2_00,
		               Method_Gameplay_AssetsPrefetch_CombatGemsAssetsPrefetch___c__DisplayClass13_0__Fetch_b__1__
		               ,0);
		    uVar2 = Newtonsoft_Json_Utilities_ReflectionUtils__IsOverridenGenericMember
		                      (param1_00,uVar2,Method_System_Linq_Enumerable_Any_CombatTypeGemSetsDic___);
		  }
		  else {
		    uVar2 = 1;
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x04002B42 RID: 11074
		[Token(Token = "0x4002B42")]
		[FieldOffset(Offset = "0x8")]
		public readonly DictManager DictProvider;

		// Token: 0x04002B43 RID: 11075
		[Token(Token = "0x4002B43")]
		[FieldOffset(Offset = "0xC")]
		private UniTaskCompletionSource _fetchCompletionSource;

		// Token: 0x04002B44 RID: 11076
		[Token(Token = "0x4002B44")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<uint, CombatGemsAssetsPrefetch.GemsSpriteAtlasVo> _gemsSpriteAtlas;

		// Token: 0x04002B45 RID: 11077
		[Token(Token = "0x4002B45")]
		[FieldOffset(Offset = "0x14")]
		private int _gemsSpriteAtlasсCurrentProgress;

		// Token: 0x04002B46 RID: 11078
		[Token(Token = "0x4002B46")]
		[FieldOffset(Offset = "0x18")]
		private int _gemsSpriteAtlasсTotalProgress;

		// Token: 0x02000CBE RID: 3262
		[Token(Token = "0x2000CBE")]
		private class GemsSpriteAtlasVo
		{
			// Token: 0x06004F89 RID: 20361 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004F89")]
			[Address(RVA = "0x9DA6", Offset = "0x9DA6", VA = "0x9DA6")]
			public GemsSpriteAtlasVo(uint setId, string path, SpriteAtlas atlas)
			{
			}

			// Token: 0x04002B48 RID: 11080
			[Token(Token = "0x4002B48")]
			[FieldOffset(Offset = "0x8")]
			public readonly uint SetId;

			// Token: 0x04002B49 RID: 11081
			[Token(Token = "0x4002B49")]
			[FieldOffset(Offset = "0xC")]
			public readonly SpriteAtlas Atlas;

			// Token: 0x04002B4A RID: 11082
			[Token(Token = "0x4002B4A")]
			[FieldOffset(Offset = "0x10")]
			public readonly string Path;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IsDisposed ---
		void Gameplay_AssetsPrefetch_CombatGemsAssetsPrefetch__set_IsDisposed(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a589c9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__CombatGemsAssetsPrefetch_GemsSpriteAtlasVo__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__CombatGemsAssetsPrefetch_GemsSpriteAtlasVo__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__CombatGemsAssetsPrefetch_GemsSpriteAtlasVo__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__CombatGemsAssetsPrefetch_GemsSpriteAtlasVo__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourcesManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__CombatGemsAssetsPrefetch_GemsSpriteAtlasVo__GetEnumerator__
		              );
		    DAT_ram_00a589c9 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if (*(int *)(param1 + 0xc) != 0) {
		    Cysharp_Threading_Tasks_UniTaskCompletionSource__MarkHandled(*(int *)(param1 + 0xc),0,0);
		  }
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x10),
		                     Method_System_Collections_Generic_Dictionary_uint__CombatGemsAssetsPrefetch_GemsSpriteAtlasVo__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__CombatGemsAssetsPrefetch_GemsSpriteAtlasVo__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__CombatGemsAssetsPrefetch_GemsSpriteAtlasVo__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f57ef5;
		    }
		    if (iVar3 == 0) goto code_r0x80f57f97;
		    uVar2 = *(undefined4 *)(local_8._4_4_ + 0x10);
		    if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 Core_GameResources_GameResourcesManager_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1e8,uVar2,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f57ef5:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80f57f97:
		      DAT_ram_009d3e38 = 0;
		      *(undefined1 *)(param1 + 0x1c) = 1;
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1e9,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(uVar2);
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
