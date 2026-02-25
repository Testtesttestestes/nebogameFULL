using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UI.Elements.ProgressBars;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Combat.View
{
	// Token: 0x02000919 RID: 2329
	[Token(Token = "0x2000919")]
	public class CombatProgressBar : ProgressBarWithText
	{
		// Token: 0x060036E0 RID: 14048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E0")]
		[Address(RVA = "0x86CF", Offset = "0x86CF", VA = "0x86CF")]
		private void OnDestroy()
		{
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E1")]
		[Address(RVA = "0x86D0", Offset = "0x86D0", VA = "0x86D0")]
		private void StopTween()
		{
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E2")]
		[Address(RVA = "0x86D1", Offset = "0x86D1", VA = "0x86D1")]
		private void TweenValue(float toValue, Scrollbar bar, float duration)
		{
		}

		// Token: 0x17000AD4 RID: 2772
		// (set) Token: 0x060036E3 RID: 14051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD4")]
		public override float Value
		{
			[Token(Token = "0x60036E3")]
			[Address(RVA = "0x86D2", Offset = "0x86D2", VA = "0x86D2", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E4")]
		[Address(RVA = "0x86D3", Offset = "0x86D3", VA = "0x86D3")]
		public CombatProgressBar()
		{
		}

		// Token: 0x04001E0F RID: 7695
		[Token(Token = "0x4001E0F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Scrollbar _scrollbarSeccond;

		// Token: 0x04001E10 RID: 7696
		[Token(Token = "0x4001E10")]
		[FieldOffset(Offset = "0x24")]
		private float _slaveDuration;

		// Token: 0x04001E11 RID: 7697
		[Token(Token = "0x4001E11")]
		[FieldOffset(Offset = "0x28")]
		private float _masterDuration;

		// Token: 0x04001E12 RID: 7698
		[Token(Token = "0x4001E12")]
		[FieldOffset(Offset = "0x2C")]
		private List<Tweener> _currentTweens;
	}
}
