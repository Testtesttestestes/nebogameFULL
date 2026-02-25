using System;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Gameplay.Competition.View;
using Il2CppDummyDll;
using MVC;
using UnityEngine.EventSystems;

namespace Gameplay.Competition.Control
{
	// Token: 0x02000904 RID: 2308
	[Token(Token = "0x2000904")]
	public class CompetitionEpViewMediator : AbstractCozyViewMediator<CompetitionModel, CompetitionEvents, CompetitionController, CompetitionEpView>
	{
		// Token: 0x06003639 RID: 13881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003639")]
		[Address(RVA = "0x8646", Offset = "0x8646", VA = "0x8646")]
		public CompetitionEpViewMediator(CompetitionModel model, CompetitionEvents events, CompetitionController controller)
		{
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363A")]
		[Address(RVA = "0x8647", Offset = "0x8647", VA = "0x8647", Slot = "21")]
		protected override void ResetEvents(CompetitionEvents events)
		{
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363B")]
		[Address(RVA = "0x8648", Offset = "0x8648", VA = "0x8648", Slot = "22")]
		protected override void SetupEvents(CompetitionEvents events)
		{
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363C")]
		[Address(RVA = "0x8649", Offset = "0x8649", VA = "0x8649")]
		private void HandleQuestsChangedEvent()
		{
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363D")]
		[Address(RVA = "0x864A", Offset = "0x864A", VA = "0x864A")]
		private void HandleActiveQuestsCountChanged()
		{
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363E")]
		[Address(RVA = "0x864B", Offset = "0x864B", VA = "0x864B")]
		private void TryShowNotification()
		{
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363F")]
		[Address(RVA = "0x864C", Offset = "0x864C", VA = "0x864C", Slot = "23")]
		protected override void ResetView(CompetitionEpView view)
		{
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003640")]
		[Address(RVA = "0x864D", Offset = "0x864D", VA = "0x864D", Slot = "24")]
		protected override void SetupView(CompetitionEpView view)
		{
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003641")]
		[Address(RVA = "0x864E", Offset = "0x864E", VA = "0x864E")]
		private void HandleEpClickEvent(PointerEventData data)
		{
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003642")]
		[Address(RVA = "0x864F", Offset = "0x864F", VA = "0x864F")]
		private void HandleStateChangedEvent(CompetitionData data)
		{
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003643")]
		[Address(RVA = "0x8650", Offset = "0x8650", VA = "0x8650")]
		private void HandleOwnerRatingChangedEvent(OwnerRating from, OwnerRating to)
		{
		}
	}
}
