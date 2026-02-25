using System;
using Core.Cache.User;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Bank.Controller;
using Gameplay.DailyQuests;
using Il2CppDummyDll;
using ServicesNamespace;
using UI.Windows;

namespace Gameplay.Competition.Model
{
	// Token: 0x020008F4 RID: 2292
	[Token(Token = "0x20008F4")]
	public class Dependencies
	{
		// Token: 0x06003601 RID: 13825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003601")]
		[Address(RVA = "0x860E", Offset = "0x860E", VA = "0x860E")]
		public Dependencies(IDictProvider dictProvider, IUserCache userCache, IDailyQuestProvider dailyQuestProvider, IDailyQuestExtInfoPresenter dailyQuestExtInfoPresenter, BankController bankController, PopupController popupController, RatingService ratingService, CompetitionService competitionService, UserData user, IGame game)
		{
		}

		// Token: 0x04001DA1 RID: 7585
		[Token(Token = "0x4001DA1")]
		[FieldOffset(Offset = "0x8")]
		public readonly IDictProvider DictProvider;

		// Token: 0x04001DA2 RID: 7586
		[Token(Token = "0x4001DA2")]
		[FieldOffset(Offset = "0xC")]
		public readonly IUserCache UserCache;

		// Token: 0x04001DA3 RID: 7587
		[Token(Token = "0x4001DA3")]
		[FieldOffset(Offset = "0x10")]
		public readonly IDailyQuestProvider DailyQuestProvider;

		// Token: 0x04001DA4 RID: 7588
		[Token(Token = "0x4001DA4")]
		[FieldOffset(Offset = "0x14")]
		public readonly IDailyQuestExtInfoPresenter DailyQuestExtInfoPresenter;

		// Token: 0x04001DA5 RID: 7589
		[Token(Token = "0x4001DA5")]
		[FieldOffset(Offset = "0x18")]
		public readonly BankController BankController;

		// Token: 0x04001DA6 RID: 7590
		[Token(Token = "0x4001DA6")]
		[FieldOffset(Offset = "0x1C")]
		public readonly PopupController PopupController;

		// Token: 0x04001DA7 RID: 7591
		[Token(Token = "0x4001DA7")]
		[FieldOffset(Offset = "0x20")]
		public readonly CompetitionService CompetitionService;

		// Token: 0x04001DA8 RID: 7592
		[Token(Token = "0x4001DA8")]
		[FieldOffset(Offset = "0x24")]
		public readonly RatingService RatingService;

		// Token: 0x04001DA9 RID: 7593
		[Token(Token = "0x4001DA9")]
		[FieldOffset(Offset = "0x28")]
		public readonly UserData User;

		// Token: 0x04001DAA RID: 7594
		[Token(Token = "0x4001DAA")]
		[FieldOffset(Offset = "0x2C")]
		public readonly IGame Game;
	}
}
