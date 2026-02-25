using System;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Gameplay.Discounts.Model
{
	// Token: 0x0200089C RID: 2204
	[Token(Token = "0x200089C")]
	public class DiscountsProviderDecorator : IDiscountsProvider, IDisposable
	{
		// Token: 0x060033E7 RID: 13287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033E7")]
		[Address(RVA = "0x841F", Offset = "0x841F", VA = "0x841F")]
		public void SetProviderImplementation(IDiscountsProvider provider)
		{
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x0000A980 File Offset: 0x00008B80
		[Token(Token = "0x60033E8")]
		[Address(RVA = "0x8420", Offset = "0x8420", VA = "0x8420", Slot = "4")]
		public bool TryGetDiscount(DiscountTargets type, out DiscountData data)
		{
			return default(bool);
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x0000A998 File Offset: 0x00008B98
		[Token(Token = "0x60033E9")]
		[Address(RVA = "0x8421", Offset = "0x8421", VA = "0x8421", Slot = "5")]
		public bool TryGetDiscountCoeff(DiscountTargets target, out double discountCoeff)
		{
			return default(bool);
		}

		// Token: 0x060033EA RID: 13290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033EA")]
		[Address(RVA = "0x8422", Offset = "0x8422", VA = "0x8422", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033EB")]
		[Address(RVA = "0x8423", Offset = "0x8423", VA = "0x8423")]
		public DiscountsProviderDecorator()
		{
		}

		// Token: 0x04001C48 RID: 7240
		[Token(Token = "0x4001C48")]
		[FieldOffset(Offset = "0x8")]
		private IDiscountsProvider _provider;
	}
}
