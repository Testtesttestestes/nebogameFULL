using System;
using Gameplay.Combat.Events;
using Il2CppDummyDll;

namespace Gameplay.TutorialCombatV2
{
	// Token: 0x02000444 RID: 1092
	[Token(Token = "0x2000444")]
	public class TutorialCombatEvents : CombatEvents
	{
		// Token: 0x060019C6 RID: 6598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C6")]
		[Address(RVA = "0x6B5E", Offset = "0x6B5E", VA = "0x6B5E")]
		public TutorialCombatEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_TutorialCombatV2_TutorialCombatEvents___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a583e8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__HandleEnabledChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__get_Enabled__
		              );
		    DAT_ram_00a583e8 = '\x01';
		  }
		  Gameplay_Combat_View_Spells_AbstractCombatSpellButton_object___HandleDataChanged
		            (param1,
		             Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__HandleEnabledChanged__
		            );
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x5c),(uint)*(byte *)(param1 + 0x49),0);
		  return;
		}
		*/

		}

		// Token: 0x04000DD6 RID: 3542
		[Token(Token = "0x4000DD6")]
		[FieldOffset(Offset = "0x70")]
		public Action CombatComplete;
	}
}
