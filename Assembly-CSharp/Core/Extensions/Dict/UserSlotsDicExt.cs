using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000FB1 RID: 4017
	[Token(Token = "0x2000FB1")]
	public static class UserSlotsDicExt
	{
		// Token: 0x06006015 RID: 24597 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006015")]
		[Address(RVA = "0xAC46", Offset = "0xAC46", VA = "0xAC46")]
		public static string GetUserTitle(this UserSlotsDic dic)
		{
		/* --- GHIDRA: GetUserTitle ---
		undefined4 Core_Extensions_Dict_UserSlotsDicExt__GetUserTitle(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x20),0x78,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06006016 RID: 24598 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006016")]
		[Address(RVA = "0xAC47", Offset = "0xAC47", VA = "0xAC47")]
		public static string GetGolemTitle(this UserSlotsDic dic)
		{
		/* --- GHIDRA: GetGolemTitle ---
		undefined4 Core_Extensions_Dict_UserSlotsDicExt__GetGolemTitle(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x2c),1,0);
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
