using System;
using Core.GameResources.Loaders.WebGL;
using Il2CppDummyDll;

namespace Core.GameResources
{
	// Token: 0x02000ED5 RID: 3797
	[Token(Token = "0x2000ED5")]
	internal class GameSpriteAtlasFabric : BaseGameResourcesFabric<GameSpriteAtlasLoader, GameResourcesManager.SpriteAtlasReadyDelegate>
	{
		// Token: 0x06005C76 RID: 23670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C76")]
		[Address(RVA = "0xA913", Offset = "0xA913", VA = "0xA913")]
		public GameSpriteAtlasFabric()
		{
		/* --- GHIDRA: .ctor ---
		void Core_GameResources_GameSpriteAtlasFabric___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6065f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_BaseGameResourcesFabric_GameTextMeshProSpriteAssetLoader__GameResourcesManager_TextMeshProSpriteAssetReadyDelegate___ctor__
		              );
		    DAT_ram_00a6065f = '\x01';
		  }
		  Sirenix_Serialization_BaseFormatter___Il2CppFullySharedGenericType___get_SerializedType
		            (param1,
		             Method_Core_GameResources_BaseGameResourcesFabric_GameTextMeshProSpriteAssetLoader__GameResourcesManager_TextMeshProSpriteAssetReadyDelegate___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
