using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200106A RID: 4202
	[Token(Token = "0x200106A")]
	public class ExpectedPortalBuyArtifactItemErrors : ExpectedDefaultError
	{
		// Token: 0x06006268 RID: 25192 RVA: 0x00012690 File Offset: 0x00010890
		[Token(Token = "0x6006268")]
		[Address(RVA = "0xAE8E", Offset = "0xAE8E", VA = "0xAE8E", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006269 RID: 25193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006269")]
		[Address(RVA = "0xAE8F", Offset = "0xAE8F", VA = "0xAE8F")]
		public ExpectedPortalBuyArtifactItemErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedPortalBuyArtifactItemErrors___ctor
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a38b == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6927);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6925);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6928);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6926);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6930);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6929);
		    DAT_ram_00a5a38b = '\x01';
		  }
		  if (param2 == -0xff) {
		    puVar1 = &StringLiteral_6926;
		    iVar4 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  else {
		    uVar2 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		    if (param2 == -6) {
		      puVar1 = &StringLiteral_6925;
		      iVar4 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		    }
		    else if (param2 == -5) {
		      puVar1 = &StringLiteral_6927;
		      iVar4 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		    }
		    else if (param2 == -4) {
		      puVar1 = &StringLiteral_6930;
		      iVar4 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		    }
		    else if (param2 == -3) {
		      puVar1 = &StringLiteral_6929;
		      iVar4 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		    }
		    else {
		      if (param2 != -2) {
		        if (param2 == -1) {
		          return 1;
		        }
		        goto code_r0x812103f5;
		      }
		      puVar1 = &StringLiteral_6928;
		      iVar4 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		    }
		  }
		  if (iVar4 == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(*puVar1,1,0,1,0,0,0,0);
		code_r0x812103f5:
		  iVar4 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar2,0);
		  if (iVar4 != 0) {
		    uVar2 = Core_Errors_Expected_ExpectedEndlessOptionsBillingErrors___c___Handle_b__0_0
		                      (uVar2,param2,uVar2);
		    return uVar2;
		  }
		  uVar3 = System_Uri___ctor(0);
		  uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		  Core_Application_App__get_ToastController(uVar3,2,uVar2,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  func_ii_7830(uVar2,0);
		  return 1;
		}
		*/

		}
	}
}
