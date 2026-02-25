using System;
using AssetContent;
using Gameplay.World.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x02000309 RID: 777
	[Token(Token = "0x2000309")]
	[Serializable]
	public class ClanInRatingViewElements
	{
		// Token: 0x06001222 RID: 4642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001222")]
		[Address(RVA = "0x641D", Offset = "0x641D", VA = "0x641D")]
		public void AssignAssets(string title, string place, string clanCultIconAssetId, string leagueBannerAssetId, string leagueIconAssetId)
		{
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001223")]
		[Address(RVA = "0x641E", Offset = "0x641E", VA = "0x641E")]
		public void AssignAssets(ClanData clanData, string place)
		{
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001224")]
		[Address(RVA = "0x641F", Offset = "0x641F", VA = "0x641F")]
		public ClanInRatingViewElements()
		{
		}

		// Token: 0x04000988 RID: 2440
		[Token(Token = "0x4000988")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000989 RID: 2441
		[Token(Token = "0x4000989")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private TextMeshProUGUI _place;

		// Token: 0x0400098A RID: 2442
		[Token(Token = "0x400098A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameImage _cultIcon;

		// Token: 0x0400098B RID: 2443
		[Token(Token = "0x400098B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameImage _leagueBanner;

		// Token: 0x0400098C RID: 2444
		[Token(Token = "0x400098C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameImage _leagueIcon;

		// Token: 0x0400098D RID: 2445
		[Token(Token = "0x400098D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameObject _restrictionsIndicator;
	}
}
