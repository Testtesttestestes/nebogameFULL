using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000FA4 RID: 4004
	[Token(Token = "0x2000FA4")]
	public static class StoneDicExt
	{
		// Token: 0x06005FEB RID: 24555 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FEB")]
		[Address(RVA = "0x1DDC", Offset = "0x1DDC", VA = "0x1DDC")]
		public static string GetTitle(this StoneDic dic)
		{
		/* --- GHIDRA: GetTitle ---
		undefined4 Core_Extensions_Dict_StoneDicExt__GetTitle(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x18),0xa8,0);
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

		// Token: 0x06005FEC RID: 24556 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FEC")]
		[Address(RVA = "0x1DDD", Offset = "0x1DDD", VA = "0x1DDD")]
		public static string GetIcon(this StoneDic dic)
		{
		/* --- GHIDRA: GetIcon ---
		undefined4 Core_Extensions_Dict_StoneDicExt__GetIcon(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x14),0x9d,0);
		  return uVar1;
		}
		*/

			return null;
		}
	}
}
