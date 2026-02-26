using System;
using System.Collections.Generic;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.ListView;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BAB RID: 2987
	[Token(Token = "0x2000BAB")]
	public class BossListWindowMediator : AbstractViewMediator<BossModel, BossEvents, BossController, BossListWindow>
	{
		// Token: 0x06004932 RID: 18738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004932")]
		[Address(RVA = "0x97A4", Offset = "0x97A4", VA = "0x97A4", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Boss_Controller_BossListWindowMediator__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a578f9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossModel__BossEvents__BossController__BossListWindow___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_BossInstance____ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__List_BossInstance___TypeInfo);
		    DAT_ram_00a578f9 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_uint__List_BossInstance___TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_uint__List_BossInstance____ctor__);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_BossModel__BossEvents__BossController__BossListWindow___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004933 RID: 18739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004933")]
		[Address(RVA = "0x97A5", Offset = "0x97A5", VA = "0x97A5")]
		public BossListWindowMediator(BossModel model, BossEvents events, BossController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_Controller_BossListWindowMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a578fa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossModel__BossEvents__BossController__BossListWindow__set_View__
		              );
		    DAT_ram_00a578fa = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Boss_Controller_BossListWindowMediator__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Boss_Controller_BossListWindowMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000ED6 RID: 3798
		// (set) Token: 0x06004934 RID: 18740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ED6")]
		public override BossListWindow View
		{
			[Token(Token = "0x6004934")]
			[Address(RVA = "0x97A6", Offset = "0x97A6", VA = "0x97A6", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004935 RID: 18741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004935")]
		[Address(RVA = "0x97A7", Offset = "0x97A7", VA = "0x97A7")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Boss_Controller_BossListWindowMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a578fc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInstance__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossListWindowMediator_ActionButtonClickHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossListWindowMediator_BossListAdapterOnQuestionButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossListWindowMediator_BossListAdapterOnSelectedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossListWindowMediator_GreenToggleOnChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossListWindowMediator_TabBarOnChangeEvent__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a578fc = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x68),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x44);
		  uVar2 = unnamed_function_1417(System_Action_BossInstance__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossListWindowMediator_BossListAdapterOnQuestionButtonClickedEvent__
		             ,0);
		  Gameplay_Boss_View_ListView_BossListAdapter__remove_SelectedEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x40);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossListWindowMediator_TabBarOnChangeEvent__,0);
		  UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x44);
		  uVar2 = unnamed_function_1417(System_Action_BossInstance__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossListWindowMediator_BossListAdapterOnSelectedEvent__
		             ,0);
		  Gameplay_Boss_View_ListView_BossListAdapter__set_Data(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x4c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossListWindowMediator_ActionButtonClickHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x60);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossListWindowMediator_GreenToggleOnChangedEvent__,0);
		  UI_ToolTip_Controller_Android_ToolTipController__GetPointerPosition(uVar3,uVar2,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Boss_Controller_BossController__Dispose(uVar2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004936 RID: 18742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004936")]
		[Address(RVA = "0x97A8", Offset = "0x97A8", VA = "0x97A8")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Boss_Controller_BossListWindowMediator__SetupView
		               (int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined4 param5;
		  
		  if (DAT_ram_00a578fd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossModel__BossEvents__BossController__BossListWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_RequirementsWindow_RequirementsWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3657);
		    DAT_ram_00a578fd = '\x01';
		  }
		  uVar1 = *(undefined4 *)(*(int *)(param1 + 8) + 8);
		  param5 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(param2 + 8) + 0x30) + 0x10) + 0x14);
		  param1_00 = unnamed_function_1417(UI_Windows_RequirementsWindow_RequirementsWindowArgs_TypeInfo);
		  UI_Windows_RequirementsWindow_RequirementsWindowArgs___ctor(param1_00,uVar1,uVar1,0,param5,0,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3657,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = 0;
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  UI_Windows_RequirementsWindow__HandleContent(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004937 RID: 18743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004937")]
		[Address(RVA = "0x97A9", Offset = "0x97A9", VA = "0x97A9")]
		private void BossListAdapterOnQuestionButtonClickedEvent(BossInstance data)
		{
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004938")]
		[Address(RVA = "0x97AA", Offset = "0x97AA", VA = "0x97AA")]
		private void GreenToggleOnChangedEvent()
		{
		/* --- GHIDRA: GreenToggleOnChangedEvent ---
		void Gameplay_Boss_Controller_BossListWindowMediator__GreenToggleOnChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  
		  if (DAT_ram_00a578fe == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a578fe = '\x01';
		  }
		  uVar2 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar2);
		  uVar5 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  iVar3 = *(int *)(*(int *)(iVar3 + 0x44) + 0xac);
		  if ((iVar3 != 0) && (iVar3 = *(int *)(iVar3 + 8), iVar3 != 0)) {
		    iVar6 = *(int *)(*(int *)(iVar3 + 0x38) + 0x18);
		    if (iVar6 == 1) {
		      if (*(int *)(*(int *)(*(int *)(iVar3 + 0x28) + 0x20) + 0xc) == 1) {
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        uVar1 = 0;
		        piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar6 = *piVar7;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110
		                               );
		              goto code_r0x80dfaff2;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80dfaff2:
		        uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,CONCAT44(uVar5,puVar4[1]));
		        Core_Gameplay_Managers_WorldManager__GoHome
		                  (uVar5,*(undefined8 *)(*(int *)(*(int *)(iVar3 + 0x28) + 0x20) + 0x10),0);
		      }
		      else {
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        uVar1 = 0;
		        piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar6 = *piVar7;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110
		                               );
		              goto code_r0x80dfb0ae;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80dfb0ae:
		        uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,CONCAT44(uVar5,puVar4[1]));
		        Core_Gameplay_Managers_WorldManager__GoToUserIsleById
		                  (uVar5,*(undefined8 *)(*(int *)(*(int *)(iVar3 + 0x28) + 0x20) + 0x10),0);
		      }
		      uVar5 = System_Uri___ctor(0);
		      uVar5 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar5,0);
		      func_ii_8753(uVar5,0);
		      return;
		    }
		    if ((iVar6 != 2) && (iVar6 == 3)) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar6 = *piVar7;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x1e0);
		            goto code_r0x80dfb17e;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x80dfb17e:
		      uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,CONCAT44(uVar5,puVar4[1]));
		      Core_Gameplay_Managers_BossManager__ShowBossWindow
		                (uVar5,*(undefined8 *)(*(int *)(iVar3 + 0x28) + 0x10),6,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004939 RID: 18745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004939")]
		[Address(RVA = "0x97AB", Offset = "0x97AB", VA = "0x97AB")]
		private void ActionButtonClickHandler()
		{
		/* --- GHIDRA: ActionButtonClickHandler ---
		void Gameplay_Boss_Controller_BossListWindowMediator__ActionButtonClickHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a578ff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossModel__BossEvents__BossController__BossListWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3643);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3641);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3642);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3640);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3639);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3645);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3644);
		    DAT_ram_00a578ff = '\x01';
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (param2 == 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(iVar3 + 0x5c),1,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar3 + 0x48),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar7,0,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar3 + 0x4c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar7,0,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar3 + 0x58),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar7,0,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar3 + 0x68),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar7,0,0);
		  }
		  else {
		    uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar3 + 0x68),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar7,1,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(iVar3 + 0x68);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar3 = *piVar8;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x178);
		          goto code_r0x80dfb316;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80dfb316:
		    uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		    piVar8 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,2);
		    local_4 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(param2 + 8) + 0x30) + 0x14) + 0xc);
		    iVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		    if ((iVar3 != 0) && (iVar6 = func_ii_1082(iVar3,*(undefined4 *)(*piVar8 + 0x20)), iVar6 == 0)) {
		      uVar7 = func_ii_1083();
		      func_ii_1050(uVar7,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar8[4] = iVar3;
		    local_8 = *(undefined4 *)(*(int *)(*(int *)(param2 + 8) + 0x28) + 0x18);
		    iVar3 = func_ii_1081(DAT_ram_00a66954,&local_8);
		    if ((iVar3 != 0) && (iVar6 = func_ii_1082(iVar3,*(undefined4 *)(*piVar8 + 0x20)), iVar6 == 0)) {
		      uVar7 = func_ii_1083();
		      func_ii_1050(uVar7,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar8[5] = iVar3;
		    uVar2 = 0;
		    UI_MonoBehaviourWithStates_Int32Enum___set_CurrentState(uVar7,uVar5,piVar8,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(iVar3 + 0x5c),0,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar3 + 0x48),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar7,1,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar3 + 0x4c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar7,1,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar3 + 0x58),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar7,1,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = *(undefined4 *)(iVar3 + 0x48);
		    uVar7 = UI_Wiki_WikiUriRouter__SetData
		                      (*(undefined4 *)(*(int *)(*(int *)(param2 + 8) + 0x30) + 8),0);
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar5,uVar7,0);
		    iVar3 = *(int *)(*(int *)(*(int *)(param2 + 8) + 0x38) + 0x18);
		    if (iVar3 == 1) {
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar3 + 0x4c),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar7,1,0);
		      uVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3645,1,0,1,0,0,0,0);
		      Gameplay_Boss_View_ListView_BossListWindow__get_Wiki(uVar7,uVar5,0);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar3 + 100),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar7,1,0);
		      uVar7 = *(undefined4 *)(param1[2] + 8);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar3 = *piVar8;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x140);
		            goto code_r0x80dfb5e8;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80dfb5e8:
		      uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		      uVar5 = func_ii_7112(uVar5,0);
		      uVar2 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(param2 + 8) + 0x30) + 0x10) + 0x14);
		      iVar3 = unnamed_function_1417
		                        (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		      Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___ctor(iVar3,uVar7,uVar5,uVar2,0)
		      ;
		      *(undefined4 *)(iVar3 + 0x24) = StringLiteral_5;
		      iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      UI_Requirements_RequirementsView__get_Data(*(undefined4 *)(iVar6 + 100),iVar3,0);
		      if (*(char *)(*(int *)(*(int *)(param2 + 8) + 0x28) + 0x30) == '\0') {
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3641,1,0,1,0,0,0,0);
		      }
		      else {
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3640,1,0,1,0,0,0,0);
		      }
		    }
		    else if (iVar3 == 2) {
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar3 + 100),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar7,0,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3644,1,0,1,0,0,0,0);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar3 + 0x4c),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar7,0,0);
		    }
		    else if (iVar3 == 3) {
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar3 + 100),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar7,0,0);
		      iVar3 = *(int *)(param2 + 8);
		      if (DAT_ram_00a5787a == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_Google_Protobuf_Collections_RepeatedField_GetCaptainTeamListAns_Types_TeamRewardInfo__get_Count__
		                  );
		        DAT_ram_00a5787a = '\x01';
		      }
		      iVar3 = *(int *)(iVar3 + 0x44);
		      if ((iVar3 == 0) || (*(int *)(iVar3 + 0xc) < 1)) {
		        iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(iVar3 + 0x4c),0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar7,0,0);
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3642,1,0,1,0,0,0,0);
		      }
		      else {
		        iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(iVar3 + 0x4c),0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar7,1,0);
		        uVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3639,1,0,1,0,0,0,0);
		        Gameplay_Boss_View_ListView_BossListWindow__get_Wiki(uVar7,uVar5,0);
		        uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3643,1,0,1,0,0,0,0);
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar6 = **(int **)(iVar3 + 0x58);
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		              (*(int **)(iVar3 + 0x58),uVar2,*(undefined4 *)(iVar6 + 0x2d4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600493A RID: 18746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600493A")]
		[Address(RVA = "0x97AC", Offset = "0x97AC", VA = "0x97AC")]
		private void BossListAdapterOnSelectedEvent(BossInstance bossInstance)
		{
		/* --- GHIDRA: BossListAdapterOnSelectedEvent ---
		void Gameplay_Boss_Controller_BossListWindowMediator__BossListAdapterOnSelectedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Boss_Controller_BossListWindowMediator__TabBarOnChangeEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600493B RID: 18747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600493B")]
		[Address(RVA = "0x97AD", Offset = "0x97AD", VA = "0x97AD")]
		private void TabBarOnChangeEvent()
		{
		/* --- GHIDRA: TabBarOnChangeEvent ---
		void Gameplay_Boss_Controller_BossListWindowMediator__TabBarOnChangeEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 *puVar5;
		  int *piVar6;
		  undefined4 local_c;
		  undefined4 local_8;
		  int local_4;
		  
		  if (DAT_ram_00a57900 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_BossInstance___TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_BossInstance___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_BossInstance___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_BossInstance___);
		    Mono_Security_ASN1__get_Item(&System_Func_BossInstance__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BossInstance__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossListWindowMediator___c__RenderList_b__12_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossListWindowMediator___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3961);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    DAT_ram_00a57900 = '\x01';
		  }
		  local_4 = 0;
		  iVar4 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x40),0);
		  iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (iVar4,*(undefined4 *)(iVar1 + 0x14),&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__List_BossInstance___TryGetValue__
		                    );
		  if (iVar1 == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar1 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x40),0);
		    local_8 = *(undefined4 *)(iVar1 + 0x14);
		    uVar3 = func_ii_1081(DAT_ram_00a66958,&local_8);
		    uVar3 = func_ii_4419(StringLiteral_3961,uVar3,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar3,0);
		  }
		  else {
		    local_c = *(undefined4 *)(local_4 + 0xc);
		    local_8 = local_c;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar1 = local_4;
		    if (*(char *)(*(int *)(iVar4 + 0x60) + 0x48) != '\0') {
		      if (*(int *)(Gameplay_Boss_Controller_BossListWindowMediator___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Boss_Controller_BossListWindowMediator___c_TypeInfo);
		      }
		      puVar5 = *(undefined4 **)(Gameplay_Boss_Controller_BossListWindowMediator___c_TypeInfo + 0x5c)
		      ;
		      iVar4 = puVar5[1];
		      if (iVar4 == 0) {
		        if (*(int *)(Gameplay_Boss_Controller_BossListWindowMediator___c_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Gameplay_Boss_Controller_BossListWindowMediator___c_TypeInfo);
		          puVar5 = *(undefined4 **)
		                    (Gameplay_Boss_Controller_BossListWindowMediator___c_TypeInfo + 0x5c);
		        }
		        uVar3 = *puVar5;
		        iVar4 = unnamed_function_1417(System_Func_BossInstance__bool__TypeInfo);
		        System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                  (iVar4,uVar3,
		                   Method_Gameplay_Boss_Controller_BossListWindowMediator___c__RenderList_b__12_0__,
		                   0);
		        *(int *)(*(int *)(Gameplay_Boss_Controller_BossListWindowMediator___c_TypeInfo + 0x5c) + 4)
		             = iVar4;
		      }
		      uVar3 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                        (iVar1,iVar4,Method_System_Linq_Enumerable_Where_BossInstance___);
		      local_4 = System_Linq_Enumerable__Select_object__object_
		                          (uVar3,Method_System_Linq_Enumerable_ToList_BossInstance___);
		      local_8 = *(undefined4 *)(local_4 + 0xc);
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_ListView_BossListAdapter__RemoveItemsFrom
		              (*(undefined4 *)(iVar1 + 0x44),local_4,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar6 = *(int **)(iVar1 + 0x54);
		    uVar3 = func_ii_4443(&local_8,0);
		    uVar2 = func_ii_4443(&local_c,0);
		    uVar3 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (uVar3,StringLiteral_1618,uVar2,0);
		    iVar1 = *piVar6;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		              (piVar6,uVar3,*(undefined4 *)(iVar1 + 0x2d4));
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = *(undefined4 *)(iVar1 + 0x44);
		    uVar3 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                      (local_4,Method_System_Linq_Enumerable_FirstOrDefault_BossInstance___);
		    Gameplay_Boss_View_ListView_BossListAdapter__BossListItemViewOnSelectedEvent(uVar2,uVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600493C RID: 18748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600493C")]
		[Address(RVA = "0x97AE", Offset = "0x97AE", VA = "0x97AE")]
		private void RenderList()
		{
		/* --- GHIDRA: RenderList ---
		void Gameplay_Boss_Controller_BossListWindowMediator__RenderList(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Boss_Controller_BossController__Dispose(param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600493D RID: 18749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600493D")]
		[Address(RVA = "0x97AF", Offset = "0x97AF", VA = "0x97AF")]
		private void UpdateList()
		{
		/* --- GHIDRA: UpdateList ---
		void Gameplay_Boss_Controller_BossListWindowMediator__UpdateList
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57901 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossModel__BossEvents__BossController__BossListWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IList_BossInstance___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossListWindowMediator_InstanceListChangedEvent__);
		    DAT_ram_00a57901 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_IList_BossInstance___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Boss_Controller_BossListWindowMediator_InstanceListChangedEvent__,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_IList_BossInstance___TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_IList_BossInstance___TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x14) = iVar4;
		      uVar2 = System_Action_IList_BossInstance___TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_IList_BossInstance___TypeInfo);
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
		    uVar5 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_IList_BossInstance___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Boss_Controller_BossListWindowMediator_InstanceListChangedEvent__,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_IList_BossInstance___TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_IList_BossInstance___TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x14) = iVar4;
		    uVar2 = System_Action_IList_BossInstance___TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_IList_BossInstance___TypeInfo);
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

		// Token: 0x17000ED7 RID: 3799
		// (set) Token: 0x0600493E RID: 18750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ED7")]
		public override BossEvents Events
		{
			[Token(Token = "0x600493E")]
			[Address(RVA = "0x97B0", Offset = "0x97B0", VA = "0x97B0", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600493F RID: 18751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600493F")]
		[Address(RVA = "0x97B1", Offset = "0x97B1", VA = "0x97B1")]
		private void InstanceListChangedEvent(IList<BossInstance> instances)
		{
		/* --- GHIDRA: InstanceListChangedEvent ---
		void Gameplay_Boss_Controller_BossListWindowMediator__InstanceListChangedEvent(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57903 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossListWindowMediator___c_TypeInfo);
		    DAT_ram_00a57903 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Boss_Controller_BossListWindowMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Boss_Controller_BossListWindowMediator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040027F3 RID: 10227
		[Token(Token = "0x40027F3")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, List<BossInstance>> _instancesByGroupId;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Boss_Controller_BossListWindowMediator__set_View(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a578fb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInstance__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossListWindowMediator_ActionButtonClickHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossListWindowMediator_BossListAdapterOnQuestionButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossListWindowMediator_BossListAdapterOnSelectedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossListWindowMediator_GreenToggleOnChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossListWindowMediator_TabBarOnChangeEvent__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a578fb = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x44);
		  uVar2 = unnamed_function_1417(System_Action_BossInstance__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossListWindowMediator_BossListAdapterOnQuestionButtonClickedEvent__
		             ,0);
		  Gameplay_Boss_View_ListView_BossListAdapter__add_QuestionButtonClickedEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x40);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossListWindowMediator_TabBarOnChangeEvent__,0);
		  UI_Tabs_TabBar__add_ChangeEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x44);
		  uVar2 = unnamed_function_1417(System_Action_BossInstance__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossListWindowMediator_BossListAdapterOnSelectedEvent__
		             ,0);
		  Gameplay_Boss_View_ListView_BossListAdapter__add_SelectedEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x60);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossListWindowMediator_GreenToggleOnChangedEvent__,0);
		  UI_Toggle_GreenToggle__add_ChangedEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x4c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossListWindowMediator_ActionButtonClickHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		/* WARNING: Removing unreachable block (ram,0x80dfc9c5) */
		
		void Gameplay_Boss_Controller_BossListWindowMediator__set_Events
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  int param2_00;
		  undefined4 uVar6;
		  int *piVar7;
		  int iVar8;
		  undefined4 uVar9;
		  undefined4 param1_00;
		  uint uVar10;
		  int iVar11;
		  int *piVar12;
		  int local_28;
		  int **local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  int *local_4;
		  
		  if (DAT_ram_00a57902 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_BossInstance___Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__int__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_BossInstance___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_uint__int___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_BossInstance___get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__int__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_BossInstance___get_Keys__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__int__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_BossInstance___set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_uint__int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderBy_TabBarItemData_BossGroupDic___uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToList_TabBarItemData_BossGroupDic____);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_BossInstance___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_BossInstance___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_BossInstance___get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_TabBarItemData_BossGroupDic___uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_BossInstance__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_BossInstance__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_BossInstance__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_BossInstance___GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TabBarItemData_BossGroupDic___Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BossInstance__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BossInstance___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TabBarItemData_BossGroupDic____ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_BossInstance__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_TabBarItemData_BossGroupDic___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_BossPossibleEmptyWindowStateController_WindowStates__set_CurrentState__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_BossGroupDic___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_BossGroupDic__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_BossGroupDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossListWindowMediator___c__InstanceListChangedEvent_b__16_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossListWindowMediator___c_TypeInfo);
		    DAT_ram_00a57902 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_10 = 0;
		  local_18 = 0;
		  iVar11 = *param2;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_BossInstance__TypeInfo ==
		          *(int *)(*(int *)(iVar11 + 0x58) + uVar10 * 8)) {
		        puVar1 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dfbcf9;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar10);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,System_Collections_Generic_ICollection_BossInstance__TypeInfo
		                                ,0);
		code_r0x80dfbcf9:
		  iVar11 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar11 < 1) {
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(iVar2 + 0x3c),1,
		               Method_UI_MonoBehaviourWithStates_BossPossibleEmptyWindowStateController_WindowStates__set_CurrentState__
		              );
		    return;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar2 + 0x3c),2,
		             Method_UI_MonoBehaviourWithStates_BossPossibleEmptyWindowStateController_WindowStates__set_CurrentState__
		            );
		  uVar3 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__int__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar3,Method_System_Collections_Generic_Dictionary_uint__int___ctor__);
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (param1[6],
		             Method_System_Collections_Generic_Dictionary_uint__List_BossInstance___Clear__);
		  iVar11 = *param2;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_BossInstance__TypeInfo ==
		          *(int *)(*(int *)(iVar11 + 0x58) + uVar10 * 8)) {
		        puVar1 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dfbddf;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar10);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_BossInstance__TypeInfo
		                                ,0);
		code_r0x80dfbddf:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  local_28 = 0;
		  local_24 = &local_4;
		  do {
		    piVar7 = local_4;
		    iVar11 = *local_4;
		    if (*(ushort *)(iVar11 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        piVar12 = (int *)(*(int *)(iVar11 + 0x58) + uVar10 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar12) {
		          puVar4 = (undefined4 *)(iVar11 + piVar12[1] * 8 + 0xc0);
		          goto code_r0x80dfbead;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar11 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80dfc5f2:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dfc5fa;
		    }
		code_r0x80dfbead:
		    DAT_ram_009d3e38 = 0;
		    iVar11 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		    piVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80dfc5f2;
		    if (iVar11 == 0) {
		      iVar11 = 7;
		      goto code_r0x80dfc647;
		    }
		    iVar11 = *local_4;
		    if (*(ushort *)(iVar11 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        piVar12 = (int *)(*(int *)(iVar11 + 0x58) + uVar10 * 8);
		        if (System_Collections_Generic_IEnumerator_BossInstance__TypeInfo == *piVar12) {
		          puVar4 = (undefined4 *)(iVar11 + piVar12[1] * 8 + 0xc0);
		          goto code_r0x80dfbf95;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar11 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_BossInstance__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80dfc269:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dfc5fa;
		    }
		code_r0x80dfbf95:
		    DAT_ram_009d3e38 = 0;
		    iVar11 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80dfc269;
		    if (DAT_ram_00a6456f == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&Core_Gameplay_Game_TypeInfo);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dfc5fa;
		      }
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar7;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        piVar12 = (int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8);
		        if (Core_Gameplay_IGame_TypeInfo == *piVar12) {
		          puVar4 = (undefined4 *)(piVar12[1] * 8 + iVar2 + 0x178);
		          goto code_r0x80dfc0b9;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                        Core_Gameplay_IGame_TypeInfo,0x17);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80dfc27d:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dfc5fa;
		    }
		code_r0x80dfc0b9:
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80dfc27d;
		    DAT_ram_009d3e38 = 0;
		    uVar6 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar6,0);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dfc5fa;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3a8,uVar6,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar11 + 8) + 0x28) + 0x1c),0);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dfc5fa;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,param1[6],
		                       *(undefined4 *)(iVar8 + 0x10),
		                       Method_System_Collections_Generic_Dictionary_uint__List_BossInstance___ContainsKey__
		                      );
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dfc5fa;
		    }
		    if (iVar5 == 0) {
		      uVar9 = *(undefined4 *)(iVar8 + 0x10);
		      iVar2 = param1[6];
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Collections_Generic_List_BossInstance__TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,uVar6,
		                   Method_System_Collections_Generic_List_BossInstance___ctor__);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,iVar2,uVar9,uVar6,
		                     Method_System_Collections_Generic_Dictionary_uint__List_BossInstance___set_Item__
		                    );
		          if (DAT_ram_009d3e38 != 1) goto code_r0x80dfc2a5;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dfc5fa;
		    }
		code_r0x80dfc2a5:
		    DAT_ram_009d3e38 = 0;
		    param2_00 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,param1[6],
		                           *(undefined4 *)(iVar8 + 0x10),
		                           Method_System_Collections_Generic_Dictionary_uint__List_BossInstance___get_Item__
		                          );
		    iVar5 = DAT_ram_009d3e38;
		    iVar2 = Method_System_Collections_Generic_List_BossInstance__Add__;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dfc5fa;
		    }
		    *(int *)(param2_00 + 0x10) = *(int *)(param2_00 + 0x10) + 1;
		    uVar10 = *(uint *)(param2_00 + 0xc);
		    if (uVar10 < *(uint *)(*(int *)(param2_00 + 8) + 0xc)) {
		      *(uint *)(param2_00 + 0xc) = uVar10 + 1;
		      *(int *)(*(int *)(param2_00 + 8) + uVar10 * 4 + 0x10) = iVar11;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,param2_00,iVar11,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dfc5fa;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3a9,uVar3,
		                       *(undefined4 *)(iVar8 + 0x10),
		                       Method_System_Collections_Generic_Dictionary_uint__int__ContainsKey__);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dfc5fa;
		    }
		    if (iVar5 == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3aa,uVar3,
		                 *(undefined4 *)(iVar8 + 0x10),0,
		                 Method_System_Collections_Generic_Dictionary_uint__int__set_Item__);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dfc5fa;
		      }
		    }
		    uVar6 = *(undefined4 *)(iVar8 + 0x10);
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3ab,uVar3,uVar6,
		                       Method_System_Collections_Generic_Dictionary_uint__int__get_Item__);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dfc5fa;
		    }
		    iVar11 = *(int *)(iVar11 + 8);
		    if (DAT_ram_00a5787d == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Math_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_00a5787d = '\x01';
		    }
		    if (DAT_ram_00a5787c == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (0x7ff,&Method_System_Collections_Generic_List_BossInviteData__get_Count__);
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_00a5787c = '\x01';
		    }
		    param1_00 = *(undefined4 *)(*(int *)(iVar11 + 0x2c) + 0xc);
		    DAT_ram_009d3e38 = 0;
		    uVar9 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x371,iVar11,uVar6);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,System_Math_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar11 = UnityEngine_Mathf__Max(param1_00,uVar9,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3aa,uVar3,uVar6,iVar8 + iVar11,
		               Method_System_Collections_Generic_Dictionary_uint__int__set_Item__);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dfc5fa:
		  iVar11 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar11 == iVar2) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar6);
		    local_28 = *piVar7;
		    iVar11 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		code_r0x80dfc647:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = *local_24;
		      if (piVar7 != (int *)0x0) {
		        uVar10 = 0;
		        iVar2 = *piVar7;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		              puVar1 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80dfc6c2;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		        }
		        puVar1 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x80dfc6c2:
		        (**(code **)((ulonglong)*puVar1 * 4))(piVar7,puVar1[1]);
		      }
		      if (local_28 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_28);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar11 != 0) &&
		         ((((iVar11 == 1 || (iVar11 == 2)) || (iVar11 == 3)) ||
		          (((iVar11 == 4 || (iVar11 == 5)) || ((iVar11 == 6 || (iVar11 != 7)))))))) {
		        return;
		      }
		      iVar11 = unnamed_function_1417
		                         (System_Collections_Generic_List_TabBarItemData_BossGroupDic___TypeInfo);
		      GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		                (iVar11,Method_System_Collections_Generic_List_TabBarItemData_BossGroupDic____ctor__
		                );
		      uVar6 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                        (param1[6],
		                         Method_System_Collections_Generic_Dictionary_uint__List_BossInstance___get_Keys__
		                        );
		      System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		                (&local_28,uVar6,
		                 Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_BossInstance___GetEnumerator__
		                );
		      local_10 = local_20;
		      local_18 = CONCAT44(local_24,local_28);
		      local_28 = 0;
		      local_24 = (int **)&local_18;
		code_r0x80dfc79c:
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3ad,&local_18,
		                           Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_BossInstance___MoveNext__
		                          );
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dfcb5d;
		        }
		        if (iVar8 == 0) {
		          iVar8 = 10;
		          iVar2 = local_28;
		          goto code_r0x80dfcbaa;
		        }
		        uVar6 = local_10._4_4_;
		        if (DAT_ram_00a6456f == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&Core_Gameplay_Game_TypeInfo);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80dfcb5d;
		          }
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar2 = *piVar7;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar10 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8);
		            if (Core_Gameplay_IGame_TypeInfo == *piVar12) {
		              puVar4 = (undefined4 *)(piVar12[1] * 8 + iVar2 + 0x178);
		              goto code_r0x80dfc8c7;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                            Core_Gameplay_IGame_TypeInfo,0x17);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80dfcb19:
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dfcb5d;
		        }
		code_r0x80dfc8c7:
		        DAT_ram_009d3e38 = 0;
		        uVar9 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80dfcb19;
		        DAT_ram_009d3e38 = 0;
		        uVar9 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar9,0);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dfcb5d;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3ae,uVar9,uVar6,0);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dfcb5d;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           UI_Tabs_TabBarItemData_BossGroupDic__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dfcb5d;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar6 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3b0,iVar8,0);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dfcb5d;
		        }
		        *(undefined4 *)(iVar2 + 0x10) = uVar6;
		        uVar6 = *(undefined4 *)(iVar8 + 0xc);
		        *(int *)(iVar2 + 0x20) = iVar8;
		        *(undefined4 *)(iVar2 + 0x14) = uVar6;
		        DAT_ram_009d3e38 = 0;
		        uVar6 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3ab,uVar3,uVar6,
		                           Method_System_Collections_Generic_Dictionary_uint__int__get_Item__);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3b1,iVar2,uVar6,0);
		        iVar8 = Method_System_Collections_Generic_List_TabBarItemData_BossGroupDic___Add__;
		        if (DAT_ram_009d3e38 == 1) break;
		        *(int *)(iVar11 + 0x10) = *(int *)(iVar11 + 0x10) + 1;
		        uVar10 = *(uint *)(iVar11 + 0xc);
		        if (uVar10 < *(uint *)(*(int *)(iVar11 + 8) + 0xc)) {
		          *(uint *)(iVar11 + 0xc) = uVar10 + 1;
		          *(int *)(*(int *)(iVar11 + 8) + uVar10 * 4 + 0x10) = iVar2;
		          goto code_r0x80dfc79c;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar11,iVar2,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dfcb5d:
		      iVar2 = global_1;
		      iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar2 == iVar8) {
		        piVar7 = (int *)import::env::__cxa_begin_catch(uVar6);
		        iVar2 = *piVar7;
		        iVar8 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_28 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 != 1) {
		code_r0x80dfcbaa:
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if (iVar8 != 0) {
		            if (iVar8 == 1) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar8 == 2) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar8 == 3) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar8 == 4) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar8 == 5) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar8 == 6) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar8 == 7) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar8 == 8) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar8 == 9) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar8 != 10) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		          }
		          if (*(int *)(Gameplay_Boss_Controller_BossListWindowMediator___c_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Gameplay_Boss_Controller_BossListWindowMediator___c_TypeInfo);
		          }
		          puVar4 = *(undefined4 **)
		                    (Gameplay_Boss_Controller_BossListWindowMediator___c_TypeInfo + 0x5c);
		          iVar2 = puVar4[2];
		          if (iVar2 == 0) {
		            if (*(int *)(Gameplay_Boss_Controller_BossListWindowMediator___c_TypeInfo + 0x74) == 0)
		            {
		              func_ii_306000(Gameplay_Boss_Controller_BossListWindowMediator___c_TypeInfo);
		              puVar4 = *(undefined4 **)
		                        (Gameplay_Boss_Controller_BossListWindowMediator___c_TypeInfo + 0x5c);
		            }
		            uVar3 = *puVar4;
		            iVar2 = unnamed_function_1417(System_Func_TabBarItemData_BossGroupDic___uint__TypeInfo);
		            System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                      (iVar2,uVar3,
		                       Method_Gameplay_Boss_Controller_BossListWindowMediator___c__InstanceListChangedEvent_b__16_0__
		                       ,0);
		            *(int *)(*(int *)(Gameplay_Boss_Controller_BossListWindowMediator___c_TypeInfo + 0x5c) +
		                    8) = iVar2;
		          }
		          uVar3 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                            (iVar11,iVar2,
		                             Method_System_Linq_Enumerable_OrderBy_TabBarItemData_BossGroupDic___uint___
		                            );
		          uVar3 = System_Linq_Enumerable__Select_object__object_
		                            (uVar3,
		                             Method_System_Linq_Enumerable_ToList_TabBarItemData_BossGroupDic____);
		          iVar11 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                             (param1,*(undefined4 *)(*param1 + 0x15c));
		          UI_Tabs_TabBar__HandleSelected(*(undefined4 *)(iVar11 + 0x40),uVar3,0);
		          iVar11 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                             (param1,*(undefined4 *)(*param1 + 0x15c));
		          Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		                    (*(undefined4 *)(iVar11 + 0x40),0,0,0);
		          return;
		        }
		        uVar6 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3b2,&local_28);
		      goto joined_r0x80dfcce6;
		    }
		    uVar6 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3ac,&local_28);
		joined_r0x80dfcce6:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
