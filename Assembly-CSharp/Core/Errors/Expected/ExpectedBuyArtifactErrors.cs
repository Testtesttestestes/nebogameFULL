using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001046 RID: 4166
	[Token(Token = "0x2001046")]
	public class ExpectedBuyArtifactErrors : ExpectedDefaultError
	{
		// Token: 0x0600620E RID: 25102 RVA: 0x00012390 File Offset: 0x00010590
		[Token(Token = "0x600620E")]
		[Address(RVA = "0xAE39", Offset = "0xAE39", VA = "0xAE39", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600620F RID: 25103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600620F")]
		[Address(RVA = "0xAE3A", Offset = "0xAE3A", VA = "0xAE3A")]
		public ExpectedBuyArtifactErrors()
		{
		}
	}
}
