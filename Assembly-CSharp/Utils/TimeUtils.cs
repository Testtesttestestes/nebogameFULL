using System;
using Il2CppDummyDll;

namespace Utils
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	public static class TimeUtils
	{
		// Token: 0x060002EA RID: 746 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x5763", Offset = "0x5763", VA = "0x5763")]
		public static float MsToSec(ulong ms)
		{
			return 0f;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1CA4", Offset = "0x1CA4", VA = "0x1CA4")]
		public static float MsToSec(long ms)
		{
			return 0f;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x5764", Offset = "0x5764", VA = "0x5764")]
		public static float SecToMs(ulong sec)
		{
			return 0f;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x5765", Offset = "0x5765", VA = "0x5765")]
		public static float SecToMs(long sec)
		{
			return 0f;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x5766", Offset = "0x5766", VA = "0x5766")]
		public static string FormatTwoDigits(int value)
		{
			return null;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x5767", Offset = "0x5767", VA = "0x5767")]
		public static string TimerFormat(double seconds)
		{
			return null;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x5768", Offset = "0x5768", VA = "0x5768")]
		public static string DateFormat(long seconds)
		{
			return null;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x5769", Offset = "0x5769", VA = "0x5769")]
		public static string DateTimeFormat(ulong milliseconds)
		{
			return null;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x576A", Offset = "0x576A", VA = "0x576A")]
		public static string DateFormat(long seconds, string format)
		{
			return null;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x576B", Offset = "0x576B", VA = "0x576B")]
		public static string Format(double seconds)
		{
			return null;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x17000074")]
		public static long UnixTimestamp
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x576C", Offset = "0x576C", VA = "0x576C")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x17000075")]
		public static long UnixTimestampMilliseconds
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x4475", Offset = "0x4475", VA = "0x4475")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		public const float SEC_ONE = 1f;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		public const float MS_IN_SEC = 1000f;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x0")]
		public static float SEC_IN_HOUR;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x4")]
		public static float SEC_IN_MINUTE;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x8")]
		public static float SEC_IN_DAY;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		public const string DATE_TIME_FORMAT = "dd MMMM yyyy, HH:mm";

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		public const string DATE_FORMAT = "dd.MM.yyyy";

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		public const string TIMER_FORMAT = "hh':'mm':'ss";

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		public const string TIMER_FORMAT_24 = "HH':'mm':'ss";

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		public const string ONLY_SECONDS_TIMER_FORMAT = "ss";

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0xC")]
		private static string _timerFormatDays;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x10")]
		private static string _timerFormatHours;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x14")]
		private static string _timerFormatMinutes;
	}
}
