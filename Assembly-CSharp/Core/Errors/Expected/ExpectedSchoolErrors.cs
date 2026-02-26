using System;
using Il2CppDummyDll;
using UI.Windows;

namespace Core.Errors.Expected
{
	// Token: 0x0200106E RID: 4206
	[Token(Token = "0x200106E")]
	public class ExpectedSchoolErrors : ExpectedDefaultError
	{
		// Token: 0x06006271 RID: 25201 RVA: 0x000126D8 File Offset: 0x000108D8
		[Token(Token = "0x6006271")]
		[Address(RVA = "0xAE97", Offset = "0xAE97", VA = "0xAE97", Slot = "4")]
		public override bool Handle(int errorCode)
		{
		/* --- GHIDRA: Handle ---
		void Core_Errors_Expected_ExpectedSchoolErrors__Handle
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Windows_RequirementsWindow__HandleContent(param2,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006272 RID: 25202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006272")]
		[Address(RVA = "0xAE98", Offset = "0xAE98", VA = "0xAE98")]
		protected void Show(RequirementsWindow.RequirementsWindowArgs windowArgs)
		{
		}

		// Token: 0x06006273 RID: 25203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006273")]
		[Address(RVA = "0xAE99", Offset = "0xAE99", VA = "0xAE99")]
		public ExpectedSchoolErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedSchoolErrors___ctor(undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5a38e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8381);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8375);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8372);
		    DAT_ram_00a5a38e = '\x01';
		  }
		  if (param2 == -4) {
		    return 1;
		  }
		  if (param2 == -3) {
		    uVar1 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = 1;
		    param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8372,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar2,2,param3_00,0);
		  }
		  else {
		    if (param2 == -2) {
		      uVar1 = System_Uri___ctor(0);
		      uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8375,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		      return 1;
		    }
		    if (param2 == -1) {
		      uVar1 = System_Uri___ctor(0);
		      uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8381,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		      return 1;
		    }
		  }
		  return uVar1;
		}
		*/

		}
	}
}
