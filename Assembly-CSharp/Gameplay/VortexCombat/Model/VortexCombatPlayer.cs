using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Combat.Factories;
using Gameplay.Combat.TeamCombat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.VortexCombat.Model
{
	// Token: 0x020003B2 RID: 946
	[Token(Token = "0x20003B2")]
	public class VortexCombatPlayer : TeamCombatPlayer
	{
		// Token: 0x06001631 RID: 5681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001631")]
		[Address(RVA = "0x67F2", Offset = "0x67F2", VA = "0x67F2")]
		public VortexCombatPlayer(PlayerInfo playerInfo, UserData user, ICombatSpellDataFactory spellFactory)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_VortexCombat_Model_VortexCombatPlayer___ctor(int param1,int *param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  longlong lVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  uint uVar7;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a58232 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_PlayerSkill__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_PlayerSkill__TypeInfo);
		    DAT_ram_00a58232 = '\x01';
		  }
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_PlayerSkill__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		        puVar1 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ebca44;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,System_Collections_Generic_ICollection_PlayerSkill__TypeInfo,
		                                0);
		code_r0x80ebca44:
		  iVar4 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  if (0 < iVar4) {
		    do {
		      iVar5 = *param2;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar7 = 0;
		        do {
		          piVar6 = (int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8);
		          if (System_Collections_Generic_IList_PlayerSkill__TypeInfo == *piVar6) {
		            puVar1 = (uint *)(iVar5 + piVar6[1] * 8 + 0xc0);
		            goto code_r0x80ebcac7;
		          }
		          uVar7 = uVar7 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		      }
		      puVar1 = (uint *)func_ii_1080(param2,System_Collections_Generic_IList_PlayerSkill__TypeInfo,0)
		      ;
		code_r0x80ebcac7:
		      iVar5 = (**(code **)((ulonglong)*puVar1 * 4))(param2,iVar3,puVar1[1]);
		      if ((iVar3 == 0x10) && (*(int *)(param1 + 0x58) != 0)) {
		        iVar5 = *(int *)(iVar5 + 0xc);
		        lVar2 = Gameplay_Combat_Model_CombatPlayer__get_TotalExtraHealth(param1,0);
		        *(longlong *)(param1 + 0x68) = iVar5 - lVar2;
		      }
		      iVar3 = iVar3 + 1;
		    } while (iVar3 != iVar4);
		  }
		  Gameplay_Combat_Model_CombatPlayer__TryGetSpell(param1,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001632")]
		[Address(RVA = "0x67F3", Offset = "0x67F3", VA = "0x67F3", Slot = "6")]
		public override void SetPlayerSkills(IList<PlayerSkill> value)
		{
		}

		// Token: 0x04000BBC RID: 3004
		[Token(Token = "0x4000BBC")]
		[FieldOffset(Offset = "0x68")]
		public long LastManaBoostDelta;
	}
}
