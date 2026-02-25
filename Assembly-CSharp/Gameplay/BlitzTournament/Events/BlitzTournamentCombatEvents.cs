using System;
using Gameplay.Combat.Events;
using Il2CppDummyDll;
using Protocol.Tournaments;

namespace Gameplay.BlitzTournament.Events
{
	// Token: 0x02000BD5 RID: 3029
	[Token(Token = "0x2000BD5")]
	public class BlitzTournamentCombatEvents : CombatEvents
	{
		// Token: 0x06004A3E RID: 19006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A3E")]
		[Address(RVA = "0x98A0", Offset = "0x98A0", VA = "0x98A0")]
		public BlitzTournamentCombatEvents()
		{
		}

		// Token: 0x04002874 RID: 10356
		[Token(Token = "0x4002874")]
		[FieldOffset(Offset = "0x70")]
		public Action<ProtoFinalTnmCombatCompleteEvt> FinalBattleCompletedEvent;

		// Token: 0x04002875 RID: 10357
		[Token(Token = "0x4002875")]
		[FieldOffset(Offset = "0x74")]
		public Action<ProtoCurrentTnmCombatCompleteEvt> CurrentBattleCompletedEvent;
	}
}
