using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001040 RID: 4160
	[Token(Token = "0x2001040")]
	public class ExpectedArenaWhitMonsterErrors : ExpectedDefaultError
	{
		// Token: 0x060061FA RID: 25082 RVA: 0x000122E8 File Offset: 0x000104E8
		[Token(Token = "0x60061FA")]
		[Address(RVA = "0xAE25", Offset = "0xAE25", VA = "0xAE25", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x060061FB RID: 25083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061FB")]
		[Address(RVA = "0xAE26", Offset = "0xAE26", VA = "0xAE26")]
		public ExpectedArenaWhitMonsterErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedArenaWhitMonsterErrors___ctor(int param1,uint param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a5a357 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Errors_Expected_ExpectedAuchanError_ErrorArgs_TypeInfo);
		    DAT_ram_00a5a357 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Core_Errors_Expected_ExpectedAuchanError_ErrorArgs_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Core_Errors_Expected_ExpectedAuchanError_ErrorArgs_TypeInfo + 0xb8)
		                 * 4 + -4) != Core_Errors_Expected_ExpectedAuchanError_ErrorArgs_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_00,Core_Errors_Expected_ExpectedAuchanError_ErrorArgs_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (param2 == 0xfffffffc) {
		    Core_Errors_Expected_ExpectedAuchanError__Handle(0xfffffffc,param1_00,0xfffffffc);
		  }
		  else {
		    if (param2 < 0xfffffffe) {
		      return 0;
		    }
		    Core_Errors_Expected_ExpectedAuchanError__ShowNoTradeAccountDialogWindow(param2,param2);
		  }
		  return 1;
		}
		*/

		}
	}
}
