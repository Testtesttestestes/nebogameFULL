using System;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.WorldAxis.Colossus.Combat.Factories
{
	// Token: 0x0200033E RID: 830
	[Token(Token = "0x200033E")]
	public class ColossusCombatSpellDataFactory : ICombatSpellDataFactory, IDisposable
	{
		// Token: 0x0600131D RID: 4893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131D")]
		[Address(RVA = "0x650E", Offset = "0x650E", VA = "0x650E", Slot = "5")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		int Gameplay_WorldAxis_Colossus_Combat_Factories_ColossusCombatSpellDataFactory__Dispose
		              (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58c1f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_Spells_SpellData_Create_VortexCombatSpellData___)
		    ;
		    DAT_ram_00a58c1f = '\x01';
		  }
		  iVar1 = Core_Data_Spells_SpellData__Create_object_
		                    (*(undefined4 *)(*(int *)(param2 + 0xc) + 0xc),*(undefined4 *)(param2 + 0x10),
		                     Method_Core_Data_Spells_SpellData_Create_VortexCombatSpellData___);
		  *(int *)(iVar1 + 0x38) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x0600131E RID: 4894 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600131E")]
		[Address(RVA = "0x650F", Offset = "0x650F", VA = "0x650F", Slot = "4")]
		public CombatSpellData Create(SpellCombat spell)
		{
			return null;
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131F")]
		[Address(RVA = "0x6510", Offset = "0x6510", VA = "0x6510")]
		public ColossusCombatSpellDataFactory()
		{
		}
	}
}
