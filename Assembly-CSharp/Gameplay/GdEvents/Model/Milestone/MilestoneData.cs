using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Collections.Model.Factories;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.GdEvents.Model.Milestone
{
	// Token: 0x02000757 RID: 1879
	[Token(Token = "0x2000757")]
	public class MilestoneData : IDisposable
	{
		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06002CCF RID: 11471 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CD0 RID: 11472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A4")]
		public GdEventData Owner
		{
			[Token(Token = "0x6002CCF")]
			[Address(RVA = "0x7D55", Offset = "0x7D55", VA = "0x7D55")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CD0")]
			[Address(RVA = "0x7D56", Offset = "0x7D56", VA = "0x7D56")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06002CD1 RID: 11473 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CD2 RID: 11474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A5")]
		public ICollectionDataFactory CollectionDataFactory
		{
			[Token(Token = "0x6002CD1")]
			[Address(RVA = "0x7D57", Offset = "0x7D57", VA = "0x7D57")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CD2")]
			[Address(RVA = "0x7D58", Offset = "0x7D58", VA = "0x7D58")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06002CD3 RID: 11475 RVA: 0x000088F8 File Offset: 0x00006AF8
		// (set) Token: 0x06002CD4 RID: 11476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A6")]
		public bool Selected
		{
			[Token(Token = "0x6002CD3")]
			[Address(RVA = "0x7D59", Offset = "0x7D59", VA = "0x7D59")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002CD4")]
			[Address(RVA = "0x7D5A", Offset = "0x7D5A", VA = "0x7D5A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CD5")]
		[Address(RVA = "0x7D5B", Offset = "0x7D5B", VA = "0x7D5B", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CD6")]
		[Address(RVA = "0x7D5C", Offset = "0x7D5C", VA = "0x7D5C")]
		public MilestoneData(GdEventData evt, GameEventDic.Types.Milestone milestoneDic, ICollectionDataFactory collectionDataFactory)
		{
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x00008910 File Offset: 0x00006B10
		[Token(Token = "0x6002CD7")]
		[Address(RVA = "0x7D5D", Offset = "0x7D5D", VA = "0x7D5D")]
		public int GetContentStageCount()
		{
			return 0;
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002CD8")]
		[Address(RVA = "0x7D5E", Offset = "0x7D5E", VA = "0x7D5E")]
		public List<ActivityGroupData> GetActivities(IDictProvider dictProvider)
		{
			return null;
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x00008928 File Offset: 0x00006B28
		[Token(Token = "0x6002CD9")]
		[Address(RVA = "0x7D5F", Offset = "0x7D5F", VA = "0x7D5F")]
		public bool TryGetArtikuls(IDictProvider dictProvider, out StageContentData<ArtikulData> artikuls)
		{
			return default(bool);
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x00008940 File Offset: 0x00006B40
		[Token(Token = "0x6002CDA")]
		[Address(RVA = "0x7D60", Offset = "0x7D60", VA = "0x7D60")]
		public bool TryGetMedals(IDictProvider dictProvider, out StageContentData<MedalDicWrapper> medals)
		{
			return default(bool);
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x00008958 File Offset: 0x00006B58
		[Token(Token = "0x6002CDB")]
		[Address(RVA = "0x7D61", Offset = "0x7D61", VA = "0x7D61")]
		public bool TryGetAvatars(IDictProvider dictProvider, out StageContentData<AprDicWrapper> avatars)
		{
			return default(bool);
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x00008970 File Offset: 0x00006B70
		[Token(Token = "0x6002CDC")]
		[Address(RVA = "0x7D62", Offset = "0x7D62", VA = "0x7D62")]
		public bool TryGetCollections(IDictProvider dictProvider, out StageContentData<CollectionData> collections)
		{
			return default(bool);
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x00008988 File Offset: 0x00006B88
		[Token(Token = "0x6002CDD")]
		[Address(RVA = "0x7D63", Offset = "0x7D63", VA = "0x7D63")]
		public bool TryGetMonster(IDictProvider dictProvider, out StageContentData<MonsterData> monsters)
		{
			return default(bool);
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x000089A0 File Offset: 0x00006BA0
		[Token(Token = "0x6002CDE")]
		[Address(RVA = "0x7D64", Offset = "0x7D64", VA = "0x7D64")]
		public bool TryGetGifts(IDictProvider dictProvider, SocialGiftDic defaultGiftDic, out StageContentData<SocialGiftDic> gifts)
		{
			return default(bool);
		}

		// Token: 0x0400189F RID: 6303
		[Token(Token = "0x400189F")]
		[FieldOffset(Offset = "0x8")]
		public readonly GameEventDic.Types.Milestone MilestoneDic;

		// Token: 0x040018A0 RID: 6304
		[Token(Token = "0x40018A0")]
		[FieldOffset(Offset = "0xC")]
		private StageContentData<ArtikulData> _artikuls;

		// Token: 0x040018A1 RID: 6305
		[Token(Token = "0x40018A1")]
		[FieldOffset(Offset = "0x10")]
		private StageContentData<MedalDicWrapper> _medals;

		// Token: 0x040018A2 RID: 6306
		[Token(Token = "0x40018A2")]
		[FieldOffset(Offset = "0x14")]
		private StageContentData<CollectionData> _collections;

		// Token: 0x040018A3 RID: 6307
		[Token(Token = "0x40018A3")]
		[FieldOffset(Offset = "0x18")]
		private StageContentData<MonsterData> _monsters;

		// Token: 0x040018A7 RID: 6311
		[Token(Token = "0x40018A7")]
		[FieldOffset(Offset = "0x28")]
		private List<ActivityGroupData> _activity;
	}
}
