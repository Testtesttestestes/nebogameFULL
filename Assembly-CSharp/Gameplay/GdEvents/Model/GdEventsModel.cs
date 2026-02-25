using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Core.Gameplay.Managers.GameActivityRouting;
using Core.Gameplay.Managers.Requirements;
using Core.GameTime;
using Gameplay.Collections.Model.Factories;
using Gameplay.GdEvents.Model.Categories;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.GdEvents.Model
{
	// Token: 0x02000750 RID: 1872
	[Token(Token = "0x2000750")]
	public class GdEventsModel : AbstractModel, ITimeOffsetProvider
	{
		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06002C9C RID: 11420 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C9D RID: 11421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000893")]
		public AbstractGdEventCatData MainCategory
		{
			[Token(Token = "0x6002C9C")]
			[Address(RVA = "0x7D29", Offset = "0x7D29", VA = "0x7D29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C9D")]
			[Address(RVA = "0x7D2A", Offset = "0x7D2A", VA = "0x7D2A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06002C9E RID: 11422 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C9F RID: 11423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000894")]
		public List<AbstractGdEventCatData> Categories
		{
			[Token(Token = "0x6002C9E")]
			[Address(RVA = "0x7D2B", Offset = "0x7D2B", VA = "0x7D2B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C9F")]
			[Address(RVA = "0x7D2C", Offset = "0x7D2C", VA = "0x7D2C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06002CA0 RID: 11424 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CA1 RID: 11425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000895")]
		public TriggerDic[] TriggersForDetectCompletions
		{
			[Token(Token = "0x6002CA0")]
			[Address(RVA = "0x7D2D", Offset = "0x7D2D", VA = "0x7D2D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CA1")]
			[Address(RVA = "0x7D2E", Offset = "0x7D2E", VA = "0x7D2E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06002CA2 RID: 11426 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CA3 RID: 11427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000896")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x6002CA2")]
			[Address(RVA = "0x7D2F", Offset = "0x7D2F", VA = "0x7D2F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CA3")]
			[Address(RVA = "0x7D30", Offset = "0x7D30", VA = "0x7D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06002CA4 RID: 11428 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CA5 RID: 11429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000897")]
		public ICurrentTimeProvider TimeProvider
		{
			[Token(Token = "0x6002CA4")]
			[Address(RVA = "0x7D31", Offset = "0x7D31", VA = "0x7D31")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CA5")]
			[Address(RVA = "0x7D32", Offset = "0x7D32", VA = "0x7D32")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06002CA6 RID: 11430 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CA7 RID: 11431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000898")]
		public IRequirementValidator RequirementValidator
		{
			[Token(Token = "0x6002CA6")]
			[Address(RVA = "0x7D33", Offset = "0x7D33", VA = "0x7D33")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CA7")]
			[Address(RVA = "0x7D34", Offset = "0x7D34", VA = "0x7D34")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06002CA8 RID: 11432 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CA9 RID: 11433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000899")]
		public ICollectionDataFactory CollectionDataFactory
		{
			[Token(Token = "0x6002CA8")]
			[Address(RVA = "0x7D35", Offset = "0x7D35", VA = "0x7D35")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CA9")]
			[Address(RVA = "0x7D36", Offset = "0x7D36", VA = "0x7D36")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06002CAA RID: 11434 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CAB RID: 11435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700089A")]
		public IRouter Router
		{
			[Token(Token = "0x6002CAA")]
			[Address(RVA = "0x7D37", Offset = "0x7D37", VA = "0x7D37")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CAB")]
			[Address(RVA = "0x7D38", Offset = "0x7D38", VA = "0x7D38")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06002CAC RID: 11436 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CAD RID: 11437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700089B")]
		public IRewardProvider RewardProvider
		{
			[Token(Token = "0x6002CAC")]
			[Address(RVA = "0x7D39", Offset = "0x7D39", VA = "0x7D39")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CAD")]
			[Address(RVA = "0x7D3A", Offset = "0x7D3A", VA = "0x7D3A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06002CAE RID: 11438 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CAF RID: 11439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700089C")]
		public GdEventIdsPrefs IdsPrefs
		{
			[Token(Token = "0x6002CAE")]
			[Address(RVA = "0x7D3B", Offset = "0x7D3B", VA = "0x7D3B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CAF")]
			[Address(RVA = "0x7D3C", Offset = "0x7D3C", VA = "0x7D3C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06002CB0 RID: 11440 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CB1 RID: 11441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700089D")]
		public EventTabs EventTabs
		{
			[Token(Token = "0x6002CB0")]
			[Address(RVA = "0x7D3D", Offset = "0x7D3D", VA = "0x7D3D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CB1")]
			[Address(RVA = "0x7D3E", Offset = "0x7D3E", VA = "0x7D3E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06002CB2 RID: 11442 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CB3 RID: 11443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700089E")]
		public SocialGiftDic DefaultGiftData
		{
			[Token(Token = "0x6002CB2")]
			[Address(RVA = "0x7D3F", Offset = "0x7D3F", VA = "0x7D3F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CB3")]
			[Address(RVA = "0x7D40", Offset = "0x7D40", VA = "0x7D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06002CB4 RID: 11444 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CB5 RID: 11445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700089F")]
		public IGame Game
		{
			[Token(Token = "0x6002CB4")]
			[Address(RVA = "0x7D41", Offset = "0x7D41", VA = "0x7D41")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CB5")]
			[Address(RVA = "0x7D42", Offset = "0x7D42", VA = "0x7D42")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06002CB6 RID: 11446 RVA: 0x00008880 File Offset: 0x00006A80
		[Token(Token = "0x170008A0")]
		public ulong Offset
		{
			[Token(Token = "0x6002CB6")]
			[Address(RVA = "0x7D43", Offset = "0x7D43", VA = "0x7D43", Slot = "6")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06002CB7 RID: 11447 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CB8 RID: 11448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A1")]
		public GdEventData CurrentEvent
		{
			[Token(Token = "0x6002CB7")]
			[Address(RVA = "0x7D44", Offset = "0x7D44", VA = "0x7D44")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CB8")]
			[Address(RVA = "0x7D45", Offset = "0x7D45", VA = "0x7D45")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CB9")]
		[Address(RVA = "0x7D46", Offset = "0x7D46", VA = "0x7D46", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CBA")]
		[Address(RVA = "0x7D47", Offset = "0x7D47", VA = "0x7D47")]
		public GdEventsModel(IGame game, IRouter router, ICollectionDataFactory collectionDataFactory, IRequirementValidator requirementValidator, ICurrentTimeProvider timeProvider, IDictProvider dictProvider, TriggerDic[] triggersForDetectCompletions, UserData user)
		{
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002CBB")]
		[Address(RVA = "0x7D48", Offset = "0x7D48", VA = "0x7D48")]
		public GdEventData GetEvent(GameEventDic dict)
		{
			return null;
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x00008898 File Offset: 0x00006A98
		[Token(Token = "0x6002CBC")]
		[Address(RVA = "0x7D49", Offset = "0x7D49", VA = "0x7D49")]
		public bool RemoveEvent(GameEventDic value)
		{
			return default(bool);
		}

		// Token: 0x04001885 RID: 6277
		[Token(Token = "0x4001885")]
		public const string GD_EVENTS_NOTVIEWED_IDS = "gd_events_notviewed_ids";

		// Token: 0x04001886 RID: 6278
		[Token(Token = "0x4001886")]
		public const string DEFAULT_EP_ICON_RES_KEY = "EVENT_LIBRARY";

		// Token: 0x04001894 RID: 6292
		[Token(Token = "0x4001894")]
		[FieldOffset(Offset = "0x40")]
		private TimerStrings _timerStrings;

		// Token: 0x04001895 RID: 6293
		[Token(Token = "0x4001895")]
		[FieldOffset(Offset = "0x44")]
		private Dictionary<uint, GdEventData> _events;

		// Token: 0x04001896 RID: 6294
		[Token(Token = "0x4001896")]
		[FieldOffset(Offset = "0x48")]
		private string _progressValueTemplate;
	}
}
