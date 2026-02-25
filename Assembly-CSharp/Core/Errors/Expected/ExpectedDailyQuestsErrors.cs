using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001051 RID: 4177
	[Token(Token = "0x2001051")]
	public class ExpectedDailyQuestsErrors : ExpectedDefaultError
	{
		// Token: 0x06006228 RID: 25128 RVA: 0x00012468 File Offset: 0x00010668
		[Token(Token = "0x6006228")]
		[Address(RVA = "0xAE53", Offset = "0xAE53", VA = "0xAE53", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006229 RID: 25129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006229")]
		[Address(RVA = "0xAE54", Offset = "0xAE54", VA = "0xAE54")]
		public ExpectedDailyQuestsErrors()
		{
		}
	}
}
