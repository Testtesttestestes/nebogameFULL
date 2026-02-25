using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.DailyQuests;
using Protocol.Dic;

namespace Gameplay.DailyQuests.Model
{
	// Token: 0x02000881 RID: 2177
	[Token(Token = "0x2000881")]
	public class GoalData : IGoal, IQuest
	{
		// Token: 0x0600332E RID: 13102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600332E")]
		[Address(RVA = "0x8380", Offset = "0x8380", VA = "0x8380")]
		public GoalData(ProtoGetQuestsAns.Types.UserQuest quest, DailyGoalDic dic)
		{
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x0600332F RID: 13103 RVA: 0x0000A698 File Offset: 0x00008898
		// (set) Token: 0x06003330 RID: 13104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A1B")]
		public float ApproximateProgress
		{
			[Token(Token = "0x600332F")]
			[Address(RVA = "0x8381", Offset = "0x8381", VA = "0x8381", Slot = "8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003330")]
			[Address(RVA = "0x8382", Offset = "0x8382", VA = "0x8382", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06003331 RID: 13105 RVA: 0x0000A6B0 File Offset: 0x000088B0
		// (set) Token: 0x06003332 RID: 13106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A1C")]
		public bool RewardTaken
		{
			[Token(Token = "0x6003331")]
			[Address(RVA = "0x8383", Offset = "0x8383", VA = "0x8383", Slot = "12")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003332")]
			[Address(RVA = "0x8384", Offset = "0x8384", VA = "0x8384", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x1400016B RID: 363
		// (add) Token: 0x06003333 RID: 13107 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003334 RID: 13108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400016B")]
		public event Action QuestChangedEvent
		{
			[Token(Token = "0x6003333")]
			[Address(RVA = "0x8385", Offset = "0x8385", VA = "0x8385", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003334")]
			[Address(RVA = "0x8386", Offset = "0x8386", VA = "0x8386", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06003335 RID: 13109 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A1D")]
		public DailyGoalDic Dic
		{
			[Token(Token = "0x6003335")]
			[Address(RVA = "0x8387", Offset = "0x8387", VA = "0x8387", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06003336 RID: 13110 RVA: 0x0000A6C8 File Offset: 0x000088C8
		// (set) Token: 0x06003337 RID: 13111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A1E")]
		public bool IsCompleted
		{
			[Token(Token = "0x6003336")]
			[Address(RVA = "0x8388", Offset = "0x8388", VA = "0x8388", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003337")]
			[Address(RVA = "0x8389", Offset = "0x8389", VA = "0x8389", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06003338 RID: 13112 RVA: 0x0000A6E0 File Offset: 0x000088E0
		[Token(Token = "0x17000A1F")]
		public uint Id
		{
			[Token(Token = "0x6003338")]
			[Address(RVA = "0x838A", Offset = "0x838A", VA = "0x838A", Slot = "14")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06003339 RID: 13113 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A20")]
		public string Description
		{
			[Token(Token = "0x6003339")]
			[Address(RVA = "0x838B", Offset = "0x838B", VA = "0x838B", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x0600333A RID: 13114 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A21")]
		public string Title
		{
			[Token(Token = "0x600333A")]
			[Address(RVA = "0x838C", Offset = "0x838C", VA = "0x838C", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x0600333B RID: 13115 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A22")]
		public string IconAssetId
		{
			[Token(Token = "0x600333B")]
			[Address(RVA = "0x838D", Offset = "0x838D", VA = "0x838D", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x0600333C RID: 13116 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A23")]
		public string BackgroundAssetId
		{
			[Token(Token = "0x600333C")]
			[Address(RVA = "0x838E", Offset = "0x838E", VA = "0x838E", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x0600333D RID: 13117 RVA: 0x0000A6F8 File Offset: 0x000088F8
		[Token(Token = "0x17000A24")]
		public uint CategoryId
		{
			[Token(Token = "0x600333D")]
			[Address(RVA = "0x838F", Offset = "0x838F", VA = "0x838F", Slot = "19")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x0600333E RID: 13118 RVA: 0x0000A710 File Offset: 0x00008910
		[Token(Token = "0x17000A25")]
		public uint SortOrder
		{
			[Token(Token = "0x600333E")]
			[Address(RVA = "0x8390", Offset = "0x8390", VA = "0x8390", Slot = "20")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x0600333F RID: 13119 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A26")]
		public IList<GameActivityDic.Types.URI> Activities
		{
			[Token(Token = "0x600333F")]
			[Address(RVA = "0x8391", Offset = "0x8391", VA = "0x8391", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06003340 RID: 13120 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A27")]
		public RepeatedField<RestrictionInfo> Restrictions
		{
			[Token(Token = "0x6003340")]
			[Address(RVA = "0x8392", Offset = "0x8392", VA = "0x8392", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06003341 RID: 13121 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A28")]
		public RepeatedField<RewardInfo> Rewards
		{
			[Token(Token = "0x6003341")]
			[Address(RVA = "0x8393", Offset = "0x8393", VA = "0x8393", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06003342 RID: 13122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A29")]
		public string LargeIconAssetId
		{
			[Token(Token = "0x6003342")]
			[Address(RVA = "0x8394", Offset = "0x8394", VA = "0x8394", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06003343 RID: 13123 RVA: 0x0000A728 File Offset: 0x00008928
		[Token(Token = "0x17000A2A")]
		public IQuest.QuestType Type
		{
			[Token(Token = "0x6003343")]
			[Address(RVA = "0x8395", Offset = "0x8395", VA = "0x8395", Slot = "24")]
			get
			{
				return IQuest.QuestType.Default;
			}
		}

		// Token: 0x04001BFE RID: 7166
		[Token(Token = "0x4001BFE")]
		[FieldOffset(Offset = "0x8")]
		private ProtoGetQuestsAns.Types.UserQuest _quest;

		// Token: 0x04001BFF RID: 7167
		[Token(Token = "0x4001BFF")]
		[FieldOffset(Offset = "0xC")]
		private float _approximateProgress;
	}
}
