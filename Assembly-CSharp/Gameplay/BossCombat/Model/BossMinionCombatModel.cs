using System;
using Core.Cache.User;
using Core.Data;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Combat;
using Utils;

namespace Gameplay.BossCombat.Model
{
	// Token: 0x02000B3F RID: 2879
	[Token(Token = "0x2000B3F")]
	public class BossMinionCombatModel : CombatModel
	{
		// Token: 0x060045D5 RID: 17877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045D5")]
		[Address(RVA = "0x9477", Offset = "0x9477", VA = "0x9477")]
		public BossMinionCombatModel(CombatDependencies dependencies, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		}

		// Token: 0x060045D6 RID: 17878 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60045D6")]
		[Address(RVA = "0x9478", Offset = "0x9478", VA = "0x9478", Slot = "9")]
		protected override CombatPlayer CreatePlayer(ICombatPlayerFactory playerFactory, ICombatSpellDataFactory spellFactory, IUserCache userCache, PlayerInfo playerInfo)
		{
			return null;
		}

		// Token: 0x060045D7 RID: 17879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045D7")]
		[Address(RVA = "0x9479", Offset = "0x9479", VA = "0x9479")]
		private void FillEffectIndexes(CombatPlayer player)
		{
		}
	}
}
