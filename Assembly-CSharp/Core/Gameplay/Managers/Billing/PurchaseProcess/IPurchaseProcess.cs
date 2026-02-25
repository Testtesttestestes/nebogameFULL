using System;
using Gameplay.Bank.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Billing.PurchaseProcess
{
	// Token: 0x020011F2 RID: 4594
	[Token(Token = "0x20011F2")]
	public interface IPurchaseProcess
	{
		// Token: 0x06006D27 RID: 27943
		[Token(Token = "0x6006D27")]
		void Run(BankOptionData option);
	}
}
