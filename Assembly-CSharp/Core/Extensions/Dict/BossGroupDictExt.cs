using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F29 RID: 3881
	[Token(Token = "0x2000F29")]
	public static class BossGroupDictExt
	{
		// Token: 0x06005D9D RID: 23965 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D9D")]
		[Address(RVA = "0x1B78", Offset = "0x1B78", VA = "0x1B78")]
		public static string GetTitle(this BossGroupDic bossGroupDic)
		{
		/* --- GHIDRA: GetTitle ---
		void Core_Extensions_Dict_BossGroupDictExt__GetTitle(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param1 + 0xc) != param2) {
		    *(int *)(param1 + 0xc) = param2;
		    iVar1 = *(int *)(param1 + 8);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

			return null;
		}
	}
}
