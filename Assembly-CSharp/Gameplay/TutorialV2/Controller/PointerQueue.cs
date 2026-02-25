using System;
using System.Collections.Generic;
using Gameplay.Tutorial.Guide.View;
using Il2CppDummyDll;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x02000437 RID: 1079
	[Token(Token = "0x2000437")]
	public class PointerQueue : TutorialStepsQueueBase
	{
		// Token: 0x06001977 RID: 6519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001977")]
		[Address(RVA = "0x6B16", Offset = "0x6B16", VA = "0x6B16")]
		public PointerQueue(GraphicPointerView pointer, IEnumerable<GraphicPointerView.GraphicPointerViewArgs> sequence)
		{
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x000058F8 File Offset: 0x00003AF8
		[Token(Token = "0x17000482")]
		public override StepActionType StepActionType
		{
			[Token(Token = "0x6001978")]
			[Address(RVA = "0x6B17", Offset = "0x6B17", VA = "0x6B17", Slot = "4")]
			get
			{
				return StepActionType.None;
			}
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001979")]
		[Address(RVA = "0x6B18", Offset = "0x6B18", VA = "0x6B18", Slot = "6")]
		public override void Hide()
		{
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600197A")]
		[Address(RVA = "0x6B19", Offset = "0x6B19", VA = "0x6B19", Slot = "5")]
		protected override void ShowNextInternal(StepActionType actionType)
		{
		}

		// Token: 0x04000D8B RID: 3467
		[Token(Token = "0x4000D8B")]
		[FieldOffset(Offset = "0x8")]
		private readonly GraphicPointerView _pointer;

		// Token: 0x04000D8C RID: 3468
		[Token(Token = "0x4000D8C")]
		[FieldOffset(Offset = "0xC")]
		private Queue<GraphicPointerView.GraphicPointerViewArgs> _queue;
	}
}
