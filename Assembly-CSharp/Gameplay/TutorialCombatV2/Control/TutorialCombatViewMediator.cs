using System;
using Gameplay.Combat.Control;
using Gameplay.TutorialCombatV2.Model;
using Il2CppDummyDll;

namespace Gameplay.TutorialCombatV2.Control
{
	// Token: 0x02000454 RID: 1108
	[Token(Token = "0x2000454")]
	public class TutorialCombatViewMediator : OneOnOneCombatViewMediator<TutorialCombatModel, TutorialCombatEvents, TutorialCombatController>
	{
		// Token: 0x06001A40 RID: 6720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A40")]
		[Address(RVA = "0x6BD7", Offset = "0x6BD7", VA = "0x6BD7")]
		public TutorialCombatViewMediator(TutorialCombatModel model, TutorialCombatEvents events, TutorialCombatController controller)
		{
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A41")]
		[Address(RVA = "0x6BD8", Offset = "0x6BD8", VA = "0x6BD8", Slot = "39")]
		protected override void UpdateExperience()
		{
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A42")]
		[Address(RVA = "0x6BD9", Offset = "0x6BD9", VA = "0x6BD9", Slot = "37")]
		protected override void HandleGameOver()
		{
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A43")]
		[Address(RVA = "0x6BDA", Offset = "0x6BDA", VA = "0x6BDA", Slot = "34")]
		protected override void HandleFieldInteraction()
		{
		}
	}
}
