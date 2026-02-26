using System;
using Core.MVC.Interfaces;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.ClanWars.Events;
using Gameplay.Clans.ClanWars.Model;
using Gameplay.Clans.Office.View.ClanWarsTab.ClanPoliticsTab;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Office.Controller.ClanWars
{
	// Token: 0x02000A88 RID: 2696
	[Token(Token = "0x2000A88")]
	public class TruceStatusViewMediator : AbstractViewMediator<ClanWarsModel, ClanWarsEvents, ClanWarsController, ClanWarStatusView>, IViewMediator<ClanWarStatusView>, IViewMediator
	{
		// Token: 0x06004081 RID: 16513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004081")]
		[Address(RVA = "0x8F3B", Offset = "0x8F3B", VA = "0x8F3B")]
		public TruceStatusViewMediator(ClanWarsModel model, ClanWarsEvents events, ClanWarsController controller, ClanPolicyListElement.ClanPolicyListElementArgs args)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57ab6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator_ShieldButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57ab6 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x44) + 0x2c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator_ShieldButtonClickedEventHandler__
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
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x44) + 0x2c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator_ShieldButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__ShieldButtonClickedEventHandler
		              (param1,param1);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClanWars_TruceStatusViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57734 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsModel__ClanWarsEvents__ClanWarsController__ClanWarStatusView__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_TruceStatusViewMediator_AttackButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57734 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x24) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_TruceStatusViewMediator_AttackButtonClickedEventHandler__
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
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x24) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_TruceStatusViewMediator_AttackButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    Gameplay_Clans_Office_Controller_ClanWars_TruceStatusViewMediator__set_View(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000CB9 RID: 3257
		// (set) Token: 0x06004082 RID: 16514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB9")]
		public override ClanWarStatusView View
		{
			[Token(Token = "0x6004082")]
			[Address(RVA = "0x8F3C", Offset = "0x8F3C", VA = "0x8F3C", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004083")]
		[Address(RVA = "0x8F3D", Offset = "0x8F3D", VA = "0x8F3D")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__Init
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
		  int iVar8;
		  int iVar9;
		  int iVar10;
		  undefined8 uVar11;
		  int *param1_00;
		  uint uVar12;
		  
		  if (DAT_ram_00a57ab9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_TruceStatusView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25415);
		    DAT_ram_00a57ab9 = '\x01';
		  }
		  uVar11 = CONCAT44(in_register_20000004,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar11,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = (undefined4)((ulonglong)uVar11 >> 0x20);
		  Gameplay_Clans_Buildings_Golem_View_TruceStatusView__Awake(*(undefined4 *)(iVar2 + 0x44),0);
		  param1_00 = *(int **)(param1[2] + 0xc);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar12 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar12 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar12 * 8 + 4) * 8 + iVar2 + 0xd0);
		        goto code_r0x80e1d41b;
		      }
		      uVar12 = uVar12 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar12);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e1d41b:
		  bVar1 = false;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(CONCAT44(uVar4,param1_00),puVar3[1]);
		  uVar11 = Core_Extensions_Dict_DictExt__GetDoubleParameter(uVar4,StringLiteral_25415,0);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar5 = func_ii_7331(uVar11,0);
		  uVar4 = (undefined4)((ulonglong)uVar11 >> 0x20);
		  iVar2 = *(int *)(*(int *)(param1[2] + 0x18) + 0x1c);
		  if (iVar2 != 0) {
		    fVar6 = func_ii_7103(iVar2,0);
		    bVar1 = fVar6 < fVar5;
		  }
		  iVar7 = Core_Gameplay_Managers_ClanWarsManager__set_Controller(param1[7],0);
		  iVar8 = Gameplay_Isles_Clan_Model_ClanIsleModel__set_GolemRecoveryBacktime
		                    (*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x10),0);
		  iVar9 = Gameplay_World_Model_ClanData__get_IsRightHandClan
		                    (*(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x10) + 0x10) + 0x30),0);
		  iVar10 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                     (CONCAT44(uVar4,param1),*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar10 + 0x44),1,
		             Method_UI_MonoBehaviourWithStates_TruceStatusView_State__set_CurrentState__);
		  if ((((iVar2 != 0) && (iVar8 == 0)) && (iVar9 == 0)) && ((iVar7 == 0 && (!bVar1)))) {
		    Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__HandleGolemHasShield
		              (param1,iVar2);
		    Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__UpdateGolemSleepAnnotation
		              (param1,iVar2);
		    return;
		  }
		  if (iVar7 != 0) {
		    Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__HandleCanStartWar
		              (param1,iVar2);
		    Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__UpdateGolemSleepAnnotation
		              (param1,iVar2);
		    return;
		  }
		  if (iVar2 != 0) {
		    if (bVar1) {
		      Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__HandleWarsDisabled
		                (param1,iVar2);
		      Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__UpdateGolemSleepAnnotation
		                (param1,iVar2);
		      return;
		    }
		    if (iVar8 != 0) {
		      Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__HandleHasCreditDebt
		                (param1,iVar2);
		      Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__UpdateGolemSleepAnnotation
		                (param1,iVar2);
		      return;
		    }
		    if (iVar9 != 0) {
		      Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__UpdateView(param1,iVar2);
		    }
		    Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__UpdateGolemSleepAnnotation
		              (param1,iVar2);
		    return;
		  }
		  Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__HandleSeasonEndSoon(param1,0);
		  Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__UpdateGolemSleepAnnotation
		            (param1,0);
		  return;
		}
		*/

		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_Controller_ClanWars_TruceStatusViewMediator__Init
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57736 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Errors_Expected_Clans_ExpectedClanWarErrors_ExpectedClanWarsErrorsArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4215);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2178);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2181);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2084);
		    DAT_ram_00a57736 = '\x01';
		  }
		  if (param2 < 0) {
		    iVar3 = unnamed_function_1417
		                      (
		                      Core_Errors_Expected_Clans_ExpectedClanWarErrors_ExpectedClanWarsErrorsArgs_TypeInfo
		                      );
		    *(undefined1 *)(iVar3 + 8) = *(undefined1 *)(*(int *)(*(int *)(param1[6] + 0x1c) + 0x1c) + 0x40)
		    ;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar2 + 0x1c);
		    puVar1 = &StringLiteral_2181;
		    uVar4 = Core_Errors_Expected_Clans_ExpectedClanWarErrors__Handle(param2,iVar3,0);
		  }
		  else {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar3 + 0x1c);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    puVar1 = &StringLiteral_2178;
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4215,1,0,1,0,0,0,0);
		  }
		  uVar4 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (*puVar1,uVar4,StringLiteral_2084,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,uVar4,0);
		  return;
		}
		*/

		}

		// Token: 0x06004084 RID: 16516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004084")]
		[Address(RVA = "0x8F3E", Offset = "0x8F3E", VA = "0x8F3E")]
		private void SetNotInWarStatus(int error)
		{
		/* --- GHIDRA: SetNotInWarStatus ---
		void Gameplay_Clans_Office_Controller_ClanWars_TruceStatusViewMediator__SetNotInWarStatus
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57737 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57737 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x240);
		        goto code_r0x80dd207a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x30);
		code_r0x80dd207a:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))
		                        (param1_01,CONCAT44(in_register_20000014,puVar2[1]));
		  iVar3 = *(int *)(*(int *)(*(int *)(param1 + 0x18) + 0x1c) + 0x1c);
		  iVar4 = *(int *)(*(int *)(param1 + 0x18) + 0x24);
		  Core_Gameplay_Managers_ClanWarsManager__OpenWarStatusWindow
		            (param1_00,*(undefined8 *)(iVar3 + 0x10),*(undefined4 *)(iVar4 + 8),
		             *(undefined4 *)(iVar4 + 0x10),*(undefined4 *)(iVar3 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x06004085 RID: 16517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004085")]
		[Address(RVA = "0x8F3F", Offset = "0x8F3F", VA = "0x8F3F")]
		private void AttackButtonClickedEventHandler()
		{
		/* --- GHIDRA: AttackButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_TruceStatusViewMediator__AttackButtonClickedEventHandler
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57738 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsModel__ClanWarsEvents__ClanWarsController__ClanWarStatusView___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57738 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ClanWarsModel__ClanWarsEvents__ClanWarsController__ClanWarStatusView___ctor__
		            );
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x230);
		        goto code_r0x80dcbd2b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80dcbd2b:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  *(undefined4 *)(param1 + 0x1c) = param5;
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  return;
		}
		*/

		}

		// Token: 0x040023E1 RID: 9185
		[Token(Token = "0x40023E1")]
		[FieldOffset(Offset = "0x18")]
		private ClanPolicyListElement.ClanPolicyListElementArgs _args;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Office_Controller_ClanWars_TruceStatusViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  uint *puVar5;
		  int iVar6;
		  int *param1_00;
		  undefined4 param2_00;
		  undefined4 param3;
		  undefined4 param4;
		  undefined4 uVar7;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57735 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsModel__ClanWarsEvents__ClanWarsController__ClanWarStatusView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ClanWarStatusView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3631);
		    DAT_ram_00a57735 = '\x01';
		  }
		  local_4 = 0;
		  iVar6 = *(int *)(*(int *)(param1[6] + 0x24) + 0xc);
		  iVar2 = Gameplay_Clans_ClanWars_Model_ClanWarsModel___ctor(param1[2],&local_4,0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar7 = 1;
		  iVar4 = -0x15;
		  if (iVar2 == 0) {
		    iVar4 = iVar6;
		  }
		  if (iVar4 < 0) {
		    uVar7 = 2;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar3,uVar7,
		             Method_UI_MonoBehaviourWithStates_ClanWarStatusView_State__set_CurrentState__);
		  Gameplay_Clans_Office_Controller_ClanWars_TruceStatusViewMediator__Init(param1,iVar4,iVar4);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar7 = *(undefined4 *)(iVar4 + 0x24);
		  uVar3 = Core_Data_UserData__get_ClanId(*(undefined4 *)(param1[2] + 8),0);
		  System_Linq_Enumerable__First_object_(uVar7,uVar3,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar7 = *(undefined4 *)(iVar4 + 0x2c);
		  uVar3 = Core_Data_UserData__get_ClanId(*(undefined4 *)(param1[2] + 8),0);
		  System_Linq_Enumerable__First_object_(uVar7,uVar3,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = UI_Rewards_AbstractRewardsRender__SetRewards
		                    (*(undefined4 *)(iVar4 + 0x24),
		                     Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar7 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3631,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar7,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar4 + 0x30);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x230);
		        goto code_r0x80dd1e4e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80dd1e4e:
		  iVar4 = (**(code **)((ulonglong)*puVar5 * 4))(param1_00,puVar5[1]);
		  param2_00 = *(undefined4 *)(*(int *)(iVar4 + 0x10) + 0x18);
		  param3 = *(undefined4 *)(param1[2] + 8);
		  param4 = *(undefined4 *)(*(int *)(param1[6] + 0x24) + 8);
		  uVar7 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__Dispose
		            (uVar7,param2_00,param3,param4,0);
		  UI_Requirements_RequirementsView__get_Data(uVar3,uVar7,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57ab7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow__get_Model__
		              );
		    DAT_ram_00a57ab7 = '\x01';
		  }
		  iVar1 = Gameplay_Isles_Clan_Model_ClanIsleModel__set_GolemRecoveryBacktime
		                    (*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x10),0);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (iVar1 != 0) {
		    Gameplay_Clans_ClanWars_Controller_ClanWarsController__TakeOutGolemResultHandler
		              (param1_00,param1[8],0);
		    return;
		  }
		  Gameplay_Clans_ClanWars_Controller_ClanWarsController__GetCurrentSeasonInfoResultHandler
		            (param1_00,param1[8],0);
		  return;
		}
		*/


		/* --- GHIDRA: ShieldButtonClickedEventHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__ShieldButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57ab8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4246);
		    DAT_ram_00a57ab8 = '\x01';
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
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4246,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,param2_00,0);
		  Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__Init(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: UpdateView ---
		void Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__UpdateView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57aba == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4258);
		    DAT_ram_00a57aba = '\x01';
		  }
		  Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__UpdateShieldButtonAndCost
		            (param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4258,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: HandleHasCreditDebt ---
		void Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__HandleHasCreditDebt
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57abb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4258);
		    DAT_ram_00a57abb = '\x01';
		  }
		  Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__UpdateShieldButtonAndCost
		            (param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4258,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: HandleGolemHasShield ---
		void Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__HandleGolemHasShield
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57abc == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4258);
		    DAT_ram_00a57abc = '\x01';
		  }
		  Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__UpdateShieldButtonAndCost
		            (param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4258,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__HandleSeasonEnd(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: HandleCanStartWar ---
		void Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__HandleCanStartWar
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57abd == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4263);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4261);
		    DAT_ram_00a57abd = '\x01';
		  }
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
		  Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__HandleSeasonEnd(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: HandleWarsDisabled ---
		void Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__HandleWarsDisabled
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57abe == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4261);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4253);
		    DAT_ram_00a57abe = '\x01';
		  }
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
		  Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__HandleSeasonEnd(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: HandleSeasonEndSoon ---
		void Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__HandleSeasonEndSoon
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57abf == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4260);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4252);
		    DAT_ram_00a57abf = '\x01';
		  }
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
		  Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__HandleSeasonEnd(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: HandleSeasonEnd ---
		void Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__HandleSeasonEnd
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  uint *puVar1;
		  undefined4 uVar2;
		  float fVar3;
		  undefined4 param1_00;
		  undefined8 param1_01;
		  int *param1_02;
		  int iVar4;
		  undefined4 param1_03;
		  uint uVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57ac0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4295);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27626);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22759);
		    DAT_ram_00a57ac0 = '\x01';
		  }
		  param1_02 = *(int **)(param1[2] + 0xc);
		  iVar4 = *param1_02;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar5 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80e1dd96;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_02,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e1dd96:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(CONCAT44(in_register_20000004,param1_02),puVar1[1]);
		  param1_01 = Core_Extensions_Dict_DictExt__GetDoubleParameter(uVar2,StringLiteral_27626,0);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar3 = func_ii_7331(param1_01,0);
		  uVar2 = Utils_TimeUtils__DateFormat((double)fVar3,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_03 = *(undefined4 *)(iVar4 + 0x44);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param1_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4295,1,0,1,0,0,0,0);
		  iVar4 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_22759,uVar2,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar4 + 0x10) = local_8;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (param1_00,iVar4,0);
		  Gameplay_Clans_Buildings_Golem_View_TruceStatusView__SetStatusAnnotationKey(param1_03,uVar2,0);
		  return;
		}
		*/


		/* --- GHIDRA: UpdateGolemSleepAnnotation ---
		void Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__UpdateGolemSleepAnnotation
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  float param3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a57ac1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4294);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4246);
		    DAT_ram_00a57ac1 = '\x01';
		  }
		  iVar1 = Gameplay_Isles_Clan_Model_ClanIsleModel__set_GolemRecoveryBacktime
		                    (*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x10),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = UI_Rewards_AbstractRewardsRender__SetRewards
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x44) + 0x2c),
		                     Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		  if (iVar1 != 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4294,1,0,1,0,0,0,0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar4,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Clans_Buildings_Golem_View_TruceStatusView__SetStatusAnnotationText
		              (*(undefined4 *)(iVar1 + 0x44),
		               *(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x10) + 0x10) + 0x34),0);
		    iVar1 = param1[7];
		    uVar3 = Gameplay_Isles_Clan_Model_ClanIsleModel__get_GolemHasShield
		                      (*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x10),0);
		    uVar3 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(uVar3,0);
		    param3 = func_ii_7103(*(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x10) + 0x10) + 0x34),0);
		    iVar1 = Core_Gameplay_Managers_ClanWarsManager__GetPayOffCost(iVar1,uVar3,param3,0);
		    param1[8] = iVar1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x34);
		    iVar1 = param1[8];
		    uVar5 = *(undefined4 *)(param1[2] + 8);
		    uVar6 = *(undefined4 *)(*(int *)(param1[6] + 0x10) + 0x18);
		    uVar3 = unnamed_function_1417
		                      (Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		    Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__Dispose
		              (uVar3,uVar6,uVar5,iVar1,0);
		    UI_Requirements_RequirementsView__get_Data(uVar4,uVar3,0);
		    return;
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4246,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar4,0);
		  param1[8] = *(int *)(*(int *)(*(int *)(*(int *)(param1[2] + 0x10) + 0x10) + 0x38) + 0x28);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x34);
		  iVar1 = param1[8];
		  uVar5 = *(undefined4 *)(param1[2] + 8);
		  uVar6 = *(undefined4 *)(*(int *)(param1[6] + 0x10) + 0x18);
		  uVar3 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__Dispose
		            (uVar3,uVar6,uVar5,iVar1,0);
		  UI_Requirements_RequirementsView__get_Data(uVar4,uVar3,0);
		  return;
		}
		*/


		/* --- GHIDRA: UpdateShieldButtonAndCost ---
		void Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__UpdateShieldButtonAndCost
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57ac2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__ClanWarsEvents__ClanWarsController__WarStatusWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_4204);
		    DAT_ram_00a57ac2 = '\x01';
		  }
		  iVar1 = Gameplay_World_Model_ClanData__get_IsRightHandClan
		                    (*(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x10) + 0x10) + 0x30),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar1 != 0) {
		    Gameplay_Clans_Buildings_Golem_View_TruceStatusView__SetStatusDescriptionKey
		              (*(int *)(iVar2 + 0x44),StringLiteral_4204,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Linq_Enumerable__First_object_(*(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x2c),0,0);
		    return;
		  }
		  param1_00 = *(undefined4 *)(*(int *)(iVar2 + 0x44) + 0x2c);
		  param2_00 = Gameplay_Clans_Model_ClansModel__set_GolemUserData
		                        (*(undefined4 *)(param1[6] + 0x10),0);
		  System_Linq_Enumerable__First_object_(param1_00,param2_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: ValidateShieldButton ---
		void Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator__ValidateShieldButton
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a57ac3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsModel__ClanWarsEvents__ClanWarsController__WarStatusWindow___ctor__
		              );
		    DAT_ram_00a57ac3 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ClanWarsModel__ClanWarsEvents__ClanWarsController__WarStatusWindow___ctor__
		            );
		  Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator__CombatButtonClickedEventHandler
		            (param1,param5,param1);
		  return;
		}
		*/

}
