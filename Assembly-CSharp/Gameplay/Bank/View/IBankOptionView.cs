using System;
using Gameplay.Bank.Model;
using Il2CppDummyDll;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C4B RID: 3147
	[Token(Token = "0x2000C4B")]
	public interface IBankOptionView
	{
		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06004CBB RID: 19643
		// (set) Token: 0x06004CBC RID: 19644
		[Token(Token = "0x17000F78")]
		BankOptionData BankOptionData { [Token(Token = "0x6004CBB")] get; [Token(Token = "0x6004CBC")] set; }

		// Token: 0x06004CBD RID: 19645
		[Token(Token = "0x6004CBD")]
		void AddBuyButtonListener(Action<IBankOptionView> callback);

		// Token: 0x06004CBE RID: 19646
		[Token(Token = "0x6004CBE")]
		void RemoveBuyButtonListener(Action<IBankOptionView> callback);
	}
}
