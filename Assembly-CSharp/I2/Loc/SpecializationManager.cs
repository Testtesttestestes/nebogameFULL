using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001355 RID: 4949
	[Token(Token = "0x2001355")]
	public class SpecializationManager : BaseSpecializationManager
	{
		// Token: 0x06007584 RID: 30084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007584")]
		[Address(RVA = "0xBF14", Offset = "0xBF14", VA = "0xBF14")]
		private SpecializationManager()
		{
		/* --- GHIDRA: .cctor ---
		void I2_Loc_SpecializationManager___cctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5972b == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    DAT_ram_00a5972b = '\x01';
		  }
		  if (DAT_ram_00a5972c == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5972c = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 8);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if ((iVar1 != 0) && (iVar1 = func_ii_4769(*(undefined4 *)(param1 + 0xc),0), iVar1 == 0)) {
		    if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Application_TypeInfo);
		    }
		    iVar1 = func_ii_3441(0);
		    if (iVar1 != 0) {
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 8),0);
		      UnityEngine_GameObject__FindGameObjectWithTag(uVar2,*(undefined4 *)(param1 + 0xc),param2,1,0);
		    }
		  }
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		int I2_Loc_SpecializationManager___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a59725 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SpecializationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3154);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18958);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19094);
		    DAT_ram_00a59725 = '\x01';
		  }
		  iVar1 = System_Xml_XmlTextEncoder__StartAttribute(param1,StringLiteral_18958,4,0);
		  if (-1 < iVar1) {
		    iVar2 = func_ii_4769(param2,0);
		    if (iVar2 != 0) {
		      if (*(int *)(I2_Loc_SpecializationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_SpecializationManager_TypeInfo);
		      }
		      iVar2 = *(int *)**(undefined4 **)(I2_Loc_SpecializationManager_TypeInfo + 0x5c);
		      param2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		                         ((int *)**(undefined4 **)(I2_Loc_SpecializationManager_TypeInfo + 0x5c),
		                          *(undefined4 *)(iVar2 + 0xec));
		    }
		    iVar2 = func_ii_4769(param2,0);
		    while( true ) {
		      if ((iVar2 != 0) ||
		         (iVar2 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                            (param2,StringLiteral_3154,0), iVar2 == 0)) {
		        uVar4 = System_Data_DataSet__ReadXmlSchema(param1,0,iVar1,0);
		        return uVar4;
		      }
		      iVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                        (StringLiteral_18958,param2,StringLiteral_19094,0);
		      iVar3 = System_Xml_XmlTextEncoder__StartAttribute(param1,iVar2,4,0);
		      if (-1 < iVar3) break;
		      if (*(int *)(I2_Loc_SpecializationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_SpecializationManager_TypeInfo);
		      }
		      iVar2 = *(int *)**(undefined4 **)(I2_Loc_SpecializationManager_TypeInfo + 0x5c);
		      param2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xf0) * 4))
		                         ((int *)**(undefined4 **)(I2_Loc_SpecializationManager_TypeInfo + 0x5c),
		                          param2,*(undefined4 *)(iVar2 + 0xf4));
		      iVar2 = func_ii_4769(param2,0);
		    }
		    iVar3 = *(int *)(iVar2 + 8) + iVar3;
		    iVar1 = func_ii_13789(param1,StringLiteral_18958,iVar3,4,0);
		    if (iVar1 < 0) {
		      iVar1 = *(int *)(param1 + 8);
		    }
		    param1 = System_Data_DataSet__ReadXmlSchema(param1,iVar3,iVar1 - iVar3,0);
		  }
		  return param1;
		}
		*/

		}

		// Token: 0x06007585 RID: 30085 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007585")]
		[Address(RVA = "0xBF15", Offset = "0xBF15", VA = "0xBF15")]
		public static string GetSpecializedText(string text, [Optional] string specialization)
		{
		/* --- GHIDRA: GetSpecializedText ---
		undefined4
		I2_Loc_SpecializationManager__GetSpecializedText
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a59726 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_SpecializationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3154);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18958);
		    DAT_ram_00a59726 = '\x01';
		  }
		  iVar1 = func_ii_4769(param3,0);
		  param1_01 = StringLiteral_3154;
		  if (iVar1 == 0) {
		    param1_01 = param3;
		  }
		  if (((param1 != 0) && (iVar1 = func_ii_7903(param1,StringLiteral_18958,0), iVar1 != 0)) ||
		     (iVar1 = System_Collections_CollectionBase___ctor(param1_01,StringLiteral_3154,0), iVar1 == 0))
		  {
		    if (*(int *)(I2_Loc_SpecializationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_SpecializationManager_TypeInfo);
		    }
		    param1_00 = I2_Loc_SpecializationManager__SetSpecializedText(param1,0,param2);
		    func_ii_2946(param1_00,param1_01,param2,
		                 Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		    param2 = I2_Loc_SpecializationManager__SetSpecializedText(param1_00,param2);
		  }
		  return param2;
		}
		*/

			return null;
		}

		// Token: 0x06007586 RID: 30086 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007586")]
		[Address(RVA = "0xBF16", Offset = "0xBF16", VA = "0xBF16")]
		public static string SetSpecializedText(string text, string newText, string specialization)
		{
		/* --- GHIDRA: SetSpecializedText ---
		undefined4 I2_Loc_SpecializationManager__SetSpecializedText(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int local_28;
		  undefined8 *local_24;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 uStack_14;
		  undefined4 local_10;
		  undefined4 uStack_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59727 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__TryGetValue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__string__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__string__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__string__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string__get_Value__);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3154);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18958);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19094);
		    DAT_ram_00a59727 = '\x01';
		  }
		  local_4 = 0;
		  local_10 = 0;
		  uStack_c = 0;
		  local_18 = 0;
		  uStack_14 = 0;
		  local_20 = 0;
		  iVar3 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (param1,StringLiteral_3154,&local_4,
		                     Method_System_Collections_Generic_Dictionary_string__string__TryGetValue__);
		  if (iVar3 == 0) {
		    local_4 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  }
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_20,param1,
		             Method_System_Collections_Generic_Dictionary_string__string__GetEnumerator__);
		  local_28 = 0;
		  local_24 = &local_20;
		  uVar5 = local_4;
		  do {
		    do {
		      do {
		        local_4 = uVar5;
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x158,&local_20,
		                           Method_System_Collections_Generic_Dictionary_Enumerator_string__string__MoveNext__
		                          );
		        param1_00 = local_10;
		        uVar2 = uStack_14;
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81053d32;
		        }
		        if (iVar4 == 0) {
		          iVar4 = 5;
		          iVar3 = local_28;
		          goto code_r0x81053d7f;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar4 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                          (uStack_14,StringLiteral_3154,0);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81053d32;
		        }
		        uVar5 = local_4;
		      } while (iVar4 == 0);
		      DAT_ram_009d3e38 = 0;
		      iVar4 = func_ii_4769(param1_00,0);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81053d32;
		      }
		      uVar5 = local_4;
		    } while (iVar4 != 0);
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1b1,string___TypeInfo,5);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81053d32;
		    }
		    *(undefined4 *)(iVar4 + 0x10) = local_4;
		    uVar5 = StringLiteral_18958;
		    *(undefined4 *)(iVar4 + 0x18) = uVar2;
		    *(undefined4 *)(iVar4 + 0x14) = uVar5;
		    uVar5 = StringLiteral_19094;
		    *(undefined4 *)(iVar4 + 0x20) = param1_00;
		    *(undefined4 *)(iVar4 + 0x1c) = uVar5;
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x236,iVar4,0)
		    ;
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar3 != 1);
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81053d32:
		  iVar3 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar4) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar3 = *piVar6;
		    iVar4 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_28 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x81053d7f:
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 0) {
		        if ((iVar4 == 0) ||
		           ((((uVar5 = 0, iVar4 != 1 && (iVar4 != 2)) && (iVar4 != 3)) &&
		            ((iVar4 != 4 && (iVar4 == 5)))))) {
		          uVar5 = local_4;
		        }
		        return uVar5;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x355,&local_28);
		  iVar3 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar3 != 1) {
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
		*/

		/* --- GHIDRA: SetSpecializedText ---
		undefined4 I2_Loc_SpecializationManager__SetSpecializedText(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int local_28;
		  undefined8 *local_24;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 uStack_14;
		  undefined4 local_10;
		  undefined4 uStack_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59727 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__TryGetValue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__string__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__string__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__string__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string__get_Value__);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3154);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18958);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19094);
		    DAT_ram_00a59727 = '\x01';
		  }
		  local_4 = 0;
		  local_10 = 0;
		  uStack_c = 0;
		  local_18 = 0;
		  uStack_14 = 0;
		  local_20 = 0;
		  iVar3 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (param1,StringLiteral_3154,&local_4,
		                     Method_System_Collections_Generic_Dictionary_string__string__TryGetValue__);
		  if (iVar3 == 0) {
		    local_4 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  }
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_20,param1,
		             Method_System_Collections_Generic_Dictionary_string__string__GetEnumerator__);
		  local_28 = 0;
		  local_24 = &local_20;
		  uVar5 = local_4;
		  do {
		    do {
		      do {
		        local_4 = uVar5;
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x158,&local_20,
		                           Method_System_Collections_Generic_Dictionary_Enumerator_string__string__MoveNext__
		                          );
		        param1_00 = local_10;
		        uVar2 = uStack_14;
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81053d32;
		        }
		        if (iVar4 == 0) {
		          iVar4 = 5;
		          iVar3 = local_28;
		          goto code_r0x81053d7f;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar4 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                          (uStack_14,StringLiteral_3154,0);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81053d32;
		        }
		        uVar5 = local_4;
		      } while (iVar4 == 0);
		      DAT_ram_009d3e38 = 0;
		      iVar4 = func_ii_4769(param1_00,0);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81053d32;
		      }
		      uVar5 = local_4;
		    } while (iVar4 != 0);
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1b1,string___TypeInfo,5);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81053d32;
		    }
		    *(undefined4 *)(iVar4 + 0x10) = local_4;
		    uVar5 = StringLiteral_18958;
		    *(undefined4 *)(iVar4 + 0x18) = uVar2;
		    *(undefined4 *)(iVar4 + 0x14) = uVar5;
		    uVar5 = StringLiteral_19094;
		    *(undefined4 *)(iVar4 + 0x20) = param1_00;
		    *(undefined4 *)(iVar4 + 0x1c) = uVar5;
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x236,iVar4,0)
		    ;
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar3 != 1);
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81053d32:
		  iVar3 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar4) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar3 = *piVar6;
		    iVar4 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_28 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x81053d7f:
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 0) {
		        if ((iVar4 == 0) ||
		           ((((uVar5 = 0, iVar4 != 1 && (iVar4 != 2)) && (iVar4 != 3)) &&
		            ((iVar4 != 4 && (iVar4 == 5)))))) {
		          uVar5 = local_4;
		        }
		        return uVar5;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x355,&local_28);
		  iVar3 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar3 != 1) {
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
		*/

			return null;
		}

		// Token: 0x06007587 RID: 30087 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007587")]
		[Address(RVA = "0xBF17", Offset = "0xBF17", VA = "0xBF17")]
		public static string SetSpecializedText(Dictionary<string, string> specializations)
		{
			return null;
		}

		// Token: 0x06007588 RID: 30088 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007588")]
		[Address(RVA = "0xBF18", Offset = "0xBF18", VA = "0xBF18")]
		public static Dictionary<string, string> GetSpecializations(string text, [Optional] Dictionary<string, string> buffer)
		{
		/* --- GHIDRA: GetSpecializations ---
		void I2_Loc_SpecializationManager__GetSpecializations(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a59729 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Contains__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3154);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18958);
		    DAT_ram_00a59729 = '\x01';
		  }
		  if (param1 != 0) {
		    if (param2 == 0) {
		      param2 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		      GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		                (param2,Method_System_Collections_Generic_List_string___ctor__);
		    }
		    iVar2 = func_ii_4685(param2,StringLiteral_3154,
		                         Method_System_Collections_Generic_List_string__Contains__);
		    uVar3 = StringLiteral_3154;
		    iVar1 = Method_System_Collections_Generic_List_string__Add__;
		    if (iVar2 == 0) {
		      *(int *)(param2 + 0x10) = *(int *)(param2 + 0x10) + 1;
		      uVar5 = *(uint *)(param2 + 0xc);
		      if (uVar5 < *(uint *)(*(int *)(param2 + 8) + 0xc)) {
		        *(uint *)(param2 + 0xc) = uVar5 + 1;
		        *(undefined4 *)(*(int *)(param2 + 8) + uVar5 * 4 + 0x10) = uVar3;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param2,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      }
		    }
		    if (0 < *(int *)(param1 + 8)) {
		      iVar1 = 0;
		      do {
		        iVar1 = func_ii_13789(param1,StringLiteral_18958,iVar1,4,0);
		        if (iVar1 < 0) {
		          return;
		        }
		        iVar1 = *(int *)(StringLiteral_18958 + 8) + iVar1;
		        iVar2 = System_String__Contains(param1,0x5d,iVar1,0);
		        if (iVar2 < 0) {
		          return;
		        }
		        uVar3 = System_Data_DataSet__ReadXmlSchema(param1,iVar1,iVar2 - iVar1,0);
		        iVar4 = func_ii_4685(param2,uVar3,Method_System_Collections_Generic_List_string__Contains__)
		        ;
		        iVar2 = Method_System_Collections_Generic_List_string__Add__;
		        if (iVar4 == 0) {
		          *(int *)(param2 + 0x10) = *(int *)(param2 + 0x10) + 1;
		          uVar5 = *(uint *)(param2 + 0xc);
		          if (uVar5 < *(uint *)(*(int *)(param2 + 8) + 0xc)) {
		            *(uint *)(param2 + 0xc) = uVar5 + 1;
		            *(undefined4 *)(*(int *)(param2 + 8) + uVar5 * 4 + 0x10) = uVar3;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (param2,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38))
		            ;
		          }
		        }
		      } while (iVar1 < *(int *)(param1 + 8));
		    }
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06007589 RID: 30089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007589")]
		[Address(RVA = "0xBF19", Offset = "0xBF19", VA = "0xBF19")]
		public static void AppendSpecializations(string text, [Optional] List<string> list)
		{
		/* --- GHIDRA: AppendSpecializations ---
		void I2_Loc_SpecializationManager__AppendSpecializations(undefined4 param1)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a5972a == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SpecializationManager_TypeInfo);
		    DAT_ram_00a5972a = '\x01';
		  }
		  piVar1 = (int *)unnamed_function_1417(I2_Loc_SpecializationManager_TypeInfo);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe0) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xe4));
		  **(undefined4 **)(I2_Loc_SpecializationManager_TypeInfo + 0x5c) = piVar1;
		  return;
		}
		*/

		}

		// Token: 0x04003D5F RID: 15711
		[Token(Token = "0x4003D5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SpecializationManager Singleton;
	}
}
