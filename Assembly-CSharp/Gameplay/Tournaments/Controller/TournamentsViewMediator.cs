using System;
using Core.Data.Tournaments;
using Gameplay.BlitzTournament.View;
using Gameplay.Tournaments.Events;
using Gameplay.Tournaments.Model;
using Gameplay.Tournaments.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Tournaments;

namespace Gameplay.Tournaments.Controller
{
	// Token: 0x020004CB RID: 1227
	[Token(Token = "0x20004CB")]
	public class TournamentsViewMediator : AbstractViewMediator<TournamentsModel, TournamentsEvents, TournamentsController, TournamentsWindow>
	{
		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001D19 RID: 7449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000535")]
		private TournamentProgressWindow TournamentProgressWindow
		{
			[Token(Token = "0x6001D18")]
			[Address(RVA = "0x6E97", Offset = "0x6E97", VA = "0x6E97")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D19")]
			[Address(RVA = "0x6E98", Offset = "0x6E98", VA = "0x6E98")]
			set
			{
			}
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1A")]
		[Address(RVA = "0x6E99", Offset = "0x6E99", VA = "0x6E99")]
		public TournamentsViewMediator(TournamentsModel model, TournamentsEvents events, TournamentsController controller)
		{
		/* --- GHIDRA: <TournamentListRequestedEventHandler>b__30_0 ---
		uint Gameplay_Tournaments_Controller_TournamentsViewMediator___TournamentListRequestedEventHandler_b__30_0
		               (int param1,int param2,undefined4 param3)
		
		{
		  longlong lVar1;
		  longlong lVar2;
		  
		  if (DAT_ram_00a5857d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentsWindow__get_Model__
		              );
		    DAT_ram_00a5857d = '\x01';
		  }
		  lVar2 = *(longlong *)(*(int *)(param2 + 0xc) + 0x10);
		  lVar1 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		  return (uint)(lVar2 == lVar1);
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Tournaments_Controller_TournamentsViewMediator__get_TournamentProgressWindow
		            (param1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1B")]
		[Address(RVA = "0x6E9A", Offset = "0x6E9A", VA = "0x6E9A")]
		private void ProgressWindowClosedEventHandler()
		{
		/* --- GHIDRA: ProgressWindowClosedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__ProgressWindowClosedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58565 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentsWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ResourceSet__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_BetAddedButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_HistoryButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_InTournamentButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_QuitButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_RulesButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58565 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x48) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_RulesButtonClickHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x50) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_HistoryButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x54) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_InTournamentButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x58) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_QuitButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x4c) + 0x38);
		    uVar1 = unnamed_function_1417(System_Action_ResourceSet__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_BetAddedButtonClickedEventHandler__
		               ,0);
		    Gameplay_Tournaments_View_BetControlView__add_BetAddedEvent(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x48) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_RulesButtonClickHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x50) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_HistoryButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x54) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_InTournamentButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x58) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_QuitButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x4c) + 0x38);
		    uVar1 = unnamed_function_1417(System_Action_ResourceSet__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_BetAddedButtonClickedEventHandler__
		               ,0);
		    Gameplay_Tournaments_View_BetControlView__get_PlayerStatus(uVar3,uVar1,0);
		    Gameplay_Tournaments_Controller_TournamentsViewMediator__set_Controller(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000536 RID: 1334
		// (set) Token: 0x06001D1C RID: 7452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000536")]
		public override TournamentsWindow View
		{
			[Token(Token = "0x6001D1C")]
			[Address(RVA = "0x6E9B", Offset = "0x6E9B", VA = "0x6E9B", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000537 RID: 1335
		// (set) Token: 0x06001D1D RID: 7453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000537")]
		public override TournamentsEvents Events
		{
			[Token(Token = "0x6001D1D")]
			[Address(RVA = "0x6E9C", Offset = "0x6E9C", VA = "0x6E9C", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1E")]
		[Address(RVA = "0x6E9D", Offset = "0x6E9D", VA = "0x6E9D")]
		private void SubscribeToEvents()
		{
		/* --- GHIDRA: SubscribeToEvents ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__SubscribeToEvents
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58568 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBetChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoStateChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_BetChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_PlayerBetAddedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_StateChangedEventHandler__
		              );
		    DAT_ram_00a58568 = '\x01';
		  }
		  if ((char)param1[9] != '\0') {
		    *(undefined1 *)(param1 + 9) = 0;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_PlayerBetAddedEventHandler__
		               ,0);
		    param1_00 = (int *)func_ii_7048(uVar5,uVar2,0);
		    iVar3 = System_Action_TypeInfo;
		    if (param1_00 == (int *)0x0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *param1_00) ||
		            (*(int **)(iVar1 + 0x18) = param1_00, *param1_00 != iVar3)) {
		      System_Activator__CreateInstance(param1_00,iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar3 + 0x28);
		    uVar2 = unnamed_function_1417(System_Action_ProtoBetChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_BetChangedEventHandler__
		               ,0);
		    iVar1 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_ProtoBetChangedEvt__TypeInfo;
		    if (iVar1 == 0) {
		      *(undefined4 *)(iVar3 + 0x28) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar1,System_Action_ProtoBetChangedEvt__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar1,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar3 + 0x28) = iVar4;
		      uVar2 = System_Action_ProtoBetChangedEvt__TypeInfo;
		      iVar3 = func_ii_1082(iVar1,System_Action_ProtoBetChangedEvt__TypeInfo);
		      if (iVar3 == 0) {
		        System_Activator__CreateInstance(iVar1,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar3 + 0x34);
		    uVar2 = unnamed_function_1417(System_Action_ProtoStateChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_StateChangedEventHandler__
		               ,0);
		    iVar1 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_ProtoStateChangedEvt__TypeInfo;
		    if (iVar1 == 0) {
		      *(undefined4 *)(iVar3 + 0x34) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar1,System_Action_ProtoStateChangedEvt__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar3 + 0x34) = iVar4;
		    uVar2 = System_Action_ProtoStateChangedEvt__TypeInfo;
		    iVar3 = func_ii_1082(iVar1,System_Action_ProtoStateChangedEvt__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1F")]
		[Address(RVA = "0x6E9E", Offset = "0x6E9E", VA = "0x6E9E")]
		private void UnsubscribeFromEvents()
		{
		/* --- GHIDRA: UnsubscribeFromEvents ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__UnsubscribeFromEvents
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58569 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentsWindow__set_Controller__
		              );
		    DAT_ram_00a58569 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (iVar1 != 0) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    Gameplay_Tournaments_Controller_TournamentsController__SubscribeResultHandler(uVar2,0);
		  }
		  param1[4] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (iVar1 != 0) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    Gameplay_Tournaments_Controller_TournamentsController__LeaveTournamentResultHandler(uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000538 RID: 1336
		// (set) Token: 0x06001D20 RID: 7456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000538")]
		public override TournamentsController Controller
		{
			[Token(Token = "0x6001D20")]
			[Address(RVA = "0x6E9F", Offset = "0x6E9F", VA = "0x6E9F", Slot = "18")]
			set
			{
			}
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D21")]
		[Address(RVA = "0x6EA0", Offset = "0x6EA0", VA = "0x6EA0")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__Init(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5856b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_View_TournamentListElementBase_TournamentData__get_TournamentData__
		              );
		    DAT_ram_00a5856b = '\x01';
		  }
		  Gameplay_Tournaments_Controller_TournamentsViewMediator__DetermineIfPlayerCanLeave
		            (param1,*(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 0x18) + 0x2c) + 8) + 0xc),
		             param1);
		  return;
		}
		*/

		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D22")]
		[Address(RVA = "0x6EA1", Offset = "0x6EA1", VA = "0x6EA1")]
		private void InTournamentButtonClickedEventHandler()
		{
		/* --- GHIDRA: InTournamentButtonClickedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__InTournamentButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Tournaments_Controller_TournamentsController__GetTournamentHistoryResultHandler(uVar1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x54),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x58),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D23")]
		[Address(RVA = "0x6EA2", Offset = "0x6EA2", VA = "0x6EA2")]
		private void QuitButtonClickedEventHandler()
		{
		/* --- GHIDRA: QuitButtonClickedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__QuitButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5856c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentsWindow__get_Model__
		              );
		    DAT_ram_00a5856c = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x50),0,0);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Tournaments_Controller_TournamentsController__WatchCombat
		            (param1_00,*(undefined4 *)(param1[2] + 0x20),0);
		  return;
		}
		*/

		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D24")]
		[Address(RVA = "0x6EA3", Offset = "0x6EA3", VA = "0x6EA3")]
		private void HistoryButtonClickedEventHandler()
		{
		/* --- GHIDRA: HistoryButtonClickedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__HistoryButtonClickedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_01;
		  int iVar5;
		  longlong lVar6;
		  int local_4;
		  
		  if (DAT_ram_00a5856d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_View_TournamentListElementBase_TournamentData__get_TournamentData__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_25416);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27809);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15157);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2593);
		    DAT_ram_00a5856d = '\x01';
		  }
		  uVar1 = Gameplay_Tournaments_Model_TournamentCombatModel___ctor(param1[2],0);
		  local_4 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar1,StringLiteral_27809,0);
		  lVar6 = (longlong)local_4;
		  uVar2 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(param1[2] + 8),0);
		  if ((longlong)(ulonglong)uVar2 < lVar6) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15157,1,0,1,0,0,0,0);
		    param1_00 = unnamed_function_1417
		                          (System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    param3_00 = func_ii_4443(&local_4,0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (param1_00,StringLiteral_25416,param3_00,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    uVar4 = Core_GameLocalization__GetTranslation(uVar4,param1_00,0);
		    Core_Application_App__get_ToastController(uVar1,6,uVar4,0);
		  }
		  else {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *param1_01;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0x110);
		          goto code_r0x80f06b7a;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f06b7a:
		    iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		    iVar5 = Gameplay_Isles_Base_Model_BaseIsleModel__set_IsCurrentIsle
		                      (*(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x14) + 0x20) + 0x10),2,0);
		    if (iVar5 == 0) {
		      uVar1 = System_Uri___ctor(0);
		      uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2593,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar1,6,uVar4,0);
		    }
		    else {
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		      Gameplay_Tournaments_Controller_TournamentsController__GetTournamentListResultHandler
		                (uVar1,*(undefined4 *)(*(int *)(*(int *)(param1[6] + 0x2c) + 8) + 0xc),param2,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D25")]
		[Address(RVA = "0x6EA4", Offset = "0x6EA4", VA = "0x6EA4")]
		private void BetAddedButtonClickedEventHandler(ResourceSet bet)
		{
		/* --- GHIDRA: BetAddedButtonClickedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__BetAddedButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5856e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_19433);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27811);
		    DAT_ram_00a5856e = '\x01';
		  }
		  uVar1 = Gameplay_Tournaments_Model_TournamentCombatModel___ctor(*(undefined4 *)(param1 + 8),0);
		  uVar1 = Core_Extensions_Dict_DictExt__GetResourceSetParameter(uVar1,StringLiteral_27811,0);
		  Core_ExternAppMethods__OpenPaymentWindow(uVar1,StringLiteral_19433,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D26")]
		[Address(RVA = "0x6EA5", Offset = "0x6EA5", VA = "0x6EA5")]
		private void RulesButtonClickHandler()
		{
		/* --- GHIDRA: RulesButtonClickHandler ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__RulesButtonClickHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Tournaments_Controller_TournamentsViewMediator__TournamentSelectedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D27")]
		[Address(RVA = "0x6EA6", Offset = "0x6EA6", VA = "0x6EA6")]
		private void UIBlockedChangedEventHandler(bool block)
		{
		/* --- GHIDRA: UIBlockedChangedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__UIBlockedChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5856f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_TournamentHistoryWindow___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Tournaments_View_TournamentHistoryWindow_TournamentHistoryWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_12673);
		    DAT_ram_00a5856f = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x50),1,0);
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Tournaments_View_TournamentHistoryWindow_TournamentHistoryWindowArgs_TypeInfo
		                    );
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar1,0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  *(undefined4 *)(iVar1 + 0x18) = uVar3;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar2,StringLiteral_12673,iVar1,
		             Method_UI_Windows_PopupController_Show_TournamentHistoryWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D28")]
		[Address(RVA = "0x6EA7", Offset = "0x6EA7", VA = "0x6EA7")]
		private void HistoryRequestedEventHandler()
		{
		/* --- GHIDRA: HistoryRequestedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__HistoryRequestedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  undefined4 param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58570 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_TournamentListElement___);
		    Mono_Security_ASN1__get_Item(&System_Func_TournamentListElement__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_View_TournamentListElementBase_TournamentData__get_TournamentData__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator___c__DisplayClass27_0__StateChangedEventHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Tournaments_Controller_TournamentsViewMediator___c__DisplayClass27_0_TypeInfo
		              );
		    DAT_ram_00a58570 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Tournaments_Controller_TournamentsViewMediator___c__DisplayClass27_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 8) = param2;
		  iVar3 = param1[7];
		  uVar1 = unnamed_function_1417(System_Func_TournamentListElement__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Gameplay_Tournaments_Controller_TournamentsViewMediator___c__DisplayClass27_0__StateChangedEventHandler_b__0__
		             ,0);
		  piVar2 = (int *)System_Func_object__bool____ctor
		                            (iVar3,uVar1,
		                             Method_System_Linq_Enumerable_FirstOrDefault_TournamentListElement___);
		  if (piVar2 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x108) * 4))
		              (piVar2,*(undefined4 *)(*piVar2 + 0x10c));
		  }
		  iVar3 = *(int *)(param1[6] + 0x2c);
		  if (*(int *)(*(int *)(iVar3 + 8) + 0xc) == *(int *)(*(int *)(param2_00 + 8) + 0xc)) {
		    uVar1 = *(undefined4 *)(*(int *)(*(int *)(param2_00 + 8) + 0x10) + 0xc);
		    if (DAT_ram_00a58577 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_UI_MonoBehaviourWithStates_TournamentInfoBox_State__set_CurrentState__);
		      DAT_ram_00a58577 = '\x01';
		    }
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(iVar4 + 0x4c),uVar1,
		               Method_UI_MonoBehaviourWithStates_TournamentInfoBox_State__set_CurrentState__);
		    Gameplay_Tournaments_Controller_TournamentsViewMediator__OpenTournamentProgressWindow
		              (param1,iVar3,param1);
		    Gameplay_Tournaments_Controller_TournamentsViewMediator__ResolveTournamentState
		              (param1,*(undefined4 *)(*(int *)(iVar3 + 0xc) + 0x14),param1);
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x4c) + 0x38) + 0x28);
		  iVar4 = param1[2];
		  uVar1 = *(undefined4 *)(*(int *)(param2_00 + 8) + 0xc);
		  iVar3 = Gameplay_Tournaments_Model_TournamentsModel__set_CurrentTournamentType(iVar4,0);
		  uVar1 = Gameplay_Tournaments_Model_TournamentsModel__PopulateHistory
		                    (iVar4,uVar1,*(undefined4 *)(*(int *)(iVar3 + 8) + 0x20),0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,uVar1,0);
		  Gameplay_Tournaments_Controller_TournamentsViewMediator__ResolveInfoBoxState
		            (param1,*(undefined4 *)(*(int *)(param2_00 + 8) + 0x10),
		             *(undefined4 *)(*(int *)(param2_00 + 8) + 0xc),param1);
		  return;
		}
		*/

		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D29")]
		[Address(RVA = "0x6EA8", Offset = "0x6EA8", VA = "0x6EA8")]
		private void StateChangedEventHandler(ProtoStateChangedEvt evt)
		{
		/* --- GHIDRA: StateChangedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__StateChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58571 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_View_TournamentListElementBase_TournamentData__get_TournamentData__
		              );
		    DAT_ram_00a58571 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x4c) + 0x38);
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(param1[6] + 0x2c) + 0xc) + 0x28);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		  Gameplay_Tournaments_View_BetControlView__UpdateGladiatorsBet(param1_00,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D2A")]
		[Address(RVA = "0x6EA9", Offset = "0x6EA9", VA = "0x6EA9")]
		private void PlayerBetAddedEventHandler()
		{
		/* --- GHIDRA: PlayerBetAddedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__PlayerBetAddedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58572 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_View_TournamentListElementBase_TournamentData__get_TournamentData__
		              );
		    DAT_ram_00a58572 = '\x01';
		  }
		  if (*(int *)(*(int *)(*(int *)(param1[6] + 0x2c) + 0xc) + 0xc) == *(int *)(param2 + 0xc)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x4c) + 0x38);
		    uVar3 = *(undefined4 *)(param2 + 0x10);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar3 = Core_Money_Money__op_Explicit(uVar3,0);
		    Gameplay_Tournaments_View_BetControlView__Init(uVar2,uVar3,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Tournaments_View_TournamentInfoBox__get_MultilineInfo
		              (*(undefined4 *)(iVar1 + 0x4c),*(undefined4 *)(param2 + 0x20),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x4c) + 0x30);
		    uVar2 = Core_Money_Money__op_Explicit(*(undefined4 *)(param2 + 0x24),0);
		    Gameplay_Tournaments_View_TournamentBank__RenderRewards(uVar3,uVar2,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x4c) + 0x38) + 0x28);
		    uVar2 = Gameplay_Tournaments_Model_TournamentsModel__PopulateHistory
		                      (param1[2],*(undefined4 *)(param2 + 0xc),*(undefined4 *)(param2 + 0x10),0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D2B")]
		[Address(RVA = "0x6EAA", Offset = "0x6EAA", VA = "0x6EAA")]
		private void BetChangedEventHandler(ProtoBetChangedEvt evt)
		{
		/* --- GHIDRA: BetChangedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__BetChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a58573 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TournamentListElementBase__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Values__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_TournamentListElement___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_TournamentData___);
		    Mono_Security_ASN1__get_Item(&System_Func_TournamentListElement__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_TournamentSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator__TournamentListRequestedEventHandler_b__30_0__
		              );
		    DAT_ram_00a58573 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1[2] + 0xc),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Values__
		                    );
		  uVar2 = func_ii_6295(uVar2,Method_System_Linq_Enumerable_ToArray_TournamentData___);
		  param1_00 = unnamed_function_1417(System_Action_TournamentListElementBase__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_TournamentSelectedEventHandler__
		             ,0);
		  iVar3 = Gameplay_Tournaments_View_TournamentsWindow__OnShow(uVar1,uVar2,param1_00,0);
		  param1[7] = iVar3;
		  if (*(int *)(param1[2] + 0x28) == 0) {
		    uVar1 = *(undefined4 *)(iVar3 + 0x10);
		  }
		  else {
		    iVar3 = Gameplay_Tournaments_Model_TournamentsModel__set_CurrentTournamentType(param1[2],0);
		    Gameplay_Tournaments_Controller_TournamentsViewMediator__ResolveInfoBoxState
		              (param1,*(undefined4 *)(*(int *)(iVar3 + 0xc) + 0x14),
		               *(undefined4 *)(param1[2] + 0x20),param1);
		    iVar3 = param1[7];
		    uVar1 = unnamed_function_1417(System_Func_TournamentListElement__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator__TournamentListRequestedEventHandler_b__30_0__
		               ,0);
		    uVar1 = func_ii_7423(iVar3,uVar1,Method_System_Linq_Enumerable_First_TournamentListElement___);
		  }
		  Gameplay_Tournaments_Controller_TournamentsViewMediator__BlockUIIfNeeded(param1,uVar1,param1);
		  Gameplay_Tournaments_Controller_TournamentsViewMediator__set_Events(param1,param1);
		  Gameplay_Tournaments_Controller_TournamentsViewMediator__TournamentSelectedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D2C")]
		[Address(RVA = "0x6EAB", Offset = "0x6EAB", VA = "0x6EAB")]
		private void TournamentListRequestedEventHandler()
		{
		/* --- GHIDRA: TournamentListRequestedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__TournamentListRequestedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a58574 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3614);
		    DAT_ram_00a58574 = '\x01';
		  }
		  if (*(char *)(*(int *)(param1 + 8) + 0x1c) != '\0') {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3614,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,6,param3_00,0);
		    return;
		  }
		  Gameplay_Tournaments_Controller_TournamentsViewMediator__BlockUIIfNeeded(param1,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D2D")]
		[Address(RVA = "0x6EAC", Offset = "0x6EAC", VA = "0x6EAC")]
		private void TournamentSelectedEventHandler(TournamentListElementBase listElement)
		{
		/* --- GHIDRA: TournamentSelectedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__TournamentSelectedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint param2_00;
		  
		  if (DAT_ram_00a58575 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_TournamentsWindow_TournamentsWindowArgs__get_BackButton__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_WindowWhitCloseButton_TournamentsWindow_TournamentsWindowArgs__get_CloseButton__
		              );
		    DAT_ram_00a58575 = '\x01';
		  }
		  if (*(char *)(param1[2] + 0x1c) == '\0') {
		    param2_00 = 1;
		  }
		  else {
		    iVar1 = Gameplay_Tournaments_Model_TournamentsModel__set_CurrentTournamentType(param1[2],0);
		    param2_00 = (uint)(*(int *)(*(int *)(*(int *)(iVar1 + 0xc) + 0x14) + 0xc) != 1);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  *(char *)(iVar1 + 0x5c) = (char)param2_00;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x34),param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x38),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D2E")]
		[Address(RVA = "0x6EAD", Offset = "0x6EAD", VA = "0x6EAD")]
		private void BlockUIIfNeeded()
		{
		/* --- GHIDRA: BlockUIIfNeeded ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__BlockUIIfNeeded
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param2_00;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58576 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_View_TournamentListElementBase_TournamentData__SetSelected__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_View_TournamentListElementBase_TournamentData__get_TournamentData__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Tournaments_View_TournamentListElement_TypeInfo);
		    DAT_ram_00a58576 = '\x01';
		  }
		  if (param1[6] != 0) {
		    Gameplay_BlitzTournament_View_TournamentListElementBase_object___Init
		              (param1[6],0,
		               Method_Gameplay_BlitzTournament_View_TournamentListElementBase_TournamentData__SetSelected__
		              );
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Tournaments_View_TournamentListElement_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(Gameplay_Tournaments_View_TournamentListElement_TypeInfo + 0xb8) *
		                 4 + -4) != Gameplay_Tournaments_View_TournamentListElement_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param2,Gameplay_Tournaments_View_TournamentListElement_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param2_00 = param2[0xb];
		  Gameplay_BlitzTournament_View_TournamentListElementBase_object___Init
		            (param2,1,
		             Method_Gameplay_BlitzTournament_View_TournamentListElementBase_TournamentData__SetSelected__
		            );
		  param1[6] = (int)param2;
		  *(undefined4 *)(param1[2] + 0x20) = *(undefined4 *)(*(int *)(param2_00 + 8) + 0xc);
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(param2_00 + 0xc) + 0x14) + 0xc);
		  if (DAT_ram_00a58577 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_TournamentInfoBox_State__set_CurrentState__);
		    DAT_ram_00a58577 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x4c),uVar2,
		             Method_UI_MonoBehaviourWithStates_TournamentInfoBox_State__set_CurrentState__);
		  Gameplay_Tournaments_Controller_TournamentsViewMediator__OpenTournamentProgressWindow
		            (param1,param2_00,param1);
		  Gameplay_Tournaments_Controller_TournamentsViewMediator__ResolveTournamentState
		            (param1,*(undefined4 *)(*(int *)(param2_00 + 0xc) + 0x14),param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x4c) + 0x38) + 0x28);
		  uVar2 = Gameplay_Tournaments_Model_TournamentsModel__PopulateHistory
		                    (param1[2],*(undefined4 *)(*(int *)(param2_00 + 8) + 0xc),
		                     *(undefined4 *)(*(int *)(param2_00 + 8) + 0x20),0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D2F")]
		[Address(RVA = "0x6EAE", Offset = "0x6EAE", VA = "0x6EAE")]
		private void SelectListElement(TournamentListElementBase listElement)
		{
		/* --- GHIDRA: SelectListElement ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__SelectListElement
		               (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58577 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_TournamentInfoBox_State__set_CurrentState__);
		    DAT_ram_00a58577 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x4c),param2,
		             Method_UI_MonoBehaviourWithStates_TournamentInfoBox_State__set_CurrentState__);
		  Gameplay_Tournaments_Controller_TournamentsViewMediator__OpenTournamentProgressWindow
		            (param1,param3,param1);
		  Gameplay_Tournaments_Controller_TournamentsViewMediator__ResolveTournamentState
		            (param1,*(undefined4 *)(*(int *)(param3 + 0xc) + 0x14),param1);
		  return;
		}
		*/

		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D30")]
		[Address(RVA = "0x6EAF", Offset = "0x6EAF", VA = "0x6EAF")]
		private void ResolveInfoBoxState(TournamentInfoBox.State state, TournamentData data)
		{
		/* --- GHIDRA: ResolveInfoBoxState ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__ResolveInfoBoxState
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58578 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58578 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x20);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,0,0);
		  if ((((iVar1 == 0) && (*(int *)(param2 + 0x30) != 0)) && (*(int *)(param2 + 0xc) != 1)) &&
		     ((iVar1 = Gameplay_Tournaments_Controller_TournamentsViewMediator__ResolveTournamentState
		                         (param1,param2,param1), iVar1 == 0 && (*(int *)(param2 + 0xc) - 2U < 3))))
		  {
		    Gameplay_Tournaments_Controller_TournamentsViewMediator__DetermineIfPlayerCanLeave
		              (param1,param3,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D31")]
		[Address(RVA = "0x6EB0", Offset = "0x6EB0", VA = "0x6EB0")]
		private void ResolveTournamentState(StateInfo stateInfo, uint tournamentTypeId)
		{
		/* --- GHIDRA: ResolveTournamentState ---
		uint Gameplay_Tournaments_Controller_TournamentsViewMediator__ResolveTournamentState
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint param2_00;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a58579 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_Fighter___);
		    Mono_Security_ASN1__get_Item(&System_Func_Fighter__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator__DetermineIfPlayerCanLeave_b__36_0__
		              );
		    DAT_ram_00a58579 = '\x01';
		  }
		  if (*(int *)(param2 + 0xc) != 2) {
		    if (*(int *)(param2 + 0x30) == 2) {
		      param1_00 = *(undefined4 *)(param2 + 0x2c);
		      uVar3 = unnamed_function_1417(System_Func_Fighter__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (uVar3,param1,
		                 Method_Gameplay_Tournaments_Controller_TournamentsViewMediator__DetermineIfPlayerCanLeave_b__36_0__
		                 ,0);
		      iVar2 = func_ii_7423(param1_00,uVar3,Method_System_Linq_Enumerable_First_Fighter___);
		      *(undefined1 *)(iVar2 + 0x28) = 1;
		      bVar1 = *(int *)(iVar2 + 0x1c) != 0;
		    }
		    else {
		      bVar1 = *(int *)(param2 + 0x30) == 1;
		    }
		    param2_00 = (uint)bVar1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x58),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,param2_00,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x54),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,param2_00,0);
		  }
		  return param2_00;
		}
		*/

		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x00006180 File Offset: 0x00004380
		[Token(Token = "0x6001D32")]
		[Address(RVA = "0x6EB1", Offset = "0x6EB1", VA = "0x6EB1")]
		private bool DetermineIfPlayerCanLeave(StateInfo stateInfo)
		{
		/* --- GHIDRA: DetermineIfPlayerCanLeave ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__DetermineIfPlayerCanLeave
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5857a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_TournamentProgressWindow___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Tournaments_View_TournamentProgressWindow_TournamentProgressWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_12674);
		    DAT_ram_00a5857a = '\x01';
		  }
		  *(undefined4 *)(param1[2] + 0x20) = param2;
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Tournaments_View_TournamentProgressWindow_TournamentProgressWindowArgs_TypeInfo
		                        );
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12674,param1_00,
		                     Method_UI_Windows_PopupController_Show_TournamentProgressWindow___);
		  Gameplay_Tournaments_Controller_TournamentsViewMediator__get_TournamentProgressWindow
		            (param1,uVar1,param1);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D33")]
		[Address(RVA = "0x6EB2", Offset = "0x6EB2", VA = "0x6EB2")]
		private void OpenTournamentProgressWindow(uint tournamentTypeId)
		{
		/* --- GHIDRA: OpenTournamentProgressWindow ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__OpenTournamentProgressWindow
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a5857b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a5857b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(iVar1 + 0x4c);
		  uVar5 = *(undefined4 *)(iVar1 + 0x38);
		  uVar6 = *(undefined4 *)(*(int *)(param2 + 0xc) + 0x18);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar6 = Core_Money_Money__op_Explicit(uVar6,0);
		  uVar2 = Core_Money_Money__op_Explicit(*(undefined4 *)(*(int *)(param2 + 8) + 0x20),0);
		  uVar3 = Core_Money_Money__op_Explicit(*(undefined4 *)(*(int *)(param2 + 0xc) + 0x28),0);
		  Gameplay_Tournaments_View_BetControlView__SetNewPrice(uVar5,uVar6,uVar2,uVar3,0);
		  uVar6 = *(undefined4 *)(iVar1 + 0x24);
		  uVar5 = Core_Data_Tournaments_TournamentData__Create(param2,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar6,uVar5,0);
		  uVar6 = *(undefined4 *)(iVar1 + 0x1c);
		  uVar5 = Core_Extensions_Dict_ThemeRatingKindDicExt__GetDescription(*(undefined4 *)(param2 + 8),0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar6,uVar5,0);
		  uVar6 = *(undefined4 *)(iVar1 + 0x38);
		  uVar5 = Core_Money_Money__op_Explicit(*(undefined4 *)(*(int *)(param2 + 0xc) + 0x18),0);
		  Gameplay_Tournaments_View_BetControlView__Init(uVar6,uVar5,0);
		  if (*(int *)(param2 + 0x10) == 0) {
		    uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar1 + 0x2c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar5,0,0);
		  }
		  else {
		    Gameplay_Tournaments_View_TournamentsWindow_TournamentsWindowArgs___ctor
		              (*(undefined4 *)(iVar1 + 0x2c),*(int *)(param2 + 0x10),0);
		  }
		  uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x2c),0);
		  iVar4 = func_ii_7305(uVar5,0);
		  if (iVar4 != 0) {
		    uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar1 + 0x24),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar5,0,0);
		  }
		  Gameplay_Tournaments_View_TournamentInfoBox__get_MultilineInfo
		            (iVar1,*(undefined4 *)(*(int *)(param2 + 0xc) + 0x10),0);
		  uVar5 = *(undefined4 *)(param2 + 0x14);
		  uVar6 = *(undefined4 *)(iVar1 + 0x30);
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0xc) + 0x14) + 0x24);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		  uVar3 = Core_Money_Money__op_Explicit
		                    (*(undefined4 *)(*(int *)(*(int *)(param2 + 0xc) + 0x14) + 0x28),0);
		  Gameplay_Tournaments_View_TournamentBank__Start
		            (uVar6,uVar5,uVar2,uVar3,*(undefined4 *)(param2 + 0x18),0);
		  uVar6 = *(undefined4 *)(iVar1 + 0x20);
		  uVar5 = Core_Extensions_Dict_TournamentDicExt__GetTitle(*(undefined4 *)(param2 + 8),0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar6,uVar5,0);
		  return;
		}
		*/

		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D34")]
		[Address(RVA = "0x6EB3", Offset = "0x6EB3", VA = "0x6EB3")]
		private void UpdateInfoBox(TournamentData data)
		{
		/* --- GHIDRA: UpdateInfoBox ---
		uint Gameplay_Tournaments_Controller_TournamentsViewMediator__UpdateInfoBox
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5857c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_View_TournamentListElementBase_TournamentData__get_TournamentData__
		              );
		    DAT_ram_00a5857c = '\x01';
		  }
		  return (uint)(*(int *)(*(int *)(*(int *)(param2 + 0x2c) + 8) + 0xc) ==
		               *(int *)(*(int *)(param1 + 8) + 0x20));
		}
		*/

		}

		// Token: 0x04000FDA RID: 4058
		[Token(Token = "0x4000FDA")]
		private const string LOCALIZATION_LEAVE_QUEUE_FIRST = "BLITZ/LEAVE_QUEUE_FIRST";

		// Token: 0x04000FDB RID: 4059
		[Token(Token = "0x4000FDB")]
		private const string LOCALIZATION_MIN_LEVEL_REQUIREMENT = "TOURNAMENTS/MIN_LEVEL_REQUIREMENT";

		// Token: 0x04000FDC RID: 4060
		[Token(Token = "0x4000FDC")]
		[FieldOffset(Offset = "0x18")]
		private TournamentListElement _selectedTournament;

		// Token: 0x04000FDD RID: 4061
		[Token(Token = "0x4000FDD")]
		[FieldOffset(Offset = "0x1C")]
		private TournamentListElement[] _spawnedElements;

		// Token: 0x04000FDE RID: 4062
		[Token(Token = "0x4000FDE")]
		[FieldOffset(Offset = "0x20")]
		private TournamentProgressWindow _tournamentProgressWindow;

		// Token: 0x04000FDF RID: 4063
		[Token(Token = "0x4000FDF")]
		[FieldOffset(Offset = "0x24")]
		private bool _initComplete;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TournamentProgressWindow ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__get_TournamentProgressWindow
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58563 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_ProgressWindowClosedEventHandler__
		              );
		    DAT_ram_00a58563 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 != 0) {
		    uVar3 = *(undefined4 *)(param1 + 0x20);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_ProgressWindowClosedEventHandler__
		               ,0);
		    UI_Windows_BaseWindow__add_onClose(uVar3,uVar2,0);
		  }
		  *(undefined4 *)(param1 + 0x20) = param2;
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param2,0,0);
		  if (iVar1 != 0) {
		    uVar3 = *(undefined4 *)(param1 + 0x20);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_ProgressWindowClosedEventHandler__
		               ,0);
		    UI_Windows_BaseWindow__get_IsActiveResourceBar(uVar3,uVar2,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_TournamentProgressWindow ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__set_TournamentProgressWindow
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58564 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentsWindow___ctor__
		              );
		    DAT_ram_00a58564 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentsWindow___ctor__
		            );
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a58566 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentsWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_HistoryRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_TournamentListRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_UIBlockedChangedEventHandler__
		              );
		    DAT_ram_00a58566 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    Gameplay_Tournaments_Controller_TournamentsViewMediator__SubscribeToEvents(param1,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_TournamentListRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_bool__TypeInfo);
		    System_Action_AsyncGPUReadbackRequest___Invoke
		              (uVar3,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_UIBlockedChangedEventHandler__
		               ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_bool__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_bool__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar5;
		      uVar3 = System_Action_bool__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_bool__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_HistoryRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x24) = piVar4, *piVar4 != iVar1)) {
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
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_TournamentListRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_bool__TypeInfo);
		    System_Action_AsyncGPUReadbackRequest___Invoke
		              (uVar3,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_UIBlockedChangedEventHandler__
		               ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_bool__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_bool__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar5;
		      uVar3 = System_Action_bool__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_bool__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_HistoryRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x24) = piVar4, *piVar4 != iVar1))
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


		/* --- GHIDRA: set_Events ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58567 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBetChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoStateChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_BetChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_PlayerBetAddedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_StateChangedEventHandler__
		              );
		    DAT_ram_00a58567 = '\x01';
		  }
		  if ((char)param1[9] == '\0') {
		    *(undefined1 *)(param1 + 9) = 1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_PlayerBetAddedEventHandler__
		               ,0);
		    param1_00 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    iVar3 = System_Action_TypeInfo;
		    if (param1_00 == (int *)0x0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *param1_00) ||
		            (*(int **)(iVar1 + 0x18) = param1_00, *param1_00 != iVar3)) {
		      System_Activator__CreateInstance(param1_00,iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar3 + 0x28);
		    uVar2 = unnamed_function_1417(System_Action_ProtoBetChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_BetChangedEventHandler__
		               ,0);
		    iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_ProtoBetChangedEvt__TypeInfo;
		    if (iVar1 == 0) {
		      *(undefined4 *)(iVar3 + 0x28) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar1,System_Action_ProtoBetChangedEvt__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar1,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar3 + 0x28) = iVar4;
		      uVar2 = System_Action_ProtoBetChangedEvt__TypeInfo;
		      iVar3 = func_ii_1082(iVar1,System_Action_ProtoBetChangedEvt__TypeInfo);
		      if (iVar3 == 0) {
		        System_Activator__CreateInstance(iVar1,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar3 + 0x34);
		    uVar2 = unnamed_function_1417(System_Action_ProtoStateChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsViewMediator_StateChangedEventHandler__
		               ,0);
		    iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_ProtoStateChangedEvt__TypeInfo;
		    if (iVar1 == 0) {
		      *(undefined4 *)(iVar3 + 0x34) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar1,System_Action_ProtoStateChangedEvt__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar3 + 0x34) = iVar4;
		    uVar2 = System_Action_ProtoStateChangedEvt__TypeInfo;
		    iVar3 = func_ii_1082(iVar1,System_Action_ProtoStateChangedEvt__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Controller ---
		void Gameplay_Tournaments_Controller_TournamentsViewMediator__set_Controller
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5856a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentsWindow__get_Model__
		              );
		    DAT_ram_00a5856a = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Tournaments_Controller_TournamentsController__StartListeningForCombatStart(param1_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Tabs_TabBar__HandleSelected(*(undefined4 *)(iVar1 + 0x44),*(undefined4 *)(param1[2] + 0x30),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(iVar1 + 0x44),0,0,0);
		  return;
		}
		*/

}
