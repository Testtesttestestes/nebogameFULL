using System;
using Gameplay.BlitzTournament.Events;
using Gameplay.BlitzTournament.Model;
using Gameplay.BlitzTournament.View;
using Il2CppDummyDll;
using MVC;
using Protocol.BlitzTournaments;

namespace Gameplay.BlitzTournament.Controller
{
	// Token: 0x02000BDB RID: 3035
	[Token(Token = "0x2000BDB")]
	public class BlitzTournamentProgressMediator : AbstractViewMediator<BlitzTournamentModel, Gameplay.BlitzTournament.Events.BlitzTournamentEvents, BlitzTournamentController, BlitzTournamentProgressWindow>
	{
		// Token: 0x06004A65 RID: 19045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A65")]
		[Address(RVA = "0x98C7", Offset = "0x98C7", VA = "0x98C7")]
		public BlitzTournamentProgressMediator(BlitzTournamentModel model, Gameplay.BlitzTournament.Events.BlitzTournamentEvents events, BlitzTournamentController controller)
		{
		/* --- GHIDRA: <UseFirstBattleDescription>b__23_1 ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator___UseFirstBattleDescription_b__23_1
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a608e1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentWindow___ctor__
		              );
		    DAT_ram_00a608e1 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentWindow___ctor__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: <UseFirstBattleDescription>b__23_2 ---
		uint Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator___UseFirstBattleDescription_b__23_2
		               (int param1,int param2,undefined4 param3)
		
		{
		  longlong lVar1;
		  longlong lVar2;
		  
		  if (DAT_ram_00a608e0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentProgressWindow__get_Model__
		              );
		    DAT_ram_00a608e0 = '\x01';
		  }
		  lVar2 = *(longlong *)(*(int *)(param2 + 0xc) + 0x10);
		  lVar1 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		  return (uint)(lVar2 != lVar1);
		}
		*/

		/* --- GHIDRA: <UseFirstBattleDescription>b__23_0 ---
		uint Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator___UseFirstBattleDescription_b__23_0
		               (int param1,int param2,undefined4 param3)
		
		{
		  longlong lVar1;
		  longlong lVar2;
		  
		  if (DAT_ram_00a608df == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentProgressWindow__get_Model__
		              );
		    DAT_ram_00a608df = '\x01';
		  }
		  lVar2 = *(longlong *)(*(int *)(param2 + 0xc) + 0x10);
		  lVar1 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		  return (uint)(lVar2 == lVar1);
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  char cVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint param2_00;
		  
		  if (DAT_ram_00a608ce == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentProgressWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentProgressWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator_RulesButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a608ce = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar2,0);
		  if (iVar3 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = *(undefined4 *)(*(int *)(iVar3 + 0x50) + 0xb4);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar2,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator_RulesButtonClickHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar4,uVar2,0);
		  }
		  param1[5] = param2;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar2,0);
		  if (iVar3 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = *(undefined4 *)(*(int *)(iVar3 + 0x50) + 0xb4);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar2,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator_RulesButtonClickHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar4,uVar2,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Tabs_TabBar__HandleSelected
		              (*(undefined4 *)(iVar3 + 0x44),*(undefined4 *)(param1[2] + 0x2c),0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		              (*(undefined4 *)(iVar3 + 0x44),0,0,0);
		    if (DAT_ram_00a608d2 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_UI_Windows_BaseWindow_BlitzTournamentProgressWindow_BlitzTournamentProgressWindowArgs__get_WindowArgs__
		                );
		      DAT_ram_00a608d2 = '\x01';
		    }
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = func_ii_8093(uVar2,
		                         Method_UI_Windows_BaseWindow_BlitzTournamentProgressWindow_BlitzTournamentProgressWindowArgs__get_WindowArgs__
		                        );
		    if (*(int *)(iVar3 + 0x1c) == 1) {
		      Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__LoadLosePage
		                (param1,param1);
		    }
		    else if (*(int *)(iVar3 + 0x1c) == 2) {
		      Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UpdateGeneralView
		                (param1,param1);
		    }
		    else {
		      Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__ResolveWindowState
		                (param1,param1);
		    }
		    cVar1 = *(char *)(param1[2] + 0x20);
		    if (DAT_ram_00a608dd == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_UI_Windows_ClosableBaseWindow_BlitzTournamentProgressWindow_BlitzTournamentProgressWindowArgs__get_BackButton__
		                );
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_UI_Windows_WindowWhitCloseButton_BlitzTournamentProgressWindow_BlitzTournamentProgressWindowArgs__get_CloseButton__
		                );
		      DAT_ram_00a608dd = '\x01';
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param2_00 = (uint)(cVar1 == '\0');
		    System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar3 + 0x34),param2_00,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar3 + 0x38),param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000F09 RID: 3849
		// (set) Token: 0x06004A66 RID: 19046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F09")]
		public override BlitzTournamentProgressWindow View
		{
			[Token(Token = "0x6004A66")]
			[Address(RVA = "0x98C8", Offset = "0x98C8", VA = "0x98C8", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (set) Token: 0x06004A67 RID: 19047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F0A")]
		public override Gameplay.BlitzTournament.Events.BlitzTournamentEvents Events
		{
			[Token(Token = "0x6004A67")]
			[Address(RVA = "0x98C9", Offset = "0x98C9", VA = "0x98C9", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A68")]
		[Address(RVA = "0x98CA", Offset = "0x98CA", VA = "0x98CA")]
		private void RulesButtonClickHandler()
		{
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A69")]
		[Address(RVA = "0x98CB", Offset = "0x98CB", VA = "0x98CB")]
		private void TournamentInfoReceivedEventHandler()
		{
		/* --- GHIDRA: TournamentInfoReceivedEventHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__TournamentInfoReceivedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 in_register_20000014;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  float fVar3;
		  int iVar4;
		  int *piVar5;
		  int *piVar6;
		  undefined8 uVar7;
		  int *local_4;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a608d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a608d1 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar4 = *(int *)(param1 + 0x18);
		  if (0 < *(int *)(iVar4 + 0xc)) {
		    do {
		      piVar5 = *(int **)(iVar4 + iVar1 * 4 + 0x10);
		      uVar7 = *(undefined8 *)(param2 + 0x10);
		      iVar4 = *piVar5;
		      iVar4 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe0) * 4))
		                        (piVar5,uVar7,&local_4,*(undefined4 *)(iVar4 + 0xe4));
		      in_register_20000014 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      if (iVar4 != 0) break;
		      iVar1 = iVar1 + 1;
		      iVar4 = *(int *)(param1 + 0x18);
		    } while (iVar1 < *(int *)(iVar4 + 0xc));
		  }
		  piVar5 = local_4;
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(piVar5,0,0);
		  piVar5 = local_4;
		  if (iVar1 == 0) {
		    iVar4 = *(int *)(param2 + 0x18);
		    uVar7 = CONCAT44(in_register_20000014,*(undefined4 *)(*local_4 + 0xec));
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*local_4 + 0xe8) * 4))(local_4,uVar7);
		    uVar2 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    piVar6 = (int *)piVar5[5];
		    if (iVar1 == 0) {
		      fVar3 = 0.0;
		    }
		    else {
		      uVar7 = CONCAT44(uVar2,*(undefined4 *)(*piVar5 + 0xec));
		      param2_00 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xe8) * 4))(piVar5,uVar7);
		      uVar2 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      fVar3 = Utils_MathUtils_MathUtils__SaferDivide((float)iVar4,param2_00,0);
		    }
		    iVar1 = *piVar6;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x108) * 4))
		              (piVar6,CONCAT44(uVar2,fVar3),*(undefined4 *)(iVar1 + 0x10c));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A6A")]
		[Address(RVA = "0x98CC", Offset = "0x98CC", VA = "0x98CC")]
		private void HealthChangedEventHandler(ProtoHealthChangedEvt evt)
		{
		/* --- GHIDRA: HealthChangedEventHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__HealthChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a608d2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_BlitzTournamentProgressWindow_BlitzTournamentProgressWindowArgs__get_WindowArgs__
		              );
		    DAT_ram_00a608d2 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(param1_00,
		                       Method_UI_Windows_BaseWindow_BlitzTournamentProgressWindow_BlitzTournamentProgressWindowArgs__get_WindowArgs__
		                      );
		  if (*(int *)(iVar1 + 0x1c) != 1) {
		    if (*(int *)(iVar1 + 0x1c) != 2) {
		      Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__ResolveWindowState
		                (param1,param1);
		      return;
		    }
		    Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UpdateGeneralView
		              (param1,param1);
		    return;
		  }
		  Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__LoadLosePage(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A6B")]
		[Address(RVA = "0x98CD", Offset = "0x98CD", VA = "0x98CD")]
		private void ResolveWindowState()
		{
		/* --- GHIDRA: ResolveWindowState ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__ResolveWindowState
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a608d3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentProgressWindow__get_Model__
		              );
		    DAT_ram_00a608d3 = '\x01';
		  }
		  iVar3 = *(int *)(param1[2] + 0x10);
		  if (iVar3 == 0) {
		    if (DAT_ram_00a608dd == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_UI_Windows_ClosableBaseWindow_BlitzTournamentProgressWindow_BlitzTournamentProgressWindowArgs__get_BackButton__
		                );
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_UI_Windows_WindowWhitCloseButton_BlitzTournamentProgressWindow_BlitzTournamentProgressWindowArgs__get_CloseButton__
		                );
		      DAT_ram_00a608dd = '\x01';
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar3 + 0x34),1,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar3 + 0x38),1,0);
		    return;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Gameplay_BlitzTournament_View_BlitzTournamentProgressWindow__OnShow(uVar1,iVar3,param1);
		  param1[6] = iVar2;
		  iVar2 = *(int *)(iVar3 + 0x18);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = *(undefined4 *)(*(int *)(iVar3 + 0x40) + 0x28);
		  if (iVar2 == 2) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar3 + 0x40) + 0x24),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__LoadGridWindow
		              (param1,param1);
		    Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UpdateInfoBox
		              (param1,param1);
		    return;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__LoadGridWindow(param1,param1)
		  ;
		  Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UseFirstBattleDescription
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004A6C RID: 19052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A6C")]
		[Address(RVA = "0x98CE", Offset = "0x98CE", VA = "0x98CE")]
		private void DefineTournamentState()
		{
		/* --- GHIDRA: DefineTournamentState ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__DefineTournamentState
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(*(int *)(iVar1 + 0x40) + 0x28),1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(*(int *)(iVar1 + 0x40) + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__LoadGridWindow(param1,param1)
		  ;
		  Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UpdateInfoBox(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A6D")]
		[Address(RVA = "0x98CF", Offset = "0x98CF", VA = "0x98CF")]
		public void LoadWaitingWindow()
		{
		/* --- GHIDRA: LoadWaitingWindow ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__LoadWaitingWindow
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(*(int *)(iVar1 + 0x40) + 0x28),0,0);
		  Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__LoadGridWindow(param1,param1)
		  ;
		  Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UseFirstBattleDescription
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004A6E RID: 19054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A6E")]
		[Address(RVA = "0x98D0", Offset = "0x98D0", VA = "0x98D0")]
		public void LoadGridWindow()
		{
		/* --- GHIDRA: LoadGridWindow ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__LoadGridWindow
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a608d4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentProgressWindow__get_Model__
		              );
		    DAT_ram_00a608d4 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(iVar1 + 0x58),*(undefined4 *)(param1[2] + 0x18),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x5c);
		  param2_00 = Gameplay_BlitzTournament_Model_BlitzTournamentModel__SetBackTime
		                        (param1,*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x1c),param1);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  if (DAT_ram_00a608d7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_BlitzTournamentBracketInfoBox_State__set_CurrentState__
		              );
		    DAT_ram_00a608d7 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x40),3,
		             Method_UI_MonoBehaviourWithStates_BlitzTournamentBracketInfoBox_State__set_CurrentState__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004A6F RID: 19055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A6F")]
		[Address(RVA = "0x98D1", Offset = "0x98D1", VA = "0x98D1")]
		private void UpdateGeneralView()
		{
		/* --- GHIDRA: UpdateGeneralView ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UpdateGeneralView
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a608d5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentProgressWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_BlitzTournamentBracketInfoBox_State__set_CurrentState__
		              );
		    DAT_ram_00a608d5 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_BlitzTournament_View_BlitzTournamentProgressWindow__Init(uVar1,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = *(int *)(iVar2 + 0x40);
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (iVar2,1,
		             Method_UI_MonoBehaviourWithStates_BlitzTournamentBracketInfoBox_State__set_CurrentState__
		            );
		  param1_00 = *(undefined4 *)(iVar2 + 0x1c);
		  uVar1 = Core_Extensions_Dict_BaseOptionExt__GetExternalPrice
		                    (*(undefined4 *)(*(int *)(param1[2] + 0x1c) + 8),0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar2 + 0x28),0,0);
		  Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__RenderRewards(param1,param1);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004A70 RID: 19056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A70")]
		[Address(RVA = "0x98D2", Offset = "0x98D2", VA = "0x98D2")]
		public void LoadLosePage()
		{
		/* --- GHIDRA: LoadLosePage ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__LoadLosePage
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a608d6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentProgressWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_BlitzTournamentBracketInfoBox_State__set_CurrentState__
		              );
		    DAT_ram_00a608d6 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_BlitzTournament_View_BlitzTournamentProgressWindow__ShowLosePage(uVar1,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = *(int *)(iVar2 + 0x40);
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (iVar2,2,
		             Method_UI_MonoBehaviourWithStates_BlitzTournamentBracketInfoBox_State__set_CurrentState__
		            );
		  param1_00 = *(undefined4 *)(iVar2 + 0x1c);
		  uVar1 = Core_Extensions_Dict_BaseOptionExt__GetExternalPrice
		                    (*(undefined4 *)(*(int *)(param1[2] + 0x1c) + 8),0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar2 + 0x28),0,0);
		  Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UseLoseDescription
		            (param1,param1);
		  Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UseFollowingBattleDescription
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004A71 RID: 19057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A71")]
		[Address(RVA = "0x98D3", Offset = "0x98D3", VA = "0x98D3")]
		public void LoadWinPage()
		{
		/* --- GHIDRA: LoadWinPage ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__LoadWinPage
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a608d7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_BlitzTournamentBracketInfoBox_State__set_CurrentState__
		              );
		    DAT_ram_00a608d7 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x40),3,
		             Method_UI_MonoBehaviourWithStates_BlitzTournamentBracketInfoBox_State__set_CurrentState__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004A72 RID: 19058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A72")]
		[Address(RVA = "0x98D4", Offset = "0x98D4", VA = "0x98D4")]
		private void UpdateInfoBox()
		{
		/* --- GHIDRA: UpdateInfoBox ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UpdateInfoBox
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a608d8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentProgressWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UseFirstBattleDescription_b__23_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UseFirstBattleDescription_b__23_1__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_BattleInfo___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_FighterInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_BattleInfo__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_FighterInfo__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3609);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15165);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25860);
		    DAT_ram_00a608d8 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x24);
		  uVar1 = unnamed_function_1417(System_Func_BattleInfo__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param1,
		             Method_Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UseFirstBattleDescription_b__23_0__
		             ,0);
		  iVar2 = func_ii_7423(uVar3,uVar1,Method_System_Linq_Enumerable_First_BattleInfo___);
		  uVar3 = *(undefined4 *)(iVar2 + 0xc);
		  uVar1 = unnamed_function_1417(System_Func_FighterInfo__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param1,
		             Method_Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UseFirstBattleDescription_b__23_1__
		             ,0);
		  iVar2 = func_ii_7423(uVar3,uVar1,Method_System_Linq_Enumerable_First_FighterInfo___);
		  uVar1 = *(undefined4 *)(*(int *)(iVar2 + 0xc) + 0x18);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x40) + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param1_00 = func_ii_7508(StringLiteral_3609,1,0,1,0,0,0,0);
		  iVar2 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_25860,uVar1,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar2 + 0x10) = local_8;
		  uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (param1_00,iVar2,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UnityEngine_Component__GetComponentInChildren_object_
		            (*(undefined4 *)(*(int *)(iVar2 + 0x40) + 0x20),
		             **(undefined4 **)(DAT_ram_00a66978 + 0x5c),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x60);
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15165,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x58),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004A73 RID: 19059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A73")]
		[Address(RVA = "0x98D5", Offset = "0x98D5", VA = "0x98D5")]
		private void UseFirstBattleDescription()
		{
		/* --- GHIDRA: UseFirstBattleDescription ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UseFirstBattleDescription
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a608d9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentProgressWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3608);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3617);
		    DAT_ram_00a608d9 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x40) + 0x1c);
		  uVar2 = Core_Extensions_Dict_BaseOptionExt__GetExternalPrice
		                    (*(undefined4 *)(*(int *)(param1[2] + 0x1c) + 8),0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x40) + 0x20);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3617,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar3,0);
		  Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UseFollowingBattleDescription
		            (param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x60);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3608,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x58),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A74")]
		[Address(RVA = "0x98D6", Offset = "0x98D6", VA = "0x98D6")]
		private void UseFollowingBattleDescription()
		{
		/* --- GHIDRA: UseFollowingBattleDescription ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UseFollowingBattleDescription
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  
		  if (DAT_ram_00a608da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentProgressWindow__get_Model__
		              );
		    DAT_ram_00a608da = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(*(int *)(iVar1 + 0x40) + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar2 = (int *)func_ii_7307(*(undefined4 *)(*(int *)(iVar1 + 0x40) + 0x24),
		                               *(undefined4 *)(*(int *)(param1[2] + 0x1c) + 0xc),0);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xf0) * 4))(piVar2,*(undefined4 *)(*piVar2 + 0xf4));
		  return;
		}
		*/

		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A75")]
		[Address(RVA = "0x98D7", Offset = "0x98D7", VA = "0x98D7")]
		private void RenderRewards()
		{
		/* --- GHIDRA: RenderRewards ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__RenderRewards
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a608db == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3616);
		    DAT_ram_00a608db = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x40) + 0x20);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3616,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004A76 RID: 19062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A76")]
		[Address(RVA = "0x98D8", Offset = "0x98D8", VA = "0x98D8")]
		private void UseLoseDescription()
		{
		/* --- GHIDRA: UseLoseDescription ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UseLoseDescription
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a608dc == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3621);
		    DAT_ram_00a608dc = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x40) + 0x20);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3621,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004A77 RID: 19063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A77")]
		[Address(RVA = "0x98D9", Offset = "0x98D9", VA = "0x98D9")]
		private void UseWinDescription()
		{
		/* --- GHIDRA: UseWinDescription ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UseWinDescription
		               (int *param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a608dd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_BlitzTournamentProgressWindow_BlitzTournamentProgressWindowArgs__get_BackButton__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_WindowWhitCloseButton_BlitzTournamentProgressWindow_BlitzTournamentProgressWindowArgs__get_CloseButton__
		              );
		    DAT_ram_00a608dd = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x34),param2 ^ 1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x38),param2 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A78")]
		[Address(RVA = "0x98DA", Offset = "0x98DA", VA = "0x98DA")]
		private void BlockUI(bool block)
		{
		/* --- GHIDRA: BlockUI ---
		undefined4
		Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__BlockUI
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a608de == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UseFirstBattleDescription_b__23_2__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_FighterInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_FighterInfo__bool__TypeInfo);
		    DAT_ram_00a608de = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param2 + 0xc);
		  uVar1 = unnamed_function_1417(System_Func_FighterInfo__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param1,
		             Method_Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__UseFirstBattleDescription_b__23_2__
		             ,0);
		  uVar1 = Newtonsoft_Json_Utilities_ReflectionUtils__IsOverridenGenericMember
		                    (param1_00,uVar1,Method_System_Linq_Enumerable_Any_FighterInfo___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x04002883 RID: 10371
		[Token(Token = "0x4002883")]
		private const string LOCALIZATION_BATTLE_ABOUT_TO_START = "BLITZ/BATTLE_ABOUT_TO_START";

		// Token: 0x04002884 RID: 10372
		[Token(Token = "0x4002884")]
		private const string LOCALIZATION_NEXT_ROUND_DESCRIPTION = "BLITZ/NEXT_ROUND_DESCRIPTION";

		// Token: 0x04002885 RID: 10373
		[Token(Token = "0x4002885")]
		private const string LOCALIZATION_LOSE_DESCRIPTION = "BLITZ/LOSE_DESCRIPTION";

		// Token: 0x04002886 RID: 10374
		[Token(Token = "0x4002886")]
		private const string LOCALIZATION_WIN_DESCRIPTION = "BLITZ/WIN_DESCRIPTION";

		// Token: 0x04002887 RID: 10375
		[Token(Token = "0x4002887")]
		private const string LOCALIZATION_BATTLES_IN_PROCESS = "BLITZ/BATTLES_IN_PROCESS";

		// Token: 0x04002888 RID: 10376
		[Token(Token = "0x4002888")]
		private const string LOCALIZATION_STARTING_SOON = "TOURNAMENTS/STARTING_SOON";

		// Token: 0x04002889 RID: 10377
		[Token(Token = "0x4002889")]
		[FieldOffset(Offset = "0x18")]
		private BattleInfoListElement[] _listElements;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a608cf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentProgressWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoHealthChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator_HealthChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator_TournamentInfoReceivedEventHandler__
		              );
		    DAT_ram_00a608cf = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x30);
		    uVar2 = unnamed_function_1417(System_Action_ProtoHealthChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator_HealthChangedEventHandler__
		               ,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_ProtoHealthChangedEvt__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x30) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ProtoHealthChangedEvt__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x30) = iVar4;
		      uVar2 = System_Action_ProtoHealthChangedEvt__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ProtoHealthChangedEvt__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator_TournamentInfoReceivedEventHandler__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x14) = piVar5, *piVar5 != iVar1)) {
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
		    uVar6 = *(undefined4 *)(iVar1 + 0x30);
		    uVar2 = unnamed_function_1417(System_Action_ProtoHealthChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator_HealthChangedEventHandler__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_ProtoHealthChangedEvt__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x30) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ProtoHealthChangedEvt__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x30) = iVar4;
		      uVar2 = System_Action_ProtoHealthChangedEvt__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ProtoHealthChangedEvt__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator_TournamentInfoReceivedEventHandler__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x14) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar5) || (*(int **)(iVar3 + 0x14) = piVar5, *piVar5 != iVar1))
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


		/* --- GHIDRA: set_Events ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator__set_Events
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a608d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19433);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20574);
		    DAT_ram_00a608d0 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x81cf6d24;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81cf6d24:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetResourceSetParameter(uVar3,StringLiteral_20574,0);
		  Core_ExternAppMethods__OpenPaymentWindow(uVar3,StringLiteral_19433,0,0);
		  return;
		}
		*/

}
