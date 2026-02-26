using System;
using Gameplay.RateGame.Events;
using Gameplay.RateGame.Model;
using Gameplay.RateGame.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.RateGame.Controller
{
	// Token: 0x020005AB RID: 1451
	[Token(Token = "0x20005AB")]
	public class RateGameWindowMediator : AbstractViewMediator<RateGameModel, RateGameEvents, RateGameController, RateGameWindow>
	{
		// Token: 0x060022D5 RID: 8917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D5")]
		[Address(RVA = "0x742C", Offset = "0x742C", VA = "0x742C")]
		public RateGameWindowMediator(RateGameModel model, RateGameEvents events, RateGameController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_RateGame_Controller_RateGameWindowMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a580d3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RateGameModel__RateGameEvents__RateGameController__RateGameWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_RateGameWindow_RateGameWindowState__set_CurrentState__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_RateGame_Controller_RateGameWindowMediator_NegativeRateButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_RateGame_Controller_RateGameWindowMediator_PositiveRateButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_RateGame_Controller_RateGameWindowMediator_RateGameButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_RateGame_Controller_RateGameWindowMediator_ViewOnCloseButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a580d3 = '\x01';
		  }
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar3,0);
		  if (iVar4 != 0) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(*(int *)(iVar4 + 0x58) + 0xb4);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar3,param1,
		               Method_Gameplay_RateGame_Controller_RateGameWindowMediator_RateGameButtonClickHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar7,uVar3,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(*(int *)(iVar4 + 0x60) + 0xb4);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar3,param1,
		               Method_Gameplay_RateGame_Controller_RateGameWindowMediator_PositiveRateButtonClickHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar7,uVar3,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(*(int *)(iVar4 + 0x5c) + 0xb4);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar3,param1,
		               Method_Gameplay_RateGame_Controller_RateGameWindowMediator_NegativeRateButtonClickHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar7,uVar3,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_RateGame_Controller_RateGameWindowMediator_ViewOnCloseButtonClickEvent__
		               ,0);
		    if (DAT_ram_00a580bd == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      DAT_ram_00a580bd = '\x01';
		    }
		    iVar2 = *(int *)(iVar4 + 100);
		    do {
		      piVar5 = (int *)func_ii_7048(iVar2,uVar3,0);
		      if ((piVar5 != (int *)0x0) && (System_Action_TypeInfo != *piVar5)) {
		        System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar6 = func_ii_4329(iVar4 + 100,piVar5,iVar2);
		      bVar1 = iVar6 != iVar2;
		      iVar2 = iVar6;
		    } while (bVar1);
		  }
		  param1[5] = param2;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar3,0);
		  if (iVar4 != 0) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(*(int *)(iVar4 + 0x58) + 0xb4);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar3,param1,
		               Method_Gameplay_RateGame_Controller_RateGameWindowMediator_RateGameButtonClickHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar7,uVar3,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(*(int *)(iVar4 + 0x60) + 0xb4);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar3,param1,
		               Method_Gameplay_RateGame_Controller_RateGameWindowMediator_PositiveRateButtonClickHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar7,uVar3,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(*(int *)(iVar4 + 0x5c) + 0xb4);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar3,param1,
		               Method_Gameplay_RateGame_Controller_RateGameWindowMediator_NegativeRateButtonClickHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar7,uVar3,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_RateGame_Controller_RateGameWindowMediator_ViewOnCloseButtonClickEvent__
		               ,0);
		    if (DAT_ram_00a580bc == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      DAT_ram_00a580bc = '\x01';
		    }
		    iVar2 = *(int *)(iVar4 + 100);
		    do {
		      piVar5 = (int *)UnityEngine_UI_Image__set_sprite(iVar2,uVar3,0);
		      if ((piVar5 != (int *)0x0) && (System_Action_TypeInfo != *piVar5)) {
		        System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar6 = func_ii_4329(iVar4 + 100,piVar5,iVar2);
		      bVar1 = iVar6 != iVar2;
		      iVar2 = iVar6;
		    } while (bVar1);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(iVar4 + 0x54),1,
		               Method_UI_MonoBehaviourWithStates_RateGameWindow_RateGameWindowState__set_CurrentState__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700065F RID: 1631
		// (set) Token: 0x060022D6 RID: 8918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065F")]
		public override RateGameWindow View
		{
			[Token(Token = "0x60022D6")]
			[Address(RVA = "0x742D", Offset = "0x742D", VA = "0x742D", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D7")]
		[Address(RVA = "0x742E", Offset = "0x742E", VA = "0x742E")]
		private void PositiveRateButtonClickHandler()
		{
		/* --- GHIDRA: PositiveRateButtonClickHandler ---
		void Gameplay_RateGame_Controller_RateGameWindowMediator__PositiveRateButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_00;
		  undefined4 param2_00;
		  int *param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a580d5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RateGameModel__RateGameEvents__RateGameController__RateGameWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_FeedbackForm_View_FeedbackFormWindow_FeedbackFormWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_FeedbackFormWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12616);
		    DAT_ram_00a580d5 = '\x01';
		  }
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  param1_01 = *(int **)(param1[2] + 0x14);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x80ea0434;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80ea0434:
		  param1_00 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  uVar1 = 0;
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x160);
		        goto code_r0x80ea04b8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Application_IApp_TypeInfo,0x14);
		code_r0x80ea04b8:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  param2_00 = Gameplay_FeedbackForm_Model_Source_DefaultSource___ctor
		                        (param1_01,*(undefined4 *)(iVar4 + 0x14),0);
		  iVar4 = unnamed_function_1417
		                    (Gameplay_FeedbackForm_View_FeedbackFormWindow_FeedbackFormWindowArgs_TypeInfo);
		  Gameplay_FeedbackForm_View_FeedbackFormWindow_FeedbackFormWindowArgs__get_Source
		            (iVar4,param2_00,0);
		  *(undefined4 *)(iVar4 + 0x18) = *(undefined4 *)(param1[2] + 8);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar2,StringLiteral_12616,iVar4,
		             Method_UI_Windows_PopupController_Show_FeedbackFormWindow___);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(uVar2,2,0);
		  return;
		}
		*/

		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D8")]
		[Address(RVA = "0x742F", Offset = "0x742F", VA = "0x742F")]
		private void NegativeRateButtonClickHandler()
		{
		/* --- GHIDRA: NegativeRateButtonClickHandler ---
		void Gameplay_RateGame_Controller_RateGameWindowMediator__NegativeRateButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  undefined4 param3;
		  
		  if (DAT_ram_00a580d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_BaseEventBusEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_RateGameWindow_RateGameWindowState__get_CurrentState__
		              );
		    DAT_ram_00a580d6 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = *param1;
		  if (*(int *)(*(int *)(iVar1 + 0x54) + 0x18) == 1) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x148) * 4))
		                      (param1,*(undefined4 *)(iVar3 + 0x14c));
		    Gameplay_RateGame_Controller_RateGameController__Handler(uVar2,param1);
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar3 + 0x15c));
		  if (*(int *)(*(int *)(iVar1 + 0x54) + 0x18) == 3) {
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x88) + 0xc);
		    if (iVar1 != 0) {
		      uVar2 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      param1_00 = unnamed_function_1417(Core_Events_BaseEventBusEventArgs_TypeInfo);
		      Core_Application_Managers_Connection_ServerConnectionDelay__ResetAll(param1_00,uVar2,param3,0)
		      ;
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D9")]
		[Address(RVA = "0x7430", Offset = "0x7430", VA = "0x7430")]
		private void ViewOnCloseButtonClickEvent()
		{
		/* --- GHIDRA: ViewOnCloseButtonClickEvent ---
		void Gameplay_RateGame_Controller_RateGameWindowMediator__ViewOnCloseButtonClickEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a580d7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RateGameModel__RateGameEvents__RateGameController__RateGameWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RateGame_Controller_RateGameWindowMediator_RateGameEvent__);
		    DAT_ram_00a580d7 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_Gameplay_RateGame_Controller_RateGameWindowMediator_RateGameEvent__,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x14) = iVar4;
		      uVar2 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_Gameplay_RateGame_Controller_RateGameWindowMediator_RateGameEvent__,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x14) = iVar4;
		    uVar2 = System_Action_uint__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000660 RID: 1632
		// (set) Token: 0x060022DA RID: 8922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000660")]
		public override RateGameEvents Events
		{
			[Token(Token = "0x60022DA")]
			[Address(RVA = "0x7431", Offset = "0x7431", VA = "0x7431", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022DB")]
		[Address(RVA = "0x7432", Offset = "0x7432", VA = "0x7432")]
		private void RateGameEvent(uint rate)
		{
		/* --- GHIDRA: RateGameEvent ---
		void Gameplay_RateGame_Controller_RateGameWindowMediator__RateGameEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a580d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13091);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13092);
		    DAT_ram_00a580d9 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(*(int *)(iVar1 + 0x50) + 0x14);
		  if (0 < iVar1) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    Gameplay_RateGame_Controller_RateGameController__ShowRateGameWindow(uVar2,iVar1,param1);
		    return;
		  }
		  iVar1 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		  UI_Windows_Alert__Show(iVar1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13092,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 0x18) = uVar2;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13091,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 0x1c) = uVar2;
		  UI_Windows_UnityInstantiator___ctor(iVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060022DC RID: 8924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022DC")]
		[Address(RVA = "0x7433", Offset = "0x7433", VA = "0x7433")]
		private void RateGameButtonClickHandler()
		{
		/* --- GHIDRA: RateGameButtonClickHandler ---
		void Gameplay_RateGame_Controller_RateGameWindowMediator__RateGameButtonClickHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a580da == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a580da = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x30,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_RateGame_Controller_RateGameWindowMediator__set_View(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 param3;
		  
		  if (DAT_ram_00a580d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_BaseEventBusEventArgs_TypeInfo);
		    DAT_ram_00a580d4 = '\x01';
		  }
		  iVar1 = System_Uri___ctor(0);
		  iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x88) + 0x10);
		  if (iVar1 != 0) {
		    uVar2 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417(Core_Events_BaseEventBusEventArgs_TypeInfo);
		    Core_Application_Managers_Connection_ServerConnectionDelay__ResetAll(param1_00,uVar2,param3,0);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  }
		  UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor(0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(uVar2,2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_RateGame_Controller_RateGameWindowMediator__set_Events
		               (int *param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a580d8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RateGameModel__RateGameEvents__RateGameController__RateGameWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_RateGameWindow_RateGameWindowState__set_CurrentState__
		              );
		    DAT_ram_00a580d8 = '\x01';
		  }
		  iVar1 = *(int *)(param1[2] + 0xc);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = 2;
		  if ((longlong)iVar1 <= (longlong)(ulonglong)param2) {
		    param2_00 = 3;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar2 + 0x54),param2_00,
		             Method_UI_MonoBehaviourWithStates_RateGameWindow_RateGameWindowState__set_CurrentState__
		            );
		  return;
		}
		*/

}
