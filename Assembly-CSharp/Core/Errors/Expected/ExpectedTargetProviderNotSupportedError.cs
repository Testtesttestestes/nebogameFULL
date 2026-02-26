using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001075 RID: 4213
	[Token(Token = "0x2001075")]
	public class ExpectedTargetProviderNotSupportedError : ExpectedDefaultError
	{
		// Token: 0x0600627D RID: 25213 RVA: 0x00012750 File Offset: 0x00010950
		[Token(Token = "0x600627D")]
		[Address(RVA = "0xAEA3", Offset = "0xAEA3", VA = "0xAEA3", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600627E RID: 25214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600627E")]
		[Address(RVA = "0xAEA4", Offset = "0xAEA4", VA = "0xAEA4")]
		public ExpectedTargetProviderNotSupportedError()
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Errors_Expected_ExpectedTargetProviderNotSupportedError___ctor
		               (int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int *param1_01;
		  int param6;
		  int param5;
		  int param4;
		  int param2_00;
		  
		  if (DAT_ram_00a5a394 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_RequirementsWindow_RequirementsWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13146);
		    DAT_ram_00a5a394 = '\x01';
		  }
		  if (param2 == -999) {
		    param1_01 = *(int **)(param1 + 8);
		    if (param1_01 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_01 + 0xb8) <
		           (uint)*(byte *)(
		                          Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo
		                          + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_01 + 100) +
		                   (uint)*(byte *)(
		                                  Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo
		                                  + 0xb8) * 4 + -4) !=
		          Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo))
		      {
		        System_Activator__CreateInstance
		                  (param1_01,
		                   Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo
		                  );
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    param6 = param1_01[5];
		    param5 = param1_01[4];
		    param4 = param1_01[3];
		    param2_00 = param1_01[2];
		    param1_00 = unnamed_function_1417(UI_Windows_RequirementsWindow_RequirementsWindowArgs_TypeInfo)
		    ;
		    UI_Windows_RequirementsWindow_RequirementsWindowArgs___ctor
		              (param1_00,param2_00,0,param4,param5,param6,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = func_ii_7508(StringLiteral_13146,1,0,1,0,0,0,0);
		    *(undefined4 *)(param1_00 + 0x18) = uVar1;
		    UI_Windows_RequirementsWindow__HandleContent(param1_00,0);
		  }
		  return (uint)(param2 == -999);
		}
		*/

		}
	}
}
