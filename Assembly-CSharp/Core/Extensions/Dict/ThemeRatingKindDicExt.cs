using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000FA6 RID: 4006
	[Token(Token = "0x2000FA6")]
	public static class ThemeRatingKindDicExt
	{
		// Token: 0x06005FF6 RID: 24566 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FF6")]
		[Address(RVA = "0xAC2B", Offset = "0xAC2B", VA = "0xAC2B")]
		public static string GetTitle(this ThemeRatingKindDic dict)
		{
		/* --- GHIDRA: GetTitle ---
		undefined4 Core_Extensions_Dict_ThemeRatingKindDicExt__GetTitle(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x18),0xb8,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005FF7 RID: 24567 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FF7")]
		[Address(RVA = "0xAC2C", Offset = "0xAC2C", VA = "0xAC2C")]
		public static string GetDescription(this ThemeRatingKindDic dict)
		{
		/* --- GHIDRA: GetDescription ---
		undefined4 Core_Extensions_Dict_ThemeRatingKindDicExt__GetDescription(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x44),0x1c,0);
		  return uVar1;
		}
		*/

			return null;
		}
	}
}
