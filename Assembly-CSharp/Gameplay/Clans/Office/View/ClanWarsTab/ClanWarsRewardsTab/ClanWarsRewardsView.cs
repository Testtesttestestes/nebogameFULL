using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using TMPro;
using UI;
using UI.Elements.Filters.GenericFilter;
using UnityEngine;
using Utils;

namespace Gameplay.Clans.Office.View.ClanWarsTab.ClanWarsRewardsTab
{
	// Token: 0x02000A17 RID: 2583
	[Token(Token = "0x2000A17")]
	public class ClanWarsRewardsView : MonoBehaviour
	{
		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06003D6A RID: 15722 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C34")]
		public GenericSubFilterView FilterView
		{
			[Token(Token = "0x6003D6A")]
			[Address(RVA = "0x8C2A", Offset = "0x8C2A", VA = "0x8C2A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06003D6B RID: 15723 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C35")]
		public CurrentLeagueInfo InfoBox
		{
			[Token(Token = "0x6003D6B")]
			[Address(RVA = "0x8C2B", Offset = "0x8C2B", VA = "0x8C2B")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003D6C")]
		[Address(RVA = "0x8C2C", Offset = "0x8C2C", VA = "0x8C2C")]
		public FilterListElement UpdateRewardsList(IList<SeasonLeagueRewardsDic> seasonRewards, Action<FilterListElement> listElementClickedEventHandler)
		{
			return null;
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D6D")]
		[Address(RVA = "0x8C2D", Offset = "0x8C2D", VA = "0x8C2D")]
		public void UpdateLeagueInfo(ClanLeagueDic leagueDic, SeasonLeagueRewardsDic dic, ResourceSet bank)
		{
		}

		// Token: 0x06003D6E RID: 15726 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003D6E")]
		[Address(RVA = "0x1C78", Offset = "0x1C78", VA = "0x1C78")]
		private string GetPlacesText(SeasonLeagueRewardsDic dic)
		{
			return null;
		}

		// Token: 0x06003D6F RID: 15727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D6F")]
		[Address(RVA = "0x8C2E", Offset = "0x8C2E", VA = "0x8C2E")]
		public void SetCurrentSeasonBacktime(BackTime backTime)
		{
		}

		// Token: 0x06003D70 RID: 15728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D70")]
		[Address(RVA = "0x8C2F", Offset = "0x8C2F", VA = "0x8C2F")]
		public void SetNextSeasonBacktime(BackTime backTime)
		{
		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D71")]
		[Address(RVA = "0x8C30", Offset = "0x8C30", VA = "0x8C30")]
		public ClanWarsRewardsView()
		{
		}

		// Token: 0x0400223F RID: 8767
		[Token(Token = "0x400223F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private FilterListElement _listElementPrefab;

		// Token: 0x04002240 RID: 8768
		[Token(Token = "0x4002240")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04002241 RID: 8769
		[Token(Token = "0x4002241")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GenericSubFilterView _filtersView;

		// Token: 0x04002242 RID: 8770
		[Token(Token = "0x4002242")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CurrentLeagueInfo _infoBox;

		// Token: 0x04002243 RID: 8771
		[Token(Token = "0x4002243")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BacktimeViewUGUI _timer;

		// Token: 0x04002244 RID: 8772
		[Token(Token = "0x4002244")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _timerDescription;

		// Token: 0x04002245 RID: 8773
		[Token(Token = "0x4002245")]
		[FieldOffset(Offset = "0x28")]
		private List<FilterListElement> _instances;
	}
}
