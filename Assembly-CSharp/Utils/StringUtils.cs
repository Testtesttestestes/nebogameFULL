using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace Utils
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	public static class StringUtils
	{
		// Token: 0x060002E4 RID: 740 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x21A7", Offset = "0x21A7", VA = "0x21A7")]
		public static string GetShortNumberString(double value, bool asInt = false)
		{
			return null;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1CCD", Offset = "0x1CCD", VA = "0x1CCD")]
		public static string GetShortNumberString2(double value)
		{
			return null;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1AFF", Offset = "0x1AFF", VA = "0x1AFF")]
		public static string GetNumberStringWithSpaces(double value, string whiteSpace = "\u00a0")
		{
		/* --- GHIDRA: GetNumberStringWithSpaces ---
		void Utils_StringUtils__GetNumberStringWithSpaces(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = System_Collections_CollectionBase___ctor(param1[6],param2,0);
		  if (iVar1 == 0) {
		    param1[6] = param2;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))(param1,*(undefined4 *)(*param1 + 0xe4));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x5760", Offset = "0x5760", VA = "0x5760")]
		public static string GetRomanNumber(uint value)
		{
		/* --- GHIDRA: GetRomanNumber ---
		undefined4 Utils_StringUtils__GetRomanNumber(double param1,double param2,undefined4 param3)
		
		{
		  int param3_00;
		  undefined4 uVar1;
		  undefined4 param3_01;
		  
		  if (DAT_ram_00a6281e == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    DAT_ram_00a6281e = '\x01';
		  }
		  param3_00 = Utils_StringUtils_TypeInfo;
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  uVar1 = UI_SimpleIconValue__set_IconAssetId(param1,StringLiteral_28780,param3_00);
		  param3_01 = func_ii_8614(param2,0,uVar1);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar1,StringLiteral_1618,param3_01,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x5761", Offset = "0x5761", VA = "0x5761")]
		public static string GetBarValueString(double current, double total)
		{
		/* --- GHIDRA: GetBarValueString ---
		void Utils_StringUtils__GetBarValueString(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  undefined4 param2;
		  
		  if (DAT_ram_00a6281f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_RegularExpressions_Regex_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19153);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18993);
		    DAT_ram_00a6281f = '\x01';
		  }
		  **(undefined4 **)(Utils_StringUtils_TypeInfo + 0x5c) = StringLiteral_18993;
		  uVar1 = unnamed_function_1417(System_Text_RegularExpressions_Regex_TypeInfo);
		  System_Xml_Schema_FacetsChecker_FacetsCompiler__Preprocess(uVar1,StringLiteral_19153,8,0);
		  puVar2 = *(undefined4 **)(Utils_StringUtils_TypeInfo + 0x5c);
		  puVar2[1] = uVar1;
		  param2 = *puVar2;
		  uVar1 = unnamed_function_1417(System_Text_RegularExpressions_Regex_TypeInfo);
		  System_Xml_Schema_FacetsChecker_FacetsCompiler__Preprocess(uVar1,param2,0x208,0);
		  *(undefined4 *)(*(int *)(Utils_StringUtils_TypeInfo + 0x5c) + 8) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string TAG_PATTERN;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x4")]
		public static readonly Regex EMAIL_REGEXP;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Regex TAG_REGEXP;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0xC")]
		private static NumberFormatInfo _numberFormatInfoWithSpaces;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: .cctor ---
		float Utils_StringUtils___cctor(ulonglong param1,undefined4 param2)
		
		{
		  return (float)param1 / 1000.0;
		}
		*/


		/* --- GHIDRA: IsNullOrEmpty ---
		void Newtonsoft_Json_Utilities_StringUtils__IsNullOrEmpty
		               (undefined4 param1,undefined4 param2,undefined4 param3,int param4)
		
		{
		  System_Collections_Generic_KeyValuePair_object__int____ctor
		            (param1,param2,param3,1,*(undefined4 *)(*(int *)(*(int *)(param4 + 0x10) + 0x60) + 0x88)
		            );
		  return;
		}
		*/


		/* --- GHIDRA: FormatWith ---
		undefined4
		Newtonsoft_Json_Utilities_StringUtils__FormatWith
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a54d55 == '\0') {
		    Mono_Security_ASN1__get_Item(&Newtonsoft_Json_IJsonLineInfo_TypeInfo);
		    DAT_ram_00a54d55 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x10c));
		  param1_00 = func_ii_1082(param1,Newtonsoft_Json_IJsonLineInfo_TypeInfo);
		  uVar1 = Newtonsoft_Json_JsonSerializationException___ctor(param1_00,uVar1,param2,param3,param1);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: FormatWith ---
		undefined4
		Newtonsoft_Json_Utilities_StringUtils__FormatWith
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a54d55 == '\0') {
		    Mono_Security_ASN1__get_Item(&Newtonsoft_Json_IJsonLineInfo_TypeInfo);
		    DAT_ram_00a54d55 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x10c));
		  param1_00 = func_ii_1082(param1,Newtonsoft_Json_IJsonLineInfo_TypeInfo);
		  uVar1 = Newtonsoft_Json_JsonSerializationException___ctor(param1_00,uVar1,param2,param3,param1);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: FormatWith ---
		undefined4
		Newtonsoft_Json_Utilities_StringUtils__FormatWith
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a54d55 == '\0') {
		    Mono_Security_ASN1__get_Item(&Newtonsoft_Json_IJsonLineInfo_TypeInfo);
		    DAT_ram_00a54d55 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x10c));
		  param1_00 = func_ii_1082(param1,Newtonsoft_Json_IJsonLineInfo_TypeInfo);
		  uVar1 = Newtonsoft_Json_JsonSerializationException___ctor(param1_00,uVar1,param2,param3,param1);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: FormatWith ---
		undefined4
		Newtonsoft_Json_Utilities_StringUtils__FormatWith
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a54d55 == '\0') {
		    Mono_Security_ASN1__get_Item(&Newtonsoft_Json_IJsonLineInfo_TypeInfo);
		    DAT_ram_00a54d55 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x10c));
		  param1_00 = func_ii_1082(param1,Newtonsoft_Json_IJsonLineInfo_TypeInfo);
		  uVar1 = Newtonsoft_Json_JsonSerializationException___ctor(param1_00,uVar1,param2,param3,param1);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: FormatWith ---
		undefined4
		Newtonsoft_Json_Utilities_StringUtils__FormatWith
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a54d55 == '\0') {
		    Mono_Security_ASN1__get_Item(&Newtonsoft_Json_IJsonLineInfo_TypeInfo);
		    DAT_ram_00a54d55 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x10c));
		  param1_00 = func_ii_1082(param1,Newtonsoft_Json_IJsonLineInfo_TypeInfo);
		  uVar1 = Newtonsoft_Json_JsonSerializationException___ctor(param1_00,uVar1,param2,param3,param1);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: CreateStringWriter ---
		void Newtonsoft_Json_Utilities_StringUtils__CreateStringWriter
		               (char *param1,int param2,undefined4 param3)
		
		{
		  short sVar1;
		  uint uVar2;
		  
		  *(undefined ***)(param2 + 0x10) = &PTR_DAT_ram_01220121_ram_0075005c;
		  sVar1 = 0x57;
		  if (param1 < s___Scripting__UnityEngine__WaitFo_ram_00009ff1 + 0xf) {
		    sVar1 = 0x30;
		  }
		  *(short *)(param2 + 0x14) = (short)((uint)param1 >> 0xc) + sVar1;
		  sVar1 = 0x57;
		  if (((uint)param1 & 0xf) < 10) {
		    sVar1 = 0x30;
		  }
		  *(short *)(param2 + 0x1a) = sVar1 + (short)((uint)param1 & 0xf);
		  sVar1 = 0x57;
		  uVar2 = (uint)param1 >> 4 & 0xf;
		  if (uVar2 < 10) {
		    sVar1 = 0x30;
		  }
		  *(short *)(param2 + 0x18) = sVar1 + (short)uVar2;
		  sVar1 = 0x57;
		  uVar2 = (uint)param1 >> 8 & 0xf;
		  if (uVar2 < 10) {
		    sVar1 = 0x30;
		  }
		  *(short *)(param2 + 0x16) = sVar1 + (short)uVar2;
		  return;
		}
		*/


		/* --- GHIDRA: ToCharAsUnicode ---
		undefined4
		Newtonsoft_Json_Utilities_StringUtils__ToCharAsUnicode(undefined4 param1,undefined4 param2)
		
		{
		  ushort uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  ushort *puVar6;
		  int iVar7;
		  
		  iVar2 = func_ii_4769(param1,0);
		  if (iVar2 != 0) {
		    return param1;
		  }
		  uVar3 = func_ii_3010(param1,0,0);
		  if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a66974);
		  }
		  iVar2 = System_Char__IsWhiteSpaceLatin1(uVar3,0);
		  if (iVar2 == 0) {
		    return param1;
		  }
		  iVar2 = I2_Loc_StringObfucator__XoREncode(param1,0);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    uVar1 = *(ushort *)(iVar2 + 0x10);
		    if (DAT_ram_00a54ce5 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		      DAT_ram_00a54ce5 = '\x01';
		    }
		    if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		    }
		    uVar3 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		    if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a66974);
		    }
		    uVar3 = System_Char__ToUpperInvariant((uint)uVar1,uVar3,0);
		    *(short *)(iVar2 + 0x10) = (short)uVar3;
		    if (1 < *(int *)(iVar2 + 0xc)) {
		      uVar1 = *(ushort *)(iVar2 + 0x12);
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      iVar4 = System_Char__IsWhiteSpaceLatin1((uint)uVar1,0);
		      if (iVar4 != 0) {
		        if (2 < *(int *)(iVar2 + 0xc)) {
		          puVar6 = (ushort *)(iVar2 + 0x14);
		          uVar1 = *puVar6;
		          if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a66974);
		          }
		          iVar4 = 1;
		          iVar5 = System_Char__IsWhiteSpaceLatin1((uint)uVar1,0);
		          if (iVar5 == 0) {
		code_r0x80afc688:
		            uVar1 = *puVar6;
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            iVar5 = System_Char__IsSeparatorLatin1((uint)uVar1,0);
		            if (iVar5 != 0) {
		              puVar6 = (ushort *)(iVar2 + iVar4 * 2 + 0x10);
		              uVar1 = *puVar6;
		              if (DAT_ram_00a54ce5 == '\0') {
		                Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		                DAT_ram_00a54ce5 = '\x01';
		              }
		              if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		                func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		              }
		              uVar3 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		              if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                func_ii_306000(DAT_ram_00a66974);
		              }
		              uVar3 = System_Char__ToUpperInvariant((uint)uVar1,uVar3,0);
		              *puVar6 = (ushort)uVar3;
		            }
		            goto code_r0x80afc731;
		          }
		        }
		        uVar1 = *(ushort *)(iVar2 + 0x12);
		        if (DAT_ram_00a54ce5 == '\0') {
		          Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		          DAT_ram_00a54ce5 = '\x01';
		        }
		        if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		          func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		        }
		        uVar3 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		        if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		          func_ii_306000(DAT_ram_00a66974);
		        }
		        uVar3 = System_Char__ToUpperInvariant((uint)uVar1,uVar3,0);
		        *(short *)(iVar2 + 0x12) = (short)uVar3;
		        iVar5 = *(int *)(iVar2 + 0xc);
		        if (2 < iVar5) {
		          iVar4 = 2;
		          do {
		            iVar7 = iVar4 + 1;
		            if (iVar7 < iVar5) {
		              puVar6 = (ushort *)(iVar2 + iVar7 * 2 + 0x10);
		              uVar1 = *puVar6;
		              if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                func_ii_306000(DAT_ram_00a66974);
		              }
		              iVar5 = System_Char__IsWhiteSpaceLatin1((uint)uVar1,0);
		              if (iVar5 == 0) goto code_r0x80afc688;
		            }
		            puVar6 = (ushort *)(iVar2 + iVar4 * 2 + 0x10);
		            uVar1 = *puVar6;
		            if (DAT_ram_00a54ce5 == '\0') {
		              Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		              DAT_ram_00a54ce5 = '\x01';
		            }
		            if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		              func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		            }
		            uVar3 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            uVar3 = System_Char__ToUpperInvariant((uint)uVar1,uVar3,0);
		            *puVar6 = (ushort)uVar3;
		            iVar5 = *(int *)(iVar2 + 0xc);
		            iVar4 = iVar7;
		          } while (iVar7 < iVar5);
		        }
		      }
		    }
		  }
		code_r0x80afc731:
		  uVar3 = System_String__ToCharArray(0,iVar2,0);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: ForgivingCaseSensitiveFind<object> ---
		undefined4
		Newtonsoft_Json_Utilities_StringUtils__ForgivingCaseSensitiveFind_object_
		          (int param1,undefined4 param2,int param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int param1_01;
		  int iVar4;
		  
		  param1_00 = *(int **)(param1 + 8);
		  param1_01 = *(int *)(*(int *)(*(int *)(param3 + 0x10) + 0x60) + 0xc);
		  if ((*(byte *)(param1_01 + 0xbd) & 1) == 0) {
		    param1_01 = func_ii_1079(param1_01);
		  }
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (param1_01 == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x824eae84;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,param1_01,2);
		code_r0x824eae84:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: ForgivingCaseSensitiveFind<__Il2CppFullySharedGenericType> ---
		int Newtonsoft_Json_Utilities_StringUtils__ForgivingCaseSensitiveFind___Il2CppFullySharedGenericType_
		              (undefined4 param1,int *param2,int param3)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param3 + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		  }
		  iVar1 = *param2;
		  if (iVar1 == 0) {
		    iVar1 = System_Delegate__Combine(*(undefined4 *)(*(int *)(param3 + 0x1c) + 8));
		    *param2 = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: ToCamelCase ---
		undefined4 Newtonsoft_Json_Utilities_StringUtils__ToCamelCase(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a54ce5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    DAT_ram_00a54ce5 = '\x01';
		  }
		  if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		  }
		  uVar1 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		  if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a66974);
		  }
		  uVar1 = System_Char__ToUpperInvariant(param1,uVar1,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: ToLower ---
		undefined4 Newtonsoft_Json_Utilities_StringUtils__ToLower(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Newtonsoft_Json_Utilities_StringUtils__ToKebabCase(param1,0x5f,param1);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: ToSnakeCase ---
		undefined4 Newtonsoft_Json_Utilities_StringUtils__ToSnakeCase(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Newtonsoft_Json_Utilities_StringUtils__ToKebabCase(param1,0x2d,param1);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: ToKebabCase ---
		int Newtonsoft_Json_Utilities_StringUtils__ToKebabCase(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  int iVar4;
		  int param2_01;
		  
		  param2_01 = 0;
		  if (DAT_ram_00a54ce6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    DAT_ram_00a54ce6 = '\x01';
		  }
		  iVar1 = func_ii_4769(param1,0);
		  if (iVar1 == 0) {
		    iVar1 = 0;
		    param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		    func_ii_2101(param1_00,0);
		    if (0 < *(int *)(param1 + 8)) {
		      do {
		        iVar4 = 3;
		        if (iVar1 == 0) {
		          iVar4 = 0;
		        }
		        iVar2 = func_ii_3010(param1,param2_01,0);
		        if (iVar2 != 0x20) {
		          uVar3 = func_ii_3010(param1,param2_01,0);
		          if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a66974);
		          }
		          iVar4 = System_Char__IsWhiteSpaceLatin1(uVar3,0);
		          if (iVar4 == 0) {
		            iVar4 = func_ii_3010(param1,param2_01,0);
		            if (iVar4 == param2) {
		              func_ii_3135(param1_00,param2,0);
		              iVar4 = 0;
		            }
		            else {
		              if (iVar1 == 3) {
		                func_ii_3135(param1_00,param2,0);
		              }
		              uVar3 = func_ii_3010(param1,param2_01,0);
		              func_ii_3135(param1_00,uVar3,0);
		              iVar4 = 1;
		            }
		          }
		          else {
		            if (iVar1 == 1) {
		code_r0x80afc8ae:
		              func_ii_3135(param1_00,param2,0);
		            }
		            else if (iVar1 == 2) {
		              if ((param2_01 != 0) && (param2_01 + 1 < *(int *)(param1 + 8))) {
		                iVar1 = func_ii_3010(param1,param2_01 + 1,0);
		                if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                  func_ii_306000(DAT_ram_00a66974);
		                }
		                iVar4 = System_Char__IsWhiteSpaceLatin1(iVar1,0);
		                if ((iVar4 == 0) && (param2 != iVar1)) goto code_r0x80afc8ae;
		              }
		            }
		            else if (iVar1 == 3) goto code_r0x80afc8ae;
		            uVar3 = func_ii_3010(param1,param2_01,0);
		            if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		              func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		            }
		            param2_00 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            uVar3 = System_Char__ToUpperInvariant(uVar3,param2_00,0);
		            func_ii_3135(param1_00,uVar3,0);
		            iVar4 = 2;
		          }
		        }
		        iVar1 = iVar4;
		        param2_01 = param2_01 + 1;
		      } while (param2_01 < *(int *)(param1 + 8));
		    }
		    param1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                       (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  }
		  return param1;
		}
		*/


		/* --- GHIDRA: ToSeparatedCase ---
		undefined4
		Newtonsoft_Json_Utilities_StringUtils__ToSeparatedCase(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a66974);
		  }
		  uVar1 = System_Char__GetNumericValue(param1,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: IsHighSurrogate ---
		undefined4
		Newtonsoft_Json_Utilities_StringUtils__IsHighSurrogate(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a66974);
		  }
		  uVar1 = System_Char__IsHighSurrogate(param1,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: IsLowSurrogate ---
		undefined4
		Newtonsoft_Json_Utilities_StringUtils__IsLowSurrogate
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Xml_Schema_XmlSchemaException___ctor(param1,param2,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: IndexOf ---
		uint Newtonsoft_Json_Utilities_StringUtils__IndexOf(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (0 < *(int *)(param1 + 8)) {
		    iVar1 = func_ii_3010(param1,0,0);
		    return (uint)(iVar1 == param2);
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: StartsWith ---
		uint Newtonsoft_Json_Utilities_StringUtils__StartsWith(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (0 < *(int *)(param1 + 8)) {
		    iVar1 = func_ii_3010(param1,*(int *)(param1 + 8) + -1,0);
		    return (uint)(iVar1 == param2);
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: EndsWith ---
		undefined4
		Newtonsoft_Json_Utilities_StringUtils__EndsWith(int param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int param2_00;
		  
		  if (param1 == 0) {
		    uVar3 = unnamed_function_2232(&System_ArgumentNullException_TypeInfo);
		    uVar3 = unnamed_function_1417(uVar3);
		    System_ArgumentException__get_Message(uVar3,0);
		    uVar4 = unnamed_function_2232(&Method_Newtonsoft_Json_Utilities_StringUtils_Trim__);
		    func_ii_1050(uVar3,uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (param2 < 0) {
		    uVar3 = unnamed_function_2232(&System_ArgumentOutOfRangeException_TypeInfo);
		    uVar3 = unnamed_function_1417(uVar3);
		    uVar4 = unnamed_function_2232(&StringLiteral_27389);
		    func_ii_6353(uVar3,uVar4,0);
		    uVar4 = unnamed_function_2232(&Method_Newtonsoft_Json_Utilities_StringUtils_Trim__);
		    func_ii_1050(uVar3,uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (param3 < 0) {
		    uVar3 = unnamed_function_2232(&System_ArgumentOutOfRangeException_TypeInfo);
		    uVar3 = unnamed_function_1417(uVar3);
		    uVar4 = unnamed_function_2232(&StringLiteral_25085);
		    func_ii_6353(uVar3,uVar4,0);
		    uVar4 = unnamed_function_2232(&Method_Newtonsoft_Json_Utilities_StringUtils_Trim__);
		    func_ii_1050(uVar3,uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00 = param2 + param3 + -1;
		  if (*(int *)(param1 + 8) <= param2_00) {
		    uVar3 = unnamed_function_2232(&System_ArgumentOutOfRangeException_TypeInfo);
		    uVar3 = unnamed_function_1417(uVar3);
		    uVar4 = unnamed_function_2232(&StringLiteral_25085);
		    func_ii_6353(uVar3,uVar4,0);
		    uVar4 = unnamed_function_2232(&Method_Newtonsoft_Json_Utilities_StringUtils_Trim__);
		    func_ii_1050(uVar3,uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (param2 < param2_00) {
		    do {
		      uVar3 = func_ii_3010(param1,param2,0);
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      iVar1 = BestHTTP_PlatformSupport_Memory_BufferPool__Resize(uVar3,0);
		      if (iVar1 == 0) goto code_r0x80afb06e;
		      param2 = param2 + 1;
		      iVar1 = param2_00;
		    } while (param2 != param2_00);
		  }
		  else {
		code_r0x80afb06e:
		    iVar1 = param2;
		    if (param2_00 < param2) goto code_r0x80afb0b4;
		  }
		  do {
		    uVar3 = func_ii_3010(param1,param2_00,0);
		    if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a66974);
		    }
		    iVar2 = BestHTTP_PlatformSupport_Memory_BufferPool__Resize(uVar3,0);
		  } while ((iVar2 != 0) && (param2_00 = param2_00 + -1, iVar1 <= param2_00));
		code_r0x80afb0b4:
		  uVar3 = System_Data_DataSet__ReadXmlSchema(param1,iVar1,(param2_00 - iVar1) + 1,0);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: TryFormat ---
		void LunarConsolePluginInternal_StringUtils__TryFormat
		               (undefined8 *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  undefined4 *param2_00;
		  int *piVar5;
		  undefined4 param1_00;
		  undefined8 uVar6;
		  undefined1 auStack_10 [8];
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a60694 == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePlugin_CVarRangeAttribute_var);
		    Mono_Security_ASN1__get_Item(&LunarConsolePlugin_CVarRangeAttribute_TypeInfo);
		    Mono_Security_ASN1__get_Item(&LunarConsolePlugin_CVarValueRange_TypeInfo);
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_Log_TypeInfo);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9703);
		    DAT_ram_00a60694 = '\x01';
		  }
		  uVar1 = LunarConsolePlugin_CVarRangeAttribute_var;
		  local_4 = 0.0;
		  local_8 = 0.0;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,DAT_ram_00a669a0)
		    ;
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) goto code_r0x81cc8079;
		    uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cc8666:
		    iVar4 = global_1;
		    iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar4 != iVar2) goto code_r0x81cc87c6;
		    puVar3 = (undefined4 *)import::env::__cxa_begin_catch(uVar1);
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar1,
		                         *(undefined4 *)*puVar3);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 != 1) {
		        if (iVar2 != 0) {
		          param1_00 = *puVar3;
		          import::env::__cxa_end_catch();
		          uVar1 = unnamed_function_2232(&object___TypeInfo);
		          iVar4 = Mono_Security_ASN1Convert__ToOid(uVar1,1);
		          uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		                            (param2,*(undefined4 *)(*param2 + 0x104));
		          func_ii_4505(iVar4,uVar1);
		          *(undefined4 *)(iVar4 + 0x10) = uVar1;
		          iVar2 = unnamed_function_2232(&LunarConsolePluginInternal_Log_TypeInfo);
		          if (*(int *)(iVar2 + 0x74) == 0) {
		            func_ii_306000(iVar2);
		          }
		          uVar1 = unnamed_function_2232(&StringLiteral_7591);
		          LunarConsolePluginInternal_BaseList_object___Lock(param1_00,uVar1,iVar4,auStack_10);
		          goto code_r0x81cc87d8;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x81cc87d6:
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		code_r0x81cc87c6:
		    import::env::__resumeException(uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x81cc8079:
		  DAT_ram_009d3e38 = 0;
		  uVar1 = import::env::invoke_iii(s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x259,uVar1,0);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
		    uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x81cc8666;
		  }
		  DAT_ram_009d3e38 = 0;
		  iVar2 = import::env::invoke_iiiii
		                    (*(undefined4 *)(*param2 + 0x130),param2,uVar1,1,
		                     *(undefined4 *)(*param2 + 0x134));
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
		    uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x81cc8666;
		  }
		  if (((*(int *)(iVar2 + 0xc) != 0) && (piVar5 = *(int **)(iVar2 + 0x10), piVar5 != (int *)0x0)) &&
		     (*piVar5 == LunarConsolePlugin_CVarRangeAttribute_TypeInfo)) {
		    local_4 = (float4)piVar5[2];
		    local_8 = (float4)piVar5[3];
		    if (1e-05 <= (float)local_8 - (float)local_4) {
		code_r0x81cc8653:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = CONCAT44(local_8,local_4);
		      goto code_r0x81cc8800;
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1b1,
		                               object___TypeInfo,3);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cc8666;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x235,&local_4,0);
		    if (DAT_ram_009d3e38 != 1) {
		      if (iVar4 == 0) {
		code_r0x81cc826a:
		        piVar5[4] = iVar4;
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x235,&local_8,0);
		        if (DAT_ram_009d3e38 != 1) {
		          if (iVar4 == 0) {
		code_r0x81cc8350:
		            piVar5[5] = iVar4;
		            DAT_ram_009d3e38 = 0;
		            iVar4 = import::env::invoke_iii
		                              (*(undefined4 *)(*param2 + 0x100),param2,
		                               *(undefined4 *)(*param2 + 0x104));
		            if (DAT_ram_009d3e38 != 1) {
		              if (iVar4 == 0) {
		code_r0x81cc843d:
		                piVar5[6] = iVar4;
		                if (*(int *)(LunarConsolePluginInternal_Log_TypeInfo + 0x74) == 0) {
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_vi
		                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                             LunarConsolePluginInternal_Log_TypeInfo);
		                  if (DAT_ram_009d3e38 == 1) goto code_r0x81cc865e;
		                }
		                uVar1 = StringLiteral_9703;
		                if (DAT_ram_00a606f7 == '\0') {
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_vi(0x7ff,&LunarConsolePluginInternal_Log_TypeInfo);
		                  if (DAT_ram_009d3e38 != 1) {
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_vi(0x7ff,&LunarConsolePluginInternal_StringUtils_TypeInfo);
		                    if (DAT_ram_009d3e38 != 1) {
		                      DAT_ram_00a606f7 = '\x01';
		                      goto code_r0x81cc84ff;
		                    }
		                  }
		                }
		                else {
		code_r0x81cc84ff:
		                  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_vi
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                               LunarConsolePluginInternal_StringUtils_TypeInfo);
		                    if (DAT_ram_009d3e38 == 1) goto code_r0x81cc865e;
		                  }
		                  DAT_ram_009d3e38 = 0;
		                  uVar1 = import::env::invoke_iiii
		                                    (s___Scripting__UnityEngine__Render_ram_00003671 + 0x2a,uVar1,
		                                     piVar5,auStack_10);
		                  if (DAT_ram_009d3e38 != 1) {
		                    if (*(int *)(LunarConsolePluginInternal_Log_TypeInfo + 0x74) == 0) {
		                      DAT_ram_009d3e38 = 0;
		                      import::env::invoke_vi
		                                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                                 LunarConsolePluginInternal_Log_TypeInfo);
		                      if (DAT_ram_009d3e38 == 1) goto code_r0x81cc865e;
		                    }
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_vii
		                              (s___Scripting__UnityEngine__Render_ram_00003671 + 0x31,uVar1,
		                               auStack_10);
		                    if (DAT_ram_009d3e38 != 1) {
		                      if (*(int *)(LunarConsolePlugin_CVarValueRange_TypeInfo + 0x74) == 0) {
		                        DAT_ram_009d3e38 = 0;
		                        import::env::invoke_vi
		                                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                                   LunarConsolePlugin_CVarValueRange_TypeInfo);
		                        if (DAT_ram_009d3e38 == 1) goto code_r0x81cc865e;
		                      }
		                      local_8 = (float4)((ulonglong)
		                                         **(undefined8 **)
		                                           (LunarConsolePlugin_CVarValueRange_TypeInfo + 0x5c) >>
		                                        0x20);
		                      local_4 = (float4)**(undefined8 **)
		                                          (LunarConsolePlugin_CVarValueRange_TypeInfo + 0x5c);
		                      goto code_r0x81cc8653;
		                    }
		                  }
		                }
		              }
		              else {
		                DAT_ram_009d3e38 = 0;
		                iVar2 = import::env::invoke_iii
		                                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar4,
		                                   *(undefined4 *)(*piVar5 + 0x20));
		                if (DAT_ram_009d3e38 != 1) {
		                  if (iVar2 != 0) goto code_r0x81cc843d;
		                  DAT_ram_009d3e38 = 0;
		                  uVar1 = import::env::invoke_i
		                                    (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1b);
		                  if (DAT_ram_009d3e38 != 1) {
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_vii(0x41b,uVar1,0);
		                    if (DAT_ram_009d3e38 != 1) goto code_r0x81cc87d6;
		                  }
		                }
		              }
		            }
		code_r0x81cc865e:
		            DAT_ram_009d3e38 = 0;
		            uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81cc8666;
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar2 = import::env::invoke_iii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar4,
		                             *(undefined4 *)(*piVar5 + 0x20));
		          if (DAT_ram_009d3e38 != 1) {
		            if (iVar2 != 0) goto code_r0x81cc8350;
		            DAT_ram_009d3e38 = 0;
		            uVar1 = import::env::invoke_i(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1b);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vii(0x41b,uVar1,0);
		              if (DAT_ram_009d3e38 != 1) goto code_r0x81cc87d6;
		            }
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81cc8666;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar4,
		                         *(undefined4 *)(*piVar5 + 0x20));
		      if (DAT_ram_009d3e38 != 1) {
		        if (iVar2 != 0) goto code_r0x81cc826a;
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::invoke_i(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1b);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii(0x41b,uVar1,0);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x81cc87d6;
		        }
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x81cc8666;
		  }
		code_r0x81cc87d8:
		  if (*(int *)(LunarConsolePlugin_CVarValueRange_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePlugin_CVarValueRange_TypeInfo);
		  }
		  uVar6 = **(undefined8 **)(LunarConsolePlugin_CVarValueRange_TypeInfo + 0x5c);
		code_r0x81cc8800:
		  *param1 = uVar6;
		  return;
		}
		*/


		/* --- GHIDRA: StartsWithIgnoreCase ---
		undefined4
		LunarConsolePluginInternal_StringUtils__StartsWithIgnoreCase
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Newtonsoft_Json_JsonSerializationException__Create(param1,param2,5,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: EqualsIgnoreCase ---
		int * LunarConsolePluginInternal_StringUtils__EqualsIgnoreCase
		                (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *param1_00;
		  uint *puVar3;
		  undefined4 *puVar4;
		  undefined4 param1_01;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  int *piVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a60707 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a60707 = '\x01';
		  }
		  iVar2 = func_ii_4769(param2,0);
		  if (iVar2 != 0) {
		    return param1;
		  }
		  param1_00 = (int *)unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_string___ctor__);
		  iVar2 = *param1;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_string__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81cd3e16;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1,System_Collections_Generic_IEnumerable_string__TypeInfo,0);
		code_r0x81cd3e16:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param1,puVar3[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    do {
		      do {
		        piVar7 = local_4;
		        iVar2 = *local_4;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		              puVar4 = (undefined4 *)(iVar2 + piVar8[1] * 8 + 0xc0);
		              goto code_r0x81cd3edd;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81cd3f25:
		          DAT_ram_009d3e38 = 0;
		          param1_01 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81cd4189;
		        }
		code_r0x81cd3edd:
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		        piVar7 = local_4;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81cd3f25;
		        if (iVar2 == 0) {
		          iVar2 = 0;
		          goto code_r0x81cd41d2;
		        }
		        iVar2 = *local_4;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_string__TypeInfo == *piVar8) {
		              puVar4 = (undefined4 *)(iVar2 + piVar8[1] * 8 + 0xc0);
		              goto code_r0x81cd3fd0;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_Generic_IEnumerator_string__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81cd408f:
		          DAT_ram_009d3e38 = 0;
		          param1_01 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81cd4189;
		        }
		code_r0x81cd3fd0:
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81cd408f;
		        if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     LunarConsolePluginInternal_StringUtils_TypeInfo);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            param1_01 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81cd4189;
		          }
		        }
		      } while ((param2 == 0) || (iVar2 == 0));
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iiiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0xc6,iVar2,param2,5,0);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        param1_01 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81cd4189;
		      }
		    } while (iVar5 == 0);
		    iVar6 = *param1_00;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_ICollection_string__TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 0xd0);
		          goto code_r0x81cd4143;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,param1_00,
		                        System_Collections_Generic_ICollection_string__TypeInfo,2);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x81cd4143:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar4,param1_00,iVar2,puVar4[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  param1_01 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cd4189:
		  iVar2 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(param1_01);
		    iVar2 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar2;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x81cd41d2:
		      piVar7 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar6 = *local_4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81cd424a;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81cd424a:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		      }
		      if (iVar2 == 0) {
		        return param1_00;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_01 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Render_ram_000036af + 0x1f,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_01);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: Filter ---
		undefined4 LunarConsolePluginInternal_StringUtils__Filter(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a60708 == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a60708 = '\x01';
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  uVar1 = 0;
		  local_4 = 0;
		  iVar2 = func_ii_4769(param1,0);
		  if ((iVar2 == 0) &&
		     (iVar2 = System_Net_WebHeaderCollection__Add(param1,&local_4,0), uVar1 = local_4, iVar2 == 0))
		  {
		    uVar1 = 0;
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: ParseInt ---
		undefined4
		LunarConsolePluginInternal_StringUtils__ParseInt
		          (undefined4 param1,undefined1 *param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_4;
		  
		  iVar2 = 0;
		  uVar3 = 0;
		  local_4 = 0;
		  iVar1 = func_ii_4769(param1,0);
		  if ((iVar1 == 0) &&
		     (iVar2 = System_Net_WebHeaderCollection__Add(param1,&local_4,0), uVar3 = local_4, iVar2 == 0))
		  {
		    uVar3 = 0;
		  }
		  *param2 = (char)iVar2;
		  return uVar3;
		}
		*/


		/* --- GHIDRA: ParseInt ---
		undefined4
		LunarConsolePluginInternal_StringUtils__ParseInt
		          (undefined4 param1,undefined1 *param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_4;
		  
		  iVar2 = 0;
		  uVar3 = 0;
		  local_4 = 0;
		  iVar1 = func_ii_4769(param1,0);
		  if ((iVar1 == 0) &&
		     (iVar2 = System_Net_WebHeaderCollection__Add(param1,&local_4,0), uVar3 = local_4, iVar2 == 0))
		  {
		    uVar3 = 0;
		  }
		  *param2 = (char)iVar2;
		  return uVar3;
		}
		*/


		/* --- GHIDRA: ParseInt ---
		undefined4
		LunarConsolePluginInternal_StringUtils__ParseInt
		          (undefined4 param1,undefined1 *param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_4;
		  
		  iVar2 = 0;
		  uVar3 = 0;
		  local_4 = 0;
		  iVar1 = func_ii_4769(param1,0);
		  if ((iVar1 == 0) &&
		     (iVar2 = System_Net_WebHeaderCollection__Add(param1,&local_4,0), uVar3 = local_4, iVar2 == 0))
		  {
		    uVar3 = 0;
		  }
		  *param2 = (char)iVar2;
		  return uVar3;
		}
		*/


		/* --- GHIDRA: ParseFloat ---
		uint LunarConsolePluginInternal_StringUtils__ParseFloat(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  byte local_1;
		  
		  if (DAT_ram_00a6070b == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a6070b = '\x01';
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  local_1 = 0;
		  iVar1 = func_ii_4769(param1,0);
		  if (iVar1 == 0) {
		    if (*(int *)(DAT_ram_00a66944 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a66944);
		    }
		    iVar1 = Unity_Services_LevelPlay_LevelPlayAdInfo__GetAdSize(param1,&local_1,0);
		    if (iVar1 == 0) {
		      uVar2 = 0;
		    }
		    else {
		      uVar2 = (uint)(local_1 != 0);
		    }
		  }
		  else {
		    uVar2 = 0;
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: ParseFloat ---
		uint LunarConsolePluginInternal_StringUtils__ParseFloat(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  byte local_1;
		  
		  if (DAT_ram_00a6070b == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a6070b = '\x01';
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  local_1 = 0;
		  iVar1 = func_ii_4769(param1,0);
		  if (iVar1 == 0) {
		    if (*(int *)(DAT_ram_00a66944 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a66944);
		    }
		    iVar1 = Unity_Services_LevelPlay_LevelPlayAdInfo__GetAdSize(param1,&local_1,0);
		    if (iVar1 == 0) {
		      uVar2 = 0;
		    }
		    else {
		      uVar2 = (uint)(local_1 != 0);
		    }
		  }
		  else {
		    uVar2 = 0;
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: ParseBool ---
		int LunarConsolePluginInternal_StringUtils__ParseBool(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a6070c == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a6070c = '\x01';
		  }
		  if (param1 != 0) {
		    if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		    }
		    iVar3 = System_String__ReplaceHelper
		                      (param1,**(undefined4 **)
		                                (LunarConsolePluginInternal_StringUtils_TypeInfo + 0x5c),1,0);
		    if (DAT_ram_00a6070d == '\0') {
		      Mono_Security_ASN1__get_Item(&float___TypeInfo);
		      DAT_ram_00a6070d = '\x01';
		    }
		    if (iVar3 == 0) {
		      return 0;
		    }
		    iVar1 = 0;
		    iVar2 = Mono_Security_ASN1Convert__ToOid(float___TypeInfo,*(undefined4 *)(iVar3 + 0xc));
		    if (0 < *(int *)(iVar3 + 0xc)) {
		      do {
		        iVar4 = System_Text_RegularExpressions_Capture__get_Value
		                          (*(undefined4 *)(iVar3 + iVar1 * 4 + 0x10),iVar2 + 0x10 + iVar1 * 4,0);
		        if (iVar4 == 0) {
		          return 0;
		        }
		        iVar1 = iVar1 + 1;
		      } while (iVar1 < *(int *)(iVar3 + 0xc));
		    }
		  }
		  return iVar2;
		}
		*/


		/* --- GHIDRA: ParseBool ---
		int LunarConsolePluginInternal_StringUtils__ParseBool(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a6070c == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a6070c = '\x01';
		  }
		  if (param1 != 0) {
		    if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		    }
		    iVar3 = System_String__ReplaceHelper
		                      (param1,**(undefined4 **)
		                                (LunarConsolePluginInternal_StringUtils_TypeInfo + 0x5c),1,0);
		    if (DAT_ram_00a6070d == '\0') {
		      Mono_Security_ASN1__get_Item(&float___TypeInfo);
		      DAT_ram_00a6070d = '\x01';
		    }
		    if (iVar3 == 0) {
		      return 0;
		    }
		    iVar1 = 0;
		    iVar2 = Mono_Security_ASN1Convert__ToOid(float___TypeInfo,*(undefined4 *)(iVar3 + 0xc));
		    if (0 < *(int *)(iVar3 + 0xc)) {
		      do {
		        iVar4 = System_Text_RegularExpressions_Capture__get_Value
		                          (*(undefined4 *)(iVar3 + iVar1 * 4 + 0x10),iVar2 + 0x10 + iVar1 * 4,0);
		        if (iVar4 == 0) {
		          return 0;
		        }
		        iVar1 = iVar1 + 1;
		      } while (iVar1 < *(int *)(iVar3 + 0xc));
		    }
		  }
		  return iVar2;
		}
		*/


		/* --- GHIDRA: ParseBool ---
		int LunarConsolePluginInternal_StringUtils__ParseBool(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a6070c == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a6070c = '\x01';
		  }
		  if (param1 != 0) {
		    if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		    }
		    iVar3 = System_String__ReplaceHelper
		                      (param1,**(undefined4 **)
		                                (LunarConsolePluginInternal_StringUtils_TypeInfo + 0x5c),1,0);
		    if (DAT_ram_00a6070d == '\0') {
		      Mono_Security_ASN1__get_Item(&float___TypeInfo);
		      DAT_ram_00a6070d = '\x01';
		    }
		    if (iVar3 == 0) {
		      return 0;
		    }
		    iVar1 = 0;
		    iVar2 = Mono_Security_ASN1Convert__ToOid(float___TypeInfo,*(undefined4 *)(iVar3 + 0xc));
		    if (0 < *(int *)(iVar3 + 0xc)) {
		      do {
		        iVar4 = System_Text_RegularExpressions_Capture__get_Value
		                          (*(undefined4 *)(iVar3 + iVar1 * 4 + 0x10),iVar2 + 0x10 + iVar1 * 4,0);
		        if (iVar4 == 0) {
		          return 0;
		        }
		        iVar1 = iVar1 + 1;
		      } while (iVar1 < *(int *)(iVar3 + 0xc));
		    }
		  }
		  return iVar2;
		}
		*/


		/* --- GHIDRA: ParseFloats ---
		undefined4 LunarConsolePluginInternal_StringUtils__ParseFloats(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined8 local_8;
		  
		  local_8 = 0;
		  uVar1 = System_Double__Parse(param1,&local_8,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: ParseFloats ---
		undefined4 LunarConsolePluginInternal_StringUtils__ParseFloats(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined8 local_8;
		  
		  local_8 = 0;
		  uVar1 = System_Double__Parse(param1,&local_8,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: IsNumeric ---
		undefined4 LunarConsolePluginInternal_StringUtils__IsNumeric(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 local_4;
		  
		  local_4 = 0;
		  uVar1 = System_Net_WebHeaderCollection__Add(param1,&local_4,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: IsInteger ---
		int LunarConsolePluginInternal_StringUtils__IsInteger
		              (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a6070e == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a6070e = '\x01';
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  iVar1 = LunarConsolePluginInternal_StringUtils__StartOfTheWordOffset(param1,param2,param2);
		  return iVar1 - param2;
		}
		*/


		/* --- GHIDRA: StartOfTheWordOffset ---
		int LunarConsolePluginInternal_StringUtils__StartOfTheWordOffset
		              (undefined4 param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a6070f == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a6070f = '\x01';
		  }
		  do {
		    param2 = param2 + -1;
		    iVar3 = param2;
		    if (param2 < 0) goto code_r0x81cd4868;
		    uVar2 = func_ii_3010(param1,param2,0);
		    if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		    }
		    if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a66974);
		    }
		    iVar3 = System_Char__CheckLetter(uVar2,0);
		    if (iVar3 != 0) break;
		    if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a66974);
		    }
		    iVar3 = System_Char__TryParse(uVar2,0);
		  } while (iVar3 == 0);
		  do {
		    uVar2 = func_ii_3010(param1,param2,0);
		    if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		    }
		    if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a66974);
		    }
		    iVar3 = System_Char__CheckLetter(uVar2,0);
		    if (iVar3 == 0) {
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      iVar4 = System_Char__TryParse(uVar2,0);
		      iVar3 = param2;
		      if (iVar4 == 0) break;
		    }
		    bVar1 = 0 < param2;
		    param2 = param2 + -1;
		    iVar3 = -1;
		  } while (bVar1);
		code_r0x81cd4868:
		  return iVar3 + 1;
		}
		*/


		/* --- GHIDRA: StartOfTheWord ---
		int LunarConsolePluginInternal_StringUtils__StartOfTheWord
		              (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a60710 == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a60710 = '\x01';
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  iVar1 = LunarConsolePluginInternal_StringUtils__EndOfTheWordOffset(param1,param2,param2);
		  return iVar1 - param2;
		}
		*/


		/* --- GHIDRA: EndOfTheWordOffset ---
		int LunarConsolePluginInternal_StringUtils__EndOfTheWordOffset
		              (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a60711 == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a60711 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 8);
		  if (param2 < iVar2) {
		    while( true ) {
		      uVar1 = func_ii_3010(param1,param2,0);
		      if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		      }
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      iVar2 = System_Char__CheckLetter(uVar1,0);
		      if (iVar2 != 0) break;
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      iVar2 = System_Char__TryParse(uVar1,0);
		      if ((iVar2 != 0) || (param2 = param2 + 1, *(int *)(param1 + 8) <= param2)) break;
		    }
		    iVar2 = *(int *)(param1 + 8);
		  }
		  if (param2 < iVar2) {
		    do {
		      uVar1 = func_ii_3010(param1,param2,0);
		      if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		      }
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      iVar2 = System_Char__CheckLetter(uVar1,0);
		      if (iVar2 == 0) {
		        if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		          func_ii_306000(DAT_ram_00a66974);
		        }
		        iVar2 = System_Char__TryParse(uVar1,0);
		        if (iVar2 == 0) {
		          return param2;
		        }
		      }
		      param2 = param2 + 1;
		    } while (param2 < *(int *)(param1 + 8));
		  }
		  return param2;
		}
		*/


		/* --- GHIDRA: EndOfTheWord ---
		uint LunarConsolePluginInternal_StringUtils__EndOfTheWord(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a66974);
		  }
		  iVar1 = System_Char__CheckLetter(param1,0);
		  if (iVar1 == 0) {
		    if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a66974);
		    }
		    uVar2 = System_Char__TryParse(param1,0);
		    uVar2 = uVar2 ^ 1;
		  }
		  else {
		    uVar2 = 0;
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: IsSeparator ---
		int LunarConsolePluginInternal_StringUtils__IsSeparator(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a60712 == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a60712 = '\x01';
		  }
		  if ((0 < param2) && (param2 <= *(int *)(param1 + 8))) {
		    if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		    }
		    iVar1 = LunarConsolePluginInternal_StringUtils__OffsetInLine(param1,param2,param2);
		    if (iVar1 != -1) {
		      if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		      }
		      if (DAT_ram_00a60716 == '\0') {
		        Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		        DAT_ram_00a60716 = '\x01';
		      }
		      if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		      }
		      uVar2 = System_String__IndexOf(param1,10,param2 + -1,0);
		      if (DAT_ram_00a60718 == '\0') {
		        Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		        DAT_ram_00a60718 = '\x01';
		      }
		      if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		      }
		      iVar3 = param2 + iVar1 + (uVar2 ^ 0xffffffff);
		      iVar1 = System_String__IndexOf(param1,10,param2 + -1,0);
		      param2 = iVar3;
		      if (iVar1 <= iVar3) {
		        param2 = iVar1;
		      }
		    }
		  }
		  return param2;
		}
		*/


		/* --- GHIDRA: MoveLineUp ---
		int LunarConsolePluginInternal_StringUtils__MoveLineUp(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a60713 == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a60713 = '\x01';
		  }
		  if ((-1 < param2) && (param2 < *(int *)(param1 + 8))) {
		    if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		    }
		    if (DAT_ram_00a60719 == '\0') {
		      Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		      DAT_ram_00a60719 = '\x01';
		    }
		    if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		    }
		    if (param2 < *(int *)(param1 + 8)) {
		      iVar1 = System_String__Contains(param1,10,param2,0);
		      iVar2 = *(int *)(param1 + 8);
		      if (iVar1 != -1) {
		        iVar2 = iVar1;
		      }
		      if ((iVar2 < *(int *)(param1 + 8)) && (iVar2 + 1 != -1)) {
		        if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		          func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		        }
		        if (DAT_ram_00a60716 == '\0') {
		          Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		          DAT_ram_00a60716 = '\x01';
		        }
		        if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		          func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		        }
		        if (param2 == 0) {
		          uVar3 = 0;
		        }
		        else {
		          uVar3 = System_String__IndexOf(param1,10,param2 + -1,0);
		          uVar3 = uVar3 ^ 0xffffffff;
		        }
		        iVar1 = uVar3 + param2 + iVar2 + 1;
		        iVar2 = LunarConsolePluginInternal_StringUtils__StartOfNextLineIndex(param1,param2,param2);
		        param2 = iVar1;
		        if (iVar2 <= iVar1) {
		          param2 = iVar2;
		        }
		      }
		    }
		  }
		  return param2;
		}
		*/


		/* --- GHIDRA: MoveLineDown ---
		int LunarConsolePluginInternal_StringUtils__MoveLineDown
		              (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a60714 == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a60714 = '\x01';
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  if (param2 < 1) {
		    return -param2;
		  }
		  iVar1 = System_String__IndexOf(param1,10,param2 + -1,0);
		  return (iVar1 + 1) - param2;
		}
		*/


		/* --- GHIDRA: StartOfLineOffset ---
		int LunarConsolePluginInternal_StringUtils__StartOfLineOffset
		              (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (0 < param2) {
		    iVar1 = System_String__IndexOf(param1,10,param2 + -1,0);
		    return iVar1 + 1;
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: StartOfLineIndex ---
		int LunarConsolePluginInternal_StringUtils__StartOfLineIndex
		              (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a60715 == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a60715 = '\x01';
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  iVar1 = *(int *)(param1 + 8);
		  if ((param2 < iVar1) && (iVar1 = System_String__Contains(param1,10,param2,0), iVar1 == -1)) {
		    iVar1 = *(int *)(param1 + 8);
		  }
		  return iVar1 - param2;
		}
		*/


		/* --- GHIDRA: EndOfLineOffset ---
		int LunarConsolePluginInternal_StringUtils__EndOfLineOffset(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 8);
		  if ((param2 < iVar1) && (iVar1 = System_String__Contains(param1,10,param2,0), iVar1 == -1)) {
		    iVar1 = *(int *)(param1 + 8);
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: EndOfLineIndex ---
		int LunarConsolePluginInternal_StringUtils__EndOfLineIndex
		              (undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  
		  if (DAT_ram_00a60716 == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a60716 = '\x01';
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  if (param2 < 1) {
		    return param2;
		  }
		  uVar1 = System_String__IndexOf(param1,10,param2 + -1,0);
		  return (uVar1 ^ 0xffffffff) + param2;
		}
		*/


		/* --- GHIDRA: OffsetInLine ---
		int LunarConsolePluginInternal_StringUtils__OffsetInLine
		              (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a60717 == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a60717 = '\x01';
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  if (DAT_ram_00a60718 == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a60718 = '\x01';
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  iVar1 = -1;
		  if ((0 < param2) && (iVar2 = System_String__IndexOf(param1,10,param2 + -1,0), iVar2 != -1)) {
		    if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		    }
		    if (iVar2 < 1) {
		      return 0;
		    }
		    iVar1 = System_String__IndexOf(param1,10,iVar2 + -1,0);
		    iVar1 = iVar1 + 1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: StartOfPrevLineIndex ---
		undefined4
		LunarConsolePluginInternal_StringUtils__StartOfPrevLineIndex
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60718 == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a60718 = '\x01';
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  if (param2 < 1) {
		    return 0xffffffff;
		  }
		  uVar1 = System_String__IndexOf(param1,10,param2 + -1,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: EndOfPrevLineIndex ---
		int LunarConsolePluginInternal_StringUtils__EndOfPrevLineIndex
		              (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a60719 == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a60719 = '\x01';
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  iVar2 = *(int *)(param1 + 8);
		  iVar3 = iVar2;
		  if (param2 < iVar2) {
		    iVar1 = System_String__Contains(param1,10,param2,0);
		    iVar3 = *(int *)(param1 + 8);
		    iVar2 = iVar3;
		    if (iVar1 != -1) {
		      iVar2 = iVar1;
		    }
		  }
		  iVar1 = -1;
		  if (iVar2 < iVar3) {
		    iVar1 = iVar2 + 1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: StartOfNextLineIndex ---
		int LunarConsolePluginInternal_StringUtils__StartOfNextLineIndex
		              (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a6071a == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a6071a = '\x01';
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  if (DAT_ram_00a60719 == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a60719 = '\x01';
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  iVar1 = -1;
		  if (param2 < *(int *)(param1 + 8)) {
		    iVar2 = System_String__Contains(param1,10,param2,0);
		    iVar3 = *(int *)(param1 + 8);
		    iVar4 = iVar3;
		    if (iVar2 != -1) {
		      iVar4 = iVar2;
		    }
		    if ((iVar4 < iVar3) && (iVar4 = iVar4 + 1, iVar4 != -1)) {
		      iVar1 = iVar3;
		      if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		        iVar1 = *(int *)(param1 + 8);
		      }
		      if ((iVar4 < iVar1) && (iVar1 = System_String__Contains(param1,10,iVar4,0), iVar1 == -1)) {
		        iVar1 = *(int *)(param1 + 8);
		      }
		    }
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: EndOfNextLineIndex ---
		int LunarConsolePluginInternal_StringUtils__EndOfNextLineIndex(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (param1 == 0) {
		    return 0;
		  }
		  iVar1 = 0;
		  if (0 < *(int *)(param1 + 8)) {
		    do {
		      iVar2 = func_ii_3010(param1,param2_00,0);
		      iVar1 = iVar1 + (uint)(iVar2 == 10);
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param1 + 8));
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: LinesBreaksCount ---
		undefined4 LunarConsolePluginInternal_StringUtils__LinesBreaksCount(int param1,undefined4 param2)
		
		{
		  if (param1 != 0) {
		    return *(undefined4 *)(param1 + 8);
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: Strlen ---
		undefined4
		LunarConsolePluginInternal_StringUtils__Strlen
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6071b == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a6071b = '\x01';
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  uVar1 = LunarConsolePluginInternal_StringUtils__GetSuggestedText(param1,param2,0,param2);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GetSuggestedText ---
		undefined4
		LunarConsolePluginInternal_StringUtils__GetSuggestedText
		          (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6071c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_IList_TypeInfo);
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a6071c = '\x01';
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  uVar1 = System_Collections_IList_TypeInfo;
		  param2_00 = 0;
		  if ((param2 != 0) &&
		     (param2_00 = func_ii_1082(param2,System_Collections_IList_TypeInfo), param2_00 == 0)) {
		    System_Activator__CreateInstance(param2,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = LunarConsolePluginInternal_StringUtils__GetSuggestedText(param1,param2_00,0,param2);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GetSuggestedText ---
		undefined4
		LunarConsolePluginInternal_StringUtils__GetSuggestedText
		          (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6071c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_IList_TypeInfo);
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a6071c = '\x01';
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  uVar1 = System_Collections_IList_TypeInfo;
		  param2_00 = 0;
		  if ((param2 != 0) &&
		     (param2_00 = func_ii_1082(param2,System_Collections_IList_TypeInfo), param2_00 == 0)) {
		    System_Activator__CreateInstance(param2,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = LunarConsolePluginInternal_StringUtils__GetSuggestedText(param1,param2_00,0,param2);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GetSuggestedText0 ---
		undefined4
		LunarConsolePluginInternal_StringUtils__GetSuggestedText0
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6071e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_IList_TypeInfo);
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a6071e = '\x01';
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  uVar1 = System_Collections_IList_TypeInfo;
		  param2_00 = 0;
		  if ((param2 != 0) &&
		     (param2_00 = func_ii_1082(param2,System_Collections_IList_TypeInfo), param2_00 == 0)) {
		    System_Activator__CreateInstance(param2,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = LunarConsolePluginInternal_StringUtils__GetSuggestedTextFiltered(param1,param2_00,param2);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GetSuggestedTextFiltered ---
		undefined4
		LunarConsolePluginInternal_StringUtils__GetSuggestedTextFiltered
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6071f == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a6071f = '\x01';
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  uVar1 = LunarConsolePluginInternal_StringUtils__GetSuggestedTextFiltered(param1,param2,param2);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GetSuggestedTextFiltered ---
		undefined4
		LunarConsolePluginInternal_StringUtils__GetSuggestedTextFiltered
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6071f == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    DAT_ram_00a6071f = '\x01';
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  uVar1 = LunarConsolePluginInternal_StringUtils__GetSuggestedTextFiltered(param1,param2,param2);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GetSuggestedTextFiltered0 ---
		int LunarConsolePluginInternal_StringUtils__GetSuggestedTextFiltered0(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int *param2_00;
		  
		  if (DAT_ram_00a60721 == '\0') {
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_589);
		    Mono_Security_ASN1__get_Item(&StringLiteral_555);
		    DAT_ram_00a60721 = '\x01';
		  }
		  iVar2 = StringLiteral_555;
		  if ((param1 != 0) && (0 < *(int *)(param1 + 8))) {
		    if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		    }
		    uVar1 = func_ii_7088(param1,*(undefined4 *)
		                                 (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x5c) +
		                                 8),
		                         *(undefined4 *)
		                          (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x5c) + 0x10),
		                         0);
		    iVar2 = func_ii_7088(uVar1,*(undefined4 *)
		                                (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x5c) +
		                                0xc),
		                         *(undefined4 *)
		                          (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x5c) + 0x14),
		                         0);
		    iVar3 = System_Xml_Schema_XmlSchemaException___ctor(iVar2,0x20,0);
		    if (iVar3 != -1) {
		      param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,1);
		      if ((iVar2 != 0) &&
		         (iVar3 = func_ii_1082(iVar2,*(undefined4 *)(*param2_00 + 0x20)), iVar3 == 0)) {
		        uVar1 = func_ii_1083();
		        func_ii_1050(uVar1,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      param2_00[4] = iVar2;
		      iVar2 = LunarConsolePluginInternal_StringUtils_TypeInfo;
		      if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		      }
		      uVar1 = func_ii_13978(StringLiteral_589,param2_00,iVar2);
		      return uVar1;
		    }
		  }
		  return iVar2;
		}
		*/


		/* --- GHIDRA: Arg ---
		undefined4 LunarConsolePluginInternal_StringUtils__Arg(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a60722 == '\0') {
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a60722 = '\x01';
		  }
		  if ((param1 == 0) || (*(int *)(param1 + 8) < 1)) {
		    return StringLiteral_5;
		  }
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  iVar1 = System_String__ToLower
		                    (param1,*(undefined4 *)
		                             (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x5c) + 8),
		                     0);
		  if (iVar1 == 0) {
		code_r0x81cd30b9:
		    if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		    }
		    iVar1 = System_String__ToLower
		                      (param1,*(undefined4 *)
		                               (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x5c) +
		                               0xc),0);
		    if (iVar1 == 0) goto code_r0x81cd3133;
		    if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		    }
		    iVar1 = System_String__CompareTo
		                      (param1,*(undefined4 *)
		                               (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x5c) +
		                               0xc),0);
		    if (iVar1 == 0) goto code_r0x81cd3133;
		  }
		  else {
		    if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		    }
		    iVar1 = System_String__CompareTo
		                      (param1,*(undefined4 *)
		                               (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x5c) + 8
		                               ),0);
		    if (iVar1 == 0) goto code_r0x81cd30b9;
		  }
		  param1 = System_Data_DataSet__ReadXmlSchema(param1,1,*(int *)(param1 + 8) + -2,0);
		code_r0x81cd3133:
		  if (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(LunarConsolePluginInternal_StringUtils_TypeInfo);
		  }
		  uVar2 = func_ii_7088(param1,*(undefined4 *)
		                               (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x5c) +
		                               0x10),
		                       *(undefined4 *)
		                        (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x5c) + 8),0);
		  uVar2 = func_ii_7088(uVar2,*(undefined4 *)
		                              (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x5c) +
		                              0x14),
		                       *(undefined4 *)
		                        (*(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x5c) + 0xc),0);
		  return uVar2;
		}
		*/


		/* --- GHIDRA: UnArg ---
		int LunarConsolePluginInternal_StringUtils__UnArg(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60723 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a60723 = '\x01';
		  }
		  if (param1 == 0) {
		    param1 = StringLiteral_5;
		  }
		  return param1;
		}
		*/


		/* --- GHIDRA: NonNullOrEmpty ---
		undefined4 LunarConsolePluginInternal_StringUtils__NonNullOrEmpty(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (param1 != (int *)0x0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xd8) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xdc));
		    return uVar1;
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: ToString ---
		int LunarConsolePluginInternal_StringUtils__ToString(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param1_01;
		  uint param2_00;
		  uint param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a6072a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    DAT_ram_00a6072a = '\x01';
		  }
		  iVar1 = func_ii_4769(param1,0);
		  if (iVar1 == 0) {
		    param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		    func_ii_2101(param1_00,0);
		    if (0 < *(int *)(param1 + 8)) {
		      param1_01 = func_ii_3010(param1,0,0);
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      param2_00 = System_Char__ToUpper(param1_01,0);
		      func_ii_3135(param1_00,param2_00,0);
		      if (1 < *(int *)(param1 + 8)) {
		        iVar1 = 1;
		        do {
		          param1_02 = func_ii_3010(param1,iVar1,0);
		          if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a66974);
		          }
		          iVar2 = System_Char__IsWhiteSpaceLatin1(param1_02,0);
		          if (iVar2 == 0) {
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            iVar2 = System_Char__TryParse(param1_02,0);
		            if (iVar2 != 0) {
		              if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                func_ii_306000(DAT_ram_00a66974);
		              }
		              iVar2 = System_Char__TryParse(param2_00 & 0xffff,0);
		              if (iVar2 == 0) goto code_r0x81cd6d18;
		            }
		          }
		          else {
		code_r0x81cd6d18:
		            iVar2 = func_ii_4075(param1_00,0);
		            if (0 < iVar2) {
		              func_ii_3135(param1_00,0x20,0);
		            }
		          }
		          func_ii_3135(param1_00,param1_02,0);
		          iVar1 = iVar1 + 1;
		          param2_00 = param1_02;
		        } while (iVar1 < *(int *)(param1 + 8));
		      }
		    }
		    param1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                       (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  }
		  return param1;
		}
		*/


		/* --- GHIDRA: ToString ---
		int LunarConsolePluginInternal_StringUtils__ToString(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param1_01;
		  uint param2_00;
		  uint param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a6072a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    DAT_ram_00a6072a = '\x01';
		  }
		  iVar1 = func_ii_4769(param1,0);
		  if (iVar1 == 0) {
		    param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		    func_ii_2101(param1_00,0);
		    if (0 < *(int *)(param1 + 8)) {
		      param1_01 = func_ii_3010(param1,0,0);
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      param2_00 = System_Char__ToUpper(param1_01,0);
		      func_ii_3135(param1_00,param2_00,0);
		      if (1 < *(int *)(param1 + 8)) {
		        iVar1 = 1;
		        do {
		          param1_02 = func_ii_3010(param1,iVar1,0);
		          if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a66974);
		          }
		          iVar2 = System_Char__IsWhiteSpaceLatin1(param1_02,0);
		          if (iVar2 == 0) {
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            iVar2 = System_Char__TryParse(param1_02,0);
		            if (iVar2 != 0) {
		              if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                func_ii_306000(DAT_ram_00a66974);
		              }
		              iVar2 = System_Char__TryParse(param2_00 & 0xffff,0);
		              if (iVar2 == 0) goto code_r0x81cd6d18;
		            }
		          }
		          else {
		code_r0x81cd6d18:
		            iVar2 = func_ii_4075(param1_00,0);
		            if (0 < iVar2) {
		              func_ii_3135(param1_00,0x20,0);
		            }
		          }
		          func_ii_3135(param1_00,param1_02,0);
		          iVar1 = iVar1 + 1;
		          param2_00 = param1_02;
		        } while (iVar1 < *(int *)(param1 + 8));
		      }
		    }
		    param1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                       (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  }
		  return param1;
		}
		*/


		/* --- GHIDRA: ToString ---
		int LunarConsolePluginInternal_StringUtils__ToString(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param1_01;
		  uint param2_00;
		  uint param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a6072a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    DAT_ram_00a6072a = '\x01';
		  }
		  iVar1 = func_ii_4769(param1,0);
		  if (iVar1 == 0) {
		    param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		    func_ii_2101(param1_00,0);
		    if (0 < *(int *)(param1 + 8)) {
		      param1_01 = func_ii_3010(param1,0,0);
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      param2_00 = System_Char__ToUpper(param1_01,0);
		      func_ii_3135(param1_00,param2_00,0);
		      if (1 < *(int *)(param1 + 8)) {
		        iVar1 = 1;
		        do {
		          param1_02 = func_ii_3010(param1,iVar1,0);
		          if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a66974);
		          }
		          iVar2 = System_Char__IsWhiteSpaceLatin1(param1_02,0);
		          if (iVar2 == 0) {
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            iVar2 = System_Char__TryParse(param1_02,0);
		            if (iVar2 != 0) {
		              if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                func_ii_306000(DAT_ram_00a66974);
		              }
		              iVar2 = System_Char__TryParse(param2_00 & 0xffff,0);
		              if (iVar2 == 0) goto code_r0x81cd6d18;
		            }
		          }
		          else {
		code_r0x81cd6d18:
		            iVar2 = func_ii_4075(param1_00,0);
		            if (0 < iVar2) {
		              func_ii_3135(param1_00,0x20,0);
		            }
		          }
		          func_ii_3135(param1_00,param1_02,0);
		          iVar1 = iVar1 + 1;
		          param2_00 = param1_02;
		        } while (iVar1 < *(int *)(param1 + 8));
		      }
		    }
		    param1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                       (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  }
		  return param1;
		}
		*/


		/* --- GHIDRA: ToString ---
		int LunarConsolePluginInternal_StringUtils__ToString(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param1_01;
		  uint param2_00;
		  uint param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a6072a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    DAT_ram_00a6072a = '\x01';
		  }
		  iVar1 = func_ii_4769(param1,0);
		  if (iVar1 == 0) {
		    param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		    func_ii_2101(param1_00,0);
		    if (0 < *(int *)(param1 + 8)) {
		      param1_01 = func_ii_3010(param1,0,0);
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      param2_00 = System_Char__ToUpper(param1_01,0);
		      func_ii_3135(param1_00,param2_00,0);
		      if (1 < *(int *)(param1 + 8)) {
		        iVar1 = 1;
		        do {
		          param1_02 = func_ii_3010(param1,iVar1,0);
		          if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a66974);
		          }
		          iVar2 = System_Char__IsWhiteSpaceLatin1(param1_02,0);
		          if (iVar2 == 0) {
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            iVar2 = System_Char__TryParse(param1_02,0);
		            if (iVar2 != 0) {
		              if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                func_ii_306000(DAT_ram_00a66974);
		              }
		              iVar2 = System_Char__TryParse(param2_00 & 0xffff,0);
		              if (iVar2 == 0) goto code_r0x81cd6d18;
		            }
		          }
		          else {
		code_r0x81cd6d18:
		            iVar2 = func_ii_4075(param1_00,0);
		            if (0 < iVar2) {
		              func_ii_3135(param1_00,0x20,0);
		            }
		          }
		          func_ii_3135(param1_00,param1_02,0);
		          iVar1 = iVar1 + 1;
		          param2_00 = param1_02;
		        } while (iVar1 < *(int *)(param1 + 8));
		      }
		    }
		    param1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                       (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  }
		  return param1;
		}
		*/


		/* --- GHIDRA: ToString ---
		int LunarConsolePluginInternal_StringUtils__ToString(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param1_01;
		  uint param2_00;
		  uint param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a6072a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    DAT_ram_00a6072a = '\x01';
		  }
		  iVar1 = func_ii_4769(param1,0);
		  if (iVar1 == 0) {
		    param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		    func_ii_2101(param1_00,0);
		    if (0 < *(int *)(param1 + 8)) {
		      param1_01 = func_ii_3010(param1,0,0);
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      param2_00 = System_Char__ToUpper(param1_01,0);
		      func_ii_3135(param1_00,param2_00,0);
		      if (1 < *(int *)(param1 + 8)) {
		        iVar1 = 1;
		        do {
		          param1_02 = func_ii_3010(param1,iVar1,0);
		          if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a66974);
		          }
		          iVar2 = System_Char__IsWhiteSpaceLatin1(param1_02,0);
		          if (iVar2 == 0) {
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            iVar2 = System_Char__TryParse(param1_02,0);
		            if (iVar2 != 0) {
		              if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                func_ii_306000(DAT_ram_00a66974);
		              }
		              iVar2 = System_Char__TryParse(param2_00 & 0xffff,0);
		              if (iVar2 == 0) goto code_r0x81cd6d18;
		            }
		          }
		          else {
		code_r0x81cd6d18:
		            iVar2 = func_ii_4075(param1_00,0);
		            if (0 < iVar2) {
		              func_ii_3135(param1_00,0x20,0);
		            }
		          }
		          func_ii_3135(param1_00,param1_02,0);
		          iVar1 = iVar1 + 1;
		          param2_00 = param1_02;
		        } while (iVar1 < *(int *)(param1 + 8));
		      }
		    }
		    param1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                       (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  }
		  return param1;
		}
		*/


		/* --- GHIDRA: ToString ---
		int LunarConsolePluginInternal_StringUtils__ToString(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param1_01;
		  uint param2_00;
		  uint param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a6072a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    DAT_ram_00a6072a = '\x01';
		  }
		  iVar1 = func_ii_4769(param1,0);
		  if (iVar1 == 0) {
		    param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		    func_ii_2101(param1_00,0);
		    if (0 < *(int *)(param1 + 8)) {
		      param1_01 = func_ii_3010(param1,0,0);
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      param2_00 = System_Char__ToUpper(param1_01,0);
		      func_ii_3135(param1_00,param2_00,0);
		      if (1 < *(int *)(param1 + 8)) {
		        iVar1 = 1;
		        do {
		          param1_02 = func_ii_3010(param1,iVar1,0);
		          if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a66974);
		          }
		          iVar2 = System_Char__IsWhiteSpaceLatin1(param1_02,0);
		          if (iVar2 == 0) {
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            iVar2 = System_Char__TryParse(param1_02,0);
		            if (iVar2 != 0) {
		              if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                func_ii_306000(DAT_ram_00a66974);
		              }
		              iVar2 = System_Char__TryParse(param2_00 & 0xffff,0);
		              if (iVar2 == 0) goto code_r0x81cd6d18;
		            }
		          }
		          else {
		code_r0x81cd6d18:
		            iVar2 = func_ii_4075(param1_00,0);
		            if (0 < iVar2) {
		              func_ii_3135(param1_00,0x20,0);
		            }
		          }
		          func_ii_3135(param1_00,param1_02,0);
		          iVar1 = iVar1 + 1;
		          param2_00 = param1_02;
		        } while (iVar1 < *(int *)(param1 + 8));
		      }
		    }
		    param1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                       (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  }
		  return param1;
		}
		*/


		/* --- GHIDRA: ToString ---
		int LunarConsolePluginInternal_StringUtils__ToString(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param1_01;
		  uint param2_00;
		  uint param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a6072a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    DAT_ram_00a6072a = '\x01';
		  }
		  iVar1 = func_ii_4769(param1,0);
		  if (iVar1 == 0) {
		    param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		    func_ii_2101(param1_00,0);
		    if (0 < *(int *)(param1 + 8)) {
		      param1_01 = func_ii_3010(param1,0,0);
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      param2_00 = System_Char__ToUpper(param1_01,0);
		      func_ii_3135(param1_00,param2_00,0);
		      if (1 < *(int *)(param1 + 8)) {
		        iVar1 = 1;
		        do {
		          param1_02 = func_ii_3010(param1,iVar1,0);
		          if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a66974);
		          }
		          iVar2 = System_Char__IsWhiteSpaceLatin1(param1_02,0);
		          if (iVar2 == 0) {
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            iVar2 = System_Char__TryParse(param1_02,0);
		            if (iVar2 != 0) {
		              if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                func_ii_306000(DAT_ram_00a66974);
		              }
		              iVar2 = System_Char__TryParse(param2_00 & 0xffff,0);
		              if (iVar2 == 0) goto code_r0x81cd6d18;
		            }
		          }
		          else {
		code_r0x81cd6d18:
		            iVar2 = func_ii_4075(param1_00,0);
		            if (0 < iVar2) {
		              func_ii_3135(param1_00,0x20,0);
		            }
		          }
		          func_ii_3135(param1_00,param1_02,0);
		          iVar1 = iVar1 + 1;
		          param2_00 = param1_02;
		        } while (iVar1 < *(int *)(param1 + 8));
		      }
		    }
		    param1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                       (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  }
		  return param1;
		}
		*/


		/* --- GHIDRA: ToString ---
		int LunarConsolePluginInternal_StringUtils__ToString(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param1_01;
		  uint param2_00;
		  uint param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a6072a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    DAT_ram_00a6072a = '\x01';
		  }
		  iVar1 = func_ii_4769(param1,0);
		  if (iVar1 == 0) {
		    param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		    func_ii_2101(param1_00,0);
		    if (0 < *(int *)(param1 + 8)) {
		      param1_01 = func_ii_3010(param1,0,0);
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      param2_00 = System_Char__ToUpper(param1_01,0);
		      func_ii_3135(param1_00,param2_00,0);
		      if (1 < *(int *)(param1 + 8)) {
		        iVar1 = 1;
		        do {
		          param1_02 = func_ii_3010(param1,iVar1,0);
		          if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a66974);
		          }
		          iVar2 = System_Char__IsWhiteSpaceLatin1(param1_02,0);
		          if (iVar2 == 0) {
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            iVar2 = System_Char__TryParse(param1_02,0);
		            if (iVar2 != 0) {
		              if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                func_ii_306000(DAT_ram_00a66974);
		              }
		              iVar2 = System_Char__TryParse(param2_00 & 0xffff,0);
		              if (iVar2 == 0) goto code_r0x81cd6d18;
		            }
		          }
		          else {
		code_r0x81cd6d18:
		            iVar2 = func_ii_4075(param1_00,0);
		            if (0 < iVar2) {
		              func_ii_3135(param1_00,0x20,0);
		            }
		          }
		          func_ii_3135(param1_00,param1_02,0);
		          iVar1 = iVar1 + 1;
		          param2_00 = param1_02;
		        } while (iVar1 < *(int *)(param1 + 8));
		      }
		    }
		    param1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                       (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  }
		  return param1;
		}
		*/


		/* --- GHIDRA: ToString ---
		int LunarConsolePluginInternal_StringUtils__ToString(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param1_01;
		  uint param2_00;
		  uint param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a6072a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    DAT_ram_00a6072a = '\x01';
		  }
		  iVar1 = func_ii_4769(param1,0);
		  if (iVar1 == 0) {
		    param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		    func_ii_2101(param1_00,0);
		    if (0 < *(int *)(param1 + 8)) {
		      param1_01 = func_ii_3010(param1,0,0);
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      param2_00 = System_Char__ToUpper(param1_01,0);
		      func_ii_3135(param1_00,param2_00,0);
		      if (1 < *(int *)(param1 + 8)) {
		        iVar1 = 1;
		        do {
		          param1_02 = func_ii_3010(param1,iVar1,0);
		          if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a66974);
		          }
		          iVar2 = System_Char__IsWhiteSpaceLatin1(param1_02,0);
		          if (iVar2 == 0) {
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            iVar2 = System_Char__TryParse(param1_02,0);
		            if (iVar2 != 0) {
		              if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                func_ii_306000(DAT_ram_00a66974);
		              }
		              iVar2 = System_Char__TryParse(param2_00 & 0xffff,0);
		              if (iVar2 == 0) goto code_r0x81cd6d18;
		            }
		          }
		          else {
		code_r0x81cd6d18:
		            iVar2 = func_ii_4075(param1_00,0);
		            if (0 < iVar2) {
		              func_ii_3135(param1_00,0x20,0);
		            }
		          }
		          func_ii_3135(param1_00,param1_02,0);
		          iVar1 = iVar1 + 1;
		          param2_00 = param1_02;
		        } while (iVar1 < *(int *)(param1 + 8));
		      }
		    }
		    param1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                       (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  }
		  return param1;
		}
		*/


		/* --- GHIDRA: Join<__Il2CppFullySharedGenericType> ---
		void LunarConsolePluginInternal_StringUtils__Join___Il2CppFullySharedGenericType_
		               (int param1,int param2,undefined4 param3,undefined4 param4,int param5)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined1 *param2_00;
		  int iVar4;
		  int iVar5;
		  undefined4 *puVar6;
		  int param3_00;
		  uint *puVar7;
		  undefined1 local_10 [8];
		  undefined4 local_8;
		  undefined1 *local_4;
		  
		  piVar3 = *(int **)(param5 + 0x1c);
		  if (piVar3 == (int *)0x0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param5);
		    piVar3 = *(int **)(param5 + 0x1c);
		  }
		  param3_00 = *(int *)(piVar3[10] + 0x84);
		  param2_00 = local_10 + -(param3_00 + 0xfU & 0xfffffff0);
		  iVar4 = *piVar3;
		  if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		    iVar4 = func_ii_1079(iVar4);
		  }
		  iVar4 = unnamed_function_1417(iVar4);
		  puVar7 = *(uint **)(*(int *)(param5 + 0x1c) + 4);
		  (**(code **)((ulonglong)*puVar7 * 4))(iVar4,puVar7);
		  *(undefined4 *)(iVar4 + 0xc) = param3;
		  *(int *)(iVar4 + 8) = param2;
		  if (param1 != 0) {
		    if (param2 != 0) {
		      iVar5 = *(int *)(*(int *)(param5 + 0x1c) + 0x14);
		      if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		        iVar5 = func_ii_1079(iVar5);
		      }
		      uVar1 = unnamed_function_1417(iVar5);
		      puVar7 = *(uint **)(*(int *)(param5 + 0x1c) + 0x18);
		      (**(code **)((ulonglong)*puVar7 * 4))
		                (uVar1,iVar4,*(undefined4 *)(*(int *)(param5 + 0x1c) + 0x10),puVar7);
		      puVar7 = *(uint **)(*(int *)(param5 + 0x1c) + 0x1c);
		      uVar1 = (**(code **)((ulonglong)*puVar7 * 4))(param1,uVar1,puVar7);
		      puVar7 = *(uint **)(*(int *)(param5 + 0x1c) + 0x20);
		      iVar5 = (**(code **)((ulonglong)*puVar7 * 4))(uVar1,puVar7);
		      local_4 = param2_00;
		      if (iVar5 < 2) {
		        puVar6 = *(undefined4 **)(*(int *)(param5 + 0x1c) + 0x24);
		        local_8 = uVar1;
		        (**(code **)((ulonglong)(uint)puVar6[2] * 4))(*puVar6,puVar6,0,&local_8,param2_00);
		      }
		      else {
		        iVar5 = *(int *)(*(int *)(param5 + 0x1c) + 0x14);
		        if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		          iVar5 = func_ii_1079(iVar5);
		        }
		        uVar1 = unnamed_function_1417(iVar5);
		        puVar7 = *(uint **)(*(int *)(param5 + 0x1c) + 0x18);
		        (**(code **)((ulonglong)*puVar7 * 4))
		                  (uVar1,iVar4,*(undefined4 *)(*(int *)(param5 + 0x1c) + 0x2c),puVar7);
		        puVar7 = *(uint **)(*(int *)(param5 + 0x1c) + 0x1c);
		        local_8 = (**(code **)((ulonglong)*puVar7 * 4))(param1,uVar1,puVar7);
		        puVar6 = *(undefined4 **)(*(int *)(param5 + 0x1c) + 0x24);
		        (**(code **)((ulonglong)(uint)puVar6[2] * 4))(*puVar6,puVar6,0,&local_8,param2_00);
		      }
		      unnamed_function_713(param4,param2_00,param3_00);
		      return;
		    }
		    uVar1 = unnamed_function_2232(&System_ArgumentNullException_TypeInfo);
		    uVar1 = unnamed_function_1417(uVar1);
		    uVar2 = unnamed_function_2232(&StringLiteral_28226);
		    Mono_Security_X509_X509Certificate___ctor(uVar1,uVar2,0);
		    func_ii_1050(uVar1,param5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = unnamed_function_2232(&System_ArgumentNullException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  uVar2 = unnamed_function_2232(&StringLiteral_27321);
		  Mono_Security_X509_X509Certificate___ctor(uVar1,uVar2,0);
		  func_ii_1050(uVar1,param5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: ToDisplayName ---
		int * LunarConsolePluginInternal_StringUtils__ToDisplayName(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *param1_00;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  uint *puVar6;
		  int param1_01;
		  int iVar7;
		  int *piVar8;
		  
		  iVar7 = 0;
		  if (DAT_ram_00a6072b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IDictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_47);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19016);
		    DAT_ram_00a6072b = '\x01';
		  }
		  iVar2 = System_Net_WebConnection__ReadLine(param1,10,0,0);
		  param1_00 = (int *)unnamed_function_1417
		                               (System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      param1_01 = *(int *)(iVar2 + iVar7 * 4 + 0x10);
		      iVar3 = System_Xml_Schema_XmlSchemaException___ctor(param1_01,0x3a,0);
		      uVar4 = System_Data_DataSet__ReadXmlSchema(param1_01,0,iVar3,0);
		      uVar5 = System_Data_DataSet__ReadXmlSchema
		                        (param1_01,iVar3 + 1,*(int *)(param1_01 + 8) - (iVar3 + 1),0);
		      uVar5 = func_ii_7088(uVar5,StringLiteral_19016,StringLiteral_47,0);
		      iVar3 = *param1_00;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IDictionary_string__string__TypeInfo == *piVar8) {
		            puVar6 = (uint *)(piVar8[1] * 8 + iVar3 + 200);
		            goto code_r0x81cc90c7;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      puVar6 = (uint *)func_ii_1080(param1_00,
		                                    System_Collections_Generic_IDictionary_string__string__TypeInfo,
		                                    1);
		code_r0x81cc90c7:
		      (**(code **)((ulonglong)*puVar6 * 4))(param1_00,uVar4,uVar5,puVar6[1]);
		      iVar7 = iVar7 + 1;
		    } while (iVar7 < *(int *)(iVar2 + 0xc));
		  }
		  return param1_00;
		}
		*/


		/* --- GHIDRA: DeserializeString ---
		void LunarConsolePluginInternal_StringUtils__DeserializeString(undefined4 param1)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a6072c == '\0') {
		    Mono_Security_ASN1__get_Item(&char___TypeInfo);
		    Mono_Security_ASN1__get_Item(&LunarConsolePluginInternal_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_774);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18992);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18994);
		    Mono_Security_ASN1__get_Item(&StringLiteral_527);
		    DAT_ram_00a6072c = '\x01';
		  }
		  iVar1 = Mono_Security_ASN1Convert__ToOid(char___TypeInfo,1);
		  *(undefined2 *)(iVar1 + 0x10) = 0x20;
		  **(int **)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x5c) = iVar1;
		  iVar1 = *(int *)(LunarConsolePluginInternal_StringUtils_TypeInfo + 0x5c);
		  *(undefined4 *)(iVar1 + 8) = StringLiteral_527;
		  *(undefined4 *)(iVar1 + 0xc) = StringLiteral_774;
		  *(undefined4 *)(iVar1 + 0x10) = StringLiteral_18992;
		  *(undefined4 *)(iVar1 + 0x14) = StringLiteral_18994;
		  return;
		}
		*/


		/* --- GHIDRA: .cctor ---
		undefined4
		LunarConsolePluginInternal_StringUtils___cctor(int param1,undefined4 *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = 0;
		  if ((param2[1] == *(int *)(param1 + 0xc)) && ((float)param2[2] == *(float *)(param1 + 0x10))) {
		    uVar1 = System_Collections_CollectionBase___ctor(*param2,*(undefined4 *)(param1 + 8),0);
		  }
		  return uVar1;
		}
		*/

}
