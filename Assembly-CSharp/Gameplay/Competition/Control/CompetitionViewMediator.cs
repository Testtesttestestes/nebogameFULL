using System;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Gameplay.Competition.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Competition;

namespace Gameplay.Competition.Control
{
	// Token: 0x02000906 RID: 2310
	[Token(Token = "0x2000906")]
	public class CompetitionViewMediator : AbstractCozyViewMediator<CompetitionModel, Gameplay.Competition.Events.CompetitionEvents, CompetitionController, CompetitionView>
	{
		// Token: 0x0600364B RID: 13899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600364B")]
		[Address(RVA = "0x8658", Offset = "0x8658", VA = "0x8658")]
		public CompetitionViewMediator(CompetitionModel model, Gameplay.Competition.Events.CompetitionEvents events, CompetitionController controller)
		{
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600364C")]
		[Address(RVA = "0x8659", Offset = "0x8659", VA = "0x8659", Slot = "21")]
		protected override void ResetEvents(Gameplay.Competition.Events.CompetitionEvents events)
		{
		}

		// Token: 0x0600364D RID: 13901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600364D")]
		[Address(RVA = "0x865A", Offset = "0x865A", VA = "0x865A", Slot = "22")]
		protected override void SetupEvents(Gameplay.Competition.Events.CompetitionEvents events)
		{
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600364E")]
		[Address(RVA = "0x865B", Offset = "0x865B", VA = "0x865B", Slot = "23")]
		protected override void ResetView(CompetitionView view)
		{
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600364F")]
		[Address(RVA = "0x865C", Offset = "0x865C", VA = "0x865C", Slot = "24")]
		protected override void SetupView(CompetitionView view)
		{
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003650")]
		[Address(RVA = "0x865D", Offset = "0x865D", VA = "0x865D")]
		private void HandleFireAnimationTime()
		{
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003651")]
		[Address(RVA = "0x865E", Offset = "0x865E", VA = "0x865E")]
		private string FormatBackTime(float value)
		{
			return null;
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003652")]
		[Address(RVA = "0x865F", Offset = "0x865F", VA = "0x865F")]
		private void HandleTabBarChangeEvent()
		{
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003653")]
		[Address(RVA = "0x8660", Offset = "0x8660", VA = "0x8660")]
		private void HandleStateChangedEvent(CompetitionData data)
		{
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003654")]
		[Address(RVA = "0x8661", Offset = "0x8661", VA = "0x8661")]
		private void SetState(EventState state)
		{
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003655")]
		[Address(RVA = "0x8662", Offset = "0x8662", VA = "0x8662")]
		private void HandleActiveQuestsCountChanged()
		{
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003656")]
		[Address(RVA = "0x8663", Offset = "0x8663", VA = "0x8663")]
		private void ValidateTabCounters()
		{
		}
	}
}
