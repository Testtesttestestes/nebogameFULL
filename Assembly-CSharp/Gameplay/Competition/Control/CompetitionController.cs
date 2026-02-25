using System;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Competition;
using Protocol.Rating;
using ServicesNamespace;
using Utils;

namespace Gameplay.Competition.Control
{
	// Token: 0x02000903 RID: 2307
	[Token(Token = "0x2000903")]
	public class CompetitionController : AbstractController<CompetitionModel, Gameplay.Competition.Events.CompetitionEvents>
	{
		// Token: 0x06003626 RID: 13862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003626")]
		[Address(RVA = "0x8633", Offset = "0x8633", VA = "0x8633")]
		public CompetitionController(RatingService ratingService, CompetitionService competitionService, CompetitionModel model, Gameplay.Competition.Events.CompetitionEvents events)
		{
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003627")]
		[Address(RVA = "0x8634", Offset = "0x8634", VA = "0x8634", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06003628 RID: 13864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003628")]
		[Address(RVA = "0x8635", Offset = "0x8635", VA = "0x8635", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003629")]
		[Address(RVA = "0x8636", Offset = "0x8636", VA = "0x8636")]
		private void RequestQuests()
		{
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600362A")]
		[Address(RVA = "0x8637", Offset = "0x8637", VA = "0x8637")]
		private void HandleQuestsUpdated()
		{
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600362B")]
		[Address(RVA = "0x8638", Offset = "0x8638", VA = "0x8638")]
		private void HandleActiveQuestsCountChanged()
		{
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600362C")]
		[Address(RVA = "0x8639", Offset = "0x8639", VA = "0x8639")]
		private void ValidateInit()
		{
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600362D")]
		[Address(RVA = "0x863A", Offset = "0x863A", VA = "0x863A")]
		private void StartListen()
		{
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600362E")]
		[Address(RVA = "0x863B", Offset = "0x863B", VA = "0x863B")]
		private void StopListen()
		{
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600362F")]
		[Address(RVA = "0x863C", Offset = "0x863C", VA = "0x863C")]
		private void HandleQuestsChanged()
		{
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003630")]
		[Address(RVA = "0x863D", Offset = "0x863D", VA = "0x863D")]
		private void HandleDictionariesChangedEvent()
		{
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003631")]
		[Address(RVA = "0x863E", Offset = "0x863E", VA = "0x863E")]
		private void RequestOwnerRatingService()
		{
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003632")]
		[Address(RVA = "0x863F", Offset = "0x863F", VA = "0x863F")]
		private void HandleGetOwnerRatingService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003633")]
		[Address(RVA = "0x8640", Offset = "0x8640", VA = "0x8640")]
		private void RequestStateService()
		{
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003634")]
		[Address(RVA = "0x8641", Offset = "0x8641", VA = "0x8641")]
		private void HandleGetStateService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003635")]
		[Address(RVA = "0x8642", Offset = "0x8642", VA = "0x8642")]
		private void HandleOwnedRatingChangedEvent(OwnerRating from, OwnerRating to)
		{
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003636")]
		[Address(RVA = "0x8643", Offset = "0x8643", VA = "0x8643")]
		private void HandleRatingChangedEventService(ProtoCompetitionRatingChangedEvt msg)
		{
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003637")]
		[Address(RVA = "0x8644", Offset = "0x8644", VA = "0x8644")]
		private void HandleStateChangedEventService(ProtoCompetitionStateChangedEvt msg)
		{
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003638")]
		[Address(RVA = "0x8645", Offset = "0x8645", VA = "0x8645")]
		private void SetInfo([NotNull] CompetitionInfo info)
		{
		}

		// Token: 0x04001DD6 RID: 7638
		[Token(Token = "0x4001DD6")]
		[FieldOffset(Offset = "0x18")]
		private readonly RatingService _ratingService;

		// Token: 0x04001DD7 RID: 7639
		[Token(Token = "0x4001DD7")]
		[FieldOffset(Offset = "0x1C")]
		private readonly CompetitionService _competitionService;

		// Token: 0x04001DD8 RID: 7640
		[Token(Token = "0x4001DD8")]
		[FieldOffset(Offset = "0x20")]
		private int _initialStepsCount;
	}
}
