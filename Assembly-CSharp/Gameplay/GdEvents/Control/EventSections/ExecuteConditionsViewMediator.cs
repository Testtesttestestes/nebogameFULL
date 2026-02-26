using System;
using Core.Data;
using Gameplay.GdEvents.Model;
using Gameplay.GdEvents.View.EventView;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.GdEvents.Control.EventSections
{
	// Token: 0x02000771 RID: 1905
	[Token(Token = "0x2000771")]
	public class ExecuteConditionsViewMediator : AbstractViewMediator<GdEventsModel, GdEventsEvents, GdEventsController, ConditionsEventSectionView>
	{
		// Token: 0x06002D59 RID: 11609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D59")]
		[Address(RVA = "0x7DD7", Offset = "0x7DD7", VA = "0x7DD7")]
		public ExecuteConditionsViewMediator(GdEventsModel model, GdEventsEvents events, GdEventsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_Control_EventSections_ExecuteConditionsViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57464 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__ConditionsEventSectionView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_GdEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_ExecuteConditionsViewMediator_HandleCurrentEventRewardUpdatedEvent__
		              );
		    DAT_ram_00a57464 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x24);
		    uVar2 = unnamed_function_1417(System_Action_GdEventData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_GdEvents_Control_EventSections_ExecuteConditionsViewMediator_HandleCurrentEventRewardUpdatedEvent__
		               ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_GdEventData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x24) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_GdEventData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x24) = iVar4;
		      uVar2 = System_Action_GdEventData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_GdEventData__TypeInfo);
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
		    uVar5 = *(undefined4 *)(iVar1 + 0x24);
		    uVar2 = unnamed_function_1417(System_Action_GdEventData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_GdEvents_Control_EventSections_ExecuteConditionsViewMediator_HandleCurrentEventRewardUpdatedEvent__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_GdEventData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x24) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_GdEventData__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x24) = iVar4;
		    uVar2 = System_Action_GdEventData__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_GdEventData__TypeInfo);
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

		// Token: 0x170008B4 RID: 2228
		// (set) Token: 0x06002D5A RID: 11610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B4")]
		public override GdEventsEvents Events
		{
			[Token(Token = "0x6002D5A")]
			[Address(RVA = "0x7DD8", Offset = "0x7DD8", VA = "0x7DD8", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (set) Token: 0x06002D5B RID: 11611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B5")]
		public override ConditionsEventSectionView View
		{
			[Token(Token = "0x6002D5B")]
			[Address(RVA = "0x7DD9", Offset = "0x7DD9", VA = "0x7DD9", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5C")]
		[Address(RVA = "0x7DDA", Offset = "0x7DDA", VA = "0x7DDA")]
		private void HandleCurrentEventRewardUpdatedEvent(GdEventData evt)
		{
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5D")]
		[Address(RVA = "0x7DDB", Offset = "0x7DDB", VA = "0x7DDB")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_GdEvents_Control_EventSections_ExecuteConditionsViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  uint param2_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57466 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__ConditionsEventSectionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Requirements_ListFillBehaviors_ListFillBehaviorWhitOutSeparation_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RestrictionInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    DAT_ram_00a57466 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar3 = *(int **)(iVar1 + 0x1c);
		  uVar2 = Core_Extensions_Dict_GameEventExt__GetDescription
		                    (*(undefined4 *)(*(int *)(param1[2] + 0x4c) + 0x10),0);
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar3,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar1 + 0x20),
		             (uint)(*(char *)(*(int *)(*(int *)(param1[2] + 0x4c) + 0x10) + 0x10) == '\0'),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x2c),0);
		  iVar1 = *(int *)(*(int *)(param1[2] + 0x4c) + 0x10);
		  if (*(char *)(iVar1 + 0x10) == '\0') {
		    param2_00 = 0;
		  }
		  else {
		    param2_00 = (uint)(0 < *(int *)(*(int *)(iVar1 + 0x30) + 0xc));
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,param2_00,0);
		  iVar4 = *(int *)(param1[2] + 0x4c);
		  iVar1 = *(int *)(*(int *)(iVar4 + 0x10) + 0x30);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    uVar2 = *(undefined4 *)(param1[2] + 8);
		    iVar4 = unnamed_function_1417
		                      (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___ctor(iVar4,uVar2,uVar2,iVar1,0);
		    uVar2 = unnamed_function_1417
		                      (
		                      Core_Gameplay_Managers_Requirements_ListFillBehaviors_ListFillBehaviorWhitOutSeparation_TypeInfo
		                      );
		    *(undefined4 *)(iVar4 + 0x10) = uVar2;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Requirements_RequirementsView__get_Data(*(undefined4 *)(iVar1 + 0x2c),iVar4,0);
		    iVar4 = *(int *)(param1[2] + 0x4c);
		  }
		  Gameplay_GdEvents_Control_EventSections_ExecuteConditionsViewMediator__SetupView
		            (param1,iVar4,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5E")]
		[Address(RVA = "0x7DDC", Offset = "0x7DDC", VA = "0x7DDC")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_GdEvents_Control_EventSections_ExecuteConditionsViewMediator__SetupView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57467 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_IRewardProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a57467 = '\x01';
		  }
		  local_4 = 0;
		  uVar3 = *(undefined4 *)(*(int *)(param2 + 0x10) + 0xc);
		  piVar4 = *(int **)(param2 + 0x24);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_GdEvents_Model_IRewardProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x80d8aab7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Gameplay_GdEvents_Model_IRewardProvider_TypeInfo,3);
		code_r0x80d8aab7:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,uVar3,&local_4,puVar2[1]);
		  iVar6 = *param1;
		  if (iVar5 == 0) {
		    uVar3 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x148) * 4))
		                      (param1,*(undefined4 *)(iVar6 + 0x14c));
		    Gameplay_GdEvents_Control_GdEventsController__RequestRewards(uVar3,param2,0);
		  }
		  else {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x158) * 4))
		                      (param1,*(undefined4 *)(iVar6 + 0x15c));
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(iVar5 + 0x24),0);
		    uVar3 = local_4;
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    iVar5 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar3,0);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar4 = (int *)func_ii_7307(*(undefined4 *)(iVar6 + 0x28),iVar5,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xf0) * 4))(piVar4,*(undefined4 *)(*piVar4 + 0xf4));
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,(uint)(*(int *)(iVar5 + 0xc) != 0),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5F")]
		[Address(RVA = "0x7DDD", Offset = "0x7DDD", VA = "0x7DDD")]
		private void HandleRewards(GdEventData evt)
		{
		/* --- GHIDRA: HandleRewards ---
		uint Gameplay_GdEvents_Control_EventSections_ExecuteConditionsViewMediator__HandleRewards
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar2 = (int *)func_ii_7307(*(undefined4 *)(iVar1 + 0x28),param2,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xf0) * 4))(piVar2,*(undefined4 *)(*piVar2 + 0xf4));
		  return (uint)(*(int *)(param2 + 0xc) != 0);
		}
		*/

		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x00008C58 File Offset: 0x00006E58
		[Token(Token = "0x6002D60")]
		[Address(RVA = "0x7DDE", Offset = "0x7DDE", VA = "0x7DDE")]
		private bool TryShowRewards(RewardData[] rewards)
		{
		/* --- GHIDRA: TryShowRewards ---
		void Gameplay_GdEvents_Control_EventSections_ExecuteConditionsViewMediator__TryShowRewards
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a57468 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__MilestonesEventSectionView___ctor__
		              );
		    DAT_ram_00a57468 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__MilestonesEventSectionView___ctor__
		            );
		  return;
		}
		*/

			return default(bool);
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_GdEvents_Control_EventSections_ExecuteConditionsViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57465 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__ConditionsEventSectionView__set_View__
		              );
		    DAT_ram_00a57465 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_GdEvents_Control_EventSections_ExecuteConditionsViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_GdEvents_Control_EventSections_ExecuteConditionsViewMediator__set_View
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_GdEvents_Control_EventSections_ExecuteConditionsViewMediator__SetupView
		            (param1,param2,param2);
		  return;
		}
		*/

}
