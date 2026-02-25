using System;
using System.Collections.Generic;
using Gameplay.VortexRating.View.GreatPrizesTab;
using Il2CppDummyDll;
using Protocol.Dic;
using UI;
using UI.Elements.Filters.GenericFilter;
using UI.Rewards;
using UI.Tabs;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.Rewards
{
	// Token: 0x020002F5 RID: 757
	[Token(Token = "0x20002F5")]
	public class SeasonRewardsView : MonoBehaviourWithStates<SeasonRewardsView.Tab>
	{
		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002AE")]
		public RewardsRender RewardsView
		{
			[Token(Token = "0x60011E6")]
			[Address(RVA = "0x63E1", Offset = "0x63E1", VA = "0x63E1")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002AF")]
		public GenericFilterView PeriodFilter
		{
			[Token(Token = "0x60011E7")]
			[Address(RVA = "0x63E2", Offset = "0x63E2", VA = "0x63E2")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002B0")]
		public TabBar TabBar
		{
			[Token(Token = "0x60011E8")]
			[Address(RVA = "0x63E3", Offset = "0x63E3", VA = "0x63E3")]
			get
			{
				return null;
			}
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011E9")]
		[Address(RVA = "0x63E4", Offset = "0x63E4", VA = "0x63E4")]
		public PrizeListElement[] Init(IList<RatingPrizeDic> prizes, string period)
		{
			return null;
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011EA")]
		[Address(RVA = "0x63E5", Offset = "0x63E5", VA = "0x63E5")]
		public SeasonRewardsView()
		{
		}

		// Token: 0x04000951 RID: 2385
		[Token(Token = "0x4000951")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private PrizeListElement _prizeListElementPrefab;

		// Token: 0x04000952 RID: 2386
		[Token(Token = "0x4000952")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04000953 RID: 2387
		[Token(Token = "0x4000953")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RewardsRender _rewardsView;

		// Token: 0x04000954 RID: 2388
		[Token(Token = "0x4000954")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GenericFilterView _periodFilter;

		// Token: 0x04000955 RID: 2389
		[Token(Token = "0x4000955")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x020002F6 RID: 758
		[Token(Token = "0x20002F6")]
		public enum Tab
		{
			// Token: 0x04000957 RID: 2391
			[Token(Token = "0x4000957")]
			UNKNOWN_TAB,
			// Token: 0x04000958 RID: 2392
			[Token(Token = "0x4000958")]
			USERS,
			// Token: 0x04000959 RID: 2393
			[Token(Token = "0x4000959")]
			CLANS
		}
	}
}
