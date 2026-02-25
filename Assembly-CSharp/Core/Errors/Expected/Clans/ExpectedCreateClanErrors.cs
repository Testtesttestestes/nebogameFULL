using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Clans
{
	// Token: 0x02001083 RID: 4227
	[Token(Token = "0x2001083")]
	public class ExpectedCreateClanErrors : ExpectedDefaultError
	{
		// Token: 0x0600629B RID: 25243 RVA: 0x00012870 File Offset: 0x00010A70
		[Token(Token = "0x600629B")]
		[Address(RVA = "0xAEC1", Offset = "0xAEC1", VA = "0xAEC1", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600629C RID: 25244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600629C")]
		[Address(RVA = "0xAEC2", Offset = "0xAEC2", VA = "0xAEC2")]
		public ExpectedCreateClanErrors()
		{
		}

		// Token: 0x02001084 RID: 4228
		[Token(Token = "0x2001084")]
		public class ExpectedCreateClanErrorsArgs
		{
			// Token: 0x0600629D RID: 25245 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600629D")]
			[Address(RVA = "0xAEC3", Offset = "0xAEC3", VA = "0xAEC3")]
			public ExpectedCreateClanErrorsArgs(uint backtime)
			{
			}

			// Token: 0x040034F7 RID: 13559
			[Token(Token = "0x40034F7")]
			[FieldOffset(Offset = "0x8")]
			public uint Cooldown;
		}
	}
}
