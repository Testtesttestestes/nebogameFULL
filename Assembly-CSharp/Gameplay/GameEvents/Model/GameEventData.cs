using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Model.ActionsOnEvents;
using Gameplay.GameEvents.Model.Tags;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Events;

namespace Gameplay.GameEvents.Model
{
	// Token: 0x02000791 RID: 1937
	[Token(Token = "0x2000791")]
	public class GameEventData : IDisposable
	{
		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06002E06 RID: 11782 RVA: 0x00008D48 File Offset: 0x00006F48
		[Token(Token = "0x170008D7")]
		public bool IsRewardTaken
		{
			[Token(Token = "0x6002E06")]
			[Address(RVA = "0x7E84", Offset = "0x7E84", VA = "0x7E84")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06002E07 RID: 11783 RVA: 0x00008D60 File Offset: 0x00006F60
		[Token(Token = "0x170008D8")]
		public bool IsRead
		{
			[Token(Token = "0x6002E07")]
			[Address(RVA = "0x7E85", Offset = "0x7E85", VA = "0x7E85")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06002E08 RID: 11784 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E09 RID: 11785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D9")]
		public EventTypeDic EventTypeDic
		{
			[Token(Token = "0x6002E08")]
			[Address(RVA = "0x7E86", Offset = "0x7E86", VA = "0x7E86")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E09")]
			[Address(RVA = "0x7E87", Offset = "0x7E87", VA = "0x7E87")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E0A")]
		[Address(RVA = "0x7E88", Offset = "0x7E88", VA = "0x7E88", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E0B")]
		[Address(RVA = "0x7E89", Offset = "0x7E89", VA = "0x7E89")]
		public GameEventData(EventTypeDic eventTypeDic, ProtoGetEventsListAns.Types.EventInfo eventInfo, List<AbstractTag> tags)
		{
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06002E0C RID: 11788 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008DA")]
		public string Title
		{
			[Token(Token = "0x6002E0C")]
			[Address(RVA = "0x7E8A", Offset = "0x7E8A", VA = "0x7E8A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06002E0D RID: 11789 RVA: 0x00008D78 File Offset: 0x00006F78
		[Token(Token = "0x170008DB")]
		public bool ContainsArtifactRewards
		{
			[Token(Token = "0x6002E0D")]
			[Address(RVA = "0x1ACD", Offset = "0x1ACD", VA = "0x1ACD")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06002E0E RID: 11790 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E0F RID: 11791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008DC")]
		public AssetDic SoundAssetShowInReadView
		{
			[Token(Token = "0x6002E0E")]
			[Address(RVA = "0x7E8B", Offset = "0x7E8B", VA = "0x7E8B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E0F")]
			[Address(RVA = "0x7E8C", Offset = "0x7E8C", VA = "0x7E8C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x00008D90 File Offset: 0x00006F90
		[Token(Token = "0x6002E10")]
		[Address(RVA = "0x7E8D", Offset = "0x7E8D", VA = "0x7E8D")]
		public bool TryResetArtifactFromRewardCache(ArtifactInfo artifactInfo)
		{
			return default(bool);
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x00008DA8 File Offset: 0x00006FA8
		[Token(Token = "0x6002E11")]
		[Address(RVA = "0x7E8E", Offset = "0x7E8E", VA = "0x7E8E")]
		public bool TryGetInfoPageURL(out string url)
		{
			return default(bool);
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002E12")]
		[Address(RVA = "0x7E8F", Offset = "0x7E8F", VA = "0x7E8F")]
		public static string Parse(string text, GameEventData eventData, AbstractTag.TagViewHandler viewHandler)
		{
			return null;
		}

		// Token: 0x04001937 RID: 6455
		[Token(Token = "0x4001937")]
		[FieldOffset(Offset = "0x8")]
		public bool HasBeenViewed;

		// Token: 0x04001938 RID: 6456
		[Token(Token = "0x4001938")]
		[FieldOffset(Offset = "0xC")]
		public readonly string DateString;

		// Token: 0x04001939 RID: 6457
		[Token(Token = "0x4001939")]
		[FieldOffset(Offset = "0x10")]
		public GameEventData.GameEventBackground EventBackground;

		// Token: 0x0400193A RID: 6458
		[Token(Token = "0x400193A")]
		[FieldOffset(Offset = "0x14")]
		public int ViewedCount;

		// Token: 0x0400193B RID: 6459
		[Token(Token = "0x400193B")]
		[FieldOffset(Offset = "0x18")]
		public GameEventsModel Model;

		// Token: 0x0400193C RID: 6460
		[Token(Token = "0x400193C")]
		[FieldOffset(Offset = "0x1C")]
		public EventCategoriesDic Category;

		// Token: 0x0400193E RID: 6462
		[Token(Token = "0x400193E")]
		[FieldOffset(Offset = "0x24")]
		public ProtoGetEventsListAns.Types.EventInfo EventInfo;

		// Token: 0x0400193F RID: 6463
		[Token(Token = "0x400193F")]
		[FieldOffset(Offset = "0x28")]
		public List<AbstractTag> SourceTags;

		// Token: 0x04001940 RID: 6464
		[Token(Token = "0x4001940")]
		[FieldOffset(Offset = "0x2C")]
		public List<AbstractTag> Tags;

		// Token: 0x04001941 RID: 6465
		[Token(Token = "0x4001941")]
		[FieldOffset(Offset = "0x30")]
		public RepeatedField<ArtifactInfo> ArtifactsFromRewardCache;

		// Token: 0x04001942 RID: 6466
		[Token(Token = "0x4001942")]
		[FieldOffset(Offset = "0x34")]
		public List<AbstractActionOnEvent> ActionsOnEvent;

		// Token: 0x04001943 RID: 6467
		[Token(Token = "0x4001943")]
		[FieldOffset(Offset = "0x38")]
		private string _title;

		// Token: 0x02000792 RID: 1938
		[Token(Token = "0x2000792")]
		public class GameEventBackground
		{
			// Token: 0x170008DD RID: 2269
			// (get) Token: 0x06002E13 RID: 11795 RVA: 0x00008DC0 File Offset: 0x00006FC0
			[Token(Token = "0x170008DD")]
			public bool IsEmpty
			{
				[Token(Token = "0x6002E13")]
				[Address(RVA = "0x7E90", Offset = "0x7E90", VA = "0x7E90")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06002E14 RID: 11796 RVA: 0x00008DD8 File Offset: 0x00006FD8
			[Token(Token = "0x6002E14")]
			[Address(RVA = "0x7E91", Offset = "0x7E91", VA = "0x7E91")]
			public bool TryGetAssetId(out string eventBannerListAssetId, out string eventBannerAssetId)
			{
				return default(bool);
			}

			// Token: 0x06002E15 RID: 11797 RVA: 0x00008DF0 File Offset: 0x00006FF0
			[Token(Token = "0x6002E15")]
			[Address(RVA = "0x7E92", Offset = "0x7E92", VA = "0x7E92")]
			public bool TryGetAssetPath(out string eventBannerListAssetPath, out string eventBannerAssetPath)
			{
				return default(bool);
			}

			// Token: 0x06002E16 RID: 11798 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E16")]
			[Address(RVA = "0x7E93", Offset = "0x7E93", VA = "0x7E93")]
			public GameEventBackground()
			{
			}

			// Token: 0x04001945 RID: 6469
			[Token(Token = "0x4001945")]
			[FieldOffset(Offset = "0x8")]
			public string EventBannerPath;

			// Token: 0x04001946 RID: 6470
			[Token(Token = "0x4001946")]
			[FieldOffset(Offset = "0xC")]
			public string EventListBannerPath;

			// Token: 0x04001947 RID: 6471
			[Token(Token = "0x4001947")]
			[FieldOffset(Offset = "0x10")]
			public string EventBannerAssetId;

			// Token: 0x04001948 RID: 6472
			[Token(Token = "0x4001948")]
			[FieldOffset(Offset = "0x14")]
			public string EventListBannerAssetId;
		}
	}
}
