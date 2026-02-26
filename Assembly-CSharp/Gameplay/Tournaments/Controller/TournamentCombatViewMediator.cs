using System;
using Gameplay.Combat.Control;
using Gameplay.Combat.View;
using Gameplay.Tournaments.Events;
using Gameplay.Tournaments.Model;
using Il2CppDummyDll;
using Protocol.Tournaments;

namespace Gameplay.Tournaments.Controller
{
	// Token: 0x020004BD RID: 1213
	[Token(Token = "0x20004BD")]
	public class TournamentCombatViewMediator : OneOnOneCombatViewMediator<TournamentCombatModel, TournamentCombatEvents, TournamentCombatController>
	{
		// Token: 0x06001CAF RID: 7343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAF")]
		[Address(RVA = "0x6E2E", Offset = "0x6E2E", VA = "0x6E2E")]
		public TournamentCombatViewMediator(TournamentCombatModel model, TournamentCombatEvents events, TournamentCombatController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tournaments_Controller_TournamentCombatViewMediator___ctor
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  longlong lVar4;
		  undefined4 uVar5;
		  longlong lVar6;
		  
		  if (DAT_ram_00a5851e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__OneOnOneCombatView__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentCombatViewMediator_CloseButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Tournaments_View_TournamentCombatView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5851e = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (piVar3 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar3 + 0xb8) <
		           (uint)*(byte *)(Gameplay_Tournaments_View_TournamentCombatView_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar3 + 100) +
		                   (uint)*(byte *)(Gameplay_Tournaments_View_TournamentCombatView_TypeInfo + 0xb8) *
		                   4 + -4) != Gameplay_Tournaments_View_TournamentCombatView_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (piVar3,Gameplay_Tournaments_View_TournamentCombatView_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    uVar5 = *(undefined4 *)(piVar3[0x1d] + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentCombatViewMediator_CloseButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar5,uVar1,0);
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_Events
		            (param1,param2,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__OneOnOneCombatView__set_View__
		            );
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (piVar3 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar3 + 0xb8) <
		           (uint)*(byte *)(Gameplay_Tournaments_View_TournamentCombatView_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar3 + 100) +
		                   (uint)*(byte *)(Gameplay_Tournaments_View_TournamentCombatView_TypeInfo + 0xb8) *
		                   4 + -4) != Gameplay_Tournaments_View_TournamentCombatView_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (piVar3,Gameplay_Tournaments_View_TournamentCombatView_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    uVar5 = *(undefined4 *)(piVar3[0x1d] + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentCombatViewMediator_CloseButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar1,0);
		    iVar2 = piVar3[0x1c];
		    lVar6 = *(longlong *)(param1[2] + 0x60);
		    lVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(param1[2] + 8),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (iVar2,(uint)(lVar6 == lVar4),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700052D RID: 1325
		// (set) Token: 0x06001CB0 RID: 7344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052D")]
		public override OneOnOneCombatView View
		{
			[Token(Token = "0x6001CB0")]
			[Address(RVA = "0x6E2F", Offset = "0x6E2F", VA = "0x6E2F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB1")]
		[Address(RVA = "0x6E30", Offset = "0x6E30", VA = "0x6E30")]
		private void CloseButtonClickedEventHandler()
		{
		/* --- GHIDRA: CloseButtonClickedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentCombatViewMediator__CloseButtonClickedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a5851f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__OneOnOneCombatView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentCombatViewMediator_CurrentBattleCompletedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentCombatViewMediator_FinalBattleCompletedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentCombatViewMediator_ReturnToTournament__
		              );
		    DAT_ram_00a5851f = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x74);
		    uVar2 = unnamed_function_1417(System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentCombatViewMediator_CurrentBattleCompletedEventHandler__
		               ,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x74) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x74) = iVar4;
		      uVar2 = System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x70);
		    uVar2 = unnamed_function_1417(System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentCombatViewMediator_FinalBattleCompletedEventHandler__
		               ,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x70) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x70) = iVar4;
		      uVar2 = System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x78);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentCombatViewMediator_ReturnToTournament__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x78) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x78) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___ValidateUserBalance
		            (param1,param2,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__OneOnOneCombatView__set_Events__
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x74);
		    uVar2 = unnamed_function_1417(System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentCombatViewMediator_CurrentBattleCompletedEventHandler__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x74) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x74) = iVar4;
		      uVar2 = System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x70);
		    uVar2 = unnamed_function_1417(System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentCombatViewMediator_FinalBattleCompletedEventHandler__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x70) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x70) = iVar4;
		      uVar2 = System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x78);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentCombatViewMediator_ReturnToTournament__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x78) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar5) || (*(int **)(iVar3 + 0x78) = piVar5, *piVar5 != iVar1))
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

		// Token: 0x1700052E RID: 1326
		// (set) Token: 0x06001CB2 RID: 7346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052E")]
		public override TournamentCombatEvents Events
		{
			[Token(Token = "0x6001CB2")]
			[Address(RVA = "0x6E31", Offset = "0x6E31", VA = "0x6E31", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB3")]
		[Address(RVA = "0x6E32", Offset = "0x6E32", VA = "0x6E32")]
		private void FinalBattleCompletedEventHandler(ProtoFinalTnmCombatCompleteEvt evt)
		{
		/* --- GHIDRA: FinalBattleCompletedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentCombatViewMediator__FinalBattleCompletedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  longlong lVar3;
		  longlong lVar4;
		  
		  if (DAT_ram_00a58520 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentCombatViewMediator_ReturnToTournament__
		              );
		    DAT_ram_00a58520 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar1 != 0) {
		    lVar4 = *(longlong *)(param2 + 0x18);
		    iVar1 = *(int *)param1[2];
		    uVar2 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x100) * 4))
		                      ((int *)param1[2],*(undefined4 *)(iVar1 + 0x104));
		    lVar3 = Core_Data_UserData__get_UserId(uVar2,0);
		    if (lVar4 != lVar3) {
		      lVar4 = *(longlong *)(param2 + 0x10);
		      iVar1 = *(int *)param1[2];
		      uVar2 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x100) * 4))
		                        ((int *)param1[2],*(undefined4 *)(iVar1 + 0x104));
		      lVar3 = Core_Data_UserData__get_UserId(uVar2,0);
		      if (lVar4 != lVar3) {
		        return;
		      }
		    }
		    param1[0xe] = param2;
		    iVar1 = param1[10];
		    if (0 < *(int *)(iVar1 + 8)) {
		      uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar2,param1,
		                 Method_Gameplay_Tournaments_Controller_TournamentCombatViewMediator_ReturnToTournament__
		                 ,0);
		      Gameplay_Combat_View_Animations_CombatAnimationCounter__remove__completeEvent(iVar1,uVar2,0);
		      return;
		    }
		    Gameplay_Tournaments_Controller_TournamentCombatViewMediator__CurrentBattleCompletedEventHandler
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB4")]
		[Address(RVA = "0x6E33", Offset = "0x6E33", VA = "0x6E33")]
		private void CurrentBattleCompletedEventHandler(ProtoCurrentTnmCombatCompleteEvt evt)
		{
		/* --- GHIDRA: CurrentBattleCompletedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentCombatViewMediator__CurrentBattleCompletedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a58521 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentCombatViewMediator_ReturnToTournament__
		              );
		    DAT_ram_00a58521 = '\x01';
		  }
		  param1_00 = param1[10];
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Tournaments_Controller_TournamentCombatViewMediator_ReturnToTournament__
		             ,0);
		  Gameplay_Combat_View_Animations_CombatAnimationCounter__add_CompleteEvent(param1_00,uVar1,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Tournaments_Controller_TournamentCombatController__IsOtherPlayer(uVar1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB5")]
		[Address(RVA = "0x6E34", Offset = "0x6E34", VA = "0x6E34")]
		public void ReturnToTournament()
		{
		/* --- GHIDRA: ReturnToTournament ---
		void Gameplay_Tournaments_Controller_TournamentCombatViewMediator__ReturnToTournament
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  undefined8 uVar5;
		  int *piVar6;
		  undefined4 param2_00;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a58522 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__TryOpenBuildingByType__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58522 = '\x01';
		  }
		  uVar5 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar5);
		  uVar7 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  Gameplay_Combat_View_PlayerChatBubble__AddText(*(undefined4 *)(iVar2 + 100),0);
		  uVar5 = CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar5);
		  uVar7 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  Gameplay_Combat_View_PlayerChatBubble__AddText(*(undefined4 *)(iVar2 + 0x68),0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x140);
		        goto code_r0x80eff5c3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80eff5c3:
		  uVar1 = 0;
		  uVar5 = CONCAT44(uVar7,puVar3[1]);
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,uVar5);
		  uVar7 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  uVar4 = func_ii_7112(uVar4,0);
		  param2_00 = *(undefined4 *)(param1[2] + 0x50);
		  piVar6 = *(int **)(*(int *)(param1[2] + 0x3c) + 0x14);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd8);
		        goto code_r0x80eff65d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Gameplay_Combat_ICombat_TypeInfo,3);
		code_r0x80eff65d:
		  uVar5 = CONCAT44(uVar7,puVar3[1]);
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar6,uVar5);
		  uVar7 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  uVar1 = 0;
		  piVar6 = *(int **)(*(int *)(param1[2] + 0x3c) + 0x14);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80eff6e6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x80eff6e6:
		  uVar5 = CONCAT44(uVar7,puVar3[1]);
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar6,uVar5);
		  uVar7 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  DefaultNamespace_SceneAppManager__RemoveScene(param1_00,param2_00,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x110);
		        goto code_r0x80eff79e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80eff79e:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,CONCAT44(uVar7,puVar3[1]));
		  uVar7 = *(undefined4 *)(iVar2 + 0x14);
		  uVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(uVar4,0);
		  uVar4 = Gameplay_World_Model_WorldModel__set_IsMovingOnWorldLevel(uVar7,uVar5,0);
		  uVar7 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  Gameplay_Isles_Base_AbstractIsle_object__object__object__Int32Enum___SetIsCurrentIsle
		            (uVar4,2,
		             Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__TryOpenBuildingByType__
		            );
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x1c8);
		        goto code_r0x80eff868;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x21);
		code_r0x80eff868:
		  uVar5 = CONCAT44(uVar7,puVar3[1]);
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,uVar5);
		  uVar7 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  Core_Gameplay_Managers_TournamentsManager__Init(uVar4,0);
		  if ((char)param1[0xd] != '\0') {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x1c8);
		          goto code_r0x80eff920;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x21);
		code_r0x80eff920:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,CONCAT44(uVar7,puVar3[1]));
		    Gameplay_Tournaments_Controller_TournamentsController__WatchCombat
		              (*(undefined4 *)(iVar2 + 0x18),*(undefined4 *)(param1[0xe] + 0xc),puVar3);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB6")]
		[Address(RVA = "0x6E35", Offset = "0x6E35", VA = "0x6E35", Slot = "37")]
		protected override void HandleGameOver()
		{
		/* --- GHIDRA: HandleGameOver ---
		void Gameplay_Tournaments_Controller_TournamentCombatViewMediator__HandleGameOver
		               (int *param1,undefined4 param2)
		
		{
		  uint param2_00;
		  int iVar1;
		  longlong lVar2;
		  undefined4 param1_00;
		  longlong lVar3;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a58523 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__OneOnOneCombatView__get_Model__
		              );
		    DAT_ram_00a58523 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x14);
		  lVar3 = *(longlong *)(param1[2] + 0x60);
		  lVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(param1[2] + 8),0);
		  if (((lVar3 != lVar2) &&
		      (iVar1 = Gameplay_Combat_Model_CombatModel__GetTurnState(param1[2],0), param2_00 = 0,
		      iVar1 != 0)) && (*(int *)(param1[2] + 0x28) == 0)) {
		    param2_00 = (uint)(*(int *)(param1[2] + 0x10) == 0);
		  }
		  func_ii_14245(param1_00,param2_00,0);
		  lVar3 = *(longlong *)(param1[2] + 0x60);
		  lVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(param1[2] + 8),0);
		  if (lVar3 == lVar2) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Combat_View_GameField_GameFieldMono__get_FieldBlackoutVisible
		              (*(undefined4 *)(iVar1 + 0x14),0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB7")]
		[Address(RVA = "0x6E36", Offset = "0x6E36", VA = "0x6E36", Slot = "34")]
		protected override void HandleFieldInteraction()
		{
		/* --- GHIDRA: HandleFieldInteraction ---
		void Gameplay_Tournaments_Controller_TournamentCombatViewMediator__HandleFieldInteraction
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58524 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentHistoryWindow___ctor__
		              );
		    DAT_ram_00a58524 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentHistoryWindow___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04000FAC RID: 4012
		[Token(Token = "0x4000FAC")]
		[FieldOffset(Offset = "0x34")]
		private bool _isFinalCombat;

		// Token: 0x04000FAD RID: 4013
		[Token(Token = "0x4000FAD")]
		[FieldOffset(Offset = "0x38")]
		private ProtoCurrentTnmCombatCompleteEvt _completeEvent;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Tournaments_Controller_TournamentCombatViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Tournaments_Controller_TournamentCombatController__AppendGameOver(param1_00,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Tournaments_Controller_TournamentCombatViewMediator__set_Events
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined1 *)(param1 + 0x34) = 1;
		  return;
		}
		*/

}
