using System;
using Gameplay.Clans.ClanWars.Events;
using Gameplay.Clans.Events;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;

namespace Gameplay.Clans.Office.Events
{
	// Token: 0x02000A5D RID: 2653
	[Token(Token = "0x2000A5D")]
	public class ClanInfoEvents : AbstractMVCEvents
	{
		// Token: 0x06003ECF RID: 16079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ECF")]
		[Address(RVA = "0x8D8B", Offset = "0x8D8B", VA = "0x8D8B")]
		public ClanInfoEvents(ClansEvents clansEvents, ClanWarsEvents clanWarEvents)
		{
		}

		// Token: 0x04002358 RID: 9048
		[Token(Token = "0x4002358")]
		[FieldOffset(Offset = "0x14")]
		public readonly ClansEvents ClansEvents;

		// Token: 0x04002359 RID: 9049
		[Token(Token = "0x4002359")]
		[FieldOffset(Offset = "0x18")]
		public readonly ClanWarsEvents ClanWarEvents;

		// Token: 0x0400235A RID: 9050
		[Token(Token = "0x400235A")]
		[FieldOffset(Offset = "0x1C")]
		public Action MembersRequestedEvent;

		// Token: 0x0400235B RID: 9051
		[Token(Token = "0x400235B")]
		[FieldOffset(Offset = "0x20")]
		public Action JoinRequestSentEvent;

		// Token: 0x0400235C RID: 9052
		[Token(Token = "0x400235C")]
		[FieldOffset(Offset = "0x24")]
		public Action JoinRequestCancelledEvent;

		// Token: 0x0400235D RID: 9053
		[Token(Token = "0x400235D")]
		[FieldOffset(Offset = "0x28")]
		public Action MembersChangedEvent;

		// Token: 0x0400235E RID: 9054
		[Token(Token = "0x400235E")]
		[FieldOffset(Offset = "0x2C")]
		public Action NewHeadAppointedEvent;

		// Token: 0x0400235F RID: 9055
		[Token(Token = "0x400235F")]
		[FieldOffset(Offset = "0x30")]
		public Action VacancyAddedEvent;

		// Token: 0x04002360 RID: 9056
		[Token(Token = "0x4002360")]
		[FieldOffset(Offset = "0x34")]
		public Action ClanStateFlagsChangedEvent;

		// Token: 0x04002361 RID: 9057
		[Token(Token = "0x4002361")]
		[FieldOffset(Offset = "0x38")]
		public Action ClanTreasuryRequestedEvent;

		// Token: 0x04002362 RID: 9058
		[Token(Token = "0x4002362")]
		[FieldOffset(Offset = "0x3C")]
		public Action<ResourceSet, ResourceSet> UserBalanceChangedEvent;
	}
}
