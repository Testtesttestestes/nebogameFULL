using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012E5 RID: 4837
	[Token(Token = "0x20012E5")]
	public class UiAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x06007313 RID: 29459 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001747")]
		protected override string Theme
		{
			[Token(Token = "0x6007313")]
			[Address(RVA = "0xBD1C", Offset = "0xBD1C", VA = "0xBD1C", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007314 RID: 29460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007314")]
		[Address(RVA = "0xBD1D", Offset = "0xBD1D", VA = "0xBD1D", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x06007315 RID: 29461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007315")]
		[Address(RVA = "0xBD1E", Offset = "0xBD1E", VA = "0xBD1E", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x06007316 RID: 29462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007316")]
		[Address(RVA = "0xBD1F", Offset = "0xBD1F", VA = "0xBD1F")]
		private void FxActivatedEvent(UiScope.FxActivatedEventArgs e)
		{
		}

		// Token: 0x06007317 RID: 29463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007317")]
		[Address(RVA = "0xBD20", Offset = "0xBD20", VA = "0xBD20")]
		private void ToolTipShownEvent(UiScope.ToolTipShownEventArgs e)
		{
		}

		// Token: 0x06007318 RID: 29464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007318")]
		[Address(RVA = "0xBD21", Offset = "0xBD21", VA = "0xBD21")]
		private void WindowOpenedEvent(UiScope.WindowOpenedEventArgs e)
		{
		}

		// Token: 0x06007319 RID: 29465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007319")]
		[Address(RVA = "0xBD22", Offset = "0xBD22", VA = "0xBD22")]
		private void LogAccountWindowOpened(UiScope.WindowOpenedEventArgs e)
		{
		}

		// Token: 0x0600731A RID: 29466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600731A")]
		[Address(RVA = "0xBD23", Offset = "0xBD23", VA = "0xBD23")]
		private void LogWindowOpenedEvent(string eventName, UiScope.WindowOpenedEventArgs e, [Optional] Dictionary<string, object> extraProperties)
		{
		}

		// Token: 0x0600731B RID: 29467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600731B")]
		[Address(RVA = "0xBD24", Offset = "0xBD24", VA = "0xBD24")]
		public UiAnalyticsListener()
		{
		}

		// Token: 0x04003C41 RID: 15425
		[Token(Token = "0x4003C41")]
		private const string BANK_WINDOW_OPENED = "bank_window_opened";

		// Token: 0x04003C42 RID: 15426
		[Token(Token = "0x4003C42")]
		private const string DISCOUNTS_WINDOW_OPENED = "discounts_window_opened";

		// Token: 0x04003C43 RID: 15427
		[Token(Token = "0x4003C43")]
		private const string SPECIAL_OFFERS_WINDOW_OPENED = "special_offers_window_opened";

		// Token: 0x04003C44 RID: 15428
		[Token(Token = "0x4003C44")]
		private const string MARKET_WINDOW_OPENED = "market_window_opened";

		// Token: 0x04003C45 RID: 15429
		[Token(Token = "0x4003C45")]
		private const string ARTIFACT_COMPARER_WINDOW_OPENED = "artifact_comparer_window_opened";

		// Token: 0x04003C46 RID: 15430
		[Token(Token = "0x4003C46")]
		private const string ACCOUNT_LIST_WINDOW_OPENED = "account_list_window_opened";

		// Token: 0x04003C47 RID: 15431
		[Token(Token = "0x4003C47")]
		private const string ACCOUNT_WINDOW_OPENED = "account_window_opened";

		// Token: 0x04003C48 RID: 15432
		[Token(Token = "0x4003C48")]
		private const string RATE_GAME_WINDOW = "rate_game_window_opened";

		// Token: 0x04003C49 RID: 15433
		[Token(Token = "0x4003C49")]
		private const string GDEVENTS_OPENED = "gdevents_list_opened";

		// Token: 0x04003C4A RID: 15434
		[Token(Token = "0x4003C4A")]
		private const string GDEVENT_OPENED = "gdevent_opened";

		// Token: 0x04003C4B RID: 15435
		[Token(Token = "0x4003C4B")]
		private const string COMPETITION_OPENED = "competition_opened";

		// Token: 0x04003C4C RID: 15436
		[Token(Token = "0x4003C4C")]
		private const string TOOLTIP_SHOWN = "tooltip_shown";

		// Token: 0x04003C4D RID: 15437
		[Token(Token = "0x4003C4D")]
		private const string FX_SHOWN = "fx_shown";

		// Token: 0x04003C4E RID: 15438
		[Token(Token = "0x4003C4E")]
		private const int MaxToolTipEventNum = 3;

		// Token: 0x04003C4F RID: 15439
		[Token(Token = "0x4003C4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _toolTipEventCounterCounter;
	}
}
