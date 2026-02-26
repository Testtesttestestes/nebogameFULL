using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Extensions
{
	// Token: 0x02000F13 RID: 3859
	[Token(Token = "0x2000F13")]
	public static class UriExt
	{
		// Token: 0x06005D43 RID: 23875 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D43")]
		[Address(RVA = "0x2257", Offset = "0x2257", VA = "0x2257")]
		public static Dictionary<string, string> QueryStringToDictionary(this Uri uri)
		{
		/* --- GHIDRA: QueryStringToDictionary ---
		undefined4 Core_Extensions_UriExt__QueryStringToDictionary(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = func_ii_5618(0);
		  uVar1 = UnityEngine_Networking_UnityWebRequest__EscapeURL(param1,uVar1,param1);
		  return uVar1;
		}
		*/

			return null;
		}
	}
}
