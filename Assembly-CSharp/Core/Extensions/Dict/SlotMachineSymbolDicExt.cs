using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000FA1 RID: 4001
	[Token(Token = "0x2000FA1")]
	public static class SlotMachineSymbolDicExt
	{
		// Token: 0x06005FDE RID: 24542 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FDE")]
		[Address(RVA = "0xAC15", Offset = "0xAC15", VA = "0xAC15")]
		public static string GetIconAssetId(this SlotMachineSymbolDic slotMachineSymbolDic)
		{
		/* --- GHIDRA: GetIconAssetId ---
		undefined4
		Core_Extensions_Dict_SlotMachineSymbolDicExt__GetIconAssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x28),5,0);
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
