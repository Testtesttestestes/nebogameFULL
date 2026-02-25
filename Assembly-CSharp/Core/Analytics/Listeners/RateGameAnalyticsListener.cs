using System;
using Core.Events;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012DB RID: 4827
	[Token(Token = "0x20012DB")]
	public class RateGameAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x060072D2 RID: 29394 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700173F")]
		protected override string Theme
		{
			[Token(Token = "0x60072D2")]
			[Address(RVA = "0xBCDB", Offset = "0xBCDB", VA = "0xBCDB", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072D3 RID: 29395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072D3")]
		[Address(RVA = "0xBCDC", Offset = "0xBCDC", VA = "0xBCDC", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x060072D4 RID: 29396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072D4")]
		[Address(RVA = "0xBCDD", Offset = "0xBCDD", VA = "0xBCDD", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x060072D5 RID: 29397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072D5")]
		[Address(RVA = "0xBCDE", Offset = "0xBCDE", VA = "0xBCDE")]
		private void CloseButtonClickedAfterPositiveRateEvent(BaseEventBusEventArgs obj)
		{
		}

		// Token: 0x060072D6 RID: 29398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072D6")]
		[Address(RVA = "0xBCDF", Offset = "0xBCDF", VA = "0xBCDF")]
		private void StoreButtonClickEvent(BaseEventBusEventArgs obj)
		{
		}

		// Token: 0x060072D7 RID: 29399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072D7")]
		[Address(RVA = "0xBCE0", Offset = "0xBCE0", VA = "0xBCE0")]
		private void RateGameRequestEvent(RateGameScope.RateGameEventArgs e)
		{
		}

		// Token: 0x060072D8 RID: 29400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072D8")]
		[Address(RVA = "0xBCE1", Offset = "0xBCE1", VA = "0xBCE1")]
		private void RateGameSuccessEvent(RateGameScope.RateGameEventArgs e)
		{
		}

		// Token: 0x060072D9 RID: 29401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072D9")]
		[Address(RVA = "0xBCE2", Offset = "0xBCE2", VA = "0xBCE2")]
		private void RateGameCancelEvent(BaseEventBusEventArgs e)
		{
		}

		// Token: 0x060072DA RID: 29402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072DA")]
		[Address(RVA = "0xBCE3", Offset = "0xBCE3", VA = "0xBCE3")]
		public RateGameAnalyticsListener()
		{
		}

		// Token: 0x04003C23 RID: 15395
		[Token(Token = "0x4003C23")]
		private const string RATE_GAME_CANCEL = "rate_game_cancel";

		// Token: 0x04003C24 RID: 15396
		[Token(Token = "0x4003C24")]
		private const string RATE_GAME_REQUEST = "rate_game_request";

		// Token: 0x04003C25 RID: 15397
		[Token(Token = "0x4003C25")]
		private const string RATE_GAME_SUCCESS = "rate_game_success";

		// Token: 0x04003C26 RID: 15398
		[Token(Token = "0x4003C26")]
		private const string STORE_BUTTON_CLICK = "store_button_click";

		// Token: 0x04003C27 RID: 15399
		[Token(Token = "0x4003C27")]
		private const string CLOSE_BUTTON_CLICK_ON_POSITIVE_RATE = "close_button_click_on_positive_rate";
	}
}
