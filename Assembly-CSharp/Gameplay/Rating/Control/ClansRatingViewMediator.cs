using System;
using System.Collections.Generic;
using Gameplay.Clans.Office.View;
using Gameplay.Rating.Events;
using Gameplay.Rating.Model;
using Gameplay.Rating.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Dic;
using Protocol.Rating;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.Rating.Control
{
	// Token: 0x02000594 RID: 1428
	[Token(Token = "0x2000594")]
	public class ClansRatingViewMediator : BaseRatingViewMediator
	{
		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000644")]
		protected override Action<RatingRequestDto> RequestRatingsAction
		{
			[Token(Token = "0x6002239")]
			[Address(RVA = "0x7390", Offset = "0x7390", VA = "0x7390", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000645")]
		protected override IList<RatingPrizeDic> RatingPrizes
		{
			[Token(Token = "0x600223A")]
			[Address(RVA = "0x7391", Offset = "0x7391", VA = "0x7391", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223B")]
		[Address(RVA = "0x7392", Offset = "0x7392", VA = "0x7392")]
		public ClansRatingViewMediator(RatingModel model, Gameplay.Rating.Events.RatingEvents events, RatingController controller, RatingKindTypeDic.Types.RatingKindType kindType, uint ratingType)
		{
		}

		// Token: 0x17000646 RID: 1606
		// (set) Token: 0x0600223C RID: 8764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000646")]
		public override RatingWindow View
		{
			[Token(Token = "0x600223C")]
			[Address(RVA = "0x7393", Offset = "0x7393", VA = "0x7393", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223D")]
		[Address(RVA = "0x7394", Offset = "0x7394", VA = "0x7394")]
		private void ResetView()
		{
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223E")]
		[Address(RVA = "0x7395", Offset = "0x7395", VA = "0x7395")]
		private void SetupView()
		{
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223F")]
		[Address(RVA = "0x7396", Offset = "0x7396", VA = "0x7396")]
		private void ExtraFilterDeselectedEventHandler()
		{
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002240")]
		[Address(RVA = "0x7397", Offset = "0x7397", VA = "0x7397")]
		private void ExtraFilterSelectedEventHandler(object data)
		{
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002241")]
		[Address(RVA = "0x7398", Offset = "0x7398", VA = "0x7398")]
		private void UpdateOsaView([NotNull] RatingRequestDto rating, [CanBeNull] ClanCultDic cultDic)
		{
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002242")]
		[Address(RVA = "0x7399", Offset = "0x7399", VA = "0x7399", Slot = "28")]
		protected override void OnRatingsDataReceivingCompleteEvent(RatingRequestDto ratingRequest)
		{
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002243")]
		[Address(RVA = "0x739A", Offset = "0x739A", VA = "0x739A", Slot = "22")]
		protected override void InitPeriodFilters()
		{
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002244")]
		[Address(RVA = "0x739B", Offset = "0x739B", VA = "0x739B", Slot = "23")]
		protected override SubFilterListElement InitSubRatingsFilters(uint ratingType)
		{
			return null;
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002245")]
		[Address(RVA = "0x739C", Offset = "0x739C", VA = "0x739C", Slot = "21")]
		protected override void InitExtraFilters()
		{
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002246")]
		[Address(RVA = "0x739D", Offset = "0x739D", VA = "0x739D")]
		private void InjectClansCallback(uint ratingType, RatingPeriods ratingPeriods)
		{
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002247")]
		[Address(RVA = "0x739E", Offset = "0x739E", VA = "0x739E")]
		private void ClanContextClickedEventHandler(ClanInRatingListElement element)
		{
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002248")]
		[Address(RVA = "0x739F", Offset = "0x739F", VA = "0x739F", Slot = "24")]
		protected override void SelectSubRatings(SubFilterListElement element)
		{
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002249")]
		[Address(RVA = "0x73A0", Offset = "0x73A0", VA = "0x73A0", Slot = "27")]
		protected override void HandleRewardsToggleChanged(bool active)
		{
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600224A")]
		[Address(RVA = "0x73A1", Offset = "0x73A1", VA = "0x73A1")]
		private void ShowClanInfoPopupWindow(ClanData data)
		{
		}

		// Token: 0x040012CC RID: 4812
		[Token(Token = "0x40012CC")]
		[FieldOffset(Offset = "0x28")]
		private readonly bool _hasClan;

		// Token: 0x040012CD RID: 4813
		[Token(Token = "0x40012CD")]
		[FieldOffset(Offset = "0x2C")]
		private ClanCultDic _clanCultDic;
	}
}
