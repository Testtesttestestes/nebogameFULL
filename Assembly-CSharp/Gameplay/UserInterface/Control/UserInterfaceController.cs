using System;
using System.Collections.Generic;
using CloudsFly.Movement;
using Gameplay.UserInterface.Events;
using Gameplay.UserInterface.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Utils;
using Utils.Accumulators;

namespace Gameplay.UserInterface.Control
{
	// Token: 0x020003EC RID: 1004
	[Token(Token = "0x20003EC")]
	public class UserInterfaceController : AbstractController<UserInterfaceModel, UserInterfaceEvents>
	{
		// Token: 0x06001767 RID: 5991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001767")]
		[Address(RVA = "0x6923", Offset = "0x6923", VA = "0x6923")]
		public UserInterfaceController(UserInterfaceModel model, UserInterfaceEvents events)
		{
		/* --- GHIDRA: <HandleRun>b__2_0 ---
		void Gameplay_UserInterface_Control_UserInterfaceController___HandleRun_b__2_0
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a598b6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserInterfaceView___ctor__
		              );
		    DAT_ram_00a598b6 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserInterfaceView___ctor__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInterface_Control_UserInterfaceController___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a598b0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__remove_UpdateEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_PopupController_StateChanged_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceController_CurrentIsleChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleScenesLoadedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleScenesUnloadEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleUserTriggersEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleWorldEngineMoveCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleWorldEngineMoveStartEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInterface_Control_UserInterfaceController_OnChangeWindows__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceController_UserOnOnUserInfoChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceController_UserOnUserLevelChangedEvent__
		              );
		    DAT_ram_00a598b0 = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = *(int **)(iVar2 + 0x20);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x110);
		        goto code_r0x81082d46;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81082d46:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  iVar7 = *(int *)(iVar2 + 0xc);
		  uVar8 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar4 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		  func_ii_6877(uVar4,param1,
		               Method_Gameplay_UserInterface_Control_UserInterfaceController_CurrentIsleChangedEvent__
		               ,0);
		  iVar2 = func_ii_7048(uVar8,uVar4,0);
		  uVar4 = System_Action_ulong__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		  }
		  else {
		    iVar5 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x1c) = iVar5;
		    uVar4 = System_Action_ulong__TypeInfo;
		    iVar7 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar6 = *(int **)(iVar2 + 0x20);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x110);
		        goto code_r0x81082e5d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81082e5d:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  iVar7 = *(int *)(iVar2 + 8);
		  uVar8 = *(undefined4 *)(iVar7 + 8);
		  uVar4 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar4,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleWorldEngineMoveStartEvent__
		             ,0);
		  iVar2 = func_ii_7048(uVar8,uVar4,0);
		  uVar4 = System_Action_WorldMovementTypes__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar7 + 8) = 0;
		  }
		  else {
		    iVar5 = func_ii_1082(iVar2,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 8) = iVar5;
		    uVar4 = System_Action_WorldMovementTypes__TypeInfo;
		    iVar7 = func_ii_1082(iVar2,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar6 = *(int **)(iVar2 + 0x20);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x110);
		        goto code_r0x81082f68;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81082f68:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  iVar7 = *(int *)(iVar2 + 8);
		  uVar8 = *(undefined4 *)(iVar7 + 0xc);
		  uVar4 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar4,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleWorldEngineMoveCompleteEvent__
		             ,0);
		  iVar2 = func_ii_7048(uVar8,uVar4,0);
		  uVar4 = System_Action_WorldMovementTypes__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar7 + 0xc) = 0;
		  }
		  else {
		    iVar5 = func_ii_1082(iVar2,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0xc) = iVar5;
		    uVar4 = System_Action_WorldMovementTypes__TypeInfo;
		    iVar7 = func_ii_1082(iVar2,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar8 = *(undefined4 *)(iVar2 + 8);
		  uVar1 = 0;
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceController_UserOnOnUserInfoChangedEvent__
		             ,0);
		  Core_Data_UserData__add_OnUserInfoChangedEvent(uVar8,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar8 = *(undefined4 *)(iVar2 + 8);
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceController_UserOnUserLevelChangedEvent__
		             ,0);
		  Core_Data_UserData__add_OnUserLevelChangedEvent(uVar8,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar4 = Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(iVar2 + 8),0);
		  uVar8 = unnamed_function_1417
		                    (
		                    Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		                    );
		  Utils_Accumulators_AccumulatorBase___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___remove_UpdateEvent
		            (uVar8,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleUserTriggersEvent__
		             ,0);
		  UnityEngine_Events_InvokableCall_InputAction_CallbackContext___add_Delegate
		            (uVar4,uVar8,
		             Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__remove_UpdateEvent__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = *(int **)(iVar2 + 0x20);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		        goto code_r0x81083145;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81083145:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar1 = 0;
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe8);
		        goto code_r0x810831c5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,5);
		code_r0x810831c5:
		  uVar1 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar8 = unnamed_function_1417(UI_Windows_PopupController_StateChanged_TypeInfo);
		  UI_Windows_PopupController___ctor
		            (uVar8,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceController_OnChangeWindows__,0);
		  UI_Windows_PopupController__add_OnChangeStateEvent(uVar4,uVar8,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar8 = *(undefined4 *)(iVar2 + 0x24);
		  uVar4 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleScenesLoadedEvent__
		             ,0);
		  DefaultNamespace_SceneAppManager__add_SceneLoadedEvent(uVar8,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar8 = *(undefined4 *)(iVar2 + 0x24);
		  uVar4 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleScenesUnloadEvent__
		             ,0);
		  DefaultNamespace_SceneAppManager__add_SceneUnloadedEvent(uVar8,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = *(int **)(iVar2 + 0x20);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x208);
		        goto code_r0x8108330d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x29);
		code_r0x8108330d:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  local_4 = *(undefined4 *)(iVar2 + 0x1c);
		  Core_Gameplay_Managers_PopupScheduleManager__OpenFirstAvailableWindow(uVar4,&local_4,0);
		  return;
		}
		*/

		}

		// Token: 0x06001768 RID: 5992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001768")]
		[Address(RVA = "0x6924", Offset = "0x6924", VA = "0x6924", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_UserInterface_Control_UserInterfaceController__HandleStop
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a598b1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__add_UpdateEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_PopupScheduleManager_Args_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_bool____TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_PopupScheduleManager_ScheduleOpenWindow_UserGotNewLevelWindow___
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_PopupController_StateChanged_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceController_CurrentIsleChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleScenesLoadedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleScenesUnloadEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleUserTriggersEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleWorldEngineMoveCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleWorldEngineMoveStartEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInterface_Control_UserInterfaceController_NotifyUserGoNewLevel__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInterface_Control_UserInterfaceController_OnChangeWindows__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInterface_Control_UserInterfaceController__HandleRun_b__2_0__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceController_UserOnOnUserInfoChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceController_UserOnUserLevelChangedEvent__
		              );
		    DAT_ram_00a598b1 = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = *(int **)(iVar2 + 0x20);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x110);
		        goto code_r0x810834ff;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x810834ff:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  iVar7 = *(int *)(iVar2 + 0xc);
		  uVar8 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar4 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		  func_ii_6877(uVar4,param1,
		               Method_Gameplay_UserInterface_Control_UserInterfaceController_CurrentIsleChangedEvent__
		               ,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar8,uVar4,0);
		  uVar4 = System_Action_ulong__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		  }
		  else {
		    iVar5 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x1c) = iVar5;
		    uVar4 = System_Action_ulong__TypeInfo;
		    iVar7 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar6 = *(int **)(iVar2 + 0x20);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x110);
		        goto code_r0x81083616;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81083616:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  iVar7 = *(int *)(iVar2 + 8);
		  uVar8 = *(undefined4 *)(iVar7 + 8);
		  uVar4 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar4,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleWorldEngineMoveStartEvent__
		             ,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar8,uVar4,0);
		  uVar4 = System_Action_WorldMovementTypes__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar7 + 8) = 0;
		  }
		  else {
		    iVar5 = func_ii_1082(iVar2,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 8) = iVar5;
		    uVar4 = System_Action_WorldMovementTypes__TypeInfo;
		    iVar7 = func_ii_1082(iVar2,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar6 = *(int **)(iVar2 + 0x20);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x110);
		        goto code_r0x81083721;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81083721:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  iVar7 = *(int *)(iVar2 + 8);
		  uVar8 = *(undefined4 *)(iVar7 + 0xc);
		  uVar4 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar4,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleWorldEngineMoveCompleteEvent__
		             ,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar8,uVar4,0);
		  uVar4 = System_Action_WorldMovementTypes__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar7 + 0xc) = 0;
		  }
		  else {
		    iVar5 = func_ii_1082(iVar2,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0xc) = iVar5;
		    uVar4 = System_Action_WorldMovementTypes__TypeInfo;
		    iVar7 = func_ii_1082(iVar2,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar8 = *(undefined4 *)(iVar2 + 8);
		  uVar1 = 0;
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceController_UserOnOnUserInfoChangedEvent__
		             ,0);
		  Core_Data_RewardData__Create(uVar8,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar8 = *(undefined4 *)(iVar2 + 8);
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceController_UserOnUserLevelChangedEvent__
		             ,0);
		  Core_Data_UserData__remove_UserSkillsChangedEvent(uVar8,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar4 = Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(iVar2 + 8),0);
		  uVar8 = unnamed_function_1417
		                    (
		                    Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		                    );
		  Utils_Accumulators_AccumulatorBase___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___remove_UpdateEvent
		            (uVar8,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleUserTriggersEvent__
		             ,0);
		  UnityEngine_Events_InvokableCall_InputAction_CallbackContext___Invoke
		            (uVar4,uVar8,
		             Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__add_UpdateEvent__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = *(int **)(iVar2 + 0x20);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		        goto code_r0x810838fe;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x810838fe:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar1 = 0;
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe8);
		        goto code_r0x8108397e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,5);
		code_r0x8108397e:
		  uVar1 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar8 = unnamed_function_1417(UI_Windows_PopupController_StateChanged_TypeInfo);
		  UI_Windows_PopupController___ctor
		            (uVar8,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceController_OnChangeWindows__,0);
		  UI_Windows_Layer___ctor(uVar4,uVar8,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar8 = *(undefined4 *)(iVar2 + 0x24);
		  uVar4 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleScenesLoadedEvent__
		             ,0);
		  Test_TestCameraController___ctor(uVar8,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar8 = *(undefined4 *)(iVar2 + 0x24);
		  uVar4 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleScenesUnloadEvent__
		             ,0);
		  DefaultNamespace_SceneAppManager__remove_SceneLoadedEvent(uVar8,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar7 = unnamed_function_1417(Core_Gameplay_Managers_PopupScheduleManager_Args_TypeInfo);
		  UnityEngine_Purchasing_Default_WinProductDescription__set_title(iVar7,7,0);
		  *(undefined8 *)(iVar7 + 8) = 0x7fffffff;
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceController_NotifyUserGoNewLevel__,0)
		  ;
		  *(undefined4 *)(iVar7 + 0x10) = uVar4;
		  *(int *)(iVar2 + 0x1c) = iVar7;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = *(int **)(iVar2 + 0x20);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x208);
		        goto code_r0x81083b28;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x29);
		code_r0x81083b28:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  local_4 = *(undefined4 *)(iVar2 + 0x1c);
		  iVar2 = Mono_Security_ASN1Convert__ToOid(System_Func_bool____TypeInfo,1);
		  uVar8 = unnamed_function_1417(System_Func_bool__TypeInfo);
		  System_Func_BackgroundSize___Invoke
		            (uVar8,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceController__HandleRun_b__2_0__,0);
		  *(undefined4 *)(iVar2 + 0x10) = uVar8;
		  UI_Windows_PopupController__HasOpenWindow_object_
		            (uVar4,&local_4,iVar2,
		             Method_Core_Gameplay_Managers_PopupScheduleManager_ScheduleOpenWindow_UserGotNewLevelWindow___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001769 RID: 5993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001769")]
		[Address(RVA = "0x6925", Offset = "0x6925", VA = "0x6925", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600176A")]
		[Address(RVA = "0x6926", Offset = "0x6926", VA = "0x6926")]
		private void HandleScenesLoadedEvent(string sceneName)
		{
		/* --- GHIDRA: HandleScenesLoadedEvent ---
		void Gameplay_UserInterface_Control_UserInterfaceController__HandleScenesLoadedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x34);
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(*(int *)(iVar2 + 0x24) + 0x10),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600176B RID: 5995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600176B")]
		[Address(RVA = "0x6927", Offset = "0x6927", VA = "0x6927")]
		private void HandleScenesUnloadEvent(string sceneName)
		{
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600176C")]
		[Address(RVA = "0x6928", Offset = "0x6928", VA = "0x6928")]
		private void HandleWorldEngineMoveCompleteEvent(WorldMovementTypes movementType)
		{
		/* --- GHIDRA: HandleWorldEngineMoveCompleteEvent ---
		void Gameplay_UserInterface_Control_UserInterfaceController__HandleWorldEngineMoveCompleteEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600176D RID: 5997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600176D")]
		[Address(RVA = "0x6929", Offset = "0x6929", VA = "0x6929")]
		private void HandleWorldEngineMoveStartEvent(WorldMovementTypes movementType)
		{
		/* --- GHIDRA: HandleWorldEngineMoveStartEvent ---
		void Gameplay_UserInterface_Control_UserInterfaceController__HandleWorldEngineMoveStartEvent
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x28);
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar2 + 8),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600176E RID: 5998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600176E")]
		[Address(RVA = "0x692A", Offset = "0x692A", VA = "0x692A")]
		private void HandleUserTriggersEvent(IEnumerable<TriggerValue> changes, AccumulatorBase<int, TriggerValue> accumulator)
		{
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600176F")]
		[Address(RVA = "0x692B", Offset = "0x692B", VA = "0x692B")]
		private void UserOnOnUserInfoChangedEvent()
		{
		/* --- GHIDRA: UserOnOnUserInfoChangedEvent ---
		void Gameplay_UserInterface_Control_UserInterfaceController__UserOnOnUserInfoChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a598b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a598b2 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x24);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  param1_01 = *(int **)(iVar2 + 0x20);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x208);
		        goto code_r0x81083d93;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x29);
		code_r0x81083d93:
		  param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  Core_Gameplay_Managers_PopupScheduleManager__UnScheduleOpenWindow(param1_00,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001770 RID: 6000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001770")]
		[Address(RVA = "0x692C", Offset = "0x692C", VA = "0x692C")]
		private void UserOnUserLevelChangedEvent()
		{
		/* --- GHIDRA: UserOnUserLevelChangedEvent ---
		void Gameplay_UserInterface_Control_UserInterfaceController__UserOnUserLevelChangedEvent
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001771 RID: 6001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001771")]
		[Address(RVA = "0x692D", Offset = "0x692D", VA = "0x692D")]
		private void CurrentIsleChangedEvent(ulong prevOwnerId)
		{
		/* --- GHIDRA: CurrentIsleChangedEvent ---
		void Gameplay_UserInterface_Control_UserInterfaceController__CurrentIsleChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x20);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param2 == 0,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001772")]
		[Address(RVA = "0x692E", Offset = "0x692E", VA = "0x692E")]
		private void OnChangeWindows(int visibleFullscreenWndCount)
		{
		/* --- GHIDRA: OnChangeWindows ---
		void Gameplay_UserInterface_Control_UserInterfaceController__OnChangeWindows
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x2c);
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar2 + 8),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001773 RID: 6003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001773")]
		[Address(RVA = "0x692F", Offset = "0x692F", VA = "0x692F")]
		private void NotifyUserGoNewLevel()
		{
		/* --- GHIDRA: NotifyUserGoNewLevel ---
		void Gameplay_UserInterface_Control_UserInterfaceController__NotifyUserGoNewLevel
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a598b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleGetUserLevelReward__
		              );
		    DAT_ram_00a598b3 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  uVar1 = ServicesNamespace_MainService__GetEventMilestonesRewardsInfo(uVar1,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_UserInterface_Control_UserInterfaceController_HandleGetUserLevelReward__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001774 RID: 6004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001774")]
		[Address(RVA = "0x6930", Offset = "0x6930", VA = "0x6930")]
		public void GetUserLevelReward()
		{
		/* --- GHIDRA: GetUserLevelReward ---
		void Gameplay_UserInterface_Control_UserInterfaceController__GetUserLevelReward
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint uVar2;
		  uint *param3_00;
		  int *param1_00;
		  int iVar3;
		  int *param1_01;
		  
		  if (DAT_ram_00a598b4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedGetUserLevelRewardErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetUserLevelRewardAns_TypeInfo);
		    DAT_ram_00a598b4 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoGetUserLevelRewardAns_TypeInfo != *param1_00)
		     ) {
		    System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoGetUserLevelRewardAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedGetUserLevelRewardErrors___
		                    );
		  iVar3 = *param1;
		  if (uVar2 == 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x100) * 4))
		                      (param1,*(undefined4 *)(iVar3 + 0x104));
		    param1_01 = *(int **)(iVar3 + 0x20);
		    iVar3 = *param1_01;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          param3_00 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x140)
		          ;
		          goto code_r0x81083f88;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    param3_00 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x81083f88:
		    iVar3 = (**(code **)((ulonglong)*param3_00 * 4))(param1_01,param3_00[1]);
		    Gameplay_User_Controller_UserController__UpdateUserInfo
		              (*(undefined4 *)(iVar3 + 0x18),param1_00[4],param3_00);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x30);
		  }
		  else {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x110) * 4))
		                      (param1,*(undefined4 *)(iVar3 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x30);
		  }
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),uVar2 ^ 1,*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001775 RID: 6005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001775")]
		[Address(RVA = "0x6931", Offset = "0x6931", VA = "0x6931")]
		private void HandleGetUserLevelReward(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetUserLevelReward ---
		uint Gameplay_UserInterface_Control_UserInterfaceController__HandleGetUserLevelReward
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint uVar5;
		  uint uVar6;
		  int *piVar7;
		  undefined4 param1_00;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined8 local_10;
		  longlong local_8;
		  
		  if (DAT_ram_00a598b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_Names_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_Scopes_TypeInfo);
		    DAT_ram_00a598b5 = '\x01';
		  }
		  local_8 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar7 = *(int **)(iVar1 + 0x10);
		  iVar1 = *piVar7;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar6 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar6 * 8 + 4) * 8 + iVar1 + 0xd0);
		        goto code_r0x81084191;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar6);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x81084191:
		  uVar6 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar4 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(iVar1 + 8),0);
		  iVar1 = Core_Extensions_Dict_DictExt__GetCaveLevel(uVar3,uVar4,0);
		  uVar5 = Core_Extensions_Dict_ResourceSetExt__GetDelta(*(undefined4 *)(iVar1 + 0x40),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar7 = *(int **)(iVar1 + 0x20);
		  iVar1 = *piVar7;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar6 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar6 * 8 + 4) * 8 + iVar1 + 0x140);
		        goto code_r0x8108425c;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar6);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8108425c:
		  iVar1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x14) + 0x3c);
		  local_10 = 0xffffffff;
		  local_14 = Utils_LocalProps_Scopes_TypeInfo;
		  uVar3 = Spine_SkeletonJson__GetFloat(&local_14,0);
		  local_1c = 0xffffffff;
		  local_20 = Utils_LocalProps_Names_TypeInfo;
		  uVar4 = Spine_SkeletonJson__GetFloat(&local_20,0);
		  uVar6 = Utils_LocalProps__SetProp(param1_00,uVar3,uVar4,&local_8,0,0);
		  return uVar6 & local_8 != 0 & (uVar5 ^ 1);
		}
		*/

		}
	}
}
