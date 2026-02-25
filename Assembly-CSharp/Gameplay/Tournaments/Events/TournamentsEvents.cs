using System;
using Il2CppDummyDll;
using MVC;
using Protocol.Tournaments;

namespace Gameplay.Tournaments.Events
{
	// Token: 0x020004BB RID: 1211
	[Token(Token = "0x20004BB")]
	public class TournamentsEvents : AbstractMVCEvents
	{
		// Token: 0x06001CA2 RID: 7330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA2")]
		[Address(RVA = "0x6E21", Offset = "0x6E21", VA = "0x6E21")]
		public TournamentsEvents()
		{
		}

		// Token: 0x04000FA0 RID: 4000
		[Token(Token = "0x4000FA0")]
		[FieldOffset(Offset = "0x14")]
		public Action TournamentsListRequestedEvent;

		// Token: 0x04000FA1 RID: 4001
		[Token(Token = "0x4000FA1")]
		[FieldOffset(Offset = "0x18")]
		public Action PlayerBetAddedEvent;

		// Token: 0x04000FA2 RID: 4002
		[Token(Token = "0x4000FA2")]
		[FieldOffset(Offset = "0x1C")]
		public Action<ulong> PlayerBetOnPlayerSetEvent;

		// Token: 0x04000FA3 RID: 4003
		[Token(Token = "0x4000FA3")]
		[FieldOffset(Offset = "0x20")]
		public Action<bool> UIBlockedChangedEvent;

		// Token: 0x04000FA4 RID: 4004
		[Token(Token = "0x4000FA4")]
		[FieldOffset(Offset = "0x24")]
		public Action HistoryRequestedEvent;

		// Token: 0x04000FA5 RID: 4005
		[Token(Token = "0x4000FA5")]
		[FieldOffset(Offset = "0x28")]
		public Action<ProtoBetChangedEvt> BetChangedEvent;

		// Token: 0x04000FA6 RID: 4006
		[Token(Token = "0x4000FA6")]
		[FieldOffset(Offset = "0x2C")]
		public Action<ProtoBetChangedOnPlayerEvt> BetChangedOnPlayerEvent;

		// Token: 0x04000FA7 RID: 4007
		[Token(Token = "0x4000FA7")]
		[FieldOffset(Offset = "0x30")]
		public Action<ProtoHealtChangedEvt> HealthChangedEvent;

		// Token: 0x04000FA8 RID: 4008
		[Token(Token = "0x4000FA8")]
		[FieldOffset(Offset = "0x34")]
		public Action<ProtoStateChangedEvt> StateChangedEvent;

		// Token: 0x04000FA9 RID: 4009
		[Token(Token = "0x4000FA9")]
		[FieldOffset(Offset = "0x38")]
		public Action<ProtoCurrentTnmCombatCompleteEvt> CurrentCombatCompleteEvent;

		// Token: 0x04000FAA RID: 4010
		[Token(Token = "0x4000FAA")]
		[FieldOffset(Offset = "0x3C")]
		public Action<ProtoFinalTnmCombatCompleteEvt> FinalCombatCompleteEvent;
	}
}
