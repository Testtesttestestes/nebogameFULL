using System;
using Il2CppDummyDll;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x0200043F RID: 1087
	[Token(Token = "0x200043F")]
	public abstract class TutorialStepsQueueBase
	{
		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060019A1 RID: 6561
		[Token(Token = "0x17000486")]
		public abstract StepActionType StepActionType { [Token(Token = "0x60019A1")] get; }

		// Token: 0x060019A2 RID: 6562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019A2")]
		[Address(RVA = "0x1CE0", Offset = "0x1CE0", VA = "0x1CE0")]
		public void ShowNextStep(StepActionType actionType, ICompleteCallback completeCallback)
		{
		}

		// Token: 0x060019A3 RID: 6563
		[Token(Token = "0x60019A3")]
		protected abstract void ShowNextInternal(StepActionType actionType);

		// Token: 0x060019A4 RID: 6564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019A4")]
		[Address(RVA = "0x6B3D", Offset = "0x6B3D", VA = "0x6B3D")]
		private void Unsubscribe(ICompleteCallback callback)
		{
		}

		// Token: 0x060019A5 RID: 6565
		[Token(Token = "0x60019A5")]
		public abstract void Hide();

		// Token: 0x060019A6 RID: 6566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019A6")]
		[Address(RVA = "0x6B3E", Offset = "0x6B3E", VA = "0x6B3E")]
		protected TutorialStepsQueueBase()
		{
		}
	}
}
