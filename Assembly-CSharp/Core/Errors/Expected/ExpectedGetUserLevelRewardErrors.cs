using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001062 RID: 4194
	[Token(Token = "0x2001062")]
	public class ExpectedGetUserLevelRewardErrors : ExpectedDefaultError
	{
		// Token: 0x06006259 RID: 25177 RVA: 0x000125E8 File Offset: 0x000107E8
		[Token(Token = "0x6006259")]
		[Address(RVA = "0xAE7F", Offset = "0xAE7F", VA = "0xAE7F", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600625A RID: 25178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600625A")]
		[Address(RVA = "0xAE80", Offset = "0xAE80", VA = "0xAE80")]
		public ExpectedGetUserLevelRewardErrors()
		{
		}
	}
}
