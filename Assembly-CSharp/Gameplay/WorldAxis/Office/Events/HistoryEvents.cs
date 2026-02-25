using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.WorldAxis.Office.Events
{
	// Token: 0x020002D9 RID: 729
	[Token(Token = "0x20002D9")]
	public class HistoryEvents : AbstractMVCEvents
	{
		// Token: 0x06001132 RID: 4402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001132")]
		[Address(RVA = "0x632F", Offset = "0x632F", VA = "0x632F")]
		public HistoryEvents()
		{
		}

		// Token: 0x040008EF RID: 2287
		[Token(Token = "0x40008EF")]
		[FieldOffset(Offset = "0x14")]
		public Action HistoryRequestedEvent;

		// Token: 0x040008F0 RID: 2288
		[Token(Token = "0x40008F0")]
		[FieldOffset(Offset = "0x18")]
		public Action FirstHistoryRequestedEvent;

		// Token: 0x040008F1 RID: 2289
		[Token(Token = "0x40008F1")]
		[FieldOffset(Offset = "0x1C")]
		public Action BattleInfoRequestedEvent;
	}
}
