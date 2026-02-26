using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000FAC RID: 4012
	[Token(Token = "0x2000FAC")]
	public static class UserBuildingTypeDicExt
	{
		// Token: 0x06006001 RID: 24577 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006001")]
		[Address(RVA = "0xAC36", Offset = "0xAC36", VA = "0xAC36")]
		public static string GetTitle(this UserBuildingTypeDic userBuildingTypeDic)
		{
		/* --- GHIDRA: GetTitle ---
		undefined4 Core_Extensions_Dict_UserBuildingTypeDicExt__GetTitle(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x20),0x2b,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06006002 RID: 24578 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006002")]
		[Address(RVA = "0xAC37", Offset = "0xAC37", VA = "0xAC37")]
		public static string GetDescription(this UserBuildingTypeDic userBuildingTypeDic)
		{
		/* --- GHIDRA: GetDescription ---
		undefined4 Core_Extensions_Dict_UserBuildingTypeDicExt__GetDescription(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x20),0x2c,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06006003 RID: 24579 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006003")]
		[Address(RVA = "0xAC38", Offset = "0xAC38", VA = "0xAC38")]
		public static string GetUpgradeText(this UserBuildingTypeDic userBuildingTypeDic)
		{
		/* --- GHIDRA: GetUpgradeText ---
		undefined4 Core_Extensions_Dict_UserBuildingTypeDicExt__GetUpgradeText(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x30),0x13,0);
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
