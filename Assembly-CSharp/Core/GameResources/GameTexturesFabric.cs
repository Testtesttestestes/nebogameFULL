using System;
using Core.GameResources.Loaders.WebGL;
using Il2CppDummyDll;

namespace Core.GameResources
{
	// Token: 0x02000ED8 RID: 3800
	[Token(Token = "0x2000ED8")]
	internal class GameTexturesFabric : BaseGameResourcesFabric<GameTextureLoader, GameResourcesManager.TextureReadyDelegate>
	{
		// Token: 0x06005C79 RID: 23673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C79")]
		[Address(RVA = "0xA916", Offset = "0xA916", VA = "0xA916")]
		public GameTexturesFabric()
		{
		/* --- GHIDRA: .ctor ---
		void Core_GameResources_GameTexturesFabric___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60662 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_BaseGameResourcesFabric_GameAudioClipLoader__GameResourcesManager_AudioClipReadyDelegate___ctor__
		              );
		    DAT_ram_00a60662 = '\x01';
		  }
		  Sirenix_Serialization_BaseFormatter___Il2CppFullySharedGenericType___get_SerializedType
		            (param1,
		             Method_Core_GameResources_BaseGameResourcesFabric_GameAudioClipLoader__GameResourcesManager_AudioClipReadyDelegate___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
