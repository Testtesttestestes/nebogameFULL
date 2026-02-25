using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012BC RID: 4796
	[Token(Token = "0x20012BC")]
	public class AfVideoAdAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x060071E0 RID: 29152 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001721")]
		protected override string Theme
		{
			[Token(Token = "0x60071E0")]
			[Address(RVA = "0xBBE9", Offset = "0xBBE9", VA = "0xBBE9", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060071E1 RID: 29153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071E1")]
		[Address(RVA = "0xBBEA", Offset = "0xBBEA", VA = "0xBBEA", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x060071E2 RID: 29154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071E2")]
		[Address(RVA = "0xBBEB", Offset = "0xBBEB", VA = "0xBBEB", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x060071E3 RID: 29155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071E3")]
		[Address(RVA = "0xBBEC", Offset = "0xBBEC", VA = "0xBBEC")]
		private void AdWatchedEvent(AdScope.AdEventArgs e)
		{
		}

		// Token: 0x060071E4 RID: 29156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071E4")]
		[Address(RVA = "0xBBED", Offset = "0xBBED", VA = "0xBBED")]
		public AfVideoAdAnalyticsListener()
		{
		}

		// Token: 0x04003BAA RID: 15274
		[Token(Token = "0x4003BAA")]
		private const string AF_AD_VIEW = "Af_ad_view";
	}
}
