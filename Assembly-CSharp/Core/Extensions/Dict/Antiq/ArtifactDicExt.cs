using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict.Antiq
{
	// Token: 0x02000FB2 RID: 4018
	[Token(Token = "0x2000FB2")]
	public static class ArtifactDicExt
	{
		// Token: 0x06006017 RID: 24599 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006017")]
		[Address(RVA = "0xAC48", Offset = "0xAC48", VA = "0xAC48")]
		public static string GetImage(this Antiq.Types.ArtifactsDic dict)
		{
		/* --- GHIDRA: GetImage ---
		undefined4 Core_Extensions_Dict_Antiq_ArtifactDicExt__GetImage(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x2c),0xe4,0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  return uVar2;
		}
		*/

			return null;
		}
	}
}
