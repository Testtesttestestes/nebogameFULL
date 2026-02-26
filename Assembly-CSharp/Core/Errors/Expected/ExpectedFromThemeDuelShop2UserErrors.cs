using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001059 RID: 4185
	[Token(Token = "0x2001059")]
	public class ExpectedFromThemeDuelShop2UserErrors : ExpectedDefaultError
	{
		// Token: 0x0600623F RID: 25151 RVA: 0x00012570 File Offset: 0x00010770
		[Token(Token = "0x600623F")]
		[Address(RVA = "0xAE65", Offset = "0xAE65", VA = "0xAE65", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006240 RID: 25152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006240")]
		[Address(RVA = "0xAE66", Offset = "0xAE66", VA = "0xAE66")]
		public ExpectedFromThemeDuelShop2UserErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedFromThemeDuelShop2UserErrors___ctor
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a379 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Shop_ProtoMoveArtifactFromUser2ShopAns_Types_Errors_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7858);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7861);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7859);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7864);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7674);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7862);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7857);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7860);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7863);
		    DAT_ram_00a5a379 = '\x01';
		  }
		  if (param2 == -10) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    local_4 = 0xfffffff6;
		    uVar2 = func_ii_1081(Protocol_Shop_ProtoMoveArtifactFromUser2ShopAns_Types_Errors_TypeInfo,
		                         &local_4);
		    uVar2 = func_ii_4419(StringLiteral_7674,uVar2,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    uVar1 = 1;
		  }
		  else if (param2 == -9) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_7864,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    uVar1 = 1;
		  }
		  else if (param2 == -8) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_7860,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    uVar1 = 1;
		  }
		  else if (param2 == -7) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_7863,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    uVar1 = 1;
		  }
		  else if (param2 == -6) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_7862,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    uVar1 = 1;
		  }
		  else if (param2 == -5) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_7859,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    uVar1 = 1;
		  }
		  else if (param2 == -4) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_7857,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    uVar1 = 1;
		  }
		  else if (param2 == -3) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_7858,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    uVar1 = 1;
		  }
		  else if (param2 == -2) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_7861,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    uVar1 = 1;
		  }
		  else if (param2 == -1) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_7858,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    uVar1 = 1;
		  }
		  else {
		    uVar1 = Core_Errors_Expected_ExpectedEndlessOptionsBillingErrors___c___Handle_b__0_0
		                      (auStack_10,param2,auStack_10);
		  }
		  return uVar1;
		}
		*/

		}
	}
}
