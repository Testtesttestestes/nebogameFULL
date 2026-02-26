using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Combat.View.Tweens
{
	// Token: 0x02000932 RID: 2354
	[Token(Token = "0x2000932")]
	public class PulsatingTweener : MonoBehaviour
	{
		// Token: 0x0600378A RID: 14218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600378A")]
		[Address(RVA = "0x8775", Offset = "0x8775", VA = "0x8775")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void Gameplay_Combat_View_Tweens_PulsatingTweener__OnEnable(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x24) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x24),1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600378B RID: 14219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600378B")]
		[Address(RVA = "0x8776", Offset = "0x8776", VA = "0x8776")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void Gameplay_Combat_View_Tweens_PulsatingTweener__OnDisable(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0x1c) = 0x140000000;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600378C RID: 14220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600378C")]
		[Address(RVA = "0x8777", Offset = "0x8777", VA = "0x8777")]
		public PulsatingTweener()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_Tweens_PulsatingTweener___ctor(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  
		  iVar1 = *(int *)(*(int *)(param1 + 0x10) + 0xc);
		  if (0 < iVar1) {
		    param2_00 = 0;
		    do {
		      Gameplay_Combat_View_Tweens_FromToTweener__Rollback
		                (*(undefined4 *)(*(int *)(param1 + 0x10) + param2_00 * 4 + 0x10),param2_00);
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x04001EA8 RID: 7848
		[Token(Token = "0x4001EA8")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector3 _to;

		// Token: 0x04001EA9 RID: 7849
		[Token(Token = "0x4001EA9")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _period;

		// Token: 0x04001EAA RID: 7850
		[Token(Token = "0x4001EAA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Ease _ease;

		// Token: 0x04001EAB RID: 7851
		[Token(Token = "0x4001EAB")]
		[FieldOffset(Offset = "0x24")]
		private Tween _scaleTween;
	}
}
