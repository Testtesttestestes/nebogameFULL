using System;
using System.Collections.Generic;
using System.Threading;
using Animations;
using Core.Data;
using Cysharp.Threading.Tasks;
using Gameplay.ArtifactDrop.View;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Rewards.Renderers
{
	// Token: 0x0200019F RID: 415
	[Token(Token = "0x200019F")]
	public class ArtifactRewardRender : AbstractRewardRender
	{
		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000180")]
		public Button TakeAllBtn
		{
			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0x5E89", Offset = "0x5E89", VA = "0x5E89")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000181")]
		public Button SellAllBtn
		{
			[Token(Token = "0x6000B70")]
			[Address(RVA = "0x5E8A", Offset = "0x5E8A", VA = "0x5E8A")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x5E8B", Offset = "0x5E8B", VA = "0x5E8B", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		/* --- GHIDRA: HandleRewardChanged ---
		undefined4
		UI_Rewards_Renderers_ArtifactRewardRender__HandleRewardChanged
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a59a19 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59a19 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x810aadb9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x810aadb9:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = func_ii_7944(param3,uVar3,0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x5E8C", Offset = "0x5E8C", VA = "0x5E8C", Slot = "10")]
		protected virtual ArtikulData CreateArtikul(int index, uint artikulId)
		{
		/* --- GHIDRA: CreateArtikul ---
		void UI_Rewards_Renderers_ArtifactRewardRender__CreateArtikul(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  uint uVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  uint *puVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a59a1a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Rewards_Renderers_ArtifactRewardRender_HandleOnDestroyEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59a1a = '\x01';
		  }
		  iVar7 = *(int *)(param1 + 0x10);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_UI_Rewards_Renderers_ArtifactRewardRender_HandleOnDestroyEvent__,0)
		  ;
		  if (DAT_ram_00a59a0a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a59a0a = '\x01';
		  }
		  param1_00 = *(int *)(iVar7 + 0x10);
		  do {
		    piVar4 = (int *)func_ii_7048(param1_00,uVar3,0);
		    if ((piVar4 != (int *)0x0) && (System_Action_TypeInfo != *piVar4)) {
		      System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar5 = func_ii_4329(iVar7 + 0x10,piVar4,param1_00);
		    bVar1 = iVar5 != param1_00;
		    param1_00 = iVar5;
		  } while (bVar1);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar4;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0x150);
		        goto code_r0x810aaf2d;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x810aaf2d:
		  uVar3 = (**(code **)((ulonglong)*puVar6 * 4))(piVar4,puVar6[1]);
		  Core_Gameplay_Managers_ArtifactDropManager__AddView(uVar3,param1,0);
		  *(undefined4 *)(param1 + 0x3c) = 0;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x5E8D", Offset = "0x5E8D", VA = "0x5E8D")]
		private void HandleOnDestroyEvent()
		{
		/* --- GHIDRA: HandleOnDestroyEvent ---
		void UI_Rewards_Renderers_ArtifactRewardRender__HandleOnDestroyEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  uint *puVar4;
		  int iVar5;
		  undefined4 param1_00;
		  int param1_01;
		  uint uVar6;
		  int iVar7;
		  int *piVar8;
		  int *local_4;
		  
		  iVar7 = 0;
		  if (DAT_ram_00a59a1b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_TryGetComponent_IGuideTarget___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactView__Add__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ArtifactView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a59a1b = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar5 = *(int *)(param2 + 0xc);
		  if (0 < iVar5) {
		    do {
		      param1_00 = *(undefined4 *)(param1 + 0x34);
		      uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x10),0);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      piVar2 = (int *)func_ii_6805(param1_00,uVar1,
		                                   Method_UnityEngine_Object_Instantiate_ArtifactView___);
		      uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (piVar2,0);
		      Gameplay_SmallGames_View_SmallGamesResourceRenderer__Init(uVar1,0);
		      (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x138) * 4))
		                (piVar2,*(undefined4 *)(param2 + iVar7 * 4 + 0x10),*(undefined4 *)(*piVar2 + 0x13c))
		      ;
		      iVar3 = Method_System_Collections_Generic_List_ArtifactView__Add__;
		      param1_01 = *(int *)(param1 + 0x48);
		      *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		      uVar6 = *(uint *)(param1_01 + 0xc);
		      if (uVar6 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		        *(uint *)(param1_01 + 0xc) = uVar6 + 1;
		        *(int **)(*(int *)(param1_01 + 8) + uVar6 * 4 + 0x10) = piVar2;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_01,piVar2,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38))
		        ;
		      }
		      if ((iVar7 == 0) &&
		         (iVar3 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                            (piVar2,&local_4,
		                             Method_UnityEngine_Component_TryGetComponent_IGuideTarget___),
		         piVar2 = local_4, iVar3 != 0)) {
		        iVar3 = *local_4;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar6 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8);
		            if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo == *piVar8) {
		              puVar4 = (uint *)(piVar8[1] * 8 + iVar3 + 0xe0);
		              goto code_r0x810ab10c;
		            }
		            uVar6 = uVar6 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar6);
		        }
		        puVar4 = (uint *)func_ii_1080(local_4,
		                                      Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,4);
		code_r0x810ab10c:
		        uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar2,puVar4[1]);
		        UnityEngine_Object__op_Implicit(uVar1,1,0);
		      }
		      iVar7 = iVar7 + 1;
		    } while (iVar7 != iVar5);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x5E8E", Offset = "0x5E8E", VA = "0x5E8E")]
		public void SetArtifacts(params ArtifactData[] artifacts)
		{
		/* --- GHIDRA: SetArtifacts ---
		void UI_Rewards_Renderers_ArtifactRewardRender__SetArtifacts
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59a1c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArtifactView__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArtifactView__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArtifactView__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_Func_UniTask__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactView__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Rewards_Renderers_ArtifactRewardRender___c__DisplayClass17_0__RemoveAll_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&UI_Rewards_Renderers_ArtifactRewardRender___c__DisplayClass17_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
		    DAT_ram_00a59a1c = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar2 = unnamed_function_1417
		                    (UI_Rewards_Renderers_ArtifactRewardRender___c__DisplayClass17_0_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = param2;
		  *(int *)(iVar2 + 8) = param1;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x48),
		             Method_System_Collections_Generic_List_ArtifactView__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_ArtifactView__MoveNext__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) break;
		    if (iVar3 == 0) goto code_r0x810ab2af;
		    *(undefined4 *)(local_8._4_4_ + 0x24) = 2;
		  }
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
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
		code_r0x810ab2af:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = unnamed_function_1417(System_Func_UniTask__TypeInfo);
		      System_Func_ulong___Invoke
		                (uVar4,iVar2,
		                 Method_UI_Rewards_Renderers_ArtifactRewardRender___c__DisplayClass17_0__RemoveAll_b__0__
		                 ,0);
		      if (*(int *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Cysharp_Threading_Tasks_UniTask_TypeInfo);
		      }
		      Cysharp_Threading_Tasks_UniTask__FromCanceled(&local_18,uVar4,0);
		      return;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x6b,&local_18);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
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

		// Token: 0x06000B75 RID: 2933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x5E8F", Offset = "0x5E8F", VA = "0x5E8F")]
		public void RemoveAll(IAnimationProvider provider)
		{
		/* --- GHIDRA: RemoveAll ---
		void UI_Rewards_Renderers_ArtifactRewardRender__RemoveAll
		               (undefined8 *param1,undefined4 param2,undefined4 param3,uint param4,undefined4 param5
		               )
		
		{
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_24;
		  undefined4 local_1c;
		  undefined4 uStack_18;
		  ulonglong local_14;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59a1d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_ArtifactRewardRender__RemoveAllAsync_d__18___
		              );
		    DAT_ram_00a59a1d = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  local_14 = (ulonglong)param4;
		  local_24 = 0;
		  local_28 = 0xffffffff;
		  _local_1c = CONCAT44(param3,param2);
		  if (*(int *)(
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_ArtifactRewardRender__RemoveAllAsync_d__18___
		              + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_ArtifactRewardRender__RemoveAllAsync_d__18___
		              );
		  }
		  UI_Rewards_Renderers_ArtifactRewardRender___c__DisplayClass19_0___Remove_b__0(&local_28,&local_30)
		  ;
		  Core_Analytics_Okg_OkgAnalytics__ApplyLog_d__48__MoveNext(&local_30,&local_24,0);
		  *param1 = local_30;
		  return;
		}
		*/

		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x5E90", Offset = "0x5E90", VA = "0x5E90")]
		private UniTask RemoveAllAsync(IAnimationProvider provider, CancellationToken cancellationToken)
		{
		/* --- GHIDRA: RemoveAllAsync ---
		void UI_Rewards_Renderers_ArtifactRewardRender__RemoveAllAsync
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  undefined1 auStack_8 [8];
		  
		  if (DAT_ram_00a59a1e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_UniTask__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Rewards_Renderers_ArtifactRewardRender___c__DisplayClass19_0__Remove_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&UI_Rewards_Renderers_ArtifactRewardRender___c__DisplayClass19_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
		    DAT_ram_00a59a1e = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (UI_Rewards_Renderers_ArtifactRewardRender___c__DisplayClass19_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 0x10) = param3;
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(undefined4 *)(param2_00 + 8) = param1;
		  param1_00 = unnamed_function_1417(System_Func_UniTask__TypeInfo);
		  System_Func_ulong___Invoke
		            (param1_00,param2_00,
		             Method_UI_Rewards_Renderers_ArtifactRewardRender___c__DisplayClass19_0__Remove_b__0__,0
		            );
		  if (*(int *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Cysharp_Threading_Tasks_UniTask_TypeInfo);
		  }
		  Cysharp_Threading_Tasks_UniTask__FromCanceled(auStack_8,param1_00,0);
		  return;
		}
		*/

			return default(UniTask);
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x5E91", Offset = "0x5E91", VA = "0x5E91")]
		public void Remove(ArtifactData artifactData, IAnimationProvider provider)
		{
		/* --- GHIDRA: Remove ---
		void UI_Rewards_Renderers_ArtifactRewardRender__Remove
		               (undefined8 *param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  undefined1 auStack_40 [8];
		  undefined8 local_38;
		  undefined4 local_2c;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined4 uStack_1c;
		  undefined4 local_18;
		  undefined4 uStack_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59a1f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_ArtifactRewardRender__RemoveAsync_d__20___
		              );
		    DAT_ram_00a59a1f = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_28 = 0;
		  local_2c = 0xffffffff;
		  _local_18 = CONCAT44(param5,param4);
		  _local_20 = CONCAT44(param3,param2);
		  if (*(int *)(
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_ArtifactRewardRender__RemoveAsync_d__20___
		              + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_ArtifactRewardRender__RemoveAsync_d__20___
		              );
		  }
		  UI_Rewards_Renderers_ArtifactRewardRender__RemoveAllAsync_d__18__SetStateMachine
		            (&local_2c,auStack_40);
		  Core_Analytics_Okg_OkgAnalytics__ApplyLog_d__48__MoveNext(&local_38,&local_28,0);
		  *param1 = local_38;
		  return;
		}
		*/

		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x5E92", Offset = "0x5E92", VA = "0x5E92")]
		private UniTask RemoveAsync(ArtifactData artifactData, IAnimationProvider provider, CancellationToken cancellationToken)
		{
		/* --- GHIDRA: RemoveAsync ---
		void UI_Rewards_Renderers_ArtifactRewardRender__RemoveAsync(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a59a20 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactView__get_Count__);
		    DAT_ram_00a59a20 = '\x01';
		  }
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x3c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)(0 < *(int *)(*(int *)(param1 + 0x48) + 0xc)),0);
		  if ((*(int *)(*(int *)(param1 + 0x48) + 0xc) < 1) &&
		     (iVar1 = *(int *)(*(int *)(param1 + 0x18) + 0x40), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

			return default(UniTask);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x5E93", Offset = "0x5E93", VA = "0x5E93", Slot = "11")]
		protected virtual void ValidateVisibleButtons()
		{
		/* --- GHIDRA: ValidateVisibleButtons ---
		void UI_Rewards_Renderers_ArtifactRewardRender__ValidateVisibleButtons(int param1,undefined4 param2)
		
		{
		  System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		            (*(undefined4 *)(param1 + 0x44),0);
		  System_Threading_CancellationTokenSource__Cancel(*(undefined4 *)(param1 + 0x44),0);
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x5E94", Offset = "0x5E94", VA = "0x5E94", Slot = "9")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void UI_Rewards_Renderers_ArtifactRewardRender__Dispose(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_24;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59a21 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Rewards_Renderers_ArtifactViewAnimationHandler_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Threading_CancellationTokenSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactView___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtifactView__TypeInfo);
		    DAT_ram_00a59a21 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(UI_Rewards_Renderers_ArtifactViewAnimationHandler_TypeInfo);
		  *(undefined4 *)(param1 + 0x40) = uVar1;
		  uVar1 = unnamed_function_1417(System_Threading_CancellationTokenSource_TypeInfo);
		  Gameplay_Combat_Control_Conveyor__Next(uVar1,0);
		  *(undefined4 *)(param1 + 0x44) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_ArtifactView__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_ArtifactView___ctor__);
		  *(undefined4 *)(param1 + 0x48) = uVar1;
		  local_30 = 0x3f8000003f800000;
		  local_8 = 0x3f8000003f800000;
		  local_38 = 0x3f8000003f800000;
		  local_10 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_24,&local_38,0);
		  *(undefined4 *)(param1 + 0x20) = (undefined4)local_24;
		  local_1c = 0x3f8000003f800000;
		  local_40 = 0x3f8000003f800000;
		  local_24 = 0x3f8000003f800000;
		  local_48 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_14,&local_48,0);
		  *(undefined4 *)(param1 + 0x24) = local_14;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x5E95", Offset = "0x5E95", VA = "0x5E95")]
		public ArtifactRewardRender()
		{
		}

		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArtikulView ArtikulPrefab;

		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameObject FAQPrefab;

		// Token: 0x04000539 RID: 1337
		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject LockPrefab;

		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ArtifactView ArtifactPrefab;

		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TakeSellAllButtonsView _buttonsPrefab;

		// Token: 0x0400053C RID: 1340
		[Token(Token = "0x400053C")]
		[FieldOffset(Offset = "0x3C")]
		protected TakeSellAllButtonsView _buttons;

		// Token: 0x0400053D RID: 1341
		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0x40")]
		private ArtifactViewAnimationHandler _animationHandler;

		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0x44")]
		private CancellationTokenSource _cancellationSource;

		// Token: 0x0400053F RID: 1343
		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0x48")]
		protected readonly List<ArtifactView> _currentArtifacts;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TakeAllBtn ---
		undefined4 UI_Rewards_Renderers_ArtifactRewardRender__get_TakeAllBtn(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x3c) + 0x14);
		}
		*/


		/* --- GHIDRA: get_SellAllBtn ---
		void UI_Rewards_Renderers_ArtifactRewardRender__get_SellAllBtn(int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  uint *puVar4;
		  undefined4 param2_00;
		  longlong lVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  int *piVar9;
		  uint uVar10;
		  
		  iVar8 = 0;
		  if (DAT_ram_00a59a18 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Rewards_Renderers_ArtifactRewardRender_HandleOnDestroyEvent__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_IRewardInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactView__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ArtikulView___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_GameObject___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_TakeSellAllButtonsView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a59a18 = '\x01';
		  }
		  iVar6 = param1[0x12];
		  iVar7 = *(int *)(iVar6 + 0xc);
		  *(undefined4 *)(iVar6 + 0xc) = 0;
		  *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		  if (0 < iVar7) {
		    func_ii_2064(*(undefined4 *)(iVar6 + 8),0,iVar7,0);
		  }
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  if (*(int *)(iVar6 + 0xc) != 0) {
		    iVar8 = param1[0xe];
		    uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (param1[4],0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar8 = func_ii_6805(iVar8,uVar2,Method_UnityEngine_Object_Instantiate_TakeSellAllButtonsView___
		                        );
		    param1[0xf] = iVar8;
		    iVar8 = param1[4];
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,Method_UI_Rewards_Renderers_ArtifactRewardRender_HandleOnDestroyEvent__,
		               0);
		    if (DAT_ram_00a59a09 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      DAT_ram_00a59a09 = '\x01';
		    }
		    iVar6 = *(int *)(iVar8 + 0x10);
		    do {
		      piVar3 = (int *)UnityEngine_UI_Image__set_sprite(iVar6,uVar2,0);
		      if ((piVar3 != (int *)0x0) && (System_Action_TypeInfo != *piVar3)) {
		        System_Activator__CreateInstance(piVar3,System_Action_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar7 = func_ii_4329(iVar8 + 0x10,piVar3,iVar6);
		      bVar1 = iVar7 != iVar6;
		      iVar6 = iVar7;
		    } while (bVar1);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar3;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8 + 4) * 8 + iVar8 + 0x150);
		          goto code_r0x810aa98c;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x810aa98c:
		    uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		    Core_Gameplay_Managers_ArtifactDropManager__get_Controller(uVar2,param1,0);
		    return;
		  }
		  uVar10 = 0;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  piVar3 = (int *)func_ii_7225(uVar2,0);
		  iVar6 = *piVar3;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Data_Decorators_IRewardInfo_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8)
		         ) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x810aaa34;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar10);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar3,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810aaa34:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		  uVar10 = 0;
		  iVar6 = *piVar3;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_long__TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8)) {
		        puVar4 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x810aaab2;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar10);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar3,System_Collections_Generic_ICollection_long__TypeInfo,0);
		code_r0x810aaab2:
		  iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		  if (0 < iVar6) {
		    do {
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xf4));
		      piVar3 = (int *)func_ii_7225(uVar2,0);
		      iVar7 = *piVar3;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8);
		          if (Core_Data_Decorators_IRewardInfo_TypeInfo == *piVar9) {
		            puVar4 = (uint *)(piVar9[1] * 8 + iVar7 + 0xd0);
		            goto code_r0x810aab51;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar3,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810aab51:
		      piVar3 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		      iVar7 = *piVar3;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8);
		          if (System_Collections_Generic_IList_long__TypeInfo == *piVar9) {
		            puVar4 = (uint *)(iVar7 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x810aabcf;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar3,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x810aabcf:
		      lVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar3,iVar8,puVar4[1]);
		      if (lVar5 == 0xffffffff) {
		        iVar7 = param1[0xc];
		        uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                          (param1[4],0);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        func_ii_6805(iVar7,uVar2,Method_UnityEngine_Object_Instantiate_GameObject___);
		      }
		      else if (lVar5 < 1) {
		        if (lVar5 == 0) {
		          iVar7 = param1[0xb];
		          uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                            (param1[4],0);
		          if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		            func_ii_306000(UnityEngine_Object_TypeInfo);
		          }
		          func_ii_6805(iVar7,uVar2,Method_UnityEngine_Object_Instantiate_GameObject___);
		        }
		      }
		      else {
		        uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                          (param1,iVar8,(int)lVar5,*(undefined4 *)(*param1 + 0x114));
		        iVar7 = param1[10];
		        param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                              (param1[4],0);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        piVar3 = (int *)func_ii_6805(iVar7,param2_00,
		                                     Method_UnityEngine_Object_Instantiate_ArtikulView___);
		        (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x138) * 4))
		                  (piVar3,uVar2,*(undefined4 *)(*piVar3 + 0x13c));
		      }
		      iVar8 = iVar8 + 1;
		    } while (iVar8 != iVar6);
		  }
		  return;
		}
		*/

}
