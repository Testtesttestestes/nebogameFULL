using System;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Clans.Combat.Factories
{
	// Token: 0x02000AA1 RID: 2721
	[Token(Token = "0x2000AA1")]
	public class ClanCombatSpellDataFactory : ICombatSpellDataFactory, IDisposable
	{
		// Token: 0x06004176 RID: 16758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004176")]
		[Address(RVA = "0x902D", Offset = "0x902D", VA = "0x902D", Slot = "5")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		int Gameplay_Clans_Combat_Factories_ClanCombatSpellDataFactory__Dispose
		              (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57799 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_Spells_SpellData_Create_ClanCombatSpellData___);
		    DAT_ram_00a57799 = '\x01';
		  }
		  iVar1 = Core_Data_Spells_SpellData__Create_object_
		                    (*(undefined4 *)(*(int *)(param2 + 0xc) + 0xc),*(undefined4 *)(param2 + 0x10),
		                     Method_Core_Data_Spells_SpellData_Create_ClanCombatSpellData___);
		  *(int *)(iVar1 + 0x38) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06004177 RID: 16759 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004177")]
		[Address(RVA = "0x902E", Offset = "0x902E", VA = "0x902E", Slot = "4")]
		public CombatSpellData Create(SpellCombat spell)
		{
			return null;
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004178")]
		[Address(RVA = "0x902F", Offset = "0x902F", VA = "0x902F")]
		public ClanCombatSpellDataFactory()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Combat_Factories_ClanCombatSpellDataFactory___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5779a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__Dispose__
		              );
		    DAT_ram_00a5779a = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x20) = 0;
		  Gameplay_Combat_Control_CombatController_object__object___CompleteQueueCallback
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__Dispose__
		            );
		  return;
		}
		*/

		}
	}
}
