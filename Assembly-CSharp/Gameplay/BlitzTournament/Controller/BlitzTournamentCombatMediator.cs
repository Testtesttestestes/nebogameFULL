using System;
using Gameplay.BlitzTournament.Events;
using Gameplay.BlitzTournament.Model;
using Gameplay.Combat.Control;
using Il2CppDummyDll;
using Protocol.Tournaments;

namespace Gameplay.BlitzTournament.Controller
{
	// Token: 0x02000BD8 RID: 3032
	[Token(Token = "0x2000BD8")]
	public class BlitzTournamentCombatMediator : OneOnOneCombatViewMediator<BlitzTournamentCombatModel, BlitzTournamentCombatEvents, BlitzTournamentCombatController>
	{
		// Token: 0x06004A46 RID: 19014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A46")]
		[Address(RVA = "0x98A8", Offset = "0x98A8", VA = "0x98A8")]
		public BlitzTournamentCombatMediator(BlitzTournamentCombatModel model, BlitzTournamentCombatEvents events, BlitzTournamentCombatController controller)
		{
		}

		// Token: 0x17000F08 RID: 3848
		// (set) Token: 0x06004A47 RID: 19015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F08")]
		public override BlitzTournamentCombatEvents Events
		{
			[Token(Token = "0x6004A47")]
			[Address(RVA = "0x98A9", Offset = "0x98A9", VA = "0x98A9", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004A48 RID: 19016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A48")]
		[Address(RVA = "0x98AA", Offset = "0x98AA", VA = "0x98AA")]
		private void CurrentBattleCompletedEventHandler(ProtoCurrentTnmCombatCompleteEvt evt)
		{
		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A49")]
		[Address(RVA = "0x98AB", Offset = "0x98AB", VA = "0x98AB")]
		private void FinalBattleCompletedEventHandler(ProtoFinalTnmCombatCompleteEvt evt)
		{
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A4A")]
		[Address(RVA = "0x98AC", Offset = "0x98AC", VA = "0x98AC")]
		private void HandleBattleComplete(in ulong loserId, in ulong winnerId)
		{
		}

		// Token: 0x06004A4B RID: 19019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A4B")]
		[Address(RVA = "0x98AD", Offset = "0x98AD", VA = "0x98AD", Slot = "37")]
		protected override void HandleGameOver()
		{
		}

		// Token: 0x06004A4C RID: 19020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A4C")]
		[Address(RVA = "0x98AE", Offset = "0x98AE", VA = "0x98AE")]
		private void ReturnToTournament()
		{
		}

		// Token: 0x0400287F RID: 10367
		[Token(Token = "0x400287F")]
		[FieldOffset(Offset = "0x34")]
		private bool _finalCombat;
	}
}
