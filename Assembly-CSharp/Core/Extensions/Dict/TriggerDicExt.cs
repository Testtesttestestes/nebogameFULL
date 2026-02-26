using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000FA9 RID: 4009
	[Token(Token = "0x2000FA9")]
	public static class TriggerDicExt
	{
		// Token: 0x06005FFE RID: 24574 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FFE")]
		[Address(RVA = "0xAC33", Offset = "0xAC33", VA = "0xAC33")]
		public static string GetDescription(this TriggerDic triggerDic)
		{
		/* --- GHIDRA: GetDescription ---
		undefined4 Core_Extensions_Dict_TriggerDicExt__GetDescription(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x28),100,0);
		  return uVar1;
		}
		*/

			return null;
		}
	}
}
