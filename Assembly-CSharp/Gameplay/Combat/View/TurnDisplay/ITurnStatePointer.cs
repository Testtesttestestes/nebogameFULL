using System;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Combat.View.TurnDisplay
{
	// Token: 0x02000934 RID: 2356
	[Token(Token = "0x2000934")]
	public interface ITurnStatePointer
	{
		// Token: 0x14000178 RID: 376
		// (add) Token: 0x06003791 RID: 14225
		// (remove) Token: 0x06003792 RID: 14226
		[Token(Token = "0x14000178")]
		event Action TimeOutEvent;

		// Token: 0x14000179 RID: 377
		// (add) Token: 0x06003793 RID: 14227
		// (remove) Token: 0x06003794 RID: 14228
		[Token(Token = "0x14000179")]
		event Action TurnStateChangedEvent;

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06003795 RID: 14229
		[Token(Token = "0x17000AF3")]
		TurnStates TurnState { [Token(Token = "0x6003795")] get; }

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06003796 RID: 14230
		// (set) Token: 0x06003797 RID: 14231
		[Token(Token = "0x17000AF4")]
		IGameAudio GameAudio { [Token(Token = "0x6003796")] get; [Token(Token = "0x6003797")] set; }

		// Token: 0x06003798 RID: 14232
		[Token(Token = "0x6003798")]
		void SetTurnState(TurnStates state, float timeout);

		// Token: 0x06003799 RID: 14233
		[Token(Token = "0x6003799")]
		void Stop();
	}
}
