using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007A3 RID: 1955
	[Token(Token = "0x20007A3")]
	public class EventMilestone_48 : AbstractTag
	{
		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06002E6D RID: 11885 RVA: 0x000091C8 File Offset: 0x000073C8
		[Token(Token = "0x170008FA")]
		public uint EventId
		{
			[Token(Token = "0x6002E6D")]
			[Address(RVA = "0x7EE8", Offset = "0x7EE8", VA = "0x7EE8")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06002E6E RID: 11886 RVA: 0x000091E0 File Offset: 0x000073E0
		[Token(Token = "0x170008FB")]
		public int MilestoneNumber
		{
			[Token(Token = "0x6002E6E")]
			[Address(RVA = "0x7EE9", Offset = "0x7EE9", VA = "0x7EE9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x000091F8 File Offset: 0x000073F8
		[Token(Token = "0x6002E6F")]
		[Address(RVA = "0x7EEA", Offset = "0x7EEA", VA = "0x7EEA", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E70")]
		[Address(RVA = "0x7EEB", Offset = "0x7EEB", VA = "0x7EEB")]
		public EventMilestone_48()
		{
		}

		// Token: 0x04001977 RID: 6519
		[Token(Token = "0x4001977")]
		public const string GAME_EVENT_TITLE = "game_event_title";

		// Token: 0x04001978 RID: 6520
		[Token(Token = "0x4001978")]
		public const string EVENT_MILESTONE_TITLE = "event_milestone_title";
	}
}
