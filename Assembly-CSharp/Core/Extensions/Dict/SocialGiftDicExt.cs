using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000FA2 RID: 4002
	[Token(Token = "0x2000FA2")]
	public static class SocialGiftDicExt
	{
		// Token: 0x06005FDF RID: 24543 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FDF")]
		[Address(RVA = "0xAC16", Offset = "0xAC16", VA = "0xAC16")]
		public static string GetIconAssetId(this SocialGiftDic giftDic)
		{
		/* --- GHIDRA: GetIconAssetId ---
		undefined4 Core_Extensions_Dict_SocialGiftDicExt__GetIconAssetId(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x2c),0x52,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005FE0 RID: 24544 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FE0")]
		[Address(RVA = "0xAC17", Offset = "0xAC17", VA = "0xAC17")]
		public static string GetTitle(this SocialGiftDic giftDic)
		{
		/* --- GHIDRA: GetTitle ---
		undefined4 Core_Extensions_Dict_SocialGiftDicExt__GetTitle(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x2c),0x53,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005FE1 RID: 24545 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FE1")]
		[Address(RVA = "0xAC18", Offset = "0xAC18", VA = "0xAC18")]
		public static string GetDescription(this SocialGiftDic giftDic)
		{
		/* --- GHIDRA: GetDescription ---
		undefined4
		Core_Extensions_Dict_SocialGiftDicExt__GetDescription
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x48),param2,0);
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
