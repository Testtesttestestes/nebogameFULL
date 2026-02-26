using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Elements.Filters.GenericFilter
{
	// Token: 0x02000237 RID: 567
	[Token(Token = "0x2000237")]
	public class GenericFilterView : MonoBehaviour
	{
		// Token: 0x140000F1 RID: 241
		// (add) Token: 0x06000E02 RID: 3586 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000E03 RID: 3587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000F1")]
		public event Action<object> SelectedEvent
		{
			[Token(Token = "0x6000E02")]
			[Address(RVA = "0x6095", Offset = "0x6095", VA = "0x6095")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000E03")]
			[Address(RVA = "0x6096", Offset = "0x6096", VA = "0x6096")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E04")]
		[Address(RVA = "0x6097", Offset = "0x6097", VA = "0x6097", Slot = "4")]
		public virtual void Init(IEnumerable<FilterListElement.FilterData> data)
		{
		/* --- GHIDRA: Init ---
		void UI_Elements_Filters_GenericFilter_GenericFilterView__Init
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x20);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar1 + 0x14),0,0);
		  *(undefined1 *)(iVar1 + 0x1c) = 0;
		  UI_Elements_Filters_GenericFilter_GenericFilterView__ListElementClickedEventHandler
		            (param1,param2,1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E05")]
		[Address(RVA = "0x6098", Offset = "0x6098", VA = "0x6098", Slot = "5")]
		protected virtual void ListElementClickedEventHandler(FilterListElement element)
		{
		/* --- GHIDRA: ListElementClickedEventHandler ---
		void UI_Elements_Filters_GenericFilter_GenericFilterView__ListElementClickedEventHandler
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a6398f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a6398f = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(uVar2,param2,0);
		  if (iVar1 == 0) {
		    uVar2 = *(undefined4 *)(param1 + 0x20);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		    if (iVar1 != 0) {
		      iVar1 = *(int *)(param1 + 0x20);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(iVar1 + 0x14),0,0);
		      *(undefined1 *)(iVar1 + 0x1c) = 0;
		    }
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_Component__GetComponent_object_(param2,0);
		    if (iVar1 != 0) {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(param2 + 0x14),1,0);
		      *(undefined1 *)(param2 + 0x1c) = 1;
		    }
		    *(int *)(param1 + 0x20) = param2;
		    if (param3 != 0) {
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar1 = UnityEngine_Component__GetComponent_object_(param2,0);
		      iVar3 = *(int *)(param1 + 0x18);
		      if (iVar1 == 0) {
		        uVar2 = 0;
		        if (iVar3 == 0) {
		          return;
		        }
		      }
		      else {
		        if (iVar3 == 0) {
		          return;
		        }
		        uVar2 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0x24);
		      }
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),uVar2,*(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x6099", Offset = "0x6099", VA = "0x6099")]
		protected void SelectElement(FilterListElement element, bool notify)
		{
		/* --- GHIDRA: SelectElement ---
		void UI_Elements_Filters_GenericFilter_GenericFilterView__SelectElement
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int param2_01;
		  
		  if (DAT_ram_00a63990 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FilterListElement__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FilterListElement__get_Item__);
		    DAT_ram_00a63990 = '\x01';
		  }
		  if (param2 < 0) {
		    UI_Elements_Filters_GenericFilter_GenericFilterView__ListElementClickedEventHandler
		              (param1,0,1,param2);
		    return;
		  }
		  param2_01 = *(int *)(*(int *)(param1 + 0x1c) + 0xc) + -1;
		  if (param2 <= param2_01) {
		    param2_01 = param2;
		  }
		  param2_00 = System_Linq_Enumerable__ToList_object_
		                        (*(int *)(param1 + 0x1c),param2_01,
		                         Method_System_Collections_Generic_List_FilterListElement__get_Item__);
		  UI_Elements_Filters_GenericFilter_GenericFilterView__ListElementClickedEventHandler
		            (param1,param2_00,1,param2);
		  return;
		}
		*/

		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x609A", Offset = "0x609A", VA = "0x609A")]
		public void SelectByIndex(int index)
		{
		/* --- GHIDRA: SelectByIndex ---
		void UI_Elements_Filters_GenericFilter_GenericFilterView__SelectByIndex
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int param2_01;
		  
		  if (DAT_ram_00a63991 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FilterListElement__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FilterListElement__get_Item__);
		    DAT_ram_00a63991 = '\x01';
		  }
		  if (param2 < 0) {
		    UI_Elements_Filters_GenericFilter_GenericFilterView__ListElementClickedEventHandler
		              (param1,0,0,param2);
		    return;
		  }
		  param2_01 = *(int *)(*(int *)(param1 + 0x1c) + 0xc) + -1;
		  if (param2 <= param2_01) {
		    param2_01 = param2;
		  }
		  param2_00 = System_Linq_Enumerable__ToList_object_
		                        (*(int *)(param1 + 0x1c),param2_01,
		                         Method_System_Collections_Generic_List_FilterListElement__get_Item__);
		  UI_Elements_Filters_GenericFilter_GenericFilterView__ListElementClickedEventHandler
		            (param1,param2_00,0,param2);
		  return;
		}
		*/

		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E08")]
		[Address(RVA = "0x609B", Offset = "0x609B", VA = "0x609B")]
		public void SelectByIndexSilent(int index)
		{
		/* --- GHIDRA: SelectByIndexSilent ---
		undefined4
		UI_Elements_Filters_GenericFilter_GenericFilterView__SelectByIndexSilent
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63992 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FilterListElement__get_Item__);
		    DAT_ram_00a63992 = '\x01';
		  }
		  uVar1 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(param1 + 0x1c),param2,
		                     Method_System_Collections_Generic_List_FilterListElement__get_Item__);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E09")]
		[Address(RVA = "0x609C", Offset = "0x609C", VA = "0x609C")]
		public FilterListElement GetElementByIndex(int index)
		{
		/* --- GHIDRA: GetElementByIndex ---
		undefined4
		UI_Elements_Filters_GenericFilter_GenericFilterView__GetElementByIndex(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63993 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FilterListElement__IndexOf__);
		    DAT_ram_00a63993 = '\x01';
		  }
		  uVar1 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                    (*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(param1 + 0x20),
		                     Method_System_Collections_Generic_List_FilterListElement__IndexOf__);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x000041B8 File Offset: 0x000023B8
		[Token(Token = "0x170001DA")]
		public int CurrentIndex
		{
			[Token(Token = "0x6000E0A")]
			[Address(RVA = "0x609D", Offset = "0x609D", VA = "0x609D")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0B")]
		[Address(RVA = "0x609E", Offset = "0x609E", VA = "0x609E")]
		protected void PopulateList(IEnumerable<FilterListElement.FilterData> data)
		{
		/* --- GHIDRA: PopulateList ---
		void UI_Elements_Filters_GenericFilter_GenericFilterView__PopulateList(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63995 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_FilterListElement___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_FilterListElement__TypeInfo);
		    DAT_ram_00a63995 = '\x01';
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

		// Token: 0x06000E0C RID: 3596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0C")]
		[Address(RVA = "0x609F", Offset = "0x609F", VA = "0x609F")]
		public GenericFilterView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Elements_Filters_GenericFilter_GenericFilterView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63996 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SubFilterListElement__TypeInfo);
		    DAT_ram_00a63996 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
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

		}

		// Token: 0x040006EB RID: 1771
		[Token(Token = "0x40006EB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private FilterListElement _listElementPrefab;

		// Token: 0x040006EC RID: 1772
		[Token(Token = "0x40006EC")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x040006EE RID: 1774
		[Token(Token = "0x40006EE")]
		[FieldOffset(Offset = "0x1C")]
		private readonly List<FilterListElement> _listElements;

		// Token: 0x040006EF RID: 1775
		[Token(Token = "0x40006EF")]
		[FieldOffset(Offset = "0x20")]
		protected FilterListElement _selectedElement;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_SelectedEvent ---
		void UI_Elements_Filters_GenericFilter_GenericFilterView__add_SelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6398e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    DAT_ram_00a6398e = '\x01';
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
		void UI_Elements_Filters_GenericFilter_GenericFilterView__remove_SelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  uint uVar1;
		  
		  UI_Elements_Filters_GenericFilter_GenericFilterView__get_CurrentIndex(param1,param2,param1);
		  if (DAT_ram_00a63991 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FilterListElement__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FilterListElement__get_Item__);
		    DAT_ram_00a63991 = '\x01';
		  }
		  uVar1 = *(int *)(*(int *)(param1 + 0x1c) + 0xc) - 1;
		  param2_00 = System_Linq_Enumerable__ToList_object_
		                        (*(int *)(param1 + 0x1c),(int)uVar1 >> 0x1f & uVar1,
		                         Method_System_Collections_Generic_List_FilterListElement__get_Item__);
		  UI_Elements_Filters_GenericFilter_GenericFilterView__ListElementClickedEventHandler
		            (param1,param2_00,0,param1);
		  return;
		}
		*/


		/* --- GHIDRA: get_CurrentIndex ---
		void UI_Elements_Filters_GenericFilter_GenericFilterView__get_CurrentIndex
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  uint uVar3;
		  int iVar4;
		  int param2_00;
		  undefined4 uVar5;
		  int *piVar6;
		  uint *puVar7;
		  undefined4 *puVar8;
		  int iVar9;
		  int iVar10;
		  int *piVar11;
		  int local_24;
		  int **ppiStack_20;
		  undefined8 local_1c;
		  int *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63994 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_FilterListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_FilterListElement__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_FilterListElement__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_FilterListElement__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_FilterListElement_FilterData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_FilterListElement_FilterData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_FilterListElement__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_FilterListElement__Clear__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FilterListElement__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_FilterListElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63994 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_14 = (int *)0x0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_24,param1[7],
		             Method_System_Collections_Generic_List_FilterListElement__GetEnumerator__);
		  local_8 = local_1c;
		  local_24 = 0;
		  ppiStack_20 = (int **)&local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_FilterListElement__MoveNext__
		                      );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x823229a1;
		    }
		    if (iVar4 == 0) goto code_r0x82322a45;
		    DAT_ram_009d3e38 = 0;
		    iVar10 = local_8._4_4_;
		    uVar5 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_FilterListElement__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x82322999:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x823229a1;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar5,param1,
		               *(undefined4 *)(*param1 + 0xec),0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x82322999;
		    if (DAT_ram_00a63989 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Action_FilterListElement__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x82322999;
		      DAT_ram_00a63989 = '\x01';
		    }
		    iVar4 = *(int *)(iVar10 + 0x20);
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 2,iVar4,uVar5,0);
		      uVar2 = System_Action_FilterListElement__TypeInfo;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x82322985:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x823229a1;
		      }
		      if (iVar9 == 0) {
		        param2_00 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        param2_00 = import::env::invoke_iii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar9,
		                               System_Action_FilterListElement__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x82322985;
		        if (param2_00 == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar9,uVar2);
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 != 1) goto code_r0x8232316c;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x823229a1;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar9 = func_ii_4329(iVar10 + 0x20,param2_00,iVar4);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x82322985;
		      bVar1 = iVar4 != iVar9;
		      iVar4 = iVar9;
		    } while (bVar1);
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii
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
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar5,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x823229a1:
		  iVar10 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar10 == iVar4) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar4 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_24 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 != 1) {
		      if (iVar4 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x82322a45:
		      DAT_ram_009d3e38 = 0;
		      iVar10 = param1[7];
		      iVar4 = *(int *)(iVar10 + 0xc);
		      *(undefined4 *)(iVar10 + 0xc) = 0;
		      *(int *)(iVar10 + 0x10) = *(int *)(iVar10 + 0x10) + 1;
		      if (0 < iVar4) {
		        func_ii_2064(*(undefined4 *)(iVar10 + 8),0,iVar4,0);
		      }
		      iVar10 = *param2;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar3 = 0;
		        do {
		          if (System_Collections_Generic_IEnumerable_FilterListElement_FilterData__TypeInfo ==
		              *(int *)(*(int *)(iVar10 + 0x58) + uVar3 * 8)) {
		            puVar7 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar3 * 8 + 4) * 8 + 0xc0)
		            ;
		            goto code_r0x82322aed;
		          }
		          uVar3 = uVar3 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar3);
		      }
		      puVar7 = (uint *)func_ii_1080(param2,
		                                    System_Collections_Generic_IEnumerable_FilterListElement_FilterData__TypeInfo
		                                    ,0);
		code_r0x82322aed:
		      local_14 = (int *)(**(code **)((ulonglong)*puVar7 * 4))(param2,puVar7[1]);
		      local_24 = 0;
		      ppiStack_20 = &local_14;
		code_r0x82322b28:
		      do {
		        piVar6 = local_14;
		        iVar10 = *local_14;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar3 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar3 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		              puVar8 = (undefined4 *)(iVar10 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x82322bbc;
		            }
		            uVar3 = uVar3 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar3);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar8 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x82323000:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8232303a;
		        }
		code_r0x82322bbc:
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_iii(*puVar8,piVar6,puVar8[1]);
		        piVar6 = local_14;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x82323000;
		        if (iVar10 == 0) goto code_r0x82323083;
		        iVar10 = *local_14;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar3 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar3 * 8);
		            if (System_Collections_Generic_IEnumerator_FilterListElement_FilterData__TypeInfo ==
		                *piVar11) {
		              puVar8 = (undefined4 *)(iVar10 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x82322c97;
		            }
		            uVar3 = uVar3 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar3);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar8 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                            System_Collections_Generic_IEnumerator_FilterListElement_FilterData__TypeInfo
		                            ,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x82323032:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8232303a;
		        }
		code_r0x82322c97:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::invoke_iii(*puVar8,piVar6,puVar8[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x82323032;
		        iVar10 = param1[5];
		        iVar4 = param1[4];
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x8232303a;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        piVar6 = (int *)import::env::invoke_iiii
		                                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,iVar4,
		                                   iVar10,Method_UnityEngine_Object_Instantiate_FilterListElement___
		                                  );
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8232303a;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (*(undefined4 *)(*piVar6 + 0xe0),piVar6,uVar5,*(undefined4 *)(*piVar6 + 0xe4));
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8232303a;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Action_FilterListElement__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x8232300a:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8232303a;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar5,param1,
		                   *(undefined4 *)(*param1 + 0xec),0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x8232300a;
		        if (DAT_ram_00a63988 == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&System_Action_FilterListElement__TypeInfo);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x8232300a;
		          DAT_ram_00a63988 = '\x01';
		        }
		        iVar10 = piVar6[8];
		        do {
		          DAT_ram_009d3e38 = 0;
		          iVar4 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 5,iVar10,uVar5,0);
		          uVar2 = System_Action_FilterListElement__TypeInfo;
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x82322fec:
		            DAT_ram_009d3e38 = 0;
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x8232303a;
		          }
		          if (iVar4 == 0) {
		            iVar9 = 0;
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            iVar9 = import::env::invoke_iii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar4,
		                               System_Action_FilterListElement__TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x82322fec;
		            if (iVar9 == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar4,uVar2);
		              iVar10 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar10 != 1) {
		code_r0x8232316c:
		                do {
		                  halt_trap();
		                } while( true );
		              }
		              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x8232303a;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar9 = func_ii_4329(piVar6 + 8,iVar9,iVar10);
		          iVar4 = Method_System_Collections_Generic_List_FilterListElement__Add__;
		          if (DAT_ram_009d3e38 == 1) goto code_r0x82322fec;
		          bVar1 = iVar10 != iVar9;
		          iVar10 = iVar9;
		        } while (bVar1);
		        iVar10 = param1[7];
		        *(int *)(iVar10 + 0x10) = *(int *)(iVar10 + 0x10) + 1;
		        uVar3 = *(uint *)(iVar10 + 0xc);
		        if (uVar3 < *(uint *)(*(int *)(iVar10 + 8) + 0xc)) {
		          *(uint *)(iVar10 + 0xc) = uVar3 + 1;
		          *(int **)(*(int *)(iVar10 + 8) + uVar3 * 4 + 0x10) = piVar6;
		          goto code_r0x82322b28;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar10,piVar6,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar10 != 1);
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8232303a:
		      iVar10 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar10 == iVar4) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		        local_24 = *piVar6;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 != 1) {
		code_r0x82323083:
		          DAT_ram_009d3e38 = 0;
		          piVar6 = *ppiStack_20;
		          if (piVar6 != (int *)0x0) {
		            uVar3 = 0;
		            iVar10 = *piVar6;
		            if (*(ushort *)(iVar10 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar3 * 8)) {
		                  puVar7 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar3 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x823230fe;
		                }
		                uVar3 = uVar3 + 1;
		              } while (*(ushort *)(iVar10 + 0xb6) != uVar3);
		            }
		            puVar7 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x823230fe:
		            (**(code **)((ulonglong)*puVar7 * 4))(piVar6,puVar7[1]);
		          }
		          if (local_24 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(local_24);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          return;
		        }
		        uVar5 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x15,&local_24);
		      goto joined_r0x82323152;
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x14,&local_24);
		joined_r0x82323152:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
