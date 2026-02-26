using System;
using Il2CppDummyDll;

namespace Core.GameResources.Loaders.WebGL
{
	// Token: 0x02000EEB RID: 3819
	[Token(Token = "0x2000EEB")]
	public class GameTextureLoader : AbstractGameTextureLoader
	{
		// Token: 0x06005CBC RID: 23740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CBC")]
		[Address(RVA = "0xA94F", Offset = "0xA94F", VA = "0xA94F")]
		public GameTextureLoader()
		{
		/* --- GHIDRA: .ctor ---
		void Core_GameResources_Loaders_WebGL_GameTextureLoader___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5aca7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_AudioClipReadyDelegate___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourceCancellationToken_TypeInfo);
		    DAT_ram_00a5aca7 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Core_GameResources_GameResourceCancellationToken_TypeInfo);
		  Core_GameResources_GameResourceCancellationToken__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0x30) = param1_00;
		  AssetContent_Loaders_AbstractGameGraphicLoader_object__object___set_IsReady
		            (param1,
		             Method_Core_GameResources_AbstractGameResourceLoader_GameResourcesManager_AudioClipReadyDelegate___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
