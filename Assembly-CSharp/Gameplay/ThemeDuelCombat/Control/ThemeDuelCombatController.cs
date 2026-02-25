using System;
using System.Collections.Generic;
using Gameplay.ArenaCombat;
using Gameplay.Combat.Control;
using Gameplay.Combat.Model;
using Gameplay.ThemeDuelCombat.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Themeduel;
using ServicesNamespace;
using Utils;

namespace Gameplay.ThemeDuelCombat.Control
{
	// Token: 0x020004D9 RID: 1241
	[Token(Token = "0x20004D9")]
	public class ThemeDuelCombatController : CombatController<ThemeDuelCombatModel, ThemeDuelCombatEvents>
	{
		// Token: 0x06001D84 RID: 7556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D84")]
		[Address(RVA = "0x6F03", Offset = "0x6F03", VA = "0x6F03")]
		public ThemeDuelCombatController(ICombatService service, ThemeDuelCombatModel model, ThemeDuelCombatEvents events, ThemeDuelCombatEventStatisticsObserver combatEventObserver)
		{
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D85")]
		[Address(RVA = "0x6F04", Offset = "0x6F04", VA = "0x6F04")]
		private void OnTurn(bool isPlayerStep)
		{
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D86")]
		[Address(RVA = "0x6F05", Offset = "0x6F05", VA = "0x6F05", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D87")]
		[Address(RVA = "0x6F06", Offset = "0x6F06", VA = "0x6F06")]
		private void OnScoreChanged(long score)
		{
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D88")]
		[Address(RVA = "0x6F07", Offset = "0x6F07", VA = "0x6F07", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D89")]
		[Address(RVA = "0x6F08", Offset = "0x6F08", VA = "0x6F08", Slot = "18")]
		protected override void HandleJoinToCombatInfoChanged()
		{
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D8A")]
		[Address(RVA = "0x6F09", Offset = "0x6F09", VA = "0x6F09", Slot = "23")]
		protected override void HandleGameOverInfoChanged(GameOverData gameOverData)
		{
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D8B")]
		[Address(RVA = "0x6F0A", Offset = "0x6F0A", VA = "0x6F0A")]
		private void RequestPutJoinRequest(ProtoRequestCombatCmd.Types.ArenaCombatTypes type)
		{
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D8C")]
		[Address(RVA = "0x6F0B", Offset = "0x6F0B", VA = "0x6F0B")]
		private void HandlePutJoinServiceRequest(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D8D")]
		[Address(RVA = "0x6F0C", Offset = "0x6F0C", VA = "0x6F0C", Slot = "15")]
		protected override void AddCombatServiceEventsHandlers()
		{
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D8E")]
		[Address(RVA = "0x6F0D", Offset = "0x6F0D", VA = "0x6F0D", Slot = "16")]
		protected override void RemoveCombatServiceEventsHandlers()
		{
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D8F")]
		[Address(RVA = "0x6F0E", Offset = "0x6F0E", VA = "0x6F0E")]
		private void HandelCurrentThemeDuelStateChanged(ProtoThemeDuelStateChangedEvt msg)
		{
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D90")]
		[Address(RVA = "0x6F0F", Offset = "0x6F0F", VA = "0x6F0F")]
		private void HandleThemeScoreChangedEvt(ProtoThemeScoreChangedEvt msg)
		{
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x00006300 File Offset: 0x00004500
		[Token(Token = "0x6001D91")]
		[Address(RVA = "0x6F10", Offset = "0x6F10", VA = "0x6F10", Slot = "20")]
		protected override bool TryHandleJoinError(ProtoJoinToCombatAns msg)
		{
			return default(bool);
		}

		// Token: 0x0400100E RID: 4110
		[Token(Token = "0x400100E")]
		[FieldOffset(Offset = "0x0")]
		private static Random _duelIdRandom;

		// Token: 0x0400100F RID: 4111
		[Token(Token = "0x400100F")]
		[FieldOffset(Offset = "0x20")]
		private long _startBalance;

		// Token: 0x04001010 RID: 4112
		[Token(Token = "0x4001010")]
		[FieldOffset(Offset = "0x28")]
		private long _gameBalance;

		// Token: 0x04001011 RID: 4113
		[Token(Token = "0x4001011")]
		[FieldOffset(Offset = "0x30")]
		private int _duelId;

		// Token: 0x04001012 RID: 4114
		[Token(Token = "0x4001012")]
		[FieldOffset(Offset = "0x34")]
		private int _numSteps;

		// Token: 0x04001013 RID: 4115
		[Token(Token = "0x4001013")]
		[FieldOffset(Offset = "0x38")]
		private long _startTs;

		// Token: 0x04001014 RID: 4116
		[Token(Token = "0x4001014")]
		[FieldOffset(Offset = "0x40")]
		private readonly ThemeDuelCombatEventStatisticsObserver _combatEventObserver;

		// Token: 0x04001015 RID: 4117
		[Token(Token = "0x4001015")]
		[FieldOffset(Offset = "0x44")]
		private readonly Dictionary<int, int> _eventStoneMatchesMap;
	}
}
