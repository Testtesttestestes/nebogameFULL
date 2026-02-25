using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core.Data;
using Core.Dict;
using Gameplay.Clans.Model;
using Gameplay.Clans.Office.View;
using Gameplay.Clans.Office.View.ClanMembersTab;
using Il2CppDummyDll;
using MVC;
using Protocol.ClanIsle;
using Protocol.Clans;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Rating;
using UI.Elements.Filters.GenericFilter;
using UI.Elements.RatingElements.SubRatings;
using UI.Tabs;

namespace Gameplay.Clans.Office.Model
{
	// Token: 0x02000A42 RID: 2626
	[Token(Token = "0x2000A42")]
	public class ClanInfoModel : AbstractModel
	{
		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06003E22 RID: 15906 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C74")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6003E22")]
			[Address(RVA = "0x8CE1", Offset = "0x8CE1", VA = "0x8CE1")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003E23 RID: 15907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E23")]
		[Address(RVA = "0x8CE2", Offset = "0x8CE2", VA = "0x8CE2")]
		public ClanInfoModel(UserData user, ClansModel clansModel, ulong clanId, [Optional] ClanOfficeData clanOfficeData)
		{
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06003E24 RID: 15908 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E25 RID: 15909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C75")]
		public ClanOfficeData ClanOfficeData
		{
			[Token(Token = "0x6003E24")]
			[Address(RVA = "0x8CE3", Offset = "0x8CE3", VA = "0x8CE3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E25")]
			[Address(RVA = "0x8CE4", Offset = "0x8CE4", VA = "0x8CE4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06003E26 RID: 15910 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E27 RID: 15911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C76")]
		public List<ClanMemberListElement.ClanMemberListElementArgs> ClanMembers
		{
			[Token(Token = "0x6003E26")]
			[Address(RVA = "0x8CE5", Offset = "0x8CE5", VA = "0x8CE5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E27")]
			[Address(RVA = "0x8CE6", Offset = "0x8CE6", VA = "0x8CE6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06003E28 RID: 15912 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C77")]
		public FilterListElement.FilterData[] FilterDatas
		{
			[Token(Token = "0x6003E28")]
			[Address(RVA = "0x8CE7", Offset = "0x8CE7", VA = "0x8CE7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E29")]
		[Address(RVA = "0x8CE8", Offset = "0x8CE8", VA = "0x8CE8")]
		public void SetIsleInfo(ProtoGetIsleInfoAns.Types.ClanIsleInformation clanIsleInfo)
		{
		}

		// Token: 0x06003E2A RID: 15914 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E2A")]
		[Address(RVA = "0x8CE9", Offset = "0x8CE9", VA = "0x8CE9")]
		public TabBarItemData[] GetTabBarItemData()
		{
			return null;
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E2B")]
		[Address(RVA = "0x8CEA", Offset = "0x8CEA", VA = "0x8CEA")]
		public void PopulateMembers(IList<ProtoGetMembersListAns.Types.MemberInfo> members)
		{
		}

		// Token: 0x06003E2C RID: 15916 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E2C")]
		[Address(RVA = "0x8CEB", Offset = "0x8CEB", VA = "0x8CEB")]
		public ResourceSet GetAddVacancyPrice()
		{
			return null;
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E2D")]
		[Address(RVA = "0x8CEC", Offset = "0x8CEC", VA = "0x8CEC")]
		private ClanMemberListElement.ClanMemberListElementArgs ConstructArgs(ProtoGetMembersListAns.Types.MemberInfo memberInfo)
		{
			return null;
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E2E")]
		[Address(RVA = "0x8CED", Offset = "0x8CED", VA = "0x8CED")]
		private FilterListElement.FilterData[] CreateFilterDatas()
		{
			return null;
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E2F")]
		[Address(RVA = "0x8CEE", Offset = "0x8CEE", VA = "0x8CEE")]
		private List<SubRatingListElementArgs> CreateSubRatingListElementArgs()
		{
			return null;
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E30")]
		[Address(RVA = "0x8CEF", Offset = "0x8CEF", VA = "0x8CEF")]
		private SubFilterListElement.SubFilterData[] CreateUserRatingSubFilters()
		{
			return null;
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E31")]
		[Address(RVA = "0x8CF0", Offset = "0x8CF0", VA = "0x8CF0")]
		public ResourceSet GetJoinPrice()
		{
			return null;
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x0000C408 File Offset: 0x0000A608
		[Token(Token = "0x6003E32")]
		[Address(RVA = "0x8CF1", Offset = "0x8CF1", VA = "0x8CF1")]
		[CompilerGenerated]
		private ClanInfoWindow.State <.ctor>g__DetermineWindowState|9_0(ref ClanInfoModel.<>c__DisplayClass9_0 A_1)
		{
			return ClanInfoWindow.State.UNKNOWN_STATE;
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E33")]
		[Address(RVA = "0x8CF2", Offset = "0x8CF2", VA = "0x8CF2")]
		[CompilerGenerated]
		private FilterListElement.FilterData <CreateFilterDatas>g__CreateData|26_0(RatingPeriods period)
		{
			return null;
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E34")]
		[Address(RVA = "0x8CF3", Offset = "0x8CF3", VA = "0x8CF3")]
		[CompilerGenerated]
		internal static SubFilterListElement.SubFilterData <CreateUserRatingSubFilters>g__ConstructArgs|28_1(UserRatingKindDic dic)
		{
			return null;
		}

		// Token: 0x040022E6 RID: 8934
		[Token(Token = "0x40022E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private readonly IDictProvider _dictProvider;

		// Token: 0x040022E7 RID: 8935
		[Token(Token = "0x40022E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ulong ClanId;

		// Token: 0x040022E8 RID: 8936
		[Token(Token = "0x40022E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly SubRatingsListArgs SubRatingsArgs;

		// Token: 0x040022E9 RID: 8937
		[Token(Token = "0x40022E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public readonly SubFilterListElement.SubFilterData[] UserRatingSubFilters;

		// Token: 0x040022EA RID: 8938
		[Token(Token = "0x40022EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly ClanInfoWindow.State State;

		// Token: 0x040022EB RID: 8939
		[Token(Token = "0x40022EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly ClansModel ClansModel;

		// Token: 0x040022EC RID: 8940
		[Token(Token = "0x40022EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ZigguratLevelDic ZigguratLevelDic;

		// Token: 0x040022ED RID: 8941
		[Token(Token = "0x40022ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private FilterListElement.FilterData[] _filterDatas;
	}
}
