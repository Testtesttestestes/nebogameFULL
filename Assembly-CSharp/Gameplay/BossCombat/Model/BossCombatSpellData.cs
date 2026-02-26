using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Model;
using Gameplay.Combat.Model;
using Il2CppDummyDll;

namespace Gameplay.BossCombat.Model
{
	// Token: 0x02000B3E RID: 2878
	[Token(Token = "0x2000B3E")]
	public class BossCombatSpellData : CombatSpellData
	{
		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x060045D2 RID: 17874 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060045D3 RID: 17875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DC1")]
		public List<TeamData.TeamAssistantData> Assistants
		{
			[Token(Token = "0x60045D2")]
			[Address(RVA = "0x9474", Offset = "0x9474", VA = "0x9474")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045D3")]
			[Address(RVA = "0x9475", Offset = "0x9475", VA = "0x9475")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045D4")]
		[Address(RVA = "0x9476", Offset = "0x9476", VA = "0x9476")]
		public BossCombatSpellData()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Assistants ---
		void Gameplay_BossCombat_Model_BossCombatSpellData__set_Assistants(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57989 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamData_TeamAssistantData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_TeamData_TeamAssistantData__TypeInfo);
		    DAT_ram_00a57989 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_TeamData_TeamAssistantData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_TeamData_TeamAssistantData___ctor__);
		  *(undefined4 *)(param1 + 0x48) = param1_00;
		  Gameplay_Combat_Model_CombatSpellData__get_AnimationAssetId(param1,0);
		  return;
		}
		*/

}
