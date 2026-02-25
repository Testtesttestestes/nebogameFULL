using System;
using Gameplay.Combat;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001079 RID: 4217
	[Token(Token = "0x2001079")]
	public class ExpectedVortexCombatErrors : ExpectedCombatErrors
	{
		// Token: 0x06006285 RID: 25221 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006285")]
		[Address(RVA = "0xAEAB", Offset = "0xAEAB", VA = "0xAEAB", Slot = "5")]
		public override string GetInsufficientConditionsText(ICombat combat)
		{
			return null;
		}

		// Token: 0x06006286 RID: 25222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006286")]
		[Address(RVA = "0xAEAC", Offset = "0xAEAC", VA = "0xAEAC")]
		public ExpectedVortexCombatErrors()
		{
		}
	}
}
