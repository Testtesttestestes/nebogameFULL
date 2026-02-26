using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x020013AA RID: 5034
	[Token(Token = "0x20013AA")]
	public class RTLFixer
	{
		// Token: 0x060077CA RID: 30666 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077CA")]
		[Address(RVA = "0xC125", Offset = "0xC125", VA = "0xC125")]
		public static string Fix(string str)
		{
		/* --- GHIDRA: Fix ---
		undefined4 I2_Loc_RTLFixer__Fix(undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int param1_00;
		  
		  if (DAT_ram_00a54e17 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a54e17 = '\x01';
		  }
		  if (param2 != 0) {
		    uVar6 = I2_Loc_RTLFixer__Fix(param1,0,1,param2);
		    return uVar6;
		  }
		  iVar1 = 0;
		  iVar2 = System_Net_WebConnection__ReadLine(param1,0x20,0,0);
		  uVar6 = StringLiteral_5;
		  uVar5 = StringLiteral_5;
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      param1_00 = *(int *)(iVar2 + iVar1 * 4 + 0x10);
		      uVar3 = func_ii_7775(param1_00,0);
		      uVar3 = func_ii_3010(uVar3,*(int *)(param1_00 + 8) / 2,0);
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      iVar4 = System_Char__IsUpper(uVar3,0);
		      if (iVar4 == 0) {
		        uVar5 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                          (uVar5,param1_00,StringLiteral_118,0);
		      }
		      else {
		        uVar5 = I2_Loc_RTLFixer__Fix(uVar5,0,1,iVar1);
		        uVar6 = System_Int32__ToString(uVar6,uVar5,param1_00,StringLiteral_118,0);
		        uVar5 = StringLiteral_5;
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  uVar3 = StringLiteral_5;
		  iVar1 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                    (uVar5,StringLiteral_5,0);
		  if (iVar1 != 0) {
		    uVar5 = I2_Loc_RTLFixer__Fix(uVar5,0,1,uVar3);
		    uVar6 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar6,uVar5,0);
		  }
		  return uVar6;
		}
		*/

		/* --- GHIDRA: Fix ---
		undefined4 I2_Loc_RTLFixer__Fix(undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int param1_00;
		  
		  if (DAT_ram_00a54e17 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a54e17 = '\x01';
		  }
		  if (param2 != 0) {
		    uVar6 = I2_Loc_RTLFixer__Fix(param1,0,1,param2);
		    return uVar6;
		  }
		  iVar1 = 0;
		  iVar2 = System_Net_WebConnection__ReadLine(param1,0x20,0,0);
		  uVar6 = StringLiteral_5;
		  uVar5 = StringLiteral_5;
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      param1_00 = *(int *)(iVar2 + iVar1 * 4 + 0x10);
		      uVar3 = func_ii_7775(param1_00,0);
		      uVar3 = func_ii_3010(uVar3,*(int *)(param1_00 + 8) / 2,0);
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      iVar4 = System_Char__IsUpper(uVar3,0);
		      if (iVar4 == 0) {
		        uVar5 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                          (uVar5,param1_00,StringLiteral_118,0);
		      }
		      else {
		        uVar5 = I2_Loc_RTLFixer__Fix(uVar5,0,1,iVar1);
		        uVar6 = System_Int32__ToString(uVar6,uVar5,param1_00,StringLiteral_118,0);
		        uVar5 = StringLiteral_5;
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  uVar3 = StringLiteral_5;
		  iVar1 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                    (uVar5,StringLiteral_5,0);
		  if (iVar1 != 0) {
		    uVar5 = I2_Loc_RTLFixer__Fix(uVar5,0,1,uVar3);
		    uVar6 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar6,uVar5,0);
		  }
		  return uVar6;
		}
		*/

		/* --- GHIDRA: Fix ---
		undefined4 I2_Loc_RTLFixer__Fix(undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int param1_00;
		  
		  if (DAT_ram_00a54e17 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a54e17 = '\x01';
		  }
		  if (param2 != 0) {
		    uVar6 = I2_Loc_RTLFixer__Fix(param1,0,1,param2);
		    return uVar6;
		  }
		  iVar1 = 0;
		  iVar2 = System_Net_WebConnection__ReadLine(param1,0x20,0,0);
		  uVar6 = StringLiteral_5;
		  uVar5 = StringLiteral_5;
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      param1_00 = *(int *)(iVar2 + iVar1 * 4 + 0x10);
		      uVar3 = func_ii_7775(param1_00,0);
		      uVar3 = func_ii_3010(uVar3,*(int *)(param1_00 + 8) / 2,0);
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      iVar4 = System_Char__IsUpper(uVar3,0);
		      if (iVar4 == 0) {
		        uVar5 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                          (uVar5,param1_00,StringLiteral_118,0);
		      }
		      else {
		        uVar5 = I2_Loc_RTLFixer__Fix(uVar5,0,1,iVar1);
		        uVar6 = System_Int32__ToString(uVar6,uVar5,param1_00,StringLiteral_118,0);
		        uVar5 = StringLiteral_5;
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  uVar3 = StringLiteral_5;
		  iVar1 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                    (uVar5,StringLiteral_5,0);
		  if (iVar1 != 0) {
		    uVar5 = I2_Loc_RTLFixer__Fix(uVar5,0,1,uVar3);
		    uVar6 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar6,uVar5,0);
		  }
		  return uVar6;
		}
		*/

			return null;
		}

		// Token: 0x060077CB RID: 30667 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077CB")]
		[Address(RVA = "0xC126", Offset = "0xC126", VA = "0xC126")]
		public static string Fix(string str, bool rtl)
		{
			return null;
		}

		// Token: 0x060077CC RID: 30668 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077CC")]
		[Address(RVA = "0xC127", Offset = "0xC127", VA = "0xC127")]
		public static string Fix(string str, bool showTashkeel, bool useHinduNumbers)
		{
			return null;
		}

		// Token: 0x060077CD RID: 30669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077CD")]
		[Address(RVA = "0xC128", Offset = "0xC128", VA = "0xC128")]
		public RTLFixer()
		{
		}
	}
}
