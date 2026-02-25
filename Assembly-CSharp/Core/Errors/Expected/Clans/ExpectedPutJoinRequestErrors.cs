using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Clans
{
	// Token: 0x02001087 RID: 4231
	[Token(Token = "0x2001087")]
	public class ExpectedPutJoinRequestErrors : ExpectedDefaultError
	{
		// Token: 0x060062A2 RID: 25250 RVA: 0x000128B8 File Offset: 0x00010AB8
		[Token(Token = "0x60062A2")]
		[Address(RVA = "0xAEC8", Offset = "0xAEC8", VA = "0xAEC8", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x060062A3 RID: 25251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062A3")]
		[Address(RVA = "0xAEC9", Offset = "0xAEC9", VA = "0xAEC9")]
		public ExpectedPutJoinRequestErrors()
		{
		}

		// Token: 0x02001088 RID: 4232
		[Token(Token = "0x2001088")]
		public class ExpectedPutJoinRequestErrorsArgs
		{
			// Token: 0x060062A4 RID: 25252 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60062A4")]
			[Address(RVA = "0xAECA", Offset = "0xAECA", VA = "0xAECA")]
			public ExpectedPutJoinRequestErrorsArgs(uint backtime)
			{
			}

			// Token: 0x040034F8 RID: 13560
			[Token(Token = "0x40034F8")]
			[FieldOffset(Offset = "0x8")]
			public uint Cooldown;
		}
	}
}
