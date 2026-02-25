using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012BD RID: 4797
	[Token(Token = "0x20012BD")]
	public class AnalyticsEventMediatorListener : AbstractAnalyticsListener
	{
		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x060071E5 RID: 29157 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001722")]
		protected override string Theme
		{
			[Token(Token = "0x60071E5")]
			[Address(RVA = "0xBBEE", Offset = "0xBBEE", VA = "0xBBEE", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060071E6 RID: 29158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071E6")]
		[Address(RVA = "0xBBEF", Offset = "0xBBEF", VA = "0xBBEF", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x060071E7 RID: 29159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071E7")]
		[Address(RVA = "0xBBF0", Offset = "0xBBF0", VA = "0xBBF0")]
		private void OnTutorialStepEvent(AnalyticsEventMediatorScope.AnalyticsEventMediatorArgs args)
		{
		}

		// Token: 0x060071E8 RID: 29160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071E8")]
		[Address(RVA = "0xBBF1", Offset = "0xBBF1", VA = "0xBBF1")]
		private void OnGameLoadingEvent(AnalyticsEventMediatorScope.AnalyticsEventMediatorArgs args)
		{
		}

		// Token: 0x060071E9 RID: 29161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071E9")]
		[Address(RVA = "0xBBF2", Offset = "0xBBF2", VA = "0xBBF2", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x060071EA RID: 29162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071EA")]
		[Address(RVA = "0xBBF3", Offset = "0xBBF3", VA = "0xBBF3")]
		public AnalyticsEventMediatorListener()
		{
		}

		// Token: 0x04003BAB RID: 15275
		[Token(Token = "0x4003BAB")]
		public const string THEME = "analytics_event_mediator";

		// Token: 0x04003BAC RID: 15276
		[Token(Token = "0x4003BAC")]
		public const string GAME_LOADING = "game_loading";

		// Token: 0x04003BAD RID: 15277
		[Token(Token = "0x4003BAD")]
		public const string TUTORIAL_STEP_NEW = "tutorial_step_new";
	}
}
