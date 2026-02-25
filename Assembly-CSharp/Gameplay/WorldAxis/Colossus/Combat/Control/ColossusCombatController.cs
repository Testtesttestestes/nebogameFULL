using System;
using System.Runtime.CompilerServices;
using Gameplay.Combat.Control;
using Gameplay.VortexCombat.Control;
using Gameplay.WorldAxis.Colossus.Combat.Model;
using Il2CppDummyDll;
using Protocol.Partycombat;
using ServicesNamespace;

namespace Gameplay.WorldAxis.Colossus.Combat.Control
{
	// Token: 0x0200033F RID: 831
	[Token(Token = "0x200033F")]
	public class ColossusCombatController : CombatController<ColossusCombatModel, ColossusCombatEvents>
	{
		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001321 RID: 4897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FD")]
		public VortexCombatController VortexCombatController
		{
			[Token(Token = "0x6001320")]
			[Address(RVA = "0x6511", Offset = "0x6511", VA = "0x6511")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001321")]
			[Address(RVA = "0x6512", Offset = "0x6512", VA = "0x6512")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001322")]
		[Address(RVA = "0x6513", Offset = "0x6513", VA = "0x6513", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001323")]
		[Address(RVA = "0x6514", Offset = "0x6514", VA = "0x6514")]
		public ColossusCombatController(VortexCombatController vortexCombatController, ICombatService service, ColossusCombatModel model, ColossusCombatEvents events)
		{
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001324")]
		[Address(RVA = "0x6515", Offset = "0x6515", VA = "0x6515", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001325")]
		[Address(RVA = "0x6516", Offset = "0x6516", VA = "0x6516", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001326")]
		[Address(RVA = "0x6517", Offset = "0x6517", VA = "0x6517")]
		private void HandleInitEvent()
		{
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001327")]
		[Address(RVA = "0x6518", Offset = "0x6518", VA = "0x6518")]
		private void HandleCombatCompleteEvent(ProtoCombatCompleteEvt evt)
		{
		}
	}
}
