using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace I2.Loc
{
	// Token: 0x0200135A RID: 4954
	[Token(Token = "0x200135A")]
	public static class GoogleTranslation
	{
		// Token: 0x0600759E RID: 30110 RVA: 0x00015390 File Offset: 0x00013590
		[Token(Token = "0x600759E")]
		[Address(RVA = "0xBF2B", Offset = "0xBF2B", VA = "0xBF2B")]
		public static bool CanTranslate()
		{
		/* --- GHIDRA: CanTranslate ---
		void I2_Loc_GoogleTranslation__CanTranslate
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5973d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TranslationQuery___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_string__TranslationQuery__TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_StringComparer_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_I2_Loc_GoogleTranslation___c__DisplayClass2_0__Translate_b__0__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation___c__DisplayClass2_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17873);
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_fnOnTranslationReady_TypeInfo);
		    DAT_ram_00a5973d = '\x01';
		  }
		  iVar1 = unnamed_function_1417(I2_Loc_GoogleTranslation___c__DisplayClass2_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x14) = param3;
		  *(undefined4 *)(iVar1 + 0xc) = param1;
		  *(undefined4 *)(iVar1 + 8) = param4;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizeDropdown___ctor(0);
		  if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		  }
		  iVar2 = I2_Loc_GoogleLanguages___cctor(iVar1);
		  if (iVar2 == 0) {
		    iVar1 = *(int *)(iVar1 + 8);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),0,StringLiteral_17873,*(undefined4 *)(iVar1 + 0x14));
		    return;
		  }
		  iVar2 = System_Collections_CollectionBase___ctor(*(undefined4 *)(iVar1 + 0x14),param2,0);
		  if (iVar2 != 0) {
		    iVar2 = *(int *)(iVar1 + 8);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar1 + 0xc),0,
		               *(undefined4 *)(iVar2 + 0x14));
		    return;
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
		  uVar4 = *(undefined4 *)(*(int *)(System_StringComparer_TypeInfo + 0x5c) + 8);
		  uVar3 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_string__TranslationQuery__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData____ctor
		            (uVar3,uVar4,
		             Method_System_Collections_Generic_Dictionary_string__TranslationQuery___ctor__);
		  *(undefined4 *)(iVar1 + 0x10) = uVar3;
		  iVar2 = func_ii_4769(*(undefined4 *)(iVar1 + 0x14),0);
		  if (iVar2 != 0) {
		    iVar1 = *(int *)(iVar1 + 8);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),**(undefined4 **)(DAT_ram_00a66978 + 0x5c),0,
		               *(undefined4 *)(iVar1 + 0x14));
		    return;
		  }
		  uVar3 = *(undefined4 *)(iVar1 + 0x10);
		  uVar4 = *(undefined4 *)(iVar1 + 0x14);
		  uVar5 = *(undefined4 *)(iVar1 + 0xc);
		  if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		  }
		  I2_Loc_GoogleTranslation__CancelCurrentGoogleTranslations(uVar5,param2,uVar4,uVar3,iVar1);
		  uVar4 = *(undefined4 *)(iVar1 + 0x10);
		  uVar3 = unnamed_function_1417(I2_Loc_GoogleTranslation_fnOnTranslationReady_TypeInfo);
		  I2_Loc_GoogleTranslation_fnOnTranslated__EndInvoke
		            (uVar3,iVar1,Method_I2_Loc_GoogleTranslation___c__DisplayClass2_0__Translate_b__0__,0);
		  if (DAT_ram_00a5973f == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_TranslationJob_Main_TypeInfo);
		    DAT_ram_00a5973f = '\x01';
		  }
		  uVar5 = unnamed_function_1417(I2_Loc_TranslationJob_Main_TypeInfo);
		  I2_Loc_TranslationJob_GET__ProcessResult(uVar5,uVar4,uVar3,0);
		  if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		  }
		  I2_Loc_GoogleTranslation__ConvertTranslationRequest(uVar5,uVar5);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600759F RID: 30111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600759F")]
		[Address(RVA = "0xBF2C", Offset = "0xBF2C", VA = "0xBF2C")]
		public static void Translate(string text, string LanguageCodeFrom, string LanguageCodeTo, GoogleTranslation.fnOnTranslated OnTranslationReady)
		{
		/* --- GHIDRA: Translate ---
		uint I2_Loc_GoogleTranslation__Translate(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a59740 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_TranslationJob_Main_TypeInfo);
		    DAT_ram_00a59740 = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(I2_Loc_TranslationJob_Main_TypeInfo);
		  I2_Loc_TranslationJob_GET__ProcessResult(param1_00,param1,0,0);
		  do {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xe8) * 4))
		                      (param1_00,*(undefined4 *)(*param1_00 + 0xec));
		  } while (iVar1 == 0);
		  return (uint)(iVar1 != 2);
		}
		*/

		/* --- GHIDRA: Translate ---
		uint I2_Loc_GoogleTranslation__Translate(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a59740 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_TranslationJob_Main_TypeInfo);
		    DAT_ram_00a59740 = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(I2_Loc_TranslationJob_Main_TypeInfo);
		  I2_Loc_TranslationJob_GET__ProcessResult(param1_00,param1,0,0);
		  do {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xe8) * 4))
		                      (param1_00,*(undefined4 *)(*param1_00 + 0xec));
		  } while (iVar1 == 0);
		  return (uint)(iVar1 != 2);
		}
		*/

		}

		// Token: 0x060075A0 RID: 30112 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075A0")]
		[Address(RVA = "0xBF2D", Offset = "0xBF2D", VA = "0xBF2D")]
		public static string ForceTranslate(string text, string LanguageCodeFrom, string LanguageCodeTo)
		{
		/* --- GHIDRA: ForceTranslate ---
		int I2_Loc_GoogleTranslation__ForceTranslate(undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  uint uVar8;
		  undefined1 auStack_60 [4];
		  int local_5c;
		  undefined8 *puStack_58;
		  undefined8 local_54;
		  undefined8 local_4c;
		  undefined8 local_44;
		  undefined8 local_3c;
		  undefined4 local_34;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a59741 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__TranslationQuery__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__TranslationQuery__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__TranslationQuery__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__TranslationQuery__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleLanguages_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__TranslationQuery__get_Value__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2111);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2361);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2003);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1236);
		    DAT_ram_00a59741 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  local_30 = 0;
		  iVar1 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar1,Method_System_Collections_Generic_List_string___ctor__);
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_2101(param1_00,0);
		  System_Collections_Generic_Dictionary_uint__WorldSpaceData___FindEntry
		            (&local_5c,param1,
		             Method_System_Collections_Generic_Dictionary_string__TranslationQuery__GetEnumerator__)
		  ;
		  local_8 = local_34;
		  local_10 = local_3c;
		  local_18 = local_44;
		  local_20 = local_4c;
		  local_28 = local_54;
		  local_5c = 0;
		  puStack_58 = &local_30;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x362,&local_30,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_string__TranslationQuery__MoveNext__
		                      );
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81060ed1;
		    }
		    if (iVar2 == 0) break;
		    DAT_ram_009d3e38 = 0;
		    iVar2 = local_18._4_4_;
		    uVar4 = (undefined4)local_18;
		    uVar5 = local_20._4_4_;
		    iVar3 = func_ii_4075(param1_00,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81060ed1;
		    }
		    if (0 < iVar3) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_iiii
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,
		                 StringLiteral_2111,0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81060ed1;
		      }
		    }
		    if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 I2_Loc_GoogleLanguages_TypeInfo);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81060ed1;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x363,uVar4,auStack_60);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81060ed1;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,uVar4,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81060ed1;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,StringLiteral_2003,
		               0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81060ed1;
		    }
		    if (0 < *(int *)(iVar2 + 0xc)) {
		      uVar4 = *(undefined4 *)(iVar2 + 0x10);
		      if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   I2_Loc_GoogleLanguages_TypeInfo);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81060ed1;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x363,uVar4,auStack_60);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81060ed1;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_iiii
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,uVar4,0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81060ed1;
		      }
		      iVar7 = 1;
		      if (1 < *(int *)(iVar2 + 0xc)) {
		        do {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_iiii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,
		                     StringLiteral_1236,0);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81060ed1;
		          }
		          uVar4 = *(undefined4 *)(iVar2 + iVar7 * 4 + 0x10);
		          if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       I2_Loc_GoogleLanguages_TypeInfo);
		            iVar3 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar3 == 1) {
		              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x81060ed1;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x363,uVar4,
		                             auStack_60);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81060ed1;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_iiii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,uVar4,0);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81060ed1;
		          }
		          iVar7 = iVar7 + 1;
		        } while (iVar7 < *(int *)(iVar2 + 0xc));
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,StringLiteral_2361,
		               0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81060ed1;
		    }
		    if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 I2_Loc_GoogleTranslation_TypeInfo);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81060ed1;
		      }
		    }
		    if (DAT_ram_00a59754 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Globalization_CultureInfo_TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_00a59754 = '\x01';
		        goto code_r0x81060a1e;
		      }
		code_r0x81060c78:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81060ed1;
		    }
		code_r0x81060a1e:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = func_ii_4769(uVar5,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81060c78;
		    if (iVar7 == 0) {
		      if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   System_Globalization_CultureInfo_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81060c78;
		      }
		      DAT_ram_009d3e38 = 0;
		      piVar6 = (int *)import::env::invoke_ii
		                                (s_struct_Uniforms___color__array<v_ram_00000aff + 199,0);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_iii
		                          (*(undefined4 *)(*piVar6 + 0x110),piVar6,*(undefined4 *)(*piVar6 + 0x114))
		        ;
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x364,uVar4,uVar5,0);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x81060bbf;
		        }
		      }
		      goto code_r0x81060c78;
		    }
		    uVar4 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		code_r0x81060bbf:
		    DAT_ram_009d3e38 = 0;
		    iVar2 = System_Collections_CollectionBase___ctor(uVar4,uVar5,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81060ed1;
		    }
		    if (iVar2 != 0) {
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x365,uVar5,0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81060ed1;
		      }
		    }
		    if (param2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_iiii
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,uVar5,0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81060ed1:
		        iVar7 = global_1;
		        iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar7 == iVar2) {
		          piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		          iVar7 = *piVar6;
		          iVar2 = 0;
		          DAT_ram_009d3e38 = 0;
		          local_5c = iVar7;
		          import::env::invoke_v(0x123);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 != 1) {
		code_r0x81060f1e:
		            DAT_ram_009d3e38 = 0;
		            if (iVar7 == 0) {
		              if ((iVar2 == 0) ||
		                 ((((((iVar2 != 1 && (iVar2 != 2)) && (iVar2 != 3)) &&
		                    ((iVar2 != 4 && (iVar2 != 5)))) &&
		                   ((iVar2 != 6 && ((iVar2 != 7 && (iVar2 != 8)))))) &&
		                  ((iVar2 != 9 && ((iVar2 != 10 && (iVar2 == 0xb)))))))) {
		                uVar5 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                                  (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		                iVar7 = Method_System_Collections_Generic_List_string__Add__;
		                *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		                uVar8 = *(uint *)(iVar1 + 0xc);
		                if (uVar8 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		                  *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		                  *(undefined4 *)(*(int *)(iVar1 + 8) + uVar8 * 4 + 0x10) = uVar5;
		                }
		                else {
		                  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                            (iVar1,uVar5,
		                             *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		                }
		              }
		              return iVar1;
		            }
		            System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar5 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x367,&local_5c);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          import::env::__resumeException(uVar5);
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
		    }
		    else {
		      if (*(int *)(System_Uri_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,System_Uri_TypeInfo);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81060ed1;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x366,uVar5,0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81060ed1;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_iiii
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,uVar5,0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81060ed1;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar2 = func_ii_4075(param1_00,0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81060ed1;
		      }
		      if (4000 < iVar2) {
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::invoke_iii
		                          (*(undefined4 *)(*param1_00 + 0xd8),param1_00,
		                           *(undefined4 *)(*param1_00 + 0xdc));
		        iVar7 = Method_System_Collections_Generic_List_string__Add__;
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81060ec9:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81060ed1;
		        }
		        *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		        uVar8 = *(uint *)(iVar1 + 0xc);
		        if (uVar8 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		          *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		          *(undefined4 *)(*(int *)(iVar1 + 8) + uVar8 * 4 + 0x10) = uVar5;
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar1,uVar5,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		          if (DAT_ram_009d3e38 == 1) goto code_r0x81060ec9;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x321,param1_00,0,0);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81060ed1;
		        }
		      }
		    }
		  }
		  iVar2 = 0xb;
		  iVar7 = local_5c;
		  goto code_r0x81060f1e;
		}
		*/

		/* --- GHIDRA: ForceTranslate ---
		int I2_Loc_GoogleTranslation__ForceTranslate(undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  uint uVar8;
		  undefined1 auStack_60 [4];
		  int local_5c;
		  undefined8 *puStack_58;
		  undefined8 local_54;
		  undefined8 local_4c;
		  undefined8 local_44;
		  undefined8 local_3c;
		  undefined4 local_34;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a59741 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__TranslationQuery__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__TranslationQuery__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__TranslationQuery__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__TranslationQuery__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleLanguages_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__TranslationQuery__get_Value__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2111);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2361);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2003);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1236);
		    DAT_ram_00a59741 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  local_30 = 0;
		  iVar1 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar1,Method_System_Collections_Generic_List_string___ctor__);
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_2101(param1_00,0);
		  System_Collections_Generic_Dictionary_uint__WorldSpaceData___FindEntry
		            (&local_5c,param1,
		             Method_System_Collections_Generic_Dictionary_string__TranslationQuery__GetEnumerator__)
		  ;
		  local_8 = local_34;
		  local_10 = local_3c;
		  local_18 = local_44;
		  local_20 = local_4c;
		  local_28 = local_54;
		  local_5c = 0;
		  puStack_58 = &local_30;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x362,&local_30,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_string__TranslationQuery__MoveNext__
		                      );
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81060ed1;
		    }
		    if (iVar2 == 0) break;
		    DAT_ram_009d3e38 = 0;
		    iVar2 = local_18._4_4_;
		    uVar4 = (undefined4)local_18;
		    uVar5 = local_20._4_4_;
		    iVar3 = func_ii_4075(param1_00,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81060ed1;
		    }
		    if (0 < iVar3) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_iiii
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,
		                 StringLiteral_2111,0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81060ed1;
		      }
		    }
		    if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 I2_Loc_GoogleLanguages_TypeInfo);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81060ed1;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x363,uVar4,auStack_60);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81060ed1;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,uVar4,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81060ed1;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,StringLiteral_2003,
		               0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81060ed1;
		    }
		    if (0 < *(int *)(iVar2 + 0xc)) {
		      uVar4 = *(undefined4 *)(iVar2 + 0x10);
		      if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   I2_Loc_GoogleLanguages_TypeInfo);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81060ed1;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x363,uVar4,auStack_60);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81060ed1;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_iiii
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,uVar4,0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81060ed1;
		      }
		      iVar7 = 1;
		      if (1 < *(int *)(iVar2 + 0xc)) {
		        do {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_iiii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,
		                     StringLiteral_1236,0);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81060ed1;
		          }
		          uVar4 = *(undefined4 *)(iVar2 + iVar7 * 4 + 0x10);
		          if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       I2_Loc_GoogleLanguages_TypeInfo);
		            iVar3 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar3 == 1) {
		              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x81060ed1;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x363,uVar4,
		                             auStack_60);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81060ed1;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_iiii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,uVar4,0);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81060ed1;
		          }
		          iVar7 = iVar7 + 1;
		        } while (iVar7 < *(int *)(iVar2 + 0xc));
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,StringLiteral_2361,
		               0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81060ed1;
		    }
		    if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 I2_Loc_GoogleTranslation_TypeInfo);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81060ed1;
		      }
		    }
		    if (DAT_ram_00a59754 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Globalization_CultureInfo_TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_00a59754 = '\x01';
		        goto code_r0x81060a1e;
		      }
		code_r0x81060c78:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81060ed1;
		    }
		code_r0x81060a1e:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = func_ii_4769(uVar5,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81060c78;
		    if (iVar7 == 0) {
		      if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   System_Globalization_CultureInfo_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81060c78;
		      }
		      DAT_ram_009d3e38 = 0;
		      piVar6 = (int *)import::env::invoke_ii
		                                (s_struct_Uniforms___color__array<v_ram_00000aff + 199,0);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_iii
		                          (*(undefined4 *)(*piVar6 + 0x110),piVar6,*(undefined4 *)(*piVar6 + 0x114))
		        ;
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x364,uVar4,uVar5,0);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x81060bbf;
		        }
		      }
		      goto code_r0x81060c78;
		    }
		    uVar4 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		code_r0x81060bbf:
		    DAT_ram_009d3e38 = 0;
		    iVar2 = System_Collections_CollectionBase___ctor(uVar4,uVar5,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81060ed1;
		    }
		    if (iVar2 != 0) {
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x365,uVar5,0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81060ed1;
		      }
		    }
		    if (param2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_iiii
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,uVar5,0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81060ed1:
		        iVar7 = global_1;
		        iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar7 == iVar2) {
		          piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		          iVar7 = *piVar6;
		          iVar2 = 0;
		          DAT_ram_009d3e38 = 0;
		          local_5c = iVar7;
		          import::env::invoke_v(0x123);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 != 1) {
		code_r0x81060f1e:
		            DAT_ram_009d3e38 = 0;
		            if (iVar7 == 0) {
		              if ((iVar2 == 0) ||
		                 ((((((iVar2 != 1 && (iVar2 != 2)) && (iVar2 != 3)) &&
		                    ((iVar2 != 4 && (iVar2 != 5)))) &&
		                   ((iVar2 != 6 && ((iVar2 != 7 && (iVar2 != 8)))))) &&
		                  ((iVar2 != 9 && ((iVar2 != 10 && (iVar2 == 0xb)))))))) {
		                uVar5 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                                  (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		                iVar7 = Method_System_Collections_Generic_List_string__Add__;
		                *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		                uVar8 = *(uint *)(iVar1 + 0xc);
		                if (uVar8 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		                  *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		                  *(undefined4 *)(*(int *)(iVar1 + 8) + uVar8 * 4 + 0x10) = uVar5;
		                }
		                else {
		                  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                            (iVar1,uVar5,
		                             *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		                }
		              }
		              return iVar1;
		            }
		            System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar5 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x367,&local_5c);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          import::env::__resumeException(uVar5);
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
		    }
		    else {
		      if (*(int *)(System_Uri_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,System_Uri_TypeInfo);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81060ed1;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x366,uVar5,0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81060ed1;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_iiii
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,uVar5,0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81060ed1;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar2 = func_ii_4075(param1_00,0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81060ed1;
		      }
		      if (4000 < iVar2) {
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::invoke_iii
		                          (*(undefined4 *)(*param1_00 + 0xd8),param1_00,
		                           *(undefined4 *)(*param1_00 + 0xdc));
		        iVar7 = Method_System_Collections_Generic_List_string__Add__;
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81060ec9:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81060ed1;
		        }
		        *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		        uVar8 = *(uint *)(iVar1 + 0xc);
		        if (uVar8 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		          *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		          *(undefined4 *)(*(int *)(iVar1 + 8) + uVar8 * 4 + 0x10) = uVar5;
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar1,uVar5,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		          if (DAT_ram_009d3e38 == 1) goto code_r0x81060ec9;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x321,param1_00,0,0);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81060ed1;
		        }
		      }
		    }
		  }
		  iVar2 = 0xb;
		  iVar7 = local_5c;
		  goto code_r0x81060f1e;
		}
		*/

			return null;
		}

		// Token: 0x060075A1 RID: 30113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075A1")]
		[Address(RVA = "0xBF2E", Offset = "0xBF2E", VA = "0xBF2E")]
		public static void Translate(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady, bool usePOST = true)
		{
		}

		// Token: 0x060075A2 RID: 30114 RVA: 0x000153A8 File Offset: 0x000135A8
		[Token(Token = "0x60075A2")]
		[Address(RVA = "0xBF2F", Offset = "0xBF2F", VA = "0xBF2F")]
		public static bool ForceTranslate(Dictionary<string, TranslationQuery> requests, bool usePOST = true)
		{
			return default(bool);
		}

		// Token: 0x060075A3 RID: 30115 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075A3")]
		[Address(RVA = "0xBF30", Offset = "0xBF30", VA = "0xBF30")]
		public static List<string> ConvertTranslationRequest(Dictionary<string, TranslationQuery> requests, bool encodeGET)
		{
		/* --- GHIDRA: ConvertTranslationRequest ---
		void I2_Loc_GoogleTranslation__ConvertTranslationRequest(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int param1_01;
		  uint uVar2;
		  
		  if (DAT_ram_00a59742 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TranslationJob__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TranslationJob__get_Count__);
		    DAT_ram_00a59742 = '\x01';
		  }
		  if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		  }
		  iVar1 = Method_System_Collections_Generic_List_TranslationJob__Add__;
		  param1_01 = *(int *)(*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x5c) + 4);
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_01 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar2 + 1;
		    *(undefined4 *)(*(int *)(param1_01 + 8) + uVar2 * 4 + 0x10) = param1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,param1,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  if (*(int *)(*(int *)(*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x5c) + 4) + 0xc) == 1) {
		    if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		    }
		    if (DAT_ram_00a59743 == '\0') {
		      Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation__WaitForTranslations_d__11_TypeInfo);
		      DAT_ram_00a59743 = '\x01';
		    }
		    param1_00 = unnamed_function_1417(I2_Loc_GoogleTranslation__WaitForTranslations_d__11_TypeInfo);
		    Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,0,0);
		    I2_Loc_CoroutineManager__Awake(param1_00,0);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060075A4 RID: 30116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075A4")]
		[Address(RVA = "0xBF31", Offset = "0xBF31", VA = "0xBF31")]
		private static void AddTranslationJob(TranslationJob job)
		{
		/* --- GHIDRA: AddTranslationJob ---
		undefined4 I2_Loc_GoogleTranslation__AddTranslationJob(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59743 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation__WaitForTranslations_d__11_TypeInfo);
		    DAT_ram_00a59743 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(I2_Loc_GoogleTranslation__WaitForTranslations_d__11_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,0,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x060075A5 RID: 30117 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075A5")]
		[Address(RVA = "0xBF32", Offset = "0xBF32", VA = "0xBF32")]
		private static IEnumerator WaitForTranslations()
		{
		/* --- GHIDRA: WaitForTranslations ---
		undefined4
		I2_Loc_GoogleTranslation__WaitForTranslations(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int param2_00;
		  int iVar6;
		  undefined4 param1_00;
		  int iVar7;
		  int *piVar8;
		  int iVar9;
		  undefined4 uVar10;
		  uint uVar11;
		  undefined4 *puVar12;
		  int iVar13;
		  undefined1 local_40 [16];
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 uStack_10;
		  undefined4 local_c;
		  int local_8;
		  int local_4;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a59744 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TranslationQuery__get_Keys__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TranslationQuery__set_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_string___);
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2111);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2057);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2110);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16107);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15893);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15637);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2324);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14241);
		    DAT_ram_00a59744 = '\x01';
		  }
		  iVar3 = System_String__ToLower(param1,StringLiteral_2057,0);
		  if ((iVar3 == 0) && (iVar3 = System_String__ToLower(param1,StringLiteral_2110,0), iVar3 == 0)) {
		    iVar3 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,1);
		    *(undefined4 *)(iVar3 + 0x10) = StringLiteral_2111;
		    iVar3 = System_UriBuilder___ctor(param1,iVar3,0,0);
		    param2_00 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,1);
		    *(undefined4 *)(param2_00 + 0x10) = StringLiteral_2324;
		    uVar5 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                      (param2,
		                       Method_System_Collections_Generic_Dictionary_string__TranslationQuery__get_Keys__
		                      );
		    iVar6 = func_ii_6295(uVar5,Method_System_Linq_Enumerable_ToArray_string___);
		    uVar5 = 0;
		    if (0 < *(int *)(iVar6 + 0xc)) {
		      do {
		        iVar13 = iVar4 * 4;
		        uVar5 = *(undefined4 *)(iVar6 + iVar13 + 0x10);
		        if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		        }
		        I2_Loc_GoogleTranslation__GetTranslation(&local_18,uVar5,param2,iVar13);
		        local_20 = local_c;
		        local_28 = CONCAT44(uStack_10,local_14);
		        uVar10 = *(undefined4 *)(iVar13 + iVar3 + 0x10);
		        if (local_4 != 0) {
		          uVar11 = *(uint *)(local_4 + 0xc) - 1;
		          uVar2 = *(uint *)(local_4 + 0xc);
		          if (-1 < (int)uVar11) {
		            do {
		              if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		                func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		              }
		              if (DAT_ram_00a5974f == '\0') {
		                Mono_Security_ASN1__get_Item(&StringLiteral_1226);
		                Mono_Security_ASN1__get_Item(&StringLiteral_1228);
		                Mono_Security_ASN1__get_Item(&StringLiteral_5);
		                DAT_ram_00a5974f = '\x01';
		              }
		              if (uVar11 < 0x46) {
		                param1_00 = System_Data_DataSet__ReadXmlSchema(StringLiteral_1228,0,uVar2,0);
		              }
		              else {
		                uVar2 = 0xffffffff;
		                param1_00 = StringLiteral_5;
		                do {
		                  param1_00 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor
		                                        (param1_00,StringLiteral_1226,0);
		                  uVar2 = uVar2 + 1;
		                } while (uVar2 != uVar11);
		              }
		              uVar10 = func_ii_7088(uVar10,param1_00,*(undefined4 *)(local_4 + uVar11 * 4 + 0x10),0)
		              ;
		              bVar1 = 0 < (int)uVar11;
		              uVar2 = uVar11;
		              uVar11 = uVar11 - 1;
		            } while (bVar1);
		          }
		        }
		        iVar13 = System_UriBuilder___ctor(uVar10,param2_00,0,0);
		        if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		        }
		        if (DAT_ram_00a59754 == '\0') {
		          Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		          DAT_ram_00a59754 = '\x01';
		        }
		        iVar4 = iVar4 + 1;
		        iVar7 = func_ii_4769(uVar5,0);
		        if (iVar7 == 0) {
		          if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		            func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		          }
		          piVar8 = (int *)System_String__StartsWith(0);
		          uVar10 = (**(code **)((ulonglong)*(uint *)(*piVar8 + 0x110) * 4))
		                             (piVar8,*(undefined4 *)(*piVar8 + 0x114));
		          uVar10 = I2_Loc_GoogleLanguages__GetGoogleLanguageCode(uVar10,uVar5,0);
		        }
		        else {
		          uVar10 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		        }
		        iVar7 = System_Collections_CollectionBase___ctor(uVar10,uVar5,0);
		        if ((iVar7 != 0) && (iVar7 = 0, 0 < *(int *)(iVar13 + 0xc))) {
		          do {
		            puVar12 = (undefined4 *)(iVar13 + iVar7 * 4 + 0x10);
		            uVar5 = *puVar12;
		            if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		              func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		            }
		            if (DAT_ram_00a59754 == '\0') {
		              Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		              DAT_ram_00a59754 = '\x01';
		            }
		            iVar9 = func_ii_4769(uVar5,0);
		            if (iVar9 == 0) {
		              if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		                func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		              }
		              piVar8 = (int *)System_String__StartsWith(0);
		              uVar10 = (**(code **)((ulonglong)*(uint *)(*piVar8 + 0x110) * 4))
		                                 (piVar8,*(undefined4 *)(*piVar8 + 0x114));
		              uVar5 = I2_Loc_GoogleLanguages__GetGoogleLanguageCode(uVar10,uVar5,0);
		            }
		            else {
		              uVar5 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		            }
		            *puVar12 = uVar5;
		            iVar7 = iVar7 + 1;
		          } while (iVar7 < *(int *)(iVar13 + 0xc));
		        }
		        uVar5 = Method_System_Collections_Generic_Dictionary_string__TranslationQuery__set_Item__;
		        *(undefined4 *)((undefined8 *)((uint)&local_18 | 4) + 1) = local_20;
		        *(undefined8 *)((uint)&local_18 | 4) = local_28;
		        local_30 = CONCAT44(local_4,iVar13);
		        local_8 = iVar13;
		        System_Collections_Generic_Dictionary_object__TranslationQuery___get_Values
		                  (param2,local_18,local_40,uVar5);
		        uVar5 = 0;
		      } while (iVar4 < *(int *)(iVar6 + 0xc));
		    }
		  }
		  else {
		    iVar4 = func_ii_7903(param1,StringLiteral_15893,0);
		    uVar5 = StringLiteral_15637;
		    if ((iVar4 == 0) &&
		       (iVar4 = func_ii_7903(param1,StringLiteral_14241,0), uVar5 = StringLiteral_5, iVar4 == 0)) {
		      uVar5 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_16107,param1,0);
		    }
		  }
		  return uVar5;
		}
		*/

			return null;
		}

		// Token: 0x060075A6 RID: 30118 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075A6")]
		[Address(RVA = "0xBF33", Offset = "0xBF33", VA = "0xBF33")]
		public static string ParseTranslationResult(string html, Dictionary<string, TranslationQuery> requests)
		{
		/* --- GHIDRA: ParseTranslationResult ---
		uint I2_Loc_GoogleTranslation__ParseTranslationResult(undefined4 param1)
		
		{
		  int *piVar1;
		  uint uVar2;
		  
		  if (DAT_ram_00a59745 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TranslationJob__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_UnityWebRequest__get_Count__);
		    DAT_ram_00a59745 = '\x01';
		  }
		  if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		  }
		  piVar1 = *(int **)(I2_Loc_GoogleTranslation_TypeInfo + 0x5c);
		  if (*(int *)(*piVar1 + 0xc) < 1) {
		    if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		      piVar1 = *(int **)(I2_Loc_GoogleTranslation_TypeInfo + 0x5c);
		    }
		    uVar2 = (uint)(0 < *(int *)(piVar1[1] + 0xc));
		  }
		  else {
		    uVar2 = 1;
		  }
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x060075A7 RID: 30119 RVA: 0x000153C0 File Offset: 0x000135C0
		[Token(Token = "0x60075A7")]
		[Address(RVA = "0xBF34", Offset = "0xBF34", VA = "0xBF34")]
		public static bool IsTranslating()
		{
		/* --- GHIDRA: IsTranslating ---
		void I2_Loc_GoogleTranslation__IsTranslating(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  int iVar3;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59746 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TranslationJob__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TranslationJob__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TranslationJob__get_Current__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TranslationJob__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_UnityWebRequest__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TranslationJob__GetEnumerator__);
		    DAT_ram_00a59746 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		  }
		  piVar1 = *(int **)(I2_Loc_GoogleTranslation_TypeInfo + 0x5c);
		  iVar2 = *piVar1;
		  iVar3 = *(int *)(iVar2 + 0xc);
		  *(undefined4 *)(iVar2 + 0xc) = 0;
		  *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		  if (0 < iVar3) {
		    func_ii_2064(*(undefined4 *)(iVar2 + 8),0,iVar3,0);
		    piVar1 = *(int **)(I2_Loc_GoogleTranslation_TypeInfo + 0x5c);
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,piVar1[1],
		             Method_System_Collections_Generic_List_TranslationJob__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_TranslationJob__MoveNext__)
		    ;
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81061ac3;
		    }
		    if (iVar3 == 0) goto code_r0x81061b19;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (*(undefined4 *)(*local_8._4_4_ + 0xf0),local_8._4_4_,
		               *(undefined4 *)(*local_8._4_4_ + 0xf4));
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar2 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81061ac3:
		  iVar2 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar3) {
		    piVar1 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar3 = *piVar1;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x81061b19:
		      DAT_ram_009d3e38 = 0;
		      if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		      }
		      iVar2 = *(int *)(*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x5c) + 4);
		      iVar3 = *(int *)(iVar2 + 0xc);
		      *(undefined4 *)(iVar2 + 0xc) = 0;
		      *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		      if (0 < iVar3) {
		        func_ii_2064(*(undefined4 *)(iVar2 + 8),0,iVar3,0);
		      }
		      return;
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x369,&local_18);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x060075A8 RID: 30120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075A8")]
		[Address(RVA = "0xBF35", Offset = "0xBF35", VA = "0xBF35")]
		public static void CancelCurrentGoogleTranslations()
		{
		/* --- GHIDRA: CancelCurrentGoogleTranslations ---
		void I2_Loc_GoogleTranslation__CancelCurrentGoogleTranslations
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59747 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__string__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__string__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__string__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string__get_Value__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_SpecializationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18958);
		    DAT_ram_00a59747 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  iVar1 = func_ii_7903(param1,StringLiteral_18958,0);
		  if (iVar1 == 0) {
		    if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		    }
		    func_ii_7910(param1,param2,param3,param4,&local_20);
		    return;
		  }
		  if (*(int *)(I2_Loc_SpecializationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_SpecializationManager_TypeInfo);
		  }
		  uVar2 = I2_Loc_SpecializationManager__SetSpecializedText(param1,0,&local_20);
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_18,uVar2,
		             Method_System_Collections_Generic_Dictionary_string__string__GetEnumerator__);
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x158,&local_18,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_string__string__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8105f3e8;
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    uVar2 = (undefined4)local_8;
		    if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 I2_Loc_GoogleTranslation_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiiii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x360,uVar2,param2,param3,param4,
		               &local_20);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8105f3e8:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x361,&local_20);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
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
		*/

		}

		// Token: 0x060075A9 RID: 30121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075A9")]
		[Address(RVA = "0xBF36", Offset = "0xBF36", VA = "0xBF36")]
		public static void CreateQueries(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		/* --- GHIDRA: CreateQueries ---
		void I2_Loc_GoogleTranslation__CreateQueries
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined1 auStack_60 [8];
		  undefined8 local_58;
		  undefined8 local_50;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  int local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59749 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_IndexOf_string___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TranslationQuery__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TranslationQuery__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TranslationQuery__set_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Concat_string___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Distinct_string___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_string___);
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    DAT_ram_00a59749 = '\x01';
		  }
		  iVar1 = func_ii_4769(param1,0);
		  if (iVar1 == 0) {
		    iVar1 = System_Collections_Generic_Dictionary_object__TranslationQuery___Clear
		                      (param4,param1,
		                       Method_System_Collections_Generic_Dictionary_string__TranslationQuery__ContainsKey__
		                      );
		    if (iVar1 == 0) {
		      local_c = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,1);
		      *(undefined4 *)(local_c + 0x10) = param3;
		      local_8 = 0;
		      local_18 = CONCAT44(param1,param1);
		      local_10 = param2;
		      if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		      }
		      I2_Loc_GoogleTranslation__GetGoogleNoTranslateTag(&local_18,auStack_60);
		      local_38 = CONCAT44(local_c,local_10);
		      local_30 = local_8;
		      local_40 = local_18;
		      System_Collections_Generic_Dictionary_object__TranslationQuery___get_Values
		                (param4,param1,&local_40,
		                 Method_System_Collections_Generic_Dictionary_string__TranslationQuery__set_Item__);
		    }
		    else {
		      System_Collections_Generic_Dictionary_object__TranslationQuery___get_Count
		                (&local_18,param4,param1,
		                 Method_System_Collections_Generic_Dictionary_string__TranslationQuery__get_Item__);
		      local_20 = local_10;
		      local_28 = local_18;
		      iVar1 = LunarConsolePlugin_CVar__set_Value
		                        (local_c,param3,Method_System_Array_IndexOf_string___);
		      if (iVar1 < 0) {
		        iVar1 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,1);
		        *(undefined4 *)(iVar1 + 0x10) = param3;
		        uVar2 = System_Collections_Generic_HashSet_Enumerator_uint___MoveNext
		                          (local_c,iVar1,Method_System_Linq_Enumerable_Concat_string___);
		        uVar2 = System_Linq_Enumerable__DefaultIfEmptyIterator___Il2CppFullySharedGenericType_
		                          (uVar2,Method_System_Linq_Enumerable_Distinct_string___);
		        local_c = func_ii_6295(uVar2,Method_System_Linq_Enumerable_ToArray_string___);
		      }
		      local_10 = local_20;
		      local_48 = local_8;
		      local_50 = CONCAT44(local_c,local_20);
		      local_18 = local_28;
		      local_58 = local_28;
		      System_Collections_Generic_Dictionary_object__TranslationQuery___get_Values
		                (param4,param1,&local_58,
		                 Method_System_Collections_Generic_Dictionary_string__TranslationQuery__set_Item__);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060075AA RID: 30122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075AA")]
		[Address(RVA = "0x1EE7", Offset = "0x1EE7", VA = "0x1EE7")]
		private static void CreateQueries_Plurals(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		// Token: 0x060075AB RID: 30123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075AB")]
		[Address(RVA = "0xBF37", Offset = "0xBF37", VA = "0xBF37")]
		public static void AddQuery(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		/* --- GHIDRA: AddQuery ---
		undefined4
		I2_Loc_GoogleTranslation__AddQuery
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 *puVar4;
		  undefined1 auStack_18 [12];
		  undefined4 local_c;
		  int local_8;
		  undefined4 *puVar3;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a5974a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_IndexOf_string___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TranslationQuery__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TranslationQuery__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5974a = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_object__TranslationQuery___Clear
		                    (param3,param1,
		                     Method_System_Collections_Generic_Dictionary_string__TranslationQuery__ContainsKey__
		                    );
		  if (iVar1 != 0) {
		    System_Collections_Generic_Dictionary_object__TranslationQuery___get_Count
		              (auStack_18,param3,param1,
		               Method_System_Collections_Generic_Dictionary_string__TranslationQuery__get_Item__);
		    iVar1 = LunarConsolePlugin_CVar__set_Value(local_c,param2,Method_System_Array_IndexOf_string___)
		    ;
		    puVar4 = (undefined4 *)(local_8 + iVar1 * 4 + 0x10);
		    if (local_8 == 0) {
		      puVar4 = &StringLiteral_5;
		    }
		    puVar3 = &StringLiteral_5;
		    if (-1 < iVar1) {
		      puVar3 = puVar4;
		    }
		    uVar2 = *puVar3;
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x060075AC RID: 30124 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075AC")]
		[Address(RVA = "0xBF38", Offset = "0xBF38", VA = "0xBF38")]
		private static string GetTranslation(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		/* --- GHIDRA: GetTranslation ---
		void I2_Loc_GoogleTranslation__GetTranslation
		               (undefined8 *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int local_50;
		  undefined8 *local_4c;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined4 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined4 uStack_1c;
		  undefined4 local_18;
		  undefined4 uStack_14;
		  undefined4 local_10;
		  undefined4 uStack_c;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a5974b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__TranslationQuery__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__TranslationQuery__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__TranslationQuery__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__TranslationQuery__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__TranslationQuery__get_Value__
		              );
		    DAT_ram_00a5974b = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uStack_c = 0;
		  local_18 = 0;
		  uStack_14 = 0;
		  local_20 = 0;
		  uStack_1c = 0;
		  local_28 = 0;
		  local_30 = 0;
		  System_Collections_Generic_Dictionary_uint__WorldSpaceData___FindEntry
		            (&local_30,param3,
		             Method_System_Collections_Generic_Dictionary_string__TranslationQuery__GetEnumerator__)
		  ;
		  local_50 = 0;
		  local_4c = &local_30;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x362,&local_30,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_string__TranslationQuery__MoveNext__
		                      );
		    uVar3 = local_20;
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8106173f:
		      iVar1 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar2) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar2 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_50 = iVar2;
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
		code_r0x81061795:
		          DAT_ram_009d3e38 = 0;
		          *param1 = 0;
		          param1[2] = 0;
		          param1[1] = 0;
		          return;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x368,&local_50);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
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
		    if (iVar2 == 0) goto code_r0x81061795;
		    local_40 = CONCAT44(local_10,uStack_14);
		    local_38 = uStack_c;
		    local_48 = CONCAT44(local_18,uStack_1c);
		    DAT_ram_009d3e38 = 0;
		    iVar2 = System_Collections_CollectionBase___ctor(local_20,param2,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8106173f;
		    }
		    if (iVar2 != 0) {
		      *(undefined4 *)param1 = uVar3;
		      *(undefined8 *)((int)param1 + 4) = local_48;
		      *(undefined8 *)((int)param1 + 0xc) = local_40;
		      *(undefined4 *)((int)param1 + 0x14) = local_38;
		      return;
		    }
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x060075AD RID: 30125 RVA: 0x000153D8 File Offset: 0x000135D8
		[Token(Token = "0x60075AD")]
		[Address(RVA = "0xBF39", Offset = "0xBF39", VA = "0xBF39")]
		private static TranslationQuery FindQueryFromOrigText(string origText, Dictionary<string, TranslationQuery> dict)
		{
		/* --- GHIDRA: FindQueryFromOrigText ---
		uint I2_Loc_GoogleTranslation__FindQueryFromOrigText(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  if (DAT_ram_00a5974c == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_28742);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19138);
		    DAT_ram_00a5974c = '\x01';
		  }
		  iVar1 = System_Xml_XmlTextEncoder__StartAttribute(param1,StringLiteral_28742,4,0);
		  if (iVar1 < 0) {
		    uVar2 = 0;
		  }
		  else {
		    iVar1 = func_ii_13789(param1,StringLiteral_19138,iVar1,4,0);
		    uVar2 = (uint)(0 < iVar1);
		  }
		  return uVar2;
		}
		*/

			return default(TranslationQuery);
		}

		// Token: 0x060075AE RID: 30126 RVA: 0x000153F0 File Offset: 0x000135F0
		[Token(Token = "0x60075AE")]
		[Address(RVA = "0xBF3A", Offset = "0xBF3A", VA = "0xBF3A")]
		public static bool HasParameters(string text)
		{
		/* --- GHIDRA: HasParameters ---
		undefined4 I2_Loc_GoogleTranslation__HasParameters(undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5974d == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_28743);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28742);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19138);
		    DAT_ram_00a5974d = '\x01';
		  }
		  param2_00 = System_Xml_XmlTextEncoder__StartAttribute(param1,StringLiteral_28743,4,0);
		  if (param2_00 < 0) {
		    if (param2 != 0) {
		      return 0;
		    }
		    param2_00 = System_Xml_XmlTextEncoder__StartAttribute(param1,StringLiteral_28742,4,0);
		    if (param2_00 < 0) {
		      return 0;
		    }
		  }
		  iVar1 = func_ii_13789(param1,StringLiteral_19138,param2_00 + 2,4,0);
		  if (iVar1 < 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = System_Data_DataSet__ReadXmlSchema(param1,param2_00,(iVar1 - param2_00) + 2,0);
		  }
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x060075AF RID: 30127 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075AF")]
		[Address(RVA = "0xBF3B", Offset = "0xBF3B", VA = "0xBF3B")]
		public static string GetPluralParameter(string text, bool forceTag)
		{
		/* --- GHIDRA: GetPluralParameter ---
		int I2_Loc_GoogleTranslation__GetPluralParameter(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5974e == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_18956);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19094);
		    DAT_ram_00a5974e = '\x01';
		  }
		  iVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (StringLiteral_18956,param2,StringLiteral_19094,0);
		  iVar2 = System_Xml_XmlTextEncoder__StartAttribute(param1,iVar1,4,0);
		  if (-1 < iVar2) {
		    iVar2 = *(int *)(iVar1 + 8) + iVar2;
		    iVar1 = func_ii_13789(param1,StringLiteral_18956,iVar2,4,0);
		    if (iVar1 < 0) {
		      iVar1 = *(int *)(param1 + 8);
		    }
		    uVar3 = System_Data_DataSet__ReadXmlSchema(param1,iVar2,iVar1 - iVar2,0);
		    return uVar3;
		  }
		  iVar1 = System_Xml_XmlTextEncoder__StartAttribute(param1,StringLiteral_18956,4,0);
		  if (-1 < iVar1) {
		    if (iVar1 != 0) {
		      uVar3 = System_Data_DataSet__ReadXmlSchema(param1,0,iVar1,0);
		      return uVar3;
		    }
		    iVar1 = System_Xml_XmlTextEncoder__StartAttribute(param1,StringLiteral_19094,4,0);
		    if (-1 < iVar1) {
		      iVar1 = iVar1 + 1;
		      iVar2 = func_ii_13789(param1,StringLiteral_18956,iVar1,4,0);
		      if (iVar2 < 0) {
		        iVar2 = *(int *)(param1 + 8);
		      }
		      param1 = System_Data_DataSet__ReadXmlSchema(param1,iVar1,iVar2 - iVar1,0);
		    }
		  }
		  return param1;
		}
		*/

			return null;
		}

		// Token: 0x060075B0 RID: 30128 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075B0")]
		[Address(RVA = "0xBF3C", Offset = "0xBF3C", VA = "0xBF3C")]
		public static string GetPluralText(string text, string pluralType)
		{
		/* --- GHIDRA: GetPluralText ---
		undefined4
		I2_Loc_GoogleTranslation__GetPluralText(undefined4 param1,int *param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  iVar1 = System_Text_RegularExpressions_MatchCollection__get_IsReadOnly(param2,0);
		  if (param3 < iVar1) {
		    do {
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x1d8) * 4))
		                        (param2,param3,*(undefined4 *)(*param2 + 0x1dc));
		      uVar2 = I2_Loc_I2Utils__FindObject(uVar2,0);
		      iVar3 = func_ii_3010(uVar2,0,0);
		      if (iVar3 == 0x2f) {
		        uVar2 = System_String__get_Chars(uVar2,1,0);
		        iVar3 = System_String__Substring(param1,uVar2,4,0);
		        if (iVar3 != 0) {
		          return param3;
		        }
		      }
		      param3 = param3 + 1;
		    } while (param3 != iVar1);
		  }
		  return 0xffffffff;
		}
		*/

			return null;
		}

		// Token: 0x060075B1 RID: 30129 RVA: 0x00015408 File Offset: 0x00013608
		[Token(Token = "0x60075B1")]
		[Address(RVA = "0xBF3D", Offset = "0xBF3D", VA = "0xBF3D")]
		private static int FindClosingTag(string tag, MatchCollection matches, int startIndex)
		{
		/* --- GHIDRA: FindClosingTag ---
		undefined4 I2_Loc_GoogleTranslation__FindClosingTag(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5974f == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_1226);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1228);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5974f = '\x01';
		  }
		  if (param1 < 0x46) {
		    uVar2 = System_Data_DataSet__ReadXmlSchema(StringLiteral_1228,0,param1 + 1,0);
		    return uVar2;
		  }
		  iVar1 = -1;
		  uVar2 = StringLiteral_5;
		  do {
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar2,StringLiteral_1226,0);
		    iVar1 = iVar1 + 1;
		  } while (iVar1 != param1);
		  return uVar2;
		}
		*/

			return 0;
		}

		// Token: 0x060075B2 RID: 30130 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075B2")]
		[Address(RVA = "0xBF3E", Offset = "0xBF3E", VA = "0xBF3E")]
		private static string GetGoogleNoTranslateTag(int tagNumber)
		{
		/* --- GHIDRA: GetGoogleNoTranslateTag ---
		void I2_Loc_GoogleTranslation__GetGoogleNoTranslateTag(int param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 uVar9;
		  uint uVar10;
		  int iVar11;
		  
		  iVar11 = 0;
		  if (DAT_ram_00a59750 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__get_Count__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_RegularExpressions_Regex_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28742);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24479);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19092);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19138);
		    DAT_ram_00a59750 = '\x01';
		  }
		  uVar9 = *(undefined4 *)(param1 + 4);
		  if (*(int *)(System_Text_RegularExpressions_Regex_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Text_RegularExpressions_Regex_TypeInfo);
		  }
		  param1_00 = (int *)System_Text_RegularExpressions_Regex__Match(uVar9,StringLiteral_19092,0);
		  if ((param1_00 != (int *)0x0) &&
		     (iVar1 = System_Text_RegularExpressions_MatchCollection__get_IsReadOnly(param1_00,0),
		     iVar1 != 0)) {
		    uVar9 = *(undefined4 *)(param1 + 4);
		    iVar1 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (iVar1,Method_System_Collections_Generic_List_string___ctor__);
		    iVar2 = System_Text_RegularExpressions_MatchCollection__get_IsReadOnly(param1_00,0);
		    if (0 < iVar2) {
		      do {
		        uVar3 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x1d8) * 4))
		                          (param1_00,iVar11,*(undefined4 *)(*param1_00 + 0x1dc));
		        uVar3 = I2_Loc_I2Utils__FindObject(uVar3,0);
		        if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		        }
		        iVar4 = System_Text_RegularExpressions_MatchCollection__get_IsReadOnly(param1_00,0);
		        iVar7 = iVar11;
		        if (iVar11 < iVar4) {
		code_r0x8105fe01:
		          uVar8 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x1d8) * 4))
		                            (param1_00,iVar7,*(undefined4 *)(*param1_00 + 0x1dc));
		          uVar8 = I2_Loc_I2Utils__FindObject(uVar8,0);
		          iVar5 = func_ii_3010(uVar8,0,0);
		          if (iVar5 != 0x2f) goto code_r0x8105fe45;
		          uVar8 = System_String__get_Chars(uVar8,1,0);
		          iVar5 = System_String__Substring(uVar3,uVar8,4,0);
		          if (iVar5 == 0) goto code_r0x8105fe45;
		          if (-1 < iVar7) {
		            iVar4 = System_Collections_CollectionBase___ctor(uVar3,StringLiteral_24479,0);
		            if (iVar4 == 0) {
		              piVar6 = (int *)(**(code **)((ulonglong)*(uint *)(*param1_00 + 0x1d8) * 4))
		                                        (param1_00,iVar11,*(undefined4 *)(*param1_00 + 0x1dc));
		              uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar6 + 0xd8) * 4))
		                                (piVar6,*(undefined4 *)(*piVar6 + 0xdc));
		              iVar4 = *(int *)(iVar1 + 0xc);
		              if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		                func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		              }
		              if (DAT_ram_00a5974f == '\0') {
		                Mono_Security_ASN1__get_Item(&StringLiteral_1226);
		                Mono_Security_ASN1__get_Item(&StringLiteral_1228);
		                Mono_Security_ASN1__get_Item(&StringLiteral_5);
		                DAT_ram_00a5974f = '\x01';
		              }
		              if (iVar4 < 0x46) {
		                uVar8 = System_Data_DataSet__ReadXmlSchema(StringLiteral_1228,0,iVar4 + 1,0);
		              }
		              else {
		                iVar5 = -1;
		                uVar8 = StringLiteral_5;
		                do {
		                  uVar8 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar8,StringLiteral_1226,0)
		                  ;
		                  iVar5 = iVar5 + 1;
		                } while (iVar5 != iVar4);
		              }
		              uVar8 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar8,StringLiteral_118,0);
		              uVar9 = func_ii_7088(uVar9,uVar3,uVar8,0);
		              iVar4 = Method_System_Collections_Generic_List_string__Add__;
		              *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		              uVar10 = *(uint *)(iVar1 + 0xc);
		              if (uVar10 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		                *(uint *)(iVar1 + 0xc) = uVar10 + 1;
		                *(undefined4 *)(*(int *)(iVar1 + 8) + uVar10 * 4 + 0x10) = uVar3;
		              }
		              else {
		                System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                          (iVar1,uVar3,
		                           *(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		              }
		              piVar6 = (int *)(**(code **)((ulonglong)*(uint *)(*param1_00 + 0x1d8) * 4))
		                                        (param1_00,iVar7,*(undefined4 *)(*param1_00 + 0x1dc));
		              uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar6 + 0xd8) * 4))
		                                (piVar6,*(undefined4 *)(*piVar6 + 0xdc));
		              iVar7 = *(int *)(iVar1 + 0xc);
		              if (DAT_ram_00a5974f == '\0') {
		                Mono_Security_ASN1__get_Item(&StringLiteral_1226);
		                Mono_Security_ASN1__get_Item(&StringLiteral_1228);
		                Mono_Security_ASN1__get_Item(&StringLiteral_5);
		                DAT_ram_00a5974f = '\x01';
		              }
		              if (iVar7 < 0x46) {
		                uVar8 = System_Data_DataSet__ReadXmlSchema(StringLiteral_1228,0,iVar7 + 1,0);
		              }
		              else {
		                iVar4 = -1;
		                uVar8 = StringLiteral_5;
		                do {
		                  uVar8 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar8,StringLiteral_1226,0)
		                  ;
		                  iVar4 = iVar4 + 1;
		                } while (iVar4 != iVar7);
		              }
		              uVar8 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar8,StringLiteral_118,0);
		              uVar9 = func_ii_7088(uVar9,uVar3,uVar8,0);
		              iVar7 = Method_System_Collections_Generic_List_string__Add__;
		              *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		              uVar10 = *(uint *)(iVar1 + 0xc);
		              if (uVar10 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		                *(uint *)(iVar1 + 0xc) = uVar10 + 1;
		                *(undefined4 *)(*(int *)(iVar1 + 8) + uVar10 * 4 + 0x10) = uVar3;
		              }
		              else {
		                System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                          (iVar1,uVar3,
		                           *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		              }
		            }
		            else {
		              uVar3 = *(undefined4 *)(param1 + 4);
		              iVar4 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x1d8) * 4))
		                                (param1_00,iVar11,*(undefined4 *)(*param1_00 + 0x1dc));
		              uVar8 = *(undefined4 *)(iVar4 + 8);
		              iVar4 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x1d8) * 4))
		                                (param1_00,iVar7,*(undefined4 *)(*param1_00 + 0x1dc));
		              iVar5 = *(int *)(iVar4 + 8);
		              iVar4 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x1d8) * 4))
		                                (param1_00,iVar11,*(undefined4 *)(*param1_00 + 0x1dc));
		              iVar4 = *(int *)(iVar4 + 8);
		              iVar7 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x1d8) * 4))
		                                (param1_00,iVar7,*(undefined4 *)(*param1_00 + 0x1dc));
		              uVar3 = System_Data_DataSet__ReadXmlSchema
		                                (uVar3,uVar8,(iVar5 - iVar4) + *(int *)(iVar7 + 0xc),0);
		              iVar7 = *(int *)(iVar1 + 0xc);
		              if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		                func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		              }
		              if (DAT_ram_00a5974f == '\0') {
		                Mono_Security_ASN1__get_Item(&StringLiteral_1226);
		                Mono_Security_ASN1__get_Item(&StringLiteral_1228);
		                Mono_Security_ASN1__get_Item(&StringLiteral_5);
		                DAT_ram_00a5974f = '\x01';
		              }
		              if (iVar7 < 0x46) {
		                uVar8 = System_Data_DataSet__ReadXmlSchema(StringLiteral_1228,0,iVar7 + 1,0);
		              }
		              else {
		                iVar4 = -1;
		                uVar8 = StringLiteral_5;
		                do {
		                  uVar8 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar8,StringLiteral_1226,0)
		                  ;
		                  iVar4 = iVar4 + 1;
		                } while (iVar4 != iVar7);
		              }
		              uVar8 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar8,StringLiteral_118,0);
		              uVar9 = func_ii_7088(uVar9,uVar3,uVar8,0);
		              iVar7 = Method_System_Collections_Generic_List_string__Add__;
		              *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		              uVar10 = *(uint *)(iVar1 + 0xc);
		              if (uVar10 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		                *(uint *)(iVar1 + 0xc) = uVar10 + 1;
		                *(undefined4 *)(*(int *)(iVar1 + 8) + uVar10 * 4 + 0x10) = uVar3;
		              }
		              else {
		                System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                          (iVar1,uVar3,
		                           *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		              }
		            }
		            goto code_r0x810603e1;
		          }
		        }
		code_r0x8105fe5d:
		        piVar6 = (int *)(**(code **)((ulonglong)*(uint *)(*param1_00 + 0x1d8) * 4))
		                                  (param1_00,iVar11,*(undefined4 *)(*param1_00 + 0x1dc));
		        uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar6 + 0xd8) * 4))
		                          (piVar6,*(undefined4 *)(*piVar6 + 0xdc));
		        iVar7 = System_String__Substring(uVar3,StringLiteral_28742,4,0);
		        if ((iVar7 != 0) && (iVar7 = func_ii_16527(uVar3,StringLiteral_19138,4,0), iVar7 != 0)) {
		          iVar7 = *(int *)(iVar1 + 0xc);
		          if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		          }
		          if (DAT_ram_00a5974f == '\0') {
		            Mono_Security_ASN1__get_Item(&StringLiteral_1226);
		            Mono_Security_ASN1__get_Item(&StringLiteral_1228);
		            Mono_Security_ASN1__get_Item(&StringLiteral_5);
		            DAT_ram_00a5974f = '\x01';
		          }
		          if (iVar7 < 0x46) {
		            uVar8 = System_Data_DataSet__ReadXmlSchema(StringLiteral_1228,0,iVar7 + 1,0);
		          }
		          else {
		            iVar4 = -1;
		            uVar8 = StringLiteral_5;
		            do {
		              uVar8 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar8,StringLiteral_1226,0);
		              iVar4 = iVar4 + 1;
		            } while (iVar4 != iVar7);
		          }
		          uVar8 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar8,StringLiteral_118,0);
		          uVar9 = func_ii_7088(uVar9,uVar3,uVar8,0);
		          iVar7 = Method_System_Collections_Generic_List_string__Add__;
		          *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		          uVar10 = *(uint *)(iVar1 + 0xc);
		          if (uVar10 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		            *(uint *)(iVar1 + 0xc) = uVar10 + 1;
		            *(undefined4 *)(*(int *)(iVar1 + 8) + uVar10 * 4 + 0x10) = uVar3;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (iVar1,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		          }
		        }
		code_r0x810603e1:
		        iVar11 = iVar11 + 1;
		      } while (iVar11 != iVar2);
		    }
		    *(undefined4 *)(param1 + 4) = uVar9;
		    uVar9 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                      (iVar1,Method_System_Collections_Generic_List_string__ToArray__);
		    *(undefined4 *)(param1 + 0x14) = uVar9;
		  }
		  return;
		code_r0x8105fe45:
		  iVar7 = iVar7 + 1;
		  if (iVar7 == iVar4) goto code_r0x8105fe5d;
		  goto code_r0x8105fe01;
		}
		*/

			return null;
		}

		// Token: 0x060075B3 RID: 30131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075B3")]
		[Address(RVA = "0xBF3F", Offset = "0xBF3F", VA = "0xBF3F")]
		private static void ParseNonTranslatableElements(ref TranslationQuery query)
		{
		/* --- GHIDRA: ParseNonTranslatableElements ---
		undefined4
		I2_Loc_GoogleTranslation__ParseNonTranslatableElements
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined1 auStack_18 [12];
		  undefined4 local_c;
		  int local_8;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a59751 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_IndexOf_string___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TranslationQuery__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TranslationQuery__get_Item__);
		    DAT_ram_00a59751 = '\x01';
		  }
		  iVar2 = System_Collections_Generic_Dictionary_object__TranslationQuery___Clear
		                    (param3,param1,
		                     Method_System_Collections_Generic_Dictionary_string__TranslationQuery__ContainsKey__
		                    );
		  if (((iVar2 != 0) &&
		      (System_Collections_Generic_Dictionary_object__TranslationQuery___get_Count
		                 (auStack_18,param3,param1,
		                  Method_System_Collections_Generic_Dictionary_string__TranslationQuery__get_Item__)
		      , local_8 != 0)) && (-1 < *(int *)(local_8 + 0xc))) {
		    iVar2 = 0;
		    iVar3 = func_ii_4769(param2,0);
		    if ((iVar3 != 0) ||
		       (iVar2 = LunarConsolePlugin_CVar__set_Value
		                          (local_c,param2,Method_System_Array_IndexOf_string___), -1 < iVar2)) {
		      uVar1 = *(undefined4 *)(local_8 + iVar2 * 4 + 0x10);
		    }
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x060075B4 RID: 30132 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075B4")]
		[Address(RVA = "0xBF40", Offset = "0xBF40", VA = "0xBF40")]
		public static string GetQueryResult(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		/* --- GHIDRA: GetQueryResult ---
		undefined4
		I2_Loc_GoogleTranslation__GetQueryResult
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 uStack_c;
		  undefined4 local_8;
		  undefined4 uStack_4;
		  
		  if (DAT_ram_00a59752 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__string__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__string__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__string__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string__get_Value__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_SpecializationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_StringComparer_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18958);
		    DAT_ram_00a59752 = '\x01';
		  }
		  local_8 = 0;
		  uStack_4 = 0;
		  local_10 = 0;
		  uStack_c = 0;
		  local_18 = 0;
		  iVar1 = func_ii_7903(param1,StringLiteral_18958,0);
		  if (iVar1 == 0) {
		    if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		    }
		    uVar2 = func_ii_7920(param1,param2,param3,&local_20);
		    return uVar2;
		  }
		  if (*(int *)(I2_Loc_SpecializationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_SpecializationManager_TypeInfo);
		  }
		  uVar2 = I2_Loc_SpecializationManager__SetSpecializedText(param1,0,&local_20);
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
		  uVar5 = *(undefined4 *)(*(int *)(System_StringComparer_TypeInfo + 0x5c) + 8);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData____ctor
		            (param1_00,uVar5,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_18,uVar2,
		             Method_System_Collections_Generic_Dictionary_string__string__GetEnumerator__);
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x158,&local_18,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_string__string__MoveNext__
		                      );
		    uVar5 = local_8;
		    uVar2 = uStack_c;
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810621f9;
		    }
		    if (iVar3 == 0) goto code_r0x8106224f;
		    if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 I2_Loc_GoogleTranslation_TypeInfo);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810621f9;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x36a,uVar5,param2,param3,
		                       &local_20);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x84,param1_00,uVar2,uVar5,
		               Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810621f9:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x8106224f:
		      DAT_ram_009d3e38 = 0;
		      if (*(int *)(I2_Loc_SpecializationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_SpecializationManager_TypeInfo);
		      }
		      uVar2 = I2_Loc_SpecializationManager__SetSpecializedText(param1_00,&local_20);
		      return uVar2;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x36b,&local_20);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(uVar2);
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
		*/

			return null;
		}

		// Token: 0x060075B5 RID: 30133 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075B5")]
		[Address(RVA = "0xBF41", Offset = "0xBF41", VA = "0xBF41")]
		public static string RebuildTranslation(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
		/* --- GHIDRA: RebuildTranslation ---
		void I2_Loc_GoogleTranslation__RebuildTranslation(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59755 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TranslationJob___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_UnityWebRequest___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_TranslationJob__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_UnityWebRequest__TypeInfo);
		    DAT_ram_00a59755 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_UnityWebRequest__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_UnityWebRequest___ctor__);
		  **(undefined4 **)(I2_Loc_GoogleTranslation_TypeInfo + 0x5c) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_TranslationJob__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_TranslationJob___ctor__);
		  *(undefined4 *)(*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x5c) + 4) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060075B6 RID: 30134 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075B6")]
		[Address(RVA = "0x1EF1", Offset = "0x1EF1", VA = "0x1EF1")]
		private static string RebuildTranslation_Plural(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			return null;
		}

		// Token: 0x060075B7 RID: 30135 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075B7")]
		[Address(RVA = "0x35E1", Offset = "0x35E1", VA = "0x35E1")]
		public static string UppercaseFirst(string s)
		{
		/* --- GHIDRA: UppercaseFirst ---
		undefined4 I2_Loc_GoogleTranslation__UppercaseFirst(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a59754 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    DAT_ram_00a59754 = '\x01';
		  }
		  iVar1 = func_ii_4769(param1,0);
		  if (iVar1 != 0) {
		    return **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  }
		  if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		  }
		  piVar2 = (int *)System_String__StartsWith(0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x110) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x114));
		  uVar3 = I2_Loc_GoogleLanguages__GetGoogleLanguageCode(uVar3,param1,0);
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x060075B8 RID: 30136 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075B8")]
		[Address(RVA = "0x35E2", Offset = "0x35E2", VA = "0x35E2")]
		public static string TitleCase(string s)
		{
			return null;
		}

		// Token: 0x04003D6E RID: 15726
		[Token(Token = "0x4003D6E")]
		[FieldOffset(Offset = "0x0")]
		private static List<UnityWebRequest> mCurrentTranslations;

		// Token: 0x04003D6F RID: 15727
		[Token(Token = "0x4003D6F")]
		[FieldOffset(Offset = "0x4")]
		private static List<TranslationJob> mTranslationJobs;

		// Token: 0x0200135B RID: 4955
		// (Invoke) Token: 0x060075BB RID: 30139
		[Token(Token = "0x200135B")]
		public delegate void fnOnTranslated(string Translation, string Error);

		// Token: 0x0200135C RID: 4956
		// (Invoke) Token: 0x060075BF RID: 30143
		[Token(Token = "0x200135C")]
		public delegate void fnOnTranslationReady(Dictionary<string, TranslationQuery> dict, string error);
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: .cctor ---
		void I2_Loc_GoogleTranslation___cctor(int param1,int param2,int param3,undefined4 param4)
		
		{
		  char cVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  uVar3 = *(undefined4 *)(param3 + 4);
		  *(int *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = uVar3;
		  *(int *)(param1 + 0x10) = param2;
		  cVar1 = *(char *)(param3 + 0x2e);
		  *(int *)(param1 + 0x20) = param1;
		  iVar2 = func_ii_4538(param3);
		  if (iVar2 == 0) {
		    if (cVar1 == '\x01') {
		      *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Player_ram_000035bf + 0x14;
		    }
		    else {
		      if (param2 == 0) {
		        uVar3 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                          (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		        func_ii_1050(uVar3,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		      *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		    }
		  }
		  else if (cVar1 == '\x02') {
		    *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Player_ram_000035bf + 0x13;
		  }
		  else {
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  *(char **)(param1 + 0x1c) = s___Scripting__UnityEngine__Player_ram_000035bf + 0x15;
		  return;
		}
		*/

}
