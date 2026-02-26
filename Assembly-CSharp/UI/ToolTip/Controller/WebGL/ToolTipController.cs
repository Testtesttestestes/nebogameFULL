using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ToolTip.Controller.WebGL
{
	// Token: 0x0200016C RID: 364
	[Token(Token = "0x200016C")]
	public class ToolTipController : BaseToolTipController
	{
		// Token: 0x06000A26 RID: 2598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x5D7D", Offset = "0x5D7D", VA = "0x5D7D")]
		public ToolTipController(Canvas canvas, RectTransform layer, Vector2 padding)
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Controller_Android_ToolTipController___ctor
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  int *piVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int param1_00;
		  uint uVar7;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a5999f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_IToolTipDataProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_IToolTipSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IToolTipSource__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IToolTipSource__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IToolTipSource__Contains__)
		    ;
		    DAT_ram_00a5999f = '\x01';
		  }
		  if (param2 == (int *)param1[4]) {
		    uVar7 = 0;
		    uVar4 = UI_ToolTip_Controller_Android_ToolTipController__Hide(param1,0);
		    uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar4,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,0,0);
		    iVar3 = *param2;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (UI_ToolTip_IToolTipSource_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8)) {
		          puVar1 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8109c546;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar7);
		    }
		    puVar1 = (uint *)func_ii_1080(param2,UI_ToolTip_IToolTipSource_TypeInfo,0);
		code_r0x8109c546:
		    piVar2 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		    uVar7 = 0;
		    iVar3 = *piVar2;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (UI_ToolTip_IToolTipDataProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8)
		           ) {
		          puVar1 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8109c5c6;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar7);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar2,UI_ToolTip_IToolTipDataProvider_TypeInfo,0);
		code_r0x8109c5c6:
		    piVar2 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(piVar2,puVar1[1]);
		    iVar6 = *piVar2;
		    uVar4 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0xf0) * 4))
		                      (piVar2,param1[6],*(undefined4 *)(iVar6 + 0xf4));
		    iVar3 = func_ii_5677(uVar4,Method_UnityEngine_Component_GetComponent_RectTransform___);
		    param1[5] = iVar3;
		    uVar4 = UI_ToolTip_Controller_Android_ToolTipController__HideAwait(param1,iVar6);
		    uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar4,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar5,1,0);
		    UnityEngine_Transform__get_childCount(uVar4,0);
		    if (DAT_ram_00a59999 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__Add__);
		      DAT_ram_00a59999 = '\x01';
		    }
		    if (DAT_ram_00a59998 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 UI_ToolTip_Controller_BaseToolTipController__UpdateToolTipPositionCoroutine_d__22_TypeInfo
		                );
		      DAT_ram_00a59998 = '\x01';
		    }
		    iVar6 = unnamed_function_1417
		                      (
		                      UI_ToolTip_Controller_BaseToolTipController__UpdateToolTipPositionCoroutine_d__22_TypeInfo
		                      );
		    *(int **)(iVar6 + 0x14) = param1;
		    *(undefined4 *)(iVar6 + 8) = 0;
		    *(int *)(iVar6 + 0x10) = iVar3;
		    uVar4 = Utils_CoroutineSource__GetMono(iVar6,0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (param1[2],param2,uVar4,
		               Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__Add__);
		    iVar3 = param1[0xc];
		    iVar6 = *(int *)(iVar3 + 0xc);
		    *(undefined4 *)(iVar3 + 0xc) = 0;
		    *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		    if (0 < iVar6) {
		      func_ii_2064(*(undefined4 *)(iVar3 + 8),0,iVar6,0);
		    }
		    iVar3 = param1[3];
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),param1[4],*(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  else {
		    iVar3 = func_ii_4685(param1[0xc],param2,
		                         Method_System_Collections_Generic_List_IToolTipSource__Contains__);
		    if (iVar3 == 0) {
		      iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1[5],0);
		      if (iVar3 != 0) {
		        (**(code **)((ulonglong)*(uint *)(*param1 + 0x118) * 4))
		                  (param1,param1[4],*(undefined4 *)(*param1 + 0x11c));
		      }
		      iVar3 = Method_System_Collections_Generic_List_IToolTipSource__Add__;
		      iVar6 = param1[4];
		      param1_00 = param1[0xc];
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar7 = *(uint *)(param1_00 + 0xc);
		      if (uVar7 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		        *(uint *)(param1_00 + 0xc) = uVar7 + 1;
		        *(int *)(*(int *)(param1_00 + 8) + uVar7 * 4 + 0x10) = iVar6;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,iVar6,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		      }
		      param1[4] = (int)param2;
		      local_8 = 0;
		      local_10 = 0;
		      local_18 = 0;
		      local_20 = 0;
		      uVar4 = UI_ToolTip_Controller_Android_ToolTipController__Hide(param1,param1_00);
		      uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (uVar4,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar5,1,0);
		      (**(code **)((ulonglong)*(uint *)(*param1 + 0x120) * 4))
		                (param1,&local_10,*(undefined4 *)(*param1 + 0x124));
		      UI_ToolTip_Controller_BaseToolTipController__GetContentSize
		                (param1,&local_10,uVar4,&local_20,uVar4);
		      local_28 = local_18;
		      local_30 = local_20;
		      UnityEngine_Transform__get_position(uVar4,&local_30,0);
		    }
		  }
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Controller_WebGL_ToolTipController___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  UI_ToolTip_Controller_BaseToolTipController___ctor(param1,param2,param1);
		  uVar1 = *(undefined4 *)(param1 + 0x14);
		  if (DAT_ram_00a59999 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__Add__);
		    DAT_ram_00a59999 = '\x01';
		  }
		  if (DAT_ram_00a59998 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_ToolTip_Controller_BaseToolTipController__UpdateToolTipPositionCoroutine_d__22_TypeInfo
		              );
		    DAT_ram_00a59998 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        UI_ToolTip_Controller_BaseToolTipController__UpdateToolTipPositionCoroutine_d__22_TypeInfo
		                        );
		  *(int *)(param1_00 + 0x14) = param1;
		  *(undefined4 *)(param1_00 + 8) = 0;
		  *(undefined4 *)(param1_00 + 0x10) = uVar1;
		  uVar1 = Utils_CoroutineSource__GetMono(param1_00,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (*(undefined4 *)(param1 + 8),param2,uVar1,
		             Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__Add__);
		  return;
		}
		*/

		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x5D7E", Offset = "0x5D7E", VA = "0x5D7E", Slot = "10")]
		public override void Show(IToolTipSource source)
		{
		/* --- GHIDRA: Show ---
		void UI_ToolTip_Controller_Android_ToolTipController__Show(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a599a0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IToolTipSource__Remove__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a599a0 = '\x01';
		  }
		  if (param2 == *(int *)(param1 + 0x10)) {
		    uVar1 = UI_ToolTip_Controller_Android_ToolTipController__Hide(param1,param1);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    iVar2 = func_ii_7305(uVar1,0);
		    if (iVar2 == 0) {
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x14),0);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      UnityEngine_Application__get_isPlaying(uVar1,0);
		      if (DAT_ram_00a5999a == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__Remove__
		                  );
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__get_Item__
		                  );
		        DAT_ram_00a5999a = '\x01';
		      }
		      uVar1 = System_Data_DataRelationCollection__Add
		                        (*(undefined4 *)(param1 + 8),param2,
		                         Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__get_Item__
		                        );
		      System_Linq_Enumerable__First_KeyValuePair_object__object__
		                (*(undefined4 *)(param1 + 8),param2,
		                 Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__Remove__);
		      func_ii_7950(uVar1,0);
		    }
		    uVar1 = UI_ToolTip_Controller_Android_ToolTipController__Hide(param1,param1);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    uVar1 = UI_ToolTip_Controller_Android_ToolTipController__HideAwait(param1,param1);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    *(undefined8 *)(param1 + 0x10) = 0;
		  }
		  func_ii_4876(*(undefined4 *)(param1 + 0x30),param2,
		               Method_System_Collections_Generic_List_IToolTipSource__Remove__);
		  return;
		}
		*/

		/* --- GHIDRA: Show ---
		void UI_ToolTip_Controller_WebGL_ToolTipController__Show
		               (undefined4 param1,undefined4 *param2,undefined4 param3)
		
		{
		  undefined1 local_8 [8];
		  
		  if (DAT_ram_00a5999c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_InputSystem_InputControl_Vector2__ReadValue__);
		    DAT_ram_00a5999c = '\x01';
		  }
		  if (DAT_ram_00a5a202 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_InputSystem_Pointer_TypeInfo);
		    DAT_ram_00a5a202 = '\x01';
		  }
		  UnityEngine_InputSystem_InputControl_Vector2___ReadUnprocessedValue
		            (local_8,*(undefined4 *)
		                      (**(int **)(UnityEngine_InputSystem_Pointer_TypeInfo + 0x5c) + 0xe8),
		             Method_UnityEngine_InputSystem_InputControl_Vector2__ReadValue__);
		  param2[2] = 0;
		  param2[1] = local_8._4_4_;
		  *param2 = local_8._0_4_;
		  return;
		}
		*/

		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x5D7F", Offset = "0x5D7F", VA = "0x5D7F", Slot = "12")]
		protected override void GetPointerPosition(out Vector3 position)
		{
		/* --- GHIDRA: GetPointerPosition ---
		void UI_ToolTip_Controller_Android_ToolTipController__GetPointerPosition
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a599a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a599a4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
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

		/* --- GHIDRA: GetPointerPosition ---
		void UI_ToolTip_Controller_WebGL_ToolTipController__GetPointerPosition(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int param3;
		  
		  if (DAT_ram_00a5999d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_MonoPointerClickHandler___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IToolTipSource__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ToolTip_Controller_Android_ToolTipController_HandleOverlapPointerDownEvent__
		              );
		    DAT_ram_00a5999d = '\x01';
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x38),0);
		  if (iVar1 != 0) {
		    param1_00 = func_ii_5677(*(undefined4 *)(param1 + 0x38),
		                             Method_UnityEngine_Component_GetComponent_MonoPointerClickHandler___);
		    param1_01 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_01,param1,
		               Method_UI_ToolTip_Controller_Android_ToolTipController_HandleOverlapPointerDownEvent__
		               ,0);
		    Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(param1_00,param1_01,0);
		  }
		  iVar1 = *(int *)(param1 + 0x30);
		  param3 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < param3) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,param3,0);
		  }
		  *(undefined8 *)(param1 + 0x10) = 0;
		  *(undefined8 *)(param1 + 0x34) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x30")]
		private Tweener _tweener;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: Dispose ---
		void UI_ToolTip_Controller_Android_ToolTipController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined8 *param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined8 uVar2;
		  
		  if (DAT_ram_00a5999e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_AddComponent_GraphicRaycaster___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IToolTipSource___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IToolTipSource__TypeInfo);
		    DAT_ram_00a5999e = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_IToolTipSource__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_IToolTipSource___ctor__);
		  *(undefined4 *)(param1 + 0x30) = uVar1;
		  uVar2 = *param4;
		  if (DAT_ram_00a59995 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__TypeInfo);
		    DAT_ram_00a59995 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar1,Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine___ctor__);
		  *(undefined4 *)(param1 + 8) = uVar1;
		  *(undefined8 *)(param1 + 0x28) = 0x41a0000041a00000;
		  *(undefined8 *)(param1 + 0x20) = uVar2;
		  *(undefined4 *)(param1 + 0x18) = param3;
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param3,0);
		  UnityEngine_GameObject__GetComponent_object_
		            (uVar1,Method_UnityEngine_GameObject_AddComponent_GraphicRaycaster___);
		  return;
		}
		*/


		/* --- GHIDRA: Hide ---
		undefined4 UI_ToolTip_Controller_Android_ToolTipController__Hide(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a599a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_RectTransform___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Resources_Load_RectTransform___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12523);
		    DAT_ram_00a599a1 = '\x01';
		  }
		  if (*(int *)(param1 + 0x34) != 0) {
		    return *(undefined4 *)(param1 + 0x34);
		  }
		  uVar1 = UnityEngine_Resources__GetBuiltinResource_object_
		                    (StringLiteral_12523,Method_UnityEngine_Resources_Load_RectTransform___);
		  param2_00 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar1 = func_ii_6805(uVar1,param2_00,Method_UnityEngine_Object_Instantiate_RectTransform___);
		  *(undefined4 *)(param1 + 0x34) = uVar1;
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GetAwaitAnimation ---
		void UI_ToolTip_Controller_Android_ToolTipController__GetAwaitAnimation
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  param1_00 = UI_ToolTip_Controller_Android_ToolTipController__Hide(param1,&local_30);
		  param1_01 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1_00,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_01,1,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x120) * 4))
		            (param1,&local_10,*(undefined4 *)(*param1 + 0x124));
		  UI_ToolTip_Controller_BaseToolTipController__GetContentSize
		            (param1,&local_10,param1_00,&local_20,&local_30);
		  local_28 = local_18;
		  local_30 = local_20;
		  UnityEngine_Transform__get_position(param1_00,&local_30,0);
		  return;
		}
		*/


		/* --- GHIDRA: ShowAwait ---
		void UI_ToolTip_Controller_Android_ToolTipController__ShowAwait(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = UI_ToolTip_Controller_Android_ToolTipController__Hide(param1,param1);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/


		/* --- GHIDRA: HideAwait ---
		undefined4 UI_ToolTip_Controller_Android_ToolTipController__HideAwait(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined8 local_60;
		  undefined4 local_58;
		  undefined8 local_50;
		  undefined8 local_48;
		  undefined8 local_40;
		  ulonglong local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  uint local_18;
		  undefined8 local_10;
		  uint local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a599a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_Image___);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_GameObject_GetComponent_MonoPointerClickHandler___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_RectTransform___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_GameObject_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_UI_Image_var);
		    Mono_Security_ASN1__get_Item(&Utils_MonoPointerClickHandler_var);
		    Mono_Security_ASN1__get_Item(&UnityEngine_RectTransform_var);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ToolTip_Controller_Android_ToolTipController_HandleOverlapPointerDownEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Type___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16362);
		    DAT_ram_00a599a2 = '\x01';
		  }
		  if (*(int *)(param1 + 0x38) == 0) {
		    piVar1 = (int *)Mono_Security_ASN1Convert__ToOid(System_Type___TypeInfo,3);
		    uVar4 = UnityEngine_RectTransform_var;
		    if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a669a0);
		    }
		    iVar2 = func_ii_2734(uVar4,0);
		    if ((iVar2 != 0) && (iVar3 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20)), iVar3 == 0)) {
		      uVar4 = func_ii_1083();
		      func_ii_1050(uVar4,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar1[4] = iVar2;
		    iVar2 = func_ii_2734(UnityEngine_UI_Image_var,0);
		    if ((iVar2 != 0) && (iVar3 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20)), iVar3 == 0)) {
		      uVar4 = func_ii_1083();
		      func_ii_1050(uVar4,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar1[5] = iVar2;
		    iVar2 = func_ii_2734(Utils_MonoPointerClickHandler_var,0);
		    if ((iVar2 != 0) && (iVar3 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20)), iVar3 == 0)) {
		      uVar4 = func_ii_1083();
		      func_ii_1050(uVar4,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar1[6] = iVar2;
		    uVar4 = unnamed_function_1417(UnityEngine_GameObject_TypeInfo);
		    func_ii_8020(uVar4,StringLiteral_16362,piVar1,0);
		    piVar1 = (int *)func_ii_6601(uVar4,Method_UnityEngine_GameObject_GetComponent_Image___);
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x170) * 4))
		              (&local_10,piVar1,*(undefined4 *)(*piVar1 + 0x174));
		    local_18 = local_8;
		    local_20 = local_10;
		    local_4 = 0;
		    local_38 = (ulonglong)local_8;
		    local_40 = local_10;
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x178) * 4))
		              (piVar1,&local_40,*(undefined4 *)(*piVar1 + 0x17c));
		    param1_00 = func_ii_6601(uVar4,
		                             Method_UnityEngine_GameObject_GetComponent_MonoPointerClickHandler___);
		    param1_01 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_01,param1,
		               Method_UI_ToolTip_Controller_Android_ToolTipController_HandleOverlapPointerDownEvent__
		               ,0);
		    Utils_MoneyUtils__StringToResourcesSet(param1_00,param1_01,0);
		    uVar4 = func_ii_6601(uVar4,Method_UnityEngine_GameObject_GetComponent_RectTransform___);
		    *(undefined4 *)(param1 + 0x38) = uVar4;
		    UnityEngine_Transform__GetParent(uVar4,*(undefined4 *)(param1 + 0x18),0);
		    uVar4 = *(undefined4 *)(param1 + 0x38);
		    if (DAT_ram_00a65d40 == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Vector2_TypeInfo);
		      DAT_ram_00a65d40 = '\x01';
		    }
		    local_48 = **(undefined8 **)(UnityEngine_Vector2_TypeInfo + 0x5c);
		    local_28 = local_48;
		    UnityEngine_RectTransform__get_anchorMin(uVar4,&local_48,0);
		    uVar4 = *(undefined4 *)(param1 + 0x38);
		    if (DAT_ram_00a65d3f == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Vector2_TypeInfo);
		      DAT_ram_00a65d3f = '\x01';
		    }
		    local_50 = *(undefined8 *)(*(int *)(UnityEngine_Vector2_TypeInfo + 0x5c) + 8);
		    local_30 = local_50;
		    UnityEngine_RectTransform__get_anchorMax(uVar4,&local_50,0);
		    Core_Extensions_TransformExt__ToTransformData(*(undefined4 *)(param1 + 0x38),0.0,0);
		    Core_Extensions_TransformExt__SetLeft(*(undefined4 *)(param1 + 0x38),0.0,0);
		    Core_Extensions_TransformExt__SetRight(*(undefined4 *)(param1 + 0x38),0.0,0);
		    Core_Extensions_TransformExt__SetTop(*(undefined4 *)(param1 + 0x38),0.0,0);
		    uVar4 = *(undefined4 *)(param1 + 0x38);
		    if (DAT_ram_00a6501f == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		      DAT_ram_00a6501f = '\x01';
		    }
		    local_58 = *(undefined4 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0x14);
		    local_60 = *(undefined8 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0xc);
		    Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar4,&local_60,0);
		  }
		  return *(undefined4 *)(param1 + 0x38);
		}
		*/


		/* --- GHIDRA: GetOverlap ---
		void UI_ToolTip_Controller_Android_ToolTipController__GetOverlap
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x118) * 4))
		            (param1,param1[4],*(undefined4 *)(*param1 + 0x11c));
		  return;
		}
		*/


		/* --- GHIDRA: HandleOverlapPointerDownEvent ---
		void UI_ToolTip_Controller_Android_ToolTipController__HandleOverlapPointerDownEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  param1_00 = UI_ToolTip_Controller_Android_ToolTipController__HideAwait(param1,param1);
		  param1_01 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1_00,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_01,1,0);
		  UnityEngine_Transform__get_childCount(param1_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: ShowOverlap ---
		void UI_ToolTip_Controller_Android_ToolTipController__ShowOverlap
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = UI_ToolTip_Controller_Android_ToolTipController__HideAwait(param1,param1);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/


		/* --- GHIDRA: HideOverlap ---
		void UI_ToolTip_Controller_Android_ToolTipController__HideOverlap
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a599a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_IToolTipSource_TypeInfo);
		    DAT_ram_00a599a3 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (UI_ToolTip_IToolTipSource_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 200);
		        goto code_r0x8109cf1b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,UI_ToolTip_IToolTipSource_TypeInfo,1);
		code_r0x8109cf1b:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  return;
		}
		*/

}
