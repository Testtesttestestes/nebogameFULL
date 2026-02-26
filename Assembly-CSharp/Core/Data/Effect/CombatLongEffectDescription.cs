using System;
using System.Collections.Generic;
using Core.Data.Skills;
using Il2CppDummyDll;

namespace Core.Data.Effect
{
	// Token: 0x020010EA RID: 4330
	[Token(Token = "0x20010EA")]
	public class CombatLongEffectDescription : CombatEffectDescription
	{
		// Token: 0x06006539 RID: 25913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006539")]
		[Address(RVA = "0xB105", Offset = "0xB105", VA = "0xB105")]
		public CombatLongEffectDescription(string sourceText, EffectData[] effects, Skills userSkills)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Data_Effect_CombatLongEffectDescription___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a60840 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		    DAT_ram_00a60840 = '\x01';
		  }
		  func_ii_2946(param2,param4,param5,
		               Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		  return;
		}
		*/

		}

		// Token: 0x0600653A RID: 25914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600653A")]
		[Address(RVA = "0xB106", Offset = "0xB106", VA = "0xB106", Slot = "6")]
		protected override void WriteValue(Dictionary<string, string> source, uint effectId, string textVarName, string value)
		{
		}
	}
}
