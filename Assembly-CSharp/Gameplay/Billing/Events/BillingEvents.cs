using System;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Billing.Events
{
	// Token: 0x02000BF6 RID: 3062
	[Token(Token = "0x2000BF6")]
	public class BillingEvents : AbstractMVCEvents
	{
		// Token: 0x06004B0E RID: 19214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B0E")]
		[Address(RVA = "0x996B", Offset = "0x996B", VA = "0x996B")]
		public BillingEvents()
		{
		}

		// Token: 0x040028D9 RID: 10457
		[Token(Token = "0x40028D9")]
		[FieldOffset(Offset = "0x14")]
		public Action BalanceChanged;

		// Token: 0x040028DA RID: 10458
		[Token(Token = "0x40028DA")]
		[FieldOffset(Offset = "0x18")]
		public Action<BankOptionData> BuyOptionErrorEvent;

		// Token: 0x040028DB RID: 10459
		[Token(Token = "0x40028DB")]
		[FieldOffset(Offset = "0x1C")]
		public Action<BankOptionData> BuyOptionSuccessEvent;

		// Token: 0x040028DC RID: 10460
		[Token(Token = "0x40028DC")]
		[FieldOffset(Offset = "0x20")]
		public Action<BankOptionData> BuyOptionCancelEvent;

		// Token: 0x040028DD RID: 10461
		[Token(Token = "0x40028DD")]
		[FieldOffset(Offset = "0x24")]
		public Action<BankOptionData> BuyOptionPendingEvent;
	}
}
