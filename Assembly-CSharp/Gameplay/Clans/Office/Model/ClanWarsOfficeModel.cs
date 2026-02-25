using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Gameplay.Clans.ClanWars.Model;
using Gameplay.Clans.Office.View.ClanWarsTab.ClanPoliticsTab;
using Gameplay.World.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.ClanWar;
using Protocol.Common;
using Protocol.Dic;
using UI.Elements.Filters.GenericFilter;
using UI.Tabs;

namespace Gameplay.Clans.Office.Model
{
	// Token: 0x02000A4C RID: 2636
	[Token(Token = "0x2000A4C")]
	public class ClanWarsOfficeModel : AbstractModel
	{
		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06003E6C RID: 15980 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C83")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6003E6C")]
			[Address(RVA = "0x8D2B", Offset = "0x8D2B", VA = "0x8D2B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06003E6D RID: 15981 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E6E RID: 15982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C84")]
		public ClanPolicyListElement.ClanPolicyListElementArgs MyClanArgs
		{
			[Token(Token = "0x6003E6D")]
			[Address(RVA = "0x8D2C", Offset = "0x8D2C", VA = "0x8D2C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E6E")]
			[Address(RVA = "0x8D2D", Offset = "0x8D2D", VA = "0x8D2D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06003E6F RID: 15983 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E70 RID: 15984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C85")]
		public ClanWarsModel ClanWarsModel
		{
			[Token(Token = "0x6003E6F")]
			[Address(RVA = "0x8D2E", Offset = "0x8D2E", VA = "0x8D2E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E70")]
			[Address(RVA = "0x8D2F", Offset = "0x8D2F", VA = "0x8D2F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06003E71 RID: 15985 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E72 RID: 15986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C86")]
		public ClanData ClanData
		{
			[Token(Token = "0x6003E71")]
			[Address(RVA = "0x8D30", Offset = "0x8D30", VA = "0x8D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E72")]
			[Address(RVA = "0x8D31", Offset = "0x8D31", VA = "0x8D31")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E73")]
		[Address(RVA = "0x8D32", Offset = "0x8D32", VA = "0x8D32")]
		public ClanWarsOfficeModel(UserData user, ClanWarsModel clanWarsModel)
		{
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E74")]
		[Address(RVA = "0x8D33", Offset = "0x8D33", VA = "0x8D33")]
		public void InitClanData(ClanData clanData)
		{
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E75")]
		[Address(RVA = "0x8D34", Offset = "0x8D34", VA = "0x8D34")]
		public TabBarItemData[] GetTabBarData()
		{
			return null;
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E76")]
		[Address(RVA = "0x8D35", Offset = "0x8D35", VA = "0x8D35")]
		public FilterListElement.FilterData[] GetFilterDatas()
		{
			return null;
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E77")]
		[Address(RVA = "0x8D36", Offset = "0x8D36", VA = "0x8D36")]
		public void SetBankDistribution(IList<ProtoGetSeasonBankDistributionAns.Types.BankDistributionInfo> bankDistribution)
		{
		}

		// Token: 0x06003E78 RID: 15992 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E78")]
		[Address(RVA = "0x8D37", Offset = "0x8D37", VA = "0x8D37")]
		public ResourceSet GetBankDistribution(uint leagueId, uint lowerBound)
		{
			return null;
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E79")]
		[Address(RVA = "0x8D38", Offset = "0x8D38", VA = "0x8D38")]
		public SeasonLeagueRewardsDic[] GetSeasonLeagueRewards(uint leagueId)
		{
			return null;
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E7A")]
		[Address(RVA = "0x8D39", Offset = "0x8D39", VA = "0x8D39")]
		public void CreateClanList(IList<ProtoRequestClanPolicyAns.Types.PolicyInfo> clansList)
		{
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E7B")]
		[Address(RVA = "0x8D3A", Offset = "0x8D3A", VA = "0x8D3A")]
		public void AddClansList(IList<ProtoRequestClanPolicyAns.Types.PolicyInfo> clansList)
		{
		}

		// Token: 0x06003E7C RID: 15996 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E7C")]
		[Address(RVA = "0x8D3B", Offset = "0x8D3B", VA = "0x8D3B")]
		private SubFilterListElement.SubFilterData[] CreateSubRatingListElementArgs()
		{
			return null;
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E7D")]
		[Address(RVA = "0x8D3C", Offset = "0x8D3C", VA = "0x8D3C")]
		private SubFilterListElement.SubFilterData ConstructArgs(ClanLeagueDic dic)
		{
			return null;
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E7E")]
		[Address(RVA = "0x8D3D", Offset = "0x8D3D", VA = "0x8D3D")]
		private ClanPolicyListElement.ClanPolicyListElementArgs ConstructArgs(ProtoRequestClanPolicyAns.Types.PolicyInfo policyInfo, in int index, in int prevCount)
		{
			return null;
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E7F")]
		[Address(RVA = "0x8D3E", Offset = "0x8D3E", VA = "0x8D3E")]
		[CompilerGenerated]
		internal static FilterListElement.FilterData <GetFilterDatas>g__CreateData|24_0(ClanWarsOfficeModel.ClanPolicyFilter filter, string title)
		{
			return null;
		}

		// Token: 0x04002318 RID: 8984
		[Token(Token = "0x4002318")]
		[FieldOffset(Offset = "0xC")]
		private readonly IDictProvider _dictProvider;

		// Token: 0x04002319 RID: 8985
		[Token(Token = "0x4002319")]
		[FieldOffset(Offset = "0x10")]
		public readonly string HonorAssetId;

		// Token: 0x0400231A RID: 8986
		[Token(Token = "0x400231A")]
		[FieldOffset(Offset = "0x14")]
		public readonly SubFilterListElement.SubFilterData[] SubRatingsData;

		// Token: 0x0400231B RID: 8987
		[Token(Token = "0x400231B")]
		[FieldOffset(Offset = "0x18")]
		public readonly Stack<IList<ClanPolicyListElement.ClanPolicyListElementArgs>> ArgsPagesStack;

		// Token: 0x0400231C RID: 8988
		[Token(Token = "0x400231C")]
		[FieldOffset(Offset = "0x1C")]
		private readonly Dictionary<uint, SeasonLeagueRewardsDic[]> _seasonLeagueRewardsByLeagueId;

		// Token: 0x0400231D RID: 8989
		[Token(Token = "0x400231D")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<uint, Dictionary<uint, ResourceSet>> _banksByLowerBoundByLeagueId;

		// Token: 0x0400231E RID: 8990
		[Token(Token = "0x400231E")]
		[FieldOffset(Offset = "0x24")]
		private readonly ResourceSet _zeroResource;

		// Token: 0x02000A4D RID: 2637
		[Token(Token = "0x2000A4D")]
		public class Policy
		{
			// Token: 0x06003E80 RID: 16000 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003E80")]
			[Address(RVA = "0x8D3F", Offset = "0x8D3F", VA = "0x8D3F")]
			public Policy()
			{
			}

			// Token: 0x04002322 RID: 8994
			[Token(Token = "0x4002322")]
			[FieldOffset(Offset = "0x8")]
			public ResourceSet AttackPrice;

			// Token: 0x04002323 RID: 8995
			[Token(Token = "0x4002323")]
			[FieldOffset(Offset = "0xC")]
			public int WarDeclarationError;

			// Token: 0x04002324 RID: 8996
			[Token(Token = "0x4002324")]
			[FieldOffset(Offset = "0x10")]
			public int WarWinRatingDelta;
		}

		// Token: 0x02000A4E RID: 2638
		[Token(Token = "0x2000A4E")]
		public enum ClanPolicyFilter
		{
			// Token: 0x04002326 RID: 8998
			[Token(Token = "0x4002326")]
			ALL,
			// Token: 0x04002327 RID: 8999
			[Token(Token = "0x4002327")]
			CLAN_WARS,
			// Token: 0x04002328 RID: 9000
			[Token(Token = "0x4002328")]
			CAN_ATTACK
		}
	}
}
