using System;
using System.Runtime.InteropServices;
using Core.Data.Skills;
using Il2CppDummyDll;

namespace Core.Data.Spells
{
	// Token: 0x020010D0 RID: 4304
	[Token(Token = "0x20010D0")]
	public class SpellsBasedDescription : AbstractSpellsBasedDescription
	{
		// Token: 0x060064D7 RID: 25815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064D7")]
		[Address(RVA = "0xB0B9", Offset = "0xB0B9", VA = "0xB0B9")]
		public SpellsBasedDescription(string sourceText, SpellData[] spells, [Optional] Skills userSkills)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Data_Spells_SpellsBasedDescription___ctor(undefined4 param1)
		
		{
		  if (DAT_ram_00a60812 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_EffectSkillsMapping_TypeInfo);
		    DAT_ram_00a60812 = '\x01';
		  }
		  if (*(int *)(Core_Data_Skills_EffectSkillsMapping_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Data_Skills_EffectSkillsMapping_TypeInfo);
		  }
		  return **(undefined4 **)(Core_Data_Skills_EffectSkillsMapping_TypeInfo + 0x5c);
		}
		*/

		}
	}
}
