using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012D0 RID: 4816
	[Token(Token = "0x20012D0")]
	public class GdEventsAnalyticListener : AbstractAnalyticsListener
	{
		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x0600727F RID: 29311 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001734")]
		protected override string Theme
		{
			[Token(Token = "0x600727F")]
			[Address(RVA = "0xBC88", Offset = "0xBC88", VA = "0xBC88", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007280 RID: 29312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007280")]
		[Address(RVA = "0xBC89", Offset = "0xBC89", VA = "0xBC89", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x06007281 RID: 29313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007281")]
		[Address(RVA = "0xBC8A", Offset = "0xBC8A", VA = "0xBC8A", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x06007282 RID: 29314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007282")]
		[Address(RVA = "0xBC8B", Offset = "0xBC8B", VA = "0xBC8B")]
		private void HandleEvtCompleteEvent(GdEventsScope.CompletionsArgs args)
		{
		}

		// Token: 0x06007283 RID: 29315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007283")]
		[Address(RVA = "0xBC8C", Offset = "0xBC8C", VA = "0xBC8C")]
		private void HandleMilestoneCompleteEvent(GdEventsScope.CompletionsArgs args)
		{
		}

		// Token: 0x06007284 RID: 29316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007284")]
		[Address(RVA = "0xBC8D", Offset = "0xBC8D", VA = "0xBC8D")]
		private void HandleGameActivityNavigationEvent(GdEventsScope.Args args)
		{
		}

		// Token: 0x06007285 RID: 29317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007285")]
		[Address(RVA = "0xBC8E", Offset = "0xBC8E", VA = "0xBC8E")]
		private void HandleMilestoneSelectedEvent(GdEventsScope.Args args)
		{
		}

		// Token: 0x06007286 RID: 29318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007286")]
		[Address(RVA = "0xBC8F", Offset = "0xBC8F", VA = "0xBC8F")]
		public GdEventsAnalyticListener()
		{
		}

		// Token: 0x04003C00 RID: 15360
		[Token(Token = "0x4003C00")]
		public const string THEME = "gdevents";

		// Token: 0x04003C01 RID: 15361
		[Token(Token = "0x4003C01")]
		private const string GAME_ACTIVITY_NAVIGATION = "game_activity_navigation";

		// Token: 0x04003C02 RID: 15362
		[Token(Token = "0x4003C02")]
		public const string MILESTONE_SELECTED = "milestone_selected";

		// Token: 0x04003C03 RID: 15363
		[Token(Token = "0x4003C03")]
		private const string COMPLETE = "complete";

		// Token: 0x04003C04 RID: 15364
		[Token(Token = "0x4003C04")]
		private const string MILESTINE_COMPLETE = "milestine_complete";
	}
}
