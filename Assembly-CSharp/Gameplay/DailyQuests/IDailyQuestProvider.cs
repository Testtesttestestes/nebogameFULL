using System;
using Gameplay.DailyQuests.Events;
using Gameplay.DailyQuests.Model;
using Il2CppDummyDll;

namespace Gameplay.DailyQuests
{
	// Token: 0x0200086A RID: 2154
	[Token(Token = "0x200086A")]
	public interface IDailyQuestProvider
	{
		// Token: 0x060032A8 RID: 12968
		[Token(Token = "0x60032A8")]
		IDailyQuest GetQuest(uint id);

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x060032A9 RID: 12969
		[Token(Token = "0x170009FB")]
		DailyQuestEvents Events { [Token(Token = "0x60032A9")] get; }
	}
}
