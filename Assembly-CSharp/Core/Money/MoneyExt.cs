using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Money
{
	// Token: 0x02000EBA RID: 3770
	[Token(Token = "0x2000EBA")]
	public static class MoneyExt
	{
		// Token: 0x06005BE1 RID: 23521 RVA: 0x00010740 File Offset: 0x0000E940
		[Token(Token = "0x6005BE1")]
		[Address(RVA = "0xA89D", Offset = "0xA89D", VA = "0xA89D")]
		public static double GetValue(this Money money, Money.MoneyType type)
		{
			return 0.0;
		}

		// Token: 0x06005BE2 RID: 23522 RVA: 0x00010758 File Offset: 0x0000E958
		[Token(Token = "0x6005BE2")]
		[Address(RVA = "0xA89E", Offset = "0xA89E", VA = "0xA89E")]
		public static bool IsEnough(this Money money, Money required, out Money lack)
		{
			return default(bool);
		}

		// Token: 0x06005BE3 RID: 23523 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005BE3")]
		[Address(RVA = "0xA89F", Offset = "0xA89F", VA = "0xA89F")]
		public static IReadOnlyDictionary<Money.MoneyType, double> GetDelta(this Money money, Money other)
		{
			return null;
		}

		// Token: 0x06005BE4 RID: 23524 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005BE4")]
		[Address(RVA = "0xA8A0", Offset = "0xA8A0", VA = "0xA8A0")]
		public static Money Floor(this Money money)
		{
			return null;
		}

		// Token: 0x06005BE5 RID: 23525 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005BE5")]
		[Address(RVA = "0xA8A1", Offset = "0xA8A1", VA = "0xA8A1")]
		public static Money Ceiling(this Money money)
		{
			return null;
		}

		// Token: 0x06005BE6 RID: 23526 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005BE6")]
		[Address(RVA = "0xA8A2", Offset = "0xA8A2", VA = "0xA8A2")]
		public static Money Round(this Money money)
		{
			return null;
		}
	}
}
