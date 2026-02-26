using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001358 RID: 4952
	[Token(Token = "0x2001358")]
	public static class GoogleLanguages
	{
		// Token: 0x0600758E RID: 30094 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600758E")]
		[Address(RVA = "0xBF1E", Offset = "0xBF1E", VA = "0xBF1E")]
		public static string GetLanguageCode(string Filter, bool ShowWarnings = false)
		{
		/* --- GHIDRA: GetLanguageCode ---
		int I2_Loc_GoogleLanguages__GetLanguageCode(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  uint uVar9;
		  int iVar10;
		  int local_4c;
		  undefined1 *puStack_48;
		  undefined8 local_44;
		  undefined8 local_3c;
		  undefined8 local_34;
		  undefined4 local_2c;
		  undefined1 local_28 [8];
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a5972e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleLanguages_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_string__GoogleLanguages_LanguageCodeDef__get_Key__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_string__GoogleLanguages_LanguageCodeDef__get_Value__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Insert__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_264);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    Mono_Security_ASN1__get_Item(&StringLiteral_184);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18830);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19094);
		    DAT_ram_00a5972e = '\x01';
		  }
		  uVar3 = System_Globalization_TextInfo__ToTitleCase(param1,0);
		  uVar4 = I2_Loc_StringObfucator__XoREncode(StringLiteral_184,0);
		  uVar3 = Facebook_Unity_FBLocation__FromDictionary(uVar3,uVar4,0);
		  iVar5 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar5,Method_System_Collections_Generic_List_string___ctor__);
		  if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_Skin_SkinEntry__int___FindEntry
		            (&local_4c,**(undefined4 **)(I2_Loc_GoogleLanguages_TypeInfo + 0x5c),
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__GetEnumerator__
		            );
		  local_8 = local_2c;
		  local_10 = local_34;
		  local_18 = local_3c;
		  local_20 = local_44;
		  local_4c = 0;
		  puStack_48 = local_28;
		code_r0x810546df:
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x356,local_28,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__MoveNext__
		                      );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810549ed;
		    }
		    if (iVar6 == 0) {
		      iVar6 = 5;
		      iVar10 = local_4c;
		      goto code_r0x81054a3a;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar7 = (undefined4)local_18;
		    uVar4 = local_20._4_4_;
		    iVar6 = func_ii_4769(param1,0);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810549ed;
		    }
		    if (iVar6 == 0) {
		      iVar10 = I2_Loc_GoogleLanguages_TypeInfo;
		      if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   I2_Loc_GoogleLanguages_TypeInfo);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x810549ed;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x357,uVar4,uVar3,iVar10)
		      ;
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810549ed;
		      }
		      if (iVar6 == 0) goto code_r0x810546df;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1b1,string___TypeInfo,1);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810549ed;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x26e,StringLiteral_18830,
		                       uVar7,StringLiteral_19094,0);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810549ed;
		    }
		    *(undefined4 *)(iVar6 + 0x10) = uVar7;
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x236,iVar6,0)
		    ;
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810549ed;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x359,param2,uVar7,0);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810549ed;
		    }
		    if (iVar6 == 0) {
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_iiiii
		                        (s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x26e,uVar4,
		                         StringLiteral_118,uVar7,0);
		      iVar10 = Method_System_Collections_Generic_List_string__Add__;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x810549e5;
		      *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		      uVar9 = *(uint *)(iVar5 + 0xc);
		      if (uVar9 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		        *(uint *)(iVar5 + 0xc) = uVar9 + 1;
		        *(undefined4 *)(*(int *)(iVar5 + 8) + uVar9 * 4 + 0x10) = uVar4;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar5,uVar4,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x810549e5:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810549ed:
		          iVar10 = global_1;
		          iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar10 == iVar6) {
		            piVar8 = (int *)import::env::__cxa_begin_catch(uVar3);
		            iVar10 = *piVar8;
		            iVar6 = 0;
		            DAT_ram_009d3e38 = 0;
		            local_4c = iVar10;
		            import::env::invoke_v(0x123);
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 != 1) {
		code_r0x81054a3a:
		              DAT_ram_009d3e38 = 0;
		              if (iVar10 == 0) {
		                if (((iVar6 == 0) ||
		                    ((((iVar6 != 1 && (iVar6 != 2)) && (iVar6 != 3)) &&
		                     ((iVar6 != 4 && (iVar6 == 5)))))) &&
		                   (iVar10 = *(int *)(iVar5 + 0xc) + -2, -1 < iVar10)) {
		                  do {
		                    uVar3 = System_Linq_Enumerable__ToList_object_
		                                      (iVar5,iVar10,
		                                       Method_System_Collections_Generic_List_string__get_Item__);
		                    uVar4 = System_Linq_Enumerable__ToList_object_
		                                      (iVar5,iVar10,
		                                       Method_System_Collections_Generic_List_string__get_Item__);
		                    uVar4 = UnityEngine_WWWTranscoder__SevenBitClean(uVar4,StringLiteral_264,0);
		                    uVar3 = System_Data_DataSet__ReadXmlSchema(uVar3,0,uVar4,0);
		                    uVar4 = System_Linq_Enumerable__ToList_object_
		                                      (iVar5,iVar10 + 1,
		                                       Method_System_Collections_Generic_List_string__get_Item__);
		                    iVar6 = System_String__Substring(uVar4,uVar3,4,0);
		                    if (iVar6 != 0) {
		                      uVar4 = System_Linq_Enumerable__ToList_object_
		                                        (iVar5,iVar10,
		                                         Method_System_Collections_Generic_List_string__get_Item__);
		                      uVar4 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                                        (uVar3,StringLiteral_1618,uVar4,0);
		                      System_Collections_Generic_List_UsageHint___get_Item
		                                (iVar5,iVar10,uVar4,
		                                 Method_System_Collections_Generic_List_string__set_Item__);
		                      uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor
		                                        (uVar3,StringLiteral_1618,0);
		                      System_Collections_Generic_List_IntPtr___AddWithResize
		                                (iVar5,iVar10 + 1,uVar3,
		                                 Method_System_Collections_Generic_List_string__Insert__);
		                    }
		                    bVar1 = 0 < iVar10;
		                    iVar10 = iVar10 + -1;
		                  } while (bVar1);
		                }
		                return iVar5;
		              }
		              System_Data_DataSet__ValidateLocaleConstraint(iVar10);
		              do {
		                halt_trap();
		              } while( true );
		            }
		            uVar3 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x35a,&local_4c);
		          iVar5 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar5 == 1) {
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
		      }
		    }
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x0600758F RID: 30095 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600758F")]
		[Address(RVA = "0xBF1F", Offset = "0xBF1F", VA = "0xBF1F")]
		public static List<string> GetLanguagesForDropdown(string Filter, string CodesToExclude)
		{
		/* --- GHIDRA: GetLanguagesForDropdown ---
		undefined4 I2_Loc_GoogleLanguages__GetLanguagesForDropdown(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a59730 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_264);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1145);
		    Mono_Security_ASN1__get_Item(&StringLiteral_149);
		    DAT_ram_00a59730 = '\x01';
		  }
		  iVar1 = System_Xml_XmlTextEncoder__StartAttribute(param1,StringLiteral_264,4,0);
		  if (0 < iVar1) {
		    param1 = System_Data_DataSet__ReadXmlSchema(param1,0,iVar1,0);
		  }
		  iVar1 = System_Xml_Schema_XmlSchemaException___ctor(param1,0x2f,0);
		  if (iVar1 < 1) {
		    return param1;
		  }
		  param1_00 = System_Data_DataSet__ReadXmlSchema(param1,0,iVar1,0);
		  uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (param1_00,StringLiteral_1618,param1_00,0);
		  iVar1 = System_Collections_CollectionBase___ctor(param1,uVar2,0);
		  if (iVar1 == 0) {
		    uVar2 = func_ii_7088(param1,StringLiteral_1618,StringLiteral_149,0);
		    param1_00 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar2,StringLiteral_1145,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06007590 RID: 30096 RVA: 0x000152E8 File Offset: 0x000134E8
		[Token(Token = "0x6007590")]
		[Address(RVA = "0x1EDE", Offset = "0x1EDE", VA = "0x1EDE")]
		private static bool LanguageMatchesFilter(string Language, string[] Filters)
		{
			return default(bool);
		}

		// Token: 0x06007591 RID: 30097 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007591")]
		[Address(RVA = "0xBF20", Offset = "0xBF20", VA = "0xBF20")]
		public static string GetFormatedLanguageName(string Language)
		{
		/* --- GHIDRA: GetFormatedLanguageName ---
		void I2_Loc_GoogleLanguages__GetFormatedLanguageName
		               (undefined4 param1,undefined4 *param2,undefined4 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  uint param3_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a59732 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleLanguages_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18830);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19094);
		    DAT_ram_00a59732 = '\x01';
		  }
		  iVar1 = func_ii_4769(param1,0);
		  if (iVar1 != 0) {
		    *param2 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		    *param3 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		    return;
		  }
		  param3_00 = System_Xml_XmlTextEncoder__StartAttribute(param1,StringLiteral_18830,4,0);
		  if ((int)param3_00 < 0) {
		    *param2 = param1;
		    if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		    }
		    uVar2 = I2_Loc_EventCallback___ctor(param1,0,param1);
		    *param3 = uVar2;
		    return;
		  }
		  uVar2 = System_Data_DataSet__ReadXmlSchema(param1,0,param3_00,0);
		  uVar2 = System_Convert__FromBase64String(uVar2,0);
		  *param2 = uVar2;
		  iVar1 = func_ii_13789(param1,StringLiteral_19094,param3_00,4,0);
		  uVar2 = System_Data_DataSet__ReadXmlSchema
		                    (param1,param3_00 + 1,iVar1 + (param3_00 ^ 0xffffffff),0);
		  *param3 = uVar2;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06007592 RID: 30098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007592")]
		[Address(RVA = "0x35EE", Offset = "0x35EE", VA = "0x35EE")]
		public static string GetCodedLanguage(string Language, string code)
		{
			return null;
		}

		// Token: 0x06007593 RID: 30099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007593")]
		[Address(RVA = "0xBF21", Offset = "0xBF21", VA = "0xBF21")]
		public static void UnPackCodeFromLanguageName(string CodedLanguage, out string Language, out string code)
		{
		/* --- GHIDRA: UnPackCodeFromLanguageName ---
		undefined4
		I2_Loc_GoogleLanguages__UnPackCodeFromLanguageName
		          (undefined4 param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined1 auStack_50 [4];
		  int local_4c;
		  undefined1 *puStack_48;
		  undefined8 local_44;
		  undefined8 local_3c;
		  undefined8 local_34;
		  undefined4 local_2c;
		  undefined1 local_28 [8];
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a59734 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleLanguages_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_string__GoogleLanguages_LanguageCodeDef__get_Key__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_string__GoogleLanguages_LanguageCodeDef__get_Value__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_1331);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1145);
		    Mono_Security_ASN1__get_Item(&StringLiteral_149);
		    DAT_ram_00a59734 = '\x01';
		  }
		  if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_Skin_SkinEntry__int___FindEntry
		            (&local_4c,**(undefined4 **)(I2_Loc_GoogleLanguages_TypeInfo + 0x5c),
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__GetEnumerator__
		            );
		  local_8 = local_2c;
		  local_10 = local_34;
		  local_18 = local_3c;
		  local_20 = local_44;
		  local_4c = 0;
		  puStack_48 = local_28;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x356,local_28,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__MoveNext__
		                      );
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81055330;
		    }
		    if (iVar1 == 0) goto code_r0x810553d2;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_20._4_4_;
		    iVar1 = System_Collections_CollectionBase___ctor(param1,(undefined4)local_18,0);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) break;
		    if (iVar1 != 0) {
		      if (param2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return uVar2;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar1 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000f84 + 199,uVar2,0x2f,0);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        if (iVar1 < 1) {
		          DAT_ram_009d3e38 = 0;
		          return uVar2;
		        }
		        DAT_ram_009d3e38 = 0;
		        param2_00 = import::env::invoke_iiiii
		                              (s_struct_Uniforms___color__array<v_ram_000013c7 + 0xc1,uVar2,0,iVar1,
		                               0);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0xc5,uVar2,iVar1 + 1,
		                             0);
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            uVar2 = import::env::invoke_iiiiii
		                              (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1d9,param2_00,
		                               StringLiteral_149,uVar2,StringLiteral_1145,0);
		            iVar4 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar4 != 1) {
		              DAT_ram_009d3e38 = 0;
		              return uVar2;
		            }
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		        }
		      }
		code_r0x81055330:
		      iVar4 = global_1;
		      iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar4 == iVar1) {
		        piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar1 = *piVar3;
		        DAT_ram_009d3e38 = 0;
		        local_4c = iVar1;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		          if (iVar1 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x810553d2:
		          DAT_ram_009d3e38 = 0;
		          if (param3 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return 0;
		          }
		          iVar4 = System_Xml_XmlTextEncoder__StartAttribute(param1,StringLiteral_1331,4,0);
		          if (0 < iVar4) {
		            uVar2 = System_Data_DataSet__ReadXmlSchema(param1,0,iVar4,0);
		            if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		              func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		            }
		            uVar2 = I2_Loc_GoogleLanguages__UnPackCodeFromLanguageName(uVar2,param2,0,auStack_50);
		            return uVar2;
		          }
		          return 0;
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x35c,&local_4c);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__resumeException(uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x81055330;
		}
		*/

		}

		// Token: 0x06007594 RID: 30100 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007594")]
		[Address(RVA = "0x1EEA", Offset = "0x1EEA", VA = "0x1EEA")]
		public static string GetGoogleLanguageCode(string InternationalCode)
		{
		/* --- GHIDRA: GetGoogleLanguageCode ---
		int I2_Loc_GoogleLanguages__GetGoogleLanguageCode(int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param2_00;
		  int *param1_00;
		  int iVar2;
		  int iVar3;
		  uint uVar4;
		  int param2_01;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int local_c;
		  int *local_8;
		  int local_4;
		  
		  param2_01 = 0;
		  local_4 = param2;
		  if (DAT_ram_00a653df == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    DAT_ram_00a653df = '\x01';
		  }
		  local_c = 0;
		  if (param2 == 0) {
		    uVar5 = unnamed_function_2232(&System_ArgumentNullException_TypeInfo);
		    uVar5 = unnamed_function_1417(uVar5);
		    uVar6 = unnamed_function_2232(&StringLiteral_27468);
		    Mono_Security_X509_X509Certificate___ctor(uVar5,uVar6,0);
		    uVar6 = unnamed_function_2232(&Method_System_Globalization_TextInfo_ToTitleCase__);
		    func_ii_1050(uVar5,uVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(param2 + 8) != 0) {
		    param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		    func_ii_2101(param1_00,0);
		    local_8 = param1_00;
		    if (0 < *(int *)(param2 + 8)) {
		      param2_00 = 0;
		      do {
		        iVar2 = System_Globalization_CharUnicodeInfo__InternalGetUnicodeCategory
		                          (param2,param2_00,&local_c,0);
		        if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		          func_ii_306000(DAT_ram_00a66974);
		        }
		        iVar3 = System_Globalization_TextInfo__IsWordSeparator(iVar2,0);
		        if (iVar3 == 0) {
		joined_r0x8280d8ad:
		          if (local_c == 2) {
		            uVar5 = func_ii_3010(param2,param2_00,0);
		            func_ii_3135(param1_00,uVar5,0);
		            param2_00 = param2_00 + 1;
		          }
		          uVar5 = func_ii_3010(param2,param2_00,0);
		          func_ii_3135(param1_00,uVar5,0);
		        }
		        else {
		          bVar1 = iVar2 == 1;
		          iVar2 = System_Globalization_TextInfo__AddNonLetter
		                            (param1,&local_8,&local_4,param2_00,local_c,iVar2);
		          iVar2 = iVar2 + 1;
		          param2_00 = iVar2;
		          if (iVar2 < *(int *)(param2 + 8)) {
		            do {
		              while (uVar4 = System_Globalization_CharUnicodeInfo__InternalGetUnicodeCategory
		                                       (param2,param2_00,&local_c,0), 4 < uVar4) {
		                iVar3 = func_ii_3010(param2,param2_00,0);
		                if (iVar3 == 0x27) {
		                  param2_00 = param2_00 + 1;
		                  if (bVar1) {
		                    if (param2_01 == 0) {
		                      param2_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                                            (param1,param2,*(undefined4 *)(*param1 + 0x104));
		                    }
		                    System_Text_StringBuilder__AppendHelper
		                              (param1_00,param2_01,iVar2,param2_00 - iVar2,0);
		                  }
		                  else {
		                    System_Text_StringBuilder__AppendHelper
		                              (param1_00,param2,iVar2,param2_00 - iVar2,0);
		                  }
		                  bVar1 = true;
		                  iVar2 = param2_00;
		                  if (*(int *)(param2 + 8) <= param2_00) goto code_r0x8280d89b;
		                }
		                else if (((1 << (uVar4 & 0x1f) & 0x1ffcf800U) != 0) ||
		                        (param2_00 = local_c + param2_00, *(int *)(param2 + 8) <= param2_00))
		                goto code_r0x8280d841;
		              }
		              bVar1 = (bool)(uVar4 == 1 | bVar1);
		              param2_00 = local_c + param2_00;
		            } while (param2_00 < *(int *)(param2 + 8));
		          }
		code_r0x8280d841:
		          iVar3 = param2_00 - iVar2;
		          if (0 < iVar3) {
		            if (bVar1) {
		              if (param2_01 == 0) {
		                param2_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                                      (param1,param2,*(undefined4 *)(*param1 + 0x104));
		              }
		              System_Text_StringBuilder__AppendHelper(param1_00,param2_01,iVar2,iVar3,0);
		            }
		            else {
		              System_Text_StringBuilder__AppendHelper(param1_00,param2,iVar2,iVar3,0);
		            }
		          }
		code_r0x8280d89b:
		          if (param2_00 < *(int *)(param2 + 8)) goto joined_r0x8280d8ad;
		        }
		        param2_00 = param2_00 + 1;
		      } while (param2_00 < *(int *)(param2 + 8));
		    }
		    param2 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                       (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  }
		  return param2;
		}
		*/

			return null;
		}

		// Token: 0x06007595 RID: 30101 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007595")]
		[Address(RVA = "0xBF22", Offset = "0xBF22", VA = "0xBF22")]
		public static string GetLanguageName(string code, bool useParenthesesForRegion = false, bool allowDiscardRegion = true)
		{
		/* --- GHIDRA: GetLanguageName ---
		undefined4 I2_Loc_GoogleLanguages__GetLanguageName(undefined4 param1)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  int local_30;
		  undefined8 *local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a59735 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleLanguages_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_string__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_string__GoogleLanguages_LanguageCodeDef__get_Value__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_StringComparer_TypeInfo);
		    DAT_ram_00a59735 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  if (*(int *)(System_StringComparer_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_StringComparer_TypeInfo);
		  }
		  if (DAT_ram_00a6628f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_StringComparer_TypeInfo);
		    DAT_ram_00a6628f = '\x01';
		  }
		  if (*(int *)(System_StringComparer_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_StringComparer_TypeInfo);
		  }
		  uVar4 = *(undefined4 *)(*(int *)(System_StringComparer_TypeInfo + 0x5c) + 8);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_HashSet_string__TypeInfo);
		  System_Collections_Generic_HashSet_object____ctor
		            (param1_00,uVar4,Method_System_Collections_Generic_HashSet_string___ctor__);
		  if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_Skin_SkinEntry__int___FindEntry
		            (&local_28,**(undefined4 **)(I2_Loc_GoogleLanguages_TypeInfo + 0x5c),
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__GetEnumerator__
		            );
		  local_30 = 0;
		  local_2c = &local_28;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x356,&local_28,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81055646;
		    }
		    if (iVar2 == 0) goto code_r0x8105569c;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x19d,param1_00,
		               (undefined4)local_18,Method_System_Collections_Generic_HashSet_string__Add__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81055646:
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar2 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_30 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x8105569c:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		      Sirenix_Utilities_LinqExtensions__Convert_object_
		                (uVar4,param1_00,Method_System_Collections_Generic_List_string___ctor__);
		      return uVar4;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x35d,&local_30);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06007596 RID: 30102 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007596")]
		[Address(RVA = "0xBF23", Offset = "0xBF23", VA = "0xBF23")]
		public static List<string> GetAllInternationalCodes()
		{
		/* --- GHIDRA: GetAllInternationalCodes ---
		uint I2_Loc_GoogleLanguages__GetAllInternationalCodes(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  uint uVar5;
		  int local_30;
		  undefined8 *local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  byte local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a59736 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleLanguages_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_string__GoogleLanguages_LanguageCodeDef__get_Value__
		              );
		    DAT_ram_00a59736 = '\x01';
		  }
		  local_8 = 0;
		  _local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_Skin_SkinEntry__int___FindEntry
		            (&local_28,**(undefined4 **)(I2_Loc_GoogleLanguages_TypeInfo + 0x5c),
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__GetEnumerator__
		            );
		  local_30 = 0;
		  local_2c = &local_28;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x356,&local_28,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810558c4:
		      iVar1 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar2) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar2 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_30 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar2 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return 0;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x35e,&local_30);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        import::env::__resumeException(uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return 0;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = (uint)local_10;
		    uVar3 = (undefined4)local_18;
		    iVar2 = System_Collections_CollectionBase___ctor(param1,local_18._4_4_,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810558c4;
		    }
		    if (iVar2 != 0) break;
		    DAT_ram_009d3e38 = 0;
		    iVar2 = System_Collections_CollectionBase___ctor(param1,uVar3,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810558c4;
		    }
		  } while (iVar2 == 0);
		  DAT_ram_009d3e38 = 0;
		  return uVar5 & 1;
		}
		*/

			return null;
		}

		// Token: 0x06007597 RID: 30103 RVA: 0x00015300 File Offset: 0x00013500
		[Token(Token = "0x6007597")]
		[Address(RVA = "0xBF24", Offset = "0xBF24", VA = "0xBF24")]
		public static bool LanguageCode_HasJoinedWord(string languageCode)
		{
		/* --- GHIDRA: LanguageCode_HasJoinedWord ---
		undefined4 I2_Loc_GoogleLanguages__LanguageCode_HasJoinedWord(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int local_30;
		  undefined8 *local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a59737 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleLanguages_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_string__GoogleLanguages_LanguageCodeDef__get_Value__
		              );
		    DAT_ram_00a59737 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  if (2 < *(int *)(param1 + 8)) {
		    param1 = System_Data_DataSet__ReadXmlSchema(param1,0,2,0);
		  }
		  uVar3 = func_ii_7775(param1,0);
		  if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_Skin_SkinEntry__int___FindEntry
		            (&local_28,**(undefined4 **)(I2_Loc_GoogleLanguages_TypeInfo + 0x5c),
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__GetEnumerator__
		            );
		  local_30 = 0;
		  local_2c = &local_28;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x356,&local_28,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_string__GoogleLanguages_LanguageCodeDef__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81055b19:
		      iVar1 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar4 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_30 = iVar4;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar4 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return 0;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x35f,&local_30);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        import::env::__resumeException(uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (iVar4 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return 0;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_10._4_4_;
		    iVar4 = System_Collections_CollectionBase___ctor((undefined4)local_18,uVar3,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81055b19;
		    }
		    if (iVar4 != 0) {
		      DAT_ram_009d3e38 = 0;
		      return uVar2;
		    }
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x06007598 RID: 30104 RVA: 0x00015318 File Offset: 0x00013518
		[Token(Token = "0x6007598")]
		[Address(RVA = "0xBF25", Offset = "0xBF25", VA = "0xBF25")]
		private static int GetPluralRule(string langCode)
		{
		/* --- GHIDRA: GetPluralRule ---
		undefined4
		I2_Loc_GoogleLanguages__GetPluralRule(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a59738 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleLanguages_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8001);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16532);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12433);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11967);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10857);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18792);
		    DAT_ram_00a59738 = '\x01';
		  }
		  iVar2 = System_Collections_CollectionBase___ctor(param2,StringLiteral_12433,0);
		  if (iVar2 != 0) {
		    return 1;
		  }
		  iVar2 = System_Collections_CollectionBase___ctor(param2,StringLiteral_18792,0);
		  if (iVar2 != 0) {
		    return 1;
		  }
		  iVar2 = System_Collections_CollectionBase___ctor(param2,StringLiteral_11967,0);
		  if (iVar2 != 0) {
		    return 1;
		  }
		  if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		  }
		  puVar1 = &StringLiteral_8001;
		  iVar2 = I2_Loc_GoogleLanguages__LanguageCode_HasJoinedWord(param1,param2);
		  if (iVar2 == 3) {
		    iVar2 = System_Collections_CollectionBase___ctor(param2,StringLiteral_16532,0);
		  }
		  else {
		    if ((((iVar2 == 4) || (iVar2 == 5)) || (iVar2 == 6)) || ((iVar2 == 7 || (iVar2 == 8))))
		    goto code_r0x81055d3d;
		    if (iVar2 == 9) {
		      iVar2 = System_Collections_CollectionBase___ctor(param2,StringLiteral_16532,0);
		      goto joined_r0x81055d30;
		    }
		    if ((iVar2 == 10) || (iVar2 == 0xb)) {
		code_r0x81055cdd:
		      iVar2 = System_Collections_CollectionBase___ctor(param2,StringLiteral_16532,0);
		      if (iVar2 != 0) {
		        return 1;
		      }
		      iVar2 = System_Collections_CollectionBase___ctor(param2,StringLiteral_8001,0);
		    }
		    else {
		      if (iVar2 != 0xc) {
		        if (iVar2 == 0xd) {
		          puVar1 = &StringLiteral_16532;
		          goto code_r0x81055d3d;
		        }
		        if (iVar2 == 0xe) {
		          return 0;
		        }
		        if ((iVar2 != 0xf) && (iVar2 != 0x10)) {
		          return 0;
		        }
		        goto code_r0x81055cdd;
		      }
		      iVar2 = System_Collections_CollectionBase___ctor(param2,StringLiteral_8001,0);
		    }
		    puVar1 = &StringLiteral_10857;
		  }
		joined_r0x81055d30:
		  if (iVar2 != 0) {
		    return 1;
		  }
		code_r0x81055d3d:
		  uVar3 = System_Collections_CollectionBase___ctor(param2,*puVar1,0);
		  return uVar3;
		}
		*/

			return 0;
		}

		// Token: 0x06007599 RID: 30105 RVA: 0x00015330 File Offset: 0x00013530
		[Token(Token = "0x6007599")]
		[Address(RVA = "0xBF26", Offset = "0xBF26", VA = "0xBF26")]
		public static bool LanguageHasPluralType(string langCode, string pluralType)
		{
		/* --- GHIDRA: LanguageHasPluralType ---
		int I2_Loc_GoogleLanguages__LanguageHasPluralType(undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a59739 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleLanguages_TypeInfo);
		    DAT_ram_00a59739 = '\x01';
		  }
		  iVar1 = param2;
		  if (param2 != 0) {
		    if (param2 == 1) {
		      iVar1 = 1;
		    }
		    else {
		      if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		      }
		      iVar1 = 5;
		      iVar2 = I2_Loc_GoogleLanguages__LanguageCode_HasJoinedWord(param1,param2);
		      if (iVar2 == 2) {
		        uVar3 = 5;
		        if (param2 < 2) {
		          uVar3 = 1;
		        }
		        return uVar3;
		      }
		      if (iVar2 == 3) {
		        if (param2 == 2) {
		          return 2;
		        }
		        if ((((param2 != 3) && (param2 != 4)) && (param2 != 5)) &&
		           (((param2 != 6 && (param2 != 7)) && ((param2 != 8 && ((param2 != 9 && (param2 != 10))))))
		           )) {
		          if (param2 == 0xb) {
		            return 1;
		          }
		          if (param2 == 0xc) {
		            return 2;
		          }
		        }
		        if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		        }
		        if (7 < param2 - 3U) {
		          if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		          }
		          if (6 < param2 - 0xdU) {
		            return 5;
		          }
		        }
		        return 3;
		      }
		      if (iVar2 == 4) {
		        if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		        }
		        uVar3 = 3;
		        if (0x12 < param2 % 100 - 1U) {
		          uVar3 = 5;
		        }
		        return uVar3;
		      }
		      if (iVar2 == 5) {
		        if (param2 % 10 == 1) {
		          uVar3 = 5;
		          if (param2 % 100 != 0xb) {
		            uVar3 = 1;
		          }
		          return uVar3;
		        }
		        if (1 < param2 % 10) {
		          uVar3 = 3;
		          if (0xfffffff5 < param2 % 100 - 0x14U) {
		            uVar3 = 5;
		          }
		          return uVar3;
		        }
		      }
		      else if (iVar2 == 6) {
		        iVar1 = 1;
		        if (param2 % 10 != 1 || param2 % 100 == 0xb) {
		          if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		          }
		          iVar1 = 5;
		          if (param2 % 10 - 2U < 3) {
		            if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		              func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		            }
		            uVar3 = 3;
		            if (0xfffffffc < param2 % 100 - 0xfU) {
		              uVar3 = 5;
		            }
		            return uVar3;
		          }
		        }
		      }
		      else {
		        if (iVar2 == 7) {
		          if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		          }
		          uVar3 = 3;
		          if (2 < param2 - 2U) {
		            uVar3 = 5;
		          }
		          return uVar3;
		        }
		        if (iVar2 == 8) {
		          if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		          }
		          iVar1 = 5;
		          if (param2 % 10 - 2U < 3) {
		            if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		              func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		            }
		            uVar3 = 3;
		            if (0xfffffffc < param2 % 100 - 0xfU) {
		              uVar3 = 5;
		            }
		            return uVar3;
		          }
		        }
		        else if (iVar2 == 9) {
		          iVar1 = param2 % 100;
		          if (iVar1 != 1) {
		            if (iVar1 == 2) {
		              return 2;
		            }
		            if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		              func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		            }
		            uVar3 = 3;
		            if (1 < iVar1 - 3U) {
		              uVar3 = 5;
		            }
		            return uVar3;
		          }
		          iVar1 = 1;
		        }
		        else if (iVar2 == 10) {
		          iVar1 = 2;
		          if (param2 != 2) {
		            if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		              func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		            }
		            iVar1 = 3;
		            if (param2 - 7U < 0xfffffffc) {
		              if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		                func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		              }
		              uVar3 = 4;
		              if (3 < param2 - 7U) {
		                uVar3 = 5;
		              }
		              return uVar3;
		            }
		          }
		        }
		        else if (iVar2 == 0xb) {
		          iVar1 = 2;
		          if (param2 != 2) {
		            if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		              func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		            }
		            iVar1 = 3;
		            if (param2 % 100 - 0xbU < 0xfffffff8) {
		              uVar3 = 4;
		              if (param2 % 100 < 0xb) {
		                uVar3 = 5;
		              }
		              return uVar3;
		            }
		          }
		        }
		        else if (iVar2 == 0xc) {
		          if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		          }
		          uVar4 = param2 % 100 - 0xb;
		          iVar1 = 3;
		          if (uVar4 < 0xfffffff6) {
		            if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		              func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		            }
		            uVar3 = 4;
		            if (8 < uVar4) {
		              uVar3 = 5;
		            }
		            return uVar3;
		          }
		        }
		        else if (iVar2 == 0xd) {
		          iVar1 = 1;
		          if (param2 % 10 != 1) {
		            uVar3 = 2;
		            if (param2 % 10 != 2) {
		              uVar3 = 5;
		            }
		            return uVar3;
		          }
		        }
		        else if (iVar2 == 0xe) {
		          if (param2 % 10 == 1) {
		            uVar3 = 5;
		            if (param2 % 100 != 0xb) {
		              uVar3 = 1;
		            }
		            return uVar3;
		          }
		        }
		        else {
		          if (iVar2 == 0xf) {
		            iVar1 = param2 % 10;
		            if (iVar1 == 1) {
		              iVar1 = param2 % 100;
		              if (((iVar1 != 0xb) && (iVar1 != 0x47)) && (iVar1 != 0x5b)) {
		                return 1;
		              }
		            }
		            else if (iVar1 == 2) {
		              iVar1 = param2 % 100;
		              if (((iVar1 != 0xc) && (iVar1 != 0x48)) && (iVar1 != 0x5c)) {
		                return 2;
		              }
		            }
		            else if ((((iVar1 == 3) || (iVar1 == 4)) ||
		                     ((iVar1 != 5 &&
		                      ((((iVar1 != 6 && (iVar1 != 7)) && (iVar1 != 8)) && (iVar1 == 9)))))) &&
		                    ((iVar1 = param2 % 100, iVar1 != 0xd && (iVar1 != 0xe)))) {
		              if (iVar1 == 0xf) {
		                return 3;
		              }
		              if (iVar1 == 0x10) {
		                return 3;
		              }
		              if (iVar1 == 0x11) {
		                return 3;
		              }
		              if (iVar1 == 0x12) {
		                return 3;
		              }
		              if (iVar1 != 0x13) {
		                if (iVar1 == 0x14) {
		                  return 3;
		                }
		                if (iVar1 == 0x15) {
		                  return 3;
		                }
		                if (iVar1 == 0x16) {
		                  return 3;
		                }
		                if (iVar1 == 0x17) {
		                  return 3;
		                }
		                if (iVar1 == 0x18) {
		                  return 3;
		                }
		                if (iVar1 == 0x19) {
		                  return 3;
		                }
		                if (iVar1 == 0x1a) {
		                  return 3;
		                }
		                if (iVar1 == 0x1b) {
		                  return 3;
		                }
		                if (iVar1 == 0x1c) {
		                  return 3;
		                }
		                if (iVar1 == 0x1d) {
		                  return 3;
		                }
		                if (iVar1 == 0x1e) {
		                  return 3;
		                }
		                if (iVar1 == 0x1f) {
		                  return 3;
		                }
		                if (iVar1 == 0x20) {
		                  return 3;
		                }
		                if (iVar1 == 0x21) {
		                  return 3;
		                }
		                if (iVar1 == 0x22) {
		                  return 3;
		                }
		                if (iVar1 == 0x23) {
		                  return 3;
		                }
		                if (iVar1 == 0x24) {
		                  return 3;
		                }
		                if (iVar1 == 0x25) {
		                  return 3;
		                }
		                if (iVar1 == 0x26) {
		                  return 3;
		                }
		                if (iVar1 == 0x27) {
		                  return 3;
		                }
		                if (iVar1 == 0x28) {
		                  return 3;
		                }
		                if (iVar1 == 0x29) {
		                  return 3;
		                }
		                if (iVar1 == 0x2a) {
		                  return 3;
		                }
		                if (iVar1 == 0x2b) {
		                  return 3;
		                }
		                if (iVar1 == 0x2c) {
		                  return 3;
		                }
		                if (iVar1 == 0x2d) {
		                  return 3;
		                }
		                if (iVar1 == 0x2e) {
		                  return 3;
		                }
		                if (iVar1 == 0x2f) {
		                  return 3;
		                }
		                if (iVar1 == 0x30) {
		                  return 3;
		                }
		                if (iVar1 == 0x31) {
		                  return 3;
		                }
		                if (iVar1 == 0x32) {
		                  return 3;
		                }
		                if (iVar1 == 0x33) {
		                  return 3;
		                }
		                if (iVar1 == 0x34) {
		                  return 3;
		                }
		                if (iVar1 == 0x35) {
		                  return 3;
		                }
		                if (iVar1 == 0x36) {
		                  return 3;
		                }
		                if (iVar1 == 0x37) {
		                  return 3;
		                }
		                if (iVar1 == 0x38) {
		                  return 3;
		                }
		                if (iVar1 == 0x39) {
		                  return 3;
		                }
		                if (iVar1 == 0x3a) {
		                  return 3;
		                }
		                if (iVar1 == 0x3b) {
		                  return 3;
		                }
		                if (iVar1 == 0x3c) {
		                  return 3;
		                }
		                if (iVar1 == 0x3d) {
		                  return 3;
		                }
		                if (iVar1 == 0x3e) {
		                  return 3;
		                }
		                if (iVar1 == 0x3f) {
		                  return 3;
		                }
		                if (iVar1 == 0x40) {
		                  return 3;
		                }
		                if (iVar1 == 0x41) {
		                  return 3;
		                }
		                if (iVar1 == 0x42) {
		                  return 3;
		                }
		                if (iVar1 == 0x43) {
		                  return 3;
		                }
		                if (iVar1 == 0x44) {
		                  return 3;
		                }
		                if (iVar1 == 0x45) {
		                  return 3;
		                }
		                if (iVar1 == 0x46) {
		                  return 3;
		                }
		                if (iVar1 == 0x47) {
		                  return 3;
		                }
		                if (iVar1 == 0x48) {
		                  return 3;
		                }
		                if ((iVar1 != 0x49) && (iVar1 != 0x4a)) {
		                  if (iVar1 == 0x4b) {
		                    return 3;
		                  }
		                  if (iVar1 == 0x4c) {
		                    return 3;
		                  }
		                  if (iVar1 == 0x4d) {
		                    return 3;
		                  }
		                  if (iVar1 == 0x4e) {
		                    return 3;
		                  }
		                  if (iVar1 != 0x4f) {
		                    if (iVar1 == 0x50) {
		                      return 3;
		                    }
		                    if (iVar1 == 0x51) {
		                      return 3;
		                    }
		                    if (iVar1 == 0x52) {
		                      return 3;
		                    }
		                    if (iVar1 == 0x53) {
		                      return 3;
		                    }
		                    if (iVar1 == 0x54) {
		                      return 3;
		                    }
		                    if (iVar1 == 0x55) {
		                      return 3;
		                    }
		                    if (iVar1 == 0x56) {
		                      return 3;
		                    }
		                    if (iVar1 == 0x57) {
		                      return 3;
		                    }
		                    if (iVar1 == 0x58) {
		                      return 3;
		                    }
		                    if (iVar1 == 0x59) {
		                      return 3;
		                    }
		                    if (iVar1 == 0x5a) {
		                      return 3;
		                    }
		                    if (iVar1 == 0x5b) {
		                      return 3;
		                    }
		                    if (iVar1 == 0x5c) {
		                      return 3;
		                    }
		                    if ((iVar1 != 0x5d) && (iVar1 != 0x5e)) {
		                      if (iVar1 == 0x5f) {
		                        return 3;
		                      }
		                      if (iVar1 == 0x60) {
		                        return 3;
		                      }
		                      if (iVar1 == 0x61) {
		                        return 3;
		                      }
		                      if (iVar1 == 0x62) {
		                        return 3;
		                      }
		                      if (iVar1 != 99) {
		                        return 3;
		                      }
		                    }
		                  }
		                }
		              }
		            }
		            uVar3 = 5;
		            if (param2 % 1000000 == 0) {
		              uVar3 = 4;
		            }
		            return uVar3;
		          }
		          if (iVar2 == 0x10) {
		            if (param2 == 2) {
		              return 2;
		            }
		            iVar1 = param2;
		            if (param2 != 3) {
		              uVar3 = 4;
		              if (param2 != 6) {
		                uVar3 = 5;
		              }
		              return uVar3;
		            }
		          }
		        }
		      }
		    }
		  }
		  return iVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600759A RID: 30106 RVA: 0x00015348 File Offset: 0x00013548
		[Token(Token = "0x600759A")]
		[Address(RVA = "0xBF27", Offset = "0xBF27", VA = "0xBF27")]
		public static ePluralType GetPluralType(string langCode, int n)
		{
		/* --- GHIDRA: GetPluralType ---
		int I2_Loc_GoogleLanguages__GetPluralType(undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined *puVar2;
		  
		  if (DAT_ram_00a5973a == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleLanguages_TypeInfo);
		    DAT_ram_00a5973a = '\x01';
		  }
		  iVar1 = I2_Loc_GoogleLanguages_TypeInfo;
		  if ((param2 != 0) && (param2 != 1)) {
		    if (param2 == 2) {
		      return 0x3a8;
		    }
		    if (param2 != 3) {
		      if (param2 != 4) {
		        return 0x3a8;
		      }
		      if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		      }
		      iVar1 = I2_Loc_GoogleLanguages__LanguageCode_HasJoinedWord(param1,iVar1);
		      if (2 < iVar1 - 10U) {
		        puVar2 = &DAT_ram_000f4240;
		        if (iVar1 != 0xf) {
		          puVar2 = (undefined *)0x6;
		        }
		        return (int)puVar2;
		      }
		      param2 = *(int *)(&DAT_ram_005a3664 + (iVar1 - 10U) * 4);
		    }
		  }
		  return param2;
		}
		*/

			return ePluralType.Zero;
		}

		// Token: 0x0600759B RID: 30107 RVA: 0x00015360 File Offset: 0x00013560
		[Token(Token = "0x600759B")]
		[Address(RVA = "0xBF28", Offset = "0xBF28", VA = "0xBF28")]
		public static int GetPluralTestNumber(string langCode, ePluralType pluralType)
		{
		/* --- GHIDRA: GetPluralTestNumber ---
		uint I2_Loc_GoogleLanguages__GetPluralTestNumber(int param1,int param2,int param3,undefined4 param4)
		
		{
		  return (uint)(param1 <= param3 && param2 <= param1);
		}
		*/

			return 0;
		}

		// Token: 0x0600759C RID: 30108 RVA: 0x00015378 File Offset: 0x00013578
		[Token(Token = "0x600759C")]
		[Address(RVA = "0xBF29", Offset = "0xBF29", VA = "0xBF29")]
		private static bool inRange(int amount, int min, int max)
		{
		/* --- GHIDRA: inRange ---
		void I2_Loc_GoogleLanguages__inRange(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  undefined4 param2;
		  ulonglong local_1100;
		  undefined8 local_10f8;
		  undefined8 local_10f0;
		  undefined8 local_10e8;
		  ulonglong local_10e0;
		  undefined8 local_10d8;
		  ulonglong local_10d0;
		  undefined8 local_10c8;
		  ulonglong local_10c0;
		  undefined8 local_10b8;
		  ulonglong local_10b0;
		  undefined8 local_10a8;
		  undefined8 local_10a0;
		  undefined8 local_1098;
		  ulonglong local_1090;
		  undefined8 local_1088;
		  undefined8 local_1080;
		  undefined8 local_1078;
		  undefined8 local_1070;
		  undefined8 local_1068;
		  ulonglong local_1060;
		  undefined8 local_1058;
		  undefined8 local_1050;
		  undefined8 local_1048;
		  ulonglong local_1040;
		  undefined8 local_1038;
		  ulonglong local_1030;
		  undefined8 local_1028;
		  ulonglong local_1020;
		  undefined8 local_1018;
		  undefined8 local_1010;
		  undefined8 local_1008;
		  undefined8 local_1000;
		  undefined8 local_ff8;
		  undefined8 local_ff0;
		  undefined8 local_fe8;
		  undefined8 local_fe0;
		  undefined8 local_fd8;
		  ulonglong local_fd0;
		  undefined8 local_fc8;
		  undefined8 local_fc0;
		  undefined8 local_fb8;
		  undefined8 local_fb0;
		  undefined8 local_fa8;
		  ulonglong local_fa0;
		  undefined8 local_f98;
		  undefined8 local_f90;
		  undefined8 local_f88;
		  undefined8 local_f80;
		  undefined8 local_f78;
		  undefined8 local_f70;
		  undefined8 local_f68;
		  ulonglong local_f60;
		  undefined8 local_f58;
		  ulonglong local_f50;
		  undefined8 local_f48;
		  ulonglong local_f40;
		  undefined8 local_f38;
		  undefined8 local_f30;
		  undefined8 local_f28;
		  ulonglong local_f20;
		  undefined8 local_f18;
		  undefined8 local_f10;
		  undefined8 local_f08;
		  undefined8 local_f00;
		  undefined8 local_ef8;
		  ulonglong local_ef0;
		  undefined8 local_ee8;
		  undefined8 local_ee0;
		  undefined8 local_ed8;
		  ulonglong local_ed0;
		  undefined8 local_ec8;
		  ulonglong local_ec0;
		  undefined8 local_eb8;
		  undefined8 local_eb0;
		  undefined8 local_ea8;
		  undefined8 local_ea0;
		  undefined8 local_e98;
		  undefined8 local_e90;
		  undefined8 local_e88;
		  undefined8 local_e80;
		  undefined8 local_e78;
		  undefined8 local_e70;
		  undefined8 local_e68;
		  undefined8 local_e60;
		  undefined8 local_e58;
		  undefined8 local_e50;
		  undefined8 local_e48;
		  undefined8 local_e40;
		  undefined8 local_e38;
		  undefined8 local_e30;
		  undefined8 local_e28;
		  undefined8 local_e20;
		  undefined8 local_e18;
		  undefined8 local_e10;
		  undefined8 local_e08;
		  undefined8 local_e00;
		  undefined8 local_df8;
		  undefined8 local_df0;
		  undefined8 local_de8;
		  undefined8 local_de0;
		  undefined8 local_dd8;
		  undefined8 local_dd0;
		  undefined8 local_dc8;
		  undefined8 local_dc0;
		  undefined8 local_db8;
		  undefined8 local_db0;
		  undefined8 local_da8;
		  undefined8 local_da0;
		  undefined8 local_d98;
		  undefined8 local_d90;
		  undefined8 local_d88;
		  undefined8 local_d80;
		  undefined8 local_d78;
		  undefined8 local_d70;
		  undefined8 local_d68;
		  ulonglong local_d60;
		  undefined8 local_d58;
		  ulonglong local_d50;
		  undefined8 local_d48;
		  ulonglong local_d40;
		  undefined8 local_d38;
		  ulonglong local_d30;
		  undefined8 local_d28;
		  ulonglong local_d20;
		  undefined8 local_d18;
		  ulonglong local_d10;
		  undefined8 local_d08;
		  ulonglong local_d00;
		  undefined8 local_cf8;
		  ulonglong local_cf0;
		  undefined8 local_ce8;
		  undefined8 local_ce0;
		  undefined8 local_cd8;
		  undefined8 local_cd0;
		  undefined8 local_cc8;
		  ulonglong local_cc0;
		  undefined8 local_cb8;
		  undefined8 local_cb0;
		  undefined8 local_ca8;
		  ulonglong local_ca0;
		  undefined8 local_c98;
		  undefined8 local_c90;
		  undefined8 local_c88;
		  ulonglong local_c80;
		  undefined8 local_c78;
		  undefined8 local_c70;
		  undefined8 local_c68;
		  undefined8 local_c60;
		  undefined8 local_c58;
		  undefined8 local_c50;
		  undefined8 local_c48;
		  ulonglong local_c40;
		  undefined8 local_c38;
		  undefined8 local_c30;
		  undefined8 local_c28;
		  ulonglong local_c20;
		  undefined8 local_c18;
		  undefined8 local_c10;
		  undefined8 local_c08;
		  undefined8 local_c00;
		  undefined8 local_bf8;
		  undefined8 local_bf0;
		  undefined8 local_be8;
		  undefined8 local_be0;
		  undefined8 local_bd8;
		  undefined8 local_bd0;
		  undefined8 local_bc8;
		  ulonglong local_bc0;
		  undefined8 local_bb8;
		  undefined8 local_bb0;
		  undefined8 local_ba8;
		  undefined8 local_ba0;
		  undefined8 local_b98;
		  ulonglong local_b90;
		  undefined8 local_b88;
		  ulonglong local_b80;
		  undefined8 local_b78;
		  ulonglong local_b70;
		  undefined8 local_b68;
		  ulonglong local_b60;
		  undefined8 local_b58;
		  undefined8 local_b50;
		  undefined8 local_b48;
		  undefined8 local_b40;
		  undefined8 local_b38;
		  undefined8 local_b30;
		  undefined8 local_b28;
		  undefined8 local_b20;
		  undefined8 local_b18;
		  undefined8 local_b10;
		  undefined8 local_b08;
		  undefined8 local_b00;
		  undefined8 local_af8;
		  undefined8 local_af0;
		  undefined8 local_ae8;
		  undefined8 local_ae0;
		  undefined8 local_ad8;
		  undefined8 local_ad0;
		  undefined8 local_ac8;
		  undefined8 local_ac0;
		  undefined8 local_ab8;
		  undefined8 local_ab0;
		  undefined8 local_aa8;
		  undefined8 local_aa0;
		  undefined8 local_a98;
		  undefined8 local_a90;
		  undefined8 local_a88;
		  ulonglong local_a80;
		  undefined8 local_a78;
		  undefined8 local_a70;
		  undefined8 local_a68;
		  undefined8 local_a60;
		  undefined8 local_a58;
		  undefined8 local_a50;
		  undefined8 local_a48;
		  ulonglong local_a40;
		  undefined8 local_a38;
		  undefined8 local_a30;
		  undefined8 local_a28;
		  ulonglong local_a20;
		  undefined8 local_a18;
		  ulonglong local_a10;
		  undefined8 local_a08;
		  ulonglong local_a00;
		  undefined8 local_9f8;
		  ulonglong local_9f0;
		  undefined8 local_9e8;
		  undefined8 local_9e0;
		  undefined8 local_9d8;
		  undefined8 local_9d0;
		  undefined8 local_9c8;
		  ulonglong local_9c0;
		  undefined8 local_9b8;
		  ulonglong local_9b0;
		  undefined8 local_9a8;
		  ulonglong local_9a0;
		  undefined8 local_998;
		  undefined8 local_990;
		  undefined8 local_988;
		  ulonglong local_980;
		  undefined8 local_978;
		  undefined8 local_970;
		  undefined8 local_968;
		  ulonglong local_960;
		  undefined8 local_958;
		  ulonglong local_950;
		  undefined8 local_948;
		  undefined8 local_940;
		  undefined8 local_938;
		  undefined8 local_930;
		  undefined8 local_928;
		  undefined8 local_920;
		  undefined8 local_918;
		  ulonglong local_910;
		  undefined8 local_908;
		  ulonglong local_900;
		  undefined8 local_8f8;
		  undefined8 local_8f0;
		  undefined8 local_8e8;
		  ulonglong local_8e0;
		  undefined8 local_8d8;
		  ulonglong local_8d0;
		  undefined8 local_8c8;
		  undefined8 local_8c0;
		  undefined8 local_8b8;
		  undefined8 local_8b0;
		  undefined8 local_8a8;
		  ulonglong local_8a0;
		  undefined8 local_898;
		  undefined8 local_890;
		  undefined8 local_888;
		  undefined8 local_880;
		  undefined8 local_878;
		  ulonglong local_870;
		  undefined8 local_868;
		  ulonglong local_860;
		  undefined8 local_858;
		  undefined8 local_850;
		  undefined8 local_848;
		  undefined8 local_840;
		  undefined8 local_838;
		  ulonglong local_830;
		  undefined8 local_828;
		  undefined8 local_820;
		  undefined8 local_818;
		  ulonglong local_810;
		  undefined8 local_808;
		  ulonglong local_800;
		  undefined8 local_7f8;
		  undefined8 local_7f0;
		  undefined8 local_7e8;
		  undefined8 local_7e0;
		  undefined8 local_7d8;
		  undefined8 local_7d0;
		  undefined8 local_7c8;
		  ulonglong local_7c0;
		  undefined8 local_7b8;
		  ulonglong local_7b0;
		  undefined8 local_7a8;
		  undefined8 local_7a0;
		  undefined8 local_798;
		  undefined8 local_790;
		  undefined8 local_788;
		  ulonglong local_780;
		  undefined8 local_778;
		  ulonglong local_770;
		  undefined8 local_768;
		  undefined8 local_760;
		  undefined8 local_758;
		  ulonglong local_750;
		  undefined8 local_748;
		  undefined8 local_740;
		  undefined8 local_738;
		  ulonglong local_730;
		  undefined8 local_728;
		  undefined8 local_720;
		  undefined8 local_718;
		  ulonglong local_710;
		  undefined8 local_708;
		  undefined8 local_700;
		  undefined8 local_6f8;
		  undefined8 local_6f0;
		  undefined8 local_6e8;
		  ulonglong local_6e0;
		  undefined8 local_6d8;
		  ulonglong local_6d0;
		  undefined8 local_6c8;
		  ulonglong local_6c0;
		  undefined8 local_6b8;
		  undefined8 local_6b0;
		  undefined8 local_6a8;
		  ulonglong local_6a0;
		  undefined8 local_698;
		  undefined8 local_690;
		  undefined8 local_688;
		  undefined8 local_680;
		  undefined8 local_678;
		  undefined8 local_670;
		  undefined8 local_668;
		  undefined8 local_660;
		  undefined8 local_658;
		  undefined8 local_650;
		  undefined8 local_648;
		  ulonglong local_640;
		  undefined8 local_638;
		  ulonglong local_630;
		  undefined8 local_628;
		  undefined8 local_620;
		  undefined8 local_618;
		  ulonglong local_610;
		  undefined8 local_608;
		  undefined8 local_600;
		  undefined8 local_5f8;
		  undefined8 local_5f0;
		  undefined8 local_5e8;
		  undefined8 local_5e0;
		  undefined8 local_5d8;
		  undefined8 local_5d0;
		  undefined8 local_5c8;
		  undefined8 local_5c0;
		  undefined8 local_5b8;
		  undefined8 local_5b0;
		  undefined8 local_5a8;
		  undefined8 local_5a0;
		  undefined8 local_598;
		  ulonglong local_590;
		  undefined8 local_588;
		  ulonglong local_580;
		  undefined8 local_578;
		  undefined8 local_570;
		  undefined8 local_568;
		  undefined8 local_560;
		  undefined8 local_558;
		  undefined8 local_550;
		  undefined8 local_548;
		  ulonglong local_540;
		  undefined8 local_538;
		  ulonglong local_530;
		  undefined8 local_528;
		  undefined8 local_520;
		  undefined8 local_518;
		  undefined8 local_510;
		  undefined8 local_508;
		  undefined8 local_500;
		  undefined8 local_4f8;
		  undefined8 local_4f0;
		  undefined8 local_4e8;
		  undefined8 local_4e0;
		  undefined8 local_4d8;
		  undefined8 local_4d0;
		  undefined8 local_4c8;
		  undefined8 local_4c0;
		  undefined8 local_4b8;
		  undefined8 local_4b0;
		  undefined8 local_4a8;
		  undefined8 local_4a0;
		  undefined8 local_498;
		  undefined8 local_490;
		  undefined8 local_488;
		  undefined8 local_480;
		  undefined8 local_478;
		  undefined8 local_470;
		  undefined8 local_468;
		  undefined8 local_460;
		  undefined8 local_458;
		  ulonglong local_450;
		  undefined8 local_448;
		  undefined8 local_440;
		  undefined8 local_438;
		  undefined8 local_430;
		  undefined8 local_428;
		  undefined8 local_420;
		  undefined8 local_418;
		  ulonglong local_410;
		  undefined8 local_408;
		  undefined8 local_400;
		  undefined8 local_3f8;
		  ulonglong local_3f0;
		  undefined8 local_3e8;
		  ulonglong local_3e0;
		  undefined8 local_3d8;
		  undefined8 local_3d0;
		  undefined8 local_3c8;
		  ulonglong local_3c0;
		  undefined8 local_3b8;
		  undefined8 local_3b0;
		  undefined8 local_3a8;
		  ulonglong local_3a0;
		  undefined8 local_398;
		  undefined8 local_390;
		  undefined8 local_388;
		  undefined8 local_380;
		  undefined8 local_378;
		  undefined8 local_370;
		  undefined8 local_368;
		  undefined8 local_360;
		  undefined8 local_358;
		  undefined8 local_350;
		  undefined8 local_348;
		  undefined8 local_340;
		  undefined8 local_338;
		  undefined8 local_330;
		  undefined8 local_328;
		  undefined8 local_320;
		  undefined8 local_318;
		  undefined8 local_310;
		  undefined8 local_308;
		  undefined8 local_300;
		  undefined8 local_2f8;
		  ulonglong local_2f0;
		  undefined8 local_2e8;
		  undefined8 local_2e0;
		  undefined8 local_2d8;
		  undefined8 local_2d0;
		  undefined8 local_2c8;
		  ulonglong local_2c0;
		  undefined8 local_2b8;
		  ulonglong local_2b0;
		  undefined8 local_2a8;
		  ulonglong local_2a0;
		  undefined8 local_298;
		  undefined8 local_290;
		  undefined8 local_288;
		  ulonglong local_280;
		  undefined8 local_278;
		  undefined8 local_270;
		  undefined8 local_268;
		  undefined8 local_260;
		  undefined8 local_258;
		  ulonglong local_250;
		  undefined8 local_248;
		  ulonglong local_240;
		  undefined8 local_238;
		  undefined8 local_230;
		  undefined8 local_228;
		  ulonglong local_220;
		  undefined8 local_218;
		  undefined8 local_210;
		  undefined8 local_208;
		  undefined8 local_200;
		  undefined8 local_1f8;
		  ulonglong local_1f0;
		  undefined8 local_1e8;
		  undefined8 local_1e0;
		  undefined8 local_1d8;
		  undefined8 local_1d0;
		  undefined8 local_1c8;
		  undefined8 local_1c0;
		  undefined8 local_1b8;
		  undefined8 local_1b0;
		  undefined8 local_1a8;
		  ulonglong local_1a0;
		  undefined8 local_198;
		  undefined8 local_190;
		  undefined8 local_188;
		  undefined8 local_180;
		  undefined8 local_178;
		  undefined8 local_170;
		  undefined8 local_168;
		  undefined8 local_160;
		  undefined8 local_158;
		  undefined8 local_150;
		  undefined8 local_148;
		  undefined8 local_140;
		  undefined8 local_138;
		  undefined8 local_130;
		  undefined8 local_128;
		  undefined8 local_120;
		  undefined8 local_118;
		  undefined8 local_110;
		  undefined8 local_108;
		  undefined8 local_100;
		  undefined8 local_f8;
		  undefined8 local_f0;
		  undefined8 local_e8;
		  undefined8 local_e0;
		  undefined8 local_d8;
		  undefined8 local_d0;
		  undefined8 local_c8;
		  undefined8 local_c0;
		  undefined8 local_b8;
		  undefined8 local_b0;
		  undefined8 local_a8;
		  undefined8 local_a0;
		  undefined8 local_98;
		  undefined8 local_90;
		  undefined8 local_88;
		  ulonglong local_80;
		  undefined8 local_78;
		  ulonglong local_70;
		  undefined8 local_68;
		  ulonglong local_60;
		  undefined8 local_58;
		  undefined8 local_50;
		  undefined8 local_48;
		  ulonglong local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  uint local_10;
		  uint local_c;
		  undefined1 local_8;
		  undefined2 local_7;
		  undefined1 local_5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5973b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleLanguages_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_StringComparer_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10509);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26594);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14524);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24206);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25149);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14093);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19804);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24276);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10373);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26265);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27740);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14509);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13657);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14432);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25500);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27920);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23005);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25100);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27886);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22547);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20508);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26510);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3906);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3221);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14522);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5821);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19947);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8158);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28487);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20682);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24896);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6076);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14361);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28305);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16509);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8795);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25046);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14775);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14774);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25010);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19909);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25098);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25597);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9192);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25475);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25774);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19763);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5384);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22994);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3806);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12480);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19900);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28529);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21074);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26207);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22761);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24998);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22999);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10273);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10841);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24977);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15316);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26263);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24868);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10881);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14526);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20766);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10274);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10218);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10680);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14513);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19905);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11388);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23257);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24525);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8906);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24466);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24403);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10683);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25533);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26208);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19903);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14460);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22991);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27134);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27712);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13632);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10004);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28545);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17300);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26529);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9466);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19906);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28236);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3213);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22899);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10842);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22166);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27694);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24973);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14508);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12862);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13683);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24205);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21090);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7345);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14051);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7492);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27738);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10868);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24694);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3224);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13688);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14486);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10222);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25711);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3223);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14770);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17672);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14053);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25214);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25216);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22765);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5408);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22894);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10001);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10074);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10220);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8476);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14303);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10082);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28455);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22852);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2998);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25666);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25008);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24971);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22897);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20429);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1331);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7341);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23002);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27359);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23258);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23006);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5390);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16215);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14515);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7333);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3876);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7336);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12054);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14525);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3845);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5974);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24398);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26264);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25940);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5968);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9481);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22550);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22993);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20745);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24269);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23003);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24987);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19743);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8466);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8631);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8414);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10856);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23001);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8181);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10851);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27303);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14430);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5087);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27364);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14780);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12302);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26542);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4020);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6691);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19913);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27815);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24513);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8478);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25503);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22854);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3216);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22889);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13050);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3813);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24523);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18201);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5409);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23198);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6702);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13046);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20032);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3953);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28363);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25761);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3228);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19657);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25474);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22891);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24949);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9484);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22987);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3229);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14481);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28538);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20583);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26535);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8069);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25148);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3772);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4016);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7897);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19899);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8475);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14776);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7547);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25492);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8468);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26205);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11598);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8159);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22132);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5971);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13051);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27736);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25381);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22886);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27377);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8175);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23014);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2810);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8821);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22992);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23228);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14332);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25596);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25588);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3219);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23151);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8034);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23004);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25379);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24982);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3225);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14523);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27642);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24980);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26078);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25969);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5803);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9340);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22986);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5107);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16529);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3226);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25667);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8444);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14512);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15366);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24947);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24894);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8477);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20629);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22996);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25604);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6688);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22551);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12052);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16501);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24314);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22484);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3222);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3466);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22549);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16511);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24870);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14517);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27363);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27876);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27241);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9205);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7338);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16212);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23321);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25020);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7335);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17397);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8865);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23000);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5376);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7344);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5389);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27534);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14514);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3227);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14050);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26262);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19902);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8412);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28272);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19907);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7340);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2952);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3986);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19898);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24263);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12448);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23152);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22888);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19904);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17888);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11378);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13052);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19910);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14355);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27691);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26508);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25006);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26209);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24471);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8474);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22896);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14519);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14214);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27889);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20506);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5367);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3315);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5356);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24397);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27369);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8625);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2951);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12481);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24497);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24517);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3259);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8861);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27614);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3196);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24370);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9223);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8154);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25439);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10858);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7342);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5386);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22052);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7334);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28533);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23015);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27932);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14518);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19790);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27529);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27742);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22988);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25736);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15415);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8824);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27530);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26601);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17841);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24999);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3843);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14511);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27290);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11875);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7494);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14520);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20031);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16861);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24483);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11597);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22997);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11845);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20489);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3507);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17746);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10261);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27877);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5387);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28537);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23302);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20025);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22104);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23259);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16895);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21018);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18445);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28316);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22885);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28539);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3473);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26528);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22014);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25712);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5385);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27531);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24699);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15306);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6583);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27375);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27261);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25537);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17695);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25536);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22882);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11599);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14510);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3214);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27499);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25598);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3811);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18826);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10837);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10005);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19912);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26506);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23260);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8157);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10838);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16349);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3042);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23120);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5316);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11381);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10818);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15308);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22893);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17934);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23009);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14215);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7337);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6262);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22884);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26087);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14527);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8751);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13690);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14047);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28137);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3508);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22548);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24869);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22989);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14482);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10499);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22898);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23263);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14521);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22546);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7316);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5388);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12056);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14507);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9789);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19751);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25873);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24978);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21390);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10843);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25441);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10268);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11203);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12228);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15310);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22995);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27305);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15354);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28485);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14779);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26558);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10484);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25601);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22998);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24207);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20513);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22964);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28203);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23288);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18463);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7343);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10277);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22887);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11603);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25382);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28530);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18795);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25443);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6692);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16502);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12477);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24984);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11600);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23261);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10358);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25472);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19908);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27207);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24340);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12367);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3215);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24473);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2999);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10281);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19911);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25007);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25218);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19901);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3218);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11415);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14516);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24886);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19914);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3220);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8607);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25476);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8147);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14209);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10282);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10221);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10374);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19655);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7339);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22990);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23262);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9465);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10270);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28534);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8156);
		    DAT_ram_00a5973b = '\x01';
		  }
		  if (*(int *)(System_StringComparer_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_StringComparer_TypeInfo);
		  }
		  if (DAT_ram_00a6628f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_StringComparer_TypeInfo);
		    DAT_ram_00a6628f = '\x01';
		  }
		  if (*(int *)(System_StringComparer_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_StringComparer_TypeInfo);
		  }
		  param2 = *(undefined4 *)(*(int *)(System_StringComparer_TypeInfo + 0x5c) + 8);
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData____ctor
		            (param1_00,param2,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef___ctor__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_18 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_19657;
		  local_20 = CONCAT44(StringLiteral_1331,StringLiteral_19657);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_2810,&local_20,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_28 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_19655;
		  local_30 = CONCAT44(StringLiteral_1331,StringLiteral_19655);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_2951,&local_30,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_38 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_19751;
		  local_40 = (ulonglong)StringLiteral_19751;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_2952,&local_40,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_48 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_19763;
		  local_50 = CONCAT44(StringLiteral_1331,StringLiteral_19763);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_2998,&local_50,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_58 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_27359;
		  local_60 = (ulonglong)StringLiteral_27359;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_2999,&local_60,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_68 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_19790;
		  local_70 = (ulonglong)StringLiteral_19790;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3042,&local_70,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0xb;
		  local_7 = 0;
		  local_78 = 0xb00000000;
		  local_c = 0;
		  local_10 = StringLiteral_19898;
		  local_80 = (ulonglong)StringLiteral_19898;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3196,&local_80,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0xb;
		  local_7 = 0;
		  local_88 = 0xb00000000;
		  local_c = StringLiteral_19898;
		  local_10 = StringLiteral_19901;
		  local_90 = CONCAT44(StringLiteral_19898,StringLiteral_19901);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3213,&local_90,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0xb;
		  local_7 = 0;
		  local_98 = 0xb00000000;
		  local_c = StringLiteral_19898;
		  local_10 = StringLiteral_19900;
		  local_a0 = CONCAT44(StringLiteral_19898,StringLiteral_19900);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3214,&local_a0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0xb;
		  local_7 = 0;
		  local_a8 = 0xb00000000;
		  local_c = StringLiteral_19898;
		  local_10 = StringLiteral_19902;
		  local_b0 = CONCAT44(StringLiteral_19898,StringLiteral_19902);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3215,&local_b0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0xb;
		  local_7 = 0;
		  local_b8 = 0xb00000000;
		  local_c = StringLiteral_19898;
		  local_10 = StringLiteral_19903;
		  local_c0 = CONCAT44(StringLiteral_19898,StringLiteral_19903);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3216,&local_c0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0xb;
		  local_7 = 0;
		  local_c8 = 0xb00000000;
		  local_c = StringLiteral_19898;
		  local_10 = StringLiteral_19904;
		  local_d0 = CONCAT44(StringLiteral_19898,StringLiteral_19904);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3217,&local_d0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0xb;
		  local_7 = 0;
		  local_d8 = 0xb00000000;
		  local_c = StringLiteral_19898;
		  local_10 = StringLiteral_19905;
		  local_e0 = CONCAT44(StringLiteral_19898,StringLiteral_19905);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3218,&local_e0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0xb;
		  local_7 = 0;
		  local_e8 = 0xb00000000;
		  local_c = StringLiteral_19898;
		  local_10 = StringLiteral_19906;
		  local_f0 = CONCAT44(StringLiteral_19898,StringLiteral_19906);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3219,&local_f0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0xb;
		  local_7 = 0;
		  local_f8 = 0xb00000000;
		  local_c = StringLiteral_19898;
		  local_10 = StringLiteral_19907;
		  local_100 = CONCAT44(StringLiteral_19898,StringLiteral_19907);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3220,&local_100,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0xb;
		  local_7 = 0;
		  local_108 = 0xb00000000;
		  local_c = StringLiteral_19898;
		  local_10 = StringLiteral_19908;
		  local_110 = CONCAT44(StringLiteral_19898,StringLiteral_19908);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3221,&local_110,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0xb;
		  local_7 = 0;
		  local_118 = 0xb00000000;
		  local_c = StringLiteral_19898;
		  local_10 = StringLiteral_19909;
		  local_120 = CONCAT44(StringLiteral_19898,StringLiteral_19909);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3222,&local_120,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0xb;
		  local_7 = 0;
		  local_128 = 0xb00000000;
		  local_c = StringLiteral_19898;
		  local_10 = StringLiteral_19910;
		  local_130 = CONCAT44(StringLiteral_19898,StringLiteral_19910);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3223,&local_130,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0xb;
		  local_7 = 0;
		  local_138 = 0xb00000000;
		  local_c = StringLiteral_19898;
		  local_10 = StringLiteral_19911;
		  local_140 = CONCAT44(StringLiteral_19898,StringLiteral_19911);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3224,&local_140,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0xb;
		  local_7 = 0;
		  local_148 = 0xb00000000;
		  local_c = StringLiteral_19898;
		  local_10 = StringLiteral_19912;
		  local_150 = CONCAT44(StringLiteral_19898,StringLiteral_19912);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3225,&local_150,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0xb;
		  local_7 = 0;
		  local_158 = 0xb00000000;
		  local_c = StringLiteral_19898;
		  local_10 = StringLiteral_19913;
		  local_160 = CONCAT44(StringLiteral_19898,StringLiteral_19913);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3226,&local_160,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0xb;
		  local_7 = 0;
		  local_168 = 0xb00000000;
		  local_c = StringLiteral_19898;
		  local_10 = StringLiteral_19899;
		  local_170 = CONCAT44(StringLiteral_19898,StringLiteral_19899);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3227,&local_170,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0xb;
		  local_7 = 0;
		  local_178 = 0xb00000000;
		  local_c = StringLiteral_19898;
		  local_10 = StringLiteral_19914;
		  local_180 = CONCAT44(StringLiteral_19898,StringLiteral_19914);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3228,&local_180,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_188 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_19804;
		  local_190 = CONCAT44(StringLiteral_1331,StringLiteral_19804);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3229,&local_190,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_198 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_24471;
		  local_1a0 = (ulonglong)StringLiteral_24471;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3259,&local_1a0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_1a8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_19947;
		  local_1b0 = CONCAT44(StringLiteral_1331,StringLiteral_19947);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3315,&local_1b0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_1b8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_20025;
		  local_1c0 = CONCAT44(StringLiteral_1331,StringLiteral_20025);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3466,&local_1c0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_1c8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_19743;
		  local_1d0 = CONCAT44(StringLiteral_1331,StringLiteral_19743);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3473,&local_1d0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_1d8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_20031;
		  local_1e0 = CONCAT44(StringLiteral_1331,StringLiteral_20031);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3507,&local_1e0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_1e8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_20032;
		  local_1f0 = (ulonglong)StringLiteral_20032;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3508,&local_1f0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_1f8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_20583;
		  local_200 = CONCAT44(StringLiteral_1331,StringLiteral_20583);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3772,&local_200,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_208 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_20429;
		  local_210 = CONCAT44(StringLiteral_1331,StringLiteral_20429);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3806,&local_210,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_218 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_23014;
		  local_220 = (ulonglong)StringLiteral_23014;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3811,&local_220,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_228 = 0x100000000;
		  local_c = StringLiteral_23014;
		  local_10 = StringLiteral_23015;
		  local_230 = CONCAT44(StringLiteral_23014,StringLiteral_23015);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3813,&local_230,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 6;
		  local_7 = 0;
		  local_238 = 0x600000000;
		  local_c = 0;
		  local_10 = StringLiteral_20489;
		  local_240 = (ulonglong)StringLiteral_20489;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3843,&local_240,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_248 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_20629;
		  local_250 = (ulonglong)StringLiteral_20629;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3845,&local_250,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_258 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_20508;
		  local_260 = CONCAT44(StringLiteral_1331,StringLiteral_20508);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3876,&local_260,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_268 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_20513;
		  local_270 = CONCAT44(StringLiteral_1331,StringLiteral_20513);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3906,&local_270,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 6;
		  local_7 = 0;
		  local_278 = 0x600000000;
		  local_c = 0;
		  local_10 = StringLiteral_20766;
		  local_280 = (ulonglong)StringLiteral_20766;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3953,&local_280,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_288 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_20745;
		  local_290 = CONCAT44(StringLiteral_1331,StringLiteral_20745);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_3986,&local_290,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_298 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_20506;
		  local_2a0 = (ulonglong)StringLiteral_20506;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_4016,&local_2a0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_2a8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_25500;
		  local_2b0 = (ulonglong)StringLiteral_25500;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_4020,&local_2b0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_2b8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_21018;
		  local_2c0 = (ulonglong)StringLiteral_21018;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_5087,&local_2c0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_2c8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_21090;
		  local_2d0 = CONCAT44(StringLiteral_1331,StringLiteral_21090);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_5316,&local_2d0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_2d8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_21074;
		  local_2e0 = CONCAT44(StringLiteral_1331,StringLiteral_21074);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_5356,&local_2e0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_2e8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_25712;
		  local_2f0 = (ulonglong)StringLiteral_25712;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_5367,&local_2f0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 1;
		  local_5 = 0;
		  local_4 = 0;
		  local_7 = 0;
		  local_2f8 = 1;
		  local_c = StringLiteral_28533;
		  local_10 = StringLiteral_28530;
		  local_300 = CONCAT44(StringLiteral_28533,StringLiteral_28530);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_5376,&local_300,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 1;
		  local_5 = 0;
		  local_4 = 0;
		  local_7 = 0;
		  local_308 = 1;
		  local_c = StringLiteral_28539;
		  local_10 = StringLiteral_28534;
		  local_310 = CONCAT44(StringLiteral_28539,StringLiteral_28534);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_5384,&local_310,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 1;
		  local_5 = 0;
		  local_4 = 0;
		  local_7 = 0;
		  local_318 = 1;
		  local_c = StringLiteral_28533;
		  local_10 = StringLiteral_28537;
		  local_320 = CONCAT44(StringLiteral_28533,StringLiteral_28537);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_5385,&local_320,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 1;
		  local_5 = 0;
		  local_4 = 0;
		  local_7 = 0;
		  local_328 = 1;
		  local_c = StringLiteral_28533;
		  local_10 = StringLiteral_28533;
		  local_330 = CONCAT44(StringLiteral_28533,StringLiteral_28533);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_5386,&local_330,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 1;
		  local_5 = 0;
		  local_4 = 0;
		  local_7 = 0;
		  local_338 = 1;
		  local_c = StringLiteral_28533;
		  local_10 = StringLiteral_28533;
		  local_340 = CONCAT44(StringLiteral_28533,StringLiteral_28533);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_5387,&local_340,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 1;
		  local_5 = 0;
		  local_4 = 0;
		  local_7 = 0;
		  local_348 = 1;
		  local_c = StringLiteral_28533;
		  local_10 = StringLiteral_28538;
		  local_350 = CONCAT44(StringLiteral_28533,StringLiteral_28538);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_5388,&local_350,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 1;
		  local_5 = 0;
		  local_4 = 0;
		  local_7 = 0;
		  local_358 = 1;
		  local_c = StringLiteral_28539;
		  local_10 = StringLiteral_28539;
		  local_360 = CONCAT44(StringLiteral_28539,StringLiteral_28539);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_5389,&local_360,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 1;
		  local_5 = 0;
		  local_4 = 0;
		  local_7 = 0;
		  local_368 = 1;
		  local_c = StringLiteral_28539;
		  local_10 = StringLiteral_28539;
		  local_370 = CONCAT44(StringLiteral_28539,StringLiteral_28539);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_5390,&local_370,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_378 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_22132;
		  local_380 = CONCAT44(StringLiteral_1331,StringLiteral_22132);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_5409,&local_380,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_388 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_25008;
		  local_390 = CONCAT44(StringLiteral_1331,StringLiteral_25008);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_5803,&local_390,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_398 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_21390;
		  local_3a0 = (ulonglong)StringLiteral_21390;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_5821,&local_3a0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_3a8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_22014;
		  local_3b0 = CONCAT44(StringLiteral_1331,StringLiteral_22014);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_5968,&local_3b0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 6;
		  local_7 = 0;
		  local_3b8 = 0x600000000;
		  local_c = 0;
		  local_10 = StringLiteral_24397;
		  local_3c0 = (ulonglong)StringLiteral_24397;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_5971,&local_3c0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 5;
		  local_7 = 0;
		  local_3c8 = 0x500000000;
		  local_c = StringLiteral_24397;
		  local_10 = StringLiteral_24398;
		  local_3d0 = CONCAT44(StringLiteral_24397,StringLiteral_24398);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_5974,&local_3d0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 7;
		  local_7 = 0;
		  local_3d8 = 0x700000000;
		  local_c = 0;
		  local_10 = StringLiteral_22052;
		  local_3e0 = (ulonglong)StringLiteral_22052;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_6076,&local_3e0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_3e8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_22484;
		  local_3f0 = (ulonglong)StringLiteral_22484;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_6262,&local_3f0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_3f8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_22761;
		  local_400 = CONCAT44(StringLiteral_1331,StringLiteral_22761);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_6583,&local_400,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_408 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_25596;
		  local_410 = (ulonglong)StringLiteral_25596;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_6688,&local_410,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_418 = 0x100000000;
		  local_c = StringLiteral_25596;
		  local_10 = StringLiteral_25597;
		  local_420 = CONCAT44(StringLiteral_25596,StringLiteral_25597);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_6691,&local_420,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_428 = 0x100000000;
		  local_c = StringLiteral_25596;
		  local_10 = StringLiteral_25598;
		  local_430 = CONCAT44(StringLiteral_25596,StringLiteral_25598);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_6692,&local_430,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_438 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_22765;
		  local_440 = CONCAT44(StringLiteral_1331,StringLiteral_22765);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_6702,&local_440,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_448 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_22882;
		  local_450 = (ulonglong)StringLiteral_22882;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_7316,&local_450,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_458 = 0x100000000;
		  local_c = StringLiteral_22882;
		  local_10 = StringLiteral_22884;
		  local_460 = CONCAT44(StringLiteral_22882,StringLiteral_22884);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_7333,&local_460,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_468 = 0x100000000;
		  local_c = StringLiteral_22882;
		  local_10 = StringLiteral_22885;
		  local_470 = CONCAT44(StringLiteral_22882,StringLiteral_22885);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_7334,&local_470,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_478 = 0x100000000;
		  local_c = StringLiteral_22882;
		  local_10 = StringLiteral_22886;
		  local_480 = CONCAT44(StringLiteral_22882,StringLiteral_22886);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_7335,&local_480,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_488 = 0x100000000;
		  local_c = StringLiteral_22882;
		  local_10 = StringLiteral_22887;
		  local_490 = CONCAT44(StringLiteral_22882,StringLiteral_22887);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_7336,&local_490,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_498 = 0x100000000;
		  local_c = StringLiteral_22882;
		  local_10 = StringLiteral_22889;
		  local_4a0 = CONCAT44(StringLiteral_22882,StringLiteral_22889);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_7337,&local_4a0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_4a8 = 0x100000000;
		  local_c = StringLiteral_22882;
		  local_10 = StringLiteral_22891;
		  local_4b0 = CONCAT44(StringLiteral_22882,StringLiteral_22891);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_7338,&local_4b0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_4b8 = 0x100000000;
		  local_c = StringLiteral_22882;
		  local_10 = StringLiteral_22893;
		  local_4c0 = CONCAT44(StringLiteral_22882,StringLiteral_22893);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_7339,&local_4c0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_4c8 = 0x100000000;
		  local_c = StringLiteral_22882;
		  local_10 = StringLiteral_22894;
		  local_4d0 = CONCAT44(StringLiteral_22882,StringLiteral_22894);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_7340,&local_4d0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_4d8 = 0x100000000;
		  local_c = StringLiteral_22882;
		  local_10 = StringLiteral_22898;
		  local_4e0 = CONCAT44(StringLiteral_22882,StringLiteral_22898);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_7341,&local_4e0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_4e8 = 0x100000000;
		  local_c = StringLiteral_22882;
		  local_10 = StringLiteral_22896;
		  local_4f0 = CONCAT44(StringLiteral_22882,StringLiteral_22896);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_7342,&local_4f0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_4f8 = 0x100000000;
		  local_c = StringLiteral_22882;
		  local_10 = StringLiteral_22888;
		  local_500 = CONCAT44(StringLiteral_22882,StringLiteral_22888);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_7343,&local_500,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_508 = 0x100000000;
		  local_c = StringLiteral_22882;
		  local_10 = StringLiteral_22897;
		  local_510 = CONCAT44(StringLiteral_22882,StringLiteral_22897);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_7344,&local_510,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_518 = 0x100000000;
		  local_c = StringLiteral_22882;
		  local_10 = StringLiteral_22899;
		  local_520 = CONCAT44(StringLiteral_22882,StringLiteral_22899);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_7345,&local_520,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_528 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_22964;
		  local_530 = (ulonglong)StringLiteral_22964;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_7492,&local_530,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_538 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_23009;
		  local_540 = (ulonglong)StringLiteral_23009;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_7494,&local_540,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_548 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_22852;
		  local_550 = CONCAT44(StringLiteral_1331,StringLiteral_22852);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_7547,&local_550,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_558 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_23228;
		  local_560 = CONCAT44(StringLiteral_1331,StringLiteral_23228);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_7897,&local_560,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_568 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_23198;
		  local_570 = CONCAT44(StringLiteral_1331,StringLiteral_23198);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8034,&local_570,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_578 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_23152;
		  local_580 = (ulonglong)StringLiteral_23152;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8069,&local_580,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 2;
		  local_7 = 0;
		  local_588 = 0x200000000;
		  local_c = 0;
		  local_10 = StringLiteral_23257;
		  local_590 = (ulonglong)StringLiteral_23257;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8147,&local_590,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 2;
		  local_7 = 0;
		  local_598 = 0x200000000;
		  local_c = StringLiteral_23257;
		  local_10 = StringLiteral_23258;
		  local_5a0 = CONCAT44(StringLiteral_23257,StringLiteral_23258);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8154,&local_5a0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 2;
		  local_7 = 0;
		  local_5a8 = 0x200000000;
		  local_c = StringLiteral_23257;
		  local_10 = StringLiteral_23259;
		  local_5b0 = CONCAT44(StringLiteral_23257,StringLiteral_23259);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8155,&local_5b0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 2;
		  local_7 = 0;
		  local_5b8 = 0x200000000;
		  local_c = StringLiteral_23257;
		  local_10 = StringLiteral_23261;
		  local_5c0 = CONCAT44(StringLiteral_23257,StringLiteral_23261);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8156,&local_5c0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 2;
		  local_7 = 0;
		  local_5c8 = 0x200000000;
		  local_c = StringLiteral_23257;
		  local_10 = StringLiteral_23262;
		  local_5d0 = CONCAT44(StringLiteral_23257,StringLiteral_23262);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8157,&local_5d0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 2;
		  local_7 = 0;
		  local_5d8 = 0x200000000;
		  local_c = StringLiteral_23257;
		  local_10 = StringLiteral_23263;
		  local_5e0 = CONCAT44(StringLiteral_23257,StringLiteral_23263);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8158,&local_5e0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 2;
		  local_7 = 0;
		  local_5e8 = 0x200000000;
		  local_c = StringLiteral_23257;
		  local_10 = StringLiteral_23260;
		  local_5f0 = CONCAT44(StringLiteral_23257,StringLiteral_23260);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8159,&local_5f0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_5f8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_23151;
		  local_600 = CONCAT44(StringLiteral_1331,StringLiteral_23151);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8181,&local_600,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_608 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_24205;
		  local_610 = (ulonglong)StringLiteral_24205;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8412,&local_610,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_618 = 0x100000000;
		  local_c = StringLiteral_24205;
		  local_10 = StringLiteral_24206;
		  local_620 = CONCAT44(StringLiteral_24205,StringLiteral_24206);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8414,&local_620,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0;
		  local_7 = 0;
		  local_628 = 0;
		  local_c = 0;
		  local_10 = StringLiteral_24949;
		  local_630 = (ulonglong)StringLiteral_24949;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8466,&local_630,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_638 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_22546;
		  local_640 = (ulonglong)StringLiteral_22546;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8468,&local_640,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_648 = 0x100000000;
		  local_c = StringLiteral_22546;
		  local_10 = StringLiteral_22547;
		  local_650 = CONCAT44(StringLiteral_22546,StringLiteral_22547);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8474,&local_650,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_658 = 0x100000000;
		  local_c = StringLiteral_22546;
		  local_10 = StringLiteral_22549;
		  local_660 = CONCAT44(StringLiteral_22546,StringLiteral_22549);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8475,&local_660,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_668 = 0x100000000;
		  local_c = StringLiteral_22546;
		  local_10 = StringLiteral_22550;
		  local_670 = CONCAT44(StringLiteral_22546,StringLiteral_22550);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8476,&local_670,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_678 = 0x100000000;
		  local_c = StringLiteral_22546;
		  local_10 = StringLiteral_22551;
		  local_680 = CONCAT44(StringLiteral_22546,StringLiteral_22551);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8477,&local_680,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_688 = 0x100000000;
		  local_c = StringLiteral_22546;
		  local_10 = StringLiteral_22548;
		  local_690 = CONCAT44(StringLiteral_22546,StringLiteral_22548);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8478,&local_690,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_698 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_22854;
		  local_6a0 = (ulonglong)StringLiteral_22854;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8607,&local_6a0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_6a8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_24207;
		  local_6b0 = CONCAT44(StringLiteral_1331,StringLiteral_24207);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8625,&local_6b0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_6b8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_24263;
		  local_6c0 = (ulonglong)StringLiteral_24263;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8631,&local_6c0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_6c8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_24403;
		  local_6d0 = (ulonglong)StringLiteral_24403;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8751,&local_6d0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_6d8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_24276;
		  local_6e0 = (ulonglong)StringLiteral_24276;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8795,&local_6e0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_6e8 = 0x100000000;
		  local_c = StringLiteral_24894;
		  local_10 = StringLiteral_24314;
		  local_6f0 = CONCAT44(StringLiteral_24894,StringLiteral_24314);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8821,&local_6f0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_6f8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_24473;
		  local_700 = CONCAT44(StringLiteral_1331,StringLiteral_24473);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8824,&local_700,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_708 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_24340;
		  local_710 = (ulonglong)StringLiteral_24340;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8861,&local_710,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_718 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_24370;
		  local_720 = CONCAT44(StringLiteral_1331,StringLiteral_24370);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8865,&local_720,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_728 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_24466;
		  local_730 = (ulonglong)StringLiteral_24466;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8906,&local_730,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_738 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_24483;
		  local_740 = CONCAT44(StringLiteral_1331,StringLiteral_24483);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_9465,&local_740,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0;
		  local_7 = 0;
		  local_748 = 0;
		  local_c = 0;
		  local_10 = StringLiteral_24497;
		  local_750 = (ulonglong)StringLiteral_24497;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_9340,&local_750,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_758 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_24513;
		  local_760 = CONCAT44(StringLiteral_1331,StringLiteral_24513);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_9466,&local_760,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 10;
		  local_7 = 0;
		  local_768 = 0xa00000000;
		  local_c = 0;
		  local_10 = StringLiteral_23302;
		  local_770 = (ulonglong)StringLiteral_23302;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_9789,&local_770,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_778 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_24517;
		  local_780 = (ulonglong)StringLiteral_24517;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_9223,&local_780,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_788 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_24525;
		  local_790 = CONCAT44(StringLiteral_1331,StringLiteral_24525);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_9484,&local_790,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_798 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_24694;
		  local_7a0 = CONCAT44(StringLiteral_1331,StringLiteral_24694);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_9205,&local_7a0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0xe;
		  local_7 = 0;
		  local_7a8 = 0xe00000000;
		  local_c = 0;
		  local_10 = StringLiteral_24699;
		  local_7b0 = (ulonglong)StringLiteral_24699;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_9192,&local_7b0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_7b8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_24868;
		  local_7c0 = (ulonglong)StringLiteral_24868;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10001,&local_7c0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_7c8 = 0x100000000;
		  local_c = StringLiteral_24868;
		  local_10 = StringLiteral_24870;
		  local_7d0 = CONCAT44(StringLiteral_24868,StringLiteral_24870);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10004,&local_7d0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_7d8 = 0x100000000;
		  local_c = StringLiteral_24868;
		  local_10 = StringLiteral_24869;
		  local_7e0 = CONCAT44(StringLiteral_24868,StringLiteral_24869);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10005,&local_7e0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_7e8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_24886;
		  local_7f0 = CONCAT44(StringLiteral_1331,StringLiteral_24886);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_9481,&local_7f0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 1;
		  local_5 = 0;
		  local_4 = 0;
		  local_7 = 0;
		  local_7f8 = 1;
		  local_c = 0;
		  local_10 = StringLiteral_24896;
		  local_800 = (ulonglong)StringLiteral_24896;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10074,&local_800,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_808 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_24947;
		  local_810 = (ulonglong)StringLiteral_24947;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10082,&local_810,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_818 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_24980;
		  local_820 = CONCAT44(StringLiteral_1331,StringLiteral_24980);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10217,&local_820,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_828 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_24984;
		  local_830 = (ulonglong)StringLiteral_24984;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10218,&local_830,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_838 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_24998;
		  local_840 = CONCAT44(StringLiteral_1331,StringLiteral_24998);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10220,&local_840,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_848 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_24999;
		  local_850 = CONCAT44(StringLiteral_1331,StringLiteral_24999);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10221,&local_850,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_858 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_24978;
		  local_860 = (ulonglong)StringLiteral_24978;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10222,&local_860,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_868 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_24982;
		  local_870 = (ulonglong)StringLiteral_24982;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_5107,&local_870,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_878 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_24973;
		  local_880 = CONCAT44(StringLiteral_1331,StringLiteral_24973);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10261,&local_880,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_888 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_26535;
		  local_890 = CONCAT44(StringLiteral_1331,StringLiteral_26535);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10268,&local_890,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_898 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_25010;
		  local_8a0 = (ulonglong)StringLiteral_25010;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10270,&local_8a0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_8a8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_25007;
		  local_8b0 = CONCAT44(StringLiteral_1331,StringLiteral_25007);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10273,&local_8b0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_8b8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_24971;
		  local_8c0 = CONCAT44(StringLiteral_1331,StringLiteral_24971);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10274,&local_8c0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0;
		  local_7 = 0;
		  local_8c8 = 0;
		  local_c = 0;
		  local_10 = StringLiteral_24987;
		  local_8d0 = (ulonglong)StringLiteral_24987;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10277,&local_8d0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_8d8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_25006;
		  local_8e0 = (ulonglong)StringLiteral_25006;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10282,&local_8e0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_8e8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_24977;
		  local_8f0 = CONCAT44(StringLiteral_1331,StringLiteral_24977);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10281,&local_8f0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_8f8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_25020;
		  local_900 = (ulonglong)StringLiteral_25020;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10373,&local_900,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_908 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_25046;
		  local_910 = (ulonglong)StringLiteral_25046;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10683,&local_910,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_918 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_25098;
		  local_920 = CONCAT44(StringLiteral_1331,StringLiteral_25098);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8444,&local_920,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_928 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_25100;
		  local_930 = CONCAT44(StringLiteral_1331,StringLiteral_25100);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10484,&local_930,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_938 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_25148;
		  local_940 = CONCAT44(StringLiteral_1331,StringLiteral_25148);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10499,&local_940,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_948 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_25149;
		  local_950 = (ulonglong)StringLiteral_25149;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10358,&local_950,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 5;
		  local_7 = 0;
		  local_958 = 0x500000000;
		  local_c = 0;
		  local_10 = StringLiteral_25218;
		  local_960 = (ulonglong)StringLiteral_25218;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10374,&local_960,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_968 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_25216;
		  local_970 = CONCAT44(StringLiteral_1331,StringLiteral_25216);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10680,&local_970,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 5;
		  local_7 = 0;
		  local_978 = 0x500000000;
		  local_c = 0;
		  local_10 = StringLiteral_25214;
		  local_980 = (ulonglong)StringLiteral_25214;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10509,&local_980,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_988 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_24269;
		  local_990 = CONCAT44(StringLiteral_1331,StringLiteral_24269);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10856,&local_990,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0xd;
		  local_7 = 0;
		  local_998 = 0xd00000000;
		  local_c = 0;
		  local_10 = StringLiteral_25439;
		  local_9a0 = (ulonglong)StringLiteral_25439;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10818,&local_9a0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_9a8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_25379;
		  local_9b0 = (ulonglong)StringLiteral_25379;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10837,&local_9b0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0;
		  local_7 = 0;
		  local_9b8 = 0;
		  local_c = 0;
		  local_10 = StringLiteral_25474;
		  local_9c0 = (ulonglong)StringLiteral_25474;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10838,&local_9c0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0;
		  local_7 = 0;
		  local_9c8 = 0;
		  local_c = StringLiteral_25474;
		  local_10 = StringLiteral_25475;
		  local_9d0 = CONCAT44(StringLiteral_25474,StringLiteral_25475);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10841,&local_9d0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0;
		  local_7 = 0;
		  local_9d8 = 0;
		  local_c = StringLiteral_25474;
		  local_10 = StringLiteral_25476;
		  local_9e0 = CONCAT44(StringLiteral_25474,StringLiteral_25476);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10842,&local_9e0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_9e8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_25441;
		  local_9f0 = (ulonglong)StringLiteral_25441;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10843,&local_9f0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0xc;
		  local_7 = 0;
		  local_9f8 = 0xc00000000;
		  local_c = 0;
		  local_10 = StringLiteral_25492;
		  local_a00 = (ulonglong)StringLiteral_25492;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10851,&local_a00,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 2;
		  local_7 = 0;
		  local_a08 = 0x200000000;
		  local_c = 0;
		  local_10 = StringLiteral_25382;
		  local_a10 = (ulonglong)StringLiteral_25382;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10858,&local_a10,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_a18 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_25472;
		  local_a20 = (ulonglong)StringLiteral_25472;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10868,&local_a20,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_a28 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_25381;
		  local_a30 = CONCAT44(StringLiteral_1331,StringLiteral_25381);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_10881,&local_a30,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_a38 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_25443;
		  local_a40 = (ulonglong)StringLiteral_25443;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_11203,&local_a40,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_a48 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_25503;
		  local_a50 = CONCAT44(StringLiteral_1331,StringLiteral_25503);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_11378,&local_a50,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_a58 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_25711;
		  local_a60 = CONCAT44(StringLiteral_1331,StringLiteral_25711);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_11381,&local_a60,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_a68 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_25536;
		  local_a70 = CONCAT44(StringLiteral_1331,StringLiteral_25536);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_11597,&local_a70,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_a78 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_25537;
		  local_a80 = (ulonglong)StringLiteral_25537;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_11415,&local_a80,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_a88 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_25588;
		  local_a90 = CONCAT44(StringLiteral_1331,StringLiteral_25588);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_11388,&local_a90,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_a98 = 0x100000000;
		  local_c = StringLiteral_27377;
		  local_10 = StringLiteral_25667;
		  local_aa0 = CONCAT44(StringLiteral_27377,StringLiteral_25667);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_11599,&local_aa0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_aa8 = 0x100000000;
		  local_c = StringLiteral_25604;
		  local_10 = StringLiteral_25533;
		  local_ab0 = CONCAT44(StringLiteral_25604,StringLiteral_25533);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_11600,&local_ab0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_ab8 = 0x100000000;
		  local_c = StringLiteral_25604;
		  local_10 = StringLiteral_25601;
		  local_ac0 = CONCAT44(StringLiteral_25604,StringLiteral_25601);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_11603,&local_ac0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_ac8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_24523;
		  local_ad0 = CONCAT44(StringLiteral_1331,StringLiteral_24523);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14332,&local_ad0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_ad8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_25666;
		  local_ae0 = CONCAT44(StringLiteral_1331,StringLiteral_25666);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14481,&local_ae0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_ae8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_25736;
		  local_af0 = CONCAT44(StringLiteral_1331,StringLiteral_25736);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_11845,&local_af0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_af8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_25761;
		  local_b00 = CONCAT44(StringLiteral_1331,StringLiteral_25761);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_11875,&local_b00,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_b08 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_22104;
		  local_b10 = CONCAT44(StringLiteral_1331,StringLiteral_22104);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_5408,&local_b10,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_b18 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_25774;
		  local_b20 = CONCAT44(StringLiteral_1331,StringLiteral_25774);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_12054,&local_b20,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_b28 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_25873;
		  local_b30 = CONCAT44(StringLiteral_1331,StringLiteral_25873);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_12052,&local_b30,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_b38 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_25940;
		  local_b40 = CONCAT44(StringLiteral_1331,StringLiteral_25940);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_12056,&local_b40,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_b48 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_26078;
		  local_b50 = CONCAT44(StringLiteral_1331,StringLiteral_26078);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_12228,&local_b50,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_b58 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_26205;
		  local_b60 = (ulonglong)StringLiteral_26205;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_12302,&local_b60,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0;
		  local_7 = 0;
		  local_b68 = 0;
		  local_c = 0;
		  local_10 = StringLiteral_23120;
		  local_b70 = (ulonglong)StringLiteral_23120;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_12367,&local_b70,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 8;
		  local_7 = 0;
		  local_b78 = 0x800000000;
		  local_c = 0;
		  local_10 = StringLiteral_26087;
		  local_b80 = (ulonglong)StringLiteral_26087;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_12448,&local_b80,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_b88 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_26207;
		  local_b90 = (ulonglong)StringLiteral_26207;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_12477,&local_b90,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 2;
		  local_7 = 0;
		  local_b98 = 0x200000000;
		  local_c = StringLiteral_26207;
		  local_10 = StringLiteral_26208;
		  local_ba0 = CONCAT44(StringLiteral_26207,StringLiteral_26208);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_12480,&local_ba0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_ba8 = 0x100000000;
		  local_c = StringLiteral_26207;
		  local_10 = StringLiteral_26209;
		  local_bb0 = CONCAT44(StringLiteral_26207,StringLiteral_26209);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_12481,&local_bb0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_bb8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_25969;
		  local_bc0 = (ulonglong)StringLiteral_25969;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_12862,&local_bc0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_bc8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_26262;
		  local_bd0 = CONCAT44(StringLiteral_1331,StringLiteral_26262);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_13046,&local_bd0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_bd8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_26263;
		  local_be0 = CONCAT44(StringLiteral_1331,StringLiteral_26263);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_13050,&local_be0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_be8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_26264;
		  local_bf0 = CONCAT44(StringLiteral_1331,StringLiteral_26264);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_13051,&local_bf0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_bf8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_26265;
		  local_c00 = CONCAT44(StringLiteral_1331,StringLiteral_26265);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_13052,&local_c00,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_c08 = 0x100000000;
		  local_c = StringLiteral_26510;
		  local_10 = StringLiteral_26506;
		  local_c10 = CONCAT44(StringLiteral_26510,StringLiteral_26506);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_13632,&local_c10,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 4;
		  local_7 = 0;
		  local_c18 = 0x400000000;
		  local_c = 0;
		  local_10 = StringLiteral_26510;
		  local_c20 = (ulonglong)StringLiteral_26510;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_13657,&local_c20,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_c28 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_26508;
		  local_c30 = CONCAT44(StringLiteral_1331,StringLiteral_26508);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_13683,&local_c30,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 6;
		  local_7 = 0;
		  local_c38 = 0x600000000;
		  local_c = 0;
		  local_10 = StringLiteral_26528;
		  local_c40 = (ulonglong)StringLiteral_26528;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_13688,&local_c40,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 6;
		  local_7 = 0;
		  local_c48 = 0x600000000;
		  local_c = StringLiteral_26528;
		  local_10 = StringLiteral_26529;
		  local_c50 = CONCAT44(StringLiteral_26528,StringLiteral_26529);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_13690,&local_c50,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_c58 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_26542;
		  local_c60 = CONCAT44(StringLiteral_1331,StringLiteral_26542);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14051,&local_c60,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_c68 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_26558;
		  local_c70 = CONCAT44(StringLiteral_1331,StringLiteral_26558);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14053,&local_c70,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_c78 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_26594;
		  local_c80 = (ulonglong)StringLiteral_26594;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14355,&local_c80,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_c88 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_26601;
		  local_c90 = CONCAT44(StringLiteral_1331,StringLiteral_26601);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_11598,&local_c90,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_c98 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_27290;
		  local_ca0 = (ulonglong)StringLiteral_27290;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14047,&local_ca0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_ca8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_27134;
		  local_cb0 = CONCAT44(StringLiteral_1331,StringLiteral_27134);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14050,&local_cb0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 6;
		  local_7 = 0;
		  local_cb8 = 0x600000000;
		  local_c = 0;
		  local_10 = StringLiteral_27363;
		  local_cc0 = (ulonglong)StringLiteral_27363;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14209,&local_cc0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 5;
		  local_7 = 0;
		  local_cc8 = 0x500000000;
		  local_c = StringLiteral_27363;
		  local_10 = StringLiteral_27364;
		  local_cd0 = CONCAT44(StringLiteral_27363,StringLiteral_27364);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14214,&local_cd0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 5;
		  local_7 = 0;
		  local_cd8 = 0x500000000;
		  local_c = StringLiteral_27363;
		  local_10 = StringLiteral_27369;
		  local_ce0 = CONCAT44(StringLiteral_27363,StringLiteral_27369);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14215,&local_ce0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_ce8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_23321;
		  local_cf0 = (ulonglong)StringLiteral_23321;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14093,&local_cf0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_cf8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_27303;
		  local_d00 = (ulonglong)StringLiteral_27303;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14303,&local_d00,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_d08 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_27207;
		  local_d10 = (ulonglong)StringLiteral_27207;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14361,&local_d10,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 7;
		  local_7 = 0;
		  local_d18 = 0x700000000;
		  local_c = 0;
		  local_10 = StringLiteral_27241;
		  local_d20 = (ulonglong)StringLiteral_27241;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14430,&local_d20,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 9;
		  local_7 = 0;
		  local_d28 = 0x900000000;
		  local_c = 0;
		  local_10 = StringLiteral_27261;
		  local_d30 = (ulonglong)StringLiteral_27261;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14432,&local_d30,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_d38 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_27305;
		  local_d40 = (ulonglong)StringLiteral_27305;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14460,&local_d40,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_d48 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_27377;
		  local_d50 = (ulonglong)StringLiteral_27377;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14482,&local_d50,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_d58 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_22986;
		  local_d60 = (ulonglong)StringLiteral_22986;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14486,&local_d60,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_d68 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_22987;
		  local_d70 = CONCAT44(StringLiteral_22986,StringLiteral_22987);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14507,&local_d70,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_d78 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_22988;
		  local_d80 = CONCAT44(StringLiteral_22986,StringLiteral_22988);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14508,&local_d80,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_d88 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_22994;
		  local_d90 = CONCAT44(StringLiteral_22986,StringLiteral_22994);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14509,&local_d90,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_d98 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_22989;
		  local_da0 = CONCAT44(StringLiteral_22986,StringLiteral_22989);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14510,&local_da0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_da8 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_22990;
		  local_db0 = CONCAT44(StringLiteral_22986,StringLiteral_22990);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14511,&local_db0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_db8 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_22991;
		  local_dc0 = CONCAT44(StringLiteral_22986,StringLiteral_22991);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14512,&local_dc0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_dc8 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_22992;
		  local_dd0 = CONCAT44(StringLiteral_22986,StringLiteral_22992);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14513,&local_dd0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_dd8 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_22993;
		  local_de0 = CONCAT44(StringLiteral_22986,StringLiteral_22993);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14514,&local_de0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_de8 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_23003;
		  local_df0 = CONCAT44(StringLiteral_22986,StringLiteral_23003);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14515,&local_df0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_df8 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_22995;
		  local_e00 = CONCAT44(StringLiteral_22986,StringLiteral_22995);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14516,&local_e00,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_e08 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_22996;
		  local_e10 = CONCAT44(StringLiteral_22986,StringLiteral_22996);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14517,&local_e10,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_e18 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_22997;
		  local_e20 = CONCAT44(StringLiteral_22986,StringLiteral_22997);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14519,&local_e20,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_e28 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_22998;
		  local_e30 = CONCAT44(StringLiteral_22986,StringLiteral_22998);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14520,&local_e30,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_e38 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_22999;
		  local_e40 = CONCAT44(StringLiteral_22986,StringLiteral_22999);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14521,&local_e40,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_e48 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_23002;
		  local_e50 = CONCAT44(StringLiteral_22986,StringLiteral_23002);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14522,&local_e50,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_e58 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_23000;
		  local_e60 = CONCAT44(StringLiteral_22986,StringLiteral_23000);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14523,&local_e60,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_e68 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_23001;
		  local_e70 = CONCAT44(StringLiteral_22986,StringLiteral_23001);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14524,&local_e70,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_e78 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_22994;
		  local_e80 = CONCAT44(StringLiteral_22986,StringLiteral_22994);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14525,&local_e80,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_e88 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_23005;
		  local_e90 = CONCAT44(StringLiteral_22986,StringLiteral_23005);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14526,&local_e90,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_e98 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_23006;
		  local_ea0 = CONCAT44(StringLiteral_22986,StringLiteral_23006);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14527,&local_ea0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_ea8 = 0x100000000;
		  local_c = StringLiteral_22986;
		  local_10 = StringLiteral_23004;
		  local_eb0 = CONCAT44(StringLiteral_22986,StringLiteral_23004);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14518,&local_eb0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_eb8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_27499;
		  local_ec0 = (ulonglong)StringLiteral_27499;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14770,&local_ec0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0;
		  local_7 = 0;
		  local_ec8 = 0;
		  local_c = 0;
		  local_10 = StringLiteral_27534;
		  local_ed0 = (ulonglong)StringLiteral_27534;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14774,&local_ed0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_ed8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_27375;
		  local_ee0 = CONCAT44(StringLiteral_1331,StringLiteral_27375);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14775,&local_ee0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_ee8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_27529;
		  local_ef0 = (ulonglong)StringLiteral_27529;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14776,&local_ef0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_ef8 = 0x100000000;
		  local_c = StringLiteral_27529;
		  local_10 = StringLiteral_27530;
		  local_f00 = CONCAT44(StringLiteral_27529,StringLiteral_27530);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14779,&local_f00,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_f08 = 0x100000000;
		  local_c = StringLiteral_27529;
		  local_10 = StringLiteral_27531;
		  local_f10 = CONCAT44(StringLiteral_27529,StringLiteral_27531);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_14780,&local_f10,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_f18 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_27614;
		  local_f20 = (ulonglong)StringLiteral_27614;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_15316,&local_f20,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0;
		  local_7 = 0;
		  local_f28 = 0;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_27877;
		  local_f30 = CONCAT44(StringLiteral_1331,StringLiteral_27877);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_15354,&local_f30,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_f38 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_27642;
		  local_f40 = (ulonglong)StringLiteral_27642;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_15366,&local_f40,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_f48 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_27691;
		  local_f50 = (ulonglong)StringLiteral_27691;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_15310,&local_f50,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 1;
		  local_5 = 0;
		  local_4 = 0;
		  local_7 = 0;
		  local_f58 = 1;
		  local_c = 0;
		  local_10 = StringLiteral_27694;
		  local_f60 = (ulonglong)StringLiteral_27694;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_15415,&local_f60,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_f68 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_27712;
		  local_f70 = CONCAT44(StringLiteral_1331,StringLiteral_27712);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_16215,&local_f70,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_f78 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_20682;
		  local_f80 = CONCAT44(StringLiteral_1331,StringLiteral_20682);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_16212,&local_f80,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_f88 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_27736;
		  local_f90 = CONCAT44(StringLiteral_1331,StringLiteral_27736);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_16511,&local_f90,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_f98 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_27738;
		  local_fa0 = (ulonglong)StringLiteral_27738;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_15306,&local_fa0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_fa8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_27740;
		  local_fb0 = CONCAT44(StringLiteral_1331,StringLiteral_27740);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_16502,&local_fb0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_fb8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_27742;
		  local_fc0 = CONCAT44(StringLiteral_1331,StringLiteral_27742);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_16349,&local_fc0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0;
		  local_7 = 0;
		  local_fc8 = 0;
		  local_c = 0;
		  local_10 = StringLiteral_27815;
		  local_fd0 = (ulonglong)StringLiteral_27815;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_16509,&local_fd0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_fd8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_27876;
		  local_fe0 = CONCAT44(StringLiteral_1331,StringLiteral_27876);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_16501,&local_fe0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_fe8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_27886;
		  local_ff0 = CONCAT44(StringLiteral_1331,StringLiteral_27886);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_16529,&local_ff0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_ff8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_27889;
		  local_1000 = CONCAT44(StringLiteral_1331,StringLiteral_27889);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_15308,&local_1000,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_1008 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_27920;
		  local_1010 = CONCAT44(StringLiteral_1331,StringLiteral_27920);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_16861,&local_1010,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 6;
		  local_7 = 0;
		  local_1018 = 0x600000000;
		  local_c = 0;
		  local_10 = StringLiteral_27932;
		  local_1020 = (ulonglong)StringLiteral_27932;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_16895,&local_1020,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_1028 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_28137;
		  local_1030 = (ulonglong)StringLiteral_28137;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_17300,&local_1030,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 2;
		  local_7 = 0;
		  local_1038 = 0x200000000;
		  local_c = 0;
		  local_10 = StringLiteral_28203;
		  local_1040 = (ulonglong)StringLiteral_28203;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_17397,&local_1040,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_1048 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_28236;
		  local_1050 = CONCAT44(StringLiteral_1331,StringLiteral_28236);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_17672,&local_1050,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_1058 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_28272;
		  local_1060 = (ulonglong)StringLiteral_28272;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_17695,&local_1060,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_1068 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_28305;
		  local_1070 = CONCAT44(StringLiteral_1331,StringLiteral_28305);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_17746,&local_1070,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_1078 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_28316;
		  local_1080 = CONCAT44(StringLiteral_1331,StringLiteral_28316);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_17841,&local_1080,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 0x10;
		  local_7 = 0;
		  local_1088 = 0x1000000000;
		  local_c = 0;
		  local_10 = StringLiteral_22166;
		  local_1090 = (ulonglong)StringLiteral_22166;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_17888,&local_1090,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_1098 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_28363;
		  local_10a0 = CONCAT44(StringLiteral_1331,StringLiteral_28363);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_17934,&local_10a0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_10a8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_23288;
		  local_10b0 = (ulonglong)StringLiteral_23288;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_8175,&local_10b0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_10b8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_28455;
		  local_10c0 = (ulonglong)StringLiteral_28455;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_18201,&local_10c0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_10c8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_28485;
		  local_10d0 = (ulonglong)StringLiteral_28485;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_18445,&local_10d0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_10d8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_28487;
		  local_10e0 = (ulonglong)StringLiteral_28487;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_18463,&local_10e0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_10e8 = 0x100000000;
		  local_c = StringLiteral_1331;
		  local_10 = StringLiteral_28529;
		  local_10f0 = CONCAT44(StringLiteral_1331,StringLiteral_28529);
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_18795,&local_10f0,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  local_8 = 0;
		  local_5 = 0;
		  local_4 = 1;
		  local_7 = 0;
		  local_10f8 = 0x100000000;
		  local_c = 0;
		  local_10 = StringLiteral_28545;
		  local_1100 = (ulonglong)StringLiteral_28545;
		  System_Collections_Generic_Dictionary_object__GoogleLanguages_LanguageCodeDef____ctor
		            (param1_00,StringLiteral_18826,&local_1100,
		             Method_System_Collections_Generic_Dictionary_string__GoogleLanguages_LanguageCodeDef__Add__
		            );
		  **(undefined4 **)(I2_Loc_GoogleLanguages_TypeInfo + 0x5c) = param1_00;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x04003D69 RID: 15721
		[Token(Token = "0x4003D69")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<string, GoogleLanguages.LanguageCodeDef> mLanguageDef;

		// Token: 0x02001359 RID: 4953
		[Token(Token = "0x2001359")]
		public struct LanguageCodeDef
		{
			// Token: 0x04003D6A RID: 15722
			[Token(Token = "0x4003D6A")]
			[FieldOffset(Offset = "0x0")]
			public string Code;

			// Token: 0x04003D6B RID: 15723
			[Token(Token = "0x4003D6B")]
			[FieldOffset(Offset = "0x4")]
			public string GoogleCode;

			// Token: 0x04003D6C RID: 15724
			[Token(Token = "0x4003D6C")]
			[FieldOffset(Offset = "0x8")]
			public bool HasJoinedWords;

			// Token: 0x04003D6D RID: 15725
			[Token(Token = "0x4003D6D")]
			[FieldOffset(Offset = "0xC")]
			public int PluralRule;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: .cctor ---
		uint I2_Loc_GoogleLanguages___cctor(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  uint uVar1;
		  
		  if (DAT_ram_00a5973c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a5973c = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  if (*(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc) < 1) {
		    return 0;
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  param1_00 = I2_Loc_LocalizationManager__GetRequiredWebServiceVersion(0,0);
		  uVar1 = func_ii_4769(param1_00,0);
		  return uVar1 ^ 1;
		}
		*/

}
