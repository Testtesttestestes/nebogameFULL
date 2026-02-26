using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200105A RID: 4186
	[Token(Token = "0x200105A")]
	public class ExpectedFromUser2ShopErrors : ExpectedDefaultError
	{
		// Token: 0x06006241 RID: 25153 RVA: 0x00012588 File Offset: 0x00010788
		[Token(Token = "0x6006241")]
		[Address(RVA = "0xAE67", Offset = "0xAE67", VA = "0xAE67", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006242 RID: 25154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006242")]
		[Address(RVA = "0xAE68", Offset = "0xAE68", VA = "0xAE68")]
		public ExpectedFromUser2ShopErrors()
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Errors_Expected_ExpectedFromUser2ShopErrors___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5a37a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12181);
		    DAT_ram_00a5a37a = '\x01';
		  }
		  if (param2 == -1) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_12181,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,param3_00,0);
		  }
		  return (uint)(param2 == -1);
		}
		*/

		}
	}
}
