using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200104A RID: 4170
	[Token(Token = "0x200104A")]
	public class ExpectedChangeAprErrors : ExpectedDefaultError
	{
		// Token: 0x06006216 RID: 25110 RVA: 0x000123F0 File Offset: 0x000105F0
		[Token(Token = "0x6006216")]
		[Address(RVA = "0xAE41", Offset = "0xAE41", VA = "0xAE41", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006217 RID: 25111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006217")]
		[Address(RVA = "0xAE42", Offset = "0xAE42", VA = "0xAE42")]
		public ExpectedChangeAprErrors()
		{
		}
	}
}
