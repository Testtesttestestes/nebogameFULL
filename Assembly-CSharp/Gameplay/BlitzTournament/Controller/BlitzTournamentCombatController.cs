using System;
using Gameplay.BlitzTournament.Events;
using Gameplay.BlitzTournament.Model;
using Gameplay.Combat.Control;
using Il2CppDummyDll;
using Protocol.Tournaments;
using ServicesNamespace;

namespace Gameplay.BlitzTournament.Controller
{
	// Token: 0x02000BD7 RID: 3031
	[Token(Token = "0x2000BD7")]
	public class BlitzTournamentCombatController : CombatController<BlitzTournamentCombatModel, BlitzTournamentCombatEvents>
	{
		// Token: 0x06004A40 RID: 19008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A40")]
		[Address(RVA = "0x98A2", Offset = "0x98A2", VA = "0x98A2")]
		public BlitzTournamentCombatController(BlitzTournamentService blitzTournamentService, ICombatService service, BlitzTournamentCombatModel model, BlitzTournamentCombatEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentCombatController___ctor
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a608b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentCombatController_CurrentBattleCompleteEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentCombatController_FinalBattleCompleteEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__StartAwaitJumpToCombatEvent__
		              );
		    DAT_ram_00a608b6 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x40) == 0) {
		    Gameplay_Combat_Control_CombatController_object__object___SpellCalled
		              (param1,
		               Method_Gameplay_Combat_Control_CombatController_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__StartAwaitJumpToCombatEvent__
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
		             Method_Gameplay_BlitzTournament_Controller_BlitzTournamentCombatController_CurrentBattleCompleteEventHandler__
		             ,0);
		  ServicesNamespace_BlitzTournamentService__remove_StateChangedEvent(iVar1,uVar2,0);
		  iVar1 = param1[8];
		  uVar2 = unnamed_function_1417(System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_BlitzTournament_Controller_BlitzTournamentCombatController_FinalBattleCompleteEventHandler__
		             ,0);
		  ServicesNamespace_BlitzTournamentService__remove_CurrentBattleCompleteEvent(iVar1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A41")]
		[Address(RVA = "0x98A3", Offset = "0x98A3", VA = "0x98A3", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentCombatController__HandleRun
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a608b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentCombatController_CurrentBattleCompleteEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentCombatController_FinalBattleCompleteEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__HandleStop__
		              );
		    DAT_ram_00a608b7 = '\x01';
		  }
		  Gameplay_Combat_Control_CombatController_object__object___HandleSpellAppliedServiceEvent
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__HandleStop__
		            );
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_BlitzTournament_Controller_BlitzTournamentCombatController_CurrentBattleCompleteEventHandler__
		             ,0);
		  ServicesNamespace_BlitzTournamentService__add_CurrentBattleCompleteEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_BlitzTournament_Controller_BlitzTournamentCombatController_FinalBattleCompleteEventHandler__
		             ,0);
		  ServicesNamespace_BlitzTournamentService__add_FinalBattleCompleteEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004A42 RID: 19010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A42")]
		[Address(RVA = "0x98A4", Offset = "0x98A4", VA = "0x98A4", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentCombatController__HandleStop
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined8 *)(iVar1 + 0x60) = *(undefined8 *)(param2 + 0x18);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined8 *)(iVar1 + 0x68) = *(undefined8 *)(param2 + 0x10);
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

		// Token: 0x06004A43 RID: 19011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A43")]
		[Address(RVA = "0x98A5", Offset = "0x98A5", VA = "0x98A5")]
		private void FinalBattleCompleteEventHandler(ProtoFinalTnmCombatCompleteEvt evt)
		{
		/* --- GHIDRA: FinalBattleCompleteEventHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentCombatController__FinalBattleCompleteEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined8 *)(iVar1 + 0x60) = *(undefined8 *)(param2 + 0x18);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined8 *)(iVar1 + 0x68) = *(undefined8 *)(param2 + 0x10);
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

		// Token: 0x06004A44 RID: 19012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A44")]
		[Address(RVA = "0x98A6", Offset = "0x98A6", VA = "0x98A6")]
		private void CurrentBattleCompleteEventHandler(ProtoCurrentTnmCombatCompleteEvt evt)
		{
		/* --- GHIDRA: CurrentBattleCompleteEventHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentCombatController__CurrentBattleCompleteEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 param5;
		  
		  if (DAT_ram_00a608b8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__TryAppendGameOverToCombatEvents__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_GameOverData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_PlayerProfitData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_PlayerProfit_TypeInfo);
		    DAT_ram_00a608b8 = '\x01';
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
		             Method_Gameplay_Combat_Control_CombatController_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__TryAppendGameOverToCombatEvents__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A45")]
		[Address(RVA = "0x98A7", Offset = "0x98A7", VA = "0x98A7")]
		public void AppendGameOver()
		{
		/* --- GHIDRA: AppendGameOver ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentCombatController__AppendGameOver
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a608b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController___ctor__
		              );
		    DAT_ram_00a608b9 = '\x01';
		  }
		  HuaweiMobileServices_Base_OnSuccessListener___Il2CppFullySharedGenericType___onSuccess
		            (param1,param2,param3,param4,
		             Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0400287E RID: 10366
		[Token(Token = "0x400287E")]
		[FieldOffset(Offset = "0x20")]
		private BlitzTournamentService _blitzTournamentService;
	}
}
