using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Duel
{
	// Token: 0x0200107C RID: 4220
	[Token(Token = "0x200107C")]
	public class ExpectedPayoffErrors : ExpectedDefaultError
	{
		// Token: 0x0600628B RID: 25227 RVA: 0x000127E0 File Offset: 0x000109E0
		[Token(Token = "0x600628B")]
		[Address(RVA = "0xAEB1", Offset = "0xAEB1", VA = "0xAEB1", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600628C RID: 25228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600628C")]
		[Address(RVA = "0xAEB2", Offset = "0xAEB2", VA = "0xAEB2")]
		public ExpectedPayoffErrors()
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Errors_Expected_Duel_ExpectedPayoffErrors___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5a39a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17809);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8356);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17807);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17810);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17806);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17811);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4278);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17808);
		    DAT_ram_00a5a39a = '\x01';
		  }
		  uVar3 = StringLiteral_4278;
		  if (((((param2 != -8) && (uVar3 = StringLiteral_17809, param2 != -7)) &&
		       (uVar3 = StringLiteral_8356, param2 != -6)) &&
		      ((uVar3 = StringLiteral_17808, param2 != -5 && (uVar3 = StringLiteral_17811, param2 != -4))))
		     && ((uVar3 = StringLiteral_17810, param2 != -3 &&
		         ((uVar3 = StringLiteral_17806, param2 != -2 &&
		          (uVar3 = StringLiteral_17807, param2 != -100)))))) {
		    uVar3 = 0;
		  }
		  uVar1 = func_ii_4769(uVar3,0);
		  if (uVar1 == 0) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar3,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar2,2,uVar3,0);
		  }
		  return uVar1 ^ 1;
		}
		*/

		}
	}
}
