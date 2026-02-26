using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F91 RID: 3985
	[Token(Token = "0x2000F91")]
	public static class PreloaderDicExt
	{
		// Token: 0x06005F95 RID: 24469 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F95")]
		[Address(RVA = "0x1D7B", Offset = "0x1D7B", VA = "0x1D7B")]
		public static string GetBackgroundImageAssetId(this PreloaderDic dict)
		{
		/* --- GHIDRA: GetBackgroundImageAssetId ---
		undefined4
		Core_Extensions_Dict_PreloaderDicExt__GetBackgroundImageAssetId
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 *param4,
		          undefined4 param5,undefined4 param6)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined1 auStack_10 [12];
		  int local_4;
		  
		  local_4 = 0;
		  uVar1 = Utils_JWT_JWTContent___ctor(param1,param2,param3,&local_4,param5,auStack_10);
		  if (local_4 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = *(undefined4 *)(local_4 + 0x14);
		  }
		  *param4 = uVar2;
		  return uVar1;
		}
		*/

			return null;
		}
	}
}
