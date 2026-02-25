using System;
using Gameplay.Combat.Control;
using Gameplay.Combat.View;
using Gameplay.Tournaments.Events;
using Gameplay.Tournaments.Model;
using Il2CppDummyDll;
using Protocol.Tournaments;

namespace Gameplay.Tournaments.Controller
{
	// Token: 0x020004BD RID: 1213
	[Token(Token = "0x20004BD")]
	public class TournamentCombatViewMediator : OneOnOneCombatViewMediator<TournamentCombatModel, TournamentCombatEvents, TournamentCombatController>
	{
		// Token: 0x06001CAF RID: 7343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAF")]
		[Address(RVA = "0x6E2E", Offset = "0x6E2E", VA = "0x6E2E")]
		public TournamentCombatViewMediator(TournamentCombatModel model, TournamentCombatEvents events, TournamentCombatController controller)
		{
		}

		// Token: 0x1700052D RID: 1325
		// (set) Token: 0x06001CB0 RID: 7344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052D")]
		public override OneOnOneCombatView View
		{
			[Token(Token = "0x6001CB0")]
			[Address(RVA = "0x6E2F", Offset = "0x6E2F", VA = "0x6E2F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB1")]
		[Address(RVA = "0x6E30", Offset = "0x6E30", VA = "0x6E30")]
		private void CloseButtonClickedEventHandler()
		{
		}

		// Token: 0x1700052E RID: 1326
		// (set) Token: 0x06001CB2 RID: 7346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052E")]
		public override TournamentCombatEvents Events
		{
			[Token(Token = "0x6001CB2")]
			[Address(RVA = "0x6E31", Offset = "0x6E31", VA = "0x6E31", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB3")]
		[Address(RVA = "0x6E32", Offset = "0x6E32", VA = "0x6E32")]
		private void FinalBattleCompletedEventHandler(ProtoFinalTnmCombatCompleteEvt evt)
		{
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB4")]
		[Address(RVA = "0x6E33", Offset = "0x6E33", VA = "0x6E33")]
		private void CurrentBattleCompletedEventHandler(ProtoCurrentTnmCombatCompleteEvt evt)
		{
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB5")]
		[Address(RVA = "0x6E34", Offset = "0x6E34", VA = "0x6E34")]
		public void ReturnToTournament()
		{
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB6")]
		[Address(RVA = "0x6E35", Offset = "0x6E35", VA = "0x6E35", Slot = "37")]
		protected override void HandleGameOver()
		{
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB7")]
		[Address(RVA = "0x6E36", Offset = "0x6E36", VA = "0x6E36", Slot = "34")]
		protected override void HandleFieldInteraction()
		{
		}

		// Token: 0x04000FAC RID: 4012
		[Token(Token = "0x4000FAC")]
		[FieldOffset(Offset = "0x34")]
		private bool _isFinalCombat;

		// Token: 0x04000FAD RID: 4013
		[Token(Token = "0x4000FAD")]
		[FieldOffset(Offset = "0x38")]
		private ProtoCurrentTnmCombatCompleteEvt _completeEvent;
	}
}
