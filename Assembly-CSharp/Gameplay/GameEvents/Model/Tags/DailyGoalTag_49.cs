using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007A0 RID: 1952
	[Token(Token = "0x20007A0")]
	public class DailyGoalTag_49 : AbstractTag
	{
		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06002E64 RID: 11876 RVA: 0x00009138 File Offset: 0x00007338
		[Token(Token = "0x170008F6")]
		public uint GoalId
		{
			[Token(Token = "0x6002E64")]
			[Address(RVA = "0x7EDF", Offset = "0x7EDF", VA = "0x7EDF")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x00009150 File Offset: 0x00007350
		[Token(Token = "0x6002E65")]
		[Address(RVA = "0x7EE0", Offset = "0x7EE0", VA = "0x7EE0", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E66")]
		[Address(RVA = "0x7EE1", Offset = "0x7EE1", VA = "0x7EE1")]
		public DailyGoalTag_49()
		{
		}

		// Token: 0x04001975 RID: 6517
		[Token(Token = "0x4001975")]
		public const string DAILY_GOAL_TITLE = "daily_goal_title";
	}
}
