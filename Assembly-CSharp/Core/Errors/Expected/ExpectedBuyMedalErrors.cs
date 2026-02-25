using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001047 RID: 4167
	[Token(Token = "0x2001047")]
	public class ExpectedBuyMedalErrors : ExpectedDefaultError
	{
		// Token: 0x06006210 RID: 25104 RVA: 0x000123A8 File Offset: 0x000105A8
		[Token(Token = "0x6006210")]
		[Address(RVA = "0xAE3B", Offset = "0xAE3B", VA = "0xAE3B", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006211 RID: 25105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006211")]
		[Address(RVA = "0xAE3C", Offset = "0xAE3C", VA = "0xAE3C")]
		public ExpectedBuyMedalErrors()
		{
		}
	}
}
