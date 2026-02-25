using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.U2D;

namespace CloudsFly
{
	// Token: 0x020012FF RID: 4863
	[Token(Token = "0x20012FF")]
	public class CloudsVerticalMovementAnimation : MonoBehaviour
	{
		// Token: 0x060073B7 RID: 29623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073B7")]
		[Address(RVA = "0xBD9E", Offset = "0xBD9E", VA = "0xBD9E")]
		private void OnDestroy()
		{
		}

		// Token: 0x060073B8 RID: 29624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073B8")]
		[Address(RVA = "0xBD9F", Offset = "0xBD9F", VA = "0xBD9F")]
		private void Awake()
		{
		}

		// Token: 0x060073B9 RID: 29625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073B9")]
		[Address(RVA = "0xBDA0", Offset = "0xBDA0", VA = "0xBDA0")]
		public void Animate(bool toUp)
		{
		}

		// Token: 0x060073BA RID: 29626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073BA")]
		[Address(RVA = "0xBDA1", Offset = "0xBDA1", VA = "0xBDA1")]
		public void SetAtlas(SpriteAtlas atlas)
		{
		}

		// Token: 0x060073BB RID: 29627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073BB")]
		[Address(RVA = "0xBDA2", Offset = "0xBDA2", VA = "0xBDA2")]
		public CloudsVerticalMovementAnimation()
		{
		}

		// Token: 0x04003C9B RID: 15515
		[Token(Token = "0x4003C9B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _cloudsContainer;

		// Token: 0x04003C9C RID: 15516
		[Token(Token = "0x4003C9C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private int _distance;

		// Token: 0x04003C9D RID: 15517
		[Token(Token = "0x4003C9D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _duration;

		// Token: 0x04003C9E RID: 15518
		[Token(Token = "0x4003C9E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _delay;

		// Token: 0x04003C9F RID: 15519
		[Token(Token = "0x4003C9F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Ease _ease;
	}
}
