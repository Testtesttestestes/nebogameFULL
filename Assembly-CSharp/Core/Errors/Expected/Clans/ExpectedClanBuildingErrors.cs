using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Clans
{
	// Token: 0x02001080 RID: 4224
	[Token(Token = "0x2001080")]
	public class ExpectedClanBuildingErrors : ExpectedDefaultError
	{
		// Token: 0x06006295 RID: 25237 RVA: 0x00012840 File Offset: 0x00010A40
		[Token(Token = "0x6006295")]
		[Address(RVA = "0xAEBB", Offset = "0xAEBB", VA = "0xAEBB", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006296 RID: 25238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006296")]
		[Address(RVA = "0xAEBC", Offset = "0xAEBC", VA = "0xAEBC")]
		public ExpectedClanBuildingErrors()
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Errors_Expected_Clans_ExpectedClanBuildingErrors___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  uint uVar1;
		  undefined4 uVar2;
		  int *param1_01;
		  
		  if (DAT_ram_00a5a3a0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Errors_Expected_Clans_ExpectedClanWarErrors_ExpectedClanWarsErrorsArgs_TypeInfo
		              );
		    DAT_ram_00a5a3a0 = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 8);
		  if (param1_01 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_01 + 0xb8) <
		         (uint)*(byte *)(
		                        Core_Errors_Expected_Clans_ExpectedClanWarErrors_ExpectedClanWarsErrorsArgs_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_01 + 100) +
		                 (uint)*(byte *)(
		                                Core_Errors_Expected_Clans_ExpectedClanWarErrors_ExpectedClanWarsErrorsArgs_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Core_Errors_Expected_Clans_ExpectedClanWarErrors_ExpectedClanWarsErrorsArgs_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_01,
		                 Core_Errors_Expected_Clans_ExpectedClanWarErrors_ExpectedClanWarsErrorsArgs_TypeInfo
		                );
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1_00 = Core_Errors_Expected_Clans_ExpectedClanWarErrors__Handle(param2,param1_01,param1_01);
		  uVar1 = func_ii_4769(param1_00,0);
		  if (uVar1 == 0) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    Core_Application_App__get_ToastController(uVar2,2,param1_00,0);
		  }
		  return uVar1 ^ 1;
		}
		*/

		}
	}
}
