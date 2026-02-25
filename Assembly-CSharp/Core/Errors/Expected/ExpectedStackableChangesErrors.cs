using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001072 RID: 4210
	[Token(Token = "0x2001072")]
	public class ExpectedStackableChangesErrors : ExpectedDefaultError
	{
		// Token: 0x06006278 RID: 25208 RVA: 0x00012720 File Offset: 0x00010920
		[Token(Token = "0x6006278")]
		[Address(RVA = "0xAE9E", Offset = "0xAE9E", VA = "0xAE9E", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006279 RID: 25209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006279")]
		[Address(RVA = "0xAE9F", Offset = "0xAE9F", VA = "0xAE9F")]
		public ExpectedStackableChangesErrors()
		{
		}

		// Token: 0x02001073 RID: 4211
		[Token(Token = "0x2001073")]
		public enum Action : byte
		{
			// Token: 0x040034F2 RID: 13554
			[Token(Token = "0x40034F2")]
			DEFAULT,
			// Token: 0x040034F3 RID: 13555
			[Token(Token = "0x40034F3")]
			MERGE,
			// Token: 0x040034F4 RID: 13556
			[Token(Token = "0x40034F4")]
			SPLIT
		}
	}
}
