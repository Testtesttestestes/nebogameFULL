using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace UI.Filters
{
	// Token: 0x020001E6 RID: 486
	[Token(Token = "0x20001E6")]
	public class MetaFiltersView : MonoBehaviour
	{
		// Token: 0x140000E6 RID: 230
		// (add) Token: 0x06000C8F RID: 3215 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000C90 RID: 3216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000E6")]
		public event Action ChangedEvent
		{
			[Token(Token = "0x6000C8F")]
			[Address(RVA = "0x5F92", Offset = "0x5F92", VA = "0x5F92")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000C90")]
			[Address(RVA = "0x5F93", Offset = "0x5F93", VA = "0x5F93")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A3")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x6000C91")]
			[Address(RVA = "0x5F94", Offset = "0x5F94", VA = "0x5F94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C92")]
			[Address(RVA = "0x5F95", Offset = "0x5F95", VA = "0x5F95")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x00003EA0 File Offset: 0x000020A0
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A4")]
		public ArtikulTypeFilters.Types.FilterType FilterType
		{
			[Token(Token = "0x6000C93")]
			[Address(RVA = "0x5F96", Offset = "0x5F96", VA = "0x5F96")]
			[CompilerGenerated]
			get
			{
				return ArtikulTypeFilters.Types.FilterType.UnknownFilterType;
			}
			[Token(Token = "0x6000C94")]
			[Address(RVA = "0x5F97", Offset = "0x5F97", VA = "0x5F97")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C95")]
		[Address(RVA = "0x5F98", Offset = "0x5F98", VA = "0x5F98")]
		public void Init(ArtikulTypeFilters.Types.FilterType type, Dictionary<uint, ArtikulTypeFilters> allFilters)
		{
		/* --- GHIDRA: Init ---
		void UI_Filters_MetaFiltersView__Init(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int param1_00;
		  uint uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a63931 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Filters_AbstractFilterToggleView_MetaFilterData_ArtikulTypeMetaFilterDic__ArtikulTypeFilters___get_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Filters_AbstractFilterToggleView_MetaFilterData_ArtikulTypeMetaFilterDic__ArtikulTypeFilters___get_IsOn__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__ArtikulTypeMetaFilterDic__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtikulTypeMetaFilterDic__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtikulTypeMetaFilterDic__Remove__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtikulTypeMetaFilterDic__get_Count__);
		    DAT_ram_00a63931 = '\x01';
		  }
		  iVar1 = Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorItemView__get_SkillId
		                    (param2,
		                     Method_UI_Filters_AbstractFilterToggleView_MetaFilterData_ArtikulTypeMetaFilterDic__ArtikulTypeFilters___get_IsOn__
		                    );
		  param1_00 = *(int *)(param1 + 0x1c);
		  param2_00 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(param1 + 0x18),
		                         *(undefined4 *)(*(int *)(*(int *)(param2 + 0x18) + 8) + 0xc),
		                         Method_System_Collections_Generic_Dictionary_uint__ArtikulTypeMetaFilterDic__get_Item__
		                        );
		  iVar3 = Method_System_Collections_Generic_List_ArtikulTypeMetaFilterDic__Add__;
		  if (iVar1 == 0) {
		    func_ii_4876(param1_00,param2_00,
		                 Method_System_Collections_Generic_List_ArtikulTypeMetaFilterDic__Remove__);
		  }
		  else {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param2_00;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,param2_00,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38)
		                );
		    }
		  }
		  *(bool *)(*(int *)(param1 + 0x24) + 0x10) = 0 < *(int *)(*(int *)(param1 + 0x1c) + 0xc);
		  iVar3 = *(int *)(param1 + 0x20);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x5F99", Offset = "0x5F99", VA = "0x5F99")]
		private void FilterToggleClickedEventHandler(AbstractFilterToggleView<MetaFilterData<ArtikulTypeMetaFilterDic, ArtikulTypeFilters>> view)
		{
		/* --- GHIDRA: FilterToggleClickedEventHandler ---
		void UI_Filters_MetaFiltersView__FilterToggleClickedEventHandler(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63932 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtikulTypeMetaFilterDic___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_ArtikulTypeMetaFilterDic__TypeInfo);
		    DAT_ram_00a63932 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_ArtikulTypeMetaFilterDic__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_ArtikulTypeMetaFilterDic___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C97")]
		[Address(RVA = "0x5F9A", Offset = "0x5F9A", VA = "0x5F9A")]
		public MetaFiltersView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Filters_MetaFiltersView___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63933 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Filters_MetaFiltersView___c_TypeInfo);
		    DAT_ram_00a63933 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(UI_Filters_MetaFiltersView___c_TypeInfo);
		  **(undefined4 **)(UI_Filters_MetaFiltersView___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04000618 RID: 1560
		[Token(Token = "0x4000618")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private MetaFilterToggleView _filterPrefab;

		// Token: 0x04000619 RID: 1561
		[Token(Token = "0x4000619")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _contentParent;

		// Token: 0x0400061A RID: 1562
		[Token(Token = "0x400061A")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, ArtikulTypeMetaFilterDic> _selectedMetaFilters;

		// Token: 0x0400061B RID: 1563
		[Token(Token = "0x400061B")]
		[FieldOffset(Offset = "0x1C")]
		public readonly List<ArtikulTypeMetaFilterDic> ActiveMetaFilters;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ChangedEvent ---
		void UI_Filters_MetaFiltersView__add_ChangedEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a6392f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a6392f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x20,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_FilterType ---
		void UI_Filters_MetaFiltersView__set_FilterType
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 *puVar8;
		  undefined4 uVar9;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63930 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Filters_AbstractFilterToggleView_MetaFilterData_ArtikulTypeMetaFilterDic__ArtikulTypeFilters___add_FilterToggleClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Action_AbstractFilterToggleView_MetaFilterData_ArtikulTypeMetaFilterDic__ArtikulTypeFilters____TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__ArtikulTypeMetaFilterDic__get_Values__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Distinct_uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_ArtikulTypeFilters__uint___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderBy_ArtikulTypeMetaFilterDic__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_uint__ArtikulTypeFilters___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ArtikulTypeFilters___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToDictionary_ArtikulTypeMetaFilterDic__uint___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__ArtikulTypeMetaFilterDic__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__ArtikulTypeMetaFilterDic__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__ArtikulTypeMetaFilterDic__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&UI_Filters_FilterInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtikulTypeMetaFilterDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_uint__ArtikulTypeFilters__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtikulTypeFilters__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Filters_MetaFilterData_ArtikulTypeMetaFilterDic__ArtikulTypeFilters___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&UI_Filters_MetaFilterData_ArtikulTypeMetaFilterDic__ArtikulTypeFilters__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Filters_MetaFiltersView_FilterToggleClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_MetaFilterToggleView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_MetaFiltersView___c__Init_b__15_0__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_MetaFiltersView___c__Init_b__15_1__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_MetaFiltersView___c__Init_b__15_3__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Filters_MetaFiltersView___c__DisplayClass15_0__Init_b__2__);
		    Mono_Security_ASN1__get_Item(&UI_Filters_MetaFiltersView___c__DisplayClass15_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Filters_MetaFiltersView___c_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__ArtikulTypeMetaFilterDic__GetEnumerator__
		              );
		    DAT_ram_00a63930 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar2 = unnamed_function_1417(UI_Filters_MetaFiltersView___c__DisplayClass15_0_TypeInfo);
		  *(undefined4 *)(iVar2 + 8) = param3;
		  *(undefined4 *)(param1 + 0x28) = param2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x8231c6bb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8231c6bb:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar4 = Core_Extensions_Dict_DictExt__GetString(uVar4,param2,0);
		  if (*(int *)(UI_Filters_MetaFiltersView___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UI_Filters_MetaFiltersView___c_TypeInfo);
		  }
		  puVar8 = *(undefined4 **)(UI_Filters_MetaFiltersView___c_TypeInfo + 0x5c);
		  iVar7 = puVar8[1];
		  if (iVar7 == 0) {
		    if (*(int *)(UI_Filters_MetaFiltersView___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UI_Filters_MetaFiltersView___c_TypeInfo);
		      puVar8 = *(undefined4 **)(UI_Filters_MetaFiltersView___c_TypeInfo + 0x5c);
		    }
		    uVar9 = *puVar8;
		    iVar7 = unnamed_function_1417(System_Func_ArtikulTypeMetaFilterDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar7,uVar9,Method_UI_Filters_MetaFiltersView___c__Init_b__15_0__,0);
		    *(int *)(*(int *)(UI_Filters_MetaFiltersView___c_TypeInfo + 0x5c) + 4) = iVar7;
		  }
		  uVar4 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar4,iVar7,
		                     Method_System_Linq_Enumerable_OrderBy_ArtikulTypeMetaFilterDic__uint___);
		  if (*(int *)(UI_Filters_MetaFiltersView___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UI_Filters_MetaFiltersView___c_TypeInfo);
		  }
		  puVar8 = *(undefined4 **)(UI_Filters_MetaFiltersView___c_TypeInfo + 0x5c);
		  iVar7 = puVar8[2];
		  if (iVar7 == 0) {
		    if (*(int *)(UI_Filters_MetaFiltersView___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UI_Filters_MetaFiltersView___c_TypeInfo);
		      puVar8 = *(undefined4 **)(UI_Filters_MetaFiltersView___c_TypeInfo + 0x5c);
		    }
		    uVar9 = *puVar8;
		    iVar7 = unnamed_function_1417(System_Func_ArtikulTypeMetaFilterDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar7,uVar9,Method_UI_Filters_MetaFiltersView___c__Init_b__15_1__,0);
		    *(int *)(*(int *)(UI_Filters_MetaFiltersView___c_TypeInfo + 0x5c) + 8) = iVar7;
		  }
		  uVar4 = System_Linq_Enumerable__ToDictionary_object__object_
		                    (uVar4,iVar7,
		                     Method_System_Linq_Enumerable_ToDictionary_ArtikulTypeMetaFilterDic__uint___);
		  *(undefined4 *)(param1 + 0x18) = uVar4;
		  uVar4 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (uVar4,
		                     Method_System_Collections_Generic_Dictionary_uint__ArtikulTypeMetaFilterDic__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_20,uVar4,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__ArtikulTypeMetaFilterDic__GetEnumerator__
		            );
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__ArtikulTypeMetaFilterDic__MoveNext__
		                      );
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8231cd90;
		    }
		    if (iVar5 == 0) goto code_r0x8231cde6;
		    uVar4 = *(undefined4 *)(param1 + 0x14);
		    uVar9 = *(undefined4 *)(param1 + 0x10);
		    iVar7 = local_8._4_4_;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8231cd90;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar6 = (int *)import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar9,uVar4,
		                               Method_UnityEngine_Object_Instantiate_MetaFilterToggleView___);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8231cd90;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       UI_Filters_MetaFilterData_ArtikulTypeMetaFilterDic__ArtikulTypeFilters__TypeInfo
		                      );
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8231cd2c:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8231cd90;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (s___Scripting__Unity__IO__Archive__ram_00004472 + 7,iVar5,
		               Method_UI_Filters_MetaFilterData_ArtikulTypeMetaFilterDic__ArtikulTypeFilters___ctor__
		              );
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8231cd2c;
		    *(int *)(iVar5 + 8) = iVar7;
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s___Scripting__Unity__IO__Archive__ram_00004472 + 8,
		                       *(undefined4 *)(iVar7 + 0x18),Method_System_Linq_Enumerable_Distinct_uint___)
		    ;
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8231cd90;
		    }
		    iVar7 = *(int *)(iVar2 + 0xc);
		    if (iVar7 == 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Func_uint__ArtikulTypeFilters__TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s___Scripting__Unity__IO__Archive__ram_00004472 + 9,iVar7,iVar2,
		                   Method_UI_Filters_MetaFiltersView___c__DisplayClass15_0__Init_b__2__,0);
		        if (DAT_ram_009d3e38 != 1) {
		          *(int *)(iVar2 + 0xc) = iVar7;
		          goto code_r0x8231ca5c;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8231cd90;
		    }
		code_r0x8231ca5c:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iiii
		                      (s___Scripting__Unity__IO__Archive__ram_00004472 + 10,uVar4,iVar7,
		                       Method_System_Linq_Enumerable_Select_uint__ArtikulTypeFilters___);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8231cd4a:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8231cd90;
		    }
		    if (*(int *)(UI_Filters_MetaFiltersView___c_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 UI_Filters_MetaFiltersView___c_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8231cd4a;
		    }
		    puVar8 = *(undefined4 **)(UI_Filters_MetaFiltersView___c_TypeInfo + 0x5c);
		    iVar7 = puVar8[3];
		    if (iVar7 == 0) {
		      if (*(int *)(UI_Filters_MetaFiltersView___c_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   UI_Filters_MetaFiltersView___c_TypeInfo);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8231cd90;
		        }
		        puVar8 = *(undefined4 **)(UI_Filters_MetaFiltersView___c_TypeInfo + 0x5c);
		      }
		      uVar9 = *puVar8;
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Func_ArtikulTypeFilters__uint__TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x76,iVar7,uVar9,
		                   Method_UI_Filters_MetaFiltersView___c__Init_b__15_3__,0);
		        if (DAT_ram_009d3e38 != 1) {
		          *(int *)(*(int *)(UI_Filters_MetaFiltersView___c_TypeInfo + 0x5c) + 0xc) = iVar7;
		          goto code_r0x8231cbaf;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8231cd90;
		    }
		code_r0x8231cbaf:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x77,uVar4,iVar7,
		                       Method_System_Linq_Enumerable_OrderBy_ArtikulTypeFilters__uint___);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8231cd90;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0xd0,uVar4,
		                       Method_System_Linq_Enumerable_ToArray_ArtikulTypeFilters___);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8231cd7e:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8231cd90;
		    }
		    *(undefined4 *)(iVar5 + 0xc) = uVar4;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(*piVar6 + 0xe8),piVar6,iVar5,*(undefined4 *)(*piVar6 + 0xec));
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8231cd7e;
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_AbstractFilterToggleView_MetaFilterData_ArtikulTypeMetaFilterDic__ArtikulTypeFilters____TypeInfo
		                      );
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar4,param1,
		               Method_UI_Filters_MetaFiltersView_FilterToggleClickedEventHandler__,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x4c,piVar6,uVar4,
		               Method_UI_Filters_AbstractFilterToggleView_MetaFilterData_ArtikulTypeMetaFilterDic__ArtikulTypeFilters___add_FilterToggleClickedEvent__
		              );
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8231cd90:
		  iVar2 = global_1;
		  iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar7) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar7 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar7;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		      if (iVar7 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x8231cde6:
		      DAT_ram_009d3e38 = 0;
		      iVar2 = unnamed_function_1417(UI_Filters_FilterInfo_TypeInfo);
		      *(undefined4 *)(iVar2 + 0xc) = *(undefined4 *)(param1 + 0x1c);
		      *(int *)(param1 + 0x24) = iVar2;
		      return;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0xb,&local_20);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
