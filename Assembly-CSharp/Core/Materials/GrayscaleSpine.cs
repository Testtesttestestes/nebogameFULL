using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.Materials
{
	// Token: 0x02000EBE RID: 3774
	[Token(Token = "0x2000EBE")]
	public class GrayscaleSpine
	{
		// Token: 0x06005C06 RID: 23558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C06")]
		[Address(RVA = "0xA8C2", Offset = "0xA8C2", VA = "0xA8C2")]
		public GrayscaleSpine(MeshRenderer meshRenderer)
		{
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x06005C07 RID: 23559 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012AB")]
		private MaterialPropertyBlock MaterialPropertyBlock
		{
			[Token(Token = "0x6005C07")]
			[Address(RVA = "0xA8C3", Offset = "0xA8C3", VA = "0xA8C3")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005C08 RID: 23560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C08")]
		[Address(RVA = "0xA8C4", Offset = "0xA8C4", VA = "0xA8C4")]
		public void SetGrayscale(float value, ref MaterialType materialType)
		{
		}

		// Token: 0x0400324C RID: 12876
		[Token(Token = "0x400324C")]
		[FieldOffset(Offset = "0x8")]
		private float _grayscale;

		// Token: 0x0400324D RID: 12877
		[Token(Token = "0x400324D")]
		[FieldOffset(Offset = "0xC")]
		private readonly MeshRenderer _meshRenderer;

		// Token: 0x0400324E RID: 12878
		[Token(Token = "0x400324E")]
		[FieldOffset(Offset = "0x10")]
		private MaterialPropertyBlock _materialPropertyBlock;
	}
}
