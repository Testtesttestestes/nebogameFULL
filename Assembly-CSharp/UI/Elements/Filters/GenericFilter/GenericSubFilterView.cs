using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Elements.Filters.GenericFilter
{
	// Token: 0x02000238 RID: 568
	[Token(Token = "0x2000238")]
	public class GenericSubFilterView : MonoBehaviour
	{
		// Token: 0x140000F2 RID: 242
		// (add) Token: 0x06000E0D RID: 3597 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000E0E RID: 3598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000F2")]
		public event Action<SubFilterListElement> ClickedEvent
		{
			[Token(Token = "0x6000E0D")]
			[Address(RVA = "0x60A0", Offset = "0x60A0", VA = "0x60A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000E0E")]
			[Address(RVA = "0x60A1", Offset = "0x60A1", VA = "0x60A1")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0F")]
		[Address(RVA = "0x60A2", Offset = "0x60A2", VA = "0x60A2")]
		public void Init(IList<SubFilterListElement.SubFilterData> subFilterData)
		{
		/* --- GHIDRA: Init ---
		void UI_Elements_Filters_GenericFilter_GenericSubFilterView__Init
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63999 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SubFilterListElement__get_Item__);
		    DAT_ram_00a63999 = '\x01';
		  }
		  iVar1 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(param1 + 0x18),param2,
		                     Method_System_Collections_Generic_List_SubFilterListElement__get_Item__);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar1 + 0x14),1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E10")]
		[Address(RVA = "0x60A3", Offset = "0x60A3", VA = "0x60A3")]
		public void SelectByIndexSilent(int index)
		{
		/* --- GHIDRA: SelectByIndexSilent ---
		undefined4
		UI_Elements_Filters_GenericFilter_GenericSubFilterView__SelectByIndexSilent
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6399a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SubFilterListElement__get_Item__);
		    DAT_ram_00a6399a = '\x01';
		  }
		  uVar1 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(param1 + 0x18),param2,
		                     Method_System_Collections_Generic_List_SubFilterListElement__get_Item__);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E11")]
		[Address(RVA = "0x60A4", Offset = "0x60A4", VA = "0x60A4")]
		public SubFilterListElement GetElementByIndex(int index)
		{
			return null;
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E12")]
		[Address(RVA = "0x60A5", Offset = "0x60A5", VA = "0x60A5")]
		private void InstanceClickedEventHandler(SubFilterListElement element)
		{
		/* --- GHIDRA: InstanceClickedEventHandler ---
		void UI_Elements_Filters_GenericFilter_GenericSubFilterView__InstanceClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6399b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SubFilterListElement___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_SubFilterListElement__TypeInfo);
		    DAT_ram_00a6399b = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_SubFilterListElement__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_SubFilterListElement___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E13")]
		[Address(RVA = "0x60A6", Offset = "0x60A6", VA = "0x60A6")]
		public GenericSubFilterView()
		{
		}

		// Token: 0x040006F0 RID: 1776
		[Token(Token = "0x40006F0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SubFilterListElement _listElementPrefab;

		// Token: 0x040006F1 RID: 1777
		[Token(Token = "0x40006F1")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x040006F2 RID: 1778
		[Token(Token = "0x40006F2")]
		[FieldOffset(Offset = "0x18")]
		private List<SubFilterListElement> _instances;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickedEvent ---
		void UI_Elements_Filters_GenericFilter_GenericSubFilterView__add_ClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63997 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SubFilterListElement__TypeInfo);
		    DAT_ram_00a63997 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_SubFilterListElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_SubFilterListElement__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ClickedEvent ---
		void UI_Elements_Filters_GenericFilter_GenericSubFilterView__remove_ClickedEvent
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
		  
		  if (DAT_ram_00a63998 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SubFilterListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SubFilterListElement__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SubFilterListElement__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_SubFilterListElement__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_Filters_GenericFilter_GenericSubFilterView_InstanceClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_SubFilterListElement_SubFilterData__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_SubFilterListElement_SubFilterData__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SubFilterListElement__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SubFilterListElement__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SubFilterListElement__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_SubFilterListElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63998 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_14 = (int *)0x0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_24,*(undefined4 *)(param1 + 0x18),
		             Method_System_Collections_Generic_List_SubFilterListElement__GetEnumerator__);
		  local_8 = local_1c;
		  local_24 = 0;
		  ppiStack_20 = (int **)&local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_SubFilterListElement__MoveNext__
		                      );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x82323e0a;
		    }
		    if (iVar3 == 0) goto code_r0x82323eae;
		    DAT_ram_009d3e38 = 0;
		    iVar10 = local_8._4_4_;
		    uVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_SubFilterListElement__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x82323e02:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x82323e0a;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar4,param1,
		               Method_UI_Elements_Filters_GenericFilter_GenericSubFilterView_InstanceClickedEventHandler__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x82323e02;
		    if (DAT_ram_00a6399d == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Action_SubFilterListElement__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x82323e02;
		      DAT_ram_00a6399d = '\x01';
		    }
		    iVar3 = *(int *)(iVar10 + 0x24);
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 2,iVar3,uVar4,0);
		      uVar11 = System_Action_SubFilterListElement__TypeInfo;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x82323dee:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x82323e0a;
		      }
		      if (iVar8 == 0) {
		        iVar9 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar8,
		                           System_Action_SubFilterListElement__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x82323dee;
		        if (iVar9 == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar8,uVar11);
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 != 1) goto code_r0x82324612;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x82323e0a;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar8 = func_ii_4329(iVar10 + 0x24,iVar9,iVar3);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x82323dee;
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
		code_r0x82323e0a:
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
		code_r0x82323eae:
		      DAT_ram_009d3e38 = 0;
		      iVar10 = *(int *)(param1 + 0x18);
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
		          if (System_Collections_Generic_IEnumerable_SubFilterListElement_SubFilterData__TypeInfo ==
		              *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		            puVar6 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0)
		            ;
		            goto code_r0x82323f56;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		      }
		      puVar6 = (uint *)func_ii_1080(param2,
		                                    System_Collections_Generic_IEnumerable_SubFilterListElement_SubFilterData__TypeInfo
		                                    ,0);
		code_r0x82323f56:
		      local_14 = (int *)(**(code **)((ulonglong)*puVar6 * 4))(param2,puVar6[1]);
		      local_24 = 0;
		      ppiStack_20 = &local_14;
		code_r0x82323f91:
		      do {
		        piVar5 = local_14;
		        iVar10 = *local_14;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar12) {
		              puVar7 = (undefined4 *)(iVar10 + piVar12[1] * 8 + 0xc0);
		              goto code_r0x82324025;
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
		code_r0x823244a6:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x823244e0;
		        }
		code_r0x82324025:
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_iii(*puVar7,piVar5,puVar7[1]);
		        piVar5 = local_14;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x823244a6;
		        if (iVar10 == 0) goto code_r0x82324529;
		        iVar10 = *local_14;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		            if (System_Collections_Generic_IEnumerator_SubFilterListElement_SubFilterData__TypeInfo
		                == *piVar12) {
		              puVar7 = (undefined4 *)(iVar10 + piVar12[1] * 8 + 0xc0);
		              goto code_r0x82324100;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                            System_Collections_Generic_IEnumerator_SubFilterListElement_SubFilterData__TypeInfo
		                            ,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x823244d8:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x823244e0;
		        }
		code_r0x82324100:
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_iii(*puVar7,piVar5,puVar7[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x823244d8;
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
		            goto code_r0x823244e0;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar11,uVar4,
		                           Method_UnityEngine_Object_Instantiate_SubFilterListElement___);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x823244e0;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x62,
		                   *(undefined4 *)(iVar8 + 0x10),*(undefined4 *)(iVar10 + 8),0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x823244ba:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x823244e0;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x107,
		                   *(undefined4 *)(iVar8 + 0x18),*(undefined4 *)(iVar10 + 0xc),0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x823244ba;
		        *(undefined4 *)(iVar8 + 0x20) = *(undefined4 *)(iVar10 + 0x10);
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Action_SubFilterListElement__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x823244b0:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x823244e0;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar4,param1,
		                   Method_UI_Elements_Filters_GenericFilter_GenericSubFilterView_InstanceClickedEventHandler__
		                   ,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x823244b0;
		        if (DAT_ram_00a6399c == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&System_Action_SubFilterListElement__TypeInfo);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x823244b0;
		          DAT_ram_00a6399c = '\x01';
		        }
		        iVar10 = *(int *)(iVar8 + 0x24);
		        do {
		          DAT_ram_009d3e38 = 0;
		          iVar3 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 5,iVar10,uVar4,0);
		          uVar11 = System_Action_SubFilterListElement__TypeInfo;
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x82324492:
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x823244e0;
		          }
		          if (iVar3 == 0) {
		            iVar9 = 0;
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            iVar9 = import::env::invoke_iii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar3,
		                               System_Action_SubFilterListElement__TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x82324492;
		            if (iVar9 == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar3,uVar11);
		              iVar10 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar10 != 1) {
		code_r0x82324612:
		                do {
		                  halt_trap();
		                } while( true );
		              }
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x823244e0;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar9 = func_ii_4329(iVar8 + 0x24,iVar9,iVar10);
		          iVar3 = Method_System_Collections_Generic_List_SubFilterListElement__Add__;
		          if (DAT_ram_009d3e38 == 1) goto code_r0x82324492;
		          bVar1 = iVar10 != iVar9;
		          iVar10 = iVar9;
		        } while (bVar1);
		        iVar10 = *(int *)(param1 + 0x18);
		        *(int *)(iVar10 + 0x10) = *(int *)(iVar10 + 0x10) + 1;
		        uVar2 = *(uint *)(iVar10 + 0xc);
		        if (uVar2 < *(uint *)(*(int *)(iVar10 + 8) + 0xc)) {
		          *(uint *)(iVar10 + 0xc) = uVar2 + 1;
		          *(int *)(*(int *)(iVar10 + 8) + uVar2 * 4 + 0x10) = iVar8;
		          goto code_r0x82323f91;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar10,iVar8,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar10 != 1);
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x823244e0:
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
		code_r0x82324529:
		          DAT_ram_009d3e38 = 0;
		          piVar5 = *ppiStack_20;
		          if (piVar5 != (int *)0x0) {
		            uVar2 = 0;
		            iVar10 = *piVar5;
		            if (*(ushort *)(iVar10 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		                  puVar6 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x823245a4;
		                }
		                uVar2 = uVar2 + 1;
		              } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		            }
		            puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x823245a4:
		            (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		          }
		          if (local_24 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(local_24);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          return;
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x17,&local_24);
		      goto joined_r0x823245f8;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x16,&local_24);
		joined_r0x823245f8:
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
