using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace JWTDecoder.Helpers
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	internal static class EncodingHelper
	{
		// Token: 0x060007AC RID: 1964 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x5B81", Offset = "0x5B81", VA = "0x5B81")]
		internal static byte[] GetBytes(string input)
		{
		/* --- GHIDRA: GetBytes ---
		undefined4 JWTDecoder_Helpers_EncodingHelper__GetBytes(undefined4 param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  
		  piVar1 = (int *)func_ii_5618(0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x1e8) * 4))
		                    (piVar1,param1,*(undefined4 *)(*piVar1 + 0x1ec));
		  return uVar2;
		}
		*/

		/* --- GHIDRA: GetBytes ---
		undefined4 JWTDecoder_Helpers_EncodingHelper__GetBytes(undefined4 param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  
		  piVar1 = (int *)func_ii_5618(0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x1e8) * 4))
		                    (piVar1,param1,*(undefined4 *)(*piVar1 + 0x1ec));
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x5B82", Offset = "0x5B82", VA = "0x5B82")]
		internal static byte[][] GetBytes(IEnumerable<string> input)
		{
			return null;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x5B83", Offset = "0x5B83", VA = "0x5B83")]
		internal static string GetString(byte[] bytes)
		{
		/* --- GHIDRA: GetString ---
		undefined4
		JWTDecoder_Helpers_EncodingHelper__GetString(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  undefined4 *puVar2;
		  
		  if (DAT_ram_00a5b859 == '\0') {
		    Mono_Security_ASN1__get_Item(&JWTDecoder_HashAlgorithm_var);
		    Mono_Security_ASN1__get_Item(&JWTDecoder_HashAlgorithm_TypeInfo);
		    DAT_ram_00a5b859 = '\x01';
		  }
		  uVar1 = JWTDecoder_HashAlgorithm_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar1 = func_ii_2734(uVar1,0);
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  param1_00 = (int *)func_ii_6444(uVar1,param2,0);
		  if (param1_00 != (int *)0x0) {
		    if (*(int *)(*param1_00 + 0x20) == *(int *)(JWTDecoder_HashAlgorithm_TypeInfo + 0x20)) {
		      puVar2 = (undefined4 *)func_ii_15774(param1_00);
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                        (param1,*puVar2,*(undefined4 *)(*param1 + 0xf4));
		      return uVar1;
		    }
		    System_Activator__CreateInstance(param1_00,JWTDecoder_HashAlgorithm_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}
	}
}
