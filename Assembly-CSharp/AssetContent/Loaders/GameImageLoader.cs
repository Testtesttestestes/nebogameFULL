using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace AssetContent.Loaders
{
	// Token: 0x02000E30 RID: 3632
	[Token(Token = "0x2000E30")]
	[DisallowMultipleComponent]
	public class GameImageLoader : AbstractGameGraphicLoader<Image, Sprite>
	{
		// Token: 0x060058FF RID: 22783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058FF")]
		[Address(RVA = "0xA653", Offset = "0xA653", VA = "0xA653", Slot = "11")]
		public override void SetAsset(Sprite asset)
		{
		/* --- GHIDRA: SetAsset ---
		void AssetContent_Loaders_GameImageLoader__SetAsset
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a63bf2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourcesManager_TypeInfo);
		    DAT_ram_00a63bf2 = '\x01';
		  }
		  if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		  }
		  Core_GameResources_GameResourcesManager__ReleaseAudioClip(param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06005900 RID: 22784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005900")]
		[Address(RVA = "0xA654", Offset = "0xA654", VA = "0xA654", Slot = "12")]
		public override void ReleaseAsset(string url)
		{
		/* --- GHIDRA: ReleaseAsset ---
		void AssetContent_Loaders_GameImageLoader__ReleaseAsset
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63bf3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourcesManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_GameResources_GameResourcesManager_ResourceFailedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_GameResources_GameResourcesManager_SpriteReadyDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_Loaders_GameImageLoader___c__DisplayClass2_0__LoadAsset_b__0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_Loaders_GameImageLoader___c__DisplayClass2_0__LoadAsset_b__1__);
		    Mono_Security_ASN1__get_Item
		              (&AssetContent_Loaders_GameImageLoader___c__DisplayClass2_0_TypeInfo);
		    DAT_ram_00a63bf3 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (AssetContent_Loaders_GameImageLoader___c__DisplayClass2_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 0xc) = param4;
		  *(undefined4 *)(param2_00 + 8) = param3;
		  param1_00 = unnamed_function_1417
		                        (Core_GameResources_GameResourcesManager_SpriteReadyDelegate_TypeInfo);
		  Core_GameResources_GameResourcesManager_TextureReadyDelegate__EndInvoke
		            (param1_00,param2_00,
		             Method_AssetContent_Loaders_GameImageLoader___c__DisplayClass2_0__LoadAsset_b__0__,0);
		  param1_01 = unnamed_function_1417
		                        (Core_GameResources_GameResourcesManager_ResourceFailedDelegate_TypeInfo);
		  Core_GameResources_GameResourcesManager_SpriteAtlasReadyDelegate___ctor
		            (param1_01,param2_00,
		             Method_AssetContent_Loaders_GameImageLoader___c__DisplayClass2_0__LoadAsset_b__1__,0);
		  if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		  }
		  Core_GameResources_GameResourcesManager__ReleaseTexture(param2,param1_00,param1_01,param5,0);
		  return;
		}
		*/

		}

		// Token: 0x06005901 RID: 22785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005901")]
		[Address(RVA = "0xA655", Offset = "0xA655", VA = "0xA655", Slot = "13")]
		public override void LoadAsset(string url, Action<Sprite, string> successCallback, Action<string> failCallback, bool saveOnDisk)
		{
		/* --- GHIDRA: LoadAsset ---
		void AssetContent_Loaders_GameImageLoader__LoadAsset(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63bf4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite___ctor__);
		    DAT_ram_00a63bf4 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06005902 RID: 22786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005902")]
		[Address(RVA = "0xA656", Offset = "0xA656", VA = "0xA656")]
		public GameImageLoader()
		{
		}
	}
}
