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
	// Token: 0x02000B3F RID: 2879
	[Token(Token = "0x2000B3F")]
	public class BossMinionCombatModel : CombatModel
	{
		// Token: 0x060045D5 RID: 17877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045D5")]
		[Address(RVA = "0x9477", Offset = "0x9477", VA = "0x9477")]
		public BossMinionCombatModel(CombatDependencies dependencies, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_BossCombat_Model_BossMinionCombatModel___ctor
		              (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		              undefined4 param6)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  iVar1 = Gameplay_Combat_Model_CombatModel__TryGetEventSpell(param1,param2,param3,param4,param5,0);
		  if (DAT_ram_00a5798a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__AddRange__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__Clear__
		              );
		    DAT_ram_00a5798a = '\x01';
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

		// Token: 0x060045D6 RID: 17878 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60045D6")]
		[Address(RVA = "0x9478", Offset = "0x9478", VA = "0x9478", Slot = "9")]
		protected override CombatPlayer CreatePlayer(ICombatPlayerFactory playerFactory, ICombatSpellDataFactory spellFactory, IUserCache userCache, PlayerInfo playerInfo)
		{
		/* --- GHIDRA: CreatePlayer ---
		void Gameplay_BossCombat_Model_BossMinionCombatModel__CreatePlayer
		               (int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5798a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__AddRange__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__Clear__
		              );
		    DAT_ram_00a5798a = '\x01';
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

		// Token: 0x060045D7 RID: 17879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045D7")]
		[Address(RVA = "0x9479", Offset = "0x9479", VA = "0x9479")]
		private void FillEffectIndexes(CombatPlayer player)
		{
		}
	}
}
