using System;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Gameplay.Competition.View.Sections.Rating;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Competition.Control.Sections
{
	// Token: 0x0200090C RID: 2316
	[Token(Token = "0x200090C")]
	public class RatingViewMediator : AbstractCozyViewMediator<RatingModel, RatingEvents, RatingController, RatingView>
	{
		// Token: 0x0600366E RID: 13934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600366E")]
		[Address(RVA = "0x867B", Offset = "0x867B", VA = "0x867B")]
		public RatingViewMediator(RatingView view, RatingModel model, RatingEvents events, RatingController controller)
		{
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600366F")]
		[Address(RVA = "0x867C", Offset = "0x867C", VA = "0x867C", Slot = "21")]
		protected override void ResetEvents(RatingEvents events)
		{
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003670")]
		[Address(RVA = "0x867D", Offset = "0x867D", VA = "0x867D", Slot = "22")]
		protected override void SetupEvents(RatingEvents events)
		{
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003671")]
		[Address(RVA = "0x867E", Offset = "0x867E", VA = "0x867E", Slot = "23")]
		protected override void ResetView(RatingView view)
		{
		}

		// Token: 0x06003672 RID: 13938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003672")]
		[Address(RVA = "0x867F", Offset = "0x867F", VA = "0x867F", Slot = "24")]
		protected override void SetupView(RatingView view)
		{
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003673")]
		[Address(RVA = "0x8680", Offset = "0x8680", VA = "0x8680")]
		private void SetupText()
		{
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003674")]
		[Address(RVA = "0x8681", Offset = "0x8681", VA = "0x8681")]
		private void HandleOwnerRatingChangedEvent(OwnerRating from, OwnerRating to)
		{
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003675")]
		[Address(RVA = "0x8682", Offset = "0x8682", VA = "0x8682")]
		private void HandleRatingChangedEvent()
		{
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003676")]
		[Address(RVA = "0x8683", Offset = "0x8683", VA = "0x8683")]
		private void UpdateRatingView()
		{
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003677")]
		[Address(RVA = "0x8684", Offset = "0x8684", VA = "0x8684")]
		private void UpdateOwnerRating()
		{
		}

		// Token: 0x06003678 RID: 13944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003678")]
		[Address(RVA = "0x8685", Offset = "0x8685", VA = "0x8685")]
		private void UpdateTopLeaders()
		{
		}

		// Token: 0x06003679 RID: 13945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003679")]
		[Address(RVA = "0x8686", Offset = "0x8686", VA = "0x8686")]
		private void UpdateOSAView()
		{
		}
	}
}
