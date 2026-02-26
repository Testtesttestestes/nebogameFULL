using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Collections.Model.Factories;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.GdEvents.Model.Milestone
{
	// Token: 0x02000757 RID: 1879
	[Token(Token = "0x2000757")]
	public class MilestoneData : IDisposable
	{
		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06002CCF RID: 11471 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CD0 RID: 11472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A4")]
		public GdEventData Owner
		{
			[Token(Token = "0x6002CCF")]
			[Address(RVA = "0x7D55", Offset = "0x7D55", VA = "0x7D55")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CD0")]
			[Address(RVA = "0x7D56", Offset = "0x7D56", VA = "0x7D56")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06002CD1 RID: 11473 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CD2 RID: 11474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A5")]
		public ICollectionDataFactory CollectionDataFactory
		{
			[Token(Token = "0x6002CD1")]
			[Address(RVA = "0x7D57", Offset = "0x7D57", VA = "0x7D57")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CD2")]
			[Address(RVA = "0x7D58", Offset = "0x7D58", VA = "0x7D58")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06002CD3 RID: 11475 RVA: 0x000088F8 File Offset: 0x00006AF8
		// (set) Token: 0x06002CD4 RID: 11476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A6")]
		public bool Selected
		{
			[Token(Token = "0x6002CD3")]
			[Address(RVA = "0x7D59", Offset = "0x7D59", VA = "0x7D59")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002CD4")]
			[Address(RVA = "0x7D5A", Offset = "0x7D5A", VA = "0x7D5A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CD5")]
		[Address(RVA = "0x7D5B", Offset = "0x7D5B", VA = "0x7D5B", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_GdEvents_Model_Milestone_MilestoneData__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a2e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ActivityGroupData___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ActivityGroupData__TypeInfo);
		    DAT_ram_00a5a2e0 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_ActivityGroupData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_ActivityGroupData___ctor__);
		  *(undefined4 *)(param1 + 0x28) = param1_00;
		  *(undefined4 *)(param1 + 0x20) = param4;
		  *(undefined4 *)(param1 + 8) = param3;
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CD6")]
		[Address(RVA = "0x7D5C", Offset = "0x7D5C", VA = "0x7D5C")]
		public MilestoneData(GdEventData evt, GameEventDic.Types.Milestone milestoneDic, ICollectionDataFactory collectionDataFactory)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_GdEvents_Model_Milestone_MilestoneData___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a2e1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_GameEventDic_Types_Milestone_Types_Collection__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    DAT_ram_00a5a2e1 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 8);
		  return *(int *)(*(int *)(iVar1 + 0x18) + 0xc) + *(int *)(*(int *)(iVar1 + 0x10) + 0xc) +
		         *(int *)(*(int *)(iVar1 + 0x1c) + 0xc) + *(int *)(*(int *)(iVar1 + 0x28) + 0xc) +
		         *(int *)(*(int *)(iVar1 + 0x14) + 0xc) + *(int *)(*(int *)(iVar1 + 0x20) + 0xc);
		}
		*/

		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x00008910 File Offset: 0x00006B10
		[Token(Token = "0x6002CD7")]
		[Address(RVA = "0x7D5D", Offset = "0x7D5D", VA = "0x7D5D")]
		public int GetContentStageCount()
		{
		/* --- GHIDRA: GetContentStageCount ---
		/* WARNING: Removing unreachable block (ram,0x811f8fd1) */
		/* WARNING: Removing unreachable block (ram,0x811f8e9b) */
		
		int Gameplay_GdEvents_Model_Milestone_MilestoneData__GetContentStageCount
		              (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  int *piVar9;
		  int iVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a2e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_Milestone_ActivityGroupData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_SelectMany_GameActivityDic_Types_URI__GameActivityData___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_GameActivityData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_GameActivityDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_GameActivityDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_GameActivityDic_Types_URI__IEnumerable_GameActivityData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ActivityTypeDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ActivityGroupData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ActivityGroupData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ActivityTypeDic__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Model_Milestone_MilestoneData___c__DisplayClass21_0__GetActivities_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Model_Milestone_MilestoneData___c__DisplayClass21_0_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Model_Milestone_MilestoneData___c__DisplayClass21_1__GetActivities_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Model_Milestone_MilestoneData___c__DisplayClass21_1_TypeInfo);
		    DAT_ram_00a5a2e2 = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 0x28) + 0xc) != 0) {
		    return *(int *)(param1 + 0x28);
		  }
		  uVar1 = 0;
		  iVar10 = *param2;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xd0);
		        goto code_r0x811f8d07;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811f8d07:
		  iVar10 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(iVar10 + 0x2dc),
		                              Method_Google_Protobuf_Collections_RepeatedField_ActivityTypeDic__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x811f8d3c:
		  do {
		    do {
		      piVar6 = local_4;
		      iVar10 = *local_4;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		            puVar3 = (undefined4 *)(iVar10 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x811f8de2;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x811f8e26:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811f93b9;
		      }
		code_r0x811f8de2:
		      DAT_ram_009d3e38 = 0;
		      iVar10 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811f8e26;
		      if (iVar10 == 0) goto code_r0x811f9402;
		      DAT_ram_009d3e38 = 0;
		      iVar10 = import::env::invoke_ii
		                         (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                          Gameplay_GdEvents_Model_Milestone_MilestoneData___c__DisplayClass21_0_TypeInfo
		                         );
		      piVar6 = local_4;
		      if (DAT_ram_009d3e38 == 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811f93b9;
		      }
		      iVar5 = *local_4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_ActivityTypeDic__TypeInfo == *piVar9) {
		            puVar3 = (undefined4 *)(iVar5 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x811f8f36;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_ActivityTypeDic__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x811f9250:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811f93b9;
		      }
		code_r0x811f8f36:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811f9250;
		      *(undefined4 *)(iVar10 + 8) = uVar4;
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         Gameplay_GdEvents_Model_Milestone_MilestoneData___c__DisplayClass21_1_TypeInfo
		                        );
		      if (DAT_ram_009d3e38 == 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811f93b9;
		      }
		      iVar7 = *param2;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar6 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (Core_Dict_IDictProvider_TypeInfo == *piVar6) {
		            puVar3 = (undefined4 *)(piVar6[1] * 8 + iVar7 + 0xd0);
		            goto code_r0x811f9067;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,param2,
		                          Core_Dict_IDictProvider_TypeInfo,2);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x811f9264:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811f93b9;
		      }
		code_r0x811f9067:
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iii(*puVar3,param2,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811f9264;
		      uVar8 = *(undefined4 *)(iVar7 + 0x2d0);
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Func_GameActivityDic__bool__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x811f926e:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811f93b9;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar4,iVar10,
		                 Method_Gameplay_GdEvents_Model_Milestone_MilestoneData___c__DisplayClass21_0__GetActivities_b__0__
		                 ,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811f926e;
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x226,uVar8,uVar4,
		                         Method_System_Linq_Enumerable_Where_GameActivityDic___);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811f93b9;
		      }
		      *(undefined4 *)(iVar5 + 8) = uVar4;
		      uVar8 = *(undefined4 *)(*(int *)(param1 + 8) + 0x24);
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Func_GameActivityDic_Types_URI__IEnumerable_GameActivityData___TypeInfo
		                        );
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x811f9282:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811f93b9;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x227,uVar4,iVar5,
		                 Method_Gameplay_GdEvents_Model_Milestone_MilestoneData___c__DisplayClass21_1__GetActivities_b__1__
		                 ,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811f9282;
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x28b,uVar8,uVar4,
		                         Method_System_Linq_Enumerable_SelectMany_GameActivityDic_Types_URI__GameActivityData___
		                        );
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811f93b9;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0xd0,uVar4,
		                         Method_System_Linq_Enumerable_ToArray_GameActivityData___);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811f93b9;
		      }
		    } while (*(int *)(iVar7 + 0xc) == 0);
		    uVar4 = *(undefined4 *)(iVar10 + 8);
		    iVar5 = *(int *)(param1 + 0x28);
		    DAT_ram_009d3e38 = 0;
		    iVar10 = import::env::invoke_ii
		                       (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                        Gameplay_GdEvents_Model_Milestone_ActivityGroupData_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811f936a:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811f93b9;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x28c,iVar10,uVar4,iVar5);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811f936a;
		    *(int *)(iVar10 + 0xc) = iVar7;
		    iVar7 = Method_System_Collections_Generic_List_ActivityGroupData__Add__;
		    *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar5 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		      *(uint *)(iVar5 + 0xc) = uVar1 + 1;
		      *(int *)(*(int *)(iVar5 + 8) + uVar1 * 4 + 0x10) = iVar10;
		      goto code_r0x811f8d3c;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar5,iVar10,
		               *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar10 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811f93b9:
		  iVar10 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar10 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    local_c = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 != 1) {
		code_r0x811f9402:
		      DAT_ram_009d3e38 = 0;
		      piVar6 = *local_8;
		      if (piVar6 != (int *)0x0) {
		        uVar1 = 0;
		        iVar10 = *piVar6;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x811f947d;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x811f947d:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      }
		      if (local_c == 0) {
		        return *(undefined4 *)(param1 + 0x28);
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_c);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x28d,&local_c);
		  iVar10 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar10 == 1) {
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

			return 0;
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002CD8")]
		[Address(RVA = "0x7D5E", Offset = "0x7D5E", VA = "0x7D5E")]
		public List<ActivityGroupData> GetActivities(IDictProvider dictProvider)
		{
		/* --- GHIDRA: GetActivities ---
		uint Gameplay_GdEvents_Model_Milestone_MilestoneData__GetActivities
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param2_00;
		  undefined4 param4_00;
		  int iVar3;
		  int *piVar4;
		  int param2_01;
		  
		  param2_01 = 0;
		  iVar1 = 0;
		  if (DAT_ram_00a5a2e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_ArtikulData___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_Model_Milestone_StageContentData_ArtikulData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Model_Milestone_StageContentData_ArtikulData__TypeInfo);
		    DAT_ram_00a5a2e3 = '\x01';
		  }
		  param2_00 = *(int *)(*(int *)(*(int *)(param1 + 8) + 0x10) + 0xc);
		  if ((param2_00 != 0) && (iVar1 = *(int *)(param1 + 0xc), iVar1 == 0)) {
		    uVar2 = Mono_Security_ASN1Convert__ToOid(Core_Data_ArtikulData___TypeInfo,param2_00);
		    param4_00 = *(undefined4 *)(param1 + 0x1c);
		    iVar1 = unnamed_function_1417
		                      (Gameplay_GdEvents_Model_Milestone_StageContentData_ArtikulData__TypeInfo);
		    UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor
		              (iVar1,uVar2,param2,param4_00,
		               Method_Gameplay_GdEvents_Model_Milestone_StageContentData_ArtikulData___ctor__);
		    *(int *)(param1 + 0xc) = iVar1;
		    iVar3 = *(int *)(*(int *)(param1 + 8) + 0x10);
		    if (0 < *(int *)(iVar3 + 0xc)) {
		      do {
		        piVar4 = *(int **)(*(int *)(param1 + 0xc) + 8);
		        uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (iVar3,param2_01,
		                           Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		        iVar1 = func_ii_7944(uVar2,param2,0);
		        if ((iVar1 != 0) &&
		           (iVar3 = func_ii_1082(iVar1,*(undefined4 *)(*piVar4 + 0x20)), iVar3 == 0)) {
		          uVar2 = func_ii_1083();
		          func_ii_1050(uVar2,0);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar4[param2_01 + 4] = iVar1;
		        param2_01 = param2_01 + 1;
		        iVar3 = *(int *)(*(int *)(param1 + 8) + 0x10);
		      } while (param2_01 < *(int *)(iVar3 + 0xc));
		      iVar1 = *(int *)(param1 + 0xc);
		    }
		  }
		  *param3 = iVar1;
		  return (uint)(param2_00 != 0);
		}
		*/

			return null;
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x00008928 File Offset: 0x00006B28
		[Token(Token = "0x6002CD9")]
		[Address(RVA = "0x7D5F", Offset = "0x7D5F", VA = "0x7D5F")]
		public bool TryGetArtikuls(IDictProvider dictProvider, out StageContentData<ArtikulData> artikuls)
		{
		/* --- GHIDRA: TryGetArtikuls ---
		uint Gameplay_GdEvents_Model_Milestone_MilestoneData__TryGetArtikuls
		               (int param1,int *param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  int param2_00;
		  undefined4 uVar6;
		  int *piVar7;
		  int param2_01;
		  int *piVar8;
		  
		  param2_01 = 0;
		  iVar1 = 0;
		  if (DAT_ram_00a5a2e4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_MedalDicWrapper__uint__GetWrapper__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_DictWrappers_Wrappers_MedalDicWrapper___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_Model_Milestone_StageContentData_MedalDicWrapper___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Model_Milestone_StageContentData_MedalDicWrapper__TypeInfo);
		    DAT_ram_00a5a2e4 = '\x01';
		  }
		  param2_00 = *(int *)(*(int *)(*(int *)(param1 + 8) + 0x14) + 0xc);
		  if ((param2_00 != 0) && (iVar1 = *(int *)(param1 + 0x10), iVar1 == 0)) {
		    uVar3 = Mono_Security_ASN1Convert__ToOid
		                      (Core_Dict_DictWrappers_Wrappers_MedalDicWrapper___TypeInfo,param2_00);
		    uVar6 = *(undefined4 *)(param1 + 0x1c);
		    iVar1 = unnamed_function_1417
		                      (Gameplay_GdEvents_Model_Milestone_StageContentData_MedalDicWrapper__TypeInfo)
		    ;
		    UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor
		              (iVar1,uVar3,param2,uVar6,
		               Method_Gameplay_GdEvents_Model_Milestone_StageContentData_MedalDicWrapper___ctor__);
		    *(int *)(param1 + 0x10) = iVar1;
		    if (0 < *(int *)(*(int *)(*(int *)(param1 + 8) + 0x14) + 0xc)) {
		      do {
		        piVar7 = *(int **)(*(int *)(param1 + 0x10) + 8);
		        iVar1 = *param2;
		        if (*(ushort *)(iVar1 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar1 + 0x58) + uVar2 * 8);
		            if (Core_Dict_IDictProvider_TypeInfo == *piVar8) {
		              puVar4 = (uint *)(piVar8[1] * 8 + iVar1 + 0xd8);
		              goto code_r0x811f9766;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar1 + 0xb6) != uVar2);
		        }
		        puVar4 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,3);
		code_r0x811f9766:
		        iVar1 = (**(code **)((ulonglong)*puVar4 * 4))(param2,puVar4[1]);
		        uVar6 = *(undefined4 *)(iVar1 + 0xc);
		        uVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(*(int *)(param1 + 8) + 0x14),param2_01,
		                           Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		        iVar1 = func_ii_7730(uVar6,uVar3,
		                             Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_MedalDicWrapper__uint__GetWrapper__
		                            );
		        if ((iVar1 != 0) &&
		           (iVar5 = func_ii_1082(iVar1,*(undefined4 *)(*piVar7 + 0x20)), iVar5 == 0)) {
		          uVar3 = func_ii_1083();
		          func_ii_1050(uVar3,0);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar7[param2_01 + 4] = iVar1;
		        param2_01 = param2_01 + 1;
		      } while (param2_01 < *(int *)(*(int *)(*(int *)(param1 + 8) + 0x14) + 0xc));
		      iVar1 = *(int *)(param1 + 0x10);
		    }
		  }
		  *param3 = iVar1;
		  return (uint)(param2_00 != 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x00008940 File Offset: 0x00006B40
		[Token(Token = "0x6002CDA")]
		[Address(RVA = "0x7D60", Offset = "0x7D60", VA = "0x7D60")]
		public bool TryGetMedals(IDictProvider dictProvider, out StageContentData<MedalDicWrapper> medals)
		{
		/* --- GHIDRA: TryGetMedals ---
		uint Gameplay_GdEvents_Model_Milestone_MilestoneData__TryGetMedals
		               (int param1,int *param2,int *param3,undefined4 param4)
		
		{
		  int param1_00;
		  uint *puVar1;
		  int param2_00;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  uint uVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int *piVar8;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a5a2e5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprDicWrapper__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprDicWrapper__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprDicWrapper___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AprDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_Model_Milestone_StageContentData_AprDicWrapper___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Model_Milestone_StageContentData_AprDicWrapper__TypeInfo);
		    DAT_ram_00a5a2e5 = '\x01';
		  }
		  if (*(int *)(*(int *)(*(int *)(param1 + 8) + 0x18) + 0xc) == 0) {
		    *param3 = 0;
		    return 0;
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_AprDicWrapper__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_AprDicWrapper___ctor__);
		  if (0 < *(int *)(*(int *)(*(int *)(param1 + 8) + 0x18) + 0xc)) {
		    do {
		      iVar7 = *param2;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar5 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar5 * 8);
		          if (Core_Dict_IDictProvider_TypeInfo == *piVar8) {
		            puVar1 = (uint *)(piVar8[1] * 8 + iVar7 + 0xd8);
		            goto code_r0x811f9913;
		          }
		          uVar5 = uVar5 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar5);
		      }
		      puVar1 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,3);
		code_r0x811f9913:
		      iVar7 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		      uVar6 = *(undefined4 *)(iVar7 + 0x14);
		      uVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(*(int *)(param1 + 8) + 0x18),iVar4,
		                         Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		      param2_00 = func_ii_7730(uVar6,uVar3,
		                               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		                              );
		      iVar2 = Gameplay_Aprs_Model_AprData__GetAppropriateApr
		                        (*(undefined4 *)(param2_00 + 0x10),
		                         *(undefined4 *)(*(int *)(param1 + 0x1c) + 0x1c),0);
		      iVar7 = Method_System_Collections_Generic_List_AprDicWrapper__Add__;
		      if (iVar2 != 0) {
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar5 = *(uint *)(param1_00 + 0xc);
		        if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		          *(int *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = param2_00;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_00,param2_00,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		        }
		      }
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(*(int *)(*(int *)(param1 + 8) + 0x18) + 0xc));
		  }
		  uVar3 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                    (param1_00,Method_System_Collections_Generic_List_AprDicWrapper__ToArray__);
		  uVar6 = *(undefined4 *)(param1 + 0x1c);
		  iVar4 = unnamed_function_1417
		                    (Gameplay_GdEvents_Model_Milestone_StageContentData_AprDicWrapper__TypeInfo);
		  UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor
		            (iVar4,uVar3,param2,uVar6,
		             Method_Gameplay_GdEvents_Model_Milestone_StageContentData_AprDicWrapper___ctor__);
		  *param3 = iVar4;
		  return (uint)(*(int *)(*(int *)(iVar4 + 8) + 0xc) != 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x00008958 File Offset: 0x00006B58
		[Token(Token = "0x6002CDB")]
		[Address(RVA = "0x7D61", Offset = "0x7D61", VA = "0x7D61")]
		public bool TryGetAvatars(IDictProvider dictProvider, out StageContentData<AprDicWrapper> avatars)
		{
		/* --- GHIDRA: TryGetAvatars ---
		uint Gameplay_GdEvents_Model_Milestone_MilestoneData__TryGetAvatars
		               (int param1,int *param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int param2_00;
		  undefined4 param4_00;
		  int iVar5;
		  int *piVar6;
		  int param2_01;
		  int iVar7;
		  int *piVar8;
		  
		  param2_01 = 0;
		  iVar1 = 0;
		  if (DAT_ram_00a5a2e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_CollectionData___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_Factories_ICollectionDataFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_GameEventDic_Types_Milestone_Types_Collection__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_GameEventDic_Types_Milestone_Types_Collection__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_Model_Milestone_StageContentData_CollectionData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Model_Milestone_StageContentData_CollectionData__TypeInfo);
		    DAT_ram_00a5a2e6 = '\x01';
		  }
		  param2_00 = *(int *)(*(int *)(*(int *)(param1 + 8) + 0x1c) + 0xc);
		  if ((param2_00 != 0) && (iVar1 = *(int *)(param1 + 0x14), iVar1 == 0)) {
		    uVar3 = Mono_Security_ASN1Convert__ToOid(Core_Data_CollectionData___TypeInfo,param2_00);
		    param4_00 = *(undefined4 *)(param1 + 0x1c);
		    iVar1 = unnamed_function_1417
		                      (Gameplay_GdEvents_Model_Milestone_StageContentData_CollectionData__TypeInfo);
		    UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor
		              (iVar1,uVar3,param2,param4_00,
		               Method_Gameplay_GdEvents_Model_Milestone_StageContentData_CollectionData___ctor__);
		    *(int *)(param1 + 0x14) = iVar1;
		    iVar5 = *(int *)(*(int *)(*(int *)(param1 + 8) + 0x1c) + 0xc);
		    if (0 < iVar5) {
		      do {
		        iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(*(int *)(param1 + 8) + 0x1c),param2_01,
		                           Method_Google_Protobuf_Collections_RepeatedField_GameEventDic_Types_Milestone_Types_Collection__get_Item__
		                          );
		        iVar7 = *param2;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar6 = (int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8);
		            if (Core_Dict_IDictProvider_TypeInfo == *piVar6) {
		              puVar4 = (uint *)(piVar6[1] * 8 + iVar7 + 0xd0);
		              goto code_r0x811f9b57;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		        }
		        puVar4 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811f9b57:
		        uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(param2,puVar4[1]);
		        uVar3 = func_ii_6816(uVar3,*(undefined4 *)(iVar1 + 0xc),0);
		        piVar6 = *(int **)(param1 + 0x20);
		        iVar7 = *piVar6;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8);
		            if (Gameplay_Collections_Model_Factories_ICollectionDataFactory_TypeInfo == *piVar8) {
		              puVar4 = (uint *)(iVar7 + piVar8[1] * 8 + 0xc0);
		              goto code_r0x811f9bdf;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar6,
		                                      Gameplay_Collections_Model_Factories_ICollectionDataFactory_TypeInfo
		                                      ,0);
		code_r0x811f9bdf:
		        iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,uVar3,puVar4[1]);
		        Gameplay_Collections_View_CollectionIconView__Init(iVar7,*(undefined4 *)(iVar1 + 0x10),0);
		        piVar6 = *(int **)(*(int *)(param1 + 0x14) + 8);
		        if ((iVar7 != 0) &&
		           (iVar1 = func_ii_1082(iVar7,*(undefined4 *)(*piVar6 + 0x20)), iVar1 == 0)) {
		          uVar3 = func_ii_1083();
		          func_ii_1050(uVar3,0);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar6[param2_01 + 4] = iVar7;
		        param2_01 = param2_01 + 1;
		      } while (param2_01 != iVar5);
		      iVar1 = *(int *)(param1 + 0x14);
		    }
		  }
		  *param3 = iVar1;
		  return (uint)(param2_00 != 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x00008970 File Offset: 0x00006B70
		[Token(Token = "0x6002CDC")]
		[Address(RVA = "0x7D62", Offset = "0x7D62", VA = "0x7D62")]
		public bool TryGetCollections(IDictProvider dictProvider, out StageContentData<CollectionData> collections)
		{
		/* --- GHIDRA: TryGetCollections ---
		uint Gameplay_GdEvents_Model_Milestone_MilestoneData__TryGetCollections
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int param2_01;
		  
		  iVar2 = 0;
		  param2_01 = 0;
		  if (DAT_ram_00a5a2e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_ArtikulStackSize___);
		    Mono_Security_ASN1__get_Item(&Core_Data_MonsterData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_MonsterData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_Model_Milestone_StageContentData_MonsterData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Model_Milestone_StageContentData_MonsterData__TypeInfo);
		    DAT_ram_00a5a2e7 = '\x01';
		  }
		  param2_00 = *(int *)(*(int *)(*(int *)(param1 + 8) + 0x20) + 0xc);
		  if ((param2_00 != 0) && (iVar2 = *(int *)(param1 + 0x18), iVar2 == 0)) {
		    uVar1 = Mono_Security_ASN1Convert__ToOid(Core_Data_MonsterData___TypeInfo,param2_00);
		    uVar3 = *(undefined4 *)(param1 + 0x1c);
		    iVar2 = unnamed_function_1417
		                      (Gameplay_GdEvents_Model_Milestone_StageContentData_MonsterData__TypeInfo);
		    UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor
		              (iVar2,uVar1,param2,uVar3,
		               Method_Gameplay_GdEvents_Model_Milestone_StageContentData_MonsterData___ctor__);
		    *(int *)(param1 + 0x18) = iVar2;
		    iVar4 = *(int *)(*(int *)(param1 + 8) + 0x20);
		    if (0 < *(int *)(iVar4 + 0xc)) {
		      do {
		        uVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (iVar4,param2_01,
		                           Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		        iVar2 = Method_System_Array_Empty_ArtikulStackSize___;
		        iVar4 = *(int *)(Method_System_Array_Empty_ArtikulStackSize___ + 0x1c);
		        if (iVar4 == 0) {
		          System_ReadOnlySpan_char___GetPinnableReference
		                    (Method_System_Array_Empty_ArtikulStackSize___);
		          iVar4 = *(int *)(iVar2 + 0x1c);
		        }
		        iVar4 = *(int *)(iVar4 + 8);
		        if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		          iVar4 = func_ii_1079(iVar4);
		        }
		        if (*(int *)(iVar4 + 0x74) == 0) {
		          func_ii_306000(iVar4);
		        }
		        iVar2 = *(int *)(*(int *)(iVar2 + 0x1c) + 8);
		        if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		          iVar2 = func_ii_1079(iVar2);
		        }
		        uVar3 = **(undefined4 **)(iVar2 + 0x5c);
		        if (*(int *)(Core_Data_MonsterData_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_Data_MonsterData_TypeInfo);
		        }
		        iVar2 = Core_Data_MonsterData__Create(uVar1,uVar3,param2,0);
		        piVar5 = *(int **)(*(int *)(param1 + 0x18) + 8);
		        if ((iVar2 != 0) &&
		           (iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar5 + 0x20)), iVar4 == 0)) {
		          uVar1 = func_ii_1083();
		          func_ii_1050(uVar1,0);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar5[param2_01 + 4] = iVar2;
		        param2_01 = param2_01 + 1;
		        iVar4 = *(int *)(*(int *)(param1 + 8) + 0x20);
		      } while (param2_01 < *(int *)(iVar4 + 0xc));
		      iVar2 = *(int *)(param1 + 0x18);
		    }
		  }
		  *param3 = iVar2;
		  return (uint)(param2_00 != 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x00008988 File Offset: 0x00006B88
		[Token(Token = "0x6002CDD")]
		[Address(RVA = "0x7D63", Offset = "0x7D63", VA = "0x7D63")]
		public bool TryGetMonster(IDictProvider dictProvider, out StageContentData<MonsterData> monsters)
		{
		/* --- GHIDRA: TryGetMonster ---
		uint Gameplay_GdEvents_Model_Milestone_MilestoneData__TryGetMonster
		               (int param1,int *param2,int param3,int *param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  int param2_00;
		  undefined4 uVar5;
		  int param2_01;
		  int *piVar6;
		  
		  param2_01 = 0;
		  if (DAT_ram_00a5a2e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_SocialGiftDic___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_Model_Milestone_StageContentData_SocialGiftDic___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Model_Milestone_StageContentData_SocialGiftDic__TypeInfo);
		    DAT_ram_00a5a2e8 = '\x01';
		  }
		  param2_00 = *(int *)(*(int *)(*(int *)(param1 + 8) + 0x28) + 0xc);
		  if (param2_00 == 0) {
		    *param4 = 0;
		  }
		  else {
		    uVar2 = Mono_Security_ASN1Convert__ToOid(Protocol_Dic_SocialGiftDic___TypeInfo,param2_00);
		    uVar5 = *(undefined4 *)(param1 + 0x1c);
		    iVar3 = unnamed_function_1417
		                      (Gameplay_GdEvents_Model_Milestone_StageContentData_SocialGiftDic__TypeInfo);
		    UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor
		              (iVar3,uVar2,param2,uVar5,
		               Method_Gameplay_GdEvents_Model_Milestone_StageContentData_SocialGiftDic___ctor__);
		    *param4 = iVar3;
		    iVar3 = *(int *)(*(int *)(param1 + 8) + 0x28);
		    if (0 < *(int *)(iVar3 + 0xc)) {
		      do {
		        uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (iVar3,param2_01,
		                           Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		        iVar3 = *param2;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar6 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		            if (Core_Dict_IDictProvider_TypeInfo == *piVar6) {
		              puVar4 = (uint *)(piVar6[1] * 8 + iVar3 + 0xd0);
		              goto code_r0x811f9f51;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		        }
		        puVar4 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811f9f51:
		        uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(param2,puVar4[1]);
		        iVar3 = Core_Extensions_Dict_DictExt__GetClanBuildingLevel(uVar5,uVar2,0);
		        if ((*(char *)(iVar3 + 0x14) == '\0') ||
		           (*(char *)(*(int *)(*(int *)(param1 + 0x1c) + 0x10) + 0x10) == '\0')) {
		          iVar3 = param3;
		        }
		        *(int *)(*(int *)(*param4 + 8) + param2_01 * 4 + 0x10) = iVar3;
		        param2_01 = param2_01 + 1;
		        iVar3 = *(int *)(*(int *)(param1 + 8) + 0x28);
		      } while (param2_01 < *(int *)(iVar3 + 0xc));
		    }
		  }
		  return (uint)(param2_00 != 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x000089A0 File Offset: 0x00006BA0
		[Token(Token = "0x6002CDE")]
		[Address(RVA = "0x7D64", Offset = "0x7D64", VA = "0x7D64")]
		public bool TryGetGifts(IDictProvider dictProvider, SocialGiftDic defaultGiftDic, out StageContentData<SocialGiftDic> gifts)
		{
			return default(bool);
		}

		// Token: 0x0400189F RID: 6303
		[Token(Token = "0x400189F")]
		[FieldOffset(Offset = "0x8")]
		public readonly GameEventDic.Types.Milestone MilestoneDic;

		// Token: 0x040018A0 RID: 6304
		[Token(Token = "0x40018A0")]
		[FieldOffset(Offset = "0xC")]
		private StageContentData<ArtikulData> _artikuls;

		// Token: 0x040018A1 RID: 6305
		[Token(Token = "0x40018A1")]
		[FieldOffset(Offset = "0x10")]
		private StageContentData<MedalDicWrapper> _medals;

		// Token: 0x040018A2 RID: 6306
		[Token(Token = "0x40018A2")]
		[FieldOffset(Offset = "0x14")]
		private StageContentData<CollectionData> _collections;

		// Token: 0x040018A3 RID: 6307
		[Token(Token = "0x40018A3")]
		[FieldOffset(Offset = "0x18")]
		private StageContentData<MonsterData> _monsters;

		// Token: 0x040018A7 RID: 6311
		[Token(Token = "0x40018A7")]
		[FieldOffset(Offset = "0x28")]
		private List<ActivityGroupData> _activity;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Selected ---
		void Gameplay_GdEvents_Model_Milestone_MilestoneData__set_Selected(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param3;
		  
		  if (DAT_ram_00a5a2df == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ActivityGroupData__Clear__)
		    ;
		    DAT_ram_00a5a2df = '\x01';
		  }
		  *(undefined8 *)(param1 + 0xc) = 0;
		  *(undefined8 *)(param1 + 0x1c) = 0;
		  *(undefined8 *)(param1 + 0x14) = 0;
		  iVar1 = *(int *)(param1 + 0x28);
		  param3 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < param3) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,param3,0);
		  }
		  return;
		}
		*/

}
