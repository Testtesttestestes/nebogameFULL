using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.GdEvents.Model;
using Gameplay.GdEvents.View.EventView;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.GdEvents.Control.EventSections
{
	// Token: 0x0200076A RID: 1898
	[Token(Token = "0x200076A")]
	public class DescriptionViewMediator : AbstractViewMediator<GdEventsModel, GdEventsEvents, GdEventsController, DescriptionEventSectionView>
	{
		// Token: 0x06002D36 RID: 11574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D36")]
		[Address(RVA = "0x7DB4", Offset = "0x7DB4", VA = "0x7DB4")]
		public DescriptionViewMediator(GdEventsModel model, GdEventsEvents events, GdEventsController controller)
		{
		/* --- GHIDRA: <HandleBattlePass>g__GetAvailableOptions|16_1 ---
		void Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___HandleBattlePass_g__GetAvailableOptions_16_1
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a327 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo);
		    DAT_ram_00a5a327 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo);
		  **(undefined4 **)
		    (Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  uint *puVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  
		  if (DAT_ram_00a5a31b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__DescriptionEventSectionView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_GdEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_HandleCurrentEventRewardUpdatedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_InventoryChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a31b = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar7 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_GdEventData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_HandleCurrentEventRewardUpdatedEvent__
		               ,0);
		    iVar4 = func_ii_7048(uVar7,uVar3,0);
		    uVar3 = System_Action_GdEventData__TypeInfo;
		    if (iVar4 == 0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar4,System_Action_GdEventData__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar4,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar2 + 0x24) = iVar5;
		      uVar3 = System_Action_GdEventData__TypeInfo;
		      iVar2 = func_ii_1082(iVar4,System_Action_GdEventData__TypeInfo);
		      if (iVar2 == 0) {
		        System_Activator__CreateInstance(iVar4,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar8;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar6 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x120);
		          goto code_r0x812009f4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar6 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x812009f4:
		    iVar2 = (**(code **)((ulonglong)*puVar6 * 4))(piVar8,puVar6[1]);
		    iVar4 = *(int *)(iVar2 + 0x20);
		    uVar7 = *(undefined4 *)(iVar4 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_InventoryChangedEventHandler__
		               ,0);
		    piVar8 = (int *)func_ii_7048(uVar7,uVar3,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar8 == (int *)0x0) {
		      *(undefined4 *)(iVar4 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar8) ||
		            (*(int **)(iVar4 + 0x14) = piVar8, *piVar8 != iVar2)) {
		      System_Activator__CreateInstance(piVar8,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar7 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_GdEventData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_HandleCurrentEventRewardUpdatedEvent__
		               ,0);
		    iVar4 = UnityEngine_UI_Image__set_sprite(uVar7,uVar3,0);
		    uVar3 = System_Action_GdEventData__TypeInfo;
		    if (iVar4 == 0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar4,System_Action_GdEventData__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar4,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar2 + 0x24) = iVar5;
		      uVar3 = System_Action_GdEventData__TypeInfo;
		      iVar2 = func_ii_1082(iVar4,System_Action_GdEventData__TypeInfo);
		      if (iVar2 == 0) {
		        System_Activator__CreateInstance(iVar4,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar8;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar6 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x120);
		          goto code_r0x81200ba4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar6 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x81200ba4:
		    iVar2 = (**(code **)((ulonglong)*puVar6 * 4))(piVar8,puVar6[1]);
		    iVar4 = *(int *)(iVar2 + 0x20);
		    uVar7 = *(undefined4 *)(iVar4 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_InventoryChangedEventHandler__
		               ,0);
		    piVar8 = (int *)UnityEngine_UI_Image__set_sprite(uVar7,uVar3,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar8 == (int *)0x0) {
		      *(undefined4 *)(iVar4 + 0x14) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar8) || (*(int **)(iVar4 + 0x14) = piVar8, *piVar8 != iVar2))
		    {
		      System_Activator__CreateInstance(piVar8,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x170008B2 RID: 2226
		// (set) Token: 0x06002D37 RID: 11575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B2")]
		public override GdEventsEvents Events
		{
			[Token(Token = "0x6002D37")]
			[Address(RVA = "0x7DB5", Offset = "0x7DB5", VA = "0x7DB5", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D38")]
		[Address(RVA = "0x7DB6", Offset = "0x7DB6", VA = "0x7DB6")]
		private void InventoryChangedEventHandler()
		{
		/* --- GHIDRA: InventoryChangedEventHandler ---
		void Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__InventoryChangedEventHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__TryGetContentFromMilestones
		            (param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D39")]
		[Address(RVA = "0x7DB7", Offset = "0x7DB7", VA = "0x7DB7")]
		private void HandleCurrentEventRewardUpdatedEvent(GdEventData evt)
		{
		/* --- GHIDRA: HandleCurrentEventRewardUpdatedEvent ---
		void Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__HandleCurrentEventRewardUpdatedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5a31c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__DescriptionEventSectionView__set_View__
		              );
		    DAT_ram_00a5a31c = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x170008B3 RID: 2227
		// (set) Token: 0x06002D3A RID: 11578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B3")]
		public override DescriptionEventSectionView View
		{
			[Token(Token = "0x6002D3A")]
			[Address(RVA = "0x7DB8", Offset = "0x7DB8", VA = "0x7DB8", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D3B")]
		[Address(RVA = "0x7DB9", Offset = "0x7DB9", VA = "0x7DB9")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  int param2_00;
		  
		  if (DAT_ram_00a5a31e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__DescriptionEventSectionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_AprsButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_CollectionsButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_ItemsButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_MedalsButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_Categories_TimerStrings_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8341);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8334);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8338);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8335);
		    DAT_ram_00a5a31e = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(*(int *)(iVar1 + 0x30) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_AprsButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(*(int *)(iVar1 + 0x34) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_MedalsButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(*(int *)(iVar1 + 0x38) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_CollectionsButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_ItemsButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar7 = *(int **)(iVar1 + 0x1c);
		  uVar2 = Core_Extensions_Dict_GameEventExt__GetTitle
		                    (*(undefined4 *)(*(int *)(param1[2] + 0x4c) + 0x10),0);
		  iVar1 = *piVar7;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar7,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(iVar1 + 0x28);
		  uVar2 = Core_Extensions_Dict_GameEventExt__GetDescriptionExecConditions
		                    (*(undefined4 *)(*(int *)(param1[2] + 0x4c) + 0x10),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar6,uVar2,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_8335,1,0,1,0,0,0,0);
		  uVar6 = func_ii_7508(StringLiteral_8334,1,0,1,0,0,0,0);
		  uVar3 = func_ii_7508(StringLiteral_8341,1,0,1,0,0,0,0);
		  uVar4 = func_ii_7508(StringLiteral_8338,1,0,1,0,0,0,0);
		  iVar1 = unnamed_function_1417(Gameplay_GdEvents_Model_Categories_TimerStrings_TypeInfo);
		  if (DAT_ram_00a5a2f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5a2f5 = '\x01';
		  }
		  *(undefined4 *)(iVar1 + 0x18) = StringLiteral_5;
		  *(undefined4 *)(iVar1 + 0x14) = uVar4;
		  *(undefined4 *)(iVar1 + 0x10) = uVar3;
		  *(undefined4 *)(iVar1 + 0xc) = uVar6;
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = *(int *)(param1[2] + 0x4c);
		  iVar5 = *(int *)(iVar5 + 0x2c);
		  *(int *)(iVar5 + 0x24) = iVar1;
		  if (param2_00 != *(int *)(iVar5 + 0x28)) {
		    *(int *)(iVar5 + 0x28) = param2_00;
		    if (param2_00 == 0) {
		      UI_Elements_RightPanel_TitleWithLevel__set_Level(*(undefined4 *)(iVar5 + 0x18),0,0);
		    }
		    else {
		      UI_Elements_RightPanel_TitleWithLevel__set_Level
		                (*(undefined4 *)(iVar5 + 0x18),*(undefined4 *)(param2_00 + 0xc),0);
		      Gameplay_GdEvents_View_BackTimeView__HandleDataChanged(iVar5,param2_00,param1);
		    }
		  }
		  Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__TryGetContentFromMilestones
		            (param1,*(undefined4 *)(param1[2] + 0x4c),param1);
		  Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__TryShowRewards(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D3C")]
		[Address(RVA = "0x7DBA", Offset = "0x7DBA", VA = "0x7DBA")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__SetupView
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param2_00;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *piVar4;
		  int param1_02;
		  
		  if (DAT_ram_00a5a31f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__DescriptionEventSectionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_GameEventDic_Types_Milestone__IEnumerable_uint___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Predicate_AprData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__AprsButtonClickedEventHandler_b__9_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass9_0__AprsButtonClickedEventHandler_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass9_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo);
		    DAT_ram_00a5a31f = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass9_0_TypeInfo
		                        );
		  if (*(int *)(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo + 0x74)
		      == 0) {
		    func_ii_306000(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo);
		  }
		  piVar4 = *(int **)(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo +
		                    0x5c);
		  param1_02 = piVar4[1];
		  iVar2 = Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo;
		  if (param1_02 == 0) {
		    if (*(int *)(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo + 0x74
		                ) == 0) {
		      func_ii_306000(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo);
		      piVar4 = *(int **)(
		                        Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo
		                        + 0x5c);
		    }
		    iVar2 = *piVar4;
		    param1_02 = unnamed_function_1417
		                          (System_Func_GameEventDic_Types_Milestone__IEnumerable_uint___TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (param1_02,iVar2,
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__AprsButtonClickedEventHandler_b__9_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo +
		                     0x5c) + 4) = param1_02;
		  }
		  iVar2 = Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__ItemsButtonClickedEventHandler
		                    (param1,param1_02,param2_00 + 8,iVar2);
		  if (iVar2 != 0) {
		    uVar1 = 0;
		    piVar4 = *(int **)(*(int *)(param1 + 8) + 0x3c);
		    iVar2 = *piVar4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x138);
		          goto code_r0x81201957;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0xf);
		code_r0x81201957:
		    param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    param1_01 = unnamed_function_1417(System_Predicate_AprData__TypeInfo);
		    func_ii_7297(param1_01,param2_00,
		                 Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass9_0__AprsButtonClickedEventHandler_b__1__
		                 ,0);
		    Core_Gameplay_Managers_AprsManager__ShowAprsWindow(param1_00,param1_01,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D3D")]
		[Address(RVA = "0x7DBB", Offset = "0x7DBB", VA = "0x7DBB")]
		private void AprsButtonClickedEventHandler()
		{
		/* --- GHIDRA: AprsButtonClickedEventHandler ---
		void Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__AprsButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param2_00;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *piVar4;
		  int param1_02;
		  
		  if (DAT_ram_00a5a320 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__DescriptionEventSectionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_GameEventDic_Types_Milestone__IEnumerable_uint___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Predicate_MedalData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__MedalsButtonClickedEventHandler_b__10_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass10_0__MedalsButtonClickedEventHandler_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass10_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo);
		    DAT_ram_00a5a320 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass10_0_TypeInfo
		                        );
		  if (*(int *)(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo + 0x74)
		      == 0) {
		    func_ii_306000(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo);
		  }
		  piVar4 = *(int **)(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo +
		                    0x5c);
		  param1_02 = piVar4[2];
		  iVar2 = Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo;
		  if (param1_02 == 0) {
		    if (*(int *)(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo + 0x74
		                ) == 0) {
		      func_ii_306000(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo);
		      piVar4 = *(int **)(
		                        Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo
		                        + 0x5c);
		    }
		    iVar2 = *piVar4;
		    param1_02 = unnamed_function_1417
		                          (System_Func_GameEventDic_Types_Milestone__IEnumerable_uint___TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (param1_02,iVar2,
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__MedalsButtonClickedEventHandler_b__10_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo +
		                     0x5c) + 8) = param1_02;
		  }
		  iVar2 = Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__ItemsButtonClickedEventHandler
		                    (param1,param1_02,param2_00 + 8,iVar2);
		  if (iVar2 != 0) {
		    uVar1 = 0;
		    piVar4 = *(int **)(*(int *)(param1 + 8) + 0x3c);
		    iVar2 = *piVar4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x130);
		          goto code_r0x81201bd1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x81201bd1:
		    param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    param1_01 = unnamed_function_1417(System_Predicate_MedalData__TypeInfo);
		    func_ii_7297(param1_01,param2_00,
		                 Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass10_0__MedalsButtonClickedEventHandler_b__1__
		                 ,0);
		    Core_Gameplay_Managers_MedalsManager__ShowMedalsWindow(param1_00,param1_01,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002D3E RID: 11582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D3E")]
		[Address(RVA = "0x7DBC", Offset = "0x7DBC", VA = "0x7DBC")]
		private void MedalsButtonClickedEventHandler()
		{
		/* --- GHIDRA: MedalsButtonClickedEventHandler ---
		void Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__MedalsButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param2_00;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *piVar4;
		  int param1_02;
		  
		  if (DAT_ram_00a5a321 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__DescriptionEventSectionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_GameEventDic_Types_Milestone__IEnumerable_uint___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Predicate_CollectionData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__CollectionsButtonClickedEventHandler_b__11_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass11_0__CollectionsButtonClickedEventHandler_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass11_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo);
		    DAT_ram_00a5a321 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass11_0_TypeInfo
		                        );
		  if (*(int *)(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo + 0x74)
		      == 0) {
		    func_ii_306000(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo);
		  }
		  piVar4 = *(int **)(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo +
		                    0x5c);
		  param1_02 = piVar4[5];
		  iVar2 = Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo;
		  if (param1_02 == 0) {
		    if (*(int *)(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo + 0x74
		                ) == 0) {
		      func_ii_306000(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo);
		      piVar4 = *(int **)(
		                        Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo
		                        + 0x5c);
		    }
		    iVar2 = *piVar4;
		    param1_02 = unnamed_function_1417
		                          (System_Func_GameEventDic_Types_Milestone__IEnumerable_uint___TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (param1_02,iVar2,
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__CollectionsButtonClickedEventHandler_b__11_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo +
		                     0x5c) + 0x14) = param1_02;
		  }
		  iVar2 = Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__ItemsButtonClickedEventHandler
		                    (param1,param1_02,param2_00 + 8,iVar2);
		  if (iVar2 != 0) {
		    uVar1 = 0;
		    piVar4 = *(int **)(*(int *)(param1 + 8) + 0x3c);
		    iVar2 = *piVar4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x280);
		          goto code_r0x81201d79;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x38);
		code_r0x81201d79:
		    param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    param1_01 = unnamed_function_1417(System_Predicate_CollectionData__TypeInfo);
		    func_ii_7297(param1_01,param2_00,
		                 Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass11_0__CollectionsButtonClickedEventHandler_b__1__
		                 ,0);
		    Core_Gameplay_Managers_CollectionsManager__ShowOwnCollectionsWindow(param1_00,param1_01,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D3F")]
		[Address(RVA = "0x7DBD", Offset = "0x7DBD", VA = "0x7DBD")]
		private void CollectionsButtonClickedEventHandler()
		{
		/* --- GHIDRA: CollectionsButtonClickedEventHandler ---
		void Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__CollectionsButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param2_00;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *piVar4;
		  int param1_02;
		  
		  if (DAT_ram_00a5a322 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__DescriptionEventSectionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_ArtifactFilterDelegate_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_GameEventDic_Types_Milestone__IEnumerable_uint___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__ItemsButtonClickedEventHandler_b__12_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass12_0__ItemsButtonClickedEventHandler_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass12_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo);
		    DAT_ram_00a5a322 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass12_0_TypeInfo
		                        );
		  if (*(int *)(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo + 0x74)
		      == 0) {
		    func_ii_306000(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo);
		  }
		  piVar4 = *(int **)(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo +
		                    0x5c);
		  param1_02 = piVar4[6];
		  iVar2 = Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo;
		  if (param1_02 == 0) {
		    if (*(int *)(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo + 0x74
		                ) == 0) {
		      func_ii_306000(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo);
		      piVar4 = *(int **)(
		                        Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo
		                        + 0x5c);
		    }
		    iVar2 = *piVar4;
		    param1_02 = unnamed_function_1417
		                          (System_Func_GameEventDic_Types_Milestone__IEnumerable_uint___TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (param1_02,iVar2,
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__ItemsButtonClickedEventHandler_b__12_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo +
		                     0x5c) + 0x18) = param1_02;
		  }
		  iVar2 = Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__ItemsButtonClickedEventHandler
		                    (param1,param1_02,param2_00 + 8,iVar2);
		  if (iVar2 != 0) {
		    uVar1 = 0;
		    piVar4 = *(int **)(*(int *)(param1 + 8) + 0x3c);
		    iVar2 = *piVar4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x120);
		          goto code_r0x81201f21;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x81201f21:
		    param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    param1_01 = unnamed_function_1417
		                          (
		                          Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_ArtifactFilterDelegate_TypeInfo
		                          );
		    Gameplay_Inventory_View_Chest_InventoryChestWindowOptions___ctor
		              (param1_01,param2_00,
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass12_0__ItemsButtonClickedEventHandler_b__1__
		               ,0);
		    Core_Gameplay_Managers_Inventory_InventoryManager__DismantleArtifact(param1_00,0,0,param1_01,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002D40 RID: 11584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D40")]
		[Address(RVA = "0x7DBE", Offset = "0x7DBE", VA = "0x7DBE")]
		private void ItemsButtonClickedEventHandler()
		{
		/* --- GHIDRA: ItemsButtonClickedEventHandler ---
		uint Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__ItemsButtonClickedEventHandler
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5a323 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__DescriptionEventSectionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_SelectMany_GameEventDic_Types_Milestone__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToHashSet_uint___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__get_Count__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8332);
		    DAT_ram_00a5a323 = '\x01';
		  }
		  uVar1 = System_Linq_Enumerable__SelectMany_ValueTuple_object__object___object_
		                    (*(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 8) + 0x4c) + 0x10) + 0x28),
		                     param2,
		                     Method_System_Linq_Enumerable_SelectMany_GameEventDic_Types_Milestone__uint___)
		  ;
		  iVar2 = System_Linq_Enumerable__ToHashSet_int_
		                    (uVar1,Method_System_Linq_Enumerable_ToHashSet_uint___);
		  *param3 = iVar2;
		  iVar2 = *(int *)(iVar2 + 0x10);
		  if (iVar2 == 0) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8332,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,1,param3_00,0);
		  }
		  return (uint)(iVar2 != 0);
		}
		*/

		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x00008B80 File Offset: 0x00006D80
		[Token(Token = "0x6002D41")]
		[Address(RVA = "0x7DBF", Offset = "0x7DBF", VA = "0x7DBF")]
		private bool TryGetContentFromMilestones(Func<GameEventDic.Types.Milestone, IEnumerable<uint>> getter, out HashSet<uint> result)
		{
		/* --- GHIDRA: TryGetContentFromMilestones ---
		void Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__TryGetContentFromMilestones
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
		  
		  if (DAT_ram_00a5a324 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_IRewardProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a5a324 = '\x01';
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
		        goto code_r0x812011da;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Gameplay_GdEvents_Model_IRewardProvider_TypeInfo,3);
		code_r0x812011da:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,uVar3,&local_4,puVar2[1]);
		  iVar6 = *param1;
		  if (iVar5 == 0) {
		    uVar3 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x148) * 4))
		                      (param1,*(undefined4 *)(iVar6 + 0x14c));
		    Gameplay_GdEvents_Control_GdEventsController__HandleGetEventMilestonesRewardsInfoService
		              (uVar3,param2,iVar6);
		  }
		  else {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x158) * 4))
		                      (param1,*(undefined4 *)(iVar6 + 0x15c));
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(iVar5 + 0x20),0);
		    uVar3 = local_4;
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    iVar5 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar3,0);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar4 = (int *)func_ii_7307(*(undefined4 *)(iVar6 + 0x24),iVar5,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xf0) * 4))(piVar4,*(undefined4 *)(*piVar4 + 0xf4));
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,(uint)(*(int *)(iVar5 + 0xc) != 0),0);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D42")]
		[Address(RVA = "0x7DC0", Offset = "0x7DC0", VA = "0x7DC0")]
		private void HandleRewards(GdEventData evt)
		{
		/* --- GHIDRA: HandleRewards ---
		uint Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__HandleRewards
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar2 = (int *)func_ii_7307(*(undefined4 *)(iVar1 + 0x24),param2,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xf0) * 4))(piVar2,*(undefined4 *)(*piVar2 + 0xf4));
		  return (uint)(*(int *)(param2 + 0xc) != 0);
		}
		*/

		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x00008B98 File Offset: 0x00006D98
		[Token(Token = "0x6002D43")]
		[Address(RVA = "0x7DC1", Offset = "0x7DC1", VA = "0x7DC1")]
		private bool TryShowRewards(RewardData[] rewards)
		{
		/* --- GHIDRA: TryShowRewards ---
		void Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__TryShowRewards
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 *puVar7;
		  int *piVar8;
		  int iVar9;
		  int *piVar10;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a5a325 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_ArtikulDicWrapper__uint__GetWrapper__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__DescriptionEventSectionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Distinct_uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_SelectMany_GameEventDic_Types_Milestone__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_uint___);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_GameEventDic_Types_Milestone__IEnumerable_uint___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__HandleBattlePass_b__16_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo);
		    DAT_ram_00a5a325 = '\x01';
		  }
		  iVar5 = *(int *)(*(int *)(param1[2] + 0x4c) + 0x10);
		  if (*(char *)(iVar5 + 0x10) == '\0') {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar4 + 0x40),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar6,0,0);
		    return;
		  }
		  uVar6 = *(undefined4 *)(iVar5 + 0x28);
		  if (*(int *)(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo + 0x74)
		      == 0) {
		    func_ii_306000(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo);
		  }
		  puVar7 = *(undefined4 **)
		            (Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo + 0x5c);
		  iVar5 = puVar7[7];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo + 0x74
		                ) == 0) {
		      func_ii_306000(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo);
		      puVar7 = *(undefined4 **)
		                (Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo + 0x5c
		                );
		    }
		    uVar3 = *puVar7;
		    iVar5 = unnamed_function_1417
		                      (System_Func_GameEventDic_Types_Milestone__IEnumerable_uint___TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar5,uVar3,
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__HandleBattlePass_b__16_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c_TypeInfo +
		                     0x5c) + 0x1c) = iVar5;
		  }
		  uVar6 = System_Linq_Enumerable__SelectMany_ValueTuple_object__object___object_
		                    (uVar6,iVar5,
		                     Method_System_Linq_Enumerable_SelectMany_GameEventDic_Types_Milestone__uint___)
		  ;
		  uVar6 = System_Linq_Enumerable__DefaultIfEmptyIterator___Il2CppFullySharedGenericType_
		                    (uVar6,Method_System_Linq_Enumerable_Distinct_uint___);
		  iVar5 = System_Linq_Enumerable__OrderBy_uint__uint_
		                    (uVar6,Method_System_Linq_Enumerable_ToArray_uint___);
		  if (0 < *(int *)(iVar5 + 0xc)) {
		    do {
		      uVar6 = *(undefined4 *)(iVar5 + iVar4 * 4 + 0x10);
		      piVar8 = *(int **)(param1[2] + 0x18);
		      iVar9 = *piVar8;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		          if (Core_Dict_IDictProvider_TypeInfo == *piVar10) {
		            puVar2 = (uint *)(piVar10[1] * 8 + iVar9 + 0xd8);
		            goto code_r0x81200e41;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar8,Core_Dict_IDictProvider_TypeInfo,3);
		code_r0x81200e41:
		      iVar9 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		      iVar9 = func_ii_7730(*(undefined4 *)(iVar9 + 8),uVar6,
		                           Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_ArtikulDicWrapper__uint__GetWrapper__
		                          );
		      if (*(int *)(*(int *)(iVar9 + 0x10) + 0x20) == 0x78) {
		        uVar1 = 0;
		        iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(iVar4 + 0x40),0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar6,1,0);
		        iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        iVar4 = *(int *)(iVar4 + 0x40);
		        piVar8 = *(int **)(param1[2] + 0x3c);
		        iVar5 = *piVar8;
		        if (*(ushort *)(iVar5 + 0xb6) == 0) goto code_r0x81200f1e;
		        goto code_r0x81200ee6;
		      }
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(iVar5 + 0xc));
		  }
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar4 + 0x40),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar6,0,0);
		  return;
		  while (uVar1 = uVar1 + 1, *(ushort *)(iVar5 + 0xb6) != uVar1) {
		code_r0x81200ee6:
		    if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		      puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x120);
		      goto code_r0x81200f28;
		    }
		  }
		code_r0x81200f1e:
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x81200f28:
		  uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  uVar3 = Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__HandleBattlePass
		                    (param1,iVar9);
		  if (DAT_ram_00a5a2ac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    DAT_ram_00a5a2ac = '\x01';
		  }
		  *(undefined4 *)(iVar4 + 0x1c) = uVar6;
		  iVar5 = *(int *)(iVar9 + 0x10);
		  uVar6 = *(undefined4 *)(iVar5 + 0x54);
		  *(undefined4 *)(iVar4 + 0x24) = uVar3;
		  *(undefined4 *)(iVar4 + 0x20) = uVar6;
		  uVar3 = *(undefined4 *)(iVar4 + 0x18);
		  uVar6 = Core_Extensions_Dict_AprMarkerDicExt__GetTitle(iVar5,0);
		  AssetContent_GameImage__get_AssetId(uVar3,uVar6,0);
		  Gameplay_GdEvents_View_EventView_BattlePassGroupView__Init
		            (iVar4,*(undefined4 *)(iVar4 + 0x20),iVar5);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002D44 RID: 11588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D44")]
		[Address(RVA = "0x7DC2", Offset = "0x7DC2", VA = "0x7DC2")]
		private void HandleBattlePass()
		{
		/* --- GHIDRA: HandleBattlePass ---
		undefined4
		Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__HandleBattlePass
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param2_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a326 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__DescriptionEventSectionView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_uint__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass16_0__HandleBattlePass_b__2__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass16_0_TypeInfo
		              );
		    DAT_ram_00a5a326 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass16_0_TypeInfo
		                        );
		  param1_00 = *(int **)(*(int *)(param1 + 8) + 0x3c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 400);
		        goto code_r0x812010b4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x812010b4:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  *(undefined4 *)(param2_00 + 8) = *(undefined4 *)(iVar4 + 0x2c);
		  param1_01 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 8) + 0x4c) + 0x10) + 0x34);
		  uVar3 = unnamed_function_1417(System_Func_uint__bool__TypeInfo);
		  System_Linq_Enumerable__ToArray_uint_
		            (uVar3,param2_00,
		             Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator___c__DisplayClass16_0__HandleBattlePass_b__2__
		             ,0);
		  uVar3 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (param1_01,uVar3,Method_System_Linq_Enumerable_Where_uint___);
		  uVar3 = System_Linq_Enumerable__ToList_MarkToMarkAdjustmentRecord_
		                    (uVar3,Method_System_Linq_Enumerable_ToList_uint___);
		  return uVar3;
		}
		*/

		}

		// Token: 0x06002D45 RID: 11589 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002D45")]
		[Address(RVA = "0x7DC3", Offset = "0x7DC3", VA = "0x7DC3")]
		[CompilerGenerated]
		private List<uint> <HandleBattlePass>g__GetAvailableOptions|16_1()
		{
			return null;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__set_Events
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__TryShowRewards(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5a31d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_AprsButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_CollectionsButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_ItemsButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_MedalsButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5a31d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x30) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_AprsButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x34) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_MedalsButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x38) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_CollectionsButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_GdEvents_Control_EventSections_DescriptionViewMediator_ItemsButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  return;
		}
		*/

}
