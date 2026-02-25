using System;
using Gameplay.Combat.Control;
using Gameplay.Combat.Events;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Duel;
using ServicesNamespace;
using Utils;

namespace Gameplay.Duel.Controller
{
	// Token: 0x02000864 RID: 2148
	[Token(Token = "0x2000864")]
	public class DuelCombatController : CombatController<CombatModel, CombatEvents>
	{
		// Token: 0x06003268 RID: 12904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003268")]
		[Address(RVA = "0x82BD", Offset = "0x82BD", VA = "0x82BD")]
		public DuelCombatController(DuelService duelService, ICombatService service, CombatModel model, CombatEvents events, bool showCombatWaitWindow)
		{
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003269")]
		[Address(RVA = "0x82BE", Offset = "0x82BE", VA = "0x82BE", Slot = "17")]
		protected override void HandleAwait(BackTime timeout)
		{
		}

		// Token: 0x0600326A RID: 12906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600326A")]
		[Address(RVA = "0x82BF", Offset = "0x82BF", VA = "0x82BF", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x0600326B RID: 12907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600326B")]
		[Address(RVA = "0x82C0", Offset = "0x82C0", VA = "0x82C0", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x0600326C RID: 12908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600326C")]
		[Address(RVA = "0x82C1", Offset = "0x82C1", VA = "0x82C1")]
		private void PaidOffEventHandler(ProtoDuelPaidOffEvt evt)
		{
		}

		// Token: 0x0600326D RID: 12909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600326D")]
		[Address(RVA = "0x82C2", Offset = "0x82C2", VA = "0x82C2", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x04001BA9 RID: 7081
		[Token(Token = "0x4001BA9")]
		[FieldOffset(Offset = "0x20")]
		private readonly bool _showCombatWait;

		// Token: 0x04001BAA RID: 7082
		[Token(Token = "0x4001BAA")]
		[FieldOffset(Offset = "0x24")]
		private DuelService _duelService;
	}
}
