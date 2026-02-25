using System;
using System.Collections.Generic;
using Gameplay.Rating.Events;
using Gameplay.Rating.Model;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.Rating.Control
{
	// Token: 0x02000598 RID: 1432
	[Token(Token = "0x2000598")]
	public class CultsRatingViewMediator : BaseRatingViewMediator
	{
		// Token: 0x06002252 RID: 8786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002252")]
		[Address(RVA = "0x73A9", Offset = "0x73A9", VA = "0x73A9")]
		public CultsRatingViewMediator(RatingModel model, RatingEvents events, RatingController controller, RatingKindTypeDic.Types.RatingKindType kindType, uint ratingType)
		{
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06002253 RID: 8787 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000647")]
		protected override Action<RatingRequestDto> RequestRatingsAction
		{
			[Token(Token = "0x6002253")]
			[Address(RVA = "0x73AA", Offset = "0x73AA", VA = "0x73AA", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000648")]
		protected override IList<RatingPrizeDic> RatingPrizes
		{
			[Token(Token = "0x6002254")]
			[Address(RVA = "0x73AB", Offset = "0x73AB", VA = "0x73AB", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (set) Token: 0x06002255 RID: 8789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000649")]
		public override RatingWindow View
		{
			[Token(Token = "0x6002255")]
			[Address(RVA = "0x73AC", Offset = "0x73AC", VA = "0x73AC", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002256")]
		[Address(RVA = "0x73AD", Offset = "0x73AD", VA = "0x73AD")]
		private void ResetView()
		{
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002257")]
		[Address(RVA = "0x73AE", Offset = "0x73AE", VA = "0x73AE")]
		private void SetupView()
		{
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002258")]
		[Address(RVA = "0x73AF", Offset = "0x73AF", VA = "0x73AF", Slot = "28")]
		protected override void OnRatingsDataReceivingCompleteEvent(RatingRequestDto ratingRequest)
		{
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002259")]
		[Address(RVA = "0x73B0", Offset = "0x73B0", VA = "0x73B0", Slot = "22")]
		protected override void InitPeriodFilters()
		{
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600225A")]
		[Address(RVA = "0x73B1", Offset = "0x73B1", VA = "0x73B1", Slot = "23")]
		protected override SubFilterListElement InitSubRatingsFilters(uint ratingType)
		{
			return null;
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600225B")]
		[Address(RVA = "0x73B2", Offset = "0x73B2", VA = "0x73B2", Slot = "21")]
		protected override void InitExtraFilters()
		{
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600225C")]
		[Address(RVA = "0x73B3", Offset = "0x73B3", VA = "0x73B3", Slot = "24")]
		protected override void SelectSubRatings(SubFilterListElement element)
		{
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600225D")]
		[Address(RVA = "0x73B4", Offset = "0x73B4", VA = "0x73B4", Slot = "27")]
		protected override void HandleRewardsToggleChanged(bool active)
		{
		}
	}
}
