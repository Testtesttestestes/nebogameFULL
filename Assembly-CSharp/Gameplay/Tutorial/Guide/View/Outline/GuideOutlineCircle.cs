using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View.Outline
{
	// Token: 0x0200046A RID: 1130
	[Token(Token = "0x200046A")]
	public class GuideOutlineCircle : AbstractGuideOutline
	{
		// Token: 0x06001AD4 RID: 6868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD4")]
		[Address(RVA = "0x6C5E", Offset = "0x6C5E", VA = "0x6C5E", Slot = "4")]
		protected override void HandleSizeChanged(float width, float height)
		{
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD5")]
		[Address(RVA = "0x6C5F", Offset = "0x6C5F", VA = "0x6C5F", Slot = "5")]
		public override void StartAnimation(float delay)
		{
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD6")]
		[Address(RVA = "0x6C60", Offset = "0x6C60", VA = "0x6C60")]
		private void StartAnimationInternal()
		{
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD7")]
		[Address(RVA = "0x6C61", Offset = "0x6C61", VA = "0x6C61", Slot = "6")]
		public override void StopAnimation()
		{
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD8")]
		[Address(RVA = "0x6C62", Offset = "0x6C62", VA = "0x6C62")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD9")]
		[Address(RVA = "0x6C63", Offset = "0x6C63", VA = "0x6C63")]
		public GuideOutlineCircle()
		{
		}

		// Token: 0x04000E6B RID: 3691
		[Token(Token = "0x4000E6B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ParticleSystem _psIdle;

		// Token: 0x04000E6C RID: 3692
		[Token(Token = "0x4000E6C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticleSystem _psMain;

		// Token: 0x04000E6D RID: 3693
		[Token(Token = "0x4000E6D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _particlesPerPixel;

		// Token: 0x04000E6E RID: 3694
		[Token(Token = "0x4000E6E")]
		[FieldOffset(Offset = "0x20")]
		private Tween _delayedCall;
	}
}
