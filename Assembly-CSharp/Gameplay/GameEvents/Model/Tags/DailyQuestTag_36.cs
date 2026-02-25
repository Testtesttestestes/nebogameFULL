using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007A1 RID: 1953
	[Token(Token = "0x20007A1")]
	public class DailyQuestTag_36 : AbstractTag
	{
		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x00009168 File Offset: 0x00007368
		[Token(Token = "0x170008F7")]
		public uint DaylyQuestId
		{
			[Token(Token = "0x6002E67")]
			[Address(RVA = "0x7EE2", Offset = "0x7EE2", VA = "0x7EE2")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x00009180 File Offset: 0x00007380
		[Token(Token = "0x6002E68")]
		[Address(RVA = "0x7EE3", Offset = "0x7EE3", VA = "0x7EE3", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E69")]
		[Address(RVA = "0x7EE4", Offset = "0x7EE4", VA = "0x7EE4")]
		public DailyQuestTag_36()
		{
		}

		// Token: 0x04001976 RID: 6518
		[Token(Token = "0x4001976")]
		public const string DAILY_QUEST_TITLE = "daily_quest_title";
	}
}
