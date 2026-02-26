using System;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Gameplay.WorldAxis.Office.View.History;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.WorldAxis.Office.Controller
{
	// Token: 0x020002DF RID: 735
	[Token(Token = "0x20002DF")]
	public class HistoryViewMediator : AbstractViewMediator<HistoryModel, HistoryEvents, HistoryController, HistoryView>, IHideableMediator
	{
		// Token: 0x06001156 RID: 4438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001156")]
		[Address(RVA = "0x6353", Offset = "0x6353", VA = "0x6353")]
		public HistoryViewMediator(HistoryModel model, HistoryEvents events, HistoryController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_Controller_HistoryViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58b45 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HistoryModel__HistoryEvents__HistoryController__HistoryView__set_View__
		              );
		    DAT_ram_00a58b45 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_WorldAxis_Office_Controller_HistoryViewMediator__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_WorldAxis_Office_Controller_HistoryViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000290 RID: 656
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000290")]
		public override HistoryView View
		{
			[Token(Token = "0x6001157")]
			[Address(RVA = "0x6354", Offset = "0x6354", VA = "0x6354", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001158")]
		[Address(RVA = "0x6355", Offset = "0x6355", VA = "0x6355")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_WorldAxis_Office_Controller_HistoryViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58b47 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HistoryModel__HistoryEvents__HistoryController__HistoryView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_BackButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_ColossusFilterSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_ExtraFilterDeselectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_MoreItemsAfterNeededEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_ToggleChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_HistoryView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58b47 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView__get_AdditionalButtons(uVar1,0);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_MoreItemsAfterNeededEventHandler__
		             ,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar2,param1_00,0);
		  if ((piVar3 != (int *)0x0) && (System_Action_TypeInfo != *piVar3)) {
		    System_Activator__CreateInstance(piVar3,System_Action_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView__get_MoreItemsAfterNeededEvent
		            (uVar1,piVar3,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar4 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_ToggleChangedEventHandler__
		             ,0);
		  UI_ToolTip_Controller_Android_ToolTipController__GetPointerPosition(uVar2,uVar1,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar4 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_object__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_ColossusFilterSelectedEventHandler__
		             ,0);
		  UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData___ctor
		            (uVar2,uVar1,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar4 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_ExtraFilterDeselectedEventHandler__
		             ,0);
		  UI_Elements_GenericList_SelectableListElementArgs___ctor(uVar2,uVar1,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar4 + 0x2c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_BackButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar1,1,Method_UI_MonoBehaviourWithStates_HistoryView_State__set_CurrentState__);
		  if ((char)param1[7] == '\0') {
		    *(undefined1 *)(param1 + 7) = 1;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar3 = *(int **)(iVar4 + 0x20);
		    uVar1 = Gameplay_WorldAxis_Office_Model_HistoryModel__set_LastRequestedBattles(param1[2],param1)
		    ;
		    iVar4 = *piVar3;
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe0) * 4))
		              (piVar3,uVar1,*(undefined4 *)(iVar4 + 0xe4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001159")]
		[Address(RVA = "0x6356", Offset = "0x6356", VA = "0x6356")]
		private void SetupView()
		{
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115A")]
		[Address(RVA = "0x6357", Offset = "0x6357", VA = "0x6357")]
		private void ToggleChangedEventHandler()
		{
		/* --- GHIDRA: ToggleChangedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_HistoryViewMediator__ToggleChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int param2_00;
		  
		  param1[6] = 0;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_WorldAxis_Office_Controller_HistoryController__HandleRun
		            (param1_00,param2_00,(uint)*(byte *)(*(int *)(iVar1 + 0x24) + 0x48),param1);
		  return;
		}
		*/

		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115B")]
		[Address(RVA = "0x6358", Offset = "0x6358", VA = "0x6358")]
		private void ExtraFilterDeselectedEventHandler()
		{
		/* --- GHIDRA: ExtraFilterDeselectedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_HistoryViewMediator__ExtraFilterDeselectedEventHandler
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int param2_00;
		  
		  if (DAT_ram_00a58b48 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ColossusDic_TypeInfo);
		    DAT_ram_00a58b48 = '\x01';
		  }
		  if ((param2 != (int *)0x0) && (Protocol_Dic_ColossusDic_TypeInfo != *param2)) {
		    System_Activator__CreateInstance(param2,Protocol_Dic_ColossusDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1[6] = param2[3];
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_WorldAxis_Office_Controller_HistoryController__HandleRun
		            (param1_00,param2_00,(uint)*(byte *)(*(int *)(iVar1 + 0x24) + 0x48),param1);
		  return;
		}
		*/

		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115C")]
		[Address(RVA = "0x6359", Offset = "0x6359", VA = "0x6359")]
		private void ColossusFilterSelectedEventHandler(object data)
		{
		/* --- GHIDRA: ColossusFilterSelectedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_HistoryViewMediator__ColossusFilterSelectedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int param2_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_WorldAxis_Office_Controller_HistoryController__HandleRun
		            (param1_00,param2_00,(uint)*(byte *)(*(int *)(iVar1 + 0x24) + 0x48),param1);
		  return;
		}
		*/

		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115D")]
		[Address(RVA = "0x635A", Offset = "0x635A", VA = "0x635A")]
		private void RequestFirstHistory()
		{
		/* --- GHIDRA: RequestFirstHistory ---
		void Gameplay_WorldAxis_Office_Controller_HistoryViewMediator__RequestFirstHistory
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58b49 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_HistoryView_State__set_CurrentState__);
		    DAT_ram_00a58b49 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1_00,1,Method_UI_MonoBehaviourWithStates_HistoryView_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115E")]
		[Address(RVA = "0x635B", Offset = "0x635B", VA = "0x635B")]
		private void BackButtonClickedEventHandler()
		{
		/* --- GHIDRA: BackButtonClickedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_HistoryViewMediator__BackButtonClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58b4a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HistoryModel__HistoryEvents__HistoryController__HistoryView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_BattleInfoRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_FirstHistoryRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_HistoryRequestedEventHandler__
		              );
		    DAT_ram_00a58b4a = '\x01';
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
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_HistoryRequestedEventHandler__
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_FirstHistoryRequestedEventHandler__
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_BattleInfoRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
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
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_HistoryRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_FirstHistoryRequestedEventHandler__
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_BattleInfoRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x17000291 RID: 657
		// (set) Token: 0x0600115F RID: 4447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000291")]
		public override HistoryEvents Events
		{
			[Token(Token = "0x600115F")]
			[Address(RVA = "0x635C", Offset = "0x635C", VA = "0x635C", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001160")]
		[Address(RVA = "0x635D", Offset = "0x635D", VA = "0x635D")]
		private void BattleInfoRequestedEventHandler()
		{
		/* --- GHIDRA: BattleInfoRequestedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_HistoryViewMediator__BattleInfoRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58b4c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HistoryModel__HistoryEvents__HistoryController__HistoryView__get_Model__
		              );
		    DAT_ram_00a58b4c = '\x01';
		  }
		  if (DAT_ram_00a58b50 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HistoryModel__HistoryEvents__HistoryController__HistoryView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_BattleHistoryListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_ListElementClickedEventHandler__
		              );
		    DAT_ram_00a58b50 = '\x01';
		  }
		  iVar3 = *(int *)(param1[2] + 0x20);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    iVar1 = 0;
		    do {
		      iVar4 = *(int *)(iVar3 + iVar1 * 4 + 0x10);
		      uVar2 = unnamed_function_1417(System_Action_BattleHistoryListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar2,param1,
		                 Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_ListElementClickedEventHandler__
		                 ,0);
		      *(undefined4 *)(iVar4 + 0x18) = uVar2;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  if (DAT_ram_00a58b4f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HistoryModel__HistoryEvents__HistoryController__HistoryView__get_Model__
		              );
		    DAT_ram_00a58b4f = '\x01';
		  }
		  iVar3 = *(int *)(param1[2] + 0x1c);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_WorldAxis_Office_View_History_HistoryView__Remove(uVar2,(uint)(iVar3 != 0),0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_WorldAxis_Office_View_History_HistoryView__set_MoreItemsAfterNeededEvent
		            (uVar2,*(undefined4 *)(param1[2] + 0x2c),0);
		  return;
		}
		*/

		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001161")]
		[Address(RVA = "0x635E", Offset = "0x635E", VA = "0x635E")]
		private void FirstHistoryRequestedEventHandler()
		{
		/* --- GHIDRA: FirstHistoryRequestedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_HistoryViewMediator__FirstHistoryRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58b4d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HistoryModel__HistoryEvents__HistoryController__HistoryView__get_Model__
		              );
		    DAT_ram_00a58b4d = '\x01';
		  }
		  if (DAT_ram_00a58b50 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HistoryModel__HistoryEvents__HistoryController__HistoryView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_BattleHistoryListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_ListElementClickedEventHandler__
		              );
		    DAT_ram_00a58b50 = '\x01';
		  }
		  iVar3 = *(int *)(param1[2] + 0x20);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    iVar1 = 0;
		    do {
		      iVar4 = *(int *)(iVar3 + iVar1 * 4 + 0x10);
		      uVar2 = unnamed_function_1417(System_Action_BattleHistoryListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar2,param1,
		                 Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_ListElementClickedEventHandler__
		                 ,0);
		      *(undefined4 *)(iVar4 + 0x18) = uVar2;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  if (DAT_ram_00a58b4f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HistoryModel__HistoryEvents__HistoryController__HistoryView__get_Model__
		              );
		    DAT_ram_00a58b4f = '\x01';
		  }
		  iVar3 = *(int *)(param1[2] + 0x1c);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_WorldAxis_Office_View_History_HistoryView__Remove(uVar2,(uint)(iVar3 != 0),0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView__Init
		            (uVar2,*(undefined4 *)(param1[2] + 0x20),0);
		  return;
		}
		*/

		}

		// Token: 0x06001162 RID: 4450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001162")]
		[Address(RVA = "0x635F", Offset = "0x635F", VA = "0x635F")]
		private void HistoryRequestedEventHandler()
		{
		/* --- GHIDRA: HistoryRequestedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_HistoryViewMediator__HistoryRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58b4e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HistoryModel__HistoryEvents__HistoryController__HistoryView__get_Model__
		              );
		    DAT_ram_00a58b4e = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_WorldAxis_Office_Controller_HistoryController__GetFirstHistoryResultHandler
		            (param1_00,*(undefined4 *)(param1[2] + 0x1c),param1[6],0,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001163")]
		[Address(RVA = "0x6360", Offset = "0x6360", VA = "0x6360")]
		private void MoreItemsAfterNeededEventHandler()
		{
		/* --- GHIDRA: MoreItemsAfterNeededEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_HistoryViewMediator__MoreItemsAfterNeededEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a58b4f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HistoryModel__HistoryEvents__HistoryController__HistoryView__get_Model__
		              );
		    DAT_ram_00a58b4f = '\x01';
		  }
		  iVar1 = *(int *)(param1[2] + 0x1c);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_WorldAxis_Office_View_History_HistoryView__Remove(param1_00,(uint)(iVar1 != 0),0);
		  return;
		}
		*/

		}

		// Token: 0x06001164 RID: 4452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001164")]
		[Address(RVA = "0x6361", Offset = "0x6361", VA = "0x6361")]
		private void UpdateOSARequestBounds()
		{
		/* --- GHIDRA: UpdateOSARequestBounds ---
		void Gameplay_WorldAxis_Office_Controller_HistoryViewMediator__UpdateOSARequestBounds
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int iVar3;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a58b50 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HistoryModel__HistoryEvents__HistoryController__HistoryView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_BattleHistoryListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_ListElementClickedEventHandler__
		              );
		    DAT_ram_00a58b50 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 8) + 0x20);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      iVar3 = *(int *)(iVar2 + iVar1 * 4 + 0x10);
		      param1_00 = unnamed_function_1417(System_Action_BattleHistoryListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_00,param1,
		                 Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_ListElementClickedEventHandler__
		                 ,0);
		      *(undefined4 *)(iVar3 + 0x18) = param1_00;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001165 RID: 4453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001165")]
		[Address(RVA = "0x6362", Offset = "0x6362", VA = "0x6362")]
		private void InjectCallback()
		{
		/* --- GHIDRA: InjectCallback ---
		void Gameplay_WorldAxis_Office_Controller_HistoryViewMediator__InjectCallback
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58b51 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_HistoryView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_BattleHistoryListElement_BattleHistoryListElementArgs__get_Data__
		              );
		    DAT_ram_00a58b51 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar1,3,Method_UI_MonoBehaviourWithStates_HistoryView_State__set_CurrentState__);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_WorldAxis_Office_Controller_HistoryController__GetHistoryResultHandler
		            (uVar1,*(undefined4 *)(param2 + 0x18),param1);
		  return;
		}
		*/

		}

		// Token: 0x06001166 RID: 4454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001166")]
		[Address(RVA = "0x6363", Offset = "0x6363", VA = "0x6363")]
		private void ListElementClickedEventHandler(BattleHistoryListElement element)
		{
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001167")]
		[Address(RVA = "0x6364", Offset = "0x6364", VA = "0x6364", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_WorldAxis_Office_Controller_HistoryViewMediator__Hide
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  if (DAT_ram_00a58b52 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_RatingsModel__RatingsEvents___ctor__);
		    DAT_ram_00a58b52 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_RatingsModel__RatingsEvents___ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = param4;
		  return;
		}
		*/

		}

		// Token: 0x040008FA RID: 2298
		[Token(Token = "0x40008FA")]
		[FieldOffset(Offset = "0x18")]
		private uint _colossusId;

		// Token: 0x040008FB RID: 2299
		[Token(Token = "0x40008FB")]
		[FieldOffset(Offset = "0x1C")]
		private bool _isInit;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_WorldAxis_Office_Controller_HistoryViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a58b46 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_BackButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_ColossusFilterSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_ExtraFilterDeselectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_MoreItemsAfterNeededEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_ToggleChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58b46 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView__get_AdditionalButtons(uVar1,0);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_MoreItemsAfterNeededEventHandler__
		             ,0);
		  param1_01 = (int *)func_ii_7048(uVar2,param1_00,0);
		  if ((param1_01 != (int *)0x0) && (System_Action_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView__get_MoreItemsAfterNeededEvent
		            (uVar1,param1_01,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar3 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_ToggleChangedEventHandler__
		             ,0);
		  UI_Toggle_GreenToggle__add_ChangedEvent(uVar2,uVar1,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar3 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_object__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_ColossusFilterSelectedEventHandler__
		             ,0);
		  UI_Elements_Filters_GenericFilter_GenericFilterView__add_SelectedEvent(uVar2,uVar1,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar3 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_ExtraFilterDeselectedEventHandler__
		             ,0);
		  UI_Elements_Filters_GenericFilter_DeselectableGenericFilterView__add_DeselectedEvent
		            (uVar2,uVar1,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar3 + 0x2c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Office_Controller_HistoryViewMediator_BackButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_WorldAxis_Office_Controller_HistoryViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a58b4b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HistoryModel__HistoryEvents__HistoryController__HistoryView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_HistoryView_State__set_CurrentState__);
		    DAT_ram_00a58b4b = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1_00,2,Method_UI_MonoBehaviourWithStates_HistoryView_State__set_CurrentState__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_WorldAxis_Office_View_History_BattleHistoryListElement_BattleHistoryListElementArgs___ctor
		            (*(undefined4 *)(iVar1 + 0x28),*(undefined4 *)(param1[2] + 0x24),0);
		  return;
		}
		*/

}
