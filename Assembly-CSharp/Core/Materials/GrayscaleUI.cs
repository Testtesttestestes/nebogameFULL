using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.Materials
{
	// Token: 0x02000EC0 RID: 3776
	[Token(Token = "0x2000EC0")]
	public class GrayscaleUI : IDisposable
	{
		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x06005C0E RID: 23566 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012AE")]
		private Material CachedMaterial
		{
			[Token(Token = "0x6005C0E")]
			[Address(RVA = "0xA8CA", Offset = "0xA8CA", VA = "0xA8CA")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005C0F RID: 23567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C0F")]
		[Address(RVA = "0xA8CB", Offset = "0xA8CB", VA = "0xA8CB")]
		public GrayscaleUI(IMaterialProvider materialProvider)
		{
		}

		// Token: 0x06005C10 RID: 23568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C10")]
		[Address(RVA = "0xA8CC", Offset = "0xA8CC", VA = "0xA8CC")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x06005C11 RID: 23569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C11")]
		[Address(RVA = "0xA8CD", Offset = "0xA8CD", VA = "0xA8CD", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04003252 RID: 12882
		[Token(Token = "0x4003252")]
		[FieldOffset(Offset = "0x8")]
		private float _grayscale;

		// Token: 0x04003253 RID: 12883
		[Token(Token = "0x4003253")]
		[FieldOffset(Offset = "0xC")]
		private readonly IMaterialProvider _materialProvider;

		// Token: 0x04003254 RID: 12884
		[Token(Token = "0x4003254")]
		[FieldOffset(Offset = "0x10")]
		private Material _cachedMaterial;
	}
}
