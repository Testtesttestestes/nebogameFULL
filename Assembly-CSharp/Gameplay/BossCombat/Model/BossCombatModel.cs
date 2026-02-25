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
	// Token: 0x02000B3D RID: 2877
	[Token(Token = "0x2000B3D")]
	public class BossCombatModel : CombatModel
	{
		// Token: 0x060045CF RID: 17871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045CF")]
		[Address(RVA = "0x9471", Offset = "0x9471", VA = "0x9471")]
		public BossCombatModel(CombatDependencies dependencies, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		}

		// Token: 0x060045D0 RID: 17872 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60045D0")]
		[Address(RVA = "0x9472", Offset = "0x9472", VA = "0x9472", Slot = "9")]
		protected override CombatPlayer CreatePlayer(ICombatPlayerFactory playerFactory, ICombatSpellDataFactory spellFactory, IUserCache userCache, PlayerInfo playerInfo)
		{
			return null;
		}

		// Token: 0x060045D1 RID: 17873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045D1")]
		[Address(RVA = "0x9473", Offset = "0x9473", VA = "0x9473")]
		private void FillEffectIndexes(CombatPlayer player)
		{
		}
	}
}
