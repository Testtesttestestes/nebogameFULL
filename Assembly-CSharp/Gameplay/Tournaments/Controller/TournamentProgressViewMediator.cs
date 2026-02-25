using System;
using System.Collections.Generic;
using Gameplay.Tournaments.Events;
using Gameplay.Tournaments.Model;
using Gameplay.Tournaments.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Tournaments;
using UnityEngine;

namespace Gameplay.Tournaments.Controller
{
	// Token: 0x020004C0 RID: 1216
	[Token(Token = "0x20004C0")]
	public class TournamentProgressViewMediator : AbstractViewMediator<TournamentsModel, TournamentsEvents, TournamentsController, TournamentProgressWindow>
	{
		// Token: 0x06001CC3 RID: 7363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CC3")]
		[Address(RVA = "0x6E42", Offset = "0x6E42", VA = "0x6E42")]
		public TournamentProgressViewMediator(TournamentsModel model, TournamentsEvents events, TournamentsController controller)
		{
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x00006048 File Offset: 0x00004248
		[Token(Token = "0x17000530")]
		private TournamentStates _currentState
		{
			[Token(Token = "0x6001CC4")]
			[Address(RVA = "0x6E43", Offset = "0x6E43", VA = "0x6E43")]
			get
			{
				return TournamentStates.NoTournament;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x00006060 File Offset: 0x00004260
		[Token(Token = "0x17000531")]
		private bool _selectable
		{
			[Token(Token = "0x6001CC5")]
			[Address(RVA = "0x6E44", Offset = "0x6E44", VA = "0x6E44")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000532 RID: 1330
		// (set) Token: 0x06001CC6 RID: 7366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000532")]
		public override TournamentProgressWindow View
		{
			[Token(Token = "0x6001CC6")]
			[Address(RVA = "0x6E45", Offset = "0x6E45", VA = "0x6E45", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000533 RID: 1331
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000533")]
		public override TournamentsEvents Events
		{
			[Token(Token = "0x6001CC7")]
			[Address(RVA = "0x6E46", Offset = "0x6E46", VA = "0x6E46", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CC8")]
		[Address(RVA = "0x6E47", Offset = "0x6E47", VA = "0x6E47")]
		private void CurrentCombatCompleteEventHandler(ProtoCurrentTnmCombatCompleteEvt evt)
		{
		}

		// Token: 0x17000534 RID: 1332
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000534")]
		public override TournamentsController Controller
		{
			[Token(Token = "0x6001CC9")]
			[Address(RVA = "0x6E48", Offset = "0x6E48", VA = "0x6E48", Slot = "18")]
			set
			{
			}
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCA")]
		[Address(RVA = "0x6E49", Offset = "0x6E49", VA = "0x6E49")]
		private void Init()
		{
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCB")]
		[Address(RVA = "0x6E4A", Offset = "0x6E4A", VA = "0x6E4A")]
		private void RulesButtonClickHandler()
		{
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCC")]
		[Address(RVA = "0x6E4B", Offset = "0x6E4B", VA = "0x6E4B")]
		private void WatchBattleButtonClickedEventHandler(UserInfo userInfo)
		{
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCD")]
		[Address(RVA = "0x6E4C", Offset = "0x6E4C", VA = "0x6E4C")]
		private void StateChangedEventHandler(ProtoStateChangedEvt evt)
		{
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCE")]
		[Address(RVA = "0x6E4D", Offset = "0x6E4D", VA = "0x6E4D")]
		private void BetChangedOnPlayerEventHandler(ProtoBetChangedOnPlayerEvt evt)
		{
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCF")]
		[Address(RVA = "0x6E4E", Offset = "0x6E4E", VA = "0x6E4E")]
		private void BetOnPlayerEventHandler(ulong userId)
		{
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD0")]
		[Address(RVA = "0x6E4F", Offset = "0x6E4F", VA = "0x6E4F")]
		private void PlayerViewClickedEventHandler(TournamentPlayerBattleView playerView)
		{
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD1")]
		[Address(RVA = "0x6E50", Offset = "0x6E50", VA = "0x6E50")]
		private void HealthChangedEventHandler(ProtoHealtChangedEvt evt)
		{
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD2")]
		[Address(RVA = "0x6E51", Offset = "0x6E51", VA = "0x6E51")]
		private void DeterminePlayerRole()
		{
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD3")]
		[Address(RVA = "0x6E52", Offset = "0x6E52", VA = "0x6E52")]
		private void PopulateTournamentGrid()
		{
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD4")]
		[Address(RVA = "0x6E53", Offset = "0x6E53", VA = "0x6E53")]
		private void UpdateView()
		{
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD5")]
		[Address(RVA = "0x6E54", Offset = "0x6E54", VA = "0x6E54")]
		private void HandleGladiatorRole()
		{
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD6")]
		[Address(RVA = "0x6E55", Offset = "0x6E55", VA = "0x6E55")]
		private void HandleLoseGladiator()
		{
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD7")]
		[Address(RVA = "0x6E56", Offset = "0x6E56", VA = "0x6E56")]
		private void HandleWinGladiator()
		{
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD8")]
		[Address(RVA = "0x6E57", Offset = "0x6E57", VA = "0x6E57")]
		private void HandleViewerRole()
		{
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD9")]
		[Address(RVA = "0x6E58", Offset = "0x6E58", VA = "0x6E58")]
		private void HandleNoFighter()
		{
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDA")]
		[Address(RVA = "0x6E59", Offset = "0x6E59", VA = "0x6E59")]
		private void HandleLoseViewer(StateInfo stateInfo)
		{
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDB")]
		[Address(RVA = "0x6E5A", Offset = "0x6E5A", VA = "0x6E5A")]
		private void HandleWinViewer(StateInfo stateInfo)
		{
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDC")]
		[Address(RVA = "0x6E5B", Offset = "0x6E5B", VA = "0x6E5B")]
		private void DisplayOpponentName()
		{
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDD")]
		[Address(RVA = "0x6E5C", Offset = "0x6E5C", VA = "0x6E5C")]
		private void DisplayPageBeforeBet()
		{
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDE")]
		[Address(RVA = "0x6E5D", Offset = "0x6E5D", VA = "0x6E5D")]
		private void DisplayBetOnPlayerForViewer(ulong userId)
		{
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDF")]
		[Address(RVA = "0x6E5E", Offset = "0x6E5E", VA = "0x6E5E")]
		private void UpdateBetOnPlayerForViewer()
		{
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE0")]
		[Address(RVA = "0x6E5F", Offset = "0x6E5F", VA = "0x6E5F")]
		private void DisplayBetOnPlayerInfo()
		{
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE1")]
		[Address(RVA = "0x6E60", Offset = "0x6E60", VA = "0x6E60")]
		private void UpdateBetsOnPlayer()
		{
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001CE2")]
		[Address(RVA = "0x6E61", Offset = "0x6E61", VA = "0x6E61")]
		private string GetBetsOnFighterText(Fighter fighter)
		{
			return null;
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001CE3")]
		[Address(RVA = "0x6E62", Offset = "0x6E62", VA = "0x6E62")]
		private string GetGainForFighterText(Fighter fighter)
		{
			return null;
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE4")]
		[Address(RVA = "0x6E63", Offset = "0x6E63", VA = "0x6E63", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x04000FB2 RID: 4018
		[Token(Token = "0x4000FB2")]
		private const string LOCALIZATION_GLADIATOR_ANNOTATION = "TOURNAMENTS/GLADIATOR_ANNOTATION";

		// Token: 0x04000FB3 RID: 4019
		[Token(Token = "0x4000FB3")]
		private const string LOCALIZATION_FOR_VICTORY = "TOURNAMENTS/FOR_VICTORY";

		// Token: 0x04000FB4 RID: 4020
		[Token(Token = "0x4000FB4")]
		private const string LOCALIZATION_BETS_ON_VICTORY = "TOURNAMENTS/BETS_ON_VICTORY";

		// Token: 0x04000FB5 RID: 4021
		[Token(Token = "0x4000FB5")]
		private const string LOCALIZATION_GAIN_INCREASE = "TOURNAMENTS/GAIN_INCREASE";

		// Token: 0x04000FB6 RID: 4022
		[Token(Token = "0x4000FB6")]
		private const string LOCALIZATION_MADE_BET = "TOURNAMENTS/MADE_BET";

		// Token: 0x04000FB7 RID: 4023
		[Token(Token = "0x4000FB7")]
		private const string LOCALIZATION_PLAYER_BET_PERCENTAGE = "TOURNAMENTS/PLAYER_BET_PERCENTAGE";

		// Token: 0x04000FB8 RID: 4024
		[Token(Token = "0x4000FB8")]
		private const string LOCALIZATION_POSSIBLE_GAIN = "TOURNAMENTS/POSSIBLE_GAIN";

		// Token: 0x04000FB9 RID: 4025
		[Token(Token = "0x4000FB9")]
		private const string LOCALIZATION_ARENA_LEVEL_ANNOTATION = "TOURNAMENTS/ARENA_LEVEL_ANNOTATION";

		// Token: 0x04000FBA RID: 4026
		[Token(Token = "0x4000FBA")]
		private const string LOCALIZATION_BET_WARNING = "TOURNAMENTS/BET_WARNING";

		// Token: 0x04000FBB RID: 4027
		[Token(Token = "0x4000FBB")]
		private const string LOCALIZATION_CHOOSE_BET_ANNOTATION = "TOURNAMENTS/CHOOSE_BET_ANNOTATION";

		// Token: 0x04000FBC RID: 4028
		[Token(Token = "0x4000FBC")]
		private const string LOCALIZATION_LOSE_ANNOTATION = "TOURNAMENTS/LOSE_ANNOTATION";

		// Token: 0x04000FBD RID: 4029
		[Token(Token = "0x4000FBD")]
		private const string LOCALIZATION_WIN_ANNOTATION = "TOURNAMENTS/WIN_ANNOTATION";

		// Token: 0x04000FBE RID: 4030
		[Token(Token = "0x4000FBE")]
		private const string LOCALIZATION_FIGHTER_LOST_ANNOTATION = "TOURNAMENTS/FIGHTER_LOST_ANNOTATION";

		// Token: 0x04000FBF RID: 4031
		[Token(Token = "0x4000FBF")]
		private const string LOCALIZATION_FIGHTER_WON_ANNOTATION = "TOURNAMENTS/FIGHTER_WON_ANNOTATION";

		// Token: 0x04000FC0 RID: 4032
		[Token(Token = "0x4000FC0")]
		private const string LOCALIZATION_BET_BURNED = "TOURNAMENTS/BET_BURNED";

		// Token: 0x04000FC1 RID: 4033
		[Token(Token = "0x4000FC1")]
		private const int TO_PERCENT = 100;

		// Token: 0x04000FC2 RID: 4034
		[Token(Token = "0x4000FC2")]
		[FieldOffset(Offset = "0x18")]
		private readonly Color _color;

		// Token: 0x04000FC3 RID: 4035
		[Token(Token = "0x4000FC3")]
		[FieldOffset(Offset = "0x28")]
		private UserTNMStatus _playerStatus;

		// Token: 0x04000FC4 RID: 4036
		[Token(Token = "0x4000FC4")]
		[FieldOffset(Offset = "0x2C")]
		private TournamentBattleInfoListElement[] _listElements;

		// Token: 0x04000FC5 RID: 4037
		[Token(Token = "0x4000FC5")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<ulong, TournamentPlayerBattleView> _playerViewsById;

		// Token: 0x04000FC6 RID: 4038
		[Token(Token = "0x4000FC6")]
		[FieldOffset(Offset = "0x34")]
		private TournamentPlayerBattleView _selectedPlayer;
	}
}
