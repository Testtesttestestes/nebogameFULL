using System;
using Gameplay.Boss.Model;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.BossCombat.Factories
{
	// Token: 0x02000B40 RID: 2880
	[Token(Token = "0x2000B40")]
	public class BossCombatSpellDataFactory : ICombatSpellDataFactory, IDisposable
	{
		// Token: 0x060045D8 RID: 17880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045D8")]
		[Address(RVA = "0x947A", Offset = "0x947A", VA = "0x947A", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045D9")]
		[Address(RVA = "0x947B", Offset = "0x947B", VA = "0x947B")]
		public BossCombatSpellDataFactory(BossInstanceModel bossInstanceModel)
		{
		}

		// Token: 0x060045DA RID: 17882 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60045DA")]
		[Address(RVA = "0x947C", Offset = "0x947C", VA = "0x947C", Slot = "4")]
		public CombatSpellData Create(SpellCombat spell)
		{
			return null;
		}

		// Token: 0x04002624 RID: 9764
		[Token(Token = "0x4002624")]
		[FieldOffset(Offset = "0x8")]
		private BossInstanceModel _bossInstanceModel;
	}
}
