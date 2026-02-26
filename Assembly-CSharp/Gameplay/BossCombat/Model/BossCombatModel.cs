using System;
using Core.Cache.User;
using Core.Data;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Combat;
using Utils;

namespace Gameplay.BossCombat.Model
{
	// Token: 0x02000B3D RID: 2877
	[Token(Token = "0x2000B3D")]
	public class BossCombatModel : CombatModel
	{
		// Token: 0x060045CF RID: 17871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045CF")]
		[Address(RVA = "0x9471", Offset = "0x9471", VA = "0x9471")]
		public BossCombatModel(CombatDependencies dependencies, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_BossCombat_Model_BossCombatModel___ctor
		              (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		              undefined4 param6)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  iVar1 = Gameplay_Combat_Model_CombatModel__TryGetEventSpell(param1,param2,param3,param4,param5,0);
		  if (DAT_ram_00a57988 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__AddRange__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__Clear__
		              );
		    DAT_ram_00a57988 = '\x01';
		  }
		  uVar2 = 3;
		  if (*(int *)(*(int *)(param1 + 0xc) + 0x2c) != *(int *)(*(int *)(iVar1 + 8) + 0x14)) {
		    uVar2 = 1;
		  }
		  uVar2 = Gameplay_Antiq_Model_AntiqModel__TryGetEffectValue
		                    (*(undefined4 *)(iVar1 + 0x14),*(undefined4 *)(*(int *)(param1 + 0xc) + 0xc),
		                     uVar2,0);
		  param1_00 = *(int *)(iVar1 + 0x18);
		  *(undefined4 *)(param1_00 + 0xc) = 0;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  System_Collections_Generic_List_Int32Enum___AddEnumerable
		            (param1_00,uVar2,
		             Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__AddRange__
		            );
		  return iVar1;
		}
		*/

		}

		// Token: 0x060045D0 RID: 17872 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60045D0")]
		[Address(RVA = "0x9472", Offset = "0x9472", VA = "0x9472", Slot = "9")]
		protected override CombatPlayer CreatePlayer(ICombatPlayerFactory playerFactory, ICombatSpellDataFactory spellFactory, IUserCache userCache, PlayerInfo playerInfo)
		{
		/* --- GHIDRA: CreatePlayer ---
		void Gameplay_BossCombat_Model_BossCombatModel__CreatePlayer
		               (int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57988 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__AddRange__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__Clear__
		              );
		    DAT_ram_00a57988 = '\x01';
		  }
		  uVar1 = 3;
		  if (*(int *)(*(int *)(param1 + 0xc) + 0x2c) != *(int *)(*(int *)(param2 + 8) + 0x14)) {
		    uVar1 = 1;
		  }
		  uVar1 = Gameplay_Antiq_Model_AntiqModel__TryGetEffectValue
		                    (*(undefined4 *)(param2 + 0x14),*(undefined4 *)(*(int *)(param1 + 0xc) + 0xc),
		                     uVar1,0);
		  param1_00 = *(int *)(param2 + 0x18);
		  *(undefined4 *)(param1_00 + 0xc) = 0;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  System_Collections_Generic_List_Int32Enum___AddEnumerable
		            (param1_00,uVar1,
		             Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__AddRange__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060045D1 RID: 17873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045D1")]
		[Address(RVA = "0x9473", Offset = "0x9473", VA = "0x9473")]
		private void FillEffectIndexes(CombatPlayer player)
		{
		}
	}
}
