using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012E1 RID: 4833
	[Token(Token = "0x20012E1")]
	public class ThemeDuelAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x060072F7 RID: 29431 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001744")]
		protected override string Theme
		{
			[Token(Token = "0x60072F7")]
			[Address(RVA = "0xBD00", Offset = "0xBD00", VA = "0xBD00", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072F8 RID: 29432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072F8")]
		[Address(RVA = "0xBD01", Offset = "0xBD01", VA = "0xBD01", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x060072F9 RID: 29433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072F9")]
		[Address(RVA = "0xBD02", Offset = "0xBD02", VA = "0xBD02", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x060072FA RID: 29434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072FA")]
		[Address(RVA = "0xBD03", Offset = "0xBD03", VA = "0xBD03")]
		private void OnBuyItemEvent(ThemeDuelScope.BuyItemEventArgs obj)
		{
		}

		// Token: 0x060072FB RID: 29435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072FB")]
		[Address(RVA = "0xBD04", Offset = "0xBD04", VA = "0xBD04")]
		private void OnOpenWindowEvent(ThemeDuelScope.OpenWindowEventArgs obj)
		{
		}

		// Token: 0x060072FC RID: 29436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072FC")]
		[Address(RVA = "0xBD05", Offset = "0xBD05", VA = "0xBD05")]
		private void OnBattleFinishedEvent(ThemeDuelScope.BattleFinishedArgs obj)
		{
		}

		// Token: 0x060072FD RID: 29437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072FD")]
		[Address(RVA = "0xBD06", Offset = "0xBD06", VA = "0xBD06")]
		private void OnBattleBeginEvent(ThemeDuelScope.BattleBeginEventArgs obj)
		{
		}

		// Token: 0x060072FE RID: 29438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072FE")]
		[Address(RVA = "0xBD07", Offset = "0xBD07", VA = "0xBD07")]
		public ThemeDuelAnalyticsListener()
		{
		}

		// Token: 0x04003C30 RID: 15408
		[Token(Token = "0x4003C30")]
		private const string EVENT_BATTLE_BEGIN = "event_battle_begin";

		// Token: 0x04003C31 RID: 15409
		[Token(Token = "0x4003C31")]
		private const string EVENT_BATTLE_FINISHED = "event_battle_finished";

		// Token: 0x04003C32 RID: 15410
		[Token(Token = "0x4003C32")]
		private const string EVENT_SHOP = "event_shop";

		// Token: 0x04003C33 RID: 15411
		[Token(Token = "0x4003C33")]
		private const string EVENT_RATING = "event_rating";

		// Token: 0x04003C34 RID: 15412
		[Token(Token = "0x4003C34")]
		private const string EVENT_WINDOW = "event_window";
	}
}
