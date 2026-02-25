using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Clans
{
	// Token: 0x02001089 RID: 4233
	[Token(Token = "0x2001089")]
	public class ExpectedUnregisterClanErrors : ExpectedDefaultError
	{
		// Token: 0x060062A5 RID: 25253 RVA: 0x000128D0 File Offset: 0x00010AD0
		[Token(Token = "0x60062A5")]
		[Address(RVA = "0xAECB", Offset = "0xAECB", VA = "0xAECB", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x060062A6 RID: 25254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062A6")]
		[Address(RVA = "0xAECC", Offset = "0xAECC", VA = "0xAECC")]
		public ExpectedUnregisterClanErrors()
		{
		}
	}
}
