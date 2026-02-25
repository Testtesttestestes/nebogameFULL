using System;
using Core.Data;
using Gameplay.GdEvents.Model;
using Gameplay.GdEvents.View.EventView;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.GdEvents.Control.EventSections
{
	// Token: 0x02000771 RID: 1905
	[Token(Token = "0x2000771")]
	public class ExecuteConditionsViewMediator : AbstractViewMediator<GdEventsModel, GdEventsEvents, GdEventsController, ConditionsEventSectionView>
	{
		// Token: 0x06002D59 RID: 11609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D59")]
		[Address(RVA = "0x7DD7", Offset = "0x7DD7", VA = "0x7DD7")]
		public ExecuteConditionsViewMediator(GdEventsModel model, GdEventsEvents events, GdEventsController controller)
		{
		}

		// Token: 0x170008B4 RID: 2228
		// (set) Token: 0x06002D5A RID: 11610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B4")]
		public override GdEventsEvents Events
		{
			[Token(Token = "0x6002D5A")]
			[Address(RVA = "0x7DD8", Offset = "0x7DD8", VA = "0x7DD8", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (set) Token: 0x06002D5B RID: 11611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B5")]
		public override ConditionsEventSectionView View
		{
			[Token(Token = "0x6002D5B")]
			[Address(RVA = "0x7DD9", Offset = "0x7DD9", VA = "0x7DD9", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5C")]
		[Address(RVA = "0x7DDA", Offset = "0x7DDA", VA = "0x7DDA")]
		private void HandleCurrentEventRewardUpdatedEvent(GdEventData evt)
		{
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5D")]
		[Address(RVA = "0x7DDB", Offset = "0x7DDB", VA = "0x7DDB")]
		private void ResetView()
		{
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5E")]
		[Address(RVA = "0x7DDC", Offset = "0x7DDC", VA = "0x7DDC")]
		private void SetupView()
		{
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5F")]
		[Address(RVA = "0x7DDD", Offset = "0x7DDD", VA = "0x7DDD")]
		private void HandleRewards(GdEventData evt)
		{
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x00008C58 File Offset: 0x00006E58
		[Token(Token = "0x6002D60")]
		[Address(RVA = "0x7DDE", Offset = "0x7DDE", VA = "0x7DDE")]
		private bool TryShowRewards(RewardData[] rewards)
		{
			return default(bool);
		}
	}
}
