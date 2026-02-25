using System;
using Gameplay.BossCombat.Model;
using Gameplay.Combat.Control;
using Gameplay.Combat.View;
using Il2CppDummyDll;

namespace Gameplay.BossCombat.Controller
{
	// Token: 0x02000B45 RID: 2885
	[Token(Token = "0x2000B45")]
	public class BossMinionCombatViewMediator : OneOnOneCombatViewMediator<BossMinionCombatModel, BossMinionCombatEvents, BossMinionCombatController>
	{
		// Token: 0x060045E8 RID: 17896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045E8")]
		[Address(RVA = "0x948A", Offset = "0x948A", VA = "0x948A")]
		public BossMinionCombatViewMediator(BossMinionCombatModel model, BossMinionCombatEvents events, BossMinionCombatController controller)
		{
		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045E9")]
		[Address(RVA = "0x948B", Offset = "0x948B", VA = "0x948B", Slot = "37")]
		protected override void HandleGameOver()
		{
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x0000D1A0 File Offset: 0x0000B3A0
		[Token(Token = "0x60045EA")]
		[Address(RVA = "0x948C", Offset = "0x948C", VA = "0x948C", Slot = "22")]
		protected override bool HandleGameOverWindowCloseRequestEvent(CombatGameOverView view)
		{
			return default(bool);
		}
	}
}
