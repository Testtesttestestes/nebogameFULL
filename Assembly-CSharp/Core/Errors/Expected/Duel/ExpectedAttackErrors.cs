using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Duel
{
	// Token: 0x0200107B RID: 4219
	[Token(Token = "0x200107B")]
	public class ExpectedAttackErrors : ExpectedDefaultError
	{
		// Token: 0x06006289 RID: 25225 RVA: 0x000127C8 File Offset: 0x000109C8
		[Token(Token = "0x6006289")]
		[Address(RVA = "0xAEAF", Offset = "0xAEAF", VA = "0xAEAF", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600628A RID: 25226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600628A")]
		[Address(RVA = "0xAEB0", Offset = "0xAEB0", VA = "0xAEB0")]
		public ExpectedAttackErrors()
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Errors_Expected_Duel_ExpectedAttackErrors___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 *puVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  param1_00 = 0;
		  if (DAT_ram_00a5a399 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6235);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6230);
		    DAT_ram_00a5a399 = '\x01';
		  }
		  if (param2 == -2) {
		    puVar1 = &StringLiteral_6235;
		    iVar4 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  else {
		    if (param2 != -1) goto code_r0x81211902;
		    puVar1 = &StringLiteral_6230;
		    iVar4 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  if (iVar4 == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param1_00 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar1,1,0,1,0,0,0,0);
		code_r0x81211902:
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
