using System;
using Gameplay.BlitzTournament.Events;
using Gameplay.BlitzTournament.Model;
using Gameplay.BlitzTournament.View;
using Il2CppDummyDll;
using MVC;
using Protocol.BlitzTournaments;

namespace Gameplay.BlitzTournament.Controller
{
	// Token: 0x02000BDB RID: 3035
	[Token(Token = "0x2000BDB")]
	public class BlitzTournamentProgressMediator : AbstractViewMediator<BlitzTournamentModel, Gameplay.BlitzTournament.Events.BlitzTournamentEvents, BlitzTournamentController, BlitzTournamentProgressWindow>
	{
		// Token: 0x06004A65 RID: 19045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A65")]
		[Address(RVA = "0x98C7", Offset = "0x98C7", VA = "0x98C7")]
		public BlitzTournamentProgressMediator(BlitzTournamentModel model, Gameplay.BlitzTournament.Events.BlitzTournamentEvents events, BlitzTournamentController controller)
		{
		}

		// Token: 0x17000F09 RID: 3849
		// (set) Token: 0x06004A66 RID: 19046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F09")]
		public override BlitzTournamentProgressWindow View
		{
			[Token(Token = "0x6004A66")]
			[Address(RVA = "0x98C8", Offset = "0x98C8", VA = "0x98C8", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (set) Token: 0x06004A67 RID: 19047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F0A")]
		public override Gameplay.BlitzTournament.Events.BlitzTournamentEvents Events
		{
			[Token(Token = "0x6004A67")]
			[Address(RVA = "0x98C9", Offset = "0x98C9", VA = "0x98C9", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A68")]
		[Address(RVA = "0x98CA", Offset = "0x98CA", VA = "0x98CA")]
		private void RulesButtonClickHandler()
		{
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A69")]
		[Address(RVA = "0x98CB", Offset = "0x98CB", VA = "0x98CB")]
		private void TournamentInfoReceivedEventHandler()
		{
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A6A")]
		[Address(RVA = "0x98CC", Offset = "0x98CC", VA = "0x98CC")]
		private void HealthChangedEventHandler(ProtoHealthChangedEvt evt)
		{
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A6B")]
		[Address(RVA = "0x98CD", Offset = "0x98CD", VA = "0x98CD")]
		private void ResolveWindowState()
		{
		}

		// Token: 0x06004A6C RID: 19052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A6C")]
		[Address(RVA = "0x98CE", Offset = "0x98CE", VA = "0x98CE")]
		private void DefineTournamentState()
		{
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A6D")]
		[Address(RVA = "0x98CF", Offset = "0x98CF", VA = "0x98CF")]
		public void LoadWaitingWindow()
		{
		}

		// Token: 0x06004A6E RID: 19054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A6E")]
		[Address(RVA = "0x98D0", Offset = "0x98D0", VA = "0x98D0")]
		public void LoadGridWindow()
		{
		}

		// Token: 0x06004A6F RID: 19055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A6F")]
		[Address(RVA = "0x98D1", Offset = "0x98D1", VA = "0x98D1")]
		private void UpdateGeneralView()
		{
		}

		// Token: 0x06004A70 RID: 19056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A70")]
		[Address(RVA = "0x98D2", Offset = "0x98D2", VA = "0x98D2")]
		public void LoadLosePage()
		{
		}

		// Token: 0x06004A71 RID: 19057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A71")]
		[Address(RVA = "0x98D3", Offset = "0x98D3", VA = "0x98D3")]
		public void LoadWinPage()
		{
		}

		// Token: 0x06004A72 RID: 19058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A72")]
		[Address(RVA = "0x98D4", Offset = "0x98D4", VA = "0x98D4")]
		private void UpdateInfoBox()
		{
		}

		// Token: 0x06004A73 RID: 19059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A73")]
		[Address(RVA = "0x98D5", Offset = "0x98D5", VA = "0x98D5")]
		private void UseFirstBattleDescription()
		{
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A74")]
		[Address(RVA = "0x98D6", Offset = "0x98D6", VA = "0x98D6")]
		private void UseFollowingBattleDescription()
		{
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A75")]
		[Address(RVA = "0x98D7", Offset = "0x98D7", VA = "0x98D7")]
		private void RenderRewards()
		{
		}

		// Token: 0x06004A76 RID: 19062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A76")]
		[Address(RVA = "0x98D8", Offset = "0x98D8", VA = "0x98D8")]
		private void UseLoseDescription()
		{
		}

		// Token: 0x06004A77 RID: 19063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A77")]
		[Address(RVA = "0x98D9", Offset = "0x98D9", VA = "0x98D9")]
		private void UseWinDescription()
		{
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A78")]
		[Address(RVA = "0x98DA", Offset = "0x98DA", VA = "0x98DA")]
		private void BlockUI(bool block)
		{
		}

		// Token: 0x04002883 RID: 10371
		[Token(Token = "0x4002883")]
		private const string LOCALIZATION_BATTLE_ABOUT_TO_START = "BLITZ/BATTLE_ABOUT_TO_START";

		// Token: 0x04002884 RID: 10372
		[Token(Token = "0x4002884")]
		private const string LOCALIZATION_NEXT_ROUND_DESCRIPTION = "BLITZ/NEXT_ROUND_DESCRIPTION";

		// Token: 0x04002885 RID: 10373
		[Token(Token = "0x4002885")]
		private const string LOCALIZATION_LOSE_DESCRIPTION = "BLITZ/LOSE_DESCRIPTION";

		// Token: 0x04002886 RID: 10374
		[Token(Token = "0x4002886")]
		private const string LOCALIZATION_WIN_DESCRIPTION = "BLITZ/WIN_DESCRIPTION";

		// Token: 0x04002887 RID: 10375
		[Token(Token = "0x4002887")]
		private const string LOCALIZATION_BATTLES_IN_PROCESS = "BLITZ/BATTLES_IN_PROCESS";

		// Token: 0x04002888 RID: 10376
		[Token(Token = "0x4002888")]
		private const string LOCALIZATION_STARTING_SOON = "TOURNAMENTS/STARTING_SOON";

		// Token: 0x04002889 RID: 10377
		[Token(Token = "0x4002889")]
		[FieldOffset(Offset = "0x18")]
		private BattleInfoListElement[] _listElements;
	}
}
