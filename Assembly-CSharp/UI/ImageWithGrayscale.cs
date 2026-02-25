using System;
using Core.Materials;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UI
{
	// Token: 0x020000FE RID: 254
	[Token(Token = "0x20000FE")]
	public class ImageWithGrayscale : Image, IGrayscalable, IMaterialProvider
	{
		// Token: 0x0600085B RID: 2139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x5C11", Offset = "0x5C11", VA = "0x5C11", Slot = "89")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085C")]
		[Address(RVA = "0x5C12", Offset = "0x5C12", VA = "0x5C12", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x5C13", Offset = "0x5C13", VA = "0x5C13")]
		public ImageWithGrayscale()
		{
		}

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0xB0")]
		private GrayscaleUI _grayscale;
	}
}
