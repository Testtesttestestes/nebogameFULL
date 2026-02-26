using System;
using Core.GameResources.Loaders.WebGL;
using Il2CppDummyDll;

namespace Core.GameResources
{
	// Token: 0x02000ED6 RID: 3798
	[Token(Token = "0x2000ED6")]
	internal class GameTextMeshProSpriteAssetFabric : BaseGameResourcesFabric<GameTextMeshProSpriteAssetLoader, GameResourcesManager.TextMeshProSpriteAssetReadyDelegate>
	{
		// Token: 0x06005C77 RID: 23671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C77")]
		[Address(RVA = "0xA914", Offset = "0xA914", VA = "0xA914")]
		public GameTextMeshProSpriteAssetFabric()
		{
		/* --- GHIDRA: .ctor ---
		void Core_GameResources_GameTextMeshProSpriteAssetFabric___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60660 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_BaseGameResourcesFabric_GameAnimationLoader__GameResourcesManager_AnimationReadyDelegate___ctor__
		              );
		    DAT_ram_00a60660 = '\x01';
		  }
		  Sirenix_Serialization_BaseFormatter___Il2CppFullySharedGenericType___get_SerializedType
		            (param1,
		             Method_Core_GameResources_BaseGameResourcesFabric_GameAnimationLoader__GameResourcesManager_AnimationReadyDelegate___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
