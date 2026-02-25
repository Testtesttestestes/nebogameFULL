using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012C1 RID: 4801
	[Token(Token = "0x20012C1")]
	public class AuchanAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x06007203 RID: 29187 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001725")]
		protected override string Theme
		{
			[Token(Token = "0x6007203")]
			[Address(RVA = "0xBC0C", Offset = "0xBC0C", VA = "0xBC0C", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007204 RID: 29188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007204")]
		[Address(RVA = "0xBC0D", Offset = "0xBC0D", VA = "0xBC0D", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x06007205 RID: 29189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007205")]
		[Address(RVA = "0xBC0E", Offset = "0xBC0E", VA = "0xBC0E", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x06007206 RID: 29190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007206")]
		[Address(RVA = "0xBC0F", Offset = "0xBC0F", VA = "0xBC0F")]
		private void AuchanBuyArtifactEvent(AuchanScope.AuchanEventArgs e)
		{
		}

		// Token: 0x06007207 RID: 29191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007207")]
		[Address(RVA = "0xBC10", Offset = "0xBC10", VA = "0xBC10")]
		public AuchanAnalyticsListener()
		{
		}

		// Token: 0x04003BBF RID: 15295
		[Token(Token = "0x4003BBF")]
		private const string BUY_ARTIFACT = "buy_artifact";
	}
}
