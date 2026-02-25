using System;
using Il2CppDummyDll;

namespace Gameplay.Combat.View.Spells
{
	// Token: 0x0200093F RID: 2367
	[Token(Token = "0x200093F")]
	public interface ICombatSpellDisplay
	{
		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06003804 RID: 14340
		// (set) Token: 0x06003805 RID: 14341
		[Token(Token = "0x17000B0E")]
		int Count { [Token(Token = "0x6003804")] get; [Token(Token = "0x6003805")] set; }

		// Token: 0x06003806 RID: 14342
		[Token(Token = "0x6003806")]
		CombatSpellButton GetNexButton();

		// Token: 0x06003807 RID: 14343
		[Token(Token = "0x6003807")]
		void Reset();
	}
}
