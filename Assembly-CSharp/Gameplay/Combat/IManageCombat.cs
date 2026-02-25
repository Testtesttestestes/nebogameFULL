using System;
using Gameplay.Combat.View;
using Il2CppDummyDll;

namespace Gameplay.Combat
{
	// Token: 0x02000911 RID: 2321
	[Token(Token = "0x2000911")]
	public interface IManageCombat
	{
		// Token: 0x0600368F RID: 13967
		[Token(Token = "0x600368F")]
		void SetView(AbstractCombatView view);
	}
}
