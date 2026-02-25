using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Clans
{
	// Token: 0x02001081 RID: 4225
	[Token(Token = "0x2001081")]
	public class ExpectedClanWarErrors : ExpectedDefaultError
	{
		// Token: 0x06006297 RID: 25239 RVA: 0x00012858 File Offset: 0x00010A58
		[Token(Token = "0x6006297")]
		[Address(RVA = "0xAEBD", Offset = "0xAEBD", VA = "0xAEBD", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006298 RID: 25240 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006298")]
		[Address(RVA = "0xAEBE", Offset = "0xAEBE", VA = "0xAEBE")]
		public static string GetClanWarErrorLocalization(int errorCode, ExpectedClanWarErrors.ExpectedClanWarsErrorsArgs args)
		{
			return null;
		}

		// Token: 0x06006299 RID: 25241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006299")]
		[Address(RVA = "0xAEBF", Offset = "0xAEBF", VA = "0xAEBF")]
		public ExpectedClanWarErrors()
		{
		}

		// Token: 0x02001082 RID: 4226
		[Token(Token = "0x2001082")]
		public class ExpectedClanWarsErrorsArgs
		{
			// Token: 0x0600629A RID: 25242 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600629A")]
			[Address(RVA = "0xAEC0", Offset = "0xAEC0", VA = "0xAEC0")]
			public ExpectedClanWarsErrorsArgs()
			{
			}

			// Token: 0x040034F6 RID: 13558
			[Token(Token = "0x40034F6")]
			[FieldOffset(Offset = "0x8")]
			public bool BlitzModeEnabled;
		}
	}
}
