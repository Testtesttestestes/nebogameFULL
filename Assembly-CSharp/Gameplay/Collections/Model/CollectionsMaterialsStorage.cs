using System;
using System.Collections.Generic;
using Core.Data;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Collections.Model
{
	// Token: 0x020009D3 RID: 2515
	[Token(Token = "0x20009D3")]
	public class CollectionsMaterialsStorage : ICollectionsMaterialsStorage, IDisposable
	{
		// Token: 0x06003C32 RID: 15410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C32")]
		[Address(RVA = "0x8B01", Offset = "0x8B01", VA = "0x8B01")]
		public void Init(IGame game, IDictionary<uint, CollectionData> collectionsById)
		{
		/* --- GHIDRA: Init ---
		undefined4
		Gameplay_Collections_Model_CollectionsMaterialsStorage__Init
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Collections_Model_CollectionsMaterialsStorage__TryGetMedalCollections
		                    (param1,param2,*(undefined4 *)(param1 + 8),param3,param1);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x0000C108 File Offset: 0x0000A308
		[Token(Token = "0x6003C33")]
		[Address(RVA = "0x8B02", Offset = "0x8B02", VA = "0x8B02", Slot = "4")]
		public bool TryGetArtikulCollections(uint artikulId, out List<CollectionWithRank> collectionsWithRank)
		{
		/* --- GHIDRA: TryGetArtikulCollections ---
		undefined4
		Gameplay_Collections_Model_CollectionsMaterialsStorage__TryGetArtikulCollections
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Collections_Model_CollectionsMaterialsStorage__TryGetMedalCollections
		                    (param1,param2,*(undefined4 *)(param1 + 0xc),param3,param1);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x0000C120 File Offset: 0x0000A320
		[Token(Token = "0x6003C34")]
		[Address(RVA = "0x8B03", Offset = "0x8B03", VA = "0x8B03", Slot = "5")]
		public bool TryGetMedalCollections(uint medalId, out List<CollectionWithRank> collectionsWithRank)
		{
		/* --- GHIDRA: TryGetMedalCollections ---
		/* WARNING: Removing unreachable block (ram,0x80e76918) */
		
		undefined4
		Gameplay_Collections_Model_CollectionsMaterialsStorage__TryGetMedalCollections
		          (undefined4 param1,undefined4 param2,undefined4 param3,int *param4,undefined4 param5)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  undefined4 *puVar8;
		  uint uVar9;
		  undefined8 uVar10;
		  undefined8 local_48;
		  int local_40;
		  undefined8 *local_3c;
		  undefined8 local_38 [3];
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 uStack_14;
		  undefined4 local_10;
		  undefined4 uStack_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57eaf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_CollectionData__List_uint___GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_CollectionData__List_uint____TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_uint__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_uint___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_CollectionData__List_uint___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_CollectionData__List_uint___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_CollectionData__List_uint___get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_uint__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_uint__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_CollectionData__List_uint___get_Key__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_CollectionData__List_uint___get_Value__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CollectionWithRank__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CollectionWithRank___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_CollectionWithRank__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Model_CollectionsMaterialsStorage___c__TryGetMaterialCollectionsInternal_b__5_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Model_CollectionsMaterialsStorage___c__DisplayClass5_0__TryGetMaterialCollectionsInternal_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_CollectionsMaterialsStorage___c__DisplayClass5_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_CollectionsMaterialsStorage___c_TypeInfo);
		    DAT_ram_00a57eaf = '\x01';
		  }
		  local_4 = 0;
		  *param4 = 0;
		  iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (param3,param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__Dictionary_CollectionData__List_uint____TryGetValue__
		                    );
		  if (iVar1 == 0) {
		    return 0;
		  }
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_CollectionWithRank__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_CollectionWithRank___ctor__);
		  *param4 = iVar2;
		  System_Collections_Generic_List_object___GetEnumerator
		            (local_38,local_4,
		             Method_System_Collections_Generic_Dictionary_CollectionData__List_uint___GetEnumerator__
		            );
		  local_10 = (undefined4)local_38[2];
		  uStack_c = (undefined4)((ulonglong)local_38[2] >> 0x20);
		  local_18 = (undefined4)local_38[1];
		  uStack_14 = (undefined4)((ulonglong)local_38[1] >> 0x20);
		  local_20 = local_38[0];
		  local_40 = 0;
		  local_3c = &local_20;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x158,&local_20,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_CollectionData__List_uint___MoveNext__
		                      );
		    param2_00 = local_10;
		    uVar6 = uStack_14;
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e76cbd;
		    }
		    iVar2 = local_40;
		    if (iVar3 == 0) goto code_r0x80e76d06;
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_Collections_Model_CollectionsMaterialsStorage___c__DisplayClass5_0_TypeInfo
		                      );
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e76cbd;
		    }
		    *(undefined4 *)(iVar2 + 8) = uVar6;
		    if (*(int *)(Gameplay_Collections_Model_CollectionsMaterialsStorage___c_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 Gameplay_Collections_Model_CollectionsMaterialsStorage___c_TypeInfo);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e76cbd;
		      }
		    }
		    puVar8 = *(undefined4 **)
		              (Gameplay_Collections_Model_CollectionsMaterialsStorage___c_TypeInfo + 0x5c);
		    iVar3 = puVar8[1];
		    if (iVar3 == 0) break;
		code_r0x80e76a3b:
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xc9,param2_00,iVar3,
		                       Method_System_Linq_Enumerable_OrderBy_uint__uint___);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e76cbd;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xca,uVar6,
		                       Method_System_Linq_Enumerable_ToArray_uint___);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e76cbd;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Func_uint__bool__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e76c31:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e76cbd;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xcb,uVar6,iVar2,
		               Method_Gameplay_Collections_Model_CollectionsMaterialsStorage___c__DisplayClass5_0__TryGetMaterialCollectionsInternal_b__1__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e76c31;
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xcc,iVar4,uVar6,
		                       Method_System_Linq_Enumerable_FirstOrDefault_uint___);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e76cbd;
		    }
		    if (iVar5 == 0) {
		      iVar5 = *(int *)(*(int *)(iVar4 + 0xc) * 4 + iVar4 + 0xc);
		    }
		    iVar4 = *param4;
		    DAT_ram_009d3e38 = 0;
		    uVar6 = System_Linq_Enumerable__FirstOrDefault_uint_(*(undefined4 *)(iVar2 + 8),0);
		    iVar3 = DAT_ram_009d3e38;
		    iVar2 = Method_System_Collections_Generic_List_CollectionWithRank__Add__;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e76cbd;
		    }
		    *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		    uVar10 = CONCAT44(iVar5,uVar6);
		    uVar9 = *(uint *)(iVar4 + 0xc);
		    if (uVar9 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		      *(uint *)(iVar4 + 0xc) = uVar9 + 1;
		      *(undefined8 *)(*(int *)(iVar4 + 8) + uVar9 * 8 + 0x10) = uVar10;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      local_48 = uVar10;
		      local_38[0] = uVar10;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xce,iVar4,&local_48,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e76cbd:
		        iVar2 = global_1;
		        iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar2 == iVar3) {
		          piVar7 = (int *)import::env::__cxa_begin_catch(uVar6);
		          iVar2 = *piVar7;
		          DAT_ram_009d3e38 = 0;
		          local_40 = iVar2;
		          import::env::invoke_v(0x123);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 != 1) {
		code_r0x80e76d06:
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 == 0) {
		              DAT_ram_009d3e38 = 0;
		              return iVar1;
		            }
		            System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar6 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xcf,&local_40);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__resumeException(uVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  if (*(int *)(Gameplay_Collections_Model_CollectionsMaterialsStorage___c_TypeInfo + 0x74) == 0) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		               Gameplay_Collections_Model_CollectionsMaterialsStorage___c_TypeInfo);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e76cbd;
		    }
		    puVar8 = *(undefined4 **)
		              (Gameplay_Collections_Model_CollectionsMaterialsStorage___c_TypeInfo + 0x5c);
		  }
		  uVar6 = *puVar8;
		  DAT_ram_009d3e38 = 0;
		  iVar3 = import::env::invoke_ii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                     System_Func_uint__uint__TypeInfo);
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 200,iVar3,uVar6,
		               Method_Gameplay_Collections_Model_CollectionsMaterialsStorage___c__TryGetMaterialCollectionsInternal_b__5_0__
		               ,0);
		    if (DAT_ram_009d3e38 != 1) {
		      *(int *)(*(int *)(Gameplay_Collections_Model_CollectionsMaterialsStorage___c_TypeInfo + 0x5c)
		              + 4) = iVar3;
		      goto code_r0x80e76a3b;
		    }
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x80e76cbd;
		}
		*/

			return default(bool);
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x0000C138 File Offset: 0x0000A338
		[Token(Token = "0x6003C35")]
		[Address(RVA = "0x8B04", Offset = "0x8B04", VA = "0x8B04")]
		private bool TryGetMaterialCollectionsInternal(uint materialId, Dictionary<uint, Dictionary<CollectionData, List<uint>>> dict, out List<CollectionWithRank> collectionsWithRank)
		{
		/* --- GHIDRA: TryGetMaterialCollectionsInternal ---
		void Gameplay_Collections_Model_CollectionsMaterialsStorage__TryGetMaterialCollectionsInternal
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57eb1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_CollectionData__List_uint____Clear__
		              );
		    DAT_ram_00a57eb1 = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 8),
		             Method_System_Collections_Generic_Dictionary_uint__Dictionary_CollectionData__List_uint____Clear__
		            );
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0xc),
		             Method_System_Collections_Generic_Dictionary_uint__Dictionary_CollectionData__List_uint____Clear__
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C36")]
		[Address(RVA = "0x1C4D", Offset = "0x1C4D", VA = "0x1C4D")]
		private void FillMaterials(CollectionRanksDic rankDic, IGame game, CollectionData collection)
		{
		}

		// Token: 0x06003C37 RID: 15415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C37")]
		[Address(RVA = "0x8B05", Offset = "0x8B05", VA = "0x8B05", Slot = "6")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Collections_Model_CollectionsMaterialsStorage__Dispose(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57eb2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_CollectionData__List_uint_____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_uint__Dictionary_CollectionData__List_uint____TypeInfo
		              );
		    DAT_ram_00a57eb2 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_uint__Dictionary_CollectionData__List_uint____TypeInfo
		                    );
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_uint__Dictionary_CollectionData__List_uint_____ctor__
		            );
		  *(undefined4 *)(param1 + 8) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_uint__Dictionary_CollectionData__List_uint____TypeInfo
		                    );
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_uint__Dictionary_CollectionData__List_uint_____ctor__
		            );
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06003C38 RID: 15416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C38")]
		[Address(RVA = "0x8B06", Offset = "0x8B06", VA = "0x8B06")]
		public CollectionsMaterialsStorage()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Collections_Model_CollectionsMaterialsStorage___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57eb3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_CollectionsMaterialsStorage___c_TypeInfo);
		    DAT_ram_00a57eb3 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Collections_Model_CollectionsMaterialsStorage___c_TypeInfo)
		  ;
		  **(undefined4 **)(Gameplay_Collections_Model_CollectionsMaterialsStorage___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002145 RID: 8517
		[Token(Token = "0x4002145")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<uint, Dictionary<CollectionData, List<uint>>> _artikulMaterials;

		// Token: 0x04002146 RID: 8518
		[Token(Token = "0x4002146")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<uint, Dictionary<CollectionData, List<uint>>> _medalMaterials;
	}
}
