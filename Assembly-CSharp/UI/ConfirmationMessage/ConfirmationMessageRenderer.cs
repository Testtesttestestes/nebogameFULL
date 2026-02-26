using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using Utils;

namespace UI.ConfirmationMessage
{
	// Token: 0x02000258 RID: 600
	[Token(Token = "0x2000258")]
	public class ConfirmationMessageRenderer : MonoBehaviour
	{
		// Token: 0x06000E82 RID: 3714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E82")]
		[Address(RVA = "0x6103", Offset = "0x6103", VA = "0x6103")]
		public void Show(string message, float duration)
		{
		/* --- GHIDRA: Show ---
		void UI_ConfirmationMessage_ConfirmationMessageRenderer__Show(int param1,undefined4 param2)
		
		{
		  Utils_TweenContainer__StopAllTweens(*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E83")]
		[Address(RVA = "0x6104", Offset = "0x6104", VA = "0x6104")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_ConfirmationMessage_ConfirmationMessageRenderer__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a639c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TweenContainer_TypeInfo);
		    DAT_ram_00a639c5 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_TweenContainer_TypeInfo);
		  Utils_TweenContainer__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E84")]
		[Address(RVA = "0x6105", Offset = "0x6105", VA = "0x6105")]
		public ConfirmationMessageRenderer()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ConfirmationMessage_ConfirmationMessageRenderer___ctor(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  undefined4 param1_00;
		  float fVar2;
		  int iVar3;
		  float param3;
		  
		  if (DAT_ram_00a639c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Animations_ShineEffect_TypeInfo);
		    DAT_ram_00a639c6 = '\x01';
		  }
		  fVar2 = *(float *)(param1 + 0x18);
		  fVar1 = UnityEngine_Time__get_timeAsRational(0);
		  *(float *)(param1 + 0x18) = fVar2 + fVar1 * *(float *)(param1 + 0x10);
		  iVar3 = **(int **)(param1 + 0x14);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x1d0) * 4))
		                        (*(int **)(param1 + 0x14),*(undefined4 *)(iVar3 + 0x1d4));
		  if (*(int *)(UI_Animations_ShineEffect_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UI_Animations_ShineEffect_TypeInfo);
		  }
		  fVar1 = FLOOR(*(float *)(param1 + 0x18) * 0.5);
		  fVar2 = *(float *)(param1 + 0x18) - (fVar1 + fVar1);
		  fVar1 = 2.0;
		  if (fVar2 <= 2.0) {
		    fVar1 = fVar2;
		  }
		  param3 = 0.0;
		  if (0.0 <= fVar2) {
		    param3 = fVar1;
		  }
		  UnityEngine_Material__SetFloat
		            (param1_00,**(undefined4 **)(UI_Animations_ShineEffect_TypeInfo + 0x5c),param3,0);
		  return;
		}
		*/

		}

		// Token: 0x04000747 RID: 1863
		[Token(Token = "0x4000747")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _message;

		// Token: 0x04000748 RID: 1864
		[Token(Token = "0x4000748")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04000749 RID: 1865
		[Token(Token = "0x4000749")]
		[FieldOffset(Offset = "0x18")]
		private TweenContainer _tweenContainer;
	}
}
