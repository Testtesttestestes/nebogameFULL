using System;
using System.Runtime.InteropServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.ArenaCombat;
using Gameplay.Combat;
using Gameplay.ThemeDuelCombat.Control;
using Gameplay.ThemeDuelCombat.Model;
using Gameplay.ThemeDuelCombat.View;
using Il2CppDummyDll;
using Protocol.Combat;
using Utils;

namespace Gameplay.ThemeDuelCombat
{
	// Token: 0x020004D5 RID: 1237
	[Token(Token = "0x20004D5")]
	public class ThemeDuelCombat : AbstractCombat<ThemeDuelCombatModel, ThemeDuelCombatEvents, ThemeDuelCombatController, ThemeDuelCombatViewMediator, ThemeDuelCombatView>
	{
		// Token: 0x06001D70 RID: 7536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D70")]
		[Address(RVA = "0x6EEF", Offset = "0x6EEF", VA = "0x6EEF")]
		public ThemeDuelCombat(IGame game, UserData loggedUser, UserData user, ProtoRequestCombatCmd.Types.ArenaCombatTypes matchmakingWay, BackTime awaitBackTime)
		{
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D71")]
		[Address(RVA = "0x6EF0", Offset = "0x6EF0", VA = "0x6EF0", Slot = "13")]
		protected override void InitMVC()
		{
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D72")]
		[Address(RVA = "0x6EF1", Offset = "0x6EF1", VA = "0x6EF1", Slot = "11")]
		public override void Dispose()
		{
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x000062D0 File Offset: 0x000044D0
		[Token(Token = "0x6001D73")]
		[Address(RVA = "0x6EF2", Offset = "0x6EF2", VA = "0x6EF2")]
		public static bool TryRun(IGame game, ProtoRequestCombatCmd.Types.ArenaCombatTypes matchmakingWay, [Optional] BackTime awaitBackTime)
		{
			return default(bool);
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001D74")]
		[Address(RVA = "0x6EF3", Offset = "0x6EF3", VA = "0x6EF3")]
		public static ICombat Run(IGame game, BackTime awaitBackTime)
		{
			return null;
		}

		// Token: 0x04001000 RID: 4096
		[Token(Token = "0x4001000")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ThemeDuelCombatEventStatisticsObserver _eventStatisticsObserver;

		// Token: 0x04001001 RID: 4097
		[Token(Token = "0x4001001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private ProtoRequestCombatCmd.Types.ArenaCombatTypes _matchmakingWay;
	}
}
