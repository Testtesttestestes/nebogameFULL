using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Rating.Events;
using Gameplay.Rating.Model;
using Gameplay.Rating.View;
using Gameplay.ThemeDuel.Model;
using Gameplay.ThemeDuel.View.RatingTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Dic;
using Protocol.Rating;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.ThemeDuel.Controller
{
	// Token: 0x020004EF RID: 1263
	[Token(Token = "0x20004EF")]
	public class ThemeDuelRatingViewMediator : AbstractViewMediator<ThemeDuelRatingModel, Gameplay.Rating.Events.RatingEvents, ThemeDuelRatingController, RatingView>, IHideableMediator
	{
		// Token: 0x06001E1A RID: 7706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E1A")]
		[Address(RVA = "0x6F98", Offset = "0x6F98", VA = "0x6F98", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x00006468 File Offset: 0x00004668
		// (set) Token: 0x06001E1C RID: 7708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000579")]
		private RatingPeriods SelectedRatingPeriod
		{
			[Token(Token = "0x6001E1B")]
			[Address(RVA = "0x6F99", Offset = "0x6F99", VA = "0x6F99")]
			[CompilerGenerated]
			get
			{
				return RatingPeriods.UnknownRatingPeriod;
			}
			[Token(Token = "0x6001E1C")]
			[Address(RVA = "0x6F9A", Offset = "0x6F9A", VA = "0x6F9A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E1D")]
		[Address(RVA = "0x6F9B", Offset = "0x6F9B", VA = "0x6F9B")]
		public ThemeDuelRatingViewMediator(ThemeDuelRatingModel model, Gameplay.Rating.Events.RatingEvents events, ThemeDuelRatingController controller)
		{
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E1E")]
		[Address(RVA = "0x6F9C", Offset = "0x6F9C", VA = "0x6F9C")]
		private void Init()
		{
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E1F")]
		[Address(RVA = "0x6F9D", Offset = "0x6F9D", VA = "0x6F9D")]
		private void PeriodFilterSelectedEventHandler(object data)
		{
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E20")]
		[Address(RVA = "0x6F9E", Offset = "0x6F9E", VA = "0x6F9E")]
		private void SelectPeriodSilent(object data)
		{
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E21")]
		[Address(RVA = "0x6F9F", Offset = "0x6F9F", VA = "0x6F9F")]
		private void SubRatingsClickedEventHandler(SubFilterListElement element)
		{
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E22")]
		[Address(RVA = "0x6FA0", Offset = "0x6FA0", VA = "0x6FA0")]
		private void SelectSubRatingSilent(SubFilterListElement element)
		{
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E23")]
		[Address(RVA = "0x6FA1", Offset = "0x6FA1", VA = "0x6FA1")]
		private void RequestRatings()
		{
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E24")]
		[Address(RVA = "0x6FA2", Offset = "0x6FA2", VA = "0x6FA2")]
		private void RewardsToggleChangedEventHandler(bool active)
		{
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E25")]
		[Address(RVA = "0x6FA3", Offset = "0x6FA3", VA = "0x6FA3")]
		private void UpdateRewards()
		{
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001E26")]
		[Address(RVA = "0x6FA4", Offset = "0x6FA4", VA = "0x6FA4")]
		private RatingRewardsView.RatingRewardArgs[] GetRewards(uint ratingType, RatingPeriods ratingPeriod, IEnumerable<RatingPrizeDic> ratingPrizes)
		{
			return null;
		}

		// Token: 0x1700057A RID: 1402
		// (set) Token: 0x06001E27 RID: 7719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057A")]
		public override RatingView View
		{
			[Token(Token = "0x6001E27")]
			[Address(RVA = "0x6FA5", Offset = "0x6FA5", VA = "0x6FA5", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E28")]
		[Address(RVA = "0x6FA6", Offset = "0x6FA6", VA = "0x6FA6")]
		private void ExtraFilterToggleChangedEventHandler(bool enabled)
		{
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E29")]
		[Address(RVA = "0x6FA7", Offset = "0x6FA7", VA = "0x6FA7")]
		private void PeriodFilterToggleChangedEventHandler(bool enabled)
		{
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E2A")]
		[Address(RVA = "0x6FA8", Offset = "0x6FA8", VA = "0x6FA8")]
		private void ExtraFilterDeselectedEventHandler()
		{
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E2B")]
		[Address(RVA = "0x6FA9", Offset = "0x6FA9", VA = "0x6FA9")]
		private void ExtraFilterSelectedEventHandler(object data)
		{
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E2C")]
		[Address(RVA = "0x6FAA", Offset = "0x6FAA", VA = "0x6FAA")]
		private void UpdateOsaView(RatingRequestDto ratingRequest)
		{
		}

		// Token: 0x1700057B RID: 1403
		// (set) Token: 0x06001E2D RID: 7725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057B")]
		public override Gameplay.Rating.Events.RatingEvents Events
		{
			[Token(Token = "0x6001E2D")]
			[Address(RVA = "0x6FAB", Offset = "0x6FAB", VA = "0x6FAB", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E2E")]
		[Address(RVA = "0x6FAC", Offset = "0x6FAC", VA = "0x6FAC")]
		private void UserRatingsRequestedEventHandler(RatingRequestDto ratingRequest)
		{
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E2F")]
		[Address(RVA = "0x6FAD", Offset = "0x6FAD", VA = "0x6FAD")]
		private void InitPeriodFilters()
		{
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001E30")]
		[Address(RVA = "0x6FAE", Offset = "0x6FAE", VA = "0x6FAE")]
		private SubFilterListElement InitSubRatingsFilters(uint ratingType)
		{
			return null;
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E31")]
		[Address(RVA = "0x6FAF", Offset = "0x6FAF", VA = "0x6FAF")]
		private void InitExtraFilters()
		{
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E32")]
		[Address(RVA = "0x6FB0", Offset = "0x6FB0", VA = "0x6FB0")]
		private void HandleRewardsToggleChanged(bool active)
		{
		}

		// Token: 0x0400106A RID: 4202
		[Token(Token = "0x400106A")]
		[FieldOffset(Offset = "0x1C")]
		private SubFilterListElement _selectedSubFilter;

		// Token: 0x0400106B RID: 4203
		[Token(Token = "0x400106B")]
		[FieldOffset(Offset = "0x20")]
		private CultDic _cultDic;
	}
}
