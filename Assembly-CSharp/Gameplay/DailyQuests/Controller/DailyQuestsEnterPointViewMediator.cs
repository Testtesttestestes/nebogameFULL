using System;
using Gameplay.DailyQuests.Events;
using Gameplay.DailyQuests.Model;
using Gameplay.DailyQuests.View;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using MVC;
using UI;

namespace Gameplay.DailyQuests.Controller
{
	// Token: 0x0200088A RID: 2186
	[Token(Token = "0x200088A")]
	public class DailyQuestsEnterPointViewMediator : AbstractViewMediator<DailyQuestsModel, DailyQuestEvents, DailyQuestsController, UserInterfaceView>
	{
		// Token: 0x0600338F RID: 13199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600338F")]
		[Address(RVA = "0x83C9", Offset = "0x83C9", VA = "0x83C9")]
		public DailyQuestsEnterPointViewMediator(DailyQuestsModel model, DailyQuestEvents events, DailyQuestsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57c82 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__UserInterfaceView__Dispose__
		              );
		    DAT_ram_00a57c82 = '\x01';
		  }
		  Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator__ShowDailyQuests(param1,param1);
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__UserInterfaceView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003390 RID: 13200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003390")]
		[Address(RVA = "0x83CA", Offset = "0x83CA", VA = "0x83CA", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator__Dispose
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57c83 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__UserInterfaceView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator_HandleActiveQuestsCountChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator_HandleQuestsChangedEvent__
		              );
		    DAT_ram_00a57c83 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator_HandleActiveQuestsCountChanged__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator_HandleQuestsChangedEvent__
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator_HandleActiveQuestsCountChanged__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator_HandleQuestsChangedEvent__
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

		// Token: 0x17000A3F RID: 2623
		// (set) Token: 0x06003391 RID: 13201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A3F")]
		public override DailyQuestEvents Events
		{
			[Token(Token = "0x6003391")]
			[Address(RVA = "0x83CB", Offset = "0x83CB", VA = "0x83CB", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (set) Token: 0x06003392 RID: 13202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A40")]
		public override UserInterfaceView View
		{
			[Token(Token = "0x6003392")]
			[Address(RVA = "0x83CC", Offset = "0x83CC", VA = "0x83CC", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003393")]
		[Address(RVA = "0x83CD", Offset = "0x83CD", VA = "0x83CD")]
		private void SetupView()
		{
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003394")]
		[Address(RVA = "0x83CE", Offset = "0x83CE", VA = "0x83CE")]
		private void HandleActiveQuestsCountChanged()
		{
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003395")]
		[Address(RVA = "0x83CF", Offset = "0x83CF", VA = "0x83CF")]
		private void TryShowNotification()
		{
		/* --- GHIDRA: TryShowNotification ---
		void Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator__TryShowNotification
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator__HandleQuestsChangedEvent
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003396 RID: 13206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003396")]
		[Address(RVA = "0x83D0", Offset = "0x83D0", VA = "0x83D0")]
		private void HandleDailyQuestsButtonClickedEvent(IndexButtonBasic btn)
		{
		/* --- GHIDRA: HandleDailyQuestsButtonClickedEvent ---
		void Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator__HandleDailyQuestsButtonClickedEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57c86 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__UserInterfaceView__get_Model__
		              );
		    DAT_ram_00a57c86 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = Gameplay_DailyQuests_Model_DailyQuestsModel__set_Categories(param1[2],param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Collections_Generic_Dictionary_int__object___get_Count
		              (*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x14) + 0x24) + 0x14),uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003397 RID: 13207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003397")]
		[Address(RVA = "0x83D1", Offset = "0x83D1", VA = "0x83D1")]
		private void HandleQuestsChangedEvent()
		{
		/* --- GHIDRA: HandleQuestsChangedEvent ---
		void Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator__HandleQuestsChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a57c87 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator_HandleOnCloseDailyQuestsWindow__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6251);
		    DAT_ram_00a57c87 = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) != 0) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7109(StringLiteral_6251,0);
		    return;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x170);
		        goto code_r0x80e415bb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x16);
		code_r0x80e415bb:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  uVar3 = Core_Gameplay_Managers_DailyQuestsManager__SetView(uVar3,0,0);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator_HandleOnCloseDailyQuestsWindow__
		             ,0);
		  UI_Windows_BaseWindow__get_IsActiveResourceBar(uVar3,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003398 RID: 13208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003398")]
		[Address(RVA = "0x83D2", Offset = "0x83D2", VA = "0x83D2")]
		private void ShowDailyQuests()
		{
		/* --- GHIDRA: ShowDailyQuests ---
		void Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator__ShowDailyQuests
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57c88 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator_HandleOnCloseDailyQuestsWindow__
		              );
		    DAT_ram_00a57c88 = '\x01';
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x18),0);
		  if (iVar1 != 0) {
		    param1_00 = *(undefined4 *)(param1 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator_HandleOnCloseDailyQuestsWindow__
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

		// Token: 0x06003399 RID: 13209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003399")]
		[Address(RVA = "0x83D3", Offset = "0x83D3", VA = "0x83D3")]
		private void CloseDailyQuests()
		{
		/* --- GHIDRA: CloseDailyQuests ---
		void Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator__CloseDailyQuests
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57c89 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator_HandleOnCloseDailyQuestsWindow__
		              );
		    DAT_ram_00a57c89 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator_HandleOnCloseDailyQuestsWindow__
		             ,0);
		  UI_Windows_BaseWindow__add_onClose(param1_01,param1_00,0);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600339A RID: 13210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600339A")]
		[Address(RVA = "0x83D4", Offset = "0x83D4", VA = "0x83D4")]
		private void HandleOnCloseDailyQuestsWindow()
		{
		/* --- GHIDRA: HandleOnCloseDailyQuestsWindow ---
		void Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator__HandleOnCloseDailyQuestsWindow
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57c8a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestsView___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Sorting_QuestComparer_TypeInfo);
		    DAT_ram_00a57c8a = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Sorting_QuestComparer_TypeInfo);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestsView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = param5;
		  return;
		}
		*/

		}

		// Token: 0x04001C17 RID: 7191
		[Token(Token = "0x4001C17")]
		[FieldOffset(Offset = "0x18")]
		private DailyQuestsWindow _dailyQuestsWindow;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57c84 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__UserInterfaceView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator_HandleDailyQuestsButtonClickedEvent__
		              );
		    DAT_ram_00a57c84 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x24);
		    uVar1 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator_HandleDailyQuestsButtonClickedEvent__
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
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x24);
		    uVar1 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator_HandleDailyQuestsButtonClickedEvent__
		               ,0);
		    UI_IndexButtonBasic__get_CanvasGroup(uVar3,uVar1,0);
		    if (DAT_ram_00a57c85 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__UserInterfaceView__get_Model__
		                );
		      DAT_ram_00a57c85 = '\x01';
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x14) + 0x24) + 0x14);
		    uVar1 = Gameplay_DailyQuests_Model_DailyQuestsModel__set_Categories(param1[2],param1);
		    System_Collections_Generic_Dictionary_int__object___get_Count(uVar3,uVar1,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57c85 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__UserInterfaceView__get_Model__
		              );
		    DAT_ram_00a57c85 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x14) + 0x24) + 0x14);
		  param2_00 = Gameplay_DailyQuests_Model_DailyQuestsModel__set_Categories(param1[2],param1);
		  System_Collections_Generic_Dictionary_int__object___get_Count(param1_00,param2_00,0);
		  return;
		}
		*/

}
