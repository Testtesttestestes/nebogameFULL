using System;
using Core.Data.Tournaments;
using Gameplay.BlitzTournament.Events;
using Gameplay.BlitzTournament.Model;
using Gameplay.BlitzTournament.View;
using Il2CppDummyDll;
using MVC;
using Protocol.BlitzTournaments;

namespace Gameplay.BlitzTournament.Controller
{
	// Token: 0x02000BDC RID: 3036
	[Token(Token = "0x2000BDC")]
	public class BlitzTournamentViewMediator : AbstractViewMediator<BlitzTournamentModel, Gameplay.BlitzTournament.Events.BlitzTournamentEvents, BlitzTournamentController, BlitzTournamentWindow>
	{
		// Token: 0x06004A7C RID: 19068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A7C")]
		[Address(RVA = "0x98DE", Offset = "0x98DE", VA = "0x98DE")]
		public BlitzTournamentViewMediator(BlitzTournamentModel model, Gameplay.BlitzTournament.Events.BlitzTournamentEvents events, BlitzTournamentController controller)
		{
		}

		// Token: 0x17000F0B RID: 3851
		// (set) Token: 0x06004A7D RID: 19069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F0B")]
		public override Gameplay.BlitzTournament.Events.BlitzTournamentEvents Events
		{
			[Token(Token = "0x6004A7D")]
			[Address(RVA = "0x98DF", Offset = "0x98DF", VA = "0x98DF", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000F0C RID: 3852
		// (set) Token: 0x06004A7E RID: 19070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F0C")]
		public override BlitzTournamentWindow View
		{
			[Token(Token = "0x6004A7E")]
			[Address(RVA = "0x98E0", Offset = "0x98E0", VA = "0x98E0", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004A7F RID: 19071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A7F")]
		[Address(RVA = "0x98E1", Offset = "0x98E1", VA = "0x98E1")]
		private void RulesButtonClickHandler()
		{
		}

		// Token: 0x06004A80 RID: 19072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A80")]
		[Address(RVA = "0x98E2", Offset = "0x98E2", VA = "0x98E2")]
		private void ResolveWindowState(BlitzTournamentWindow.WindowState windowState)
		{
		}

		// Token: 0x06004A81 RID: 19073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A81")]
		[Address(RVA = "0x98E3", Offset = "0x98E3", VA = "0x98E3")]
		private void BlockUIEventHandler(bool block)
		{
		}

		// Token: 0x06004A82 RID: 19074 RVA: 0x0000DB90 File Offset: 0x0000BD90
		[Token(Token = "0x6004A82")]
		[Address(RVA = "0x98E4", Offset = "0x98E4", VA = "0x98E4")]
		private bool CheckForClosePermission()
		{
			return default(bool);
		}

		// Token: 0x06004A83 RID: 19075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A83")]
		[Address(RVA = "0x98E5", Offset = "0x98E5", VA = "0x98E5")]
		private void FightersCountChangedEventHandler(uint count)
		{
		}

		// Token: 0x06004A84 RID: 19076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A84")]
		[Address(RVA = "0x98E6", Offset = "0x98E6", VA = "0x98E6")]
		private void StateChangedEventHandler(ProtoStateChangedEvt evt)
		{
		}

		// Token: 0x06004A85 RID: 19077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A85")]
		[Address(RVA = "0x98E7", Offset = "0x98E7", VA = "0x98E7")]
		private void TournamentInfoReceivedEventHandler()
		{
		}

		// Token: 0x06004A86 RID: 19078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A86")]
		[Address(RVA = "0x98E8", Offset = "0x98E8", VA = "0x98E8")]
		private void ResolveTournamentState(ProtoGetTournamentInfoAns.Types.TournamentInfo info)
		{
		}

		// Token: 0x06004A87 RID: 19079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A87")]
		[Address(RVA = "0x98E9", Offset = "0x98E9", VA = "0x98E9")]
		private void ShowTournamentProgressWindow(BlitzTournamentWindow.WindowState windowState = BlitzTournamentWindow.WindowState.Default)
		{
		}

		// Token: 0x06004A88 RID: 19080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A88")]
		[Address(RVA = "0x98EA", Offset = "0x98EA", VA = "0x98EA")]
		private void LeftQueueEventHandler()
		{
		}

		// Token: 0x06004A89 RID: 19081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A89")]
		[Address(RVA = "0x98EB", Offset = "0x98EB", VA = "0x98EB")]
		private void JoinedQueueEventHandler()
		{
		}

		// Token: 0x06004A8A RID: 19082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A8A")]
		[Address(RVA = "0x98EC", Offset = "0x98EC", VA = "0x98EC")]
		private void EnterTournamentButtonClickHandler()
		{
		}

		// Token: 0x06004A8B RID: 19083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A8B")]
		[Address(RVA = "0x98ED", Offset = "0x98ED", VA = "0x98ED")]
		private void ExitTournamentButtonClickHandler()
		{
		}

		// Token: 0x06004A8C RID: 19084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A8C")]
		[Address(RVA = "0x98EE", Offset = "0x98EE", VA = "0x98EE")]
		private void TournamentListReceivedEventHandler()
		{
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A8D")]
		[Address(RVA = "0x98EF", Offset = "0x98EF", VA = "0x98EF")]
		private void TournamentSelectedEventHandler(TournamentListElementBase listElement)
		{
		}

		// Token: 0x06004A8E RID: 19086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A8E")]
		[Address(RVA = "0x98F0", Offset = "0x98F0", VA = "0x98F0")]
		private void SelectListElement(TournamentListElementBase listElement)
		{
		}

		// Token: 0x06004A8F RID: 19087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A8F")]
		[Address(RVA = "0x98F1", Offset = "0x98F1", VA = "0x98F1")]
		private void UpdateInfoBox(BlitzTournamentData data)
		{
		}

		// Token: 0x0400288A RID: 10378
		[Token(Token = "0x400288A")]
		private const string LOCALIZATION_ABANDON = "BLITZ/ABANDON";

		// Token: 0x0400288B RID: 10379
		[Token(Token = "0x400288B")]
		private const string LOCALIZATION_ENTER_TOURNAMENT = "BLITZ/ENTER_TOURNAMENT";

		// Token: 0x0400288C RID: 10380
		[Token(Token = "0x400288C")]
		private const string LOCALIZATION_LEAVE_QUEUE_FIRST = "BLITZ/LEAVE_QUEUE_FIRST";

		// Token: 0x0400288D RID: 10381
		[Token(Token = "0x400288D")]
		[FieldOffset(Offset = "0x18")]
		private BlitzTournamentListElement _selectedTournament;

		// Token: 0x0400288E RID: 10382
		[Token(Token = "0x400288E")]
		[FieldOffset(Offset = "0x1C")]
		private BlitzTournamentProgressWindow _tournamentProgressWindow;

		// Token: 0x0400288F RID: 10383
		[Token(Token = "0x400288F")]
		[FieldOffset(Offset = "0x20")]
		private BlitzTournamentListElement[] _spawnedElements;
	}
}
