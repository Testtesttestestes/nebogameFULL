using System;
using Gameplay.Combat.Control;
using Gameplay.Tournaments.Events;
using Gameplay.Tournaments.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Tournaments;
using ServicesNamespace;
using Utils;

namespace Gameplay.Tournaments.Controller
{
	// Token: 0x020004BC RID: 1212
	[Token(Token = "0x20004BC")]
	public class TournamentCombatController : CombatController<TournamentCombatModel, TournamentCombatEvents>
	{
		// Token: 0x06001CA3 RID: 7331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA3")]
		[Address(RVA = "0x6E22", Offset = "0x6E22", VA = "0x6E22")]
		public TournamentCombatController(TournamentsService tournamentsService, ICombatService service, TournamentCombatModel model, TournamentCombatEvents events)
		{
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA4")]
		[Address(RVA = "0x6E23", Offset = "0x6E23", VA = "0x6E23")]
		public void WatchCombat()
		{
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA5")]
		[Address(RVA = "0x6E24", Offset = "0x6E24", VA = "0x6E24")]
		private void WatchCombatResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA6")]
		[Address(RVA = "0x6E25", Offset = "0x6E25", VA = "0x6E25", Slot = "25")]
		public override void NotifyShowViewProcessComplete()
		{
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00006018 File Offset: 0x00004218
		[Token(Token = "0x6001CA7")]
		[Address(RVA = "0x6E26", Offset = "0x6E26", VA = "0x6E26", Slot = "22")]
		protected override bool IsOtherPlayer(ProtoPlayerActionEvt msg)
		{
			return default(bool);
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA8")]
		[Address(RVA = "0x6E27", Offset = "0x6E27", VA = "0x6E27")]
		public void AppendGameOver()
		{
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA9")]
		[Address(RVA = "0x6E28", Offset = "0x6E28", VA = "0x6E28")]
		public void StopWatchingCombat()
		{
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAA")]
		[Address(RVA = "0x6E29", Offset = "0x6E29", VA = "0x6E29")]
		private void StopWatchingCombatResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAB")]
		[Address(RVA = "0x6E2A", Offset = "0x6E2A", VA = "0x6E2A", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAC")]
		[Address(RVA = "0x6E2B", Offset = "0x6E2B", VA = "0x6E2B", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAD")]
		[Address(RVA = "0x6E2C", Offset = "0x6E2C", VA = "0x6E2C")]
		private void CurrentCombatCompleteEventHandler(ProtoCurrentTnmCombatCompleteEvt evt)
		{
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAE")]
		[Address(RVA = "0x6E2D", Offset = "0x6E2D", VA = "0x6E2D")]
		private void FinalCombatCompleteEventHandler(ProtoFinalTnmCombatCompleteEvt evt)
		{
		}

		// Token: 0x04000FAB RID: 4011
		[Token(Token = "0x4000FAB")]
		[FieldOffset(Offset = "0x20")]
		private TournamentsService _tournamentsService;
	}
}
