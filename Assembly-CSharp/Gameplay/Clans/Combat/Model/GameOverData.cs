using System;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.ClanWar;

namespace Gameplay.Clans.Combat.Model
{
	// Token: 0x02000A9F RID: 2719
	[Token(Token = "0x2000A9F")]
	public class GameOverData : GameOverData
	{
		// Token: 0x06004171 RID: 16753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004171")]
		[Address(RVA = "0x9028", Offset = "0x9028", VA = "0x9028")]
		public GameOverData(ClanWarFinishReasons reason, bool isWin, CombatPlayer myPlayer, CombatPlayer enemyPlayer, CombatPlayer loosePlayer, PlayerProfitData playerProfit)
		{
		}

		// Token: 0x06004172 RID: 16754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004172")]
		[Address(RVA = "0x9029", Offset = "0x9029", VA = "0x9029")]
		public GameOverData(bool isWin, CombatPlayer myPlayer, CombatPlayer enemyPlayer, CombatPlayer loosePlayer, PlayerProfitData playerProfit)
		{
		}

		// Token: 0x04002445 RID: 9285
		[Token(Token = "0x4002445")]
		[FieldOffset(Offset = "0x24")]
		public readonly ClanWarFinishReasons Reason;

		// Token: 0x04002446 RID: 9286
		[Token(Token = "0x4002446")]
		[FieldOffset(Offset = "0x28")]
		public CombatPlayer MyPlayer;

		// Token: 0x04002447 RID: 9287
		[Token(Token = "0x4002447")]
		[FieldOffset(Offset = "0x2C")]
		public CombatPlayer EnemyPlayer;
	}
}
