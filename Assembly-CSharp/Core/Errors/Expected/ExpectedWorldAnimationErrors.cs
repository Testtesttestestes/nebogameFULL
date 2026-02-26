using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200107A RID: 4218
	[Token(Token = "0x200107A")]
	public class ExpectedWorldAnimationErrors : ExpectedDefaultError
	{
		// Token: 0x06006287 RID: 25223 RVA: 0x000127B0 File Offset: 0x000109B0
		[Token(Token = "0x6006287")]
		[Address(RVA = "0xAEAD", Offset = "0xAEAD", VA = "0xAEAD", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006288 RID: 25224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006288")]
		[Address(RVA = "0xAEAE", Offset = "0xAEAE", VA = "0xAEAE")]
		public ExpectedWorldAnimationErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedWorldAnimationErrors___ctor
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a398 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6231);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6232);
		    DAT_ram_00a5a398 = '\x01';
		  }
		  if (param2 != -5) {
		    if ((param2 == -4) || (param2 == -3)) {
		      return 0;
		    }
		    if (param2 != -2) {
		      if (param2 == -1) {
		        iVar1 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		        UI_Windows_Alert__Show(iVar1,0);
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar2 = func_ii_7508(StringLiteral_6231,1,0,1,0,0,0,0);
		        *(undefined4 *)(iVar1 + 0x1c) = uVar2;
		        UI_Windows_UnityInstantiator___ctor(iVar1,0);
		        return 1;
		      }
		      if (param2 != -2000) {
		        if (param2 != -0x32) {
		          return 0;
		        }
		        iVar1 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		        UI_Windows_Alert__Show(iVar1,0);
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar2 = func_ii_7508(StringLiteral_6232,1,0,1,0,0,0,0);
		        *(undefined4 *)(iVar1 + 0x1c) = uVar2;
		        UI_Windows_UnityInstantiator___ctor(iVar1,0);
		      }
		    }
		  }
		  return 1;
		}
		*/

		}
	}
}
