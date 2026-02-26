using System;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using UI.ToolTip;

namespace Gameplay.Combat.View.Spells
{
	// Token: 0x02000943 RID: 2371
	[Token(Token = "0x2000943")]
	public class CombatSpellButton : AbstractCombatSpellButton<CombatSpellData>
	{
		// Token: 0x0600381A RID: 14362 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600381A")]
		[Address(RVA = "0x87D1", Offset = "0x87D1", VA = "0x87D1", Slot = "18")]
		public override BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x0600381B RID: 14363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600381B")]
		[Address(RVA = "0x87D2", Offset = "0x87D2", VA = "0x87D2")]
		public CombatSpellButton()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_Spells_CombatSpellButton___ctor(int param1,undefined4 param2)
		
		{
		  uint param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a566e7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__HandleDataChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__get_Data__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_FakeCombatSpellData_TypeInfo);
		    DAT_ram_00a566e7 = '\x01';
		  }
		  Gameplay_Combat_View_Spells_AbstractCombatSpellButton_object___GetData
		            (param1,
		             Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__HandleDataChanged__
		            );
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  param2_00 = 1;
		  if (*(int **)(param1 + 0x4c) != (int *)0x0) {
		    iVar1 = **(int **)(param1 + 0x4c);
		    if ((uint)*(byte *)(Gameplay_Combat_Model_FakeCombatSpellData_TypeInfo + 0xb8) <=
		        (uint)*(byte *)(iVar1 + 0xb8)) {
		      param2_00 = (uint)(*(int *)(*(int *)(iVar1 + 100) +
		                                  (uint)*(byte *)(Gameplay_Combat_Model_FakeCombatSpellData_TypeInfo
		                                                 + 0xb8) * 4 + -4) !=
		                        Gameplay_Combat_Model_FakeCombatSpellData_TypeInfo);
		    }
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2_00,0);
		  return;
		}
		*/

		}
	}
}
