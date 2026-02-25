using System;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;

namespace Gameplay.Aprs.View.DiscountWidget
{
	// Token: 0x02000D5E RID: 3422
	[Token(Token = "0x2000D5E")]
	public interface IAprDiscountWidget
	{
		// Token: 0x060053D2 RID: 21458
		[Token(Token = "0x60053D2")]
		void SetData(IAprDataDiscountProvider data);
	}
}
