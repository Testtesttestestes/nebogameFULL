using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001040 RID: 4160
	[Token(Token = "0x2001040")]
	public class ExpectedArenaWhitMonsterErrors : ExpectedDefaultError
	{
		// Token: 0x060061FA RID: 25082 RVA: 0x000122E8 File Offset: 0x000104E8
		[Token(Token = "0x60061FA")]
		[Address(RVA = "0xAE25", Offset = "0xAE25", VA = "0xAE25", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x060061FB RID: 25083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061FB")]
		[Address(RVA = "0xAE26", Offset = "0xAE26", VA = "0xAE26")]
		public ExpectedArenaWhitMonsterErrors()
		{
		}
	}
}
