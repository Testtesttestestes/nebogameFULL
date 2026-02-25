using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.DailyQuests.Model
{
	// Token: 0x02000883 RID: 2179
	[Token(Token = "0x2000883")]
	public interface IGoal : IQuest
	{
		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06003346 RID: 13126
		[Token(Token = "0x17000A2D")]
		IList<GameActivityDic.Types.URI> Activities { [Token(Token = "0x6003346")] get; }

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06003347 RID: 13127
		[Token(Token = "0x17000A2E")]
		DailyGoalDic Dic { [Token(Token = "0x6003347")] get; }
	}
}
