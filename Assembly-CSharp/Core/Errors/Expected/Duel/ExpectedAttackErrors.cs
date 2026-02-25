using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Duel
{
	// Token: 0x0200107B RID: 4219
	[Token(Token = "0x200107B")]
	public class ExpectedAttackErrors : ExpectedDefaultError
	{
		// Token: 0x06006289 RID: 25225 RVA: 0x000127C8 File Offset: 0x000109C8
		[Token(Token = "0x6006289")]
		[Address(RVA = "0xAEAF", Offset = "0xAEAF", VA = "0xAEAF", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600628A RID: 25226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600628A")]
		[Address(RVA = "0xAEB0", Offset = "0xAEB0", VA = "0xAEB0")]
		public ExpectedAttackErrors()
		{
		}
	}
}
