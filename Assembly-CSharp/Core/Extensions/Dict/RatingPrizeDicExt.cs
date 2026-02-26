using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F96 RID: 3990
	[Token(Token = "0x2000F96")]
	public static class RatingPrizeDicExt
	{
		// Token: 0x06005FA0 RID: 24480 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FA0")]
		[Address(RVA = "0xABDC", Offset = "0xABDC", VA = "0xABDC")]
		public static string GetPrizeBanner(this RatingPrizeDic dic)
		{
		/* --- GHIDRA: GetPrizeBanner ---
		undefined4 Core_Extensions_Dict_RatingPrizeDicExt__GetPrizeBanner(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x20),0xa9,0);
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

		// Token: 0x06005FA1 RID: 24481 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FA1")]
		[Address(RVA = "0xABDD", Offset = "0xABDD", VA = "0xABDD")]
		public static string GetUserPrizeBanner(this RatingPrizeDic dic)
		{
		/* --- GHIDRA: GetUserPrizeBanner ---
		undefined4 Core_Extensions_Dict_RatingPrizeDicExt__GetUserPrizeBanner(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x20),0xaa,0);
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

		// Token: 0x06005FA2 RID: 24482 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FA2")]
		[Address(RVA = "0xABDE", Offset = "0xABDE", VA = "0xABDE")]
		public static string GetClanPrizeBanner(this RatingPrizeDic dic)
		{
		/* --- GHIDRA: GetClanPrizeBanner ---
		undefined4 Core_Extensions_Dict_RatingPrizeDicExt__GetClanPrizeBanner(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x14),0xd5,0);
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
