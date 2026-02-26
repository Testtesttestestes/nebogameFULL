using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Core
{
	// Token: 0x02000E59 RID: 3673
	[Token(Token = "0x2000E59")]
	public static class GameLocalization
	{
		// Token: 0x060059E4 RID: 23012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059E4")]
		[Address(RVA = "0xA708", Offset = "0xA708", VA = "0xA708")]
		public static void SetLocalizationLanguage(CultureInfo culture)
		{
		/* --- GHIDRA: SetLocalizationLanguage ---
		uint Core_GameLocalization__SetLocalizationLanguage(int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  uint uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6054e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__IndexOf__);
		    DAT_ram_00a6054e = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param1_00 = **(undefined4 **)(Core_GameLocalization_TypeInfo + 0x5c);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x118) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x11c));
		  uVar1 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                    (param1_00,param2_00,Method_System_Collections_Generic_List_string__IndexOf__);
		  return (uVar1 ^ 0xffffffff) >> 0x1f;
		}
		*/

		}

		// Token: 0x060059E5 RID: 23013 RVA: 0x0000FF00 File Offset: 0x0000E100
		[Token(Token = "0x60059E5")]
		[Address(RVA = "0xA709", Offset = "0xA709", VA = "0xA709")]
		public static bool IsCyrillic(CultureInfo culture)
		{
		/* --- GHIDRA: IsCyrillic ---
		void Core_GameLocalization__IsCyrillic(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  int param2_00;
		  int iVar5;
		  int *piVar6;
		  uint *puVar7;
		  int iVar8;
		  undefined4 param3;
		  int *piVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a6054f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_UIStringDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__IndexOf__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UIStringDic__GetEnumerator__);
		    DAT_ram_00a6054f = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  uVar2 = I2_Loc_LocalizationManager__GetLanguageFromCode(1,0);
		  uVar3 = I2_Loc_LocalizationManager__GetWebServiceURL(0);
		  uVar2 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                    (uVar2,uVar3,Method_System_Collections_Generic_List_string__IndexOf__);
		  uVar3 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x1c),0,
		                     Method_System_Collections_Generic_List_LanguageSourceData__get_Item__);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (param1,
		                              Method_Google_Protobuf_Collections_RepeatedField_UIStringDic__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar6 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar4 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x81ca3b27;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81ca3b6f:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81ca3d27;
		    }
		code_r0x81ca3b27:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81ca3b6f;
		    if (iVar8 == 0) {
		      iVar8 = 0;
		      goto code_r0x81ca3d70;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_UIStringDic__TypeInfo == *piVar9) {
		          puVar4 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x81ca3c12;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_UIStringDic__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81ca3d0b:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81ca3d27;
		    }
		code_r0x81ca3c12:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81ca3d0b;
		    param3 = *(undefined4 *)(iVar8 + 0xc);
		    DAT_ram_009d3e38 = 0;
		    param2_00 = import::env::invoke_iiiii
		                          (s___Scripting__UnityEngine__Contex_ram_0000360b + 0x11,uVar3,param3,0,0);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81ca3d27;
		    }
		    if (param2_00 == 0) {
		      DAT_ram_009d3e38 = 0;
		      param2_00 = import::env::invoke_iiii
		                            (s___Scripting__UnityEngine__Contex_ram_0000360b + 0x12,uVar3,param3,0);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81ca3d27;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiiii
		              (s___Scripting__UnityEngine__Contex_ram_0000360b + 0x13,param2_00,uVar2,
		               *(undefined4 *)(iVar8 + 0x10),0,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar8 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81ca3d27:
		  iVar8 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar8 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar8;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x81ca3d70:
		      piVar6 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar5 = *local_4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar7 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81ca3de8;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar7 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81ca3de8:
		        (**(code **)((ulonglong)*puVar7 * 4))(piVar6,puVar7[1]);
		      }
		      if (iVar8 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Contex_ram_0000360b + 0x14,&local_c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
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

			return default(bool);
		}

		// Token: 0x060059E6 RID: 23014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059E6")]
		[Address(RVA = "0xA70A", Offset = "0xA70A", VA = "0xA70A")]
		public static void UpdateLocalization(RepeatedField<UIStringDic> newLocalization)
		{
		/* --- GHIDRA: UpdateLocalization ---
		uint Core_GameLocalization__UpdateLocalization
		               (undefined4 param1,undefined4 *param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6,undefined4 param7,undefined4 param8,
		               undefined4 param9)
		
		{
		  undefined4 param1_00;
		  uint uVar1;
		  
		  if (DAT_ram_00a60551 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a60551 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  param1_00 = I2_Loc_LocalizationManager__remove_OnLocalizeEvent
		                        (param1,param3,param4,param5,param6,param7,param8,1,0);
		  *param2 = param1_00;
		  uVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param1_00,0)
		  ;
		  return uVar1 ^ 1;
		}
		*/

		}

		// Token: 0x060059E7 RID: 23015 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60059E7")]
		[Address(RVA = "0x1D55", Offset = "0x1D55", VA = "0x1D55")]
		public static string GetValue(string key, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
		/* --- GHIDRA: GetValue ---
		undefined4 Core_GameLocalization__GetValue(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x34);
		  param2_00 = 0;
		  if (DAT_ram_00a5acf5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__);
		    DAT_ram_00a5acf5 = '\x01';
		  }
		  if (0 < *(int *)(param1_00 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param1_00,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == 0x5c) {
		        return *(undefined4 *)(iVar1 + 0x10);
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param1_00 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x060059E8 RID: 23016 RVA: 0x0000FF18 File Offset: 0x0000E118
		[Token(Token = "0x60059E8")]
		[Address(RVA = "0xA70B", Offset = "0xA70B", VA = "0xA70B")]
		public static bool TryGetValue(string key, out string value, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
		/* --- GHIDRA: TryGetValue ---
		void Core_GameLocalization__TryGetValue(undefined4 param1)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param1_00;
		  uint uVar3;
		  uint uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a60553 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26510);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25010);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20032);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24949);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27736);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27691);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24471);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27932);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20489);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27877);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26528);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24978);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28203);
		    DAT_ram_00a60553 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_string___ctor__);
		  uVar2 = StringLiteral_26528;
		  iVar1 = Method_System_Collections_Generic_List_string__Add__;
		  iVar5 = *(int *)(param1_00 + 0x10) + 1;
		  *(int *)(param1_00 + 0x10) = iVar5;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    uVar4 = uVar3 + 1;
		    *(uint *)(param1_00 + 0xc) = uVar4;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    uVar4 = *(uint *)(param1_00 + 0xc);
		    iVar5 = *(int *)(param1_00 + 0x10);
		  }
		  uVar2 = StringLiteral_20489;
		  iVar1 = Method_System_Collections_Generic_List_string__Add__;
		  iVar5 = iVar5 + 1;
		  *(int *)(param1_00 + 0x10) = iVar5;
		  if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    uVar3 = uVar4 + 1;
		    *(uint *)(param1_00 + 0xc) = uVar3;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    uVar3 = *(uint *)(param1_00 + 0xc);
		    iVar5 = *(int *)(param1_00 + 0x10);
		  }
		  uVar2 = StringLiteral_24978;
		  iVar1 = Method_System_Collections_Generic_List_string__Add__;
		  iVar5 = iVar5 + 1;
		  *(int *)(param1_00 + 0x10) = iVar5;
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    uVar4 = uVar3 + 1;
		    *(uint *)(param1_00 + 0xc) = uVar4;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    uVar4 = *(uint *)(param1_00 + 0xc);
		    iVar5 = *(int *)(param1_00 + 0x10);
		  }
		  uVar2 = StringLiteral_24471;
		  iVar1 = Method_System_Collections_Generic_List_string__Add__;
		  iVar5 = iVar5 + 1;
		  *(int *)(param1_00 + 0x10) = iVar5;
		  if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    uVar3 = uVar4 + 1;
		    *(uint *)(param1_00 + 0xc) = uVar3;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    uVar3 = *(uint *)(param1_00 + 0xc);
		    iVar5 = *(int *)(param1_00 + 0x10);
		  }
		  uVar2 = StringLiteral_20032;
		  iVar1 = Method_System_Collections_Generic_List_string__Add__;
		  iVar5 = iVar5 + 1;
		  *(int *)(param1_00 + 0x10) = iVar5;
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    uVar4 = uVar3 + 1;
		    *(uint *)(param1_00 + 0xc) = uVar4;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    uVar4 = *(uint *)(param1_00 + 0xc);
		    iVar5 = *(int *)(param1_00 + 0x10);
		  }
		  uVar2 = StringLiteral_25010;
		  iVar1 = Method_System_Collections_Generic_List_string__Add__;
		  iVar5 = iVar5 + 1;
		  *(int *)(param1_00 + 0x10) = iVar5;
		  if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    uVar3 = uVar4 + 1;
		    *(uint *)(param1_00 + 0xc) = uVar3;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    uVar3 = *(uint *)(param1_00 + 0xc);
		    iVar5 = *(int *)(param1_00 + 0x10);
		  }
		  uVar2 = StringLiteral_28203;
		  iVar1 = Method_System_Collections_Generic_List_string__Add__;
		  iVar5 = iVar5 + 1;
		  *(int *)(param1_00 + 0x10) = iVar5;
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    uVar4 = uVar3 + 1;
		    *(uint *)(param1_00 + 0xc) = uVar4;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    uVar4 = *(uint *)(param1_00 + 0xc);
		    iVar5 = *(int *)(param1_00 + 0x10);
		  }
		  uVar2 = StringLiteral_27691;
		  iVar1 = Method_System_Collections_Generic_List_string__Add__;
		  iVar5 = iVar5 + 1;
		  *(int *)(param1_00 + 0x10) = iVar5;
		  if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    uVar3 = uVar4 + 1;
		    *(uint *)(param1_00 + 0xc) = uVar3;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    uVar3 = *(uint *)(param1_00 + 0xc);
		    iVar5 = *(int *)(param1_00 + 0x10);
		  }
		  uVar2 = StringLiteral_27877;
		  iVar1 = Method_System_Collections_Generic_List_string__Add__;
		  iVar5 = iVar5 + 1;
		  *(int *)(param1_00 + 0x10) = iVar5;
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    uVar4 = uVar3 + 1;
		    *(uint *)(param1_00 + 0xc) = uVar4;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    uVar4 = *(uint *)(param1_00 + 0xc);
		    iVar5 = *(int *)(param1_00 + 0x10);
		  }
		  uVar2 = StringLiteral_26510;
		  iVar1 = Method_System_Collections_Generic_List_string__Add__;
		  iVar5 = iVar5 + 1;
		  *(int *)(param1_00 + 0x10) = iVar5;
		  if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    uVar3 = uVar4 + 1;
		    *(uint *)(param1_00 + 0xc) = uVar3;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    uVar3 = *(uint *)(param1_00 + 0xc);
		    iVar5 = *(int *)(param1_00 + 0x10);
		  }
		  uVar2 = StringLiteral_27736;
		  iVar1 = Method_System_Collections_Generic_List_string__Add__;
		  iVar5 = iVar5 + 1;
		  *(int *)(param1_00 + 0x10) = iVar5;
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    uVar4 = uVar3 + 1;
		    *(uint *)(param1_00 + 0xc) = uVar4;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    uVar4 = *(uint *)(param1_00 + 0xc);
		    iVar5 = *(int *)(param1_00 + 0x10);
		  }
		  uVar2 = StringLiteral_24949;
		  iVar1 = Method_System_Collections_Generic_List_string__Add__;
		  iVar5 = iVar5 + 1;
		  *(int *)(param1_00 + 0x10) = iVar5;
		  if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    uVar3 = uVar4 + 1;
		    *(uint *)(param1_00 + 0xc) = uVar3;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    uVar3 = *(uint *)(param1_00 + 0xc);
		    iVar5 = *(int *)(param1_00 + 0x10);
		  }
		  uVar2 = StringLiteral_27932;
		  iVar1 = Method_System_Collections_Generic_List_string__Add__;
		  *(int *)(param1_00 + 0x10) = iVar5 + 1;
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  **(int **)(Core_GameLocalization_TypeInfo + 0x5c) = param1_00;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060059E9 RID: 23017 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60059E9")]
		[Address(RVA = "0x1B5A", Offset = "0x1B5A", VA = "0x1B5A")]
		public static string GetTranslation(string key, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
		/* --- GHIDRA: GetTranslation ---
		undefined4
		Core_GameLocalization__GetTranslation(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 uVar1;
		  undefined4 param2_00;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 uStack_c;
		  undefined4 local_8;
		  undefined4 uStack_4;
		  
		  if (DAT_ram_00a5acda == '\0') {
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
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    DAT_ram_00a5acda = '\x01';
		  }
		  local_8 = 0;
		  uStack_4 = 0;
		  local_10 = 0;
		  uStack_c = 0;
		  local_18 = 0;
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_18,param2,
		             Method_System_Collections_Generic_Dictionary_string__string__GetEnumerator__);
		  local_20 = 0;
		  local_1c = &local_18;
		  while( true ) {
		    param2_00 = param1;
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x158,&local_18,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_string__string__MoveNext__
		                      );
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812cd280;
		    }
		    iVar4 = local_20;
		    if (iVar2 == 0) goto code_r0x812cd2c9;
		    DAT_ram_009d3e38 = 0;
		    uVar1 = CONCAT44(local_8,uStack_c);
		    iVar2 = import::env::invoke_iii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1b1,
		                       System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) break;
		    *(undefined8 *)(iVar2 + 0x10) = uVar1;
		    DAT_ram_009d3e38 = 0;
		    param1 = import::env::invoke_iiii
		                       (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xf2,param2_00,iVar2,
		                        &local_20);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x812cd280:
		      iVar4 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar4 == iVar2) {
		        piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		        iVar4 = *piVar3;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar4;
		        import::env::invoke_v(0x123);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		code_r0x812cd2c9:
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 == 0) {
		            return param2_00;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        param1_00 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x8c,&local_20);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
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
		  }
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x812cd280;
		}
		*/

			return null;
		}

		// Token: 0x0400309B RID: 12443
		[Token(Token = "0x400309B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<string> _cyrillicLanguageCodes;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: .cctor ---
		undefined4
		Core_GameLocalization___cctor
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  local_8 = param3;
		  local_4 = param2;
		  if (DAT_ram_00a60554 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    DAT_ram_00a60554 = '\x01';
		  }
		  uVar1 = func_ii_4443(&local_4,0);
		  param3_00 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_8,0);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar1,StringLiteral_19176,param3_00,0);
		  return uVar1;
		}
		*/

}
