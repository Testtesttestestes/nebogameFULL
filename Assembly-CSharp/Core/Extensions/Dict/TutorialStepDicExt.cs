using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000FAA RID: 4010
	[Token(Token = "0x2000FAA")]
	public static class TutorialStepDicExt
	{
		// Token: 0x06005FFF RID: 24575 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FFF")]
		[Address(RVA = "0xAC34", Offset = "0xAC34", VA = "0xAC34")]
		public static string GetDialog(this TutorialStepDic dic)
		{
		/* --- GHIDRA: GetDialog ---
		undefined4 Core_Extensions_Dict_TutorialStepDicExt__GetDialog(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x10),0x6a,0);
		  return *(undefined4 *)(iVar1 + 0x10);
		}
		*/

			return null;
		}
	}
}
