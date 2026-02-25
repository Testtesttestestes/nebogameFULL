using System;
using Gameplay.BossCombat.Model;
using Gameplay.Combat.Control;
using Gameplay.Combat.View;
using Il2CppDummyDll;

namespace Gameplay.BossCombat.Controller
{
	// Token: 0x02000B43 RID: 2883
	[Token(Token = "0x2000B43")]
	public class BossCombatViewMediator : OneOnOneCombatViewMediator<BossCombatModel, BossCombatEvents, BossCombatController>
	{
		// Token: 0x060045DF RID: 17887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045DF")]
		[Address(RVA = "0x9481", Offset = "0x9481", VA = "0x9481")]
		public BossCombatViewMediator(BossCombatModel model, BossCombatEvents events, BossCombatController controller)
		{
		}

		// Token: 0x060045E0 RID: 17888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045E0")]
		[Address(RVA = "0x9482", Offset = "0x9482", VA = "0x9482", Slot = "37")]
		protected override void HandleGameOver()
		{
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x0000D188 File Offset: 0x0000B388
		[Token(Token = "0x60045E1")]
		[Address(RVA = "0x9483", Offset = "0x9483", VA = "0x9483", Slot = "22")]
		protected override bool HandleGameOverWindowCloseRequestEvent(CombatGameOverView view)
		{
			return default(bool);
		}
	}
}
