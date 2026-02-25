using System;
using Core.Animations;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;

namespace Core.Materials
{
	// Token: 0x02000EBF RID: 3775
	[Token(Token = "0x2000EBF")]
	public class GrayscaleSpineUI : IDisposable
	{
		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x06005C09 RID: 23561 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012AC")]
		private SkeletonGraphic SkeletonGraphic
		{
			[Token(Token = "0x6005C09")]
			[Address(RVA = "0xA8C5", Offset = "0xA8C5", VA = "0xA8C5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x06005C0A RID: 23562 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012AD")]
		private Material CachedMaterial
		{
			[Token(Token = "0x6005C0A")]
			[Address(RVA = "0xA8C6", Offset = "0xA8C6", VA = "0xA8C6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005C0B RID: 23563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C0B")]
		[Address(RVA = "0xA8C7", Offset = "0xA8C7", VA = "0xA8C7")]
		public GrayscaleSpineUI(ISkeletonGraphicProvider skeletonGraphicProvider)
		{
		}

		// Token: 0x06005C0C RID: 23564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C0C")]
		[Address(RVA = "0xA8C8", Offset = "0xA8C8", VA = "0xA8C8")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x06005C0D RID: 23565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C0D")]
		[Address(RVA = "0xA8C9", Offset = "0xA8C9", VA = "0xA8C9", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0400324F RID: 12879
		[Token(Token = "0x400324F")]
		[FieldOffset(Offset = "0x8")]
		private float _grayscale;

		// Token: 0x04003250 RID: 12880
		[Token(Token = "0x4003250")]
		[FieldOffset(Offset = "0xC")]
		private Material _cachedMaterial;

		// Token: 0x04003251 RID: 12881
		[Token(Token = "0x4003251")]
		[FieldOffset(Offset = "0x10")]
		private ISkeletonGraphicProvider _skeletonGraphicProvider;
	}
}
