using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core.Data;
using Gameplay.Craft.Controller.Filters;
using Gameplay.Craft.Events;
using Gameplay.Craft.Model;
using Gameplay.Craft.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Craft;
using Protocol.Dic;
using Protocol.Main;
using UI.Filters;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Craft.Controller
{
	// Token: 0x020008C8 RID: 2248
	[Token(Token = "0x20008C8")]
	public class CraftViewMediator : AbstractViewMediator<CraftModel, Gameplay.Craft.Events.CraftEvents, CraftController, CraftWindow>
	{
		// Token: 0x060034DD RID: 13533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034DD")]
		[Address(RVA = "0x8506", Offset = "0x8506", VA = "0x8506")]
		public CraftViewMediator(CraftModel model, Gameplay.Craft.Events.CraftEvents events, CraftController controller)
		{
		/* --- GHIDRA: <DeleteButtonClickedEventHandler>b__79_0 ---
		void Gameplay_Craft_Controller_CraftViewMediator___DeleteButtonClickedEventHandler_b__79_0
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63a77 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		    DAT_ram_00a63a77 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <MaxLevelButtonClickedEventHandler>b__76_0 ---
		void Gameplay_Craft_Controller_CraftViewMediator___MaxLevelButtonClickedEventHandler_b__76_0
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Craft_Controller_CraftController__GetUserSchemesResultHandler
		            (param1_00,*(undefined4 *)(param2 + 8),param1);
		  return;
		}
		*/

		/* --- GHIDRA: <SellAllButtonClickedEventHandler>g__GetArtifactData|72_0 ---
		uint Gameplay_Craft_Controller_CraftViewMediator___SellAllButtonClickedEventHandler_g__GetArtifactData_72_0
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a63a76 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__get_Model__
		              );
		    DAT_ram_00a63a76 = '\x01';
		  }
		  return (uint)(*(int *)(param2 + 0xc) == *(int *)(*(int *)(*(int *)(param1 + 8) + 0x14) + 0x10) + 1
		               );
		}
		*/

		/* --- GHIDRA: <ShowAccelerateConfirmationWindow>b__55_0 ---
		undefined4
		Gameplay_Craft_Controller_CraftViewMediator___ShowAccelerateConfirmationWindow_b__55_0
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a63a75 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a63a75 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x158);
		        goto code_r0x823349a6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x823349a6:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Core_Gameplay_Managers_CacheManager__GetEndOfFrameCacheRequestAccumulator(uVar3,0);
		  uVar3 = func_ii_8553(uVar3,param2,*(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		  return uVar3;
		}
		*/

		/* --- GHIDRA: <RedrawRecipesList>b__44_1 ---
		void Gameplay_Craft_Controller_CraftViewMediator___RedrawRecipesList_b__44_1
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (DAT_ram_00a63a4d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__);
		    DAT_ram_00a63a4d = '\x01';
		  }
		  iVar1 = System_Linq_Enumerable__ToList_object_
		                    (param1[0xb],param1[0xc],
		                     Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__);
		  Gameplay_Craft_Controller_CraftController__CancelCraftResultHandler
		            (param1_00,*(undefined4 *)(*(int *)(iVar1 + 0x48) + 0xc),param1);
		  return;
		}
		*/

		/* --- GHIDRA: <RedrawRecipesList>b__44_0 ---
		uint Gameplay_Craft_Controller_CraftViewMediator___RedrawRecipesList_b__44_0
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a63a74 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_CraftWindow_CraftWindowArgs__get_WindowArgs__);
		    DAT_ram_00a63a74 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(param2 + 0x10) + 0xc) + 8) + 0xc);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(param1_00,
		                       Method_UI_Windows_BaseWindow_CraftWindow_CraftWindowArgs__get_WindowArgs__);
		  return (uint)(iVar2 == *(int *)(iVar1 + 0x18));
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Craft_Controller_CraftViewMediator___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63a4d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__);
		    DAT_ram_00a63a4d = '\x01';
		  }
		  uVar1 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(param1 + 0x2c),*(undefined4 *)(param1 + 0x30),
		                     Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__);
		  return uVar1;
		}
		*/

		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x060034DE RID: 13534 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A77")]
		private CraftSlotListElement SelectedSlot
		{
			[Token(Token = "0x60034DE")]
			[Address(RVA = "0x8507", Offset = "0x8507", VA = "0x8507")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (set) Token: 0x060034DF RID: 13535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A78")]
		public override CraftWindow View
		{
			[Token(Token = "0x60034DF")]
			[Address(RVA = "0x8508", Offset = "0x8508", VA = "0x8508", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (set) Token: 0x060034E0 RID: 13536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A79")]
		public override Gameplay.Craft.Events.CraftEvents Events
		{
			[Token(Token = "0x60034E0")]
			[Address(RVA = "0x8509", Offset = "0x8509", VA = "0x8509", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (set) Token: 0x060034E1 RID: 13537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A7A")]
		public override CraftController Controller
		{
			[Token(Token = "0x60034E1")]
			[Address(RVA = "0x850A", Offset = "0x850A", VA = "0x850A", Slot = "18")]
			set
			{
			}
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E2")]
		[Address(RVA = "0x850B", Offset = "0x850B", VA = "0x850B")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Craft_Controller_CraftViewMediator__Init
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63a52 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Count__);
		    DAT_ram_00a63a52 = '\x01';
		  }
		  if ((*(int *)(*(int *)(param3 + 0x38) + 0xc) == 0) && (*(longlong *)(param3 + 0x20) == 0)) {
		    func_ii_17558(param2,param3,0);
		    return;
		  }
		  param2_00 = Gameplay_Craft_View_CraftSlotListElement__DisplayEmptySlot
		                        (*(undefined4 *)(param1 + 8),*(undefined4 *)(param3 + 0x18),param3);
		  Gameplay_Craft_Model_CraftModel__GetSchemeInfo(param2,param2_00,param3,0);
		  return;
		}
		*/

		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E3")]
		[Address(RVA = "0x850C", Offset = "0x850C", VA = "0x850C")]
		private void HandleActiveSlot(CraftSlotListElement slot, UserCraftSlotInfo slotInfo)
		{
		/* --- GHIDRA: HandleActiveSlot ---
		void Gameplay_Craft_Controller_CraftViewMediator__HandleActiveSlot(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a63a53 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSchemeData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_CraftWindowStates_State__set_CurrentState__);
		    DAT_ram_00a63a53 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1[2] + 0xc) + 0xc);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar2 == 0) {
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(iVar1 + 0x3c),3,
		               Method_UI_MonoBehaviourWithStates_CraftWindowStates_State__set_CurrentState__);
		    return;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x3c),1,
		             Method_UI_MonoBehaviourWithStates_CraftWindowStates_State__set_CurrentState__);
		  Gameplay_Craft_Controller_CraftViewMediator__PopulateFiltersData(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E4")]
		[Address(RVA = "0x850D", Offset = "0x850D", VA = "0x850D")]
		private void HandleRecipesView()
		{
		/* --- GHIDRA: HandleRecipesView ---
		void Gameplay_Craft_Controller_CraftViewMediator__HandleRecipesView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63a54 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSlotListElement__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_CraftWindowStates_State__set_CurrentState__);
		    DAT_ram_00a63a54 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x3c),2,
		             Method_UI_MonoBehaviourWithStates_CraftWindowStates_State__set_CurrentState__);
		  if (0 < *(int *)(param1[0xb] + 0xc)) {
		    param2_00 = System_Linq_Enumerable__ToList_object_
		                          (param1[0xb],0,
		                           Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__);
		    Gameplay_Craft_Controller_CraftViewMediator__SelectCraftRecipeListElement
		              (param1,param2_00,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E5")]
		[Address(RVA = "0x850E", Offset = "0x850E", VA = "0x850E")]
		private void HandleCraftSlotsView()
		{
		/* --- GHIDRA: HandleCraftSlotsView ---
		int Gameplay_Craft_Controller_CraftViewMediator__HandleCraftSlotsView
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63a55 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CraftRecipeListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Craft_View_CraftRecipeListElement_CraftRecipeListElementArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftViewMediator_CraftRecipeButtonClickedEventHandler__
		              );
		    DAT_ram_00a63a55 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Craft_View_CraftRecipeListElement_CraftRecipeListElementArgs_TypeInfo
		                        );
		  UnityEngine_InputSystem_LowLevel_SelectObservable___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___Subscribe
		            (param1_00,0);
		  *(undefined4 *)(param1_00 + 0x10) = param2;
		  param1_01 = unnamed_function_1417(System_Action_CraftRecipeListElement__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Craft_Controller_CraftViewMediator_CraftRecipeButtonClickedEventHandler__
		             ,0);
		  *(undefined4 *)(param1_00 + 0x14) = param1_01;
		  return param1_00;
		}
		*/

		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034E6")]
		[Address(RVA = "0x850F", Offset = "0x850F", VA = "0x850F")]
		private CraftRecipeListElement.CraftRecipeListElementArgs ConstructArgs(CraftSchemeData data)
		{
		/* --- GHIDRA: ConstructArgs ---
		void Gameplay_Craft_Controller_CraftViewMediator__ConstructArgs
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63a56 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_CraftWindowStates_State__get_CurrentState__);
		    DAT_ram_00a63a56 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(*(int *)(iVar1 + 0x3c) + 0x18) == 1) {
		    if (param1[9] != 0) {
		      Gameplay_Craft_View_CraftRecipeListElement_CraftRecipeListElementArgs__get_Selected
		                (param1[9],0,0);
		    }
		    param1[9] = param2;
		    param1[0xd] = *(int *)(*(int *)(*(int *)(param2 + 0x10) + 8) + 0xc);
		    Gameplay_Craft_View_CraftRecipeListElement_CraftRecipeListElementArgs__get_Selected(param2,1,0);
		    Gameplay_Craft_Controller_CraftViewMediator__SelectCraftSlotListElement
		              (param1,*(undefined4 *)(param2 + 0x10),param1);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E7")]
		[Address(RVA = "0x8510", Offset = "0x8510", VA = "0x8510")]
		private void SelectCraftRecipeListElement(CraftRecipeListElement.CraftRecipeListElementArgs args)
		{
		/* --- GHIDRA: SelectCraftRecipeListElement ---
		void Gameplay_Craft_Controller_CraftViewMediator__SelectCraftRecipeListElement
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63a57 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSlotListElement__IndexOf__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSlotListElement__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_CraftWindowStates_State__get_CurrentState__);
		    DAT_ram_00a63a57 = '\x01';
		  }
		  local_8 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(*(int *)(iVar1 + 0x3c) + 0x18) == 2) {
		    iVar1 = param1[0xc];
		    param1_00 = param1[0xb];
		    if (iVar1 < *(int *)(param1_00 + 0xc)) {
		      if (DAT_ram_00a63a4d == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__);
		        DAT_ram_00a63a4d = '\x01';
		        iVar1 = param1[0xc];
		        param1_00 = param1[0xb];
		      }
		      uVar2 = System_Linq_Enumerable__ToList_object_
		                        (param1_00,iVar1,
		                         Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__);
		      Gameplay_Craft_View_CraftSlotListElement__InitManufacture(uVar2,0,0);
		      param1_00 = param1[0xb];
		    }
		    iVar1 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                      (param1_00,param2,
		                       Method_System_Collections_Generic_List_CraftSlotListElement__IndexOf__);
		    param1[0xc] = iVar1;
		    Gameplay_Craft_View_CraftSlotListElement__InitManufacture(param2,1,0);
		    iVar1 = Gameplay_Craft_Model_CraftModel__SetCraftSlots
		                      (param1[2],*(undefined4 *)(*(int *)(param2 + 0x48) + 0xc),&local_8,param1);
		    if (iVar1 != 0) {
		      Gameplay_Craft_Controller_CraftViewMediator__ShowAccelerateConfirmationWindow(param1,param1);
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		      Gameplay_Craft_Controller_CraftController__GetUserProfessionsResultHandler(uVar2,param1);
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Craft_View_CraftInfoBox__UpdateInfo
		              (*(undefined4 *)(iVar1 + 0x4c),*(undefined4 *)(param1[2] + 8),param2,local_8,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E8")]
		[Address(RVA = "0x8511", Offset = "0x8511", VA = "0x8511")]
		private void SelectCraftSlotListElement(CraftSlotListElement element)
		{
		/* --- GHIDRA: SelectCraftSlotListElement ---
		void Gameplay_Craft_Controller_CraftViewMediator__SelectCraftSlotListElement
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 param4;
		  undefined4 param2_00;
		  int *param1_00;
		  
		  if (DAT_ram_00a63a58 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_Controller_Filters_ICraftFilter_TypeInfo);
		    DAT_ram_00a63a58 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x4c) + 0x50),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x4c) + 0x54),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x4c);
		  param2_00 = *(undefined4 *)(param1[2] + 8);
		  param1_00 = (int *)param1[7];
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Craft_Controller_Filters_ICraftFilter_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		        goto code_r0x82331131;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Gameplay_Craft_Controller_Filters_ICraftFilter_TypeInfo,2)
		  ;
		code_r0x82331131:
		  param4 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,param2,puVar4[1]);
		  Gameplay_Craft_View_CraftInfoBox__get_RentGroup(uVar3,param2_00,param2,param4,0);
		  return;
		}
		*/

		}

		// Token: 0x060034E9 RID: 13545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E9")]
		[Address(RVA = "0x8512", Offset = "0x8512", VA = "0x8512")]
		private void UpdateRecipeInfo(CraftSchemeData data)
		{
		/* --- GHIDRA: UpdateRecipeInfo ---
		void Gameplay_Craft_Controller_CraftViewMediator__UpdateRecipeInfo(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63a59 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__ICraftFilter__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__ICraftFilter__get_Keys__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__ICraftFilter__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__ICraftFilter__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__ICraftFilter__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_Controller_Filters_ICraftFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_FilterInfo_FilterType__ICraftFilter__GetEnumerator__
		              );
		    DAT_ram_00a63a59 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (param1[6],
		                     Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__ICraftFilter__get_Keys__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_KeyCollection_FilterInfo_FilterType__ICraftFilter__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x96,&local_10,
		                       Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__ICraftFilter__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8232f654;
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    piVar5 = (int *)import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,param1[6],
		                               local_8._4_4_,
		                               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__ICraftFilter__get_Item__
		                              );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8232f654;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8232f654;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,
		                       *(undefined4 *)(*(int *)(iVar3 + 0x48) + 0x38),uVar2,
		                       Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		                      );
		    if (DAT_ram_009d3e38 == 1) break;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Gameplay_Craft_Controller_Filters_ICraftFilter_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 200);
		          goto code_r0x8232f5e1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Gameplay_Craft_Controller_Filters_ICraftFilter_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x8232f5e1:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar4,piVar5,uVar2,puVar4[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8232f654:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x21,&local_18);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 != 1) {
		    import::env::__resumeException(uVar2);
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

		}

		// Token: 0x060034EA RID: 13546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034EA")]
		[Address(RVA = "0x8513", Offset = "0x8513", VA = "0x8513")]
		private void PopulateFiltersData()
		{
		/* --- GHIDRA: PopulateFiltersData ---
		void Gameplay_Craft_Controller_CraftViewMediator__PopulateFiltersData(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a63a5a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Array_IndexOf_CraftRecipeListElement_CraftRecipeListElementArgs___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator_ConstructArgs__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator__RedrawRecipesList_b__44_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator__RedrawRecipesList_b__44_1__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_FirstOrDefault_CraftRecipeListElement_CraftRecipeListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_CraftSchemeData__CraftRecipeListElement_CraftRecipeListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_CraftRecipeListElement_CraftRecipeListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_CraftSchemeData__CraftRecipeListElement_CraftRecipeListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_CraftRecipeListElement_CraftRecipeListElementArgs__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSchemeData__get_Count__);
		    DAT_ram_00a63a5a = '\x01';
		  }
		  iVar5 = *(int *)(param1[2] + 0xc);
		  uVar1 = Gameplay_Craft_Controller_CraftViewMediator__RedrawRecipesList(param1,iVar5,param1);
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Func_CraftSchemeData__CraftRecipeListElement_CraftRecipeListElementArgs__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar2,param1,Method_Gameplay_Craft_Controller_CraftViewMediator_ConstructArgs__,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar1,uVar2,
		                     Method_System_Linq_Enumerable_Select_CraftSchemeData__CraftRecipeListElement_CraftRecipeListElementArgs___
		                    );
		  iVar3 = func_ii_6295(uVar1,
		                       Method_System_Linq_Enumerable_ToArray_CraftRecipeListElement_CraftRecipeListElementArgs___
		                      );
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Craft_View_CraftWindow__OnClose(uVar1,iVar3,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Filters_FiltersView__AchievedToggleOnChangedEvent
		            (*(undefined4 *)(iVar4 + 0x48),*(undefined4 *)(iVar3 + 0xc),*(undefined4 *)(iVar5 + 0xc)
		             ,0);
		  uVar1 = unnamed_function_1417
		                    (System_Func_CraftRecipeListElement_CraftRecipeListElementArgs__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param1,
		             Method_Gameplay_Craft_Controller_CraftViewMediator__RedrawRecipesList_b__44_0__,0);
		  iVar4 = System_Func_object__bool____ctor
		                    (iVar3,uVar1,
		                     Method_System_Linq_Enumerable_FirstOrDefault_CraftRecipeListElement_CraftRecipeListElementArgs___
		                    );
		  if (iVar4 == 0) {
		    if (*(int *)(iVar3 + 0xc) != 0) {
		      uVar1 = unnamed_function_1417
		                        (
		                        System_Func_CraftRecipeListElement_CraftRecipeListElementArgs__bool__TypeInfo
		                        );
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (uVar1,param1,
		                 Method_Gameplay_Craft_Controller_CraftViewMediator__RedrawRecipesList_b__44_1__,0);
		      iVar4 = System_Func_object__bool____ctor
		                        (iVar3,uVar1,
		                         Method_System_Linq_Enumerable_FirstOrDefault_CraftRecipeListElement_CraftRecipeListElementArgs___
		                        );
		      if (iVar4 != 0) {
		        if (DAT_ram_00a63a56 == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&Method_UI_MonoBehaviourWithStates_CraftWindowStates_State__get_CurrentState__)
		          ;
		          DAT_ram_00a63a56 = '\x01';
		        }
		        iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        if (*(int *)(*(int *)(iVar5 + 0x3c) + 0x18) == 1) {
		          if (param1[9] != 0) {
		            Gameplay_Craft_View_CraftRecipeListElement_CraftRecipeListElementArgs__get_Selected
		                      (param1[9],0,0);
		          }
		          param1[9] = iVar4;
		          param1[0xd] = *(int *)(*(int *)(*(int *)(iVar4 + 0x10) + 8) + 0xc);
		          Gameplay_Craft_View_CraftRecipeListElement_CraftRecipeListElementArgs__get_Selected
		                    (iVar4,1,0);
		          Gameplay_Craft_Controller_CraftViewMediator__SelectCraftSlotListElement
		                    (param1,*(undefined4 *)(iVar4 + 0x10),param1);
		        }
		        uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        uVar2 = LunarConsolePlugin_CVar__set_Value
		                          (iVar3,iVar4,
		                           Method_System_Array_IndexOf_CraftRecipeListElement_CraftRecipeListElementArgs___
		                          );
		        Gameplay_Craft_View_CraftWindow__SetCounter(uVar1,uVar2,0);
		        return;
		      }
		      iVar3 = *(int *)(iVar3 + 0x10);
		      if (DAT_ram_00a63a56 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_UI_MonoBehaviourWithStates_CraftWindowStates_State__get_CurrentState__);
		        DAT_ram_00a63a56 = '\x01';
		      }
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      if (*(int *)(*(int *)(iVar4 + 0x3c) + 0x18) == 1) {
		        if (param1[9] != 0) {
		          Gameplay_Craft_View_CraftRecipeListElement_CraftRecipeListElementArgs__get_Selected
		                    (param1[9],0,0);
		        }
		        param1[9] = iVar3;
		        param1[0xd] = *(int *)(*(int *)(*(int *)(iVar3 + 0x10) + 8) + 0xc);
		        Gameplay_Craft_View_CraftRecipeListElement_CraftRecipeListElementArgs__get_Selected
		                  (iVar3,1,0);
		        Gameplay_Craft_Controller_CraftViewMediator__SelectCraftSlotListElement
		                  (param1,*(undefined4 *)(iVar3 + 0x10),param1);
		      }
		    }
		  }
		  else {
		    if (DAT_ram_00a63a56 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_UI_MonoBehaviourWithStates_CraftWindowStates_State__get_CurrentState__);
		      DAT_ram_00a63a56 = '\x01';
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (*(int *)(*(int *)(iVar3 + 0x3c) + 0x18) == 1) {
		      if (param1[9] != 0) {
		        Gameplay_Craft_View_CraftRecipeListElement_CraftRecipeListElementArgs__get_Selected
		                  (param1[9],0,0);
		      }
		      param1[9] = iVar4;
		      param1[0xd] = *(int *)(*(int *)(*(int *)(iVar4 + 0x10) + 8) + 0xc);
		      Gameplay_Craft_View_CraftRecipeListElement_CraftRecipeListElementArgs__get_Selected(iVar4,1,0)
		      ;
		      Gameplay_Craft_Controller_CraftViewMediator__SelectCraftSlotListElement
		                (param1,*(undefined4 *)(iVar4 + 0x10),param1);
		      return;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060034EB RID: 13547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034EB")]
		[Address(RVA = "0x8514", Offset = "0x8514", VA = "0x8514")]
		private void RedrawRecipesList()
		{
		/* --- GHIDRA: RedrawRecipesList ---
		/* WARNING: Removing unreachable block (ram,0x82330da8) */
		
		int Gameplay_Craft_Controller_CraftViewMediator__RedrawRecipesList
		              (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 *puVar6;
		  undefined4 uVar7;
		  undefined4 param3_00;
		  int iVar8;
		  int *piVar9;
		  int *piVar10;
		  int iVar11;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  int local_20;
		  int **local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  int *local_4;
		  
		  if (DAT_ram_00a63a5b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__ICraftFilter__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__ICraftFilter__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__ICraftFilter__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__ICraftFilter__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_Controller_Filters_ICraftFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_CraftSchemeData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_CraftSchemeData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CraftSchemeData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CraftSchemeData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_CraftSchemeData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_FilterInfo_FilterType__ICraftFilter__GetEnumerator__
		              );
		    DAT_ram_00a63a5b = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_10 = 0;
		  local_18 = 0;
		  iVar4 = unnamed_function_1417(System_Collections_Generic_List_CraftSchemeData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar4,Method_System_Collections_Generic_List_CraftSchemeData___ctor__);
		  iVar11 = *param2;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_CraftSchemeData__TypeInfo ==
		          *(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x82330934;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_IEnumerable_CraftSchemeData__TypeInfo,0);
		code_r0x82330934:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(param2,puVar5[1]);
		  local_20 = 0;
		  local_1c = &local_4;
		code_r0x82330959:
		  do {
		    do {
		      piVar9 = local_4;
		      iVar11 = *local_4;
		      if (*(ushort *)(iVar11 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		            puVar6 = (undefined4 *)(iVar11 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x82330a03;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar11 + 0xb6) != uVar2);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar6 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x82330a47:
		        DAT_ram_009d3e38 = 0;
		        uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar11 = global_1;
		        goto code_r0x82330edd;
		      }
		code_r0x82330a03:
		      DAT_ram_009d3e38 = 0;
		      iVar11 = import::env::invoke_iii(*puVar6,piVar9,puVar6[1]);
		      piVar9 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x82330a47;
		      if (iVar11 == 0) goto code_r0x82330f24;
		      iVar11 = *local_4;
		      if (*(ushort *)(iVar11 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8);
		          if (System_Collections_Generic_IEnumerator_CraftSchemeData__TypeInfo == *piVar10) {
		            puVar6 = (undefined4 *)(iVar11 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x82330af2;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar11 + 0xb6) != uVar2);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar6 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_CraftSchemeData__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x82330bc9:
		        DAT_ram_009d3e38 = 0;
		        uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar11 = global_1;
		        goto code_r0x82330edd;
		      }
		code_r0x82330af2:
		      DAT_ram_009d3e38 = 0;
		      param3_00 = import::env::invoke_iii(*puVar6,piVar9,puVar6[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x82330bc9;
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x9f,
		                         *(undefined4 *)(param1 + 0x18),
		                         Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__ICraftFilter__get_Values__
		                        );
		      iVar11 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar11 == 1) {
		        uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar11 = global_1;
		        goto code_r0x82330edd;
		      }
		      DAT_ram_009d3e38 = 0;
		      System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		                (&local_30,uVar7,
		                 Method_System_Collections_Generic_Dictionary_ValueCollection_FilterInfo_FilterType__ICraftFilter__GetEnumerator__
		                );
		      iVar11 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar11 == 1) {
		        uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar11 = global_1;
		        goto code_r0x82330edd;
		      }
		      local_10 = local_28;
		      local_18 = CONCAT44(puStack_2c,local_30);
		      local_30 = 0;
		      puStack_2c = &local_18;
		      do {
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xa1,&local_18,
		                           Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__ICraftFilter__MoveNext__
		                          );
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x82330d20:
		          DAT_ram_009d3e38 = 0;
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar11 = global_1;
		          iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar11 == iVar8) {
		            piVar9 = (int *)import::env::__cxa_begin_catch(uVar7);
		            iVar8 = *piVar9;
		            iVar3 = 0;
		            DAT_ram_009d3e38 = 0;
		            local_30 = iVar8;
		            import::env::invoke_v(0x123);
		            iVar11 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            uVar2 = 1;
		            if (iVar11 != 1) goto code_r0x82330d7a;
		            uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar11 = global_1;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x22,&local_30);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 != 1) goto code_r0x82330edd;
		          goto code_r0x82330ff8;
		        }
		        if (uVar2 == 0) break;
		        piVar9 = local_10._4_4_;
		        iVar11 = *local_10._4_4_;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		            if (Gameplay_Craft_Controller_Filters_ICraftFilter_TypeInfo == *piVar10) {
		              puVar6 = (undefined4 *)(piVar10[1] * 8 + iVar11 + 0xd0);
		              goto code_r0x82330cc9;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar6 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_10._4_4_,
		                            Gameplay_Craft_Controller_Filters_ICraftFilter_TypeInfo,2);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x82330d20;
		code_r0x82330cc9:
		        DAT_ram_009d3e38 = 0;
		        iVar11 = import::env::invoke_iiii(*puVar6,piVar9,param3_00,puVar6[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x82330d20;
		      } while (iVar11 != 0);
		      uVar2 = uVar2 ^ 1;
		      iVar3 = 6;
		      iVar8 = 0;
		code_r0x82330d7a:
		      iVar11 = Method_System_Collections_Generic_List_CraftSchemeData__Add__;
		      if (iVar8 != 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar8);
		        iVar11 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar11 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar11 = global_1;
		        goto code_r0x82330edd;
		      }
		      if ((iVar3 != 0) &&
		         ((((iVar3 == 1 || (iVar3 == 2)) || (iVar3 == 3)) ||
		          (((iVar3 == 4 || (iVar3 == 5)) || (iVar3 != 6)))))) goto code_r0x82330f24;
		    } while (uVar2 == 0);
		    *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		    uVar2 = *(uint *)(iVar4 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		      *(uint *)(iVar4 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(iVar4 + 8) + uVar2 * 4 + 0x10) = param3_00;
		      goto code_r0x82330959;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar4,param3_00,
		               *(undefined4 *)(*(int *)(*(int *)(iVar11 + 0x10) + 0x60) + 0x38));
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar11 != 1);
		  uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar11 = global_1;
		code_r0x82330edd:
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar11) {
		    piVar9 = (int *)import::env::__cxa_begin_catch(uVar7);
		    local_20 = *piVar9;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 != 1) {
		code_r0x82330f24:
		      DAT_ram_009d3e38 = 0;
		      piVar9 = *local_1c;
		      if (piVar9 != (int *)0x0) {
		        uVar2 = 0;
		        iVar11 = *piVar9;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8)) {
		              puVar5 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x82330f9f;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar2);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar9,System_IDisposable_TypeInfo,0);
		code_r0x82330f9f:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar9,puVar5[1]);
		      }
		      if (local_20 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_20);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      return iVar4;
		    }
		    uVar7 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x23,&local_20);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 != 1) {
		    import::env::__resumeException(uVar7);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x82330ff8:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060034EC RID: 13548 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034EC")]
		[Address(RVA = "0x8515", Offset = "0x8515", VA = "0x8515")]
		private List<CraftSchemeData> FilterCraftSchemes(IList<CraftSchemeData> rawData)
		{
		/* --- GHIDRA: FilterCraftSchemes ---
		void Gameplay_Craft_Controller_CraftViewMediator__FilterCraftSchemes(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a63a5c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_UserCraftSlotInfo___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_UserCraftSlotInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_UserCraftSlotInfo__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator___c__UpdateCounter_b__46_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		    DAT_ram_00a63a5c = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1[2] + 0x20);
		  if (*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[1];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    iVar4 = unnamed_function_1417(System_Func_UserCraftSlotInfo__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar4,uVar1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator___c__UpdateCounter_b__46_0__,0);
		    *(int *)(*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c) + 4) = iVar4;
		  }
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar2,iVar4,Method_System_Linq_Enumerable_Where_UserCraftSlotInfo___);
		  uVar2 = func_ii_6330(uVar2,Method_System_Linq_Enumerable_Count_UserCraftSlotInfo___);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = UI_Tabs_TabBar__SelectByItem(*(undefined4 *)(iVar4 + 0x40),1,0);
		  Core_Extensions_Dict_BossGroupDictExt__GetTitle(uVar1,uVar2,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060034ED RID: 13549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034ED")]
		[Address(RVA = "0x8516", Offset = "0x8516", VA = "0x8516")]
		private void UpdateCounter()
		{
		/* --- GHIDRA: UpdateCounter ---
		/* WARNING: Removing unreachable block (ram,0x82331a71) */
		
		void Gameplay_Craft_Controller_CraftViewMediator__UpdateCounter(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int param3;
		  undefined4 param2_00;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63a5d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_CraftSlotListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftViewMediator_CraftSlotButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_UserCraftSlotInfo___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CraftSlotListElement__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CraftSlotListElement__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_CraftSlotListElement__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_UserCraftSlotInfo__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSlotListElement__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftViewMediator___c__DisplayClass47_0__RedrawCraftSlots_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Craft_Controller_CraftViewMediator___c__DisplayClass47_0_TypeInfo);
		    DAT_ram_00a63a5d = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,param1[0xb],
		             Method_System_Collections_Generic_List_CraftSlotListElement__GetEnumerator__);
		  local_8 = local_18;
		  local_10 = CONCAT44(puStack_1c,local_20);
		  local_20 = 0;
		  puStack_1c = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_CraftSlotListElement__MoveNext__
		                      );
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x823318ae;
		    }
		    if (iVar1 == 0) goto code_r0x82331904;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,local_8._4_4_,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar2,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x823318ae:
		  iVar5 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar1 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x82331904:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      param2_00 = *(undefined4 *)(param1[2] + 0x24);
		      uVar4 = unnamed_function_1417(System_Action_CraftSlotListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar4,param1,
		                 Method_Gameplay_Craft_Controller_CraftViewMediator_CraftSlotButtonClickedEventHandler__
		                 ,0);
		      iVar5 = Gameplay_Craft_View_CraftWindow__SetRecipes(uVar2,param2_00,uVar4,0);
		      param1[0xb] = iVar5;
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_20,iVar5,
		                 Method_System_Collections_Generic_List_CraftSlotListElement__GetEnumerator__);
		      local_8 = local_18;
		      local_10 = CONCAT44(puStack_1c,local_20);
		      local_20 = 0;
		      puStack_1c = &local_10;
		code_r0x823319d1:
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar1 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                           Method_System_Collections_Generic_List_Enumerator_CraftSlotListElement__MoveNext__
		                          );
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x82331ce1;
		        }
		        if (iVar1 == 0) goto code_r0x82331d37;
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           Gameplay_Craft_Controller_CraftViewMediator___c__DisplayClass47_0_TypeInfo
		                          );
		        if (DAT_ram_009d3e38 == 1) {
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x82331ce1;
		        }
		        *(undefined4 *)(iVar5 + 8) = local_8._4_4_;
		        uVar4 = *(undefined4 *)(param1[2] + 0x20);
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Func_UserCraftSlotInfo__bool__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x82331bfd:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x82331ce1;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar2,iVar5,
		                   Method_Gameplay_Craft_Controller_CraftViewMediator___c__DisplayClass47_0__RedrawCraftSlots_b__0__
		                   ,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x82331bfd;
		        DAT_ram_009d3e38 = 0;
		        param3 = import::env::invoke_iiii
		                           (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21c,uVar4,uVar2,
		                            Method_System_Linq_Enumerable_FirstOrDefault_UserCraftSlotInfo___);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x82331ce1;
		        }
		        uVar2 = *(undefined4 *)(iVar5 + 8);
		        if (param3 == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x28,uVar2,0);
		          iVar5 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar5 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x82331ce1;
		          }
		          goto code_r0x823319d1;
		        }
		        if (DAT_ram_00a63a52 == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (0x7ff,&
		                           Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__get_Model__
		                    );
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (0x7ff,&
		                           Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Count__
		                    );
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_00a63a52 = '\x01';
		        }
		        if ((*(int *)(*(int *)(param3 + 0x38) + 0xc) == 0) && (*(longlong *)(param3 + 0x20) == 0)) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s___Scripting__Unity__IO__Archive__ram_00004472 + 0x25,uVar2,param3,0);
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_iiii
		                            (s___Scripting__Unity__IO__Archive__ram_00004472 + 0x26,param1[2],
		                             *(undefined4 *)(param3 + 0x18),&local_20);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s___Scripting__Unity__IO__Archive__ram_00004472 + 0x27,uVar2,uVar4,param3,0);
		        }
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x82331ce1:
		      iVar5 = global_1;
		      iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar5 == iVar1) {
		        piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar1 = *piVar3;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar1;
		        import::env::invoke_v(0x123);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 != 1) {
		          if (iVar1 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x82331d37:
		          DAT_ram_009d3e38 = 0;
		          if (DAT_ram_00a63a4d == '\0') {
		            Mono_Security_ASN1__get_Item
		                      (&Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__);
		            DAT_ram_00a63a4d = '\x01';
		          }
		          uVar2 = System_Linq_Enumerable__ToList_object_
		                            (param1[0xb],param1[0xc],
		                             Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__
		                            );
		          Gameplay_Craft_Controller_CraftViewMediator__SelectCraftRecipeListElement
		                    (param1,uVar2,&local_20);
		          Gameplay_Craft_Controller_CraftViewMediator__RedrawCraftSlots(param1,&local_20);
		          Gameplay_Craft_Controller_CraftViewMediator__FilterCraftSchemes(param1,&local_20);
		          return;
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x29,&local_20);
		      goto joined_r0x82331dbc;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x24,&local_20);
		joined_r0x82331dbc:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar2);
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

		// Token: 0x060034EE RID: 13550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034EE")]
		[Address(RVA = "0x8517", Offset = "0x8517", VA = "0x8517")]
		private void RedrawCraftSlots()
		{
		/* --- GHIDRA: RedrawCraftSlots ---
		void Gameplay_Craft_Controller_CraftViewMediator__RedrawCraftSlots(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar7 = 0;
		  if (DAT_ram_00a63a5e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CraftSlotListElement__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CraftSlotListElement__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_CraftSlotListElement__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSlotListElement__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSlotListElement__get_Count__);
		    DAT_ram_00a63a5e = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar5 = *(int *)(param1[8] + 8);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  *(undefined1 *)(iVar5 + 0x10) = *(undefined1 *)(*(int *)(iVar2 + 100) + 0x48);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,param1[0xb],
		             Method_System_Collections_Generic_List_CraftSlotListElement__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		code_r0x82331eb6:
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_CraftSlotListElement__MoveNext__
		                      );
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x82332076;
		    }
		    if (iVar5 == 0) goto code_r0x82332119;
		    iVar2 = local_8._4_4_;
		    iVar5 = *(int *)(local_8._4_4_ + 0x44);
		    iVar6 = param1[8];
		    if (DAT_ram_00a63a7e == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (0x7ff,&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Count__);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x82332076;
		      }
		      DAT_ram_00a63a7e = '\x01';
		    }
		    if ((*(char *)(*(int *)(iVar6 + 8) + 0x10) == '\0') ||
		       (((iVar5 != 0 && (*(longlong *)(iVar5 + 0x20) == 0)) &&
		        (0 < *(int *)(*(int *)(iVar5 + 0x38) + 0xc))))) break;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,iVar2,0)
		    ;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8233205a;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar3,0,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8233205a:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x82332076:
		      iVar2 = global_1;
		      iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar2 == iVar5) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar5 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar5;
		        import::env::invoke_v(0x123);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		          if (iVar5 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x82332119:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		          Gameplay_Craft_View_CraftWindow__CreateManufactureSlots
		                    (uVar3,iVar7,*(undefined4 *)(param1[0xb] + 0xc),0);
		          return;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x2a,&local_18);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
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
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,iVar2,0);
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar3,1,0);
		    if (DAT_ram_009d3e38 != 1) {
		      iVar7 = iVar7 + 1;
		      goto code_r0x82331eb6;
		    }
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x82332076;
		}
		*/

		}

		// Token: 0x060034EF RID: 13551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034EF")]
		[Address(RVA = "0x8518", Offset = "0x8518", VA = "0x8518")]
		private void FilterCraftSlots()
		{
		/* --- GHIDRA: FilterCraftSlots ---
		int Gameplay_Craft_Controller_CraftViewMediator__FilterCraftSlots
		              (undefined4 param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63a5f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Craft_Controller_CraftViewMediator__DelayedRequest_d__49_TypeInfo);
		    DAT_ram_00a63a5f = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Craft_Controller_CraftViewMediator__DelayedRequest_d__49_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(float *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034F0")]
		[Address(RVA = "0x8519", Offset = "0x8519", VA = "0x8519")]
		private IEnumerator DelayedRequest(float seconds)
		{
		/* --- GHIDRA: DelayedRequest ---
		void Gameplay_Craft_Controller_CraftViewMediator__DelayedRequest
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a63a60 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator_PickerWindowOnClose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator_PickerWindowOnSelectedEvent__);
		    DAT_ram_00a63a60 = '\x01';
		  }
		  uVar1 = Gameplay_Craft_View_CraftSpinPickerDialogWindow__HandleContent(param2,param3,0);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar2,param1,
		                Method_Gameplay_Craft_Controller_CraftViewMediator_PickerWindowOnSelectedEvent__,0);
		  Gameplay_Craft_View_CraftSpinPickerDialogWindow__set_SelectedAttemptsNum(uVar1,uVar2,0);
		  uVar2 = *(undefined4 *)(param1 + 0x28);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Gameplay_Craft_Controller_CraftViewMediator_PickerWindowOnClose__,0
		            );
		  UI_Windows_BaseWindow__get_IsActiveResourceBar(uVar2,uVar1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F1")]
		[Address(RVA = "0x851A", Offset = "0x851A", VA = "0x851A")]
		private void ShowValuePicker(int maxValue, int maxEnoughValue)
		{
		/* --- GHIDRA: ShowValuePicker ---
		void Gameplay_Craft_Controller_CraftViewMediator__ShowValuePicker
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Craft_Controller_CraftViewMediator__PickerWindowOnClose
		            (param1,*(undefined4 *)
		                     (*(int *)(*(int *)(*(int *)(*(int *)(param1 + 0x24) + 0x10) + 0xc) + 8) + 0xc),
		             param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F2")]
		[Address(RVA = "0x851B", Offset = "0x851B", VA = "0x851B")]
		private void PickerWindowOnSelectedEvent(uint quantity)
		{
		/* --- GHIDRA: PickerWindowOnSelectedEvent ---
		void Gameplay_Craft_Controller_CraftViewMediator__PickerWindowOnSelectedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a63a61 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator_PickerWindowOnClose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator_PickerWindowOnSelectedEvent__);
		    DAT_ram_00a63a61 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x28);
		  uVar1 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar1,param1,
		                Method_Gameplay_Craft_Controller_CraftViewMediator_PickerWindowOnSelectedEvent__,0);
		  Gameplay_Craft_View_CraftSpinPickerDialogWindow__add_SelectedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x28);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Gameplay_Craft_Controller_CraftViewMediator_PickerWindowOnClose__,0
		            );
		  UI_Windows_BaseWindow__add_onClose(uVar2,uVar1,0);
		  *(undefined4 *)(param1 + 0x28) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F3")]
		[Address(RVA = "0x851C", Offset = "0x851C", VA = "0x851C")]
		private void PickerWindowOnClose()
		{
		/* --- GHIDRA: PickerWindowOnClose ---
		undefined4
		Gameplay_Craft_Controller_CraftViewMediator__PickerWindowOnClose
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int param1_01;
		  uint uVar5;
		  
		  if (DAT_ram_00a63a62 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
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
		               Method_Gameplay_Craft_Controller_CraftViewMediator___c__DisplayClass53_0__ShowStartCraftingConfirmationWindow_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Craft_Controller_CraftViewMediator___c__DisplayClass53_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4107);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4451);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4486);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4474);
		    DAT_ram_00a63a62 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Craft_Controller_CraftViewMediator___c__DisplayClass53_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param3;
		  *(undefined4 *)(iVar1 + 0xc) = param2;
		  *(undefined4 *)(iVar1 + 8) = param1;
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4474,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4486,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  param1_01 = *(int *)(param1_00 + 0x24);
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar3,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4451,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar2,iVar1,
		             Method_Gameplay_Craft_Controller_CraftViewMediator___c__DisplayClass53_0__ShowStartCraftingConfirmationWindow_b__0__
		             ,0);
		  *(undefined4 *)(iVar4 + 8) = uVar2;
		  *(int *)(iVar3 + 0x14) = iVar4;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar5 = *(uint *)(param1_01 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar5 * 4 + 0x10) = iVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar4 = *(int *)(param1_00 + 0x24);
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar3,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4107,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = iVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_00,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034F4")]
		[Address(RVA = "0x851D", Offset = "0x851D", VA = "0x851D")]
		public DialogWindow ShowStartCraftingConfirmationWindow(uint schemeId, uint quantity)
		{
		/* --- GHIDRA: ShowStartCraftingConfirmationWindow ---
		undefined4
		Gameplay_Craft_Controller_CraftViewMediator__ShowStartCraftingConfirmationWindow
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  int iVar7;
		  int iVar8;
		  int *piVar9;
		  int iVar10;
		  int param1_01;
		  int iVar11;
		  
		  if (DAT_ram_00a63a63 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftViewMediator___c__DisplayClass54_0__ShowRentSlotConfirmationWindow_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Craft_Controller_CraftViewMediator___c__DisplayClass54_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4448);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4107);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26152);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3708);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4449);
		    DAT_ram_00a63a63 = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (Gameplay_Craft_Controller_CraftViewMediator___c__DisplayClass54_0_TypeInfo);
		  *(undefined4 *)(iVar2 + 0x10) = param3;
		  *(undefined4 *)(iVar2 + 0xc) = param2;
		  *(undefined4 *)(iVar2 + 8) = param1;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0x160);
		        goto code_r0x82332768;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x82332768:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar9,CONCAT44(in_register_20000014,puVar3[1]));
		  iVar10 = Core_Gameplay_Managers_Requirements_RequirementsManager__Deinit
		                     (uVar4,*(undefined4 *)(*(int *)(iVar2 + 0xc) + 0x14),0);
		  uVar4 = *(undefined4 *)(iVar10 + 0x10);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar4 = Core_Money_Money__op_Explicit(uVar4,0);
		  iVar10 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(iVar10,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4448,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar10 + 0x18) = uVar5;
		  uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4449,1,0,1,0,0,0,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  uVar5 = 0x7ff80000;
		  param3_00 = Core_Extensions_Dict_ResourceSetExt__ToNullableResourceSet
		                        (uVar4,NAN,0,StringLiteral_2556,0,0,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_26152,param3_00,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar6 = Core_GameLocalization__GetTranslation(uVar6,param1_00,0);
		  *(undefined4 *)(iVar10 + 0x1c) = uVar6;
		  param1_01 = *(int *)(iVar10 + 0x24);
		  iVar7 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar7,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3708,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar7 + 8) = uVar6;
		  iVar8 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  *(undefined4 *)(iVar8 + 8) = uVar4;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar11 = *piVar9;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 0x140);
		        goto code_r0x82332967;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x82332967:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar9,CONCAT44(uVar5,puVar3[1]));
		  uVar4 = func_ii_7112(uVar4,0);
		  *(undefined4 *)(iVar8 + 0xc) = uVar4;
		  *(int *)(iVar7 + 0x10) = iVar8;
		  iVar8 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar4,iVar2,
		             Method_Gameplay_Craft_Controller_CraftViewMediator___c__DisplayClass54_0__ShowRentSlotConfirmationWindow_b__0__
		             ,0);
		  *(undefined4 *)(iVar8 + 8) = uVar4;
		  *(int *)(iVar7 + 0x14) = iVar8;
		  iVar2 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar1 = *(uint *)(param1_01 + 0xc);
		  if (uVar1 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar1 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar1 * 4 + 0x10) = iVar7;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar7,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar8 = *(int *)(iVar10 + 0x24);
		  iVar7 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar7,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4107,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar7 + 8) = uVar4;
		  iVar2 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		  uVar1 = *(uint *)(iVar8 + 0xc);
		  if (uVar1 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		    *(uint *)(iVar8 + 0xc) = uVar1 + 1;
		    *(int *)(*(int *)(iVar8 + 8) + uVar1 * 4 + 0x10) = iVar7;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar8,iVar7,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar4 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (iVar10,0);
		  return uVar4;
		}
		*/

			return null;
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034F5")]
		[Address(RVA = "0x851E", Offset = "0x851E", VA = "0x851E")]
		public DialogWindow ShowRentSlotConfirmationWindow(CraftSlotDic craftSlotDic, [Optional] Action callback)
		{
		/* --- GHIDRA: ShowRentSlotConfirmationWindow ---
		undefined4
		Gameplay_Craft_Controller_CraftViewMediator__ShowRentSlotConfirmationWindow
		          (int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  uint *puVar1;
		  undefined4 uVar2;
		  float fVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 param1_00;
		  undefined4 param3;
		  int param1_01;
		  int iVar6;
		  double dVar7;
		  ulonglong uVar8;
		  int iVar9;
		  int *piVar10;
		  int param1_02;
		  int iVar11;
		  uint uVar12;
		  
		  if (DAT_ram_00a63a64 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftViewMediator__ShowAccelerateConfirmationWindow_b__55_0__
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_26152);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3694);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4453);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27345);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4452);
		    DAT_ram_00a63a64 = '\x01';
		  }
		  dVar7 = func_ii_6906(*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 8) + 0x78),2,0);
		  if (ABS(dVar7) < 2147483648.0) {
		    iVar9 = (int)dVar7;
		  }
		  else {
		    iVar9 = -0x80000000;
		  }
		  if (iVar9 == 0) {
		    uVar2 = Core_Errors_Expected_ExpectedBillingErrors__Check(2,0);
		    return uVar2;
		  }
		  iVar9 = *(int *)(param1 + 8);
		  if (DAT_ram_00a63a23 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a63a23 = '\x01';
		  }
		  piVar10 = *(int **)(iVar9 + 0x10);
		  iVar9 = *piVar10;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar12 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8 + 4) * 8 + iVar9 + 0xd0);
		        goto code_r0x82332c85;
		      }
		      uVar12 = uVar12 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar12);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar10,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x82332c85:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar10,CONCAT44(in_register_20000014,puVar1[1]));
		  uVar8 = Core_Extensions_Dict_DictExt__GetDoubleParameter(uVar2,StringLiteral_27345,0);
		  if (DAT_ram_00a63a4d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__);
		    DAT_ram_00a63a4d = '\x01';
		  }
		  iVar9 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(param1 + 0x2c),*(undefined4 *)(param1 + 0x30),
		                     Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__);
		  fVar3 = UnityEngine_Camera__set_orthographicSize
		                    ((float)*(ulonglong *)(*(int *)(iVar9 + 0x44) + 0x20),(float)uVar8,0);
		  if (ABS(fVar3) < 2.1474836e+09) {
		    iVar9 = (int)fVar3;
		  }
		  else {
		    iVar9 = -0x80000000;
		  }
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  uVar2 = *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 8);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Data_ArtifactData__get_SellPrice(uVar2,(double)(iVar9 + 1),0);
		  iVar9 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(iVar9,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4452,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar9 + 0x18) = uVar4;
		  uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4453,1,0,1,0,0,0,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  uVar4 = 0x7ff80000;
		  param3 = Core_Extensions_Dict_ResourceSetExt__ToNullableResourceSet
		                     (uVar2,NAN,0,StringLiteral_2556,0,0,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_26152,param3,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar5 = Core_GameLocalization__GetTranslation(uVar5,param1_00,0);
		  *(undefined4 *)(iVar9 + 0x1c) = uVar5;
		  param1_02 = *(int *)(iVar9 + 0x24);
		  param1_01 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_01,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3694,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_01 + 8) = uVar5;
		  iVar6 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  *(undefined4 *)(iVar6 + 8) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar10 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar11 = *piVar10;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar12 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar12 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar12 * 8 + 4) * 8 + iVar11 + 0x140);
		        goto code_r0x82332f11;
		      }
		      uVar12 = uVar12 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar12);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar10,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x82332f11:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar10,CONCAT44(uVar4,puVar1[1]));
		  uVar2 = func_ii_7112(uVar2,0);
		  *(undefined4 *)(iVar6 + 0xc) = uVar2;
		  *(int *)(param1_01 + 0x10) = iVar6;
		  iVar6 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar2,param1,
		             Method_Gameplay_Craft_Controller_CraftViewMediator__ShowAccelerateConfirmationWindow_b__55_0__
		             ,0);
		  *(undefined4 *)(iVar6 + 8) = uVar2;
		  *(int *)(param1_01 + 0x14) = iVar6;
		  iVar6 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_02 + 0x10) = *(int *)(param1_02 + 0x10) + 1;
		  uVar12 = *(uint *)(param1_02 + 0xc);
		  if (uVar12 < *(uint *)(*(int *)(param1_02 + 8) + 0xc)) {
		    *(uint *)(param1_02 + 0xc) = uVar12 + 1;
		    *(int *)(*(int *)(param1_02 + 8) + uVar12 * 4 + 0x10) = param1_01;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_02,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (iVar9,0);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x060034F6 RID: 13558 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034F6")]
		[Address(RVA = "0x851F", Offset = "0x851F", VA = "0x851F")]
		public BaseWindow ShowAccelerateConfirmationWindow()
		{
		/* --- GHIDRA: ShowAccelerateConfirmationWindow ---
		undefined4
		Gameplay_Craft_Controller_CraftViewMediator__ShowAccelerateConfirmationWindow
		          (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int param1_01;
		  int param1_02;
		  uint uVar3;
		  
		  if (DAT_ram_00a63a65 == '\0') {
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
		    Mono_Security_ASN1__get_Item(&StringLiteral_4483);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4482);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3611);
		    DAT_ram_00a63a65 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4482,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4483,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  param1_02 = *(int *)(param1_00 + 0x24);
		  param1_01 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_01,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3611,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_01 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_02 + 0x10) = *(int *)(param1_02 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_02 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_02 + 8) + 0xc)) {
		    *(uint *)(param1_02 + 0xc) = uVar3 + 1;
		    *(int *)(*(int *)(param1_02 + 8) + uVar3 * 4 + 0x10) = param1_01;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_02,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_00,0);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x060034F7 RID: 13559 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034F7")]
		[Address(RVA = "0x8520", Offset = "0x8520", VA = "0x8520")]
		public DialogWindow ShowSlotExpiredWindow()
		{
		/* --- GHIDRA: ShowSlotExpiredWindow ---
		undefined4
		Gameplay_Craft_Controller_CraftViewMediator__ShowSlotExpiredWindow
		          (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int param1_01;
		  int param1_02;
		  uint uVar3;
		  
		  if (DAT_ram_00a63a66 == '\0') {
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
		    Mono_Security_ASN1__get_Item(&StringLiteral_11313);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4472);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3611);
		    DAT_ram_00a63a66 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_11313,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4472,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  param1_02 = *(int *)(param1_00 + 0x24);
		  param1_01 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_01,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3611,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_01 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_02 + 0x10) = *(int *)(param1_02 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_02 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_02 + 8) + 0xc)) {
		    *(uint *)(param1_02 + 0xc) = uVar3 + 1;
		    *(int *)(*(int *)(param1_02 + 8) + uVar3 * 4 + 0x10) = param1_01;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_02,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_00,0);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x060034F8 RID: 13560 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034F8")]
		[Address(RVA = "0x8521", Offset = "0x8521", VA = "0x8521")]
		private DialogWindow ShowNotAvailableSlotsWindow()
		{
		/* --- GHIDRA: ShowNotAvailableSlotsWindow ---
		void Gameplay_Craft_Controller_CraftViewMediator__ShowNotAvailableSlotsWindow
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63a67 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__Dispose__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63a67 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x28);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,0,0);
		  if (iVar1 != 0) {
		    Gameplay_Craft_Controller_CraftViewMediator__PickerWindowOnSelectedEvent(param1,param1);
		  }
		  if (*(int *)(param1 + 0x38) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x38),0);
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__Dispose__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060034F9 RID: 13561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F9")]
		[Address(RVA = "0x8522", Offset = "0x8522", VA = "0x8522", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Craft_Controller_CraftViewMediator__Dispose(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param4;
		  undefined4 param1_00;
		  undefined4 param3;
		  undefined4 param2_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a63a68 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_Controller_Filters_ICraftFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_CraftWindowStates_State__get_CurrentState__);
		    DAT_ram_00a63a68 = '\x01';
		  }
		  if (((param1[9] != 0) && (*(int *)(param1[9] + 0x10) != 0)) &&
		     (iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c)),
		     *(int *)(*(int *)(iVar2 + 0x3c) + 0x18) == 1)) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar2 + 0x4c);
		    uVar1 = 0;
		    param3 = *(undefined4 *)(param1[9] + 0x10);
		    param2_00 = *(undefined4 *)(param1[2] + 8);
		    param1_01 = (int *)param1[7];
		    iVar2 = *param1_01;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Craft_Controller_Filters_ICraftFilter_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x823332c4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,Gameplay_Craft_Controller_Filters_ICraftFilter_TypeInfo,
		                                  2);
		code_r0x823332c4:
		    param4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,param3,puVar3[1]);
		    Gameplay_Craft_View_CraftInfoBox__get_RentGroup(param1_00,param2_00,param3,param4,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060034FA RID: 13562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034FA")]
		[Address(RVA = "0x8523", Offset = "0x8523", VA = "0x8523")]
		private void UserBalanceChangedEventHandler()
		{
		/* --- GHIDRA: UserBalanceChangedEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__UserBalanceChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  float fVar6;
		  int iVar7;
		  undefined4 uVar8;
		  int *piVar9;
		  ulonglong uVar10;
		  int iVar11;
		  longlong local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63a69 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_ProfessionDic_Types_LevelInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_ProfessionDic_Types_LevelInfo__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftViewMediator___c__DisplayClass60_0__ProfessionRequestedEventHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Craft_Controller_CraftViewMediator___c__DisplayClass60_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4467);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4487);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23073);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4468);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25096);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4465);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25586);
		    DAT_ram_00a63a69 = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (Gameplay_Craft_Controller_CraftViewMediator___c__DisplayClass60_0_TypeInfo);
		  iVar11 = param1[2];
		  *(undefined4 *)(iVar2 + 8) = *(undefined4 *)(iVar11 + 0x14);
		  iVar7 = *(int *)(iVar11 + 0x18);
		  iVar11 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                     (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = *(undefined4 *)(iVar11 + 0x50);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4465,1,0,1,0,0,0,0);
		  uVar4 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar4,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  local_4 = *(undefined4 *)(*(int *)(iVar2 + 8) + 0x10);
		  uVar5 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar4,StringLiteral_25096,uVar5,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar3 = Core_GameLocalization__GetTranslation(uVar3,uVar4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar8,uVar3,0);
		  uVar3 = *(undefined4 *)(iVar7 + 0x14);
		  uVar8 = unnamed_function_1417(System_Func_ProfessionDic_Types_LevelInfo__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar8,iVar2,
		             Method_Gameplay_Craft_Controller_CraftViewMediator___c__DisplayClass60_0__ProfessionRequestedEventHandler_b__0__
		             ,0);
		  iVar11 = System_Func_object__bool____ctor
		                     (uVar3,uVar8,
		                      Method_System_Linq_Enumerable_FirstOrDefault_ProfessionDic_Types_LevelInfo___)
		  ;
		  if (iVar11 == 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar8 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x54),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar8,0,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar8 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x58),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar8,1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar8 = *(undefined4 *)(iVar2 + 0x5c);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4468,1,0,1,0,0,0,0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar8,uVar3,0);
		  }
		  else {
		    uVar1 = *(uint *)(iVar11 + 0x10);
		    uVar10 = *(ulonglong *)(*(int *)(iVar2 + 8) + 0x18);
		    iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar9 = *(int **)(iVar7 + 0x54);
		    if (uVar10 < uVar1) {
		      fVar6 = Utils_MathUtils_MathUtils__SaferDivide
		                        ((float)*(ulonglong *)(*(int *)(iVar2 + 8) + 0x18),
		                         *(undefined4 *)(iVar11 + 0x10),0);
		      (**(code **)((ulonglong)*(uint *)(*piVar9 + 0x108) * 4))
		                (piVar9,fVar6,*(undefined4 *)(*piVar9 + 0x10c));
		      local_10 = (ulonglong)*(uint *)(iVar11 + 0x10) - *(longlong *)(*(int *)(iVar2 + 8) + 0x18);
		      uVar8 = func_ii_8783(&local_10,0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      piVar9 = *(int **)(iVar2 + 0x54);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4487,1,0,1,0,0,0,0);
		      uVar4 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		      System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		                (uVar4,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		      local_4 = *(undefined4 *)(iVar11 + 0xc);
		      uVar5 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		      System_Reflection_FieldInfo__get_IsStatic
		                (uVar4,StringLiteral_25586,uVar5,
		                 Method_System_Collections_Generic_Dictionary_string__string__Add__);
		      System_Reflection_FieldInfo__get_IsStatic
		                (uVar4,StringLiteral_23073,uVar8,
		                 Method_System_Collections_Generic_Dictionary_string__string__Add__);
		      uVar8 = Core_GameLocalization__GetTranslation(uVar3,uVar4,0);
		      iVar2 = *piVar9;
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0x118) * 4))
		                (piVar9,uVar8,*(undefined4 *)(iVar2 + 0x11c));
		    }
		    else {
		      uVar8 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (piVar9,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar8,0,0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar8 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar2 + 0x58),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar8,1,0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar8 = *(undefined4 *)(iVar2 + 0x5c);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4467,1,0,1,0,0,0,0);
		      UnityEngine_Component__GetComponentInChildren_object_(uVar8,uVar3,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060034FB RID: 13563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034FB")]
		[Address(RVA = "0x8524", Offset = "0x8524", VA = "0x8524")]
		private void ProfessionRequestedEventHandler()
		{
		/* --- GHIDRA: ProfessionRequestedEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__ProfessionRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Craft_View_CraftWindow__get_InChestButton(param1_00,0);
		  Gameplay_Craft_Controller_CraftViewMediator__HandleActiveSlot(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060034FC RID: 13564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034FC")]
		[Address(RVA = "0x8525", Offset = "0x8525", VA = "0x8525")]
		private void SchemesRequestedEventHandler()
		{
		/* --- GHIDRA: SchemesRequestedEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__SchemesRequestedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Craft_Controller_CraftViewMediator__CraftSlotsRequestedEventHandler(param1,param1);
		  Gameplay_Craft_Controller_CraftViewMediator__UpdateCounter(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060034FD RID: 13565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034FD")]
		[Address(RVA = "0x8526", Offset = "0x8526", VA = "0x8526")]
		private void CraftSlotsRequestedEventHandler()
		{
		/* --- GHIDRA: CraftSlotsRequestedEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__CraftSlotsRequestedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  float fVar1;
		  ulonglong param2_00;
		  ulonglong uVar2;
		  undefined8 param1_00;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  undefined4 uVar6;
		  ulonglong uVar7;
		  byte local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63a6a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_ulong___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Min_ulong___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_UserCraftSlotInfo__ulong___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_ulong___);
		    Mono_Security_ASN1__get_Item(&System_Func_ulong__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_UserCraftSlotInfo__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong__get_Value__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator___c__SetupTimer_b__63_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator___c__SetupTimer_b__63_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator___c__SetupTimer_b__63_2__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator___c__SetupTimer_b__63_3__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		    DAT_ram_00a63a6a = '\x01';
		  }
		  local_8 = 0;
		  _local_10 = 0;
		  if (*(int *)(param1 + 0x38) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x38),0);
		  }
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 8) + 0x20);
		  if (*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c);
		  iVar5 = puVar4[2];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar6 = *puVar4;
		    iVar5 = unnamed_function_1417(System_Func_UserCraftSlotInfo__ulong__TypeInfo);
		    func_ii_7542(iVar5,uVar6,
		                 Method_Gameplay_Craft_Controller_CraftViewMediator___c__SetupTimer_b__63_0__,0);
		    *(int *)(*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c) + 8) = iVar5;
		  }
		  uVar3 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                    (uVar3,iVar5,Method_System_Linq_Enumerable_Select_UserCraftSlotInfo__ulong___);
		  if (*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c);
		  iVar5 = puVar4[3];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar6 = *puVar4;
		    iVar5 = unnamed_function_1417(System_Func_ulong__bool__TypeInfo);
		    System_Func_ulong__ValueTuple_int__double____Invoke
		              (iVar5,uVar6,
		               Method_Gameplay_Craft_Controller_CraftViewMediator___c__SetupTimer_b__63_1__,0);
		    *(int *)(*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c) + 0xc) =
		         iVar5;
		  }
		  uVar3 = System_Linq_Enumerable__UnionIterator___Il2CppFullySharedGenericType_
		                    (uVar3,iVar5,Method_System_Linq_Enumerable_Where_ulong___);
		  iVar5 = System_Linq_Enumerable__Count_Substring_
		                    (uVar3,Method_System_Linq_Enumerable_Count_ulong___);
		  if (iVar5 < 1) {
		    param2_00 = 0;
		  }
		  else {
		    param2_00 = System_Linq_Enumerable__Min_float_(uVar3,Method_System_Linq_Enumerable_Min_ulong___)
		    ;
		  }
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 8) + 0x20);
		  if (*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c);
		  iVar5 = puVar4[4];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar6 = *puVar4;
		    iVar5 = unnamed_function_1417(System_Func_UserCraftSlotInfo__ulong__TypeInfo);
		    func_ii_7542(iVar5,uVar6,
		                 Method_Gameplay_Craft_Controller_CraftViewMediator___c__SetupTimer_b__63_2__,0);
		    *(int *)(*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c) + 0x10) =
		         iVar5;
		  }
		  uVar3 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                    (uVar3,iVar5,Method_System_Linq_Enumerable_Select_UserCraftSlotInfo__ulong___);
		  if (*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c);
		  iVar5 = puVar4[5];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar6 = *puVar4;
		    iVar5 = unnamed_function_1417(System_Func_ulong__bool__TypeInfo);
		    System_Func_ulong__ValueTuple_int__double____Invoke
		              (iVar5,uVar6,
		               Method_Gameplay_Craft_Controller_CraftViewMediator___c__SetupTimer_b__63_3__,0);
		    *(int *)(*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c) + 0x14) =
		         iVar5;
		  }
		  uVar3 = System_Linq_Enumerable__UnionIterator___Il2CppFullySharedGenericType_
		                    (uVar3,iVar5,Method_System_Linq_Enumerable_Where_ulong___);
		  iVar5 = System_Linq_Enumerable__Count_Substring_
		                    (uVar3,Method_System_Linq_Enumerable_Count_ulong___);
		  uVar2 = param2_00;
		  if ((iVar5 < 1) ||
		     (uVar2 = System_Linq_Enumerable__Min_float_(uVar3,Method_System_Linq_Enumerable_Min_ulong___),
		     param2_00 == 0)) {
		    param2_00 = uVar2;
		    if (uVar2 == 0) {
		      return;
		    }
		  }
		  else {
		    uVar7 = param2_00;
		    if (uVar2 <= param2_00) {
		      uVar7 = uVar2;
		    }
		    if (uVar2 != 0) {
		      param2_00 = uVar7;
		    }
		  }
		  Core_Log_Files_FileDownloadLogger__LogDownload
		            (&local_10,param2_00,Method_System_Nullable_ulong___ctor__);
		  if (local_10 != 0) {
		    param1_00 = System_Nullable_TimeSpan___get_HasValue
		                          (&local_10,Method_System_Nullable_ulong__get_Value__);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    fVar1 = Utils_StringUtils___cctor(param1_00,0);
		    if (DAT_ram_00a63a5f == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Gameplay_Craft_Controller_CraftViewMediator__DelayedRequest_d__49_TypeInfo);
		      DAT_ram_00a63a5f = '\x01';
		    }
		    iVar5 = unnamed_function_1417
		                      (Gameplay_Craft_Controller_CraftViewMediator__DelayedRequest_d__49_TypeInfo);
		    *(int *)(iVar5 + 0x14) = param1;
		    *(undefined4 *)(iVar5 + 8) = 0;
		    *(float *)(iVar5 + 0x10) = fVar1;
		    uVar3 = Utils_CoroutineSource__GetMono(iVar5,0);
		    *(undefined4 *)(param1 + 0x38) = uVar3;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060034FE RID: 13566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034FE")]
		[Address(RVA = "0x8527", Offset = "0x8527", VA = "0x8527")]
		private void SetupTimer()
		{
		/* --- GHIDRA: SetupTimer ---
		void Gameplay_Craft_Controller_CraftViewMediator__SetupTimer
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int param2_00;
		  
		  if (param2 == 5) {
		    param2_00 = *param1;
		    param1_00 = (**(code **)((ulonglong)*(uint *)(param2_00 + 0x148) * 4))
		                          (param1,*(undefined4 *)(param2_00 + 0x14c));
		    Gameplay_Craft_Controller_CraftController__GetUserProfessionsResultHandler(param1_00,param2_00);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060034FF RID: 13567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034FF")]
		[Address(RVA = "0x8528", Offset = "0x8528", VA = "0x8528")]
		private void ArtifactTakenEventHandler(DropTypes dropType)
		{
		/* --- GHIDRA: ArtifactTakenEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__ArtifactTakenEventHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Craft_Controller_CraftViewMediator__PopulateFiltersData(param1,param1);
		  return;
		}
		*/

		/* --- GHIDRA: ArtifactTakenEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__ArtifactTakenEventHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Craft_Controller_CraftViewMediator__PopulateFiltersData(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003500 RID: 13568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003500")]
		[Address(RVA = "0x8529", Offset = "0x8529", VA = "0x8529")]
		private void ArtifactTakenEventHandler(DropTypes dropType, ArtifactData data)
		{
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003501")]
		[Address(RVA = "0x852A", Offset = "0x852A", VA = "0x852A")]
		private void SchemeChangedEventHandler(UserScheme scheme)
		{
		/* --- GHIDRA: SchemeChangedEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__SchemeChangedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Craft_Controller_CraftViewMediator__UpdateCounter(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003502 RID: 13570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003502")]
		[Address(RVA = "0x852B", Offset = "0x852B", VA = "0x852B")]
		private void CraftSlotsChangedEventHandler()
		{
		/* --- GHIDRA: CraftSlotsChangedEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__CraftSlotsChangedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a63a6b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CraftRecipeListElement_CraftRecipeListElementArgs__get_args__
		              );
		    DAT_ram_00a63a6b = '\x01';
		  }
		  param1_00 = *(int *)(param2 + 0x18);
		  if (DAT_ram_00a63a56 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_CraftWindowStates_State__get_CurrentState__);
		    DAT_ram_00a63a56 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(*(int *)(iVar1 + 0x3c) + 0x18) == 1) {
		    if (param1[9] != 0) {
		      Gameplay_Craft_View_CraftRecipeListElement_CraftRecipeListElementArgs__get_Selected
		                (param1[9],0,0);
		    }
		    param1[9] = param1_00;
		    param1[0xd] = *(int *)(*(int *)(*(int *)(param1_00 + 0x10) + 8) + 0xc);
		    Gameplay_Craft_View_CraftRecipeListElement_CraftRecipeListElementArgs__get_Selected
		              (param1_00,1,0);
		    Gameplay_Craft_Controller_CraftViewMediator__SelectCraftSlotListElement
		              (param1,*(undefined4 *)(param1_00 + 0x10),param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003503 RID: 13571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003503")]
		[Address(RVA = "0x852C", Offset = "0x852C", VA = "0x852C")]
		private void CraftRecipeButtonClickedEventHandler(CraftRecipeListElement element)
		{
		/* --- GHIDRA: CraftRecipeButtonClickedEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__CraftRecipeButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Craft_Controller_CraftViewMediator__SelectCraftRecipeListElement(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06003504 RID: 13572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003504")]
		[Address(RVA = "0x852D", Offset = "0x852D", VA = "0x852D")]
		private void CraftSlotButtonClickedEventHandler(CraftSlotListElement element)
		{
		/* --- GHIDRA: CraftSlotButtonClickedEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__CraftSlotButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  undefined4 *puVar4;
		  int param1_02;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63a6c == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_ArtifactFilterDelegate_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftViewMediator___c__InChestButtonClickedEventHandler_b__70_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		    DAT_ram_00a63a6c = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x82333d75;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x82333d75:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,2);
		  *(undefined8 *)(iVar3 + 0x10) = 0x500000001;
		  if (*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c);
		  param1_02 = puVar4[6];
		  if (param1_02 == 0) {
		    if (*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar4;
		    param1_02 = unnamed_function_1417
		                          (
		                          Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_ArtifactFilterDelegate_TypeInfo
		                          );
		    Gameplay_Inventory_View_Chest_InventoryChestWindowOptions___ctor
		              (param1_02,param2_00,
		               Method_Gameplay_Craft_Controller_CraftViewMediator___c__InChestButtonClickedEventHandler_b__70_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c) + 0x18) =
		         param1_02;
		  }
		  Core_Gameplay_Managers_Inventory_InventoryManager__DismantleArtifact
		            (param1_00,iVar3,0,param1_02,0);
		  return;
		}
		*/

		}

		// Token: 0x06003505 RID: 13573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003505")]
		[Address(RVA = "0x852E", Offset = "0x852E", VA = "0x852E")]
		private void InChestButtonClickedEventHandler()
		{
		/* --- GHIDRA: InChestButtonClickedEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__InChestButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int param1_01;
		  
		  if (DAT_ram_00a63a6d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_ArtifactInfo__ulong___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ulong___);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtifactInfo__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftViewMediator___c__TakeButtonClickedEventHandler_b__71_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		    DAT_ram_00a63a6d = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (DAT_ram_00a63a4d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__);
		    DAT_ram_00a63a4d = '\x01';
		  }
		  iVar1 = System_Linq_Enumerable__ToList_object_
		                    (param1[0xb],param1[0xc],
		                     Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__);
		  uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x38);
		  if (*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		  }
		  piVar3 = *(int **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c);
		  param1_01 = piVar3[7];
		  iVar1 = Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo;
		  if (param1_01 == 0) {
		    if (*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		      piVar3 = *(int **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c);
		    }
		    iVar1 = *piVar3;
		    param1_01 = unnamed_function_1417(System_Func_ArtifactInfo__ulong__TypeInfo);
		    func_ii_7542(param1_01,iVar1,
		                 Method_Gameplay_Craft_Controller_CraftViewMediator___c__TakeButtonClickedEventHandler_b__71_0__
		                 ,0);
		    *(int *)(*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c) + 0x1c) =
		         param1_01;
		  }
		  uVar2 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                    (uVar2,param1_01,Method_System_Linq_Enumerable_Select_ArtifactInfo__ulong___);
		  uVar2 = System_Linq_Enumerable__ToArray_PlayerLoopSystem_
		                    (uVar2,Method_System_Linq_Enumerable_ToArray_ulong___);
		  Gameplay_Craft_Controller_CraftController___ctor(param1_00,uVar2,iVar1);
		  return;
		}
		*/

		}

		// Token: 0x06003506 RID: 13574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003506")]
		[Address(RVA = "0x852F", Offset = "0x852F", VA = "0x852F")]
		private void TakeButtonClickedEventHandler()
		{
		/* --- GHIDRA: TakeButtonClickedEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__TakeButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int *param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63a6e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftViewMediator__SellAllButtonClickedEventHandler_g__GetArtifactData_72_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_ArtifactInfo__ArtifactData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ArtifactData___);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtifactInfo__ArtifactData__TypeInfo);
		    DAT_ram_00a63a6e = '\x01';
		  }
		  param2_00 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                               (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (DAT_ram_00a63a4d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__);
		    DAT_ram_00a63a4d = '\x01';
		  }
		  iVar1 = System_Linq_Enumerable__ToList_object_
		                    (param1[0xb],param1[0xc],
		                     Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__);
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x38);
		  uVar2 = unnamed_function_1417(System_Func_ArtifactInfo__ArtifactData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar2,param1,
		             Method_Gameplay_Craft_Controller_CraftViewMediator__SellAllButtonClickedEventHandler_g__GetArtifactData_72_0__
		             ,0);
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar3,uVar2,Method_System_Linq_Enumerable_Select_ArtifactInfo__ArtifactData___)
		  ;
		  uVar2 = func_ii_6295(uVar2,Method_System_Linq_Enumerable_ToArray_ArtifactData___);
		  if (DAT_ram_00a63a32 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactData____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_RequestSellArtifacts__);
		    DAT_ram_00a63a32 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param2_00 + 0x100) * 4))
		                    (param2_00,*(undefined4 *)(*param2_00 + 0x104));
		  param1_00 = *(undefined4 *)(iVar1 + 8);
		  uVar3 = unnamed_function_1417(System_Action_ArtifactData____TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param2_00,Method_Gameplay_Craft_Controller_CraftController_RequestSellArtifacts__
		             ,0);
		  UI_Windows_ConfirmSellUserArtifactWindow__HandleContent(param1_00,uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003507 RID: 13575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003507")]
		[Address(RVA = "0x8530", Offset = "0x8530", VA = "0x8530")]
		private void SellAllButtonClickedEventHandler()
		{
		/* --- GHIDRA: SellAllButtonClickedEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__SellAllButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63a4d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__);
		    DAT_ram_00a63a4d = '\x01';
		  }
		  iVar1 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(param1 + 0x2c),*(undefined4 *)(param1 + 0x30),
		                     Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__);
		  Gameplay_Craft_Controller_CraftViewMediator__ShowStartCraftingConfirmationWindow
		            (param1,*(undefined4 *)(iVar1 + 0x48),0,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003508 RID: 13576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003508")]
		[Address(RVA = "0x8531", Offset = "0x8531", VA = "0x8531")]
		private void RentButtonClickedEventHandler()
		{
		/* --- GHIDRA: RentButtonClickedEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__RentButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Craft_Controller_CraftViewMediator__ShowRentSlotConfirmationWindow(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003509 RID: 13577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003509")]
		[Address(RVA = "0x8532", Offset = "0x8532", VA = "0x8532")]
		private void AccelerateButtonClickedEventHandler()
		{
		/* --- GHIDRA: AccelerateButtonClickedEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__AccelerateButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 param2_01;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63a6f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Craft_Controller_CraftController_CancelCraft__);
		    DAT_ram_00a63a6f = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1[2] + 8);
		  if (DAT_ram_00a63a4d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__);
		    DAT_ram_00a63a4d = '\x01';
		  }
		  param2_00 = System_Linq_Enumerable__ToList_object_
		                        (param1[0xb],param1[0xc],
		                         Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__);
		  param2_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_00 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(param1_00,param2_01,Method_Gameplay_Craft_Controller_CraftController_CancelCraft__,0
		               );
		  UI_Windows_ConfirmCancelCraftWindow__HandleContent(param1_01,param2_00,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600350A RID: 13578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350A")]
		[Address(RVA = "0x8533", Offset = "0x8533", VA = "0x8533")]
		private void CancelButtonClickedEventHandler()
		{
		/* --- GHIDRA: CancelButtonClickedEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__CancelButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  
		  if (DAT_ram_00a63a70 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftViewMediator__MaxLevelButtonClickedEventHandler_b__76_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_ProfessionDic_Types_LevelInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_ProfessionDic_Types_LevelInfo__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4466);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4469);
		    DAT_ram_00a63a70 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x18) + 0x14);
		  uVar1 = unnamed_function_1417(System_Func_ProfessionDic_Types_LevelInfo__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param1,
		             Method_Gameplay_Craft_Controller_CraftViewMediator__MaxLevelButtonClickedEventHandler_b__76_0__
		             ,0);
		  iVar2 = System_Func_object__bool____ctor
		                    (uVar3,uVar1,
		                     Method_System_Linq_Enumerable_FirstOrDefault_ProfessionDic_Types_LevelInfo___);
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  puVar4 = &StringLiteral_4466;
		  if (iVar2 == 0) {
		    puVar4 = &StringLiteral_4469;
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar4,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar1,7,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x0600350B RID: 13579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350B")]
		[Address(RVA = "0x8534", Offset = "0x8534", VA = "0x8534")]
		private void MaxLevelButtonClickedEventHandler()
		{
		/* --- GHIDRA: MaxLevelButtonClickedEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__MaxLevelButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined1 auStack_8 [8];
		  
		  if (DAT_ram_00a63a71 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_CraftSlotListElement___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderBy_CraftSlotListElement__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_CraftSlotListElement__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_CraftSlotListElement__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftViewMediator___c__CraftButtonClickedEventHandler_b__77_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftViewMediator___c__CraftButtonClickedEventHandler_b__77_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftViewMediator___c__CraftButtonClickedEventHandler_b__77_2__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftViewMediator___c__DisplayClass77_0__CraftButtonClickedEventHandler_b__3__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Craft_Controller_CraftViewMediator___c__DisplayClass77_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		    DAT_ram_00a63a71 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Craft_Controller_CraftViewMediator___c__DisplayClass77_0_TypeInfo);
		  *(int **)(iVar1 + 8) = param1;
		  iVar3 = param1[0xb];
		  if (*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c);
		  iVar5 = puVar4[8];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar4;
		    iVar5 = unnamed_function_1417(System_Func_CraftSlotListElement__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar5,uVar2,
		               Method_Gameplay_Craft_Controller_CraftViewMediator___c__CraftButtonClickedEventHandler_b__77_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c) + 0x20) =
		         iVar5;
		  }
		  uVar2 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (iVar3,iVar5,Method_System_Linq_Enumerable_OrderBy_CraftSlotListElement__uint___
		                    );
		  if (*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c);
		  iVar3 = puVar4[9];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar6 = *puVar4;
		    iVar3 = unnamed_function_1417(System_Func_CraftSlotListElement__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar3,uVar6,
		               Method_Gameplay_Craft_Controller_CraftViewMediator___c__CraftButtonClickedEventHandler_b__77_1__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c) + 0x24) =
		         iVar3;
		  }
		  iVar3 = System_Func_object__bool____ctor
		                    (uVar2,iVar3,
		                     Method_System_Linq_Enumerable_FirstOrDefault_CraftSlotListElement___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar5 = func_ii_3812(iVar3,0,0);
		  if (iVar5 == 0) {
		    iVar1 = Gameplay_Craft_Model_CraftModel__SetCraftSlots
		                      (param1[2],*(undefined4 *)(*(int *)(iVar3 + 0x48) + 0xc),auStack_8,param1);
		    if (iVar1 == 0) {
		      Gameplay_Craft_Controller_CraftViewMediator__CraftButtonClickedEventHandler
		                (param1,iVar3,param1);
		    }
		    else {
		      Gameplay_Craft_Controller_CraftViewMediator__ShowAccelerateConfirmationWindow(param1,param1);
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		      Gameplay_Craft_Controller_CraftController__GetUserProfessionsResultHandler(uVar2,param1);
		    }
		  }
		  else {
		    iVar3 = param1[0xb];
		    if (*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		    }
		    puVar4 = *(undefined4 **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c);
		    iVar5 = puVar4[10];
		    if (iVar5 == 0) {
		      if (*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo);
		        puVar4 = *(undefined4 **)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c);
		      }
		      uVar2 = *puVar4;
		      iVar5 = unnamed_function_1417(System_Func_CraftSlotListElement__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (iVar5,uVar2,
		                 Method_Gameplay_Craft_Controller_CraftViewMediator___c__CraftButtonClickedEventHandler_b__77_2__
		                 ,0);
		      *(int *)(*(int *)(Gameplay_Craft_Controller_CraftViewMediator___c_TypeInfo + 0x5c) + 0x28) =
		           iVar5;
		    }
		    uVar2 = System_Func_object__bool____ctor
		                      (iVar3,iVar5,
		                       Method_System_Linq_Enumerable_FirstOrDefault_CraftSlotListElement___);
		    *(undefined4 *)(iVar1 + 0xc) = uVar2;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar3 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		    if (iVar3 == 0) {
		      Gameplay_Craft_Controller_CraftViewMediator__ShowSlotExpiredWindow(param1,param1);
		    }
		    else {
		      uVar6 = *(undefined4 *)(*(int *)(iVar1 + 0xc) + 0x48);
		      uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar2,iVar1,
		                 Method_Gameplay_Craft_Controller_CraftViewMediator___c__DisplayClass77_0__CraftButtonClickedEventHandler_b__3__
		                 ,0);
		      Gameplay_Craft_Controller_CraftViewMediator__ShowStartCraftingConfirmationWindow
		                (param1,uVar6,uVar2,param1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600350C RID: 13580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350C")]
		[Address(RVA = "0x8535", Offset = "0x8535", VA = "0x8535")]
		private void CraftButtonClickedEventHandler()
		{
		/* --- GHIDRA: CraftButtonClickedEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__CraftButtonClickedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *param4;
		  int iVar4;
		  uint param2_00;
		  int *param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63a72 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63a72 = '\x01';
		  }
		  local_4 = 0;
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param2,0,0);
		  if (iVar2 != 0) {
		    uVar3 = func_ii_7504(*(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		    iVar2 = Core_Data_UserData__get_Accounts(uVar3,3,&local_4,0);
		    if (iVar2 != 0) {
		      iVar2 = *(int *)(*(int *)(param1 + 0x24) + 0x10);
		      iVar4 = *(int *)(iVar2 + 8);
		      param2_00 = *(uint *)(iVar4 + 0x10);
		      if (param2_00 < 2) {
		        Gameplay_Craft_Controller_CraftViewMediator__PickerWindowOnClose
		                  (param1,*(undefined4 *)(iVar4 + 0xc),1,iVar4);
		        return;
		      }
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar4 = *param1_00;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		            param4 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x160);
		            goto code_r0x823346fd;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      param4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x823346fd:
		      uVar3 = (**(code **)((ulonglong)*param4 * 4))(param1_00,param4[1]);
		      uVar3 = Core_Gameplay_Managers_Requirements_RequirementsManager__CheckMaterials
		                        (uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0xc) + 8) + 0x14),
		                         *(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		      Gameplay_Craft_Controller_CraftViewMediator__DelayedRequest(param1,param2_00,uVar3,param4);
		      return;
		    }
		  }
		  Gameplay_Craft_Controller_CraftViewMediator__PickerWindowOnClose
		            (param1,*(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 0x24) + 0x10) + 8) + 0xc),1,
		             param2);
		  return;
		}
		*/

		}

		// Token: 0x0600350D RID: 13581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350D")]
		[Address(RVA = "0x8536", Offset = "0x8536", VA = "0x8536")]
		private void PickQuantityToCraft(CraftSlotListElement freeSlot)
		{
		/* --- GHIDRA: PickQuantityToCraft ---
		void Gameplay_Craft_Controller_CraftViewMediator__PickQuantityToCraft(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63a73 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CraftSchemeData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftViewMediator__DeleteButtonClickedEventHandler_b__79_0__
		              );
		    DAT_ram_00a63a73 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x24) + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_CraftSchemeData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Craft_Controller_CraftViewMediator__DeleteButtonClickedEventHandler_b__79_0__
		             ,0);
		  UI_Windows_ConfirmDeleteCraftSchemeWindow__HandleContent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600350E RID: 13582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350E")]
		[Address(RVA = "0x8537", Offset = "0x8537", VA = "0x8537")]
		private void DeleteButtonClickedEventHandler()
		{
		/* --- GHIDRA: DeleteButtonClickedEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__DeleteButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(*(int *)(iVar1 + 0x40) + 0x3c) != 1) {
		    Gameplay_Craft_Controller_CraftViewMediator__HandleActiveSlot(param1,param1);
		    return;
		  }
		  Gameplay_Craft_Controller_CraftViewMediator__HandleRecipesView(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600350F RID: 13583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350F")]
		[Address(RVA = "0x8538", Offset = "0x8538", VA = "0x8538")]
		private void TabChangedEventHandler()
		{
		/* --- GHIDRA: TabChangedEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__TabChangedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Craft_Controller_CraftViewMediator__UpdateRecipeInfo(param1,param1);
		  Gameplay_Craft_Controller_CraftViewMediator__PopulateFiltersData(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003510 RID: 13584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003510")]
		[Address(RVA = "0x8539", Offset = "0x8539", VA = "0x8539")]
		private void FiltersViewChangedEventHandler()
		{
		/* --- GHIDRA: FiltersViewChangedEventHandler ---
		void Gameplay_Craft_Controller_CraftViewMediator__FiltersViewChangedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Craft_Controller_CraftViewMediator__RedrawCraftSlots(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003511 RID: 13585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003511")]
		[Address(RVA = "0x853A", Offset = "0x853A", VA = "0x853A")]
		private void CompletedToggleChangedEventHandler()
		{
		/* --- GHIDRA: CompletedToggleChangedEventHandler ---
		uint Gameplay_Craft_Controller_CraftViewMediator__CompletedToggleChangedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  return (uint)(*(int *)(*(int *)(*(int *)(*(int *)(param2 + 0x10) + 0xc) + 8) + 0xc) ==
		               *(int *)(param1 + 0x34));
		}
		*/

		}

		// Token: 0x06003515 RID: 13589 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003515")]
		[Address(RVA = "0x853E", Offset = "0x853E", VA = "0x853E")]
		[CompilerGenerated]
		private ArtifactData <SellAllButtonClickedEventHandler>g__GetArtifactData|72_0(ArtifactInfo artifactInfo)
		{
			return null;
		}

		// Token: 0x04001CEC RID: 7404
		[Token(Token = "0x4001CEC")]
		private const string LOCALIZATION_MASTERY_LEVEL = "CRAFT/MASTERY_LEVEL";

		// Token: 0x04001CED RID: 7405
		[Token(Token = "0x4001CED")]
		private const string LOCALIZATION_TIL_NEXT_LEVEL = "CRAFT/TIL_NEXT_LEVEL";

		// Token: 0x04001CEE RID: 7406
		[Token(Token = "0x4001CEE")]
		private const string LOCALIZATION_MAX_LEVEL_ANNOTATION = "CRAFT/MAX_LEVEL_ANNOTATION";

		// Token: 0x04001CEF RID: 7407
		[Token(Token = "0x4001CEF")]
		private const string LOCALIZATION_PRODUCTION = "CRAFT/PRODUCTION";

		// Token: 0x04001CF0 RID: 7408
		[Token(Token = "0x4001CF0")]
		private const string LOCALIZATION_CRAFT = "CRAFT/CRAFT";

		// Token: 0x04001CF1 RID: 7409
		[Token(Token = "0x4001CF1")]
		private const string LOCALIZATION_START_PRODUCTION = "CRAFT/START_PRODUCTION";

		// Token: 0x04001CF2 RID: 7410
		[Token(Token = "0x4001CF2")]
		private const string LOCALIZATION_BUYING_SLOT = "CRAFT/BUYING_SLOT";

		// Token: 0x04001CF3 RID: 7411
		[Token(Token = "0x4001CF3")]
		private const string LOCALIZATION_BUYING_SLOT_ANNOTATION = "CRAFT/BUYING_SLOT_ANNOTATION";

		// Token: 0x04001CF4 RID: 7412
		[Token(Token = "0x4001CF4")]
		private const string LOCALIZATION_ACCELERATE = "BUILDINGS/ACCELERATE_BUTTON";

		// Token: 0x04001CF5 RID: 7413
		[Token(Token = "0x4001CF5")]
		private const string LOCALIZATION_CRAFT_ACCELERATION = "CRAFT/CRAFT_ACCELERATION";

		// Token: 0x04001CF6 RID: 7414
		[Token(Token = "0x4001CF6")]
		private const string LOCALIZATION_CRAFT_ACCELERATION_ANNOTATION = "CRAFT/CRAFT_ACCELERATION_ANNOTATION";

		// Token: 0x04001CF7 RID: 7415
		[Token(Token = "0x4001CF7")]
		private const string LOCALIZATION_SLOT_EXPIRED = "CRAFT/SLOT_EXPIRED";

		// Token: 0x04001CF8 RID: 7416
		[Token(Token = "0x4001CF8")]
		private const string LOCALIZATION_SLOT_EXPIRED_ANNOTATION = "CRAFT/SLOT_EXPIRED_ANNOTATION";

		// Token: 0x04001CF9 RID: 7417
		[Token(Token = "0x4001CF9")]
		private const string LOCALIZATION_MAX_SKILL_LEVEL = "CRAFT/MAX_SKILL_LEVEL";

		// Token: 0x04001CFA RID: 7418
		[Token(Token = "0x4001CFA")]
		private const string LOCALIZATION_MAX_LEVEL_NOTE = "CRAFT/MAX_LEVEL_NOTE";

		// Token: 0x04001CFB RID: 7419
		[Token(Token = "0x4001CFB")]
		private const string LOCALIZATION_MAX_SKILL_LEVEL_ACHIEVED = "CRAFT/MAX_SKILL_LEVEL_ACHIEVED";

		// Token: 0x04001CFC RID: 7420
		[Token(Token = "0x4001CFC")]
		private const int MANUFACTURE_INDEX = 1;

		// Token: 0x04001CFD RID: 7421
		[Token(Token = "0x4001CFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<FilterInfo.FilterType, ICraftFilter> _filters;

		// Token: 0x04001CFE RID: 7422
		[Token(Token = "0x4001CFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly ICraftFilter _achievedFilter;

		// Token: 0x04001CFF RID: 7423
		[Token(Token = "0x4001CFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly CraftFilters.CompletedFilter _completedFilter;

		// Token: 0x04001D00 RID: 7424
		[Token(Token = "0x4001D00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private CraftRecipeListElement.CraftRecipeListElementArgs _selectedArgs;

		// Token: 0x04001D01 RID: 7425
		[Token(Token = "0x4001D01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CraftSpinPickerDialogWindow _pickerWindow;

		// Token: 0x04001D02 RID: 7426
		[Token(Token = "0x4001D02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private List<CraftSlotListElement> _slots;

		// Token: 0x04001D03 RID: 7427
		[Token(Token = "0x4001D03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _selectedSlotIndex;

		// Token: 0x04001D04 RID: 7428
		[Token(Token = "0x4001D04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private uint _selectedSchemeId;

		// Token: 0x04001D05 RID: 7429
		[Token(Token = "0x4001D05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Coroutine _timerRoutine;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SelectedSlot ---
		void Gameplay_Craft_Controller_CraftViewMediator__get_SelectedSlot
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a63a4e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftViewMediator_AccelerateButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator_CancelButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftViewMediator_CompletedToggleChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator_CraftButtonClickedEventHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator_DeleteButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator_FiltersViewChangedEventHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftViewMediator_InChestButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftViewMediator_MaxLevelButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator_RentButtonClickedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftViewMediator_SellAllButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator_TabChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator_TakeButtonClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a63a4e = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x48);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_FiltersViewChangedEventHandler__,0
		              );
		    UI_Filters_FiltersView__add_ChangedEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x40);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_TabChangedEventHandler__,0);
		    UI_Tabs_TabBar__add_ChangeEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 100);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_CompletedToggleChangedEventHandler__
		               ,0);
		    UI_Toggle_GreenToggle__add_ChangedEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x4c) + 0x38) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_CraftButtonClickedEventHandler__,0
		              );
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x4c) + 0x3c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_DeleteButtonClickedEventHandler__,
		               0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x4c) + 0x40) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_AccelerateButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x4c) + 0x44) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_CancelButtonClickedEventHandler__,
		               0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x58) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_MaxLevelButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x4c) + 0x54) + 0x10) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_RentButtonClickedEventHandler__,0)
		    ;
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x4c) + 0x48) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_TakeButtonClickedEventHandler__,0)
		    ;
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x4c) + 0x4c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_SellAllButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x6c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_InChestButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x48);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_FiltersViewChangedEventHandler__,0
		              );
		    UI_Filters_FiltersView__get_PriceFilterButton(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x40);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_TabChangedEventHandler__,0);
		    UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 100);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_CompletedToggleChangedEventHandler__
		               ,0);
		    UI_ToolTip_Controller_Android_ToolTipController__GetPointerPosition(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x4c) + 0x38) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_CraftButtonClickedEventHandler__,0
		              );
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x4c) + 0x3c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_DeleteButtonClickedEventHandler__,
		               0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x4c) + 0x40) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_AccelerateButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x4c) + 0x44) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_CancelButtonClickedEventHandler__,
		               0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x58) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_MaxLevelButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x4c) + 0x54) + 0x10) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_RentButtonClickedEventHandler__,0)
		    ;
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x4c) + 0x48) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_TakeButtonClickedEventHandler__,0)
		    ;
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x4c) + 0x4c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_SellAllButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x6c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_InChestButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    Gameplay_Craft_Controller_CraftViewMediator__set_Controller(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Craft_Controller_CraftViewMediator__set_View(int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  uint *puVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a63a4f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_UserScheme__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator_ArtifactTakenEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator_ArtifactTakenEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator_CraftSlotsChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator_CraftSlotsRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator_ProfessionRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator_SchemeChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator_SchemesRequestedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftViewMediator_UserBalanceChangedEventHandler__)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a63a4f = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar2 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar8 = *(undefined4 *)(iVar3 + 0x14);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_ProfessionRequestedEventHandler__,
		               0);
		    piVar5 = (int *)func_ii_7048(uVar8,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x14) = piVar5, *piVar5 != iVar2)) {
		      System_Activator__CreateInstance(piVar5,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar8 = *(undefined4 *)(iVar3 + 0x18);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_SchemesRequestedEventHandler__,0);
		    piVar5 = (int *)func_ii_7048(uVar8,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x18) = piVar5, *piVar5 != iVar2)) {
		      System_Activator__CreateInstance(piVar5,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar8 = *(undefined4 *)(iVar3 + 0x1c);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_CraftSlotsRequestedEventHandler__,
		               0);
		    piVar5 = (int *)func_ii_7048(uVar8,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x1c) = piVar5, *piVar5 != iVar2)) {
		      System_Activator__CreateInstance(piVar5,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar8 = *(undefined4 *)(iVar2 + 0x24);
		    uVar4 = unnamed_function_1417(System_Action_UserScheme__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_SchemeChangedEventHandler__,0);
		    iVar3 = func_ii_7048(uVar8,uVar4,0);
		    uVar4 = System_Action_UserScheme__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		    }
		    else {
		      iVar6 = func_ii_1082(iVar3,System_Action_UserScheme__TypeInfo);
		      if (iVar6 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar2 + 0x24) = iVar6;
		      uVar4 = System_Action_UserScheme__TypeInfo;
		      iVar2 = func_ii_1082(iVar3,System_Action_UserScheme__TypeInfo);
		      if (iVar2 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar8 = *(undefined4 *)(iVar3 + 0x28);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_CraftSlotsChangedEventHandler__,0)
		    ;
		    piVar5 = (int *)func_ii_7048(uVar8,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x28) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x28) = piVar5, *piVar5 != iVar2)) {
		      System_Activator__CreateInstance(piVar5,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar8 = *(undefined4 *)(iVar3 + 0x20);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_UserBalanceChangedEventHandler__,0
		              );
		    piVar5 = (int *)func_ii_7048(uVar8,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x20) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x20) = piVar5, *piVar5 != iVar2)) {
		      System_Activator__CreateInstance(piVar5,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar7 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x150);
		          goto code_r0x8232fb4b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar7 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x8232fb4b:
		    iVar2 = (**(code **)((ulonglong)*puVar7 * 4))(piVar5,puVar7[1]);
		    iVar3 = **(int **)(iVar2 + 0x10);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x110) * 4))
		                      (*(int **)(iVar2 + 0x10),*(undefined4 *)(iVar3 + 0x114));
		    uVar8 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar4 = unnamed_function_1417(System_Action_DropTypes__ArtifactData__TypeInfo);
		    System_Action_Int32Enum__Int32Enum___Invoke
		              (uVar4,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_ArtifactTakenEventHandler__,0);
		    iVar3 = func_ii_7048(uVar8,uVar4,0);
		    uVar4 = System_Action_DropTypes__ArtifactData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else {
		      iVar6 = func_ii_1082(iVar3,System_Action_DropTypes__ArtifactData__TypeInfo);
		      if (iVar6 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar2 + 0x1c) = iVar6;
		      uVar4 = System_Action_DropTypes__ArtifactData__TypeInfo;
		      iVar2 = func_ii_1082(iVar3,System_Action_DropTypes__ArtifactData__TypeInfo);
		      if (iVar2 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar7 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x150);
		          goto code_r0x8232fc7b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar7 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x8232fc7b:
		    iVar2 = (**(code **)((ulonglong)*puVar7 * 4))(piVar5,puVar7[1]);
		    iVar3 = **(int **)(iVar2 + 0x10);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x110) * 4))
		                      (*(int **)(iVar2 + 0x10),*(undefined4 *)(iVar3 + 0x114));
		    uVar8 = *(undefined4 *)(iVar2 + 0x18);
		    uVar4 = unnamed_function_1417(System_Action_DropTypes__TypeInfo);
		    System_Action_int___Invoke
		              (uVar4,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_ArtifactTakenEventHandler__,0);
		    iVar3 = func_ii_7048(uVar8,uVar4,0);
		    uVar4 = System_Action_DropTypes__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else {
		      iVar6 = func_ii_1082(iVar3,System_Action_DropTypes__TypeInfo);
		      if (iVar6 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar2 + 0x18) = iVar6;
		      uVar4 = System_Action_DropTypes__TypeInfo;
		      iVar2 = func_ii_1082(iVar3,System_Action_DropTypes__TypeInfo);
		      if (iVar2 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar2 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar8 = *(undefined4 *)(iVar3 + 0x14);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_ProfessionRequestedEventHandler__,
		               0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar8,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x14) = piVar5, *piVar5 != iVar2)) {
		      System_Activator__CreateInstance(piVar5,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar8 = *(undefined4 *)(iVar3 + 0x18);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_SchemesRequestedEventHandler__,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar8,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x18) = piVar5, *piVar5 != iVar2)) {
		      System_Activator__CreateInstance(piVar5,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar8 = *(undefined4 *)(iVar3 + 0x1c);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_CraftSlotsRequestedEventHandler__,
		               0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar8,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x1c) = piVar5, *piVar5 != iVar2)) {
		      System_Activator__CreateInstance(piVar5,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar8 = *(undefined4 *)(iVar2 + 0x24);
		    uVar4 = unnamed_function_1417(System_Action_UserScheme__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_SchemeChangedEventHandler__,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar8,uVar4,0);
		    uVar4 = System_Action_UserScheme__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		    }
		    else {
		      iVar6 = func_ii_1082(iVar3,System_Action_UserScheme__TypeInfo);
		      if (iVar6 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar2 + 0x24) = iVar6;
		      uVar4 = System_Action_UserScheme__TypeInfo;
		      iVar2 = func_ii_1082(iVar3,System_Action_UserScheme__TypeInfo);
		      if (iVar2 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar8 = *(undefined4 *)(iVar3 + 0x28);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_CraftSlotsChangedEventHandler__,0)
		    ;
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar8,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x28) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x28) = piVar5, *piVar5 != iVar2)) {
		      System_Activator__CreateInstance(piVar5,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar8 = *(undefined4 *)(iVar3 + 0x20);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_UserBalanceChangedEventHandler__,0
		              );
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar8,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x20) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x20) = piVar5, *piVar5 != iVar2)) {
		      System_Activator__CreateInstance(piVar5,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar7 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x150);
		          goto code_r0x823300a8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar7 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x823300a8:
		    iVar2 = (**(code **)((ulonglong)*puVar7 * 4))(piVar5,puVar7[1]);
		    iVar3 = **(int **)(iVar2 + 0x10);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x110) * 4))
		                      (*(int **)(iVar2 + 0x10),*(undefined4 *)(iVar3 + 0x114));
		    uVar8 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar4 = unnamed_function_1417(System_Action_DropTypes__ArtifactData__TypeInfo);
		    System_Action_Int32Enum__Int32Enum___Invoke
		              (uVar4,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_ArtifactTakenEventHandler__,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar8,uVar4,0);
		    uVar4 = System_Action_DropTypes__ArtifactData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else {
		      iVar6 = func_ii_1082(iVar3,System_Action_DropTypes__ArtifactData__TypeInfo);
		      if (iVar6 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar2 + 0x1c) = iVar6;
		      uVar4 = System_Action_DropTypes__ArtifactData__TypeInfo;
		      iVar2 = func_ii_1082(iVar3,System_Action_DropTypes__ArtifactData__TypeInfo);
		      if (iVar2 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar7 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x150);
		          goto code_r0x823301d8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar7 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x823301d8:
		    iVar2 = (**(code **)((ulonglong)*puVar7 * 4))(piVar5,puVar7[1]);
		    iVar3 = **(int **)(iVar2 + 0x10);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x110) * 4))
		                      (*(int **)(iVar2 + 0x10),*(undefined4 *)(iVar3 + 0x114));
		    uVar8 = *(undefined4 *)(iVar2 + 0x18);
		    uVar4 = unnamed_function_1417(System_Action_DropTypes__TypeInfo);
		    System_Action_int___Invoke
		              (uVar4,param1,
		               Method_Gameplay_Craft_Controller_CraftViewMediator_ArtifactTakenEventHandler__,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar8,uVar4,0);
		    uVar4 = System_Action_DropTypes__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		      return;
		    }
		    iVar6 = func_ii_1082(iVar3,System_Action_DropTypes__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar2 + 0x18) = iVar6;
		    uVar4 = System_Action_DropTypes__TypeInfo;
		    iVar2 = func_ii_1082(iVar3,System_Action_DropTypes__TypeInfo);
		    if (iVar2 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Craft_Controller_CraftViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a63a50 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__set_Controller__
		              );
		    DAT_ram_00a63a50 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (iVar1 != 0) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    Gameplay_Craft_Controller_CraftController__Subscribe(uVar2,param1);
		  }
		  param1[4] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (iVar1 != 0) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    Gameplay_Craft_Controller_CraftController__CraftSlotsChangedEventHandler(uVar2,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Controller ---
		void Gameplay_Craft_Controller_CraftViewMediator__set_Controller(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63a51 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CraftModel__CraftEvents__CraftController__CraftWindow__get_Model__
		              );
		    DAT_ram_00a63a51 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Craft_Controller_CraftController__GetUserProfessionsResultHandler(uVar1,param1);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Craft_Controller_CraftController__SpeedupCraftResultHandler(uVar1,param1);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Craft_Controller_CraftController__SellArtifactsResultHandler(uVar1,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar2 + 0x40);
		  uVar1 = Gameplay_Craft_Model_CraftModel__PopulateSchemes(param1,param1);
		  UI_Tabs_TabBar__HandleSelected(param1_00,uVar1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(iVar2 + 0x40),0,1,0);
		  Gameplay_Craft_Controller_CraftViewMediator__UpdateRecipeInfo(param1,param1);
		  return;
		}
		*/

}
