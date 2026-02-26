using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200137B RID: 4987
	[Token(Token = "0x200137B")]
	public static class LocalizationManager
	{
		// Token: 0x0600768D RID: 30349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600768D")]
		[Address(RVA = "0xC004", Offset = "0xC004", VA = "0xC004")]
		public static void InitializeIfNeeded()
		{
		/* --- GHIDRA: InitializeIfNeeded ---
		undefined4 I2_Loc_LocalizationManager__InitializeIfNeeded(undefined4 param1)
		
		{
		  if (DAT_ram_00a604e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_1966);
		    DAT_ram_00a604e4 = '\x01';
		  }
		  return StringLiteral_1966;
		}
		*/

		}

		// Token: 0x0600768E RID: 30350 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600768E")]
		[Address(RVA = "0xC005", Offset = "0xC005", VA = "0xC005")]
		public static string GetVersion()
		{
		/* --- GHIDRA: GetVersion ---
		undefined4 I2_Loc_LocalizationManager__GetVersion(undefined4 param1)
		
		{
		  return 5;
		}
		*/

			return null;
		}

		// Token: 0x0600768F RID: 30351 RVA: 0x000157B0 File Offset: 0x000139B0
		[Token(Token = "0x600768F")]
		[Address(RVA = "0xC006", Offset = "0xC006", VA = "0xC006")]
		public static int GetRequiredWebServiceVersion()
		{
		/* --- GHIDRA: GetRequiredWebServiceVersion ---
		undefined4 I2_Loc_LocalizationManager__GetRequiredWebServiceVersion(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a604e5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604e5 = '\x01';
		  }
		  if ((param1 != 0) && (iVar1 = func_ii_4769(*(undefined4 *)(param1 + 0x30),0), iVar1 == 0)) {
		    return *(undefined4 *)(param1 + 0x30);
		  }
		  iVar1 = I2_Loc_LocalizationManager_TypeInfo;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizeDropdown___ctor(iVar1);
		  iVar1 = 0;
		  do {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    iVar2 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c);
		    if (*(int *)(iVar2 + 0xc) <= iVar1) {
		      return **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		    }
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      iVar2 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c);
		    }
		    iVar2 = System_Linq_Enumerable__ToList_object_
		                      (iVar2,iVar1,
		                       Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    if (iVar2 != 0) {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)
		                          (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),iVar1,
		                         Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		      iVar2 = func_ii_4769(*(undefined4 *)(iVar2 + 0x30),0);
		      if (iVar2 == 0) {
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        iVar1 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)
		                            (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),iVar1,
		                           Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		        return *(undefined4 *)(iVar1 + 0x30);
		      }
		    }
		    iVar1 = iVar1 + 1;
		  } while( true );
		}
		*/

			return 0;
		}

		// Token: 0x06007690 RID: 30352 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007690")]
		[Address(RVA = "0xC007", Offset = "0xC007", VA = "0xC007")]
		public static string GetWebServiceURL([Optional] LanguageSourceData source)
		{
		/* --- GHIDRA: GetWebServiceURL ---
		undefined4 I2_Loc_LocalizationManager__GetWebServiceURL(undefined4 param1)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a604e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604e6 = '\x01';
		  }
		  param1_00 = I2_Loc_LocalizationManager_TypeInfo;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizeDropdown___ctor(param1_00);
		  return **(undefined4 **)(I2_Loc_LocalizationManager_TypeInfo + 0x5c);
		}
		*/

			return null;
		}

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x06007691 RID: 30353 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06007692 RID: 30354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017AB")]
		public static string CurrentLanguage
		{
			[Token(Token = "0x6007691")]
			[Address(RVA = "0xC008", Offset = "0xC008", VA = "0xC008")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007692")]
			[Address(RVA = "0xC009", Offset = "0xC009", VA = "0xC009")]
			set
			{
			}
		}

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x06007693 RID: 30355 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06007694 RID: 30356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017AC")]
		public static string CurrentLanguageCode
		{
			[Token(Token = "0x6007693")]
			[Address(RVA = "0xC00A", Offset = "0xC00A", VA = "0xC00A")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007694")]
			[Address(RVA = "0xC00B", Offset = "0xC00B", VA = "0xC00B")]
			set
			{
			}
		}

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x06007695 RID: 30357 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06007696 RID: 30358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017AD")]
		public static string CurrentRegion
		{
			[Token(Token = "0x6007695")]
			[Address(RVA = "0xC00C", Offset = "0xC00C", VA = "0xC00C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007696")]
			[Address(RVA = "0xC00D", Offset = "0xC00D", VA = "0xC00D")]
			set
			{
			}
		}

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x06007697 RID: 30359 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06007698 RID: 30360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017AE")]
		public static string CurrentRegionCode
		{
			[Token(Token = "0x6007697")]
			[Address(RVA = "0xC00E", Offset = "0xC00E", VA = "0xC00E")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007698")]
			[Address(RVA = "0xC00F", Offset = "0xC00F", VA = "0xC00F")]
			set
			{
			}
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x06007699 RID: 30361 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017AF")]
		public static CultureInfo CurrentCulture
		{
			[Token(Token = "0x6007699")]
			[Address(RVA = "0xC010", Offset = "0xC010", VA = "0xC010")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600769A RID: 30362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600769A")]
		[Address(RVA = "0xC011", Offset = "0xC011", VA = "0xC011")]
		public static void SetLanguageAndCode(string LanguageName, string LanguageCode, bool RememberLanguage = true, bool Force = false)
		{
		/* --- GHIDRA: SetLanguageAndCode ---
		undefined4 I2_Loc_LocalizationManager__SetLanguageAndCode(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  undefined4 *param2_00;
		  
		  if (DAT_ram_00a604f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    DAT_ram_00a604f0 = '\x01';
		  }
		  if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		               System_Globalization_CultureInfo_TypeInfo);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) goto code_r0x81c9ea19;
		    uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		code_r0x81c9ea19:
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iii(s___Scripting__UnityEngine__Contex_ram_0000360b + 0xd,param1,0);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		      DAT_ram_009d3e38 = 0;
		      return uVar1;
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar4 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar2) {
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
		          import::env::__cxa_end_catch();
		          iVar4 = unnamed_function_2232(&System_Globalization_CultureInfo_TypeInfo);
		          if (*(int *)(iVar4 + 0x74) == 0) {
		            func_ii_306000(iVar4);
		          }
		          uVar1 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		          return uVar1;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81c9eb80;
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
		code_r0x81c9eb80:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600769B RID: 30363 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600769B")]
		[Address(RVA = "0xC012", Offset = "0xC012", VA = "0xC012")]
		private static CultureInfo CreateCultureForCode(string code)
		{
		/* --- GHIDRA: CreateCultureForCode ---
		void I2_Loc_LocalizationManager__CreateCultureForCode(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a604f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604f1 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  if ((*(char *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xc) == '\0') &&
		     (param1 != 0)) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    if (DAT_ram_00a604f2 == '\0') {
		      Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		      DAT_ram_00a604f2 = '\x01';
		    }
		    param1_00 = func_ii_8975(0);
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    System_Threading_Thread__get_CurrentCulture
		              (param1_00,*(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 8),0
		              );
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  *(char *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xc) = (char)param1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600769C RID: 30364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600769C")]
		[Address(RVA = "0xC013", Offset = "0xC013", VA = "0xC013")]
		public static void EnableChangingCultureInfo(bool bEnable)
		{
		/* --- GHIDRA: EnableChangingCultureInfo ---
		void I2_Loc_LocalizationManager__EnableChangingCultureInfo(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a604f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604f2 = '\x01';
		  }
		  param1_00 = func_ii_8975(0);
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  System_Threading_Thread__get_CurrentCulture
		            (param1_00,*(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 8),0);
		  return;
		}
		*/

		}

		// Token: 0x0600769D RID: 30365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600769D")]
		[Address(RVA = "0xC014", Offset = "0xC014", VA = "0xC014")]
		private static void SetCurrentCultureInfo()
		{
		/* --- GHIDRA: SetCurrentCultureInfo ---
		void I2_Loc_LocalizationManager__SetCurrentCultureInfo(undefined4 param1)
		
		{
		  int param2;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a604f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8918);
		    DAT_ram_00a604f3 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  if (*(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc) != 0) {
		    uVar1 = Mycom_Tracker_Unity_Ads_AdFormat___cctor
		                      (StringLiteral_8918,**(undefined4 **)(DAT_ram_00a66978 + 0x5c),0);
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    uVar2 = I2_Loc_LocalizationManager__ApplyDownloadedDataFromGoogle(0,uVar1);
		    iVar3 = func_ii_4769(uVar1,0);
		    if (iVar3 == 0) {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      iVar3 = I2_Loc_LocalizationManager__SelectStartupLanguage(uVar1,1,0,1,uVar1);
		      if (iVar3 != 0) {
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        uVar2 = I2_Loc_LocalizationManager__GetSupportedLanguage(uVar1,uVar1);
		        I2_Loc_LocalizationManager__get_CurrentCulture(uVar1,uVar2,1,0,uVar1);
		        return;
		      }
		    }
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    iVar4 = System_Linq_Enumerable__ToList_object_
		                      (*(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),
		                       0,Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    iVar3 = I2_Loc_LocalizationManager_TypeInfo;
		    if (*(char *)(iVar4 + 0x28) == '\0') {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      uVar1 = I2_Loc_LocalizationManager__HasLanguage(uVar2,1,iVar3);
		      iVar3 = func_ii_4769(uVar1,0);
		      if (iVar3 == 0) {
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        uVar2 = I2_Loc_LocalizationManager__GetSupportedLanguage(uVar1,uVar1);
		        I2_Loc_LocalizationManager__get_CurrentCulture(uVar1,uVar2,0,0,uVar1);
		        return;
		      }
		    }
		    iVar3 = 0;
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    iVar4 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc);
		    if (0 < iVar4) {
		      do {
		        param2 = 0;
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        iVar5 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)
		                            (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),iVar3,
		                           Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		        if (0 < *(int *)(*(int *)(iVar5 + 0x24) + 0xc)) {
		          while( true ) {
		            if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		              func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		            }
		            iVar5 = System_Linq_Enumerable__ToList_object_
		                              (*(undefined4 *)
		                                (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),iVar3,
		                               Method_System_Collections_Generic_List_LanguageSourceData__get_Item__
		                              );
		            if (*(int *)(*(int *)(iVar5 + 0x24) + 0xc) <= param2) break;
		            if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		              func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		            }
		            iVar5 = System_Linq_Enumerable__ToList_object_
		                              (*(undefined4 *)
		                                (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),iVar3,
		                               Method_System_Collections_Generic_List_LanguageSourceData__get_Item__
		                              );
		            iVar5 = System_Linq_Enumerable__ToList_object_
		                              (*(undefined4 *)(iVar5 + 0x24),param2,
		                               Method_System_Collections_Generic_List_LanguageData__get_Item__);
		            if ((*(byte *)(iVar5 + 0x10) & 1) == 0) {
		              if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		                func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		              }
		              iVar4 = System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)
		                                  (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),
		                                 iVar3,
		                                 Method_System_Collections_Generic_List_LanguageSourceData__get_Item__
		                                );
		              iVar4 = System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)(iVar4 + 0x24),param2,
		                                 Method_System_Collections_Generic_List_LanguageData__get_Item__);
		              uVar1 = *(undefined4 *)(iVar4 + 8);
		              iVar3 = System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)
		                                  (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),
		                                 iVar3,
		                                 Method_System_Collections_Generic_List_LanguageSourceData__get_Item__
		                                );
		              iVar3 = System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)(iVar3 + 0x24),param2,
		                                 Method_System_Collections_Generic_List_LanguageData__get_Item__);
		              I2_Loc_LocalizationManager__get_CurrentCulture
		                        (uVar1,*(undefined4 *)(iVar3 + 0xc),0,0,param2);
		              return;
		            }
		            param2 = param2 + 1;
		          }
		        }
		        iVar3 = iVar3 + 1;
		      } while (iVar3 != iVar4);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600769E RID: 30366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600769E")]
		[Address(RVA = "0xC015", Offset = "0xC015", VA = "0xC015")]
		private static void SelectStartupLanguage()
		{
		/* --- GHIDRA: SelectStartupLanguage ---
		uint I2_Loc_LocalizationManager__SelectStartupLanguage
		               (undefined4 param1,int param2,int param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a604f4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604f4 = '\x01';
		  }
		  iVar1 = I2_Loc_LocalizationManager_TypeInfo;
		  if (param3 != 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    I2_Loc_LocalizeDropdown___ctor(iVar1);
		  }
		  iVar1 = 0;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar5 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc);
		  if (0 < iVar5) {
		    do {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      uVar3 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)
		                          (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),iVar1,
		                         Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		      iVar4 = I2_Loc_LanguageSourceData__Import_Google_Result(uVar3,param1,0,param4,iVar1);
		      if (-1 < iVar4) {
		        return 1;
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar5);
		  }
		  uVar2 = 0;
		  if (param2 != 0) {
		    iVar1 = 0;
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    iVar5 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc);
		    if (iVar5 < 1) {
		      return 0;
		    }
		    do {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      uVar3 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)
		                          (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),iVar1,
		                         Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		      iVar4 = I2_Loc_LanguageSourceData__Import_Google_Result(uVar3,param1,1,param4,iVar1);
		      uVar2 = (uint)(-1 < iVar4);
		    } while ((uVar2 == 0) && (iVar1 = iVar1 + 1, iVar1 != iVar5));
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x0600769F RID: 30367 RVA: 0x000157C8 File Offset: 0x000139C8
		[Token(Token = "0x600769F")]
		[Address(RVA = "0xC016", Offset = "0xC016", VA = "0xC016")]
		public static bool HasLanguage(string Language, bool AllowDiscartingRegion = true, bool Initialize = true, bool SkipDisabled = true)
		{
		/* --- GHIDRA: HasLanguage ---
		undefined4
		I2_Loc_LocalizationManager__HasLanguage(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a604f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleLanguages_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604f5 = '\x01';
		  }
		  if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		  }
		  uVar2 = I2_Loc_EventCallback___ctor(param1,0,0);
		  iVar3 = func_ii_4769(uVar2,0);
		  if (iVar3 == 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    iVar3 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc);
		    if (0 < iVar3) {
		      iVar1 = 0;
		      do {
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        uVar4 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)
		                            (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),iVar1,
		                           Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		        iVar5 = I2_Loc_LanguageSourceData__IsCurrentLanguage(uVar4,uVar2,1,param2,iVar1);
		        if (-1 < iVar5) {
		          if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		          }
		          iVar3 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)
		                              (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),iVar1,
		                             Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		          iVar3 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(iVar3 + 0x24),iVar5,
		                             Method_System_Collections_Generic_List_LanguageData__get_Item__);
		          return *(undefined4 *)(iVar3 + 8);
		        }
		        iVar1 = iVar1 + 1;
		      } while (iVar1 != iVar3);
		    }
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    iVar3 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc);
		    if (0 < iVar3) {
		      iVar1 = 0;
		      do {
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        uVar4 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)
		                            (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),iVar1,
		                           Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		        iVar5 = I2_Loc_LanguageSourceData__IsCurrentLanguage(uVar4,uVar2,0,param2,iVar1);
		        if (-1 < iVar5) {
		          if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		          }
		          iVar3 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)
		                              (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),iVar1,
		                             Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		          iVar3 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(iVar3 + 0x24),iVar5,
		                             Method_System_Collections_Generic_List_LanguageData__get_Item__);
		          return *(undefined4 *)(iVar3 + 8);
		        }
		        iVar1 = iVar1 + 1;
		      } while (iVar1 != iVar3);
		    }
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar3 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc);
		  if (0 < iVar3) {
		    iVar1 = 0;
		    do {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      uVar2 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)
		                          (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),iVar1,
		                         Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		      iVar5 = I2_Loc_LanguageSourceData__Import_Google_Result(uVar2,param1,0,param2,iVar1);
		      if (-1 < iVar5) {
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        iVar3 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)
		                            (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),iVar1,
		                           Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		        iVar3 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(iVar3 + 0x24),iVar5,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        return *(undefined4 *)(iVar3 + 8);
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar3);
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar3 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc);
		  if (0 < iVar3) {
		    iVar1 = 0;
		    do {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      uVar2 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)
		                          (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),iVar1,
		                         Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		      iVar5 = I2_Loc_LanguageSourceData__Import_Google_Result(uVar2,param1,1,param2,iVar1);
		      if (-1 < iVar5) {
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        iVar3 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)
		                            (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),iVar1,
		                           Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		        iVar3 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(iVar3 + 0x24),iVar5,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        return *(undefined4 *)(iVar3 + 8);
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar3);
		  }
		  return **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		}
		*/

			return default(bool);
		}

		// Token: 0x060076A0 RID: 30368 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076A0")]
		[Address(RVA = "0xC017", Offset = "0xC017", VA = "0xC017")]
		public static string GetSupportedLanguage(string Language, bool ignoreDisabled = false)
		{
		/* --- GHIDRA: GetSupportedLanguage ---
		undefined4 I2_Loc_LocalizationManager__GetSupportedLanguage(undefined4 param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int param2_01;
		  int iVar1;
		  
		  if (DAT_ram_00a604f6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604f6 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  if (*(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc) == 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    if (DAT_ram_00a60508 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		      Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		      DAT_ram_00a60508 = '\x01';
		    }
		    iVar1 = I2_Loc_LocalizationManager_TypeInfo;
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    I2_Loc_LocalizationManager__UpdateSources(iVar1);
		    I2_Loc_LocalizationManager__RegisterSceneSources(iVar1);
		    I2_Loc_LocalizationManager__UnregisterDeletededSources(iVar1);
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar1 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc);
		  if (0 < iVar1) {
		    param2_00 = 0;
		    do {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      param1_00 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)
		                              (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),
		                             param2_00,
		                             Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		      param2_01 = I2_Loc_LanguageSourceData__Import_Google_Result(param1_00,param1,1,1,param2_00);
		      if (-1 < param2_01) {
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        iVar1 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)
		                            (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),param2_00,
		                           Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		        iVar1 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(iVar1 + 0x24),param2_01,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        return *(undefined4 *)(iVar1 + 0xc);
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar1);
		  }
		  return **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		}
		*/

			return null;
		}

		// Token: 0x060076A1 RID: 30369 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076A1")]
		[Address(RVA = "0xC018", Offset = "0xC018", VA = "0xC018")]
		public static string GetLanguageCode(string Language)
		{
		/* --- GHIDRA: GetLanguageCode ---
		undefined4
		I2_Loc_LocalizationManager__GetLanguageCode(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int param2_01;
		  int iVar1;
		  
		  if (DAT_ram_00a604f7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604f7 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  if (*(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc) == 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    if (DAT_ram_00a60508 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		      Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		      DAT_ram_00a60508 = '\x01';
		    }
		    iVar1 = I2_Loc_LocalizationManager_TypeInfo;
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    I2_Loc_LocalizationManager__UpdateSources(iVar1);
		    I2_Loc_LocalizationManager__RegisterSceneSources(iVar1);
		    I2_Loc_LocalizationManager__UnregisterDeletededSources(iVar1);
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar1 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc);
		  if (0 < iVar1) {
		    param2_00 = 0;
		    do {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      param1_00 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)
		                              (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),
		                             param2_00,
		                             Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		      param2_01 = I2_Loc_LanguageSourceData__IsCurrentLanguage(param1_00,param1,param2,0,param2_00);
		      if (-1 < param2_01) {
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        iVar1 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)
		                            (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),param2_00,
		                           Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		        iVar1 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(iVar1 + 0x24),param2_01,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        return *(undefined4 *)(iVar1 + 8);
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar1);
		  }
		  return **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		}
		*/

			return null;
		}

		// Token: 0x060076A2 RID: 30370 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076A2")]
		[Address(RVA = "0xC019", Offset = "0xC019", VA = "0xC019")]
		public static string GetLanguageFromCode(string Code, bool exactMatch = true)
		{
		/* --- GHIDRA: GetLanguageFromCode ---
		undefined4 I2_Loc_LocalizationManager__GetLanguageFromCode(undefined4 param1,undefined4 param2)
		
		{
		  int param2_00;
		  int param2_01;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int param1_00;
		  
		  if (DAT_ram_00a604f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_string___);
		    Mono_Security_ASN1__get_Item(&System_Func_string__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_I2_Loc_LocalizationManager___c__DisplayClass33_0__GetAllLanguages_b__0__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager___c__DisplayClass33_0_TypeInfo);
		    DAT_ram_00a604f8 = '\x01';
		  }
		  param2_01 = unnamed_function_1417(I2_Loc_LocalizationManager___c__DisplayClass33_0_TypeInfo);
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  if (*(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc) == 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    if (DAT_ram_00a60508 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		      Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		      DAT_ram_00a60508 = '\x01';
		    }
		    iVar3 = I2_Loc_LocalizationManager_TypeInfo;
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    I2_Loc_LocalizationManager__UpdateSources(iVar3);
		    I2_Loc_LocalizationManager__RegisterSceneSources(iVar3);
		    I2_Loc_LocalizationManager__UnregisterDeletededSources(iVar3);
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_string___ctor__);
		  *(undefined4 *)(param2_01 + 8) = uVar1;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar3 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc);
		  if (0 < iVar3) {
		    param2_00 = 0;
		    do {
		      uVar1 = *(undefined4 *)(param2_01 + 8);
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      uVar2 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)
		                          (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),param2_00,
		                         Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		      uVar2 = I2_Loc_LanguageSourceData__RemoveLanguage(uVar2,param1,param2_00);
		      param1_00 = *(int *)(param2_01 + 0xc);
		      if (param1_00 == 0) {
		        param1_00 = unnamed_function_1417(System_Func_string__bool__TypeInfo);
		        System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                  (param1_00,param2_01,
		                   Method_I2_Loc_LocalizationManager___c__DisplayClass33_0__GetAllLanguages_b__0__,0
		                  );
		        *(int *)(param2_01 + 0xc) = param1_00;
		      }
		      uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                        (uVar2,param1_00,Method_System_Linq_Enumerable_Where_string___);
		      func_ii_6335(uVar1,uVar2,Method_System_Collections_Generic_List_string__AddRange__);
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar3);
		  }
		  return *(undefined4 *)(param2_01 + 8);
		}
		*/

			return null;
		}

		// Token: 0x060076A3 RID: 30371 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076A3")]
		[Address(RVA = "0xC01A", Offset = "0xC01A", VA = "0xC01A")]
		public static List<string> GetAllLanguages(bool SkipDisabled = true)
		{
		/* --- GHIDRA: GetAllLanguages ---
		undefined4
		I2_Loc_LocalizationManager__GetAllLanguages(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  int param2_01;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int param1_00;
		  
		  if (DAT_ram_00a604f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_string___);
		    Mono_Security_ASN1__get_Item(&System_Func_string__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_I2_Loc_LocalizationManager___c__DisplayClass34_0__GetAllLanguagesCode_b__0__)
		    ;
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager___c__DisplayClass34_0_TypeInfo);
		    DAT_ram_00a604f9 = '\x01';
		  }
		  param2_01 = unnamed_function_1417(I2_Loc_LocalizationManager___c__DisplayClass34_0_TypeInfo);
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_string___ctor__);
		  *(undefined4 *)(param2_01 + 8) = uVar1;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar3 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc);
		  if (0 < iVar3) {
		    param2_00 = 0;
		    do {
		      uVar1 = *(undefined4 *)(param2_01 + 8);
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      uVar2 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)
		                          (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),param2_00,
		                         Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		      uVar2 = I2_Loc_LanguageSourceData__GetLanguages(uVar2,param1,param2,param2_00);
		      param1_00 = *(int *)(param2_01 + 0xc);
		      if (param1_00 == 0) {
		        param1_00 = unnamed_function_1417(System_Func_string__bool__TypeInfo);
		        System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                  (param1_00,param2_01,
		                   Method_I2_Loc_LocalizationManager___c__DisplayClass34_0__GetAllLanguagesCode_b__0__
		                   ,0);
		        *(int *)(param2_01 + 0xc) = param1_00;
		      }
		      uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                        (uVar2,param1_00,Method_System_Linq_Enumerable_Where_string___);
		      func_ii_6335(uVar1,uVar2,Method_System_Collections_Generic_List_string__AddRange__);
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar3);
		  }
		  return *(undefined4 *)(param2_01 + 8);
		}
		*/

			return null;
		}

		// Token: 0x060076A4 RID: 30372 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076A4")]
		[Address(RVA = "0xC01B", Offset = "0xC01B", VA = "0xC01B")]
		public static List<string> GetAllLanguagesCode(bool allowRegions = true, bool SkipDisabled = true)
		{
		/* --- GHIDRA: GetAllLanguagesCode ---
		uint I2_Loc_LocalizationManager__GetAllLanguagesCode(undefined4 param1,undefined4 param2)
		
		{
		  int param2_00;
		  uint uVar1;
		  int iVar2;
		  int param2_01;
		  int iVar3;
		  
		  if (DAT_ram_00a604fa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604fa = '\x01';
		  }
		  uVar1 = 1;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar3 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc);
		  if (0 < iVar3) {
		    uVar1 = 0;
		    param2_00 = 0;
		    do {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)
		                          (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),param2_00,
		                         Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		      if (DAT_ram_00a604a9 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        DAT_ram_00a604a9 = '\x01';
		      }
		      param2_01 = I2_Loc_LanguageSourceData__Import_Google_Result(iVar2,param1,0,1,param2_00);
		      if (param2_01 < 0) {
		        return uVar1;
		      }
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(iVar2 + 0x24),param2_01,
		                         Method_System_Collections_Generic_List_LanguageData__get_Item__);
		      if ((*(byte *)(iVar2 + 0x10) & 1) != 0) {
		        return uVar1;
		      }
		      param2_00 = param2_00 + 1;
		      uVar1 = (uint)(iVar3 <= param2_00);
		    } while (param2_00 != iVar3);
		  }
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060076A5 RID: 30373 RVA: 0x000157E0 File Offset: 0x000139E0
		[Token(Token = "0x60076A5")]
		[Address(RVA = "0xC01C", Offset = "0xC01C", VA = "0xC01C")]
		public static bool IsLanguageEnabled(string Language)
		{
		/* --- GHIDRA: IsLanguageEnabled ---
		void I2_Loc_LocalizationManager__IsLanguageEnabled(undefined4 param1)
		
		{
		  int param2;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a604fb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604fb = '\x01';
		  }
		  param2 = 0;
		  while( true ) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    param1_01 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c);
		    if (*(int *)(param1_01 + 0xc) <= param2) break;
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      param1_01 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c);
		    }
		    uVar1 = System_Linq_Enumerable__ToList_object_
		                      (param1_01,param2,
		                       Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    uVar1 = I2_Loc_LanguageSourceData__Import_Google_Result
		                      (uVar1,**(undefined4 **)(I2_Loc_LocalizationManager_TypeInfo + 0x5c),1,0,
		                       param2);
		    param1_00 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)
		                            (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),param2,
		                           Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    I2_Loc_LanguageSourceData__GetSavedLanguageFileName(param1_00,uVar1,1,1,1,0,param2);
		    param2 = param2 + 1;
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060076A6 RID: 30374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076A6")]
		[Address(RVA = "0xC01D", Offset = "0xC01D", VA = "0xC01D")]
		private static void LoadCurrentLanguage()
		{
		/* --- GHIDRA: LoadCurrentLanguage ---
		void I2_Loc_LocalizationManager__LoadCurrentLanguage(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a604fc == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleLanguages_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604fc = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar2 = I2_Loc_LocalizationManager_TypeInfo;
		  **(undefined4 **)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) = param1;
		  uVar1 = I2_Loc_LocalizationManager__GetSupportedLanguage
		                    (**(undefined4 **)(I2_Loc_LocalizationManager_TypeInfo + 0x5c),iVar2);
		  iVar2 = I2_Loc_LocalizationManager_TypeInfo;
		  *(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 4) = uVar1;
		  if (DAT_ram_00a60507 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_IndexOf_string___);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a60507 = '\x01';
		    iVar2 = I2_Loc_LocalizationManager_TypeInfo;
		  }
		  if (*(int *)(iVar2 + 0x74) == 0) {
		    func_ii_306000(iVar2);
		    iVar2 = I2_Loc_LocalizationManager_TypeInfo;
		  }
		  iVar2 = LunarConsolePlugin_CVar__set_Value
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x5c) + 0x18),uVar1,
		                     Method_System_Array_IndexOf_string___);
		  iVar3 = *(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c);
		  *(bool *)(iVar3 + 0xd) = -1 < iVar2;
		  uVar1 = *(undefined4 *)(iVar3 + 4);
		  if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		  }
		  uVar1 = I2_Loc_GoogleLanguages__GetAllInternationalCodes(uVar1,0);
		  *(char *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xe) = (char)uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060076A7 RID: 30375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076A7")]
		[Address(RVA = "0xC01E", Offset = "0xC01E", VA = "0xC01E")]
		public static void PreviewLanguage(string NewLanguage)
		{
		/* --- GHIDRA: PreviewLanguage ---
		void I2_Loc_LocalizationManager__PreviewLanguage(undefined4 param1)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int param2;
		  int param1_00;
		  uint uVar4;
		  
		  if (DAT_ram_00a604fd == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizationParamsManager__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizationParamsManager__Contains__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_FindObjectsOfType_LocalizationParamsManager___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a604fd = '\x01';
		  }
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = 0;
		  iVar2 = UnityEngine_Object__FindObjectsByType_object_
		                    (Method_UnityEngine_Object_FindObjectsOfType_LocalizationParamsManager___);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      param2 = *(int *)(iVar2 + iVar1 * 4 + 0x10);
		      if (*(char *)(param2 + 0x14) != '\0') {
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        iVar3 = func_ii_4685(*(undefined4 *)
		                              (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x10),param2,
		                             Method_System_Collections_Generic_List_ILocalizationParamsManager__Contains__
		                            );
		        if (iVar3 == 0) {
		          if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		            func_ii_306000(OKG_Logs_Debug_TypeInfo);
		          }
		          System_Collections_Generic_Dictionary_uint__object___get_Count(param2,0);
		          if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		          }
		          iVar3 = Method_System_Collections_Generic_List_ILocalizationParamsManager__Add__;
		          param1_00 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x10);
		          *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		          uVar4 = *(uint *)(param1_00 + 0xc);
		          if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		            *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		            *(int *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = param2;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (param1_00,param2,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		          }
		        }
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060076A8 RID: 30376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076A8")]
		[Address(RVA = "0xC01F", Offset = "0xC01F", VA = "0xC01F")]
		public static void AutoLoadGlobalParamManagers()
		{
		/* --- GHIDRA: AutoLoadGlobalParamManagers ---
		void I2_Loc_LocalizationManager__AutoLoadGlobalParamManagers
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  char cVar1;
		  int iVar2;
		  int *piVar3;
		  int param2_00;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a604fe == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_I2_Loc_LocalizationManager___c__ApplyLocalizationParams_b__43_0__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager__GetParam_TypeInfo);
		    DAT_ram_00a604fe = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager___c_TypeInfo);
		  }
		  piVar3 = *(int **)(I2_Loc_LocalizationManager___c_TypeInfo + 0x5c);
		  param2_00 = piVar3[1];
		  if (param2_00 == 0) {
		    if (*(int *)(I2_Loc_LocalizationManager___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager___c_TypeInfo);
		      piVar3 = *(int **)(I2_Loc_LocalizationManager___c_TypeInfo + 0x5c);
		    }
		    iVar4 = *piVar3;
		    param2_00 = unnamed_function_1417(I2_Loc_LocalizationManager__GetParam_TypeInfo);
		    iVar2 = Method_I2_Loc_LocalizationManager___c__ApplyLocalizationParams_b__43_0__;
		    uVar5 = *(undefined4 *)
		             (Method_I2_Loc_LocalizationManager___c__ApplyLocalizationParams_b__43_0__ + 4);
		    *(int *)(param2_00 + 0x14) =
		         Method_I2_Loc_LocalizationManager___c__ApplyLocalizationParams_b__43_0__;
		    *(undefined4 *)(param2_00 + 8) = uVar5;
		    *(int *)(param2_00 + 0x10) = iVar4;
		    cVar1 = *(char *)(iVar2 + 0x2e);
		    *(int *)(param2_00 + 0x20) = param2_00;
		    iVar2 = func_ii_4538(iVar2);
		    if (iVar2 == 0) {
		      if (cVar1 == '\0') {
		        *(char **)(param2_00 + 0xc) = s___Scripting__UnityEngine__Contex_ram_0000360b + 1;
		      }
		      else {
		        if (iVar4 == 0) {
		          uVar5 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                            (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		          func_ii_1050(uVar5,0);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        *(undefined4 *)(param2_00 + 0xc) = *(undefined4 *)(param2_00 + 8);
		        *(undefined4 *)(param2_00 + 0x20) = *(undefined4 *)(param2_00 + 0x10);
		      }
		    }
		    else if (cVar1 == '\x01') {
		      *(char **)(param2_00 + 0xc) = s___Scripting__UnityEngine__Contex_ram_0000360b;
		    }
		    else {
		      *(undefined4 *)(param2_00 + 0xc) = *(undefined4 *)(param2_00 + 8);
		      *(undefined4 *)(param2_00 + 0x20) = *(undefined4 *)(param2_00 + 0x10);
		    }
		    *(char **)(param2_00 + 0x1c) = s___Scripting__UnityEngine__Contex_ram_0000360b + 2;
		    *(int *)(*(int *)(I2_Loc_LocalizationManager___c_TypeInfo + 0x5c) + 4) = param2_00;
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizationManager__ApplyLocalizationParams(param1,param2_00,param2,param2_00);
		  return;
		}
		*/

		}

		// Token: 0x060076A9 RID: 30377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076A9")]
		[Address(RVA = "0xC020", Offset = "0xC020", VA = "0xC020")]
		public static void ApplyLocalizationParams(ref string translation, bool allowLocalizedParameters = true)
		{
		/* --- GHIDRA: ApplyLocalizationParams ---
		undefined4
		I2_Loc_LocalizationManager__ApplyLocalizationParams
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  undefined4 *puVar7;
		  int iVar8;
		  int *piVar9;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a60502 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponents_MonoBehaviour___);
		    Mono_Security_ASN1__get_Item(&I2_Loc_ILocalizationParamsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizationParamsManager__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizationParamsManager__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a60502 = '\x01';
		  }
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar3 = UnityEngine_Component__GetComponent_object_(param2,0);
		  if (iVar3 != 0) {
		    iVar3 = UnityEngine_GameObject__GetComponents_object_
		                      (param2,Method_UnityEngine_GameObject_GetComponents_MonoBehaviour___);
		    iVar8 = *(int *)(iVar3 + 0xc);
		    if (0 < iVar8) {
		      do {
		        puVar7 = (undefined4 *)(iVar3 + iVar2 * 4 + 0x10);
		        piVar5 = (int *)func_ii_1082(*puVar7,I2_Loc_ILocalizationParamsManager_TypeInfo);
		        if ((piVar5 != (int *)0x0) &&
		           (iVar4 = UnityEngine_Awaitable___c____cctor_b__76_1(*puVar7,0), iVar4 != 0)) {
		          iVar4 = *piVar5;
		          if (*(ushort *)(iVar4 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar9 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		              if (I2_Loc_ILocalizationParamsManager_TypeInfo == *piVar9) {
		                puVar6 = (uint *)(iVar4 + piVar9[1] * 8 + 0xc0);
		                goto code_r0x81ca0119;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		          }
		          puVar6 = (uint *)func_ii_1080(piVar5,I2_Loc_ILocalizationParamsManager_TypeInfo,0);
		code_r0x81ca0119:
		          iVar4 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,param1,puVar6[1]);
		          if (iVar4 != 0) {
		            return iVar4;
		          }
		        }
		        iVar2 = iVar2 + 1;
		      } while (iVar2 != iVar8);
		    }
		  }
		  iVar2 = 0;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar3 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x10) + 0xc);
		  if (0 < iVar3) {
		    do {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      piVar5 = (int *)System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)
		                                  (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x10),
		                                 iVar2,
		                                 Method_System_Collections_Generic_List_ILocalizationParamsManager__get_Item__
		                                );
		      iVar8 = *piVar5;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (I2_Loc_ILocalizationParamsManager_TypeInfo == *piVar9) {
		            puVar6 = (uint *)(iVar8 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x81ca0213;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar6 = (uint *)func_ii_1080(piVar5,I2_Loc_ILocalizationParamsManager_TypeInfo,0);
		code_r0x81ca0213:
		      iVar8 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,param1,puVar6[1]);
		      if (iVar8 != 0) {
		        return iVar8;
		      }
		      iVar2 = iVar2 + 1;
		    } while (iVar2 != iVar3);
		  }
		  return 0;
		}
		*/

		/* --- GHIDRA: ApplyLocalizationParams ---
		undefined4
		I2_Loc_LocalizationManager__ApplyLocalizationParams
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  undefined4 *puVar7;
		  int iVar8;
		  int *piVar9;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a60502 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponents_MonoBehaviour___);
		    Mono_Security_ASN1__get_Item(&I2_Loc_ILocalizationParamsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizationParamsManager__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizationParamsManager__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a60502 = '\x01';
		  }
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar3 = UnityEngine_Component__GetComponent_object_(param2,0);
		  if (iVar3 != 0) {
		    iVar3 = UnityEngine_GameObject__GetComponents_object_
		                      (param2,Method_UnityEngine_GameObject_GetComponents_MonoBehaviour___);
		    iVar8 = *(int *)(iVar3 + 0xc);
		    if (0 < iVar8) {
		      do {
		        puVar7 = (undefined4 *)(iVar3 + iVar2 * 4 + 0x10);
		        piVar5 = (int *)func_ii_1082(*puVar7,I2_Loc_ILocalizationParamsManager_TypeInfo);
		        if ((piVar5 != (int *)0x0) &&
		           (iVar4 = UnityEngine_Awaitable___c____cctor_b__76_1(*puVar7,0), iVar4 != 0)) {
		          iVar4 = *piVar5;
		          if (*(ushort *)(iVar4 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar9 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		              if (I2_Loc_ILocalizationParamsManager_TypeInfo == *piVar9) {
		                puVar6 = (uint *)(iVar4 + piVar9[1] * 8 + 0xc0);
		                goto code_r0x81ca0119;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		          }
		          puVar6 = (uint *)func_ii_1080(piVar5,I2_Loc_ILocalizationParamsManager_TypeInfo,0);
		code_r0x81ca0119:
		          iVar4 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,param1,puVar6[1]);
		          if (iVar4 != 0) {
		            return iVar4;
		          }
		        }
		        iVar2 = iVar2 + 1;
		      } while (iVar2 != iVar8);
		    }
		  }
		  iVar2 = 0;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar3 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x10) + 0xc);
		  if (0 < iVar3) {
		    do {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      piVar5 = (int *)System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)
		                                  (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x10),
		                                 iVar2,
		                                 Method_System_Collections_Generic_List_ILocalizationParamsManager__get_Item__
		                                );
		      iVar8 = *piVar5;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (I2_Loc_ILocalizationParamsManager_TypeInfo == *piVar9) {
		            puVar6 = (uint *)(iVar8 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x81ca0213;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar6 = (uint *)func_ii_1080(piVar5,I2_Loc_ILocalizationParamsManager_TypeInfo,0);
		code_r0x81ca0213:
		      iVar8 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,param1,puVar6[1]);
		      if (iVar8 != 0) {
		        return iVar8;
		      }
		      iVar2 = iVar2 + 1;
		    } while (iVar2 != iVar3);
		  }
		  return 0;
		}
		*/

		/* --- GHIDRA: ApplyLocalizationParams ---
		undefined4
		I2_Loc_LocalizationManager__ApplyLocalizationParams
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  undefined4 *puVar7;
		  int iVar8;
		  int *piVar9;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a60502 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponents_MonoBehaviour___);
		    Mono_Security_ASN1__get_Item(&I2_Loc_ILocalizationParamsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizationParamsManager__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizationParamsManager__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a60502 = '\x01';
		  }
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar3 = UnityEngine_Component__GetComponent_object_(param2,0);
		  if (iVar3 != 0) {
		    iVar3 = UnityEngine_GameObject__GetComponents_object_
		                      (param2,Method_UnityEngine_GameObject_GetComponents_MonoBehaviour___);
		    iVar8 = *(int *)(iVar3 + 0xc);
		    if (0 < iVar8) {
		      do {
		        puVar7 = (undefined4 *)(iVar3 + iVar2 * 4 + 0x10);
		        piVar5 = (int *)func_ii_1082(*puVar7,I2_Loc_ILocalizationParamsManager_TypeInfo);
		        if ((piVar5 != (int *)0x0) &&
		           (iVar4 = UnityEngine_Awaitable___c____cctor_b__76_1(*puVar7,0), iVar4 != 0)) {
		          iVar4 = *piVar5;
		          if (*(ushort *)(iVar4 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar9 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		              if (I2_Loc_ILocalizationParamsManager_TypeInfo == *piVar9) {
		                puVar6 = (uint *)(iVar4 + piVar9[1] * 8 + 0xc0);
		                goto code_r0x81ca0119;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		          }
		          puVar6 = (uint *)func_ii_1080(piVar5,I2_Loc_ILocalizationParamsManager_TypeInfo,0);
		code_r0x81ca0119:
		          iVar4 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,param1,puVar6[1]);
		          if (iVar4 != 0) {
		            return iVar4;
		          }
		        }
		        iVar2 = iVar2 + 1;
		      } while (iVar2 != iVar8);
		    }
		  }
		  iVar2 = 0;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar3 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x10) + 0xc);
		  if (0 < iVar3) {
		    do {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      piVar5 = (int *)System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)
		                                  (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x10),
		                                 iVar2,
		                                 Method_System_Collections_Generic_List_ILocalizationParamsManager__get_Item__
		                                );
		      iVar8 = *piVar5;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (I2_Loc_ILocalizationParamsManager_TypeInfo == *piVar9) {
		            puVar6 = (uint *)(iVar8 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x81ca0213;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar6 = (uint *)func_ii_1080(piVar5,I2_Loc_ILocalizationParamsManager_TypeInfo,0);
		code_r0x81ca0213:
		      iVar8 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,param1,puVar6[1]);
		      if (iVar8 != 0) {
		        return iVar8;
		      }
		      iVar2 = iVar2 + 1;
		    } while (iVar2 != iVar3);
		  }
		  return 0;
		}
		*/

		/* --- GHIDRA: ApplyLocalizationParams ---
		undefined4
		I2_Loc_LocalizationManager__ApplyLocalizationParams
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  undefined4 *puVar7;
		  int iVar8;
		  int *piVar9;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a60502 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponents_MonoBehaviour___);
		    Mono_Security_ASN1__get_Item(&I2_Loc_ILocalizationParamsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizationParamsManager__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizationParamsManager__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a60502 = '\x01';
		  }
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar3 = UnityEngine_Component__GetComponent_object_(param2,0);
		  if (iVar3 != 0) {
		    iVar3 = UnityEngine_GameObject__GetComponents_object_
		                      (param2,Method_UnityEngine_GameObject_GetComponents_MonoBehaviour___);
		    iVar8 = *(int *)(iVar3 + 0xc);
		    if (0 < iVar8) {
		      do {
		        puVar7 = (undefined4 *)(iVar3 + iVar2 * 4 + 0x10);
		        piVar5 = (int *)func_ii_1082(*puVar7,I2_Loc_ILocalizationParamsManager_TypeInfo);
		        if ((piVar5 != (int *)0x0) &&
		           (iVar4 = UnityEngine_Awaitable___c____cctor_b__76_1(*puVar7,0), iVar4 != 0)) {
		          iVar4 = *piVar5;
		          if (*(ushort *)(iVar4 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar9 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		              if (I2_Loc_ILocalizationParamsManager_TypeInfo == *piVar9) {
		                puVar6 = (uint *)(iVar4 + piVar9[1] * 8 + 0xc0);
		                goto code_r0x81ca0119;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		          }
		          puVar6 = (uint *)func_ii_1080(piVar5,I2_Loc_ILocalizationParamsManager_TypeInfo,0);
		code_r0x81ca0119:
		          iVar4 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,param1,puVar6[1]);
		          if (iVar4 != 0) {
		            return iVar4;
		          }
		        }
		        iVar2 = iVar2 + 1;
		      } while (iVar2 != iVar8);
		    }
		  }
		  iVar2 = 0;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar3 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x10) + 0xc);
		  if (0 < iVar3) {
		    do {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      piVar5 = (int *)System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)
		                                  (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x10),
		                                 iVar2,
		                                 Method_System_Collections_Generic_List_ILocalizationParamsManager__get_Item__
		                                );
		      iVar8 = *piVar5;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (I2_Loc_ILocalizationParamsManager_TypeInfo == *piVar9) {
		            puVar6 = (uint *)(iVar8 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x81ca0213;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar6 = (uint *)func_ii_1080(piVar5,I2_Loc_ILocalizationParamsManager_TypeInfo,0);
		code_r0x81ca0213:
		      iVar8 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,param1,puVar6[1]);
		      if (iVar8 != 0) {
		        return iVar8;
		      }
		      iVar2 = iVar2 + 1;
		    } while (iVar2 != iVar3);
		  }
		  return 0;
		}
		*/

		}

		// Token: 0x060076AA RID: 30378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076AA")]
		[Address(RVA = "0xC021", Offset = "0xC021", VA = "0xC021")]
		public static void ApplyLocalizationParams(ref string translation, GameObject root, bool allowLocalizedParameters = true)
		{
		}

		// Token: 0x060076AB RID: 30379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076AB")]
		[Address(RVA = "0xC022", Offset = "0xC022", VA = "0xC022")]
		public static void ApplyLocalizationParams(ref string translation, Dictionary<string, object> parameters, bool allowLocalizedParameters = true)
		{
		}

		// Token: 0x060076AC RID: 30380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076AC")]
		[Address(RVA = "0xC023", Offset = "0xC023", VA = "0xC023")]
		public static void ApplyLocalizationParams(ref string translation, LocalizationManager._GetParam getParam, bool allowLocalizedParameters = true)
		{
		}

		// Token: 0x060076AD RID: 30381 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076AD")]
		[Address(RVA = "0xC024", Offset = "0xC024", VA = "0xC024")]
		internal static string GetLocalizationParam(string ParamName, GameObject root)
		{
		/* --- GHIDRA: GetLocalizationParam ---
		undefined4
		I2_Loc_LocalizationManager__GetLocalizationParam
		          (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int iVar4;
		  int iVar5;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a60503 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleLanguages_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_ePluralType_TypeInfo);
		    DAT_ram_00a60503 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = System_Text_RegularExpressions_MatchCollection__get_IsReadOnly(param1,0);
		  if (0 < iVar1) {
		    do {
		      piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x1d8) * 4))
		                                (param1,iVar5,*(undefined4 *)(*param1 + 0x1dc));
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))
		                        (piVar2,*(undefined4 *)(*piVar2 + 0xec));
		      param1_00 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))
		                            (piVar2,*(undefined4 *)(*piVar2 + 0xec));
		      iVar4 = System_Text_RegularExpressions_GroupCollection__get_IsReadOnly(param1_00,0);
		      uVar3 = System_Text_RegularExpressions_GroupCollection__System_Collections_IList_RemoveAt
		                        (uVar3,iVar4 + -1,0);
		      uVar3 = System_Text_RegularExpressions_Capture__set_Text(uVar3,0);
		      piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(param3 + 0xc) * 4))
		                                (*(undefined4 *)(param3 + 0x20),uVar3,*(undefined4 *)(param3 + 0x14)
		                                );
		      if (piVar2 != (int *)0x0) {
		        if (DAT_ram_00a66978 != *piVar2) {
		          System_Activator__CreateInstance(piVar2,DAT_ram_00a66978);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        local_4 = 0;
		        iVar4 = System_Net_WebHeaderCollection__Add(piVar2,&local_4,0);
		        uVar3 = local_4;
		        if (iVar4 != 0) {
		          if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		          }
		          local_8 = I2_Loc_GoogleLanguages__LanguageHasPluralType(param2,uVar3,0);
		          local_c = 0xffffffff;
		          local_10 = I2_Loc_ePluralType_TypeInfo;
		          uVar3 = Spine_SkeletonJson__GetFloat(&local_10,0);
		          return uVar3;
		        }
		      }
		      iVar5 = iVar5 + 1;
		    } while (iVar5 != iVar1);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x060076AE RID: 30382 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076AE")]
		[Address(RVA = "0xC025", Offset = "0xC025", VA = "0xC025")]
		private static string GetPluralType(MatchCollection matches, string langCode, LocalizationManager._GetParam getParam)
		{
		/* --- GHIDRA: GetPluralType ---
		undefined4 I2_Loc_LocalizationManager__GetPluralType(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60504 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a60504 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  uVar1 = I2_Loc_LocalizationManager__ApplyRTLfix(param1,0,1,param1);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060076AF RID: 30383 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076AF")]
		[Address(RVA = "0xC026", Offset = "0xC026", VA = "0xC026")]
		public static string ApplyRTLfix(string line)
		{
		/* --- GHIDRA: ApplyRTLfix ---
		undefined4
		I2_Loc_LocalizationManager__ApplyRTLfix
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param4_00;
		  
		  if (DAT_ram_00a60506 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a60506 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  param4_00 = I2_Loc_LocalizationManager_TypeInfo;
		  if (*(char *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xd) != '\0') {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    param1 = I2_Loc_LocalizationManager__ApplyRTLfix(param1,param2,param3,param4_00);
		  }
		  return param1;
		}
		*/

		/* --- GHIDRA: ApplyRTLfix ---
		undefined4
		I2_Loc_LocalizationManager__ApplyRTLfix
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param4_00;
		  
		  if (DAT_ram_00a60506 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a60506 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  param4_00 = I2_Loc_LocalizationManager_TypeInfo;
		  if (*(char *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xd) != '\0') {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    param1 = I2_Loc_LocalizationManager__ApplyRTLfix(param1,param2,param3,param4_00);
		  }
		  return param1;
		}
		*/

			return null;
		}

		// Token: 0x060076B0 RID: 30384 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076B0")]
		[Address(RVA = "0xC027", Offset = "0xC027", VA = "0xC027")]
		public static string ApplyRTLfix(string line, int maxCharacters, bool ignoreNumbers)
		{
			return null;
		}

		// Token: 0x060076B1 RID: 30385 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076B1")]
		[Address(RVA = "0xC028", Offset = "0xC028", VA = "0xC028")]
		public static string FixRTL_IfNeeded(string text, int maxCharacters = 0, bool ignoreNumber = false)
		{
		/* --- GHIDRA: FixRTL_IfNeeded ---
		uint I2_Loc_LocalizationManager__FixRTL_IfNeeded(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  
		  if (DAT_ram_00a60507 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_IndexOf_string___);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a60507 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  uVar1 = LunarConsolePlugin_CVar__set_Value
		                    (*(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x18),
		                     param1,Method_System_Array_IndexOf_string___);
		  return (uVar1 ^ 0xffffffff) >> 0x1f;
		}
		*/

			return null;
		}

		// Token: 0x060076B2 RID: 30386 RVA: 0x000157F8 File Offset: 0x000139F8
		[Token(Token = "0x60076B2")]
		[Address(RVA = "0xC029", Offset = "0xC029", VA = "0xC029")]
		public static bool IsRTL(string Code)
		{
		/* --- GHIDRA: IsRTL ---
		uint I2_Loc_LocalizationManager__IsRTL(undefined4 param1)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a60508 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a60508 = '\x01';
		  }
		  param1_00 = I2_Loc_LocalizationManager_TypeInfo;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizationManager__UpdateSources(param1_00);
		  I2_Loc_LocalizationManager__RegisterSceneSources(param1_00);
		  I2_Loc_LocalizationManager__UnregisterDeletededSources(param1_00);
		  return (uint)(0 < *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) +
		                            0xc));
		}
		*/

			return default(bool);
		}

		// Token: 0x060076B3 RID: 30387 RVA: 0x00015810 File Offset: 0x00013A10
		[Token(Token = "0x60076B3")]
		[Address(RVA = "0xC02A", Offset = "0xC02A", VA = "0xC02A")]
		public static bool UpdateSources()
		{
		/* --- GHIDRA: UpdateSources ---
		void I2_Loc_LocalizationManager__UpdateSources(undefined4 param1)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 param2;
		  int param2_00;
		  
		  if (DAT_ram_00a60509 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a60509 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  param2_00 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc)
		              + -1;
		  if (-1 < param2_00) {
		    do {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)
		                          (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),param2_00,
		                         Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		      if (iVar2 == 0) {
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        param2 = System_Linq_Enumerable__ToList_object_
		                           (*(undefined4 *)
		                             (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),param2_00
		                            ,Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		        if (DAT_ram_00a6050f == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&Method_System_Collections_Generic_List_LanguageSourceData__Remove__);
		          Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		          DAT_ram_00a6050f = '\x01';
		        }
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        func_ii_4876(*(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),
		                     param2,Method_System_Collections_Generic_List_LanguageSourceData__Remove__);
		      }
		      bVar1 = 0 < param2_00;
		      param2_00 = param2_00 + -1;
		    } while (bVar1);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060076B4 RID: 30388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076B4")]
		[Address(RVA = "0xC02B", Offset = "0xC02B", VA = "0xC02B")]
		private static void UnregisterDeletededSources()
		{
		/* --- GHIDRA: UnregisterDeletededSources ---
		void I2_Loc_LocalizationManager__UnregisterDeletededSources(undefined4 param1)
		
		{
		  int param2;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a6050a == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSource___TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSource_var);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__Contains__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a6050a = '\x01';
		  }
		  uVar1 = I2_Loc_LanguageSource_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  param2 = 0;
		  uVar1 = func_ii_2734(uVar1,0);
		  iVar2 = UnityEngine_ResourcesAPI___cctor(uVar1,0);
		  uVar1 = I2_Loc_LanguageSource___TypeInfo;
		  if ((iVar2 != 0) && (iVar3 = func_ii_1082(iVar2,I2_Loc_LanguageSource___TypeInfo), iVar3 == 0)) {
		    System_Activator__CreateInstance(iVar2,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar2 = *(int *)(iVar3 + param2 * 4 + 0x10);
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      iVar4 = func_ii_4685(*(undefined4 *)
		                            (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),
		                           *(undefined4 *)(iVar2 + 0x10),
		                           Method_System_Collections_Generic_List_LanguageSourceData__Contains__);
		      if (iVar4 == 0) {
		        iVar4 = *(int *)(iVar2 + 0x10);
		        if (*(int *)(iVar4 + 8) == 0) {
		          *(int *)(iVar4 + 8) = iVar2;
		        }
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        I2_Loc_LocalizationManager__AllowSyncFromGoogle(iVar4,param2);
		      }
		      param2 = param2 + 1;
		    } while (param2 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060076B5 RID: 30389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076B5")]
		[Address(RVA = "0xC02C", Offset = "0xC02C", VA = "0xC02C")]
		private static void RegisterSceneSources()
		{
		/* --- GHIDRA: RegisterSceneSources ---
		void I2_Loc_LocalizationManager__RegisterSceneSources(undefined4 param1)
		
		{
		  int param2;
		  undefined4 param1_00;
		  int param1_01;
		  int iVar1;
		  int iVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a6050b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__Contains__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_ResourceManager_GetAsset_LanguageSourceAsset___);
		    DAT_ram_00a6050b = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar2 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x20);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    param2 = 0;
		    do {
		      param2_00 = *(undefined4 *)(iVar2 + param2 * 4 + 0x10);
		      param1_00 = I2_Loc_RegisterGlobalParameters___ctor(0);
		      param1_01 = UnityEngine_UIElements_ResolvedStyleAccessPropertyBag__AddProperty___Il2CppFullySharedGenericType_
		                            (param1_00,param2_00,
		                             Method_I2_Loc_ResourceManager_GetAsset_LanguageSourceAsset___);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar1 = UnityEngine_Component__GetComponent_object_(param1_01,0);
		      if (iVar1 != 0) {
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        iVar1 = func_ii_4685(*(undefined4 *)
		                              (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),
		                             *(undefined4 *)(param1_01 + 0xc),
		                             Method_System_Collections_Generic_List_LanguageSourceData__Contains__);
		        if (iVar1 == 0) {
		          iVar1 = *(int *)(param1_01 + 0xc);
		          if (*(char *)(iVar1 + 0xf) == '\0') {
		            *(undefined1 *)(iVar1 + 0xf) = 1;
		          }
		          *(int *)(iVar1 + 8) = param1_01;
		          if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		          }
		          I2_Loc_LocalizationManager__AllowSyncFromGoogle(iVar1,param2);
		        }
		      }
		      param2 = param2 + 1;
		    } while (param2 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060076B6 RID: 30390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076B6")]
		[Address(RVA = "0xC02D", Offset = "0xC02D", VA = "0xC02D")]
		private static void RegisterSourceInResources()
		{
		/* --- GHIDRA: RegisterSourceInResources ---
		undefined4
		I2_Loc_LocalizationManager__RegisterSourceInResources(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a6050c == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a6050c = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar2 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x24);
		  if (iVar2 == 0) {
		    return 1;
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    iVar2 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x24);
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                    (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  return uVar1;
		}
		*/

		}

		// Token: 0x060076B7 RID: 30391 RVA: 0x00015828 File Offset: 0x00013A28
		[Token(Token = "0x60076B7")]
		[Address(RVA = "0xC02E", Offset = "0xC02E", VA = "0xC02E")]
		private static bool AllowSyncFromGoogle(LanguageSourceData Source)
		{
		/* --- GHIDRA: AllowSyncFromGoogle ---
		void I2_Loc_LocalizationManager__AllowSyncFromGoogle(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 param1_00;
		  uint uVar4;
		  float fVar5;
		  
		  if (DAT_ram_00a6050d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TermData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageSourceData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__Contains__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a6050d = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar1 = func_ii_4685(*(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),
		                       param1,Method_System_Collections_Generic_List_LanguageSourceData__Contains__)
		  ;
		  if (iVar1 != 0) {
		    return;
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar2 = Method_System_Collections_Generic_List_LanguageSourceData__Add__;
		  iVar1 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c);
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar1 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		    *(uint *)(iVar1 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar1 + 8) + uVar4 * 4 + 0x10) = param1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar1,param1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  if (DAT_ram_00a6049b == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a6049b = '\x01';
		  }
		  iVar2 = func_ii_4769(*(undefined4 *)(param1 + 0x30),0);
		  if ((iVar2 == 0) &&
		     (iVar3 = func_ii_4769(*(undefined4 *)(param1 + 0x34),0),
		     iVar2 = I2_Loc_LocalizationManager_TypeInfo, iVar3 == 0)) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    param1_00 = I2_Loc_LocalizationManager__GetRequiredWebServiceVersion(param1,iVar2);
		    iVar3 = func_ii_4769(param1_00,0);
		    iVar1 = iVar2;
		    if ((iVar3 == 0) && (*(int *)(param1 + 0x40) != 1)) {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      if (DAT_ram_00a6050c == '\0') {
		        Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		        DAT_ram_00a6050c = '\x01';
		      }
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      iVar1 = I2_Loc_LocalizationManager_TypeInfo;
		      iVar2 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x24);
		      if (iVar2 != 0) {
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		          iVar2 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x24);
		        }
		        iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                          (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		        if (iVar2 == 0) goto code_r0x81c8f984;
		      }
		      I2_Loc_LanguageSourceData__FreeUnusedLanguages(param1,iVar1);
		      fVar5 = *(float *)(param1 + 0x4c);
		      if (0.0 < fVar5) {
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        if (DAT_ram_00a6050e == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&I2_Loc_LocalizationManager__Delayed_Import_Google_d__63_TypeInfo);
		          DAT_ram_00a6050e = '\x01';
		        }
		        iVar1 = unnamed_function_1417
		                          (I2_Loc_LocalizationManager__Delayed_Import_Google_d__63_TypeInfo);
		        *(int *)(iVar1 + 0x14) = param1;
		        *(undefined4 *)(iVar1 + 8) = 0;
		        *(undefined1 *)(iVar1 + 0x18) = 0;
		        *(float *)(iVar1 + 0x10) = fVar5;
		        I2_Loc_CoroutineManager__Awake(iVar1,0);
		      }
		      else {
		        I2_Loc_LanguageSourceData__IsNewerVersion(param1,0,0,iVar1);
		      }
		    }
		  }
		code_r0x81c8f984:
		  iVar2 = *(int *)(param1 + 0x24);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (iVar2,iVar1,Method_System_Collections_Generic_List_LanguageData__get_Item__
		                        );
		      *(byte *)(iVar2 + 0x10) = *(byte *)(iVar2 + 0x10) & 0xfb;
		      iVar1 = iVar1 + 1;
		      iVar2 = *(int *)(param1 + 0x24);
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  iVar2 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                    (*(undefined4 *)(param1 + 0x18),
		                     Method_System_Collections_Generic_Dictionary_string__TermData__get_Count__);
		  if (iVar2 == 0) {
		    I2_Loc_LanguageSourceData__DeserializeFullTerm(param1,1,iVar1);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060076B8 RID: 30392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076B8")]
		[Address(RVA = "0xC02F", Offset = "0xC02F", VA = "0xC02F")]
		internal static void AddSource(LanguageSourceData Source)
		{
		/* --- GHIDRA: AddSource ---
		int I2_Loc_LocalizationManager__AddSource
		              (undefined4 param1,float param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a6050e == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager__Delayed_Import_Google_d__63_TypeInfo);
		    DAT_ram_00a6050e = '\x01';
		  }
		  iVar1 = unnamed_function_1417(I2_Loc_LocalizationManager__Delayed_Import_Google_d__63_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined1 *)(iVar1 + 0x18) = (undefined1)param3;
		  *(float *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060076B9 RID: 30393 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076B9")]
		[Address(RVA = "0xC030", Offset = "0xC030", VA = "0xC030")]
		private static IEnumerator Delayed_Import_Google(LanguageSourceData source, float delay, bool justCheck)
		{
		/* --- GHIDRA: Delayed_Import_Google ---
		void I2_Loc_LocalizationManager__Delayed_Import_Google(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6050f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__Remove__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a6050f = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  func_ii_4876(*(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),param1,
		               Method_System_Collections_Generic_List_LanguageSourceData__Remove__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060076BA RID: 30394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076BA")]
		[Address(RVA = "0xC031", Offset = "0xC031", VA = "0xC031")]
		internal static void RemoveSource(LanguageSourceData Source)
		{
		/* --- GHIDRA: RemoveSource ---
		uint I2_Loc_LocalizationManager__RemoveSource(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  
		  if (DAT_ram_00a60510 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_IndexOf_string___);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a60510 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  uVar1 = LunarConsolePlugin_CVar__set_Value
		                    (*(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x20),
		                     param1,Method_System_Array_IndexOf_string___);
		  return (uVar1 ^ 0xffffffff) >> 0x1f;
		}
		*/

		}

		// Token: 0x060076BB RID: 30395 RVA: 0x00015840 File Offset: 0x00013A40
		[Token(Token = "0x60076BB")]
		[Address(RVA = "0xC032", Offset = "0xC032", VA = "0xC032")]
		public static bool IsGlobalSource(string SourceName)
		{
		/* --- GHIDRA: IsGlobalSource ---
		undefined4
		I2_Loc_LocalizationManager__IsGlobalSource(undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a60511 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a60511 = '\x01';
		  }
		  iVar2 = func_ii_4769(param1,0);
		  if (iVar2 == 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    iVar2 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc);
		    if (0 < iVar2) {
		      do {
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        uVar1 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)
		                            (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),iVar4,
		                           Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		        iVar3 = func_ii_13851(uVar1,param1,0,iVar4);
		        if (iVar3 != 0) {
		          if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		          }
		          uVar1 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)
		                              (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),iVar4,
		                             Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		          return uVar1;
		        }
		        iVar4 = iVar4 + 1;
		      } while (iVar4 != iVar2);
		    }
		  }
		  uVar1 = 0;
		  if (param2 != 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    iVar4 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c);
		    if (0 < *(int *)(iVar4 + 0xc)) {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        iVar4 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c);
		      }
		      uVar1 = System_Linq_Enumerable__ToList_object_
		                        (iVar4,0,
		                         Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    }
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x060076BC RID: 30396 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076BC")]
		[Address(RVA = "0xC033", Offset = "0xC033", VA = "0xC033")]
		public static LanguageSourceData GetSourceContaining(string term, bool fallbackToFirst = true)
		{
		/* --- GHIDRA: GetSourceContaining ---
		undefined4 I2_Loc_LocalizationManager__GetSourceContaining(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a60512 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a60512 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar3 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc);
		  if (0 < iVar3) {
		    do {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      uVar1 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)
		                          (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),param2_00,
		                         Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		      uVar1 = I2_Loc_LanguageSourceData__UpdateAssetDictionary(uVar1,param1,param2_00);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar2 = UnityEngine_Component__GetComponent_object_(uVar1,0);
		      if (iVar2 != 0) {
		        return uVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar3);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x060076BD RID: 30397 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076BD")]
		[Address(RVA = "0xC034", Offset = "0xC034", VA = "0xC034")]
		public static UnityEngine.Object FindAsset(string value)
		{
		/* --- GHIDRA: FindAsset ---
		void I2_Loc_LocalizationManager__FindAsset(undefined4 param1)
		
		{
		  int param2;
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a60513 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a60513 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar1 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc);
		  if (0 < iVar1) {
		    param2 = 0;
		    do {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      param1_00 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)
		                              (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),param2,
		                             Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		      I2_Loc_LanguageSourceData__ApplyDownloadedDataOnSceneLoaded(param1_00,param2);
		      param2 = param2 + 1;
		    } while (param2 != iVar1);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060076BE RID: 30398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076BE")]
		[Address(RVA = "0xC035", Offset = "0xC035", VA = "0xC035")]
		public static void ApplyDownloadedDataFromGoogle()
		{
		/* --- GHIDRA: ApplyDownloadedDataFromGoogle ---
		undefined4 I2_Loc_LocalizationManager__ApplyDownloadedDataFromGoogle(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a60514 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a60514 = '\x01';
		  }
		  if (param1 == 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    iVar1 = func_ii_4769(*(undefined4 *)
		                          (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x28),0);
		    if (iVar1 == 0) goto code_r0x81c9e7d9;
		  }
		  iVar1 = I2_Loc_LocalizationManager_TypeInfo;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizationManager__GetCurrentDeviceLanguage(iVar1);
		code_r0x81c9e7d9:
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  return *(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x28);
		}
		*/

		}

		// Token: 0x060076BF RID: 30399 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076BF")]
		[Address(RVA = "0xC036", Offset = "0xC036", VA = "0xC036")]
		public static string GetCurrentDeviceLanguage(bool force = false)
		{
		/* --- GHIDRA: GetCurrentDeviceLanguage ---
		void I2_Loc_LocalizationManager__GetCurrentDeviceLanguage(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a60515 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_SystemLanguage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5383);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5391);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5392);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5380);
		    DAT_ram_00a60515 = '\x01';
		  }
		  if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Application_TypeInfo);
		  }
		  local_4 = UnityEngine_Application__get_isMobilePlatform(0);
		  local_8 = 0xffffffff;
		  local_c = UnityEngine_SystemLanguage_TypeInfo;
		  param1_00 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  *(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x28) = param1_00;
		  iVar1 = System_Collections_CollectionBase___ctor(param1_00,StringLiteral_5391,0);
		  iVar2 = I2_Loc_LocalizationManager_TypeInfo;
		  if (iVar1 != 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    iVar2 = I2_Loc_LocalizationManager_TypeInfo;
		    *(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x28) =
		         StringLiteral_5380;
		  }
		  if (*(int *)(iVar2 + 0x74) == 0) {
		    func_ii_306000(iVar2);
		    iVar2 = I2_Loc_LocalizationManager_TypeInfo;
		  }
		  iVar2 = System_Collections_CollectionBase___ctor
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x5c) + 0x28),StringLiteral_5392,0);
		  if (iVar2 != 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    *(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x28) =
		         StringLiteral_5383;
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060076C0 RID: 30400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076C0")]
		[Address(RVA = "0xC037", Offset = "0xC037", VA = "0xC037")]
		private static void DetectDeviceLanguage()
		{
		/* --- GHIDRA: DetectDeviceLanguage ---
		void I2_Loc_LocalizationManager__DetectDeviceLanguage(undefined4 param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 param1_00;
		  uint uVar4;
		  int iVar5;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a60516 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizeTargetDescriptor__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizeTargetDescriptor__FindIndex__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizeTargetDescriptor__Insert__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizeTargetDescriptor__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizeTargetDescriptor__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Predicate_ILocalizeTargetDescriptor__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_I2_Loc_LocalizationManager___c__DisplayClass73_0__RegisterTarget_b__0__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager___c__DisplayClass73_0_TypeInfo);
		    DAT_ram_00a60516 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(I2_Loc_LocalizationManager___c__DisplayClass73_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param1;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  param1_00 = *(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x2c);
		  uVar1 = unnamed_function_1417(System_Predicate_ILocalizeTargetDescriptor__TypeInfo);
		  func_ii_7297(uVar1,param2_00,
		               Method_I2_Loc_LocalizationManager___c__DisplayClass73_0__RegisterTarget_b__0__,0);
		  iVar2 = System_Collections_Generic_List_UsageHint___FindAll
		                    (param1_00,uVar1,
		                     Method_System_Collections_Generic_List_ILocalizeTargetDescriptor__FindIndex__);
		  if (iVar2 == -1) {
		    while( true ) {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      iVar2 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x2c);
		      uVar4 = *(uint *)(iVar2 + 0xc);
		      if ((int)uVar4 <= iVar5) break;
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        iVar2 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x2c);
		      }
		      iVar3 = System_Linq_Enumerable__ToList_object_
		                        (iVar2,iVar5,
		                         Method_System_Collections_Generic_List_ILocalizeTargetDescriptor__get_Item__
		                        );
		      iVar2 = *(int *)(param2_00 + 8);
		      if (*(int *)(iVar2 + 0xc) < *(int *)(iVar3 + 0xc)) {
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		          iVar2 = *(int *)(param2_00 + 8);
		        }
		        System_Collections_Generic_List_IntPtr___AddWithResize
		                  (*(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x2c),
		                   iVar5,iVar2,
		                   Method_System_Collections_Generic_List_ILocalizeTargetDescriptor__Insert__);
		        return;
		      }
		      iVar5 = iVar5 + 1;
		    }
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      iVar2 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x2c);
		      uVar4 = *(uint *)(iVar2 + 0xc);
		    }
		    iVar5 = Method_System_Collections_Generic_List_ILocalizeTargetDescriptor__Add__;
		    uVar1 = *(undefined4 *)(param2_00 + 8);
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    if (uVar4 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar4 + 1;
		      *(undefined4 *)(*(int *)(iVar2 + 8) + uVar4 * 4 + 0x10) = uVar1;
		      return;
		    }
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar2,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060076C1 RID: 30401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076C1")]
		[Address(RVA = "0xC038", Offset = "0xC038", VA = "0xC038")]
		public static void RegisterTarget(ILocalizeTargetDescriptor desc)
		{
		/* --- GHIDRA: RegisterTarget ---
		void I2_Loc_LocalizationManager__RegisterTarget(undefined4 param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a60517 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_OnLocalizeCallback_TypeInfo);
		    DAT_ram_00a60517 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  param1_00 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x30);
		  do {
		    param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param1,0);
		    if ((param1_01 != (int *)0x0) &&
		       (I2_Loc_LocalizationManager_OnLocalizeCallback_TypeInfo != *param1_01)) {
		      System_Activator__CreateInstance
		                (param1_01,I2_Loc_LocalizationManager_OnLocalizeCallback_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    iVar2 = func_ii_4329(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x30,param1_01,
		                         param1_00);
		    bVar1 = iVar2 != param1_00;
		    param1_00 = iVar2;
		  } while (bVar1);
		  return;
		}
		*/

		}

		// Token: 0x14000308 RID: 776
		// (add) Token: 0x060076C2 RID: 30402 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060076C3 RID: 30403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000308")]
		public static event LocalizationManager.OnLocalizeCallback OnLocalizeEvent
		{
			[Token(Token = "0x60076C2")]
			[Address(RVA = "0xC039", Offset = "0xC039", VA = "0xC039")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60076C3")]
			[Address(RVA = "0xC03A", Offset = "0xC03A", VA = "0xC03A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060076C4 RID: 30404 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076C4")]
		[Address(RVA = "0xC03B", Offset = "0xC03B", VA = "0xC03B")]
		public static string GetTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
		{
		/* --- GHIDRA: GetTranslation ---
		undefined4
		I2_Loc_LocalizationManager__GetTranslation
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          ,undefined4 param6,undefined4 param7,undefined4 param8,undefined4 param9)
		
		{
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a6051a == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a6051a = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  if (DAT_ram_00a60519 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a60519 = '\x01';
		  }
		  local_4 = 0;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  func_ii_13839(param1,&local_4,param2,param3,param4,param5,param6,param7,param8,auStack_10);
		  return local_4;
		}
		*/

			return null;
		}

		// Token: 0x060076C5 RID: 30405 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076C5")]
		[Address(RVA = "0xC03C", Offset = "0xC03C", VA = "0xC03C")]
		public static string GetTermTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
		{
		/* --- GHIDRA: GetTermTranslation ---
		undefined4 I2_Loc_LocalizationManager__GetTermTranslation(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a6051c == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a6051c = '\x01';
		  }
		  iVar1 = func_ii_4769(param1,0);
		  if (iVar1 == 0) {
		    while( true ) {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      iVar1 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c);
		      if (*(int *)(iVar1 + 0xc) <= param2_00) break;
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        iVar1 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c);
		      }
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,param2_00,
		                         Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		      iVar1 = func_ii_4769(*(undefined4 *)(iVar1 + 0x20),0);
		      if (iVar1 == 0) {
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        uVar3 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)
		                            (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),param2_00,
		                           Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		        iVar1 = I2_Loc_LanguageSourceData__IsCurrentLanguage(uVar3,param1,0,0,param2_00);
		        if (-1 < iVar1) {
		          if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		          }
		          uVar3 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)
		                              (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),
		                             param2_00,
		                             Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		          iVar2 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)
		                              (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),
		                             param2_00,
		                             Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		          iVar2 = func_ii_13851(uVar3,*(undefined4 *)(iVar2 + 0x20),0,param2_00);
		          if (iVar2 != 0) {
		            uVar3 = I2_Loc_LocalizeTarget_UnityUI_Text___ctor(iVar2,iVar1,0,0,0);
		            iVar1 = func_ii_4769(uVar3,0);
		            if (iVar1 == 0) {
		              return uVar3;
		            }
		          }
		        }
		      }
		      param2_00 = param2_00 + 1;
		    }
		  }
		  if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Application_TypeInfo);
		  }
		  uVar3 = UnityEngine_Application__get_identifier(0);
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x060076C6 RID: 30406 RVA: 0x00015858 File Offset: 0x00013A58
		[Token(Token = "0x60076C6")]
		[Address(RVA = "0x3610", Offset = "0x3610", VA = "0x3610")]
		public static bool TryGetTranslation(string Term, out string Translation, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
		{
		/* --- GHIDRA: TryGetTranslation ---
		undefined4 I2_Loc_LocalizationManager__TryGetTranslation(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0xcc) + 8);
		}
		*/

			return default(bool);
		}

		// Token: 0x060076C7 RID: 30407 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076C7")]
		public static T GetTranslatedObject<T>(string AssetName, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060076C8 RID: 30408 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076C8")]
		public static T GetTranslatedObjectByTermName<T>(string Term, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060076C9 RID: 30409 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076C9")]
		[Address(RVA = "0xC03D", Offset = "0xC03D", VA = "0xC03D")]
		public static string GetAppName(string languageCode)
		{
		/* --- GHIDRA: GetAppName ---
		void I2_Loc_LocalizationManager__GetAppName(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a6051d == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a6051d = '\x01';
		  }
		  iVar2 = I2_Loc_LocalizationManager_TypeInfo;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizationManager__IsLanguageEnabled(iVar2);
		  if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Application_TypeInfo);
		  }
		  iVar1 = func_ii_3441(0);
		  iVar2 = I2_Loc_LocalizationManager_TypeInfo;
		  if (iVar1 == 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    I2_Loc_LocalizationManager__Coroutine_LocalizeAll(param1,iVar2);
		    return;
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar2 = I2_Loc_LocalizationManager_TypeInfo;
		  iVar1 = *(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c);
		  *(byte *)(iVar1 + 0x35) = *(byte *)(iVar1 + 0x35) | (byte)param1;
		  if (*(char *)(iVar1 + 0x34) == '\0') {
		    if (*(int *)(iVar2 + 0x74) == 0) {
		      func_ii_306000(iVar2);
		    }
		    if (DAT_ram_00a6051e == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&I2_Loc_LocalizationManager__Coroutine_LocalizeAll_d__88_TypeInfo);
		      DAT_ram_00a6051e = '\x01';
		    }
		    iVar2 = unnamed_function_1417(I2_Loc_LocalizationManager__Coroutine_LocalizeAll_d__88_TypeInfo);
		    *(undefined4 *)(iVar2 + 8) = 0;
		    I2_Loc_CoroutineManager__Awake(iVar2,0);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060076CA RID: 30410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076CA")]
		[Address(RVA = "0xC03E", Offset = "0xC03E", VA = "0xC03E")]
		public static void LocalizeAll(bool Force = false)
		{
		/* --- GHIDRA: LocalizeAll ---
		int I2_Loc_LocalizationManager__LocalizeAll(undefined4 param1)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a6051e == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager__Coroutine_LocalizeAll_d__88_TypeInfo);
		    DAT_ram_00a6051e = '\x01';
		  }
		  iVar1 = unnamed_function_1417(I2_Loc_LocalizationManager__Coroutine_LocalizeAll_d__88_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060076CB RID: 30411 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076CB")]
		[Address(RVA = "0xC03F", Offset = "0xC03F", VA = "0xC03F")]
		private static IEnumerator Coroutine_LocalizeAll()
		{
		/* --- GHIDRA: Coroutine_LocalizeAll ---
		void I2_Loc_LocalizationManager__Coroutine_LocalizeAll(undefined4 param1,undefined4 param2)
		
		{
		  int param3;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a6051f == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_Localize___TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_Localize_var);
		    DAT_ram_00a6051f = '\x01';
		  }
		  uVar1 = I2_Loc_Localize_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  param3 = 0;
		  uVar1 = func_ii_2734(uVar1,0);
		  iVar2 = UnityEngine_ResourcesAPI___cctor(uVar1,0);
		  uVar1 = I2_Loc_Localize___TypeInfo;
		  if ((iVar2 != 0) && (iVar3 = func_ii_1082(iVar2,I2_Loc_Localize___TypeInfo), iVar3 == 0)) {
		    System_Activator__CreateInstance(iVar2,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = *(int *)(iVar3 + 0xc);
		  if (0 < iVar2) {
		    do {
		      I2_Loc_Localize__HasCallback(*(undefined4 *)(iVar3 + param3 * 4 + 0x10),param1,param3);
		      param3 = param3 + 1;
		    } while (param3 != iVar2);
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar3 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x30);
		  if (iVar3 != 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      iVar3 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x30);
		    }
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060076CC RID: 30412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076CC")]
		[Address(RVA = "0xC040", Offset = "0xC040", VA = "0xC040")]
		private static void DoLocalizeAll(bool Force = false)
		{
		/* --- GHIDRA: DoLocalizeAll ---
		undefined4 I2_Loc_LocalizationManager__DoLocalizeAll(undefined4 param1)
		
		{
		  int param2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  
		  if (DAT_ram_00a60520 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a60520 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_string___ctor__);
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar1 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc);
		  if (0 < iVar1) {
		    param2 = 0;
		    do {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      param1_01 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)
		                              (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),param2,
		                             Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		      I2_Loc_LanguageSourceData__HasUnloadedLanguages(param1_01,0,param1_00,param2);
		      param2 = param2 + 1;
		    } while (param2 != iVar1);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x060076CD RID: 30413 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076CD")]
		[Address(RVA = "0xC041", Offset = "0xC041", VA = "0xC041")]
		public static List<string> GetCategories()
		{
		/* --- GHIDRA: GetCategories ---
		undefined4 I2_Loc_LocalizationManager__GetCategories(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a60521 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_string__UnionWith__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a60521 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  if (*(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc) == 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    if (DAT_ram_00a60508 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		      Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		      DAT_ram_00a60508 = '\x01';
		    }
		    iVar1 = I2_Loc_LocalizationManager_TypeInfo;
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    I2_Loc_LocalizationManager__UpdateSources(iVar1);
		    I2_Loc_LocalizationManager__RegisterSceneSources(iVar1);
		    I2_Loc_LocalizationManager__UnregisterDeletededSources(iVar1);
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar1 = I2_Loc_LocalizationManager_TypeInfo;
		  iVar4 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c);
		  if (*(int *)(iVar4 + 0xc) == 1) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      iVar4 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c);
		    }
		    uVar2 = System_Linq_Enumerable__ToList_object_
		                      (iVar4,0,Method_System_Collections_Generic_List_LanguageSourceData__get_Item__
		                      );
		    uVar2 = I2_Loc_LanguageSourceData__ContainsTerm(uVar2,param1,iVar1);
		    return uVar2;
		  }
		  iVar1 = 0;
		  uVar2 = unnamed_function_1417(System_Collections_Generic_HashSet_string__TypeInfo);
		  func_ii_7115(uVar2,Method_System_Collections_Generic_HashSet_string___ctor__);
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar4 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc);
		  if (0 < iVar4) {
		    do {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      uVar3 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)
		                          (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),iVar1,
		                         Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		      uVar3 = I2_Loc_LanguageSourceData__ContainsTerm(uVar3,param1,iVar1);
		      System_Collections_Generic_HashSet_object___TrimExcess
		                (uVar2,uVar3,Method_System_Collections_Generic_HashSet_string__UnionWith__);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar4);
		  }
		  uVar3 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  Sirenix_Utilities_LinqExtensions__Convert_object_
		            (uVar3,uVar2,Method_System_Collections_Generic_List_string___ctor__);
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x060076CE RID: 30414 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076CE")]
		[Address(RVA = "0xC042", Offset = "0xC042", VA = "0xC042")]
		public static List<string> GetTermsList([Optional] string Category)
		{
		/* --- GHIDRA: GetTermsList ---
		undefined4 I2_Loc_LocalizationManager__GetTermsList(undefined4 param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a60522 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a60522 = '\x01';
		  }
		  iVar2 = I2_Loc_LocalizationManager_TypeInfo;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizeDropdown___ctor(iVar2);
		  iVar2 = *(int *)(*(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) + 0xc);
		  if (0 < iVar2) {
		    param2_00 = 0;
		    do {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      param1_00 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)
		                              (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),
		                             param2_00,
		                             Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		      iVar1 = func_ii_13851(param1_00,param1,0,param2_00);
		      if (iVar1 != 0) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x060076CF RID: 30415 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076CF")]
		[Address(RVA = "0xC043", Offset = "0xC043", VA = "0xC043")]
		public static TermData GetTermData(string term)
		{
		/* --- GHIDRA: GetTermData ---
		void I2_Loc_LocalizationManager__GetTermData(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a60524 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizationParamsManager___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizeTargetDescriptor___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_LanguageSourceData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_ILocalizeTargetDescriptor__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_ILocalizationParamsManager__TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19909);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19900);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19905);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19903);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19906);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19913);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19899);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24314);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19902);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19907);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19898);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19904);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19910);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8919);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19912);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23120);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24933);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28137);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19908);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19911);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19901);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19914);
		    DAT_ram_00a60524 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_List_ILocalizationParamsManager__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_ILocalizationParamsManager___ctor__);
		  *(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x10) = uVar1;
		  iVar2 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,0x15);
		  *(undefined4 *)(iVar2 + 0x10) = StringLiteral_19901;
		  *(undefined4 *)(iVar2 + 0x14) = StringLiteral_19898;
		  *(undefined4 *)(iVar2 + 0x18) = StringLiteral_19900;
		  *(undefined4 *)(iVar2 + 0x1c) = StringLiteral_19902;
		  *(undefined4 *)(iVar2 + 0x20) = StringLiteral_19903;
		  *(undefined4 *)(iVar2 + 0x24) = StringLiteral_19904;
		  *(undefined4 *)(iVar2 + 0x28) = StringLiteral_19905;
		  *(undefined4 *)(iVar2 + 0x2c) = StringLiteral_19906;
		  *(undefined4 *)(iVar2 + 0x30) = StringLiteral_19907;
		  *(undefined4 *)(iVar2 + 0x34) = StringLiteral_19908;
		  *(undefined4 *)(iVar2 + 0x38) = StringLiteral_19909;
		  *(undefined4 *)(iVar2 + 0x3c) = StringLiteral_19910;
		  *(undefined4 *)(iVar2 + 0x40) = StringLiteral_19911;
		  *(undefined4 *)(iVar2 + 0x44) = StringLiteral_19912;
		  *(undefined4 *)(iVar2 + 0x48) = StringLiteral_19913;
		  *(undefined4 *)(iVar2 + 0x4c) = StringLiteral_19899;
		  *(undefined4 *)(iVar2 + 0x50) = StringLiteral_19914;
		  *(undefined4 *)(iVar2 + 0x54) = StringLiteral_23120;
		  *(undefined4 *)(iVar2 + 0x58) = StringLiteral_24314;
		  *(undefined4 *)(iVar2 + 0x5c) = StringLiteral_28137;
		  *(undefined4 *)(iVar2 + 0x60) = StringLiteral_24933;
		  *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x18) = iVar2;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_LanguageSourceData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_LanguageSourceData___ctor__);
		  *(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) = uVar1;
		  iVar2 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,1);
		  *(undefined4 *)(iVar2 + 0x10) = StringLiteral_8919;
		  iVar3 = *(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c);
		  *(undefined4 *)(iVar3 + 0x24) = 0;
		  *(int *)(iVar3 + 0x20) = iVar2;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_ILocalizeTargetDescriptor__TypeInfo)
		  ;
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_ILocalizeTargetDescriptor___ctor__);
		  iVar2 = *(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c);
		  *(undefined1 *)(iVar2 + 0x36) = 0;
		  *(undefined4 *)(iVar2 + 0x2c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: GetTermData ---
		void I2_Loc_LocalizationManager__GetTermData(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a60524 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizationParamsManager___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizeTargetDescriptor___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_LanguageSourceData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_ILocalizeTargetDescriptor__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_ILocalizationParamsManager__TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19909);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19900);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19905);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19903);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19906);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19913);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19899);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24314);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19902);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19907);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19898);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19904);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19910);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8919);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19912);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23120);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24933);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28137);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19908);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19911);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19901);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19914);
		    DAT_ram_00a60524 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_List_ILocalizationParamsManager__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_ILocalizationParamsManager___ctor__);
		  *(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x10) = uVar1;
		  iVar2 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,0x15);
		  *(undefined4 *)(iVar2 + 0x10) = StringLiteral_19901;
		  *(undefined4 *)(iVar2 + 0x14) = StringLiteral_19898;
		  *(undefined4 *)(iVar2 + 0x18) = StringLiteral_19900;
		  *(undefined4 *)(iVar2 + 0x1c) = StringLiteral_19902;
		  *(undefined4 *)(iVar2 + 0x20) = StringLiteral_19903;
		  *(undefined4 *)(iVar2 + 0x24) = StringLiteral_19904;
		  *(undefined4 *)(iVar2 + 0x28) = StringLiteral_19905;
		  *(undefined4 *)(iVar2 + 0x2c) = StringLiteral_19906;
		  *(undefined4 *)(iVar2 + 0x30) = StringLiteral_19907;
		  *(undefined4 *)(iVar2 + 0x34) = StringLiteral_19908;
		  *(undefined4 *)(iVar2 + 0x38) = StringLiteral_19909;
		  *(undefined4 *)(iVar2 + 0x3c) = StringLiteral_19910;
		  *(undefined4 *)(iVar2 + 0x40) = StringLiteral_19911;
		  *(undefined4 *)(iVar2 + 0x44) = StringLiteral_19912;
		  *(undefined4 *)(iVar2 + 0x48) = StringLiteral_19913;
		  *(undefined4 *)(iVar2 + 0x4c) = StringLiteral_19899;
		  *(undefined4 *)(iVar2 + 0x50) = StringLiteral_19914;
		  *(undefined4 *)(iVar2 + 0x54) = StringLiteral_23120;
		  *(undefined4 *)(iVar2 + 0x58) = StringLiteral_24314;
		  *(undefined4 *)(iVar2 + 0x5c) = StringLiteral_28137;
		  *(undefined4 *)(iVar2 + 0x60) = StringLiteral_24933;
		  *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x18) = iVar2;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_LanguageSourceData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_LanguageSourceData___ctor__);
		  *(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c) = uVar1;
		  iVar2 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,1);
		  *(undefined4 *)(iVar2 + 0x10) = StringLiteral_8919;
		  iVar3 = *(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c);
		  *(undefined4 *)(iVar3 + 0x24) = 0;
		  *(int *)(iVar3 + 0x20) = iVar2;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_ILocalizeTargetDescriptor__TypeInfo)
		  ;
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_ILocalizeTargetDescriptor___ctor__);
		  iVar2 = *(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c);
		  *(undefined1 *)(iVar2 + 0x36) = 0;
		  *(undefined4 *)(iVar2 + 0x2c) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060076D0 RID: 30416 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076D0")]
		[Address(RVA = "0xC044", Offset = "0xC044", VA = "0xC044")]
		public static TermData GetTermData(string term, out LanguageSourceData source)
		{
			return null;
		}

		// Token: 0x04003E25 RID: 15909
		[Token(Token = "0x4003E25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string mCurrentLanguage;

		// Token: 0x04003E26 RID: 15910
		[Token(Token = "0x4003E26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static string mLanguageCode;

		// Token: 0x04003E27 RID: 15911
		[Token(Token = "0x4003E27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static CultureInfo mCurrentCulture;

		// Token: 0x04003E28 RID: 15912
		[Token(Token = "0x4003E28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static bool mChangeCultureInfo;

		// Token: 0x04003E29 RID: 15913
		[Token(Token = "0x4003E29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public static bool IsRight2Left;

		// Token: 0x04003E2A RID: 15914
		[Token(Token = "0x4003E2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public static bool HasJoinedWords;

		// Token: 0x04003E2B RID: 15915
		[Token(Token = "0x4003E2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static List<ILocalizationParamsManager> ParamManagers;

		// Token: 0x04003E2C RID: 15916
		[Token(Token = "0x4003E2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static LocalizationManager.FnCustomApplyLocalizationParams CustomApplyLocalizationParams;

		// Token: 0x04003E2D RID: 15917
		[Token(Token = "0x4003E2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string[] LanguagesRTL;

		// Token: 0x04003E2E RID: 15918
		[Token(Token = "0x4003E2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static List<LanguageSourceData> Sources;

		// Token: 0x04003E2F RID: 15919
		[Token(Token = "0x4003E2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] GlobalSources;

		// Token: 0x04003E30 RID: 15920
		[Token(Token = "0x4003E30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static Func<LanguageSourceData, bool> Callback_AllowSyncFromGoogle;

		// Token: 0x04003E31 RID: 15921
		[Token(Token = "0x4003E31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static string mCurrentDeviceLanguage;

		// Token: 0x04003E32 RID: 15922
		[Token(Token = "0x4003E32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static List<ILocalizeTargetDescriptor> mLocalizeTargets;

		// Token: 0x04003E34 RID: 15924
		[Token(Token = "0x4003E34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private static bool mLocalizeIsScheduled;

		// Token: 0x04003E35 RID: 15925
		[Token(Token = "0x4003E35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private static bool mLocalizeIsScheduledWithForcedValue;

		// Token: 0x04003E36 RID: 15926
		[Token(Token = "0x4003E36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		public static bool HighlightLocalizedTargets;

		// Token: 0x0200137C RID: 4988
		// (Invoke) Token: 0x060076D3 RID: 30419
		[Token(Token = "0x200137C")]
		public delegate bool FnCustomApplyLocalizationParams(ref string translation, LocalizationManager._GetParam getParam, bool allowLocalizedParameters);

		// Token: 0x0200137D RID: 4989
		// (Invoke) Token: 0x060076D7 RID: 30423
		[Token(Token = "0x200137D")]
		public delegate object _GetParam(string param);

		// Token: 0x0200137E RID: 4990
		// (Invoke) Token: 0x060076DB RID: 30427
		[Token(Token = "0x200137E")]
		public delegate void OnLocalizeCallback();
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CurrentLanguage ---
		void I2_Loc_LocalizationManager__get_CurrentLanguage(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a604e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604e7 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizeDropdown___ctor(param1);
		  param1_00 = I2_Loc_LocalizationManager__HasLanguage(param1,0,param1);
		  iVar1 = func_ii_4769(param1_00,0);
		  if (iVar1 == 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    iVar1 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                      (**(undefined4 **)(I2_Loc_LocalizationManager_TypeInfo + 0x5c),param1_00,0);
		    if (iVar1 != 0) {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      param2_00 = I2_Loc_LocalizationManager__GetSupportedLanguage(param1_00,param1_00);
		      I2_Loc_LocalizationManager__get_CurrentCulture(param1_00,param2_00,1,0,param1_00);
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_CurrentLanguage ---
		undefined4 I2_Loc_LocalizationManager__set_CurrentLanguage(undefined4 param1)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a604e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604e8 = '\x01';
		  }
		  param1_00 = I2_Loc_LocalizationManager_TypeInfo;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizeDropdown___ctor(param1_00);
		  return *(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 4);
		}
		*/


		/* --- GHIDRA: get_CurrentLanguageCode ---
		void I2_Loc_LocalizationManager__get_CurrentLanguageCode(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a604e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604e9 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizeDropdown___ctor(param1);
		  iVar1 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                    (*(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 4),
		                     param1,0);
		  if (iVar1 != 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    param1_00 = I2_Loc_LocalizationManager__GetLanguageCode(param1,1,param1);
		    iVar1 = func_ii_4769(param1_00,0);
		    if (iVar1 == 0) {
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      I2_Loc_LocalizationManager__get_CurrentCulture(param1_00,param1,1,0,param1);
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_CurrentLanguageCode ---
		undefined4 I2_Loc_LocalizationManager__set_CurrentLanguageCode(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  uint uVar3;
		  uint uVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a604ea == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18845);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19124);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1687);
		    DAT_ram_00a604ea = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  if (DAT_ram_00a604e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604e6 = '\x01';
		  }
		  iVar2 = I2_Loc_LocalizationManager_TypeInfo;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizeDropdown___ctor(iVar2);
		  param1_00 = **(undefined4 **)(I2_Loc_LocalizationManager_TypeInfo + 0x5c);
		  uVar1 = I2_Loc_StringObfucator__XoREncode(StringLiteral_1687,0);
		  iVar2 = func_ii_13807(param1_00,uVar1,0);
		  if (0 < iVar2) {
		    uVar1 = System_String__get_Chars(param1_00,iVar2 + 1,0);
		    return uVar1;
		  }
		  uVar1 = I2_Loc_StringObfucator__XoREncode(StringLiteral_18845,0);
		  uVar3 = func_ii_13807(param1_00,uVar1,0);
		  uVar1 = I2_Loc_StringObfucator__XoREncode(StringLiteral_19124,0);
		  uVar4 = System_String__LastIndexOf(param1_00,uVar1,0);
		  if ((0 < (int)uVar3) && (uVar3 != uVar4)) {
		    uVar1 = System_Data_DataSet__ReadXmlSchema(param1_00,uVar3 + 1,uVar4 + (uVar3 ^ 0xffffffff),0);
		    return uVar1;
		  }
		  return **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		}
		*/


		/* --- GHIDRA: get_CurrentRegion ---
		void I2_Loc_LocalizationManager__get_CurrentRegion(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a604eb == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18845);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1072);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1145);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19124);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1687);
		    DAT_ram_00a604eb = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  if (DAT_ram_00a604e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604e6 = '\x01';
		  }
		  iVar2 = I2_Loc_LocalizationManager_TypeInfo;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizeDropdown___ctor(iVar2);
		  uVar4 = **(undefined4 **)(I2_Loc_LocalizationManager_TypeInfo + 0x5c);
		  uVar1 = I2_Loc_StringObfucator__XoREncode(StringLiteral_1687,0);
		  iVar2 = func_ii_13807(uVar4,uVar1,0);
		  if (iVar2 < 1) {
		    uVar1 = I2_Loc_StringObfucator__XoREncode(StringLiteral_18845,0);
		    iVar2 = func_ii_13807(uVar4,uVar1,0);
		    uVar1 = I2_Loc_StringObfucator__XoREncode(StringLiteral_19124,0);
		    iVar3 = System_String__LastIndexOf(uVar4,uVar1,0);
		    if ((0 < iVar2) && (iVar2 != iVar3)) {
		      uVar4 = System_String__get_Chars(uVar4,iVar2,0);
		    }
		    uVar4 = System_Int32__ToString(uVar4,StringLiteral_1072,param1,StringLiteral_1145,0);
		    iVar2 = *(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74);
		  }
		  else {
		    uVar4 = System_String__get_Chars(uVar4,iVar2 + 1,0);
		    uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar4,param1,0);
		    iVar2 = *(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74);
		  }
		  if (iVar2 == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizationManager__get_CurrentLanguage(uVar4,uVar4);
		  return;
		}
		*/


		/* --- GHIDRA: set_CurrentRegion ---
		undefined4 I2_Loc_LocalizationManager__set_CurrentRegion(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a604ec == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_177);
		    DAT_ram_00a604ec = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  if (DAT_ram_00a604e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604e8 = '\x01';
		  }
		  iVar2 = I2_Loc_LocalizationManager_TypeInfo;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizeDropdown___ctor(iVar2);
		  param1_00 = *(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 4);
		  uVar1 = I2_Loc_StringObfucator__XoREncode(StringLiteral_177,0);
		  iVar2 = func_ii_13807(param1_00,uVar1,0);
		  if (-1 < iVar2) {
		    uVar1 = System_String__get_Chars(param1_00,iVar2 + 1,0);
		    return uVar1;
		  }
		  return **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		}
		*/


		/* --- GHIDRA: get_CurrentRegionCode ---
		void I2_Loc_LocalizationManager__get_CurrentRegionCode(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a604ed == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_177);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1331);
		    DAT_ram_00a604ed = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  if (DAT_ram_00a604e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604e8 = '\x01';
		  }
		  iVar2 = I2_Loc_LocalizationManager_TypeInfo;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizeDropdown___ctor(iVar2);
		  param1_00 = *(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 4);
		  uVar1 = I2_Loc_StringObfucator__XoREncode(StringLiteral_177,0);
		  iVar2 = func_ii_13807(param1_00,uVar1,0);
		  if (0 < iVar2) {
		    param1_00 = System_Data_DataSet__ReadXmlSchema(param1_00,0,iVar2,0);
		  }
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (param1_00,StringLiteral_1331,param1,0);
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizationManager__get_CurrentLanguageCode(uVar1,uVar1);
		  return;
		}
		*/


		/* --- GHIDRA: set_CurrentRegionCode ---
		undefined4 I2_Loc_LocalizationManager__set_CurrentRegionCode(undefined4 param1)
		
		{
		  if (DAT_ram_00a604ee == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a604ee = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  return *(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 8);
		}
		*/


		/* --- GHIDRA: get_CurrentCulture ---
		void I2_Loc_LocalizationManager__get_CurrentCulture
		               (undefined4 param1,undefined4 param2,int param3,int param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a604ef == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleLanguages_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8918);
		    DAT_ram_00a604ef = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  iVar1 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                    (**(undefined4 **)(I2_Loc_LocalizationManager_TypeInfo + 0x5c),param1,0);
		  if (iVar1 == 0) {
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    iVar1 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                      (*(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 4),
		                       param2,0);
		  }
		  else {
		    iVar1 = 1;
		  }
		  if (iVar1 != 0 || param4 != 0) {
		    if (param3 != 0) {
		      I2_Loc_PersistentStorage__SaveFile(StringLiteral_8918,param1,0);
		    }
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    **(undefined4 **)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) = param1;
		    *(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 4) = param2;
		    uVar2 = I2_Loc_LocalizationManager__SetLanguageAndCode(param2,param1);
		    iVar1 = I2_Loc_LocalizationManager_TypeInfo;
		    iVar3 = *(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c);
		    *(undefined4 *)(iVar3 + 8) = uVar2;
		    if (*(char *)(iVar3 + 0xc) != '\0') {
		      if (*(int *)(iVar1 + 0x74) == 0) {
		        func_ii_306000(iVar1);
		      }
		      if (DAT_ram_00a604f2 == '\0') {
		        Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		        DAT_ram_00a604f2 = '\x01';
		      }
		      uVar2 = func_ii_8975(0);
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      System_Threading_Thread__get_CurrentCulture
		                (uVar2,*(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 8),0);
		      iVar1 = I2_Loc_LocalizationManager_TypeInfo;
		    }
		    if (*(int *)(iVar1 + 0x74) == 0) {
		      func_ii_306000(iVar1);
		      iVar1 = I2_Loc_LocalizationManager_TypeInfo;
		    }
		    uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x5c) + 4);
		    if (DAT_ram_00a60507 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_System_Array_IndexOf_string___);
		      Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		      DAT_ram_00a60507 = '\x01';
		      iVar1 = I2_Loc_LocalizationManager_TypeInfo;
		    }
		    if (*(int *)(iVar1 + 0x74) == 0) {
		      func_ii_306000(iVar1);
		      iVar1 = I2_Loc_LocalizationManager_TypeInfo;
		    }
		    iVar1 = LunarConsolePlugin_CVar__set_Value
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x5c) + 0x18),uVar2,
		                       Method_System_Array_IndexOf_string___);
		    iVar3 = *(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c);
		    *(bool *)(iVar3 + 0xd) = -1 < iVar1;
		    uVar2 = *(undefined4 *)(iVar3 + 4);
		    if (*(int *)(I2_Loc_GoogleLanguages_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_GoogleLanguages_TypeInfo);
		    }
		    uVar2 = I2_Loc_GoogleLanguages__GetAllInternationalCodes(uVar2,0);
		    *(char *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xe) = (char)uVar2;
		    I2_Loc_LocalizationManager__GetAppName(param4,uVar2);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: add_OnLocalizeEvent ---
		void I2_Loc_LocalizationManager__add_OnLocalizeEvent(undefined4 param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a60518 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_OnLocalizeCallback_TypeInfo);
		    DAT_ram_00a60518 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  param1_00 = *(int *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x30);
		  do {
		    param1_01 = (int *)func_ii_7048(param1_00,param1,0);
		    if ((param1_01 != (int *)0x0) &&
		       (I2_Loc_LocalizationManager_OnLocalizeCallback_TypeInfo != *param1_01)) {
		      System_Activator__CreateInstance
		                (param1_01,I2_Loc_LocalizationManager_OnLocalizeCallback_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    iVar2 = func_ii_4329(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x30,param1_01,
		                         param1_00);
		    bVar1 = iVar2 != param1_00;
		    param1_00 = iVar2;
		  } while (bVar1);
		  return;
		}
		*/


		/* --- GHIDRA: remove_OnLocalizeEvent ---
		undefined4
		I2_Loc_LocalizationManager__remove_OnLocalizeEvent
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          ,undefined4 param6,undefined4 param7,undefined4 param8,undefined4 param9)
		
		{
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a60519 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a60519 = '\x01';
		  }
		  local_4 = 0;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  func_ii_13839(param1,&local_4,param2,param3,param4,param5,param6,param7,param8,auStack_10);
		  return local_4;
		}
		*/


		/* --- GHIDRA: GetTranslatedObject<object> ---
		undefined4
		I2_Loc_LocalizationManager__GetTranslatedObject_object_
		          (undefined4 param1,undefined4 param2,int param3)
		
		{
		  undefined4 uVar1;
		  
		  if ((*(int *)(param3 + 0x1c) == 0) &&
		     (Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo),
		     *(int *)(param3 + 0x1c) == 0)) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  uVar1 = I2_Loc_LocalizationManager__remove_OnLocalizeEvent(param1,0,0,1,0,0,0,1,0);
		  uVar1 = Google_Protobuf_Collections_Lists__GetHashCode___Il2CppFullySharedGenericType_
		                    (uVar1,0,**(undefined4 **)(param3 + 0x1c));
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GetTranslatedObjectByTermName<object> ---
		undefined4
		I2_Loc_LocalizationManager__GetTranslatedObjectByTermName_object_
		          (int param1,undefined4 param2,int param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 uStack_c;
		  int local_8;
		  undefined4 uStack_4;
		  
		  if (*(int *)(param3 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__Object__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__Object__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__Object__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__Object__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__Object__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__Object__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__Object__get_Value__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Object__get_Count__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    if (*(int *)(param3 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param3);
		    }
		  }
		  local_8 = 0;
		  uStack_4 = 0;
		  local_10 = 0;
		  uStack_c = 0;
		  local_18 = 0;
		  iVar1 = func_ii_4769(param2,0);
		  if (iVar1 != 0) {
		    return 0;
		  }
		  if ((*(int *)(param1 + 0x4c) == 0) ||
		     (iVar1 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                        (*(int *)(param1 + 0x4c),
		                         Method_System_Collections_Generic_Dictionary_string__Object__get_Count__),
		     iVar1 != *(int *)(*(int *)(param1 + 0x48) + 0xc))) {
		    I2_Loc_Localize__SetTerm(param1,0);
		  }
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_30,*(undefined4 *)(param1 + 0x4c),
		             Method_System_Collections_Generic_Dictionary_string__Object__GetEnumerator__);
		  local_8 = (int)local_20;
		  uStack_4 = (undefined4)((ulonglong)local_20 >> 0x20);
		  local_10 = (undefined4)local_28;
		  uStack_c = (undefined4)((ulonglong)local_28 >> 0x20);
		  local_30 = 0;
		  puStack_2c = &local_18;
		  do {
		    do {
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x158,&local_18,
		                           Method_System_Collections_Generic_Dictionary_Enumerator_string__Object__MoveNext__
		                          );
		        iVar4 = local_8;
		        uVar3 = uStack_c;
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x820f00f2;
		        }
		        if (iVar2 == 0) goto code_r0x820f0190;
		        iVar1 = **(int **)(param3 + 0x1c);
		        if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar1 = import::env::invoke_ii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar1);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x820eff3a;
		code_r0x820f00cc:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x820f00f2;
		        }
		code_r0x820eff3a:
		        DAT_ram_009d3e38 = 0;
		        iVar1 = import::env::invoke_iii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar4,iVar1);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x820f00cc;
		      } while (iVar1 == 0);
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iiiii
		                        (s___Scripting__UnityEngine__Raycas_ram_00004083 + 0xd,param2,uVar3,5,0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x820f00f2;
		      }
		    } while (iVar2 == 0);
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0xe1,param2,uVar3,5,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x820f00f2;
		    }
		  } while (iVar2 != 0);
		  iVar1 = **(int **)(param3 + 0x1c);
		  if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_ii(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar1);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x820f009c;
		  }
		  if (iVar4 == 0) {
		    DAT_ram_009d3e38 = 0;
		    return 0;
		  }
		  DAT_ram_009d3e38 = 0;
		  iVar2 = import::env::invoke_iii
		                    (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar4,iVar1);
		  if (DAT_ram_009d3e38 != 1) {
		    if (iVar2 != 0) {
		      DAT_ram_009d3e38 = 0;
		      return iVar2;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar4,iVar1);
		    if (DAT_ram_009d3e38 != 1) {
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		code_r0x820f009c:
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x820f00f2:
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
		      if (iVar4 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x820f0190:
		      DAT_ram_009d3e38 = 0;
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      uVar3 = I2_Loc_LocalizationManager__GetSourceContaining(param2,0);
		      iVar1 = **(int **)(param3 + 0x1c);
		      if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		        iVar1 = func_ii_1079(iVar1);
		      }
		      uVar3 = func_ii_1082(uVar3,iVar1);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar1 = UnityEngine_Component__GetComponent_object_(uVar3,0);
		      if (iVar1 == 0) {
		        uVar3 = I2_Loc_RegisterGlobalParameters___ctor(0);
		        uVar3 = UnityEngine_UIElements_ResolvedStyleAccessPropertyBag__AddProperty___Il2CppFullySharedGenericType_
		                          (uVar3,param2,*(undefined4 *)(*(int *)(param3 + 0x1c) + 4));
		      }
		      return uVar3;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Raycas_ram_00004083 + 0xe,&local_30);
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
		*/


		/* --- GHIDRA: .cctor ---
		void I2_Loc_LocalizationManager___cctor(int param1,int param2,int param3,undefined4 param4)
		
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
		    if (cVar1 == '\x02') {
		      *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Contex_ram_0000360b + 0xf;
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
		  else if (cVar1 == '\x03') {
		    *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Contex_ram_0000360b + 0xe;
		  }
		  else {
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  *(char **)(param1 + 0x1c) = s___Scripting__UnityEngine__Contex_ram_0000360b + 0x10;
		  return;
		}
		*/

}
