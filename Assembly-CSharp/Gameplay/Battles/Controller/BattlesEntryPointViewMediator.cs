using System;
using Gameplay.Battles.Events;
using Gameplay.Battles.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using MVC;
using UI;

namespace Gameplay.Battles.Controller
{
	// Token: 0x02000C30 RID: 3120
	[Token(Token = "0x2000C30")]
	public class BattlesEntryPointViewMediator : AbstractViewMediator<BattlesModel, BattlesEvents, BattlesController, UserInterfaceView>
	{
		// Token: 0x06004C11 RID: 19473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C11")]
		[Address(RVA = "0x9A55", Offset = "0x9A55", VA = "0x9A55")]
		public BattlesEntryPointViewMediator(BattlesModel model, BattlesEvents events, BattlesController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Battles_Controller_BattlesEntryPointViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a60985 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__UserInterfaceView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Battles_Controller_BattlesEntryPointViewMediator_UserInterfaceButtonsViewOnCombatButtonClickedEvent__
		              );
		    DAT_ram_00a60985 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x10);
		    uVar1 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Battles_Controller_BattlesEntryPointViewMediator_UserInterfaceButtonsViewOnCombatButtonClickedEvent__
		               ,0);
		    UI_IndexButtonBasic__add_ClickEvent(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x10);
		    uVar1 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Battles_Controller_BattlesEntryPointViewMediator_UserInterfaceButtonsViewOnCombatButtonClickedEvent__
		               ,0);
		    UI_IndexButtonBasic__get_CanvasGroup(uVar3,uVar1,0);
		    if (DAT_ram_00a60987 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__UserInterfaceView__get_Model__
		                );
		      DAT_ram_00a60987 = '\x01';
		    }
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		    if (iVar2 != 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      System_Collections_Generic_Dictionary_int__object___get_Count
		                (*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x14) + 0x10) + 0x14),
		                 *(undefined4 *)(param1[2] + 0x1c),0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000F55 RID: 3925
		// (set) Token: 0x06004C12 RID: 19474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F55")]
		public override UserInterfaceView View
		{
			[Token(Token = "0x6004C12")]
			[Address(RVA = "0x9A56", Offset = "0x9A56", VA = "0x9A56", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000F56 RID: 3926
		// (set) Token: 0x06004C13 RID: 19475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F56")]
		public override BattlesEvents Events
		{
			[Token(Token = "0x6004C13")]
			[Address(RVA = "0x9A57", Offset = "0x9A57", VA = "0x9A57", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004C14 RID: 19476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C14")]
		[Address(RVA = "0x9A58", Offset = "0x9A58", VA = "0x9A58")]
		private void ResetView()
		{
		}

		// Token: 0x06004C15 RID: 19477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C15")]
		[Address(RVA = "0x9A59", Offset = "0x9A59", VA = "0x9A59")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Battles_Controller_BattlesEntryPointViewMediator__SetupView
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a60987 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__UserInterfaceView__get_Model__
		              );
		    DAT_ram_00a60987 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1_00,0);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Collections_Generic_Dictionary_int__object___get_Count
		              (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x14) + 0x10) + 0x14),
		               *(undefined4 *)(param1[2] + 0x1c),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C16 RID: 19478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C16")]
		[Address(RVA = "0x9A5A", Offset = "0x9A5A", VA = "0x9A5A")]
		private void EventsOnNotificationNumChangedEvent()
		{
		/* --- GHIDRA: EventsOnNotificationNumChangedEvent ---
		void Gameplay_Battles_Controller_BattlesEntryPointViewMediator__EventsOnNotificationNumChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *piVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a60988 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__UserInterfaceView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Battles_View_BattlesWindow_BattlesWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12574);
		    DAT_ram_00a60988 = '\x01';
		  }
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		  iVar5 = *(int *)(iVar3 + 0x1c);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		  *(undefined4 *)(iVar3 + 0x1c) = 0;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		  if (iVar5 != *(int *)(iVar3 + 0x1c)) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x110) * 4))
		                      (piVar2,*(undefined4 *)(*piVar2 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x14);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  uVar1 = 0;
		  piVar2 = *(int **)(param1[2] + 0xc);
		  iVar3 = *piVar2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x81d088be;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81d088be:
		  piVar2 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar2,puVar4[1]);
		  uVar1 = 0;
		  iVar3 = *piVar2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe8);
		        goto code_r0x81d08940;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar2,Core_Application_IApp_TypeInfo,5);
		code_r0x81d08940:
		  param1_00 = (**(code **)((ulonglong)*puVar4 * 4))(piVar2,puVar4[1]);
		  param1_01 = unnamed_function_1417(Gameplay_Battles_View_BattlesWindow_BattlesWindowArgs_TypeInfo);
		  UI_Windows_BaseWindowArgs__Dispose(param1_01,0);
		  UI_Windows_PopupController__set_TopWindow(param1_00,StringLiteral_12574,param1_01,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C17")]
		[Address(RVA = "0x9A5B", Offset = "0x9A5B", VA = "0x9A5B")]
		private void UserInterfaceButtonsViewOnCombatButtonClickedEvent(IndexButtonBasic indexButton)
		{
		/* --- GHIDRA: UserInterfaceButtonsViewOnCombatButtonClickedEvent ---
		void Gameplay_Battles_Controller_BattlesEntryPointViewMediator__UserInterfaceButtonsViewOnCombatButtonClickedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a60989 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__BattlesWindow___ctor__
		              );
		    DAT_ram_00a60989 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__BattlesWindow___ctor__
		            );
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Battles_Controller_BattlesEntryPointViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a60986 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__UserInterfaceView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Battles_Controller_BattlesEntryPointViewMediator_EventsOnNotificationNumChangedEvent__
		              );
		    DAT_ram_00a60986 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Battles_Controller_BattlesEntryPointViewMediator_EventsOnNotificationNumChangedEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
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
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Battles_Controller_BattlesEntryPointViewMediator_EventsOnNotificationNumChangedEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

}
