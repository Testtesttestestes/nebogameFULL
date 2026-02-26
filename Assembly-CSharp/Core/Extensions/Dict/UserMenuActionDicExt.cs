using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000FAE RID: 4014
	[Token(Token = "0x2000FAE")]
	public static class UserMenuActionDicExt
	{
		// Token: 0x0600600A RID: 24586 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600600A")]
		[Address(RVA = "0xAC3F", Offset = "0xAC3F", VA = "0xAC3F")]
		public static string GetIconAssetId(this UserMenuActionDic userMenuActionDic)
		{
		/* --- GHIDRA: GetIconAssetId ---
		undefined4 Core_Extensions_Dict_UserMenuActionDicExt__GetIconAssetId(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x20),0x47,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600600B RID: 24587 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600600B")]
		[Address(RVA = "0xAC40", Offset = "0xAC40", VA = "0xAC40")]
		public static string GetTitle(this UserMenuActionDic userMenuActionDic)
		{
		/* --- GHIDRA: GetTitle ---
		undefined4 Core_Extensions_Dict_UserMenuActionDicExt__GetTitle(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x14),0x34,0);
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
