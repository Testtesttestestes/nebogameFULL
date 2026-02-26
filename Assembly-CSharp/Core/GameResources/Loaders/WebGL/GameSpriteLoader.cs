using System;
using Il2CppDummyDll;

namespace Core.GameResources.Loaders.WebGL
{
	// Token: 0x02000EE9 RID: 3817
	[Token(Token = "0x2000EE9")]
	public class GameSpriteLoader : AbstractGameSpriteLoader
	{
		// Token: 0x06005CBA RID: 23738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CBA")]
		[Address(RVA = "0xA94D", Offset = "0xA94D", VA = "0xA94D")]
		public GameSpriteLoader()
		{
		/* --- GHIDRA: .ctor ---
		void Core_GameResources_Loaders_Android_GameSpriteLoader___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5acaf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_TextMeshProSpriteAssetReadyDelegate___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourceCancellationToken_TypeInfo);
		    DAT_ram_00a5acaf = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Core_GameResources_GameResourceCancellationToken_TypeInfo);
		  Core_GameResources_GameResourceCancellationToken__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0x30) = param1_00;
		  AssetContent_Loaders_AbstractGameGraphicLoader_object__object___set_IsReady
		            (param1,
		             Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_TextMeshProSpriteAssetReadyDelegate___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
