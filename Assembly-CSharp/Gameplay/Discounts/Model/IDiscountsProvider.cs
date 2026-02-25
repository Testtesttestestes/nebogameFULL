using System;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Gameplay.Discounts.Model
{
	// Token: 0x020008A2 RID: 2210
	[Token(Token = "0x20008A2")]
	public interface IDiscountsProvider
	{
		// Token: 0x060033F7 RID: 13303
		[Token(Token = "0x60033F7")]
		bool TryGetDiscount(DiscountTargets type, out DiscountData data);

		// Token: 0x060033F8 RID: 13304
		[Token(Token = "0x60033F8")]
		bool TryGetDiscountCoeff(DiscountTargets target, out double discountCoeff);
	}
}
