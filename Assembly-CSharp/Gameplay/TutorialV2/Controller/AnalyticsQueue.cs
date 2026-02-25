using System;
using Il2CppDummyDll;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x02000431 RID: 1073
	[Token(Token = "0x2000431")]
	public class AnalyticsQueue : TutorialStepsQueueBase
	{
		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x00005898 File Offset: 0x00003A98
		[Token(Token = "0x1700047E")]
		public override StepActionType StepActionType
		{
			[Token(Token = "0x6001964")]
			[Address(RVA = "0x6B03", Offset = "0x6B03", VA = "0x6B03", Slot = "4")]
			get
			{
				return StepActionType.None;
			}
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001965")]
		[Address(RVA = "0x6B04", Offset = "0x6B04", VA = "0x6B04", Slot = "5")]
		protected override void ShowNextInternal(StepActionType actionType)
		{
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001966")]
		[Address(RVA = "0x6B05", Offset = "0x6B05", VA = "0x6B05", Slot = "6")]
		public override void Hide()
		{
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001967")]
		[Address(RVA = "0x6B06", Offset = "0x6B06", VA = "0x6B06")]
		public AnalyticsQueue()
		{
		}

		// Token: 0x04000D7E RID: 3454
		[Token(Token = "0x4000D7E")]
		[FieldOffset(Offset = "0x8")]
		private StepActionType _currentStage;

		// Token: 0x04000D7F RID: 3455
		[Token(Token = "0x4000D7F")]
		[FieldOffset(Offset = "0xC")]
		private int _currentStep;
	}
}
