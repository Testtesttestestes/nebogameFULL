using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x02001306 RID: 4870
	[Token(Token = "0x2001306")]
	public class TiledSpriteCloudWorldObjectArgs : SpriteCloudWorldObjectArgs
	{
		// Token: 0x060073DC RID: 29660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073DC")]
		[Address(RVA = "0xBDBF", Offset = "0xBDBF", VA = "0xBDBF")]
		public TiledSpriteCloudWorldObjectArgs(Vector3 position, Func<float, float, float> randomRange, Sprite sprite, float cloudDistance, float cloudStepDistance, float size)
		{
		}

		// Token: 0x04003CAD RID: 15533
		[Token(Token = "0x4003CAD")]
		[FieldOffset(Offset = "0x24")]
		public readonly float Size;
	}
}
