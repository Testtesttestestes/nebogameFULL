using System;
using Gameplay.GdEvents.Model;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.GdEvents
{
	// Token: 0x0200071C RID: 1820
	[Token(Token = "0x200071C")]
	public class GdEventsEvents : AbstractMVCEvents
	{
		// Token: 0x06002B91 RID: 11153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B91")]
		[Address(RVA = "0x7C28", Offset = "0x7C28", VA = "0x7C28")]
		public GdEventsEvents()
		{
		}

		// Token: 0x040017D3 RID: 6099
		[Token(Token = "0x40017D3")]
		[FieldOffset(Offset = "0x14")]
		public Action CategoriesContentChangedEvent;

		// Token: 0x040017D4 RID: 6100
		[Token(Token = "0x40017D4")]
		[FieldOffset(Offset = "0x18")]
		public Action<GdEventData, GdEventData> CurrentEventChangedEvent;

		// Token: 0x040017D5 RID: 6101
		[Token(Token = "0x40017D5")]
		[FieldOffset(Offset = "0x1C")]
		public Action ContentChangedEvent;

		// Token: 0x040017D6 RID: 6102
		[Token(Token = "0x40017D6")]
		[FieldOffset(Offset = "0x20")]
		public Action<MilestoneData> CurrentMilestoneRewardUpdatedEvent;

		// Token: 0x040017D7 RID: 6103
		[Token(Token = "0x40017D7")]
		[FieldOffset(Offset = "0x24")]
		public Action<GdEventData> CurrentEventRewardUpdatedEvent;
	}
}
