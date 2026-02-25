using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001068 RID: 4200
	[Token(Token = "0x2001068")]
	public class ExpectedPayoffBanErrors : ExpectedDefaultError
	{
		// Token: 0x06006264 RID: 25188 RVA: 0x00012660 File Offset: 0x00010860
		[Token(Token = "0x6006264")]
		[Address(RVA = "0xAE8A", Offset = "0xAE8A", VA = "0xAE8A", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006265 RID: 25189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006265")]
		[Address(RVA = "0xAE8B", Offset = "0xAE8B", VA = "0xAE8B")]
		public ExpectedPayoffBanErrors()
		{
		}
	}
}
