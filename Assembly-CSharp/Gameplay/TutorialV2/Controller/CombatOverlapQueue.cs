using System;
using System.Collections.Generic;
using Coffee.UISoftMask;
using Gameplay.Tutorial.Guide.View.Components;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Pool;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x02000434 RID: 1076
	[Token(Token = "0x2000434")]
	public class CombatOverlapQueue : TutorialStepsQueueBase
	{
		// Token: 0x0600196E RID: 6510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600196E")]
		[Address(RVA = "0x6B0D", Offset = "0x6B0D", VA = "0x6B0D")]
		public CombatOverlapQueue(ShapePointer overlap, ObjectPool<MaskingShape> shapesPool, IEnumerable<CombatOverlapQueue.Item> queue)
		{
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x000058C8 File Offset: 0x00003AC8
		[Token(Token = "0x17000480")]
		public override StepActionType StepActionType
		{
			[Token(Token = "0x600196F")]
			[Address(RVA = "0x6B0E", Offset = "0x6B0E", VA = "0x6B0E", Slot = "4")]
			get
			{
				return StepActionType.None;
			}
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001970")]
		[Address(RVA = "0x6B0F", Offset = "0x6B0F", VA = "0x6B0F", Slot = "5")]
		protected override void ShowNextInternal(StepActionType actionType)
		{
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001971")]
		[Address(RVA = "0x6B10", Offset = "0x6B10", VA = "0x6B10", Slot = "6")]
		public override void Hide()
		{
		}

		// Token: 0x04000D83 RID: 3459
		[Token(Token = "0x4000D83")]
		[FieldOffset(Offset = "0x8")]
		private readonly ShapePointer _overlap;

		// Token: 0x04000D84 RID: 3460
		[Token(Token = "0x4000D84")]
		[FieldOffset(Offset = "0xC")]
		private readonly Queue<CombatOverlapQueue.Item> _queue;

		// Token: 0x04000D85 RID: 3461
		[Token(Token = "0x4000D85")]
		[FieldOffset(Offset = "0x10")]
		private readonly ObjectPool<MaskingShape> _shapesPool;

		// Token: 0x04000D86 RID: 3462
		[Token(Token = "0x4000D86")]
		[FieldOffset(Offset = "0x14")]
		private readonly List<MaskingShape> _shapesCache;

		// Token: 0x02000435 RID: 1077
		[Token(Token = "0x2000435")]
		public class Item
		{
			// Token: 0x06001972 RID: 6514 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001972")]
			[Address(RVA = "0x6B11", Offset = "0x6B11", VA = "0x6B11")]
			public Item(Rect[] rects, Sprite[] shapes)
			{
			}

			// Token: 0x04000D87 RID: 3463
			[Token(Token = "0x4000D87")]
			[FieldOffset(Offset = "0x8")]
			public readonly Rect[] Rects;

			// Token: 0x04000D88 RID: 3464
			[Token(Token = "0x4000D88")]
			[FieldOffset(Offset = "0xC")]
			public readonly Sprite[] Shapes;
		}
	}
}
