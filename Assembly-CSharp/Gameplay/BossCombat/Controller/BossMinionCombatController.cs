using System;
using Gameplay.BossCombat.Model;
using Gameplay.Combat.Control;
using Il2CppDummyDll;
using Protocol.Boss;
using ServicesNamespace;

namespace Gameplay.BossCombat.Controller
{
	// Token: 0x02000B44 RID: 2884
	[Token(Token = "0x2000B44")]
	public class BossMinionCombatController : CombatController<BossMinionCombatModel, BossMinionCombatEvents>
	{
		// Token: 0x060045E3 RID: 17891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045E3")]
		[Address(RVA = "0x9485", Offset = "0x9485", VA = "0x9485", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045E4")]
		[Address(RVA = "0x9486", Offset = "0x9486", VA = "0x9486")]
		public BossMinionCombatController(BossService bossService, ICombatService service, BossMinionCombatModel model, BossMinionCombatEvents events)
		{
		}

		// Token: 0x060045E5 RID: 17893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045E5")]
		[Address(RVA = "0x9487", Offset = "0x9487", VA = "0x9487", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060045E6 RID: 17894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045E6")]
		[Address(RVA = "0x9488", Offset = "0x9488", VA = "0x9488", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x060045E7 RID: 17895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045E7")]
		[Address(RVA = "0x9489", Offset = "0x9489", VA = "0x9489")]
		private void BossServiceOnMinionAttackServerCancelationEvent(MinionAttackServerCancelationEvt evt)
		{
		}

		// Token: 0x04002626 RID: 9766
		[Token(Token = "0x4002626")]
		[FieldOffset(Offset = "0x20")]
		private BossService _bossService;
	}
}
