using System;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Combat.Model
{
	// Token: 0x0200099D RID: 2461
	[Token(Token = "0x200099D")]
	public class GameOverData
	{
		// Token: 0x06003ADE RID: 15070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ADE")]
		[Address(RVA = "0x8A53", Offset = "0x8A53", VA = "0x8A53")]
		public GameOverData(bool isWin, ulong opponentId, CombatPlayer loosePlayer, CombatTypes combatType, PlayerProfitData playerProfit)
		{
		}

		// Token: 0x06003ADF RID: 15071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ADF")]
		[Address(RVA = "0x8A54", Offset = "0x8A54", VA = "0x8A54")]
		public GameOverData()
		{
		}

		// Token: 0x04002083 RID: 8323
		[Token(Token = "0x4002083")]
		[FieldOffset(Offset = "0x8")]
		public readonly bool IsWin;

		// Token: 0x04002084 RID: 8324
		[Token(Token = "0x4002084")]
		[FieldOffset(Offset = "0x10")]
		public readonly ulong OpponentId;

		// Token: 0x04002085 RID: 8325
		[Token(Token = "0x4002085")]
		[FieldOffset(Offset = "0x18")]
		public readonly CombatPlayer LoosePlayer;

		// Token: 0x04002086 RID: 8326
		[Token(Token = "0x4002086")]
		[FieldOffset(Offset = "0x1C")]
		public readonly CombatTypes CombatType;

		// Token: 0x04002087 RID: 8327
		[Token(Token = "0x4002087")]
		[FieldOffset(Offset = "0x20")]
		public readonly PlayerProfitData PlayerProfit;
	}
}
