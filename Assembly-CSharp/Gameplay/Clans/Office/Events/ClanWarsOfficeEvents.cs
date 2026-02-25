using System;
using Gameplay.Clans.ClanWars.Events;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Office.Events
{
	// Token: 0x02000A60 RID: 2656
	[Token(Token = "0x2000A60")]
	public class ClanWarsOfficeEvents : AbstractMVCEvents
	{
		// Token: 0x06003ED2 RID: 16082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED2")]
		[Address(RVA = "0x8D8E", Offset = "0x8D8E", VA = "0x8D8E")]
		public ClanWarsOfficeEvents(ClanWarsEvents clanWarsEvents)
		{
		}

		// Token: 0x0400236D RID: 9069
		[Token(Token = "0x400236D")]
		[FieldOffset(Offset = "0x14")]
		public ClanWarsEvents ClanWarsEvents;

		// Token: 0x0400236E RID: 9070
		[Token(Token = "0x400236E")]
		[FieldOffset(Offset = "0x18")]
		public Action FirstPoliticsRequestedEvent;

		// Token: 0x0400236F RID: 9071
		[Token(Token = "0x400236F")]
		[FieldOffset(Offset = "0x1C")]
		public Action PoliticsAddedEvent;
	}
}
