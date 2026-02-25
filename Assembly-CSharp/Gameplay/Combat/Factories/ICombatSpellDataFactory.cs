using System;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Combat.Factories
{
	// Token: 0x020009AD RID: 2477
	[Token(Token = "0x20009AD")]
	public interface ICombatSpellDataFactory : IDisposable
	{
		// Token: 0x06003B18 RID: 15128
		[Token(Token = "0x6003B18")]
		CombatSpellData Create(SpellCombat spell);
	}
}
