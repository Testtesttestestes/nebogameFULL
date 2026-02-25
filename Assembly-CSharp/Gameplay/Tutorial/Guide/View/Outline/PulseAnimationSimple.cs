using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View.Outline
{
	// Token: 0x0200046E RID: 1134
	[Token(Token = "0x200046E")]
	public class PulseAnimationSimple : AbstractGuideOutline
	{
		// Token: 0x06001AE7 RID: 6887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE7")]
		[Address(RVA = "0x6C71", Offset = "0x6C71", VA = "0x6C71", Slot = "5")]
		public override void StartAnimation(float delay)
		{
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE8")]
		[Address(RVA = "0x6C72", Offset = "0x6C72", VA = "0x6C72", Slot = "6")]
		public override void StopAnimation()
		{
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE9")]
		[Address(RVA = "0x6C73", Offset = "0x6C73", VA = "0x6C73", Slot = "4")]
		protected override void HandleSizeChanged(float width, float height)
		{
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AEA")]
		[Address(RVA = "0x6C74", Offset = "0x6C74", VA = "0x6C74")]
		public PulseAnimationSimple()
		{
		}

		// Token: 0x04000E7A RID: 3706
		[Token(Token = "0x4000E7A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _textureSize;

		// Token: 0x04000E7B RID: 3707
		[Token(Token = "0x4000E7B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _indent;

		// Token: 0x04000E7C RID: 3708
		[Token(Token = "0x4000E7C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private PulseAnimation _animation;
	}
}
