using System;
using System.Runtime.CompilerServices;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Combat.View.Animations
{
	// Token: 0x0200097B RID: 2427
	[Token(Token = "0x200097B")]
	public class AntiqEffectCombatAnimationContentDecorator : CombatAnimationContentDecorator
	{
		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x060039CA RID: 14794 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B57")]
		public ProtoAntiqEffectTriggeredEvt.Types.EffectResult Effect
		{
			[Token(Token = "0x60039CA")]
			[Address(RVA = "0x8958", Offset = "0x8958", VA = "0x8958")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039CB")]
		[Address(RVA = "0x2A46", Offset = "0x2A46", VA = "0x2A46")]
		public AntiqEffectCombatAnimationContentDecorator(IGameAudio audio, CombatAnimation.IContent content, string text, CombatEventsToast toast, ProtoAntiqEffectTriggeredEvt.Types.EffectResult effect)
		{
		}
	}
}
