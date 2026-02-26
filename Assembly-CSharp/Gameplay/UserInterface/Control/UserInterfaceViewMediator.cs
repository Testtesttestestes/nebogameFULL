using System;
using System.Collections.Generic;
using Core.Data;
using DefaultNamespace;
using Gameplay.UserInterface.Events;
using Gameplay.UserInterface.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using MVC;
using UI;

namespace Gameplay.UserInterface.Control
{
	// Token: 0x020003ED RID: 1005
	[Token(Token = "0x20003ED")]
	public class UserInterfaceViewMediator : AbstractViewMediator<UserInterfaceModel, UserInterfaceEvents, UserInterfaceController, UserInterfaceView>
	{
		// Token: 0x06001777 RID: 6007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001777")]
		[Address(RVA = "0x6933", Offset = "0x6933", VA = "0x6933")]
		public UserInterfaceViewMediator(UserInterfaceModel model, UserInterfaceEvents events, UserInterfaceController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInterface_Control_UserInterfaceViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a598b7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserInterfaceView__set_View__
		              );
		    DAT_ram_00a598b7 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_UserInterface_Control_UserInterfaceViewMediator__CraftButtonOnClickEvent(param1,param1)
		    ;
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_UserInterface_Control_UserInterfaceViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000411 RID: 1041
		// (set) Token: 0x06001778 RID: 6008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000411")]
		public override UserInterfaceView View
		{
			[Token(Token = "0x6001778")]
			[Address(RVA = "0x6934", Offset = "0x6934", VA = "0x6934", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000412 RID: 1042
		// (set) Token: 0x06001779 RID: 6009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000412")]
		public override UserInterfaceEvents Events
		{
			[Token(Token = "0x6001779")]
			[Address(RVA = "0x6935", Offset = "0x6935", VA = "0x6935", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177A")]
		[Address(RVA = "0x6936", Offset = "0x6936", VA = "0x6936")]
		private void HandleApplicationScenesChangedEvent(IList<Scenes> scenes)
		{
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177B")]
		[Address(RVA = "0x6937", Offset = "0x6937", VA = "0x6937")]
		private void HandleUserTriggerChangedEvent(UserData user)
		{
		/* --- GHIDRA: HandleUserTriggerChangedEvent ---
		void Gameplay_UserInterface_Control_UserInterfaceViewMediator__HandleUserTriggerChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a598ba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserInterfaceView__get_Model__
		              );
		    DAT_ram_00a598ba = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_UserInterface_View_ShowHideUIElementByRestrictions___ctor
		            (*(undefined4 *)(iVar1 + 0x1c),param2,*(undefined4 *)(param1[2] + 0x14),
		             *(undefined4 *)(param1[2] + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177C")]
		[Address(RVA = "0x6938", Offset = "0x6938", VA = "0x6938")]
		private void HandleUIElementsByRestrictions(UserData user)
		{
		/* --- GHIDRA: HandleUIElementsByRestrictions ---
		void Gameplay_UserInterface_Control_UserInterfaceViewMediator__HandleUIElementsByRestrictions
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a598bb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserInterfaceView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a598bb = '\x01';
		  }
		  param1_01 = *(int **)(*(int *)(param1 + 8) + 0x20);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x230);
		        goto code_r0x81085975;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x81085975:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_ClansManager__HandleControllerInitEvent(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600177D RID: 6013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177D")]
		[Address(RVA = "0x6939", Offset = "0x6939", VA = "0x6939")]
		private void ClanButtonOnClickEvent(IndexButtonBasic obj)
		{
		/* --- GHIDRA: ClanButtonOnClickEvent ---
		void Gameplay_UserInterface_Control_UserInterfaceViewMediator__ClanButtonOnClickEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_UserInterface_Control_UserInterfaceViewMediator__ValidateMovementButtons(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600177E RID: 6014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177E")]
		[Address(RVA = "0x693A", Offset = "0x693A", VA = "0x693A")]
		private void MenuButtonOnClickEvent(IndexButtonBasic obj)
		{
		/* --- GHIDRA: MenuButtonOnClickEvent ---
		void Gameplay_UserInterface_Control_UserInterfaceViewMediator__MenuButtonOnClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a598bc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserInterfaceView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_TradeAndCraft_View_TradeOptionsWindow_TradeOptionsWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12678);
		    DAT_ram_00a598bc = '\x01';
		  }
		  piVar3 = *(int **)(*(int *)(param1 + 8) + 0x20);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x81085c17;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81085c17:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x81085c99;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x81085c99:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param1_01 = unnamed_function_1417
		                        (
		                        Gameplay_TradeAndCraft_View_TradeOptionsWindow_TradeOptionsWindowArgs_TypeInfo
		                        );
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_01,0);
		  UI_Windows_PopupController__set_TopWindow(param1_00,StringLiteral_12678,param1_01,0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600177F RID: 6015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177F")]
		[Address(RVA = "0x693B", Offset = "0x693B", VA = "0x693B")]
		private void TradeButtonOnClickEvent(IndexButtonBasic obj)
		{
		/* --- GHIDRA: TradeButtonOnClickEvent ---
		void Gameplay_UserInterface_Control_UserInterfaceViewMediator__TradeButtonOnClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a598bd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserInterfaceView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_TradeAndCraft_View_CraftOptionsWindow_CraftWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12676);
		    DAT_ram_00a598bd = '\x01';
		  }
		  piVar3 = *(int **)(*(int *)(param1 + 8) + 0x20);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x81085d89;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81085d89:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x81085e0b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x81085e0b:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param1_01 = unnamed_function_1417
		                        (Gameplay_TradeAndCraft_View_CraftOptionsWindow_CraftWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_01,0);
		  UI_Windows_PopupController__set_TopWindow(param1_00,StringLiteral_12676,param1_01,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001780")]
		[Address(RVA = "0x693C", Offset = "0x693C", VA = "0x693C")]
		private void CraftButtonOnClickEvent(IndexButtonBasic obj)
		{
		/* --- GHIDRA: CraftButtonOnClickEvent ---
		void Gameplay_UserInterface_Control_UserInterfaceViewMediator__CraftButtonOnClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a598be == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_BonusesButtonOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_ChestButtonOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_ClanButtonOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_CraftButtonOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_MenuButtonOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_TradeButtonOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_UserInterfaceWorldButtonsViewOnHomeButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_UserInterfaceWorldButtonsViewOnZigguratButtonClickedEvent__
		              );
		    DAT_ram_00a598be = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x14) + 0x30);
		  uVar2 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_TradeButtonOnClickEvent__
		             ,0);
		  UI_IndexButtonBasic__add_ClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x14) + 0x34);
		  uVar2 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_CraftButtonOnClickEvent__
		             ,0);
		  UI_IndexButtonBasic__add_ClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x14) + 0x38);
		  uVar2 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_MenuButtonOnClickEvent__
		             ,0);
		  UI_IndexButtonBasic__add_ClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x14) + 0x40);
		  uVar2 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_ClanButtonOnClickEvent__
		             ,0);
		  UI_IndexButtonBasic__add_ClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x14) + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_ChestButtonOnClickEvent__
		             ,0);
		  UI_IndexButtonBasic__add_ClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x14) + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_BonusesButtonOnClickEvent__
		             ,0);
		  UI_IndexButtonBasic__add_ClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_UserInterfaceWorldButtonsViewOnHomeButtonClickedEvent__
		             ,0);
		  Gameplay_UserInterface_View_WorldIndexButtonsView__add_HomeButtonClickedEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_UserInterfaceWorldButtonsViewOnZigguratButtonClickedEvent__
		             ,0);
		  Gameplay_UserInterface_View_WorldIndexButtonsView__add_ZigguratButtonClickedEvent(uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001781")]
		[Address(RVA = "0x693D", Offset = "0x693D", VA = "0x693D")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_UserInterface_Control_UserInterfaceViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  
		  if (DAT_ram_00a598bf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserInterfaceView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountHandler_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_BonusesButtonOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_ChestButtonOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_ClanButtonOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_CraftButtonOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_MenuButtonOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_TradeButtonOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_UserInterfaceWorldButtonsViewOnHomeButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_UserInterfaceWorldButtonsViewOnZigguratButtonClickedEvent__
		              );
		    DAT_ram_00a598bf = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x30);
		  uVar3 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_TradeButtonOnClickEvent__
		             ,0);
		  UI_IndexButtonBasic__get_CanvasGroup(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x34);
		  uVar3 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_CraftButtonOnClickEvent__
		             ,0);
		  UI_IndexButtonBasic__get_CanvasGroup(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x38);
		  uVar3 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_MenuButtonOnClickEvent__
		             ,0);
		  UI_IndexButtonBasic__get_CanvasGroup(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x40);
		  uVar3 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_ClanButtonOnClickEvent__
		             ,0);
		  UI_IndexButtonBasic__get_CanvasGroup(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_ChestButtonOnClickEvent__
		             ,0);
		  UI_IndexButtonBasic__get_CanvasGroup(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_BonusesButtonOnClickEvent__
		             ,0);
		  UI_IndexButtonBasic__get_CanvasGroup(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(iVar2 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_UserInterfaceWorldButtonsViewOnHomeButtonClickedEvent__
		             ,0);
		  Gameplay_UserInterface_View_UserView___ctor(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(iVar2 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_UserInterfaceWorldButtonsViewOnZigguratButtonClickedEvent__
		             ,0);
		  Gameplay_UserInterface_View_WorldIndexButtonsView__remove_HomeButtonClickedEvent(uVar5,uVar3,0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar3,0);
		  piVar6 = *(int **)(param1[2] + 0x20);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		        goto code_r0x81084963;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81084963:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar1 = 0;
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe8);
		        goto code_r0x810849e7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,5);
		code_r0x810849e7:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  iVar2 = UI_Windows_PopupController__BringWindowToFront(uVar5,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,(uint)(iVar2 == 0),0);
		  uVar3 = *(undefined4 *)(param1[2] + 8);
		  if (DAT_ram_00a598ba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserInterfaceView__get_Model__
		              );
		    DAT_ram_00a598ba = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_UserInterface_View_ShowHideUIElementByRestrictions___ctor
		            (*(undefined4 *)(iVar2 + 0x1c),uVar3,*(undefined4 *)(param1[2] + 0x14),
		             *(undefined4 *)(param1[2] + 0x10),0);
		  piVar6 = *(int **)(param1[2] + 0x18);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x14);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Discounts_Model_IDiscountHandler_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81084af2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Gameplay_Discounts_Model_IDiscountHandler_TypeInfo,0);
		code_r0x81084af2:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar6,uVar3,puVar4[1]);
		  Gameplay_UserInterface_Control_UserInterfaceViewMediator__HandleWorldMovementChangedEvent
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001782 RID: 6018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001782")]
		[Address(RVA = "0x693E", Offset = "0x693E", VA = "0x693E")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_UserInterface_Control_UserInterfaceViewMediator__SetupView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,param2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001783")]
		[Address(RVA = "0x693F", Offset = "0x693F", VA = "0x693F")]
		private void SetActive(bool active)
		{
		/* --- GHIDRA: SetActive ---
		void Gameplay_UserInterface_Control_UserInterfaceViewMediator__SetActive
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined8 param2_00;
		  int iVar4;
		  int *param1_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a598c0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserInterfaceView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17328);
		    DAT_ram_00a598c0 = '\x01';
		  }
		  iVar4 = *(int *)(*(int *)(param1 + 8) + 8);
		  if (*(int *)(iVar4 + 0x68) == 0) {
		    local_8 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(iVar4,0);
		    uVar3 = func_ii_1081(DAT_ram_00a66968,&local_8);
		    uVar3 = func_ii_4419(StringLiteral_17328,uVar3,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		  }
		  else {
		    uVar1 = 0;
		    param1_00 = *(int **)(*(int *)(param1 + 8) + 0x20);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		          goto code_r0x81085f52;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81085f52:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))
		                      (param1_00,CONCAT44(in_register_20000014,puVar2[1]));
		    param2_00 = Gameplay_World_Model_ClanData__set_ClanCultDic
		                          (*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 8) + 0x68),0);
		    Core_Gameplay_Managers_WorldManager__GoToUserIsleById(uVar3,param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001784")]
		[Address(RVA = "0x6940", Offset = "0x6940", VA = "0x6940")]
		private void UserInterfaceWorldButtonsViewOnZigguratButtonClickedEvent()
		{
		/* --- GHIDRA: UserInterfaceWorldButtonsViewOnZigguratButtonClickedEvent ---
		void Gameplay_UserInterface_Control_UserInterfaceViewMediator__UserInterfaceWorldButtonsViewOnZigguratButtonClickedEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a598c1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserInterfaceView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a598c1 = '\x01';
		  }
		  param1_01 = *(int **)(*(int *)(param1 + 8) + 0x20);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x110);
		        goto code_r0x81086076;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81086076:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_WorldManager__TryRequestMonsterForCurrentUserIsle(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001785")]
		[Address(RVA = "0x6941", Offset = "0x6941", VA = "0x6941")]
		private void UserInterfaceWorldButtonsViewOnHomeButtonClickedEvent()
		{
		/* --- GHIDRA: UserInterfaceWorldButtonsViewOnHomeButtonClickedEvent ---
		void Gameplay_UserInterface_Control_UserInterfaceViewMediator__UserInterfaceWorldButtonsViewOnHomeButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a598c2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserInterfaceView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a598c2 = '\x01';
		  }
		  param1_01 = *(int **)(*(int *)(param1 + 8) + 0x20);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x8108612e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x8108612e:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_Inventory_InventoryManager__ShowChestWindow(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001786")]
		[Address(RVA = "0x6942", Offset = "0x6942", VA = "0x6942")]
		private void ChestButtonOnClickEvent(IndexButtonBasic btn)
		{
		/* --- GHIDRA: ChestButtonOnClickEvent ---
		void Gameplay_UserInterface_Control_UserInterfaceViewMediator__ChestButtonOnClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a598c3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserInterfaceView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a598c3 = '\x01';
		  }
		  param1_01 = *(int **)(*(int *)(param1 + 8) + 0x20);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1b8);
		        goto code_r0x810861e6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1f);
		code_r0x810861e6:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_SmallGamesManager__ShowSmallGamesWindow(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001787")]
		[Address(RVA = "0x6943", Offset = "0x6943", VA = "0x6943")]
		private void BonusesButtonOnClickEvent(IndexButtonBasic btn)
		{
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001788")]
		[Address(RVA = "0x6944", Offset = "0x6944", VA = "0x6944")]
		private void UserInfoChangedEventHandler()
		{
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001789")]
		[Address(RVA = "0x6945", Offset = "0x6945", VA = "0x6945")]
		private void UserLevelChangedEventHandler()
		{
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600178A")]
		[Address(RVA = "0x6946", Offset = "0x6946", VA = "0x6946")]
		private void LocationChangedEventHandler()
		{
		/* --- GHIDRA: LocationChangedEventHandler ---
		void Gameplay_UserInterface_Control_UserInterfaceViewMediator__LocationChangedEventHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_UserInterface_Control_UserInterfaceViewMediator__ShowMenuWindow(param1,param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600178B RID: 6027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600178B")]
		[Address(RVA = "0x6947", Offset = "0x6947", VA = "0x6947")]
		private void HandleNotifyUserGotNewLevelEvent(UserData user)
		{
		/* --- GHIDRA: HandleNotifyUserGotNewLevelEvent ---
		void Gameplay_UserInterface_Control_UserInterfaceViewMediator__HandleNotifyUserGotNewLevelEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar1 != 0) {
		    Gameplay_UserInterface_Control_UserInterfaceViewMediator__HandleWorldMovementChangedEvent
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600178C")]
		[Address(RVA = "0x6948", Offset = "0x6948", VA = "0x6948")]
		private void HandleWorldMovementChangedEvent()
		{
		/* --- GHIDRA: HandleWorldMovementChangedEvent ---
		void Gameplay_UserInterface_Control_UserInterfaceViewMediator__HandleWorldMovementChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  uint *puVar2;
		  longlong lVar3;
		  int *param1_00;
		  int iVar4;
		  int param1_01;
		  undefined4 param1_02;
		  longlong lVar5;
		  uint uVar6;
		  
		  uVar6 = 0;
		  if (DAT_ram_00a598c4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserInterfaceView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a598c4 = '\x01';
		  }
		  param1_00 = *(int **)(param1[2] + 0x20);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x81084bac;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81084bac:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  param1_01 = *(int *)(iVar4 + 0x14);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_02 = *(undefined4 *)(iVar4 + 0x18);
		  bVar1 = false;
		  iVar4 = Gameplay_World_Model_WorldModel___ctor(param1_01,0);
		  if (iVar4 == 0) {
		    uVar6 = (uint)(*(char *)(param1_01 + 0x40) == '\0');
		  }
		  else {
		    uVar6 = 0;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Input_TableViewText__CheckOverflow
		            (param1_02,uVar6,0);
		  iVar4 = *(int *)(*(int *)(param1[2] + 8) + 0x68);
		  if (((iVar4 != 0) && (bVar1 = false, *(int *)(param1_01 + 0x28) != 0)) &&
		     (*(int *)(param1_01 + 0x1c) == 2)) {
		    lVar5 = *(longlong *)(*(int *)(param1_01 + 0x28) + 0x18);
		    lVar3 = Gameplay_World_Model_ClanData__set_ClanCultDic(iVar4,0);
		    bVar1 = lVar5 != lVar3;
		  }
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(char *)(param1_01 + 0x40) == '\0') {
		    if (*(int *)(*(int *)(param1[2] + 8) + 0x68) == 0) {
		      uVar6 = 0;
		    }
		    else {
		      uVar6 = (uint)(byte)(bVar1 | *(int *)(param1_01 + 0x1c) == 4);
		    }
		  }
		  else {
		    uVar6 = 0;
		  }
		  Gameplay_Isles_User_View_IsleAnimationButtonsView__OnDestroy
		            (*(undefined4 *)(iVar4 + 0x18),uVar6,0);
		  return;
		}
		*/

		}

		// Token: 0x0600178D RID: 6029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600178D")]
		[Address(RVA = "0x6949", Offset = "0x6949", VA = "0x6949")]
		private void ValidateMovementButtons()
		{
		/* --- GHIDRA: ValidateMovementButtons ---
		void Gameplay_UserInterface_Control_UserInterfaceViewMediator__ValidateMovementButtons
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a598c5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserInterfaceView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_MenuWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12653);
		    DAT_ram_00a598c5 = '\x01';
		  }
		  iVar2 = Core_Data_UserData__set_Money(*(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		  piVar4 = *(int **)(*(int *)(param1 + 8) + 0x20);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x81085a68;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81085a68:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe8);
		        goto code_r0x81085aea;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,5);
		code_r0x81085aea:
		  param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 8) + 8);
		  iVar5 = System_Uri___ctor(0);
		  uVar7 = *(undefined4 *)(*(int *)(iVar5 + 0x54) + 0xc);
		  iVar5 = unnamed_function_1417(Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs_TypeInfo)
		  ;
		  UI_Windows_BaseWindowArgs__Dispose(iVar5,0);
		  *(undefined4 *)(iVar5 + 0x24) = 0;
		  uVar8 = 2;
		  if (iVar2 == 0) {
		    uVar8 = 1;
		  }
		  *(undefined4 *)(iVar5 + 0x20) = uVar8;
		  *(undefined4 *)(iVar5 + 0x1c) = uVar7;
		  *(undefined4 *)(iVar5 + 0x18) = uVar6;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_00,StringLiteral_12653,iVar5,
		             Method_UI_Windows_PopupController_Show_MenuWindow___);
		  return;
		}
		*/

		}

		// Token: 0x0600178E RID: 6030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600178E")]
		[Address(RVA = "0x694A", Offset = "0x694A", VA = "0x694A")]
		private void ShowMenuWindow()
		{
		/* --- GHIDRA: ShowMenuWindow ---
		void Gameplay_UserInterface_Control_UserInterfaceViewMediator__ShowMenuWindow
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  undefined4 param1_01;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a598c6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserInterfaceView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_UserGotNewLevelWindow___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow_UserGotNewLevelWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_12681);
		    DAT_ram_00a598c6 = '\x01';
		  }
		  piVar3 = *(int **)(param1[2] + 0x20);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x810862cb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x810862cb:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x8108634d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x8108634d:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_01 = unnamed_function_1417
		                        (
		                        Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow_UserGotNewLevelWindowArgs_TypeInfo
		                        );
		  Gameplay_Bank_View_BankWindow_BankWindowArgs___ctor(param1_01,param2_00,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_00,StringLiteral_12681,param1_01,
		             Method_UI_Windows_PopupController_Show_UserGotNewLevelWindow___);
		  return;
		}
		*/

		}

		// Token: 0x0600178F RID: 6031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600178F")]
		[Address(RVA = "0x694B", Offset = "0x694B", VA = "0x694B")]
		private void ShowUserGotNewLevelWindow(UserData user)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_UserInterface_Control_UserInterfaceViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a598b8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserInterfaceView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IList_Scenes___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_HandleApplicationScenesChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_HandleNotifyUserGotNewLevelEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_HandleUserTriggerChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_HandleWorldMovementChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_LocationChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_SetActive__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_UserInfoChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_UserLevelChangedEventHandler__
		              );
		    DAT_ram_00a598b8 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_LocationChangedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_UserInfoChangedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_UserLevelChangedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x24) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_bool__TypeInfo);
		    System_Action_AsyncGPUReadbackRequest___Invoke
		              (uVar3,param1,
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_SetActive__,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_bool__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_bool__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar5;
		      uVar3 = System_Action_bool__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_bool__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x28);
		    uVar3 = unnamed_function_1417(System_Action_UserData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_HandleUserTriggerChangedEvent__
		               ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_UserData__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x28) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_UserData__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x28) = iVar5;
		      uVar3 = System_Action_UserData__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_UserData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_HandleWorldMovementChangedEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x2c);
		    uVar3 = unnamed_function_1417(System_Action_UserData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_HandleNotifyUserGotNewLevelEvent__
		               ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_UserData__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x2c) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_UserData__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x2c) = iVar5;
		      uVar3 = System_Action_UserData__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_UserData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x34);
		    uVar3 = unnamed_function_1417(System_Action_IList_Scenes___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_HandleApplicationScenesChangedEvent__
		               ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_IList_Scenes___TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x34) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_IList_Scenes___TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x34) = iVar5;
		      uVar3 = System_Action_IList_Scenes___TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_IList_Scenes___TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_LocationChangedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_UserInfoChangedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_UserLevelChangedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x24) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_bool__TypeInfo);
		    System_Action_AsyncGPUReadbackRequest___Invoke
		              (uVar3,param1,
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_SetActive__,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_bool__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_bool__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar5;
		      uVar3 = System_Action_bool__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_bool__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x28);
		    uVar3 = unnamed_function_1417(System_Action_UserData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_HandleUserTriggerChangedEvent__
		               ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_UserData__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x28) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_UserData__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x28) = iVar5;
		      uVar3 = System_Action_UserData__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_UserData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_HandleWorldMovementChangedEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x2c);
		    uVar3 = unnamed_function_1417(System_Action_UserData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_HandleNotifyUserGotNewLevelEvent__
		               ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_UserData__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x2c) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_UserData__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x2c) = iVar5;
		      uVar3 = System_Action_UserData__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_UserData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x34);
		    uVar3 = unnamed_function_1417(System_Action_IList_Scenes___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_UserInterface_Control_UserInterfaceViewMediator_HandleApplicationScenesChangedEvent__
		               ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_IList_Scenes___TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x34) = 0;
		      return;
		    }
		    iVar5 = func_ii_1082(iVar2,System_Action_IList_Scenes___TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x34) = iVar5;
		    uVar3 = System_Action_IList_Scenes___TypeInfo;
		    iVar1 = func_ii_1082(iVar2,System_Action_IList_Scenes___TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_UserInterface_Control_UserInterfaceViewMediator__set_Events
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a598b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserInterfaceView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a598b9 = '\x01';
		  }
		  piVar3 = *(int **)(*(int *)(param1 + 8) + 0x20);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x810856ce;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x810856ce:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd8);
		        goto code_r0x8108574e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,3);
		code_r0x8108574e:
		  uVar1 = 0;
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar4 + 0x3c),0);
		  piVar3 = *(int **)(*(int *)(param1 + 8) + 0x20);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x810857df;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x810857df:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd8);
		        goto code_r0x81085863;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,3);
		code_r0x81085863:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param2_00 = Gameplay_ResourceBar_View_ResourceBarView__SetColor
		                        (*(undefined4 *)(iVar4 + 0x3c),param2,1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2_00,0);
		  return;
		}
		*/

}
