using System;
using System.Collections.Generic;
using Core.MVC.Interfaces;
using Gameplay.Rating.Events;
using Gameplay.Rating.Model;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.Rating.Control
{
	// Token: 0x0200059C RID: 1436
	[Token(Token = "0x200059C")]
	public class RatingViewMediator : AbstractViewMediator<RatingModel, RatingEvents, RatingController, RatingWindow>
	{
		// Token: 0x0600226A RID: 8810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600226A")]
		[Address(RVA = "0x73C1", Offset = "0x73C1", VA = "0x73C1", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600226B")]
		[Address(RVA = "0x73C2", Offset = "0x73C2", VA = "0x73C2")]
		public RatingViewMediator(RatingModel model, RatingEvents events, RatingController controller)
		{
		}

		// Token: 0x1700064A RID: 1610
		// (set) Token: 0x0600226C RID: 8812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700064A")]
		public override RatingWindow View
		{
			[Token(Token = "0x600226C")]
			[Address(RVA = "0x73C3", Offset = "0x73C3", VA = "0x73C3", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600226D")]
		[Address(RVA = "0x73C4", Offset = "0x73C4", VA = "0x73C4")]
		private void Init()
		{
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600226E")]
		[Address(RVA = "0x73C5", Offset = "0x73C5", VA = "0x73C5")]
		private void TabChangedEventHandler()
		{
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600226F")]
		[Address(RVA = "0x73C6", Offset = "0x73C6", VA = "0x73C6")]
		private void ExtraFilterToggleChangedEventHandler(bool enabled)
		{
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002270")]
		[Address(RVA = "0x73C7", Offset = "0x73C7", VA = "0x73C7")]
		private void PeriodFilterToggleChangedEventHandler(bool enabled)
		{
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002271")]
		[Address(RVA = "0x73C8", Offset = "0x73C8", VA = "0x73C8")]
		private BaseRatingViewMediator SelectUserRatings(RatingKindTypeDic.Types.RatingKindType ratingKindType, uint ratingType)
		{
			return null;
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002272")]
		[Address(RVA = "0x73C9", Offset = "0x73C9", VA = "0x73C9")]
		private BaseRatingViewMediator SelectClanRatings(RatingKindTypeDic.Types.RatingKindType ratingKindType, uint ratingType)
		{
			return null;
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002273")]
		[Address(RVA = "0x73CA", Offset = "0x73CA", VA = "0x73CA")]
		private BaseRatingViewMediator SelectCultRatings(RatingKindTypeDic.Types.RatingKindType ratingKindType, uint ratingType)
		{
			return null;
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002274")]
		[Address(RVA = "0x73CB", Offset = "0x73CB", VA = "0x73CB")]
		private void ActivateMediator(RatingKindTypeDic.Types.RatingKindType ratingKindType, uint ratingType = 0U)
		{
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002275")]
		[Address(RVA = "0x73CC", Offset = "0x73CC", VA = "0x73CC")]
		private void ActivateCurrentMediator(IViewMediator mediator)
		{
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002276")]
		[Address(RVA = "0x73CD", Offset = "0x73CD", VA = "0x73CD")]
		private void DeactivateCurrentMediator(IViewMediator mediator)
		{
		}

		// Token: 0x040012D6 RID: 4822
		[Token(Token = "0x40012D6")]
		[FieldOffset(Offset = "0x18")]
		private UsersRatingViewMediator _usersRatingViewMediator;

		// Token: 0x040012D7 RID: 4823
		[Token(Token = "0x40012D7")]
		[FieldOffset(Offset = "0x1C")]
		private ClansRatingViewMediator _clansRatingViewMediator;

		// Token: 0x040012D8 RID: 4824
		[Token(Token = "0x40012D8")]
		[FieldOffset(Offset = "0x20")]
		private CultsRatingViewMediator _cultsRatingViewMediator;

		// Token: 0x040012D9 RID: 4825
		[Token(Token = "0x40012D9")]
		[FieldOffset(Offset = "0x24")]
		private BaseRatingViewMediator _currentMediator;

		// Token: 0x040012DA RID: 4826
		[Token(Token = "0x40012DA")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<RatingKindTypeDic.Types.RatingKindType, Func<RatingKindTypeDic.Types.RatingKindType, uint, BaseRatingViewMediator>> _tabsOpenersById;
	}
}
