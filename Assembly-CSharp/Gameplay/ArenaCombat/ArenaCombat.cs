using System;
using System.Runtime.InteropServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.ArenaCombat.Control;
using Gameplay.ArenaCombat.Model;
using Gameplay.Combat;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using Protocol.Combat;
using Utils;

namespace Gameplay.ArenaCombat
{
	// Token: 0x02000D40 RID: 3392
	[Token(Token = "0x2000D40")]
	public class ArenaCombat : AbstractCombat<ArenaCombatModel, ArenaCombatEvents, ArenaCombatController, ArenaCombatViewMediator, OneOnOneCombatView>
	{
		// Token: 0x06005316 RID: 21270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005316")]
		[Address(RVA = "0xA0EB", Offset = "0xA0EB", VA = "0xA0EB")]
		public ArenaCombat(IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime)
		{
		}

		// Token: 0x06005317 RID: 21271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005317")]
		[Address(RVA = "0xA0EC", Offset = "0xA0EC", VA = "0xA0EC")]
		public ArenaCombat(IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime, ArenaCombatModel.AttackRequestedMonster monsterRequest)
		{
		}

		// Token: 0x06005318 RID: 21272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005318")]
		[Address(RVA = "0xA0ED", Offset = "0xA0ED", VA = "0xA0ED")]
		public ArenaCombat(IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime, ArenaCombatModel.ArenaCombatRequested arenaRequest)
		{
		}

		// Token: 0x06005319 RID: 21273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005319")]
		[Address(RVA = "0xA0EE", Offset = "0xA0EE", VA = "0xA0EE", Slot = "13")]
		protected override void InitMVC()
		{
		}

		// Token: 0x0600531A RID: 21274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600531A")]
		[Address(RVA = "0xA0EF", Offset = "0xA0EF", VA = "0xA0EF", Slot = "11")]
		public override void Dispose()
		{
		}

		// Token: 0x0600531B RID: 21275 RVA: 0x0000F078 File Offset: 0x0000D278
		[Token(Token = "0x600531B")]
		[Address(RVA = "0xA0F0", Offset = "0xA0F0", VA = "0xA0F0")]
		public static bool TryRun(IGame game, ArenaCombatModel.AttackRequestedMonster request)
		{
			return default(bool);
		}

		// Token: 0x0600531C RID: 21276 RVA: 0x0000F090 File Offset: 0x0000D290
		[Token(Token = "0x600531C")]
		[Address(RVA = "0xA0F1", Offset = "0xA0F1", VA = "0xA0F1")]
		public static bool TryRun(IGame game, ProtoRequestCombatCmd.Types.ArenaCombatTypes type, bool fromArena, [Optional] BackTime awaitBackTime)
		{
			return default(bool);
		}

		// Token: 0x0600531D RID: 21277 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600531D")]
		[Address(RVA = "0xA0F2", Offset = "0xA0F2", VA = "0xA0F2")]
		public static ICombat Run(IGame game, BackTime awaitBackTime)
		{
			return null;
		}

		// Token: 0x04002D0C RID: 11532
		[Token(Token = "0x4002D0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ArenaCombatModel.AttackRequestedMonster _monsterRequest;

		// Token: 0x04002D0D RID: 11533
		[Token(Token = "0x4002D0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private ArenaCombatModel.ArenaCombatRequested _arenaRequest;

		// Token: 0x04002D0E RID: 11534
		[Token(Token = "0x4002D0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ArenaCombatEventStatisticsObserver _eventStatisticsObserver;
	}
}
