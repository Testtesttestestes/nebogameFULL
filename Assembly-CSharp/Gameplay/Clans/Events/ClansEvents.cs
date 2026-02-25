using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Events
{
	// Token: 0x02000A8C RID: 2700
	[Token(Token = "0x2000A8C")]
	public class ClansEvents : AbstractMVCEvents
	{
		// Token: 0x060040AC RID: 16556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040AC")]
		[Address(RVA = "0x8F63", Offset = "0x8F63", VA = "0x8F63")]
		public ClansEvents()
		{
		}

		// Token: 0x040023EC RID: 9196
		[Token(Token = "0x40023EC")]
		[FieldOffset(Offset = "0x14")]
		public Action ClanTreasuryChangedEvent;

		// Token: 0x040023ED RID: 9197
		[Token(Token = "0x40023ED")]
		[FieldOffset(Offset = "0x18")]
		public Action UserClanStatusChangedEvent;

		// Token: 0x040023EE RID: 9198
		[Token(Token = "0x40023EE")]
		[FieldOffset(Offset = "0x1C")]
		public Action UserTriggersChangedEvents;
	}
}
