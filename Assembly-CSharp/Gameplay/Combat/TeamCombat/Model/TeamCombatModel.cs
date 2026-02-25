using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.Combat.TeamCombat.Model
{
	// Token: 0x0200098E RID: 2446
	[Token(Token = "0x200098E")]
	public abstract class TeamCombatModel : CombatModel
	{
		// Token: 0x06003A59 RID: 14937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A59")]
		[Address(RVA = "0x89CF", Offset = "0x89CF", VA = "0x89CF")]
		protected TeamCombatModel(CombatDependencies dependencies, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		}

		// Token: 0x06003A5A RID: 14938 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A5A")]
		[Address(RVA = "0x89D0", Offset = "0x89D0", VA = "0x89D0", Slot = "17")]
		public virtual List<CombatPlayer> GetTeamPlayersContains(uint userSide)
		{
			return null;
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A5B")]
		[Address(RVA = "0x89D1", Offset = "0x89D1", VA = "0x89D1", Slot = "18")]
		public virtual List<CombatPlayer> GetTeamPlayersNotContains(uint userSide)
		{
			return null;
		}
	}
}
