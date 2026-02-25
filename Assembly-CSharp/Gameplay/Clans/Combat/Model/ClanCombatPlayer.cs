using System;
using Core.Data;
using Gameplay.Combat.Factories;
using Gameplay.Combat.TeamCombat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Clans.Combat.Model
{
	// Token: 0x02000A9D RID: 2717
	[Token(Token = "0x2000A9D")]
	public class ClanCombatPlayer : TeamCombatPlayer
	{
		// Token: 0x0600416D RID: 16749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600416D")]
		[Address(RVA = "0x9024", Offset = "0x9024", VA = "0x9024")]
		public ClanCombatPlayer(PlayerInfo playerInfo, UserData user, ICombatSpellDataFactory spellFactory)
		{
		}

		// Token: 0x0600416E RID: 16750 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600416E")]
		[Address(RVA = "0x9025", Offset = "0x9025", VA = "0x9025", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
