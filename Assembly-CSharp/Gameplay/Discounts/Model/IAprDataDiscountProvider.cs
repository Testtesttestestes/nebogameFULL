using System;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;

namespace Gameplay.Discounts.Model
{
	// Token: 0x0200089E RID: 2206
	[Token(Token = "0x200089E")]
	public interface IAprDataDiscountProvider
	{
		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x060033EF RID: 13295
		[Token(Token = "0x17000A47")]
		bool HasDiscount { [Token(Token = "0x60033EF")] get; }

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x060033F0 RID: 13296
		[Token(Token = "0x17000A48")]
		AprData AprData { [Token(Token = "0x60033F0")] get; }
	}
}
