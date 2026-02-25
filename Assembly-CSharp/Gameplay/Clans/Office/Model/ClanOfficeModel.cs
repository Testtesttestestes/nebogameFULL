using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers.Requirements;
using Gameplay.Clans.Office.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Clans;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Rating;
using UI.Elements.Filters.GenericFilter;
using UI.Elements.RatingElements.SubRatings;
using UI.Tabs;

namespace Gameplay.Clans.Office.Model
{
	// Token: 0x02000A46 RID: 2630
	[Token(Token = "0x2000A46")]
	public class ClanOfficeModel : AbstractModel
	{
		// Token: 0x06003E44 RID: 15940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E44")]
		[Address(RVA = "0x8D03", Offset = "0x8D03", VA = "0x8D03")]
		public ClanOfficeModel(UserData user)
		{
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06003E45 RID: 15941 RVA: 0x0000C498 File Offset: 0x0000A698
		// (set) Token: 0x06003E46 RID: 15942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C7B")]
		public uint MinPage
		{
			[Token(Token = "0x6003E45")]
			[Address(RVA = "0x8D04", Offset = "0x8D04", VA = "0x8D04")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6003E46")]
			[Address(RVA = "0x8D05", Offset = "0x8D05", VA = "0x8D05")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06003E47 RID: 15943 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
		// (set) Token: 0x06003E48 RID: 15944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C7C")]
		public uint MaxPage
		{
			[Token(Token = "0x6003E47")]
			[Address(RVA = "0x8D06", Offset = "0x8D06", VA = "0x8D06")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6003E48")]
			[Address(RVA = "0x8D07", Offset = "0x8D07", VA = "0x8D07")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06003E49 RID: 15945 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		[Token(Token = "0x17000C7D")]
		public bool PageDifferenceExceeded
		{
			[Token(Token = "0x6003E49")]
			[Address(RVA = "0x8D08", Offset = "0x8D08", VA = "0x8D08")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06003E4A RID: 15946 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C7E")]
		public FilterListElement.FilterData[] FilterDatas
		{
			[Token(Token = "0x6003E4A")]
			[Address(RVA = "0x8D09", Offset = "0x8D09", VA = "0x8D09")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06003E4B RID: 15947 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		// (set) Token: 0x06003E4C RID: 15948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C7F")]
		public ulong RequestedClanId
		{
			[Token(Token = "0x6003E4B")]
			[Address(RVA = "0x8D0A", Offset = "0x8D0A", VA = "0x8D0A")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6003E4C")]
			[Address(RVA = "0x8D0B", Offset = "0x8D0B", VA = "0x8D0B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06003E4D RID: 15949 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E4E RID: 15950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C80")]
		public ClanInRatingListElement.ClanInRatingListElementArgs RequestedClan
		{
			[Token(Token = "0x6003E4D")]
			[Address(RVA = "0x8D0C", Offset = "0x8D0C", VA = "0x8D0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E4E")]
			[Address(RVA = "0x8D0D", Offset = "0x8D0D", VA = "0x8D0D")]
			set
			{
			}
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E4F")]
		[Address(RVA = "0x8D0E", Offset = "0x8D0E", VA = "0x8D0E")]
		public TabBarItemData[] GetTabBarItemData()
		{
			return null;
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E50")]
		[Address(RVA = "0x8D0F", Offset = "0x8D0F", VA = "0x8D0F")]
		public void CreateClanVacancies(ProtoGetClanVacanciesListAns msg)
		{
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E51")]
		[Address(RVA = "0x8D10", Offset = "0x8D10", VA = "0x8D10")]
		public void AddClanList(ProtoGetClanVacanciesListAns msg)
		{
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E52")]
		[Address(RVA = "0x8D11", Offset = "0x8D11", VA = "0x8D11")]
		private ClanInRatingListElement.ClanInRatingListElementArgs ConstructArgs(ClanInRating clan, in int index, in int pageNumber)
		{
			return null;
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E53")]
		[Address(RVA = "0x8D12", Offset = "0x8D12", VA = "0x8D12")]
		private ClanInRatingListElement.ClanInRatingListElementArgs ConstructArgs(ClanInRating clan)
		{
			return null;
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E54")]
		[Address(RVA = "0x8D13", Offset = "0x8D13", VA = "0x8D13")]
		private List<SubRatingListElementArgs> CreateSubRatingListElementArgs()
		{
			return null;
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E55")]
		[Address(RVA = "0x8D14", Offset = "0x8D14", VA = "0x8D14")]
		private FilterListElement.FilterData[] CreateFilterDatas()
		{
			return null;
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E56")]
		[Address(RVA = "0x8D15", Offset = "0x8D15", VA = "0x8D15")]
		[CompilerGenerated]
		private FilterListElement.FilterData <CreateFilterDatas>g__CreateData|40_0(RatingPeriods period)
		{
			return null;
		}

		// Token: 0x040022FB RID: 8955
		[Token(Token = "0x40022FB")]
		public const int MIN_PAGE_DIFFERENCE = 2;

		// Token: 0x040022FC RID: 8956
		[Token(Token = "0x40022FC")]
		[FieldOffset(Offset = "0xC")]
		public readonly Dictionaries Dict;

		// Token: 0x040022FD RID: 8957
		[Token(Token = "0x40022FD")]
		[FieldOffset(Offset = "0x10")]
		public readonly string HonorAssetId;

		// Token: 0x040022FE RID: 8958
		[Token(Token = "0x40022FE")]
		[FieldOffset(Offset = "0x14")]
		public readonly Dictionary<uint, IList<ClanInRatingListElement.ClanInRatingListElementArgs>> ClanVacanciesByPage;

		// Token: 0x040022FF RID: 8959
		[Token(Token = "0x40022FF")]
		[FieldOffset(Offset = "0x18")]
		public readonly SubRatingsListArgs SubRatingsArgs;

		// Token: 0x04002300 RID: 8960
		[Token(Token = "0x4002300")]
		[FieldOffset(Offset = "0x1C")]
		public readonly int PageSize;

		// Token: 0x04002301 RID: 8961
		[Token(Token = "0x4002301")]
		[FieldOffset(Offset = "0x20")]
		public readonly List<RestrictionInfo> Restrictions;

		// Token: 0x04002302 RID: 8962
		[Token(Token = "0x4002302")]
		[FieldOffset(Offset = "0x24")]
		public readonly RequirementsInfoProvider ClanRestrictions;

		// Token: 0x04002303 RID: 8963
		[Token(Token = "0x4002303")]
		[FieldOffset(Offset = "0x28")]
		public readonly RequirementsInfoProvider FractionRestrictions;

		// Token: 0x04002304 RID: 8964
		[Token(Token = "0x4002304")]
		[FieldOffset(Offset = "0x2C")]
		public readonly ResourceSet ClanCreationCost;

		// Token: 0x04002305 RID: 8965
		[Token(Token = "0x4002305")]
		[FieldOffset(Offset = "0x30")]
		public readonly ResourceSet FractionClanCreationCost;

		// Token: 0x04002306 RID: 8966
		[Token(Token = "0x4002306")]
		[FieldOffset(Offset = "0x34")]
		private FilterListElement.FilterData[] _filterDatas;

		// Token: 0x04002307 RID: 8967
		[Token(Token = "0x4002307")]
		[FieldOffset(Offset = "0x38")]
		private ClanInRatingListElement.ClanInRatingListElementArgs _requestedClan;

		// Token: 0x02000A47 RID: 2631
		// (Invoke) Token: 0x06003E58 RID: 15960
		[Token(Token = "0x2000A47")]
		public delegate void ClanPageRemoved(int count, bool fromEnd);
	}
}
