using System;
using System.Collections.Generic;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012BB RID: 4795
	[Token(Token = "0x20012BB")]
	public class AdAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x060071D5 RID: 29141 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001720")]
		protected override string Theme
		{
			[Token(Token = "0x60071D5")]
			[Address(RVA = "0xBBDE", Offset = "0xBBDE", VA = "0xBBDE", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060071D6 RID: 29142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071D6")]
		[Address(RVA = "0xBBDF", Offset = "0xBBDF", VA = "0xBBDF", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x060071D7 RID: 29143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071D7")]
		[Address(RVA = "0xBBE0", Offset = "0xBBE0", VA = "0xBBE0", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x060071D8 RID: 29144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071D8")]
		[Address(RVA = "0xBBE1", Offset = "0xBBE1", VA = "0xBBE1")]
		private void AdPlacementShownEvent(AdScope.AdPlacementEventArgs e)
		{
		}

		// Token: 0x060071D9 RID: 29145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071D9")]
		[Address(RVA = "0xBBE2", Offset = "0xBBE2", VA = "0xBBE2")]
		private void AdTransactionClosedEvent(AdScope.AdTransactionInfoEventArgs e)
		{
		}

		// Token: 0x060071DA RID: 29146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071DA")]
		[Address(RVA = "0xBBE3", Offset = "0xBBE3", VA = "0xBBE3")]
		private void AdProviderRequestEvent(AdScope.AdEventArgs e)
		{
		}

		// Token: 0x060071DB RID: 29147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071DB")]
		[Address(RVA = "0xBBE4", Offset = "0xBBE4", VA = "0xBBE4")]
		private void AdAppRequestEvent(AdScope.AdEventArgs e)
		{
		}

		// Token: 0x060071DC RID: 29148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071DC")]
		[Address(RVA = "0xBBE5", Offset = "0xBBE5", VA = "0xBBE5")]
		private void AdErrorEvent(AdScope.AdErrorEventArgs e)
		{
		}

		// Token: 0x060071DD RID: 29149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071DD")]
		[Address(RVA = "0xBBE6", Offset = "0xBBE6", VA = "0xBBE6")]
		private void AdWatchedEvent(AdScope.AdEventArgs e)
		{
		}

		// Token: 0x060071DE RID: 29150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071DE")]
		[Address(RVA = "0xBBE7", Offset = "0xBBE7", VA = "0xBBE7")]
		private void AppendEventArgs(AdScope.AdEventArgs e, Dictionary<string, object> properties)
		{
		}

		// Token: 0x060071DF RID: 29151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071DF")]
		[Address(RVA = "0xBBE8", Offset = "0xBBE8", VA = "0xBBE8")]
		public AdAnalyticsListener()
		{
		}

		// Token: 0x04003BA4 RID: 15268
		[Token(Token = "0x4003BA4")]
		private const string WATCH_SUCCESS = "watch_success";

		// Token: 0x04003BA5 RID: 15269
		[Token(Token = "0x4003BA5")]
		private const string WATCH_ERROR = "watch_error";

		// Token: 0x04003BA6 RID: 15270
		[Token(Token = "0x4003BA6")]
		private const string APP_REQUEST = "app_request";

		// Token: 0x04003BA7 RID: 15271
		[Token(Token = "0x4003BA7")]
		private const string PROVIDER_REQUEST = "provider_request";

		// Token: 0x04003BA8 RID: 15272
		[Token(Token = "0x4003BA8")]
		private const string PLACEMENT_SHOWN = "placement_shown";

		// Token: 0x04003BA9 RID: 15273
		[Token(Token = "0x4003BA9")]
		private const string AD_TRANSACTION_CLOSED = "ad_transaction_closed";
	}
}
