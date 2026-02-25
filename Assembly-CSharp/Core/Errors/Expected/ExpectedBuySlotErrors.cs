using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001048 RID: 4168
	[Token(Token = "0x2001048")]
	public class ExpectedBuySlotErrors : ExpectedDefaultError
	{
		// Token: 0x06006212 RID: 25106 RVA: 0x000123C0 File Offset: 0x000105C0
		[Token(Token = "0x6006212")]
		[Address(RVA = "0xAE3D", Offset = "0xAE3D", VA = "0xAE3D", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006213 RID: 25107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006213")]
		[Address(RVA = "0xAE3E", Offset = "0xAE3E", VA = "0xAE3E")]
		public ExpectedBuySlotErrors()
		{
		}
	}
}
