using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Office.Events.ClanWars
{
	// Token: 0x02000A63 RID: 2659
	[Token(Token = "0x2000A63")]
	public class ClanWarsHistoryEvents : AbstractMVCEvents
	{
		// Token: 0x06003ED5 RID: 16085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED5")]
		[Address(RVA = "0x8D91", Offset = "0x8D91", VA = "0x8D91")]
		public ClanWarsHistoryEvents()
		{
		}

		// Token: 0x04002378 RID: 9080
		[Token(Token = "0x4002378")]
		[FieldOffset(Offset = "0x14")]
		public Action FirstHistoryRequestedEvent;

		// Token: 0x04002379 RID: 9081
		[Token(Token = "0x4002379")]
		[FieldOffset(Offset = "0x18")]
		public Action HistoryRequestedEvent;

		// Token: 0x0400237A RID: 9082
		[Token(Token = "0x400237A")]
		[FieldOffset(Offset = "0x1C")]
		public Action ClanWarDeclaredEvent;
	}
}
