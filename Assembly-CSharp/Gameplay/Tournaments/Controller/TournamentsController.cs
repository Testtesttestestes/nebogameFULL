using System;
using Core.Data;
using Gameplay.Tournaments.Events;
using Gameplay.Tournaments.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Tournaments;
using ServicesNamespace;
using Utils;

namespace Gameplay.Tournaments.Controller
{
	// Token: 0x020004C8 RID: 1224
	[Token(Token = "0x20004C8")]
	public class TournamentsController : AbstractController<TournamentsModel, TournamentsEvents>
	{
		// Token: 0x06001CF4 RID: 7412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF4")]
		[Address(RVA = "0x6E73", Offset = "0x6E73", VA = "0x6E73")]
		public TournamentsController(TournamentsModel model, TournamentsEvents events)
		{
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF5")]
		[Address(RVA = "0x6E74", Offset = "0x6E74", VA = "0x6E74")]
		public void StartCombatImmediately()
		{
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001CF6")]
		[Address(RVA = "0x6E75", Offset = "0x6E75", VA = "0x6E75")]
		public TournamentCombat StartListeningForCombatStart(UserData user, BackTime backTime)
		{
			return null;
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF7")]
		[Address(RVA = "0x6E76", Offset = "0x6E76", VA = "0x6E76")]
		public void GetTournamentsList()
		{
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF8")]
		[Address(RVA = "0x6E77", Offset = "0x6E77", VA = "0x6E77")]
		private void GetTournamentListResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF9")]
		[Address(RVA = "0x6E78", Offset = "0x6E78", VA = "0x6E78")]
		public void AddBet(uint tournamentTypeId, ResourceSet bet)
		{
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CFA")]
		[Address(RVA = "0x6E79", Offset = "0x6E79", VA = "0x6E79")]
		private void AddBetResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CFB")]
		[Address(RVA = "0x6E7A", Offset = "0x6E7A", VA = "0x6E7A")]
		public void SetBet(uint tournamentTypeId, ulong userId)
		{
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CFC")]
		[Address(RVA = "0x6E7B", Offset = "0x6E7B", VA = "0x6E7B")]
		private void SetBetResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CFD")]
		[Address(RVA = "0x6E7C", Offset = "0x6E7C", VA = "0x6E7C")]
		public void WatchCombat(UserInfo userInfo)
		{
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CFE")]
		[Address(RVA = "0x6E7D", Offset = "0x6E7D", VA = "0x6E7D")]
		public void GetTournamentHistory(uint tournamentTypeId)
		{
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CFF")]
		[Address(RVA = "0x6E7E", Offset = "0x6E7E", VA = "0x6E7E")]
		private void GetTournamentHistoryResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D00")]
		[Address(RVA = "0x6E7F", Offset = "0x6E7F", VA = "0x6E7F")]
		public void LeaveTournament()
		{
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D01")]
		[Address(RVA = "0x6E80", Offset = "0x6E80", VA = "0x6E80")]
		private void LeaveTournamentResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D02")]
		[Address(RVA = "0x6E81", Offset = "0x6E81", VA = "0x6E81")]
		public void Subscribe()
		{
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D03")]
		[Address(RVA = "0x6E82", Offset = "0x6E82", VA = "0x6E82")]
		private void SubscribeResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D04")]
		[Address(RVA = "0x6E83", Offset = "0x6E83", VA = "0x6E83")]
		public void Unsubscribe()
		{
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D05")]
		[Address(RVA = "0x6E84", Offset = "0x6E84", VA = "0x6E84")]
		private void UnsubscribeResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D06")]
		[Address(RVA = "0x6E85", Offset = "0x6E85", VA = "0x6E85")]
		public void SubscribeToParticipantEvents()
		{
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D07")]
		[Address(RVA = "0x6E86", Offset = "0x6E86", VA = "0x6E86")]
		public void UnsubscribeFromParticipantEvents()
		{
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D08")]
		[Address(RVA = "0x6E87", Offset = "0x6E87", VA = "0x6E87")]
		public void BlockUI(bool block)
		{
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D09")]
		[Address(RVA = "0x6E88", Offset = "0x6E88", VA = "0x6E88")]
		private void BetChangedEventHandler(ProtoBetChangedEvt evt)
		{
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0A")]
		[Address(RVA = "0x6E89", Offset = "0x6E89", VA = "0x6E89")]
		private void BetOnPlayerChangedEventHandler(ProtoBetChangedOnPlayerEvt evt)
		{
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0B")]
		[Address(RVA = "0x6E8A", Offset = "0x6E8A", VA = "0x6E8A")]
		private void HealthChangedEventHandler(ProtoHealtChangedEvt evt)
		{
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0C")]
		[Address(RVA = "0x6E8B", Offset = "0x6E8B", VA = "0x6E8B")]
		private void StateChangedEventHandler(ProtoStateChangedEvt evt)
		{
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0D")]
		[Address(RVA = "0x6E8C", Offset = "0x6E8C", VA = "0x6E8C")]
		private void HandleTournamentState(StateInfo stateInfo)
		{
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0E")]
		[Address(RVA = "0x6E8D", Offset = "0x6E8D", VA = "0x6E8D")]
		private void CurrentCombatCompleteEventHandler(ProtoCurrentTnmCombatCompleteEvt evt)
		{
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0F")]
		[Address(RVA = "0x6E8E", Offset = "0x6E8E", VA = "0x6E8E")]
		private void FinalCombatCompleteEventHandler(ProtoFinalTnmCombatCompleteEvt evt)
		{
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D10")]
		[Address(RVA = "0x6E8F", Offset = "0x6E8F", VA = "0x6E8F", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x04000FD2 RID: 4050
		[Token(Token = "0x4000FD2")]
		[FieldOffset(Offset = "0x18")]
		private TournamentsService _tournamentsService;

		// Token: 0x04000FD3 RID: 4051
		[Token(Token = "0x4000FD3")]
		[FieldOffset(Offset = "0x1C")]
		private bool _subscribed;

		// Token: 0x04000FD4 RID: 4052
		[Token(Token = "0x4000FD4")]
		[FieldOffset(Offset = "0x1D")]
		private bool _participantSubscribed;
	}
}
