using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Combat.Factories;
using Gameplay.Combat.TeamCombat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.VortexCombat.Model
{
	// Token: 0x020003B2 RID: 946
	[Token(Token = "0x20003B2")]
	public class VortexCombatPlayer : TeamCombatPlayer
	{
		// Token: 0x06001631 RID: 5681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001631")]
		[Address(RVA = "0x67F2", Offset = "0x67F2", VA = "0x67F2")]
		public VortexCombatPlayer(PlayerInfo playerInfo, UserData user, ICombatSpellDataFactory spellFactory)
		{
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001632")]
		[Address(RVA = "0x67F3", Offset = "0x67F3", VA = "0x67F3", Slot = "6")]
		public override void SetPlayerSkills(IList<PlayerSkill> value)
		{
		}

		// Token: 0x04000BBC RID: 3004
		[Token(Token = "0x4000BBC")]
		[FieldOffset(Offset = "0x68")]
		public long LastManaBoostDelta;
	}
}
