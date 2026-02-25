using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001077 RID: 4215
	[Token(Token = "0x2001077")]
	public class ExpectedThemeDuelCombatErrors : ExpectedCombatErrors
	{
		// Token: 0x06006281 RID: 25217 RVA: 0x00012780 File Offset: 0x00010980
		[Token(Token = "0x6006281")]
		[Address(RVA = "0xAEA7", Offset = "0xAEA7", VA = "0xAEA7", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006282 RID: 25218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006282")]
		[Address(RVA = "0xAEA8", Offset = "0xAEA8", VA = "0xAEA8")]
		public ExpectedThemeDuelCombatErrors()
		{
		}
	}
}
