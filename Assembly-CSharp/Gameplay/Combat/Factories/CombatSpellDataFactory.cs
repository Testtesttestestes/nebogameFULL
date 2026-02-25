using System;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Combat.Factories
{
	// Token: 0x020009AB RID: 2475
	[Token(Token = "0x20009AB")]
	public class CombatSpellDataFactory : ICombatSpellDataFactory, IDisposable
	{
		// Token: 0x06003B14 RID: 15124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B14")]
		[Address(RVA = "0x8A77", Offset = "0x8A77", VA = "0x8A77", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003B15")]
		[Address(RVA = "0x8A78", Offset = "0x8A78", VA = "0x8A78", Slot = "4")]
		public CombatSpellData Create(SpellCombat spell)
		{
			return null;
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B16")]
		[Address(RVA = "0x8A79", Offset = "0x8A79", VA = "0x8A79")]
		public CombatSpellDataFactory()
		{
		}
	}
}
