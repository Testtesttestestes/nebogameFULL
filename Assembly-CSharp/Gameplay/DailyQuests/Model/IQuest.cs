using System;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Common;

namespace Gameplay.DailyQuests.Model
{
	// Token: 0x02000884 RID: 2180
	[Token(Token = "0x2000884")]
	public interface IQuest
	{
		// Token: 0x1400016C RID: 364
		// (add) Token: 0x06003348 RID: 13128
		// (remove) Token: 0x06003349 RID: 13129
		[Token(Token = "0x1400016C")]
		event Action QuestChangedEvent;

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x0600334A RID: 13130
		// (set) Token: 0x0600334B RID: 13131
		[Token(Token = "0x17000A2F")]
		float ApproximateProgress { [Token(Token = "0x600334A")] get; [Token(Token = "0x600334B")] set; }

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x0600334C RID: 13132
		// (set) Token: 0x0600334D RID: 13133
		[Token(Token = "0x17000A30")]
		bool IsCompleted { [Token(Token = "0x600334C")] get; [Token(Token = "0x600334D")] set; }

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x0600334E RID: 13134
		// (set) Token: 0x0600334F RID: 13135
		[Token(Token = "0x17000A31")]
		bool RewardTaken { [Token(Token = "0x600334E")] get; [Token(Token = "0x600334F")] set; }

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06003350 RID: 13136
		[Token(Token = "0x17000A32")]
		uint Id { [Token(Token = "0x6003350")] get; }

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06003351 RID: 13137
		[Token(Token = "0x17000A33")]
		string Description { [Token(Token = "0x6003351")] get; }

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06003352 RID: 13138
		[Token(Token = "0x17000A34")]
		string Title { [Token(Token = "0x6003352")] get; }

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06003353 RID: 13139
		[Token(Token = "0x17000A35")]
		string IconAssetId { [Token(Token = "0x6003353")] get; }

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06003354 RID: 13140
		[Token(Token = "0x17000A36")]
		string BackgroundAssetId { [Token(Token = "0x6003354")] get; }

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06003355 RID: 13141
		[Token(Token = "0x17000A37")]
		uint CategoryId { [Token(Token = "0x6003355")] get; }

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06003356 RID: 13142
		[Token(Token = "0x17000A38")]
		uint SortOrder { [Token(Token = "0x6003356")] get; }

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06003357 RID: 13143
		[Token(Token = "0x17000A39")]
		RepeatedField<RestrictionInfo> Restrictions { [Token(Token = "0x6003357")] get; }

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06003358 RID: 13144
		[Token(Token = "0x17000A3A")]
		RepeatedField<RewardInfo> Rewards { [Token(Token = "0x6003358")] get; }

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06003359 RID: 13145
		[Token(Token = "0x17000A3B")]
		string LargeIconAssetId { [Token(Token = "0x6003359")] get; }

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x0600335A RID: 13146
		[Token(Token = "0x17000A3C")]
		IQuest.QuestType Type { [Token(Token = "0x600335A")] get; }

		// Token: 0x02000885 RID: 2181
		[Token(Token = "0x2000885")]
		public enum QuestType
		{
			// Token: 0x04001C04 RID: 7172
			[Token(Token = "0x4001C04")]
			Default,
			// Token: 0x04001C05 RID: 7173
			[Token(Token = "0x4001C05")]
			Ad
		}
	}
}
