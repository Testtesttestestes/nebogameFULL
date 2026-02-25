using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200106B RID: 4203
	[Token(Token = "0x200106B")]
	public class ExpectedPortalCommonErrors : ExpectedDefaultError
	{
		// Token: 0x0600626A RID: 25194 RVA: 0x000126A8 File Offset: 0x000108A8
		[Token(Token = "0x600626A")]
		[Address(RVA = "0xAE90", Offset = "0xAE90", VA = "0xAE90", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600626B RID: 25195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600626B")]
		[Address(RVA = "0xAE91", Offset = "0xAE91", VA = "0xAE91")]
		public ExpectedPortalCommonErrors()
		{
		}
	}
}
