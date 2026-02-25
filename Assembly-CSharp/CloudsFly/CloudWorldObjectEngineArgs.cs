using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x020012FC RID: 4860
	[Token(Token = "0x20012FC")]
	[Serializable]
	public class CloudWorldObjectEngineArgs : WorldObjectEngineArgs
	{
		// Token: 0x060073AA RID: 29610 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60073AA")]
		[Address(RVA = "0xBD91", Offset = "0xBD91", VA = "0xBD91", Slot = "4")]
		public override IWorldObjectEngine GetEngine()
		{
			return null;
		}

		// Token: 0x060073AB RID: 29611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073AB")]
		[Address(RVA = "0xBD92", Offset = "0xBD92", VA = "0xBD92")]
		public CloudWorldObjectEngineArgs()
		{
		}

		// Token: 0x04003C90 RID: 15504
		[Token(Token = "0x4003C90")]
		[FieldOffset(Offset = "0x44")]
		public Transform tiledCloudsContainer;

		// Token: 0x04003C91 RID: 15505
		[Token(Token = "0x4003C91")]
		[FieldOffset(Offset = "0x48")]
		public TiledCloudSpriteWorldObject tiledCloudSpritePrefab;

		// Token: 0x04003C92 RID: 15506
		[Token(Token = "0x4003C92")]
		[FieldOffset(Offset = "0x4C")]
		public List<Sprite> tiledSprites;

		// Token: 0x04003C93 RID: 15507
		[Token(Token = "0x4003C93")]
		[FieldOffset(Offset = "0x50")]
		public float cloudStepDistance;
	}
}
