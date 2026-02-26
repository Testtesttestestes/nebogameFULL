using System;
using Gameplay.Combat.Events;
using Il2CppDummyDll;

namespace Gameplay.BossCombat
{
	// Token: 0x02000B39 RID: 2873
	[Token(Token = "0x2000B39")]
	public class BossMinionCombatEvents : CombatEvents
	{
		// Token: 0x060045C6 RID: 17862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C6")]
		[Address(RVA = "0x9468", Offset = "0x9468", VA = "0x9468")]
		public BossMinionCombatEvents()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_BossCombat_BossMinionCombatEvents___ctor(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a57983 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__get_Data__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_BossCombat_Model_BossCombatSpellData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_BossCombatSpellData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_BossCombatSpellData__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_BossCombatSpellData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12525);
		    DAT_ram_00a57983 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_BossCombatSpellData__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12525,
		             Method_UI_ToolTip_ToolTipData_BossCombatSpellData___ctor__);
		  param1_01 = *(int **)(param1 + 0x4c);
		  if (param1_01 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_01 + 0xb8) <
		         (uint)*(byte *)(Gameplay_BossCombat_Model_BossCombatSpellData_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_01 + 100) +
		                 (uint)*(byte *)(Gameplay_BossCombat_Model_BossCombatSpellData_TypeInfo + 0xb8) * 4
		                + -4) != Gameplay_BossCombat_Model_BossCombatSpellData_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_01,Gameplay_BossCombat_Model_BossCombatSpellData_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  *(int **)(param1_00 + 0x1c) = param1_01;
		  return param1_00;
		}
		*/

		}
	}
}
