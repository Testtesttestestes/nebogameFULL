using System;
using Core.Gameplay.Managers;
using Core.MVC.Interfaces;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.ClanWars.Events;
using Gameplay.Clans.ClanWars.Model;
using Gameplay.Clans.Office.View.ClanWarsTab.ClanPoliticsTab;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Office.Controller.ClanWars
{
	// Token: 0x02000A89 RID: 2697
	[Token(Token = "0x2000A89")]
	public abstract class WarStatusViewMediatorBase : AbstractViewMediator<ClanWarsModel, ClanWarsEvents, ClanWarsController, ClanWarStatusView>, IViewMediator<ClanWarStatusView>, IViewMediator
	{
		// Token: 0x06004086 RID: 16518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004086")]
		[Address(RVA = "0x8F40", Offset = "0x8F40", VA = "0x8F40")]
		public WarStatusViewMediatorBase(ClanWarsModel model, ClanWarsEvents events, ClanWarsController controller, string enemyClanName)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClanWars_WarStatusViewMediatorBase___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57739 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsModel__ClanWarsEvents__ClanWarsController__ClanWarStatusView__set_View__
		              );
		    DAT_ram_00a57739 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    func_ii_14558(*(undefined4 *)(*(int *)(iVar2 + 0x2c) + 0xb4),0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    func_ii_14558(*(undefined4 *)(*(int *)(iVar2 + 0x24) + 0xb4),0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Clans_Office_Controller_ClanWars_WarStatusViewMediatorBase__set_View(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000CBA RID: 3258
		// (set) Token: 0x06004087 RID: 16519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CBA")]
		public override ClanWarStatusView View
		{
			[Token(Token = "0x6004087")]
			[Address(RVA = "0x8F41", Offset = "0x8F41", VA = "0x8F41", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004088")]
		[Address(RVA = "0x8F42", Offset = "0x8F42", VA = "0x8F42")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_Controller_ClanWars_WarStatusViewMediatorBase__Init
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5773b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsModel__ClanWarsEvents__ClanWarsController__ClanWarStatusView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ClanWarStatusView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_WarStatusViewMediatorBase_AttackButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_13912);
		    DAT_ram_00a5773b = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar1,4,Method_UI_MonoBehaviourWithStates_ClanWarStatusView_State__set_CurrentState__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(param1[2] + 0x18),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar2 + 0x24),1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = UI_Rewards_AbstractRewardsRender__SetRewards
		                    (*(undefined4 *)(iVar2 + 0x24),
		                     Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13912,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar1,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x24) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_WarStatusViewMediatorBase_AttackButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanWarStatusView__get_RequirementsView
		            (uVar1,*(undefined4 *)(*(int *)(param1[2] + 0x14) + 0x24),
		             *(undefined4 *)(*(int *)(param1[2] + 0x14) + 0x20),0);
		  return;
		}
		*/

		}

		// Token: 0x06004089 RID: 16521
		[Token(Token = "0x6004089")]
		protected abstract void HandlePrepareState();

		// Token: 0x0600408A RID: 16522
		[Token(Token = "0x600408A")]
		protected abstract void HandleAcceleratedState();

		// Token: 0x0600408B RID: 16523
		[Token(Token = "0x600408B")]
		protected abstract void HandleSoonStartState();

		// Token: 0x0600408C RID: 16524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600408C")]
		[Address(RVA = "0x8F43", Offset = "0x8F43", VA = "0x8F43")]
		private void HandleActiveState()
		{
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600408D")]
		[Address(RVA = "0x8F44", Offset = "0x8F44", VA = "0x8F44")]
		private void AttackButtonClickedEventHandler()
		{
		/* --- GHIDRA: AttackButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_WarStatusViewMediatorBase__AttackButtonClickedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5773c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21185);
		    DAT_ram_00a5773c = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(param2,1,0,1,0,0,0,0);
		  iVar1 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_21185,param1[7],
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar1 + 0x10) = local_8;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar1,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600408E RID: 16526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600408E")]
		[Address(RVA = "0x8F45", Offset = "0x8F45", VA = "0x8F45")]
		private void SetStatusLocalizationKey(string key)
		{
		}

		// Token: 0x040023E2 RID: 9186
		[Token(Token = "0x40023E2")]
		[FieldOffset(Offset = "0x18")]
		protected ClansManager _clansManager;

		// Token: 0x040023E3 RID: 9187
		[Token(Token = "0x40023E3")]
		[FieldOffset(Offset = "0x1C")]
		private string _enemyClanName;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Office_Controller_ClanWars_WarStatusViewMediatorBase__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5773a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsModel__ClanWarsEvents__ClanWarsController__ClanWarStatusView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_4268);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4254);
		    DAT_ram_00a5773a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x2c);
		  uVar2 = Core_Data_UserData__get_ClanId(*(undefined4 *)(param1[2] + 8),0);
		  System_Linq_Enumerable__First_object_(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x24);
		  uVar2 = Core_Data_UserData__get_ClanId(*(undefined4 *)(param1[2] + 8),0);
		  System_Linq_Enumerable__First_object_(uVar3,uVar2,0);
		  iVar1 = *(int *)(*(int *)(param1[2] + 0x14) + 0x1c);
		  if (iVar1 != 1) {
		    if (iVar1 == 2) {
		      Gameplay_Clans_Office_Controller_ClanWars_WarStatusViewMediatorBase__AttackButtonClickedEventHandler
		                (param1,StringLiteral_4268,param1);
		      Gameplay_Clans_Office_Controller_ClanWars_WarStatusViewMediatorBase__Init(param1,param1);
		      return;
		    }
		    if (((iVar1 != 3) && (iVar1 != 4)) && (iVar1 == 5)) {
		      Gameplay_Clans_Office_Controller_ClanWars_WarStatusViewMediatorBase__AttackButtonClickedEventHandler
		                (param1,StringLiteral_4254,param1);
		      iVar1 = Gameplay_Clans_ClanWars_Model_ClanWarsModel__get_EnemyClanId(param1[2],0);
		      iVar4 = *param1;
		      if (iVar1 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar4 + 0x180) * 4))
		                  (param1,*(undefined4 *)(iVar4 + 0x184));
		        return;
		      }
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0x188) * 4))(param1,*(undefined4 *)(iVar4 + 0x18c));
		    }
		    return;
		  }
		  Gameplay_Clans_Office_Controller_ClanWars_WarStatusViewMediatorBase__AttackButtonClickedEventHandler
		            (param1,StringLiteral_4254,param1);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x178) * 4))(param1,*(undefined4 *)(*param1 + 0x17c));
		  return;
		}
		*/

}
