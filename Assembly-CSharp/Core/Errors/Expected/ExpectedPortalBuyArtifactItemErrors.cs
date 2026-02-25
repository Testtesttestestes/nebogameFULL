using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200106A RID: 4202
	[Token(Token = "0x200106A")]
	public class ExpectedPortalBuyArtifactItemErrors : ExpectedDefaultError
	{
		// Token: 0x06006268 RID: 25192 RVA: 0x00012690 File Offset: 0x00010890
		[Token(Token = "0x6006268")]
		[Address(RVA = "0xAE8E", Offset = "0xAE8E", VA = "0xAE8E", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006269 RID: 25193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006269")]
		[Address(RVA = "0xAE8F", Offset = "0xAE8F", VA = "0xAE8F")]
		public ExpectedPortalBuyArtifactItemErrors()
		{
		}
	}
}
