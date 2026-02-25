using System;
using Core.Data;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Clans.Combat.Factories
{
	// Token: 0x02000AA0 RID: 2720
	[Token(Token = "0x2000AA0")]
	public class ClanCombatPlayerFactory : ICombatPlayerFactory, IDisposable
	{
		// Token: 0x06004173 RID: 16755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004173")]
		[Address(RVA = "0x902A", Offset = "0x902A", VA = "0x902A", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004174")]
		[Address(RVA = "0x902B", Offset = "0x902B", VA = "0x902B", Slot = "4")]
		public CombatPlayer Create(PlayerInfo playerInfo, UserData user, ICombatSpellDataFactory spellDataFactory)
		{
			return null;
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004175")]
		[Address(RVA = "0x902C", Offset = "0x902C", VA = "0x902C")]
		public ClanCombatPlayerFactory()
		{
		}
	}
}
