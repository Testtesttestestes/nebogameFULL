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
}
