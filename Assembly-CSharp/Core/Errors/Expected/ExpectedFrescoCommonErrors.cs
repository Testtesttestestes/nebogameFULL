using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001057 RID: 4183
	[Token(Token = "0x2001057")]
	public class ExpectedFrescoCommonErrors : ExpectedDefaultError
	{
		// Token: 0x0600623B RID: 25147 RVA: 0x00012540 File Offset: 0x00010740
		[Token(Token = "0x600623B")]
		[Address(RVA = "0xAE61", Offset = "0xAE61", VA = "0xAE61", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600623C RID: 25148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600623C")]
		[Address(RVA = "0xAE62", Offset = "0xAE62", VA = "0xAE62")]
		public ExpectedFrescoCommonErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedFrescoCommonErrors___ctor
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a377 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10797);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10798);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10796);
		    DAT_ram_00a5a377 = '\x01';
		  }
		  if (param2 < -0x13) {
		    if (param2 == -0x15) {
		      uVar2 = System_Uri___ctor(0);
		      uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10797,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar2,2,uVar1,0);
		      return 1;
		    }
		    if (param2 == -0x14) {
		      uVar2 = System_Uri___ctor(0);
		      uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10796,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar2,2,uVar1,0);
		      return 1;
		    }
		  }
		  else if (param2 == -10) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10798,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar2,2,uVar1,0);
		    return 1;
		  }
		  uVar2 = Core_Errors_Expected_ExpectedEndlessOptionsBillingErrors___c___Handle_b__0_0
		                    (param2,param2,param2);
		  return uVar2;
		}
		*/

		}
	}
}
