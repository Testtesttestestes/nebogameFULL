using System;
using Core.Data;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.VortexCombat.Factories
{
	// Token: 0x020003B6 RID: 950
	[Token(Token = "0x20003B6")]
	public class VortexCombatPlayerFactory : ICombatPlayerFactory, IDisposable
	{
		// Token: 0x0600163C RID: 5692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163C")]
		[Address(RVA = "0x67FD", Offset = "0x67FD", VA = "0x67FD", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600163D")]
		[Address(RVA = "0x67FE", Offset = "0x67FE", VA = "0x67FE", Slot = "4")]
		public CombatPlayer Create(PlayerInfo playerInfo, UserData user, ICombatSpellDataFactory spellDataFactory)
		{
			return null;
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163E")]
		[Address(RVA = "0x67FF", Offset = "0x67FF", VA = "0x67FF")]
		public VortexCombatPlayerFactory()
		{
		}
	}
}
