using System;
using Core.Materials;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UI
{
	// Token: 0x02000110 RID: 272
	[Token(Token = "0x2000110")]
	public class RawImageWithGrayscale : RawImage, IGrayscalable, IMaterialProvider
	{
		// Token: 0x060008A6 RID: 2214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x1C11", Offset = "0x1C11", VA = "0x1C11", Slot = "65")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x5C36", Offset = "0x5C36", VA = "0x5C36", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x5C37", Offset = "0x5C37", VA = "0x5C37")]
		public RawImageWithGrayscale()
		{
		}

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x94")]
		private GrayscaleUI _grayscale;
	}
}
