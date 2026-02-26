using System;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View;
using Il2CppDummyDll;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BB2 RID: 2994
	[Token(Token = "0x2000BB2")]
	public class BossRewardsViewMediator : AbstractBossWindowViewMediator<BossRewardsView>
	{
		// Token: 0x06004971 RID: 18801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004971")]
		[Address(RVA = "0x97E3", Offset = "0x97E3", VA = "0x97E3")]
		public BossRewardsViewMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004972")]
		[Address(RVA = "0x97E4", Offset = "0x97E4", VA = "0x97E4", Slot = "21")]
		protected override void ResetEvents(BossInstanceEvents events)
		{
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004973")]
		[Address(RVA = "0x97E5", Offset = "0x97E5", VA = "0x97E5", Slot = "22")]
		protected override void SetupEvents(BossInstanceEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Boss_Controller_BossRewardsViewMediator__SetupEvents
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57925 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInfo_BossRewardRangeData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossRewardsViewMediator_ViewOnSelectedEvent__);
		    DAT_ram_00a57925 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Action_BossInfo_BossRewardRangeData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_Controller_BossRewardsViewMediator_ViewOnSelectedEvent__,0);
		  Gameplay_Boss_View_BossRewardsView__add_SelectedEvent(param2,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004974 RID: 18804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004974")]
		[Address(RVA = "0x97E6", Offset = "0x97E6", VA = "0x97E6", Slot = "23")]
		protected override void ResetView(BossRewardsView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Boss_Controller_BossRewardsViewMediator__ResetView
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int param2_00;
		  
		  if (DAT_ram_00a57926 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossRewardsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_BossInfo_BossRewardRangeData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossRewardsViewMediator_ViewOnSelectedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInfo_BossRewardRangeData__get_Item__);
		    DAT_ram_00a57926 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Action_BossInfo_BossRewardRangeData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossRewardsViewMediator_ViewOnSelectedEvent__,0);
		  Gameplay_Boss_View_BossRewardsView__get_AssistantRewardsRender(param2,uVar1,0);
		  param1_00 = *(int *)(param2 + 0x44);
		  param2_00 = *(int *)(*(int *)(*(int *)(param1 + 8) + 0x30) + 0x44);
		  if (param1_00 != param2_00) {
		    Gameplay_Boss_View_BossRewardsView__get_Data(param2,param2_00,0);
		    param1_00 = *(int *)(param2 + 0x44);
		  }
		  uVar1 = System_Linq_Enumerable__ToList_object_
		                    (param1_00,0,
		                     Method_System_Collections_Generic_List_BossInfo_BossRewardRangeData__get_Item__
		                    );
		  Gameplay_Boss_View_BossRewardsView__ItemOnClickEvent(param2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004975 RID: 18805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004975")]
		[Address(RVA = "0x97E7", Offset = "0x97E7", VA = "0x97E7", Slot = "24")]
		protected override void SetupView(BossRewardsView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Boss_Controller_BossRewardsViewMediator__SetupView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a57927 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_UI_LayoutRebuilder_TypeInfo);
		    DAT_ram_00a57927 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = **(int **)(iVar1 + 0x28);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)(iVar1 + 0x28),*(undefined4 *)(iVar2 + 0xec));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = **(int **)(iVar1 + 0x30);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)(iVar1 + 0x30),*(undefined4 *)(iVar2 + 0xec));
		  if (*(int *)(param2 + 0x10) != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Rewards_AbstractRewardsRender__get_Rewards
		              (*(undefined4 *)(iVar1 + 0x28),*(undefined4 *)(param2 + 0x10),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = **(int **)(iVar1 + 0x28);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xf0) * 4))
		              (*(int **)(iVar1 + 0x28),*(undefined4 *)(iVar2 + 0xf4));
		  }
		  if (*(int *)(param2 + 0x14) != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Rewards_AbstractRewardsRender__get_Rewards
		              (*(undefined4 *)(iVar1 + 0x30),*(undefined4 *)(param2 + 0x14),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = **(int **)(iVar1 + 0x30);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xf0) * 4))
		              (*(int **)(iVar1 + 0x30),*(undefined4 *)(iVar2 + 0xf4));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x2c);
		  if (*(int *)(UnityEngine_UI_LayoutRebuilder_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_UI_LayoutRebuilder_TypeInfo);
		  }
		  UnityEngine_UI_LayoutRebuilder__StripDisabledBehavioursFromList(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004976 RID: 18806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004976")]
		[Address(RVA = "0x97E8", Offset = "0x97E8", VA = "0x97E8")]
		private void ViewOnSelectedEvent(BossInfo.BossRewardRangeData data)
		{
		/* --- GHIDRA: ViewOnSelectedEvent ---
		void Gameplay_Boss_Controller_BossRewardsViewMediator__ViewOnSelectedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a57928 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_AbstractBossWindowViewMediator_BossRolesView___ctor__
		              );
		    DAT_ram_00a57928 = '\x01';
		  }
		  Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_object__object__object___set_Model
		            (param1,param2,param3,param4,
		             Method_Gameplay_Boss_Controller_AbstractBossWindowViewMediator_BossRolesView___ctor__);
		  return;
		}
		*/

		}
	}
}
