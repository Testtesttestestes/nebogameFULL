using System;
using Core.Gameplay.Managers;
using Core.MVC.Interfaces;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Clans.Buildings.Golem.View;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.ClanWars.Events;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Buildings.Golem.Controller
{
	// Token: 0x02000ADA RID: 2778
	[Token(Token = "0x2000ADA")]
	public class EnemyTruceStatusViewMediator : AbstractViewMediator<GolemModel, ClanWarsEvents, ClanWarsController, WarStatusWindow>, IViewMediator<WarStatusWindow>, IViewMediator
	{
		// Token: 0x060042E2 RID: 17122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E2")]
		[Address(RVA = "0x9196", Offset = "0x9196", VA = "0x9196")]
		public EnemyTruceStatusViewMediator(GolemModel model, ClanWarsEvents events, ClanWarsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57a78 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator_WarButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57a78 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x44) + 0x30) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator_WarButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x44) + 0x30) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator_WarButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__WarButtonClickedEventHandler
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000D37 RID: 3383
		// (set) Token: 0x060042E3 RID: 17123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D37")]
		public override WarStatusWindow View
		{
			[Token(Token = "0x60042E3")]
			[Address(RVA = "0x9197", Offset = "0x9197", VA = "0x9197", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060042E4 RID: 17124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E4")]
		[Address(RVA = "0x9198", Offset = "0x9198", VA = "0x9198")]
		private void WarButtonClickedEventHandler()
		{
		/* --- GHIDRA: WarButtonClickedEventHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__WarButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57a7a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4262);
		    DAT_ram_00a57a7a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x48),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x44),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x24);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4262,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,param2_00,0);
		  Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__Init(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060042E5 RID: 17125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E5")]
		[Address(RVA = "0x9199", Offset = "0x9199", VA = "0x9199")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__Init
		               (int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 in_register_20000004;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  float fVar5;
		  float fVar6;
		  int iVar7;
		  undefined8 uVar8;
		  int iVar9;
		  int iVar10;
		  int *param1_00;
		  uint uVar11;
		  
		  if (DAT_ram_00a57a7b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25415);
		    DAT_ram_00a57a7b = '\x01';
		  }
		  iVar9 = *(int *)(*(int *)(*(int *)(*(int *)(*(int *)(param1[6] + 0x10) + 0x1c) + 0x10) + 0x3c) +
		                  0xc);
		  iVar10 = *(int *)(*(int *)(*(int *)(*(int *)(*(int *)(param1[2] + 0x10) + 0x10) + 0x30) + 0x20) +
		                   0xc);
		  uVar8 = CONCAT44(in_register_20000004,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar8,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = (undefined4)((ulonglong)uVar8 >> 0x20);
		  Gameplay_Clans_Buildings_Golem_View_TruceStatusView__Awake(*(undefined4 *)(iVar2 + 0x44),0);
		  if (iVar9 != iVar10) {
		    Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__HandleHasCreditDebt
		              (param1,iVar9);
		    return;
		  }
		  uVar11 = 0;
		  param1_00 = *(int **)(param1[2] + 0xc);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar11 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar11 * 8 + 4) * 8 + iVar2 + 0xd0);
		        goto code_r0x80e19759;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar11);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e19759:
		  bVar1 = false;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(CONCAT44(uVar4,param1_00),puVar3[1]);
		  uVar8 = Core_Extensions_Dict_DictExt__GetDoubleParameter(uVar4,StringLiteral_25415,0);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar5 = func_ii_7331(uVar8,0);
		  iVar2 = *(int *)(*(int *)(param1[2] + 0x18) + 0x1c);
		  if (iVar2 != 0) {
		    fVar6 = func_ii_7103(iVar2,0);
		    bVar1 = fVar6 < fVar5;
		  }
		  iVar9 = Core_Gameplay_Managers_ClanWarsManager__set_Controller(param1[7],0);
		  iVar10 = Gameplay_Isles_Clan_Model_ClanIsleModel__set_GolemRecoveryBacktime
		                     (*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x10),0);
		  iVar7 = Gameplay_World_Model_ClanData__get_IsRightHandClan
		                    (*(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x10) + 0x10) + 0x30),0);
		  if ((((iVar2 != 0) && (iVar10 == 0)) && (iVar7 == 0)) && ((iVar9 == 0 && (!bVar1)))) {
		    Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__UpdateView(param1,iVar2)
		    ;
		    return;
		  }
		  if (iVar9 != 0) {
		    Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__HandleCanStartWar
		              (param1,iVar2);
		    return;
		  }
		  if (iVar2 != 0) {
		    if (bVar1) {
		      Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__HandleWarsDisabled
		                (param1,iVar2);
		      return;
		    }
		    if (iVar10 != 0) {
		      Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__HandleSeasonEnd
		                (param1,iVar2);
		      return;
		    }
		    if (iVar7 != 0) {
		      Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__HandleGolemHasShield
		                (param1,iVar2);
		    }
		    return;
		  }
		  Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__HandleSeasonEndSoon
		            (param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060042E6 RID: 17126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E6")]
		[Address(RVA = "0x919A", Offset = "0x919A", VA = "0x919A")]
		private void UpdateView()
		{
		/* --- GHIDRA: UpdateView ---
		void Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__UpdateView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param3;
		  undefined4 param2_00;
		  undefined4 param4;
		  
		  if (DAT_ram_00a57a7c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_TruceStatusView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4257);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4217);
		    DAT_ram_00a57a7c = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x44),4,
		             Method_UI_MonoBehaviourWithStates_TruceStatusView_State__set_CurrentState__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4257,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Buildings_Golem_View_TruceStatusView__SetStatusDescriptionKey
		            (*(undefined4 *)(iVar1 + 0x44),StringLiteral_4217,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x30);
		  uVar3 = Gameplay_Clans_Model_ClansModel__set_GolemUserData(*(undefined4 *)(param1[6] + 0x10),0);
		  System_Linq_Enumerable__First_object_(uVar2,uVar3,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x34);
		  param3 = *(undefined4 *)(param1[2] + 8);
		  param2_00 = *(undefined4 *)(*(int *)(param1[6] + 0x10) + 0x18);
		  param4 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1[2] + 0x10) + 0x10) + 0x38) + 0x3c);
		  uVar3 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__Dispose
		            (uVar3,param2_00,param3,param4,0);
		  UI_Requirements_RequirementsView__get_Data(uVar2,uVar3,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x3c);
		  iVar1 = Core_Gameplay_Managers_ClanWarsManager__get_WarsDisabled(param1[7],0);
		  uVar2 = *(undefined4 *)(iVar1 + 0x18);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		  UI_Price_Price__SetColor(uVar3,0,uVar2,0);
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1[2] + 0x10) + 0x10) + 0x38) + 0x34);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Buildings_Golem_View_TruceStatusView__PrepareView
		            (*(undefined4 *)(iVar1 + 0x44),uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x060042E7 RID: 17127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E7")]
		[Address(RVA = "0x919B", Offset = "0x919B", VA = "0x919B")]
		private void HandleCanStartWar()
		{
		/* --- GHIDRA: HandleCanStartWar ---
		void Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__HandleCanStartWar
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57a7d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_TruceStatusView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4263);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4261);
		    DAT_ram_00a57a7d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x44),2,
		             Method_UI_MonoBehaviourWithStates_TruceStatusView_State__set_CurrentState__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4261,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Buildings_Golem_View_TruceStatusView__SetHonor
		            (*(undefined4 *)(iVar1 + 0x44),StringLiteral_4263,0);
		  return;
		}
		*/

		}

		// Token: 0x060042E8 RID: 17128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E8")]
		[Address(RVA = "0x919C", Offset = "0x919C", VA = "0x919C")]
		private void HandleWarsDisabled()
		{
		/* --- GHIDRA: HandleWarsDisabled ---
		void Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__HandleWarsDisabled
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57a7e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_TruceStatusView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4261);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4253);
		    DAT_ram_00a57a7e = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x44),2,
		             Method_UI_MonoBehaviourWithStates_TruceStatusView_State__set_CurrentState__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4261,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Buildings_Golem_View_TruceStatusView__SetHonor
		            (*(undefined4 *)(iVar1 + 0x44),StringLiteral_4253,0);
		  return;
		}
		*/

		}

		// Token: 0x060042E9 RID: 17129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E9")]
		[Address(RVA = "0x919D", Offset = "0x919D", VA = "0x919D")]
		private void HandleSeasonEndSoon()
		{
		/* --- GHIDRA: HandleSeasonEndSoon ---
		void Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__HandleSeasonEndSoon
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57a7f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_TruceStatusView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4260);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4252);
		    DAT_ram_00a57a7f = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x44),2,
		             Method_UI_MonoBehaviourWithStates_TruceStatusView_State__set_CurrentState__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4260,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Buildings_Golem_View_TruceStatusView__SetHonor
		            (*(undefined4 *)(iVar1 + 0x44),StringLiteral_4252,0);
		  return;
		}
		*/

		}

		// Token: 0x060042EA RID: 17130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EA")]
		[Address(RVA = "0x919E", Offset = "0x919E", VA = "0x919E")]
		private void HandleSeasonEnd()
		{
		/* --- GHIDRA: HandleSeasonEnd ---
		void Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__HandleSeasonEnd
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57a80 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_TruceStatusView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4257);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4221);
		    DAT_ram_00a57a80 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x44),3,
		             Method_UI_MonoBehaviourWithStates_TruceStatusView_State__set_CurrentState__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4257,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Buildings_Golem_View_TruceStatusView__SetStatusDescriptionKey
		            (*(undefined4 *)(iVar1 + 0x44),StringLiteral_4221,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Buildings_Golem_View_TruceStatusView__SetStatusAnnotationText
		            (*(undefined4 *)(iVar1 + 0x44),
		             *(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x10) + 0x10) + 0x34),0);
		  return;
		}
		*/

		}

		// Token: 0x060042EB RID: 17131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EB")]
		[Address(RVA = "0x919F", Offset = "0x919F", VA = "0x919F")]
		private void HandleGolemHasShield()
		{
		/* --- GHIDRA: HandleGolemHasShield ---
		void Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__HandleGolemHasShield
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57a81 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_TruceStatusView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4257);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4204);
		    DAT_ram_00a57a81 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x44),3,
		             Method_UI_MonoBehaviourWithStates_TruceStatusView_State__set_CurrentState__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4257,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Buildings_Golem_View_TruceStatusView__SetHonor
		            (*(undefined4 *)(iVar1 + 0x44),StringLiteral_4204,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x30),0,0);
		  return;
		}
		*/

		}

		// Token: 0x060042EC RID: 17132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EC")]
		[Address(RVA = "0x91A0", Offset = "0x91A0", VA = "0x91A0")]
		private void HandleHasCreditDebt()
		{
		/* --- GHIDRA: HandleHasCreditDebt ---
		void Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__HandleHasCreditDebt
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57a82 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_TruceStatusView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4220);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4259);
		    DAT_ram_00a57a82 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x44),2,
		             Method_UI_MonoBehaviourWithStates_TruceStatusView_State__set_CurrentState__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4259,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Buildings_Golem_View_TruceStatusView__SetHonor
		            (*(undefined4 *)(iVar1 + 0x44),StringLiteral_4220,0);
		  return;
		}
		*/

		}

		// Token: 0x060042ED RID: 17133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042ED")]
		[Address(RVA = "0x91A1", Offset = "0x91A1", VA = "0x91A1")]
		private void HandleDifferentLeagues()
		{
		/* --- GHIDRA: HandleDifferentLeagues ---
		void Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__HandleDifferentLeagues
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a57a83 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_GolemInventoryModel__GolemInventoryEvents__GolemInventoryController___ctor__
		              );
		    DAT_ram_00a57a83 = '\x01';
		  }
		  MVC_AbstractController_object__object___set_Model
		            (param1,param2,param3,param4,
		             Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_GolemInventoryModel__GolemInventoryEvents__GolemInventoryController___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x040024F3 RID: 9459
		[Token(Token = "0x40024F3")]
		[FieldOffset(Offset = "0x18")]
		private ClansManager _clansManager;

		// Token: 0x040024F4 RID: 9460
		[Token(Token = "0x40024F4")]
		[FieldOffset(Offset = "0x1C")]
		private ClanWarsManager _clanWarsManager;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__set_View
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57a79 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow__get_Model__
		              );
		    DAT_ram_00a57a79 = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(*(int *)(param1 + 8) + 0x10) + 0x10);
		  iVar2 = *(int *)(*(int *)(iVar1 + 0x30) + 0x1c);
		  iVar1 = *(int *)(iVar1 + 0x38);
		  Core_Gameplay_Managers_ClanWarsManager__OpenWarStatusWindow
		            (*(undefined4 *)(param1 + 0x1c),*(undefined8 *)(iVar2 + 0x10),
		             *(undefined4 *)(iVar1 + 0x3c),*(undefined4 *)(iVar1 + 0x34),
		             *(undefined4 *)(iVar2 + 0x18),0);
		  return;
		}
		*/

}
