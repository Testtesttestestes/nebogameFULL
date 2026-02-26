using System;
using Core.Data;
using Core.Gameplay;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Common;
using Utils;

namespace Gameplay.Portals.Combat.Model
{
	// Token: 0x020005EC RID: 1516
	[Token(Token = "0x20005EC")]
	public class PortalCombatModel : CombatModel
	{
		// Token: 0x060024C7 RID: 9415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C7")]
		[Address(RVA = "0x7615", Offset = "0x7615", VA = "0x7615")]
		public PortalCombatModel(IPortal portal, IBalance balance, IMonsterSource monsterSource, IGame game, CombatDependencies dependencies, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C8")]
		[Address(RVA = "0x7616", Offset = "0x7616", VA = "0x7616")]
		public void SetNextCombatCost(ResourceSet value)
		{
		/* --- GHIDRA: SetNextCombatCost ---
		undefined4
		Gameplay_Portals_Combat_Model_PortalCombatModel__SetNextCombatCost(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a57d60 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57d60 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x290);
		        goto code_r0x80e53b7e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80e53b7e:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar3 = Gameplay_Portals_Model_PortalsModel__get_HasPortalAndUser(*(undefined4 *)(iVar3 + 0x10),0)
		  ;
		  if (iVar3 == 0) {
		    uVar4 = 0;
		  }
		  else {
		    uVar4 = *(undefined4 *)(param1 + 0x6c);
		  }
		  return uVar4;
		}
		*/

		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60024C9")]
		[Address(RVA = "0x7617", Offset = "0x7617", VA = "0x7617", Slot = "12")]
		public override ResourceSet GetNextCombatCost()
		{
		/* --- GHIDRA: GetNextCombatCost ---
		void Gameplay_Portals_Combat_Model_PortalCombatModel__GetNextCombatCost
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  if (DAT_ram_00a57d61 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_PortalCombatModel__PortalCombatEvents___ctor__
		              );
		    DAT_ram_00a57d61 = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (param1,param2,param4,param5,
		             Method_Gameplay_Combat_Control_CombatController_PortalCombatModel__PortalCombatEvents___ctor__
		            );
		  *(undefined4 *)(param1 + 0x20) = param3;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04001412 RID: 5138
		[Token(Token = "0x4001412")]
		[FieldOffset(Offset = "0x5C")]
		public readonly IGame Game;

		// Token: 0x04001413 RID: 5139
		[Token(Token = "0x4001413")]
		[FieldOffset(Offset = "0x60")]
		public readonly IBalance Balance;

		// Token: 0x04001414 RID: 5140
		[Token(Token = "0x4001414")]
		[FieldOffset(Offset = "0x64")]
		public readonly IPortal Portal;

		// Token: 0x04001415 RID: 5141
		[Token(Token = "0x4001415")]
		[FieldOffset(Offset = "0x68")]
		public readonly IMonsterSource MonsterSource;

		// Token: 0x04001416 RID: 5142
		[Token(Token = "0x4001416")]
		[FieldOffset(Offset = "0x6C")]
		private ResourceSet _nextCombatCost;
	}
}
