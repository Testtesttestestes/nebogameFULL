using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012D4 RID: 4820
	[Token(Token = "0x20012D4")]
	public class InventoryAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x06007296 RID: 29334 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001738")]
		protected override string Theme
		{
			[Token(Token = "0x6007296")]
			[Address(RVA = "0xBC9F", Offset = "0xBC9F", VA = "0xBC9F", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007297 RID: 29335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007297")]
		[Address(RVA = "0xBCA0", Offset = "0xBCA0", VA = "0xBCA0", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x06007298 RID: 29336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007298")]
		[Address(RVA = "0xBCA1", Offset = "0xBCA1", VA = "0xBCA1", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x06007299 RID: 29337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007299")]
		[Address(RVA = "0xBCA2", Offset = "0xBCA2", VA = "0xBCA2")]
		private void SplitArtifactWthNumpadEvent(InventoryScope.UsingNumpadEventArgs e)
		{
		}

		// Token: 0x0600729A RID: 29338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600729A")]
		[Address(RVA = "0xBCA3", Offset = "0xBCA3", VA = "0xBCA3")]
		private void BuySlotEvent(InventoryScope.BuySlotEventArgs e)
		{
		}

		// Token: 0x0600729B RID: 29339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600729B")]
		[Address(RVA = "0xBCA4", Offset = "0xBCA4", VA = "0xBCA4")]
		public InventoryAnalyticsListener()
		{
		}

		// Token: 0x04003C08 RID: 15368
		[Token(Token = "0x4003C08")]
		private const string BUY_SLOT = "buy_slot";

		// Token: 0x04003C09 RID: 15369
		[Token(Token = "0x4003C09")]
		private const string USING_NUMPAD = "using_numpad";
	}
}
