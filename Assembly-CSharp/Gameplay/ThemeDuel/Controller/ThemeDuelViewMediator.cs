using System;
using System.Collections.Generic;
using Gameplay.ThemeDuel.Events;
using Gameplay.ThemeDuel.Model;
using Gameplay.ThemeDuel.View;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Dic;

namespace Gameplay.ThemeDuel.Controller
{
	// Token: 0x020004F6 RID: 1270
	[Token(Token = "0x20004F6")]
	public class ThemeDuelViewMediator : AbstractViewMediator<ThemeDuelModel, ThemeDuelEvents, ThemeDuelController, ThemeDuelWindow>
	{
		// Token: 0x06001E4E RID: 7758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E4E")]
		[Address(RVA = "0x6FCC", Offset = "0x6FCC", VA = "0x6FCC")]
		public ThemeDuelViewMediator(ThemeDuelModel model, ThemeDuelEvents events, ThemeDuelController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58606 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelController__ThemeDuelWindow__set_View__
		              );
		    DAT_ram_00a58606 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator__ShowEventFinishedAlert(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700057F RID: 1407
		// (set) Token: 0x06001E4F RID: 7759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057F")]
		public override ThemeDuelWindow View
		{
			[Token(Token = "0x6001E4F")]
			[Address(RVA = "0x6FCD", Offset = "0x6FCD", VA = "0x6FCD", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E50")]
		[Address(RVA = "0x6FCE", Offset = "0x6FCE", VA = "0x6FCE")]
		private void ListenEventDuelState()
		{
		/* --- GHIDRA: ListenEventDuelState ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator__ListenEventDuelState
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58608 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ThemeDuelDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator_OnCurrentThemeDuelChanged__
		              );
		    DAT_ram_00a58608 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x288);
		        goto code_r0x80f1458b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f1458b:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = *(int *)(iVar5 + 0x18);
		  param1_01 = *(undefined4 *)(iVar6 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_ThemeDuelDic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator_OnCurrentThemeDuelChanged__,
		             0);
		  iVar5 = func_ii_7048(param1_01,uVar3,0);
		  uVar3 = System_Action_ThemeDuelDic__TypeInfo;
		  if (iVar5 == 0) {
		    *(undefined4 *)(iVar6 + 0x18) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar5,System_Action_ThemeDuelDic__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar6 + 0x18) = iVar4;
		    uVar3 = System_Action_ThemeDuelDic__TypeInfo;
		    iVar6 = func_ii_1082(iVar5,System_Action_ThemeDuelDic__TypeInfo);
		    if (iVar6 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar5,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar5,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E51")]
		[Address(RVA = "0x6FCF", Offset = "0x6FCF", VA = "0x6FCF")]
		private void UnlistenEventDuelState()
		{
		/* --- GHIDRA: UnlistenEventDuelState ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator__UnlistenEventDuelState
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  if (param2 == 0) {
		    Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator__OnCurrentThemeDuelChanged(0,0);
		    Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator__ListenEventDuelState(param1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E52")]
		[Address(RVA = "0x6FD0", Offset = "0x6FD0", VA = "0x6FD0")]
		private void OnCurrentThemeDuelChanged(ThemeDuelDic td)
		{
		/* --- GHIDRA: OnCurrentThemeDuelChanged ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator__OnCurrentThemeDuelChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param2_00;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 uVar3;
		  int param1_01;
		  int param1_02;
		  uint uVar4;
		  
		  if (DAT_ram_00a58609 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_DialogWindow___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator___c__DisplayClass11_0__ShowEventFinishedAlert_g__AlertOnClose_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator___c__DisplayClass11_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15051);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15050);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12610);
		    DAT_ram_00a58609 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator___c__DisplayClass11_0_TypeInfo
		                        );
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = func_ii_7508(StringLiteral_15050,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar3;
		  uVar3 = func_ii_7508(StringLiteral_15051,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar3;
		  param1_01 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_01,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  param1_02 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_02,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar3 = UI_Windows_DialogWindow__get_NO_LABEL(0);
		  *(undefined4 *)(param1_02 + 8) = uVar3;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_01 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar4 * 4 + 0x10) = param1_02;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,param1_02,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1_00 + 0x24) = param1_01;
		  uVar2 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar2,StringLiteral_12610,param1_00,
		                     Method_UI_Windows_PopupController_Show_DialogWindow___);
		  *(undefined4 *)(param2_00 + 8) = uVar2;
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param2_00,
		             Method_Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator___c__DisplayClass11_0__ShowEventFinishedAlert_g__AlertOnClose_0__
		             ,0);
		  UI_Windows_BaseWindow__get_IsActiveResourceBar(uVar2,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E53")]
		[Address(RVA = "0x6FD1", Offset = "0x6FD1", VA = "0x6FD1")]
		private void ShowEventFinishedAlert()
		{
		/* --- GHIDRA: ShowEventFinishedAlert ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator__ShowEventFinishedAlert
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5860a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator_TabChangedEventHandler__)
		    ;
		    DAT_ram_00a5860a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(iVar1 + 0x3c);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator_TabChangedEventHandler__,0);
		  UI_Tabs_TabBar__add_ChangeEvent(param1_01,param1_00,0);
		  Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator__ListenEventDuelState(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E54")]
		[Address(RVA = "0x6FD2", Offset = "0x6FD2", VA = "0x6FD2")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  int *piVar5;
		  float fVar6;
		  undefined4 uVar7;
		  int iVar8;
		  int *piVar9;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5860b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelController__ThemeDuelWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_ThemeDuelWindow_ThemeDuelWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ThemeDuelTargets__Func_IHideableMediator___get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ThemeDuelTargets__Func_IHideableMediator___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ThemeDuelTargets__Func_IHideableMediator___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ThemeDuelTargets__Func_IHideableMediator___get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&MVC_Interfaces_IHideableMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator_TabChangedEventHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_ThemeDuelTargets__Func_IHideableMediator___GetEnumerator__
		              );
		    DAT_ram_00a5860b = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar8 = *param1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar8 + 0x15c));
		  uVar7 = *(undefined4 *)(iVar2 + 0x3c);
		  uVar3 = Gameplay_ThemeDuel_Model_ThemeDuelModel__set_Prizes(iVar8,iVar8);
		  UI_Tabs_TabBar__HandleSelected(uVar7,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar7 = *(undefined4 *)(iVar2 + 0x3c);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator_TabChangedEventHandler__,0);
		  UI_Tabs_CategoryTabBarItemView___ctor(uVar7,uVar3,0);
		  uVar3 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (param1[9],
		                     Method_System_Collections_Generic_Dictionary_ThemeDuelTargets__Func_IHideableMediator___get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar3,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_ThemeDuelTargets__Func_IHideableMediator___GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xa1,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ThemeDuelTargets__Func_IHideableMediator___MoveNext__
		                      );
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f1435c;
		    }
		    if (iVar8 == 0) goto code_r0x80f143b2;
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii
		                              (*(undefined4 *)(local_8._4_4_ + 0xc),
		                               *(undefined4 *)(local_8._4_4_ + 0x20),
		                               *(undefined4 *)(local_8._4_4_ + 0x14));
		    if (DAT_ram_009d3e38 == 1) break;
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (MVC_Interfaces_IHideableMediator_TypeInfo == *piVar9) {
		          puVar4 = (undefined4 *)(iVar2 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80f142ff;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        MVC_Interfaces_IHideableMediator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x80f142ff:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(*puVar4,piVar5,puVar4[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f1435c:
		  iVar2 = global_1;
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar8) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar8 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar8;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		      if (iVar8 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80f143b2:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar2 = func_ii_8093(uVar3,
		                           Method_UI_Windows_BaseWindow_ThemeDuelWindow_ThemeDuelWindowArgs__get_WindowArgs__
		                          );
		      iVar8 = *(int *)(iVar2 + 0x18);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar8 = iVar8 + -1;
		      if (iVar8 < 1) {
		        iVar8 = 0;
		      }
		      Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		                (*(undefined4 *)(iVar2 + 0x3c),iVar8,0,0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      piVar5 = *(int **)(iVar2 + 0x4c);
		      iVar2 = *(int *)(param1[2] + 0x14);
		      fVar6 = func_ii_7103(*(undefined4 *)(iVar2 + 0x34),0);
		      if (0.0 < fVar6) {
		        uVar3 = *(undefined4 *)(iVar2 + 0x10);
		      }
		      else {
		        uVar3 = 0;
		      }
		      uVar3 = Core_Extensions_Dict_ThemeDuelDicExt__GetImgForRulesAssetId(uVar3,0);
		      (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x2d0) * 4))
		                (piVar5,uVar3,*(undefined4 *)(*piVar5 + 0x2d4));
		      Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator__set_View(param1,piVar5);
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x189,&local_18);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
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

		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E55")]
		[Address(RVA = "0x6FD3", Offset = "0x6FD3", VA = "0x6FD3")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator__SetupView(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  int *param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a5860c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ThemeDuelTargets__Func_IHideableMediator___get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&MVC_Interfaces_IHideableMediator_TypeInfo);
		    DAT_ram_00a5860c = '\x01';
		  }
		  param1_00 = (int *)param1[10];
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (MVC_Interfaces_IHideableMediator_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80f14a4f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,MVC_Interfaces_IHideableMediator_TypeInfo,0);
		code_r0x80f14a4f:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  }
		  param1_01 = param1[9];
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar3 + 0x3c),0);
		  iVar3 = GAFInternal_Reader_GAFReader__OpenTag
		                    (param1_01,*(undefined4 *)(iVar3 + 0x14),
		                     Method_System_Collections_Generic_Dictionary_ThemeDuelTargets__Func_IHideableMediator___get_Item__
		                    );
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                    (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  param1[10] = iVar3;
		  return;
		}
		*/

		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E56")]
		[Address(RVA = "0x6FD4", Offset = "0x6FD4", VA = "0x6FD4")]
		private void TabChangedEventHandler()
		{
		/* --- GHIDRA: TabChangedEventHandler ---
		int Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator__TabChangedEventHandler
		              (int *param1,undefined4 param2)
		
		{
		  undefined4 param4;
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5860d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelController__ThemeDuelWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuel_Controller_RulesViewMediator_TypeInfo);
		    DAT_ram_00a5860d = '\x01';
		  }
		  piVar3 = (int *)param1[6];
		  if (piVar3 == (int *)0x0) {
		    iVar2 = param1[2];
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x14c));
		    piVar3 = (int *)unnamed_function_1417(Gameplay_ThemeDuel_Controller_RulesViewMediator_TypeInfo);
		    if (DAT_ram_00a585d9 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelController__RulesView___ctor__
		                );
		      DAT_ram_00a585d9 = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar3,iVar2,uVar1,param4,
		               Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelController__RulesView___ctor__
		              );
		    param1[6] = (int)piVar3;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x140) * 4))
		            (piVar3,uVar1,*(undefined4 *)(*piVar3 + 0x144));
		  piVar3 = (int *)param1[6];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x160) * 4))
		            (piVar3,*(undefined4 *)(iVar2 + 0x40),*(undefined4 *)(iVar4 + 0x164));
		  return param1[6];
		}
		*/

		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001E57")]
		[Address(RVA = "0x6FD5", Offset = "0x6FD5", VA = "0x6FD5")]
		private IHideableMediator ShowRulesTab()
		{
		/* --- GHIDRA: ShowRulesTab ---
		int Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator__ShowRulesTab(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 param2_00;
		  undefined4 param4;
		  int iVar4;
		  
		  if (DAT_ram_00a5860e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelController__ThemeDuelWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_TypeInfo);
		    DAT_ram_00a5860e = '\x01';
		  }
		  piVar3 = (int *)param1[7];
		  if (piVar3 == (int *)0x0) {
		    param2_00 = *(undefined4 *)(param1[2] + 0x10);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    iVar4 = **(int **)(iVar1 + 0x18);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x110) * 4))
		                      (*(int **)(iVar1 + 0x18),*(undefined4 *)(iVar4 + 0x114));
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    param4 = *(undefined4 *)(iVar1 + 0x18);
		    iVar1 = unnamed_function_1417
		                      (Gameplay_ThemeDuel_Controller_ThemeDuelRatingViewMediator_TypeInfo);
		    if (DAT_ram_00a585e5 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView___ctor__
		                );
		      DAT_ram_00a585e5 = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (iVar1,param2_00,uVar2,param4,
		               Method_MVC_AbstractViewMediator_ThemeDuelRatingModel__RatingEvents__ThemeDuelRatingController__RatingView___ctor__
		              );
		    param1[7] = iVar1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar1 = *(int *)(iVar1 + 0x44);
		    if (DAT_ram_00a585cd == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInCommonRatingsViewsHolder__Init__
		                );
		      DAT_ram_00a585cd = '\x01';
		    }
		    Com_TheFallenGames_OSA_Core_OSA_object__object___GetVirtualAbstractNormalizedScrollPosition
		              (*(undefined4 *)(iVar1 + 0x24),
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInCommonRatingsViewsHolder__Init__
		              );
		    piVar3 = (int *)param1[7];
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar4 = **(int **)(iVar1 + 0x18);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x110) * 4))
		                    (*(int **)(iVar1 + 0x18),*(undefined4 *)(iVar4 + 0x114));
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x140) * 4))
		            (piVar3,uVar2,*(undefined4 *)(*piVar3 + 0x144));
		  piVar3 = (int *)param1[7];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x160) * 4))
		            (piVar3,*(undefined4 *)(iVar1 + 0x44),*(undefined4 *)(iVar4 + 0x164));
		  return param1[7];
		}
		*/

			return null;
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001E58")]
		[Address(RVA = "0x6FD6", Offset = "0x6FD6", VA = "0x6FD6")]
		private IHideableMediator ShowRatingTab()
		{
		/* --- GHIDRA: ShowRatingTab ---
		int Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator__ShowRatingTab
		              (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 param4;
		  int iVar4;
		  
		  if (DAT_ram_00a5860f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelController__ThemeDuelWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuel_Controller_ThemeDuelShopViewMediator_TypeInfo);
		    DAT_ram_00a5860f = '\x01';
		  }
		  piVar3 = (int *)param1[8];
		  if (piVar3 == (int *)0x0) {
		    iVar4 = param1[2];
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    param4 = *(undefined4 *)(iVar2 + 0x1c);
		    piVar3 = (int *)unnamed_function_1417
		                              (Gameplay_ThemeDuel_Controller_ThemeDuelShopViewMediator_TypeInfo);
		    if (DAT_ram_00a585ff == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelShopController__ShopView___ctor__
		                );
		      DAT_ram_00a585ff = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar3,iVar4,uVar1,param4,
		               Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelShopController__ShopView___ctor__
		              );
		    param1[8] = (int)piVar3;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x140) * 4))
		            (piVar3,uVar1,*(undefined4 *)(*piVar3 + 0x144));
		  piVar3 = (int *)param1[8];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x160) * 4))
		            (piVar3,*(undefined4 *)(iVar2 + 0x48),*(undefined4 *)(iVar4 + 0x164));
		  return param1[8];
		}
		*/

			return null;
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001E59")]
		[Address(RVA = "0x6FD7", Offset = "0x6FD7", VA = "0x6FD7")]
		private IHideableMediator ShowShopTab()
		{
		/* --- GHIDRA: ShowShopTab ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator__ShowShopTab(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a58610 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelController__ThemeDuelWindow__Dispose__
		              );
		    DAT_ram_00a58610 = '\x01';
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelController__ThemeDuelWindow__Dispose__
		            );
		  Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator__ListenEventDuelState(param1,param1);
		  piVar1 = *(int **)(param1 + 0x1c);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  piVar1 = *(int **)(param1 + 0x20);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  piVar1 = *(int **)(param1 + 0x18);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E5A")]
		[Address(RVA = "0x6FD8", Offset = "0x6FD8", VA = "0x6FD8", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x04001078 RID: 4216
		[Token(Token = "0x4001078")]
		[FieldOffset(Offset = "0x18")]
		private RulesViewMediator _rulesViewMediator;

		// Token: 0x04001079 RID: 4217
		[Token(Token = "0x4001079")]
		[FieldOffset(Offset = "0x1C")]
		private ThemeDuelRatingViewMediator _tdRatingViewMediator;

		// Token: 0x0400107A RID: 4218
		[Token(Token = "0x400107A")]
		[FieldOffset(Offset = "0x20")]
		private ThemeDuelShopViewMediator _tdShopViewMediator;

		// Token: 0x0400107B RID: 4219
		[Token(Token = "0x400107B")]
		[FieldOffset(Offset = "0x24")]
		private readonly Dictionary<ThemeDuelTargets, Func<IHideableMediator>> _tabsOpenersById;

		// Token: 0x0400107C RID: 4220
		[Token(Token = "0x400107C")]
		[FieldOffset(Offset = "0x28")]
		private IHideableMediator _currentMediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator__set_View
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58607 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ThemeDuelDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator_OnCurrentThemeDuelChanged__
		              );
		    DAT_ram_00a58607 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x288);
		        goto code_r0x80f146e9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f146e9:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = *(int *)(iVar5 + 0x18);
		  param1_01 = *(undefined4 *)(iVar6 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_ThemeDuelDic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator_OnCurrentThemeDuelChanged__,
		             0);
		  iVar5 = UnityEngine_UI_Image__set_sprite(param1_01,uVar3,0);
		  uVar3 = System_Action_ThemeDuelDic__TypeInfo;
		  if (iVar5 == 0) {
		    *(undefined4 *)(iVar6 + 0x18) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar5,System_Action_ThemeDuelDic__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar6 + 0x18) = iVar4;
		    uVar3 = System_Action_ThemeDuelDic__TypeInfo;
		    iVar6 = func_ii_1082(iVar5,System_Action_ThemeDuelDic__TypeInfo);
		    if (iVar6 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar5,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar5,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
