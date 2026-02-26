using System;
using Gameplay.UserInterface.Control;
using Gameplay.UserInterface.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.UserInterface.View
{
	// Token: 0x020003C5 RID: 965
	[Token(Token = "0x20003C5")]
	public class UserInterfaceView : MonoBehaviour
	{
		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001696 RID: 5782 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003D1")]
		public ShowHideUIElementByRestrictions.UIElementsByRestrictions UIElementsByRestrictions
		{
			[Token(Token = "0x6001696")]
			[Address(RVA = "0x6857", Offset = "0x6857", VA = "0x6857")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001697 RID: 5783 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003D2")]
		public WorldIndexButtonsView WorldIndexButtonsView
		{
			[Token(Token = "0x6001697")]
			[Address(RVA = "0x6858", Offset = "0x6858", VA = "0x6858")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003D3")]
		public UserInterfaceButtonsView UserInterfaceButtonsView
		{
			[Token(Token = "0x6001698")]
			[Address(RVA = "0x6859", Offset = "0x6859", VA = "0x6859")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001699")]
		[Address(RVA = "0x685A", Offset = "0x685A", VA = "0x685A")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_UserInterface_View_UserInterfaceView__OnDestroy(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a58261 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58261 = '\x01';
		  }
		  Gameplay_UserInterface_View_UserInterfaceView__Awake(param1,param1,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x168);
		        goto code_r0x80ec1665;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x15);
		code_r0x80ec1665:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  Core_Gameplay_Managers_GameEventsManager__get_Controller(uVar3,param1,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x170);
		        goto code_r0x80ec1717;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x16);
		code_r0x80ec1717:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  Core_Gameplay_Managers_DailyQuestsManager__Deinit(uVar3,param1,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1b8);
		        goto code_r0x80ec17c9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x1f);
		code_r0x80ec17c9:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  Core_Gameplay_Managers_SmallGamesManager__get_Controller(uVar3,param1,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1f0);
		        goto code_r0x80ec187b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x26);
		code_r0x80ec187b:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  Core_Gameplay_Managers_SmallGamesManager__get_Controller(uVar3,param1,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1a8);
		        goto code_r0x80ec192d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x1d);
		code_r0x80ec192d:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  Core_Gameplay_Managers_ProgressSaverManager__ShowAccountLinkDialogWindow(uVar3,param1,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 400);
		        goto code_r0x80ec19df;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x80ec19df:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  Core_Gameplay_Managers_DailyQuestsManager__Deinit(uVar3,param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600169A")]
		[Address(RVA = "0x685B", Offset = "0x685B", VA = "0x685B")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_UserInterface_View_UserInterfaceView__Awake
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param3_00;
		  uint *puVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 param6;
		  undefined4 param7;
		  undefined4 uVar6;
		  undefined4 param1_00;
		  int *piVar7;
		  int iVar8;
		  undefined4 uVar9;
		  
		  if (DAT_ram_00a58262 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInterface_Control_UserInterfaceController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInterface_Events_UserInterfaceEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInterface_Model_UserInterfaceModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInterface_Control_UserInterfaceViewMediator_TypeInfo)
		    ;
		    DAT_ram_00a58262 = '\x01';
		  }
		  if (*(int *)(param1 + 0x24) == 0) {
		    param3_00 = unnamed_function_1417(Gameplay_UserInterface_Events_UserInterfaceEvents_TypeInfo);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar7;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe0);
		          goto code_r0x80ec1af2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80ec1af2:
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		    uVar1 = 0;
		    iVar8 = *piVar3;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x160);
		          goto code_r0x80ec1b74;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0x14);
		code_r0x80ec1b74:
		    iVar8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar9 = *(undefined4 *)(iVar8 + 0x14);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar3;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		          goto code_r0x80ec1c1f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ec1c1f:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar3;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x160);
		          goto code_r0x80ec1ccb;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x80ec1ccb:
		    uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar3;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x248);
		          goto code_r0x80ec1d77;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x31);
		code_r0x80ec1d77:
		    param6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    param7 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar3;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x140);
		          goto code_r0x80ec1e2b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80ec1e2b:
		    uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar6 = func_ii_7112(uVar6,0);
		    param1_00 = unnamed_function_1417(Gameplay_UserInterface_Model_UserInterfaceModel_TypeInfo);
		    Gameplay_UserInterface_Model_UserInterfaceModel__Dispose
		              (param1_00,piVar7,uVar9,uVar4,uVar5,param6,param7,uVar6,0);
		    *(undefined4 *)(param1 + 0x20) = param1_00;
		    uVar9 = unnamed_function_1417(Gameplay_UserInterface_Control_UserInterfaceController_TypeInfo);
		    Gameplay_UserInterface_Control_UserGotNewLevelWindowViewMediator__HandleGetReward_d__9__SetStateMachine
		              (uVar9,param1_00,param3_00,0);
		    *(undefined4 *)(param1 + 0x24) = uVar9;
		    uVar5 = *(undefined4 *)(param1 + 0x20);
		    uVar4 = unnamed_function_1417(Gameplay_UserInterface_Control_UserInterfaceViewMediator_TypeInfo)
		    ;
		    Gameplay_UserInterface_Control_UserInterfaceController___HandleRun_b__2_0
		              (uVar4,uVar5,param3_00,uVar9,0);
		    *(undefined4 *)(param1 + 0x28) = uVar4;
		    MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x24),0);
		    iVar8 = **(int **)(param1 + 0x28);
		    (**(code **)((ulonglong)*(uint *)(iVar8 + 0x160) * 4))
		              (*(int **)(param1 + 0x28),param2,*(undefined4 *)(iVar8 + 0x164));
		    uVar9 = *(undefined4 *)(param1 + 0x24);
		    uVar4 = *(undefined4 *)(param1 + 0x20);
		    iVar8 = *(int *)(param1 + 0x10);
		    if (DAT_ram_00a5825d == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator_TypeInfo);
		      DAT_ram_00a5825d = '\x01';
		    }
		    piVar7 = (int *)unnamed_function_1417
		                              (
		                              Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator_TypeInfo
		                              );
		    Gameplay_UserInterface_Events_UserInterfaceEvents___ctor(piVar7,uVar4,param3_00,uVar9,0);
		    *(int **)(iVar8 + 0x1c) = piVar7;
		    (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x160) * 4))
		              (piVar7,iVar8,*(undefined4 *)(*piVar7 + 0x164));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600169B RID: 5787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600169B")]
		[Address(RVA = "0x685C", Offset = "0x685C", VA = "0x685C")]
		private void InitMVC(UserInterfaceView view)
		{
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600169C")]
		[Address(RVA = "0x685D", Offset = "0x685D", VA = "0x685D")]
		public UserInterfaceView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInterface_View_UserInterfaceView___ctor(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  
		  param2_00 = *(int *)(param1 + 0x1c);
		  if (param2_00 != 0) {
		    *(undefined4 *)(param1 + 0x1c) = 0;
		    Gameplay_UserInterface_View_UserView__set_UserData(param1,param2_00,0,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000BEA RID: 3050
		[Token(Token = "0x4000BEA")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private LocationOwnerIndexView _locationOwnerIndexView;

		// Token: 0x04000BEB RID: 3051
		[Token(Token = "0x4000BEB")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private UserInterfaceButtonsView _userInterfaceButtonsView;

		// Token: 0x04000BEC RID: 3052
		[Token(Token = "0x4000BEC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WorldIndexButtonsView _worldIndexButtonsView;

		// Token: 0x04000BED RID: 3053
		[Token(Token = "0x4000BED")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ShowHideUIElementByRestrictions.UIElementsByRestrictions _uiElements;

		// Token: 0x04000BEE RID: 3054
		[Token(Token = "0x4000BEE")]
		[FieldOffset(Offset = "0x20")]
		private UserInterfaceModel _model;

		// Token: 0x04000BEF RID: 3055
		[Token(Token = "0x4000BEF")]
		[FieldOffset(Offset = "0x24")]
		private UserInterfaceController _controller;

		// Token: 0x04000BF0 RID: 3056
		[Token(Token = "0x4000BF0")]
		[FieldOffset(Offset = "0x28")]
		private UserInterfaceViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_UserInterfaceButtonsView ---
		void Gameplay_UserInterface_View_UserInterfaceView__get_UserInterfaceButtonsView
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a58260 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58260 = '\x01';
		  }
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x24),0);
		  iVar5 = **(int **)(param1 + 0x20);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe8) * 4))
		            (*(int **)(param1 + 0x20),*(undefined4 *)(iVar5 + 0xec));
		  iVar5 = **(int **)(param1 + 0x28);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x130) * 4))
		            (*(int **)(param1 + 0x28),*(undefined4 *)(iVar5 + 0x134));
		  *(undefined4 *)(param1 + 0x28) = 0;
		  *(undefined8 *)(param1 + 0x20) = 0;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x168);
		        goto code_r0x80ec120f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x15);
		code_r0x80ec120f:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  Core_Gameplay_Managers_GameEventsManager__get_Controller(uVar3,0,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x170);
		        goto code_r0x80ec12c1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x16);
		code_r0x80ec12c1:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  Core_Gameplay_Managers_DailyQuestsManager__Deinit(uVar3,0,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1b8);
		        goto code_r0x80ec1373;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x1f);
		code_r0x80ec1373:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  Core_Gameplay_Managers_SmallGamesManager__get_Controller(uVar3,0,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1f0);
		        goto code_r0x80ec1425;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x26);
		code_r0x80ec1425:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  Core_Gameplay_Managers_SmallGamesManager__get_Controller(uVar3,0,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1a8);
		        goto code_r0x80ec14d7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x1d);
		code_r0x80ec14d7:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  Core_Gameplay_Managers_ProgressSaverManager__ShowAccountLinkDialogWindow(uVar3,0,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 400);
		        goto code_r0x80ec1589;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x80ec1589:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  Core_Gameplay_Managers_DailyQuestsManager__Deinit(uVar3,0,0);
		  return;
		}
		*/

}
