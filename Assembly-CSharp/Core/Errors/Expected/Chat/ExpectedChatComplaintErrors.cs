using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Chat
{
	// Token: 0x0200108A RID: 4234
	[Token(Token = "0x200108A")]
	public class ExpectedChatComplaintErrors : ExpectedDefaultError
	{
		// Token: 0x060062A7 RID: 25255 RVA: 0x000128E8 File Offset: 0x00010AE8
		[Token(Token = "0x60062A7")]
		[Address(RVA = "0xAECD", Offset = "0xAECD", VA = "0xAECD", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x060062A8 RID: 25256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062A8")]
		[Address(RVA = "0xAECE", Offset = "0xAECE", VA = "0xAECE")]
		public ExpectedChatComplaintErrors()
		{
		}
	}
}
