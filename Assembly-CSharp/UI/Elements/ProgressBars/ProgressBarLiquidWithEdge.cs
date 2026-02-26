using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Elements.ProgressBars
{
	// Token: 0x0200021F RID: 543
	[Token(Token = "0x200021F")]
	public class ProgressBarLiquidWithEdge : ProgressBarWithText
	{
		// Token: 0x06000D7D RID: 3453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D7D")]
		[Address(RVA = "0x6060", Offset = "0x6060", VA = "0x6060", Slot = "4")]
		protected override void OnValidateSafety()
		{
		/* --- GHIDRA: <set_Value>b__4_2 ---
		void UI_Elements_ProgressBars_ProgressBarLiquidWithEdge___set_Value_b__4_2
		               (int param1,float param2,undefined4 param3)
		
		{
		  UnityEngine_UI_Scrollbar__get_size(*(undefined4 *)(param1 + 0x24),param2,0);
		  return;
		}
		*/

		/* --- GHIDRA: <set_Value>b__4_1 ---
		float UI_Elements_ProgressBars_ProgressBarLiquidWithEdge___set_Value_b__4_1
		                (int param1,undefined4 param2)
		
		{
		  return *(float *)(*(int *)(param1 + 0x24) + 0xc0);
		}
		*/

		/* --- GHIDRA: OnValidateSafety ---
		void UI_Elements_ProgressBars_ProgressBarLiquidWithEdge__OnValidateSafety
		               (int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a6397c == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Core_DOGetter_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Core_DOSetter_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_ProgressBars_ProgressBarLiquidWithEdge__set_Value_b__4_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_ProgressBars_ProgressBarLiquidWithEdge__set_Value_b__4_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_ProgressBars_ProgressBarLiquidWithEdge__set_Value_b__4_2__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_ProgressBars_ProgressBarLiquidWithEdge__set_Value_b__4_3__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_float__float__FloatOptions____
		              );
		    DAT_ram_00a6397c = '\x01';
		  }
		  if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Application_TypeInfo);
		  }
		  iVar1 = func_ii_3441(0);
		  if (iVar1 == 0) {
		    UnityEngine_UI_Scrollbar__get_value(*(undefined4 *)(param1 + 0x10),param2,0);
		    UnityEngine_UI_Scrollbar__get_size(*(undefined4 *)(param1 + 0x24),param2,0);
		    return;
		  }
		  uVar2 = unnamed_function_1417(DG_Tweening_Core_DOGetter_float__TypeInfo);
		  DG_Tweening_Core_DOGetter_Rect___Invoke
		            (uVar2,param1,
		             Method_UI_Elements_ProgressBars_ProgressBarLiquidWithEdge__set_Value_b__4_0__,0);
		  uVar3 = unnamed_function_1417(DG_Tweening_Core_DOSetter_float__TypeInfo);
		  DG_Tweening_Core_DOSetter_Rect___Invoke
		            (uVar3,param1,
		             Method_UI_Elements_ProgressBars_ProgressBarLiquidWithEdge__set_Value_b__4_1__,0);
		  if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		    func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		  }
		  uVar2 = DG_Tweening_DOTween__ManualUpdate(uVar2,uVar3,param2,1.0,0);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		            (uVar2,uVar3,
		             Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_float__float__FloatOptions____
		            );
		  uVar2 = unnamed_function_1417(DG_Tweening_Core_DOGetter_float__TypeInfo);
		  DG_Tweening_Core_DOGetter_Rect___Invoke
		            (uVar2,param1,
		             Method_UI_Elements_ProgressBars_ProgressBarLiquidWithEdge__set_Value_b__4_2__,0);
		  uVar3 = unnamed_function_1417(DG_Tweening_Core_DOSetter_float__TypeInfo);
		  DG_Tweening_Core_DOSetter_Rect___Invoke
		            (uVar3,param1,
		             Method_UI_Elements_ProgressBars_ProgressBarLiquidWithEdge__set_Value_b__4_3__,0);
		  uVar2 = DG_Tweening_DOTween__ManualUpdate(uVar2,uVar3,param2,1.0,0);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		            (uVar2,uVar3,
		             Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_float__float__FloatOptions____
		            );
		  return;
		}
		*/

		}

		// Token: 0x170001C6 RID: 454
		// (set) Token: 0x06000D7E RID: 3454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C6")]
		public override float Value
		{
			[Token(Token = "0x6000D7E")]
			[Address(RVA = "0x6061", Offset = "0x6061", VA = "0x6061", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D7F")]
		[Address(RVA = "0x6062", Offset = "0x6062", VA = "0x6062")]
		public ProgressBarLiquidWithEdge()
		{
		}

		// Token: 0x040006B6 RID: 1718
		[Token(Token = "0x40006B6")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _value;

		// Token: 0x040006B7 RID: 1719
		[Token(Token = "0x40006B7")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Scrollbar _fillScrollbar;
	}
}
