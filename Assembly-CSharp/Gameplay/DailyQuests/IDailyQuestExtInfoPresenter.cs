using System;
using Gameplay.DailyQuests.Model;
using Gameplay.DailyQuests.View;
using Il2CppDummyDll;

namespace Gameplay.DailyQuests
{
	// Token: 0x02000869 RID: 2153
	[Token(Token = "0x2000869")]
	public interface IDailyQuestExtInfoPresenter
	{
		// Token: 0x060032A7 RID: 12967
		[Token(Token = "0x60032A7")]
		DailyQuestReadViewWindow ShowDailyQuestInfoWindow(IQuest quest);
	}
}
