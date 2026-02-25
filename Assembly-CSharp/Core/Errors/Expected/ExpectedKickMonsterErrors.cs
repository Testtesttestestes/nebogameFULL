using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001066 RID: 4198
	[Token(Token = "0x2001066")]
	public class ExpectedKickMonsterErrors : ExpectedDefaultError
	{
		// Token: 0x06006260 RID: 25184 RVA: 0x00012630 File Offset: 0x00010830
		[Token(Token = "0x6006260")]
		[Address(RVA = "0xAE86", Offset = "0xAE86", VA = "0xAE86", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006261 RID: 25185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006261")]
		[Address(RVA = "0xAE87", Offset = "0xAE87", VA = "0xAE87")]
		public ExpectedKickMonsterErrors()
		{
		}
	}
}
