using System;
using Core.Data;
using Gameplay.UserInfo.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.Clans.Office.View.ClanWarsTab.ClanWarsRewardsTab
{
	// Token: 0x02000A18 RID: 2584
	[Token(Token = "0x2000A18")]
	public class CurrentLeagueInfo : MonoBehaviour
	{
		// Token: 0x06003D72 RID: 15730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D72")]
		[Address(RVA = "0x8C31", Offset = "0x8C31", VA = "0x8C31")]
		public void Init(ClanData clanData, string honorAssetId)
		{
		}

		// Token: 0x06003D73 RID: 15731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D73")]
		[Address(RVA = "0x8C32", Offset = "0x8C32", VA = "0x8C32")]
		public void UpdateLeagueInfo(ClanLeagueDic dic, RewardData[] rewards, string placesText)
		{
		}

		// Token: 0x06003D74 RID: 15732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D74")]
		[Address(RVA = "0x8C33", Offset = "0x8C33", VA = "0x8C33")]
		public CurrentLeagueInfo()
		{
		}

		// Token: 0x04002246 RID: 8774
		[Token(Token = "0x4002246")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002247 RID: 8775
		[Token(Token = "0x4002247")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RewardsRender _rewardsView;

		// Token: 0x04002248 RID: 8776
		[Token(Token = "0x4002248")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ClanLeagueBaseInfoView _baseLeagueInfo;

		// Token: 0x04002249 RID: 8777
		[Token(Token = "0x4002249")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _leagueName;

		// Token: 0x0400224A RID: 8778
		[Token(Token = "0x400224A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TitleIconValueBackground _honorRange;

		// Token: 0x0400224B RID: 8779
		[Token(Token = "0x400224B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _description;
	}
}
