using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001078 RID: 4216
	[Token(Token = "0x2001078")]
	public class ExpectedTournamentErrors : ExpectedDefaultError
	{
		// Token: 0x06006283 RID: 25219 RVA: 0x00012798 File Offset: 0x00010998
		[Token(Token = "0x6006283")]
		[Address(RVA = "0xAEA9", Offset = "0xAEA9", VA = "0xAEA9", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006284 RID: 25220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006284")]
		[Address(RVA = "0xAEAA", Offset = "0xAEAA", VA = "0xAEAA")]
		public ExpectedTournamentErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedTournamentErrors___ctor
		          (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  int param3_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a397 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_VortexCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25416);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17530);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5a397 = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(Gameplay_VortexCombat_VortexCombat_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(Gameplay_VortexCombat_VortexCombat_TypeInfo + 0xb8) * 4 + -4) !=
		        Gameplay_VortexCombat_VortexCombat_TypeInfo)) {
		      System_Activator__CreateInstance(param2,Gameplay_VortexCombat_VortexCombat_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_17530,1,0,1,0,0,0,0);
		  param2_00 = Mono_Security_ASN1Convert__ToOid
		                        (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  param3_00 = func_ii_4443(param2[10] + 0x10,0);
		  local_8 = 0;
		  if (param3_00 == 0) {
		    param3_00 = StringLiteral_5;
		  }
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_25416,param3_00,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(param2_00 + 0x10) = local_8;
		  uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar1,param2_00,0);
		  return uVar1;
		}
		*/

		}
	}
}
