using System;
using Core.Animations;
using Il2CppDummyDll;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

namespace Animations
{
	// Token: 0x0200133A RID: 4922
	[Token(Token = "0x200133A")]
	public class InIdleOutSpineAnimation : MonoBehaviour
	{
		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x0600748A RID: 29834 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001779")]
		public TextMeshProUGUI TextLabel
		{
			[Token(Token = "0x600748A")]
			[Address(RVA = "0xBE56", Offset = "0xBE56", VA = "0xBE56")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x0600748B RID: 29835 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700177A")]
		public ParticleSystem[] Particles
		{
			[Token(Token = "0x600748B")]
			[Address(RVA = "0xBE57", Offset = "0xBE57", VA = "0xBE57")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600748C RID: 29836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600748C")]
		[Address(RVA = "0xBE58", Offset = "0xBE58", VA = "0xBE58")]
		public void StartAnimation()
		{
		}

		// Token: 0x0600748D RID: 29837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600748D")]
		[Address(RVA = "0xBE59", Offset = "0xBE59", VA = "0xBE59")]
		private void AnimationOnCompleteEvent(IGameAnimation obj)
		{
		}

		// Token: 0x0600748E RID: 29838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600748E")]
		[Address(RVA = "0xBE5A", Offset = "0xBE5A", VA = "0xBE5A")]
		public void FinishAnimation()
		{
		}

		// Token: 0x0600748F RID: 29839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600748F")]
		[Address(RVA = "0xBE5B", Offset = "0xBE5B", VA = "0xBE5B")]
		[UsedImplicitly]
		public void StartParticleAnimations()
		{
		}

		// Token: 0x06007490 RID: 29840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007490")]
		[Address(RVA = "0xBE5C", Offset = "0xBE5C", VA = "0xBE5C")]
		[UsedImplicitly]
		public void StopParticleAnimations()
		{
		}

		// Token: 0x06007491 RID: 29841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007491")]
		[Address(RVA = "0xBE5D", Offset = "0xBE5D", VA = "0xBE5D")]
		public InIdleOutSpineAnimation()
		{
		}

		// Token: 0x04003D24 RID: 15652
		[Token(Token = "0x4003D24")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameSpineUiAnimation _animation;

		// Token: 0x04003D25 RID: 15653
		[Token(Token = "0x4003D25")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04003D26 RID: 15654
		[Token(Token = "0x4003D26")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticleSystem[] _particleSystems;

		// Token: 0x04003D27 RID: 15655
		[Token(Token = "0x4003D27")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _textLabel;

		// Token: 0x04003D28 RID: 15656
		[Token(Token = "0x4003D28")]
		public const string STATE_START = "start";

		// Token: 0x04003D29 RID: 15657
		[Token(Token = "0x4003D29")]
		public const string STATE_IDLE = "idle";

		// Token: 0x04003D2A RID: 15658
		[Token(Token = "0x4003D2A")]
		public const string STATE_END = "end";
	}
}
