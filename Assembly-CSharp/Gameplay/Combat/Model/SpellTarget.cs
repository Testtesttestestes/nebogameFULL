using System;
using Il2CppDummyDll;

namespace Gameplay.Combat.Model
{
	// Token: 0x020009A1 RID: 2465
	[Token(Token = "0x20009A1")]
	public class SpellTarget
	{
		// Token: 0x06003AF1 RID: 15089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AF1")]
		[Address(RVA = "0x8A65", Offset = "0x8A65", VA = "0x8A65")]
		public SpellTarget(CombatSpellData spell)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_Model_SpellTarget___ctor(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57e57 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Model_SkillsChange_AbstractShortSpellInfo_ProtoSkillsChangedEvt_Types_ShortSpellInfo___ctor__
		              );
		    DAT_ram_00a57e57 = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (param1,param2,
		             Method_Gameplay_Combat_Model_SkillsChange_AbstractShortSpellInfo_ProtoSkillsChangedEvt_Types_ShortSpellInfo___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0400208D RID: 8333
		[Token(Token = "0x400208D")]
		[FieldOffset(Offset = "0x8")]
		public readonly CombatSpellData Spell;

		// Token: 0x0400208E RID: 8334
		[Token(Token = "0x400208E")]
		[FieldOffset(Offset = "0xC")]
		public CombatPlayer[] Players;

		// Token: 0x0400208F RID: 8335
		[Token(Token = "0x400208F")]
		[FieldOffset(Offset = "0x10")]
		public int srcX;

		// Token: 0x04002090 RID: 8336
		[Token(Token = "0x4002090")]
		[FieldOffset(Offset = "0x14")]
		public int srcY;
	}
}
