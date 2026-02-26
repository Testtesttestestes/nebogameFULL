using System;
using Gameplay.Tutorial.Guide.Model.Data;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Tutorial.Guide
{
	// Token: 0x02000456 RID: 1110
	[Token(Token = "0x2000456")]
	public class GuideEvents : AbstractMVCEvents
	{
		// Token: 0x06001A4C RID: 6732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4C")]
		[Address(RVA = "0x6BE3", Offset = "0x6BE3", VA = "0x6BE3")]
		public GuideEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tutorial_Guide_GuideEvents___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58433 == '\0') {
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
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_float__RemoveListener__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_int__RemoveListener__);
		    DAT_ram_00a58433 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x6c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleGetValuesButtonClickEvent__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x2c) + 0xc0);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (uVar1,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleShapeToggleChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0xd8);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_int__TypeInfo);
		  UnityEngine_Events_UnityAction_Color___Invoke
		            (uVar1,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_BubbleMessageLayoutChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_int__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x24) + 0xd0);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_float__TypeInfo);
		  UnityEngine_Events_UnityAction_Scene___Invoke
		            (uVar1,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleMessageBlockYChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_float__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x28) + 0xd0);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_float__TypeInfo);
		  UnityEngine_Events_UnityAction_Scene___Invoke
		            (uVar1,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleMessageBlockXChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_float__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x30) + 0xd8);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_int__TypeInfo);
		  UnityEngine_Events_UnityAction_Color___Invoke
		            (uVar1,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleShapeChanged__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_int__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x34) + 0xd8);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_int__TypeInfo);
		  UnityEngine_Events_UnityAction_Color___Invoke
		            (uVar1,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleOverlapChanged__,0
		            );
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_int__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x54) + 0xd8);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_int__TypeInfo);
		  UnityEngine_Events_UnityAction_Color___Invoke
		            (uVar1,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleGraphicPointerIdChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_int__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x58) + 0xd0);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_float__TypeInfo);
		  UnityEngine_Events_UnityAction_Scene___Invoke
		            (uVar1,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleAngleChanged__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_float__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x5c) + 0x130);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar1,param1,
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleGraphicPointerOffsetXChanged__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x60) + 0x130);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar1,param1,
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleGraphicPointerOffsetYChanged__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x40) + 0xd0);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_float__TypeInfo);
		  UnityEngine_Events_UnityAction_Scene___Invoke
		            (uVar1,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleTargetPointerScaleXChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_float__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x44) + 0xd0);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_float__TypeInfo);
		  UnityEngine_Events_UnityAction_Scene___Invoke
		            (uVar1,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleTargetPointerScaleYChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_float__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x48) + 0xd0);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_float__TypeInfo);
		  UnityEngine_Events_UnityAction_Scene___Invoke
		            (uVar1,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleOutlineScaleChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_float__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x38) + 0xd0);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_float__TypeInfo);
		  UnityEngine_Events_UnityAction_Scene___Invoke
		            (uVar1,param1,
		             Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleShadeAlphaChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_float__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x4c) + 0x130);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar1,param1,
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleTargetPointerOffsetXChanged__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x50) + 0x130);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar1,param1,
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleTargetPointerOffsetYChanged__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 100) + 0x130);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar1,param1,
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleGraphicPointerScaleXChanged__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x68) + 0x130);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar1,param1,
		               Method_Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView_HandleGraphicPointerScaleYChanged__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		  return;
		}
		*/

		}

		// Token: 0x04000E20 RID: 3616
		[Token(Token = "0x4000E20")]
		[FieldOffset(Offset = "0x14")]
		public Action<IGuideTarget, GuideConfig> CurrentStepChangedEvent;

		// Token: 0x04000E21 RID: 3617
		[Token(Token = "0x4000E21")]
		[FieldOffset(Offset = "0x18")]
		public Action DevEditorToolEnabledChangedEvent;

		// Token: 0x04000E22 RID: 3618
		[Token(Token = "0x4000E22")]
		[FieldOffset(Offset = "0x1C")]
		public Action<GuideConfig> TargetAchievedStartEvent;
	}
}
