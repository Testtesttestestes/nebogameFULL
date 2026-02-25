using System;
using Il2CppDummyDll;
using UI.Elements.ProgressBars;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Preloader
{
	// Token: 0x020001CF RID: 463
	[Token(Token = "0x20001CF")]
	public class PreloaderProgressBar : ProgressBarWithText
	{
		// Token: 0x06000C25 RID: 3109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x5F34", Offset = "0x5F34", VA = "0x5F34", Slot = "4")]
		protected override void OnValidateSafety()
		{
		}

		// Token: 0x17000194 RID: 404
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000194")]
		public override float Value
		{
			[Token(Token = "0x6000C26")]
			[Address(RVA = "0x5F35", Offset = "0x5F35", VA = "0x5F35", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x5F36", Offset = "0x5F36", VA = "0x5F36")]
		private void Awake()
		{
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x5F37", Offset = "0x5F37", VA = "0x5F37")]
		private void UpdateSize()
		{
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x5F38", Offset = "0x5F38", VA = "0x5F38")]
		private void TweenValue(float toValue, Scrollbar bar, float duration)
		{
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0x5F39", Offset = "0x5F39", VA = "0x5F39")]
		public PreloaderProgressBar()
		{
		}

		// Token: 0x040005CF RID: 1487
		[Token(Token = "0x40005CF")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _value;

		// Token: 0x040005D0 RID: 1488
		[Token(Token = "0x40005D0")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _fillWidth;

		// Token: 0x040005D1 RID: 1489
		[Token(Token = "0x40005D1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _fillOffset;

		// Token: 0x040005D2 RID: 1490
		[Token(Token = "0x40005D2")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _duration;
	}
}
