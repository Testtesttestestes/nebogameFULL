using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001067 RID: 4199
	[Token(Token = "0x2001067")]
	public class ExpectedOpenCraftSlotErrors : ExpectedDefaultError
	{
		// Token: 0x06006262 RID: 25186 RVA: 0x00012648 File Offset: 0x00010848
		[Token(Token = "0x6006262")]
		[Address(RVA = "0xAE88", Offset = "0xAE88", VA = "0xAE88", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006263 RID: 25187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006263")]
		[Address(RVA = "0xAE89", Offset = "0xAE89", VA = "0xAE89")]
		public ExpectedOpenCraftSlotErrors()
		{
		}
	}
}
