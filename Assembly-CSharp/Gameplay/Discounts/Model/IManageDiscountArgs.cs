using System;
using Core.Data;
using Il2CppDummyDll;

namespace Gameplay.Discounts.Model
{
	// Token: 0x020008A3 RID: 2211
	[Token(Token = "0x20008A3")]
	public interface IManageDiscountArgs
	{
		// Token: 0x17000A4D RID: 2637
		// (set) Token: 0x060033F9 RID: 13305
		[Token(Token = "0x17000A4D")]
		DiscountData Data { [Token(Token = "0x60033F9")] set; }
	}
}
