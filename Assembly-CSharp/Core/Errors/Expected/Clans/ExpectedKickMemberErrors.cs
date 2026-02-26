using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Clans
{
	// Token: 0x02001085 RID: 4229
	[Token(Token = "0x2001085")]
	public class ExpectedKickMemberErrors : ExpectedDefaultError
	{
		// Token: 0x0600629E RID: 25246 RVA: 0x00012888 File Offset: 0x00010A88
		[Token(Token = "0x600629E")]
		[Address(RVA = "0xAEC4", Offset = "0xAEC4", VA = "0xAEC4", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600629F RID: 25247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600629F")]
		[Address(RVA = "0xAEC5", Offset = "0xAEC5", VA = "0xAEC5")]
		public ExpectedKickMemberErrors()
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Errors_Expected_Clans_ExpectedKickMemberErrors___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 *puVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  param1_00 = 0;
		  if (DAT_ram_00a60732 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4284);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4202);
		    DAT_ram_00a60732 = '\x01';
		  }
		  if (param2 == -7) {
		    puVar1 = &StringLiteral_4202;
		    iVar4 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  else {
		    if (param2 != -0x10e) goto code_r0x81cd721a;
		    puVar1 = &StringLiteral_4284;
		    iVar4 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  if (iVar4 == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param1_00 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar1,1,0,1,0,0,0,0);
		code_r0x81cd721a:
		  uVar2 = func_ii_4769(param1_00,0);
		  if (uVar2 == 0) {
		    uVar3 = System_Uri___ctor(0);
		    uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		    Core_Application_App__get_ToastController(uVar3,2,param1_00,0);
		  }
		  return uVar2 ^ 1;
		}
		*/

		}
	}
}
