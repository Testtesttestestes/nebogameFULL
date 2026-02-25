using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x02000302 RID: 770
	[Token(Token = "0x2000302")]
	public class UserRatingsView : MonoBehaviour
	{
		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002B9")]
		public BacktimeViewUGUI BacktimeView
		{
			[Token(Token = "0x600120C")]
			[Address(RVA = "0x6407", Offset = "0x6407", VA = "0x6407")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002BA")]
		public TextMeshProUGUI SeasonStatus
		{
			[Token(Token = "0x600120D")]
			[Address(RVA = "0x6408", Offset = "0x6408", VA = "0x6408")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002BB")]
		public UserSeasonRatingsListElement MyUserRatings
		{
			[Token(Token = "0x600120E")]
			[Address(RVA = "0x6409", Offset = "0x6409", VA = "0x6409")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002BC")]
		public GameObject NoRatingLabel
		{
			[Token(Token = "0x600120F")]
			[Address(RVA = "0x640A", Offset = "0x640A", VA = "0x640A")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001210")]
		[Address(RVA = "0x640B", Offset = "0x640B", VA = "0x640B")]
		public void InitCategories(IEnumerable<SortCategoryListElement.SortCategoryListElementArgs> args)
		{
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001211")]
		[Address(RVA = "0x640C", Offset = "0x640C", VA = "0x640C")]
		public void Init(IList<UserSeasonRatingsListElement.UserSeasonRatingsListElementArgs> args)
		{
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001212")]
		[Address(RVA = "0x640D", Offset = "0x640D", VA = "0x640D")]
		public UserRatingsView()
		{
		}

		// Token: 0x04000977 RID: 2423
		[Token(Token = "0x4000977")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04000978 RID: 2424
		[Token(Token = "0x4000978")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _seasonStatus;

		// Token: 0x04000979 RID: 2425
		[Token(Token = "0x4000979")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UserSeasonRatingsOSAView _osaView;

		// Token: 0x0400097A RID: 2426
		[Token(Token = "0x400097A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private SortCategoryTable _categories;

		// Token: 0x0400097B RID: 2427
		[Token(Token = "0x400097B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UserSeasonRatingsListElement _myUserRating;

		// Token: 0x0400097C RID: 2428
		[Token(Token = "0x400097C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameObject _noRatingLabel;
	}
}
