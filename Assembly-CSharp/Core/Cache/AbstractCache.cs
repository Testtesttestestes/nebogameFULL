using System;
using Il2CppDummyDll;

namespace Core.Cache
{
	// Token: 0x020010F5 RID: 4341
	[Token(Token = "0x20010F5")]
	public abstract class AbstractCache
	{
		// Token: 0x0600656A RID: 25962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600656A")]
		[Address(RVA = "0xB12E", Offset = "0xB12E", VA = "0xB12E")]
		protected AbstractCache()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Cache_AbstractCache___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60850 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_ulong__ArtifactData__TypeInfo);
		    DAT_ram_00a60850 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_ulong__ArtifactData__TypeInfo);
		  System_Collections_Generic_Dictionary_ulong__ulong___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_ulong__ArtifactData___ctor__);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(undefined4 *)(param1 + 8) = param2;
		  return;
		}
		*/

		}

		// Token: 0x04003631 RID: 13873
		[Token(Token = "0x4003631")]
		[FieldOffset(Offset = "0x0")]
		protected static long GlobalOperationIndex;
	}
}
