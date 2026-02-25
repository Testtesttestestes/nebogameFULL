using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001070 RID: 4208
	[Token(Token = "0x2001070")]
	public class ExpectedSetEmailErrors : ExpectedDefaultError
	{
		// Token: 0x06006276 RID: 25206 RVA: 0x00012708 File Offset: 0x00010908
		[Token(Token = "0x6006276")]
		[Address(RVA = "0xAE9C", Offset = "0xAE9C", VA = "0xAE9C", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006277 RID: 25207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006277")]
		[Address(RVA = "0xAE9D", Offset = "0xAE9D", VA = "0xAE9D")]
		public ExpectedSetEmailErrors()
		{
		}

		// Token: 0x02001071 RID: 4209
		[Token(Token = "0x2001071")]
		public enum EmailPasswordErrorCodes
		{
			// Token: 0x040034EC RID: 13548
			[Token(Token = "0x40034EC")]
			EMAIL_INVALID = -201,
			// Token: 0x040034ED RID: 13549
			[Token(Token = "0x40034ED")]
			PASS_TO_LONG = -202,
			// Token: 0x040034EE RID: 13550
			[Token(Token = "0x40034EE")]
			EMAIL_EXIST = -203,
			// Token: 0x040034EF RID: 13551
			[Token(Token = "0x40034EF")]
			PASS_LEN_INVALID = -2001,
			// Token: 0x040034F0 RID: 13552
			[Token(Token = "0x40034F0")]
			EMAIL_ERROR = -2100
		}
	}
}
