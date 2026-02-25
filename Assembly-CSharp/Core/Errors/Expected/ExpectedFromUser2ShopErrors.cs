using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200105A RID: 4186
	[Token(Token = "0x200105A")]
	public class ExpectedFromUser2ShopErrors : ExpectedDefaultError
	{
		// Token: 0x06006241 RID: 25153 RVA: 0x00012588 File Offset: 0x00010788
		[Token(Token = "0x6006241")]
		[Address(RVA = "0xAE67", Offset = "0xAE67", VA = "0xAE67", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006242 RID: 25154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006242")]
		[Address(RVA = "0xAE68", Offset = "0xAE68", VA = "0xAE68")]
		public ExpectedFromUser2ShopErrors()
		{
		}
	}
}
