using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F75 RID: 3957
	[Token(Token = "0x2000F75")]
	public static class GameFieldGemSetsDicExt
	{
		// Token: 0x06005F43 RID: 24387 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F43")]
		[Address(RVA = "0x1D71", Offset = "0x1D71", VA = "0x1D71")]
		public static string GetGemsSpriteAtlasAssetId(this GameFieldGemSetsDic dict)
		{
		/* --- GHIDRA: GetGemsSpriteAtlasAssetId ---
		undefined4
		Core_Extensions_Dict_GameFieldGemSetsDicExt__GetGemsSpriteAtlasAssetId
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = Core_Gameplay_Managers_DictManager__CheckSupportedService(param1,param2,param2);
		  if (iVar1 != 0) {
		    return *(undefined4 *)(iVar1 + 0x14);
		  }
		  return 0;
		}
		*/

			return null;
		}
	}
}
