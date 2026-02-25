using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200104B RID: 4171
	[Token(Token = "0x200104B")]
	public class ExpectedChangeNickErrors : ExpectedDefaultError
	{
		// Token: 0x06006218 RID: 25112 RVA: 0x00012408 File Offset: 0x00010608
		[Token(Token = "0x6006218")]
		[Address(RVA = "0xAE43", Offset = "0xAE43", VA = "0xAE43", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006219 RID: 25113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006219")]
		[Address(RVA = "0xAE44", Offset = "0xAE44", VA = "0xAE44")]
		public ExpectedChangeNickErrors()
		{
		}

		// Token: 0x0200104C RID: 4172
		[Token(Token = "0x200104C")]
		public class SuggestNickVariants
		{
			// Token: 0x0600621A RID: 25114 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600621A")]
			[Address(RVA = "0xAE45", Offset = "0xAE45", VA = "0xAE45")]
			public SuggestNickVariants()
			{
			}

			// Token: 0x040034D5 RID: 13525
			[Token(Token = "0x40034D5")]
			[FieldOffset(Offset = "0x8")]
			public string NickSource;

			// Token: 0x040034D6 RID: 13526
			[Token(Token = "0x40034D6")]
			[FieldOffset(Offset = "0xC")]
			public Action<string> Callback;
		}
	}
}
