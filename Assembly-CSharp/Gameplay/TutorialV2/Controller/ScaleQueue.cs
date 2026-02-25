using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x02000438 RID: 1080
	[Token(Token = "0x2000438")]
	public class ScaleQueue : TutorialStepsQueueBase
	{
		// Token: 0x0600197B RID: 6523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600197B")]
		[Address(RVA = "0x6B1A", Offset = "0x6B1A", VA = "0x6B1A")]
		public ScaleQueue(IEnumerable<IReadOnlyList<ScaleQueue.ScaleQueueArgs>> queue)
		{
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x00005910 File Offset: 0x00003B10
		[Token(Token = "0x17000483")]
		public override StepActionType StepActionType
		{
			[Token(Token = "0x600197C")]
			[Address(RVA = "0x6B1B", Offset = "0x6B1B", VA = "0x6B1B", Slot = "4")]
			get
			{
				return StepActionType.None;
			}
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600197D")]
		[Address(RVA = "0x6B1C", Offset = "0x6B1C", VA = "0x6B1C", Slot = "5")]
		protected override void ShowNextInternal(StepActionType actionType)
		{
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600197E")]
		[Address(RVA = "0x6B1D", Offset = "0x6B1D", VA = "0x6B1D", Slot = "6")]
		public override void Hide()
		{
		}

		// Token: 0x04000D8D RID: 3469
		[Token(Token = "0x4000D8D")]
		[FieldOffset(Offset = "0x8")]
		private readonly Queue<IReadOnlyList<ScaleQueue.ScaleQueueArgs>> _queue;

		// Token: 0x02000439 RID: 1081
		[Token(Token = "0x2000439")]
		public class ScaleQueueArgs
		{
			// Token: 0x0600197F RID: 6527 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600197F")]
			[Address(RVA = "0x6B1E", Offset = "0x6B1E", VA = "0x6B1E")]
			public ScaleQueueArgs()
			{
			}

			// Token: 0x04000D8E RID: 3470
			[Token(Token = "0x4000D8E")]
			[FieldOffset(Offset = "0x8")]
			public Transform TargetTransform;

			// Token: 0x04000D8F RID: 3471
			[Token(Token = "0x4000D8F")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 TargetScale;

			// Token: 0x04000D90 RID: 3472
			[Token(Token = "0x4000D90")]
			[FieldOffset(Offset = "0x18")]
			public float ScaleDuration;

			// Token: 0x04000D91 RID: 3473
			[Token(Token = "0x4000D91")]
			[FieldOffset(Offset = "0x1C")]
			public Ease Ease;
		}
	}
}
