using System;
using System.Collections.Generic;
using Gameplay.ArtifactComparer.Model;
using Gameplay.ArtifactComparer.View.Rows;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.ArtifactComparer.View
{
	// Token: 0x02000CD6 RID: 3286
	[Token(Token = "0x2000CD6")]
	public class ArtifactComparerTable : MonoBehaviour
	{
		// Token: 0x06004FF5 RID: 20469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF5")]
		[Address(RVA = "0x9E09", Offset = "0x9E09", VA = "0x9E09")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		undefined4
		Gameplay_ArtifactComparer_View_ArtifactComparerTable__Awake
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58a06 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_SingleOrDefault_ArtifactComparerTable_ComparerRowPrefabConfig___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ArtifactComparerTable_ComparerRowPrefabConfig__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_View_ArtifactComparerTable___c__DisplayClass5_0__GetRowPrefab_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ArtifactComparer_View_ArtifactComparerTable___c__DisplayClass5_0_TypeInfo);
		    DAT_ram_00a58a06 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_ArtifactComparer_View_ArtifactComparerTable___c__DisplayClass5_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = unnamed_function_1417
		                    (System_Func_ArtifactComparerTable_ComparerRowPrefabConfig__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Gameplay_ArtifactComparer_View_ArtifactComparerTable___c__DisplayClass5_0__GetRowPrefab_b__0__
		             ,0);
		  uVar1 = UI_SimpleIconValue__set_Value
		                    (param1_00,uVar1,
		                     Method_System_Linq_Enumerable_SingleOrDefault_ArtifactComparerTable_ComparerRowPrefabConfig___
		                    );
		  return uVar1;
		}
		*/

		}

		// Token: 0x06004FF6 RID: 20470 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004FF6")]
		[Address(RVA = "0x9E0A", Offset = "0x9E0A", VA = "0x9E0A")]
		private ArtifactComparerTable.ComparerRowPrefabConfig GetRowPrefab(ArtifactComparerRowData.RowType type)
		{
			return null;
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x06004FF7 RID: 20471 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004FF8 RID: 20472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700102D")]
		public IList<ArtifactComparerRowData> Data
		{
			[Token(Token = "0x6004FF7")]
			[Address(RVA = "0x9E0B", Offset = "0x9E0B", VA = "0x9E0B")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FF8")]
			[Address(RVA = "0x9E0C", Offset = "0x9E0C", VA = "0x9E0C")]
			set
			{
			}
		}

		// Token: 0x06004FF9 RID: 20473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF9")]
		[Address(RVA = "0x9E0D", Offset = "0x9E0D", VA = "0x9E0D")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerTable__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58a08 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactComparerRowView___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtifactComparerRowView__TypeInfo)
		    ;
		    DAT_ram_00a58a08 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_ArtifactComparerRowView__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_ArtifactComparerRowView___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004FFA RID: 20474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FFA")]
		[Address(RVA = "0x9E0E", Offset = "0x9E0E", VA = "0x9E0E")]
		public ArtifactComparerTable()
		{
		}

		// Token: 0x04002B8E RID: 11150
		[Token(Token = "0x4002B8E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04002B8F RID: 11151
		[Token(Token = "0x4002B8F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected ArtifactComparerTable.ComparerRowPrefabConfig[] _prefabsByTypes;

		// Token: 0x04002B90 RID: 11152
		[Token(Token = "0x4002B90")]
		[FieldOffset(Offset = "0x18")]
		private List<ArtifactComparerRowView> _currentRows;

		// Token: 0x04002B91 RID: 11153
		[Token(Token = "0x4002B91")]
		[FieldOffset(Offset = "0x1C")]
		private IList<ArtifactComparerRowData> _data;

		// Token: 0x02000CD7 RID: 3287
		[Token(Token = "0x2000CD7")]
		[Serializable]
		public class ComparerRowPrefabConfig
		{
			// Token: 0x06004FFB RID: 20475 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004FFB")]
			[Address(RVA = "0x9E0F", Offset = "0x9E0F", VA = "0x9E0F")]
			public ComparerRowPrefabConfig()
			{
			}

			// Token: 0x04002B92 RID: 11154
			[Token(Token = "0x4002B92")]
			[FieldOffset(Offset = "0x8")]
			public ArtifactComparerRowData.RowType Type;

			// Token: 0x04002B93 RID: 11155
			[Token(Token = "0x4002B93")]
			[FieldOffset(Offset = "0xC")]
			public ArtifactComparerRowView Prefab;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerTable__get_Data
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int *piVar2;
		  longlong lVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  uint *puVar7;
		  int iVar8;
		  undefined4 param2_00;
		  int *piVar9;
		  uint uVar10;
		  int iVar11;
		  int *piVar12;
		  longlong local_20;
		  undefined8 local_18;
		  longlong local_10;
		  undefined8 local_8;
		  
		  iVar11 = 0;
		  if (DAT_ram_00a58a07 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArtifactComparerRowView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ArtifactComparerRowView__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ArtifactComparerRowView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_ICollection_ArtifactComparerRowData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IList_ArtifactComparerRowData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactComparerRowView__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactComparerRowView__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactComparerRowView__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ArtifactComparerRowView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58a07 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(param1 + 0x18),
		             Method_System_Collections_Generic_List_ArtifactComparerRowView__GetEnumerator__);
		  local_8 = local_18;
		  local_10 = local_20;
		  local_20 = ZEXT48(&local_10) << 0x20;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_ArtifactComparerRowView__MoveNext__
		                      );
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f5dc47;
		    }
		    if (iVar4 == 0) goto code_r0x80f5dc9d;
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,local_8._4_4_,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar5,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f5dc47:
		  iVar8 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar4) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar4 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_20 = CONCAT44(local_20._4_4_,iVar4);
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		      if (iVar4 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80f5dc9d:
		      DAT_ram_009d3e38 = 0;
		      iVar8 = *(int *)(param1 + 0x18);
		      iVar4 = *(int *)(iVar8 + 0xc);
		      *(undefined4 *)(iVar8 + 0xc) = 0;
		      *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		      if (0 < iVar4) {
		        func_ii_2064(*(undefined4 *)(iVar8 + 8),0,iVar4,0);
		      }
		      piVar6 = *(int **)(param1 + 0x1c);
		      if (piVar6 == (int *)0x0) {
		        return;
		      }
		      piVar2 = (int *)0x0;
		      do {
		        iVar8 = *piVar6;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar10 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8);
		            if (System_Collections_Generic_ICollection_ArtifactComparerRowData__TypeInfo == *piVar9)
		            {
		              puVar7 = (uint *)(iVar8 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x80f5dd8a;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		        }
		        puVar7 = (uint *)func_ii_1080(piVar6,
		                                      System_Collections_Generic_ICollection_ArtifactComparerRowData__TypeInfo
		                                      ,0);
		code_r0x80f5dd8a:
		        iVar8 = (**(code **)((ulonglong)*puVar7 * 4))(piVar6,puVar7[1]);
		        if (iVar8 <= iVar11) {
		          return;
		        }
		        piVar6 = *(int **)(param1 + 0x1c);
		        iVar8 = *piVar6;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar10 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8);
		            if (System_Collections_Generic_IList_ArtifactComparerRowData__TypeInfo == *piVar9) {
		              puVar7 = (uint *)(iVar8 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x80f5de0a;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		        }
		        puVar7 = (uint *)func_ii_1080(piVar6,
		                                      System_Collections_Generic_IList_ArtifactComparerRowData__TypeInfo
		                                      ,0);
		code_r0x80f5de0a:
		        iVar8 = (**(code **)((ulonglong)*puVar7 * 4))(piVar6,iVar11,puVar7[1]);
		        iVar4 = Gameplay_ArtifactComparer_View_ArtifactComparerTable__Awake
		                          (param1,*(undefined4 *)(iVar8 + 8),iVar8);
		        uVar5 = *(undefined4 *)(iVar4 + 0xc);
		        param2_00 = *(undefined4 *)(param1 + 0x10);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        piVar6 = (int *)func_ii_6805(uVar5,param2_00,
		                                     Method_UnityEngine_Object_Instantiate_ArtifactComparerRowView___
		                                    );
		        uVar5 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                          (piVar6,0);
		        UnityEngine_Transform__get_childCount(uVar5,0);
		        uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (piVar6,0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar5,1,0);
		        piVar6[0xb] = iVar8;
		        (**(code **)((ulonglong)*(uint *)(*piVar6 + 0xe0) * 4))
		                  (piVar6,*(undefined4 *)(*piVar6 + 0xe4));
		        piVar9 = *(int **)(param1 + 0x1c);
		        iVar8 = *piVar9;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar10 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8);
		            if (System_Collections_Generic_IList_ArtifactComparerRowData__TypeInfo == *piVar12) {
		              puVar7 = (uint *)(iVar8 + piVar12[1] * 8 + 0xc0);
		              goto code_r0x80f5df06;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		        }
		        puVar7 = (uint *)func_ii_1080(piVar9,
		                                      System_Collections_Generic_IList_ArtifactComparerRowData__TypeInfo
		                                      ,0);
		code_r0x80f5df06:
		        iVar8 = (**(code **)((ulonglong)*puVar7 * 4))(piVar9,iVar11,puVar7[1]);
		        bVar1 = *(int *)(iVar8 + 8) != 1;
		        if (bVar1) {
		          piVar2 = piVar6;
		        }
		        lVar3 = 0;
		        piVar9 = piVar6;
		        if (bVar1) {
		          piVar9 = *(int **)(param1 + 0x1c);
		          iVar8 = *piVar9;
		          if (*(ushort *)(iVar8 + 0xb6) != 0) {
		            uVar10 = 0;
		            do {
		              piVar12 = (int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8);
		              if (System_Collections_Generic_IList_ArtifactComparerRowData__TypeInfo == *piVar12) {
		                puVar7 = (uint *)(iVar8 + piVar12[1] * 8 + 0xc0);
		                goto code_r0x80f5dfa3;
		              }
		              uVar10 = uVar10 + 1;
		            } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		          }
		          puVar7 = (uint *)func_ii_1080(piVar9,
		                                        System_Collections_Generic_IList_ArtifactComparerRowData__TypeInfo
		                                        ,0);
		code_r0x80f5dfa3:
		          iVar8 = (**(code **)((ulonglong)*puVar7 * 4))(piVar9,iVar11,puVar7[1]);
		          piVar9 = piVar2;
		          if (*(int *)(iVar8 + 8) != 5) {
		            local_20 = 0;
		            System_Data_SqlTypes_SqlInt32___ctor
		                      (&local_20,iVar11,Method_System_Nullable_uint___ctor__);
		            lVar3 = local_20;
		          }
		        }
		        *(longlong *)(piVar9 + 9) = lVar3;
		        (**(code **)((ulonglong)*(uint *)(*piVar9 + 0xe8) * 4))
		                  (piVar9,*(undefined4 *)(*piVar9 + 0xec));
		        iVar8 = Method_System_Collections_Generic_List_ArtifactComparerRowView__Add__;
		        iVar4 = *(int *)(param1 + 0x18);
		        *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		        uVar10 = *(uint *)(iVar4 + 0xc);
		        if (uVar10 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		          *(uint *)(iVar4 + 0xc) = uVar10 + 1;
		          *(int **)(*(int *)(iVar4 + 8) + uVar10 * 4 + 0x10) = piVar6;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar4,piVar6,*(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		        }
		        iVar11 = iVar11 + 1;
		        piVar6 = *(int **)(param1 + 0x1c);
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x204,&local_20);
		  iVar11 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar11 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
