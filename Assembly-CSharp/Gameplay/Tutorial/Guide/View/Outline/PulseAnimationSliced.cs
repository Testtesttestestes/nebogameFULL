using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View.Outline
{
	// Token: 0x0200046F RID: 1135
	[Token(Token = "0x200046F")]
	public class PulseAnimationSliced : AbstractGuideOutline
	{
		// Token: 0x06001AEB RID: 6891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AEB")]
		[Address(RVA = "0x6C75", Offset = "0x6C75", VA = "0x6C75", Slot = "4")]
		protected override void HandleSizeChanged(float width, float height)
		{
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AEC")]
		[Address(RVA = "0x6C76", Offset = "0x6C76", VA = "0x6C76", Slot = "5")]
		public override void StartAnimation(float delay)
		{
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AED")]
		[Address(RVA = "0x6C77", Offset = "0x6C77", VA = "0x6C77", Slot = "6")]
		public override void StopAnimation()
		{
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AEE")]
		[Address(RVA = "0x6C78", Offset = "0x6C78", VA = "0x6C78")]
		public PulseAnimationSliced()
		{
		}

		// Token: 0x04000E7D RID: 3709
		[Token(Token = "0x4000E7D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _indent;

		// Token: 0x04000E7E RID: 3710
		[Token(Token = "0x4000E7E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PulseAnimation _animation;
	}
}
