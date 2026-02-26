using System;
using Il2CppDummyDll;

namespace CloudsFly
{
	// Token: 0x0200130B RID: 4875
	[Token(Token = "0x200130B")]
	public class UserIsleWorldObjectEngine : BaseIsleWorldObjectEngine<UserIsleWorldObjectEngineArgs>
	{
		// Token: 0x060073E6 RID: 29670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073E6")]
		[Address(RVA = "0xBDC9", Offset = "0xBDC9", VA = "0xBDC9")]
		public UserIsleWorldObjectEngine()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 CloudsFly_UserIsleWorldObjectEngine___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59699 == '\0') {
		    Mono_Security_ASN1__get_Item(&CloudsFly_UserIsleWorldObjectEngine_TypeInfo);
		    DAT_ram_00a59699 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(CloudsFly_UserIsleWorldObjectEngine_TypeInfo);
		  if (DAT_ram_00a59698 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_CloudsFly_BaseIsleWorldObjectEngine_UserIsleWorldObjectEngineArgs___ctor__);
		    DAT_ram_00a59698 = '\x01';
		  }
		  Gameplay_Isles_Base_Controller_BaseIsleViewMediator_object__object__object__object___set_View
		            (param1_00,
		             Method_CloudsFly_BaseIsleWorldObjectEngine_UserIsleWorldObjectEngineArgs___ctor__);
		  return param1_00;
		}
		*/

		}
	}
}
