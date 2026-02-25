using System;
using System.Collections.Generic;
using Core.Money;
using Il2CppDummyDll;

namespace UI.Price
{
	// Token: 0x020001C2 RID: 450
	[Token(Token = "0x20001C2")]
	public class PriceWithZeroResources : Price
	{
		// Token: 0x06000C02 RID: 3074 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x5F15", Offset = "0x5F15", VA = "0x5F15", Slot = "6")]
		protected override List<Money> GetGameResources()
		{
			return null;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x5F16", Offset = "0x5F16", VA = "0x5F16")]
		public PriceWithZeroResources()
		{
		}
	}
}
