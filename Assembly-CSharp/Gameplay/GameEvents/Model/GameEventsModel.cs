using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Core.GameTime;
using Gameplay.GameEvents.Model.Tags;
using Gameplay.GameEvents.Model.Tags.Repo;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Events;

namespace Gameplay.GameEvents.Model
{
	// Token: 0x02000793 RID: 1939
	[Token(Token = "0x2000793")]
	public class GameEventsModel : AbstractModel
	{
		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06002E17 RID: 11799 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E18 RID: 11800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008DE")]
		public IGame Game
		{
			[Token(Token = "0x6002E17")]
			[Address(RVA = "0x7E94", Offset = "0x7E94", VA = "0x7E94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E18")]
			[Address(RVA = "0x7E95", Offset = "0x7E95", VA = "0x7E95")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06002E19 RID: 11801 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008DF")]
		public Dictionary<ulong, GameEventData> Events
		{
			[Token(Token = "0x6002E19")]
			[Address(RVA = "0x7E96", Offset = "0x7E96", VA = "0x7E96")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06002E1A RID: 11802 RVA: 0x00008E08 File Offset: 0x00007008
		// (set) Token: 0x06002E1B RID: 11803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E0")]
		public bool IsListEventsViewShown
		{
			[Token(Token = "0x6002E1A")]
			[Address(RVA = "0x7E97", Offset = "0x7E97", VA = "0x7E97")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E1B")]
			[Address(RVA = "0x7E98", Offset = "0x7E98", VA = "0x7E98")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06002E1C RID: 11804 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E1D RID: 11805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E1")]
		public GameEventData CurrentReadEvent
		{
			[Token(Token = "0x6002E1C")]
			[Address(RVA = "0x7E99", Offset = "0x7E99", VA = "0x7E99")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E1D")]
			[Address(RVA = "0x7E9A", Offset = "0x7E9A", VA = "0x7E9A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06002E1E RID: 11806 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E1F RID: 11807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E2")]
		public EventCategoriesDic DefaultCategory
		{
			[Token(Token = "0x6002E1E")]
			[Address(RVA = "0x7E9B", Offset = "0x7E9B", VA = "0x7E9B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E1F")]
			[Address(RVA = "0x7E9C", Offset = "0x7E9C", VA = "0x7E9C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06002E20 RID: 11808 RVA: 0x00008E20 File Offset: 0x00007020
		[Token(Token = "0x170008E3")]
		public int TotalNotViewedEventCount
		{
			[Token(Token = "0x6002E20")]
			[Address(RVA = "0x7E9D", Offset = "0x7E9D", VA = "0x7E9D")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x00008E38 File Offset: 0x00007038
		[Token(Token = "0x6002E21")]
		[Address(RVA = "0x7E9E", Offset = "0x7E9E", VA = "0x7E9E")]
		public int GetNotViewedEventCount(EventCategoriesDic.Types.Category category)
		{
			return 0;
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E22")]
		[Address(RVA = "0x7E9F", Offset = "0x7E9F", VA = "0x7E9F")]
		public void SetNotViewedEventCount(EventCategoriesDic.Types.Category category, int value)
		{
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06002E23 RID: 11811 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008E4")]
		public IGameAudio GameAudio
		{
			[Token(Token = "0x6002E23")]
			[Address(RVA = "0x7EA0", Offset = "0x7EA0", VA = "0x7EA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06002E24 RID: 11812 RVA: 0x00008E50 File Offset: 0x00007050
		// (set) Token: 0x06002E25 RID: 11813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E5")]
		public float? ExpirationScheduleThreshold
		{
			[Token(Token = "0x6002E24")]
			[Address(RVA = "0x7EA1", Offset = "0x7EA1", VA = "0x7EA1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E25")]
			[Address(RVA = "0x7EA2", Offset = "0x7EA2", VA = "0x7EA2")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E26")]
		[Address(RVA = "0x7EA3", Offset = "0x7EA3", VA = "0x7EA3", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E27")]
		[Address(RVA = "0x7EA4", Offset = "0x7EA4", VA = "0x7EA4")]
		public GameEventsModel(IGame game, ISourceTagFactoriesRepository sourceTagsRepository, IMetaTagFactoriesRepository metaTagRepository, ICurrentTimeProvider currentTimeProvider, UserData user)
		{
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002E28")]
		[Address(RVA = "0x1AC5", Offset = "0x1AC5", VA = "0x1AC5")]
		public GameEventData GetEvent(ProtoGetEventsListAns.Types.EventInfo eventInfo)
		{
			return null;
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002E29")]
		[Address(RVA = "0x7EA5", Offset = "0x7EA5", VA = "0x7EA5")]
		public List<GameEventData> GetEvents(EventCategoriesDic category)
		{
			return null;
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002E2A")]
		[Address(RVA = "0x7EA6", Offset = "0x7EA6", VA = "0x7EA6")]
		public EventCategoriesDic GetCategory(EventCategoriesDic.Types.Category id)
		{
			return null;
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x00008E68 File Offset: 0x00007068
		[Token(Token = "0x6002E2B")]
		[Address(RVA = "0x7EA7", Offset = "0x7EA7", VA = "0x7EA7")]
		private int ComparisonEvents(GameEventData x, GameEventData y)
		{
			return 0;
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x00008E80 File Offset: 0x00007080
		[Token(Token = "0x6002E2C")]
		[Address(RVA = "0x7EA8", Offset = "0x7EA8", VA = "0x7EA8")]
		private int ComparisonArchivedEvents(GameEventData x, GameEventData y)
		{
			return 0;
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002E2D")]
		[Address(RVA = "0x7EA9", Offset = "0x7EA9", VA = "0x7EA9")]
		public GameEventData AddEvent(ProtoGetEventsListAns.Types.EventInfo evtInfo)
		{
			return null;
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E2E")]
		[Address(RVA = "0x7EAA", Offset = "0x7EAA", VA = "0x7EAA")]
		public void RemoveEvent(ulong id)
		{
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E2F")]
		[Address(RVA = "0x7EAB", Offset = "0x7EAB", VA = "0x7EAB")]
		public void RemoveEvent(GameEventData evt)
		{
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E30")]
		[Address(RVA = "0x7EAC", Offset = "0x7EAC", VA = "0x7EAC")]
		public void ResetCacheByCategory(uint catId)
		{
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E31")]
		[Address(RVA = "0x7EAD", Offset = "0x7EAD", VA = "0x7EAD")]
		public static void FillEventTags(List<AbstractTag> tags, ProtoGetEventsListAns.Types.EventInfo eventInfo)
		{
		}

		// Token: 0x0400194A RID: 6474
		[Token(Token = "0x400194A")]
		[FieldOffset(Offset = "0x10")]
		public List<EventCategoriesDic> AvailableCategories;

		// Token: 0x0400194B RID: 6475
		[Token(Token = "0x400194B")]
		[FieldOffset(Offset = "0x14")]
		public readonly Dictionary<ulong, UserData> SourcesUsers;

		// Token: 0x0400194C RID: 6476
		[Token(Token = "0x400194C")]
		[FieldOffset(Offset = "0x18")]
		public readonly Dictionary<ulong, ClanShortInfo> SourcesClans;

		// Token: 0x0400194D RID: 6477
		[Token(Token = "0x400194D")]
		[FieldOffset(Offset = "0x1C")]
		public readonly ICurrentTimeProvider CurrentTimeProvider;

		// Token: 0x0400194E RID: 6478
		[Token(Token = "0x400194E")]
		[FieldOffset(Offset = "0x20")]
		private readonly ISourceTagFactoriesRepository _sourceTagsRepository;

		// Token: 0x0400194F RID: 6479
		[Token(Token = "0x400194F")]
		[FieldOffset(Offset = "0x24")]
		private readonly IMetaTagFactoriesRepository _metaTagRepository;

		// Token: 0x04001950 RID: 6480
		[Token(Token = "0x4001950")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<ulong, GameEventData> _events;

		// Token: 0x04001951 RID: 6481
		[Token(Token = "0x4001951")]
		[FieldOffset(Offset = "0x2C")]
		private readonly Dictionary<EventCategoriesDic.Types.Category, int> _notViewedEventCountByCategory;

		// Token: 0x04001956 RID: 6486
		[Token(Token = "0x4001956")]
		[FieldOffset(Offset = "0x44")]
		public EventCategoriesDic ArchiveCategoryDic;

		// Token: 0x04001957 RID: 6487
		[Token(Token = "0x4001957")]
		[FieldOffset(Offset = "0x48")]
		public readonly List<GameEventData> EventsTheActionWhichRequestCloseWindow;

		// Token: 0x04001958 RID: 6488
		[Token(Token = "0x4001958")]
		[FieldOffset(Offset = "0x4C")]
		private Dictionary<uint, List<GameEventData>> _eventsByCatsCache;
	}
}
