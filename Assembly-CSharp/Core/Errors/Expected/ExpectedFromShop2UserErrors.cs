using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001058 RID: 4184
	[Token(Token = "0x2001058")]
	public class ExpectedFromShop2UserErrors : ExpectedDefaultError
	{
		// Token: 0x0600623D RID: 25149 RVA: 0x00012558 File Offset: 0x00010758
		[Token(Token = "0x600623D")]
		[Address(RVA = "0xAE63", Offset = "0xAE63", VA = "0xAE63", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600623E RID: 25150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600623E")]
		[Address(RVA = "0xAE64", Offset = "0xAE64", VA = "0xAE64")]
		public ExpectedFromShop2UserErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedFromShop2UserErrors___ctor
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a378 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3711);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3712);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3713);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3710);
		    DAT_ram_00a5a378 = '\x01';
		  }
		  if (param2 == -4) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3712,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    return 1;
		  }
		  if (param2 == -3) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3713,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    return 1;
		  }
		  if (param2 != -2) {
		    if (param2 != -1) {
		      uVar1 = Core_Errors_Expected_ExpectedEndlessOptionsBillingErrors___c___Handle_b__0_0
		                        (param2,param2,param2);
		      return uVar1;
		    }
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3711,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    return 1;
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3710,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		  return 1;
		}
		*/

		}
	}
}
