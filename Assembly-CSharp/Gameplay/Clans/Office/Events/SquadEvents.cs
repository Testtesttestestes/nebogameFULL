using System;
using Gameplay.WorldAxis.Events;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Office.Events
{
	// Token: 0x02000A62 RID: 2658
	[Token(Token = "0x2000A62")]
	public class SquadEvents : AbstractMVCEvents
	{
		// Token: 0x06003ED4 RID: 16084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED4")]
		[Address(RVA = "0x8D90", Offset = "0x8D90", VA = "0x8D90")]
		public SquadEvents(ClanInfoEvents clanInfoEvents, WorldAxisEvents worldAxisEvents)
		{
		}

		// Token: 0x04002374 RID: 9076
		[Token(Token = "0x4002374")]
		[FieldOffset(Offset = "0x14")]
		public readonly ClanInfoEvents ClanInfoEvents;

		// Token: 0x04002375 RID: 9077
		[Token(Token = "0x4002375")]
		[FieldOffset(Offset = "0x18")]
		public readonly WorldAxisEvents WorldAxisEvents;

		// Token: 0x04002376 RID: 9078
		[Token(Token = "0x4002376")]
		[FieldOffset(Offset = "0x1C")]
		public Action PartyInfoRequestedEvent;

		// Token: 0x04002377 RID: 9079
		[Token(Token = "0x4002377")]
		[FieldOffset(Offset = "0x20")]
		public Action SlotsChangedEvent;
	}
}
