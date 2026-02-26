using System;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.VortexCombat.Factories
{
	// Token: 0x020003B7 RID: 951
	[Token(Token = "0x20003B7")]
	public class VortexCombatSpellDataFactory : ICombatSpellDataFactory, IDisposable
	{
		// Token: 0x0600163F RID: 5695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x6800", Offset = "0x6800", VA = "0x6800", Slot = "5")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		int Gameplay_VortexCombat_Factories_VortexCombatSpellDataFactory__Dispose
		              (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58236 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_Spells_SpellData_Create_VortexCombatSpellData___)
		    ;
		    DAT_ram_00a58236 = '\x01';
		  }
		  iVar1 = Core_Data_Spells_SpellData__Create_object_
		                    (*(undefined4 *)(*(int *)(param2 + 0xc) + 0xc),*(undefined4 *)(param2 + 0x10),
		                     Method_Core_Data_Spells_SpellData_Create_VortexCombatSpellData___);
		  *(int *)(iVar1 + 0x38) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001640")]
		[Address(RVA = "0x6801", Offset = "0x6801", VA = "0x6801", Slot = "4")]
		public CombatSpellData Create(SpellCombat spell)
		{
			return null;
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001641")]
		[Address(RVA = "0x6802", Offset = "0x6802", VA = "0x6802")]
		public VortexCombatSpellDataFactory()
		{
		/* --- GHIDRA: .ctor ---
		int * Gameplay_VortexCombat_Factories_VortexCombatSpellDataFactory___ctor
		                (int param1,undefined4 param2)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a58237 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__get_CombatService__
		              );
		    Mono_Security_ASN1__get_Item(&ServicesNamespace_PartyCombatService_TypeInfo);
		    DAT_ram_00a58237 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x18);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8) * 4 + -4) !=
		        ServicesNamespace_PartyCombatService_TypeInfo)) {
		      System_Activator__CreateInstance(param1_00,ServicesNamespace_PartyCombatService_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return param1_00;
		}
		*/

		}
	}
}
