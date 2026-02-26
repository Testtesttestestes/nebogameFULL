using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001072 RID: 4210
	[Token(Token = "0x2001072")]
	public class ExpectedStackableChangesErrors : ExpectedDefaultError
	{
		// Token: 0x06006278 RID: 25208 RVA: 0x00012720 File Offset: 0x00010920
		[Token(Token = "0x6006278")]
		[Address(RVA = "0xAE9E", Offset = "0xAE9E", VA = "0xAE9E", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006279 RID: 25209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006279")]
		[Address(RVA = "0xAE9F", Offset = "0xAE9F", VA = "0xAE9F")]
		public ExpectedStackableChangesErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedStackableChangesErrors___ctor
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a391 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4460);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4478);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4490);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4480);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4479);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4456);
		    DAT_ram_00a5a391 = '\x01';
		  }
		  if (param2 == -7) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4460,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    return 1;
		  }
		  if (param2 == -6) {
		    return 1;
		  }
		  if (param2 == -5) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4456,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    return 1;
		  }
		  if (param2 == -4) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4490,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    return 1;
		  }
		  if (param2 == -3) {
		    Core_Errors_Expected_ExpectedStartCraftErrors__Handle(0xfffffffd,0xfffffffd);
		    return 1;
		  }
		  if (param2 == -2) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4479,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    return 1;
		  }
		  if (param2 != -1) {
		    if (param2 == -1000) {
		      uVar1 = System_Uri___ctor(0);
		      uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4478,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		      uVar1 = 1;
		    }
		    else {
		      uVar1 = 0;
		    }
		    return uVar1;
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4480,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		  return 1;
		}
		*/

		}

		// Token: 0x02001073 RID: 4211
		[Token(Token = "0x2001073")]
		public enum Action : byte
		{
			// Token: 0x040034F2 RID: 13554
			[Token(Token = "0x40034F2")]
			DEFAULT,
			// Token: 0x040034F3 RID: 13555
			[Token(Token = "0x40034F3")]
			MERGE,
			// Token: 0x040034F4 RID: 13556
			[Token(Token = "0x40034F4")]
			SPLIT
		}
	}
}
