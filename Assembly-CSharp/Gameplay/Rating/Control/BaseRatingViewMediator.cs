using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Rating.Events;
using Gameplay.Rating.Model;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Rating;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.Rating.Control
{
	// Token: 0x02000592 RID: 1426
	[Token(Token = "0x2000592")]
	public abstract class BaseRatingViewMediator : AbstractViewMediator<RatingModel, Gameplay.Rating.Events.RatingEvents, RatingController, RatingWindow>
	{
		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x0600221B RID: 8731 RVA: 0x00006C30 File Offset: 0x00004E30
		// (set) Token: 0x0600221C RID: 8732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063E")]
		protected uint SelectedRatingType
		{
			[Token(Token = "0x600221B")]
			[Address(RVA = "0x737A", Offset = "0x737A", VA = "0x737A")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600221C")]
			[Address(RVA = "0x737B", Offset = "0x737B", VA = "0x737B")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x0600221D RID: 8733 RVA: 0x00006C48 File Offset: 0x00004E48
		// (set) Token: 0x0600221E RID: 8734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063F")]
		private protected RatingPeriods SelectedRatingPeriod
		{
			[Token(Token = "0x600221D")]
			[Address(RVA = "0x737C", Offset = "0x737C", VA = "0x737C")]
			[CompilerGenerated]
			protected get
			{
				return RatingPeriods.UnknownRatingPeriod;
			}
			[Token(Token = "0x600221E")]
			[Address(RVA = "0x737D", Offset = "0x737D", VA = "0x737D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600221F")]
		[Address(RVA = "0x737E", Offset = "0x737E", VA = "0x737E")]
		protected BaseRatingViewMediator(RatingModel model, Gameplay.Rating.Events.RatingEvents events, RatingController controller, RatingKindTypeDic.Types.RatingKindType kindType, uint ratingType)
		{
		}

		// Token: 0x17000640 RID: 1600
		// (set) Token: 0x06002220 RID: 8736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000640")]
		public override RatingWindow View
		{
			[Token(Token = "0x6002220")]
			[Address(RVA = "0x737F", Offset = "0x737F", VA = "0x737F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002221")]
		[Address(RVA = "0x7380", Offset = "0x7380", VA = "0x7380")]
		private void ResetView()
		{
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002222")]
		[Address(RVA = "0x7381", Offset = "0x7381", VA = "0x7381")]
		private void SetupView()
		{
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06002235 RID: 8757 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002223 RID: 8739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000641")]
		public sealed override Gameplay.Rating.Events.RatingEvents Events
		{
			[Token(Token = "0x6002235")]
			[Address(RVA = "0x738C", Offset = "0x738C", VA = "0x738C", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002223")]
			[Address(RVA = "0x7382", Offset = "0x7382", VA = "0x7382", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002224")]
		[Address(RVA = "0x7383", Offset = "0x7383", VA = "0x7383")]
		private void HandleRatingsDataReceivingCompleteEvent(RatingRequestDto ratingRequest)
		{
		}

		// Token: 0x06002225 RID: 8741
		[Token(Token = "0x6002225")]
		protected abstract void InitExtraFilters();

		// Token: 0x06002226 RID: 8742
		[Token(Token = "0x6002226")]
		protected abstract void InitPeriodFilters();

		// Token: 0x06002227 RID: 8743
		[Token(Token = "0x6002227")]
		protected abstract SubFilterListElement InitSubRatingsFilters(uint ratingType);

		// Token: 0x06002228 RID: 8744
		[Token(Token = "0x6002228")]
		protected abstract void SelectSubRatings(SubFilterListElement element);

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06002229 RID: 8745
		[Token(Token = "0x17000642")]
		protected abstract Action<RatingRequestDto> RequestRatingsAction { [Token(Token = "0x6002229")] get; }

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x0600222A RID: 8746
		[Token(Token = "0x17000643")]
		protected abstract IList<RatingPrizeDic> RatingPrizes { [Token(Token = "0x600222A")] get; }

		// Token: 0x0600222B RID: 8747
		[Token(Token = "0x600222B")]
		protected abstract void HandleRewardsToggleChanged(bool active);

		// Token: 0x0600222C RID: 8748
		[Token(Token = "0x600222C")]
		protected abstract void OnRatingsDataReceivingCompleteEvent(RatingRequestDto ratingRequest);

		// Token: 0x0600222D RID: 8749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600222D")]
		[Address(RVA = "0x7384", Offset = "0x7384", VA = "0x7384")]
		private void PeriodFilterSelectedEventHandler(object data)
		{
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600222E")]
		[Address(RVA = "0x7385", Offset = "0x7385", VA = "0x7385")]
		private void SelectPeriodSilent(object data)
		{
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600222F")]
		[Address(RVA = "0x7386", Offset = "0x7386", VA = "0x7386")]
		private void SubRatingsClickedEventHandler(SubFilterListElement element)
		{
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002230")]
		[Address(RVA = "0x7387", Offset = "0x7387", VA = "0x7387")]
		private void SelectSubRatingSilent(SubFilterListElement element)
		{
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002231")]
		[Address(RVA = "0x7388", Offset = "0x7388", VA = "0x7388")]
		private void RequestRatings(RatingRequestDto ratingRequest)
		{
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002232")]
		[Address(RVA = "0x7389", Offset = "0x7389", VA = "0x7389")]
		private void RewardsToggleChangedEventHandler(bool active)
		{
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002233")]
		[Address(RVA = "0x738A", Offset = "0x738A", VA = "0x738A")]
		private void UpdateRewards()
		{
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002234")]
		[Address(RVA = "0x738B", Offset = "0x738B", VA = "0x738B")]
		private RatingRewardsView.RatingRewardArgs[] GetRewards(uint ratingType, RatingPeriods ratingPeriod, IEnumerable<RatingPrizeDic> ratingPrizes)
		{
			return null;
		}

		// Token: 0x040012C5 RID: 4805
		[Token(Token = "0x40012C5")]
		[FieldOffset(Offset = "0x18")]
		protected readonly RatingKindTypeDic.Types.RatingKindType RatingKindType;

		// Token: 0x040012C8 RID: 4808
		[Token(Token = "0x40012C8")]
		[FieldOffset(Offset = "0x24")]
		private SubFilterListElement _selectedSubFilter;
	}
}
