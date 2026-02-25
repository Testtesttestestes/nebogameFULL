using System;
using Gameplay.Boss.Controller;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Il2CppDummyDll;

namespace Gameplay.Boss.View
{
	// Token: 0x02000B4F RID: 2895
	[Token(Token = "0x2000B4F")]
	public interface IBossWindowView
	{
		// Token: 0x06004606 RID: 17926
		[Token(Token = "0x6004606")]
		void Init(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller);
	}
}
