using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x020002F7 RID: 759
	[Token(Token = "0x20002F7")]
	public class ClanRatingsView : MonoBehaviour
	{
		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002B1")]
		public BacktimeViewUGUI BacktimeView
		{
			[Token(Token = "0x60011EB")]
			[Address(RVA = "0x63E6", Offset = "0x63E6", VA = "0x63E6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002B2")]
		public TextMeshProUGUI SeasonStatus
		{
			[Token(Token = "0x60011EC")]
			[Address(RVA = "0x63E7", Offset = "0x63E7", VA = "0x63E7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002B3")]
		public ClanSeasonRatingsListElement MyClanRatings
		{
			[Token(Token = "0x60011ED")]
			[Address(RVA = "0x63E8", Offset = "0x63E8", VA = "0x63E8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002B4")]
		public GameObject NoClanLabel
		{
			[Token(Token = "0x60011EE")]
			[Address(RVA = "0x63E9", Offset = "0x63E9", VA = "0x63E9")]
			get
			{
				return null;
			}
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011EF")]
		[Address(RVA = "0x63EA", Offset = "0x63EA", VA = "0x63EA")]
		public void InitCategories(IEnumerable<SortCategoryListElement.SortCategoryListElementArgs> args)
		{
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F0")]
		[Address(RVA = "0x63EB", Offset = "0x63EB", VA = "0x63EB")]
		public void Init(IList<ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs> args)
		{
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F1")]
		[Address(RVA = "0x63EC", Offset = "0x63EC", VA = "0x63EC")]
		public ClanRatingsView()
		{
		}

		// Token: 0x0400095A RID: 2394
		[Token(Token = "0x400095A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x0400095B RID: 2395
		[Token(Token = "0x400095B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _seasonStatus;

		// Token: 0x0400095C RID: 2396
		[Token(Token = "0x400095C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ClanSeasonRatingsOSAView _osaView;

		// Token: 0x0400095D RID: 2397
		[Token(Token = "0x400095D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private SortCategoryTable _categories;

		// Token: 0x0400095E RID: 2398
		[Token(Token = "0x400095E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ClanSeasonRatingsListElement _myClanRating;

		// Token: 0x0400095F RID: 2399
		[Token(Token = "0x400095F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameObject _noClanLabel;
	}
}
