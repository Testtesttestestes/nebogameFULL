using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Chat
{
	// Token: 0x0200108B RID: 4235
	[Token(Token = "0x200108B")]
	public class ExpectedChatSendMessageErrors : ExpectedDefaultError
	{
		// Token: 0x060062A9 RID: 25257 RVA: 0x00012900 File Offset: 0x00010B00
		[Token(Token = "0x60062A9")]
		[Address(RVA = "0xAECF", Offset = "0xAECF", VA = "0xAECF", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x060062AA RID: 25258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062AA")]
		[Address(RVA = "0xAED0", Offset = "0xAED0", VA = "0xAED0")]
		public ExpectedChatSendMessageErrors()
		{
		}
	}
}
