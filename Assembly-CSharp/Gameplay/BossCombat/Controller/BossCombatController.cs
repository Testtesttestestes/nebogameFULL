using System;
using Gameplay.BossCombat.Model;
using Gameplay.Combat.Control;
using Il2CppDummyDll;
using ServicesNamespace;

namespace Gameplay.BossCombat.Controller
{
	// Token: 0x02000B42 RID: 2882
	[Token(Token = "0x2000B42")]
	public class BossCombatController : CombatController<BossCombatModel, BossCombatEvents>
	{
		// Token: 0x060045DD RID: 17885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045DD")]
		[Address(RVA = "0x947F", Offset = "0x947F", VA = "0x947F")]
		public BossCombatController(ICombatService service, BossCombatModel model, BossCombatEvents events)
		{
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045DE")]
		[Address(RVA = "0x9480", Offset = "0x9480", VA = "0x9480", Slot = "7")]
		protected override void HandleRun()
		{
		}
	}
}
