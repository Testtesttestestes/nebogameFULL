using System;
using Gameplay.Combat;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200104E RID: 4174
	[Token(Token = "0x200104E")]
	public class ExpectedCombatErrors : ExpectedDefaultError
	{
		// Token: 0x0600621D RID: 25117 RVA: 0x00012438 File Offset: 0x00010638
		[Token(Token = "0x600621D")]
		[Address(RVA = "0xAE48", Offset = "0xAE48", VA = "0xAE48", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600621E RID: 25118 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600621E")]
		[Address(RVA = "0xAE49", Offset = "0xAE49", VA = "0xAE49", Slot = "5")]
		public virtual string GetInsufficientConditionsText(ICombat combat)
		{
			return null;
		}

		// Token: 0x0600621F RID: 25119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600621F")]
		[Address(RVA = "0xAE4A", Offset = "0xAE4A", VA = "0xAE4A")]
		public ExpectedCombatErrors()
		{
		}
	}
}
