using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Tweens
{
	// Token: 0x02000134 RID: 308
	[Token(Token = "0x2000134")]
	internal class TweeningValue : MonoBehaviour
	{
		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x17000137")]
		public float Value
		{
			[Token(Token = "0x600094F")]
			[Address(RVA = "0x5CC9", Offset = "0x5CC9", VA = "0x5CC9")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000138")]
		public RectTransform ValueTransform
		{
			[Token(Token = "0x6000950")]
			[Address(RVA = "0x5CCA", Offset = "0x5CCA", VA = "0x5CCA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000139")]
		public RectTransform RectTransform
		{
			[Token(Token = "0x6000951")]
			[Address(RVA = "0x5CCB", Offset = "0x5CCB", VA = "0x5CCB")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x5CCC", Offset = "0x5CCC", VA = "0x5CCC")]
		private IEnumerator SetValue(float value, float duration)
		{
			return null;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x5CCD", Offset = "0x5CCD", VA = "0x5CCD")]
		private void Display(float value)
		{
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x5CCE", Offset = "0x5CCE", VA = "0x5CCE")]
		public void SetValueImmediately(float value)
		{
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x5CCF", Offset = "0x5CCF", VA = "0x5CCF")]
		public IEnumerator SetValue(float value)
		{
			return null;
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x5CD0", Offset = "0x5CD0", VA = "0x5CD0")]
		public TweeningValue()
		{
		}

		// Token: 0x04000376 RID: 886
		[Token(Token = "0x4000376")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _textField;

		// Token: 0x04000377 RID: 887
		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private List<RewardToBalanceTweener.DurationCfg> _durations;

		// Token: 0x04000378 RID: 888
		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Ease _easeForAdditionValue;

		// Token: 0x04000379 RID: 889
		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Ease _easeForScale;

		// Token: 0x0400037A RID: 890
		[Token(Token = "0x400037A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _scaleDuration;

		// Token: 0x0400037B RID: 891
		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _scale;

		// Token: 0x0400037C RID: 892
		[Token(Token = "0x400037C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _numberPrefix;

		// Token: 0x0400037D RID: 893
		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x2C")]
		private RectTransform _rectTransform;

		// Token: 0x0400037E RID: 894
		[Token(Token = "0x400037E")]
		[FieldOffset(Offset = "0x30")]
		private float _value;
	}
}
