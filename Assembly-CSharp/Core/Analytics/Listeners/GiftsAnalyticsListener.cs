using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012D1 RID: 4817
	[Token(Token = "0x20012D1")]
	public class GiftsAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x06007287 RID: 29319 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001735")]
		protected override string Theme
		{
			[Token(Token = "0x6007287")]
			[Address(RVA = "0xBC90", Offset = "0xBC90", VA = "0xBC90", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007288 RID: 29320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007288")]
		[Address(RVA = "0xBC91", Offset = "0xBC91", VA = "0xBC91", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x06007289 RID: 29321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007289")]
		[Address(RVA = "0xBC92", Offset = "0xBC92", VA = "0xBC92")]
		private void GiftSendEvent(GiftsScope.GiftsEventArgs e)
		{
		}

		// Token: 0x0600728A RID: 29322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600728A")]
		[Address(RVA = "0xBC93", Offset = "0xBC93", VA = "0xBC93", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x0600728B RID: 29323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600728B")]
		[Address(RVA = "0xBC94", Offset = "0xBC94", VA = "0xBC94")]
		public GiftsAnalyticsListener()
		{
		}

		// Token: 0x04003C05 RID: 15365
		[Token(Token = "0x4003C05")]
		private const string GIFT_SEND = "gift_send";
	}
}
