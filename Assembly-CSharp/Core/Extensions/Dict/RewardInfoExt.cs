using System;
using System.Collections.Generic;
using Core.Data;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F9F RID: 3999
	[Token(Token = "0x2000F9F")]
	public static class RewardInfoExt
	{
		// Token: 0x06005FD6 RID: 24534 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FD6")]
		[Address(RVA = "0xAC0D", Offset = "0xAC0D", VA = "0xAC0D")]
		public static ResourceSet ExtractResourceSet(this RewardInfo rewardInfo)
		{
		/* --- GHIDRA: ExtractResourceSet ---
		undefined4
		Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a5a342 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IRewardInfo__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IRewardInfo___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IRewardInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_RewardData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_RewardInfoDecorator_TypeInfo);
		    DAT_ram_00a5a342 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_IRewardInfo__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_IRewardInfo___ctor__);
		  uVar2 = unnamed_function_1417(Core_Data_Decorators_RewardInfoDecorator_TypeInfo);
		  Core_Data_Effect_EffectDescription__FormatUserSkillValue(uVar2,param1,0);
		  iVar1 = Method_System_Collections_Generic_List_IRewardInfo__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = unnamed_function_1417(Core_Data_RewardData_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(uVar2,param1_00,0);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06005FD7 RID: 24535 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FD7")]
		[Address(RVA = "0xAC0E", Offset = "0xAC0E", VA = "0xAC0E")]
		public static RewardData ToRewardData(this RewardInfo rewardInfo)
		{
		/* --- GHIDRA: ToRewardData ---
		/* WARNING: Removing unreachable block (ram,0x8120713a) */
		
		undefined4 Core_Extensions_Dict_RewardInfoExt__ToRewardData(undefined4 param1)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 *puVar5;
		  undefined4 uVar6;
		  int local_38;
		  undefined8 *local_34;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a343 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_HashSet_RewardTypes___Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_Enumerator_RewardTypes__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_HashSet_RewardTypes___MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_Enumerator_RewardTypes__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_Enumerator_RewardTypes__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_HashSet_RewardTypes___get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_RewardTypes__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_RewardTypes__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_RewardTypes___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_RewardTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_HashSet_RewardTypes___GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a5a343 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		  }
		  if (*(int *)(*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x5c) + 4) == 0) {
		    uVar6 = unnamed_function_1417(System_Collections_Generic_HashSet_RewardTypes__TypeInfo);
		    System_Collections_Generic_HashSet_int___get_Count
		              (uVar6,Method_System_Collections_Generic_HashSet_RewardTypes___ctor__);
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    puVar5 = *(undefined4 **)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x5c);
		    puVar5[1] = uVar6;
		    System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		              (&local_30,*puVar5,
		               Method_System_Collections_Generic_List_HashSet_RewardTypes___GetEnumerator__);
		    local_8 = local_28;
		    local_10 = CONCAT44(puStack_2c,local_30);
		    local_38 = 0;
		    local_34 = &local_10;
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_HashSet_RewardTypes___MoveNext__
		                        );
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar3 = global_1;
		code_r0x812071ea:
		        iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar2 == iVar3) {
		          piVar4 = (int *)import::env::__cxa_begin_catch(uVar6);
		          iVar2 = *piVar4;
		          DAT_ram_009d3e38 = 0;
		          local_38 = iVar2;
		          import::env::invoke_v(0x123);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 != 1) {
		            if (iVar2 != 0) {
		              System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		              do {
		                halt_trap();
		              } while( true );
		            }
		            goto code_r0x81207297;
		          }
		          uVar6 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2aa,&local_38);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 != 1) {
		          import::env::__resumeException(uVar6);
		          do {
		            halt_trap();
		          } while( true );
		        }
		code_r0x8120728d:
		        DAT_ram_009d3e38 = 0;
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar2 == 0) goto code_r0x81207297;
		      DAT_ram_009d3e38 = 0;
		      Sirenix_Utilities_TypeExtensions__AreGenericConstraintsSatisfiedBy
		                (&local_30,local_8._4_4_,
		                 Method_System_Collections_Generic_HashSet_RewardTypes__GetEnumerator__);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar3 = global_1;
		        goto code_r0x812071ea;
		      }
		      local_18 = local_28;
		      local_20 = CONCAT44(puStack_2c,local_30);
		      local_30 = 0;
		      puStack_2c = &local_20;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2a6,&local_20,
		                           Method_System_Collections_Generic_HashSet_Enumerator_RewardTypes__MoveNext__
		                          );
		        if (DAT_ram_009d3e38 == 1) break;
		        if (iVar3 == 0) {
		          iVar2 = 3;
		          iVar3 = 0;
		          goto code_r0x8120710e;
		        }
		        uVar6 = local_18._4_4_;
		        if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) break;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_iiii
		                  (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2a7,
		                   *(undefined4 *)(*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x5c) + 4)
		                   ,uVar6,Method_System_Collections_Generic_HashSet_RewardTypes__Add__);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar3 != iVar2) {
		code_r0x812071a7:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2a9,&local_30);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) goto code_r0x8120728d;
		        goto code_r0x812071ea;
		      }
		      piVar4 = (int *)import::env::__cxa_begin_catch(uVar6);
		      iVar3 = *piVar4;
		      iVar2 = 0;
		      DAT_ram_009d3e38 = 0;
		      local_30 = iVar3;
		      import::env::invoke_v(0x123);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar3 = global_1;
		        goto code_r0x812071a7;
		      }
		code_r0x8120710e:
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 != 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar3);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar3 = global_1;
		        goto code_r0x812071ea;
		      }
		    } while ((iVar2 == 0) || (((iVar2 != 1 && (iVar2 != 2)) && (iVar2 == 3))));
		    uVar6 = 0;
		  }
		  else {
		code_r0x81207297:
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    uVar6 = *(undefined4 *)(*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x5c) + 4);
		  }
		  return uVar6;
		}
		*/

			return null;
		}

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x06005FD8 RID: 24536 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012D1")]
		private static HashSet<RewardTypes> AllGroupedRewardTypes
		{
			[Token(Token = "0x6005FD8")]
			[Address(RVA = "0xAC0F", Offset = "0xAC0F", VA = "0xAC0F")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005FD9 RID: 24537 RVA: 0x00011928 File Offset: 0x0000FB28
		[Token(Token = "0x6005FD9")]
		[Address(RVA = "0xAC10", Offset = "0xAC10", VA = "0xAC10")]
		private static int GetGroupIndex(RewardTypes rewardType)
		{
		/* --- GHIDRA: GetGroupIndex ---
		undefined4 Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(int *param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  uint uVar6;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  
		  iVar7 = 0;
		  if (DAT_ram_00a5a345 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__RewardData__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__RewardData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__RewardData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__RewardData__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_int__RewardData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_RewardTypes__Contains__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_RewardInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_RewardInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IRewardInfo__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_RewardData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_RewardInfoDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a5a345 = '\x01';
		  }
		  iVar8 = *param1;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_RewardInfo__TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar6 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x812074de;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(param1,System_Collections_Generic_ICollection_RewardInfo__TypeInfo,0
		                               );
		code_r0x812074de:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1,puVar1[1]);
		  iVar8 = unnamed_function_1417(System_Collections_Generic_List_RewardData__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (iVar8,uVar2,Method_System_Collections_Generic_List_RewardData___ctor__);
		  uVar2 = unnamed_function_1417(System_Collections_Generic_Dictionary_int__RewardData__TypeInfo);
		  System_Collections_Generic_Dictionary_int__TMP_ResourceManager_FontAssetRef___set_Item
		            (uVar2,Method_System_Collections_Generic_Dictionary_int__RewardData___ctor__);
		  do {
		    iVar9 = *param1;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar6 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar6 * 8);
		        if (System_Collections_Generic_ICollection_RewardInfo__TypeInfo == *piVar10) {
		          puVar1 = (uint *)(iVar9 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x8120758c;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar6);
		    }
		    puVar1 = (uint *)func_ii_1080(param1,System_Collections_Generic_ICollection_RewardInfo__TypeInfo
		                                  ,0);
		code_r0x8120758c:
		    iVar9 = (**(code **)((ulonglong)*puVar1 * 4))(param1,puVar1[1]);
		    if (iVar9 <= iVar7) {
		      uVar2 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                        (iVar8,Method_System_Collections_Generic_List_RewardData__ToArray__);
		      return uVar2;
		    }
		    iVar9 = *param1;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar6 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar6 * 8);
		        if (System_Collections_Generic_IList_RewardInfo__TypeInfo == *piVar10) {
		          puVar1 = (uint *)(iVar9 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x8120760b;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar6);
		    }
		    puVar1 = (uint *)func_ii_1080(param1,System_Collections_Generic_IList_RewardInfo__TypeInfo,0);
		code_r0x8120760b:
		    iVar9 = (**(code **)((ulonglong)*puVar1 * 4))(param1,iVar7,puVar1[1]);
		    uVar5 = *(undefined4 *)(iVar9 + 0xc);
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_RewardInfoExt__ToRewardData(uVar5);
		    iVar4 = Core_Data_Skills_SkillData___ctor
		                      (uVar3,uVar5,Method_System_Collections_Generic_HashSet_RewardTypes__Contains__
		                      );
		    if (iVar4 == 0) {
		      if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		      }
		      uVar5 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(iVar9,uVar5);
		      iVar9 = Method_System_Collections_Generic_List_RewardData__Add__;
		      *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		      uVar6 = *(uint *)(iVar8 + 0xc);
		      if (uVar6 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		        *(uint *)(iVar8 + 0xc) = uVar6 + 1;
		        *(undefined4 *)(*(int *)(iVar8 + 8) + uVar6 * 4 + 0x10) = uVar5;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (iVar8,uVar5,*(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		      }
		    }
		    else {
		      if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		      }
		      uVar5 = Core_Extensions_Dict_RewardInfoExt__get_AllGroupedRewardTypes(uVar5,uVar5);
		      iVar4 = GAFInternal_Core_GAFSetSequenceEvent__subscribe
		                        (uVar2,uVar5,
		                         Method_System_Collections_Generic_Dictionary_int__RewardData__ContainsKey__
		                        );
		      if (iVar4 == 0) {
		        if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		        }
		        uVar3 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(iVar9,uVar5);
		        Gameplay_Inventory_View_Info_InfoBox_TitleIconLoaderValueRow__set_Value
		                  (uVar2,uVar5,uVar3,
		                   Method_System_Collections_Generic_Dictionary_int__RewardData__set_Item__);
		        uVar5 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                          (uVar2,uVar5,
		                           Method_System_Collections_Generic_Dictionary_int__RewardData__get_Item__)
		        ;
		        iVar9 = Method_System_Collections_Generic_List_RewardData__Add__;
		        *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		        uVar6 = *(uint *)(iVar8 + 0xc);
		        if (uVar6 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		          *(uint *)(iVar8 + 0xc) = uVar6 + 1;
		          *(undefined4 *)(*(int *)(iVar8 + 8) + uVar6 * 4 + 0x10) = uVar5;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar8,uVar5,*(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		        }
		      }
		      else {
		        iVar4 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                          (uVar2,uVar5,
		                           Method_System_Collections_Generic_Dictionary_int__RewardData__get_Item__)
		        ;
		        iVar4 = *(int *)(iVar4 + 8);
		        uVar5 = unnamed_function_1417(Core_Data_Decorators_RewardInfoDecorator_TypeInfo);
		        Core_Data_Effect_EffectDescription__FormatUserSkillValue(uVar5,iVar9,0);
		        iVar9 = Method_System_Collections_Generic_List_IRewardInfo__Add__;
		        *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		        uVar6 = *(uint *)(iVar4 + 0xc);
		        if (uVar6 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		          *(uint *)(iVar4 + 0xc) = uVar6 + 1;
		          *(undefined4 *)(*(int *)(iVar4 + 8) + uVar6 * 4 + 0x10) = uVar5;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar4,uVar5,*(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		        }
		      }
		    }
		    iVar7 = iVar7 + 1;
		  } while( true );
		}
		*/

			return 0;
		}

		// Token: 0x06005FDA RID: 24538 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FDA")]
		[Address(RVA = "0xAC11", Offset = "0xAC11", VA = "0xAC11")]
		public static RewardData[] ToRewardDataArray(this IList<RewardInfo> rewards)
		{
		/* --- GHIDRA: ToRewardDataArray ---
		int Core_Extensions_Dict_RewardInfoExt__ToRewardDataArray
		              (undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  uint *puVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a5a346 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_RewardInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__GetEnumerator__);
		    DAT_ram_00a5a346 = '\x01';
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (param1,
		                              Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar3 = local_4;
		    iVar5 = *local_4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar2 = (undefined4 *)(iVar5 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x81207940;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81207a6c:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81207a7e:
		      iVar6 = global_1;
		      iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar6 == iVar5) {
		        piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		        iVar6 = *piVar3;
		        iVar5 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_c = iVar6;
		        import::env::invoke_v(0x123);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 != 1) break;
		        param1_00 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2ab,&local_c);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
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
		code_r0x81207940:
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii(*puVar2,piVar3,puVar2[1]);
		    piVar3 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81207a6c;
		    if (iVar5 == 0) {
		      iVar5 = 0;
		      break;
		    }
		    iVar5 = *local_4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_RewardInfo__TypeInfo == *piVar7) {
		          puVar2 = (undefined4 *)(iVar5 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x81207a1a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_RewardInfo__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81207a76:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81207a7e;
		    }
		code_r0x81207a1a:
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii(*puVar2,piVar3,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81207a76;
		  } while (*(int *)(iVar5 + 0xc) != param2);
		  piVar3 = local_4;
		  DAT_ram_009d3e38 = 0;
		  if (local_4 != (int *)0x0) {
		    uVar1 = 0;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81207b43;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81207b43:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		  }
		  if (iVar6 == 0) {
		    return iVar5;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06005FDB RID: 24539 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FDB")]
		[Address(RVA = "0xAC12", Offset = "0xAC12", VA = "0xAC12")]
		public static RewardInfo GetRewardInfoByType(this RepeatedField<RewardInfo> rewards, RewardTypes rewardType)
		{
		/* --- GHIDRA: GetRewardInfoByType ---
		void Core_Extensions_Dict_RewardInfoExt__GetRewardInfoByType(undefined4 param1)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 param1_01;
		  uint uVar2;
		  
		  if (DAT_ram_00a5a347 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_RewardTypes__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_RewardTypes___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_RewardTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_HashSet_RewardTypes___Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_HashSet_RewardTypes____ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_HashSet_RewardTypes___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a5a347 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_HashSet_RewardTypes___TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_HashSet_RewardTypes____ctor__);
		  param1_01 = unnamed_function_1417(System_Collections_Generic_HashSet_RewardTypes__TypeInfo);
		  System_Collections_Generic_HashSet_int___get_Count
		            (param1_01,Method_System_Collections_Generic_HashSet_RewardTypes___ctor__);
		  System_Collections_Generic_HashSet_Enumerator_Int32Enum___MoveNext
		            (param1_01,4,Method_System_Collections_Generic_HashSet_RewardTypes__Add__);
		  System_Collections_Generic_HashSet_Enumerator_Int32Enum___MoveNext
		            (param1_01,0xe,Method_System_Collections_Generic_HashSet_RewardTypes__Add__);
		  iVar1 = Method_System_Collections_Generic_List_HashSet_RewardTypes___Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param1_01;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  **(int **)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x5c) = param1_00;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04003339 RID: 13113
		[Token(Token = "0x4003339")]
		[FieldOffset(Offset = "0x0")]
		public static List<HashSet<RewardTypes>> RewardInfoSetGroups;

		// Token: 0x0400333A RID: 13114
		[Token(Token = "0x400333A")]
		[FieldOffset(Offset = "0x4")]
		private static HashSet<RewardTypes> _allGroupedRewardTypes;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_AllGroupedRewardTypes ---
		undefined4
		Core_Extensions_Dict_RewardInfoExt__get_AllGroupedRewardTypes(undefined4 param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5a344 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_RewardTypes__Contains__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_HashSet_RewardTypes___get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_HashSet_RewardTypes___get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a5a344 = '\x01';
		  }
		  param2_00 = 0;
		  while( true ) {
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    iVar1 = **(int **)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x5c);
		    if (*(int *)(iVar1 + 0xc) <= param2_00) {
		      return 0xffffffff;
		    }
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		      iVar1 = **(int **)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x5c);
		    }
		    param1_00 = System_Linq_Enumerable__ToList_object_
		                          (iVar1,param2_00,
		                           Method_System_Collections_Generic_List_HashSet_RewardTypes___get_Item__);
		    iVar1 = Core_Data_Skills_SkillData___ctor
		                      (param1_00,param1,
		                       Method_System_Collections_Generic_HashSet_RewardTypes__Contains__);
		    if (iVar1 != 0) break;
		    param2_00 = param2_00 + 1;
		  }
		  return param2_00;
		}
		*/


		/* --- GHIDRA: .cctor ---
		undefined4 Core_Extensions_Dict_RewardInfoExt___cctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x20),0x9d,0);
		  return *(undefined4 *)(iVar1 + 0x10);
		}
		*/

}
