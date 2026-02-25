using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.DailyQuests.Events
{
	// Token: 0x02000886 RID: 2182
	[Token(Token = "0x2000886")]
	public class DailyQuestEvents : AbstractMVCEvents
	{
		// Token: 0x0600335B RID: 13147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600335B")]
		[Address(RVA = "0x8396", Offset = "0x8396", VA = "0x8396")]
		public DailyQuestEvents()
		{
		}

		// Token: 0x04001C06 RID: 7174
		[Token(Token = "0x4001C06")]
		[FieldOffset(Offset = "0x14")]
		public Action QuestsChangedEvent;

		// Token: 0x04001C07 RID: 7175
		[Token(Token = "0x4001C07")]
		[FieldOffset(Offset = "0x18")]
		public Action ActiveQuestsCountChangedEvent;

		// Token: 0x04001C08 RID: 7176
		[Token(Token = "0x4001C08")]
		[FieldOffset(Offset = "0x1C")]
		public Action QuestsUpdatedEvent;

		// Token: 0x04001C09 RID: 7177
		[Token(Token = "0x4001C09")]
		[FieldOffset(Offset = "0x20")]
		public Action FinishTakeRewardEvent;
	}
}
