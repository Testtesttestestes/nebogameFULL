using System;
using Gameplay.Combat.Control;
using Gameplay.Tournaments.Events;
using Gameplay.Tournaments.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Tournaments;
using ServicesNamespace;
using Utils;

namespace Gameplay.Tournaments.Controller
{
	// Token: 0x020004BC RID: 1212
	[Token(Token = "0x20004BC")]
	public class TournamentCombatController : CombatController<TournamentCombatModel, TournamentCombatEvents>
	{
		// Token: 0x06001CA3 RID: 7331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA3")]
		[Address(RVA = "0x6E22", Offset = "0x6E22", VA = "0x6E22")]
		public TournamentCombatController(TournamentsService tournamentsService, ICombatService service, TournamentCombatModel model, TournamentCombatEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tournaments_Controller_TournamentCombatController___ctor
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined8 param2_00;
		  int param1_01;
		  
		  if (DAT_ram_00a58516 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentCombatController_WatchCombatResultHandler__
		              );
		    DAT_ram_00a58516 = '\x01';
		  }
		  param1_01 = param1[8];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar1 + 8),0);
		  uVar2 = ServicesNamespace_TournamentsService__SetBet(param1_01,param2_00,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Tournaments_Controller_TournamentCombatController_WatchCombatResultHandler__
		             ,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA4")]
		[Address(RVA = "0x6E23", Offset = "0x6E23", VA = "0x6E23")]
		public void WatchCombat()
		{
		/* --- GHIDRA: WatchCombat ---
		void Gameplay_Tournaments_Controller_TournamentCombatController__WatchCombat
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param2_00;
		  int param1_02;
		  
		  if (DAT_ram_00a58517 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_TournamentCombatModel__TournamentCombatEvents__SetJoinToCombatInfo__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_TournamentCombatModel__TournamentCombatEvents__ValidateInit__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedCombatErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoJoinToCombatAns_TypeInfo);
		    DAT_ram_00a58517 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Combat_ProtoJoinToCombatAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Combat_ProtoJoinToCombatAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined4 *)(iVar1 + 0x50);
		  param1_02 = param1_01[3];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_02,*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x14),
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedCombatErrors___
		                    );
		  if (iVar1 != 0) {
		    param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__RemoveScene(param1_00,param2_00,0);
		    return;
		  }
		  Gameplay_Combat_Control_CombatController_object__object___SelectSpell
		            (param1,param1_01[4],
		             Method_Gameplay_Combat_Control_CombatController_TournamentCombatModel__TournamentCombatEvents__SetJoinToCombatInfo__
		            );
		  Gameplay_Combat_Control_CombatController_object__object___TryHandleJoinError
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_TournamentCombatModel__TournamentCombatEvents__ValidateInit__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA5")]
		[Address(RVA = "0x6E24", Offset = "0x6E24", VA = "0x6E24")]
		private void WatchCombatResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: WatchCombatResultHandler ---
		void Gameplay_Tournaments_Controller_TournamentCombatController__WatchCombatResultHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  longlong lVar2;
		  longlong lVar3;
		  
		  if (DAT_ram_00a58518 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_TournamentCombatModel__TournamentCombatEvents__NotifyShowViewProcessComplete__
		              );
		    DAT_ram_00a58518 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  lVar3 = *(longlong *)(iVar1 + 0x60);
		  lVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar1 + 8),0);
		  if (lVar3 == lVar2) {
		    Gameplay_Tournaments_Controller_TournamentCombatController___ctor(param1,param1);
		    return;
		  }
		  Gameplay_Combat_Control_CombatController_object__object___NotifyAllAnimationComplete
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_TournamentCombatModel__TournamentCombatEvents__NotifyShowViewProcessComplete__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA6")]
		[Address(RVA = "0x6E25", Offset = "0x6E25", VA = "0x6E25", Slot = "25")]
		public override void NotifyShowViewProcessComplete()
		{
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00006018 File Offset: 0x00004218
		[Token(Token = "0x6001CA7")]
		[Address(RVA = "0x6E26", Offset = "0x6E26", VA = "0x6E26", Slot = "22")]
		protected override bool IsOtherPlayer(ProtoPlayerActionEvt msg)
		{
		/* --- GHIDRA: IsOtherPlayer ---
		void Gameplay_Tournaments_Controller_TournamentCombatController__IsOtherPlayer
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 param5;
		  
		  if (DAT_ram_00a58519 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_TournamentCombatModel__TournamentCombatEvents__TryAppendGameOverToCombatEvents__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_GameOverData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_PlayerProfitData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_PlayerProfit_TypeInfo);
		    DAT_ram_00a58519 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param5 = *(undefined4 *)(*(int *)(iVar1 + 0xc) + 0xc);
		  uVar2 = unnamed_function_1417(Protocol_Combat_PlayerProfit_TypeInfo);
		  Protocol_Combat_PlayerProfit__pb__Google_Protobuf_IMessage_get_Descriptor(uVar2,0);
		  param1_00 = unnamed_function_1417(Gameplay_Combat_Model_PlayerProfitData_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,uVar2,0);
		  uVar2 = unnamed_function_1417(Gameplay_Combat_Model_GameOverData_TypeInfo);
		  Gameplay_Combat_Model_GameFieldGamesData___ctor(uVar2,0,0,0,param5,param1_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  Gameplay_Combat_Control_CombatController_object__object___SwitchTurn
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_TournamentCombatModel__TournamentCombatEvents__TryAppendGameOverToCombatEvents__
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA8")]
		[Address(RVA = "0x6E27", Offset = "0x6E27", VA = "0x6E27")]
		public void AppendGameOver()
		{
		/* --- GHIDRA: AppendGameOver ---
		void Gameplay_Tournaments_Controller_TournamentCombatController__AppendGameOver
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5851a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentCombatController_StopWatchingCombatResultHandler__
		              );
		    DAT_ram_00a5851a = '\x01';
		  }
		  param1_00 = ServicesNamespace_TournamentsService__BrowseCombat(*(undefined4 *)(param1 + 0x20),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Tournaments_Controller_TournamentCombatController_StopWatchingCombatResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA9")]
		[Address(RVA = "0x6E28", Offset = "0x6E28", VA = "0x6E28")]
		public void StopWatchingCombat()
		{
		/* --- GHIDRA: StopWatchingCombat ---
		void Gameplay_Tournaments_Controller_TournamentCombatController__StopWatchingCombat
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x78);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAA")]
		[Address(RVA = "0x6E29", Offset = "0x6E29", VA = "0x6E29")]
		private void StopWatchingCombatResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: StopWatchingCombatResultHandler ---
		void Gameplay_Tournaments_Controller_TournamentCombatController__StopWatchingCombatResultHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5851b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_TournamentCombatModel__TournamentCombatEvents__StartAwaitJumpToCombatEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentCombatController_CurrentCombatCompleteEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentCombatController_FinalCombatCompleteEventHandler__
		              );
		    DAT_ram_00a5851b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x40) == 0) {
		    Gameplay_Combat_Control_CombatController_object__object___SpellCalled
		              (param1,
		               Method_Gameplay_Combat_Control_CombatController_TournamentCombatModel__TournamentCombatEvents__StartAwaitJumpToCombatEvent__
		              );
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		              (param1,*(undefined4 *)(iVar1 + 0x40),*(undefined4 *)(*param1 + 0x14c));
		  }
		  iVar1 = param1[8];
		  uVar2 = unnamed_function_1417(System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Tournaments_Controller_TournamentCombatController_CurrentCombatCompleteEventHandler__
		             ,0);
		  ServicesNamespace_TournamentsService__remove_StateChangedEvent(iVar1,uVar2,0);
		  iVar1 = param1[8];
		  uVar2 = unnamed_function_1417(System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Tournaments_Controller_TournamentCombatController_FinalCombatCompleteEventHandler__
		             ,0);
		  ServicesNamespace_TournamentsService__remove_CurrentCombatCompleteEvent(iVar1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAB")]
		[Address(RVA = "0x6E2A", Offset = "0x6E2A", VA = "0x6E2A", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Tournaments_Controller_TournamentCombatController__HandleRun
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5851c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_TournamentCombatModel__TournamentCombatEvents__HandleStop__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentCombatController_CurrentCombatCompleteEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentCombatController_FinalCombatCompleteEventHandler__
		              );
		    DAT_ram_00a5851c = '\x01';
		  }
		  Gameplay_Combat_Control_CombatController_object__object___HandleSpellAppliedServiceEvent
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_TournamentCombatModel__TournamentCombatEvents__HandleStop__
		            );
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Tournaments_Controller_TournamentCombatController_CurrentCombatCompleteEventHandler__
		             ,0);
		  ServicesNamespace_TournamentsService__add_CurrentCombatCompleteEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Tournaments_Controller_TournamentCombatController_FinalCombatCompleteEventHandler__
		             ,0);
		  ServicesNamespace_TournamentsService__add_FinalCombatCompleteEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAC")]
		[Address(RVA = "0x6E2B", Offset = "0x6E2B", VA = "0x6E2B", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Tournaments_Controller_TournamentCombatController__HandleStop
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x74);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAD")]
		[Address(RVA = "0x6E2C", Offset = "0x6E2C", VA = "0x6E2C")]
		private void CurrentCombatCompleteEventHandler(ProtoCurrentTnmCombatCompleteEvt evt)
		{
		/* --- GHIDRA: CurrentCombatCompleteEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentCombatController__CurrentCombatCompleteEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x70);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAE")]
		[Address(RVA = "0x6E2D", Offset = "0x6E2D", VA = "0x6E2D")]
		private void FinalCombatCompleteEventHandler(ProtoFinalTnmCombatCompleteEvt evt)
		{
		/* --- GHIDRA: FinalCombatCompleteEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentCombatController__FinalCombatCompleteEventHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a5851d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController___ctor__
		              );
		    DAT_ram_00a5851d = '\x01';
		  }
		  HuaweiMobileServices_Base_OnSuccessListener___Il2CppFullySharedGenericType___onSuccess
		            (param1,param2,param3,param4,
		             Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04000FAB RID: 4011
		[Token(Token = "0x4000FAB")]
		[FieldOffset(Offset = "0x20")]
		private TournamentsService _tournamentsService;
	}
}
