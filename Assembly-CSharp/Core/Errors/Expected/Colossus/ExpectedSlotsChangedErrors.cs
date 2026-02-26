using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Colossus
{
	// Token: 0x0200107D RID: 4221
	[Token(Token = "0x200107D")]
	public class ExpectedSlotsChangedErrors : ExpectedDefaultError
	{
		// Token: 0x0600628D RID: 25229 RVA: 0x000127F8 File Offset: 0x000109F8
		[Token(Token = "0x600628D")]
		[Address(RVA = "0xAEB3", Offset = "0xAEB3", VA = "0xAEB3", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600628E RID: 25230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600628E")]
		[Address(RVA = "0xAEB4", Offset = "0xAEB4", VA = "0xAEB4")]
		public ExpectedSlotsChangedErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_Colossus_ExpectedSlotsChangedErrors___ctor
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  uint uVar3;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5a39b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4321);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4278);
		    DAT_ram_00a5a39b = '\x01';
		  }
		  uVar3 = param2 + 0x13;
		  if (uVar3 < 8) {
		    if ((1 << (uVar3 & 0x1f) & 0x73U) != 0) {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4321,1,0,1,0,0,0,0);
		      uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4321,1,0,1,0,0,0,0);
		      UI_Windows_DialogWindow__Show(uVar1,uVar2,0);
		      return 1;
		    }
		    if (uVar3 == 3) {
		      uVar1 = System_Uri___ctor(0);
		      uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar1 = 1;
		      param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4278,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar2,2,param3_00,0);
		    }
		    else if (uVar3 == 7) {
		      uVar1 = System_Uri___ctor(0);
		      uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4278,1,0,1,0,0,0,0);
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
