using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace Utils
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	public static class StringUtils
	{
		// Token: 0x060002E4 RID: 740 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x21A7", Offset = "0x21A7", VA = "0x21A7")]
		public static string GetShortNumberString(double value, bool asInt = false)
		{
			return null;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1CCD", Offset = "0x1CCD", VA = "0x1CCD")]
		public static string GetShortNumberString2(double value)
		{
			return null;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1AFF", Offset = "0x1AFF", VA = "0x1AFF")]
		public static string GetNumberStringWithSpaces(double value, string whiteSpace = "\u00a0")
		{
			return null;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x5760", Offset = "0x5760", VA = "0x5760")]
		public static string GetRomanNumber(uint value)
		{
			return null;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x5761", Offset = "0x5761", VA = "0x5761")]
		public static string GetBarValueString(double current, double total)
		{
			return null;
		}

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string TAG_PATTERN;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x4")]
		public static readonly Regex EMAIL_REGEXP;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Regex TAG_REGEXP;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0xC")]
		private static NumberFormatInfo _numberFormatInfoWithSpaces;
	}
}
