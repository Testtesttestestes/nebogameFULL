using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace JWTDecoder
{
	// Token: 0x020000DB RID: 219
	[Token(Token = "0x20000DB")]
	public static class Decoder
	{
		// Token: 0x0600079C RID: 1948 RVA: 0x000033A8 File Offset: 0x000015A8
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x5B72", Offset = "0x5B72", VA = "0x5B72")]
		public static ValueTuple<JwtHeader, string, string> DecodeToken(string token)
		{
		/* --- GHIDRA: DecodeToken ---
		undefined4 JWTDecoder_Decoder__DecodeToken(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 *puVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5b852 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Convert_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2361);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1226);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1331);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2363);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    DAT_ram_00a5b852 = '\x01';
		  }
		  puVar1 = &StringLiteral_2363;
		  uVar2 = func_ii_7088(param1,StringLiteral_1331,StringLiteral_1226,0);
		  param1_00 = func_ii_7088(uVar2,StringLiteral_19176,StringLiteral_1618,0);
		  iVar5 = *(int *)(param1_00 + 8) % 4;
		  if (iVar5 != 0) {
		    if (iVar5 == 1) {
		code_r0x81387542:
		      uVar2 = unnamed_function_2232(&System_Exception_TypeInfo);
		      uVar2 = unnamed_function_1417(uVar2);
		      uVar3 = unnamed_function_2232(&StringLiteral_11615);
		      System_String__Concat(uVar2,uVar3,0);
		      uVar3 = unnamed_function_2232(&Method_JWTDecoder_Decoder_Base64DecodeToString__);
		      func_ii_1050(uVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (iVar5 != 2) {
		      if (iVar5 != 3) goto code_r0x81387542;
		      puVar1 = &StringLiteral_2361;
		    }
		    param1_00 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(param1_00,*puVar1,0);
		  }
		  if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Convert_TypeInfo);
		  }
		  uVar2 = System_Xml_XmlConvert__FromBinHexString(param1_00,0);
		  piVar4 = (int *)func_ii_5618(0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x1e8) * 4))
		                    (piVar4,uVar2,*(undefined4 *)(*piVar4 + 0x1ec));
		  return uVar2;
		}
		*/

			return default(ValueTuple<JwtHeader, string, string>);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600079D")]
		public static T DecodePayload<T>(string token)
		{
		/* --- GHIDRA: DecodePayload<__Il2CppFullySharedGenericType> ---
		undefined4
		JWTDecoder_Decoder__DecodePayload___Il2CppFullySharedGenericType_
		          (undefined4 param1,undefined4 param2,int param3)
		
		{
		  undefined4 param2_00;
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_00;
		  uint *puVar4;
		  byte local_5;
		  undefined4 local_4;
		  
		  piVar1 = *(int **)(param3 + 0x1c);
		  if (piVar1 == (int *)0x0) {
		    Mono_Security_ASN1__get_Item(&Sirenix_Utilities_DeepReflection_TypeInfo);
		    piVar1 = *(int **)(param3 + 0x1c);
		    if (piVar1 == (int *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param3);
		      piVar1 = *(int **)(param3 + 0x1c);
		    }
		  }
		  local_5 = 0;
		  iVar2 = *piVar1;
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  iVar2 = unnamed_function_1417(iVar2);
		  puVar4 = *(uint **)(*(int *)(param3 + 0x1c) + 4);
		  (**(code **)((ulonglong)*puVar4 * 4))(iVar2,puVar4);
		  uVar3 = *(undefined4 *)(*(int *)(param3 + 0x1c) + 8);
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  local_4 = func_ii_2734(uVar3,0);
		  uVar3 = func_ii_2734(*(undefined4 *)(*(int *)(param3 + 0x1c) + 0xc),0);
		  if (*(int *)(Sirenix_Utilities_DeepReflection_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Sirenix_Utilities_DeepReflection_TypeInfo);
		  }
		  uVar3 = Sirenix_Utilities_DeepReflection__SlowSetMemberValue(uVar3,&local_4,param1,&local_5,0,0);
		  if (local_5 == 0) {
		    if (*(int *)(Sirenix_Utilities_DeepReflection_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Sirenix_Utilities_DeepReflection_TypeInfo);
		    }
		    uVar3 = Sirenix_Utilities_DeepReflection__CreateSlowDeepStaticValueGetterDelegate(uVar3,0);
		    *(undefined4 *)(iVar2 + 8) = uVar3;
		    param1_00 = *(int *)(*(int *)(param3 + 0x1c) + 0x14);
		    if ((*(byte *)(param1_00 + 0xbd) & 1) == 0) {
		      param1_00 = func_ii_1079(param1_00);
		    }
		    uVar3 = unnamed_function_1417(param1_00);
		    puVar4 = *(uint **)(*(int *)(param3 + 0x1c) + 0x18);
		    (**(code **)((ulonglong)*puVar4 * 4))
		              (uVar3,iVar2,*(undefined4 *)(*(int *)(param3 + 0x1c) + 0x10),puVar4);
		    return uVar3;
		  }
		  uVar3 = unnamed_function_2232(&System_ArgumentException_TypeInfo);
		  uVar3 = unnamed_function_1417(uVar3);
		  param2_00 = unnamed_function_2232(&StringLiteral_8566);
		  func_ii_3067(uVar3,param2_00,0);
		  func_ii_1050(uVar3,param3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x5B73", Offset = "0x5B73", VA = "0x5B73")]
		private static string Base64DecodeToString(string ToDecode)
		{
		/* --- GHIDRA: Base64DecodeToString ---
		uint JWTDecoder_Decoder__Base64DecodeToString(undefined4 param1,int param2,undefined4 param3)
		
		{
		  char cVar1;
		  undefined4 in_register_20000004;
		  undefined4 in_register_20000014;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  uint uVar6;
		  int iVar7;
		  int *piVar8;
		  uint *puVar9;
		  undefined4 uVar10;
		  double dVar11;
		  undefined8 uVar12;
		  undefined8 uVar13;
		  uint uVar14;
		  longlong lVar15;
		  undefined8 local_20;
		  undefined4 local_18;
		  byte local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b853 == '\0') {
		    Mono_Security_ASN1__get_Item(&JWTDecoder_Algorithms_AlgorithmFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Convert_TypeInfo);
		    Mono_Security_ASN1__get_Item(&JWTDecoder_Helpers_DateTimeHelpers_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&JWTDecoder_Algorithms_IJwtAlgorithm_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Newtonsoft_Json_JsonConvert_DeserializeObject_JwtExpiration___);
		    Mono_Security_ASN1__get_Item(&Newtonsoft_Json_JsonConvert_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_double__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_double__get_Value__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1480);
		    DAT_ram_00a5b853 = '\x01';
		  }
		  local_8 = 0;
		  _local_10 = 0;
		  piVar3 = (int *)func_ii_5618(0);
		  uVar12 = CONCAT44(in_register_20000004,piVar3);
		  uVar13 = CONCAT44(in_register_20000014,param2);
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x158) * 4))
		                    (uVar12,uVar13,*(undefined4 *)(*piVar3 + 0x15c));
		  uVar2 = (undefined4)((ulonglong)uVar13 >> 0x20);
		  uVar10 = (undefined4)((ulonglong)uVar12 >> 0x20);
		  uVar5 = unnamed_function_1417(JWTDecoder_Algorithms_AlgorithmFactory_TypeInfo);
		  Localization_Culture_WebGL_CultureProvider__LocaleToSystemLang(&local_20,param1,param2);
		  uVar6 = func_ii_4769(param2,0);
		  if (*(int *)(Newtonsoft_Json_JsonConvert_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Newtonsoft_Json_JsonConvert_TypeInfo);
		  }
		  iVar7 = func_ii_14092(local_20._4_4_,
		                        Method_Newtonsoft_Json_JsonConvert_DeserializeObject_JwtExpiration___);
		  cVar1 = *(char *)(iVar7 + 8);
		  if (param2 != 0) {
		    piVar3 = (int *)JWTDecoder_Helpers_EncodingHelper__GetString
		                              (uVar5,*(undefined4 *)((int)local_20 + 8),param2);
		    if (*(int *)(Newtonsoft_Json_JsonConvert_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Newtonsoft_Json_JsonConvert_TypeInfo);
		    }
		    uVar6 = 0;
		    uVar5 = Newtonsoft_Json_JsonConvert__ToString((int)local_20,0);
		    uVar5 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (uVar5,StringLiteral_1480,local_20._4_4_,0);
		    piVar8 = (int *)func_ii_5618(0);
		    uVar12 = CONCAT44(uVar10,piVar8);
		    uVar13 = CONCAT44(uVar2,uVar5);
		    uVar5 = (**(code **)((ulonglong)*(uint *)(*piVar8 + 0x158) * 4))
		                      (uVar12,uVar13,*(undefined4 *)(*piVar8 + 0x15c));
		    uVar2 = (undefined4)((ulonglong)uVar13 >> 0x20);
		    uVar10 = (undefined4)((ulonglong)uVar12 >> 0x20);
		    iVar7 = *piVar3;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (JWTDecoder_Algorithms_IJwtAlgorithm_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar6 * 8)) {
		          puVar9 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar6 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x813877d4;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar6);
		    }
		    puVar9 = (uint *)func_ii_1080(piVar3,JWTDecoder_Algorithms_IJwtAlgorithm_TypeInfo,0);
		code_r0x813877d4:
		    uVar10 = (**(code **)((ulonglong)*puVar9 * 4))
		                       (CONCAT44(uVar10,piVar3),CONCAT44(uVar2,uVar4),uVar5,puVar9[1]);
		    if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Convert_TypeInfo);
		    }
		    uVar10 = System_Text_StringBuilder__Append(uVar10,0);
		    uVar6 = System_Collections_CollectionBase___ctor(uVar10,local_18,0);
		  }
		  if (*(int *)(Newtonsoft_Json_JsonConvert_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Newtonsoft_Json_JsonConvert_TypeInfo);
		  }
		  iVar7 = func_ii_14092(local_20._4_4_,
		                        Method_Newtonsoft_Json_JsonConvert_DeserializeObject_JwtExpiration___);
		  _local_10 = *(undefined8 *)(iVar7 + 8);
		  local_8 = *(undefined8 *)(iVar7 + 0x10);
		  if (local_10 == 0) {
		    uVar14 = (uint)(cVar1 == '\0');
		  }
		  else {
		    dVar11 = System_Nullable_double___get_HasValue
		                       (&local_10,Method_System_Nullable_double__get_Value__);
		    if (*(int *)(JWTDecoder_Helpers_DateTimeHelpers_TypeInfo + 0x74) == 0) {
		      func_ii_306000(JWTDecoder_Helpers_DateTimeHelpers_TypeInfo);
		    }
		    if (ABS(dVar11) < 9.223372036854776e+18) {
		      lVar15 = (longlong)dVar11;
		    }
		    else {
		      lVar15 = -0x8000000000000000;
		    }
		    if (DAT_ram_00a5b856 == '\0') {
		      Mono_Security_ASN1__get_Item(&JWTDecoder_Helpers_DateTimeHelpers_TypeInfo);
		      Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		      DAT_ram_00a5b856 = '\x01';
		    }
		    if (*(int *)(JWTDecoder_Helpers_DateTimeHelpers_TypeInfo + 0x74) == 0) {
		      func_ii_306000(JWTDecoder_Helpers_DateTimeHelpers_TypeInfo);
		    }
		    local_20 = **(undefined8 **)(JWTDecoder_Helpers_DateTimeHelpers_TypeInfo + 0x5c);
		    if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_DateTime_TypeInfo);
		    }
		    uVar12 = System_DateTime__AddMonths(&local_20,(double)lVar15,0);
		    if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_DateTime_TypeInfo);
		    }
		    uVar13 = ICSharpCode_SharpZipLib_Zip_ZipEntry___ctor(0);
		    uVar14 = func_ii_11431(uVar12,uVar13,0);
		  }
		  return uVar6 & uVar14;
		}
		*/

			return null;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x5B74", Offset = "0x5B74", VA = "0x5B74")]
		public static bool Validate(string token, [Optional] string secret)
		{
		/* --- GHIDRA: Validate ---
		undefined4 JWTDecoder_Decoder__Validate(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  double dVar3;
		  undefined8 param1_00;
		  undefined8 param2_00;
		  longlong lVar4;
		  undefined1 auStack_20 [8];
		  byte local_18;
		  undefined4 uStack_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b854 == '\0') {
		    Mono_Security_ASN1__get_Item(&JWTDecoder_Helpers_DateTimeHelpers_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Newtonsoft_Json_JsonConvert_DeserializeObject_JwtExpiration___);
		    Mono_Security_ASN1__get_Item(&Newtonsoft_Json_JsonConvert_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_double__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_double__get_Value__);
		    DAT_ram_00a5b854 = '\x01';
		  }
		  Localization_Culture_WebGL_CultureProvider__LocaleToSystemLang(&local_18,param1,auStack_20);
		  if (*(int *)(Newtonsoft_Json_JsonConvert_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Newtonsoft_Json_JsonConvert_TypeInfo);
		  }
		  uVar2 = 0;
		  iVar1 = func_ii_14092(uStack_14,
		                        Method_Newtonsoft_Json_JsonConvert_DeserializeObject_JwtExpiration___);
		  _local_18 = *(undefined8 *)(iVar1 + 8);
		  local_10 = *(undefined8 *)(iVar1 + 0x10);
		  if (local_18 != 0) {
		    dVar3 = System_Nullable_double___get_HasValue
		                      (&local_18,Method_System_Nullable_double__get_Value__);
		    if (*(int *)(JWTDecoder_Helpers_DateTimeHelpers_TypeInfo + 0x74) == 0) {
		      func_ii_306000(JWTDecoder_Helpers_DateTimeHelpers_TypeInfo);
		    }
		    if (ABS(dVar3) < 9.223372036854776e+18) {
		      lVar4 = (longlong)dVar3;
		    }
		    else {
		      lVar4 = -0x8000000000000000;
		    }
		    if (DAT_ram_00a5b856 == '\0') {
		      Mono_Security_ASN1__get_Item(&JWTDecoder_Helpers_DateTimeHelpers_TypeInfo);
		      Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		      DAT_ram_00a5b856 = '\x01';
		    }
		    if (*(int *)(JWTDecoder_Helpers_DateTimeHelpers_TypeInfo + 0x74) == 0) {
		      func_ii_306000(JWTDecoder_Helpers_DateTimeHelpers_TypeInfo);
		    }
		    local_8 = **(undefined8 **)(JWTDecoder_Helpers_DateTimeHelpers_TypeInfo + 0x5c);
		    if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_DateTime_TypeInfo);
		    }
		    param1_00 = System_DateTime__AddMonths(&local_8,(double)lVar4,0);
		    if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_DateTime_TypeInfo);
		    }
		    param2_00 = ICSharpCode_SharpZipLib_Zip_ZipEntry___ctor(0);
		    uVar2 = System_Net_WebConnection__CanReuseConnection(param1_00,param2_00,0);
		  }
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x5B75", Offset = "0x5B75", VA = "0x5B75")]
		public static bool IsExpired(string token)
		{
		/* --- GHIDRA: IsExpired ---
		void JWTDecoder_Decoder__IsExpired(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5b855 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_16341);
		    DAT_ram_00a5b855 = '\x01';
		  }
		  System_ArgumentOutOfRangeException___ctor(param1,param2,StringLiteral_16341,0);
		  return;
		}
		*/

			return default(bool);
		}
	}
}
