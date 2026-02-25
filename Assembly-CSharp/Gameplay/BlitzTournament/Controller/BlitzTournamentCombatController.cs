using System;
using Gameplay.BlitzTournament.Events;
using Gameplay.BlitzTournament.Model;
using Gameplay.Combat.Control;
using Il2CppDummyDll;
using Protocol.Tournaments;
using ServicesNamespace;

namespace Gameplay.BlitzTournament.Controller
{
	// Token: 0x02000BD7 RID: 3031
	[Token(Token = "0x2000BD7")]
	public class BlitzTournamentCombatController : CombatController<BlitzTournamentCombatModel, BlitzTournamentCombatEvents>
	{
		// Token: 0x06004A40 RID: 19008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A40")]
		[Address(RVA = "0x98A2", Offset = "0x98A2", VA = "0x98A2")]
		public BlitzTournamentCombatController(BlitzTournamentService blitzTournamentService, ICombatService service, BlitzTournamentCombatModel model, BlitzTournamentCombatEvents events)
		{
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A41")]
		[Address(RVA = "0x98A3", Offset = "0x98A3", VA = "0x98A3", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06004A42 RID: 19010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A42")]
		[Address(RVA = "0x98A4", Offset = "0x98A4", VA = "0x98A4", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06004A43 RID: 19011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A43")]
		[Address(RVA = "0x98A5", Offset = "0x98A5", VA = "0x98A5")]
		private void FinalBattleCompleteEventHandler(ProtoFinalTnmCombatCompleteEvt evt)
		{
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A44")]
		[Address(RVA = "0x98A6", Offset = "0x98A6", VA = "0x98A6")]
		private void CurrentBattleCompleteEventHandler(ProtoCurrentTnmCombatCompleteEvt evt)
		{
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A45")]
		[Address(RVA = "0x98A7", Offset = "0x98A7", VA = "0x98A7")]
		public void AppendGameOver()
		{
		}

		// Token: 0x0400287E RID: 10366
		[Token(Token = "0x400287E")]
		[FieldOffset(Offset = "0x20")]
		private BlitzTournamentService _blitzTournamentService;
	}
}
