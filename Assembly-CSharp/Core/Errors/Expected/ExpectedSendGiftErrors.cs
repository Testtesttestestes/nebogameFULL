using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200106F RID: 4207
	[Token(Token = "0x200106F")]
	public class ExpectedSendGiftErrors : ExpectedDefaultError
	{
		// Token: 0x06006274 RID: 25204 RVA: 0x000126F0 File Offset: 0x000108F0
		[Token(Token = "0x6006274")]
		[Address(RVA = "0xAE9A", Offset = "0xAE9A", VA = "0xAE9A", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006275 RID: 25205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006275")]
		[Address(RVA = "0xAE9B", Offset = "0xAE9B", VA = "0xAE9B")]
		public ExpectedSendGiftErrors()
		{
		}
	}
}
