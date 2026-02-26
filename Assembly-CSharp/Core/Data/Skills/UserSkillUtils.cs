using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Data.Skills
{
	// Token: 0x020010D9 RID: 4313
	[Token(Token = "0x20010D9")]
	public static class UserSkillUtils
	{
		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x06006507 RID: 25863 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001472")]
		public static List<UserSkillsIndexes> ExcludeUserSkillsIndexes
		{
			[Token(Token = "0x6006507")]
			[Address(RVA = "0x1F3B", Offset = "0x1F3B", VA = "0x1F3B")]
			get
			{
				return null;
			}
		}

		// Token: 0x040035E5 RID: 13797
		[Token(Token = "0x40035E5")]
		[FieldOffset(Offset = "0x0")]
		private static List<UserSkillsIndexes> _excludeUserSkillsIndexes;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ExcludeUserSkillsIndexes ---
		uint Core_Data_Skills_UserSkillUtils__get_ExcludeUserSkillsIndexes
		               (int param1,undefined4 param2,int param3)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param1 + 0xc) != 0) {
		    iVar1 = System_Array__IndexOf_int_
		                      (*(undefined4 *)(param1 + 8),param2,0,*(int *)(param1 + 0xc),
		                       *(undefined4 *)
		                        (*(int *)(*(int *)(*(int *)(*(int *)(*(int *)(param3 + 0x10) + 0x60) + 0x68)
		                                          + 0x10) + 0x60) + 0xac));
		    return (uint)(iVar1 != -1);
		  }
		  return 0;
		}
		*/

}
