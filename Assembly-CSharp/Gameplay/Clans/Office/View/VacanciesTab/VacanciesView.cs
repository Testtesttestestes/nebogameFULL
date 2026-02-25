using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UI;
using UI.Elements.Filters.GenericFilter;
using UI.Elements.RatingElements.SubRatings;
using UI.Toggle;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.VacanciesTab
{
	// Token: 0x02000A09 RID: 2569
	[Token(Token = "0x2000A09")]
	public class VacanciesView : MonoBehaviour
	{
		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06003D02 RID: 15618 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C09")]
		public SubRatingsList SubRatings
		{
			[Token(Token = "0x6003D02")]
			[Address(RVA = "0x8BC2", Offset = "0x8BC2", VA = "0x8BC2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06003D03 RID: 15619 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C0A")]
		public GenericFilterView FilterView
		{
			[Token(Token = "0x6003D03")]
			[Address(RVA = "0x8BC3", Offset = "0x8BC3", VA = "0x8BC3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06003D04 RID: 15620 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C0B")]
		public ClanVacancyInfoBox ClanInfoBox
		{
			[Token(Token = "0x6003D04")]
			[Address(RVA = "0x8BC4", Offset = "0x8BC4", VA = "0x8BC4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06003D05 RID: 15621 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C0C")]
		public SearchInput SearchInput
		{
			[Token(Token = "0x6003D05")]
			[Address(RVA = "0x8BC5", Offset = "0x8BC5", VA = "0x8BC5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06003D06 RID: 15622 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C0D")]
		public GreenToggle AvailableFilter
		{
			[Token(Token = "0x6003D06")]
			[Address(RVA = "0x8BC6", Offset = "0x8BC6", VA = "0x8BC6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06003D07 RID: 15623 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C0E")]
		public Button SearchButton
		{
			[Token(Token = "0x6003D07")]
			[Address(RVA = "0x8BC7", Offset = "0x8BC7", VA = "0x8BC7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06003D08 RID: 15624 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C0F")]
		public Button ResetButton
		{
			[Token(Token = "0x6003D08")]
			[Address(RVA = "0x8BC8", Offset = "0x8BC8", VA = "0x8BC8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06003D09 RID: 15625 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C10")]
		public RequestedClanListElement RequestedClan
		{
			[Token(Token = "0x6003D09")]
			[Address(RVA = "0x8BC9", Offset = "0x8BC9", VA = "0x8BC9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06003D0A RID: 15626 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C11")]
		public Button InfoButton
		{
			[Token(Token = "0x6003D0A")]
			[Address(RVA = "0x8BCA", Offset = "0x8BCA", VA = "0x8BCA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06003D0B RID: 15627 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003D0C RID: 15628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C12")]
		public Action MoreItemsAfterNeededEvent
		{
			[Token(Token = "0x6003D0B")]
			[Address(RVA = "0x8BCB", Offset = "0x8BCB", VA = "0x8BCB")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D0C")]
			[Address(RVA = "0x8BCC", Offset = "0x8BCC", VA = "0x8BCC")]
			set
			{
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06003D0D RID: 15629 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003D0E RID: 15630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C13")]
		public Action MoreItemsBeforeNeededEvent
		{
			[Token(Token = "0x6003D0D")]
			[Address(RVA = "0x8BCD", Offset = "0x8BCD", VA = "0x8BCD")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D0E")]
			[Address(RVA = "0x8BCE", Offset = "0x8BCE", VA = "0x8BCE")]
			set
			{
			}
		}

		// Token: 0x06003D0F RID: 15631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D0F")]
		[Address(RVA = "0x8BCF", Offset = "0x8BCF", VA = "0x8BCF")]
		public void Init(IList<ClanInRatingListElement.ClanInRatingListElementArgs> items)
		{
		}

		// Token: 0x06003D10 RID: 15632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D10")]
		[Address(RVA = "0x8BD0", Offset = "0x8BD0", VA = "0x8BD0")]
		public void Add(IList<ClanInRatingListElement.ClanInRatingListElementArgs> items, bool atEnd)
		{
		}

		// Token: 0x06003D11 RID: 15633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D11")]
		[Address(RVA = "0x8BD1", Offset = "0x8BD1", VA = "0x8BD1")]
		public void Remove(int count, bool fromEnd)
		{
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D12")]
		[Address(RVA = "0x8BD2", Offset = "0x8BD2", VA = "0x8BD2")]
		public void SetScrollBounds(bool activateUpperBound, bool activateLowerBound)
		{
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D13")]
		[Address(RVA = "0x8BD3", Offset = "0x8BD3", VA = "0x8BD3")]
		public VacanciesView()
		{
		}

		// Token: 0x040021E0 RID: 8672
		[Token(Token = "0x40021E0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ClansInRatingsOSAView _osaView;

		// Token: 0x040021E1 RID: 8673
		[Token(Token = "0x40021E1")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SubRatingsList _subRatings;

		// Token: 0x040021E2 RID: 8674
		[Token(Token = "0x40021E2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GenericFilterView _filterView;

		// Token: 0x040021E3 RID: 8675
		[Token(Token = "0x40021E3")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ClanVacancyInfoBox _clanInfoBox;

		// Token: 0x040021E4 RID: 8676
		[Token(Token = "0x40021E4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GreenToggle _availableFilter;

		// Token: 0x040021E5 RID: 8677
		[Token(Token = "0x40021E5")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private SearchInput _searchInput;

		// Token: 0x040021E6 RID: 8678
		[Token(Token = "0x40021E6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _searchButton;

		// Token: 0x040021E7 RID: 8679
		[Token(Token = "0x40021E7")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _resetButton;

		// Token: 0x040021E8 RID: 8680
		[Token(Token = "0x40021E8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RequestedClanListElement _requestedClan;

		// Token: 0x040021E9 RID: 8681
		[Token(Token = "0x40021E9")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _infoButton;
	}
}
