using System;
using Gameplay.GameEvents.Model;
using Gameplay.GameEvents.View;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using UI;

namespace Gameplay.GameEvents.Control
{
	// Token: 0x020007E7 RID: 2023
	[Token(Token = "0x20007E7")]
	public class GameEventsEnterPointViewMediator : AbstractViewMediator<GameEventsModel, GameEventsEvents, GameEventsController, UserInterfaceView>
	{
		// Token: 0x06002F64 RID: 12132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F64")]
		[Address(RVA = "0x7FCA", Offset = "0x7FCA", VA = "0x7FCA", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a57533 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__UserInterfaceView___ctor__
		              );
		    DAT_ram_00a57533 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__UserInterfaceView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F65")]
		[Address(RVA = "0x7FCB", Offset = "0x7FCB", VA = "0x7FCB")]
		public GameEventsEnterPointViewMediator(GameEventsModel model, GameEventsEvents events, GameEventsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a57534 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__UserInterfaceView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_EventCategoriesDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleCloseRequestEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleInitEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleNotViewedEventCountChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleOpenRequestEvent__
		              );
		    DAT_ram_00a57534 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleInitEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_int__TypeInfo);
		    System_Action_short___Invoke
		              (uVar3,param1,
		               Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleNotViewedEventCountChanged__
		               ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_int__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_int__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar5;
		      uVar3 = System_Action_int__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_int__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x30);
		    uVar3 = unnamed_function_1417(System_Action_EventCategoriesDic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleOpenRequestEvent__
		               ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_EventCategoriesDic__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x30) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_EventCategoriesDic__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x30) = iVar5;
		      uVar3 = System_Action_EventCategoriesDic__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_EventCategoriesDic__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x2c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleCloseRequestEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x2c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x2c) = piVar4, *piVar4 != iVar1)) {
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
		    uVar6 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleInitEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x30);
		    uVar3 = unnamed_function_1417(System_Action_EventCategoriesDic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleOpenRequestEvent__
		               ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_EventCategoriesDic__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x30) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_EventCategoriesDic__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x30) = iVar5;
		      uVar3 = System_Action_EventCategoriesDic__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_EventCategoriesDic__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x2c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleCloseRequestEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x2c) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x2c) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x17000938 RID: 2360
		// (set) Token: 0x06002F66 RID: 12134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000938")]
		public override GameEventsEvents Events
		{
			[Token(Token = "0x6002F66")]
			[Address(RVA = "0x7FCC", Offset = "0x7FCC", VA = "0x7FCC", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000939 RID: 2361
		// (set) Token: 0x06002F67 RID: 12135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000939")]
		public override UserInterfaceView View
		{
			[Token(Token = "0x6002F67")]
			[Address(RVA = "0x7FCD", Offset = "0x7FCD", VA = "0x7FCD", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F68")]
		[Address(RVA = "0x7FCE", Offset = "0x7FCE", VA = "0x7FCE")]
		private void HandleSetupView()
		{
		/* --- GHIDRA: HandleSetupView ---
		void Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator__HandleSetupView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57537 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__UserInterfaceView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleOnCloseEventEventsWindows__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_View_GameEventsListWindow_GameEventsListWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_GameEventsListWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12620);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8416);
		    DAT_ram_00a57537 = '\x01';
		  }
		  if (param1[6] == 0) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		    iVar2 = unnamed_function_1417
		                      (
		                      Gameplay_GameEvents_View_GameEventsListWindow_GameEventsListWindowArgs_TypeInfo
		                      );
		    UI_Windows_BaseWindowArgs__Dispose(iVar2,0);
		    *(int *)(iVar2 + 0x18) = param1[2];
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    *(undefined4 *)(iVar2 + 0x1c) = uVar3;
		    iVar2 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                      (uVar1,StringLiteral_12620,iVar2,
		                       Method_UI_Windows_PopupController_Show_GameEventsListWindow___);
		    param1[6] = iVar2;
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleOnCloseEventEventsWindows__
		               ,0);
		    UI_Windows_BaseWindow__get_IsActiveResourceBar(iVar2,uVar1,0);
		    return;
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  func_ii_7109(StringLiteral_8416,0);
		  return;
		}
		*/

		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F69")]
		[Address(RVA = "0x7FCF", Offset = "0x7FCF", VA = "0x7FCF")]
		private void ShowGameEvents(EventCategoriesDic category)
		{
		/* --- GHIDRA: ShowGameEvents ---
		void Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator__ShowGameEvents
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57538 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleOnCloseEventEventsWindows__
		              );
		    DAT_ram_00a57538 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleOnCloseEventEventsWindows__
		             ,0);
		  UI_Windows_BaseWindow__add_onClose(param1_01,param1_00,0);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6A")]
		[Address(RVA = "0x7FD0", Offset = "0x7FD0", VA = "0x7FD0")]
		private void HandleOnCloseEventEventsWindows()
		{
		/* --- GHIDRA: HandleOnCloseEventEventsWindows ---
		void Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator__HandleOnCloseEventEventsWindows
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57539 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleOnCloseEventEventsWindows__
		              );
		    DAT_ram_00a57539 = '\x01';
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x18),0);
		  if (iVar1 != 0) {
		    param1_00 = *(undefined4 *)(param1 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleOnCloseEventEventsWindows__
		               ,0);
		    UI_Windows_BaseWindow__add_onClose(param1_00,uVar2,0);
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		    UI_Windows_PopupController__Show(uVar2,*(undefined4 *)(param1 + 0x18),0,0);
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6B")]
		[Address(RVA = "0x7FD1", Offset = "0x7FD1", VA = "0x7FD1")]
		private void CloseGameEvents()
		{
		/* --- GHIDRA: CloseGameEvents ---
		void Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator__CloseGameEvents
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined8 local_3c;
		  undefined8 local_34;
		  undefined4 local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (DAT_ram_00a57529 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_GameEventsController__RequestOpenListView_d__39___
		              );
		    DAT_ram_00a57529 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_3c,0);
		  local_20 = local_34;
		  local_14 = 0;
		  local_2c = 0xffffffff;
		  local_28 = local_3c;
		  local_18 = uVar1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_FtpWebRequest__CreateConnectionAsync_d__86_
		            (&local_28,&local_2c,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_GameEventsController__RequestOpenListView_d__39___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6C")]
		[Address(RVA = "0x7FD2", Offset = "0x7FD2", VA = "0x7FD2")]
		private void HandleGameEventsButtonClickedEvent(IndexButtonBasic button)
		{
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6D")]
		[Address(RVA = "0x7FD3", Offset = "0x7FD3", VA = "0x7FD3")]
		private void HandleInitEvent()
		{
		/* --- GHIDRA: HandleInitEvent ---
		void Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator__HandleInitEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator__HandleSetupView
		            (param1,param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6E")]
		[Address(RVA = "0x7FD4", Offset = "0x7FD4", VA = "0x7FD4")]
		private void HandleOpenRequestEvent(EventCategoriesDic category)
		{
		/* --- GHIDRA: HandleOpenRequestEvent ---
		void Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator__HandleOpenRequestEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator__HandleOnCloseEventEventsWindows
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6F")]
		[Address(RVA = "0x7FD5", Offset = "0x7FD5", VA = "0x7FD5")]
		private void HandleCloseRequestEvent()
		{
		/* --- GHIDRA: HandleCloseRequestEvent ---
		void Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator__HandleCloseRequestEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1_00,0);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Collections_Generic_Dictionary_int__object___get_Count
		              (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x14) + 0x2c) + 0x14),param2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F70")]
		[Address(RVA = "0x7FD6", Offset = "0x7FD6", VA = "0x7FD6")]
		private void HandleNotViewedEventCountChanged(int count)
		{
		/* --- GHIDRA: HandleNotViewedEventCountChanged ---
		void Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator__HandleNotViewedEventCountChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5753a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventsListView__Dispose__
		              );
		    DAT_ram_00a5753a = '\x01';
		  }
		  Gameplay_GameEvents_Control_GameEventsListViewMediator__HandleOnCloseReadWindow(param1,param1);
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventsListView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x040019DB RID: 6619
		[Token(Token = "0x40019DB")]
		[FieldOffset(Offset = "0x18")]
		private GameEventsListWindow _eventsWindow;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57535 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__UserInterfaceView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleGameEventsButtonClickedEvent__
		              );
		    DAT_ram_00a57535 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x2c);
		    uVar1 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleGameEventsButtonClickedEvent__
		               ,0);
		    UI_IndexButtonBasic__add_ClickEvent(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator__set_View(param1,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x2c);
		    uVar1 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleGameEventsButtonClickedEvent__
		               ,0);
		    UI_IndexButtonBasic__get_CanvasGroup(uVar3,uVar1,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param1_00;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a57536 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__UserInterfaceView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleNotViewedEventCountChanged__
		              );
		    DAT_ram_00a57536 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar4 = *(undefined4 *)(iVar1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke
		            (uVar2,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_HandleNotViewedEventCountChanged__
		             ,0);
		  param1_00 = UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		  uVar2 = System_Action_int__TypeInfo;
		  if (param1_00 == 0) {
		    *(undefined4 *)(iVar1 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(param1_00,System_Action_int__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(param1_00,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x18) = iVar3;
		    uVar2 = System_Action_int__TypeInfo;
		    iVar1 = func_ii_1082(param1_00,System_Action_int__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(param1_00,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar2 = Gameplay_GameEvents_Model_GameEventsModel__set_DefaultCategory(param1[2],param1);
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar4,0);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Collections_Generic_Dictionary_int__object___get_Count
		              (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x14) + 0x2c) + 0x14),uVar2,0);
		  }
		  return;
		}
		*/

}
