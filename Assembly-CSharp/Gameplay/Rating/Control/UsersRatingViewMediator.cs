using System;
using System.Collections.Generic;
using Gameplay.Rating.Events;
using Gameplay.Rating.Model;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Dic;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.Rating.Control
{
	// Token: 0x0200059D RID: 1437
	[Token(Token = "0x200059D")]
	public class UsersRatingViewMediator : BaseRatingViewMediator
	{
		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06002278 RID: 8824 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700064B")]
		protected override Action<RatingRequestDto> RequestRatingsAction
		{
			[Token(Token = "0x6002278")]
			[Address(RVA = "0x73CF", Offset = "0x73CF", VA = "0x73CF", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06002279 RID: 8825 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700064C")]
		protected override IList<RatingPrizeDic> RatingPrizes
		{
			[Token(Token = "0x6002279")]
			[Address(RVA = "0x73D0", Offset = "0x73D0", VA = "0x73D0", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600227A")]
		[Address(RVA = "0x73D1", Offset = "0x73D1", VA = "0x73D1")]
		public UsersRatingViewMediator(RatingModel model, RatingEvents events, RatingController controller, RatingKindTypeDic.Types.RatingKindType ratingKindType, uint ratingType)
		{
		}

		// Token: 0x1700064D RID: 1613
		// (set) Token: 0x0600227B RID: 8827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700064D")]
		public override RatingWindow View
		{
			[Token(Token = "0x600227B")]
			[Address(RVA = "0x73D2", Offset = "0x73D2", VA = "0x73D2", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600227C")]
		[Address(RVA = "0x73D3", Offset = "0x73D3", VA = "0x73D3")]
		private void ResetView()
		{
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600227D")]
		[Address(RVA = "0x73D4", Offset = "0x73D4", VA = "0x73D4")]
		private void SetupView()
		{
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600227E")]
		[Address(RVA = "0x73D5", Offset = "0x73D5", VA = "0x73D5")]
		private void ExtraFilterDeselectedEventHandler()
		{
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600227F")]
		[Address(RVA = "0x73D6", Offset = "0x73D6", VA = "0x73D6")]
		private void ExtraFilterSelectedEventHandler(object data)
		{
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002280")]
		[Address(RVA = "0x73D7", Offset = "0x73D7", VA = "0x73D7")]
		private void UpdateOsaView([NotNull] RatingRequestDto rating, [CanBeNull] CultDic cultDic)
		{
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002281")]
		[Address(RVA = "0x73D8", Offset = "0x73D8", VA = "0x73D8", Slot = "28")]
		protected override void OnRatingsDataReceivingCompleteEvent(RatingRequestDto ratingRequest)
		{
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002282")]
		[Address(RVA = "0x73D9", Offset = "0x73D9", VA = "0x73D9", Slot = "22")]
		protected override void InitPeriodFilters()
		{
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002283")]
		[Address(RVA = "0x73DA", Offset = "0x73DA", VA = "0x73DA", Slot = "23")]
		protected override SubFilterListElement InitSubRatingsFilters(uint ratingType)
		{
			return null;
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002284")]
		[Address(RVA = "0x73DB", Offset = "0x73DB", VA = "0x73DB", Slot = "21")]
		protected override void InitExtraFilters()
		{
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002285")]
		[Address(RVA = "0x73DC", Offset = "0x73DC", VA = "0x73DC", Slot = "24")]
		protected override void SelectSubRatings(SubFilterListElement element)
		{
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002286")]
		[Address(RVA = "0x73DD", Offset = "0x73DD", VA = "0x73DD", Slot = "27")]
		protected override void HandleRewardsToggleChanged(bool active)
		{
		}

		// Token: 0x040012DB RID: 4827
		[Token(Token = "0x40012DB")]
		[FieldOffset(Offset = "0x28")]
		private CultDic _cultDic;
	}
}
