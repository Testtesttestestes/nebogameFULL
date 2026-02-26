using System;
using GAFInternal.Assets;
using Il2CppDummyDll;

namespace GAF.Assets
{
	// Token: 0x020013E3 RID: 5091
	[Token(Token = "0x20013E3")]
	[Serializable]
	public class GAFAnimationAsset : GAFAnimationAssetInternal
	{
		// Token: 0x0600797F RID: 31103 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600797F")]
		[Address(RVA = "0xC25E", Offset = "0xC25E", VA = "0xC25E")]
		public new GAFTexturesResourceInternal getResource(float _Scale, float _CSF)
		{
		/* --- GHIDRA: getResource ---
		void GAF_Assets_GAFAnimationAsset__getResource(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54ead == '\0') {
		    Mono_Security_ASN1__get_Item(&GAFInternal_Assets_GAFAnimationAssetInternal_TypeInfo);
		    DAT_ram_00a54ead = '\x01';
		  }
		  if (*(int *)(GAFInternal_Assets_GAFAnimationAssetInternal_TypeInfo + 0x74) == 0) {
		    func_ii_306000(GAFInternal_Assets_GAFAnimationAssetInternal_TypeInfo);
		  }
		  GAFInternal_Assets_GAFAnimationAssetInternal__upgrade(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06007980 RID: 31104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007980")]
		[Address(RVA = "0xC25F", Offset = "0xC25F", VA = "0xC25F")]
		public GAFAnimationAsset()
		{
		/* --- GHIDRA: .ctor ---
		void GAF_Assets_GAFAnimationAsset___ctor(undefined4 param1,undefined4 param2)
		
		{
		  GAFInternal_Assets_GAFTexturesResourceInternal__set_currentDataPath(param1,0);
		  return;
		}
		*/

		}
	}
}
