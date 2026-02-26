using System;
using Gameplay.AccountLinker.Model;
using Gameplay.AccountLinker.ProgressSaver.Model;
using Gameplay.AccountLinker.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Auth2;
using Protocol.Common;
using UnityEngine.EventSystems;

namespace Gameplay.AccountLinker.Control
{
	// Token: 0x02000E21 RID: 3617
	[Token(Token = "0x2000E21")]
	public class AccountLinkerViewMediator : AbstractViewMediator<AccountLinkerModel, AccountLinkerEvents, AccountLinkerController, AccountLinkerView>
	{
		// Token: 0x06005834 RID: 22580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005834")]
		[Address(RVA = "0xA5A3", Offset = "0xA5A3", VA = "0xA5A3", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a63b96 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountLinkerModel__AccountLinkerEvents__AccountLinkerController__AccountLinkerView___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel_TypeInfo);
		    DAT_ram_00a63b96 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_AccountLinkerModel__AccountLinkerEvents__AccountLinkerController__AccountLinkerView___ctor__
		            );
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(int **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  if (piVar3 == (int *)0x0) {
		    iVar5 = 0;
		  }
		  else {
		    uVar1 = 0;
		    iVar5 = *piVar3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		          goto code_r0x8235b7b5;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8235b7b5:
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    if (iVar5 == 0) {
		      iVar5 = 0;
		    }
		    else {
		      iVar5 = func_ii_7112(iVar5,0);
		    }
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(int **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  if (piVar3 != (int *)0x0) {
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		          goto code_r0x8235b875;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8235b875:
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    if (piVar3 != (int *)0x0) {
		      uVar1 = 0;
		      iVar4 = *piVar3;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        do {
		          if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x160);
		            goto code_r0x8235b8f6;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0x14);
		code_r0x8235b8f6:
		      iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		      if (((iVar4 != 0) && (iVar5 != 0)) && (iVar4 = *(int *)(iVar4 + 0x14), iVar4 != 0)) {
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        param2_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        param1_00 = unnamed_function_1417
		                              (
		                              Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel_TypeInfo
		                              );
		        Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__Dispose
		                  (param1_00,param2_00,iVar4,iVar5,0);
		        *(undefined4 *)(param1 + 0x18) = param1_00;
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005835 RID: 22581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005835")]
		[Address(RVA = "0xA5A4", Offset = "0xA5A4", VA = "0xA5A4")]
		public AccountLinkerViewMediator(AccountLinkerModel model, AccountLinkerEvents events, AccountLinkerController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a63b97 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountLinkerModel__AccountLinkerEvents__AccountLinkerController__AccountLinkerView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleCodeReadyEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleSetEmailErrorEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleSetUserSuccessEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleSigninTargetProviderFailedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleSigninTargetProviderSuccessEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleStartResolveAdditionalUsersEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleTokenGetErrorEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_LinkageProcessSuccessEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_OTPTokenGenCmd_Types_Result__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63b97 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleCodeReadyEvent__
		               ,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_string__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_string__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x14) = iVar4;
		      uVar2 = System_Action_string__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_string__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x34);
		    uVar2 = unnamed_function_1417(System_Action_OTPTokenGenCmd_Types_Result__TypeInfo);
		    System_Action_int___Invoke
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleTokenGetErrorEvent__
		               ,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_OTPTokenGenCmd_Types_Result__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x34) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_OTPTokenGenCmd_Types_Result__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x34) = iVar4;
		      uVar2 = System_Action_OTPTokenGenCmd_Types_Result__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_OTPTokenGenCmd_Types_Result__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x24);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleSigninTargetProviderSuccessEvent__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x24) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x24) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x28);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleSigninTargetProviderFailedEvent__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x28) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x28) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_int__TypeInfo);
		    System_Action_short___Invoke
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleSetEmailErrorEvent__
		               ,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_int__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_int__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar4;
		      uVar2 = System_Action_int__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_int__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x2c);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_LinkageProcessSuccessEvent__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x2c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x2c) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleStartResolveAdditionalUsersEvent__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x1c) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x30);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleSetUserSuccessEvent__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x30) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x30) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleCodeReadyEvent__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_string__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_string__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x14) = iVar4;
		      uVar2 = System_Action_string__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_string__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x34);
		    uVar2 = unnamed_function_1417(System_Action_OTPTokenGenCmd_Types_Result__TypeInfo);
		    System_Action_int___Invoke
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleTokenGetErrorEvent__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_OTPTokenGenCmd_Types_Result__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x34) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_OTPTokenGenCmd_Types_Result__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x34) = iVar4;
		      uVar2 = System_Action_OTPTokenGenCmd_Types_Result__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_OTPTokenGenCmd_Types_Result__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x24);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleSigninTargetProviderSuccessEvent__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x24) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x24) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x28);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleSigninTargetProviderFailedEvent__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x28) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x28) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_int__TypeInfo);
		    System_Action_short___Invoke
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleSetEmailErrorEvent__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_int__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_int__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar4;
		      uVar2 = System_Action_int__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_int__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x2c);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_LinkageProcessSuccessEvent__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x2c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x2c) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleStartResolveAdditionalUsersEvent__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x1c) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x30);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleSetUserSuccessEvent__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x30) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar5) || (*(int **)(iVar3 + 0x30) = piVar5, *piVar5 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x170011F6 RID: 4598
		// (set) Token: 0x06005836 RID: 22582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011F6")]
		public override AccountLinkerEvents Events
		{
			[Token(Token = "0x6005836")]
			[Address(RVA = "0xA5A5", Offset = "0xA5A5", VA = "0xA5A5", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170011F7 RID: 4599
		// (set) Token: 0x06005837 RID: 22583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011F7")]
		public override AccountLinkerView View
		{
			[Token(Token = "0x6005837")]
			[Address(RVA = "0xA5A6", Offset = "0xA5A6", VA = "0xA5A6", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06005838 RID: 22584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005838")]
		[Address(RVA = "0xA5A7", Offset = "0xA5A7", VA = "0xA5A7")]
		private void HandleSetupView()
		{
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005839")]
		[Address(RVA = "0xA5A8", Offset = "0xA5A8", VA = "0xA5A8")]
		private void UpdateSigninState()
		{
		/* --- GHIDRA: UpdateSigninState ---
		undefined4
		Gameplay_AccountLinker_Control_AccountLinkerViewMediator__UpdateSigninState
		          (int param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 param1_00;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63b9b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountLinkerModel__AccountLinkerEvents__AccountLinkerController__AccountLinkerView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_RefAccountInfo__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_RefAccountInfo__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_RefAccountInfo__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_RefAccountInfo__GetEnumerator__);
		    DAT_ram_00a63b9b = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if ((*(int *)(*(int *)(param1 + 8) + 8) != 0) &&
		     (iVar2 = *(int *)(param2 + 0xc), 0 < *(int *)(param2 + 0xc))) {
		    do {
		      iVar6 = *(int *)(param2 + (iVar2 + -1) * 4 + 0x10);
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_20,*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 8) + 0x50),
		                 Method_System_Collections_Generic_List_RefAccountInfo__GetEnumerator__);
		      local_8 = local_18;
		      local_10 = CONCAT44(puStack_1c,local_20);
		      local_20 = 0;
		      puStack_1c = &local_10;
		      while( true ) {
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                           Method_System_Collections_Generic_List_Enumerator_RefAccountInfo__MoveNext__
		                          );
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) break;
		        if (iVar3 == 0) goto code_r0x82364914;
		        if (*(int *)(local_8._4_4_ + 0xc) == iVar6) {
		          DAT_ram_009d3e38 = 0;
		          return local_8._4_4_;
		        }
		      }
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar6 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar6 != iVar4) {
		code_r0x823648d6:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s___Scripting__UnityEngine__Render_ram_00004866 + 0x28,&local_20);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		          import::env::__resumeException(param1_00);
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
		      piVar5 = (int *)import::env::__cxa_begin_catch(param1_00);
		      iVar4 = *piVar5;
		      DAT_ram_009d3e38 = 0;
		      local_20 = iVar4;
		      import::env::invoke_v(0x123);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_2();
		        goto code_r0x823648d6;
		      }
		      if (iVar4 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x82364914:
		      DAT_ram_009d3e38 = 0;
		      bVar1 = 1 < iVar2;
		      iVar2 = iVar2 + -1;
		    } while (bVar1);
		  }
		  return 0;
		}
		*/

		}

		// Token: 0x0600583A RID: 22586 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600583A")]
		[Address(RVA = "0xA5A9", Offset = "0xA5A9", VA = "0xA5A9")]
		public RefAccountInfo GetAnyUserLinkedProvider(params Provider[] providers)
		{
		/* --- GHIDRA: GetAnyUserLinkedProvider ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__GetAnyUserLinkedProvider
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  uint uVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(*(int *)(iVar1 + 0x28) + 0x20),1,0);
		  if (param1[6] != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(*(int *)(iVar1 + 0x28) + 0x2c),0);
		    param1_01 = Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__GetCurrentSigninState
		                          (param1[6],0);
		    iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                      (param1_01,0);
		    if (iVar1 == 0) {
		      uVar2 = Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__set_Email(param1[6],0);
		      uVar2 = uVar2 ^ 1;
		    }
		    else {
		      uVar2 = 0;
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,uVar2,0);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600583B RID: 22587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600583B")]
		[Address(RVA = "0xA5AA", Offset = "0xA5AA", VA = "0xA5AA")]
		private void UpdateTabs()
		{
		/* --- GHIDRA: UpdateTabs ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__UpdateTabs
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63b9c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnCloseCodeDisplayWindow__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_AccountLinker_View_CodeDisplayViewWindow_CodeDisplayWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_CodeDisplayViewWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12548);
		    DAT_ram_00a63b9c = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_AccountLinker_View_CodeDisplayViewWindow_CodeDisplayWindowArgs_TypeInfo
		                        );
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x18) = param2;
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12548,param1_00,
		                     Method_UI_Windows_PopupController_Show_CodeDisplayViewWindow___);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  param1_01 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_01,param1,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnCloseCodeDisplayWindow__
		             ,0);
		  UI_Windows_BaseWindow__get_IsActiveResourceBar(uVar1,param1_01,0);
		  return;
		}
		*/

		}

		// Token: 0x0600583C RID: 22588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600583C")]
		[Address(RVA = "0xA5AB", Offset = "0xA5AB", VA = "0xA5AB")]
		private void ShowCodeWindow(string code)
		{
		/* --- GHIDRA: ShowCodeWindow ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__ShowCodeWindow
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63b9d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnCloseCodeDisplayWindow__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63b9d = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x1c);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnCloseCodeDisplayWindow__
		             ,0);
		  UI_Windows_BaseWindow__add_onClose(param1_01,param1_00,0);
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600583D RID: 22589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600583D")]
		[Address(RVA = "0xA5AC", Offset = "0xA5AC", VA = "0xA5AC")]
		private void HandleOnCloseCodeDisplayWindow()
		{
		/* --- GHIDRA: HandleOnCloseCodeDisplayWindow ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__HandleOnCloseCodeDisplayWindow
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63b9e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnCloseCodeDisplayWindow__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63b9e = '\x01';
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  if (iVar1 != 0) {
		    param1_01 = *(undefined4 *)(param1 + 0x1c);
		    param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (param1_00,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnCloseCodeDisplayWindow__
		               ,0);
		    UI_Windows_BaseWindow__add_onClose(param1_01,param1_00,0);
		    System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew
		              (*(undefined4 *)(param1 + 0x1c),0,0);
		  }
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600583E RID: 22590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600583E")]
		[Address(RVA = "0xA5AD", Offset = "0xA5AD", VA = "0xA5AD")]
		private void CloseCodeWindow()
		{
		/* --- GHIDRA: CloseCodeWindow ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__CloseCodeWindow
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a63b9f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnCloseSelectUserWindow__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_SelectUserWindow___);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_AccountLinker_View_SelectUserWindow_SelectUserWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12552);
		    DAT_ram_00a63b9f = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  iVar2 = unnamed_function_1417
		                    (Gameplay_AccountLinker_View_SelectUserWindow_SelectUserWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar2,0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  *(undefined4 *)(iVar2 + 0x18) = uVar3;
		  iVar2 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12552,iVar2,
		                     Method_UI_Windows_PopupController_Show_SelectUserWindow___);
		  param1[8] = iVar2;
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnCloseSelectUserWindow__
		             ,0);
		  UI_Windows_BaseWindow__get_IsActiveResourceBar(iVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600583F RID: 22591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600583F")]
		[Address(RVA = "0xA5AE", Offset = "0xA5AE", VA = "0xA5AE")]
		private void ShowSelectUserWindow()
		{
		/* --- GHIDRA: ShowSelectUserWindow ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__ShowSelectUserWindow
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63ba0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnCloseSelectUserWindow__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63ba0 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x20);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnCloseSelectUserWindow__
		             ,0);
		  UI_Windows_BaseWindow__add_onClose(param1_01,param1_00,0);
		  *(undefined4 *)(param1 + 0x20) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06005840 RID: 22592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005840")]
		[Address(RVA = "0xA5AF", Offset = "0xA5AF", VA = "0xA5AF")]
		private void HandleOnCloseSelectUserWindow()
		{
		}

		// Token: 0x06005841 RID: 22593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005841")]
		[Address(RVA = "0xA5B0", Offset = "0xA5B0", VA = "0xA5B0")]
		private void CloseSelectUserWindow()
		{
		/* --- GHIDRA: CloseSelectUserWindow ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__CloseSelectUserWindow
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x20),0);
		  if (iVar1 != 0) {
		    System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew
		              (*(undefined4 *)(param1 + 0x20),2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005842 RID: 22594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005842")]
		[Address(RVA = "0xA5B1", Offset = "0xA5B1", VA = "0xA5B1")]
		private void HandleSetUserSuccessEvent()
		{
		/* --- GHIDRA: HandleSetUserSuccessEvent ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__HandleSetUserSuccessEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param3;
		  
		  if (DAT_ram_00a63ba1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountLinkerModel__AccountLinkerEvents__AccountLinkerController__AccountLinkerView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LinkerUser__get_Count__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2498);
		    DAT_ram_00a63ba1 = '\x01';
		  }
		  if (0 < *(int *)(*(int *)(*(int *)(param1 + 8) + 0x18) + 0xc)) {
		    Gameplay_AccountLinker_Control_AccountLinkerViewMediator__CloseCodeWindow(param1,param1);
		    return;
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param3 = func_ii_7508(StringLiteral_2498,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar1,1,param3,0);
		  return;
		}
		*/

		}

		// Token: 0x06005843 RID: 22595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005843")]
		[Address(RVA = "0xA5B2", Offset = "0xA5B2", VA = "0xA5B2")]
		private void HandleStartResolveAdditionalUsersEvent()
		{
		/* --- GHIDRA: HandleStartResolveAdditionalUsersEvent ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__HandleStartResolveAdditionalUsersEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63ba2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedSetEmailErrors___
		              );
		    DAT_ram_00a63ba2 = '\x01';
		  }
		  UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		            (param2,0,
		             Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedSetEmailErrors___
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(*(int *)(iVar1 + 0x28) + 0x20),1,0);
		  return;
		}
		*/

		}

		// Token: 0x06005844 RID: 22596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005844")]
		[Address(RVA = "0xA5B3", Offset = "0xA5B3", VA = "0xA5B3")]
		private void HandleSetEmailErrorEvent(int errorCode)
		{
		/* --- GHIDRA: HandleSetEmailErrorEvent ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__HandleSetEmailErrorEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63b9a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountLinkerModel__AccountLinkerEvents__AccountLinkerController__AccountLinkerView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_SignInVariants_States__set_CurrentState__);
		    DAT_ram_00a63b9a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x28),0,
		             Method_UI_MonoBehaviourWithStates_SignInVariants_States__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x06005845 RID: 22597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005845")]
		[Address(RVA = "0xA5B4", Offset = "0xA5B4", VA = "0xA5B4")]
		private void LinkageProcessSuccessEvent()
		{
		/* --- GHIDRA: LinkageProcessSuccessEvent ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__LinkageProcessSuccessEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param3;
		  int iVar2;
		  
		  if (DAT_ram_00a63ba3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2505);
		    DAT_ram_00a63ba3 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param3 = func_ii_7508(StringLiteral_2505,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar1,1,param3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(*(int *)(iVar2 + 0x28) + 0x20),0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x28) + 0x2c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06005846 RID: 22598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005846")]
		[Address(RVA = "0xA5B5", Offset = "0xA5B5", VA = "0xA5B5")]
		private void HandleSigninTargetProviderSuccessEvent()
		{
		/* --- GHIDRA: HandleSigninTargetProviderSuccessEvent ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__HandleSigninTargetProviderSuccessEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63ba4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Close_AccountLinkerWindow___);
		    DAT_ram_00a63ba4 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  DG_Tweening_Plugins_Core_PluginsManager__GetDefaultPlugin___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		            (uVar1,0,Method_UI_Windows_PopupController_Close_AccountLinkerWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06005847 RID: 22599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005847")]
		[Address(RVA = "0xA5B6", Offset = "0xA5B6", VA = "0xA5B6")]
		private void HandleSigninTargetProviderFailedEvent()
		{
		/* --- GHIDRA: HandleSigninTargetProviderFailedEvent ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__HandleSigninTargetProviderFailedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a63ba5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2502);
		    DAT_ram_00a63ba5 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param3_00 = func_ii_7508(StringLiteral_2502,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar1,2,param3_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06005848 RID: 22600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005848")]
		[Address(RVA = "0xA5B7", Offset = "0xA5B7", VA = "0xA5B7")]
		private void HandleTokenGetErrorEvent(OTPTokenGenCmd.Types.Result obj)
		{
		/* --- GHIDRA: HandleTokenGetErrorEvent ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__HandleTokenGetErrorEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_AccountLinker_Control_AccountLinkerViewMediator__UpdateTabs(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06005849 RID: 22601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005849")]
		[Address(RVA = "0xA5B8", Offset = "0xA5B8", VA = "0xA5B8")]
		private void HandleCodeReadyEvent(string code)
		{
		/* --- GHIDRA: HandleCodeReadyEvent ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__HandleCodeReadyEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))(param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_AccountLinker_Control_AccountLinkerController__RequestSetResolvedUserId(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600584A RID: 22602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600584A")]
		[Address(RVA = "0xA5B9", Offset = "0xA5B9", VA = "0xA5B9")]
		private void HandleOnClickHowGetCodeText(PointerEventData obj)
		{
		/* --- GHIDRA: HandleOnClickHowGetCodeText ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__HandleOnClickHowGetCodeText
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63ba6 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a63ba6 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(*(int *)(iVar1 + 0x20) + 0x160);
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param1_01,0)
		  ;
		  if (iVar1 == 0) {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x14c));
		    Gameplay_AccountLinker_Control_AccountLinkerController__RequestCodeGet
		              (param1_00,param1_01,param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    TMPro_TMP_InputField__get_text(*(undefined4 *)(iVar1 + 0x20),StringLiteral_5,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600584B RID: 22603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600584B")]
		[Address(RVA = "0xA5BA", Offset = "0xA5BA", VA = "0xA5BA")]
		private void HandleOnClickSetCodeBtnBtn()
		{
		/* --- GHIDRA: HandleOnClickSetCodeBtnBtn ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__HandleOnClickSetCodeBtnBtn
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_AccountLinker_Control_AccountLinkerController__HandleLoggedUserUserInfoUpdated
		            (param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600584C RID: 22604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600584C")]
		[Address(RVA = "0xA5BB", Offset = "0xA5BB", VA = "0xA5BB")]
		private void HandleOnClickCodeGetButton()
		{
		/* --- GHIDRA: HandleOnClickCodeGetButton ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__HandleOnClickCodeGetButton
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_AccountLinker_Control_AccountLinkerController__OpenPageHowGetCodeFromWebSite
		            (param1_00,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600584D RID: 22605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600584D")]
		[Address(RVA = "0xA5BC", Offset = "0xA5BC", VA = "0xA5BC")]
		private void HandleOnOAuthEvent(Provider provider)
		{
		/* --- GHIDRA: HandleOnOAuthEvent ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__HandleOnOAuthEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_AccountLinker_Control_AccountLinkerController__RequestSetCode(param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600584E RID: 22606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600584E")]
		[Address(RVA = "0xA5BD", Offset = "0xA5BD", VA = "0xA5BD")]
		private void HandleOnClickGPGSButton()
		{
		/* --- GHIDRA: HandleOnClickGPGSButton ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__HandleOnClickGPGSButton
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63ba7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    DAT_ram_00a63ba7 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x28) + 0x24) + 0x160);
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  iVar1 = System_Text_RegularExpressions_Regex__IsMatch
		                    (*(undefined4 *)(*(int *)(Utils_StringUtils_TypeInfo + 0x5c) + 4),param2_00,0);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                      (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x28) + 0x28) + 0x160),0);
		    if (iVar1 == 0) {
		      param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar1 = Gameplay_AccountLinker_Control_AccountLinkerController__InvokeOAuth
		                        (param1_00,param2_00,
		                         *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x28) + 0x28) + 0x160),param1);
		      if (iVar1 != 0) {
		        iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        System_Linq_Enumerable__First_object_(*(undefined4 *)(*(int *)(iVar1 + 0x28) + 0x20),0,0);
		        if (param1[6] != 0) {
		          Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__get_Email
		                    (param1[6],param2_00,0);
		        }
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600584F RID: 22607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600584F")]
		[Address(RVA = "0xA5BE", Offset = "0xA5BE", VA = "0xA5BE")]
		private void HandleOnClickSaveEmailPasswordButton()
		{
		/* --- GHIDRA: HandleOnClickSaveEmailPasswordButton ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__HandleOnClickSaveEmailPasswordButton
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63ba8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_AccountLinker_Control_AccountLinkerViewMediator___c_TypeInfo);
		    DAT_ram_00a63ba8 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_AccountLinker_Control_AccountLinkerViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_AccountLinker_Control_AccountLinkerViewMediator___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002FC5 RID: 12229
		[Token(Token = "0x4002FC5")]
		[FieldOffset(Offset = "0x18")]
		private readonly ProgressSaverModel _progressSaverModel;

		// Token: 0x04002FC6 RID: 12230
		[Token(Token = "0x4002FC6")]
		[FieldOffset(Offset = "0x1C")]
		private CodeDisplayViewWindow _codeDisplayWindow;

		// Token: 0x04002FC7 RID: 12231
		[Token(Token = "0x4002FC7")]
		[FieldOffset(Offset = "0x20")]
		private SelectUserWindow _selectUserWindow;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 *puVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a63b98 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountLinkerModel__AccountLinkerEvents__AccountLinkerController__AccountLinkerView__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnClickCodeGetButton__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnClickGPGSButton__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnClickHowGetCodeText__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnClickSaveEmailPasswordButton__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnClickSetCodeBtnBtn__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnOAuthEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_Provider__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2496);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2495);
		    DAT_ram_00a63b98 = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar2,0);
		  if (iVar3 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = *(undefined4 *)(iVar3 + 0x24);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar3 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		    if (iVar3 != 0) {
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar6 = *(undefined4 *)(iVar3 + 0x24);
		      uVar2 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar2,param1,
		                 Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnClickHowGetCodeText__
		                 ,0);
		      Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(uVar6,uVar2,0);
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(iVar3 + 0x1c) + 0xb4);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnClickSetCodeBtnBtn__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar6,uVar2,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(iVar3 + 0x2c) + 0xb4);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnClickCodeGetButton__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar6,uVar2,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x28);
		    uVar2 = unnamed_function_1417(System_Action_Provider__TypeInfo);
		    System_Action_int___Invoke
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnOAuthEvent__,
		               0);
		    Gameplay_AccountLinker_View_SignInVariants__add_OnOAuthEvent(uVar6,uVar2,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x28) + 0x1c) + 0xb4);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnClickGPGSButton__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar6,uVar2,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x28) + 0x20) + 0xb4);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnClickSaveEmailPasswordButton__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar6,uVar2,0);
		  }
		  param1[5] = param2;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar2,0);
		  if (iVar3 != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar7 = (int *)**(int **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    if (piVar7 == (int *)0x0) {
		      iVar3 = 0;
		    }
		    else {
		      uVar1 = 0;
		      iVar3 = *piVar7;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x140);
		            goto code_r0x82363f1c;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x82363f1c:
		      iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		      if (iVar3 == 0) {
		        iVar3 = 0;
		      }
		      else {
		        iVar3 = func_ii_7112(iVar3,0);
		      }
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar7 = (int *)**(int **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    if (piVar7 != (int *)0x0) {
		      iVar8 = *piVar7;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe0);
		            goto code_r0x82363fdc;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x82363fdc:
		      piVar7 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		      if (piVar7 == (int *)0x0) {
		        uVar1 = 0;
		      }
		      else {
		        uVar1 = 0;
		        iVar8 = *piVar7;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x160
		                               );
		              goto code_r0x82364062;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar7,Core_Application_IApp_TypeInfo,0x14);
		code_r0x82364062:
		        uVar1 = 0;
		        iVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		        if (((iVar8 != 0) && (iVar3 != 0)) && (iVar8 = *(int *)(iVar8 + 0x14), iVar8 != 0)) {
		          if (DAT_ram_00a6456f == '\0') {
		            Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		            DAT_ram_00a6456f = '\x01';
		          }
		          uVar6 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		          uVar2 = unnamed_function_1417
		                            (Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel_TypeInfo)
		          ;
		          Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__Dispose
		                    (uVar2,uVar6,iVar8,iVar3,0);
		          uVar1 = Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__set_Email(uVar2,0);
		        }
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    puVar5 = &StringLiteral_2496;
		    if (uVar1 == 0) {
		      puVar5 = &StringLiteral_2495;
		    }
		    uVar2 = *puVar5;
		    piVar7 = *(int **)(iVar3 + 0x30);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(uVar2,1,0,1,0,0,0,0);
		    iVar3 = *piVar7;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		              (piVar7,uVar2,*(undefined4 *)(iVar3 + 0x2d4));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar3 + 0x2c),uVar1,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = *(undefined4 *)(iVar3 + 0x24);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar3 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		    if (iVar3 != 0) {
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar6 = *(undefined4 *)(iVar3 + 0x24);
		      uVar2 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar2,param1,
		                 Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnClickHowGetCodeText__
		                 ,0);
		      Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(uVar6,uVar2,0);
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(iVar3 + 0x1c) + 0xb4);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnClickSetCodeBtnBtn__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar2,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(iVar3 + 0x2c) + 0xb4);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnClickCodeGetButton__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar2,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x28);
		    uVar2 = unnamed_function_1417(System_Action_Provider__TypeInfo);
		    System_Action_int___Invoke
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnOAuthEvent__,
		               0);
		    Gameplay_AccountLinker_View_SignInVariants__get_EmailOauthSignin(uVar6,uVar2,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x28) + 0x1c) + 0xb4);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnClickGPGSButton__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar2,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x28) + 0x20) + 0xb4);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator_HandleOnClickSaveEmailPasswordButton__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar2,0);
		    Gameplay_AccountLinker_Control_AccountLinkerViewMediator__set_View(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_AccountLinker_Control_AccountLinkerViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  int param1_00;
		  int iVar8;
		  int iVar9;
		  
		  if (DAT_ram_00a63b99 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Button___);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_OAuthProviderInvoker__Provider___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_Provider___);
		    Mono_Security_ASN1__get_Item(&System_Func_OAuthProviderInvoker__Provider__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_SignInVariants_States__set_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator___c__HandleSetupView_b__7_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_AccountLinker_Control_AccountLinkerViewMediator___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12188);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12787);
		    DAT_ram_00a63b99 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x28),3,
		             Method_UI_MonoBehaviourWithStates_SignInVariants_States__set_CurrentState__);
		  if (param1[6] == 0) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(StringLiteral_12787,0);
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = *(undefined4 *)(*(int *)(iVar1 + 0x28) + 0x24);
		    uVar5 = Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__GetCurrentSigninState
		                      (param1[6],0);
		    TMPro_TMP_InputField__get_text(uVar4,uVar5,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = *(undefined4 *)(*(int *)(iVar1 + 0x28) + 0x24);
		    uVar5 = Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__GetCurrentSigninState
		                      (param1[6],0);
		    uVar5 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar5,0);
		    System_Linq_Enumerable__First_object_(uVar4,uVar5,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = *(undefined4 *)(*(int *)(iVar1 + 0x28) + 0x28);
		    uVar5 = Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__GetCurrentSigninState
		                      (param1[6],0);
		    uVar5 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar5,0);
		    System_Linq_Enumerable__First_object_(uVar4,uVar5,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x28) + 0x20),0);
		    uVar2 = Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__set_Email(param1[6],0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar5,uVar2 ^ 1,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x28) + 0x2c),0);
		    uVar4 = Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__GetCurrentSigninState
		                      (param1[6],0);
		    iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar4,0);
		    if (iVar1 == 0) {
		      uVar2 = Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__set_Email(param1[6],0);
		      uVar2 = uVar2 ^ 1;
		    }
		    else {
		      uVar2 = 0;
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar5,uVar2,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar6 = *(int **)(*(int *)(iVar1 + 0x28) + 0x2c);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar5 = func_ii_7508(StringLiteral_12188,1,0,1,0,0,0,0);
		    iVar1 = *piVar6;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		              (piVar6,uVar5,*(undefined4 *)(iVar1 + 0x2d4));
		    uVar5 = Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__GetCurrentSigninState
		                      (param1[6],0);
		    iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar5,0);
		    if (iVar1 == 0) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      TMPro_TMP_InputField__get_text
		                (*(undefined4 *)(*(int *)(iVar1 + 0x28) + 0x28),StringLiteral_1217,0);
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar1 + 0x28) + 0x34);
		  if (*(int *)(Gameplay_AccountLinker_Control_AccountLinkerViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_AccountLinker_Control_AccountLinkerViewMediator___c_TypeInfo);
		  }
		  piVar6 = *(int **)(Gameplay_AccountLinker_Control_AccountLinkerViewMediator___c_TypeInfo + 0x5c);
		  iVar7 = piVar6[1];
		  iVar1 = Gameplay_AccountLinker_Control_AccountLinkerViewMediator___c_TypeInfo;
		  if (iVar7 == 0) {
		    if (*(int *)(Gameplay_AccountLinker_Control_AccountLinkerViewMediator___c_TypeInfo + 0x74) == 0)
		    {
		      func_ii_306000(Gameplay_AccountLinker_Control_AccountLinkerViewMediator___c_TypeInfo);
		      piVar6 = *(int **)(Gameplay_AccountLinker_Control_AccountLinkerViewMediator___c_TypeInfo +
		                        0x5c);
		    }
		    iVar1 = *piVar6;
		    iVar7 = unnamed_function_1417(System_Func_OAuthProviderInvoker__Provider__TypeInfo);
		    System_Action_object____ctor
		              (iVar7,iVar1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerViewMediator___c__HandleSetupView_b__7_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_AccountLinker_Control_AccountLinkerViewMediator___c_TypeInfo + 0x5c)
		            + 4) = iVar7;
		  }
		  uVar5 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar5,iVar7,
		                     Method_System_Linq_Enumerable_Select_OAuthProviderInvoker__Provider___);
		  uVar5 = System_Linq_Enumerable__Select_object__Int32Enum_
		                    (uVar5,Method_System_Linq_Enumerable_ToArray_Provider___);
		  iVar7 = Gameplay_AccountLinker_Control_AccountLinkerViewMediator__UpdateSigninState
		                    (param1,uVar5,iVar1);
		  if (iVar7 != 0) {
		    iVar1 = *param1;
		    iVar3 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(iVar1 + 0x15c));
		    iVar3 = *(int *)(*(int *)(iVar3 + 0x28) + 0x34);
		    if (0 < *(int *)(iVar3 + 0xc)) {
		      iVar1 = 0;
		      do {
		        param1_00 = *(int *)(iVar3 + iVar1 * 4 + 0x10);
		        iVar8 = *(int *)(param1_00 + 0x10);
		        iVar9 = *(int *)(iVar7 + 0xc);
		        uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (param1_00,0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar5,(uint)(iVar8 == iVar9),0);
		        uVar5 = func_ii_5677(param1_00,Method_UnityEngine_Component_GetComponent_Button___);
		        System_Linq_Enumerable__First_object_(uVar5,(uint)(iVar8 != iVar9),0);
		        iVar1 = iVar1 + 1;
		      } while (iVar1 < *(int *)(iVar3 + 0xc));
		    }
		  }
		  Gameplay_AccountLinker_Control_AccountLinkerViewMediator__GetAnyUserLinkedProvider(param1,iVar1);
		  return;
		}
		*/

}
