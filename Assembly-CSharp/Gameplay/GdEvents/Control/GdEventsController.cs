using System;
using System.Collections.Generic;
using Gameplay.GdEvents.Model;
using Gameplay.GdEvents.Model.Categories;
using Gameplay.GdEvents.Model.Milestone;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Utils;
using Utils.Accumulators;

namespace Gameplay.GdEvents.Control
{
	// Token: 0x02000765 RID: 1893
	[Token(Token = "0x2000765")]
	public class GdEventsController : AbstractController<GdEventsModel, GdEventsEvents>
	{
		// Token: 0x06002D11 RID: 11537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D11")]
		[Address(RVA = "0x7D8F", Offset = "0x7D8F", VA = "0x7D8F")]
		public GdEventsController(GdEventsModel model, GdEventsEvents events)
		{
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D12")]
		[Address(RVA = "0x7D90", Offset = "0x7D90", VA = "0x7D90", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D13")]
		[Address(RVA = "0x7D91", Offset = "0x7D91", VA = "0x7D91", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D14")]
		[Address(RVA = "0x7D92", Offset = "0x7D92", VA = "0x7D92")]
		private void HandleTriggersUpdateEvent(IEnumerable<TriggerValue> changes, AccumulatorBase<int, TriggerValue> accumulator)
		{
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D15")]
		[Address(RVA = "0x7D93", Offset = "0x7D93", VA = "0x7D93")]
		private void HandleDictProviderChangeEvent()
		{
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D16")]
		[Address(RVA = "0x7D94", Offset = "0x7D94", VA = "0x7D94")]
		private void RequestEventMilestoneRewards(GdEventData evt, params MilestoneData[] milestones)
		{
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D17")]
		[Address(RVA = "0x7D95", Offset = "0x7D95", VA = "0x7D95")]
		private void HandleGetEventMilestonesRewardsInfoService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D18")]
		[Address(RVA = "0x7D96", Offset = "0x7D96", VA = "0x7D96")]
		private void RequestEventRewards(GdEventData evt)
		{
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D19")]
		[Address(RVA = "0x7D97", Offset = "0x7D97", VA = "0x7D97")]
		private void HandleGetGameEventsRewardsInfoService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1A")]
		[Address(RVA = "0x7D98", Offset = "0x7D98", VA = "0x7D98")]
		public void SetCurrentEvent(GdEventData data)
		{
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002D1B")]
		[Address(RVA = "0x7D99", Offset = "0x7D99", VA = "0x7D99")]
		public List<AbstractGdEventCatData> GetCategories()
		{
			return null;
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1C")]
		[Address(RVA = "0x7D9A", Offset = "0x7D9A", VA = "0x7D9A")]
		public void RequestRewards(GdEventData evt, MilestoneData milestone)
		{
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1D")]
		[Address(RVA = "0x7D9B", Offset = "0x7D9B", VA = "0x7D9B")]
		public void RequestRewards(GdEventData evt)
		{
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1E")]
		[Address(RVA = "0x7D9C", Offset = "0x7D9C", VA = "0x7D9C")]
		public void ResetCurrentEvent()
		{
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D1F")]
		[Address(RVA = "0x7D9D", Offset = "0x7D9D", VA = "0x7D9D")]
		public void ResetRewards()
		{
		}
	}
}
