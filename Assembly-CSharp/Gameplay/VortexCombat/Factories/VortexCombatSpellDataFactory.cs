using System;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.VortexCombat.Factories
{
	// Token: 0x020003B7 RID: 951
	[Token(Token = "0x20003B7")]
	public class VortexCombatSpellDataFactory : ICombatSpellDataFactory, IDisposable
	{
		// Token: 0x0600163F RID: 5695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x6800", Offset = "0x6800", VA = "0x6800", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001640")]
		[Address(RVA = "0x6801", Offset = "0x6801", VA = "0x6801", Slot = "4")]
		public CombatSpellData Create(SpellCombat spell)
		{
			return null;
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001641")]
		[Address(RVA = "0x6802", Offset = "0x6802", VA = "0x6802")]
		public VortexCombatSpellDataFactory()
		{
		}
	}
}
