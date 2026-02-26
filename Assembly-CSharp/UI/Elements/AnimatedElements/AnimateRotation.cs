using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Elements.AnimatedElements
{
	// Token: 0x0200024E RID: 590
	[Token(Token = "0x200024E")]
	public class AnimateRotation : MonoBehaviour
	{
		// Token: 0x06000E5E RID: 3678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5E")]
		[Address(RVA = "0x60E5", Offset = "0x60E5", VA = "0x60E5")]
		public void Rotate(bool value)
		{
		/* --- GHIDRA: Rotate ---
		void UI_Elements_AnimatedElements_AnimateRotation__Rotate(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x2c) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x2c),0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0x60E6", Offset = "0x60E6", VA = "0x60E6")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Elements_AnimatedElements_AnimateRotation__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined8 uVar1;
		  
		  *(undefined4 *)(param1 + 0x10) = 0x3e99999a;
		  if (DAT_ram_00a65020 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		    DAT_ram_00a65020 = '\x01';
		  }
		  uVar1 = **(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c);
		  *(undefined4 *)(param1 + 0x1c) =
		       *(undefined4 *)(*(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c) + 1);
		  *(undefined8 *)(param1 + 0x14) = uVar1;
		  *(undefined4 *)(param1 + 0x28) = 0xc2b40000;
		  *(undefined8 *)(param1 + 0x20) = 0;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E60")]
		[Address(RVA = "0x60E7", Offset = "0x60E7", VA = "0x60E7")]
		public AnimateRotation()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Elements_AnimatedElements_AnimateRotation___ctor
		               (undefined8 *param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  undefined4 param2_01;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a639b6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_ContextMenuConfigurationItem___);
		    Mono_Security_ASN1__get_Item(&System_Func_ContextMenuConfigurationItem__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ContextMenu_ContextMenuConfiguration___c__DisplayClass1_0__GetConfig_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&UI_ContextMenu_ContextMenuConfiguration___c__DisplayClass1_0_TypeInfo);
		    DAT_ram_00a639b6 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (UI_ContextMenu_ContextMenuConfiguration___c__DisplayClass1_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param3;
		  param2_01 = *(undefined4 *)(param2 + 0xc);
		  param1_00 = unnamed_function_1417(System_Func_ContextMenuConfigurationItem__bool__TypeInfo);
		  System_Func_Color__Color___Invoke
		            (param1_00,param2_00,
		             Method_UI_ContextMenu_ContextMenuConfiguration___c__DisplayClass1_0__GetConfig_b__0__,0
		            );
		  System_Linq_Enumerable__FirstOrDefault___Il2CppFullySharedGenericType_
		            (&local_8,param2_01,param1_00,
		             Method_System_Linq_Enumerable_FirstOrDefault_ContextMenuConfigurationItem___);
		  *param1 = local_8;
		  return;
		}
		*/

		}

		// Token: 0x0400072A RID: 1834
		[Token(Token = "0x400072A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _rotationDuration;

		// Token: 0x0400072B RID: 1835
		[Token(Token = "0x400072B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Vector3 _enabledRotation;

		// Token: 0x0400072C RID: 1836
		[Token(Token = "0x400072C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _disabledRotation;

		// Token: 0x0400072D RID: 1837
		[Token(Token = "0x400072D")]
		[FieldOffset(Offset = "0x2C")]
		private Tween _rotationTween;
	}
}
