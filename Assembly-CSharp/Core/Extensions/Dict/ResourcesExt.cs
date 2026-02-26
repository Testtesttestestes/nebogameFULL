using System;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F9D RID: 3997
	[Token(Token = "0x2000F9D")]
	public static class ResourcesExt
	{
		// Token: 0x06005FD4 RID: 24532 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FD4")]
		[Address(RVA = "0xAC0B", Offset = "0xAC0B", VA = "0xAC0B")]
		public static string GetTextSpriteName(this Resources r)
		{
		/* --- GHIDRA: GetTextSpriteName ---
		undefined4 Core_Extensions_Dict_ResourcesExt__GetTextSpriteName(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x10),0x3b,0);
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
