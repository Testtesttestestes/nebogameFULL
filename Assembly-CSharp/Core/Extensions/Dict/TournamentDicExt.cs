using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000FA7 RID: 4007
	[Token(Token = "0x2000FA7")]
	public static class TournamentDicExt
	{
		// Token: 0x06005FF8 RID: 24568 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FF8")]
		[Address(RVA = "0xAC2D", Offset = "0xAC2D", VA = "0xAC2D")]
		public static string GetTitle(this TournamentDic dic)
		{
		/* --- GHIDRA: GetTitle ---
		undefined4 Core_Extensions_Dict_TournamentDicExt__GetTitle(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x44),0x1d,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005FF9 RID: 24569 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FF9")]
		[Address(RVA = "0xAC2E", Offset = "0xAC2E", VA = "0xAC2E")]
		public static string GetDescription(this TournamentDic dic)
		{
		/* --- GHIDRA: GetDescription ---
		undefined4 Core_Extensions_Dict_TournamentDicExt__GetDescription(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x40),0x3d,0);
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

		// Token: 0x06005FFA RID: 24570 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FFA")]
		[Address(RVA = "0xAC2F", Offset = "0xAC2F", VA = "0xAC2F")]
		public static string GetBannerAssetId(this TournamentDic dic)
		{
		/* --- GHIDRA: GetBannerAssetId ---
		undefined4 Core_Extensions_Dict_TournamentDicExt__GetBannerAssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x30),0x5a,0);
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
