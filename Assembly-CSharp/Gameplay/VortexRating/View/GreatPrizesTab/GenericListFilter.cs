using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.VortexRating.View.GreatPrizesTab
{
	// Token: 0x0200038D RID: 909
	[Token(Token = "0x200038D")]
	public class GenericListFilter : MonoBehaviour
	{
		// Token: 0x1400010C RID: 268
		// (add) Token: 0x06001527 RID: 5415 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001528 RID: 5416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400010C")]
		public event Action<object> SelectedEvent
		{
			[Token(Token = "0x6001527")]
			[Address(RVA = "0x66E9", Offset = "0x66E9", VA = "0x66E9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001528")]
			[Address(RVA = "0x66EA", Offset = "0x66EA", VA = "0x66EA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001529")]
		[Address(RVA = "0x66EB", Offset = "0x66EB", VA = "0x66EB")]
		public void Init(IList<GenericListFilter.ListFilterData> data)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_VortexRating_View_GreatPrizesTab_GenericListFilter__Init
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(*(int *)(param1 + 0x20) + 0x14),0,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param2 + 0x14),1,0);
		  *(int *)(param1 + 0x20) = param2;
		  iVar1 = *(int *)(param1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2 + 0x20),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600152A")]
		[Address(RVA = "0x66EC", Offset = "0x66EC", VA = "0x66EC")]
		private void ListElementClickedEventHandler(FilterListElement element)
		{
		/* --- GHIDRA: ListElementClickedEventHandler ---
		void Gameplay_VortexRating_View_GreatPrizesTab_GenericListFilter__ListElementClickedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param2 + 0x14),1,0);
		  *(int *)(param1 + 0x20) = param2;
		  iVar1 = *(int *)(param1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2 + 0x20),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600152B")]
		[Address(RVA = "0x66ED", Offset = "0x66ED", VA = "0x66ED")]
		private void SelectElement(FilterListElement element)
		{
		/* --- GHIDRA: SelectElement ---
		void Gameplay_VortexRating_View_GreatPrizesTab_GenericListFilter__SelectElement
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a581b9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_FilterListElement___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_FilterListElement__TypeInfo);
		    DAT_ram_00a581b9 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_FilterListElement__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_FilterListElement___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600152C RID: 5420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600152C")]
		[Address(RVA = "0x66EE", Offset = "0x66EE", VA = "0x66EE")]
		public GenericListFilter()
		{
		}

		// Token: 0x04000B39 RID: 2873
		[Token(Token = "0x4000B39")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private FilterListElement _listElementPrefab;

		// Token: 0x04000B3A RID: 2874
		[Token(Token = "0x4000B3A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04000B3C RID: 2876
		[Token(Token = "0x4000B3C")]
		[FieldOffset(Offset = "0x1C")]
		public readonly List<FilterListElement> ListElements;

		// Token: 0x04000B3D RID: 2877
		[Token(Token = "0x4000B3D")]
		[FieldOffset(Offset = "0x20")]
		private FilterListElement _selectedElement;

		// Token: 0x0200038E RID: 910
		[Token(Token = "0x200038E")]
		public class ListFilterData
		{
			// Token: 0x0600152D RID: 5421 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600152D")]
			[Address(RVA = "0x66EF", Offset = "0x66EF", VA = "0x66EF")]
			public ListFilterData()
			{
			}

			// Token: 0x04000B3E RID: 2878
			[Token(Token = "0x4000B3E")]
			[FieldOffset(Offset = "0x8")]
			public string Title;

			// Token: 0x04000B3F RID: 2879
			[Token(Token = "0x4000B3F")]
			[FieldOffset(Offset = "0xC")]
			public object Data;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_SelectedEvent ---
		void Gameplay_VortexRating_View_GreatPrizesTab_GenericListFilter__add_SelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a581b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    DAT_ram_00a581b7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_object__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_object__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_SelectedEvent ---
		void Gameplay_VortexRating_View_GreatPrizesTab_GenericListFilter__remove_SelectedEvent
		               (int param1,int *param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  uint *puVar6;
		  undefined4 *puVar7;
		  int iVar8;
		  int iVar9;
		  int iVar10;
		  undefined4 uVar11;
		  int *piVar12;
		  int local_24;
		  int **ppiStack_20;
		  undefined8 local_1c;
		  int *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a581b8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_FilterListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_FilterListElement__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_FilterListElement__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_FilterListElement__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_View_GreatPrizesTab_GenericListFilter_ListElementClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_GenericListFilter_ListFilterData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_GenericListFilter_ListFilterData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_FilterListElement__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_FilterListElement__Clear__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FilterListElement__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FilterListElement__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_FilterListElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a581b8 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_14 = (int *)0x0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_24,*(undefined4 *)(param1 + 0x1c),
		             Method_System_Collections_Generic_List_FilterListElement__GetEnumerator__);
		  local_8 = local_1c;
		  local_24 = 0;
		  ppiStack_20 = (int **)&local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_FilterListElement__MoveNext__
		                      );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80eb3748;
		    }
		    if (iVar3 == 0) goto code_r0x80eb37eb;
		    DAT_ram_009d3e38 = 0;
		    iVar10 = local_8._4_4_;
		    uVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_FilterListElement__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80eb3740:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80eb3748;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar4,param1,
		               Method_Gameplay_VortexRating_View_GreatPrizesTab_GenericListFilter_ListElementClickedEventHandler__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80eb3740;
		    if (DAT_ram_00a581b3 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Action_FilterListElement__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80eb3740;
		      DAT_ram_00a581b3 = '\x01';
		    }
		    iVar3 = *(int *)(iVar10 + 0x1c);
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 2,iVar3,uVar4,0);
		      uVar11 = System_Action_FilterListElement__TypeInfo;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80eb372c:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80eb3748;
		      }
		      if (iVar8 == 0) {
		        iVar9 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar8,
		                           System_Action_FilterListElement__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80eb372c;
		        if (iVar9 == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar8,uVar11);
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 != 1) goto code_r0x80eb3f6c;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eb3748;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar8 = func_ii_4329(iVar10 + 0x1c,iVar9,iVar3);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80eb372c;
		      bVar1 = iVar3 != iVar8;
		      iVar3 = iVar8;
		    } while (bVar1);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,iVar10,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar4,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80eb3748:
		  iVar10 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar10 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_24 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80eb37eb:
		      DAT_ram_009d3e38 = 0;
		      iVar10 = *(int *)(param1 + 0x1c);
		      iVar3 = *(int *)(iVar10 + 0xc);
		      *(undefined4 *)(iVar10 + 0xc) = 0;
		      *(int *)(iVar10 + 0x10) = *(int *)(iVar10 + 0x10) + 1;
		      if (0 < iVar3) {
		        func_ii_2064(*(undefined4 *)(iVar10 + 8),0,iVar3,0);
		      }
		      iVar10 = *param2;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          if (System_Collections_Generic_IEnumerable_GenericListFilter_ListFilterData__TypeInfo ==
		              *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		            puVar6 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0)
		            ;
		            goto code_r0x80eb3893;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		      }
		      puVar6 = (uint *)func_ii_1080(param2,
		                                    System_Collections_Generic_IEnumerable_GenericListFilter_ListFilterData__TypeInfo
		                                    ,0);
		code_r0x80eb3893:
		      local_14 = (int *)(**(code **)((ulonglong)*puVar6 * 4))(param2,puVar6[1]);
		      local_24 = 0;
		      ppiStack_20 = &local_14;
		code_r0x80eb38c8:
		      do {
		        piVar5 = local_14;
		        iVar10 = *local_14;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar12) {
		              puVar7 = (undefined4 *)(iVar10 + piVar12[1] * 8 + 0xc0);
		              goto code_r0x80eb395c;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80eb3d9f:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eb3dd9;
		        }
		code_r0x80eb395c:
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_iii(*puVar7,piVar5,puVar7[1]);
		        piVar5 = local_14;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80eb3d9f;
		        if (iVar10 == 0) {
		          iVar10 = 7;
		          goto code_r0x80eb3e67;
		        }
		        iVar10 = *local_14;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		            if (System_Collections_Generic_IEnumerator_GenericListFilter_ListFilterData__TypeInfo ==
		                *piVar12) {
		              puVar7 = (undefined4 *)(iVar10 + piVar12[1] * 8 + 0xc0);
		              goto code_r0x80eb3a37;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                            System_Collections_Generic_IEnumerator_GenericListFilter_ListFilterData__TypeInfo
		                            ,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80eb3dd1:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eb3dd9;
		        }
		code_r0x80eb3a37:
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_iii(*puVar7,piVar5,puVar7[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80eb3dd1;
		        uVar4 = *(undefined4 *)(param1 + 0x14);
		        uVar11 = *(undefined4 *)(param1 + 0x10);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80eb3dd9;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar11,uVar4,
		                           Method_UnityEngine_Object_Instantiate_FilterListElement___);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eb3dd9;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x107,
		                   *(undefined4 *)(iVar8 + 0x10),*(undefined4 *)(iVar10 + 8),0);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eb3dd9;
		        }
		        *(undefined4 *)(iVar8 + 0x20) = *(undefined4 *)(iVar10 + 0xc);
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Action_FilterListElement__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80eb3da9:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eb3dd9;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar4,param1,
		                   Method_Gameplay_VortexRating_View_GreatPrizesTab_GenericListFilter_ListElementClickedEventHandler__
		                   ,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80eb3da9;
		        if (DAT_ram_00a581b2 == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&System_Action_FilterListElement__TypeInfo);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80eb3da9;
		          DAT_ram_00a581b2 = '\x01';
		        }
		        iVar10 = *(int *)(iVar8 + 0x1c);
		        do {
		          DAT_ram_009d3e38 = 0;
		          iVar3 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 5,iVar10,uVar4,0);
		          uVar11 = System_Action_FilterListElement__TypeInfo;
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x80eb3d8b:
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80eb3dd9;
		          }
		          if (iVar3 == 0) {
		            iVar9 = 0;
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            iVar9 = import::env::invoke_iii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar3,
		                               System_Action_FilterListElement__TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80eb3d8b;
		            if (iVar9 == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar3,uVar11);
		              iVar10 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar10 != 1) {
		code_r0x80eb3f6c:
		                do {
		                  halt_trap();
		                } while( true );
		              }
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80eb3dd9;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar9 = func_ii_4329(iVar8 + 0x1c,iVar9,iVar10);
		          iVar3 = Method_System_Collections_Generic_List_FilterListElement__Add__;
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80eb3d8b;
		          bVar1 = iVar10 != iVar9;
		          iVar10 = iVar9;
		        } while (bVar1);
		        iVar10 = *(int *)(param1 + 0x1c);
		        *(int *)(iVar10 + 0x10) = *(int *)(iVar10 + 0x10) + 1;
		        uVar2 = *(uint *)(iVar10 + 0xc);
		        if (uVar2 < *(uint *)(*(int *)(iVar10 + 8) + 0xc)) {
		          *(uint *)(iVar10 + 0xc) = uVar2 + 1;
		          *(int *)(*(int *)(iVar10 + 8) + uVar2 * 4 + 0x10) = iVar8;
		          goto code_r0x80eb38c8;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar10,iVar8,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar10 != 1);
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80eb3dd9:
		      iVar10 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar10 == iVar3) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		        local_24 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 != 1) {
		          iVar10 = 0;
		code_r0x80eb3e67:
		          DAT_ram_009d3e38 = 0;
		          piVar5 = *ppiStack_20;
		          if (piVar5 != (int *)0x0) {
		            uVar2 = 0;
		            iVar3 = *piVar5;
		            if (*(ushort *)(iVar3 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		                  puVar6 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x80eb3ee4;
		                }
		                uVar2 = uVar2 + 1;
		              } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		            }
		            puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x80eb3ee4:
		            (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		          }
		          if (local_24 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(local_24);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if ((iVar10 == 0) ||
		             ((((iVar10 != 1 && (iVar10 != 2)) && (iVar10 != 3)) &&
		              (((iVar10 != 4 && (iVar10 != 5)) && ((iVar10 != 6 && (iVar10 == 7)))))))) {
		            iVar10 = System_Linq_Enumerable__ToList_object_
		                               (*(undefined4 *)(param1 + 0x1c),0,
		                                Method_System_Collections_Generic_List_FilterListElement__get_Item__
		                               );
		            Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                      (*(undefined4 *)(iVar10 + 0x14),1,0);
		            *(int *)(param1 + 0x20) = iVar10;
		            iVar3 = *(int *)(param1 + 0x18);
		            if (iVar3 != 0) {
		              (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                        (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar10 + 0x20),
		                         *(undefined4 *)(iVar3 + 0x14));
		            }
		          }
		          return;
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x123,&local_24);
		      goto joined_r0x80eb3e57;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x122,&local_24);
		joined_r0x80eb3e57:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
