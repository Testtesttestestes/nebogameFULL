using System;
using Core.Data;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Inventory.View
{
	// Token: 0x02000656 RID: 1622
	[Token(Token = "0x2000656")]
	[RequireComponent(typeof(RawImage))]
	public class ArtifactStatusDisplay : MonoBehaviour
	{
		// Token: 0x06002752 RID: 10066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002752")]
		[Address(RVA = "0x7885", Offset = "0x7885", VA = "0x7885")]
		public void DisplayStatusIfNeeded(ArtifactData artifactData)
		{
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002753")]
		[Address(RVA = "0x7886", Offset = "0x7886", VA = "0x7886")]
		public ArtifactStatusDisplay()
		{
		}

		// Token: 0x04001587 RID: 5511
		[Token(Token = "0x4001587")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RawImage _rawImage;

		// Token: 0x04001588 RID: 5512
		[Token(Token = "0x4001588")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Texture _brokenTexture;

		// Token: 0x04001589 RID: 5513
		[Token(Token = "0x4001589")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Texture _timeTexture;

		// Token: 0x0400158A RID: 5514
		[Token(Token = "0x400158A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Texture _restorableTexture;
	}
}
