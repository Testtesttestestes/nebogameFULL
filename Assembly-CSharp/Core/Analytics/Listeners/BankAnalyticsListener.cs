using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012C3 RID: 4803
	[Token(Token = "0x20012C3")]
	public class BankAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x06007215 RID: 29205 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001727")]
		protected override string Theme
		{
			[Token(Token = "0x6007215")]
			[Address(RVA = "0xBC1E", Offset = "0xBC1E", VA = "0xBC1E", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007216 RID: 29206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007216")]
		[Address(RVA = "0xBC1F", Offset = "0xBC1F", VA = "0xBC1F", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x06007217 RID: 29207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007217")]
		[Address(RVA = "0xBC20", Offset = "0xBC20", VA = "0xBC20", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x06007218 RID: 29208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007218")]
		[Address(RVA = "0xBC21", Offset = "0xBC21", VA = "0xBC21")]
		private void ExchangeSuccessEvent(BankScope.ExchangeEventArgs e)
		{
		}

		// Token: 0x06007219 RID: 29209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007219")]
		[Address(RVA = "0xBC22", Offset = "0xBC22", VA = "0xBC22")]
		public BankAnalyticsListener()
		{
		}

		// Token: 0x04003BCA RID: 15306
		[Token(Token = "0x4003BCA")]
		private const string EXCHANGE_SUCCESS = "exchage_success";
	}
}
