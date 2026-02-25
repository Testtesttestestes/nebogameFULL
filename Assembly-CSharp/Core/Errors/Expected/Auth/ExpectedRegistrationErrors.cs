using System;
using Il2CppDummyDll;
using Protocol.Auth2;

namespace Core.Errors.Expected.Auth
{
	// Token: 0x02001094 RID: 4244
	[Token(Token = "0x2001094")]
	public static class ExpectedRegistrationErrors
	{
		// Token: 0x060062BE RID: 25278 RVA: 0x00012948 File Offset: 0x00010B48
		[Token(Token = "0x60062BE")]
		[Address(RVA = "0xAEE2", Offset = "0xAEE2", VA = "0xAEE2")]
		public static bool TryHandle(RegisterCmd.Types.Result errorCode)
		{
			return default(bool);
		}
	}
}
