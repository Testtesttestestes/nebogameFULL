using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.DailyQuests;
using Protocol.Dic;
using Utils;

namespace Gameplay.DailyQuests.Model
{
	// Token: 0x02000879 RID: 2169
	[Token(Token = "0x2000879")]
	public class DailyQuestData : IDailyQuest, IQuest
	{
		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x060032EA RID: 13034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A08")]
		public DailyQuestsDic Dic
		{
			[Token(Token = "0x60032EA")]
			[Address(RVA = "0x833C", Offset = "0x833C", VA = "0x833C", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x060032EB RID: 13035 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A09")]
		public BackTime BackTime
		{
			[Token(Token = "0x60032EB")]
			[Address(RVA = "0x833D", Offset = "0x833D", VA = "0x833D", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x060032EC RID: 13036 RVA: 0x0000A458 File Offset: 0x00008658
		// (set) Token: 0x060032ED RID: 13037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A0A")]
		public bool IsCompleted
		{
			[Token(Token = "0x60032EC")]
			[Address(RVA = "0x833E", Offset = "0x833E", VA = "0x833E", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60032ED")]
			[Address(RVA = "0x833F", Offset = "0x833F", VA = "0x833F", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x060032EE RID: 13038 RVA: 0x0000A470 File Offset: 0x00008670
		// (set) Token: 0x060032EF RID: 13039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A0B")]
		public float ApproximateProgress
		{
			[Token(Token = "0x60032EE")]
			[Address(RVA = "0x8340", Offset = "0x8340", VA = "0x8340", Slot = "8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60032EF")]
			[Address(RVA = "0x8341", Offset = "0x8341", VA = "0x8341", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x1400016A RID: 362
		// (add) Token: 0x060032F0 RID: 13040 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060032F1 RID: 13041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400016A")]
		public event Action QuestChangedEvent
		{
			[Token(Token = "0x60032F0")]
			[Address(RVA = "0x8342", Offset = "0x8342", VA = "0x8342", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60032F1")]
			[Address(RVA = "0x8343", Offset = "0x8343", VA = "0x8343", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032F2")]
		[Address(RVA = "0x8344", Offset = "0x8344", VA = "0x8344")]
		public DailyQuestData(ProtoGetQuestsAns.Types.UserQuest quest, DailyQuestsDic dailyQuestsDic)
		{
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x060032F3 RID: 13043 RVA: 0x0000A488 File Offset: 0x00008688
		// (set) Token: 0x060032F4 RID: 13044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A0C")]
		public bool RewardTaken
		{
			[Token(Token = "0x60032F3")]
			[Address(RVA = "0x8345", Offset = "0x8345", VA = "0x8345", Slot = "12")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60032F4")]
			[Address(RVA = "0x8346", Offset = "0x8346", VA = "0x8346", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x060032F5 RID: 13045 RVA: 0x0000A4A0 File Offset: 0x000086A0
		[Token(Token = "0x17000A0D")]
		public uint Id
		{
			[Token(Token = "0x60032F5")]
			[Address(RVA = "0x8347", Offset = "0x8347", VA = "0x8347", Slot = "14")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x060032F6 RID: 13046 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A0E")]
		public string Description
		{
			[Token(Token = "0x60032F6")]
			[Address(RVA = "0x8348", Offset = "0x8348", VA = "0x8348", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x060032F7 RID: 13047 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A0F")]
		public string Title
		{
			[Token(Token = "0x60032F7")]
			[Address(RVA = "0x8349", Offset = "0x8349", VA = "0x8349", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x060032F8 RID: 13048 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A10")]
		public string IconAssetId
		{
			[Token(Token = "0x60032F8")]
			[Address(RVA = "0x834A", Offset = "0x834A", VA = "0x834A", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x060032F9 RID: 13049 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A11")]
		public string BackgroundAssetId
		{
			[Token(Token = "0x60032F9")]
			[Address(RVA = "0x834B", Offset = "0x834B", VA = "0x834B", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x060032FA RID: 13050 RVA: 0x0000A4B8 File Offset: 0x000086B8
		[Token(Token = "0x17000A12")]
		public uint CategoryId
		{
			[Token(Token = "0x60032FA")]
			[Address(RVA = "0x834C", Offset = "0x834C", VA = "0x834C", Slot = "19")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x060032FB RID: 13051 RVA: 0x0000A4D0 File Offset: 0x000086D0
		[Token(Token = "0x17000A13")]
		public uint SortOrder
		{
			[Token(Token = "0x60032FB")]
			[Address(RVA = "0x834D", Offset = "0x834D", VA = "0x834D", Slot = "20")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x060032FC RID: 13052 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A14")]
		public RepeatedField<RestrictionInfo> Restrictions
		{
			[Token(Token = "0x60032FC")]
			[Address(RVA = "0x834E", Offset = "0x834E", VA = "0x834E", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x060032FD RID: 13053 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A15")]
		public RepeatedField<RewardInfo> Rewards
		{
			[Token(Token = "0x60032FD")]
			[Address(RVA = "0x834F", Offset = "0x834F", VA = "0x834F", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x060032FE RID: 13054 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A16")]
		public string LargeIconAssetId
		{
			[Token(Token = "0x60032FE")]
			[Address(RVA = "0x8350", Offset = "0x8350", VA = "0x8350", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x060032FF RID: 13055 RVA: 0x0000A4E8 File Offset: 0x000086E8
		[Token(Token = "0x17000A17")]
		public IQuest.QuestType Type
		{
			[Token(Token = "0x60032FF")]
			[Address(RVA = "0x8351", Offset = "0x8351", VA = "0x8351", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return IQuest.QuestType.Default;
			}
		}

		// Token: 0x04001BE1 RID: 7137
		[Token(Token = "0x4001BE1")]
		[FieldOffset(Offset = "0x8")]
		private ProtoGetQuestsAns.Types.UserQuest _quest;

		// Token: 0x04001BE2 RID: 7138
		[Token(Token = "0x4001BE2")]
		[FieldOffset(Offset = "0xC")]
		private float _approximateProgress;
	}
}
