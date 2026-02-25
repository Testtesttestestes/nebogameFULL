using System;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Clans.Combat.Factories
{
	// Token: 0x02000AA1 RID: 2721
	[Token(Token = "0x2000AA1")]
	public class ClanCombatSpellDataFactory : ICombatSpellDataFactory, IDisposable
	{
		// Token: 0x06004176 RID: 16758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004176")]
		[Address(RVA = "0x902D", Offset = "0x902D", VA = "0x902D", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x06004177 RID: 16759 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004177")]
		[Address(RVA = "0x902E", Offset = "0x902E", VA = "0x902E", Slot = "4")]
		public CombatSpellData Create(SpellCombat spell)
		{
			return null;
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004178")]
		[Address(RVA = "0x902F", Offset = "0x902F", VA = "0x902F")]
		public ClanCombatSpellDataFactory()
		{
		}
	}
}
