using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001045 RID: 4165
	[Token(Token = "0x2001045")]
	public class ExpectedBossErrors : ExpectedDefaultError
	{
		// Token: 0x0600620C RID: 25100 RVA: 0x00012378 File Offset: 0x00010578
		[Token(Token = "0x600620C")]
		[Address(RVA = "0xAE37", Offset = "0xAE37", VA = "0xAE37", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600620D RID: 25101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600620D")]
		[Address(RVA = "0xAE38", Offset = "0xAE38", VA = "0xAE38")]
		public ExpectedBossErrors()
		{
		}
	}
}
