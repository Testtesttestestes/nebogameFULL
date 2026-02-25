using System;
using Core.Data;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Common;
using Protocol.Consts;

namespace Gameplay.Discounts.Model
{
	// Token: 0x0200089F RID: 2207
	[Token(Token = "0x200089F")]
	public interface IDiscountArgs
	{
		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x060033F1 RID: 13297
		[Token(Token = "0x17000A49")]
		DiscountTargets DiscountTarget { [Token(Token = "0x60033F1")] get; }

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x060033F2 RID: 13298
		[Token(Token = "0x17000A4A")]
		ResourceSet Value { [Token(Token = "0x60033F2")] get; }

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x060033F3 RID: 13299
		[Token(Token = "0x17000A4B")]
		[CanBeNull]
		DiscountData Data { [Token(Token = "0x60033F3")] get; }
	}
}
