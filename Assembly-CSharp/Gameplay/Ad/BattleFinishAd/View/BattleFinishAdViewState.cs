using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.Ad.BattleFinishAd.View
{
	// Token: 0x02000DB6 RID: 3510
	[Token(Token = "0x2000DB6")]
	public class BattleFinishAdViewState : MonoBehaviourWithStates<BattleFinishAdViewState.State>
	{
		// Token: 0x060055B8 RID: 21944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055B8")]
		[Address(RVA = "0xA358", Offset = "0xA358", VA = "0xA358")]
		public BattleFinishAdViewState()
		{
		}

		// Token: 0x02000DB7 RID: 3511
		[Token(Token = "0x2000DB7")]
		public enum State
		{
			// Token: 0x04002E72 RID: 11890
			[Token(Token = "0x4002E72")]
			Default,
			// Token: 0x04002E73 RID: 11891
			[Token(Token = "0x4002E73")]
			AdWatched
		}
	}
}
