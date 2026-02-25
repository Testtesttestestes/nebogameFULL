using System;
using Core.Data;
using Gameplay.GdEvents.Model;
using Gameplay.GdEvents.Model.Milestone;
using Gameplay.GdEvents.View.EventView;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.GdEvents.Control.EventSections
{
	// Token: 0x02000772 RID: 1906
	[Token(Token = "0x2000772")]
	public class MilestoneViewMediator : AbstractViewMediator<GdEventsModel, GdEventsEvents, GdEventsController, MilestonesEventSectionView>
	{
		// Token: 0x06002D61 RID: 11617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D61")]
		[Address(RVA = "0x7DDF", Offset = "0x7DDF", VA = "0x7DDF")]
		public MilestoneViewMediator(GdEventsModel model, GdEventsEvents events, GdEventsController controller)
		{
		}

		// Token: 0x170008B6 RID: 2230
		// (set) Token: 0x06002D62 RID: 11618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B6")]
		public override GdEventsEvents Events
		{
			[Token(Token = "0x6002D62")]
			[Address(RVA = "0x7DE0", Offset = "0x7DE0", VA = "0x7DE0", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (set) Token: 0x06002D63 RID: 11619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B7")]
		public override MilestonesEventSectionView View
		{
			[Token(Token = "0x6002D63")]
			[Address(RVA = "0x7DE1", Offset = "0x7DE1", VA = "0x7DE1", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D64")]
		[Address(RVA = "0x7DE2", Offset = "0x7DE2", VA = "0x7DE2")]
		private void ResetView()
		{
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D65")]
		[Address(RVA = "0x7DE3", Offset = "0x7DE3", VA = "0x7DE3")]
		private void SetupView()
		{
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D66")]
		[Address(RVA = "0x7DE4", Offset = "0x7DE4", VA = "0x7DE4")]
		private void InitViewComplete()
		{
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D67")]
		[Address(RVA = "0x7DE5", Offset = "0x7DE5", VA = "0x7DE5")]
		private void SetupViewComplete()
		{
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D68")]
		[Address(RVA = "0x7DE6", Offset = "0x7DE6", VA = "0x7DE6")]
		private void ListOnClickEvent(MilestoneData data)
		{
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D69")]
		[Address(RVA = "0x7DE7", Offset = "0x7DE7", VA = "0x7DE7")]
		private void HandleCurrentMilestoneRewardUpdatedEvent(MilestoneData milestone)
		{
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D6A")]
		[Address(RVA = "0x7DE8", Offset = "0x7DE8", VA = "0x7DE8")]
		private void HandleContentChangedEvent()
		{
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x00008C70 File Offset: 0x00006E70
		[Token(Token = "0x6002D6B")]
		[Address(RVA = "0x7DE9", Offset = "0x7DE9", VA = "0x7DE9")]
		private bool TrySelect(MilestoneData milestone)
		{
			return default(bool);
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D6C")]
		[Address(RVA = "0x7DEA", Offset = "0x7DEA", VA = "0x7DEA")]
		private void Select(MilestoneData milestone)
		{
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D6D")]
		[Address(RVA = "0x7DEB", Offset = "0x7DEB", VA = "0x7DEB")]
		private void HandleActivityClickEvent(GameActivityData activity)
		{
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D6E")]
		[Address(RVA = "0x7DEC", Offset = "0x7DEC", VA = "0x7DEC")]
		private void HandleRewards(MilestoneData milestone)
		{
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x00008C88 File Offset: 0x00006E88
		[Token(Token = "0x6002D6F")]
		[Address(RVA = "0x7DED", Offset = "0x7DED", VA = "0x7DED")]
		private bool TryShowRequirements(MilestoneData data)
		{
			return default(bool);
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x00008CA0 File Offset: 0x00006EA0
		[Token(Token = "0x6002D70")]
		[Address(RVA = "0x7DEE", Offset = "0x7DEE", VA = "0x7DEE")]
		private bool TryShowRewards(RewardData[] rewards)
		{
			return default(bool);
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D71")]
		[Address(RVA = "0x7DEF", Offset = "0x7DEF", VA = "0x7DEF")]
		private void HandleGifts(MilestoneData data)
		{
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x00008CB8 File Offset: 0x00006EB8
		[Token(Token = "0x6002D72")]
		[Address(RVA = "0x7DF0", Offset = "0x7DF0", VA = "0x7DF0")]
		private bool TryShowStages(MilestoneData data)
		{
			return default(bool);
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x00008CD0 File Offset: 0x00006ED0
		[Token(Token = "0x6002D73")]
		[Address(RVA = "0x7DF1", Offset = "0x7DF1", VA = "0x7DF1")]
		private bool TryShowActivity(MilestoneData data)
		{
			return default(bool);
		}
	}
}
