using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x02000432 RID: 1074
	[Token(Token = "0x2000432")]
	public class CallbackQueue : TutorialStepsQueueBase
	{
		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x000058B0 File Offset: 0x00003AB0
		[Token(Token = "0x1700047F")]
		public override StepActionType StepActionType
		{
			[Token(Token = "0x6001968")]
			[Address(RVA = "0x6B07", Offset = "0x6B07", VA = "0x6B07", Slot = "4")]
			get
			{
				return StepActionType.None;
			}
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001969")]
		[Address(RVA = "0x6B08", Offset = "0x6B08", VA = "0x6B08")]
		public CallbackQueue(StepActionType actionType, IEnumerable<CallbackQueue.CallbackItem> sequence)
		{
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600196A")]
		[Address(RVA = "0x6B09", Offset = "0x6B09", VA = "0x6B09")]
		public CallbackQueue(StepActionType actionType, params CallbackQueue.CallbackItem[] sequence)
		{
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600196B")]
		[Address(RVA = "0x6B0A", Offset = "0x6B0A", VA = "0x6B0A", Slot = "6")]
		public override void Hide()
		{
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600196C")]
		[Address(RVA = "0x6B0B", Offset = "0x6B0B", VA = "0x6B0B", Slot = "5")]
		protected override void ShowNextInternal(StepActionType actionType)
		{
		}

		// Token: 0x04000D80 RID: 3456
		[Token(Token = "0x4000D80")]
		[FieldOffset(Offset = "0x8")]
		private readonly StepActionType _stepActionType;

		// Token: 0x04000D81 RID: 3457
		[Token(Token = "0x4000D81")]
		[FieldOffset(Offset = "0xC")]
		private Queue<CallbackQueue.CallbackItem> _queue;

		// Token: 0x02000433 RID: 1075
		[Token(Token = "0x2000433")]
		public class CallbackItem
		{
			// Token: 0x0600196D RID: 6509 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600196D")]
			[Address(RVA = "0x6B0C", Offset = "0x6B0C", VA = "0x6B0C")]
			public CallbackItem(Action callback)
			{
			}

			// Token: 0x04000D82 RID: 3458
			[Token(Token = "0x4000D82")]
			[FieldOffset(Offset = "0x8")]
			public Action Callback;
		}
	}
}
