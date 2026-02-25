using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200104D RID: 4173
	[Token(Token = "0x200104D")]
	public class ExpectedCombatBillingErrors : ExpectedBillingErrors
	{
		// Token: 0x0600621B RID: 25115 RVA: 0x00012420 File Offset: 0x00010620
		[Token(Token = "0x600621B")]
		[Address(RVA = "0xAE46", Offset = "0xAE46", VA = "0xAE46", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600621C RID: 25116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600621C")]
		[Address(RVA = "0xAE47", Offset = "0xAE47", VA = "0xAE47")]
		public ExpectedCombatBillingErrors()
		{
		}
	}
}
