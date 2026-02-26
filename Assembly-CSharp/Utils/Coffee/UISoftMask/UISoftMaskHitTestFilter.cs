using System;
using Coffee.UISoftMask;
using Il2CppDummyDll;
using UnityEngine;

namespace Utils.Coffee.UISoftMask
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	public class UISoftMaskHitTestFilter : MonoBehaviour, ICanvasRaycastFilter
	{
		// Token: 0x0600034C RID: 844 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x57AB", Offset = "0x57AB", VA = "0x57AB")]
		public MaskingShapeContainer GetShapeContainer()
		{
		/* --- GHIDRA: GetShapeContainer ---
		undefined4
		Utils_Coffee_UISoftMask_UISoftMaskHitTestFilter__GetShapeContainer
		          (int param1,undefined8 *param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62849 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_TryGetComponent_MaskingShapeContainer___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a62849 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  param1_00 = 0;
		  iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		  if ((iVar1 != 0) ||
		     (iVar1 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                        (*(undefined4 *)(param1 + 0x10),(undefined4 *)(param1 + 0x18),
		                         Method_UnityEngine_Component_TryGetComponent_MaskingShapeContainer___),
		     iVar1 != 0)) {
		    param1_00 = *(undefined4 *)(param1 + 0x18);
		  }
		  local_10 = *param2;
		  local_8 = local_10;
		  uVar2 = Coffee_UISoftMask_MaskingShapeContainer__UnityEngine_UI_IMaterialModifier_GetModifiedMaterial
		                    (param1_00,&local_10,param3,1,*(float *)(param1 + 0x14),0);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x57AC", Offset = "0x57AC", VA = "0x57AC", Slot = "4")]
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
		/* --- GHIDRA: IsRaycastLocationValid ---
		void Utils_Coffee_UISoftMask_UISoftMaskHitTestFilter__IsRaycastLocationValid
		               (int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x14) = 0x3c23d70a;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x57AD", Offset = "0x57AD", VA = "0x57AD")]
		public UISoftMaskHitTestFilter()
		{
		/* --- GHIDRA: .ctor ---
		void Utils_Coffee_UISoftMask_UISoftMaskHitTestFilter___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6284a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cam_FlickerFixer_SceneManagerOnSceneLoaded__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cam_FlickerFixer_SceneManagerOnSceneUnloaded__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_SceneManagement_SceneManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_Scene__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_Scene__LoadSceneMode__TypeInfo);
		    DAT_ram_00a6284a = '\x01';
		  }
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_Scene__TypeInfo);
		  UnityEngine_Events_UnityAction_object___Invoke
		            (uVar1,param1,Method_Utils_Cam_FlickerFixer_SceneManagerOnSceneUnloaded__,0);
		  if (*(int *)(UnityEngine_SceneManagement_SceneManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_SceneManagement_SceneManager_TypeInfo);
		  }
		  UnityEngine_SceneManagement_SceneManager__add_sceneUnloaded(uVar1,0);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_Scene__LoadSceneMode__TypeInfo);
		  UnityEngine_Events_UnityAction_InputAction_CallbackContext___Invoke
		            (uVar1,param1,Method_Utils_Cam_FlickerFixer_SceneManagerOnSceneLoaded__,0);
		  UnityEngine_SceneManagement_SceneManager__add_sceneLoaded(uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SoftMask _mask;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _threshold;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x18")]
		private MaskingShapeContainer _shapeContainer;
	}
}
