using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Combat.Model
{
	// Token: 0x0200099F RID: 2463
	[Token(Token = "0x200099F")]
	public class PlayerProfitData
	{
		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06003AEA RID: 15082 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003AEB RID: 15083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BAC")]
		public PlayerProfit Data
		{
			[Token(Token = "0x6003AEA")]
			[Address(RVA = "0x8A5F", Offset = "0x8A5F", VA = "0x8A5F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003AEB")]
			[Address(RVA = "0x8A60", Offset = "0x8A60", VA = "0x8A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003AEC RID: 15084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AEC")]
		[Address(RVA = "0x8A61", Offset = "0x8A61", VA = "0x8A61")]
		public PlayerProfitData(PlayerProfit data)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_Model_PlayerProfitData___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57e56 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_PlayerProfitData___c_TypeInfo);
		    DAT_ram_00a57e56 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Combat_Model_PlayerProfitData___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Combat_Model_PlayerProfitData___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06003AED RID: 15085 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003AED")]
		[Address(RVA = "0x1BE3", Offset = "0x1BE3", VA = "0x1BE3")]
		public List<RewardData> ToRewards()
		{
		/* --- GHIDRA: ToRewards ---
		void Gameplay_Combat_Model_PlayerProfitData__ToRewards(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a57d70 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57d70 = '\x01';
		  }
		  param1_01 = *(int **)(param1[2] + 0x5c);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x290);
		        goto code_r0x80e5516f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80e5516f:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar4 = *(int *)(iVar4 + 0x10);
		  if (*(int *)(iVar4 + 0x1c) == 0) {
		    uVar1 = 0;
		  }
		  else {
		    uVar1 = 0;
		    iVar3 = Gameplay_Portals_Model_PortalsModel__get_HasPortalAndUser(iVar4,0);
		    if ((iVar3 != 0) && (*(int *)(*(int *)(*(int *)(iVar4 + 0x20) + 0x18) + 0xc) == 0)) {
		      if (*(char *)(*(int *)(iVar4 + 0x40) + 0x24) == '\0') {
		        uVar1 = 1;
		      }
		      else {
		        uVar1 = (uint)(*(char *)(*(int *)(param1[2] + 0x10) + 8) == '\0');
		      }
		    }
		  }
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar4 != 0) {
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(*(int *)(iVar4 + 0x28) + 0x20),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,uVar1,0);
		  }
		  return;
		}
		*/

			return null;
		}
	}
}
