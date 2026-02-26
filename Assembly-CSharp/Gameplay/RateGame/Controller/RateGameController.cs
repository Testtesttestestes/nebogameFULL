using System;
using Gameplay.RateGame.Events;
using Gameplay.RateGame.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.RateGame.Controller
{
	// Token: 0x020005AA RID: 1450
	[Token(Token = "0x20005AA")]
	public class RateGameController : AbstractController<RateGameModel, RateGameEvents>
	{
		// Token: 0x060022CD RID: 8909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022CD")]
		[Address(RVA = "0x7424", Offset = "0x7424", VA = "0x7424")]
		public RateGameController(RateGameModel model, RateGameEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_RateGame_Controller_RateGameController___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a580cb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_RateGameModel__RateGameEvents__Dispose__);
		    DAT_ram_00a580cb = '\x01';
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_RateGameModel__RateGameEvents__Dispose__);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060022CE RID: 8910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022CE")]
		[Address(RVA = "0x7425", Offset = "0x7425", VA = "0x7425", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_RateGame_Controller_RateGameController__Dispose(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  undefined4 local_c;
		  undefined4 local_8;
		  int local_4;
		  
		  if (DAT_ram_00a580cc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_PopupScheduleManager_Args_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_bool____TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_PopupScheduleManager_ScheduleOpenWindow_RateGameWindow___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RateGame_Controller_RateGameController_IsNeedToShowRateGameWindow__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RateGame_Controller_RateGameController_ShowRateGameWindow__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13319);
		    DAT_ram_00a580cc = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar2 + 0x10) == 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    local_8 = *(undefined4 *)(iVar2 + 0x10);
		    uVar4 = func_ii_1081(DAT_ram_00a66958,&local_8);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    local_c = *(undefined4 *)(iVar2 + 0xc);
		    uVar5 = func_ii_1081(DAT_ram_00a66954,&local_c);
		    uVar4 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_13319,uVar4,uVar5,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar4,0);
		  }
		  else {
		    iVar2 = unnamed_function_1417(Core_Gameplay_Managers_PopupScheduleManager_Args_TypeInfo);
		    UnityEngine_Purchasing_Default_WinProductDescription__set_title(iVar2,2,0);
		    *(undefined4 *)(iVar2 + 0xc) = 0x3f800000;
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_RateGame_Controller_RateGameController_ShowRateGameWindow__,0);
		    *(undefined4 *)(iVar2 + 8) = 0x7fffffff;
		    *(undefined4 *)(iVar2 + 0x10) = uVar4;
		    local_4 = iVar2;
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x208);
		          goto code_r0x80e9f864;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x29);
		code_r0x80e9f864:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    iVar2 = Mono_Security_ASN1Convert__ToOid(System_Func_bool____TypeInfo,1);
		    uVar5 = unnamed_function_1417(System_Func_bool__TypeInfo);
		    System_Func_BackgroundSize___Invoke
		              (uVar5,param1,
		               Method_Gameplay_RateGame_Controller_RateGameController_IsNeedToShowRateGameWindow__,0
		              );
		    *(undefined4 *)(iVar2 + 0x10) = uVar5;
		    UI_Windows_PopupController__HasOpenWindow_object_
		              (uVar4,&local_4,iVar2,
		               Method_Core_Gameplay_Managers_PopupScheduleManager_ScheduleOpenWindow_RateGameWindow___
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x060022CF RID: 8911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022CF")]
		[Address(RVA = "0x7426", Offset = "0x7426", VA = "0x7426", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		undefined4 Gameplay_RateGame_Controller_RateGameController__HandleRun(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a580cd == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a580cd = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x160);
		        goto code_r0x80e9fa1a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x80e9fa1a:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined4 *)(iVar4 + 0x10);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = Core_Gameplay_Managers_Requirements_RequirementsManager__GetRequirementDic
		                    (uVar3,param2_00,*(undefined4 *)(iVar4 + 8),0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x00006DC8 File Offset: 0x00004FC8
		[Token(Token = "0x60022D0")]
		[Address(RVA = "0x7427", Offset = "0x7427", VA = "0x7427")]
		private bool IsNeedToShowRateGameWindow()
		{
		/* --- GHIDRA: IsNeedToShowRateGameWindow ---
		void Gameplay_RateGame_Controller_RateGameController__IsNeedToShowRateGameWindow
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a580ce == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_RateGameWindow___);
		    Mono_Security_ASN1__get_Item(&Gameplay_RateGame_View_RateGameWindow_RateGameWindowArgs_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_12660);
		    DAT_ram_00a580ce = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_RateGame_View_RateGameWindow_RateGameWindowArgs_TypeInfo);
		  if (DAT_ram_00a580c7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_RateGameWindow_RateGameWindowArgs___ctor__
		              );
		    DAT_ram_00a580c7 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1_00,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_RateGameWindow_RateGameWindowArgs___ctor__
		            );
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(int **)(param1_00 + 0x2c) = param1;
		  *(undefined4 *)(param1_00 + 0x30) = uVar2;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  *(undefined4 *)(param1_00 + 0x10) = 8;
		  *(undefined4 *)(param1_00 + 0x34) = uVar2;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12660,param1_00,
		             Method_UI_Windows_PopupController_Show_RateGameWindow___);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D1")]
		[Address(RVA = "0x7428", Offset = "0x7428", VA = "0x7428")]
		private void ShowRateGameWindow()
		{
		/* --- GHIDRA: ShowRateGameWindow ---
		void Gameplay_RateGame_Controller_RateGameController__ShowRateGameWindow
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param3_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a580cf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_RateGame_Controller_RateGameController_Handler__);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_RateGameScope_RateGameEventArgs_TypeInfo);
		    DAT_ram_00a580cf = '\x01';
		  }
		  iVar1 = System_Uri___ctor(0);
		  iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x88) + 0x14);
		  if (iVar1 != 0) {
		    uVar2 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    uVar3 = unnamed_function_1417(Core_Events_Scopes_RateGameScope_RateGameEventArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(uVar3,uVar2,param3_00,param2,0);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),uVar3,*(undefined4 *)(iVar1 + 0x14));
		  }
		  uVar2 = ServicesNamespace_SocialService__SendGift(*(undefined4 *)(param1 + 0x18),param2,0);
		  uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_Gameplay_RateGame_Controller_RateGameController_Handler__,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_4 = param2;
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  DG_Tweening_TweenParams__SetId(uVar2,uVar3,Method_Utils_OpToken_IMessage__object__SetCustomData__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D2")]
		[Address(RVA = "0x7429", Offset = "0x7429", VA = "0x7429")]
		public void RateGame(uint rate)
		{
		/* --- GHIDRA: RateGame ---
		void Gameplay_RateGame_Controller_RateGameController__RateGame
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  int iVar2;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *piVar3;
		  undefined4 uVar4;
		  undefined4 param3_00;
		  int local_4;
		  
		  if (DAT_ram_00a580d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_RateGameScope_RateGameEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13320);
		    DAT_ram_00a580d0 = '\x01';
		  }
		  piVar3 = *(int **)(param2 + 0x20);
		  if ((piVar3 != (int *)0x0) && (Protocol_Common_ProtoDefaultAns_TypeInfo != *piVar3)) {
		    System_Activator__CreateInstance(piVar3,Protocol_Common_ProtoDefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  local_4 = piVar3[3];
		  if (local_4 < 0) {
		    uVar4 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar4 = func_ii_4419(StringLiteral_13320,uVar4,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar4,0);
		  }
		  else {
		    piVar3 = *(int **)(param2 + 0xc);
		    if (piVar3 == (int *)0x0) {
		      System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(*piVar3 + 0x20) != *(int *)(DAT_ram_00a66958 + 0x20)) {
		      System_Activator__CreateInstance(piVar3,DAT_ram_00a66958);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    puVar1 = (undefined4 *)func_ii_15774(piVar3);
		    uVar4 = *puVar1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x14);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),uVar4,*(undefined4 *)(iVar2 + 0x14));
		    }
		    iVar2 = System_Uri___ctor(0);
		    iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x88) + 0x18);
		    if (iVar2 != 0) {
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      param1_00 = unnamed_function_1417(Core_Events_Scopes_RateGameScope_RateGameEventArgs_TypeInfo)
		      ;
		      Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData
		                (param1_00,param2_00,param3_00,uVar4,0);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),param1_00,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D3")]
		[Address(RVA = "0x742A", Offset = "0x742A", VA = "0x742A")]
		private void Handler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: Handler ---
		void Gameplay_RateGame_Controller_RateGameController__Handler(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  undefined4 param3;
		  
		  if (DAT_ram_00a580d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_BaseEventBusEventArgs_TypeInfo);
		    DAT_ram_00a580d1 = '\x01';
		  }
		  ServicesNamespace_SocialService__SendGift(*(undefined4 *)(param1 + 0x18),0,0);
		  iVar1 = System_Uri___ctor(0);
		  iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x88) + 8);
		  if (iVar1 != 0) {
		    param2_00 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417(Core_Events_BaseEventBusEventArgs_TypeInfo);
		    Core_Application_Managers_Connection_ServerConnectionDelay__ResetAll
		              (param1_00,param2_00,param3,0);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D4")]
		[Address(RVA = "0x742B", Offset = "0x742B", VA = "0x742B")]
		public void RegisterCloseButtonClicked()
		{
		/* --- GHIDRA: RegisterCloseButtonClicked ---
		void Gameplay_RateGame_Controller_RateGameController__RegisterCloseButtonClicked
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a580d2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RateGameModel__RateGameEvents__RateGameController__RateGameWindow___ctor__
		              );
		    DAT_ram_00a580d2 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_RateGameModel__RateGameEvents__RateGameController__RateGameWindow___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04001304 RID: 4868
		[Token(Token = "0x4001304")]
		[FieldOffset(Offset = "0x18")]
		private SocialService _socialService;
	}
}
