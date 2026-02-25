using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Animations
{
	// Token: 0x02000259 RID: 601
	[Token(Token = "0x2000259")]
	public class ShineEffect : MonoBehaviour
	{
		// Token: 0x06000E85 RID: 3717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E85")]
		[Address(RVA = "0x6106", Offset = "0x6106", VA = "0x6106")]
		private void Update()
		{
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E86")]
		[Address(RVA = "0x6107", Offset = "0x6107", VA = "0x6107")]
		public ShineEffect()
		{
		}

		// Token: 0x0400074A RID: 1866
		[Token(Token = "0x400074A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _speed;

		// Token: 0x0400074B RID: 1867
		[Token(Token = "0x400074B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _image;

		// Token: 0x0400074C RID: 1868
		[Token(Token = "0x400074C")]
		[FieldOffset(Offset = "0x18")]
		private float _timer;

		// Token: 0x0400074D RID: 1869
		[Token(Token = "0x400074D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int ShineLocationId;
	}
}
