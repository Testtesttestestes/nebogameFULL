using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001075 RID: 4213
	[Token(Token = "0x2001075")]
	public class ExpectedTargetProviderNotSupportedError : ExpectedDefaultError
	{
		// Token: 0x0600627D RID: 25213 RVA: 0x00012750 File Offset: 0x00010950
		[Token(Token = "0x600627D")]
		[Address(RVA = "0xAEA3", Offset = "0xAEA3", VA = "0xAEA3", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600627E RID: 25214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600627E")]
		[Address(RVA = "0xAEA4", Offset = "0xAEA4", VA = "0xAEA4")]
		public ExpectedTargetProviderNotSupportedError()
		{
		}
	}
}
