using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012CF RID: 4815
	[Token(Token = "0x20012CF")]
	public class DiscountsAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x0600727A RID: 29306 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001733")]
		protected override string Theme
		{
			[Token(Token = "0x600727A")]
			[Address(RVA = "0xBC83", Offset = "0xBC83", VA = "0xBC83", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600727B RID: 29307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600727B")]
		[Address(RVA = "0xBC84", Offset = "0xBC84", VA = "0xBC84", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x0600727C RID: 29308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600727C")]
		[Address(RVA = "0xBC85", Offset = "0xBC85", VA = "0xBC85", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x0600727D RID: 29309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600727D")]
		[Address(RVA = "0xBC86", Offset = "0xBC86", VA = "0xBC86")]
		private void DiscountClickEvent(DiscountsScope.DiscountClickEventArgs e)
		{
		}

		// Token: 0x0600727E RID: 29310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600727E")]
		[Address(RVA = "0xBC87", Offset = "0xBC87", VA = "0xBC87")]
		public DiscountsAnalyticsListener()
		{
		}

		// Token: 0x04003BFF RID: 15359
		[Token(Token = "0x4003BFF")]
		private const string DISCOUNT_CLICK = "discount_click";
	}
}
