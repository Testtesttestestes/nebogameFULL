using System;
using Il2CppDummyDll;
using Protocol.Dic;
using Utils;

namespace Gameplay.DailyQuests.Model
{
	// Token: 0x02000882 RID: 2178
	[Token(Token = "0x2000882")]
	public interface IDailyQuest : IQuest
	{
		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06003344 RID: 13124
		[Token(Token = "0x17000A2B")]
		BackTime BackTime { [Token(Token = "0x6003344")] get; }

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06003345 RID: 13125
		[Token(Token = "0x17000A2C")]
		DailyQuestsDic Dic { [Token(Token = "0x6003345")] get; }
	}
}
