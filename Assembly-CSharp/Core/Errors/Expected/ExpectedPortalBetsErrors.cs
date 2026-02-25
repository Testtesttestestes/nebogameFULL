using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001069 RID: 4201
	[Token(Token = "0x2001069")]
	public class ExpectedPortalBetsErrors : ExpectedDefaultError
	{
		// Token: 0x06006266 RID: 25190 RVA: 0x00012678 File Offset: 0x00010878
		[Token(Token = "0x6006266")]
		[Address(RVA = "0xAE8C", Offset = "0xAE8C", VA = "0xAE8C", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006267 RID: 25191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006267")]
		[Address(RVA = "0xAE8D", Offset = "0xAE8D", VA = "0xAE8D")]
		public ExpectedPortalBetsErrors()
		{
		}
	}
}
