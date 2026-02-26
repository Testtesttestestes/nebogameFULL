using System;
using System.Collections.Generic;
using Core.Data;
using Core.Gameplay.Managers.Requirements;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;

namespace Gameplay.DailyQuests.Controller
{
	// Token: 0x0200088F RID: 2191
	[Token(Token = "0x200088F")]
	public class QuestsTriggerObserver : IDisposable
	{
		// Token: 0x060033B2 RID: 13234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033B2")]
		[Address(RVA = "0x83EC", Offset = "0x83EC", VA = "0x83EC")]
		public void AddDailyQuestsToBlackList(IEnumerable<uint> ids)
		{
		/* --- GHIDRA: <GetImpactedQuests>b__10_1 ---
		void Gameplay_DailyQuests_Controller_QuestsTriggerObserver___GetImpactedQuests_b__10_1
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57ca4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_DailyGoalDic___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_DailyQuestsDic___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_DailyQuestsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_DailyGoalDic__TypeInfo);
		    DAT_ram_00a57ca4 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_HashSet_DailyQuestsDic__TypeInfo);
		  func_ii_7115(uVar1,Method_System_Collections_Generic_HashSet_DailyQuestsDic___ctor__);
		  *(undefined4 *)(param1 + 8) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_HashSet_DailyGoalDic__TypeInfo);
		  func_ii_7115(uVar1,Method_System_Collections_Generic_HashSet_DailyGoalDic___ctor__);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <GetImpactedQuests>b__10_0 ---
		undefined4
		Gameplay_DailyQuests_Controller_QuestsTriggerObserver___GetImpactedQuests_b__10_0
		          (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a57ca3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Contains__);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo);
		    DAT_ram_00a57ca3 = '\x01';
		  }
		  iVar2 = Core_Data_Skills_SkillData___ctor
		                    (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(param2 + 0xc),
		                     Method_System_Collections_Generic_HashSet_uint__Contains__);
		  if (iVar2 == 0) {
		    uVar4 = *(undefined4 *)(param1 + 0xc);
		    uVar5 = *(undefined4 *)(param2 + 0x20);
		    param1_00 = *(int **)(param1 + 8);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x80e43f51;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,
		                                  Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo
		                                  ,2);
		code_r0x80e43f51:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar5,uVar4,puVar3[1]);
		  }
		  else {
		    uVar4 = 0;
		  }
		  return uVar4;
		}
		*/

		/* --- GHIDRA: AddDailyQuestsToBlackList ---
		void Gameplay_DailyQuests_Controller_QuestsTriggerObserver__AddDailyQuestsToBlackList
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int *piVar7;
		  int iVar8;
		  undefined4 local_10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57c9c == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Add__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8573);
		    DAT_ram_00a57c9c = '\x01';
		  }
		  iVar8 = *param2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_uint__TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e3f52b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_uint__TypeInfo,0);
		code_r0x80e3f52b:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    do {
		      piVar6 = local_4;
		      iVar8 = *local_4;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		            puVar3 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		            goto code_r0x80e3f5fa;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80e3f642:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e3f87a;
		      }
		code_r0x80e3f5fa:
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		      piVar6 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e3f642;
		      if (iVar8 == 0) {
		        iVar8 = 0;
		        goto code_r0x80e3f8c3;
		      }
		      iVar8 = *local_4;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar7) {
		            puVar3 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		            goto code_r0x80e3f6e7;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80e3f854:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e3f87a;
		      }
		code_r0x80e3f6e7:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e3f854;
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3bf,
		                         *(undefined4 *)(param1 + 0x18),uVar4,
		                         Method_System_Collections_Generic_HashSet_uint__Add__);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e3f87a;
		      }
		    } while (iVar5 != 0);
		    DAT_ram_009d3e38 = 0;
		    local_10 = uVar4;
		    uVar4 = import::env::invoke_iii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66958,
		                       &local_10);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e3f87a;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1c0,StringLiteral_8573,
		                       uVar4,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,OKG_Logs_Debug_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x3f,uVar4,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e3f87a:
		  iVar8 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar8 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar8;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x80e3f8c3:
		      piVar6 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar5 = *local_4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e3f93b;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e3f93b:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      }
		      if (iVar8 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x41,&local_c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
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

		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033B3")]
		[Address(RVA = "0x83ED", Offset = "0x83ED", VA = "0x83ED")]
		public void AddGoalsToBlackList(IEnumerable<uint> ids)
		{
		/* --- GHIDRA: AddGoalsToBlackList ---
		void Gameplay_DailyQuests_Controller_QuestsTriggerObserver__AddGoalsToBlackList
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57c9d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Clear__);
		    DAT_ram_00a57c9d = '\x01';
		  }
		  System_Collections_Generic_HashSet___Il2CppFullySharedGenericType___AreEqualityComparersEqual
		            (*(undefined4 *)(param1 + 0x14),Method_System_Collections_Generic_HashSet_uint__Clear__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033B4")]
		[Address(RVA = "0x83EE", Offset = "0x83EE", VA = "0x83EE")]
		public void ClearDailyQuestsBlackList()
		{
		/* --- GHIDRA: ClearDailyQuestsBlackList ---
		void Gameplay_DailyQuests_Controller_QuestsTriggerObserver__ClearDailyQuestsBlackList
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57c9e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Clear__);
		    DAT_ram_00a57c9e = '\x01';
		  }
		  System_Collections_Generic_HashSet___Il2CppFullySharedGenericType___AreEqualityComparersEqual
		            (*(undefined4 *)(param1 + 0x18),Method_System_Collections_Generic_HashSet_uint__Clear__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033B5")]
		[Address(RVA = "0x83EF", Offset = "0x83EF", VA = "0x83EF")]
		public void ClearGoalsBlackList()
		{
		/* --- GHIDRA: ClearGoalsBlackList ---
		/* WARNING: Removing unreachable block (ram,0x80e42fb4) */
		/* WARNING: Removing unreachable block (ram,0x80e439e2) */
		
		void Gameplay_DailyQuests_Controller_QuestsTriggerObserver__ClearGoalsBlackList
		               (int param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  uint *puVar8;
		  int iVar9;
		  undefined4 uVar10;
		  int *piVar11;
		  int local_1c;
		  int **local_18;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int *local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57c9f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__QuestsTriggerObserver_Quests__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__QuestsTriggerObserver_Quests__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__QuestsTriggerObserver_Quests___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__QuestsTriggerObserver_Quests__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_int__QuestsTriggerObserver_Quests__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_DailyGoalDic__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_DailyQuestsDic__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_DailyGoalDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_DailyQuestsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_RestrictionInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_DailyQuests_Controller_QuestsTriggerObserver_Quests_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RestrictionInfo__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_DailyQuestsDic__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_DailyGoalDic__GetEnumerator__);
		    DAT_ram_00a57c9f = '\x01';
		  }
		  local_8 = (int *)0x0;
		  local_c = (int *)0x0;
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_int__QuestsTriggerObserver_Quests__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_int__TMP_ResourceManager_FontAssetRef___set_Item
		            (uVar2,
		             Method_System_Collections_Generic_Dictionary_int__QuestsTriggerObserver_Quests___ctor__
		            );
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  uVar2 = unnamed_function_1417(System_Collections_Generic_HashSet_uint__TypeInfo);
		  System_Collections_Generic_HashSet_PropertyPath___get_Count
		            (uVar2,Method_System_Collections_Generic_HashSet_uint___ctor__);
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  uVar2 = unnamed_function_1417(System_Collections_Generic_HashSet_uint__TypeInfo);
		  System_Collections_Generic_HashSet_PropertyPath___get_Count
		            (uVar2,Method_System_Collections_Generic_HashSet_uint___ctor__);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(undefined4 *)(param1 + 8) = param4;
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(param2 + 400),
		                              Method_Google_Protobuf_Collections_RepeatedField_DailyQuestsDic__GetEnumerator__
		                             );
		  local_14 = 0;
		  local_10 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		          puVar3 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		          goto code_r0x80e42a14;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e43246:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar9 = global_1;
		      goto code_r0x80e43255;
		    }
		code_r0x80e42a14:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e43246;
		    if (iVar9 == 0) {
		      iVar9 = 7;
		      iVar4 = 0;
		      goto code_r0x80e432a0;
		    }
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_DailyQuestsDic__TypeInfo == *piVar11) {
		          puVar3 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		          goto code_r0x80e42af4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_DailyQuestsDic__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e42b89:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar9 = global_1;
		      goto code_r0x80e43255;
		    }
		code_r0x80e42af4:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e42b89;
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3a2,
		                               *(undefined4 *)(iVar9 + 0x24),
		                               Method_Google_Protobuf_Collections_RepeatedField_RestrictionInfo__GetEnumerator__
		                              );
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar9 = global_1;
		      goto code_r0x80e43255;
		    }
		    local_1c = 0;
		    local_18 = &local_8;
		    local_8 = piVar5;
		    do {
		      piVar5 = local_8;
		      iVar4 = *local_8;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar11 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		            puVar3 = (undefined4 *)(iVar4 + piVar11[1] * 8 + 0xc0);
		            goto code_r0x80e42c3c;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) break;
		code_r0x80e42c3c:
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		      piVar5 = local_8;
		      if (DAT_ram_009d3e38 == 1) break;
		      if (iVar4 == 0) goto code_r0x80e430c7;
		      iVar4 = *local_8;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar11 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_RestrictionInfo__TypeInfo == *piVar11) {
		            puVar3 = (undefined4 *)(iVar4 + piVar11[1] * 8 + 0xc0);
		            goto code_r0x80e42d17;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                          System_Collections_Generic_IEnumerator_RestrictionInfo__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) break;
		code_r0x80e42d17:
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x260,
		                         *(undefined4 *)(param1 + 0x10),*(undefined4 *)(iVar4 + 0xc),
		                         Method_System_Collections_Generic_Dictionary_int__QuestsTriggerObserver_Quests__ContainsKey__
		                        );
		      if (DAT_ram_009d3e38 == 1) break;
		      if (iVar6 == 0) {
		        uVar2 = *(undefined4 *)(iVar4 + 0xc);
		        uVar10 = *(undefined4 *)(param1 + 0x10);
		        DAT_ram_009d3e38 = 0;
		        iVar6 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           Gameplay_DailyQuests_Controller_QuestsTriggerObserver_Quests_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) break;
		        if (DAT_ram_00a57ca4 == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (0x7ff,&Method_System_Collections_Generic_HashSet_DailyGoalDic___ctor__);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (0x7ff,&Method_System_Collections_Generic_HashSet_DailyQuestsDic___ctor__);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&System_Collections_Generic_HashSet_DailyQuestsDic__TypeInfo)
		          ;
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&System_Collections_Generic_HashSet_DailyGoalDic__TypeInfo);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_00a57ca4 = '\x01';
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar7 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Collections_Generic_HashSet_DailyQuestsDic__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x45,uVar7,
		                   Method_System_Collections_Generic_HashSet_DailyQuestsDic___ctor__);
		        if (DAT_ram_009d3e38 == 1) break;
		        *(undefined4 *)(iVar6 + 8) = uVar7;
		        DAT_ram_009d3e38 = 0;
		        uVar7 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Collections_Generic_HashSet_DailyGoalDic__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x45,uVar7,
		                   Method_System_Collections_Generic_HashSet_DailyGoalDic___ctor__);
		        if (DAT_ram_009d3e38 == 1) break;
		        *(undefined4 *)(iVar6 + 0xc) = uVar7;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x259,uVar10,uVar2,iVar6,
		                   Method_System_Collections_Generic_Dictionary_int__QuestsTriggerObserver_Quests__Add__
		                  );
		        if (DAT_ram_009d3e38 == 1) break;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x32,
		                         *(undefined4 *)(param1 + 0x10),*(undefined4 *)(iVar4 + 0xc),
		                         Method_System_Collections_Generic_Dictionary_int__QuestsTriggerObserver_Quests__get_Item__
		                        );
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_iiii
		                (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x19d,*(undefined4 *)(iVar4 + 8),
		                 iVar9,Method_System_Collections_Generic_HashSet_DailyQuestsDic__Add__);
		    } while (DAT_ram_009d3e38 != 1);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar9 = global_1;
		    iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar9 != iVar4) {
		code_r0x80e43213:
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x46,&local_1c);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 != 1) goto code_r0x80e43255;
		      goto code_r0x80e43d8e;
		    }
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    local_1c = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar9 = global_1;
		      goto code_r0x80e43213;
		    }
		code_r0x80e430c7:
		    piVar5 = *local_18;
		    if (piVar5 != (int *)0x0) {
		      iVar9 = *piVar5;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		          if (System_IDisposable_TypeInfo == *piVar11) {
		            puVar3 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		            goto code_r0x80e43167;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                          System_IDisposable_TypeInfo,0);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x80e43167:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii(*puVar3,piVar5,puVar3[1]);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x80e431a3;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar9 = global_1;
		      goto code_r0x80e43255;
		    }
		code_r0x80e431a3:
		  } while (local_1c == 0);
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_1c);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 != 1) {
		code_r0x80e43dac:
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar9 = global_1;
		code_r0x80e43255:
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar9) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar4 = *piVar5;
		    iVar9 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_14 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x80e432a0:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar6 = *local_4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar8 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e43318;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar8 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e43318:
		        (**(code **)((ulonglong)*puVar8 * 4))(piVar5,puVar8[1]);
		      }
		      if (iVar4 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar9 != 0) &&
		         ((((iVar9 == 1 || (iVar9 == 2)) || (iVar9 == 3)) ||
		          (((iVar9 == 4 || (iVar9 == 5)) || ((iVar9 == 6 || (iVar9 != 7)))))))) {
		        return;
		      }
		      local_c = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                 (*(undefined4 *)(param2 + 0x2e0),
		                                  Method_Google_Protobuf_Collections_RepeatedField_DailyGoalDic__GetEnumerator__
		                                 );
		      local_14 = 0;
		      local_10 = &local_c;
		      do {
		        piVar5 = local_c;
		        iVar9 = *local_c;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		              puVar3 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x80e43443;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e43c6e:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar9 = global_1;
		          goto code_r0x80e43c7d;
		        }
		code_r0x80e43443:
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		        piVar5 = local_c;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e43c6e;
		        if (iVar9 == 0) {
		          iVar9 = 0;
		          goto code_r0x80e43cc4;
		        }
		        iVar9 = *local_c;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_DailyGoalDic__TypeInfo == *piVar11) {
		              puVar3 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x80e43523;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                            System_Collections_Generic_IEnumerator_DailyGoalDic__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e435b8:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar9 = global_1;
		          goto code_r0x80e43c7d;
		        }
		code_r0x80e43523:
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e435b8;
		        DAT_ram_009d3e38 = 0;
		        piVar5 = (int *)import::env::invoke_iii
		                                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3a2,
		                                   *(undefined4 *)(iVar9 + 0x20),
		                                   Method_Google_Protobuf_Collections_RepeatedField_RestrictionInfo__GetEnumerator__
		                                  );
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar9 = global_1;
		          goto code_r0x80e43c7d;
		        }
		        local_1c = 0;
		        local_18 = &local_8;
		        local_8 = piVar5;
		        do {
		          piVar5 = local_8;
		          iVar4 = *local_8;
		          if (*(ushort *)(iVar4 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar11 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		              if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		                puVar3 = (undefined4 *)(iVar4 + piVar11[1] * 8 + 0xc0);
		                goto code_r0x80e4366b;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar3 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                              System_Collections_IEnumerator_TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) break;
		code_r0x80e4366b:
		          DAT_ram_009d3e38 = 0;
		          iVar4 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		          piVar5 = local_8;
		          if (DAT_ram_009d3e38 == 1) break;
		          if (iVar4 == 0) {
		            iVar9 = 0;
		            goto code_r0x80e43afe;
		          }
		          iVar4 = *local_8;
		          if (*(ushort *)(iVar4 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar11 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		              if (System_Collections_Generic_IEnumerator_RestrictionInfo__TypeInfo == *piVar11) {
		                puVar3 = (undefined4 *)(iVar4 + piVar11[1] * 8 + 0xc0);
		                goto code_r0x80e43745;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar3 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                              System_Collections_Generic_IEnumerator_RestrictionInfo__TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) break;
		code_r0x80e43745:
		          DAT_ram_009d3e38 = 0;
		          iVar4 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x260,
		                             *(undefined4 *)(param1 + 0x10),*(undefined4 *)(iVar4 + 0xc),
		                             Method_System_Collections_Generic_Dictionary_int__QuestsTriggerObserver_Quests__ContainsKey__
		                            );
		          if (DAT_ram_009d3e38 == 1) break;
		          if (iVar6 == 0) {
		            uVar2 = *(undefined4 *)(iVar4 + 0xc);
		            uVar10 = *(undefined4 *)(param1 + 0x10);
		            DAT_ram_009d3e38 = 0;
		            iVar6 = import::env::invoke_ii
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                               Gameplay_DailyQuests_Controller_QuestsTriggerObserver_Quests_TypeInfo
		                              );
		            if (DAT_ram_009d3e38 == 1) break;
		            if (DAT_ram_00a57ca4 == '\0') {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (0x7ff,&Method_System_Collections_Generic_HashSet_DailyGoalDic___ctor__);
		              if (DAT_ram_009d3e38 == 1) break;
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (0x7ff,&Method_System_Collections_Generic_HashSet_DailyQuestsDic___ctor__);
		              if (DAT_ram_009d3e38 == 1) break;
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (0x7ff,&System_Collections_Generic_HashSet_DailyQuestsDic__TypeInfo);
		              if (DAT_ram_009d3e38 == 1) break;
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (0x7ff,&System_Collections_Generic_HashSet_DailyGoalDic__TypeInfo);
		              if (DAT_ram_009d3e38 == 1) break;
		              DAT_ram_00a57ca4 = '\x01';
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar7 = import::env::invoke_ii
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                               System_Collections_Generic_HashSet_DailyQuestsDic__TypeInfo);
		            if (DAT_ram_009d3e38 == 1) break;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x45,uVar7,
		                       Method_System_Collections_Generic_HashSet_DailyQuestsDic___ctor__);
		            if (DAT_ram_009d3e38 == 1) break;
		            *(undefined4 *)(iVar6 + 8) = uVar7;
		            DAT_ram_009d3e38 = 0;
		            uVar7 = import::env::invoke_ii
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                               System_Collections_Generic_HashSet_DailyGoalDic__TypeInfo);
		            if (DAT_ram_009d3e38 == 1) break;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x45,uVar7,
		                       Method_System_Collections_Generic_HashSet_DailyGoalDic___ctor__);
		            if (DAT_ram_009d3e38 == 1) break;
		            *(undefined4 *)(iVar6 + 0xc) = uVar7;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x259,uVar10,uVar2,iVar6,
		                       Method_System_Collections_Generic_Dictionary_int__QuestsTriggerObserver_Quests__Add__
		                      );
		            if (DAT_ram_009d3e38 == 1) break;
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar4 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x32,
		                             *(undefined4 *)(param1 + 0x10),*(undefined4 *)(iVar4 + 0xc),
		                             Method_System_Collections_Generic_Dictionary_int__QuestsTriggerObserver_Quests__get_Item__
		                            );
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_iiii
		                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x19d,
		                     *(undefined4 *)(iVar4 + 0xc),iVar9,
		                     Method_System_Collections_Generic_HashSet_DailyGoalDic__Add__);
		        } while (DAT_ram_009d3e38 != 1);
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar9 = global_1;
		        iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar9 != iVar4) {
		code_r0x80e43c3b:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x48,&local_1c);
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 != 1) goto code_r0x80e43c7d;
		          goto code_r0x80e43d8e;
		        }
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar9 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_1c = iVar9;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar9 = global_1;
		          goto code_r0x80e43c3b;
		        }
		code_r0x80e43afe:
		        piVar5 = local_8;
		        if (local_8 != (int *)0x0) {
		          iVar4 = *local_8;
		          if (*(ushort *)(iVar4 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar11 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		              if (System_IDisposable_TypeInfo == *piVar11) {
		                puVar3 = (undefined4 *)(iVar4 + piVar11[1] * 8 + 0xc0);
		                goto code_r0x80e43b9b;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar3 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                              System_IDisposable_TypeInfo,0);
		          if (DAT_ram_009d3e38 != 1) {
		code_r0x80e43b9b:
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii(*puVar3,piVar5,puVar3[1]);
		            if (DAT_ram_009d3e38 != 1) goto code_r0x80e43bd7;
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar9 = global_1;
		          goto code_r0x80e43c7d;
		        }
		code_r0x80e43bd7:
		      } while (iVar9 == 0);
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar9);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 != 1) goto code_r0x80e43dac;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar9 = global_1;
		code_r0x80e43c7d:
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar4 == iVar9) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar9 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_14 = iVar9;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		code_r0x80e43cc4:
		          piVar5 = local_c;
		          DAT_ram_009d3e38 = 0;
		          if (local_c != (int *)0x0) {
		            uVar1 = 0;
		            iVar4 = *local_c;
		            if (*(ushort *)(iVar4 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		                  puVar8 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x80e43d3c;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		            }
		            puVar8 = (uint *)func_ii_1080(local_c,System_IDisposable_TypeInfo,0);
		code_r0x80e43d3c:
		            (**(code **)((ulonglong)*puVar8 * 4))(piVar5,puVar8[1]);
		          }
		          if (iVar9 == 0) {
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x49,&local_14);
		      goto joined_r0x80e43d8b;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x47,&local_14);
		joined_r0x80e43d8b:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x80e43d8e:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060033B6 RID: 13238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033B6")]
		[Address(RVA = "0x83F0", Offset = "0x83F0", VA = "0x83F0")]
		public QuestsTriggerObserver(Dictionaries dict, UserData user, IRequirementValidator validator)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_DailyQuests_Controller_QuestsTriggerObserver___ctor
		              (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  undefined4 uVar8;
		  undefined4 uVar9;
		  int *piVar10;
		  int iVar11;
		  int local_10;
		  int **local_c;
		  int local_8;
		  int *local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a57ca0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__QuestsTriggerObserver_Quests__TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_DailyGoalDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_DailyQuestsDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_DailyQuestsDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_DailyGoalDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_TriggerValue__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_TriggerValue__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Sirenix_Utilities_LinqExtensions_AddRange_DailyGoalDic___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Sirenix_Utilities_LinqExtensions_AddRange_DailyQuestsDic___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_QuestsTriggerObserver__GetImpactedQuests_b__10_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_QuestsTriggerObserver__GetImpactedQuests_b__10_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_DailyQuests_Controller_QuestsTriggerObserver_Quests_TypeInfo);
		    DAT_ram_00a57ca0 = '\x01';
		  }
		  local_8 = 0;
		  iVar2 = unnamed_function_1417
		                    (Gameplay_DailyQuests_Controller_QuestsTriggerObserver_Quests_TypeInfo);
		  Gameplay_DailyQuests_Controller_QuestsTriggerObserver___GetImpactedQuests_b__10_1(iVar2,0);
		  iVar11 = *param2;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_TriggerValue__TypeInfo ==
		          *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e3da02;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_TriggerValue__TypeInfo
		                                ,0);
		code_r0x80e3da02:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  local_10 = 0;
		  local_c = &local_4;
		  do {
		    do {
		      piVar7 = local_4;
		      iVar11 = *local_4;
		      if (*(ushort *)(iVar11 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		            puVar4 = (undefined4 *)(iVar11 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x80e3dacd;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80e3db15:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e3de64;
		      }
		code_r0x80e3dacd:
		      DAT_ram_009d3e38 = 0;
		      iVar11 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		      piVar7 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e3db15;
		      if (iVar11 == 0) {
		        iVar11 = 0;
		        goto code_r0x80e3dead;
		      }
		      iVar11 = *local_4;
		      if (*(ushort *)(iVar11 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_TriggerValue__TypeInfo == *piVar10) {
		            puVar4 = (undefined4 *)(iVar11 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x80e3dbbe;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_TriggerValue__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80e3dc4d:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e3de64;
		      }
		code_r0x80e3dbbe:
		      DAT_ram_009d3e38 = 0;
		      iVar11 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e3dc4d;
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iiiii
		                        (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x217,
		                         *(undefined4 *)(param1 + 0x10),*(undefined4 *)(iVar11 + 0xc),&local_8,
		                         Method_System_Collections_Generic_Dictionary_int__QuestsTriggerObserver_Quests__TryGetValue__
		                        );
		      iVar11 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar11 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e3de64;
		      }
		    } while (iVar6 == 0);
		    uVar8 = *(undefined4 *)(local_8 + 8);
		    uVar9 = *(undefined4 *)(iVar2 + 8);
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Func_DailyQuestsDic__bool__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e3de48:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e3de64;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar5,param1,
		               Method_Gameplay_DailyQuests_Controller_QuestsTriggerObserver__GetImpactedQuests_b__10_0__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e3de48;
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x226,uVar8,uVar5,
		                       Method_System_Linq_Enumerable_Where_DailyQuestsDic___);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e3de52:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e3de64;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x3b,uVar9,uVar5,
		               Method_Sirenix_Utilities_LinqExtensions_AddRange_DailyQuestsDic___);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e3de52;
		    uVar8 = *(undefined4 *)(local_8 + 0xc);
		    uVar9 = *(undefined4 *)(iVar2 + 0xc);
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Func_DailyGoalDic__bool__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e3de5c:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e3de64;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar5,param1,
		               Method_Gameplay_DailyQuests_Controller_QuestsTriggerObserver__GetImpactedQuests_b__10_1__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e3de5c;
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x226,uVar8,uVar5,
		                       Method_System_Linq_Enumerable_Where_DailyGoalDic___);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x3b,uVar9,uVar5,
		               Method_Sirenix_Utilities_LinqExtensions_AddRange_DailyGoalDic___);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e3de64:
		  iVar11 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar11 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar11 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    local_10 = iVar11;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x80e3dead:
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
		              goto code_r0x80e3df25;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e3df25:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		      }
		      if (iVar11 == 0) {
		        return iVar2;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar11);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x3c,&local_10);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60033B7")]
		[Address(RVA = "0x83F1", Offset = "0x83F1", VA = "0x83F1")]
		public QuestsTriggerObserver.Quests GetImpactedQuests(IEnumerable<TriggerValue> changes)
		{
		/* --- GHIDRA: GetImpactedQuests ---
		void Gameplay_DailyQuests_Controller_QuestsTriggerObserver__GetImpactedQuests
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57ca1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__QuestsTriggerObserver_Quests__Clear__
		              );
		    DAT_ram_00a57ca1 = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x10),
		             Method_System_Collections_Generic_Dictionary_int__QuestsTriggerObserver_Quests__Clear__
		            );
		  if (DAT_ram_00a57c9d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Clear__);
		    DAT_ram_00a57c9d = '\x01';
		  }
		  System_Collections_Generic_HashSet___Il2CppFullySharedGenericType___AreEqualityComparersEqual
		            (*(undefined4 *)(param1 + 0x14),Method_System_Collections_Generic_HashSet_uint__Clear__)
		  ;
		  if (DAT_ram_00a57c9e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Clear__);
		    DAT_ram_00a57c9e = '\x01';
		  }
		  System_Collections_Generic_HashSet___Il2CppFullySharedGenericType___AreEqualityComparersEqual
		            (*(undefined4 *)(param1 + 0x18),Method_System_Collections_Generic_HashSet_uint__Clear__)
		  ;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033B8")]
		[Address(RVA = "0x83F2", Offset = "0x83F2", VA = "0x83F2", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		undefined4
		Gameplay_DailyQuests_Controller_QuestsTriggerObserver__Dispose
		          (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a57ca2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Contains__);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo);
		    DAT_ram_00a57ca2 = '\x01';
		  }
		  iVar2 = Core_Data_Skills_SkillData___ctor
		                    (*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param2 + 0xc),
		                     Method_System_Collections_Generic_HashSet_uint__Contains__);
		  if (iVar2 == 0) {
		    uVar4 = *(undefined4 *)(param1 + 0xc);
		    uVar5 = *(undefined4 *)(param2 + 0x24);
		    param1_00 = *(int **)(param1 + 8);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x80e43e74;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,
		                                  Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo
		                                  ,2);
		code_r0x80e43e74:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar5,uVar4,puVar3[1]);
		  }
		  else {
		    uVar4 = 0;
		  }
		  return uVar4;
		}
		*/

		}

		// Token: 0x04001C21 RID: 7201
		[Token(Token = "0x4001C21")]
		[FieldOffset(Offset = "0x8")]
		private readonly IRequirementValidator _requirementValidator;

		// Token: 0x04001C22 RID: 7202
		[Token(Token = "0x4001C22")]
		[FieldOffset(Offset = "0xC")]
		private readonly UserData _user;

		// Token: 0x04001C23 RID: 7203
		[Token(Token = "0x4001C23")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<int, QuestsTriggerObserver.Quests> _questsByTriggers;

		// Token: 0x04001C24 RID: 7204
		[Token(Token = "0x4001C24")]
		[FieldOffset(Offset = "0x14")]
		private readonly HashSet<uint> _dailyQuestsBlackList;

		// Token: 0x04001C25 RID: 7205
		[Token(Token = "0x4001C25")]
		[FieldOffset(Offset = "0x18")]
		private readonly HashSet<uint> _goalsBlackList;

		// Token: 0x02000890 RID: 2192
		[Token(Token = "0x2000890")]
		public class Quests
		{
			// Token: 0x060033BB RID: 13243 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60033BB")]
			[Address(RVA = "0x83F5", Offset = "0x83F5", VA = "0x83F5")]
			public Quests()
			{
			}

			// Token: 0x04001C26 RID: 7206
			[Token(Token = "0x4001C26")]
			[FieldOffset(Offset = "0x8")]
			public readonly HashSet<DailyQuestsDic> DailyQuestIds;

			// Token: 0x04001C27 RID: 7207
			[Token(Token = "0x4001C27")]
			[FieldOffset(Offset = "0xC")]
			public readonly HashSet<DailyGoalDic> GoalIds;
		}
	}
}
