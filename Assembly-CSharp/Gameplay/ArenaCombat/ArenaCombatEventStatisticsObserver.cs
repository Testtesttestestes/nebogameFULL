using System;
using Core.Application;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.ArenaCombat
{
	// Token: 0x02000D41 RID: 3393
	[Token(Token = "0x2000D41")]
	public sealed class ArenaCombatEventStatisticsObserver : CombatEventStatisticsObserver<ArenaCombatEvents>
	{
		// Token: 0x0600531E RID: 21278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600531E")]
		[Address(RVA = "0xA0F3", Offset = "0xA0F3", VA = "0xA0F3")]
		public ArenaCombatEventStatisticsObserver(ArenaCombatEvents events, IApp app, IGame game)
		{
		}

		// Token: 0x0600531F RID: 21279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600531F")]
		[Address(RVA = "0xA0F4", Offset = "0xA0F4", VA = "0xA0F4")]
		private void OnMatchStonesHandler(int numStones, StonesTypes stoneType, bool isPlayerStep)
		{
		}

		// Token: 0x06005320 RID: 21280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005320")]
		[Address(RVA = "0xA0F5", Offset = "0xA0F5", VA = "0xA0F5")]
		private void OnUseElixirHandler(uint elixirId)
		{
		}

		// Token: 0x06005321 RID: 21281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005321")]
		[Address(RVA = "0xA0F6", Offset = "0xA0F6", VA = "0xA0F6")]
		private void OnUseSpellHandler(uint spellId)
		{
		}

		// Token: 0x06005322 RID: 21282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005322")]
		[Address(RVA = "0xA0F7", Offset = "0xA0F7", VA = "0xA0F7", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x04002D0F RID: 11535
		[Token(Token = "0x4002D0F")]
		[FieldOffset(Offset = "0x28")]
		private readonly IApp _app;

		// Token: 0x04002D10 RID: 11536
		[Token(Token = "0x4002D10")]
		[FieldOffset(Offset = "0x2C")]
		private readonly IGame _game;
	}
}
