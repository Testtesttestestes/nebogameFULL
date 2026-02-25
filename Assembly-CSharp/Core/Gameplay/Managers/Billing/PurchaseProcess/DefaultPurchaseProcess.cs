using System;
using Gameplay.Bank.Model;
using Gameplay.Billing.Controller;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Billing.PurchaseProcess
{
	// Token: 0x020011F1 RID: 4593
	[Token(Token = "0x20011F1")]
	public class DefaultPurchaseProcess : IPurchaseProcess
	{
		// Token: 0x06006D25 RID: 27941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D25")]
		[Address(RVA = "0xB80E", Offset = "0xB80E", VA = "0xB80E")]
		public DefaultPurchaseProcess(AbstractBillingController controller)
		{
		}

		// Token: 0x06006D26 RID: 27942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D26")]
		[Address(RVA = "0xB80F", Offset = "0xB80F", VA = "0xB80F", Slot = "4")]
		public void Run(BankOptionData option)
		{
		}

		// Token: 0x0400391C RID: 14620
		[Token(Token = "0x400391C")]
		[FieldOffset(Offset = "0x8")]
		private readonly AbstractBillingController _controller;
	}
}
