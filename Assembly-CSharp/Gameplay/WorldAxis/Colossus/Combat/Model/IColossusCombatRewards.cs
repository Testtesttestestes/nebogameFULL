using System;
using Il2CppDummyDll;
using Protocol.Common;

namespace Gameplay.WorldAxis.Colossus.Combat.Model
{
	// Token: 0x0200033C RID: 828
	[Token(Token = "0x200033C")]
	public interface IColossusCombatRewards
	{
		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06001315 RID: 4885
		[Token(Token = "0x170002F9")]
		int[] ColossusScores { [Token(Token = "0x6001315")] get; }

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06001316 RID: 4886
		[Token(Token = "0x170002FA")]
		double CombatWinTakeOffTax { [Token(Token = "0x6001316")] get; }

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06001317 RID: 4887
		[Token(Token = "0x170002FB")]
		ResourceSet CombatWinTakeOff { [Token(Token = "0x6001317")] get; }

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06001318 RID: 4888
		[Token(Token = "0x170002FC")]
		ResourceSet CombatWinReward { [Token(Token = "0x6001318")] get; }

		// Token: 0x06001319 RID: 4889
		[Token(Token = "0x6001319")]
		ResourceSet GetResources();
	}
}
