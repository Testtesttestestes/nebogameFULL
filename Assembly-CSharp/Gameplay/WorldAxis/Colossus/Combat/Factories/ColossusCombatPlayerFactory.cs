using System;
using Core.Data;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.WorldAxis.Colossus.Combat.Factories
{
	// Token: 0x0200033D RID: 829
	[Token(Token = "0x200033D")]
	public class ColossusCombatPlayerFactory : ICombatPlayerFactory, IDisposable
	{
		// Token: 0x0600131A RID: 4890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131A")]
		[Address(RVA = "0x650B", Offset = "0x650B", VA = "0x650B", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600131B")]
		[Address(RVA = "0x650C", Offset = "0x650C", VA = "0x650C", Slot = "4")]
		public CombatPlayer Create(PlayerInfo playerInfo, UserData user, ICombatSpellDataFactory spellDataFactory)
		{
			return null;
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131C")]
		[Address(RVA = "0x650D", Offset = "0x650D", VA = "0x650D")]
		public ColossusCombatPlayerFactory()
		{
		}
	}
}
