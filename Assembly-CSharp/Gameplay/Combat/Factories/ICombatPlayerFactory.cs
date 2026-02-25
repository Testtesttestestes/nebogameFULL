using System;
using Core.Data;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Combat.Factories
{
	// Token: 0x020009AC RID: 2476
	[Token(Token = "0x20009AC")]
	public interface ICombatPlayerFactory : IDisposable
	{
		// Token: 0x06003B17 RID: 15127
		[Token(Token = "0x6003B17")]
		CombatPlayer Create(PlayerInfo playerInfo, UserData user, ICombatSpellDataFactory spellDataFactory);
	}
}
