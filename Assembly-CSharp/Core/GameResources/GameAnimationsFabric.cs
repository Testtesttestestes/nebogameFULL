using System;
using Core.GameResources.Loaders;
using Il2CppDummyDll;

namespace Core.GameResources
{
	// Token: 0x02000ED7 RID: 3799
	[Token(Token = "0x2000ED7")]
	internal class GameAnimationsFabric : BaseGameResourcesFabric<GameAnimationLoader, GameResourcesManager.AnimationReadyDelegate>
	{
		// Token: 0x06005C78 RID: 23672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C78")]
		[Address(RVA = "0xA915", Offset = "0xA915", VA = "0xA915")]
		public GameAnimationsFabric()
		{
		/* --- GHIDRA: .ctor ---
		void Core_GameResources_GameAnimationsFabric___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60661 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_BaseGameResourcesFabric_GameTextureLoader__GameResourcesManager_TextureReadyDelegate___ctor__
		              );
		    DAT_ram_00a60661 = '\x01';
		  }
		  Sirenix_Serialization_BaseFormatter___Il2CppFullySharedGenericType___get_SerializedType
		            (param1,
		             Method_Core_GameResources_BaseGameResourcesFabric_GameTextureLoader__GameResourcesManager_TextureReadyDelegate___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
