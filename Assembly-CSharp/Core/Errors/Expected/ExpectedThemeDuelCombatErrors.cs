using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001077 RID: 4215
	[Token(Token = "0x2001077")]
	public class ExpectedThemeDuelCombatErrors : ExpectedCombatErrors
	{
		// Token: 0x06006281 RID: 25217 RVA: 0x00012780 File Offset: 0x00010980
		[Token(Token = "0x6006281")]
		[Address(RVA = "0xAEA7", Offset = "0xAEA7", VA = "0xAEA7", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006282 RID: 25218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006282")]
		[Address(RVA = "0xAEA8", Offset = "0xAEA8", VA = "0xAEA8")]
		public ExpectedThemeDuelCombatErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedThemeDuelCombatErrors___ctor
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a396 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15138);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15137);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15153);
		    DAT_ram_00a5a396 = '\x01';
		  }
		  if (param2 < -0x6d) {
		    if (param2 == -1000) {
		      return 1;
		    }
		    if (param2 == -0x6e) {
		      uVar1 = System_Uri___ctor(0);
		      uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15153,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar1,6,uVar2,0);
		      return 1;
		    }
		  }
		  else {
		    if (param2 == -7) {
		      uVar1 = System_Uri___ctor(0);
		      uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15137,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar1,6,uVar2,0);
		      return 1;
		    }
		    if ((((param2 != -6) && (param2 != -5)) && (param2 != -4)) && ((param2 != -3 && (param2 == -2)))
		       ) {
		      uVar1 = System_Uri___ctor(0);
		      uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15138,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar1,6,uVar2,0);
		      return 1;
		    }
		  }
		  return 0;
		}
		*/

		}
	}
}
