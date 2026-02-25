using System;
using Gameplay.BlitzTournament.Events;
using Gameplay.BlitzTournament.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.BlitzTournaments;
using Protocol.Tournaments;
using ServicesNamespace;
using Utils;

namespace Gameplay.BlitzTournament.Controller
{
	// Token: 0x02000BD9 RID: 3033
	[Token(Token = "0x2000BD9")]
	public class BlitzTournamentController : AbstractController<BlitzTournamentModel, Gameplay.BlitzTournament.Events.BlitzTournamentEvents>
	{
		// Token: 0x06004A4D RID: 19021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A4D")]
		[Address(RVA = "0x98AF", Offset = "0x98AF", VA = "0x98AF")]
		public BlitzTournamentController(BlitzTournamentModel model, Gameplay.BlitzTournament.Events.BlitzTournamentEvents events)
		{
		}

		// Token: 0x06004A4E RID: 19022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A4E")]
		[Address(RVA = "0x98B0", Offset = "0x98B0", VA = "0x98B0")]
		public void StartCombatImmediately()
		{
		}

		// Token: 0x06004A4F RID: 19023 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004A4F")]
		[Address(RVA = "0x98B1", Offset = "0x98B1", VA = "0x98B1")]
		public BlitzTournamentCombat StartListeningForCombatStart()
		{
			return null;
		}

		// Token: 0x06004A50 RID: 19024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A50")]
		[Address(RVA = "0x98B2", Offset = "0x98B2", VA = "0x98B2")]
		public void GetTournamentInfo()
		{
		}

		// Token: 0x06004A51 RID: 19025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A51")]
		[Address(RVA = "0x98B3", Offset = "0x98B3", VA = "0x98B3")]
		private void GetTournamentInfoResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004A52 RID: 19026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A52")]
		[Address(RVA = "0x98B4", Offset = "0x98B4", VA = "0x98B4")]
		public void GetTournamentList()
		{
		}

		// Token: 0x06004A53 RID: 19027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A53")]
		[Address(RVA = "0x98B5", Offset = "0x98B5", VA = "0x98B5")]
		private void GetTournamentListResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004A54 RID: 19028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A54")]
		[Address(RVA = "0x98B6", Offset = "0x98B6", VA = "0x98B6")]
		public void JoinQueue(uint tournamentType)
		{
		}

		// Token: 0x06004A55 RID: 19029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A55")]
		[Address(RVA = "0x98B7", Offset = "0x98B7", VA = "0x98B7")]
		private void JoinQueueResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004A56 RID: 19030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A56")]
		[Address(RVA = "0x98B8", Offset = "0x98B8", VA = "0x98B8")]
		public void LeaveQueue()
		{
		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A57")]
		[Address(RVA = "0x98B9", Offset = "0x98B9", VA = "0x98B9")]
		private void LeaveQueueResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A58")]
		[Address(RVA = "0x98BA", Offset = "0x98BA", VA = "0x98BA")]
		private void FightersCountChangedEventHandler(ProtoFighterCountChangedEvt evt)
		{
		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A59")]
		[Address(RVA = "0x98BB", Offset = "0x98BB", VA = "0x98BB")]
		private void StateChangedEventHandler(Protocol.BlitzTournaments.ProtoStateChangedEvt evt)
		{
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A5A")]
		[Address(RVA = "0x98BC", Offset = "0x98BC", VA = "0x98BC")]
		private void FinalBattleCompleteEventHandler(ProtoFinalTnmCombatCompleteEvt evt)
		{
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A5B")]
		[Address(RVA = "0x98BD", Offset = "0x98BD", VA = "0x98BD")]
		private void HealthChangedEventHandler(ProtoHealthChangedEvt evt)
		{
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A5C")]
		[Address(RVA = "0x98BE", Offset = "0x98BE", VA = "0x98BE")]
		private void JoinRequestCancelledEventHandler(ProtoRequestCanceledEvt evt)
		{
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A5D")]
		[Address(RVA = "0x98BF", Offset = "0x98BF", VA = "0x98BF")]
		private void HandleTournamentState(ProtoGetTournamentInfoAns.Types.TournamentInfo tournamentInfo)
		{
		}

		// Token: 0x06004A5E RID: 19038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A5E")]
		[Address(RVA = "0x98C0", Offset = "0x98C0", VA = "0x98C0")]
		private void ResolveTournamentState(Protocol.BlitzTournaments.TournamentStates currentState)
		{
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A5F")]
		[Address(RVA = "0x98C1", Offset = "0x98C1", VA = "0x98C1")]
		public void SubscribeToServiceEvents()
		{
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A60")]
		[Address(RVA = "0x98C2", Offset = "0x98C2", VA = "0x98C2")]
		public void UnsubscribeFromServiceEvents()
		{
		}

		// Token: 0x06004A61 RID: 19041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A61")]
		[Address(RVA = "0x98C3", Offset = "0x98C3", VA = "0x98C3")]
		public void BlockUI(bool block)
		{
		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A62")]
		[Address(RVA = "0x98C4", Offset = "0x98C4", VA = "0x98C4", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x04002880 RID: 10368
		[Token(Token = "0x4002880")]
		[FieldOffset(Offset = "0x18")]
		private BlitzTournamentService _blitzService;

		// Token: 0x04002881 RID: 10369
		[Token(Token = "0x4002881")]
		[FieldOffset(Offset = "0x1C")]
		private bool _listeningForService;
	}
}
