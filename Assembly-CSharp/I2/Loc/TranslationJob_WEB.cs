using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001366 RID: 4966
	[Token(Token = "0x2001366")]
	public class TranslationJob_WEB : TranslationJob_WWW
	{
		// Token: 0x060075D9 RID: 30169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D9")]
		[Address(RVA = "0xBF62", Offset = "0xBF62", VA = "0xBF62")]
		public TranslationJob_WEB(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_TranslationJob_WEB___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param3;
		  int *piVar4;
		  int param2_00;
		  uint uVar5;
		  int iVar6;
		  undefined4 *puVar7;
		  undefined4 uVar8;
		  undefined8 local_78;
		  undefined8 local_70;
		  int local_68;
		  undefined8 *local_64;
		  undefined8 local_60;
		  undefined8 local_58;
		  undefined8 local_50;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined4 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a6046e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Comparison_KeyValuePair_string__string___TypeInfo);
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
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__TranslationQuery__get_Value__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_KeyValuePair_string__string___Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_KeyValuePair_string__string___Sort__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_KeyValuePair_string__string____ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_KeyValuePair_string__string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_TranslationJob_WEB___c__FindAllQueries_b__8_0__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_TranslationJob_WEB___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2003);
		    DAT_ram_00a6046e = '\x01';
		  }
		  uVar2 = unnamed_function_1417
		                    (System_Collections_Generic_List_KeyValuePair_string__string___TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,Method_System_Collections_Generic_List_KeyValuePair_string__string____ctor__);
		  *(undefined4 *)(param1 + 0x28) = uVar2;
		  System_Collections_Generic_Dictionary_uint__WorldSpaceData___FindEntry
		            (&local_60,*(undefined4 *)(param1 + 0x10),
		             Method_System_Collections_Generic_Dictionary_string__TranslationQuery__GetEnumerator__)
		  ;
		  local_8 = local_38;
		  local_10 = local_40;
		  local_18 = local_48;
		  local_20 = local_50;
		  local_28 = local_58;
		  local_30 = local_60;
		  local_68 = 0;
		  local_64 = &local_30;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x362,&local_30,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_string__TranslationQuery__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) break;
		    if (iVar3 == 0) {
		      iVar3 = 6;
		      iVar6 = local_68;
		      goto code_r0x81c8e46f;
		    }
		    iVar3 = 0;
		    uVar8 = (undefined4)local_18;
		    uVar2 = (undefined4)local_20;
		    iVar6 = local_18._4_4_;
		    if (0 < *(int *)(local_18._4_4_ + 0xc)) {
		      do {
		        param2_00 = *(int *)(param1 + 0x28);
		        DAT_ram_009d3e38 = 0;
		        param3 = import::env::invoke_iiiii
		                           (s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x26e,uVar8,
		                            StringLiteral_2003,*(undefined4 *)(iVar6 + iVar3 * 4 + 0x10),0);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81c8e422;
		        }
		        local_70 = 0;
		        DAT_ram_009d3e38 = 0;
		        System_Text_Formatting_StringView__get_IsEmpty
		                  (&local_70,uVar2,param3,
		                   Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		        iVar1 = Method_System_Collections_Generic_List_KeyValuePair_string__string___Add__;
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81c8e402:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81c8e422;
		        }
		        *(int *)(param2_00 + 0x10) = *(int *)(param2_00 + 0x10) + 1;
		        uVar5 = *(uint *)(param2_00 + 0xc);
		        if (uVar5 < *(uint *)(*(int *)(param2_00 + 8) + 0xc)) {
		          *(uint *)(param2_00 + 0xc) = uVar5 + 1;
		          *(undefined8 *)(*(int *)(param2_00 + 8) + uVar5 * 8 + 0x10) = local_70;
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          local_78 = local_70;
		          local_60 = local_70;
		          import::env::invoke_viii
		                    (s___Scripting__UnityEngine__Player_ram_000035bf + 0x1d,param2_00,&local_78,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		          if (DAT_ram_009d3e38 == 1) goto code_r0x81c8e402;
		        }
		        iVar3 = iVar3 + 1;
		      } while (iVar3 < *(int *)(iVar6 + 0xc));
		    }
		  }
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81c8e422:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar6 = *piVar4;
		    iVar3 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_68 = iVar6;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x81c8e46f:
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 0) {
		        if ((iVar3 == 0) ||
		           ((((iVar3 != 1 && (iVar3 != 2)) && (iVar3 != 3)) &&
		            (((iVar3 != 4 && (iVar3 != 5)) && (iVar3 == 6)))))) {
		          uVar2 = *(undefined4 *)(param1 + 0x28);
		          if (*(int *)(I2_Loc_TranslationJob_WEB___c_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_TranslationJob_WEB___c_TypeInfo);
		          }
		          puVar7 = *(undefined4 **)(I2_Loc_TranslationJob_WEB___c_TypeInfo + 0x5c);
		          iVar6 = puVar7[1];
		          if (iVar6 == 0) {
		            if (*(int *)(I2_Loc_TranslationJob_WEB___c_TypeInfo + 0x74) == 0) {
		              func_ii_306000(I2_Loc_TranslationJob_WEB___c_TypeInfo);
		              puVar7 = *(undefined4 **)(I2_Loc_TranslationJob_WEB___c_TypeInfo + 0x5c);
		            }
		            uVar8 = *puVar7;
		            iVar6 = unnamed_function_1417(System_Comparison_KeyValuePair_string__string___TypeInfo);
		            System_Collections_Generic_Comparer_KeyValuePair_object__object____get_Default
		                      (iVar6,uVar8,Method_I2_Loc_TranslationJob_WEB___c__FindAllQueries_b__8_0__,0);
		            *(int *)(*(int *)(I2_Loc_TranslationJob_WEB___c_TypeInfo + 0x5c) + 4) = iVar6;
		          }
		          System_Collections_Generic_List_KeyValuePair_object__object____Sort
		                    (uVar2,iVar6,
		                     Method_System_Collections_Generic_List_KeyValuePair_string__string___Sort__);
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Player_ram_000035bf + 0x1e,&local_68);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
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

		// Token: 0x060075DA RID: 30170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075DA")]
		[Address(RVA = "0xBF63", Offset = "0xBF63", VA = "0xBF63")]
		private void FindAllQueries()
		{
		/* --- GHIDRA: FindAllQueries ---
		void I2_Loc_TranslationJob_WEB__FindAllQueries(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  uint uVar6;
		  int param1_01;
		  undefined4 param2_00;
		  undefined4 param3;
		  undefined4 local_8;
		  int local_4;
		  
		  if (DAT_ram_00a6046f == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string__get_Value__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_KeyValuePair_string__string___RemoveRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_KeyValuePair_string__string___get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_KeyValuePair_string__string___get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28772);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24419);
		    DAT_ram_00a6046f = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 0x28) + 0xc) == 0) {
		    *(undefined4 *)(param1 + 8) = 1;
		  }
		  else {
		    uVar2 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (uVar2,Method_System_Collections_Generic_List_string___ctor__);
		    *(undefined4 *)(param1 + 0x24) = uVar2;
		    param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		    func_ii_2101(param1_00,0);
		    iVar4 = *(int *)(param1 + 0x28);
		    if (*(int *)(iVar4 + 0xc) < 1) {
		      iVar5 = 0;
		      iVar1 = 0;
		    }
		    else {
		      UnityEngine_UIElements_StyleMatchingContext__GetStyleSheetAt
		                (&local_8,iVar4,0,
		                 Method_System_Collections_Generic_List_KeyValuePair_string__string___get_Item__);
		      uVar2 = local_8;
		      UnityEngine_UIElements_StyleMatchingContext__GetStyleSheetAt
		                (&local_8,*(undefined4 *)(param1 + 0x28),0,
		                 Method_System_Collections_Generic_List_KeyValuePair_string__string___get_Item__);
		      iVar1 = local_4;
		      func_ii_2010(param1_00,uVar2,0);
		      iVar4 = Method_System_Collections_Generic_List_string__Add__;
		      iVar5 = *(int *)(param1 + 0x24);
		      *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		      uVar6 = *(uint *)(iVar5 + 0xc);
		      if (uVar6 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		        *(uint *)(iVar5 + 0xc) = uVar6 + 1;
		        *(undefined4 *)(*(int *)(iVar5 + 8) + uVar6 * 4 + 0x10) = uVar2;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (iVar5,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		      }
		      iVar5 = 0;
		      iVar4 = func_ii_4075(param1_00,0);
		      if (iVar4 < 0xc9) {
		        iVar5 = 1;
		        iVar4 = *(int *)(param1 + 0x28);
		        if (1 < *(int *)(iVar4 + 0xc)) {
		          do {
		            UnityEngine_UIElements_StyleMatchingContext__GetStyleSheetAt
		                      (&local_8,iVar4,iVar5,
		                       Method_System_Collections_Generic_List_KeyValuePair_string__string___get_Item__
		                      );
		            uVar2 = local_8;
		            UnityEngine_UIElements_StyleMatchingContext__GetStyleSheetAt
		                      (&local_8,*(undefined4 *)(param1 + 0x28),iVar5,
		                       Method_System_Collections_Generic_List_KeyValuePair_string__string___get_Item__
		                      );
		            iVar4 = local_4;
		            if ((iVar1 == 0) ||
		               (iVar3 = System_Collections_CollectionBase___ctor(local_4,iVar1,0), iVar3 != 0)) {
		              func_ii_2010(param1_00,StringLiteral_28772,0);
		              func_ii_2010(param1_00,uVar2,0);
		              iVar3 = Method_System_Collections_Generic_List_string__Add__;
		              param1_01 = *(int *)(param1 + 0x24);
		              *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		              uVar6 = *(uint *)(param1_01 + 0xc);
		              iVar1 = iVar4;
		              if (uVar6 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		                *(uint *)(param1_01 + 0xc) = uVar6 + 1;
		                *(undefined4 *)(*(int *)(param1_01 + 8) + uVar6 * 4 + 0x10) = uVar2;
		              }
		              else {
		                System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                          (param1_01,uVar2,
		                           *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		              }
		            }
		            iVar4 = func_ii_4075(param1_00,0);
		            if (200 < iVar4) break;
		            iVar5 = iVar5 + 1;
		            iVar4 = *(int *)(param1 + 0x28);
		          } while (iVar5 < *(int *)(iVar4 + 0xc));
		        }
		      }
		      iVar4 = *(int *)(param1 + 0x28);
		    }
		    System_Collections_Generic_List_RenderChain_VisualChangesProcessor_EntryProcessingInfo___RemoveAt
		              (iVar4,0,iVar5,
		               Method_System_Collections_Generic_List_KeyValuePair_string__string___RemoveRange__);
		    iVar4 = System_Net_WebConnection__ReadLine(iVar1,0x3a,0,0);
		    param2_00 = *(undefined4 *)(iVar4 + 0x10);
		    *(undefined4 *)(param1 + 0x20) = param2_00;
		    param3 = *(undefined4 *)(iVar4 + 0x14);
		    *(undefined4 *)(param1 + 0x1c) = param3;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                      (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		    if (*(int *)(System_Uri_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Uri_TypeInfo);
		    }
		    uVar2 = System_Uri__UnescapeDataString(uVar2,0);
		    uVar2 = func_ii_8529(StringLiteral_24419,param2_00,param3,uVar2,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		    uVar2 = UnityEngine_Networking_UnityWebRequest__get_timeout(uVar2,0);
		    *(undefined4 *)(param1 + 0xc) = uVar2;
		    I2_Loc_I2Utils__GetCaptureMatch(uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060075DB RID: 30171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075DB")]
		[Address(RVA = "0xBF64", Offset = "0xBF64", VA = "0xBF64")]
		private void ExecuteNextBatch()
		{
		/* --- GHIDRA: ExecuteNextBatch ---
		undefined4 I2_Loc_TranslationJob_WEB__ExecuteNextBatch(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param3;
		  
		  if (*(int *)(param1 + 0xc) != 0) {
		    iVar1 = UnityEngine_Networking_UnityWebRequest__get_isModifiable(*(int *)(param1 + 0xc),0);
		    if (iVar1 == 0) {
		      if (*(int *)(param1 + 0xc) != 0) goto code_r0x81c8e961;
		    }
		    else {
		      param2_00 = UnityEngine_Networking_DownloadHandler__Dispose
		                            (*(undefined4 *)(*(int *)(param1 + 0xc) + 0xc),0);
		      param3 = UnityEngine_Networking_UnityWebRequest__get_url(*(undefined4 *)(param1 + 0xc),0);
		      I2_Loc_TranslationJob_WEB__GetState(param1,param2_00,param3,param1);
		      UnityEngine_Networking_UnityWebRequest__Finalize(*(undefined4 *)(param1 + 0xc),0);
		      *(undefined4 *)(param1 + 0xc) = 0;
		    }
		  }
		  I2_Loc_TranslationJob_WEB__FindAllQueries(param1,param1);
		code_r0x81c8e961:
		  return *(undefined4 *)(param1 + 8);
		}
		*/

		}

		// Token: 0x060075DC RID: 30172 RVA: 0x00015498 File Offset: 0x00013698
		[Token(Token = "0x60075DC")]
		[Address(RVA = "0xBF65", Offset = "0xBF65", VA = "0xBF65", Slot = "5")]
		public override TranslationJob.eJobState GetState()
		{
		/* --- GHIDRA: GetState ---
		void I2_Loc_TranslationJob_WEB__GetState(int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a60470 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19656);
		    DAT_ram_00a60470 = '\x01';
		  }
		  iVar1 = func_ii_4769(param3,0);
		  if (iVar1 != 0) {
		    piVar2 = (int *)func_ii_5618(0);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x1f0) * 4))
		                      (piVar2,param2,0,*(undefined4 *)(param2 + 0xc),*(undefined4 *)(*piVar2 + 500))
		    ;
		    uVar3 = I2_Loc_TranslationJob_WEB__ProcessResult(param3,uVar3,StringLiteral_19656,param3);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		    iVar1 = func_ii_4769(param3,0);
		    if (iVar1 != 0) {
		      iVar1 = *(int *)(param1 + 0x14);
		      if (iVar1 == 0) {
		        return;
		      }
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x10),0,
		                 *(undefined4 *)(iVar1 + 0x14));
		      return;
		    }
		  }
		  *(undefined4 *)(param1 + 0x18) = param3;
		  *(undefined4 *)(param1 + 8) = 2;
		  return;
		}
		*/

			return TranslationJob.eJobState.Running;
		}

		// Token: 0x060075DD RID: 30173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075DD")]
		[Address(RVA = "0xBF66", Offset = "0xBF66", VA = "0xBF66")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		/* --- GHIDRA: ProcessResult ---
		undefined4
		I2_Loc_TranslationJob_WEB__ProcessResult
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  undefined4 *param2_00;
		  undefined4 uVar6;
		  int *piVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a60471 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_RegularExpressions_MatchEvaluator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_RegularExpressions_Regex_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_I2_Loc_TranslationJob_WEB___c__ParseTranslationResult_b__12_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_I2_Loc_TranslationJob_WEB___c__ParseTranslationResult_b__12_1__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_TranslationJob_WEB___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_47);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19009);
		    Mono_Security_ASN1__get_Item(&StringLiteral_982);
		    Mono_Security_ASN1__get_Item(&StringLiteral_735);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2169);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15186);
		    DAT_ram_00a60471 = '\x01';
		  }
		  DAT_ram_009d3e38 = 0;
		  iVar1 = import::env::invoke_iiiii
		                    (s___Scripting__UnityEngine__UIElem_ram_00003206 + 0x24,param2,
		                     StringLiteral_15186,4,0);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = *(int *)(StringLiteral_15186 + 8) + iVar1;
		    iVar2 = import::env::invoke_iiiiii
		                      (s___Scripting__UnityEngine__Player_ram_000035bf + 0x1f,param2,
		                       StringLiteral_982,iVar1,4,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iiiii
		                        (s_struct_Uniforms___color__array<v_ram_000013c7 + 0xc1,param2,iVar1,
		                         iVar2 - iVar1,0);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        if (*(int *)(I2_Loc_TranslationJob_WEB___c_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     I2_Loc_TranslationJob_WEB___c_TypeInfo);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81c8f2bd;
		          }
		        }
		        uVar4 = StringLiteral_19009;
		        puVar5 = *(undefined4 **)(I2_Loc_TranslationJob_WEB___c_TypeInfo + 0x5c);
		        iVar8 = puVar5[2];
		        if (iVar8 == 0) {
		          if (*(int *)(I2_Loc_TranslationJob_WEB___c_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       I2_Loc_TranslationJob_WEB___c_TypeInfo);
		            if (DAT_ram_009d3e38 != 1) {
		              puVar5 = *(undefined4 **)(I2_Loc_TranslationJob_WEB___c_TypeInfo + 0x5c);
		              goto code_r0x81c8ec3b;
		            }
		code_r0x81c8f2b5:
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		code_r0x81c8ec3b:
		            uVar6 = *puVar5;
		            DAT_ram_009d3e38 = 0;
		            iVar8 = import::env::invoke_ii
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                               System_Text_RegularExpressions_MatchEvaluator_TypeInfo);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiii
		                        (s___Scripting__UnityEngine__Player_ram_000035bf + 0x20,iVar8,uVar6,
		                         Method_I2_Loc_TranslationJob_WEB___c__ParseTranslationResult_b__12_0__,0);
		              if (DAT_ram_009d3e38 != 1) {
		                *(int *)(*(int *)(I2_Loc_TranslationJob_WEB___c_TypeInfo + 0x5c) + 8) = iVar8;
		                goto code_r0x81c8ecbe;
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		        }
		        else {
		code_r0x81c8ecbe:
		          if (*(int *)(System_Text_RegularExpressions_Regex_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       System_Text_RegularExpressions_Regex_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x81c8f2b5;
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::invoke_iiiii
		                            (s___Scripting__UnityEngine__Player_ram_000035bf + 0x21,uVar3,uVar4,
		                             iVar8,0);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            if (*(int *)(I2_Loc_TranslationJob_WEB___c_TypeInfo + 0x74) == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                         I2_Loc_TranslationJob_WEB___c_TypeInfo);
		              iVar8 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar8 == 1) {
		                uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x81c8f2bd;
		              }
		            }
		            uVar4 = StringLiteral_735;
		            puVar5 = *(undefined4 **)(I2_Loc_TranslationJob_WEB___c_TypeInfo + 0x5c);
		            iVar8 = puVar5[3];
		            if (iVar8 == 0) {
		              if (*(int *)(I2_Loc_TranslationJob_WEB___c_TypeInfo + 0x74) == 0) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vi
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                           I2_Loc_TranslationJob_WEB___c_TypeInfo);
		                if (DAT_ram_009d3e38 == 1) goto code_r0x81c8f2b5;
		                puVar5 = *(undefined4 **)(I2_Loc_TranslationJob_WEB___c_TypeInfo + 0x5c);
		              }
		              uVar6 = *puVar5;
		              DAT_ram_009d3e38 = 0;
		              iVar8 = import::env::invoke_ii
		                                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                 System_Text_RegularExpressions_MatchEvaluator_TypeInfo);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_viiii
		                          (s___Scripting__UnityEngine__Player_ram_000035bf + 0x20,iVar8,uVar6,
		                           Method_I2_Loc_TranslationJob_WEB___c__ParseTranslationResult_b__12_1__,0)
		                ;
		                if (DAT_ram_009d3e38 != 1) {
		                  *(int *)(*(int *)(I2_Loc_TranslationJob_WEB___c_TypeInfo + 0x5c) + 0xc) = iVar8;
		                  goto code_r0x81c8ee7e;
		                }
		              }
		              DAT_ram_009d3e38 = 0;
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            }
		            else {
		code_r0x81c8ee7e:
		              if (*(int *)(System_Text_RegularExpressions_Regex_TypeInfo + 0x74) == 0) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vi
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                           System_Text_RegularExpressions_Regex_TypeInfo);
		                if (DAT_ram_009d3e38 == 1) goto code_r0x81c8f2b5;
		              }
		              DAT_ram_009d3e38 = 0;
		              uVar3 = import::env::invoke_iiiii
		                                (s___Scripting__UnityEngine__Player_ram_000035bf + 0x21,uVar3,uVar4,
		                                 iVar8,0);
		              iVar8 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar8 == 1) {
		                uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              }
		              else {
		                DAT_ram_009d3e38 = 0;
		                uVar3 = import::env::invoke_iiiii
		                                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2a,uVar3,
		                                   StringLiteral_2169,StringLiteral_47,0);
		                iVar8 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar8 == 1) {
		                  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                }
		                else {
		                  DAT_ram_009d3e38 = 0;
		                  uVar4 = import::env::invoke_iii
		                                    (s_struct_VertexOutput____builtin_p_ram_00002c3d + 0x117,param3,
		                                     0);
		                  iVar8 = DAT_ram_009d3e38;
		                  DAT_ram_009d3e38 = 0;
		                  if (iVar8 == 1) {
		                    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  }
		                  else {
		                    DAT_ram_009d3e38 = 0;
		                    iVar1 = System_Collections_CollectionBase___ctor(uVar4,param3,0);
		                    iVar8 = DAT_ram_009d3e38;
		                    DAT_ram_009d3e38 = 0;
		                    if (iVar8 == 1) {
		                      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                    }
		                    else if (iVar1 == 0) {
		                      if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		                        DAT_ram_009d3e38 = 0;
		                        import::env::invoke_vi
		                                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                                   I2_Loc_GoogleTranslation_TypeInfo);
		                        iVar8 = DAT_ram_009d3e38;
		                        DAT_ram_009d3e38 = 0;
		                        if (iVar8 == 1) {
		                          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                          goto code_r0x81c8f2bd;
		                        }
		                      }
		                      DAT_ram_009d3e38 = 0;
		                      uVar4 = import::env::invoke_iii
		                                        (s___Scripting__UnityEngine__Player_ram_000035bf + 0x22,
		                                         param3,0);
		                      iVar8 = DAT_ram_009d3e38;
		                      DAT_ram_009d3e38 = 0;
		                      if (iVar8 == 1) {
		                        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                      }
		                      else {
		                        DAT_ram_009d3e38 = 0;
		                        iVar1 = System_Collections_CollectionBase___ctor(uVar4,param3,0);
		                        iVar8 = DAT_ram_009d3e38;
		                        DAT_ram_009d3e38 = 0;
		                        if (iVar8 == 1) {
		                          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                        }
		                        else if (iVar1 == 0) {
		                          if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		                            DAT_ram_009d3e38 = 0;
		                            import::env::invoke_vi
		                                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                                       I2_Loc_GoogleTranslation_TypeInfo);
		                            iVar8 = DAT_ram_009d3e38;
		                            DAT_ram_009d3e38 = 0;
		                            if (iVar8 == 1) {
		                              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              goto code_r0x81c8f2bd;
		                            }
		                          }
		                          DAT_ram_009d3e38 = 0;
		                          uVar4 = import::env::invoke_iii
		                                            (s___Scripting__UnityEngine__Player_ram_000035bf + 0x23,
		                                             param3,0);
		                          iVar8 = DAT_ram_009d3e38;
		                          DAT_ram_009d3e38 = 0;
		                          if (iVar8 == 1) {
		                            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                          }
		                          else {
		                            DAT_ram_009d3e38 = 0;
		                            iVar1 = System_Collections_CollectionBase___ctor(uVar4,param3,0);
		                            iVar8 = DAT_ram_009d3e38;
		                            DAT_ram_009d3e38 = 0;
		                            if (iVar8 == 1) {
		                              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                            }
		                            else {
		                              if (iVar1 == 0) {
		                                DAT_ram_009d3e38 = 0;
		                                return uVar3;
		                              }
		                              if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		                                DAT_ram_009d3e38 = 0;
		                                import::env::invoke_vi
		                                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                                           I2_Loc_GoogleTranslation_TypeInfo);
		                                iVar8 = DAT_ram_009d3e38;
		                                DAT_ram_009d3e38 = 0;
		                                if (iVar8 == 1) {
		                                  uVar3 = import::env::__cxa_find_matching_catch_3
		                                                    (&DAT_ram_0072c9c8);
		                                  goto code_r0x81c8f2bd;
		                                }
		                              }
		                              DAT_ram_009d3e38 = 0;
		                              uVar3 = import::env::invoke_iii
		                                                (s___Scripting__UnityEngine__Player_ram_000035bf +
		                                                 0x23,uVar3,0);
		                              iVar8 = DAT_ram_009d3e38;
		                              DAT_ram_009d3e38 = 0;
		                              if (iVar8 != 1) {
		                                DAT_ram_009d3e38 = 0;
		                                return uVar3;
		                              }
		                              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                            }
		                          }
		                        }
		                        else {
		                          if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		                            DAT_ram_009d3e38 = 0;
		                            import::env::invoke_vi
		                                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                                       I2_Loc_GoogleTranslation_TypeInfo);
		                            iVar8 = DAT_ram_009d3e38;
		                            DAT_ram_009d3e38 = 0;
		                            if (iVar8 == 1) {
		                              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              goto code_r0x81c8f2bd;
		                            }
		                          }
		                          DAT_ram_009d3e38 = 0;
		                          uVar3 = import::env::invoke_iii
		                                            (s___Scripting__UnityEngine__Player_ram_000035bf + 0x22,
		                                             uVar3,0);
		                          iVar8 = DAT_ram_009d3e38;
		                          DAT_ram_009d3e38 = 0;
		                          if (iVar8 != 1) {
		                            DAT_ram_009d3e38 = 0;
		                            return uVar3;
		                          }
		                          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                        }
		                      }
		                    }
		                    else {
		                      DAT_ram_009d3e38 = 0;
		                      uVar3 = import::env::invoke_iii
		                                        (s_struct_VertexOutput____builtin_p_ram_00002c3d + 0x117,
		                                         uVar3,0);
		                      iVar8 = DAT_ram_009d3e38;
		                      DAT_ram_009d3e38 = 0;
		                      if (iVar8 != 1) {
		                        DAT_ram_009d3e38 = 0;
		                        return uVar3;
		                      }
		                      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		  }
		code_r0x81c8f2bd:
		  iVar8 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar1) {
		    puVar5 = (undefined4 *)import::env::__cxa_begin_catch(uVar3);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar1 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar3,
		                         *(undefined4 *)*puVar5);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 != 1) {
		        if (iVar1 != 0) {
		          piVar7 = (int *)*puVar5;
		          import::env::__cxa_end_catch();
		          iVar8 = *piVar7;
		          uVar3 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0xe8) * 4))
		                            (piVar7,*(undefined4 *)(iVar8 + 0xec));
		          iVar8 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		          if (*(int *)(iVar8 + 0x74) == 0) {
		            func_ii_306000(iVar8);
		          }
		          func_ii_7109(uVar3,0);
		          return **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar5;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81c8f410;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x81c8f410:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060075DE RID: 30174 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075DE")]
		[Address(RVA = "0xBF67", Offset = "0xBF67", VA = "0xBF67")]
		private string ParseTranslationResult(string html, string OriginalText)
		{
		/* --- GHIDRA: ParseTranslationResult ---
		void I2_Loc_TranslationJob_WEB__ParseTranslationResult(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60472 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_TranslationJob_WEB___c_TypeInfo);
		    DAT_ram_00a60472 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(I2_Loc_TranslationJob_WEB___c_TypeInfo);
		  **(undefined4 **)(I2_Loc_TranslationJob_WEB___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04003D8E RID: 15758
		[Token(Token = "0x4003D8E")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, TranslationQuery> _requests;

		// Token: 0x04003D8F RID: 15759
		[Token(Token = "0x4003D8F")]
		[FieldOffset(Offset = "0x14")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		// Token: 0x04003D90 RID: 15760
		[Token(Token = "0x4003D90")]
		[FieldOffset(Offset = "0x18")]
		public string mErrorMessage;

		// Token: 0x04003D91 RID: 15761
		[Token(Token = "0x4003D91")]
		[FieldOffset(Offset = "0x1C")]
		private string mCurrentBatch_ToLanguageCode;

		// Token: 0x04003D92 RID: 15762
		[Token(Token = "0x4003D92")]
		[FieldOffset(Offset = "0x20")]
		private string mCurrentBatch_FromLanguageCode;

		// Token: 0x04003D93 RID: 15763
		[Token(Token = "0x4003D93")]
		[FieldOffset(Offset = "0x24")]
		private List<string> mCurrentBatch_Text;

		// Token: 0x04003D94 RID: 15764
		[Token(Token = "0x4003D94")]
		[FieldOffset(Offset = "0x28")]
		private List<KeyValuePair<string, string>> mQueries;
	}
}
