using System;
using System.Collections.Generic;
using Gameplay.TutorialV2.View;
using Il2CppDummyDll;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x02000436 RID: 1078
	[Token(Token = "0x2000436")]
	public class MessageBubbleQueue : TutorialStepsQueueBase
	{
		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x000058E0 File Offset: 0x00003AE0
		[Token(Token = "0x17000481")]
		public override StepActionType StepActionType
		{
			[Token(Token = "0x6001973")]
			[Address(RVA = "0x6B12", Offset = "0x6B12", VA = "0x6B12", Slot = "4")]
			get
			{
				return StepActionType.None;
			}
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001974")]
		[Address(RVA = "0x6B13", Offset = "0x6B13", VA = "0x6B13")]
		public MessageBubbleQueue(MessageBubbleView view, IEnumerable<MessageBubbleView.MessageBubbleViewArgs> steps)
		{
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001975")]
		[Address(RVA = "0x6B14", Offset = "0x6B14", VA = "0x6B14", Slot = "5")]
		protected override void ShowNextInternal(StepActionType actionType)
		{
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001976")]
		[Address(RVA = "0x6B15", Offset = "0x6B15", VA = "0x6B15", Slot = "6")]
		public override void Hide()
		{
		}

		// Token: 0x04000D89 RID: 3465
		[Token(Token = "0x4000D89")]
		[FieldOffset(Offset = "0x8")]
		private Queue<MessageBubbleView.MessageBubbleViewArgs> _steps;

		// Token: 0x04000D8A RID: 3466
		[Token(Token = "0x4000D8A")]
		[FieldOffset(Offset = "0xC")]
		private MessageBubbleView _view;
	}
}
