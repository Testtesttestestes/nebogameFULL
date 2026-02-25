using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001052 RID: 4178
	[Token(Token = "0x2001052")]
	public class ExpectedEndlessOptionsBillingErrors : ExpectedDefaultError
	{
		// Token: 0x0600622A RID: 25130 RVA: 0x00012480 File Offset: 0x00010680
		[Token(Token = "0x600622A")]
		[Address(RVA = "0xAE55", Offset = "0xAE55", VA = "0xAE55", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600622B RID: 25131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600622B")]
		[Address(RVA = "0xAE56", Offset = "0xAE56", VA = "0xAE56")]
		public ExpectedEndlessOptionsBillingErrors()
		{
		}
	}
}
