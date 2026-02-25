using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Clans
{
	// Token: 0x02001080 RID: 4224
	[Token(Token = "0x2001080")]
	public class ExpectedClanBuildingErrors : ExpectedDefaultError
	{
		// Token: 0x06006295 RID: 25237 RVA: 0x00012840 File Offset: 0x00010A40
		[Token(Token = "0x6006295")]
		[Address(RVA = "0xAEBB", Offset = "0xAEBB", VA = "0xAEBB", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006296 RID: 25238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006296")]
		[Address(RVA = "0xAEBC", Offset = "0xAEBC", VA = "0xAEBC")]
		public ExpectedClanBuildingErrors()
		{
		}
	}
}
