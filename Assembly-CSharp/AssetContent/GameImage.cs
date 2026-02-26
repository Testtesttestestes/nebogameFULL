using System;
using AssetContent.Loaders;
using Core;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace AssetContent
{
	// Token: 0x02000E2D RID: 3629
	[Token(Token = "0x2000E2D")]
	[RequireComponent(typeof(GameImageLoader))]
	public class GameImage : ImageWithGrayscale, IGameAssetContent
	{
		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x060058E0 RID: 22752 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060058E1 RID: 22753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700121A")]
		public string AssetId
		{
			[Token(Token = "0x60058E0")]
			[Address(RVA = "0xA648", Offset = "0xA648", VA = "0xA648", Slot = "92")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058E1")]
			[Address(RVA = "0xA649", Offset = "0xA649", VA = "0xA649", Slot = "93")]
			set
			{
			}
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x060058E2 RID: 22754 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060058E3 RID: 22755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700121B")]
		public string AssetPath
		{
			[Token(Token = "0x60058E2")]
			[Address(RVA = "0xA64A", Offset = "0xA64A", VA = "0xA64A", Slot = "94")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058E3")]
			[Address(RVA = "0xA64B", Offset = "0xA64B", VA = "0xA64B")]
			set
			{
			}
		}

		// Token: 0x060058E4 RID: 22756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058E4")]
		[Address(RVA = "0xA64C", Offset = "0xA64C", VA = "0xA64C")]
		private void ValidateLoader()
		{
		/* --- GHIDRA: ValidateLoader ---
		void AssetContent_GameImage__ValidateLoader(undefined4 param1,undefined4 param2)
		
		{
		  UI_ImageWithGrayscale__OnDestroy(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058E5")]
		[Address(RVA = "0xA64D", Offset = "0xA64D", VA = "0xA64D")]
		public GameImage()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 AssetContent_GameImage___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63bec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__get_AssetId__
		              );
		    DAT_ram_00a63bec = '\x01';
		  }
		  if (DAT_ram_00a63bf0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_GameRawImageLoader___);
		    DAT_ram_00a63bf0 = '\x01';
		  }
		  if (*(int *)(param1 + 0x98) != 0) {
		    return *(undefined4 *)(*(int *)(param1 + 0x98) + 0x14);
		  }
		  iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_GameRawImageLoader___);
		  *(int *)(param1 + 0x98) = iVar1;
		  return *(undefined4 *)(iVar1 + 0x14);
		}
		*/

		}

		// Token: 0x0400300A RID: 12298
		[Token(Token = "0x400300A")]
		[FieldOffset(Offset = "0xB4")]
		private GameImageLoader _gameImageLoader;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_AssetId ---
		void AssetContent_GameImage__get_AssetId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63be8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__set_AssetId__);
		    DAT_ram_00a63be8 = '\x01';
		  }
		  if (DAT_ram_00a63beb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_GameImageLoader___);
		    DAT_ram_00a63beb = '\x01';
		  }
		  if (*(int *)(param1 + 0xb4) == 0) {
		    param1_00 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_GameImageLoader___);
		    *(undefined4 *)(param1 + 0xb4) = param1_00;
		  }
		  else {
		    param1_00 = *(undefined4 *)(param1 + 0xb4);
		  }
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (param1_00,param2,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__set_AssetId__);
		  return;
		}
		*/


		/* --- GHIDRA: set_AssetId ---
		undefined4 AssetContent_GameImage__set_AssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63be9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__get_AssetPath__
		              );
		    DAT_ram_00a63be9 = '\x01';
		  }
		  if (DAT_ram_00a63beb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_GameImageLoader___);
		    DAT_ram_00a63beb = '\x01';
		  }
		  if (*(int *)(param1 + 0xb4) != 0) {
		    return *(undefined4 *)(*(int *)(param1 + 0xb4) + 0x18);
		  }
		  iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_GameImageLoader___);
		  *(int *)(param1 + 0xb4) = iVar1;
		  return *(undefined4 *)(iVar1 + 0x18);
		}
		*/


		/* --- GHIDRA: get_AssetPath ---
		void AssetContent_GameImage__get_AssetPath(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63bea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__set_AssetPath__
		              );
		    DAT_ram_00a63bea = '\x01';
		  }
		  if (DAT_ram_00a63beb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_GameImageLoader___);
		    DAT_ram_00a63beb = '\x01';
		  }
		  if (*(int *)(param1 + 0xb4) == 0) {
		    param1_00 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_GameImageLoader___);
		    *(undefined4 *)(param1 + 0xb4) = param1_00;
		  }
		  else {
		    param1_00 = *(undefined4 *)(param1 + 0xb4);
		  }
		  Core_Extensions_Dict_AprDicExt__GetImageListAssetId
		            (param1_00,param2,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__set_AssetPath__);
		  return;
		}
		*/


		/* --- GHIDRA: set_AssetPath ---
		void AssetContent_GameImage__set_AssetPath(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63beb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_GameImageLoader___);
		    DAT_ram_00a63beb = '\x01';
		  }
		  if (*(int *)(param1 + 0xb4) == 0) {
		    uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_GameImageLoader___);
		    *(undefined4 *)(param1 + 0xb4) = uVar1;
		  }
		  return;
		}
		*/

}
