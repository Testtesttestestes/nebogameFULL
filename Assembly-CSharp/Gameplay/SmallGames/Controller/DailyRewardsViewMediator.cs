using System;
using Gameplay.SmallGames.Events;
using Gameplay.SmallGames.Model;
using Gameplay.SmallGames.View.DailyRewards;
using Il2CppDummyDll;
using MVC;
using Protocol.SmallGames;

namespace Gameplay.SmallGames.Controller
{
	// Token: 0x02000539 RID: 1337
	[Token(Token = "0x2000539")]
	public class DailyRewardsViewMediator : AbstractViewMediator<SmallGamesModel, Gameplay.SmallGames.Events.SmallGamesEvents, SmallGamesController, DailyRewardsWindow>
	{
		// Token: 0x06001FD7 RID: 8151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD7")]
		[Address(RVA = "0x713C", Offset = "0x713C", VA = "0x713C")]
		public DailyRewardsViewMediator(SmallGamesModel model, Gameplay.SmallGames.Events.SmallGamesEvents events, SmallGamesController controller)
		{
		}

		// Token: 0x170005DA RID: 1498
		// (set) Token: 0x06001FD8 RID: 8152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DA")]
		public override DailyRewardsWindow View
		{
			[Token(Token = "0x6001FD8")]
			[Address(RVA = "0x713D", Offset = "0x713D", VA = "0x713D", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD9")]
		[Address(RVA = "0x713E", Offset = "0x713E", VA = "0x713E")]
		private void AccountsButtonClickHandler()
		{
		}

		// Token: 0x170005DB RID: 1499
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DB")]
		public override Gameplay.SmallGames.Events.SmallGamesEvents Events
		{
			[Token(Token = "0x6001FDA")]
			[Address(RVA = "0x713F", Offset = "0x713F", VA = "0x713F", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FDB")]
		[Address(RVA = "0x7140", Offset = "0x7140", VA = "0x7140")]
		private void VisitRegisteredEventHandler()
		{
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FDC")]
		[Address(RVA = "0x7141", Offset = "0x7141", VA = "0x7141")]
		private void CanTakeAdditionalChangedEventHandler()
		{
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FDD")]
		[Address(RVA = "0x7142", Offset = "0x7142", VA = "0x7142")]
		private void TakeButtonClickedEventHandler()
		{
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FDE")]
		[Address(RVA = "0x7143", Offset = "0x7143", VA = "0x7143")]
		private void TabSelectedEventHandler(RewardsTab tab)
		{
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FDF")]
		[Address(RVA = "0x7144", Offset = "0x7144", VA = "0x7144")]
		private void SelectTab(RewardsTab tab)
		{
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE0")]
		[Address(RVA = "0x7145", Offset = "0x7145", VA = "0x7145")]
		private void DailyBonusTakenEventHandler()
		{
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE1")]
		[Address(RVA = "0x7146", Offset = "0x7146", VA = "0x7146")]
		private void Init()
		{
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE2")]
		[Address(RVA = "0x7147", Offset = "0x7147", VA = "0x7147")]
		private void ValidateAdditionalRewardInfo()
		{
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE3")]
		[Address(RVA = "0x7148", Offset = "0x7148", VA = "0x7148")]
		private void PopulatePanel(in uint dayNumber, SingleRewardView panel, ProtoRegisterVisitAns.Types.DailyRewards data, in int panelNumber, bool canTakeAdditional)
		{
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE4")]
		[Address(RVA = "0x7149", Offset = "0x7149", VA = "0x7149")]
		private void SetUnreceivedState(string title, SingleRewardView panel, ProtoRegisterVisitAns.Types.DailyRewards data)
		{
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE5")]
		[Address(RVA = "0x714A", Offset = "0x714A", VA = "0x714A")]
		private void SetReceivedState(ProtoRegisterVisitAns.Types.DailyRewards data, string title, SingleRewardView panel, bool additionalTaken)
		{
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001FE6")]
		[Address(RVA = "0x714B", Offset = "0x714B", VA = "0x714B")]
		private string DetermineTitle(int panelNumber, uint dayNumber)
		{
			return null;
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE7")]
		[Address(RVA = "0x714C", Offset = "0x714C", VA = "0x714C")]
		private void DrawPendingWindow()
		{
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE8")]
		[Address(RVA = "0x714D", Offset = "0x714D", VA = "0x714D")]
		private void DrawReceivedWindow()
		{
		}

		// Token: 0x0400118A RID: 4490
		[Token(Token = "0x400118A")]
		private const string LOCALIZATION_TODAY = "DAILY_REWARDS/TODAY";

		// Token: 0x0400118B RID: 4491
		[Token(Token = "0x400118B")]
		private const string LOCALIZATION_TOMORROW = "DAILY_REWARDS/TOMORROW";

		// Token: 0x0400118C RID: 4492
		[Token(Token = "0x400118C")]
		private const string LOCALIZATION_DAY_NUMBER = "DAILY_REWARDS/DAY_NUMBER";

		// Token: 0x0400118D RID: 4493
		[Token(Token = "0x400118D")]
		[FieldOffset(Offset = "0x18")]
		private SingleRewardView[] _rewardsPanels;

		// Token: 0x0400118E RID: 4494
		[Token(Token = "0x400118E")]
		[FieldOffset(Offset = "0x1C")]
		private RewardsTab _selectedTab;
	}
}
