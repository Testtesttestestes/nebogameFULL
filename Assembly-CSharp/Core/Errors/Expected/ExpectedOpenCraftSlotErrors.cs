using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001067 RID: 4199
	[Token(Token = "0x2001067")]
	public class ExpectedOpenCraftSlotErrors : ExpectedDefaultError
	{
		// Token: 0x06006262 RID: 25186 RVA: 0x00012648 File Offset: 0x00010848
		[Token(Token = "0x6006262")]
		[Address(RVA = "0xAE88", Offset = "0xAE88", VA = "0xAE88", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006263 RID: 25187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006263")]
		[Address(RVA = "0xAE89", Offset = "0xAE89", VA = "0xAE89")]
		public ExpectedOpenCraftSlotErrors()
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Errors_Expected_ExpectedOpenCraftSlotErrors___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5a388 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6924);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6923);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6922);
		    DAT_ram_00a5a388 = '\x01';
		  }
		  uVar3 = StringLiteral_6922;
		  if (((param2 != -3) && (uVar3 = StringLiteral_6924, param2 != -2)) && (uVar3 = 0, param2 == -1)) {
		    uVar3 = StringLiteral_6923;
		  }
		  uVar1 = func_ii_4769(uVar3,0);
		  if (uVar1 == 0) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar3,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar2,2,uVar3,0);
		  }
		  return uVar1 ^ 1;
		}
		*/

		}
	}
}
