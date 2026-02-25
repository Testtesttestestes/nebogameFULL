using System;
using Core.Data;
using Core.Data.Skills;
using Il2CppDummyDll;

namespace Gameplay.AccountLinker.Model
{
	// Token: 0x02000E17 RID: 3607
	[Token(Token = "0x2000E17")]
	public class LinkerUser
	{
		// Token: 0x060057F3 RID: 22515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057F3")]
		[Address(RVA = "0xA565", Offset = "0xA565", VA = "0xA565")]
		public LinkerUser(UserData user)
		{
		}

		// Token: 0x04002FAA RID: 12202
		[Token(Token = "0x4002FAA")]
		[FieldOffset(Offset = "0x8")]
		public SkillCollection Skills;

		// Token: 0x04002FAB RID: 12203
		[Token(Token = "0x4002FAB")]
		[FieldOffset(Offset = "0xC")]
		public UserData User;
	}
}
