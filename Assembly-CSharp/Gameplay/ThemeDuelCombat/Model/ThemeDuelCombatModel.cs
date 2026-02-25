using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Accounts.Model.Data;
using Gameplay.Combat.Model;
using Gameplay.ThemeDuelState;
using Gameplay.ThemeDuelState.Model;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Common;
using Protocol.Dic;
using Utils;

namespace Gameplay.ThemeDuelCombat.Model
{
	// Token: 0x020004D8 RID: 1240
	[Token(Token = "0x20004D8")]
	public class ThemeDuelCombatModel : CombatModel
	{
		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001D7D RID: 7549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000549")]
		public ThemeDuelStateModel ThemeDuelModel
		{
			[Token(Token = "0x6001D7C")]
			[Address(RVA = "0x6EFB", Offset = "0x6EFB", VA = "0x6EFB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D7D")]
			[Address(RVA = "0x6EFC", Offset = "0x6EFC", VA = "0x6EFC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001D7F RID: 7551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054A")]
		public ThemeDuelStateEvents ThemeDuelEvents
		{
			[Token(Token = "0x6001D7E")]
			[Address(RVA = "0x6EFD", Offset = "0x6EFD", VA = "0x6EFD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D7F")]
			[Address(RVA = "0x6EFE", Offset = "0x6EFE", VA = "0x6EFE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D80")]
		[Address(RVA = "0x6EFF", Offset = "0x6EFF", VA = "0x6EFF", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D81")]
		[Address(RVA = "0x6F00", Offset = "0x6F00", VA = "0x6F00")]
		public ThemeDuelCombatModel(CombatDependencies dependencies, ThemeDuelStateModel themeDuelModel, ThemeDuelStateEvents themeDuelEvents, ProtoRequestCombatCmd.Types.ArenaCombatTypes matchmakingWay, BackTime awaitBackTime, UserData loggedUser, UserData user, BattleAccount battleAccount)
		{
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001D82")]
		[Address(RVA = "0x6F01", Offset = "0x6F01", VA = "0x6F01", Slot = "12")]
		public override ResourceSet GetNextCombatCost()
		{
			return null;
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x000062E8 File Offset: 0x000044E8
		[Token(Token = "0x6001D83")]
		[Address(RVA = "0x6F02", Offset = "0x6F02", VA = "0x6F02")]
		public bool TryGetCurrentDuel(out ThemeDuelDic dic)
		{
			return default(bool);
		}

		// Token: 0x04001008 RID: 4104
		[Token(Token = "0x4001008")]
		[FieldOffset(Offset = "0x5C")]
		public readonly ProtoRequestCombatCmd.Types.ArenaCombatTypes MatchmakingWay;

		// Token: 0x04001009 RID: 4105
		[Token(Token = "0x4001009")]
		[FieldOffset(Offset = "0x60")]
		public readonly Dictionary<ulong, ulong> ThemeDuelScoreByPlayerId;

		// Token: 0x0400100A RID: 4106
		[Token(Token = "0x400100A")]
		[FieldOffset(Offset = "0x64")]
		private readonly ThemeDuelDic _cachedThemeDuelDic;

		// Token: 0x0400100B RID: 4107
		[Token(Token = "0x400100B")]
		[FieldOffset(Offset = "0x68")]
		private readonly BattleAccount _battleAccount;
	}
}
