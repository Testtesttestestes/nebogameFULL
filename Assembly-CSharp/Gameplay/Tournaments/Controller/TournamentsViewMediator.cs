using System;
using Core.Data.Tournaments;
using Gameplay.BlitzTournament.View;
using Gameplay.Tournaments.Events;
using Gameplay.Tournaments.Model;
using Gameplay.Tournaments.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Tournaments;

namespace Gameplay.Tournaments.Controller
{
	// Token: 0x020004CB RID: 1227
	[Token(Token = "0x20004CB")]
	public class TournamentsViewMediator : AbstractViewMediator<TournamentsModel, TournamentsEvents, TournamentsController, TournamentsWindow>
	{
		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001D19 RID: 7449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000535")]
		private TournamentProgressWindow TournamentProgressWindow
		{
			[Token(Token = "0x6001D18")]
			[Address(RVA = "0x6E97", Offset = "0x6E97", VA = "0x6E97")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D19")]
			[Address(RVA = "0x6E98", Offset = "0x6E98", VA = "0x6E98")]
			set
			{
			}
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1A")]
		[Address(RVA = "0x6E99", Offset = "0x6E99", VA = "0x6E99")]
		public TournamentsViewMediator(TournamentsModel model, TournamentsEvents events, TournamentsController controller)
		{
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1B")]
		[Address(RVA = "0x6E9A", Offset = "0x6E9A", VA = "0x6E9A")]
		private void ProgressWindowClosedEventHandler()
		{
		}

		// Token: 0x17000536 RID: 1334
		// (set) Token: 0x06001D1C RID: 7452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000536")]
		public override TournamentsWindow View
		{
			[Token(Token = "0x6001D1C")]
			[Address(RVA = "0x6E9B", Offset = "0x6E9B", VA = "0x6E9B", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000537 RID: 1335
		// (set) Token: 0x06001D1D RID: 7453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000537")]
		public override TournamentsEvents Events
		{
			[Token(Token = "0x6001D1D")]
			[Address(RVA = "0x6E9C", Offset = "0x6E9C", VA = "0x6E9C", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1E")]
		[Address(RVA = "0x6E9D", Offset = "0x6E9D", VA = "0x6E9D")]
		private void SubscribeToEvents()
		{
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1F")]
		[Address(RVA = "0x6E9E", Offset = "0x6E9E", VA = "0x6E9E")]
		private void UnsubscribeFromEvents()
		{
		}

		// Token: 0x17000538 RID: 1336
		// (set) Token: 0x06001D20 RID: 7456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000538")]
		public override TournamentsController Controller
		{
			[Token(Token = "0x6001D20")]
			[Address(RVA = "0x6E9F", Offset = "0x6E9F", VA = "0x6E9F", Slot = "18")]
			set
			{
			}
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D21")]
		[Address(RVA = "0x6EA0", Offset = "0x6EA0", VA = "0x6EA0")]
		private void Init()
		{
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D22")]
		[Address(RVA = "0x6EA1", Offset = "0x6EA1", VA = "0x6EA1")]
		private void InTournamentButtonClickedEventHandler()
		{
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D23")]
		[Address(RVA = "0x6EA2", Offset = "0x6EA2", VA = "0x6EA2")]
		private void QuitButtonClickedEventHandler()
		{
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D24")]
		[Address(RVA = "0x6EA3", Offset = "0x6EA3", VA = "0x6EA3")]
		private void HistoryButtonClickedEventHandler()
		{
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D25")]
		[Address(RVA = "0x6EA4", Offset = "0x6EA4", VA = "0x6EA4")]
		private void BetAddedButtonClickedEventHandler(ResourceSet bet)
		{
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D26")]
		[Address(RVA = "0x6EA5", Offset = "0x6EA5", VA = "0x6EA5")]
		private void RulesButtonClickHandler()
		{
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D27")]
		[Address(RVA = "0x6EA6", Offset = "0x6EA6", VA = "0x6EA6")]
		private void UIBlockedChangedEventHandler(bool block)
		{
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D28")]
		[Address(RVA = "0x6EA7", Offset = "0x6EA7", VA = "0x6EA7")]
		private void HistoryRequestedEventHandler()
		{
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D29")]
		[Address(RVA = "0x6EA8", Offset = "0x6EA8", VA = "0x6EA8")]
		private void StateChangedEventHandler(ProtoStateChangedEvt evt)
		{
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D2A")]
		[Address(RVA = "0x6EA9", Offset = "0x6EA9", VA = "0x6EA9")]
		private void PlayerBetAddedEventHandler()
		{
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D2B")]
		[Address(RVA = "0x6EAA", Offset = "0x6EAA", VA = "0x6EAA")]
		private void BetChangedEventHandler(ProtoBetChangedEvt evt)
		{
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D2C")]
		[Address(RVA = "0x6EAB", Offset = "0x6EAB", VA = "0x6EAB")]
		private void TournamentListRequestedEventHandler()
		{
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D2D")]
		[Address(RVA = "0x6EAC", Offset = "0x6EAC", VA = "0x6EAC")]
		private void TournamentSelectedEventHandler(TournamentListElementBase listElement)
		{
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D2E")]
		[Address(RVA = "0x6EAD", Offset = "0x6EAD", VA = "0x6EAD")]
		private void BlockUIIfNeeded()
		{
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D2F")]
		[Address(RVA = "0x6EAE", Offset = "0x6EAE", VA = "0x6EAE")]
		private void SelectListElement(TournamentListElementBase listElement)
		{
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D30")]
		[Address(RVA = "0x6EAF", Offset = "0x6EAF", VA = "0x6EAF")]
		private void ResolveInfoBoxState(TournamentInfoBox.State state, TournamentData data)
		{
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D31")]
		[Address(RVA = "0x6EB0", Offset = "0x6EB0", VA = "0x6EB0")]
		private void ResolveTournamentState(StateInfo stateInfo, uint tournamentTypeId)
		{
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x00006180 File Offset: 0x00004380
		[Token(Token = "0x6001D32")]
		[Address(RVA = "0x6EB1", Offset = "0x6EB1", VA = "0x6EB1")]
		private bool DetermineIfPlayerCanLeave(StateInfo stateInfo)
		{
			return default(bool);
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D33")]
		[Address(RVA = "0x6EB2", Offset = "0x6EB2", VA = "0x6EB2")]
		private void OpenTournamentProgressWindow(uint tournamentTypeId)
		{
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D34")]
		[Address(RVA = "0x6EB3", Offset = "0x6EB3", VA = "0x6EB3")]
		private void UpdateInfoBox(TournamentData data)
		{
		}

		// Token: 0x04000FDA RID: 4058
		[Token(Token = "0x4000FDA")]
		private const string LOCALIZATION_LEAVE_QUEUE_FIRST = "BLITZ/LEAVE_QUEUE_FIRST";

		// Token: 0x04000FDB RID: 4059
		[Token(Token = "0x4000FDB")]
		private const string LOCALIZATION_MIN_LEVEL_REQUIREMENT = "TOURNAMENTS/MIN_LEVEL_REQUIREMENT";

		// Token: 0x04000FDC RID: 4060
		[Token(Token = "0x4000FDC")]
		[FieldOffset(Offset = "0x18")]
		private TournamentListElement _selectedTournament;

		// Token: 0x04000FDD RID: 4061
		[Token(Token = "0x4000FDD")]
		[FieldOffset(Offset = "0x1C")]
		private TournamentListElement[] _spawnedElements;

		// Token: 0x04000FDE RID: 4062
		[Token(Token = "0x4000FDE")]
		[FieldOffset(Offset = "0x20")]
		private TournamentProgressWindow _tournamentProgressWindow;

		// Token: 0x04000FDF RID: 4063
		[Token(Token = "0x4000FDF")]
		[FieldOffset(Offset = "0x24")]
		private bool _initComplete;
	}
}
