using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Consts;
using UnityEngine;

namespace UI.Rewards
{
	// Token: 0x02000197 RID: 407
	[Token(Token = "0x2000197")]
	public class RewardsRender : AbstractRewardsRender
	{
		// Token: 0x140000E2 RID: 226
		// (add) Token: 0x06000B54 RID: 2900 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000B55 RID: 2901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000E2")]
		public event Action OnDropProcessCompleteEvent
		{
			[Token(Token = "0x6000B54")]
			[Address(RVA = "0x5E72", Offset = "0x5E72", VA = "0x5E72")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000B55")]
			[Address(RVA = "0x5E73", Offset = "0x5E73", VA = "0x5E73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x5E74", Offset = "0x5E74", VA = "0x5E74")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void UI_Rewards_RewardsRender__Start(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x38),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)*(byte *)(param1 + 0x3c),0);
		  return;
		}
		*/

		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x5E75", Offset = "0x5E75", VA = "0x5E75")]
		private void OnValidate()
		{
		/* --- GHIDRA: OnValidate ---
		int UI_Rewards_RewardsRender__OnValidate(undefined4 param1,int param2,int param3,undefined4 param4)
		
		{
		  int param2_00;
		  int param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  int param1_01;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 param1_02;
		  uint uVar5;
		  int param2_01;
		  
		  param2_01 = 0;
		  if (DAT_ram_00a59a0e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Contains_RewardTypes___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_List_RewardData___Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_List_RewardData____ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_List_RewardData___get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_List_RewardData___get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_List_RewardData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_RewardData__TypeInfo);
		    DAT_ram_00a59a0e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param2 + 0xc);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_List_RewardData___TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,uVar3,Method_System_Collections_Generic_List_List_RewardData____ctor__);
		  iVar4 = *(int *)(param2 + 0xc);
		  if (0 < iVar4) {
		    do {
		      uVar3 = System_Linq_Enumerable__ToList_object_
		                        (param2,param2_01,
		                         Method_System_Collections_Generic_List_RewardData__get_Item__);
		      param2_00 = 0;
		      if (0 < *(int *)(param3 + 0xc)) {
		        do {
		          if (*(int *)(param1_00 + 0xc) + -1 < param2_00) {
		            uVar1 = unnamed_function_1417(System_Collections_Generic_List_RewardData__TypeInfo);
		            GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		                      (uVar1,Method_System_Collections_Generic_List_RewardData___ctor__);
		            iVar2 = Method_System_Collections_Generic_List_List_RewardData___Add__;
		            *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		            uVar5 = *(uint *)(param1_00 + 0xc);
		            if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		              *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		              *(undefined4 *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = uVar1;
		            }
		            else {
		              System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                        (param1_00,uVar1,
		                         *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		            }
		          }
		          param1_02 = *(undefined4 *)(*(int *)(param3 + param2_00 * 4 + 0x10) + 8);
		          uVar1 = func_ii_8038(uVar3,0);
		          iVar2 = Core_Data_RewardData__get_RewardId
		                            (param1_02,uVar1,Method_System_Linq_Enumerable_Contains_RewardTypes___);
		          if (iVar2 != 0) {
		            param1_01 = System_Linq_Enumerable__ToList_object_
		                                  (param1_00,param2_00,
		                                   Method_System_Collections_Generic_List_List_RewardData___get_Item__
		                                  );
		            iVar2 = Method_System_Collections_Generic_List_RewardData__Add__;
		            *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		            uVar5 = *(uint *)(param1_01 + 0xc);
		            if (uVar5 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		              *(uint *)(param1_01 + 0xc) = uVar5 + 1;
		              *(undefined4 *)(*(int *)(param1_01 + 8) + uVar5 * 4 + 0x10) = uVar3;
		            }
		            else {
		              System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                        (param1_01,uVar3,
		                         *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		            }
		          }
		          param2_00 = param2_00 + 1;
		        } while (param2_00 < *(int *)(param3 + 0xc));
		      }
		      param2_01 = param2_01 + 1;
		    } while (param2_01 != iVar4);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x5E76", Offset = "0x5E76", VA = "0x5E76")]
		protected List<List<RewardData>> GetIconValueRewardsLines(List<RewardData> iconValueTypes, RewardsRender.IconValueRewardInLine[] iconValueRewardTypesByLines)
		{
		/* --- GHIDRA: GetIconValueRewardsLines ---
		int UI_Rewards_RewardsRender__GetIconValueRewardsLines
		              (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  int param1_00;
		  undefined4 param2_00;
		  int iVar3;
		  int iVar4;
		  uint uVar5;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a59a0f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Contains_RewardTypes___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_RewardData__TypeInfo);
		    DAT_ram_00a59a0f = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_RewardData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_RewardData___ctor__);
		  iVar4 = *(int *)(param2 + 0xc);
		  if (0 < iVar4) {
		    iVar2 = 0;
		    do {
		      param1_01 = *(undefined4 *)(param2 + iVar2 * 4 + 0x10);
		      param2_00 = func_ii_8038(param1_01,0);
		      iVar3 = Core_Data_RewardData__get_RewardId
		                        (param3,param2_00,Method_System_Linq_Enumerable_Contains_RewardTypes___);
		      iVar1 = Method_System_Collections_Generic_List_RewardData__Add__;
		      if (iVar3 != 0) {
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar5 = *(uint *)(param1_00 + 0xc);
		        if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		          *(undefined4 *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = param1_01;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_00,param1_01,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		        }
		      }
		      iVar2 = iVar2 + 1;
		    } while (iVar2 != iVar4);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x5E77", Offset = "0x5E77", VA = "0x5E77")]
		protected List<RewardData> GetRewardByFitTypes(RewardData[] rewards, RewardTypes[] fitTypes)
		{
		/* --- GHIDRA: GetRewardByFitTypes ---
		undefined4
		UI_Rewards_RewardsRender__GetRewardByFitTypes
		          (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a59a10 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Contains_RewardTypes___);
		    DAT_ram_00a59a10 = '\x01';
		  }
		  uVar1 = 1;
		  iVar3 = *(int *)(*(int *)(param1 + 0x2c) + 0xc);
		  if (iVar3 < 1) {
		code_r0x810a7b68:
		    *param3 = 0;
		    return 0;
		  }
		  iVar6 = *(int *)(*(int *)(param1 + 0x2c) + 0x10);
		  *param3 = iVar6;
		  uVar4 = *(undefined4 *)(iVar6 + 8);
		  uVar2 = func_ii_8038(param2,0);
		  iVar6 = Core_Data_RewardData__get_RewardId
		                    (uVar4,uVar2,Method_System_Linq_Enumerable_Contains_RewardTypes___);
		  if (iVar6 == 0) {
		    do {
		      iVar5 = iVar5 + 1;
		      if (iVar5 == iVar3) goto code_r0x810a7b68;
		      iVar6 = *(int *)(*(int *)(param1 + 0x2c) + iVar5 * 4 + 0x10);
		      *param3 = iVar6;
		      uVar4 = *(undefined4 *)(iVar6 + 8);
		      uVar2 = func_ii_8038(param2,0);
		      iVar6 = Core_Data_RewardData__get_RewardId
		                        (uVar4,uVar2,Method_System_Linq_Enumerable_Contains_RewardTypes___);
		    } while (iVar6 == 0);
		    uVar1 = (uint)(iVar5 < iVar3);
		  }
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x5E78", Offset = "0x5E78", VA = "0x5E78")]
		private bool TryGetSeparator(RewardData reward, out RewardsRender.ContainerSeparatorConfig config)
		{
		/* --- GHIDRA: TryGetSeparator ---
		undefined4
		UI_Rewards_RewardsRender__TryGetSeparator
		          (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a59a11 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Contains_RewardTypes___);
		    DAT_ram_00a59a11 = '\x01';
		  }
		  uVar1 = 1;
		  iVar3 = *(int *)(*(int *)(param1 + 0x30) + 0xc);
		  if (iVar3 < 1) {
		code_r0x810a7c27:
		    *param3 = 0;
		    return 0;
		  }
		  iVar6 = *(int *)(*(int *)(param1 + 0x30) + 0x10);
		  *param3 = iVar6;
		  uVar4 = *(undefined4 *)(iVar6 + 8);
		  uVar2 = func_ii_8038(param2,0);
		  iVar6 = Core_Data_RewardData__get_RewardId
		                    (uVar4,uVar2,Method_System_Linq_Enumerable_Contains_RewardTypes___);
		  if (iVar6 == 0) {
		    do {
		      iVar5 = iVar5 + 1;
		      if (iVar5 == iVar3) goto code_r0x810a7c27;
		      iVar6 = *(int *)(*(int *)(param1 + 0x30) + iVar5 * 4 + 0x10);
		      *param3 = iVar6;
		      uVar4 = *(undefined4 *)(iVar6 + 8);
		      uVar2 = func_ii_8038(param2,0);
		      iVar6 = Core_Data_RewardData__get_RewardId
		                        (uVar4,uVar2,Method_System_Linq_Enumerable_Contains_RewardTypes___);
		    } while (iVar6 == 0);
		    uVar1 = (uint)(iVar5 < iVar3);
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x5E79", Offset = "0x5E79", VA = "0x5E79")]
		private bool TryGetSupportedRewardConfig(RewardData reward, out RewardsRender.RewardRenderConfigRecord config)
		{
		/* --- GHIDRA: TryGetSupportedRewardConfig ---
		void UI_Rewards_RewardsRender__TryGetSupportedRewardConfig(int param1,uint param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (param2 != *(byte *)(param1 + 0x3c)) {
		    *(char *)(param1 + 0x3c) = (char)param2;
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param1 + 0x38),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,(uint)*(byte *)(param1 + 0x3c),0);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x5E7A", Offset = "0x5E7A", VA = "0x5E7A")]
		private void SetPreloadEnabled(bool value)
		{
		/* --- GHIDRA: SetPreloadEnabled ---
		void UI_Rewards_RewardsRender__SetPreloadEnabled(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x40);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x5E7B", Offset = "0x5E7B", VA = "0x5E7B")]
		public void DispatchDropProcessCompleteEvent()
		{
		/* --- GHIDRA: DispatchDropProcessCompleteEvent ---
		/* WARNING: Removing unreachable block (ram,0x810a7f41) */
		
		void UI_Rewards_RewardsRender__DispatchDropProcessCompleteEvent(int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  int iVar11;
		  undefined4 uVar12;
		  int iVar13;
		  int iVar14;
		  undefined4 uVar15;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar13 = 0;
		  iVar5 = 0;
		  if (DAT_ram_00a59a12 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_RewardData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_RewardData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_RewardData__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData__Contains__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_RewardData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_List_RewardData___get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_List_RewardData___get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_GameObject___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_RewardsContainer___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a59a12 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if ((char)param1[0xf] != '\0') {
		    *(undefined1 *)(param1 + 0xf) = 0;
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1[0xe],0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)*(byte *)(param1 + 0xf),0);
		  }
		  iVar14 = *param1;
		  (**(code **)((ulonglong)*(uint *)(iVar14 + 0xe8) * 4))(param1,*(undefined4 *)(iVar14 + 0xec));
		  uVar3 = UI_Rewards_RewardsRender__GetIconValueRewardsLines(iVar14,param1[7],param1[8],iVar14);
		  iVar4 = UI_Rewards_RewardsRender__OnValidate(iVar14,uVar3,param1[10],iVar14);
		  if (0 < *(int *)(iVar4 + 0xc)) {
		    do {
		      iVar6 = System_Linq_Enumerable__ToList_object_
		                        (iVar4,iVar5,
		                         Method_System_Collections_Generic_List_List_RewardData___get_Item__);
		      if (0 < *(int *)(iVar6 + 0xc)) {
		        iVar6 = 0;
		        uVar15 = System_Linq_Enumerable__ToList_object_
		                           (iVar4,iVar5,
		                            Method_System_Collections_Generic_List_List_RewardData___get_Item__);
		        System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                  (&local_20,uVar15,
		                   Method_System_Collections_Generic_List_RewardData__GetEnumerator__);
		        local_8 = local_18;
		        local_10 = CONCAT44(puStack_1c,local_20);
		        local_20 = 0;
		        puStack_1c = &local_10;
		        do {
		          do {
		            DAT_ram_009d3e38 = 0;
		            iVar2 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                               Method_System_Collections_Generic_List_Enumerator_RewardData__MoveNext__
		                              );
		            iVar14 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar14 == 1) goto code_r0x810a80a1;
		            if (iVar2 == 0) goto code_r0x810a80fe;
		            uVar15 = local_8._4_4_;
		            if (DAT_ram_00a59a11 == '\0') {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi(0x7ff,&Method_System_Linq_Enumerable_Contains_RewardTypes___);
		              if (DAT_ram_009d3e38 == 1) goto code_r0x810a80a1;
		              DAT_ram_00a59a11 = '\x01';
		            }
		            bVar1 = true;
		            iVar14 = 0;
		            iVar2 = *(int *)(param1[0xc] + 0xc);
		            if (iVar2 < 1) {
		              iVar11 = 0;
		              bVar1 = false;
		            }
		            else {
		              do {
		                iVar11 = *(int *)(param1[0xc] + iVar14 * 4 + 0x10);
		                uVar12 = *(undefined4 *)(iVar11 + 8);
		                DAT_ram_009d3e38 = 0;
		                uVar7 = import::env::invoke_iii
		                                  (s_struct_Uniforms___color__array<v_ram_00001f04 + 99,uVar15,0);
		                if (DAT_ram_009d3e38 == 1) goto code_r0x810a80a1;
		                DAT_ram_009d3e38 = 0;
		                iVar8 = import::env::invoke_iiii
		                                  (s_struct_Uniforms___color__array<v_ram_00001f04 + 100,uVar12,
		                                   uVar7,Method_System_Linq_Enumerable_Contains_RewardTypes___);
		                if (DAT_ram_009d3e38 == 1) goto code_r0x810a80a1;
		                if (iVar8 != 0) goto code_r0x810a7f11;
		                iVar14 = iVar14 + 1;
		                bVar1 = iVar14 < iVar2;
		              } while (iVar14 != iVar2);
		              iVar11 = 0;
		            }
		code_r0x810a7f11:
		          } while (!bVar1);
		          if (iVar6 == 0) {
		            iVar14 = param1[4];
		            iVar6 = param1[0xd];
		            if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                         UnityEngine_Object_TypeInfo);
		              if (DAT_ram_009d3e38 == 1) break;
		            }
		            DAT_ram_009d3e38 = 0;
		            iVar6 = import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,iVar6,iVar14,
		                               Method_UnityEngine_Object_Instantiate_RewardsContainer___);
		            if (DAT_ram_009d3e38 == 1) break;
		            *(int *)(iVar6 + 0x14) = param1[5];
		            *(int *)(iVar6 + 0x18) = param1[6];
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar7 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x30e,iVar6,0);
		          iVar14 = DAT_ram_009d3e38;
		          iVar13 = iVar13 + 1;
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          piVar10 = (int *)import::env::invoke_iiiii
		                                     (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x66,iVar11,
		                                      uVar7,param1,iVar14);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_iiiii
		                    (*(undefined4 *)(*piVar10 + 0xe8),piVar10,iVar6,uVar15,
		                     *(undefined4 *)(*piVar10 + 0xec));
		        } while (DAT_ram_009d3e38 != 1);
		code_r0x810a80a1:
		        DAT_ram_009d3e38 = 0;
		        uVar15 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar14 = global_1;
		        iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar14 != iVar6) {
		code_r0x810a8197:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x67,&local_20);
		          iVar13 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar13 == 1) {
		            import::env::__cxa_find_matching_catch_3(0);
		            unnamed_function_937();
		            do {
		              halt_trap();
		            } while( true );
		          }
		          import::env::__resumeException(uVar15);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar10 = (int *)import::env::__cxa_begin_catch(uVar15);
		        iVar14 = *piVar10;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar14;
		        import::env::invoke_v(0x123);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar15 = import::env::__cxa_find_matching_catch_2();
		          goto code_r0x810a8197;
		        }
		        if (iVar14 != 0) {
		          System_Data_DataSet__ValidateLocaleConstraint(iVar14);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		code_r0x810a80fe:
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(iVar4 + 0xc));
		  }
		  iVar5 = UI_Rewards_RewardsRender__GetIconValueRewardsLines(iVar14,param1[7],param1[9],iVar14);
		  if (*(int *)(iVar5 + 0xc) < 1) goto code_r0x810a83a6;
		  uVar15 = System_Linq_Enumerable__ToList_object_
		                     (iVar5,0,Method_System_Collections_Generic_List_RewardData__get_Item__);
		  if (DAT_ram_00a59a10 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Contains_RewardTypes___);
		    DAT_ram_00a59a10 = '\x01';
		  }
		  iVar14 = *(int *)(param1[0xb] + 0xc);
		  if (0 < iVar14) {
		    iVar4 = 0;
		    iVar6 = *(int *)(param1[0xb] + 0x10);
		    uVar12 = *(undefined4 *)(iVar6 + 8);
		    uVar7 = func_ii_8038(uVar15,0);
		    iVar2 = Core_Data_RewardData__get_RewardId
		                      (uVar12,uVar7,Method_System_Linq_Enumerable_Contains_RewardTypes___);
		    if (iVar2 == 0) {
		      do {
		        iVar4 = iVar4 + 1;
		        if (iVar14 == iVar4) {
		          iVar6 = 0;
		          break;
		        }
		        iVar6 = *(int *)(param1[0xb] + iVar4 * 4 + 0x10);
		        uVar12 = *(undefined4 *)(iVar6 + 8);
		        uVar7 = func_ii_8038(uVar15,0);
		        iVar2 = Core_Data_RewardData__get_RewardId
		                          (uVar12,uVar7,Method_System_Linq_Enumerable_Contains_RewardTypes___);
		      } while (iVar2 == 0);
		      if (iVar14 <= iVar4) goto code_r0x810a824c;
		    }
		    iVar14 = param1[4];
		    uVar15 = *(undefined4 *)(iVar6 + 0xc);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    func_ii_6805(uVar15,iVar14,Method_UnityEngine_Object_Instantiate_GameObject___);
		  }
		code_r0x810a824c:
		  iVar14 = *(int *)(iVar5 + 0xc);
		  if (0 < iVar14) {
		    iVar4 = 0;
		    iVar6 = 0;
		    do {
		      uVar15 = System_Linq_Enumerable__ToList_object_
		                         (iVar5,iVar6,Method_System_Collections_Generic_List_RewardData__get_Item__)
		      ;
		      if (DAT_ram_00a59a11 == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Contains_RewardTypes___);
		        DAT_ram_00a59a11 = '\x01';
		      }
		      iVar2 = *(int *)(param1[0xc] + 0xc);
		      if (0 < iVar2) {
		        iVar11 = 0;
		        iVar8 = *(int *)(param1[0xc] + 0x10);
		        uVar12 = *(undefined4 *)(iVar8 + 8);
		        uVar7 = func_ii_8038(uVar15,0);
		        iVar9 = Core_Data_RewardData__get_RewardId
		                          (uVar12,uVar7,Method_System_Linq_Enumerable_Contains_RewardTypes___);
		        if (iVar9 == 0) {
		          do {
		            iVar11 = iVar11 + 1;
		            if (iVar2 == iVar11) {
		              iVar8 = 0;
		              break;
		            }
		            iVar8 = *(int *)(param1[0xc] + iVar11 * 4 + 0x10);
		            uVar12 = *(undefined4 *)(iVar8 + 8);
		            uVar7 = func_ii_8038(uVar15,0);
		            iVar9 = Core_Data_RewardData__get_RewardId
		                              (uVar12,uVar7,Method_System_Linq_Enumerable_Contains_RewardTypes___);
		          } while (iVar9 == 0);
		          if (iVar2 <= iVar11) goto code_r0x810a8398;
		        }
		        if (iVar4 == 0) {
		          iVar11 = param1[4];
		          iVar4 = param1[0xd];
		          if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		            func_ii_306000(UnityEngine_Object_TypeInfo);
		          }
		          iVar4 = func_ii_6805(iVar4,iVar11,
		                               Method_UnityEngine_Object_Instantiate_RewardsContainer___);
		          *(int *)(iVar4 + 0x14) = param1[5];
		          *(int *)(iVar4 + 0x18) = param1[6];
		        }
		        uVar7 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                          (iVar4,0);
		        piVar10 = (int *)Utils_ObjectUtils__IsNull(iVar8,uVar7,param1,iVar11);
		        (**(code **)((ulonglong)*(uint *)(*piVar10 + 0xe8) * 4))
		                  (piVar10,iVar4,uVar15,*(undefined4 *)(*piVar10 + 0xec));
		        iVar13 = iVar13 + 1;
		      }
		code_r0x810a8398:
		      iVar6 = iVar6 + 1;
		    } while (iVar6 != iVar14);
		  }
		code_r0x810a83a6:
		  iVar14 = *(int *)(param1[7] + 0xc);
		  if (0 < iVar14) {
		    iVar4 = 0;
		    do {
		      uVar15 = *(undefined4 *)(param1[7] + iVar4 * 4 + 0x10);
		      iVar6 = func_ii_4685(uVar3,uVar15,
		                           Method_System_Collections_Generic_List_RewardData__Contains__);
		      if ((iVar6 == 0) &&
		         (iVar6 = func_ii_4685(iVar5,uVar15,
		                               Method_System_Collections_Generic_List_RewardData__Contains__),
		         iVar6 == 0)) {
		        if (DAT_ram_00a59a11 == '\0') {
		          Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Contains_RewardTypes___);
		          DAT_ram_00a59a11 = '\x01';
		        }
		        iVar6 = *(int *)(param1[0xc] + 0xc);
		        if (0 < iVar6) {
		          iVar2 = 0;
		          iVar11 = *(int *)(param1[0xc] + 0x10);
		          uVar12 = *(undefined4 *)(iVar11 + 8);
		          uVar7 = func_ii_8038(uVar15,0);
		          iVar8 = Core_Data_RewardData__get_RewardId
		                            (uVar12,uVar7,Method_System_Linq_Enumerable_Contains_RewardTypes___);
		          if (iVar8 == 0) {
		            do {
		              iVar2 = iVar2 + 1;
		              if (iVar6 == iVar2) {
		                iVar11 = 0;
		                break;
		              }
		              iVar11 = *(int *)(param1[0xc] + iVar2 * 4 + 0x10);
		              uVar12 = *(undefined4 *)(iVar11 + 8);
		              uVar7 = func_ii_8038(uVar15,0);
		              iVar8 = Core_Data_RewardData__get_RewardId
		                                (uVar12,uVar7,Method_System_Linq_Enumerable_Contains_RewardTypes___)
		              ;
		            } while (iVar8 == 0);
		            if (iVar6 <= iVar2) goto code_r0x810a85ee;
		          }
		          if (DAT_ram_00a59a10 == '\0') {
		            Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Contains_RewardTypes___);
		            DAT_ram_00a59a10 = '\x01';
		          }
		          iVar6 = *(int *)(param1[0xb] + 0xc);
		          if (0 < iVar6) {
		            iVar2 = 0;
		            iVar8 = *(int *)(param1[0xb] + 0x10);
		            uVar12 = *(undefined4 *)(iVar8 + 8);
		            uVar7 = func_ii_8038(uVar15,0);
		            iVar9 = Core_Data_RewardData__get_RewardId
		                              (uVar12,uVar7,Method_System_Linq_Enumerable_Contains_RewardTypes___);
		            if (iVar9 == 0) {
		              do {
		                iVar2 = iVar2 + 1;
		                if (iVar6 == iVar2) {
		                  iVar8 = 0;
		                  break;
		                }
		                iVar8 = *(int *)(param1[0xb] + iVar2 * 4 + 0x10);
		                uVar12 = *(undefined4 *)(iVar8 + 8);
		                uVar7 = func_ii_8038(uVar15,0);
		                iVar9 = Core_Data_RewardData__get_RewardId
		                                  (uVar12,uVar7,
		                                   Method_System_Linq_Enumerable_Contains_RewardTypes___);
		              } while (iVar9 == 0);
		              bVar1 = iVar2 < iVar6;
		            }
		            else {
		              bVar1 = true;
		            }
		            if ((bVar1) && (0 < iVar13)) {
		              iVar6 = param1[4];
		              uVar7 = *(undefined4 *)(iVar8 + 0xc);
		              if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		                func_ii_306000(UnityEngine_Object_TypeInfo);
		              }
		              func_ii_6805(uVar7,iVar6,Method_UnityEngine_Object_Instantiate_GameObject___);
		            }
		          }
		          iVar6 = param1[4];
		          iVar2 = param1[0xd];
		          if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		            func_ii_306000(UnityEngine_Object_TypeInfo);
		          }
		          iVar6 = func_ii_6805(iVar2,iVar6,Method_UnityEngine_Object_Instantiate_RewardsContainer___
		                              );
		          *(int *)(iVar6 + 0x14) = param1[5];
		          *(int *)(iVar6 + 0x18) = param1[6];
		          uVar7 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                            (iVar6,0);
		          piVar10 = (int *)Utils_ObjectUtils__IsNull(iVar11,uVar7,param1,iVar6);
		          (**(code **)((ulonglong)*(uint *)(*piVar10 + 0xe8) * 4))
		                    (piVar10,iVar6,uVar15,*(undefined4 *)(*piVar10 + 0xec));
		          iVar13 = iVar13 + 1;
		        }
		      }
		code_r0x810a85ee:
		      iVar4 = iVar4 + 1;
		    } while (iVar4 != iVar14);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[Token(Token = "0x6000B5E")]
		public bool TryGetRender<T>(RewardTypes rewardType, out T renderer) where T : AbstractRewardRender
		{
			return default(bool);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x5E7C", Offset = "0x5E7C", VA = "0x5E7C", Slot = "6")]
		public override void Render()
		{
		/* --- GHIDRA: Render ---
		void UI_Rewards_RewardsRender__Render(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  float fVar4;
		  undefined4 *puVar5;
		  int *piVar6;
		  uint *puVar7;
		  uint uVar8;
		  int iVar9;
		  undefined4 uVar10;
		  int iVar11;
		  int *piVar12;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a59a13 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_RewardData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_RewardInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_UserSkillsIndexes_var);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_UserSkillsIndexes_TypeInfo);
		    DAT_ram_00a59a13 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = 0;
		  iVar1 = unnamed_function_1417(System_Collections_Generic_List_RewardData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar1,Method_System_Collections_Generic_List_RewardData___ctor__);
		  iVar2 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		  func_ii_7941(iVar2,0);
		  *(undefined4 *)(iVar2 + 0xc) = 1;
		  func_ii_7707(*(undefined4 *)(iVar2 + 0x10),1000,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(iVar2,0);
		  iVar2 = Method_System_Collections_Generic_List_RewardData__Add__;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  uVar8 = *(uint *)(iVar1 + 0xc);
		  if (uVar8 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		    *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		    *(undefined4 *)(*(int *)(iVar1 + 8) + uVar8 * 4 + 0x10) = uVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar1,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		  func_ii_7941(iVar2,0);
		  *(undefined4 *)(iVar2 + 0xc) = 6;
		  func_ii_7707(*(undefined4 *)(iVar2 + 0x10),0x21,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar3 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(iVar2,0);
		  iVar2 = Method_System_Collections_Generic_List_RewardData__Add__;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  uVar8 = *(uint *)(iVar1 + 0xc);
		  if (uVar8 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		    *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		    *(undefined4 *)(*(int *)(iVar1 + 8) + uVar8 * 4 + 0x10) = uVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar1,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		  func_ii_7941(iVar2,0);
		  *(char **)(iVar2 + 0xc) = s_Texture2DArray___dx_dx_d__is_too_ram_0001867d + 0x23;
		  func_ii_7707(*(undefined4 *)(iVar2 + 0x10),0xc,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar3 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(iVar2,0);
		  iVar2 = Method_System_Collections_Generic_List_RewardData__Add__;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  uVar8 = *(uint *)(iVar1 + 0xc);
		  if (uVar8 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		    *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		    *(undefined4 *)(*(int *)(iVar1 + 8) + uVar8 * 4 + 0x10) = uVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar1,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		  func_ii_7941(iVar2,0);
		  *(undefined4 *)(iVar2 + 0xc) = 0x79;
		  uVar3 = *(undefined4 *)(iVar2 + 0x10);
		  fVar4 = UnityEngine_PropertyName__ToString(0.0,1e+06,0);
		  fVar4 = fVar4 * 100.0;
		  if (fVar4 < 4.2949673e+09 && 0.0 <= fVar4) {
		    iVar9 = (int)fVar4;
		  }
		  else {
		    iVar9 = 0;
		  }
		  if (ABS(fVar4) < 2.1474836e+09) {
		    iVar11 = (int)fVar4;
		  }
		  else {
		    iVar11 = -0x80000000;
		  }
		  if (0.0 <= fVar4) {
		    iVar11 = iVar9;
		  }
		  func_ii_7707(uVar3,iVar11,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar3 = *(undefined4 *)(iVar2 + 0x10);
		  fVar4 = UnityEngine_PropertyName__ToString(0.0,1e+06,0);
		  fVar4 = fVar4 * 100.0;
		  if (fVar4 < 4.2949673e+09 && 0.0 <= fVar4) {
		    iVar9 = (int)fVar4;
		  }
		  else {
		    iVar9 = 0;
		  }
		  if (ABS(fVar4) < 2.1474836e+09) {
		    iVar11 = (int)fVar4;
		  }
		  else {
		    iVar11 = -0x80000000;
		  }
		  if (0.0 <= fVar4) {
		    iVar11 = iVar9;
		  }
		  func_ii_7707(uVar3,iVar11,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar3 = *(undefined4 *)(iVar2 + 0x10);
		  fVar4 = UnityEngine_PropertyName__ToString(0.0,1e+06,0);
		  fVar4 = fVar4 * 100.0;
		  if (fVar4 < 4.2949673e+09 && 0.0 <= fVar4) {
		    iVar9 = (int)fVar4;
		  }
		  else {
		    iVar9 = 0;
		  }
		  if (ABS(fVar4) < 2.1474836e+09) {
		    iVar11 = (int)fVar4;
		  }
		  else {
		    iVar11 = -0x80000000;
		  }
		  if (0.0 <= fVar4) {
		    iVar11 = iVar9;
		  }
		  func_ii_7707(uVar3,iVar11,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar3 = *(undefined4 *)(iVar2 + 0x10);
		  fVar4 = UnityEngine_PropertyName__ToString(0.0,0.0,0);
		  fVar4 = fVar4 * 100.0;
		  if (fVar4 < 4.2949673e+09 && 0.0 <= fVar4) {
		    iVar9 = (int)fVar4;
		  }
		  else {
		    iVar9 = 0;
		  }
		  if (ABS(fVar4) < 2.1474836e+09) {
		    iVar11 = (int)fVar4;
		  }
		  else {
		    iVar11 = -0x80000000;
		  }
		  if (0.0 <= fVar4) {
		    iVar11 = iVar9;
		  }
		  func_ii_7707(uVar3,iVar11,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar3 = *(undefined4 *)(iVar2 + 0x10);
		  fVar4 = UnityEngine_PropertyName__ToString(0.0,0.0,0);
		  fVar4 = fVar4 * 100.0;
		  if (fVar4 < 4.2949673e+09 && 0.0 <= fVar4) {
		    iVar9 = (int)fVar4;
		  }
		  else {
		    iVar9 = 0;
		  }
		  if (ABS(fVar4) < 2.1474836e+09) {
		    iVar11 = (int)fVar4;
		  }
		  else {
		    iVar11 = -0x80000000;
		  }
		  if (0.0 <= fVar4) {
		    iVar11 = iVar9;
		  }
		  func_ii_7707(uVar3,iVar11,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar3 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(iVar2,0);
		  iVar2 = Method_System_Collections_Generic_List_RewardData__Add__;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  uVar8 = *(uint *)(iVar1 + 0xc);
		  if (uVar8 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		    *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		    *(undefined4 *)(*(int *)(iVar1 + 8) + uVar8 * 4 + 0x10) = uVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar1,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		  func_ii_7941(iVar2,0);
		  *(undefined4 *)(iVar2 + 0xc) = 7;
		  uVar3 = *(undefined4 *)(iVar2 + 0x10);
		  fVar4 = UnityEngine_PropertyName__ToString(0.0,2.0,0);
		  if (fVar4 < 4.2949673e+09 && 0.0 <= fVar4) {
		    iVar9 = (int)fVar4;
		  }
		  else {
		    iVar9 = 0;
		  }
		  if (ABS(fVar4) < 2.1474836e+09) {
		    iVar11 = (int)fVar4;
		  }
		  else {
		    iVar11 = -0x80000000;
		  }
		  if (0.0 <= fVar4) {
		    iVar11 = iVar9;
		  }
		  func_ii_7707(uVar3,iVar11,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar3 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(iVar2,0);
		  iVar2 = Method_System_Collections_Generic_List_RewardData__Add__;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  uVar8 = *(uint *)(iVar1 + 0xc);
		  if (uVar8 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		    *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		    *(undefined4 *)(*(int *)(iVar1 + 8) + uVar8 * 4 + 0x10) = uVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar1,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		  func_ii_7941(iVar2,0);
		  *(undefined4 *)(iVar2 + 0xc) = 0x14;
		  uVar10 = *(undefined4 *)(iVar2 + 0x10);
		  uVar3 = UnityEngine_Random__Range(0,100,0);
		  func_ii_7707(uVar10,uVar3,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar10 = *(undefined4 *)(iVar2 + 0x10);
		  uVar3 = UnityEngine_Random__Range(0,100,0);
		  func_ii_7707(uVar10,uVar3,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar10 = *(undefined4 *)(iVar2 + 0x10);
		  uVar3 = UnityEngine_Random__Range(0,100,0);
		  func_ii_7707(uVar10,uVar3,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar10 = *(undefined4 *)(iVar2 + 0x10);
		  uVar3 = UnityEngine_Random__Range(0,100,0);
		  func_ii_7707(uVar10,uVar3,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar10 = *(undefined4 *)(iVar2 + 0x10);
		  uVar3 = UnityEngine_Random__Range(0,100,0);
		  func_ii_7707(uVar10,uVar3,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar10 = *(undefined4 *)(iVar2 + 0x10);
		  uVar3 = UnityEngine_Random__Range(0,100,0);
		  func_ii_7707(uVar10,uVar3,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar10 = *(undefined4 *)(iVar2 + 0x10);
		  uVar3 = UnityEngine_Random__Range(0,100,0);
		  func_ii_7707(uVar10,uVar3,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar10 = *(undefined4 *)(iVar2 + 0x10);
		  uVar3 = UnityEngine_Random__Range(0,100,0);
		  func_ii_7707(uVar10,uVar3,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar10 = *(undefined4 *)(iVar2 + 0x10);
		  uVar3 = UnityEngine_Random__Range(0,100,0);
		  func_ii_7707(uVar10,uVar3,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar10 = *(undefined4 *)(iVar2 + 0x10);
		  uVar3 = UnityEngine_Random__Range(0,100,0);
		  func_ii_7707(uVar10,uVar3,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar10 = *(undefined4 *)(iVar2 + 0x10);
		  uVar3 = UnityEngine_Random__Range(0,100,0);
		  func_ii_7707(uVar10,uVar3,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar10 = *(undefined4 *)(iVar2 + 0x10);
		  uVar3 = UnityEngine_Random__Range(0,100,0);
		  func_ii_7707(uVar10,uVar3,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(iVar2,0);
		  iVar2 = Method_System_Collections_Generic_List_RewardData__Add__;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  uVar8 = *(uint *)(iVar1 + 0xc);
		  if (uVar8 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		    *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		    *(undefined4 *)(*(int *)(iVar1 + 8) + uVar8 * 4 + 0x10) = uVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar1,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		  func_ii_7941(iVar2,0);
		  *(undefined4 *)(iVar2 + 0xc) = 3;
		  func_ii_7707(*(undefined4 *)(iVar2 + 0x10),s_var<private>_posTex__array<vec4<_ram_00002538 + 0x1d9
		               ,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  func_ii_7707(*(undefined4 *)(iVar2 + 0x10),s_var<private>_posTex__array<vec4<_ram_00002538 + 0x1da
		               ,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  func_ii_7707(*(undefined4 *)(iVar2 + 0x10),s_var<private>_posTex__array<vec4<_ram_00002538 + 0x1db
		               ,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar3 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(iVar2,0);
		  iVar2 = Method_System_Collections_Generic_List_RewardData__Add__;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  uVar8 = *(uint *)(iVar1 + 0xc);
		  if (uVar8 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		    *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		    *(undefined4 *)(*(int *)(iVar1 + 8) + uVar8 * 4 + 0x10) = uVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar1,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		  func_ii_7941(iVar2,0);
		  *(undefined4 *)(iVar2 + 0xc) = 0xd;
		  func_ii_7707(*(undefined4 *)(iVar2 + 0x10),s_var<private>_posTex__array<vec4<_ram_00002538 + 0x1dc
		               ,Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  func_ii_7707(*(undefined4 *)(iVar2 + 0x10),5,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  uVar3 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(iVar2,0);
		  iVar2 = Method_System_Collections_Generic_List_RewardData__Add__;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  uVar8 = *(uint *)(iVar1 + 0xc);
		  if (uVar8 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		    *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		    *(undefined4 *)(*(int *)(iVar1 + 8) + uVar8 * 4 + 0x10) = uVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar1,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		  func_ii_7941(iVar2,0);
		  *(undefined4 *)(iVar2 + 0xc) = 9;
		  uVar3 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(iVar2,0);
		  iVar2 = Method_System_Collections_Generic_List_RewardData__Add__;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  uVar8 = *(uint *)(iVar1 + 0xc);
		  if (uVar8 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		    *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		    *(undefined4 *)(*(int *)(iVar1 + 8) + uVar8 * 4 + 0x10) = uVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar1,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		  func_ii_7941(iVar2,0);
		  *(undefined4 *)(iVar2 + 0xc) = 4;
		  uVar3 = Core_Data_Skills_UserSkillsIndexes_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar3 = func_ii_2734(uVar3,0);
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  uVar3 = System_Enum__GetUnderlyingType(uVar3,0);
		  local_4 = (int *)System_Array__Sort(uVar3,0);
		  local_c = &local_8;
		  local_14 = 0;
		  local_10 = &local_4;
		  do {
		    do {
		      piVar6 = local_4;
		      iVar9 = *local_4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar8 = 0;
		        do {
		          piVar12 = (int *)(*(int *)(iVar9 + 0x58) + uVar8 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar12) {
		            puVar5 = (undefined4 *)(iVar9 + piVar12[1] * 8 + 0xc0);
		            goto code_r0x810a9295;
		          }
		          uVar8 = uVar8 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar8);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar5 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x810a92dd:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810a9506;
		      }
		code_r0x810a9295:
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iii(*puVar5,piVar6,puVar5[1]);
		      piVar6 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x810a92dd;
		      if (iVar9 == 0) {
		        iVar9 = 6;
		        goto code_r0x810a9553;
		      }
		      iVar9 = *local_4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar8 = 0;
		        do {
		          piVar12 = (int *)(*(int *)(iVar9 + 0x58) + uVar8 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar12) {
		            puVar5 = (undefined4 *)(piVar12[1] * 8 + iVar9 + 200);
		            goto code_r0x810a9382;
		          }
		          uVar8 = uVar8 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar8);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar5 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,1);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x810a94fe:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810a9506;
		      }
		code_r0x810a9382:
		      DAT_ram_009d3e38 = 0;
		      piVar6 = (int *)import::env::invoke_iii(*puVar5,piVar6,puVar5[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x810a94fe;
		      if (piVar6 == (int *)0x0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0xa7);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x810a9e2c;
		code_r0x810a9478:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810a9506;
		      }
		      if (*(int *)(*piVar6 + 0x20) != *(int *)(Core_Data_Skills_UserSkillsIndexes_TypeInfo + 0x20))
		      {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar6,
		                   Core_Data_Skills_UserSkillsIndexes_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x810a9478;
		        goto code_r0x810a9e2c;
		      }
		      DAT_ram_009d3e38 = 0;
		      piVar6 = (int *)func_ii_15774(piVar6);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x810a94fe;
		    } while (*piVar6 - 0xfU < 3);
		    uVar10 = *(undefined4 *)(iVar2 + 0x10);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x68,0,
		                       s_var<private>_posTex__array<vec4<_ram_00002538 + 0x1d8,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x295,uVar10,uVar3,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810a9506:
		  iVar9 = global_1;
		  iVar11 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar11) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_14 = *piVar6;
		    iVar9 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 != 1) {
		code_r0x810a9553:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar6 = (int *)*local_c;
		      if (piVar6 != (int *)0x0) {
		        iVar11 = *piVar6;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          uVar8 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar8 * 8)) {
		              puVar7 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar8 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x810a95e3;
		            }
		            uVar8 = uVar8 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar8);
		        }
		        puVar7 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x810a95e3:
		        (**(code **)((ulonglong)*puVar7 * 4))(piVar6,puVar7[1]);
		      }
		      if (local_14 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_14);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar9 != 0) &&
		         (((((iVar9 == 1 || (iVar9 == 2)) || (iVar9 == 3)) || ((iVar9 == 4 || (iVar9 == 5)))) ||
		          (iVar9 != 6)))) {
		        return;
		      }
		      if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		      }
		      uVar3 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(iVar2,0);
		      iVar2 = Method_System_Collections_Generic_List_RewardData__Add__;
		      *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		      uVar8 = *(uint *)(iVar1 + 0xc);
		      if (uVar8 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		        *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		        *(undefined4 *)(*(int *)(iVar1 + 8) + uVar8 * 4 + 0x10) = uVar3;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (iVar1,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		      }
		      iVar2 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		      func_ii_7941(iVar2,0);
		      *(undefined4 *)(iVar2 + 0xc) = 0xe;
		      uVar3 = Core_Data_Skills_UserSkillsIndexes_var;
		      if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a669a0);
		      }
		      uVar3 = func_ii_2734(uVar3,0);
		      if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a6697c);
		      }
		      uVar3 = System_Enum__GetUnderlyingType(uVar3,0);
		      local_4 = (int *)System_Array__Sort(uVar3,0);
		      local_c = &local_8;
		      local_14 = 0;
		      local_10 = &local_4;
		      do {
		        do {
		          piVar6 = local_4;
		          iVar9 = *local_4;
		          if (*(ushort *)(iVar9 + 0xb6) != 0) {
		            uVar8 = 0;
		            do {
		              piVar12 = (int *)(*(int *)(iVar9 + 0x58) + uVar8 * 8);
		              if (System_Collections_IEnumerator_TypeInfo == *piVar12) {
		                puVar5 = (undefined4 *)(iVar9 + piVar12[1] * 8 + 0xc0);
		                goto code_r0x810a97b9;
		              }
		              uVar8 = uVar8 + 1;
		            } while (*(ushort *)(iVar9 + 0xb6) != uVar8);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar5 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                              System_Collections_IEnumerator_TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x810a9801:
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x810a9a2a;
		          }
		code_r0x810a97b9:
		          DAT_ram_009d3e38 = 0;
		          iVar9 = import::env::invoke_iii(*puVar5,piVar6,puVar5[1]);
		          piVar6 = local_4;
		          if (DAT_ram_009d3e38 == 1) goto code_r0x810a9801;
		          if (iVar9 == 0) {
		            iVar9 = 9;
		            goto code_r0x810a9a77;
		          }
		          iVar9 = *local_4;
		          if (*(ushort *)(iVar9 + 0xb6) != 0) {
		            uVar8 = 0;
		            do {
		              piVar12 = (int *)(*(int *)(iVar9 + 0x58) + uVar8 * 8);
		              if (System_Collections_IEnumerator_TypeInfo == *piVar12) {
		                puVar5 = (undefined4 *)(piVar12[1] * 8 + iVar9 + 200);
		                goto code_r0x810a98a6;
		              }
		              uVar8 = uVar8 + 1;
		            } while (*(ushort *)(iVar9 + 0xb6) != uVar8);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar5 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                              System_Collections_IEnumerator_TypeInfo,1);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x810a9a22:
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x810a9a2a;
		          }
		code_r0x810a98a6:
		          DAT_ram_009d3e38 = 0;
		          piVar6 = (int *)import::env::invoke_iii(*puVar5,piVar6,puVar5[1]);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x810a9a22;
		          if (piVar6 == (int *)0x0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_v(s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0xa7);
		            if (DAT_ram_009d3e38 != 1) {
		code_r0x810a9e2c:
		              do {
		                halt_trap();
		              } while( true );
		            }
		code_r0x810a999c:
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x810a9a2a;
		          }
		          if (*(int *)(*piVar6 + 0x20) !=
		              *(int *)(Core_Data_Skills_UserSkillsIndexes_TypeInfo + 0x20)) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar6,
		                       Core_Data_Skills_UserSkillsIndexes_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x810a999c;
		            goto code_r0x810a9e2c;
		          }
		          DAT_ram_009d3e38 = 0;
		          piVar6 = (int *)func_ii_15774(piVar6);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x810a9a22;
		        } while (*piVar6 - 0xfU < 3);
		        uVar10 = *(undefined4 *)(iVar2 + 0x10);
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x68,0,
		                           s_var<private>_posTex__array<vec4<_ram_00002538 + 0x1d8,0);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x295,uVar10,uVar3,
		                   Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810a9a2a:
		      iVar9 = global_1;
		      iVar11 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar9 == iVar11) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar3);
		        local_14 = *piVar6;
		        iVar9 = 0;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar11 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar11 != 1) {
		code_r0x810a9a77:
		          DAT_ram_009d3e38 = 0;
		          local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		          piVar6 = (int *)*local_c;
		          if (piVar6 != (int *)0x0) {
		            iVar11 = *piVar6;
		            if (*(ushort *)(iVar11 + 0xb6) != 0) {
		              uVar8 = 0;
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar8 * 8)) {
		                  puVar7 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar8 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x810a9b07;
		                }
		                uVar8 = uVar8 + 1;
		              } while (*(ushort *)(iVar11 + 0xb6) != uVar8);
		            }
		            puVar7 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x810a9b07:
		            (**(code **)((ulonglong)*puVar7 * 4))(piVar6,puVar7[1]);
		          }
		          if (local_14 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(local_14);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if (iVar9 != 0) {
		            if (iVar9 == 1) {
		              return;
		            }
		            if (iVar9 == 2) {
		              return;
		            }
		            if (iVar9 == 3) {
		              return;
		            }
		            if (iVar9 == 4) {
		              return;
		            }
		            if (iVar9 == 5) {
		              return;
		            }
		            if (iVar9 == 6) {
		              return;
		            }
		            if (iVar9 == 7) {
		              return;
		            }
		            if (iVar9 == 8) {
		              return;
		            }
		            if (iVar9 != 9) {
		              return;
		            }
		          }
		          if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		          }
		          uVar3 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(iVar2,0);
		          iVar2 = Method_System_Collections_Generic_List_RewardData__Add__;
		          *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		          uVar8 = *(uint *)(iVar1 + 0xc);
		          if (uVar8 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		            *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		            *(undefined4 *)(*(int *)(iVar1 + 8) + uVar8 * 4 + 0x10) = uVar3;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (iVar1,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		          }
		          iVar2 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		          func_ii_7941(iVar2,0);
		          *(undefined4 *)(iVar2 + 0xc) = 0x10;
		          func_ii_7707(*(undefined4 *)(iVar2 + 0x10),
		                       s_struct_Uniforms___color__array<v_ram_00000aff + 0x35a,
		                       Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		          func_ii_7707(*(undefined4 *)(iVar2 + 0x10),
		                       s_struct_Uniforms___color__array<v_ram_00000aff + 0x287,
		                       Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		          func_ii_7707(*(undefined4 *)(iVar2 + 0x10),
		                       s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x239,
		                       Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		          uVar3 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(iVar2,0);
		          iVar2 = Method_System_Collections_Generic_List_RewardData__Add__;
		          *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		          uVar8 = *(uint *)(iVar1 + 0xc);
		          if (uVar8 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		            *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		            *(undefined4 *)(*(int *)(iVar1 + 8) + uVar8 * 4 + 0x10) = uVar3;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (iVar1,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		          }
		          iVar2 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		          func_ii_7941(iVar2,0);
		          *(undefined4 *)(iVar2 + 0xc) = 0x11;
		          func_ii_7707(*(undefined4 *)(iVar2 + 0x10),
		                       s_struct_VertexOutput____builtin_p_ram_000028b3 + 0xb6,
		                       Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		          func_ii_7707(*(undefined4 *)(iVar2 + 0x10),
		                       s_struct_VertexOutput____builtin_p_ram_000028b3 + 0xb5,
		                       Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		          func_ii_7707(*(undefined4 *)(iVar2 + 0x10),
		                       s_struct_VertexOutput____builtin_p_ram_000028b3 + 0xb4,
		                       Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		          uVar3 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(iVar2,0);
		          iVar2 = Method_System_Collections_Generic_List_RewardData__Add__;
		          *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		          uVar8 = *(uint *)(iVar1 + 0xc);
		          if (uVar8 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		            *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		            *(undefined4 *)(*(int *)(iVar1 + 8) + uVar8 * 4 + 0x10) = uVar3;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (iVar1,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		          }
		          iVar1 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                            (iVar1,Method_System_Collections_Generic_List_RewardData__ToArray__);
		          piVar6 = (int *)param1[7];
		          if ((piVar6 == (int *)0x0) ||
		             (iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar6 + 0xc0) * 4))
		                                (piVar6,iVar1,*(undefined4 *)(*piVar6 + 0xc4)), iVar2 == 0)) {
		            param1[7] = iVar1;
		            UI_Rewards_AbstractRewardsRender__RemoveAll(param1,iVar1);
		          }
		          (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		          return;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x69,&local_14);
		      goto joined_r0x810a9db3;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x6a,&local_14);
		joined_r0x810a9db3:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x5E7D", Offset = "0x5E7D", VA = "0x5E7D")]
		public void Test()
		{
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x5E7E", Offset = "0x5E7E", VA = "0x5E7E")]
		public void TestRemoveAll()
		{
		/* --- GHIDRA: TestRemoveAll ---
		void UI_Rewards_RewardsRender__TestRemoveAll(int param1,undefined4 param2)
		
		{
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_24;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  *(undefined1 *)(param1 + 0x3c) = 1;
		  local_30 = 0x3f8000003f800000;
		  local_8 = 0x3f8000003f800000;
		  local_38 = 0x3f8000003f800000;
		  local_10 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_24,&local_38,0);
		  *(undefined4 *)(param1 + 0x14) = (undefined4)local_24;
		  local_1c = 0x3f8000003f800000;
		  local_40 = 0x3f8000003f800000;
		  local_24 = 0x3f8000003f800000;
		  local_48 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_14,&local_48,0);
		  *(undefined4 *)(param1 + 0x18) = local_14;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x5E7F", Offset = "0x5E7F", VA = "0x5E7F")]
		public RewardsRender()
		{
		}

		// Token: 0x04000523 RID: 1315
		[Token(Token = "0x4000523")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RewardTypes[] _iconValueRewardTypes;

		// Token: 0x04000524 RID: 1316
		[Token(Token = "0x4000524")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RewardTypes[] _artikulArtifactRewardTypes;

		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RewardsRender.IconValueRewardInLine[] _iconValueRewardTypesByLines;

		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private RewardsRender.ContainerSeparatorConfig[] _artContainerSeparators;

		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RewardsRender.RewardRenderConfigRecord[] _supportedRewards;

		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private RewardsContainer _containerPrefab;

		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _preloader;

		// Token: 0x0400052A RID: 1322
		[Token(Token = "0x400052A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool _preloadEnabled;

		// Token: 0x02000198 RID: 408
		[Token(Token = "0x2000198")]
		[Serializable]
		public class RewardRenderConfigRecord
		{
			// Token: 0x06000B63 RID: 2915 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B63")]
			[Address(RVA = "0x1F6A", Offset = "0x1F6A", VA = "0x1F6A")]
			public AbstractRewardRender InstantiateExecuter(Transform parent, RewardsRender rootRender)
			{
				return null;
			}

			// Token: 0x06000B64 RID: 2916 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B64")]
			[Address(RVA = "0x5E80", Offset = "0x5E80", VA = "0x5E80")]
			public RewardRenderConfigRecord()
			{
			}

			// Token: 0x0400052C RID: 1324
			[Token(Token = "0x400052C")]
			[FieldOffset(Offset = "0x8")]
			public RewardTypes[] FitRewardTypes;

			// Token: 0x0400052D RID: 1325
			[Token(Token = "0x400052D")]
			[FieldOffset(Offset = "0xC")]
			public AbstractRewardRender ExecuteScriptPrefab;
		}

		// Token: 0x02000199 RID: 409
		[Token(Token = "0x2000199")]
		[Serializable]
		public class IconValueRewardInLine
		{
			// Token: 0x06000B65 RID: 2917 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B65")]
			[Address(RVA = "0x5E81", Offset = "0x5E81", VA = "0x5E81")]
			public IconValueRewardInLine()
			{
			}

			// Token: 0x0400052E RID: 1326
			[Token(Token = "0x400052E")]
			[FieldOffset(Offset = "0x8")]
			public RewardTypes[] RewardTypes;
		}

		// Token: 0x0200019A RID: 410
		[Token(Token = "0x200019A")]
		[Serializable]
		public class ContainerSeparatorConfig
		{
			// Token: 0x06000B66 RID: 2918 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B66")]
			[Address(RVA = "0x5E82", Offset = "0x5E82", VA = "0x5E82")]
			public ContainerSeparatorConfig()
			{
			}

			// Token: 0x0400052F RID: 1327
			[Token(Token = "0x400052F")]
			[FieldOffset(Offset = "0x8")]
			public RewardTypes[] RewardTypes;

			// Token: 0x04000530 RID: 1328
			[Token(Token = "0x4000530")]
			[FieldOffset(Offset = "0xC")]
			public GameObject Prefab;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnDropProcessCompleteEvent ---
		void UI_Rewards_RewardsRender__add_OnDropProcessCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a59a0d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a59a0d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x40,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
