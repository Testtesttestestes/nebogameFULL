using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Gameplay.Clans.Office.View;
using Gameplay.Clans.Office.View.ClanResumesTab;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Rating;
using UI.Elements.Filters.GenericFilter;
using UI.Tabs;

namespace Gameplay.Rating.Model
{
	// Token: 0x0200058C RID: 1420
	[Token(Token = "0x200058C")]
	public class RatingModel : AbstractModel
	{
		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000636")]
		public FilterWithIconListElement.FilterWithIconData[] CultExtraFilterDatas
		{
			[Token(Token = "0x60021DF")]
			[Address(RVA = "0x733E", Offset = "0x733E", VA = "0x733E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060021E0 RID: 8672 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000637")]
		public FilterWithIconListElement.FilterWithIconData[] ClanCultExtraFilterDatas
		{
			[Token(Token = "0x60021E0")]
			[Address(RVA = "0x733F", Offset = "0x733F", VA = "0x733F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060021E1 RID: 8673 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000638")]
		public virtual FilterListElement.FilterData[] UserPeriodFilterDatas
		{
			[Token(Token = "0x60021E1")]
			[Address(RVA = "0x7340", Offset = "0x7340", VA = "0x7340", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060021E2 RID: 8674 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000639")]
		public FilterListElement.FilterData[] ClansPeriodFilterDatas
		{
			[Token(Token = "0x60021E2")]
			[Address(RVA = "0x7341", Offset = "0x7341", VA = "0x7341")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060021E3 RID: 8675 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700063A")]
		public FilterListElement.FilterData[] CultsPeriodFilterDatas
		{
			[Token(Token = "0x60021E3")]
			[Address(RVA = "0x7342", Offset = "0x7342", VA = "0x7342")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700063B")]
		public SubFilterListElement.SubFilterData[] UsersSubFilters
		{
			[Token(Token = "0x60021E4")]
			[Address(RVA = "0x7343", Offset = "0x7343", VA = "0x7343")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060021E5 RID: 8677 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700063C")]
		public SubFilterListElement.SubFilterData[] ClansSubFilters
		{
			[Token(Token = "0x60021E5")]
			[Address(RVA = "0x7344", Offset = "0x7344", VA = "0x7344")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060021E6 RID: 8678 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700063D")]
		public SubFilterListElement.SubFilterData[] CultsSubFilters
		{
			[Token(Token = "0x60021E6")]
			[Address(RVA = "0x7345", Offset = "0x7345", VA = "0x7345")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021E7")]
		[Address(RVA = "0x7346", Offset = "0x7346", VA = "0x7346")]
		public RatingModel(UserData user)
		{
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021E8")]
		[Address(RVA = "0x7347", Offset = "0x7347", VA = "0x7347")]
		public TabBarItemData[] GetTabBarData()
		{
			return null;
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021E9")]
		[Address(RVA = "0x7348", Offset = "0x7348", VA = "0x7348")]
		public string GetPlacesText(uint lowerBound, uint upperBound)
		{
			return null;
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021EA")]
		[Address(RVA = "0x7349", Offset = "0x7349", VA = "0x7349")]
		public UserInRatingListElement.UserInRatingListElementArgs GetMyUser(uint ratingType, RatingPeriods period)
		{
			return null;
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021EB")]
		[Address(RVA = "0x734A", Offset = "0x734A", VA = "0x734A")]
		public ClanInRatingListElement.ClanInRatingListElementArgs GetMyClan(uint ratingType, RatingPeriods period)
		{
			return null;
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021EC")]
		[Address(RVA = "0x734B", Offset = "0x734B", VA = "0x734B")]
		public UserInRatingListElement.UserInRatingListElementArgs[] GetUsers(uint ratingType, RatingPeriods period)
		{
			return null;
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021ED")]
		[Address(RVA = "0x734C", Offset = "0x734C", VA = "0x734C")]
		public ClanInRatingListElement.ClanInRatingListElementArgs[] GetClans(uint ratingType, RatingPeriods period)
		{
			return null;
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021EE")]
		[Address(RVA = "0x734D", Offset = "0x734D", VA = "0x734D")]
		public CultInRatingListElement.CultInRatingListElementArgs[] GetCults(uint ratingType, RatingPeriods period)
		{
			return null;
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x00006B28 File Offset: 0x00004D28
		[Token(Token = "0x60021EF")]
		[Address(RVA = "0x734E", Offset = "0x734E", VA = "0x734E")]
		public bool HasUserCache(uint ratingType, RatingPeriods period)
		{
			return default(bool);
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x00006B40 File Offset: 0x00004D40
		[Token(Token = "0x60021F0")]
		[Address(RVA = "0x734F", Offset = "0x734F", VA = "0x734F")]
		public bool HasClansCache(uint ratingType, RatingPeriods period)
		{
			return default(bool);
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x00006B58 File Offset: 0x00004D58
		[Token(Token = "0x60021F1")]
		[Address(RVA = "0x7350", Offset = "0x7350", VA = "0x7350")]
		public bool HasCultsCache(uint ratingType, RatingPeriods period)
		{
			return default(bool);
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021F2")]
		[Address(RVA = "0x7351", Offset = "0x7351", VA = "0x7351")]
		protected FilterListElement.FilterData[] CreatePeriodFilterDatas(params RatingPeriods[] periods)
		{
			return null;
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021F3")]
		[Address(RVA = "0x7352", Offset = "0x7352", VA = "0x7352")]
		private FilterWithIconListElement.FilterWithIconData[] CreateCultFilterDatas()
		{
			return null;
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021F4")]
		[Address(RVA = "0x7353", Offset = "0x7353", VA = "0x7353")]
		private FilterWithIconListElement.FilterWithIconData[] CreateClanCultFilterDatas()
		{
			return null;
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021F5")]
		[Address(RVA = "0x7354", Offset = "0x7354", VA = "0x7354")]
		private SubFilterListElement.SubFilterData[] CreateUserSubRatingListElementArgs()
		{
			return null;
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021F6")]
		[Address(RVA = "0x7355", Offset = "0x7355", VA = "0x7355")]
		private SubFilterListElement.SubFilterData[] CreateClanSubRatingListElementArgs()
		{
			return null;
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021F7")]
		[Address(RVA = "0x7356", Offset = "0x7356", VA = "0x7356")]
		private SubFilterListElement.SubFilterData[] CreateCultSubRatingListElementArgs()
		{
			return null;
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F8")]
		[Address(RVA = "0x7357", Offset = "0x7357", VA = "0x7357")]
		public void PopulateUsers(ProtoGetUsersRatingAns msg, uint ratingType, RatingPeriods period)
		{
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F9")]
		[Address(RVA = "0x7358", Offset = "0x7358", VA = "0x7358")]
		protected void DoPopulateUsers(UserInRatingListElement.UserInRatingListElementArgs[] usersInRatingArgs, uint ratingType, RatingPeriods period, double userRating, int userPlace)
		{
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021FA")]
		[Address(RVA = "0x7359", Offset = "0x7359", VA = "0x7359")]
		private UserInRatingListElement.UserInRatingListElementArgs ConstructArgs(UserInRating userInRating, in int index)
		{
			return null;
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021FB")]
		[Address(RVA = "0x735A", Offset = "0x735A", VA = "0x735A")]
		public void PopulateClans(ProtoGetClansRatingAns msg, uint ratingType, RatingPeriods period)
		{
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021FC")]
		[Address(RVA = "0x735B", Offset = "0x735B", VA = "0x735B")]
		public void PopulateCults(ProtoGetCultsRatingAns msg, uint ratingType, RatingPeriods period)
		{
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021FD")]
		[Address(RVA = "0x735C", Offset = "0x735C", VA = "0x735C")]
		[CompilerGenerated]
		private FilterListElement.FilterData <CreatePeriodFilterDatas>g__CreateData|42_0(RatingPeriods period)
		{
			return null;
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021FE")]
		[Address(RVA = "0x735D", Offset = "0x735D", VA = "0x735D")]
		[CompilerGenerated]
		internal static FilterWithIconListElement.FilterWithIconData <CreateCultFilterDatas>g__CreateData|43_0(CultDic cultDic)
		{
			return null;
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021FF")]
		[Address(RVA = "0x735E", Offset = "0x735E", VA = "0x735E")]
		[CompilerGenerated]
		private FilterWithIconListElement.FilterWithIconData <CreateClanCultFilterDatas>g__CreateData|44_0(ClanCultDic clanCultDic)
		{
			return null;
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002200")]
		[Address(RVA = "0x735F", Offset = "0x735F", VA = "0x735F")]
		[CompilerGenerated]
		internal static SubFilterListElement.SubFilterData <CreateUserSubRatingListElementArgs>g__ConstructArgs|45_2(UserRatingKindDic dic)
		{
			return null;
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002201")]
		[Address(RVA = "0x7360", Offset = "0x7360", VA = "0x7360")]
		[CompilerGenerated]
		internal static SubFilterListElement.SubFilterData <CreateClanSubRatingListElementArgs>g__ConstructArgs|46_2(ClanRatingKindDic dic)
		{
			return null;
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002202")]
		[Address(RVA = "0x7361", Offset = "0x7361", VA = "0x7361")]
		[CompilerGenerated]
		internal static SubFilterListElement.SubFilterData <CreateCultSubRatingListElementArgs>g__ConstructArgs|47_2(CultRatingKindDic dic)
		{
			return null;
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002205")]
		[Address(RVA = "0x7364", Offset = "0x7364", VA = "0x7364")]
		[CompilerGenerated]
		private ClanInRatingListElement.ClanInRatingListElementArgs <PopulateClans>g__ConstructArgs|51_1(ClanInRating clan, in int index)
		{
			return null;
		}

		// Token: 0x040012A0 RID: 4768
		[Token(Token = "0x40012A0")]
		[FieldOffset(Offset = "0xC")]
		public readonly Dictionaries Dict;

		// Token: 0x040012A1 RID: 4769
		[Token(Token = "0x40012A1")]
		[FieldOffset(Offset = "0x10")]
		protected readonly IUserCache _userCache;

		// Token: 0x040012A2 RID: 4770
		[Token(Token = "0x40012A2")]
		[FieldOffset(Offset = "0x14")]
		private readonly Dictionary<RatingPeriods, Dictionary<uint, UserInRatingListElement.UserInRatingListElementArgs[]>> _usersCache;

		// Token: 0x040012A3 RID: 4771
		[Token(Token = "0x40012A3")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<RatingPeriods, Dictionary<uint, ClanInRatingListElement.ClanInRatingListElementArgs[]>> _clansCache;

		// Token: 0x040012A4 RID: 4772
		[Token(Token = "0x40012A4")]
		[FieldOffset(Offset = "0x1C")]
		private readonly Dictionary<RatingPeriods, Dictionary<uint, CultInRatingListElement.CultInRatingListElementArgs[]>> _cultsCache;

		// Token: 0x040012A5 RID: 4773
		[Token(Token = "0x40012A5")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<RatingPeriods, Dictionary<uint, UserInRatingListElement.UserInRatingListElementArgs>> _myUserCache;

		// Token: 0x040012A6 RID: 4774
		[Token(Token = "0x40012A6")]
		[FieldOffset(Offset = "0x24")]
		private readonly Dictionary<RatingPeriods, Dictionary<uint, ClanInRatingListElement.ClanInRatingListElementArgs>> _myClanCache;

		// Token: 0x040012A7 RID: 4775
		[Token(Token = "0x40012A7")]
		[FieldOffset(Offset = "0x28")]
		private FilterWithIconListElement.FilterWithIconData[] _cultExtraFilterDatas;

		// Token: 0x040012A8 RID: 4776
		[Token(Token = "0x40012A8")]
		[FieldOffset(Offset = "0x2C")]
		private FilterWithIconListElement.FilterWithIconData[] _clanCultExtraFilterDatas;

		// Token: 0x040012A9 RID: 4777
		[Token(Token = "0x40012A9")]
		[FieldOffset(Offset = "0x30")]
		private FilterListElement.FilterData[] _usersFilterDatas;

		// Token: 0x040012AA RID: 4778
		[Token(Token = "0x40012AA")]
		[FieldOffset(Offset = "0x34")]
		private FilterListElement.FilterData[] _clansFilterDatas;

		// Token: 0x040012AB RID: 4779
		[Token(Token = "0x40012AB")]
		[FieldOffset(Offset = "0x38")]
		private FilterListElement.FilterData[] _cultsFilterDatas;

		// Token: 0x040012AC RID: 4780
		[Token(Token = "0x40012AC")]
		[FieldOffset(Offset = "0x3C")]
		private SubFilterListElement.SubFilterData[] _usersSubFilters;

		// Token: 0x040012AD RID: 4781
		[Token(Token = "0x40012AD")]
		[FieldOffset(Offset = "0x40")]
		private SubFilterListElement.SubFilterData[] _clansSubFilters;

		// Token: 0x040012AE RID: 4782
		[Token(Token = "0x40012AE")]
		[FieldOffset(Offset = "0x44")]
		private SubFilterListElement.SubFilterData[] _cultsSubFilters;
	}
}
