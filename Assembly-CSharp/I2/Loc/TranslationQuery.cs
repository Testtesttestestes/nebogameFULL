using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x0200135F RID: 4959
	[Token(Token = "0x200135F")]
	public struct TranslationQuery
	{
		// Token: 0x04003D76 RID: 15734
		[Token(Token = "0x4003D76")]
		[FieldOffset(Offset = "0x0")]
		public string OrigText;

		// Token: 0x04003D77 RID: 15735
		[Token(Token = "0x4003D77")]
		[FieldOffset(Offset = "0x4")]
		public string Text;

		// Token: 0x04003D78 RID: 15736
		[Token(Token = "0x4003D78")]
		[FieldOffset(Offset = "0x8")]
		public string LanguageCode;

		// Token: 0x04003D79 RID: 15737
		[Token(Token = "0x4003D79")]
		[FieldOffset(Offset = "0xC")]
		public string[] TargetLanguagesCode;

		// Token: 0x04003D7A RID: 15738
		[Token(Token = "0x4003D7A")]
		[FieldOffset(Offset = "0x10")]
		public string[] Results;

		// Token: 0x04003D7B RID: 15739
		[Token(Token = "0x4003D7B")]
		[FieldOffset(Offset = "0x14")]
		public string[] Tags;
	}
}
