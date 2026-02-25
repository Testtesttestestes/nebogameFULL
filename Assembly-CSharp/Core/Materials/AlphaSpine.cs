using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.Materials
{
	// Token: 0x02000EBD RID: 3773
	[Token(Token = "0x2000EBD")]
	public class AlphaSpine
	{
		// Token: 0x06005C03 RID: 23555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C03")]
		[Address(RVA = "0xA8BF", Offset = "0xA8BF", VA = "0xA8BF")]
		public AlphaSpine(MeshRenderer meshRenderer)
		{
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x06005C04 RID: 23556 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012AA")]
		private MaterialPropertyBlock MaterialPropertyBlock
		{
			[Token(Token = "0x6005C04")]
			[Address(RVA = "0xA8C0", Offset = "0xA8C0", VA = "0xA8C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005C05 RID: 23557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C05")]
		[Address(RVA = "0xA8C1", Offset = "0xA8C1", VA = "0xA8C1")]
		public void SetAlpha(float value, ref MaterialType materialType)
		{
		}

		// Token: 0x04003249 RID: 12873
		[Token(Token = "0x4003249")]
		[FieldOffset(Offset = "0x8")]
		private float _alpha;

		// Token: 0x0400324A RID: 12874
		[Token(Token = "0x400324A")]
		[FieldOffset(Offset = "0xC")]
		private readonly MeshRenderer _meshRenderer;

		// Token: 0x0400324B RID: 12875
		[Token(Token = "0x400324B")]
		[FieldOffset(Offset = "0x10")]
		private MaterialPropertyBlock _materialPropertyBlock;
	}
}
