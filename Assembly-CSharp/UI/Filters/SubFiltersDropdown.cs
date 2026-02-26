using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI.Filters
{
	// Token: 0x020001EA RID: 490
	[Token(Token = "0x20001EA")]
	public class SubFiltersDropdown : MonoBehaviour, IDeselectHandler, IEventSystemHandler
	{
		// Token: 0x140000E8 RID: 232
		// (add) Token: 0x06000CAA RID: 3242 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000CAB RID: 3243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000E8")]
		public event Action ChangedEvent
		{
			[Token(Token = "0x6000CAA")]
			[Address(RVA = "0x5FAD", Offset = "0x5FAD", VA = "0x5FAD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000CAB")]
			[Address(RVA = "0x5FAE", Offset = "0x5FAE", VA = "0x5FAE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x00003F00 File Offset: 0x00002100
		[Token(Token = "0x170001A8")]
		private bool AllSelected
		{
			[Token(Token = "0x6000CAC")]
			[Address(RVA = "0x5FAF", Offset = "0x5FAF", VA = "0x5FAF")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x5FB0", Offset = "0x5FB0", VA = "0x5FB0")]
		public void Init(Dictionary<uint, ArtikulTypeFilters> allFilters)
		{
		/* --- GHIDRA: <AdjustFilters>b__23_1 ---
		void UI_Filters_SubFiltersDropdown___AdjustFilters_b__23_1(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6394a == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Filters_SubFiltersDropdown___c_TypeInfo);
		    DAT_ram_00a6394a = '\x01';
		  }
		  uVar1 = unnamed_function_1417(UI_Filters_SubFiltersDropdown___c_TypeInfo);
		  **(undefined4 **)(UI_Filters_SubFiltersDropdown___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: Init ---
		void UI_Filters_SubFiltersDropdown__Init(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int *param1_01;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a6393c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Filters_SubFiltersDropdown_AllToggleChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Filters_SubFiltersDropdown_MetaFiltersChangedEventHandler__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_SubFiltersDropdown_ToggleChangedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    DAT_ram_00a6393c = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_UI_Filters_SubFiltersDropdown_MetaFiltersChangedEventHandler__,0);
		  if (DAT_ram_00a6392e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a6392e = '\x01';
		  }
		  param1_00 = *(int *)(iVar4 + 0x20);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar3 = func_ii_4329(iVar4 + 0x20,param1_01,param1_00);
		    bVar1 = iVar3 == param1_00;
		    param1_00 = iVar3;
		    if (bVar1) {
		      uVar5 = *(undefined4 *)(*(int *)(param1 + 0x28) + 0xc0);
		      uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		      UnityEngine_UI_Toggle__set_group
		                (uVar2,param1,Method_UI_Filters_SubFiltersDropdown_ToggleChangedEventHandler__,0);
		      UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		                (uVar5,uVar2,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		      uVar5 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x2c) + 0x14) + 0xc0);
		      uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		      UnityEngine_UI_Toggle__set_group
		                (uVar2,param1,Method_UI_Filters_SubFiltersDropdown_AllToggleChangedEventHandler__,0)
		      ;
		      UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		                (uVar5,uVar2,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x5FB1", Offset = "0x5FB1", VA = "0x5FB1")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_Filters_SubFiltersDropdown__Awake(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int *param1_01;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a6393d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Filters_SubFiltersDropdown_AllToggleChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Filters_SubFiltersDropdown_MetaFiltersChangedEventHandler__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_SubFiltersDropdown_ToggleChangedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    DAT_ram_00a6393d = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_UI_Filters_SubFiltersDropdown_MetaFiltersChangedEventHandler__,0);
		  if (DAT_ram_00a6392f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a6392f = '\x01';
		  }
		  param1_00 = *(int *)(iVar4 + 0x20);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,uVar2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar3 = func_ii_4329(iVar4 + 0x20,param1_01,param1_00);
		    bVar1 = iVar3 == param1_00;
		    param1_00 = iVar3;
		    if (bVar1) {
		      uVar5 = *(undefined4 *)(*(int *)(param1 + 0x28) + 0xc0);
		      uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		      UnityEngine_UI_Toggle__set_group
		                (uVar2,param1,Method_UI_Filters_SubFiltersDropdown_ToggleChangedEventHandler__,0);
		      UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		                (uVar5,uVar2,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		      uVar5 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x2c) + 0x14) + 0xc0);
		      uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		      UnityEngine_UI_Toggle__set_group
		                (uVar2,param1,Method_UI_Filters_SubFiltersDropdown_AllToggleChangedEventHandler__,0)
		      ;
		      UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		                (uVar5,uVar2,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		      UI_Filters_SubFiltersDropdown__HandleFilterInfo(param1,uVar5);
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x5FB2", Offset = "0x5FB2", VA = "0x5FB2")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Filters_SubFiltersDropdown__OnDestroy(undefined4 param1,undefined4 param2)
		
		{
		  UI_Filters_SubFiltersDropdown__MetaFiltersChangedEventHandler(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x5FB3", Offset = "0x5FB3", VA = "0x5FB3")]
		private void MetaFiltersChangedEventHandler()
		{
		/* --- GHIDRA: MetaFiltersChangedEventHandler ---
		void UI_Filters_SubFiltersDropdown__MetaFiltersChangedEventHandler(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 *puVar6;
		  int iVar7;
		  int *piVar8;
		  int *piVar9;
		  int iVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a6393e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Distinct_uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_ArtikulTypeFilters__uint___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_SelectMany_ArtikulTypeMetaFilterDic__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_uint__ArtikulTypeFilters___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ArtikulTypeFilters___);
		    Mono_Security_ASN1__get_Item(&System_Func_uint__ArtikulTypeFilters__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtikulTypeFilters__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtikulTypeMetaFilterDic__IEnumerable_uint___TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_ICollection_ArtikulTypeFilters__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_ArtikulTypeFilters__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_ArtikulTypeFilters__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_SubFiltersDropdown__AdjustFilters_b__23_1__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_SubFiltersDropdown___c__AdjustFilters_b__23_0__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_SubFiltersDropdown___c__AdjustFilters_b__23_2__)
		    ;
		    Mono_Security_ASN1__get_Item(&UI_Filters_SubFiltersDropdown___c_TypeInfo);
		    DAT_ram_00a6393e = '\x01';
		  }
		  local_4 = (int *)0x0;
		  UI_Filters_SubFiltersDropdown__HandleFilterInfo(param1,0);
		  uVar5 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x1c);
		  if (*(int *)(UI_Filters_SubFiltersDropdown___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UI_Filters_SubFiltersDropdown___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(UI_Filters_SubFiltersDropdown___c_TypeInfo + 0x5c);
		  iVar7 = puVar6[1];
		  if (iVar7 == 0) {
		    if (*(int *)(UI_Filters_SubFiltersDropdown___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UI_Filters_SubFiltersDropdown___c_TypeInfo);
		      puVar6 = *(undefined4 **)(UI_Filters_SubFiltersDropdown___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar6;
		    iVar7 = unnamed_function_1417(System_Func_ArtikulTypeMetaFilterDic__IEnumerable_uint___TypeInfo)
		    ;
		    System_Linq_Enumerable__Where_object_
		              (iVar7,uVar2,Method_UI_Filters_SubFiltersDropdown___c__AdjustFilters_b__23_0__,0);
		    *(int *)(*(int *)(UI_Filters_SubFiltersDropdown___c_TypeInfo + 0x5c) + 4) = iVar7;
		  }
		  uVar5 = System_Linq_Enumerable__SelectMany_ValueTuple_object__object___object_
		                    (uVar5,iVar7,
		                     Method_System_Linq_Enumerable_SelectMany_ArtikulTypeMetaFilterDic__uint___);
		  uVar5 = System_Linq_Enumerable__DefaultIfEmptyIterator___Il2CppFullySharedGenericType_
		                    (uVar5,Method_System_Linq_Enumerable_Distinct_uint___);
		  uVar2 = unnamed_function_1417(System_Func_uint__ArtikulTypeFilters__TypeInfo);
		  System_Linq_Enumerable__Distinct_uint_
		            (uVar2,param1,Method_UI_Filters_SubFiltersDropdown__AdjustFilters_b__23_1__,0);
		  uVar5 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar5,uVar2,Method_System_Linq_Enumerable_Select_uint__ArtikulTypeFilters___);
		  if (*(int *)(UI_Filters_SubFiltersDropdown___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UI_Filters_SubFiltersDropdown___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(UI_Filters_SubFiltersDropdown___c_TypeInfo + 0x5c);
		  iVar7 = puVar6[2];
		  if (iVar7 == 0) {
		    if (*(int *)(UI_Filters_SubFiltersDropdown___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UI_Filters_SubFiltersDropdown___c_TypeInfo);
		      puVar6 = *(undefined4 **)(UI_Filters_SubFiltersDropdown___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar6;
		    iVar7 = unnamed_function_1417(System_Func_ArtikulTypeFilters__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar7,uVar2,Method_UI_Filters_SubFiltersDropdown___c__AdjustFilters_b__23_2__,0);
		    *(int *)(*(int *)(UI_Filters_SubFiltersDropdown___c_TypeInfo + 0x5c) + 8) = iVar7;
		  }
		  uVar1 = 0;
		  uVar5 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar5,iVar7,Method_System_Linq_Enumerable_OrderBy_ArtikulTypeFilters__uint___);
		  uVar5 = func_ii_6295(uVar5,Method_System_Linq_Enumerable_ToArray_ArtikulTypeFilters___);
		  *(undefined4 *)(param1 + 0x34) = uVar5;
		  uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x2c),0);
		  piVar8 = *(int **)(param1 + 0x34);
		  iVar7 = *piVar8;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_ArtikulTypeFilters__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8231deea;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar8,
		                                System_Collections_Generic_ICollection_ArtikulTypeFilters__TypeInfo,
		                                0);
		code_r0x8231deea:
		  uVar1 = 0;
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar8,puVar3[1]);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar5,(uint)(0 < iVar7),0);
		  piVar8 = *(int **)(param1 + 0x34);
		  iVar7 = *piVar8;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_ArtikulTypeFilters__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8231df78;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar8,
		                                System_Collections_Generic_IEnumerable_ArtikulTypeFilters__TypeInfo,
		                                0);
		code_r0x8231df78:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar8,puVar3[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar8 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar6 = (undefined4 *)(iVar7 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x8231e04c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = (uint *)0x0;
		    puVar6 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x8231e1b7:
		      DAT_ram_009d3e38 = (uint *)0x0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8231e1bf;
		    }
		code_r0x8231e04c:
		    DAT_ram_009d3e38 = (uint *)0x0;
		    iVar7 = import::env::invoke_iii(*puVar6,piVar8,puVar6[1]);
		    piVar8 = local_4;
		    if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x8231e1b7;
		    if (iVar7 == 0) {
		      iVar4 = 6;
		      iVar7 = 0;
		      puVar3 = DAT_ram_009d3e38;
		      goto code_r0x8231e20c;
		    }
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_ArtikulTypeFilters__TypeInfo == *piVar9) {
		          puVar6 = (undefined4 *)(iVar7 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x8231e126;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = (uint *)0x0;
		    puVar6 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ArtikulTypeFilters__TypeInfo,0);
		    if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x8231e1a3:
		      DAT_ram_009d3e38 = (uint *)0x0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8231e1bf;
		    }
		code_r0x8231e126:
		    DAT_ram_009d3e38 = (uint *)0x0;
		    uVar5 = import::env::invoke_iii(*puVar6,piVar8,puVar6[1]);
		    iVar7 = (int)DAT_ram_009d3e38;
		    if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x8231e1a3;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    import::env::invoke_viii
		              (s___Scripting__Unity__IO__Archive__ram_00004472 + 0xd,param1,uVar5,iVar7);
		    iVar7 = (int)DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = (uint *)0x0;
		  } while (iVar7 != 1);
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8231e1bf:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar8 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar7 = *piVar8;
		    iVar4 = 0;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    local_c = iVar7;
		    import::env::invoke_v(0x123);
		    puVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    if (puVar3 != (uint *)0x1) {
		code_r0x8231e20c:
		      piVar8 = local_4;
		      DAT_ram_009d3e38 = (uint *)0x0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar10 = *local_4;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x8231e284;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x8231e284:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar8,puVar3[1]);
		      }
		      if (iVar7 == 0) {
		        if ((iVar4 == 0) ||
		           ((((iVar4 != 1 && (iVar4 != 2)) && (iVar4 != 3)) &&
		            (((iVar4 != 4 && (iVar4 != 5)) && (iVar4 == 6)))))) {
		          UI_Filters_SubFiltersDropdown__AdjustFilters(param1,puVar3);
		          uVar2 = *(undefined4 *)(*(int *)(param1 + 0x2c) + 0x14);
		          uVar5 = UI_Filters_SubFiltersDropdown__remove_ChangedEvent(param1,puVar3);
		          func_ii_7603(uVar2,uVar5,0);
		          iVar7 = *(int *)(param1 + 0x44);
		          if (iVar7 != 0) {
		            (**(code **)((ulonglong)*(uint *)(iVar7 + 0xc) * 4))
		                      (*(undefined4 *)(iVar7 + 0x20),*(undefined4 *)(iVar7 + 0x14));
		          }
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = (uint *)0x0;
		  import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0xe,&local_c);
		  iVar7 = (int)DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = (uint *)0x0;
		  if (iVar7 == 1) {
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

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x5FB4", Offset = "0x5FB4", VA = "0x5FB4")]
		public void AdjustFilters()
		{
		/* --- GHIDRA: AdjustFilters ---
		void UI_Filters_SubFiltersDropdown__AdjustFilters(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  int *piVar8;
		  
		  if (DAT_ram_00a6393f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_ICollection_ArtikulTypeFilters__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_ArtikulTypeFilters__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7804);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1238);
		    DAT_ram_00a6393f = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x3c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ArtikulTypeFilters__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8231e5b7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,
		                                System_Collections_Generic_ICollection_ArtikulTypeFilters__TypeInfo,
		                                0);
		code_r0x8231e5b7:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  if (0 < iVar5) {
		    *(undefined4 *)(*(int *)(param1 + 0x48) + 0xc) = *(undefined4 *)(param1 + 0x3c);
		    uVar1 = 0;
		    piVar4 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		    func_ii_2101(piVar4,0);
		    piVar6 = *(int **)(param1 + 0x3c);
		    iVar5 = *piVar6;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_IList_ArtikulTypeFilters__TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8231e669;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar6,
		                                  System_Collections_Generic_IList_ArtikulTypeFilters__TypeInfo,0);
		code_r0x8231e669:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,0,puVar2[1]);
		    uVar3 = Gameplay_Inventory_View_Chest_ArtifactCategoryData___ctor(uVar3,0);
		    func_ii_2010(piVar4,uVar3,0);
		    iVar5 = 1;
		    do {
		      piVar6 = *(int **)(param1 + 0x3c);
		      iVar7 = *piVar6;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_ICollection_ArtikulTypeFilters__TypeInfo == *piVar8) {
		            puVar2 = (uint *)(iVar7 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x8231e6ff;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar6,
		                                    System_Collections_Generic_ICollection_ArtikulTypeFilters__TypeInfo
		                                    ,0);
		code_r0x8231e6ff:
		      iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      if (iVar7 <= iVar5) goto code_r0x8231e7c1;
		      func_ii_2010(piVar4,StringLiteral_1238,0);
		      piVar6 = *(int **)(param1 + 0x3c);
		      iVar7 = *piVar6;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IList_ArtikulTypeFilters__TypeInfo == *piVar8) {
		            puVar2 = (uint *)(iVar7 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x8231e794;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar6,
		                                    System_Collections_Generic_IList_ArtikulTypeFilters__TypeInfo,0)
		      ;
		code_r0x8231e794:
		      uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,iVar5,puVar2[1]);
		      uVar3 = Gameplay_Inventory_View_Chest_ArtifactCategoryData___ctor(uVar3,0);
		      func_ii_2010(piVar4,uVar3,0);
		      iVar5 = iVar5 + 1;
		    } while( true );
		  }
		  *(undefined4 *)(*(int *)(param1 + 0x48) + 0xc) = *(undefined4 *)(param1 + 0x34);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_7804,1,0,1,0,0,0,0);
		code_r0x8231e816:
		  uVar1 = 0;
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(param1 + 0x1c),uVar3,0);
		  iVar5 = *(int *)(param1 + 0x48);
		  piVar4 = *(int **)(param1 + 0x34);
		  iVar7 = *piVar4;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_ArtikulTypeFilters__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8231e89e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,
		                                System_Collections_Generic_ICollection_ArtikulTypeFilters__TypeInfo,
		                                0);
		code_r0x8231e89e:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  *(bool *)(iVar5 + 0x10) = 0 < iVar7;
		  return;
		code_r0x8231e7c1:
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xd8) * 4))
		                    (piVar4,*(undefined4 *)(*piVar4 + 0xdc));
		  goto code_r0x8231e816;
		}
		*/

		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x5FB5", Offset = "0x5FB5", VA = "0x5FB5")]
		private void HandleFilterInfo()
		{
		/* --- GHIDRA: HandleFilterInfo ---
		void UI_Filters_SubFiltersDropdown__HandleFilterInfo(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param3;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  int param2_00;
		  undefined4 uVar5;
		  int *piVar6;
		  uint *puVar7;
		  int iVar8;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63940 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SimpleToggleWithData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SimpleToggleWithData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SimpleToggleWithData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_SimpleToggleWithData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_ICollection_ArtikulTypeFilters__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SimpleToggleWithData__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SimpleToggleWithData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_SubFiltersDropdown_ToggleEventHandler__);
		    DAT_ram_00a63940 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x40) = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(param1 + 0x38),
		             Method_System_Collections_Generic_List_SimpleToggleWithData__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_SimpleToggleWithData__MoveNext__
		                      );
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8231da9a;
		    }
		    if (iVar3 == 0) goto code_r0x8231db4a;
		    DAT_ram_009d3e38 = 0;
		    iVar8 = local_8._4_4_;
		    uVar5 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_SimpleToggleWithData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8231da92:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8231da9a;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar5,param1,
		               Method_UI_Filters_SubFiltersDropdown_ToggleEventHandler__,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8231da92;
		    if (DAT_ram_00a63936 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Action_SimpleToggleWithData__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8231da92;
		      DAT_ram_00a63936 = '\x01';
		    }
		    iVar3 = *(int *)(iVar8 + 0x20);
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 2,iVar3,uVar5,0);
		      param3 = System_Action_SimpleToggleWithData__TypeInfo;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x8231da7e:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8231da9a;
		      }
		      if (iVar4 == 0) {
		        param2_00 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        param2_00 = import::env::invoke_iii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar4,
		                               System_Action_SimpleToggleWithData__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x8231da7e;
		        if (param2_00 == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar4,param3);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8231da9a;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = func_ii_4329(iVar8 + 0x20,param2_00,iVar3);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8231da7e;
		      bVar1 = iVar3 != iVar4;
		      iVar3 = iVar4;
		    } while (bVar1);
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,iVar8,0)
		    ;
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
		code_r0x8231da9a:
		  iVar8 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar3) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar3 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x8231db4a:
		      DAT_ram_009d3e38 = 0;
		      iVar8 = *(int *)(param1 + 0x38);
		      iVar3 = *(int *)(iVar8 + 0xc);
		      *(undefined4 *)(iVar8 + 0xc) = 0;
		      *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		      if (0 < iVar3) {
		        func_ii_2064(*(undefined4 *)(iVar8 + 8),0,iVar3,0);
		      }
		      piVar6 = *(int **)(param1 + 0x3c);
		      iVar8 = *piVar6;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          if (System_Collections_Generic_ICollection_ArtikulTypeFilters__TypeInfo ==
		              *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		            puVar7 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + iVar8 + 0xd8);
		            goto code_r0x8231dbf3;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		      }
		      puVar7 = (uint *)func_ii_1080(piVar6,
		                                    System_Collections_Generic_ICollection_ArtikulTypeFilters__TypeInfo
		                                    ,3);
		code_r0x8231dbf3:
		      (**(code **)((ulonglong)*puVar7 * 4))(piVar6,puVar7[1]);
		      return;
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0xc,&local_20);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
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

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB3")]
		[Address(RVA = "0x5FB6", Offset = "0x5FB6", VA = "0x5FB6")]
		private void DestroyAllToggles()
		{
		/* --- GHIDRA: DestroyAllToggles ---
		void UI_Filters_SubFiltersDropdown__DestroyAllToggles
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  
		  func_ii_17536(param1,param2,param1);
		  UI_Filters_SubFiltersDropdown__AdjustFilters(param1,param1);
		  param1_00 = *(undefined4 *)(*(int *)(param1 + 0x2c) + 0x14);
		  param2_00 = UI_Filters_SubFiltersDropdown__remove_ChangedEvent(param1,param1);
		  func_ii_7603(param1_00,param2_00,0);
		  iVar1 = *(int *)(param1 + 0x44);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x5FB7", Offset = "0x5FB7", VA = "0x5FB7")]
		private void ToggleEventHandler(SimpleToggleWithData toggle)
		{
		/* --- GHIDRA: ToggleEventHandler ---
		void UI_Filters_SubFiltersDropdown__ToggleEventHandler
		               (undefined4 param1,int param2,uint param3,undefined4 param4)
		
		{
		  if (param3 != (*(char *)(*(int *)(param2 + 0x14) + 0xc4) != '\0')) {
		    func_ii_7603(*(int *)(param2 + 0x14),param3,0);
		    func_ii_17536(param1,param2,param2);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB5")]
		[Address(RVA = "0x5FB8", Offset = "0x5FB8", VA = "0x5FB8")]
		private void ChangeToggleSilent(SimpleToggleWithData toggle, bool enable)
		{
		/* --- GHIDRA: ChangeToggleSilent ---
		void UI_Filters_SubFiltersDropdown__ChangeToggleSilent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a63942 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_EventSystems_EventSystem_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63942 = '\x01';
		  }
		  if (param2 != 0) {
		    if (*(int *)(UnityEngine_EventSystems_EventSystem_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_EventSystems_EventSystem_TypeInfo);
		    }
		    iVar1 = UnityEngine_EventSystems_PointerEventData__ToString(0);
		    uVar3 = *(undefined4 *)(iVar1 + 0x24);
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar3,uVar2,0);
		    if (iVar1 != 0) {
		      if (*(int *)(UnityEngine_EventSystems_EventSystem_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_EventSystems_EventSystem_TypeInfo);
		      }
		      uVar2 = UnityEngine_EventSystems_PointerEventData__ToString(0);
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		      UnityEngine_EventSystems_EventSystem__get_baseEventDataCache(uVar2,uVar3,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0x4481", Offset = "0x4481", VA = "0x4481")]
		private void ToggleSilent(SimpleToggleWithData toggle)
		{
		/* --- GHIDRA: ToggleSilent ---
		int * UI_Filters_SubFiltersDropdown__ToggleSilent(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0x5FB9", Offset = "0x5FB9", VA = "0x5FB9")]
		private void ToggleChangedEventHandler(bool enable)
		{
		/* --- GHIDRA: ToggleChangedEventHandler ---
		void UI_Filters_SubFiltersDropdown__ToggleChangedEventHandler
		               (int param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 param1_00;
		  int iVar4;
		  undefined1 auStack_20 [8];
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63943 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SimpleToggleWithData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SimpleToggleWithData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_SimpleToggleWithData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SimpleToggleWithData__GetEnumerator__);
		    DAT_ram_00a63943 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x38),
		             Method_System_Collections_Generic_List_SimpleToggleWithData__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar1 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_SimpleToggleWithData__MoveNext__
		                        );
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8231ecc8;
		      }
		      if (iVar1 == 0) goto code_r0x8231ed1e;
		      iVar4 = local_8._4_4_;
		    } while ((*(char *)(*(int *)(local_8._4_4_ + 0x14) + 0xc4) != '\0') == param2);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x22d,
		               *(int *)(local_8._4_4_ + 0x14),param2,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s___Scripting__Unity__IO__Archive__ram_00004472 + 0xf,param1,iVar4,auStack_20);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8231ecc8:
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
		code_r0x8231ed1e:
		      DAT_ram_009d3e38 = 0;
		      UI_Filters_SubFiltersDropdown__AdjustFilters(param1,auStack_20);
		      param1_00 = *(undefined4 *)(*(int *)(param1 + 0x2c) + 0x14);
		      uVar2 = UI_Filters_SubFiltersDropdown__remove_ChangedEvent(param1,auStack_20);
		      func_ii_7603(param1_00,uVar2,0);
		      iVar4 = *(int *)(param1 + 0x44);
		      if (iVar4 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                  (*(undefined4 *)(iVar4 + 0x20),*(undefined4 *)(iVar4 + 0x14));
		      }
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x10,&local_18);
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

		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0x5FBA", Offset = "0x5FBA", VA = "0x5FBA")]
		private void AllToggleChangedEventHandler(bool enable)
		{
		/* --- GHIDRA: AllToggleChangedEventHandler ---
		void UI_Filters_SubFiltersDropdown__AllToggleChangedEventHandler(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  
		  UI_Filters_SubFiltersDropdown__AdjustFilters(param1,param1);
		  param1_00 = *(undefined4 *)(*(int *)(param1 + 0x2c) + 0x14);
		  param2_00 = UI_Filters_SubFiltersDropdown__remove_ChangedEvent(param1,param1);
		  func_ii_7603(param1_00,param2_00,0);
		  iVar1 = *(int *)(param1 + 0x44);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0x5FBB", Offset = "0x5FBB", VA = "0x5FBB")]
		private void ApplyFilters()
		{
		/* --- GHIDRA: ApplyFilters ---
		void UI_Filters_SubFiltersDropdown__ApplyFilters
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63944 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Filters_SubFiltersDropdown___c__DisplayClass32_0__OnDeselect_b__0__);
		    Mono_Security_ASN1__get_Item(&UI_Filters_SubFiltersDropdown___c__DisplayClass32_0_TypeInfo);
		    DAT_ram_00a63944 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(UI_Filters_SubFiltersDropdown___c__DisplayClass32_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(undefined4 *)(param2_00 + 8) = param1;
		  param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (param1_00,param2_00,
		             Method_UI_Filters_SubFiltersDropdown___c__DisplayClass32_0__OnDeselect_b__0__,0);
		  DG_Tweening_DOVirtual__EasedValue(0.0,param1_00,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0x5FBC", Offset = "0x5FBC", VA = "0x5FBC", Slot = "4")]
		public void OnDeselect(BaseEventData eventData)
		{
		/* --- GHIDRA: OnDeselect ---
		void UI_Filters_SubFiltersDropdown__OnDeselect(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a63945 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_EventSystems_EventSystem_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63945 = '\x01';
		  }
		  uVar1 = UnityEngine_EventSystems_BaseEventData__get_currentInputModule(param2,0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = func_ii_3812(uVar1,0,0);
		  if (iVar2 == 0) {
		    uVar1 = UnityEngine_EventSystems_BaseEventData__get_currentInputModule(param2,0);
		    iVar2 = UI_Filters_SubFiltersDropdown__HandleSelectedObject(param1,uVar1,param2);
		    if (iVar2 != 0) {
		      uVar1 = UnityEngine_EventSystems_BaseEventData__get_currentInputModule(param2,0);
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar1,uVar3,0);
		      if (iVar2 != 0) {
		        if (*(int *)(UnityEngine_EventSystems_EventSystem_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_EventSystems_EventSystem_TypeInfo);
		        }
		        uVar1 = UnityEngine_EventSystems_PointerEventData__ToString(0);
		        uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (param1,0);
		        UnityEngine_EventSystems_EventSystem__get_baseEventDataCache(uVar1,uVar3,0);
		      }
		      return;
		    }
		  }
		  UnityEngine_UI_Toggle__get_isOn(*(undefined4 *)(param1 + 0x28),0,0);
		  return;
		}
		*/

		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x5FBD", Offset = "0x5FBD", VA = "0x5FBD")]
		private void HandleSelectedObject(BaseEventData eventData)
		{
		/* --- GHIDRA: HandleSelectedObject ---
		undefined4
		UI_Filters_SubFiltersDropdown__HandleSelectedObject
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param2_00;
		  int iVar2;
		  
		  if (DAT_ram_00a63946 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63946 = '\x01';
		  }
		  param1_00 = UnityEngine_UI_Selectable__set_interactable(param2,0);
		  while( true ) {
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,0,0);
		    if (iVar1 == 0) {
		      return 0;
		    }
		    param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                          (param1,0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar2 = func_ii_3812(param1_00,param2_00,0);
		    if (iVar2 != 0) break;
		    param1_00 = UnityEngine_Transform__set_parent(param1_00,0);
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x5FBE", Offset = "0x5FBE", VA = "0x5FBE")]
		private bool AnyParent(GameObject obj)
		{
		/* --- GHIDRA: AnyParent ---
		void UI_Filters_SubFiltersDropdown__AnyParent(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63947 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ArtikulTypeFilters___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__ArtikulTypeFilters__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Filters_FilterInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SimpleToggleWithData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtikulTypeFilters___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtikulTypeFilters__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_SimpleToggleWithData__TypeInfo);
		    DAT_ram_00a63947 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_uint__ArtikulTypeFilters__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar1,Method_System_Collections_Generic_Dictionary_uint__ArtikulTypeFilters___ctor__);
		  *(undefined4 *)(param1 + 0x30) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_SimpleToggleWithData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_SimpleToggleWithData___ctor__);
		  *(undefined4 *)(param1 + 0x38) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_ArtikulTypeFilters__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_ArtikulTypeFilters___ctor__);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  uVar1 = unnamed_function_1417(UI_Filters_FilterInfo_TypeInfo);
		  *(undefined4 *)(param1 + 0x48) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x5FBF", Offset = "0x5FBF", VA = "0x5FBF")]
		public SubFiltersDropdown()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 UI_Filters_SubFiltersDropdown___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63948 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ArtikulTypeFilters__get_Item__);
		    DAT_ram_00a63948 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1 + 0x30),param2,
		                     Method_System_Collections_Generic_Dictionary_uint__ArtikulTypeFilters__get_Item__
		                    );
		  return uVar1;
		}
		*/

		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x447F", Offset = "0x447F", VA = "0x447F")]
		[CompilerGenerated]
		private void <AdjustFilters>g__CreateAndAddToggle|23_3(ArtikulTypeFilters filter)
		{
		}

		// Token: 0x0400062A RID: 1578
		[Token(Token = "0x400062A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private MetaFiltersView _metaFiltersView;

		// Token: 0x0400062B RID: 1579
		[Token(Token = "0x400062B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SimpleToggleWithData _togglePrefab;

		// Token: 0x0400062C RID: 1580
		[Token(Token = "0x400062C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _content;

		// Token: 0x0400062D RID: 1581
		[Token(Token = "0x400062D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x0400062E RID: 1582
		[Token(Token = "0x400062E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _lightBg;

		// Token: 0x0400062F RID: 1583
		[Token(Token = "0x400062F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _darkBg;

		// Token: 0x04000630 RID: 1584
		[Token(Token = "0x4000630")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Toggle _toggle;

		// Token: 0x04000631 RID: 1585
		[Token(Token = "0x4000631")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private SimpleToggleWithData _allToggle;

		// Token: 0x04000632 RID: 1586
		[Token(Token = "0x4000632")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<uint, ArtikulTypeFilters> _allFilters;

		// Token: 0x04000633 RID: 1587
		[Token(Token = "0x4000633")]
		[FieldOffset(Offset = "0x34")]
		private IList<ArtikulTypeFilters> _availableFilters;

		// Token: 0x04000634 RID: 1588
		[Token(Token = "0x4000634")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<SimpleToggleWithData> _availableToggles;

		// Token: 0x04000635 RID: 1589
		[Token(Token = "0x4000635")]
		[FieldOffset(Offset = "0x3C")]
		private readonly IList<ArtikulTypeFilters> _activeFilters;

		// Token: 0x04000636 RID: 1590
		[Token(Token = "0x4000636")]
		[FieldOffset(Offset = "0x40")]
		private int _index;

		// Token: 0x04000638 RID: 1592
		[Token(Token = "0x4000638")]
		[FieldOffset(Offset = "0x48")]
		public readonly FilterInfo FilterInfo;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ChangedEvent ---
		void UI_Filters_SubFiltersDropdown__add_ChangedEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a6393a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a6393a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x44,param1_01,param1_00);
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


		/* --- GHIDRA: remove_ChangedEvent ---
		uint UI_Filters_SubFiltersDropdown__remove_ChangedEvent(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a6393b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_ICollection_ArtikulTypeFilters__TypeInfo);
		    DAT_ram_00a6393b = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x34);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ArtikulTypeFilters__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8231d3d1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,
		                                System_Collections_Generic_ICollection_ArtikulTypeFilters__TypeInfo,
		                                0);
		code_r0x8231d3d1:
		  uVar1 = 0;
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  piVar3 = *(int **)(param1 + 0x3c);
		  iVar5 = *piVar3;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_ArtikulTypeFilters__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8231d456;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,
		                                System_Collections_Generic_ICollection_ArtikulTypeFilters__TypeInfo,
		                                0);
		code_r0x8231d456:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  return (uint)(iVar5 == iVar4);
		}
		*/

}
