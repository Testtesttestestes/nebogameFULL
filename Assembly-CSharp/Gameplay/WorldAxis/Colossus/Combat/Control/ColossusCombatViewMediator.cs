using System;
using Gameplay.Combat.Control;
using Gameplay.VortexCombat.Control;
using Gameplay.WorldAxis.Colossus.Combat.Model;
using Gameplay.WorldAxis.Colossus.Combat.View;
using Il2CppDummyDll;

namespace Gameplay.WorldAxis.Colossus.Combat.Control
{
	// Token: 0x02000340 RID: 832
	[Token(Token = "0x2000340")]
	public class ColossusCombatViewMediator : AbstractCombatViewMediator<ColossusCombatModel, ColossusCombatEvents, ColossusCombatController, ColossusCombatView>
	{
		// Token: 0x06001328 RID: 4904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001328")]
		[Address(RVA = "0x6519", Offset = "0x6519", VA = "0x6519", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001329")]
		[Address(RVA = "0x651A", Offset = "0x651A", VA = "0x651A")]
		public ColossusCombatViewMediator(VortexCombatViewMediator mediator, ColossusCombatModel model, ColossusCombatEvents events, ColossusCombatController controller)
		{
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600132B RID: 4907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FE")]
		public override ColossusCombatView View
		{
			[Token(Token = "0x600132A")]
			[Address(RVA = "0x651B", Offset = "0x651B", VA = "0x651B", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x600132B")]
			[Address(RVA = "0x651C", Offset = "0x651C", VA = "0x651C", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600132D RID: 4909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FF")]
		public override ColossusCombatEvents Events
		{
			[Token(Token = "0x600132C")]
			[Address(RVA = "0x651D", Offset = "0x651D", VA = "0x651D", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x600132D")]
			[Address(RVA = "0x651E", Offset = "0x651E", VA = "0x651E", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x04000A3C RID: 2620
		[Token(Token = "0x4000A3C")]
		[FieldOffset(Offset = "0x34")]
		private VortexCombatViewMediator _mediator;
	}
}
