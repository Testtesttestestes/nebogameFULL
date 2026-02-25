using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x0200043D RID: 1085
	[Token(Token = "0x200043D")]
	public class TutorialStepAction : ICompleteCallback, IDisposable
	{
		// Token: 0x0600199A RID: 6554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600199A")]
		[Address(RVA = "0x6B38", Offset = "0x6B38", VA = "0x6B38")]
		public TutorialStepAction(StepActionType actionType)
		{
		}

		// Token: 0x1400011A RID: 282
		// (add) Token: 0x0600199B RID: 6555 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600199C RID: 6556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400011A")]
		public event Action<ICompleteCallback> CompleteEvent
		{
			[Token(Token = "0x600199B")]
			[Address(RVA = "0x6B39", Offset = "0x6B39", VA = "0x6B39", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600199C")]
			[Address(RVA = "0x6B3A", Offset = "0x6B3A", VA = "0x6B3A", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600199D")]
		[Address(RVA = "0x6B3B", Offset = "0x6B3B", VA = "0x6B3B")]
		public void Complete()
		{
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600199E")]
		[Address(RVA = "0x6B3C", Offset = "0x6B3C", VA = "0x6B3C", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000DCC RID: 3532
		[Token(Token = "0x4000DCC")]
		[FieldOffset(Offset = "0x8")]
		public readonly StepActionType ActionType;
	}
}
