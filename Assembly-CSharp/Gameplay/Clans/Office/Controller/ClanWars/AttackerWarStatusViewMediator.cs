using System;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.ClanWars.Events;
using Gameplay.Clans.ClanWars.Model;
using Il2CppDummyDll;

namespace Gameplay.Clans.Office.Controller.ClanWars
{
	// Token: 0x02000A7F RID: 2687
	[Token(Token = "0x2000A7F")]
	public class AttackerWarStatusViewMediator : WarStatusViewMediatorBase
	{
		// Token: 0x0600401A RID: 16410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600401A")]
		[Address(RVA = "0x8ED4", Offset = "0x8ED4", VA = "0x8ED4")]
		public AttackerWarStatusViewMediator(ClanWarsModel model, ClanWarsEvents events, ClanWarsController controller, string enemyClanName)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5785e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow__set_View__
		              );
		    DAT_ram_00a5785e = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    func_ii_14558(*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x48) + 0x2c) + 0xb4),0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__set_View(param1,param1)
		    ;
		  }
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClanWars_AttackerWarStatusViewMediator___ctor
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param3;
		  undefined4 param2_00;
		  undefined4 param4;
		  
		  if (DAT_ram_00a576e6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsModel__ClanWarsEvents__ClanWarsController__ClanWarStatusView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_AttackerWarStatusViewMediator_AccelerateButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ClanWarStatusView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3694);
		    DAT_ram_00a576e6 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar1,3,Method_UI_MonoBehaviourWithStates_ClanWarStatusView_State__set_CurrentState__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x2c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_AttackerWarStatusViewMediator_AccelerateButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = UI_Rewards_AbstractRewardsRender__SetRewards
		                    (*(undefined4 *)(iVar2 + 0x2c),
		                     Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3694,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar1,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(param1[2] + 0x18),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x30);
		  param3 = *(undefined4 *)(param1[2] + 8);
		  param2_00 = *(undefined4 *)(*(int *)(param1[6] + 0x10) + 0x18);
		  iVar2 = Gameplay_Clans_ClanWars_Model_ClanWarsModel__set_CurrentSeasonId(param1[2],0);
		  param4 = *(undefined4 *)(iVar2 + 0x1c);
		  uVar1 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__Dispose
		            (uVar1,param2_00,param3,param4,0);
		  UI_Requirements_RequirementsView__get_Data(uVar3,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600401B RID: 16411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600401B")]
		[Address(RVA = "0x8ED5", Offset = "0x8ED5", VA = "0x8ED5", Slot = "23")]
		protected override void HandlePrepareState()
		{
		/* --- GHIDRA: HandlePrepareState ---
		void Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__HandlePrepareState
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000004;
		  undefined8 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  float fVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  undefined4 param4;
		  double param1_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57861 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator_AccelerateButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_WarStatusView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4212);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27717);
		    DAT_ram_00a57861 = '\x01';
		  }
		  uVar2 = CONCAT44(in_register_20000004,param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar2,*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar3 + 0x48),2,
		             Method_UI_MonoBehaviourWithStates_WarStatusView_State__set_CurrentState__);
		  uVar2 = CONCAT44(uVar8,param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar2,*(undefined4 *)(*param1 + 0x15c));
		  uVar7 = *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x48) + 0x2c) + 0xb4);
		  uVar8 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar4 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar4,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator_AccelerateButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar7,uVar4,0);
		  Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__HandleSoonStartState
		            (param1,param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (CONCAT44(uVar8,param1),*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = *(undefined4 *)(*(int *)(iVar3 + 0x48) + 0x28);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4212,1,0,1,0,0,0,0);
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  uVar1 = *(uint *)(*(int *)(*(int *)(param1[7] + 0x10) + 0x14) + 0x34);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar5 = func_ii_7331((ulonglong)uVar1,0);
		  param1_00 = (double)fVar5;
		  uVar6 = Utils_TimeUtils__FormatTwoDigits(param1_00,0);
		  local_8 = 0;
		  uVar7 = (undefined4)((ulonglong)param1_00 >> 0x20);
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_27717,uVar6,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar3 + 0x10) = local_8;
		  uVar4 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar4,iVar3,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar8,uVar4,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (CONCAT44(uVar7,param1),*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(*(int *)(iVar3 + 0x48) + 0x34);
		  uVar7 = *(undefined4 *)(param1[2] + 8);
		  uVar6 = *(undefined4 *)(*(int *)(param1[6] + 0x10) + 0x18);
		  iVar3 = Core_Gameplay_Managers_ClanWarsManager__get_WarsDisabled(param1[7],0);
		  param4 = *(undefined4 *)(iVar3 + 0x1c);
		  uVar8 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__Dispose
		            (uVar8,uVar6,uVar7,param4,0);
		  UI_Requirements_RequirementsView__get_Data(uVar4,uVar8,0);
		  return;
		}
		*/

		/* --- GHIDRA: HandlePrepareState ---
		void Gameplay_Clans_Office_Controller_ClanWars_AttackerWarStatusViewMediator__HandlePrepareState
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_ClanWars_Controller_ClanWarsController__PayOffResultHandler(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600401C RID: 16412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600401C")]
		[Address(RVA = "0x8ED6", Offset = "0x8ED6", VA = "0x8ED6")]
		private void AccelerateButtonClickedEventHandler()
		{
		/* --- GHIDRA: AccelerateButtonClickedEventHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__AccelerateButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a57865 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow___ctor__
		              );
		    DAT_ram_00a57865 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow___ctor__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: AccelerateButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_AttackerWarStatusViewMediator__AccelerateButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a576e7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsModel__ClanWarsEvents__ClanWarsController__ClanWarStatusView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ClanWarStatusView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3694);
		    DAT_ram_00a576e7 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar1,5,Method_UI_MonoBehaviourWithStates_ClanWarStatusView_State__set_CurrentState__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = UI_Rewards_AbstractRewardsRender__SetRewards
		                    (*(undefined4 *)(iVar2 + 0x2c),
		                     Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3694,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar1,param2_00,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar2 + 0x2c),0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(param1[2] + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x0600401D RID: 16413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600401D")]
		[Address(RVA = "0x8ED7", Offset = "0x8ED7", VA = "0x8ED7", Slot = "25")]
		protected override void HandleSoonStartState()
		{
		/* --- GHIDRA: HandleSoonStartState ---
		void Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__HandleSoonStartState
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  float fVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57864 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4211);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22759);
		    DAT_ram_00a57864 = '\x01';
		  }
		  uVar1 = *(uint *)(*(int *)(*(int *)(param1[7] + 0x10) + 0x14) + 0x2c);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar2 = func_ii_7331((ulonglong)uVar1,0);
		  uVar3 = Utils_TimeUtils__FormatTwoDigits((double)fVar2,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(*(int *)(iVar4 + 0x48) + 0x40);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param1_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4211,1,0,1,0,0,0,0);
		  iVar4 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_22759,uVar3,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar4 + 0x10) = local_8;
		  uVar3 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (param1_00,iVar4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_01,uVar3,0);
		  return;
		}
		*/

		/* --- GHIDRA: HandleSoonStartState ---
		void Gameplay_Clans_Office_Controller_ClanWars_AttackerWarStatusViewMediator__HandleSoonStartState
		               (int *param1,undefined4 param2)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x178) * 4))(param1,*(undefined4 *)(*param1 + 0x17c));
		  return;
		}
		*/

		}

		// Token: 0x0600401E RID: 16414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600401E")]
		[Address(RVA = "0x8ED8", Offset = "0x8ED8", VA = "0x8ED8", Slot = "24")]
		protected override void HandleAcceleratedState()
		{
		/* --- GHIDRA: HandleAcceleratedState ---
		void Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__HandleAcceleratedState
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57862 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_WarStatusView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4265);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4267);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4266);
		    DAT_ram_00a57862 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x48),3,
		             Method_UI_MonoBehaviourWithStates_WarStatusView_State__set_CurrentState__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = StringLiteral_4265;
		  iVar1 = *(int *)(iVar1 + 0x48);
		  if (DAT_ram_00a5784e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    DAT_ram_00a5784e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(iVar1 + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar2,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x48) + 0x40);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4266,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar3,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x48) + 0x24);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4267,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(iVar1 + 0x48);
		  iVar4 = *(int *)(*(int *)(param1[7] + 0x10) + 0x14);
		  local_8 = *(undefined4 *)(iVar4 + 0x20);
		  local_4 = *(undefined4 *)(iVar4 + 0x24);
		  uVar3 = *(undefined4 *)(iVar1 + 0x38);
		  uVar2 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar2,0);
		  uVar3 = *(undefined4 *)(iVar1 + 0x3c);
		  uVar2 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_8,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar2,0);
		  return;
		}
		*/

		/* --- GHIDRA: HandleAcceleratedState ---
		void Gameplay_Clans_Office_Controller_ClanWars_AttackerWarStatusViewMediator__HandleAcceleratedState
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a576e8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView___ctor__
		              );
		    DAT_ram_00a576e8 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanPoliticsView___ctor__
		            );
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WarInfo ---
		void Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__get_WarInfo
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5785d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5785d = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow___ctor__
		            );
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x230);
		        goto code_r0x80de8485;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80de8485:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x240);
		        goto code_r0x80de8534;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x30);
		code_r0x80de8534:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  *(undefined4 *)(param1 + 0x1c) = uVar3;
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x44),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x48),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x48) + 0x2c);
		  uVar2 = Gameplay_Clans_Model_ClansModel__set_GolemUserData(*(undefined4 *)(param1[6] + 0x10),0);
		  System_Linq_Enumerable__First_object_(param1_00,uVar2,0);
		  Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__Init(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__Init
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  float fVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a5785f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3694);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4264);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4208);
		    DAT_ram_00a5785f = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(*(int *)(iVar1 + 0x48) + 0x20),
		             *(undefined4 *)(*(int *)(param1[7] + 0x10) + 0x18),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  func_ii_14558(*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x48) + 0x2c) + 0xb4),0);
		  iVar1 = *(int *)(*(int *)(*(int *)(param1[7] + 0x10) + 0x14) + 0x1c);
		  if (iVar1 == 1) {
		    Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__UpdateView
		              (param1,param1);
		    return;
		  }
		  if (iVar1 == 2) {
		    Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__HandleAcceleratedState
		              (param1,param1);
		    return;
		  }
		  if (((iVar1 != 3) && (iVar1 != 4)) && (iVar1 == 5)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = StringLiteral_4264;
		    iVar1 = *(int *)(iVar1 + 0x48);
		    if (DAT_ram_00a5784e == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		      DAT_ram_00a5784e = '\x01';
		    }
		    uVar4 = *(undefined4 *)(iVar1 + 0x1c);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar2,1,0,1,0,0,0,0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar2,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Clans_Buildings_Golem_View_WarStatusView__SetStatusKey
		              (*(undefined4 *)(iVar1 + 0x48),StringLiteral_3694,param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x48) + 0x24);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4208,1,0,1,0,0,0,0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar4,0);
		    iVar1 = *(int *)(param1[7] + 0x10);
		    if (DAT_ram_00a577c4 == '\0') {
		      Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		      DAT_ram_00a577c4 = '\x01';
		    }
		    fVar3 = func_ii_7103(*(undefined4 *)(iVar1 + 0x18),0);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    if (*(float *)(*(int *)(Utils_TimeUtils_TypeInfo + 0x5c) + 4) < fVar3) {
		      Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__HandlePrepareState
		                (param1,param1);
		      return;
		    }
		    Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__HandleActiveState
		              (param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: UpdateView ---
		void Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__UpdateView
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000004;
		  undefined8 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  float fVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  undefined4 param4;
		  double param1_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57860 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator_AccelerateButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_WarStatusView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4212);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4250);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3694);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27717);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4208);
		    DAT_ram_00a57860 = '\x01';
		  }
		  uVar2 = CONCAT44(in_register_20000004,param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar2,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar3 + 0x48),2,
		             Method_UI_MonoBehaviourWithStates_WarStatusView_State__set_CurrentState__);
		  uVar2 = CONCAT44(uVar4,param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar2,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = StringLiteral_4250;
		  uVar5 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  iVar3 = *(int *)(iVar3 + 0x48);
		  if (DAT_ram_00a5784e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    DAT_ram_00a5784e = '\x01';
		  }
		  uVar8 = *(undefined4 *)(iVar3 + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar4,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar8,uVar4,0);
		  uVar2 = CONCAT44(uVar5,param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar2,*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x48) + 0x2c) + 0xb4);
		  uVar4 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar5 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar5,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator_AccelerateButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar8,uVar5,0);
		  uVar2 = CONCAT44(uVar4,param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar2,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar5 = *(undefined4 *)(*(int *)(iVar3 + 0x48) + 0x24);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar8 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4208,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar5,uVar8,0);
		  uVar2 = CONCAT44(uVar4,param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar2,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  Gameplay_Clans_Buildings_Golem_View_WarStatusView__SetStatusKey
		            (*(undefined4 *)(iVar3 + 0x48),StringLiteral_3694,param1);
		  Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__HandleSoonStartState
		            (param1,param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (CONCAT44(uVar4,param1),*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar3 + 0x48) + 0x28);
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4212,1,0,1,0,0,0,0);
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  uVar1 = *(uint *)(*(int *)(*(int *)(param1[7] + 0x10) + 0x14) + 0x30);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar6 = func_ii_7331((ulonglong)uVar1,0);
		  param1_00 = (double)fVar6;
		  uVar7 = Utils_TimeUtils__FormatTwoDigits(param1_00,0);
		  local_8 = 0;
		  uVar8 = (undefined4)((ulonglong)param1_00 >> 0x20);
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_27717,uVar7,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar3 + 0x10) = local_8;
		  uVar4 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar4,iVar3,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar5,uVar4,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (CONCAT44(uVar8,param1),*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar3 + 0x48) + 0x34);
		  uVar8 = *(undefined4 *)(param1[2] + 8);
		  uVar7 = *(undefined4 *)(*(int *)(param1[6] + 0x10) + 0x18);
		  iVar3 = Core_Gameplay_Managers_ClanWarsManager__get_WarsDisabled(param1[7],0);
		  param4 = *(undefined4 *)(iVar3 + 0x1c);
		  uVar4 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__Dispose
		            (uVar4,uVar7,uVar8,param4,0);
		  UI_Requirements_RequirementsView__get_Data(uVar5,uVar4,0);
		  return;
		}
		*/


		/* --- GHIDRA: HandleActiveState ---
		void Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__HandleActiveState
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57863 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_WarStatusView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4210);
		    DAT_ram_00a57863 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x48),4,
		             Method_UI_MonoBehaviourWithStates_WarStatusView_State__set_CurrentState__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x48) + 0x28);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4210,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: FillBottomAnnotation ---
		void Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__FillBottomAnnotation
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_ClanWars_Controller_ClanWarsController__PayOffResultHandler(param1_00,param1);
		  return;
		}
		*/

}
