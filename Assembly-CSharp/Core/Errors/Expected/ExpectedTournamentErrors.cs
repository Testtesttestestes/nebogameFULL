using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001078 RID: 4216
	[Token(Token = "0x2001078")]
	public class ExpectedTournamentErrors : ExpectedDefaultError
	{
		// Token: 0x06006283 RID: 25219 RVA: 0x00012798 File Offset: 0x00010998
		[Token(Token = "0x6006283")]
		[Address(RVA = "0xAEA9", Offset = "0xAEA9", VA = "0xAEA9", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006284 RID: 25220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006284")]
		[Address(RVA = "0xAEAA", Offset = "0xAEAA", VA = "0xAEAA")]
		public ExpectedTournamentErrors()
		{
		}
	}
}
