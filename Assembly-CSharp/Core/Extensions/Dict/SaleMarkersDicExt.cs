using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000FA0 RID: 4000
	[Token(Token = "0x2000FA0")]
	public static class SaleMarkersDicExt
	{
		// Token: 0x06005FDD RID: 24541 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FDD")]
		[Address(RVA = "0xAC14", Offset = "0xAC14", VA = "0xAC14")]
		public static string GetAprAssetId(this SaleMarkersDic dict)
		{
		/* --- GHIDRA: GetAprAssetId ---
		undefined4 Core_Extensions_Dict_SaleMarkersDicExt__GetAprAssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x18),100,0);
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
