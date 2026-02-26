using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001047 RID: 4167
	[Token(Token = "0x2001047")]
	public class ExpectedBuyMedalErrors : ExpectedDefaultError
	{
		// Token: 0x06006210 RID: 25104 RVA: 0x000123A8 File Offset: 0x000105A8
		[Token(Token = "0x6006210")]
		[Address(RVA = "0xAE3B", Offset = "0xAE3B", VA = "0xAE3B", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006211 RID: 25105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006211")]
		[Address(RVA = "0xAE3C", Offset = "0xAE3C", VA = "0xAE3C")]
		public ExpectedBuyMedalErrors()
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Errors_Expected_ExpectedBuyMedalErrors___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5a364 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6904);
		    DAT_ram_00a5a364 = '\x01';
		  }
		  if (param2 == -1) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_6904,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,param3_00,0);
		  }
		  return (uint)(param2 == -1);
		}
		*/

		}
	}
}
