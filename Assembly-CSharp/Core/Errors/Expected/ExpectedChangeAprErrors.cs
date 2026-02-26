using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200104A RID: 4170
	[Token(Token = "0x200104A")]
	public class ExpectedChangeAprErrors : ExpectedDefaultError
	{
		// Token: 0x06006216 RID: 25110 RVA: 0x000123F0 File Offset: 0x000105F0
		[Token(Token = "0x6006216")]
		[Address(RVA = "0xAE41", Offset = "0xAE41", VA = "0xAE41", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006217 RID: 25111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006217")]
		[Address(RVA = "0xAE42", Offset = "0xAE42", VA = "0xAE42")]
		public ExpectedChangeAprErrors()
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Errors_Expected_ExpectedChangeAprErrors___ctor(int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5a367 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Errors_Expected_ExpectedChangeNickErrors_SuggestNickVariants_TypeInfo);
		    DAT_ram_00a5a367 = '\x01';
		  }
		  if (param2 == -2) {
		    param1_00 = *(int **)(param1 + 8);
		    if (param1_00 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_00 + 0xb8) <
		           (uint)*(byte *)(
		                          Core_Errors_Expected_ExpectedChangeNickErrors_SuggestNickVariants_TypeInfo
		                          + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_00 + 100) +
		                   (uint)*(byte *)(
		                                  Core_Errors_Expected_ExpectedChangeNickErrors_SuggestNickVariants_TypeInfo
		                                  + 0xb8) * 4 + -4) !=
		          Core_Errors_Expected_ExpectedChangeNickErrors_SuggestNickVariants_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (param1_00,
		                   Core_Errors_Expected_ExpectedChangeNickErrors_SuggestNickVariants_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = param1_00[3];
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_00[2],*(undefined4 *)(iVar1 + 0x14));
		  }
		  return (uint)(param2 == -2);
		}
		*/

		}
	}
}
