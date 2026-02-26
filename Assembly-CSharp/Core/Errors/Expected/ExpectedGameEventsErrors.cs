using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200105B RID: 4187
	[Token(Token = "0x200105B")]
	public class ExpectedGameEventsErrors : ExpectedDefaultError
	{
		// Token: 0x06006243 RID: 25155 RVA: 0x000125A0 File Offset: 0x000107A0
		[Token(Token = "0x6006243")]
		[Address(RVA = "0xAE69", Offset = "0xAE69", VA = "0xAE69", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006244 RID: 25156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006244")]
		[Address(RVA = "0xAE6A", Offset = "0xAE6A", VA = "0xAE6A")]
		public ExpectedGameEventsErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedGameEventsErrors___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  int iVar2;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5a37b == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_8356);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8357);
		    DAT_ram_00a5a37b = '\x01';
		  }
		  if (param2 == -7) {
		    Core_Errors_Expected_ExpectedGetIsleBonusErrors__Handle
		              (0xfffffff9,StringLiteral_8357,StringLiteral_8356,0xfffffff9);
		    uVar1 = 1;
		  }
		  else if (param2 == -0x309) {
		    if (DAT_ram_00a5a37d == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Core_Errors_Expected_ExpectedGetIsleBonusErrors_ExpectedGetIsleBonusErrorsArgs_TypeInfo
		                );
		      DAT_ram_00a5a37d = '\x01';
		    }
		    param1_00 = *(int **)(param1 + 8);
		    if (param1_00 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_00 + 0xb8) <
		           (uint)*(byte *)(
		                          Core_Errors_Expected_ExpectedGetIsleBonusErrors_ExpectedGetIsleBonusErrorsArgs_TypeInfo
		                          + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_00 + 100) +
		                   (uint)*(byte *)(
		                                  Core_Errors_Expected_ExpectedGetIsleBonusErrors_ExpectedGetIsleBonusErrorsArgs_TypeInfo
		                                  + 0xb8) * 4 + -4) !=
		          Core_Errors_Expected_ExpectedGetIsleBonusErrors_ExpectedGetIsleBonusErrorsArgs_TypeInfo))
		      {
		        System_Activator__CreateInstance
		                  (param1_00,
		                   Core_Errors_Expected_ExpectedGetIsleBonusErrors_ExpectedGetIsleBonusErrorsArgs_TypeInfo
		                  );
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    uVar1 = 1;
		    iVar2 = param1_00[2];
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		      return 1;
		    }
		  }
		  return uVar1;
		}
		*/

		}
	}
}
