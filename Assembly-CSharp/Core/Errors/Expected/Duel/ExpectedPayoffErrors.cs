using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Duel
{
	// Token: 0x0200107C RID: 4220
	[Token(Token = "0x200107C")]
	public class ExpectedPayoffErrors : ExpectedDefaultError
	{
		// Token: 0x0600628B RID: 25227 RVA: 0x000127E0 File Offset: 0x000109E0
		[Token(Token = "0x600628B")]
		[Address(RVA = "0xAEB1", Offset = "0xAEB1", VA = "0xAEB1", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600628C RID: 25228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600628C")]
		[Address(RVA = "0xAEB2", Offset = "0xAEB2", VA = "0xAEB2")]
		public ExpectedPayoffErrors()
		{
		}
	}
}
