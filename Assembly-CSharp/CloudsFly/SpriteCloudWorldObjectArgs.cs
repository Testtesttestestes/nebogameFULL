using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x02001308 RID: 4872
	[Token(Token = "0x2001308")]
	public abstract class SpriteCloudWorldObjectArgs : WorldObjectArgs
	{
		// Token: 0x060073DE RID: 29662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073DE")]
		[Address(RVA = "0xBDC1", Offset = "0xBDC1", VA = "0xBDC1")]
		protected SpriteCloudWorldObjectArgs(Vector3 position, Func<float, float, float> randomRange, Sprite sprite, float cloudDistance, float cloudStepDistance)
		{
		}

		// Token: 0x04003CAE RID: 15534
		[Token(Token = "0x4003CAE")]
		[FieldOffset(Offset = "0x18")]
		public readonly Sprite Sprite;

		// Token: 0x04003CAF RID: 15535
		[Token(Token = "0x4003CAF")]
		[FieldOffset(Offset = "0x1C")]
		public readonly float CloudDistance;

		// Token: 0x04003CB0 RID: 15536
		[Token(Token = "0x4003CB0")]
		[FieldOffset(Offset = "0x20")]
		public readonly float CloudStepDistance;
	}
}
