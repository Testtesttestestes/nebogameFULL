using System;
using Il2CppDummyDll;

namespace Gameplay.GdEvents.Model.Categories
{
	// Token: 0x02000761 RID: 1889
	[Token(Token = "0x2000761")]
	public class TimerStrings
	{
		// Token: 0x06002D01 RID: 11521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D01")]
		[Address(RVA = "0x7D7F", Offset = "0x7D7F", VA = "0x7D7F")]
		public TimerStrings(string start, string left, string willStartSoon, string willEndSoon)
		{
		}

		// Token: 0x040018BD RID: 6333
		[Token(Token = "0x40018BD")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Start;

		// Token: 0x040018BE RID: 6334
		[Token(Token = "0x40018BE")]
		[FieldOffset(Offset = "0xC")]
		public readonly string Left;

		// Token: 0x040018BF RID: 6335
		[Token(Token = "0x40018BF")]
		[FieldOffset(Offset = "0x10")]
		public readonly string WillStartSoon;

		// Token: 0x040018C0 RID: 6336
		[Token(Token = "0x40018C0")]
		[FieldOffset(Offset = "0x14")]
		public readonly string WillEndSoon;

		// Token: 0x040018C1 RID: 6337
		[Token(Token = "0x40018C1")]
		[FieldOffset(Offset = "0x18")]
		public readonly string Empty;
	}
}
