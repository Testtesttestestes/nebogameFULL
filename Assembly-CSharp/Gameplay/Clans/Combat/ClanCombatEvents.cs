using System;
using System.Collections.Generic;
using Gameplay.Combat.Model;
using Gameplay.Combat.TeamCombat;
using Il2CppDummyDll;

namespace Gameplay.Clans.Combat
{
	// Token: 0x02000A90 RID: 2704
	[Token(Token = "0x2000A90")]
	public class ClanCombatEvents : TeamCombatEvents
	{
		// Token: 0x060040D3 RID: 16595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040D3")]
		[Address(RVA = "0x8F8A", Offset = "0x8F8A", VA = "0x8F8A")]
		public ClanCombatEvents()
		{
		}

		// Token: 0x040023F4 RID: 9204
		[Token(Token = "0x40023F4")]
		[FieldOffset(Offset = "0x70")]
		public Action<List<CombatPlayer>> PlayersMoved;

		// Token: 0x040023F5 RID: 9205
		[Token(Token = "0x40023F5")]
		[FieldOffset(Offset = "0x74")]
		public Action Joint;
	}
}
