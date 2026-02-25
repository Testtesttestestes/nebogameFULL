using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Office.Events
{
	// Token: 0x02000A5E RID: 2654
	[Token(Token = "0x2000A5E")]
	public class ClanOfficeEvents : AbstractMVCEvents
	{
		// Token: 0x06003ED0 RID: 16080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED0")]
		[Address(RVA = "0x8D8C", Offset = "0x8D8C", VA = "0x8D8C")]
		public ClanOfficeEvents()
		{
		}

		// Token: 0x04002363 RID: 9059
		[Token(Token = "0x4002363")]
		[FieldOffset(Offset = "0x14")]
		public Action<uint> FirstVacanciesRequestedEvent;

		// Token: 0x04002364 RID: 9060
		[Token(Token = "0x4002364")]
		[FieldOffset(Offset = "0x18")]
		public Action<uint> AdditionalVacanciesRequestedEvent;

		// Token: 0x04002365 RID: 9061
		[Token(Token = "0x4002365")]
		[FieldOffset(Offset = "0x1C")]
		public Action JoinRequestCancelledEvent;

		// Token: 0x04002366 RID: 9062
		[Token(Token = "0x4002366")]
		[FieldOffset(Offset = "0x20")]
		public Action JoinRequestSentEvent;

		// Token: 0x04002367 RID: 9063
		[Token(Token = "0x4002367")]
		[FieldOffset(Offset = "0x24")]
		public Action RequestCloseOfficeWindowEvent;

		// Token: 0x04002368 RID: 9064
		[Token(Token = "0x4002368")]
		[FieldOffset(Offset = "0x28")]
		public Action<int, bool> ClanPageRemovedEvent;
	}
}
