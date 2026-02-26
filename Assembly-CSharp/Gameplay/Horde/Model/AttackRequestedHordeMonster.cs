using System;
using Core.Data;
using Gameplay.Accounts.Model.Data;
using Gameplay.ArenaCombat.Model;
using Gameplay.Horde.Model.Data;
using Gameplay.Isles.User;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Common;

namespace Gameplay.Horde.Model
{
	// Token: 0x020006FE RID: 1790
	[Token(Token = "0x20006FE")]
	public class AttackRequestedHordeMonster : ArenaCombatModel.AttackRequestedMonster
	{
		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06002AD9 RID: 10969 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000823")]
		public override MonsterData Monster
		{
			[Token(Token = "0x6002AD9")]
			[Address(RVA = "0x7B74", Offset = "0x7B74", VA = "0x7B74", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ADA")]
		[Address(RVA = "0x7B75", Offset = "0x7B75", VA = "0x7B75")]
		public AttackRequestedHordeMonster([NotNull] IMonsterSource source, [NotNull] HordeMonsterData hordMonster)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Horde_Model_AttackRequestedHordeMonster___ctor
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  return *(undefined4 *)(*(int *)(*(int *)(param1 + 0x10) + 0xc) + 0x24);
		}
		*/

		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002ADB")]
		[Address(RVA = "0x7B76", Offset = "0x7B76", VA = "0x7B76", Slot = "6")]
		public override ResourceSet GetStartMonsterAttackCost(BattleAccount account)
		{
			return null;
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002ADC")]
		[Address(RVA = "0x7B77", Offset = "0x7B77", VA = "0x7B77", Slot = "7")]
		public override ResourceSet GetResumeMonsterAttackCost(BattleAccount account)
		{
			return null;
		}

		// Token: 0x0400176E RID: 5998
		[Token(Token = "0x400176E")]
		[FieldOffset(Offset = "0x10")]
		private HordeMonsterData _hordMonster;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Monster ---
		void Gameplay_Horde_Model_AttackRequestedHordeMonster__get_Monster
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Gameplay_ArenaCombat_Model_ArenaCombatModel_AttackRequestedMonster__get_FromCave(param1,param2,0);
		  *(undefined4 *)(param1 + 0x10) = param3;
		  return;
		}
		*/

}
