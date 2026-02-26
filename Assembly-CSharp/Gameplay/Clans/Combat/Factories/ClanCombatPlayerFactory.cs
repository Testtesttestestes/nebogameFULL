using System;
using Core.Data;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Clans.Combat.Factories
{
	// Token: 0x02000AA0 RID: 2720
	[Token(Token = "0x2000AA0")]
	public class ClanCombatPlayerFactory : ICombatPlayerFactory, IDisposable
	{
		// Token: 0x06004173 RID: 16755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004173")]
		[Address(RVA = "0x902A", Offset = "0x902A", VA = "0x902A", Slot = "5")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		int Gameplay_Clans_Combat_Factories_ClanCombatPlayerFactory__Dispose
		              (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		              undefined4 param5)
		
		{
		  int param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57798 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_Model_ClanCombatPlayer_TypeInfo);
		    DAT_ram_00a57798 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Gameplay_Clans_Combat_Model_ClanCombatPlayer_TypeInfo);
		  if (DAT_ram_00a57796 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_EffectData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_EffectData__TypeInfo);
		    DAT_ram_00a57796 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_Model_TeamCombatPlayer__set_IsMyPlayer
		            (param1_00,param2,param3,param4,0);
		  param1_01 = unnamed_function_1417(System_Collections_Generic_List_EffectData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_01,Method_System_Collections_Generic_List_EffectData___ctor__);
		  *(undefined4 *)(param1_00 + 0x24) = param1_01;
		  return param1_00;
		}
		*/

		}

		// Token: 0x06004174 RID: 16756 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004174")]
		[Address(RVA = "0x902B", Offset = "0x902B", VA = "0x902B", Slot = "4")]
		public CombatPlayer Create(PlayerInfo playerInfo, UserData user, ICombatSpellDataFactory spellDataFactory)
		{
			return null;
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004175")]
		[Address(RVA = "0x902C", Offset = "0x902C", VA = "0x902C")]
		public ClanCombatPlayerFactory()
		{
		}
	}
}
