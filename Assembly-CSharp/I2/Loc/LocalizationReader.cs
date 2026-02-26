using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02001376 RID: 4982
	[Token(Token = "0x2001376")]
	public class LocalizationReader
	{
		// Token: 0x0600765B RID: 30299 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600765B")]
		[Address(RVA = "0xBFD7", Offset = "0xBFD7", VA = "0xBFD7")]
		public static Dictionary<string, string> ReadTextAsset(TextAsset asset)
		{
		/* --- GHIDRA: ReadTextAsset ---
		uint I2_Loc_LocalizationReader__ReadTextAsset
		               (undefined4 param1,int *param2,undefined4 *param3,undefined4 *param4,
		               undefined4 *param5,undefined4 *param6,undefined4 param7)
		
		{
		  int iVar1;
		  uint param3_00;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a604c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_47);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1621);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2361);
		    Mono_Security_ASN1__get_Item(&StringLiteral_92);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19016);
		    DAT_ram_00a604c5 = '\x01';
		  }
		  *param2 = **(int **)(DAT_ram_00a66978 + 0x5c);
		  *param4 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  *param5 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  *param6 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  *param3 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  iVar1 = func_ii_18910(param1,StringLiteral_1621,4,0);
		  if (-1 < iVar1) {
		    uVar2 = System_String__get_Chars(param1,iVar1 + 2,0);
		    uVar2 = System_Convert__FromBase64String(uVar2,0);
		    *param5 = uVar2;
		    if (DAT_ram_00a604cc == '\0') {
		      Mono_Security_ASN1__get_Item(&StringLiteral_92);
		      Mono_Security_ASN1__get_Item(&StringLiteral_2140);
		      DAT_ram_00a604cc = '\x01';
		    }
		    iVar3 = func_ii_4769(uVar2,0);
		    if (iVar3 == 0) {
		      uVar2 = func_ii_7088(uVar2,StringLiteral_2140,StringLiteral_92,0);
		    }
		    else {
		      uVar2 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		    }
		    *param5 = uVar2;
		    param1 = System_Data_DataSet__ReadXmlSchema(param1,0,iVar1,0);
		  }
		  param3_00 = System_Xml_XmlTextEncoder__StartAttribute(param1,StringLiteral_2361,4,0);
		  if (-1 < (int)param3_00) {
		    uVar2 = System_Data_DataSet__ReadXmlSchema(param1,0,param3_00,0);
		    iVar1 = System_Convert__FromBase64String(uVar2,0);
		    *param2 = iVar1;
		    uVar2 = System_String__get_Chars(param1,param3_00 + 1,0);
		    uVar2 = System_Convert__FromBase64String(uVar2,0);
		    *param3 = uVar2;
		    uVar2 = func_ii_7088(uVar2,StringLiteral_92,StringLiteral_47,0);
		    uVar2 = func_ii_7088(uVar2,StringLiteral_47,StringLiteral_19016,0);
		    *param3 = uVar2;
		    if (DAT_ram_00a604cc == '\0') {
		      Mono_Security_ASN1__get_Item(&StringLiteral_92);
		      Mono_Security_ASN1__get_Item(&StringLiteral_2140);
		      DAT_ram_00a604cc = '\x01';
		    }
		    iVar1 = func_ii_4769(uVar2,0);
		    if (iVar1 == 0) {
		      uVar2 = func_ii_7088(uVar2,StringLiteral_2140,StringLiteral_92,0);
		    }
		    else {
		      uVar2 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		    }
		    *param3 = uVar2;
		    iVar1 = *param2;
		    if (((2 < *(int *)(iVar1 + 8)) && (iVar3 = func_ii_3010(iVar1,0,0), iVar3 == 0x5b)) &&
		       (iVar1 = System_Xml_Schema_XmlSchemaException___ctor(*param2,0x5d,0), -1 < iVar1)) {
		      uVar2 = System_Data_DataSet__ReadXmlSchema(*param2,1,iVar1 + -1,0);
		      *param6 = uVar2;
		      iVar3 = System_String__get_Chars(*param2,iVar1 + 1,0);
		      *param2 = iVar3;
		    }
		    I2_Loc_LocalizationReader__AddCSVtoken(param2,iVar1);
		  }
		  return (param3_00 ^ 0xffffffff) >> 0x1f;
		}
		*/

			return null;
		}

		// Token: 0x0600765C RID: 30300 RVA: 0x00015738 File Offset: 0x00013938
		[Token(Token = "0x600765C")]
		[Address(RVA = "0xBFD8", Offset = "0xBFD8", VA = "0xBFD8")]
		public static bool TextAsset_ReadLine(string line, out string key, out string value, out string category, out string comment, out string termType)
		{
		/* --- GHIDRA: TextAsset_ReadLine ---
		undefined4
		I2_Loc_LocalizationReader__TextAsset_ReadLine(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a604c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IO_StreamReader_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_47);
		    Mono_Security_ASN1__get_Item(&StringLiteral_92);
		    Mono_Security_ASN1__get_Item(&StringLiteral_91);
		    DAT_ram_00a604c6 = '\x01';
		  }
		  uVar5 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  piVar2 = (int *)unnamed_function_1417(System_IO_StreamReader_TypeInfo);
		  System_IO_StreamReader___ctor(piVar2,param1,param2,0);
		  local_c = 0;
		  local_8 = &local_4;
		  DAT_ram_009d3e38 = 0;
		  local_4 = piVar2;
		  uVar3 = import::env::invoke_iii
		                    (*(undefined4 *)(*piVar2 + 0x120),piVar2,*(undefined4 *)(*piVar2 + 0x124));
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar6 = global_1;
		    iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar6 == iVar7) {
		      piVar2 = (int *)import::env::__cxa_begin_catch(uVar3);
		      iVar6 = *piVar2;
		      DAT_ram_009d3e38 = 0;
		      local_c = iVar6;
		      import::env::invoke_v(0x123);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      uVar3 = uVar5;
		      if (iVar7 != 1) goto code_r0x81c99917;
		      uVar3 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s___Scripting__UnityEngine__Player_ram_000035bf + 0x49,&local_c);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    import::env::__resumeException(uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x81c99917:
		  piVar2 = local_4;
		  DAT_ram_009d3e38 = 0;
		  if (local_4 != (int *)0x0) {
		    uVar1 = 0;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81c9998f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81c9998f:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar2,puVar4[1]);
		  }
		  if (iVar6 == 0) {
		    uVar3 = func_ii_7088(uVar3,StringLiteral_92,StringLiteral_47,0);
		    uVar3 = func_ii_7088(uVar3,StringLiteral_91,StringLiteral_47,0);
		    return uVar3;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x0600765D RID: 30301 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600765D")]
		[Address(RVA = "0xBFD9", Offset = "0xBFD9", VA = "0xBFD9")]
		public static string ReadCSVfile(string Path, Encoding encoding)
		{
		/* --- GHIDRA: ReadCSVfile ---
		int I2_Loc_LocalizationReader__ReadCSVfile(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  int param2_00;
		  uint uVar2;
		  int local_4;
		  
		  if (DAT_ram_00a604c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string____Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string_____ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string____TypeInfo);
		    DAT_ram_00a604c7 = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_string____TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_string_____ctor__);
		  if (0 < *(int *)(param1 + 8)) {
		    do {
		      param2_00 = I2_Loc_LocalizationReader__ReadCSV(param1,&local_4,param2,param1_00);
		      iVar1 = Method_System_Collections_Generic_List_string____Add__;
		      if (param2_00 == 0) {
		        return param1_00;
		      }
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar2 = *(uint *)(param1_00 + 0xc);
		      if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		        *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		        *(int *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param2_00;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,param2_00,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      }
		    } while (local_4 < *(int *)(param1 + 8));
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600765E RID: 30302 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600765E")]
		[Address(RVA = "0xBFDA", Offset = "0xBFDA", VA = "0xBFDA")]
		public static List<string[]> ReadCSV(string Text, char Separator = ',')
		{
		/* --- GHIDRA: ReadCSV ---
		undefined4 I2_Loc_LocalizationReader__ReadCSV(int param1,int *param2,int param3,undefined4 param4)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int local_c;
		  undefined4 local_8;
		  int local_4;
		  
		  bVar1 = false;
		  local_4 = param1;
		  if (DAT_ram_00a604c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    DAT_ram_00a604c8 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,Method_System_Collections_Generic_List_string___ctor__);
		  iVar4 = *(int *)(param1 + 8);
		  iVar5 = *param2;
		  local_c = iVar5;
		  local_8 = uVar2;
		  do {
		    if (iVar4 <= iVar5) {
		code_r0x81c95d75:
		      if (local_c < iVar5) {
		        I2_Loc_LocalizationReader__ParseCSVline(&local_8,&local_4,iVar5,&local_c,iVar5);
		      }
		      uVar2 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                        (uVar2,Method_System_Collections_Generic_List_string__ToArray__);
		      return uVar2;
		    }
		    iVar5 = func_ii_3010(param1,iVar5,0);
		    if (bVar1) {
		      bVar1 = true;
		      if (iVar5 == 0x22) {
		        bVar1 = false;
		        if ((*param2 + 1 < iVar4) && (iVar5 = func_ii_3010(param1,*param2 + 1,0), iVar5 == 0x22)) {
		          iVar5 = *param2;
		          if (iVar5 + 2 < iVar4) {
		            iVar3 = func_ii_3010(param1,iVar5 + 2,0);
		            iVar5 = *param2;
		            if (iVar3 == 0x22) {
		              *param2 = iVar5 + 2;
		              goto code_r0x81c95d5d;
		            }
		          }
		          bVar1 = true;
		          *param2 = iVar5 + 1;
		        }
		      }
		    }
		    else if (iVar5 == 10 || param3 == iVar5) {
		      I2_Loc_LocalizationReader__ParseCSVline(&local_8,&local_4,*param2,&local_c,iVar5);
		      bVar1 = false;
		      if (iVar5 == 10) {
		        iVar5 = *param2 + 1;
		        *param2 = iVar5;
		        goto code_r0x81c95d75;
		      }
		    }
		    else {
		      bVar1 = iVar5 == 0x22;
		    }
		code_r0x81c95d5d:
		    iVar5 = *param2 + 1;
		    *param2 = iVar5;
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x0600765F RID: 30303 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600765F")]
		[Address(RVA = "0xBFDB", Offset = "0xBFDB", VA = "0xBFDB")]
		private static string[] ParseCSVline(string Line, ref int iStart, char Separator)
		{
		/* --- GHIDRA: ParseCSVline ---
		void I2_Loc_LocalizationReader__ParseCSVline
		               (int *param1,undefined4 *param2,int param3,int *param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  int param1_01;
		  int iVar1;
		  int param1_02;
		  uint uVar2;
		  
		  if (DAT_ram_00a604c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Add__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_527);
		    Mono_Security_ASN1__get_Item(&StringLiteral_555);
		    DAT_ram_00a604c9 = '\x01';
		  }
		  param1_00 = System_Data_DataSet__ReadXmlSchema(*param2,*param4,param3 - *param4,0);
		  *param4 = param3 + 1;
		  param1_01 = func_ii_7088(param1_00,StringLiteral_555,StringLiteral_527,0);
		  if (((1 < *(int *)(param1_01 + 8)) && (iVar1 = func_ii_3010(param1_01,0,0), iVar1 == 0x22)) &&
		     (iVar1 = func_ii_3010(param1_01,*(int *)(param1_01 + 8) + -1,0), iVar1 == 0x22)) {
		    param1_01 = System_Data_DataSet__ReadXmlSchema(param1_01,1,*(int *)(param1_01 + 8) + -2,0);
		  }
		  iVar1 = Method_System_Collections_Generic_List_string__Add__;
		  param1_02 = *param1;
		  *(int *)(param1_02 + 0x10) = *(int *)(param1_02 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_02 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_02 + 8) + 0xc)) {
		    *(uint *)(param1_02 + 0xc) = uVar2 + 1;
		    *(int *)(*(int *)(param1_02 + 8) + uVar2 * 4 + 0x10) = param1_01;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_02,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06007660 RID: 30304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007660")]
		[Address(RVA = "0xBFDC", Offset = "0xBFDC", VA = "0xBFDC")]
		private static void AddCSVtoken(ref List<string> list, ref string Line, int iEnd, ref int iWordStart)
		{
		/* --- GHIDRA: AddCSVtoken ---
		void I2_Loc_LocalizationReader__AddCSVtoken(undefined4 *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int param2_00;
		  
		  uVar1 = LunarConsolePlugin_CVarList__Find(*param1,0x5c,0x2f,0);
		  *param1 = uVar1;
		  iVar2 = System_Xml_Schema_XmlSchemaException___ctor(uVar1,0x2f,0);
		  if (-1 < iVar2) {
		    param2_00 = System_Attribute___ctor(*param1,0x2f,0);
		    while (param2_00 != iVar2) {
		      uVar1 = System_String__PadRight(*param1,param2_00,1,0);
		      *param1 = uVar1;
		      param2_00 = System_Attribute___ctor(uVar1,0x2f,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007661 RID: 30305 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007661")]
		[Address(RVA = "0x3604", Offset = "0x3604", VA = "0x3604")]
		public static List<string[]> ReadI2CSV(string Text)
		{
		/* --- GHIDRA: ReadI2CSV ---
		undefined4
		I2_Loc_LocalizationReader__ReadI2CSV
		          (int param1,undefined4 param2,int param3,int param4,undefined4 param5)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  int iVar10;
		  int iVar11;
		  int iVar12;
		  int iVar13;
		  undefined4 uVar14;
		  uint uVar15;
		  undefined4 uVar16;
		  undefined4 param3_00;
		  int local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a60490 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Resize_byte___);
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Resize_string___);
		    Mono_Security_ASN1__get_Item(&byte___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TermData__Add__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleLanguages_TypeInfo);
		    Mono_Security_ASN1__get_Item(&int___TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string____get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string____get_Item__);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_TermData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1331);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16380);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3756);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    Mono_Security_ASN1__get_Item(&StringLiteral_663);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16540);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10226);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27784);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19094);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6481);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6479);
		    DAT_ram_00a60490 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  local_c = 0;
		  iVar4 = System_Linq_Enumerable__ToList_object_
		                    (param3,0,Method_System_Collections_Generic_List_string____get_Item__);
		  iVar5 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,1);
		  *(undefined4 *)(iVar5 + 0x10) = StringLiteral_10226;
		  iVar6 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,1);
		  *(undefined4 *)(iVar6 + 0x10) = StringLiteral_16540;
		  iVar7 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,2);
		  *(undefined4 *)(iVar7 + 0x10) = StringLiteral_6479;
		  *(undefined4 *)(iVar7 + 0x14) = StringLiteral_6481;
		  puVar3 = &StringLiteral_3756;
		  if ((*(int *)(iVar4 + 0xc) < 2) || (iVar13 = *(int *)(iVar5 + 0xc), iVar13 < 1))
		  goto code_r0x81c95bf5;
		  iVar2 = 0;
		  uVar14 = *(undefined4 *)(iVar4 + 0x10);
		  iVar8 = System_Xml_XmlTextEncoder__StartAttribute(uVar14,*(undefined4 *)(iVar5 + 0x10),5,0);
		  if (iVar8 < 0) {
		    do {
		      iVar2 = iVar2 + 1;
		      if (iVar13 == iVar2) break;
		      iVar8 = System_Xml_XmlTextEncoder__StartAttribute
		                        (uVar14,*(undefined4 *)(iVar5 + iVar2 * 4 + 0x10),5,0);
		    } while (iVar8 < 0);
		    if (iVar13 <= iVar2) goto code_r0x81c95bf5;
		  }
		  iVar5 = 1;
		  if (param4 == 1) {
		    I2_Loc_PersistentStorage__ForceSaveSettings(param1,iVar2);
		  }
		  iVar13 = -1;
		  iVar2 = -1;
		  if (2 < *(int *)(iVar4 + 0xc)) {
		    uVar14 = *(undefined4 *)(iVar4 + 0x14);
		    iVar5 = *(int *)(iVar6 + 0xc);
		    if (iVar5 < 1) {
		      iVar5 = 1;
		      iVar2 = -1;
		    }
		    else {
		      iVar2 = 0;
		      bVar1 = true;
		      iVar8 = System_Xml_XmlTextEncoder__StartAttribute(uVar14,*(undefined4 *)(iVar6 + 0x10),5,0);
		      if (iVar8 < 0) {
		        do {
		          iVar2 = iVar2 + 1;
		          if (iVar5 == iVar2) break;
		          iVar8 = System_Xml_XmlTextEncoder__StartAttribute
		                            (uVar14,*(undefined4 *)(iVar6 + iVar2 * 4 + 0x10),5,0);
		        } while (iVar8 < 0);
		        bVar1 = iVar2 < iVar5;
		      }
		      iVar5 = 2;
		      if (!bVar1) {
		        iVar5 = 1;
		      }
		      uVar14 = *(undefined4 *)(iVar4 + 0x14);
		      iVar2 = 1;
		      if (!bVar1) {
		        iVar2 = -1;
		      }
		    }
		    iVar8 = *(int *)(iVar7 + 0xc);
		    if (0 < iVar8) {
		      iVar13 = 0;
		      iVar9 = System_Xml_XmlTextEncoder__StartAttribute(uVar14,*(undefined4 *)(iVar7 + 0x10),5,0);
		      if (iVar9 < 0) {
		        do {
		          iVar13 = iVar13 + 1;
		          if (iVar8 == iVar13) break;
		          iVar9 = System_Xml_XmlTextEncoder__StartAttribute
		                            (uVar14,*(undefined4 *)(iVar7 + iVar13 * 4 + 0x10),5,0);
		        } while (iVar9 < 0);
		        bVar1 = iVar13 < iVar8;
		      }
		      else {
		        bVar1 = true;
		      }
		      iVar13 = 2;
		      if (!bVar1) {
		        iVar13 = iVar5;
		      }
		      iVar5 = iVar13;
		      iVar13 = 1;
		      if (!bVar1) {
		        iVar13 = -1;
		      }
		    }
		    if (3 < *(int *)(iVar4 + 0xc)) {
		      uVar14 = *(undefined4 *)(iVar4 + 0x18);
		      iVar8 = *(int *)(iVar6 + 0xc);
		      if (0 < iVar8) {
		        iVar9 = 0;
		        iVar10 = System_Xml_XmlTextEncoder__StartAttribute(uVar14,*(undefined4 *)(iVar6 + 0x10),5,0)
		        ;
		        if (iVar10 < 0) {
		          do {
		            iVar9 = iVar9 + 1;
		            if (iVar8 == iVar9) break;
		            iVar10 = System_Xml_XmlTextEncoder__StartAttribute
		                               (uVar14,*(undefined4 *)(iVar6 + iVar9 * 4 + 0x10),5,0);
		          } while (iVar10 < 0);
		          if (iVar9 < iVar8) goto code_r0x81c9553e;
		        }
		        else {
		code_r0x81c9553e:
		          iVar2 = 2;
		          iVar5 = 3;
		        }
		        uVar14 = *(undefined4 *)(iVar4 + 0x18);
		      }
		      iVar6 = *(int *)(iVar7 + 0xc);
		      if (0 < iVar6) {
		        iVar8 = 0;
		        iVar9 = System_Xml_XmlTextEncoder__StartAttribute(uVar14,*(undefined4 *)(iVar7 + 0x10),5,0);
		        if (iVar9 < 0) {
		          do {
		            iVar8 = iVar8 + 1;
		            if (iVar6 == iVar8) break;
		            iVar9 = System_Xml_XmlTextEncoder__StartAttribute
		                              (uVar14,*(undefined4 *)(iVar7 + iVar8 * 4 + 0x10),5,0);
		          } while (iVar9 < 0);
		          if (iVar6 <= iVar8) goto code_r0x81c955ae;
		        }
		        iVar5 = 3;
		        iVar13 = 2;
		      }
		    }
		  }
		code_r0x81c955ae:
		  iVar7 = *(int *)(iVar4 + 0xc) - iVar5;
		  iVar6 = iVar7;
		  if (iVar7 < 1) {
		    iVar6 = 0;
		  }
		  iVar8 = Mono_Security_ASN1Convert__ToOid(int___TypeInfo,iVar6);
		  if (0 < iVar7) {
		    iVar7 = 0;
		    do {
		      iVar9 = -1;
		      puVar3 = (undefined4 *)(iVar4 + (iVar7 + iVar5) * 4 + 0x10);
		      iVar10 = func_ii_4769(*puVar3,0);
		      if (iVar10 == 0) {
		        uVar14 = *puVar3;
		        iVar10 = System_String__Substring(uVar14,StringLiteral_663,4,0);
		        if (iVar10 != 0) {
		          uVar14 = System_String__get_Chars(uVar14,1,0);
		        }
		        if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		        }
		        I2_Loc_GoogleLanguages__GetFormatedLanguageName(uVar14,&local_4,&local_8,0);
		        iVar9 = func_ii_4769(local_8,0);
		        uVar16 = local_8;
		        if (iVar9 == 0) {
		          if (DAT_ram_00a604a0 == '\0') {
		            Mono_Security_ASN1__get_Item
		                      (&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		            Mono_Security_ASN1__get_Item
		                      (&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		            DAT_ram_00a604a0 = '\x01';
		          }
		          iVar9 = 0;
		          iVar11 = *(int *)(*(int *)(param1 + 0x24) + 0xc);
		          if (0 < iVar11) {
		            do {
		              iVar12 = System_Linq_Enumerable__ToList_object_
		                                 (*(undefined4 *)(param1 + 0x24),iVar9,
		                                  Method_System_Collections_Generic_List_LanguageData__get_Item__);
		              iVar12 = func_ii_3039(*(undefined4 *)(iVar12 + 0xc),uVar16,5,0);
		              if (iVar12 == 0) goto code_r0x81c956e8;
		              iVar9 = iVar9 + 1;
		            } while (iVar9 != iVar11);
		          }
		        }
		        else {
		          iVar9 = I2_Loc_LanguageSourceData__Import_Google_Result(param1,local_4,1,0,uVar14);
		code_r0x81c956e8:
		          if (-1 < iVar9) goto code_r0x81c95787;
		        }
		        iVar11 = unnamed_function_1417(I2_Loc_LanguageData_TypeInfo);
		        *(undefined4 *)(iVar11 + 8) = local_4;
		        *(char *)(iVar11 + 0x10) = (char)iVar10;
		        *(undefined4 *)(iVar11 + 0xc) = local_8;
		        iVar9 = Method_System_Collections_Generic_List_LanguageData__Add__;
		        iVar10 = *(int *)(param1 + 0x24);
		        *(int *)(iVar10 + 0x10) = *(int *)(iVar10 + 0x10) + 1;
		        uVar15 = *(uint *)(iVar10 + 0xc);
		        if (uVar15 < *(uint *)(*(int *)(iVar10 + 8) + 0xc)) {
		          *(uint *)(iVar10 + 0xc) = uVar15 + 1;
		          *(int *)(*(int *)(iVar10 + 8) + uVar15 * 4 + 0x10) = iVar11;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar10,iVar11,*(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		        }
		        iVar9 = *(int *)(*(int *)(param1 + 0x24) + 0xc) + -1;
		      }
		code_r0x81c95787:
		      *(int *)(iVar8 + iVar7 * 4 + 0x10) = iVar9;
		      iVar7 = iVar7 + 1;
		    } while (iVar7 != iVar6);
		  }
		  iVar4 = *(int *)(*(int *)(param1 + 0x10) + 0xc);
		  if (0 < iVar4) {
		    iVar7 = *(int *)(*(int *)(param1 + 0x24) + 0xc);
		    iVar6 = 0;
		    do {
		      iVar9 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(param1 + 0x10),iVar6,
		                         Method_System_Collections_Generic_List_TermData__get_Item__);
		      if (*(int *)(*(int *)(iVar9 + 0x14) + 0xc) < iVar7) {
		        BestHTTP_SocketIO_Packet__EncodeBinary
		                  (iVar9 + 0x14,iVar7,Method_System_Array_Resize_string___);
		        BestHTTP_SocketIO_Packet__EncodeBinary
		                  (iVar9 + 0x18,iVar7,Method_System_Array_Resize_byte___);
		      }
		      iVar6 = iVar6 + 1;
		    } while (iVar6 != iVar4);
		  }
		  iVar4 = *(int *)(param3 + 0xc);
		  if (1 < iVar4) {
		    iVar6 = 1;
		    do {
		      iVar9 = System_Linq_Enumerable__ToList_object_
		                        (param3,iVar6,Method_System_Collections_Generic_List_string____get_Item__);
		      iVar10 = func_ii_4769(param2,0);
		      iVar7 = *(int *)(iVar9 + 0x10);
		      if (iVar10 == 0) {
		        iVar7 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                          (param2,StringLiteral_1618,iVar7,0);
		      }
		      local_c = iVar7;
		      iVar10 = func_ii_16527(iVar7,StringLiteral_19094,4,0);
		      if (iVar10 == 0) {
		        uVar14 = 0;
		      }
		      else {
		        iVar10 = System_Attribute___ctor(iVar7,0x5b,0);
		        if (iVar10 < 1) {
		          uVar14 = 0;
		        }
		        else {
		          uVar16 = System_Data_DataSet__ReadXmlSchema
		                             (iVar7,iVar10 + 1,(*(int *)(iVar7 + 8) - iVar10) + -2,0);
		          iVar11 = System_Collections_CollectionBase___ctor(uVar16,StringLiteral_27784,0);
		          uVar14 = StringLiteral_16380;
		          local_c = System_String__Remove(iVar7,iVar10,0);
		          if (iVar11 == 0) {
		            uVar14 = uVar16;
		          }
		        }
		      }
		      iVar7 = I2_Loc_LanguageSourceData_TypeInfo;
		      if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LanguageSourceData_TypeInfo);
		      }
		      I2_Loc_LanguageSourceData__RemoveTerm(&local_c,iVar7);
		      iVar10 = local_c;
		      iVar11 = func_ii_4769(local_c,0);
		      if (iVar11 == 0) {
		        iVar7 = func_ii_13851(param1,iVar10,0,iVar7);
		        if (iVar7 == 0) {
		          iVar11 = 0;
		          iVar7 = unnamed_function_1417(I2_Loc_TermData_TypeInfo);
		          I2_Loc_TermData__HasSpecializations(iVar7,0);
		          *(int *)(iVar7 + 8) = iVar10;
		          uVar16 = Mono_Security_ASN1Convert__ToOid
		                             (string___TypeInfo,*(undefined4 *)(*(int *)(param1 + 0x24) + 0xc));
		          *(undefined4 *)(iVar7 + 0x14) = uVar16;
		          uVar16 = Mono_Security_ASN1Convert__ToOid
		                             (byte___TypeInfo,*(undefined4 *)(*(int *)(param1 + 0x24) + 0xc));
		          *(undefined4 *)(iVar7 + 0x18) = uVar16;
		          if (0 < *(int *)(*(int *)(param1 + 0x24) + 0xc)) {
		            do {
		              *(undefined4 *)(*(int *)(iVar7 + 0x14) + iVar11 * 4 + 0x10) =
		                   **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		              iVar11 = iVar11 + 1;
		            } while (iVar11 < *(int *)(*(int *)(param1 + 0x24) + 0xc));
		          }
		          iVar11 = Method_System_Collections_Generic_List_TermData__Add__;
		          iVar12 = *(int *)(param1 + 0x10);
		          *(int *)(iVar12 + 0x10) = *(int *)(iVar12 + 0x10) + 1;
		          uVar15 = *(uint *)(iVar12 + 0xc);
		          if (uVar15 < *(uint *)(*(int *)(iVar12 + 8) + 0xc)) {
		            *(uint *)(iVar12 + 0xc) = uVar15 + 1;
		            *(int *)(*(int *)(iVar12 + 8) + uVar15 * 4 + 0x10) = iVar7;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (iVar12,iVar7,*(undefined4 *)(*(int *)(*(int *)(iVar11 + 0x10) + 0x60) + 0x38)
		                      );
		          }
		          System_Reflection_FieldInfo__get_IsStatic
		                    (*(undefined4 *)(param1 + 0x18),iVar10,iVar7,
		                     Method_System_Collections_Generic_Dictionary_string__TermData__Add__);
		        }
		        else if (param4 == 3) goto code_r0x81c95b37;
		        if (0 < iVar2) {
		          uVar16 = *(undefined4 *)(iVar9 + iVar2 * 4 + 0x10);
		          if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_LanguageSourceData_TypeInfo);
		          }
		          uVar16 = I2_Loc_LanguageSourceData__ArrayContains(uVar16,uVar16);
		          *(undefined4 *)(iVar7 + 0xc) = uVar16;
		        }
		        if (0 < iVar13) {
		          *(undefined4 *)(iVar7 + 0x10) = *(undefined4 *)(iVar9 + iVar13 * 4 + 0x10);
		        }
		        iVar10 = 0;
		        if (0 < *(int *)(iVar8 + 0xc)) {
		          do {
		            if (*(int *)(iVar9 + 0xc) - iVar5 <= iVar10) break;
		            puVar3 = (undefined4 *)(iVar9 + (iVar10 + iVar5) * 4 + 0x10);
		            iVar11 = func_ii_4769(*puVar3,0);
		            if ((iVar11 == 0) && (iVar11 = *(int *)(iVar8 + iVar10 * 4 + 0x10), -1 < iVar11)) {
		              uVar16 = *puVar3;
		              iVar12 = System_Collections_CollectionBase___ctor(uVar16,StringLiteral_1331,0);
		              if (iVar12 == 0) {
		                iVar12 = System_Collections_CollectionBase___ctor(uVar16,StringLiteral_5,0);
		                param3_00 = 0;
		                if (iVar12 == 0) {
		                  param3_00 = uVar16;
		                }
		              }
		              else {
		                param3_00 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		              }
		              I2_Loc_LanguageSourceData__AddTerm(iVar7,iVar11,param3_00,uVar14,0);
		            }
		            iVar10 = iVar10 + 1;
		          } while (iVar10 < *(int *)(iVar8 + 0xc));
		        }
		      }
		code_r0x81c95b37:
		      iVar6 = iVar6 + 1;
		    } while (iVar6 != iVar4);
		  }
		  if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Application_TypeInfo);
		  }
		  iVar4 = func_ii_3441(0);
		  if (iVar4 != 0) {
		    iVar4 = 0;
		    if (DAT_ram_00a604b0 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		      Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__)
		      ;
		      DAT_ram_00a604b0 = '\x01';
		    }
		    iVar5 = *(int *)(param1 + 0x24);
		    if (*(int *)(iVar5 + 0xc) < 1) {
		      uVar15 = 0;
		    }
		    else {
		      do {
		        iVar5 = System_Linq_Enumerable__ToList_object_
		                          (iVar5,iVar4,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        uVar15 = (*(byte *)(iVar5 + 0x10) & 4) >> 2;
		        if (uVar15 != 0) break;
		        iVar4 = iVar4 + 1;
		        iVar5 = *(int *)(param1 + 0x24);
		      } while (iVar4 < *(int *)(iVar5 + 0xc));
		    }
		    I2_Loc_I2Utils__IsPlaying(param1,uVar15,iVar4,iVar4);
		  }
		  puVar3 = *(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		code_r0x81c95bf5:
		  return *puVar3;
		}
		*/

			return null;
		}

		// Token: 0x06007662 RID: 30306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007662")]
		[Address(RVA = "0xBFDD", Offset = "0xBFDD", VA = "0xBFDD")]
		public static void ValidateFullTerm(ref string Term)
		{
		/* --- GHIDRA: ValidateFullTerm ---
		undefined4 I2_Loc_LocalizationReader__ValidateFullTerm(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a604cb == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_47);
		    Mono_Security_ASN1__get_Item(&StringLiteral_92);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2140);
		    Mono_Security_ASN1__get_Item(&StringLiteral_91);
		    DAT_ram_00a604cb = '\x01';
		  }
		  iVar1 = func_ii_4769(param1,0);
		  if (iVar1 != 0) {
		    return **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  }
		  uVar2 = func_ii_7088(param1,StringLiteral_92,StringLiteral_2140,0);
		  uVar2 = func_ii_7088(uVar2,StringLiteral_91,StringLiteral_2140,0);
		  uVar2 = func_ii_7088(uVar2,StringLiteral_47,StringLiteral_2140,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x06007663 RID: 30307 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007663")]
		[Address(RVA = "0xBFDE", Offset = "0xBFDE", VA = "0xBFDE")]
		public static string EncodeString(string str)
		{
		/* --- GHIDRA: EncodeString ---
		undefined4 I2_Loc_LocalizationReader__EncodeString(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a604cc == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_92);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2140);
		    DAT_ram_00a604cc = '\x01';
		  }
		  iVar1 = func_ii_4769(param1,0);
		  if (iVar1 != 0) {
		    return **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  }
		  uVar2 = func_ii_7088(param1,StringLiteral_2140,StringLiteral_92,0);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06007664 RID: 30308 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007664")]
		[Address(RVA = "0xBFDF", Offset = "0xBFDF", VA = "0xBFDF")]
		public static string DecodeString(string str)
		{
			return null;
		}

		// Token: 0x06007665 RID: 30309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007665")]
		[Address(RVA = "0xBFE0", Offset = "0xBFE0", VA = "0xBFE0")]
		public LocalizationReader()
		{
		}
	}
}
