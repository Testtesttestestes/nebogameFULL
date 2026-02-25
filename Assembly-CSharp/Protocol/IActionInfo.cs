using System;
using Core.Money;
using Il2CppDummyDll;

namespace Protocol
{
	// Token: 0x020000B9 RID: 185
	[Token(Token = "0x20000B9")]
	public interface IActionInfo
	{
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000713 RID: 1811
		[Token(Token = "0x170000C3")]
		bool MarketAccount { [Token(Token = "0x6000713")] get; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000714 RID: 1812
		// (set) Token: 0x06000715 RID: 1813
		[Token(Token = "0x170000C4")]
		uint Quantity { [Token(Token = "0x6000714")] get; [Token(Token = "0x6000715")] set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000716 RID: 1814
		[Token(Token = "0x170000C5")]
		Money NormalPrice { [Token(Token = "0x6000716")] get; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000717 RID: 1815
		[Token(Token = "0x170000C6")]
		int State { [Token(Token = "0x6000717")] get; }
	}
}
