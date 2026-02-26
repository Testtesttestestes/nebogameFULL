using System;
using Core.Data;
using Gameplay.GdEvents.Model;
using Gameplay.GdEvents.Model.Milestone;
using Gameplay.GdEvents.View.EventView;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.GdEvents.Control.EventSections
{
	// Token: 0x02000772 RID: 1906
	[Token(Token = "0x2000772")]
	public class MilestoneViewMediator : AbstractViewMediator<GdEventsModel, GdEventsEvents, GdEventsController, MilestonesEventSectionView>
	{
		// Token: 0x06002D61 RID: 11617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D61")]
		[Address(RVA = "0x7DDF", Offset = "0x7DDF", VA = "0x7DDF")]
		public MilestoneViewMediator(GdEventsModel model, GdEventsEvents events, GdEventsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a57469 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__MilestonesEventSectionView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_MilestoneData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_HandleContentChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_HandleCurrentMilestoneRewardUpdatedEvent__
		              );
		    DAT_ram_00a57469 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x20);
		    uVar2 = unnamed_function_1417(System_Action_MilestoneData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_HandleCurrentMilestoneRewardUpdatedEvent__
		               ,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_MilestoneData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_MilestoneData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar4;
		      uVar2 = System_Action_MilestoneData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_MilestoneData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_HandleContentChangedEvent__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x1c) = piVar5, *piVar5 != iVar1)) {
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
		    uVar6 = *(undefined4 *)(iVar1 + 0x20);
		    uVar2 = unnamed_function_1417(System_Action_MilestoneData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_HandleCurrentMilestoneRewardUpdatedEvent__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_MilestoneData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_MilestoneData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar4;
		      uVar2 = System_Action_MilestoneData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_MilestoneData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_HandleContentChangedEvent__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x1c) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar5) || (*(int **)(iVar3 + 0x1c) = piVar5, *piVar5 != iVar1))
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

		// Token: 0x170008B6 RID: 2230
		// (set) Token: 0x06002D62 RID: 11618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B6")]
		public override GdEventsEvents Events
		{
			[Token(Token = "0x6002D62")]
			[Address(RVA = "0x7DE0", Offset = "0x7DE0", VA = "0x7DE0", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (set) Token: 0x06002D63 RID: 11619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B7")]
		public override MilestonesEventSectionView View
		{
			[Token(Token = "0x6002D63")]
			[Address(RVA = "0x7DE1", Offset = "0x7DE1", VA = "0x7DE1", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D64")]
		[Address(RVA = "0x7DE2", Offset = "0x7DE2", VA = "0x7DE2")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  
		  if (DAT_ram_00a5746c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_InitViewComplete__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MyItemViewsHolder__get_IsInitialized__
		              );
		    DAT_ram_00a5746c = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(char *)(*(int *)(iVar1 + 0x28) + 0x50) != '\0') {
		    Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__SetupView(param1,param1);
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar2 = *(int **)(iVar1 + 0x28);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_InitViewComplete__
		             ,0);
		  iVar1 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x298) * 4))
		            (piVar2,param1_00,*(undefined4 *)(iVar1 + 0x29c));
		  return;
		}
		*/

		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D65")]
		[Address(RVA = "0x7DE3", Offset = "0x7DE3", VA = "0x7DE3")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__SetupView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  
		  if (DAT_ram_00a5746d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_InitViewComplete__
		              );
		    DAT_ram_00a5746d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar2 = *(int **)(iVar1 + 0x28);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_InitViewComplete__
		             ,0);
		  iVar1 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2a0) * 4))
		            (piVar2,param1_00,*(undefined4 *)(iVar1 + 0x2a4));
		  Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__InitViewComplete(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D66")]
		[Address(RVA = "0x7DE4", Offset = "0x7DE4", VA = "0x7DE4")]
		private void InitViewComplete()
		{
		/* --- GHIDRA: InitViewComplete ---
		void Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__InitViewComplete
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a5746e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__MilestonesEventSectionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_MilestoneData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MilestoneData__get_Count__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_HandleActivityClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_ListOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MilestoneData__ResetItems__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_GameActivityData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Events_UnityEvent_GameActivityData__AddListener__);
		    DAT_ram_00a5746e = '\x01';
		  }
		  iVar1 = Gameplay_GdEvents_Model_GdEventData__ResetMilestones
		                    (*(undefined4 *)(param1[2] + 0x4c),*(undefined4 *)(param1[2] + 0x24),0);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		              (*(undefined4 *)(*(int *)(iVar2 + 0x28) + 0xa8),iVar1,0,
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MilestoneData__ResetItems__
		              );
		    Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__TrySelect
		              (param1,*(undefined4 *)(*(int *)(param1[2] + 0x4c) + 0x34),param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = *(undefined4 *)(iVar1 + 0x28);
		    uVar3 = unnamed_function_1417(System_Action_MilestoneData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_ListOnClickEvent__
		               ,0);
		    Gameplay_GdEvents_View_Milestone_MilestoneItemView_BgConfig___ctor(uVar4,uVar3,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = *(undefined4 *)(iVar1 + 0x60);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_GameActivityData__TypeInfo);
		    func_ii_7054(uVar3,param1,
		                 Method_Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_HandleActivityClickEvent__
		                 ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar4,uVar3,Method_UnityEngine_Events_UnityEvent_GameActivityData__AddListener__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D67")]
		[Address(RVA = "0x7DE5", Offset = "0x7DE5", VA = "0x7DE5")]
		private void SetupViewComplete()
		{
		/* --- GHIDRA: SetupViewComplete ---
		void Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__SetupViewComplete
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57470 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__MilestonesEventSectionView__get_Model__
		              );
		    DAT_ram_00a57470 = '\x01';
		  }
		  if (param2 != *(int *)(*(int *)(*(int *)(param1 + 8) + 0x4c) + 0x34)) {
		    Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__TrySelect(param1,param2,param2);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D68")]
		[Address(RVA = "0x7DE6", Offset = "0x7DE6", VA = "0x7DE6")]
		private void ListOnClickEvent(MilestoneData data)
		{
		/* --- GHIDRA: ListOnClickEvent ---
		void Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__ListOnClickEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__HandleActivityClickEvent
		            (param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D69")]
		[Address(RVA = "0x7DE7", Offset = "0x7DE7", VA = "0x7DE7")]
		private void HandleCurrentMilestoneRewardUpdatedEvent(MilestoneData milestone)
		{
		/* --- GHIDRA: HandleCurrentMilestoneRewardUpdatedEvent ---
		void Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__HandleCurrentMilestoneRewardUpdatedEvent
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5746f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__MilestonesEventSectionView__get_Model__
		              );
		    DAT_ram_00a5746f = '\x01';
		  }
		  Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__TryShowRewards
		            (param1,*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x4c) + 0x34),param1);
		  return;
		}
		*/

		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D6A")]
		[Address(RVA = "0x7DE8", Offset = "0x7DE8", VA = "0x7DE8")]
		private void HandleContentChangedEvent()
		{
		/* --- GHIDRA: HandleContentChangedEvent ---
		uint Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__HandleContentChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57470 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__MilestonesEventSectionView__get_Model__
		              );
		    DAT_ram_00a57470 = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(*(int *)(param1 + 8) + 0x4c) + 0x34);
		  if (param2 != iVar1) {
		    Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__TrySelect(param1,param2,param2);
		  }
		  return (uint)(param2 != iVar1);
		}
		*/

		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x00008C70 File Offset: 0x00006E70
		[Token(Token = "0x6002D6B")]
		[Address(RVA = "0x7DE9", Offset = "0x7DE9", VA = "0x7DE9")]
		private bool TrySelect(MilestoneData milestone)
		{
		/* --- GHIDRA: TrySelect ---
		void Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__TrySelect
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  undefined4 param5;
		  int iVar8;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57471 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__MilestonesEventSectionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_GdEventsScope_Args_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MilestoneData__NotifyListChangedExternally__
		              );
		    DAT_ram_00a57471 = '\x01';
		  }
		  Gameplay_GdEvents_Model_GdEventData__GetProgressState(*(undefined4 *)(param1[2] + 0x4c),param2,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___InsertOneAtStart
		            (*(undefined4 *)(*(int *)(iVar2 + 0x28) + 0xa8),0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MilestoneData__NotifyListChangedExternally__
		            );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(iVar2 + 0x24);
		  if (DAT_ram_00a65d3f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector2_TypeInfo);
		    DAT_ram_00a65d3f = '\x01';
		  }
		  local_10 = *(undefined8 *)(*(int *)(UnityEngine_Vector2_TypeInfo + 0x5c) + 8);
		  local_8 = local_10;
		  UnityEngine_UI_ScrollRect__get_normalizedPosition(uVar6,&local_10,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar7 = *(int **)(iVar2 + 0x1c);
		  uVar6 = Google_Protobuf_Collections_RepeatedField_object___get_Item(*(undefined4 *)(param2 + 8),0)
		  ;
		  iVar2 = *piVar7;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar7,uVar6,*(undefined4 *)(iVar2 + 0x2d4));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar7 = *(int **)(iVar2 + 0x20);
		  uVar6 = Core_Extensions_Dict_MedalRankDicExt__GetFrameAssetId(*(undefined4 *)(param2 + 8),0);
		  iVar2 = *piVar7;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar7,uVar6,*(undefined4 *)(iVar2 + 0x2d4));
		  iVar8 = *param1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar8 + 0x15c));
		  uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x2c),0);
		  uVar3 = Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__HandleRewards
		                    (param1,param2,iVar8);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar6,uVar3,0);
		  iVar8 = *param1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar8 + 0x15c));
		  uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x38),0);
		  uVar3 = Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__HandleGifts
		                    (param1,param2,iVar8);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar6,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x3c),0);
		  if (DAT_ram_00a57477 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__MilestonesEventSectionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_GameActivityDic_Types_URI__get_Count__
		              );
		    DAT_ram_00a57477 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(*(int *)(param2 + 8) + 0x24) + 0xc);
		  if (iVar2 != 0) {
		    uVar3 = Gameplay_GdEvents_Model_Milestone_MilestoneData__GetContentStageCount
		                      (param2,*(undefined4 *)(param1[2] + 0x18),0);
		    uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GdEvents_View_EventView_MilestonesEventSectionView__HandleActivityClickEvent
		              (uVar5,uVar3,0);
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar6,(uint)(iVar2 != 0),0);
		  uVar1 = 0;
		  Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__HandleActivityClickEvent
		            (param1,param2,0);
		  piVar7 = *(int **)(param1[2] + 0x3c);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		        goto code_r0x80d8b5ab;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80d8b5ab:
		  piVar7 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  uVar1 = 0;
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x100);
		        goto code_r0x80d8b62d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Application_IApp_TypeInfo,8);
		code_r0x80d8b62d:
		  iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  iVar2 = *(int *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x94) + 8);
		  if (iVar2 != 0) {
		    uVar1 = 0;
		    uVar6 = *(undefined4 *)(param2 + 0x1c);
		    piVar7 = *(int **)(param1[2] + 0x3c);
		    iVar8 = *piVar7;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe0);
		          goto code_r0x80d8b6c4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80d8b6c4:
		    uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		    param5 = *(undefined4 *)(param1[2] + 0x3c);
		    uVar5 = unnamed_function_1417(Core_Events_Scopes_GdEventsScope_Args_TypeInfo);
		    Core_Events_Scopes_GdEventsScope_CompletionsArgs__GetEventProperties
		              (uVar5,uVar6,param2,uVar3,param5,0);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar5,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D6C")]
		[Address(RVA = "0x7DEA", Offset = "0x7DEA", VA = "0x7DEA")]
		private void Select(MilestoneData milestone)
		{
		/* --- GHIDRA: Select ---
		void Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__Select
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  byte bVar1;
		  uint uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  int param3_00;
		  int iVar8;
		  undefined4 param6;
		  undefined1 local_5;
		  int *local_4;
		  
		  if (DAT_ram_00a57472 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__MilestonesEventSectionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_GdEventsScope_Args_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Rounting_ILocatorRepository_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Rounting_ILocator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_GameActivityRouting_IRouter_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28637);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2905);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2906);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10639);
		    DAT_ram_00a57472 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  piVar6 = *(int **)(*(int *)(param1 + 8) + 0x3c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x80d8bef0;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80d8bef0:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar2 = 0;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0x100);
		        goto code_r0x80d8bf72;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,8);
		code_r0x80d8bf72:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  iVar7 = *(int *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x94) + 0xc);
		  if (iVar7 != 0) {
		    uVar2 = 0;
		    param3_00 = *(int *)(*(int *)(*(int *)(param1 + 8) + 0x4c) + 0x34);
		    uVar4 = *(undefined4 *)(param3_00 + 0x1c);
		    piVar6 = *(int **)(*(int *)(param1 + 8) + 0x3c);
		    iVar8 = *piVar6;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + iVar8 + 0xe0);
		          goto code_r0x80d8c013;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80d8c013:
		    uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    param6 = *(undefined4 *)(*(int *)(param1 + 8) + 0x3c);
		    param1_00 = unnamed_function_1417(Core_Events_Scopes_GdEventsScope_Args_TypeInfo);
		    Core_Events_Scopes_GdEventsScope_Args___ctor(param1_00,uVar4,param3_00,param2,uVar5,param6,0);
		    (**(code **)((ulonglong)*(uint *)(iVar7 + 0xc) * 4))
		              (*(undefined4 *)(iVar7 + 0x20),param1_00,*(undefined4 *)(iVar7 + 0x14));
		  }
		  uVar4 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(param2,0);
		  iVar7 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar4,0);
		  bVar1 = *(byte *)(*(int *)(*(int *)(*(int *)(param1 + 8) + 0x4c) + 0x10) + 0x10);
		  uVar2 = (uint)bVar1;
		  if ((iVar7 == 0) && (uVar2 = 0, bVar1 != 0)) {
		    uVar4 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(param2,0);
		    uVar5 = unnamed_function_1417(System_Uri_TypeInfo);
		    UI_Windows_ClosableBaseWindow_object___HandleCloseButton(uVar5,uVar4,0);
		    piVar6 = *(int **)(*(int *)(param1 + 8) + 0x28);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_GameActivityRouting_IRouter_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		          puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80d8c12b;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_Managers_GameActivityRouting_IRouter_TypeInfo
		                                  ,0);
		code_r0x80d8c12b:
		    piVar6 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    uVar2 = 0;
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_Rounting_ILocatorRepository_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		          puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80d8c1b4;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Rounting_ILocatorRepository_TypeInfo,0);
		code_r0x80d8c1b4:
		    iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,uVar5,&local_4,puVar3[1]);
		    piVar6 = local_4;
		    if (iVar7 == 0) {
		      uVar4 = func_ii_4419(StringLiteral_2905,param2,0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      func_ii_7830(uVar4,0);
		    }
		    else {
		      uVar2 = 0;
		      iVar7 = *local_4;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (Core_Rounting_ILocator_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0xd0);
		            goto code_r0x80d8c235;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		      }
		      puVar3 = (uint *)func_ii_1080(local_4,Core_Rounting_ILocator_TypeInfo,2);
		code_r0x80d8c235:
		      iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,uVar5,puVar3[1]);
		      piVar6 = local_4;
		      if (iVar7 == 0) {
		        uVar4 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(param2,0);
		        uVar4 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                          (StringLiteral_10639,piVar6,uVar4,0);
		        if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		          func_ii_306000(OKG_Logs_Debug_TypeInfo);
		        }
		        func_ii_7830(uVar4,0);
		      }
		    }
		  }
		  else {
		    local_5 = (undefined1)uVar2;
		    uVar4 = func_ii_1081(DAT_ram_00a66944,&local_5);
		    uVar5 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(param2,0);
		    uVar4 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_28637,uVar4,uVar5,0);
		    uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_2906,uVar4,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar4,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D6D")]
		[Address(RVA = "0x7DEB", Offset = "0x7DEB", VA = "0x7DEB")]
		private void HandleActivityClickEvent(GameActivityData activity)
		{
		/* --- GHIDRA: HandleActivityClickEvent ---
		void Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__HandleActivityClickEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  int local_4;
		  
		  if (DAT_ram_00a57473 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_IRewardProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a57473 = '\x01';
		  }
		  local_4 = 0;
		  uVar3 = *(undefined4 *)(*(int *)(param2 + 8) + 0xc);
		  uVar4 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x1c) + 0x10) + 0xc);
		  piVar5 = *(int **)(*(int *)(param2 + 0x1c) + 0x24);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_GdEvents_Model_IRewardProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		        goto code_r0x80d8bb2b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_GdEvents_Model_IRewardProvider_TypeInfo,4);
		code_r0x80d8bb2b:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar4,uVar3,&local_4,puVar2[1]);
		  iVar7 = *param1;
		  if (iVar6 == 0) {
		    uVar3 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x148) * 4))
		                      (param1,*(undefined4 *)(iVar7 + 0x14c));
		    Gameplay_GdEvents_Control_GdEventsController__GetCategories
		              (uVar3,*(undefined4 *)(param2 + 0x1c),param2,0);
		  }
		  else {
		    iVar6 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x158) * 4))
		                      (param1,*(undefined4 *)(iVar7 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar6 + 0x30),0);
		    uVar4 = *(undefined4 *)(local_4 + 0x10);
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    iVar6 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar4,0);
		    iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar5 = (int *)func_ii_7307(*(undefined4 *)(iVar7 + 0x34),iVar6,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xf0) * 4))(piVar5,*(undefined4 *)(*piVar5 + 0xf4));
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(*(int *)(iVar6 + 0xc) != 0),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D6E")]
		[Address(RVA = "0x7DEC", Offset = "0x7DEC", VA = "0x7DEC")]
		private void HandleRewards(MilestoneData milestone)
		{
		/* --- GHIDRA: HandleRewards ---
		undefined4
		Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__HandleRewards
		          (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int iVar2;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a57474 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__MilestonesEventSectionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Requirements_ListFillBehaviors_ListFillBehaviorWhitOutSeparation_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RestrictionInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    DAT_ram_00a57474 = '\x01';
		  }
		  if ((*(char *)(*(int *)(*(int *)(param2 + 0x1c) + 0x10) + 0x10) != '\0') &&
		     (iVar2 = *(int *)(*(int *)(param2 + 8) + 0x2c), 0 < *(int *)(iVar2 + 0xc))) {
		    uVar1 = *(undefined4 *)(param1[2] + 8);
		    param1_00 = unnamed_function_1417
		                          (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___ctor
		              (param1_00,uVar1,uVar1,iVar2,0);
		    uVar1 = unnamed_function_1417
		                      (
		                      Core_Gameplay_Managers_Requirements_ListFillBehaviors_ListFillBehaviorWhitOutSeparation_TypeInfo
		                      );
		    *(undefined4 *)(param1_00 + 0x10) = uVar1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Requirements_RequirementsView__get_Data(*(undefined4 *)(iVar2 + 0x2c),param1_00,0);
		    uVar1 = 1;
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x00008C88 File Offset: 0x00006E88
		[Token(Token = "0x6002D6F")]
		[Address(RVA = "0x7DED", Offset = "0x7DED", VA = "0x7DED")]
		private bool TryShowRequirements(MilestoneData data)
		{
		/* --- GHIDRA: TryShowRequirements ---
		uint Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__TryShowRequirements
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar2 = (int *)func_ii_7307(*(undefined4 *)(iVar1 + 0x34),param2,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xf0) * 4))(piVar2,*(undefined4 *)(*piVar2 + 0xf4));
		  return (uint)(*(int *)(param2 + 0xc) != 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x00008CA0 File Offset: 0x00006EA0
		[Token(Token = "0x6002D70")]
		[Address(RVA = "0x7DEE", Offset = "0x7DEE", VA = "0x7DEE")]
		private bool TryShowRewards(RewardData[] rewards)
		{
		/* --- GHIDRA: TryShowRewards ---
		void Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__TryShowRewards
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57475 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_SocialGiftDic__set_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__MilestonesEventSectionView__get_Model__
		              );
		    DAT_ram_00a57475 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x5c),0);
		  param2_00 = Gameplay_GdEvents_Model_Milestone_MilestoneData__TryGetMonster
		                        (param2,*(undefined4 *)(param1[2] + 0x18),*(undefined4 *)(param1[2] + 0x38),
		                         &local_4,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_object___get_Data
		            (*(undefined4 *)(iVar1 + 0x5c),local_4,
		             Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_SocialGiftDic__set_Data__
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D71")]
		[Address(RVA = "0x7DEF", Offset = "0x7DEF", VA = "0x7DEF")]
		private void HandleGifts(MilestoneData data)
		{
		/* --- GHIDRA: HandleGifts ---
		uint Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__HandleGifts
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57476 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_CollectionData__set_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_MedalDicWrapper__set_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_MonsterData__set_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_AprDicWrapper__set_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_ArtikulData__set_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__MilestonesEventSectionView__get_Model__
		              );
		    DAT_ram_00a57476 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  local_c = 0;
		  local_10 = 0;
		  local_14 = 0;
		  iVar1 = Gameplay_GdEvents_Model_Milestone_MilestoneData___ctor(param2,0);
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x48),0);
		    uVar4 = Gameplay_GdEvents_Model_Milestone_MilestoneData__GetActivities
		                      (param2,*(undefined4 *)(param1[2] + 0x18),&local_4,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,uVar4,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_object___get_Data
		              (*(undefined4 *)(iVar2 + 0x48),local_4,
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_ArtikulData__set_Data__
		              );
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x4c),0);
		    uVar4 = Gameplay_GdEvents_Model_Milestone_MilestoneData__TryGetArtikuls
		                      (param2,*(undefined4 *)(param1[2] + 0x18),&local_8,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,uVar4,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_object___get_Data
		              (*(undefined4 *)(iVar2 + 0x4c),local_8,
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_MedalDicWrapper__set_Data__
		              );
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x50),0);
		    uVar4 = Gameplay_GdEvents_Model_Milestone_MilestoneData__TryGetMedals
		                      (param2,*(undefined4 *)(param1[2] + 0x18),&local_c,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,uVar4,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_object___get_Data
		              (*(undefined4 *)(iVar2 + 0x50),local_c,
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_AprDicWrapper__set_Data__
		              );
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x54),0);
		    uVar4 = Gameplay_GdEvents_Model_Milestone_MilestoneData__TryGetAvatars
		                      (param2,*(undefined4 *)(param1[2] + 0x18),&local_10,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,uVar4,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_object___get_Data
		              (*(undefined4 *)(iVar2 + 0x54),local_10,
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_CollectionData__set_Data__
		              );
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x58),0);
		    uVar4 = Gameplay_GdEvents_Model_Milestone_MilestoneData__TryGetCollections
		                      (param2,*(undefined4 *)(param1[2] + 0x18),&local_14,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,uVar4,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_object___get_Data
		              (*(undefined4 *)(iVar2 + 0x58),local_14,
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_MonsterData__set_Data__
		              );
		    Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__TryShowRewards
		              (param1,param2,param1);
		  }
		  return (uint)(iVar1 != 0);
		}
		*/

		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x00008CB8 File Offset: 0x00006EB8
		[Token(Token = "0x6002D72")]
		[Address(RVA = "0x7DF0", Offset = "0x7DF0", VA = "0x7DF0")]
		private bool TryShowStages(MilestoneData data)
		{
		/* --- GHIDRA: TryShowStages ---
		uint Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__TryShowStages
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a57477 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__MilestonesEventSectionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_GameActivityDic_Types_URI__get_Count__
		              );
		    DAT_ram_00a57477 = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(*(int *)(param2 + 8) + 0x24) + 0xc);
		  if (iVar1 != 0) {
		    param2_00 = Gameplay_GdEvents_Model_Milestone_MilestoneData__GetContentStageCount
		                          (param2,*(undefined4 *)(param1[2] + 0x18),0);
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GdEvents_View_EventView_MilestonesEventSectionView__HandleActivityClickEvent
		              (param1_00,param2_00,0);
		  }
		  return (uint)(iVar1 != 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x00008CD0 File Offset: 0x00006ED0
		[Token(Token = "0x6002D73")]
		[Address(RVA = "0x7DF1", Offset = "0x7DF1", VA = "0x7DF1")]
		private bool TryShowActivity(MilestoneData data)
		{
		/* --- GHIDRA: TryShowActivity ---
		void Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__TryShowActivity
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57478 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventsIndexEpView__Dispose__
		              );
		    DAT_ram_00a57478 = '\x01';
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventsIndexEpView__Dispose__
		            );
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

			return default(bool);
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5746a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__MilestonesEventSectionView__set_View__
		              );
		    DAT_ram_00a5746a = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a5746b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MilestoneData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_HandleActivityClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_InitViewComplete__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_ListOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_GameActivityData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Events_UnityEvent_GameActivityData__RemoveListener__);
		    DAT_ram_00a5746b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar3 = *(int **)(iVar1 + 0x28);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_InitViewComplete__
		             ,0);
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2a0) * 4))
		            (piVar3,uVar2,*(undefined4 *)(iVar1 + 0x2a4));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar1 + 0x28);
		  uVar2 = unnamed_function_1417(System_Action_MilestoneData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_ListOnClickEvent__
		             ,0);
		  Gameplay_GdEvents_View_Milestone_MilestonesListOsaView__add_ClickEvent(uVar4,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar1 + 0x60);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_GameActivityData__TypeInfo);
		  func_ii_7054(uVar2,param1,
		               Method_Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_HandleActivityClickEvent__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar4,uVar2,Method_UnityEngine_Events_UnityEvent_GameActivityData__RemoveListener__);
		  return;
		}
		*/

}
