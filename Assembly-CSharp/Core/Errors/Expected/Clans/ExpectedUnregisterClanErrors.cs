using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Clans
{
	// Token: 0x02001089 RID: 4233
	[Token(Token = "0x2001089")]
	public class ExpectedUnregisterClanErrors : ExpectedDefaultError
	{
		// Token: 0x060062A5 RID: 25253 RVA: 0x000128D0 File Offset: 0x00010AD0
		[Token(Token = "0x60062A5")]
		[Address(RVA = "0xAECB", Offset = "0xAECB", VA = "0xAECB", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x060062A6 RID: 25254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062A6")]
		[Address(RVA = "0xAECC", Offset = "0xAECC", VA = "0xAECC")]
		public ExpectedUnregisterClanErrors()
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Errors_Expected_Clans_ExpectedUnregisterClanErrors___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a60735 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4172);
		    DAT_ram_00a60735 = '\x01';
		  }
		  if (param2 == -4) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = func_ii_7508(StringLiteral_4172,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,4,param3_00,0);
		  }
		  return (uint)(param2 == -4);
		}
		*/

		}
	}
}
