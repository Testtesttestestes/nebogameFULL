using System;
using Gameplay.VortexRating.Events;
using Gameplay.VortexRating.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Rating;
using ServicesNamespace;
using UI.Windows;
using Utils;

namespace Gameplay.VortexRating.Controller
{
	// Token: 0x0200039F RID: 927
	[Token(Token = "0x200039F")]
	public class VortexRatingController : AbstractController<VortexRatingModel, VortexRatingEvents>
	{
		// Token: 0x0600158A RID: 5514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158A")]
		[Address(RVA = "0x674C", Offset = "0x674C", VA = "0x674C")]
		public VortexRatingController(VortexRatingModel model, VortexRatingEvents events)
		{
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158B")]
		[Address(RVA = "0x674D", Offset = "0x674D", VA = "0x674D")]
		public void GetGreatTop()
		{
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158C")]
		[Address(RVA = "0x674E", Offset = "0x674E", VA = "0x674E")]
		private void GetGreatTopResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158D")]
		[Address(RVA = "0x674F", Offset = "0x674F", VA = "0x674F")]
		public void SetGreatSetId(uint greatSetId)
		{
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158E")]
		[Address(RVA = "0x6750", Offset = "0x6750", VA = "0x6750")]
		private void SetGreatSetIdResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158F")]
		[Address(RVA = "0x6751", Offset = "0x6751", VA = "0x6751")]
		public void VoteGreatRating(ulong userId)
		{
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001590")]
		[Address(RVA = "0x6752", Offset = "0x6752", VA = "0x6752")]
		private void VoteGreatRatingResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001591")]
		[Address(RVA = "0x6753", Offset = "0x6753", VA = "0x6753")]
		public void ExitGreatRating()
		{
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001592")]
		[Address(RVA = "0x6754", Offset = "0x6754", VA = "0x6754")]
		private void ExitGreatRatingResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001593")]
		[Address(RVA = "0x6755", Offset = "0x6755", VA = "0x6755")]
		public void VoteRTRating(ulong userId, bool isLike)
		{
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001594")]
		[Address(RVA = "0x6756", Offset = "0x6756", VA = "0x6756")]
		private void VoteRTRatingResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001595")]
		[Address(RVA = "0x6757", Offset = "0x6757", VA = "0x6757")]
		public void GetVoteRTRating(RatingPeriods period, bool ownerOnly)
		{
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001596")]
		[Address(RVA = "0x6758", Offset = "0x6758", VA = "0x6758")]
		private void GetVoteRTRatingResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001597")]
		[Address(RVA = "0x6759", Offset = "0x6759", VA = "0x6759")]
		private void GreatRatingTopChangedEventHandler(ProtoGreatRatingTopChangedEvt evt)
		{
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001598")]
		[Address(RVA = "0x675A", Offset = "0x675A", VA = "0x675A")]
		private void GreatRatingSetChangedEventHandler(ProtoGreatRatingSetChangedEvt evt)
		{
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001599")]
		[Address(RVA = "0x675B", Offset = "0x675B", VA = "0x675B")]
		private void SubscribeToEvents()
		{
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159A")]
		[Address(RVA = "0x675C", Offset = "0x675C", VA = "0x675C")]
		private void UnsubscribeFromEvents()
		{
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600159B")]
		[Address(RVA = "0x675D", Offset = "0x675D", VA = "0x675D")]
		public DialogWindow ShowLowLevelWindow(int minLevel)
		{
			return null;
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159C")]
		[Address(RVA = "0x675E", Offset = "0x675E", VA = "0x675E", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159D")]
		[Address(RVA = "0x675F", Offset = "0x675F", VA = "0x675F", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159E")]
		[Address(RVA = "0x6760", Offset = "0x6760", VA = "0x6760", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x04000B71 RID: 2929
		[Token(Token = "0x4000B71")]
		[FieldOffset(Offset = "0x18")]
		private RatingService _ratingService;

		// Token: 0x04000B72 RID: 2930
		[Token(Token = "0x4000B72")]
		[FieldOffset(Offset = "0x1C")]
		private bool _subscribed;
	}
}
