using System;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Gameplay.Discounts.Model
{
	// Token: 0x0200089D RID: 2205
	[Token(Token = "0x200089D")]
	public class EmptyDiscountsProvider : IDiscountsProvider
	{
		// Token: 0x060033EC RID: 13292 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		[Token(Token = "0x60033EC")]
		[Address(RVA = "0x8424", Offset = "0x8424", VA = "0x8424", Slot = "4")]
		public bool TryGetDiscount(DiscountTargets type, out DiscountData data)
		{
			return default(bool);
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		[Token(Token = "0x60033ED")]
		[Address(RVA = "0x8425", Offset = "0x8425", VA = "0x8425", Slot = "5")]
		public bool TryGetDiscountCoeff(DiscountTargets target, out double discountCoeff)
		{
			return default(bool);
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033EE")]
		[Address(RVA = "0x8426", Offset = "0x8426", VA = "0x8426")]
		public EmptyDiscountsProvider()
		{
		}
	}
}
