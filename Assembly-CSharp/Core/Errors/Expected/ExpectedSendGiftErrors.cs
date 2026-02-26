using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200106F RID: 4207
	[Token(Token = "0x200106F")]
	public class ExpectedSendGiftErrors : ExpectedDefaultError
	{
		// Token: 0x06006274 RID: 25204 RVA: 0x000126F0 File Offset: 0x000108F0
		[Token(Token = "0x6006274")]
		[Address(RVA = "0xAE9A", Offset = "0xAE9A", VA = "0xAE9A", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006275 RID: 25205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006275")]
		[Address(RVA = "0xAE9B", Offset = "0xAE9B", VA = "0xAE9B")]
		public ExpectedSendGiftErrors()
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Errors_Expected_ExpectedSendGiftErrors___ctor
		               (undefined4 param1,uint param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  uint local_4;
		  
		  if (DAT_ram_00a5a38f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6812);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6813);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14259);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6814);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12090);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12091);
		    DAT_ram_00a5a38f = '\x01';
		  }
		  if ((int)param2 < 0) {
		    if (param2 == 0xffffff35) {
		      uVar1 = System_Uri___ctor(0);
		      uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = func_ii_7508(StringLiteral_6813,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    }
		    else if (param2 == 0xffffff36) {
		      uVar1 = System_Uri___ctor(0);
		      uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = func_ii_7508(StringLiteral_12091,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    }
		    else if (param2 == 0xffffff37) {
		      uVar1 = System_Uri___ctor(0);
		      uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = func_ii_7508(StringLiteral_6814,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    }
		    else if (param2 == 0xfffff7cc) {
		      uVar1 = System_Uri___ctor(0);
		      uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = func_ii_7508(StringLiteral_6812,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    }
		    else if (param2 == 0xfffff82f) {
		      uVar1 = System_Uri___ctor(0);
		      uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = func_ii_7508(StringLiteral_12090,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    }
		    else {
		      uVar1 = System_Uri___ctor(0);
		      uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		      local_4 = param2;
		      uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		      uVar2 = func_ii_4419(StringLiteral_14259,uVar2,0);
		      Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    }
		  }
		  return param2 >> 0x1f;
		}
		*/

		}
	}
}
