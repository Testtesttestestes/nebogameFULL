using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200106B RID: 4203
	[Token(Token = "0x200106B")]
	public class ExpectedPortalCommonErrors : ExpectedDefaultError
	{
		// Token: 0x0600626A RID: 25194 RVA: 0x000126A8 File Offset: 0x000108A8
		[Token(Token = "0x600626A")]
		[Address(RVA = "0xAE90", Offset = "0xAE90", VA = "0xAE90", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600626B RID: 25195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600626B")]
		[Address(RVA = "0xAE91", Offset = "0xAE91", VA = "0xAE91")]
		public ExpectedPortalCommonErrors()
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Errors_Expected_ExpectedPortalCommonErrors___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int param6;
		  int param5;
		  int param4;
		  int param2_00;
		  
		  if (DAT_ram_00a5a38c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_RequirementsWindow_RequirementsWindowArgs_TypeInfo);
		    DAT_ram_00a5a38c = '\x01';
		  }
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
		        Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_01,
		                 Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo
		                );
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (param2 == -1000) {
		    param6 = param1_01[5];
		    param5 = param1_01[4];
		    param4 = param1_01[3];
		    param2_00 = param1_01[2];
		    param1_00 = unnamed_function_1417(UI_Windows_RequirementsWindow_RequirementsWindowArgs_TypeInfo)
		    ;
		    UI_Windows_RequirementsWindow_RequirementsWindowArgs___ctor
		              (param1_00,param2_00,param2_00,param4,param5,param6,0);
		    UI_Windows_RequirementsWindow__HandleContent(param1_00,0);
		  }
		  return (uint)(param2 == -1000);
		}
		*/

		}
	}
}
