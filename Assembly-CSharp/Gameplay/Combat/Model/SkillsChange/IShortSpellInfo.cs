using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Common;

namespace Gameplay.Combat.Model.SkillsChange
{
	// Token: 0x020009A3 RID: 2467
	[Token(Token = "0x20009A3")]
	public interface IShortSpellInfo
	{
		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06003AF6 RID: 15094
		[Token(Token = "0x17000BAF")]
		SpellKey SpellKey { [Token(Token = "0x6003AF6")] get; }

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06003AF7 RID: 15095
		[Token(Token = "0x17000BB0")]
		IList<EffectInfo> Effects { [Token(Token = "0x6003AF7")] get; }
	}
}
