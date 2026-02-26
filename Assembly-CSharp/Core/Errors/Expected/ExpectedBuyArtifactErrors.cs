using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001046 RID: 4166
	[Token(Token = "0x2001046")]
	public class ExpectedBuyArtifactErrors : ExpectedDefaultError
	{
		// Token: 0x0600620E RID: 25102 RVA: 0x00012390 File Offset: 0x00010590
		[Token(Token = "0x600620E")]
		[Address(RVA = "0xAE39", Offset = "0xAE39", VA = "0xAE39", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600620F RID: 25103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600620F")]
		[Address(RVA = "0xAE3A", Offset = "0xAE3A", VA = "0xAE3A")]
		public ExpectedBuyArtifactErrors()
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Errors_Expected_ExpectedBuyArtifactErrors___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5a363 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6903);
		    DAT_ram_00a5a363 = '\x01';
		  }
		  if (param2 == -10) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_6903,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,param3_00,0);
		  }
		  return (uint)(param2 == -10);
		}
		*/

		}
	}
}
