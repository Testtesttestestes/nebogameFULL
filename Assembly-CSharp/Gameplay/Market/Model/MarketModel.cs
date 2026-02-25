using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Gameplay.Market.Model.Data;
using Gameplay.Market.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Shop;
using UI.Tabs;
using Utils;

namespace Gameplay.Market.Model
{
	// Token: 0x02000624 RID: 1572
	[Token(Token = "0x2000624")]
	public class MarketModel : AbstractModel
	{
		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06002621 RID: 9761 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700072C")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6002621")]
			[Address(RVA = "0x775F", Offset = "0x775F", VA = "0x775F")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06002622 RID: 9762 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002623 RID: 9763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700072D")]
		public List<MarketLotListElement.MarketLotListElementArgs> UserLots
		{
			[Token(Token = "0x6002622")]
			[Address(RVA = "0x7760", Offset = "0x7760", VA = "0x7760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002623")]
			[Address(RVA = "0x7761", Offset = "0x7761", VA = "0x7761")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06002624 RID: 9764 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002625 RID: 9765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700072E")]
		public List<MarketLotListElement.MarketLotListElementArgs> MarketOptions
		{
			[Token(Token = "0x6002624")]
			[Address(RVA = "0x7762", Offset = "0x7762", VA = "0x7762")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002625")]
			[Address(RVA = "0x7763", Offset = "0x7763", VA = "0x7763")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06002626 RID: 9766 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002627 RID: 9767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700072F")]
		public Dictionary<ulong, MarketLotListElement.MarketLotListElementArgs> UserLotsById
		{
			[Token(Token = "0x6002626")]
			[Address(RVA = "0x7764", Offset = "0x7764", VA = "0x7764")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002627")]
			[Address(RVA = "0x7765", Offset = "0x7765", VA = "0x7765")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06002628 RID: 9768 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002629 RID: 9769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000730")]
		public IList<MarketLotListElement.MarketLotListElementArgs> ExtraArtifactsResult
		{
			[Token(Token = "0x6002628")]
			[Address(RVA = "0x7766", Offset = "0x7766", VA = "0x7766")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002629")]
			[Address(RVA = "0x7767", Offset = "0x7767", VA = "0x7767")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600262A")]
		[Address(RVA = "0x7768", Offset = "0x7768", VA = "0x7768")]
		public MarketModel(UserData user)
		{
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x00007410 File Offset: 0x00005610
		[Token(Token = "0x600262B")]
		[Address(RVA = "0x7769", Offset = "0x7769", VA = "0x7769")]
		public bool ContainsInCache(ulong artId)
		{
			return default(bool);
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600262C")]
		[Address(RVA = "0x776A", Offset = "0x776A", VA = "0x776A")]
		public void EnableArtifactsFromCache(ulong artId)
		{
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600262D")]
		[Address(RVA = "0x776B", Offset = "0x776B", VA = "0x776B")]
		public void PopulateMarketArtifacts(ProtoGetMarketArtifactsAns artifacts)
		{
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600262E")]
		[Address(RVA = "0x776C", Offset = "0x776C", VA = "0x776C")]
		public void RemoveExpiredElements()
		{
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600262F")]
		[Address(RVA = "0x776D", Offset = "0x776D", VA = "0x776D")]
		public void AddScheduledElements()
		{
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x00007428 File Offset: 0x00005628
		[Token(Token = "0x6002630")]
		[Address(RVA = "0x776E", Offset = "0x776E", VA = "0x776E")]
		public bool RemoveStackSorted(out MarketModel.MarketOptionWithBacktime result)
		{
			return default(bool);
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x00007440 File Offset: 0x00005640
		[Token(Token = "0x6002631")]
		[Address(RVA = "0x776F", Offset = "0x776F", VA = "0x776F")]
		public bool RemoveAddStackSorted(out MarketModel.MarketOptionWithBacktime result)
		{
			return default(bool);
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002632")]
		[Address(RVA = "0x7770", Offset = "0x7770", VA = "0x7770")]
		public void CacheOtherArtifacts(ulong key, IList<ulong> list)
		{
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002633")]
		[Address(RVA = "0x7771", Offset = "0x7771", VA = "0x7771")]
		public IList<MarketLotListElement.MarketLotListElementArgs> GetOptionsLots(in MarketLotListElement.MarketLotListElementArgs targetItem, in IList<MarketLotListElement.MarketLotListElementArgs> availableLots)
		{
			return null;
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002634")]
		[Address(RVA = "0x7772", Offset = "0x7772", VA = "0x7772")]
		public IList<MarketLotListElement.MarketLotListElementArgs> GetSimilarArtifacts(in MarketLotListElement.MarketLotListElementArgs targetItem, in IList<MarketLotListElement.MarketLotListElementArgs> availableLots)
		{
			return null;
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002635")]
		[Address(RVA = "0x7773", Offset = "0x7773", VA = "0x7773")]
		public IList<MarketLotListElement.MarketLotListElementArgs> GetRandomOptionsArtifacts(in IList<MarketLotListElement.MarketLotListElementArgs> availableLots)
		{
			return null;
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002636")]
		[Address(RVA = "0x7774", Offset = "0x7774", VA = "0x7774")]
		public IEnumerable<MarketLotListElement.MarketLotListElementArgs> RemoveArtifacts(in IList<ulong> ids)
		{
			return null;
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002637")]
		[Address(RVA = "0x7775", Offset = "0x7775", VA = "0x7775")]
		public IEnumerable<MarketLotListElement.MarketLotListElementArgs> AddArtifacts(IList<UserArtifactWithMarketBacktimer> artifacts)
		{
			return null;
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002638")]
		[Address(RVA = "0x7776", Offset = "0x7776", VA = "0x7776")]
		private MarketLotListElement.MarketLotListElementArgs ConstructOptionLotData(MarketOptionsDic dic)
		{
			return null;
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002639")]
		[Address(RVA = "0x7777", Offset = "0x7777", VA = "0x7777")]
		private MarketLotListElement.MarketLotListElementArgs ConstructUserMarketLotData(UserArtifactWithMarketBacktimer userArtifact)
		{
			return null;
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600263A")]
		[Address(RVA = "0x7778", Offset = "0x7778", VA = "0x7778")]
		private MarketModel.MarketOptionWithBacktime ConstructMarketOptionWithBacktime(ProtoGetMarketArtifactsAns.Types.MarketOptionTimer optionTimer)
		{
			return null;
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x0600263B RID: 9787 RVA: 0x00007458 File Offset: 0x00005658
		[Token(Token = "0x17000731")]
		public ArtikulTypeFilters.Types.FilterType FilterType
		{
			[Token(Token = "0x600263B")]
			[Address(RVA = "0x7779", Offset = "0x7779", VA = "0x7779")]
			get
			{
				return ArtikulTypeFilters.Types.FilterType.UnknownFilterType;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x0600263C RID: 9788 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000732")]
		public Dictionary<uint, ArtikulTypeFilters> AllFilters
		{
			[Token(Token = "0x600263C")]
			[Address(RVA = "0x777A", Offset = "0x777A", VA = "0x777A")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600263D")]
		[Address(RVA = "0x777B", Offset = "0x777B", VA = "0x777B")]
		[CompilerGenerated]
		private void <PopulateMarketArtifacts>g__HandleOptionToExpire|28_2(ref MarketModel.<>c__DisplayClass28_0 A_1)
		{
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600263E")]
		[Address(RVA = "0x777C", Offset = "0x777C", VA = "0x777C")]
		[CompilerGenerated]
		private void <PopulateMarketArtifacts>g__HandleOptionsToAdd|28_3(ref MarketModel.<>c__DisplayClass28_0 A_1)
		{
		}

		// Token: 0x040014DD RID: 5341
		[Token(Token = "0x40014DD")]
		[FieldOffset(Offset = "0xC")]
		private readonly IDictProvider _dictProvider;

		// Token: 0x040014DE RID: 5342
		[Token(Token = "0x40014DE")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<ulong, IList<MarketLotListElement.MarketLotListElementArgs>> _cachedOtherArtifacts;

		// Token: 0x040014DF RID: 5343
		[Token(Token = "0x40014DF")]
		[FieldOffset(Offset = "0x14")]
		public readonly int MaxSimilarItemsCount;

		// Token: 0x040014E4 RID: 5348
		[Token(Token = "0x40014E4")]
		[FieldOffset(Offset = "0x28")]
		private Stack<MarketModel.MarketOptionWithBacktime> _removeStackSorted;

		// Token: 0x040014E5 RID: 5349
		[Token(Token = "0x40014E5")]
		[FieldOffset(Offset = "0x2C")]
		private Stack<MarketModel.MarketOptionWithBacktime> _addStackSorted;

		// Token: 0x040014E6 RID: 5350
		[Token(Token = "0x40014E6")]
		[FieldOffset(Offset = "0x30")]
		public readonly TabBarItemData<MarketLotData.DataType>[] TabBarData;

		// Token: 0x040014E7 RID: 5351
		[Token(Token = "0x40014E7")]
		[FieldOffset(Offset = "0x34")]
		public readonly TabBarItemData[] ExtraTabsData;

		// Token: 0x040014E8 RID: 5352
		[Token(Token = "0x40014E8")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<uint, ArtikulTypeFilters> _allFilters;

		// Token: 0x02000625 RID: 1573
		[Token(Token = "0x2000625")]
		public class MarketOptionWithBacktime
		{
			// Token: 0x06002640 RID: 9792 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002640")]
			[Address(RVA = "0x777E", Offset = "0x777E", VA = "0x777E")]
			public MarketOptionWithBacktime()
			{
			}

			// Token: 0x040014E9 RID: 5353
			[Token(Token = "0x40014E9")]
			[FieldOffset(Offset = "0x8")]
			public uint OptionId;

			// Token: 0x040014EA RID: 5354
			[Token(Token = "0x40014EA")]
			[FieldOffset(Offset = "0xC")]
			public BackTime StartBackTime;

			// Token: 0x040014EB RID: 5355
			[Token(Token = "0x40014EB")]
			[FieldOffset(Offset = "0x10")]
			public BackTime EndBackTime;
		}
	}
}
