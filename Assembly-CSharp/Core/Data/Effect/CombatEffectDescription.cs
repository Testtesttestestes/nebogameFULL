using System;
using Core.Data.Skills;
using Il2CppDummyDll;

namespace Core.Data.Effect
{
	// Token: 0x020010E9 RID: 4329
	[Token(Token = "0x20010E9")]
	public class CombatEffectDescription : AbstractEffectDescription
	{
		// Token: 0x06006537 RID: 25911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006537")]
		[Address(RVA = "0xB103", Offset = "0xB103", VA = "0xB103")]
		public CombatEffectDescription(string sourceText, EffectData[] effects, Skills userSkills)
		{
		/* --- GHIDRA: .ctor ---
		int Core_Data_Effect_CombatEffectDescription___ctor
		              (undefined4 param1,undefined8 param2,undefined8 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined8 local_8;
		  
		  local_8 = param2;
		  if (DAT_ram_00a6083f == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a6083f = '\x01';
		  }
		  iVar1 = UnityEngine_GameObject__SetActive(&local_8,0);
		  if (iVar1 == 0) {
		    iVar1 = StringLiteral_5;
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x06006538 RID: 25912 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006538")]
		[Address(RVA = "0xB104", Offset = "0xB104", VA = "0xB104", Slot = "7")]
		protected override string FormatUserSkillValue(long validValue, long rawValue)
		{
			return null;
		}
	}
}
