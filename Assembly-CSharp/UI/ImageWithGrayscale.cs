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
		/* --- GHIDRA: SetGrayscale ---
		void UI_ImageWithGrayscale__SetGrayscale(int param1,undefined4 param2)
		
		{
		  UnityEngine_UI_Graphic__OnDisable(param1,0);
		  if (*(int *)(param1 + 0xb0) != 0) {
		    Core_Materials_GrayscaleUI__SetGrayscale(*(int *)(param1 + 0xb0),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085C")]
		[Address(RVA = "0x5C12", Offset = "0x5C12", VA = "0x5C12", Slot = "8")]
		protected override void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_ImageWithGrayscale__OnDestroy(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b87f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_UI_Image_TypeInfo);
		    DAT_ram_00a5b87f = '\x01';
		  }
		  if (*(int *)(UnityEngine_UI_Image_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_UI_Image_TypeInfo);
		  }
		  UnityEngine_UI_Image__set_useSpriteMesh(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x5C13", Offset = "0x5C13", VA = "0x5C13")]
		public ImageWithGrayscale()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 UI_ImageWithGrayscale___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b880 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12657);
		    DAT_ram_00a5b880 = '\x01';
		  }
		  return StringLiteral_12657;
		}
		*/

		}

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0xB0")]
		private GrayscaleUI _grayscale;
	}
}
