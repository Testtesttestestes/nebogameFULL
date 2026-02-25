using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Gameplay.Discounts.Model
{
	// Token: 0x020008A1 RID: 2209
	[Token(Token = "0x20008A1")]
	public interface IDiscountTarget
	{
		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x060033F5 RID: 13301
		[Token(Token = "0x17000A4C")]
		DiscountTargets[] DiscountTargets { [Token(Token = "0x60033F5")] get; }

		// Token: 0x060033F6 RID: 13302
		[Token(Token = "0x60033F6")]
		void Setup(IEnumerable<IDiscountArgs> value);
	}
}
