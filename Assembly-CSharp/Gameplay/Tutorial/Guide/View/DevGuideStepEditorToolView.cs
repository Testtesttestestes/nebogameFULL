using System;
using System.Globalization;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gameplay.Tutorial.Guide.View
{
	// Token: 0x02000457 RID: 1111
	[Token(Token = "0x2000457")]
	public class DevGuideStepEditorToolView : MonoBehaviourWithStates<DevGuideStepEditorToolView.DevGuideStepEditorToolViewStates>, IDragHandler, IEventSystemHandler, IBeginDragHandler
	{
		// Token: 0x06001A4D RID: 6733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4D")]
		[Address(RVA = "0x6BE4", Offset = "0x6BE4", VA = "0x6BE4")]
		private void OnDestroy()
		{
		/* --- GHIDRA: <FillForm>b__38_3 ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView___FillForm_b__38_3(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5843f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView___c_TypeInfo);
		    DAT_ram_00a5843f = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <FillForm>b__38_2 ---
		undefined4
		Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView___FillForm_b__38_2
		          (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  param1_00 = *(undefined4 *)(param2 + 8);
		  iVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  uVar2 = Protocol_Combat_ProtoPlayerActionEvt___ctor(*(int *)(iVar1 + 0x28) + 8,0);
		  uVar2 = System_Collections_CollectionBase___ctor(param1_00,uVar2,0);
		  return uVar2;
		}
		*/

		/* --- GHIDRA: <FillForm>b__38_1 ---
		undefined4
		Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView___FillForm_b__38_1
		          (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5843e == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_OverlapType_TypeInfo);
		    DAT_ram_00a5843e = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param2 + 8);
		  iVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  local_8 = 0xffffffff;
		  local_c = Gameplay_Tutorial_Guide_Model_OverlapType_TypeInfo;
		  local_4 = *(undefined4 *)(*(int *)(iVar1 + 0x24) + 0xc);
		  uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  uVar2 = System_Collections_CollectionBase___ctor(param1_00,uVar2,0);
		  return uVar2;
		}
		*/

		/* --- GHIDRA: <FillForm>b__38_0 ---
		undefined4
		Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView___FillForm_b__38_0
		          (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5843d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_TargetPointerShape_TypeInfo);
		    DAT_ram_00a5843d = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param2 + 8);
		  iVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  local_8 = 0xffffffff;
		  local_c = Gameplay_Tutorial_Guide_Model_TargetPointerShape_TypeInfo;
		  local_4 = *(undefined4 *)(*(int *)(iVar1 + 0x24) + 8);
		  uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  uVar2 = System_Collections_CollectionBase___ctor(param1_00,uVar2,0);
		  return uVar2;
		}
		*/

		/* --- GHIDRA: OnDestroy ---
		/* WARNING: Type propagation algorithm not settling */
		
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 *puVar7;
		  int iVar8;
		  undefined4 param2_00;
		  uint uVar9;
		  int *piVar10;
		  int *piVar11;
		  undefined4 local_50;
		  undefined8 local_4c;
		  undefined4 local_44;
		  undefined8 local_40;
		  int local_38 [4];
		  undefined8 local_28;
		  int local_20 [4];
		  undefined8 local_10;
		  int *local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58434 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_BubbleMessageLayoutChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleAngleChanged__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleGetValuesButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleGraphicPointerIdChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleGraphicPointerOffsetXChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleGraphicPointerOffsetYChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleGraphicPointerScaleXChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleGraphicPointerScaleYChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleMessageBlockXChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleMessageBlockYChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleOutlineScaleChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleOverlapChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleShadeAlphaChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleShapeChanged__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleShapeToggleChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleTargetPointerOffsetXChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleTargetPointerOffsetYChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleTargetPointerScaleXChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleTargetPointerScaleYChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_string__TMP_Dropdown_OptionData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_TMP_Dropdown_OptionData___);
		    Mono_Security_ASN1__get_Item(&System_Func_string__TMP_Dropdown_OptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_TutorialUIPointerDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TMP_Dropdown_OptionData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TMP_Dropdown_OptionData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TMP_Dropdown_OptionData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_TMP_Dropdown_OptionData__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&TMPro_TMP_Dropdown_OptionData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&TMPro_TMP_Dropdown_OptionData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_OverlapType_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_TutorialUIPointerDic__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_TutorialUIPointerDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_AprDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_AprDic__get_Item__);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_View_MessageBubbleView_State_var);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_TargetPointerShape_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView___c__Start_b__25_0__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_float__AddListener__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_int__AddListener__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1739);
		    DAT_ram_00a58434 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = (int *)0x0;
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x6c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleGetValuesButtonClickEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar2,0);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x2c) + 0xc0);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (uVar2,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleShapeToggleChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0xd8);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_int__TypeInfo);
		  UnityEngine_Events_UnityAction_Color___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_BubbleMessageLayoutChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_int__AddListener__);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x24) + 0xd0);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_float__TypeInfo);
		  UnityEngine_Events_UnityAction_Scene___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleMessageBlockYChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_float__AddListener__);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x28) + 0xd0);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_float__TypeInfo);
		  UnityEngine_Events_UnityAction_Scene___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleMessageBlockXChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_float__AddListener__);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x30) + 0xd8);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_int__TypeInfo);
		  UnityEngine_Events_UnityAction_Color___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleShapeChanged__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_int__AddListener__);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x34) + 0xd8);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_int__TypeInfo);
		  UnityEngine_Events_UnityAction_Color___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleOverlapChanged__,0
		            );
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_int__AddListener__);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x54) + 0xd8);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_int__TypeInfo);
		  UnityEngine_Events_UnityAction_Color___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleGraphicPointerIdChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_int__AddListener__);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x58) + 0xd0);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_float__TypeInfo);
		  UnityEngine_Events_UnityAction_Scene___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleAngleChanged__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_float__AddListener__);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x5c) + 0x130);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar2,param1,
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleGraphicPointerOffsetXChanged__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x60) + 0x130);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar2,param1,
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleGraphicPointerOffsetYChanged__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x40) + 0xd0);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_float__TypeInfo);
		  UnityEngine_Events_UnityAction_Scene___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleTargetPointerScaleXChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_float__AddListener__);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x44) + 0xd0);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_float__TypeInfo);
		  UnityEngine_Events_UnityAction_Scene___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleTargetPointerScaleYChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_float__AddListener__);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x48) + 0xd0);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_float__TypeInfo);
		  UnityEngine_Events_UnityAction_Scene___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleOutlineScaleChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_float__AddListener__);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x38) + 0xd0);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_float__TypeInfo);
		  UnityEngine_Events_UnityAction_Scene___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleShadeAlphaChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_float__AddListener__);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x4c) + 0x130);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar2,param1,
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleTargetPointerOffsetXChanged__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x50) + 0x130);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar2,param1,
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleTargetPointerOffsetYChanged__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 100) + 0x130);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar2,param1,
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleGraphicPointerScaleXChanged__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x68) + 0x130);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar2,param1,
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleGraphicPointerScaleYChanged__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar6,uVar2,Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		  uVar2 = Gameplay_TutorialV2_View_MessageBubbleView_State_var;
		  uVar6 = *(undefined4 *)(param1 + 0x20);
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar2 = func_ii_2734(uVar2,0);
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  uVar2 = System_Enum__InternalGetValues(uVar2,0);
		  if (*(int *)(Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView___c_TypeInfo);
		  }
		  puVar7 = *(undefined4 **)
		            (Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView___c_TypeInfo + 0x5c);
		  iVar8 = puVar7[1];
		  if (iVar8 == 0) {
		    if (*(int *)(Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView___c_TypeInfo + 0x74) == 0)
		    {
		      func_ii_306000(Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView___c_TypeInfo);
		      puVar7 = *(undefined4 **)
		                (Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar7;
		    iVar8 = unnamed_function_1417(System_Func_string__TMP_Dropdown_OptionData__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar8,param2_00,
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView___c__Start_b__25_0__,0
		              );
		    *(int *)(*(int *)(Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView___c_TypeInfo + 0x5c) +
		            4) = iVar8;
		  }
		  iVar1 = 0;
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar2,iVar8,
		                     Method_System_Linq_Enumerable_Select_string__TMP_Dropdown_OptionData___);
		  uVar2 = System_Linq_Enumerable__Select_object__object_
		                    (uVar2,Method_System_Linq_Enumerable_ToList_TMP_Dropdown_OptionData___);
		  TMPro_TMP_Dropdown__set_itemImage(uVar6,uVar2,0);
		  iVar3 = unnamed_function_1417(System_Collections_Generic_List_TMP_Dropdown_OptionData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar3,Method_System_Collections_Generic_List_TMP_Dropdown_OptionData___ctor__);
		  uVar2 = unnamed_function_1417(TMPro_TMP_Dropdown_OptionData_TypeInfo);
		  System_UInt32__ToString(uVar2,StringLiteral_1739,0);
		  iVar8 = Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar9 = *(uint *)(iVar3 + 0xc);
		  if (uVar9 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar9 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar9 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		  }
		  do {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar10 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar10;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 + iVar8 + 0x178);
		          goto code_r0x80eea6bb;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar10,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80eea6bb:
		    uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar10,puVar4[1]);
		    iVar8 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		    if (*(int *)(*(int *)(iVar8 + 0x34) + 0xc) <= iVar1) break;
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar9 = 0;
		    piVar10 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar10;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 + iVar8 + 0x178);
		          goto code_r0x80eea776;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar10,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80eea776:
		    uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar10,puVar4[1]);
		    iVar8 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		    iVar8 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (*(undefined4 *)(iVar8 + 0x34),iVar1,
		                       Method_Google_Protobuf_Collections_RepeatedField_AprDic__get_Item__);
		    iVar5 = Core_Extensions_Dict_AprDicExt__GetAnimation1024AssetId(iVar8,0);
		    if (iVar5 != 0) {
		      local_4 = *(undefined4 *)(iVar8 + 0xc);
		      uVar2 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		      uVar6 = unnamed_function_1417(TMPro_TMP_Dropdown_OptionData_TypeInfo);
		      System_UInt32__ToString(uVar6,uVar2,0);
		      iVar8 = Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__Add__;
		      *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		      uVar9 = *(uint *)(iVar3 + 0xc);
		      if (uVar9 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		        *(uint *)(iVar3 + 0xc) = uVar9 + 1;
		        *(undefined4 *)(*(int *)(iVar3 + 8) + uVar9 * 4 + 0x10) = uVar6;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (iVar3,uVar6,*(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		      }
		    }
		    iVar1 = iVar1 + 1;
		  } while( true );
		  uVar6 = *(undefined4 *)(param1 + 0x30);
		  piVar10 = (int *)Mono_Security_ASN1Convert__ToOid(TMPro_TMP_Dropdown_OptionData___TypeInfo,4);
		  local_10 = 0x1ffffffff;
		  local_20[3] = Gameplay_Tutorial_Guide_Model_TargetPointerShape_TypeInfo;
		  uVar2 = Spine_SkeletonJson__GetFloat(local_20 + 3,0);
		  iVar8 = unnamed_function_1417(TMPro_TMP_Dropdown_OptionData_TypeInfo);
		  System_UInt32__ToString(iVar8,uVar2,0);
		  if ((iVar8 != 0) && (iVar1 = func_ii_1082(iVar8,*(undefined4 *)(*piVar10 + 0x20)), iVar1 == 0)) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar10[4] = iVar8;
		  local_20[1] = -1;
		  local_20[2] = 2;
		  local_20[0] = Gameplay_Tutorial_Guide_Model_TargetPointerShape_TypeInfo;
		  uVar2 = Spine_SkeletonJson__GetFloat(local_20,0);
		  iVar8 = unnamed_function_1417(TMPro_TMP_Dropdown_OptionData_TypeInfo);
		  System_UInt32__ToString(iVar8,uVar2,0);
		  if ((iVar8 != 0) && (iVar1 = func_ii_1082(iVar8,*(undefined4 *)(*piVar10 + 0x20)), iVar1 == 0)) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar10[5] = iVar8;
		  local_28 = 0x3ffffffff;
		  local_38[3] = Gameplay_Tutorial_Guide_Model_TargetPointerShape_TypeInfo;
		  uVar2 = Spine_SkeletonJson__GetFloat(local_38 + 3,0);
		  iVar8 = unnamed_function_1417(TMPro_TMP_Dropdown_OptionData_TypeInfo);
		  System_UInt32__ToString(iVar8,uVar2,0);
		  if ((iVar8 != 0) && (iVar1 = func_ii_1082(iVar8,*(undefined4 *)(*piVar10 + 0x20)), iVar1 == 0)) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar10[6] = iVar8;
		  local_38[1] = -1;
		  local_38[2] = 4;
		  local_38[0] = Gameplay_Tutorial_Guide_Model_TargetPointerShape_TypeInfo;
		  uVar2 = Spine_SkeletonJson__GetFloat(local_38,0);
		  iVar8 = unnamed_function_1417(TMPro_TMP_Dropdown_OptionData_TypeInfo);
		  System_UInt32__ToString(iVar8,uVar2,0);
		  if ((iVar8 != 0) && (iVar1 = func_ii_1082(iVar8,*(undefined4 *)(*piVar10 + 0x20)), iVar1 == 0)) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar10[7] = iVar8;
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_TMP_Dropdown_OptionData__TypeInfo);
		  Sirenix_Utilities_LinqExtensions__Convert_object_
		            (uVar2,piVar10,Method_System_Collections_Generic_List_TMP_Dropdown_OptionData___ctor__);
		  TMPro_TMP_Dropdown__set_itemImage(uVar6,uVar2,0);
		  uVar6 = *(undefined4 *)(param1 + 0x34);
		  piVar10 = (int *)Mono_Security_ASN1Convert__ToOid(TMPro_TMP_Dropdown_OptionData___TypeInfo,2);
		  local_40 = 0x1ffffffff;
		  local_44 = Gameplay_Tutorial_Guide_Model_OverlapType_TypeInfo;
		  uVar2 = Spine_SkeletonJson__GetFloat(&local_44,0);
		  iVar8 = unnamed_function_1417(TMPro_TMP_Dropdown_OptionData_TypeInfo);
		  System_UInt32__ToString(iVar8,uVar2,0);
		  if ((iVar8 != 0) && (iVar1 = func_ii_1082(iVar8,*(undefined4 *)(*piVar10 + 0x20)), iVar1 == 0)) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar10[4] = iVar8;
		  local_4c = 0x2ffffffff;
		  local_50 = Gameplay_Tutorial_Guide_Model_OverlapType_TypeInfo;
		  uVar2 = Spine_SkeletonJson__GetFloat(&local_50,0);
		  iVar8 = unnamed_function_1417(TMPro_TMP_Dropdown_OptionData_TypeInfo);
		  System_UInt32__ToString(iVar8,uVar2,0);
		  if ((iVar8 != 0) && (iVar1 = func_ii_1082(iVar8,*(undefined4 *)(*piVar10 + 0x20)), iVar1 == 0)) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar10[5] = iVar8;
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_TMP_Dropdown_OptionData__TypeInfo);
		  Sirenix_Utilities_LinqExtensions__Convert_object_
		            (uVar2,piVar10,Method_System_Collections_Generic_List_TMP_Dropdown_OptionData___ctor__);
		  TMPro_TMP_Dropdown__set_itemImage(uVar6,uVar2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar9 = 0;
		  piVar10 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar10;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 + iVar8 + 0x178);
		        goto code_r0x80eeab5c;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar10,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80eeab5c:
		  uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar10,puVar4[1]);
		  iVar8 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  uVar2 = *(undefined4 *)(*(int *)(iVar8 + 0x29c) + 0xc);
		  iVar8 = unnamed_function_1417(System_Collections_Generic_List_TMP_Dropdown_OptionData__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (iVar8,uVar2,Method_System_Collections_Generic_List_TMP_Dropdown_OptionData___ctor__);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar10 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar1 = *piVar10;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8 + 4) * 8 + iVar1 + 0x178);
		        goto code_r0x80eeac2f;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar9);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar10,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80eeac2f:
		  uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar10,puVar4[1]);
		  iVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  local_8 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(iVar1 + 0x29c),
		                              Method_Google_Protobuf_Collections_RepeatedField_TutorialUIPointerDic__GetEnumerator__
		                             );
		  local_20[3] = 0;
		  local_10 = CONCAT44(local_10._4_4_,&local_8);
		code_r0x80eeac7f:
		  do {
		    piVar10 = local_8;
		    iVar1 = *local_8;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		          puVar7 = (undefined4 *)(iVar1 + piVar11[1] * 8 + 0xc0);
		          goto code_r0x80eead13;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar9);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80eeaf80:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80eeaf88;
		    }
		code_r0x80eead13:
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii(*puVar7,piVar10,puVar7[1]);
		    piVar10 = local_8;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80eeaf80;
		    if (iVar1 == 0) goto code_r0x80eeafd1;
		    iVar1 = *local_8;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8);
		        if (System_Collections_Generic_IEnumerator_TutorialUIPointerDic__TypeInfo == *piVar11) {
		          puVar7 = (undefined4 *)(iVar1 + piVar11[1] * 8 + 0xc0);
		          goto code_r0x80eeadf0;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar9);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                        System_Collections_Generic_IEnumerator_TutorialUIPointerDic__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80eeaf62:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80eeaf88;
		    }
		code_r0x80eeadf0:
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii(*puVar7,piVar10,puVar7[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80eeaf62;
		    local_4 = *(undefined4 *)(iVar1 + 0xc);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x167,&local_4,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80eeaf88;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       TMPro_TMP_Dropdown_OptionData_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    System_UInt32__ToString(uVar6,uVar2,0);
		    iVar1 = Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__Add__;
		    if (DAT_ram_009d3e38 == 1) break;
		    *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		    uVar9 = *(uint *)(iVar8 + 0xc);
		    if (uVar9 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		      *(uint *)(iVar8 + 0xc) = uVar9 + 1;
		      *(undefined4 *)(*(int *)(iVar8 + 8) + uVar9 * 4 + 0x10) = uVar6;
		      goto code_r0x80eeac7f;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar8,uVar6,
		               *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80eeaf88:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar10 = (int *)import::env::__cxa_begin_catch(uVar2);
		    local_20[3] = *piVar10;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x80eeafd1:
		      DAT_ram_009d3e38 = 0;
		      piVar10 = (int *)*(int *)local_10;
		      if (piVar10 != (int *)0x0) {
		        uVar9 = 0;
		        iVar1 = *piVar10;
		        if (*(ushort *)(iVar1 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8)) {
		              puVar4 = (uint *)(iVar1 + *(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80eeb04c;
		            }
		            uVar9 = uVar9 + 1;
		          } while (*(ushort *)(iVar1 + 0xb6) != uVar9);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar10,System_IDisposable_TypeInfo,0);
		code_r0x80eeb04c:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar10,puVar4[1]);
		      }
		      if (local_20[3] == 0) {
		        TMPro_TMP_Dropdown__set_itemImage(*(undefined4 *)(param1 + 0x54),iVar8,0);
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_20[3]);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x169,local_20 + 3);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
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

		// Token: 0x06001A4E RID: 6734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4E")]
		[Address(RVA = "0x6BE5", Offset = "0x6BE5", VA = "0x6BE5")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__Start
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  float4 fVar1;
		  int iVar2;
		  undefined4 uVar3;
		  float4 local_4;
		  
		  local_4 = 0.0;
		  iVar2 = func_ii_6594(param2,0xa7,*(undefined4 *)(param1 + 0x74),&local_4,0);
		  if (iVar2 != 0) {
		    iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    fVar1 = local_4;
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x24) + 0x10);
		    iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    iVar2 = *(int *)(iVar2 + 0x24);
		    *(undefined4 *)(iVar2 + 0x10) = uVar3;
		    *(float4 *)(iVar2 + 0x14) = fVar1;
		    uVar3 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__remove_ChangedEvent(uVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4F")]
		[Address(RVA = "0x6BE6", Offset = "0x6BE6", VA = "0x6BE6")]
		private void HandleTargetPointerOffsetYChanged(string value)
		{
		/* --- GHIDRA: HandleTargetPointerOffsetYChanged ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__HandleTargetPointerOffsetYChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  float4 fVar1;
		  int iVar2;
		  undefined4 uVar3;
		  float4 local_4;
		  
		  local_4 = 0.0;
		  iVar2 = func_ii_6594(param2,0xa7,*(undefined4 *)(param1 + 0x74),&local_4,0);
		  if (iVar2 != 0) {
		    iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    fVar1 = local_4;
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x24) + 0x14);
		    iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    iVar2 = *(int *)(iVar2 + 0x24);
		    *(float4 *)(iVar2 + 0x10) = fVar1;
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__remove_ChangedEvent(uVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A50")]
		[Address(RVA = "0x6BE7", Offset = "0x6BE7", VA = "0x6BE7")]
		private void HandleTargetPointerOffsetXChanged(string value)
		{
		/* --- GHIDRA: HandleTargetPointerOffsetXChanged ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__HandleTargetPointerOffsetXChanged
		               (int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  *(float *)(*(int *)(iVar1 + 0x24) + 0x1c) = param2;
		  param1_00 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                        (*(undefined4 *)(param1 + 0x78),0);
		  Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__remove_ChangedEvent(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A51")]
		[Address(RVA = "0x6BE8", Offset = "0x6BE8", VA = "0x6BE8")]
		private void HandleTargetPointerScaleXChanged(float value)
		{
		/* --- GHIDRA: HandleTargetPointerScaleXChanged ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__HandleTargetPointerScaleXChanged
		               (int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  *(float *)(*(int *)(iVar1 + 0x24) + 0x20) = param2;
		  param1_00 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                        (*(undefined4 *)(param1 + 0x78),0);
		  Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__remove_ChangedEvent(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A52")]
		[Address(RVA = "0x6BE9", Offset = "0x6BE9", VA = "0x6BE9")]
		private void HandleTargetPointerScaleYChanged(float value)
		{
		/* --- GHIDRA: HandleTargetPointerScaleYChanged ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__HandleTargetPointerScaleYChanged
		               (int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  *(float *)(*(int *)(iVar1 + 0x24) + 0x2c) = param2;
		  param1_00 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                        (*(undefined4 *)(param1 + 0x78),0);
		  Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__remove_ChangedEvent(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A53")]
		[Address(RVA = "0x6BEA", Offset = "0x6BEA", VA = "0x6BEA")]
		private void HandleOutlineScaleChanged(float value)
		{
		/* --- GHIDRA: HandleOutlineScaleChanged ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__HandleOutlineScaleChanged
		               (int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  *(float *)(*(int *)(iVar1 + 0x24) + 0x24) = param2;
		  param1_00 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                        (*(undefined4 *)(param1 + 0x78),0);
		  Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__remove_ChangedEvent(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A54")]
		[Address(RVA = "0x6BEB", Offset = "0x6BEB", VA = "0x6BEB")]
		private void HandleShadeAlphaChanged(float value)
		{
		/* --- GHIDRA: HandleShadeAlphaChanged ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__HandleShadeAlphaChanged
		               (int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 param2_00;
		  
		  piVar1 = (int *)Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                            (*(undefined4 *)(param1 + 0x78),0);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xd8) * 4))
		                        (piVar1,*(undefined4 *)(*piVar1 + 0xdc));
		  TMPro_TMP_InputField__get_text(*(undefined4 *)(param1 + 0x70),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A55")]
		[Address(RVA = "0x6BEC", Offset = "0x6BEC", VA = "0x6BEC")]
		private void HandleGetValuesButtonClickEvent()
		{
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001A57 RID: 6743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049C")]
		public GuideConfig GuideConfig
		{
			[Token(Token = "0x6001A56")]
			[Address(RVA = "0x6BED", Offset = "0x6BED", VA = "0x6BED")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A57")]
			[Address(RVA = "0x6BEE", Offset = "0x6BEE", VA = "0x6BEE")]
			set
			{
			}
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A58")]
		[Address(RVA = "0x6BEF", Offset = "0x6BEF", VA = "0x6BEF")]
		private void HandleConfigChanged()
		{
		/* --- GHIDRA: HandleConfigChanged ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__HandleConfigChanged
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58436 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__FillForm_b__38_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__FillForm_b__38_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__FillForm_b__38_2__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__FillForm_b__38_3__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__FindIndex__);
		    Mono_Security_ASN1__get_Item(&System_Predicate_TMP_Dropdown_OptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_264);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19094);
		    DAT_ram_00a58436 = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x1c);
		  local_8 = *(undefined8 *)(*(int *)(param1 + 0x78) + 8);
		  uVar1 = Gameplay_Tutorial_Guide_Model_Data_GuideId___ctor(&local_8,0);
		  uVar1 = System_Int32__ToString
		                    (uVar1,StringLiteral_264,
		                     *(undefined4 *)(*(int *)(*(int *)(param1 + 0x78) + 0x10) + 0x18),
		                     StringLiteral_19094,0);
		  iVar5 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		            (piVar3,uVar1,*(undefined4 *)(iVar5 + 0x2d4));
		  piVar3 = *(int **)(param1 + 0x24);
		  iVar5 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  iVar6 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x240) * 4))
		            (piVar3,*(undefined4 *)(*(int *)(iVar5 + 0x18) + 0x14),*(undefined4 *)(iVar6 + 0x244));
		  piVar3 = *(int **)(param1 + 0x28);
		  iVar5 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  iVar6 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x240) * 4))
		            (piVar3,*(undefined4 *)(*(int *)(iVar5 + 0x18) + 0x10),*(undefined4 *)(iVar6 + 0x244));
		  piVar3 = *(int **)(param1 + 0x58);
		  iVar5 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  iVar6 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x240) * 4))
		            (piVar3,*(undefined4 *)(*(int *)(iVar5 + 0x28) + 0xc),*(undefined4 *)(iVar6 + 0x244));
		  uVar1 = *(undefined4 *)(param1 + 0x5c);
		  iVar5 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  iVar5 = System_Collections_Generic_List_float___GetEnumerator(*(int *)(iVar5 + 0x28) + 0x10,0);
		  if (iVar5 == 0) {
		    iVar5 = StringLiteral_5;
		  }
		  TMPro_TMP_InputField__set_text(uVar1,iVar5,0);
		  uVar1 = *(undefined4 *)(param1 + 0x60);
		  iVar5 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  iVar5 = System_Collections_Generic_List_float___GetEnumerator(*(int *)(iVar5 + 0x28) + 0x14,0);
		  if (iVar5 == 0) {
		    iVar5 = StringLiteral_5;
		  }
		  TMPro_TMP_InputField__set_text(uVar1,iVar5,0);
		  uVar1 = *(undefined4 *)(param1 + 100);
		  iVar5 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  iVar5 = System_Collections_Generic_List_float___GetEnumerator(*(int *)(iVar5 + 0x28) + 0x18,0);
		  if (iVar5 == 0) {
		    iVar5 = StringLiteral_5;
		  }
		  TMPro_TMP_InputField__set_text(uVar1,iVar5,0);
		  uVar1 = *(undefined4 *)(param1 + 0x68);
		  iVar5 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  iVar5 = System_Collections_Generic_List_float___GetEnumerator(*(int *)(iVar5 + 0x28) + 0x1c,0);
		  if (iVar5 == 0) {
		    iVar5 = StringLiteral_5;
		  }
		  TMPro_TMP_InputField__set_text(uVar1,iVar5,0);
		  uVar1 = *(undefined4 *)(param1 + 0x4c);
		  iVar5 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  iVar5 = System_Collections_Generic_List_float___GetEnumerator(*(int *)(iVar5 + 0x24) + 0x10,0);
		  if (iVar5 == 0) {
		    iVar5 = StringLiteral_5;
		  }
		  TMPro_TMP_InputField__set_text(uVar1,iVar5,0);
		  uVar1 = *(undefined4 *)(param1 + 0x50);
		  iVar5 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  iVar5 = System_Collections_Generic_List_float___GetEnumerator(*(int *)(iVar5 + 0x24) + 0x14,0);
		  if (iVar5 == 0) {
		    iVar5 = StringLiteral_5;
		  }
		  TMPro_TMP_InputField__set_text(uVar1,iVar5,0);
		  piVar3 = *(int **)(param1 + 0x40);
		  iVar5 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  iVar6 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x240) * 4))
		            (piVar3,*(undefined4 *)(*(int *)(iVar5 + 0x24) + 0x1c),*(undefined4 *)(iVar6 + 0x244));
		  piVar3 = *(int **)(param1 + 0x44);
		  iVar5 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  iVar6 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x240) * 4))
		            (piVar3,*(undefined4 *)(*(int *)(iVar5 + 0x24) + 0x20),*(undefined4 *)(iVar6 + 0x244));
		  piVar3 = *(int **)(param1 + 0x38);
		  iVar5 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  iVar6 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x240) * 4))
		            (piVar3,*(undefined4 *)(*(int *)(iVar5 + 0x24) + 0x24),*(undefined4 *)(iVar6 + 0x244));
		  uVar1 = *(undefined4 *)(param1 + 0x2c);
		  iVar5 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  func_ii_7603(uVar1,(uint)*(byte *)(*(int *)(iVar5 + 0x24) + 0x28),0);
		  uVar4 = *(undefined4 *)(param1 + 0x20);
		  uVar1 = func_ii_13845(uVar4,0);
		  uVar2 = unnamed_function_1417(System_Predicate_TMP_Dropdown_OptionData__TypeInfo);
		  func_ii_7297(uVar2,param1,
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__FillForm_b__38_0__,0)
		  ;
		  uVar1 = System_Collections_Generic_List_UsageHint___FindIndex
		                    (uVar1,0,uVar2,
		                     Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__FindIndex__);
		  TMPro_TMP_Dropdown__set_value(uVar4,uVar1,0);
		  uVar4 = *(undefined4 *)(param1 + 0x30);
		  uVar1 = func_ii_13845(uVar4,0);
		  uVar2 = unnamed_function_1417(System_Predicate_TMP_Dropdown_OptionData__TypeInfo);
		  func_ii_7297(uVar2,param1,
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__FillForm_b__38_1__,0)
		  ;
		  uVar1 = System_Collections_Generic_List_UsageHint___FindIndex
		                    (uVar1,0,uVar2,
		                     Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__FindIndex__);
		  TMPro_TMP_Dropdown__set_value(uVar4,uVar1,0);
		  uVar4 = *(undefined4 *)(param1 + 0x34);
		  uVar1 = func_ii_13845(uVar4,0);
		  uVar2 = unnamed_function_1417(System_Predicate_TMP_Dropdown_OptionData__TypeInfo);
		  func_ii_7297(uVar2,param1,
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__FillForm_b__38_2__,0)
		  ;
		  uVar1 = System_Collections_Generic_List_UsageHint___FindIndex
		                    (uVar1,0,uVar2,
		                     Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__FindIndex__);
		  TMPro_TMP_Dropdown__set_value(uVar4,uVar1,0);
		  uVar4 = *(undefined4 *)(param1 + 0x54);
		  uVar1 = func_ii_13845(uVar4,0);
		  uVar2 = unnamed_function_1417(System_Predicate_TMP_Dropdown_OptionData__TypeInfo);
		  func_ii_7297(uVar2,param1,
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__FillForm_b__38_3__,0)
		  ;
		  uVar1 = System_Collections_Generic_List_UsageHint___FindIndex
		                    (uVar1,0,uVar2,
		                     Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__FindIndex__);
		  TMPro_TMP_Dropdown__set_value(uVar4,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A59")]
		[Address(RVA = "0x6BF0", Offset = "0x6BF0", VA = "0x6BF0")]
		private void FillForm()
		{
		/* --- GHIDRA: FillForm ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__FillForm
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  float4 fVar1;
		  int iVar2;
		  undefined4 uVar3;
		  float4 local_4;
		  
		  local_4 = 0.0;
		  iVar2 = func_ii_6594(param2,0xa7,*(undefined4 *)(param1 + 0x74),&local_4,0);
		  if (iVar2 != 0) {
		    iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    fVar1 = local_4;
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x28) + 0x18);
		    iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    iVar2 = *(int *)(iVar2 + 0x28);
		    *(undefined4 *)(iVar2 + 0x18) = uVar3;
		    *(float4 *)(iVar2 + 0x1c) = fVar1;
		    uVar3 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__remove_ChangedEvent(uVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A5A")]
		[Address(RVA = "0x6BF1", Offset = "0x6BF1", VA = "0x6BF1")]
		private void HandleGraphicPointerScaleYChanged(string value)
		{
		/* --- GHIDRA: HandleGraphicPointerScaleYChanged ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__HandleGraphicPointerScaleYChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  float4 fVar1;
		  int iVar2;
		  undefined4 uVar3;
		  float4 local_4;
		  
		  local_4 = 0.0;
		  iVar2 = func_ii_6594(param2,0xa7,*(undefined4 *)(param1 + 0x74),&local_4,0);
		  if (iVar2 != 0) {
		    iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    fVar1 = local_4;
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x28) + 0x1c);
		    iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    iVar2 = *(int *)(iVar2 + 0x28);
		    *(float4 *)(iVar2 + 0x18) = fVar1;
		    *(undefined4 *)(iVar2 + 0x1c) = uVar3;
		    uVar3 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__remove_ChangedEvent(uVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A5B")]
		[Address(RVA = "0x6BF2", Offset = "0x6BF2", VA = "0x6BF2")]
		private void HandleGraphicPointerScaleXChanged(string value)
		{
		/* --- GHIDRA: HandleGraphicPointerScaleXChanged ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__HandleGraphicPointerScaleXChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  float4 fVar1;
		  int iVar2;
		  undefined4 uVar3;
		  float4 local_4;
		  
		  local_4 = 0.0;
		  iVar2 = func_ii_6594(param2,0xa7,*(undefined4 *)(param1 + 0x74),&local_4,0);
		  if (iVar2 != 0) {
		    iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    fVar1 = local_4;
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x28) + 0x10);
		    iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    iVar2 = *(int *)(iVar2 + 0x28);
		    *(undefined4 *)(iVar2 + 0x10) = uVar3;
		    *(float4 *)(iVar2 + 0x14) = fVar1;
		    uVar3 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__remove_ChangedEvent(uVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A5C")]
		[Address(RVA = "0x6BF3", Offset = "0x6BF3", VA = "0x6BF3")]
		private void HandleGraphicPointerOffsetYChanged(string value)
		{
		/* --- GHIDRA: HandleGraphicPointerOffsetYChanged ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__HandleGraphicPointerOffsetYChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  float4 fVar1;
		  int iVar2;
		  undefined4 uVar3;
		  float4 local_4;
		  
		  local_4 = 0.0;
		  iVar2 = func_ii_6594(param2,0xa7,*(undefined4 *)(param1 + 0x74),&local_4,0);
		  if (iVar2 != 0) {
		    iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    fVar1 = local_4;
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x28) + 0x14);
		    iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    iVar2 = *(int *)(iVar2 + 0x28);
		    *(float4 *)(iVar2 + 0x10) = fVar1;
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__remove_ChangedEvent(uVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A5D")]
		[Address(RVA = "0x6BF4", Offset = "0x6BF4", VA = "0x6BF4")]
		private void HandleGraphicPointerOffsetXChanged(string value)
		{
		/* --- GHIDRA: HandleGraphicPointerOffsetXChanged ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__HandleGraphicPointerOffsetXChanged
		               (int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  *(float *)(*(int *)(iVar1 + 0x28) + 0xc) = param2;
		  param1_00 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                        (*(undefined4 *)(param1 + 0x78),0);
		  Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__remove_ChangedEvent(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A5E")]
		[Address(RVA = "0x6BF5", Offset = "0x6BF5", VA = "0x6BF5")]
		private void HandleAngleChanged(float value)
		{
		/* --- GHIDRA: HandleAngleChanged ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__HandleAngleChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58437 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__get_Item__);
		    DAT_ram_00a58437 = '\x01';
		  }
		  local_4 = 0;
		  uVar1 = func_ii_13845(*(undefined4 *)(param1 + 0x54),0);
		  iVar2 = System_Linq_Enumerable__ToList_object_
		                    (uVar1,param2,
		                     Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__get_Item__);
		  iVar2 = System_UInt32__Parse(*(undefined4 *)(iVar2 + 8),&local_4,0);
		  if (iVar2 != 0) {
		    iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    *(undefined4 *)(*(int *)(iVar2 + 0x28) + 8) = local_4;
		    uVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__remove_ChangedEvent(uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A5F")]
		[Address(RVA = "0x6BF6", Offset = "0x6BF6", VA = "0x6BF6")]
		private void HandleGraphicPointerIdChanged(int value)
		{
		/* --- GHIDRA: HandleGraphicPointerIdChanged ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__HandleGraphicPointerIdChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  *(undefined1 *)(*(int *)(iVar1 + 0x24) + 0x28) = (undefined1)param2;
		  param1_00 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                        (*(undefined4 *)(param1 + 0x78),0);
		  Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__remove_ChangedEvent(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A60")]
		[Address(RVA = "0x6BF7", Offset = "0x6BF7", VA = "0x6BF7")]
		private void HandleShapeToggleChanged(bool value)
		{
		/* --- GHIDRA: HandleShapeToggleChanged ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__HandleShapeToggleChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int local_4;
		  
		  if (DAT_ram_00a58438 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Enum_TryParse_OverlapType___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__get_Item__);
		    DAT_ram_00a58438 = '\x01';
		  }
		  local_4 = 0;
		  uVar1 = func_ii_13845(*(undefined4 *)(param1 + 0x34),0);
		  iVar2 = System_Linq_Enumerable__ToList_object_
		                    (uVar1,param2,
		                     Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__get_Item__);
		  uVar1 = *(undefined4 *)(iVar2 + 8);
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  iVar2 = System_Enum__TryParse___Il2CppFullySharedGenericStructType_
		                    (uVar1,0,&local_4,Method_System_Enum_TryParse_OverlapType___);
		  if (iVar2 != 0) {
		    iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    iVar2 = *(int *)(*(int *)(iVar2 + 0x24) + 0xc);
		    if (iVar2 != local_4) {
		      iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                        (*(undefined4 *)(param1 + 0x78),0);
		      *(int *)(*(int *)(iVar2 + 0x24) + 0xc) = local_4;
		      uVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                        (*(undefined4 *)(param1 + 0x78),0);
		      Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__remove_ChangedEvent(uVar1,0);
		      iVar2 = local_4;
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x3c),(uint)(iVar2 == 1),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A61")]
		[Address(RVA = "0x6BF8", Offset = "0x6BF8", VA = "0x6BF8")]
		private void HandleOverlapChanged(int value)
		{
		/* --- GHIDRA: HandleOverlapChanged ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__HandleOverlapChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int local_4;
		  
		  if (DAT_ram_00a58439 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Enum_TryParse_TargetPointerShape___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__get_Item__);
		    DAT_ram_00a58439 = '\x01';
		  }
		  local_4 = 0;
		  uVar1 = func_ii_13845(*(undefined4 *)(param1 + 0x30),0);
		  iVar2 = System_Linq_Enumerable__ToList_object_
		                    (uVar1,param2,
		                     Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__get_Item__);
		  uVar1 = *(undefined4 *)(iVar2 + 8);
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  iVar2 = System_Enum__TryParse___Il2CppFullySharedGenericStructType_
		                    (uVar1,1,&local_4,Method_System_Enum_TryParse_TargetPointerShape___);
		  if ((iVar2 != 0) &&
		     (iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                        (*(undefined4 *)(param1 + 0x78),0),
		     *(int *)(*(int *)(iVar2 + 0x24) + 8) != local_4)) {
		    iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    *(int *)(*(int *)(iVar2 + 0x24) + 8) = local_4;
		    uVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__remove_ChangedEvent(uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A62")]
		[Address(RVA = "0x6BF9", Offset = "0x6BF9", VA = "0x6BF9")]
		private void HandleShapeChanged(int value)
		{
		/* --- GHIDRA: HandleShapeChanged ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__HandleShapeChanged
		               (int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  *(float *)(*(int *)(iVar1 + 0x18) + 0x14) = param2;
		  param1_00 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                        (*(undefined4 *)(param1 + 0x78),0);
		  Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__remove_ChangedEvent(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A63")]
		[Address(RVA = "0x6BFA", Offset = "0x6BFA", VA = "0x6BFA")]
		private void HandleMessageBlockYChanged(float value)
		{
		/* --- GHIDRA: HandleMessageBlockYChanged ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__HandleMessageBlockYChanged
		               (int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  *(float *)(*(int *)(iVar1 + 0x18) + 0x10) = param2;
		  param1_00 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                        (*(undefined4 *)(param1 + 0x78),0);
		  Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__remove_ChangedEvent(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A64")]
		[Address(RVA = "0x6BFB", Offset = "0x6BFB", VA = "0x6BFB")]
		private void HandleMessageBlockXChanged(float value)
		{
		/* --- GHIDRA: HandleMessageBlockXChanged ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__HandleMessageBlockXChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int local_4;
		  
		  if (DAT_ram_00a5843a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Enum_TryParse_MessageBubbleView_State___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__get_Item__);
		    DAT_ram_00a5843a = '\x01';
		  }
		  local_4 = 0;
		  uVar1 = func_ii_13845(*(undefined4 *)(param1 + 0x20),0);
		  iVar2 = System_Linq_Enumerable__ToList_object_
		                    (uVar1,param2,
		                     Method_System_Collections_Generic_List_TMP_Dropdown_OptionData__get_Item__);
		  uVar1 = *(undefined4 *)(iVar2 + 8);
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  iVar2 = System_Enum__TryParse___Il2CppFullySharedGenericStructType_
		                    (uVar1,0,&local_4,Method_System_Enum_TryParse_MessageBubbleView_State___);
		  if ((iVar2 != 0) &&
		     (iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                        (*(undefined4 *)(param1 + 0x78),0),
		     *(int *)(*(int *)(iVar2 + 0x18) + 8) != local_4)) {
		    iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    *(int *)(*(int *)(iVar2 + 0x18) + 8) = local_4;
		    uVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x78),0);
		    Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__remove_ChangedEvent(uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A65")]
		[Address(RVA = "0x6BFC", Offset = "0x6BFC", VA = "0x6BFC")]
		private void BubbleMessageLayoutChanged(int value)
		{
		/* --- GHIDRA: BubbleMessageLayoutChanged ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__BubbleMessageLayoutChanged
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined8 local_18;
		  undefined4 local_10;
		  float4 local_c;
		  float4 local_8;
		  undefined4 local_4;
		  
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1,0);
		  local_4 = 0;
		  local_10 = 0;
		  local_c = (float4)((float)*(undefined8 *)(param2 + 200) -
		                    ((float)*(undefined8 *)(param2 + 0xd8) - (float)*(undefined8 *)(param1 + 0x7c)))
		  ;
		  local_8 = (float4)((float)((ulonglong)*(undefined8 *)(param2 + 200) >> 0x20) -
		                    ((float)((ulonglong)*(undefined8 *)(param2 + 0xd8) >> 0x20) -
		                    (float)((ulonglong)*(undefined8 *)(param1 + 0x7c) >> 0x20)));
		  local_18 = CONCAT44(local_8,local_c);
		  UnityEngine_Transform__get_position(param1_00,&local_18,0);
		  return;
		}
		*/

		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A66")]
		[Address(RVA = "0x6BFD", Offset = "0x6BFD", VA = "0x6BFD", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		/* --- GHIDRA: OnDrag ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__OnDrag
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined8 local_10 [2];
		  
		  param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1,0);
		  func_ii_7888(local_10,param2_00,0);
		  *(undefined8 *)(param1 + 0x7c) = local_10[0];
		  return;
		}
		*/

		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A67")]
		[Address(RVA = "0x6BFE", Offset = "0x6BFE", VA = "0x6BFE", Slot = "6")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		/* --- GHIDRA: OnBeginDrag ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__OnBeginDrag
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5843b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_DevGuideStepEditorToolView_DevGuideStepEditorToolViewStates___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&System_Globalization_NumberFormatInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1480);
		    DAT_ram_00a5843b = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Globalization_NumberFormatInfo_TypeInfo);
		  System_Globalization_JapaneseCalendar___cctor(param1_00,0);
		  System_Globalization_NumberFormatInfo__get_PercentSymbol(param1_00,StringLiteral_1480,0);
		  *(undefined4 *)(param1 + 0x74) = param1_00;
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_UI_MonoBehaviourWithStates_DevGuideStepEditorToolView_DevGuideStepEditorToolViewStates___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A68")]
		[Address(RVA = "0x6BFF", Offset = "0x6BFF", VA = "0x6BFF")]
		public DevGuideStepEditorToolView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView___ctor
		          (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5843c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_View_MessageBubbleView_State_TypeInfo);
		    DAT_ram_00a5843c = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param2 + 8);
		  iVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x78),0);
		  local_8 = 0xffffffff;
		  local_c = Gameplay_TutorialV2_View_MessageBubbleView_State_TypeInfo;
		  local_4 = *(undefined4 *)(*(int *)(iVar1 + 0x18) + 8);
		  uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  uVar2 = System_Collections_CollectionBase___ctor(param1_00,uVar2,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x04000E23 RID: 3619
		[Token(Token = "0x4000E23")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _id;

		// Token: 0x04000E24 RID: 3620
		[Token(Token = "0x4000E24")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TMP_Dropdown _aprLayout;

		// Token: 0x04000E25 RID: 3621
		[Token(Token = "0x4000E25")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Slider _messageBlockY;

		// Token: 0x04000E26 RID: 3622
		[Token(Token = "0x4000E26")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Slider _messageBlockX;

		// Token: 0x04000E27 RID: 3623
		[Token(Token = "0x4000E27")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Toggle _outlineToggle;

		// Token: 0x04000E28 RID: 3624
		[Token(Token = "0x4000E28")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TMP_Dropdown _shape;

		// Token: 0x04000E29 RID: 3625
		[Token(Token = "0x4000E29")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TMP_Dropdown _overlapType;

		// Token: 0x04000E2A RID: 3626
		[Token(Token = "0x4000E2A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Slider _shadeAlpha;

		// Token: 0x04000E2B RID: 3627
		[Token(Token = "0x4000E2B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GameObject _shadeAlphaRow;

		// Token: 0x04000E2C RID: 3628
		[Token(Token = "0x4000E2C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Slider _targetPointerScaleX;

		// Token: 0x04000E2D RID: 3629
		[Token(Token = "0x4000E2D")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Slider _targetPointerScaleY;

		// Token: 0x04000E2E RID: 3630
		[Token(Token = "0x4000E2E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Slider _outlineScale;

		// Token: 0x04000E2F RID: 3631
		[Token(Token = "0x4000E2F")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TMP_InputField _targetPointerOffsetX;

		// Token: 0x04000E30 RID: 3632
		[Token(Token = "0x4000E30")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TMP_InputField _targetPointerOffsetY;

		// Token: 0x04000E31 RID: 3633
		[Token(Token = "0x4000E31")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TMP_Dropdown _graphicPointerId;

		// Token: 0x04000E32 RID: 3634
		[Token(Token = "0x4000E32")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Slider _angle;

		// Token: 0x04000E33 RID: 3635
		[Token(Token = "0x4000E33")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private TMP_InputField _offsetX;

		// Token: 0x04000E34 RID: 3636
		[Token(Token = "0x4000E34")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TMP_InputField _offsetY;

		// Token: 0x04000E35 RID: 3637
		[Token(Token = "0x4000E35")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private TMP_InputField _scaleX;

		// Token: 0x04000E36 RID: 3638
		[Token(Token = "0x4000E36")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TMP_InputField _scaleY;

		// Token: 0x04000E37 RID: 3639
		[Token(Token = "0x4000E37")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Button _getValuesButton;

		// Token: 0x04000E38 RID: 3640
		[Token(Token = "0x4000E38")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TMP_InputField _values;

		// Token: 0x04000E39 RID: 3641
		[Token(Token = "0x4000E39")]
		[FieldOffset(Offset = "0x74")]
		private NumberFormatInfo _numberFormat;

		// Token: 0x04000E3A RID: 3642
		[Token(Token = "0x4000E3A")]
		[FieldOffset(Offset = "0x78")]
		private GuideConfig _guideConfig;

		// Token: 0x04000E3B RID: 3643
		[Token(Token = "0x4000E3B")]
		[FieldOffset(Offset = "0x7C")]
		private Vector2 _p;

		// Token: 0x02000458 RID: 1112
		[Token(Token = "0x2000458")]
		public enum DevGuideStepEditorToolViewStates
		{
			// Token: 0x04000E3D RID: 3645
			[Token(Token = "0x4000E3D")]
			UNKNOWN,
			// Token: 0x04000E3E RID: 3646
			[Token(Token = "0x4000E3E")]
			EDIT,
			// Token: 0x04000E3F RID: 3647
			[Token(Token = "0x4000E3F")]
			NOT_AVAIL
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_GuideConfig ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__get_GuideConfig
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x78)) {
		    *(int *)(param1 + 0x78) = param2;
		    Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__set_GuideConfig(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_GuideConfig ---
		void Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__set_GuideConfig
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58435 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_TutorialV2_View_MessageBubbleView_MessageBubbleViewArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_DevGuideStepEditorToolView_DevGuideStepEditorToolViewStates__set_CurrentState__
		              );
		    DAT_ram_00a58435 = '\x01';
		  }
		  uVar2 = 1;
		  if (*(int *)(param1 + 0x78) == 0) {
		    uVar2 = 2;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,uVar2,
		             Method_UI_MonoBehaviourWithStates_DevGuideStepEditorToolView_DevGuideStepEditorToolViewStates__set_CurrentState__
		            );
		  if (*(int *)(param1 + 0x78) != 0) {
		    iVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor(*(int *)(param1 + 0x78),0);
		    if (*(int *)(iVar1 + 0x18) == 0) {
		      iVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                        (*(undefined4 *)(param1 + 0x78),0);
		      uVar2 = unnamed_function_1417
		                        (Gameplay_TutorialV2_View_MessageBubbleView_MessageBubbleViewArgs_TypeInfo);
		      *(undefined4 *)(iVar1 + 0x18) = uVar2;
		    }
		    Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__HandleConfigChanged(param1,param1);
		  }
		  return;
		}
		*/

}
