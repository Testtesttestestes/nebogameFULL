using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000FAB RID: 4011
	[Token(Token = "0x2000FAB")]
	public static class TutorialUIPointerDicExt
	{
		// Token: 0x06006000 RID: 24576 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006000")]
		[Address(RVA = "0xAC35", Offset = "0xAC35", VA = "0xAC35")]
		public static string GetView(this TutorialUIPointerDic dic)
		{
		/* --- GHIDRA: GetView ---
		undefined4 Core_Extensions_Dict_TutorialUIPointerDicExt__GetView(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x20),0x2a,0);
		  return uVar1;
		}
		*/

			return null;
		}
	}
}
