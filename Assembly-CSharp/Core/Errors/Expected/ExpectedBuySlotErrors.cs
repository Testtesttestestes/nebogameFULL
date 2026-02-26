using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001048 RID: 4168
	[Token(Token = "0x2001048")]
	public class ExpectedBuySlotErrors : ExpectedDefaultError
	{
		// Token: 0x06006212 RID: 25106 RVA: 0x000123C0 File Offset: 0x000105C0
		[Token(Token = "0x6006212")]
		[Address(RVA = "0xAE3D", Offset = "0xAE3D", VA = "0xAE3D", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006213 RID: 25107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006213")]
		[Address(RVA = "0xAE3E", Offset = "0xAE3E", VA = "0xAE3E")]
		public ExpectedBuySlotErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedBuySlotErrors___ctor(undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a365 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13753);
		    DAT_ram_00a5a365 = '\x01';
		  }
		  if (param2 == -6) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13753,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,param3_00,0);
		    return 1;
		  }
		  uVar1 = Core_Errors_Expected_ExpectedAuchanError_ErrorArgs___ctor(param2,param2,param2);
		  return uVar1;
		}
		*/

		}
	}
}
