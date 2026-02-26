using System;
using Core.GameResources.Loaders.WebGL;
using Il2CppDummyDll;

namespace Core.GameResources
{
	// Token: 0x02000ED4 RID: 3796
	[Token(Token = "0x2000ED4")]
	internal class GameSpritesFabric : BaseGameResourcesFabric<GameSpriteLoader, GameResourcesManager.SpriteReadyDelegate>
	{
		// Token: 0x06005C75 RID: 23669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C75")]
		[Address(RVA = "0xA912", Offset = "0xA912", VA = "0xA912")]
		public GameSpritesFabric()
		{
		/* --- GHIDRA: .ctor ---
		void Core_GameResources_GameSpritesFabric___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6065e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_BaseGameResourcesFabric_GameSpriteAtlasLoader__GameResourcesManager_SpriteAtlasReadyDelegate___ctor__
		              );
		    DAT_ram_00a6065e = '\x01';
		  }
		  Sirenix_Serialization_BaseFormatter___Il2CppFullySharedGenericType___get_SerializedType
		            (param1,
		             Method_Core_GameResources_BaseGameResourcesFabric_GameSpriteAtlasLoader__GameResourcesManager_SpriteAtlasReadyDelegate___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
