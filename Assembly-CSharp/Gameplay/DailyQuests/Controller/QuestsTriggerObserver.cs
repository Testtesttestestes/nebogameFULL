using System;
using System.Collections.Generic;
using Core.Data;
using Core.Gameplay.Managers.Requirements;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;

namespace Gameplay.DailyQuests.Controller
{
	// Token: 0x0200088F RID: 2191
	[Token(Token = "0x200088F")]
	public class QuestsTriggerObserver : IDisposable
	{
		// Token: 0x060033B2 RID: 13234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033B2")]
		[Address(RVA = "0x83EC", Offset = "0x83EC", VA = "0x83EC")]
		public void AddDailyQuestsToBlackList(IEnumerable<uint> ids)
		{
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033B3")]
		[Address(RVA = "0x83ED", Offset = "0x83ED", VA = "0x83ED")]
		public void AddGoalsToBlackList(IEnumerable<uint> ids)
		{
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033B4")]
		[Address(RVA = "0x83EE", Offset = "0x83EE", VA = "0x83EE")]
		public void ClearDailyQuestsBlackList()
		{
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033B5")]
		[Address(RVA = "0x83EF", Offset = "0x83EF", VA = "0x83EF")]
		public void ClearGoalsBlackList()
		{
		}

		// Token: 0x060033B6 RID: 13238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033B6")]
		[Address(RVA = "0x83F0", Offset = "0x83F0", VA = "0x83F0")]
		public QuestsTriggerObserver(Dictionaries dict, UserData user, IRequirementValidator validator)
		{
		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60033B7")]
		[Address(RVA = "0x83F1", Offset = "0x83F1", VA = "0x83F1")]
		public QuestsTriggerObserver.Quests GetImpactedQuests(IEnumerable<TriggerValue> changes)
		{
			return null;
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033B8")]
		[Address(RVA = "0x83F2", Offset = "0x83F2", VA = "0x83F2", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04001C21 RID: 7201
		[Token(Token = "0x4001C21")]
		[FieldOffset(Offset = "0x8")]
		private readonly IRequirementValidator _requirementValidator;

		// Token: 0x04001C22 RID: 7202
		[Token(Token = "0x4001C22")]
		[FieldOffset(Offset = "0xC")]
		private readonly UserData _user;

		// Token: 0x04001C23 RID: 7203
		[Token(Token = "0x4001C23")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<int, QuestsTriggerObserver.Quests> _questsByTriggers;

		// Token: 0x04001C24 RID: 7204
		[Token(Token = "0x4001C24")]
		[FieldOffset(Offset = "0x14")]
		private readonly HashSet<uint> _dailyQuestsBlackList;

		// Token: 0x04001C25 RID: 7205
		[Token(Token = "0x4001C25")]
		[FieldOffset(Offset = "0x18")]
		private readonly HashSet<uint> _goalsBlackList;

		// Token: 0x02000890 RID: 2192
		[Token(Token = "0x2000890")]
		public class Quests
		{
			// Token: 0x060033BB RID: 13243 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60033BB")]
			[Address(RVA = "0x83F5", Offset = "0x83F5", VA = "0x83F5")]
			public Quests()
			{
			}

			// Token: 0x04001C26 RID: 7206
			[Token(Token = "0x4001C26")]
			[FieldOffset(Offset = "0x8")]
			public readonly HashSet<DailyQuestsDic> DailyQuestIds;

			// Token: 0x04001C27 RID: 7207
			[Token(Token = "0x4001C27")]
			[FieldOffset(Offset = "0xC")]
			public readonly HashSet<DailyGoalDic> GoalIds;
		}
	}
}
