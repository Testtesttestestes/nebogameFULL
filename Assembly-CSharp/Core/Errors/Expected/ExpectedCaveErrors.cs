using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001049 RID: 4169
	[Token(Token = "0x2001049")]
	public class ExpectedCaveErrors : ExpectedBillingErrors
	{
		// Token: 0x06006214 RID: 25108 RVA: 0x000123D8 File Offset: 0x000105D8
		[Token(Token = "0x6006214")]
		[Address(RVA = "0xAE3F", Offset = "0xAE3F", VA = "0xAE3F", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006215 RID: 25109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006215")]
		[Address(RVA = "0xAE40", Offset = "0xAE40", VA = "0xAE40")]
		public ExpectedCaveErrors()
		{
		}
	}
}
