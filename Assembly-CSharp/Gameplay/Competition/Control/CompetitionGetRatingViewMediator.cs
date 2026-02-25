using System;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Gameplay.Competition.View.GetRatingRewardWidget;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Competition.Control
{
	// Token: 0x02000905 RID: 2309
	[Token(Token = "0x2000905")]
	public class CompetitionGetRatingViewMediator : AbstractCozyViewMediator<CompetitionModel, CompetitionEvents, CompetitionController, CompetitionGetRatingView>
	{
		// Token: 0x06003644 RID: 13892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003644")]
		[Address(RVA = "0x8651", Offset = "0x8651", VA = "0x8651")]
		public CompetitionGetRatingViewMediator(CompetitionModel model, CompetitionEvents events, CompetitionController controller)
		{
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003645")]
		[Address(RVA = "0x8652", Offset = "0x8652", VA = "0x8652")]
		public CompetitionGetRatingViewMediator(CompetitionGetRatingView view, CompetitionModel model, CompetitionEvents events, CompetitionController controller)
		{
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003646")]
		[Address(RVA = "0x8653", Offset = "0x8653", VA = "0x8653", Slot = "21")]
		protected override void ResetEvents(CompetitionEvents events)
		{
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003647")]
		[Address(RVA = "0x8654", Offset = "0x8654", VA = "0x8654", Slot = "22")]
		protected override void SetupEvents(CompetitionEvents events)
		{
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003648")]
		[Address(RVA = "0x8655", Offset = "0x8655", VA = "0x8655", Slot = "23")]
		protected override void ResetView(CompetitionGetRatingView view)
		{
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003649")]
		[Address(RVA = "0x8656", Offset = "0x8656", VA = "0x8656", Slot = "24")]
		protected override void SetupView(CompetitionGetRatingView view)
		{
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600364A")]
		[Address(RVA = "0x8657", Offset = "0x8657", VA = "0x8657")]
		private void HandleOwnerRatingChangedEvent(OwnerRating from, OwnerRating to)
		{
		}
	}
}
