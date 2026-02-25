using System;
using Core.Data;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.TradeAndCraft.Model
{
	// Token: 0x0200049C RID: 1180
	[Token(Token = "0x200049C")]
	public class TradeAndCraftModel : AbstractModel
	{
		// Token: 0x06001BE7 RID: 7143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE7")]
		[Address(RVA = "0x6D66", Offset = "0x6D66", VA = "0x6D66")]
		public TradeAndCraftModel(UserData user)
		{
		}

		// Token: 0x04000F1B RID: 3867
		[Token(Token = "0x4000F1B")]
		[FieldOffset(Offset = "0xC")]
		public readonly IDiscountHandler DiscountHandler;
	}
}
