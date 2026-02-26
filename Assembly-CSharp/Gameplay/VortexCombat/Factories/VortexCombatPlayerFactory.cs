using System;
using Core.Data;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.VortexCombat.Factories
{
	// Token: 0x020003B6 RID: 950
	[Token(Token = "0x20003B6")]
	public class VortexCombatPlayerFactory : ICombatPlayerFactory, IDisposable
	{
		// Token: 0x0600163C RID: 5692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163C")]
		[Address(RVA = "0x67FD", Offset = "0x67FD", VA = "0x67FD", Slot = "5")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		undefined4
		Gameplay_VortexCombat_Factories_VortexCombatPlayerFactory__Dispose
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          )
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58235 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo);
		    DAT_ram_00a58235 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo);
		  Gameplay_Combat_TeamCombat_Model_TeamCombatPlayer__set_IsMyPlayer
		            (param1_00,param2,param3,param4,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600163D")]
		[Address(RVA = "0x67FE", Offset = "0x67FE", VA = "0x67FE", Slot = "4")]
		public CombatPlayer Create(PlayerInfo playerInfo, UserData user, ICombatSpellDataFactory spellDataFactory)
		{
			return null;
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163E")]
		[Address(RVA = "0x67FF", Offset = "0x67FF", VA = "0x67FF")]
		public VortexCombatPlayerFactory()
		{
		}
	}
}
