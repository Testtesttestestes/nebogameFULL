using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x0200043C RID: 1084
	[Token(Token = "0x200043C")]
	public class TutorialStepsConveyor
	{
		// Token: 0x06001996 RID: 6550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001996")]
		[Address(RVA = "0x6B35", Offset = "0x6B35", VA = "0x6B35")]
		public TutorialStepsConveyor(IEnumerable<StepActionType> actions)
		{
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001997")]
		[Address(RVA = "0x6B36", Offset = "0x6B36", VA = "0x6B36")]
		public void AppendQueue(TutorialStepsQueueBase queue)
		{
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001998")]
		[Address(RVA = "0x6B37", Offset = "0x6B37", VA = "0x6B37")]
		public void Continue()
		{
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001999")]
		[Address(RVA = "0x1CEB", Offset = "0x1CEB", VA = "0x1CEB")]
		private void Next()
		{
		}

		// Token: 0x04000DC9 RID: 3529
		[Token(Token = "0x4000DC9")]
		[FieldOffset(Offset = "0x8")]
		private readonly Queue<StepActionType> _actionsQueue;

		// Token: 0x04000DCA RID: 3530
		[Token(Token = "0x4000DCA")]
		[FieldOffset(Offset = "0xC")]
		private List<TutorialStepsQueueBase> _stepQueues;

		// Token: 0x04000DCB RID: 3531
		[Token(Token = "0x4000DCB")]
		[FieldOffset(Offset = "0x10")]
		private TutorialStepAction _currentStep;
	}
}
