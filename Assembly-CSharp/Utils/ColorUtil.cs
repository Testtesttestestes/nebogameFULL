using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Utils
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	public static class ColorUtil
	{
		// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x56D0", Offset = "0x56D0", VA = "0x56D0")]
		public static void SetRGB(ref Color32 c, uint value)
		{
		/* --- GHIDRA: SetRGB ---
		void Utils_ColorUtil__SetRGB(int param1,float param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a648de == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_Enum___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_Enum__TypeInfo);
		    DAT_ram_00a648de = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_HashSet_Enum__TypeInfo);
		  func_ii_7115(param1_00,Method_System_Collections_Generic_HashSet_Enum___ctor__);
		  *(undefined4 *)(param1 + 8) = param1_00;
		  *(float *)(param1 + 0xc) = param2;
		  return;
		}
		*/

		}
	}
}
