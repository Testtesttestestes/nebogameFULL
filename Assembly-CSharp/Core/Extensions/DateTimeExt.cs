using System;
using System.Globalization;
using Il2CppDummyDll;

namespace Core.Extensions
{
	// Token: 0x02000F05 RID: 3845
	[Token(Token = "0x2000F05")]
	public static class DateTimeExt
	{
		// Token: 0x06005D21 RID: 23841 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D21")]
		[Address(RVA = "0xA9A7", Offset = "0xA9A7", VA = "0xA9A7")]
		public static CultureInfo GetDefaultCultureForDate()
		{
			return null;
		}

		// Token: 0x06005D22 RID: 23842 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D22")]
		[Address(RVA = "0xA9A8", Offset = "0xA9A8", VA = "0xA9A8")]
		public static string ToGregorianCalenderTimeString(this DateTime date, string format)
		{
			return null;
		}

		// Token: 0x06005D23 RID: 23843 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D23")]
		[Address(RVA = "0xA9A9", Offset = "0xA9A9", VA = "0xA9A9")]
		public static string ToGregorianCalenderTimeString(this DateTime date)
		{
			return null;
		}

		// Token: 0x040032D6 RID: 13014
		[Token(Token = "0x40032D6")]
		[FieldOffset(Offset = "0x0")]
		private static CultureInfo _cachedCulture;
	}
}
