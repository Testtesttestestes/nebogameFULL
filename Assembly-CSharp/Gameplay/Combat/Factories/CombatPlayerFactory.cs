using System;
using Core.Data;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Combat.Factories
{
	// Token: 0x020009AA RID: 2474
	[Token(Token = "0x20009AA")]
	public class CombatPlayerFactory : ICombatPlayerFactory, IDisposable
	{
		// Token: 0x06003B11 RID: 15121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B11")]
		[Address(RVA = "0x8A74", Offset = "0x8A74", VA = "0x8A74", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x06003B12 RID: 15122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003B12")]
		[Address(RVA = "0x8A75", Offset = "0x8A75", VA = "0x8A75", Slot = "4")]
		public CombatPlayer Create(PlayerInfo playerInfo, UserData user, ICombatSpellDataFactory spellDataFactory)
		{
			return null;
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B13")]
		[Address(RVA = "0x8A76", Offset = "0x8A76", VA = "0x8A76")]
		public CombatPlayerFactory()
		{
		}
	}
}
