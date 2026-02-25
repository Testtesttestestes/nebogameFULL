using System;
using Gameplay.Combat.Events;
using Il2CppDummyDll;
using Protocol.Tournaments;

namespace Gameplay.Tournaments.Events
{
	// Token: 0x020004BA RID: 1210
	[Token(Token = "0x20004BA")]
	public class TournamentCombatEvents : CombatEvents
	{
		// Token: 0x06001CA1 RID: 7329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA1")]
		[Address(RVA = "0x6E20", Offset = "0x6E20", VA = "0x6E20")]
		public TournamentCombatEvents()
		{
		}

		// Token: 0x04000F9D RID: 3997
		[Token(Token = "0x4000F9D")]
		[FieldOffset(Offset = "0x70")]
		public Action<ProtoFinalTnmCombatCompleteEvt> FinalBattleCompletedEvent;

		// Token: 0x04000F9E RID: 3998
		[Token(Token = "0x4000F9E")]
		[FieldOffset(Offset = "0x74")]
		public Action<ProtoCurrentTnmCombatCompleteEvt> CurrentBattleCompletedEvent;

		// Token: 0x04000F9F RID: 3999
		[Token(Token = "0x4000F9F")]
		[FieldOffset(Offset = "0x78")]
		public Action CombatViewingStopped;
	}
}
