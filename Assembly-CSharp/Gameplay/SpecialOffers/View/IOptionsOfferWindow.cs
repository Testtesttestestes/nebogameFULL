using System;
using System.Collections.Generic;
using Gameplay.Bank.View;
using Gameplay.SpecialOffers.View.Picker;
using Il2CppDummyDll;
using UI;
using UI.Windows;

namespace Gameplay.SpecialOffers.View
{
	// Token: 0x020004F8 RID: 1272
	[Token(Token = "0x20004F8")]
	public interface IOptionsOfferWindow
	{
		// Token: 0x06001E5D RID: 7773
		[Token(Token = "0x6001E5D")]
		void Init(IList<BankOptionListElement.BankOptionListElementArgs> optionArgs);

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001E5E RID: 7774
		[Token(Token = "0x17000580")]
		IndexButtonBasic InBankButton { [Token(Token = "0x6001E5E")] get; }

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001E5F RID: 7775
		[Token(Token = "0x17000581")]
		SpecialOfferPicker Picker { [Token(Token = "0x6001E5F")] get; }

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001E60 RID: 7776
		[Token(Token = "0x17000582")]
		OptionBoughtView OptionBoughtView { [Token(Token = "0x6001E60")] get; }

		// Token: 0x06001E61 RID: 7777
		[Token(Token = "0x6001E61")]
		void Close(WindowCloseReason windowCloseReason);
	}
}
