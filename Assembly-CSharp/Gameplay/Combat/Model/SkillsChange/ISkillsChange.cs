using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Combat.Model.SkillsChange
{
	// Token: 0x020009A4 RID: 2468
	[Token(Token = "0x20009A4")]
	public interface ISkillsChange
	{
		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06003AF8 RID: 15096
		[Token(Token = "0x17000BB1")]
		ulong UserId { [Token(Token = "0x6003AF8")] get; }

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06003AF9 RID: 15097
		[Token(Token = "0x17000BB2")]
		IList<PlayerSkill> Skills { [Token(Token = "0x6003AF9")] get; }

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06003AFA RID: 15098
		[Token(Token = "0x17000BB3")]
		IShortSpellInfo[] SpellsChanges { [Token(Token = "0x6003AFA")] get; }
	}
}
