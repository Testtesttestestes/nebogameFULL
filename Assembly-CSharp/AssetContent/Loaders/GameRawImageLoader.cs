using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace AssetContent.Loaders
{
	// Token: 0x02000E32 RID: 3634
	[Token(Token = "0x2000E32")]
	[DisallowMultipleComponent]
	public class GameRawImageLoader : AbstractGameGraphicLoader<RawImage, Texture2D>
	{
		// Token: 0x06005906 RID: 22790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005906")]
		[Address(RVA = "0xA65A", Offset = "0xA65A", VA = "0xA65A", Slot = "11")]
		public override void SetAsset(Texture2D asset)
		{
		/* --- GHIDRA: SetAsset ---
		void AssetContent_Loaders_GameRawImageLoader__SetAsset
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a63bf6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourcesManager_TypeInfo);
		    DAT_ram_00a63bf6 = '\x01';
		  }
		  if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		  }
		  Core_GameResources_GameResourcesManager__GetTexture(param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06005907 RID: 22791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005907")]
		[Address(RVA = "0xA65B", Offset = "0xA65B", VA = "0xA65B", Slot = "12")]
		public override void ReleaseAsset(string url)
		{
		/* --- GHIDRA: ReleaseAsset ---
		void AssetContent_Loaders_GameRawImageLoader__ReleaseAsset
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63bf7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourcesManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_GameResources_GameResourcesManager_ResourceFailedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_GameResources_GameResourcesManager_TextureReadyDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_GameRawImageLoader___c__DisplayClass2_0__LoadAsset_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_GameRawImageLoader___c__DisplayClass2_0__LoadAsset_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&AssetContent_Loaders_GameRawImageLoader___c__DisplayClass2_0_TypeInfo);
		    DAT_ram_00a63bf7 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (AssetContent_Loaders_GameRawImageLoader___c__DisplayClass2_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 0xc) = param4;
		  *(undefined4 *)(param2_00 + 8) = param3;
		  param1_00 = unnamed_function_1417
		                        (Core_GameResources_GameResourcesManager_TextureReadyDelegate_TypeInfo);
		  Core_GameResources_GameResourcesManager_ResourceFailedDelegate__EndInvoke
		            (param1_00,param2_00,
		             Method_AssetContent_Loaders_GameRawImageLoader___c__DisplayClass2_0__LoadAsset_b__0__,0
		            );
		  param1_01 = unnamed_function_1417
		                        (Core_GameResources_GameResourcesManager_ResourceFailedDelegate_TypeInfo);
		  Core_GameResources_GameResourcesManager_SpriteAtlasReadyDelegate___ctor
		            (param1_01,param2_00,
		             Method_AssetContent_Loaders_GameRawImageLoader___c__DisplayClass2_0__LoadAsset_b__1__,0
		            );
		  if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		  }
		  Core_GameResources_GameResourcesManager___cctor(param2,param1_00,param1_01,param5,0);
		  return;
		}
		*/

		}

		// Token: 0x06005908 RID: 22792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005908")]
		[Address(RVA = "0xA65C", Offset = "0xA65C", VA = "0xA65C", Slot = "13")]
		public override void LoadAsset(string url, Action<Texture2D, string> successCallback, Action<string> failCallback, bool saveOnDisk)
		{
		/* --- GHIDRA: LoadAsset ---
		void AssetContent_Loaders_GameRawImageLoader__LoadAsset(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63bf8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D___ctor__);
		    DAT_ram_00a63bf8 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06005909 RID: 22793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005909")]
		[Address(RVA = "0xA65D", Offset = "0xA65D", VA = "0xA65D")]
		public GameRawImageLoader()
		{
		}
	}
}
