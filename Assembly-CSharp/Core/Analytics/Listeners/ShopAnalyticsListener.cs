using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012DE RID: 4830
	[Token(Token = "0x20012DE")]
	public class ShopAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x060072EA RID: 29418 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001742")]
		protected override string Theme
		{
			[Token(Token = "0x60072EA")]
			[Address(RVA = "0xBCF3", Offset = "0xBCF3", VA = "0xBCF3", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072EB RID: 29419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072EB")]
		[Address(RVA = "0xBCF4", Offset = "0xBCF4", VA = "0xBCF4", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x060072EC RID: 29420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072EC")]
		[Address(RVA = "0xBCF5", Offset = "0xBCF5", VA = "0xBCF5")]
		private void BuyShopArtifactEvent(ShopScope.ShopEventArgs e)
		{
		}

		// Token: 0x060072ED RID: 29421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072ED")]
		[Address(RVA = "0xBCF6", Offset = "0xBCF6", VA = "0xBCF6", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x060072EE RID: 29422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072EE")]
		[Address(RVA = "0xBCF7", Offset = "0xBCF7", VA = "0xBCF7")]
		public ShopAnalyticsListener()
		{
		}

		// Token: 0x04003C2C RID: 15404
		[Token(Token = "0x4003C2C")]
		private const string BUY_SHOP_ARTIFACT = "buy_artifact";
	}
}
