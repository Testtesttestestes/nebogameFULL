using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200107A RID: 4218
	[Token(Token = "0x200107A")]
	public class ExpectedWorldAnimationErrors : ExpectedDefaultError
	{
		// Token: 0x06006287 RID: 25223 RVA: 0x000127B0 File Offset: 0x000109B0
		[Token(Token = "0x6006287")]
		[Address(RVA = "0xAEAD", Offset = "0xAEAD", VA = "0xAEAD", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006288 RID: 25224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006288")]
		[Address(RVA = "0xAEAE", Offset = "0xAEAE", VA = "0xAEAE")]
		public ExpectedWorldAnimationErrors()
		{
		}
	}
}
