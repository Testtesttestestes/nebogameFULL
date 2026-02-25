using System;
using Core.Events;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012D9 RID: 4825
	[Token(Token = "0x20012D9")]
	public class PlatformSpecificAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x060072BD RID: 29373 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700173D")]
		protected override string Theme
		{
			[Token(Token = "0x60072BD")]
			[Address(RVA = "0xBCC6", Offset = "0xBCC6", VA = "0xBCC6", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072BE RID: 29374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072BE")]
		[Address(RVA = "0xBCC7", Offset = "0xBCC7", VA = "0xBCC7", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x060072BF RID: 29375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072BF")]
		[Address(RVA = "0xBCC8", Offset = "0xBCC8", VA = "0xBCC8", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x060072C0 RID: 29376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072C0")]
		[Address(RVA = "0xBCC9", Offset = "0xBCC9", VA = "0xBCC9")]
		private void OnAppsFlyerConversionDataFailEvent(PlatformSpecificScope.AppsFlyerEventArgs e)
		{
		}

		// Token: 0x060072C1 RID: 29377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072C1")]
		[Address(RVA = "0xBCCA", Offset = "0xBCCA", VA = "0xBCCA")]
		private void OnAppsFlyerConversionDataSuccessEvent(PlatformSpecificScope.AppsFlyerEventArgs e)
		{
		}

		// Token: 0x060072C2 RID: 29378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072C2")]
		[Address(RVA = "0xBCCB", Offset = "0xBCCB", VA = "0xBCCB")]
		private void OnAppsFlyerAppOpenAttributionEvent(PlatformSpecificScope.AppsFlyerEventArgs e)
		{
		}

		// Token: 0x060072C3 RID: 29379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072C3")]
		[Address(RVA = "0xBCCC", Offset = "0xBCCC", VA = "0xBCCC")]
		private void GdprAgreedEvent(BaseEventBusEventArgs e)
		{
		}

		// Token: 0x060072C4 RID: 29380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072C4")]
		[Address(RVA = "0xBCCD", Offset = "0xBCCD", VA = "0xBCCD")]
		public PlatformSpecificAnalyticsListener()
		{
		}

		// Token: 0x04003C16 RID: 15382
		[Token(Token = "0x4003C16")]
		private const string GDPR_AGREED = "gdpr_agreed";

		// Token: 0x04003C17 RID: 15383
		[Token(Token = "0x4003C17")]
		private const string AF_CONVERSION_DATA_SUCCESS = "af_conversion_data_success";

		// Token: 0x04003C18 RID: 15384
		[Token(Token = "0x4003C18")]
		private const string AF_CONVERSION_DATA_FAIL = "af_conversion_data_fail";

		// Token: 0x04003C19 RID: 15385
		[Token(Token = "0x4003C19")]
		private const string AF_APP_OPEN_ATTRIBUTION = "af_app_open_attribution";
	}
}
