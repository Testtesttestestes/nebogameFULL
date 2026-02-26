using System;
using Il2CppDummyDll;

namespace CloudsFly
{
	// Token: 0x020012F5 RID: 4853
	[Token(Token = "0x20012F5")]
	public class ClanIsleWorldObjectEngine : BaseIsleWorldObjectEngine<ClanIsleWorldObjectEngineArgs>
	{
		// Token: 0x06007386 RID: 29574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007386")]
		[Address(RVA = "0xBD72", Offset = "0xBD72", VA = "0xBD72")]
		public ClanIsleWorldObjectEngine()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 CloudsFly_ClanIsleWorldObjectEngine___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59676 == '\0') {
		    Mono_Security_ASN1__get_Item(&CloudsFly_ClanIsleWorldObjectEngine_TypeInfo);
		    DAT_ram_00a59676 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(CloudsFly_ClanIsleWorldObjectEngine_TypeInfo);
		  if (DAT_ram_00a59675 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_CloudsFly_BaseIsleWorldObjectEngine_ClanIsleWorldObjectEngineArgs___ctor__);
		    DAT_ram_00a59675 = '\x01';
		  }
		  Gameplay_Isles_Base_Controller_BaseIsleViewMediator_object__object__object__object___set_View
		            (param1_00,
		             Method_CloudsFly_BaseIsleWorldObjectEngine_ClanIsleWorldObjectEngineArgs___ctor__);
		  return param1_00;
		}
		*/

		}
	}
}
