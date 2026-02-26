using System;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Gameplay.WorldAxis.Office.View.Schedule;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.WorldAxis.Office.Controller
{
	// Token: 0x020002E7 RID: 743
	[Token(Token = "0x20002E7")]
	public class WorldAxisScheduleViewMediator : AbstractViewMediator<WorldAxisOfficeModel, WorldAxisOfficeEvents, WorldAxisOfficeController, WorldAxisScheduleView>, IHideableMediator
	{
		// Token: 0x060011A8 RID: 4520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A8")]
		[Address(RVA = "0x63A5", Offset = "0x63A5", VA = "0x63A5")]
		public WorldAxisScheduleViewMediator(WorldAxisOfficeModel model, WorldAxisOfficeEvents events, WorldAxisOfficeController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58b80 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisScheduleView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_ColossusInfoButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_ToWorldAxisButtonClickedEventHandler__
		              );
		    DAT_ram_00a58b80 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x34) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_ColossusInfoButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x30) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_ToWorldAxisButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    func_ii_14558(*(undefined4 *)(*(int *)(iVar2 + 0x2c) + 0xb4),0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x34) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_ColossusInfoButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x30) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_ToWorldAxisButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator__set_View(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000299 RID: 665
		// (set) Token: 0x060011A9 RID: 4521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000299")]
		public override WorldAxisScheduleView View
		{
			[Token(Token = "0x60011A9")]
			[Address(RVA = "0x63A6", Offset = "0x63A6", VA = "0x63A6", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011AA")]
		[Address(RVA = "0x63A7", Offset = "0x63A7", VA = "0x63A7")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator__Init
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int *param1_01;
		  
		  if (DAT_ram_00a58b82 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisScheduleView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_ClansManager_ShowClanOfficeWindow__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_EnterSquadButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_4302);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17802);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17803);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17801);
		    DAT_ram_00a58b82 = '\x01';
		  }
		  iVar5 = *(int *)(*(int *)(param1[2] + 8) + 0x68);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(iVar2 + 0x28);
		  if (iVar5 != 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17803,1,0,1,0,0,0,0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar6,uVar4,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = UI_Rewards_AbstractRewardsRender__SetRewards
		                      (*(undefined4 *)(iVar2 + 0x2c),
		                       Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17801,1,0,1,0,0,0,0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar6,uVar4,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = *(undefined4 *)(*(int *)(iVar2 + 0x2c) + 0xb4);
		    uVar6 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar6,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_EnterSquadButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar4,uVar6,0);
		    return;
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17802,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar6,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = UI_Rewards_AbstractRewardsRender__SetRewards
		                    (*(undefined4 *)(iVar2 + 0x2c),
		                     Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4302,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar6,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(*(int *)(iVar2 + 0x2c) + 0xb4);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x230);
		        goto code_r0x80f7df71;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f7df71:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,uVar4,Method_Core_Gameplay_Managers_ClansManager_ShowClanOfficeWindow__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060011AB RID: 4523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011AB")]
		[Address(RVA = "0x63A8", Offset = "0x63A8", VA = "0x63A8")]
		private void HandleBottomGroup()
		{
		/* --- GHIDRA: HandleBottomGroup ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator__HandleBottomGroup
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined8 param2_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a58b83 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisScheduleView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58b83 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x230);
		        goto code_r0x80f7e357;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f7e357:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))
		                        (param1_01,CONCAT44(in_register_20000014,puVar2[1]));
		  param2_00 = Core_Data_UserData___ctor(*(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		  Core_Gameplay_Managers_ClansManager__DissociateClanFromUser(param1_00,param2_00,5,0);
		  return;
		}
		*/

		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011AC")]
		[Address(RVA = "0x63A9", Offset = "0x63A9", VA = "0x63A9")]
		private void EnterSquadButtonClickedEventHandler()
		{
		/* --- GHIDRA: EnterSquadButtonClickedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator__EnterSquadButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58b84 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58b84 = '\x01';
		  }
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  UI_Windows_PopupController__Close(uVar2,2,0);
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
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x80f7e44f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f7e44f:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  Core_Gameplay_Managers_WorldManager__GoToClanIsleById(uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060011AD RID: 4525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011AD")]
		[Address(RVA = "0x63AA", Offset = "0x63AA", VA = "0x63AA")]
		private void ToWorldAxisButtonClickedEventHandler()
		{
		/* --- GHIDRA: ToWorldAxisButtonClickedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator__ToWorldAxisButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a58b85 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58b85 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 600);
		        goto code_r0x80f7e523;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80f7e523:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_WorldAxisManager__ShowWorldAxisWindow
		            (param1_00,*(undefined4 *)(*(int *)(param1 + 0x18) + 0x1c),0);
		  return;
		}
		*/

		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011AE")]
		[Address(RVA = "0x63AB", Offset = "0x63AB", VA = "0x63AB")]
		private void ColossusInfoButtonClickedEventHandler()
		{
		/* --- GHIDRA: ColossusInfoButtonClickedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator__ColossusInfoButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int iVar3;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a58b86 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisScheduleView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ColossusBattleListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_ListElementClickedEventHandler__
		              );
		    DAT_ram_00a58b86 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 8) + 0x18);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      iVar3 = *(int *)(iVar2 + iVar1 * 4 + 0x10);
		      param1_00 = unnamed_function_1417(System_Action_ColossusBattleListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_00,param1,
		                 Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_ListElementClickedEventHandler__
		                 ,0);
		      *(undefined4 *)(iVar3 + 0x18) = param1_00;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060011AF RID: 4527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011AF")]
		[Address(RVA = "0x63AC", Offset = "0x63AC", VA = "0x63AC")]
		private void InjectCallback()
		{
		/* --- GHIDRA: InjectCallback ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator__InjectCallback
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58b87 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisScheduleView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_ColossusRatingRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_ScheduleChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_UserClanStatusChangedEventHandler__
		              );
		    DAT_ram_00a58b87 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_ColossusRatingRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x20) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x20) = piVar4, *piVar4 != iVar1)) {
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
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_ScheduleChangedEventHandler__
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = *(int *)(iVar1 + 0x18);
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_UserClanStatusChangedEventHandler__
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
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_ColossusRatingRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x20) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x20) = piVar4, *piVar4 != iVar1)) {
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
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_ScheduleChangedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = *(int *)(iVar1 + 0x18);
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_UserClanStatusChangedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x1700029A RID: 666
		// (set) Token: 0x060011B0 RID: 4528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029A")]
		public override WorldAxisOfficeEvents Events
		{
			[Token(Token = "0x60011B0")]
			[Address(RVA = "0x63AD", Offset = "0x63AD", VA = "0x63AD", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B1")]
		[Address(RVA = "0x63AE", Offset = "0x63AE", VA = "0x63AE")]
		private void UserClanStatusChangedEventHandler()
		{
		/* --- GHIDRA: UserClanStatusChangedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator__UserClanStatusChangedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator__set_View(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B2")]
		[Address(RVA = "0x63AF", Offset = "0x63AF", VA = "0x63AF")]
		private void ScheduleChangedEventHandler()
		{
		/* --- GHIDRA: ScheduleChangedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator__ScheduleChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58b88 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisScheduleView__get_Model__
		              );
		    DAT_ram_00a58b88 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x1c);
		  iVar1 = param1[2];
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(param1[6] + 0x1c) + 0x10) + 0xc);
		  if (DAT_ram_00a58b24 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__WorldAxisOfficeModel_ColossusClanRating____get_Item__
		              );
		    DAT_ram_00a58b24 = '\x01';
		  }
		  uVar2 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar1 + 0x14),uVar2,
		                     Method_System_Collections_Generic_Dictionary_uint__WorldAxisOfficeModel_ColossusClanRating____get_Item__
		                    );
		  Gameplay_WorldAxis_Office_View_TitleIconValueBackgroundPlace___ctor
		            (param1_00,uVar2,*(undefined4 *)(param1[2] + 8),0);
		  return;
		}
		*/

		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B3")]
		[Address(RVA = "0x63B0", Offset = "0x63B0", VA = "0x63B0")]
		private void ColossusRatingRequestedEventHandler()
		{
		/* --- GHIDRA: ColossusRatingRequestedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator__ColossusRatingRequestedEventHandler
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58b89 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ColossusBattleListElement_ColossusBattleListElementArgs__get_args__
		              );
		    DAT_ram_00a58b89 = '\x01';
		  }
		  Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator__ListElementClickedEventHandler
		            (param1,*(undefined4 *)(param2 + 0x18),param2);
		  return;
		}
		*/

		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B4")]
		[Address(RVA = "0x63B1", Offset = "0x63B1", VA = "0x63B1")]
		private void ListElementClickedEventHandler(ColossusBattleListElement element)
		{
		/* --- GHIDRA: ListElementClickedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator__ListElementClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  undefined4 uVar3;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58b8a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21415);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17799);
		    DAT_ram_00a58b8a = '\x01';
		  }
		  if (param1[6] != 0) {
		    Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		              (param1[6],0,0);
		  }
		  param1[6] = param2;
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		            (param2,1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(iVar1 + 0x24),*(undefined4 *)(*(int *)(param2 + 0x1c) + 0x18),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x20);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17799,1,0,1,0,0,0,0);
		  iVar1 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  param3_00 = Core_Extensions_Dict_CollectionsDicExt__GetDescription
		                        (*(undefined4 *)(*(int *)(param2 + 0x1c) + 0x10),0);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_21415,param3_00,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar1 + 0x10) = local_8;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar1,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  uVar3 = Core_Extensions_Dict_ColossusDicExt__GetIcon256
		                    (*(undefined4 *)(*(int *)(param2 + 0x1c) + 0x10),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar2,uVar3,0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController__UpdateSchedule
		            (uVar3,*(undefined4 *)(*(int *)(*(int *)(param2 + 0x1c) + 0x10) + 0xc),param1);
		  return;
		}
		*/

		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B5")]
		[Address(RVA = "0x63B2", Offset = "0x63B2", VA = "0x63B2")]
		private void Select(ColossusBattleListElement.ColossusBattleListElementArgs args)
		{
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B6")]
		[Address(RVA = "0x63B3", Offset = "0x63B3", VA = "0x63B3", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x04000914 RID: 2324
		[Token(Token = "0x4000914")]
		[FieldOffset(Offset = "0x18")]
		private ColossusBattleListElement.ColossusBattleListElementArgs _selectedArgs;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a58b81 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisScheduleView__get_Model__
		              );
		    DAT_ram_00a58b81 = '\x01';
		  }
		  Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator__Init(param1,0);
		  if (DAT_ram_00a58b86 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__WorldAxisScheduleView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ColossusBattleListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_ListElementClickedEventHandler__
		              );
		    DAT_ram_00a58b86 = '\x01';
		  }
		  iVar2 = *(int *)(param1[2] + 0x18);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      iVar3 = *(int *)(iVar2 + iVar4 * 4 + 0x10);
		      uVar1 = unnamed_function_1417(System_Action_ColossusBattleListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar1,param1,
		                 Method_Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator_ListElementClickedEventHandler__
		                 ,0);
		      *(undefined4 *)(iVar3 + 0x18) = uVar1;
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(iVar2 + 0xc));
		  }
		  iVar4 = *param1;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar4 + 0x15c));
		  Gameplay_WorldAxis_Office_View_Schedule_WorldAxisScheduleView__get_ColossusAvatar
		            (uVar1,*(undefined4 *)(param1[2] + 0x18),0);
		  Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator__ListElementClickedEventHandler
		            (param1,*(undefined4 *)(*(int *)(param1[2] + 0x18) + 0x10),iVar4);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator__set_Events
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_WorldAxis_Office_Controller_WorldAxisScheduleViewMediator__Init(param1,param1);
		  return;
		}
		*/

}
