using System;
using Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Controller;
using Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Events;
using Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Model;
using Gameplay.Ad.EnergyRegenAd.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Ad.EnergyRegenAd.Controller
{
	// Token: 0x02000DAE RID: 3502
	[Token(Token = "0x2000DAE")]
	public class EnergyRegenAdViewMediator : AbstractViewMediator<EnergyRegenAdPlacementModel, EnergyRegenAdPlacementEvents, EnergyRegenAdPlacementController, EnergyRegenAdView>
	{
		// Token: 0x0600558D RID: 21901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600558D")]
		[Address(RVA = "0xA32D", Offset = "0xA32D", VA = "0xA32D")]
		public EnergyRegenAdViewMediator(EnergyRegenAdPlacementModel model, EnergyRegenAdPlacementEvents events, EnergyRegenAdPlacementController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Ad_EnergyRegenAd_Controller_EnergyRegenAdViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58844 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementEvents__EnergyRegenAdPlacementController__EnergyRegenAdView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Ad_EnergyRegenAd_Controller_EnergyRegenAdViewMediator_AdRewardedEvent__
		              );
		    DAT_ram_00a58844 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Ad_EnergyRegenAd_Controller_EnergyRegenAdViewMediator_AdRewardedEvent__
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Ad_EnergyRegenAd_Controller_EnergyRegenAdViewMediator_AdRewardedEvent__
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

		// Token: 0x17001160 RID: 4448
		// (set) Token: 0x0600558E RID: 21902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001160")]
		public override EnergyRegenAdPlacementEvents Events
		{
			[Token(Token = "0x600558E")]
			[Address(RVA = "0xA32E", Offset = "0xA32E", VA = "0xA32E", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17001161 RID: 4449
		// (set) Token: 0x0600558F RID: 21903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001161")]
		public override EnergyRegenAdView View
		{
			[Token(Token = "0x600558F")]
			[Address(RVA = "0xA32F", Offset = "0xA32F", VA = "0xA32F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005590")]
		[Address(RVA = "0xA330", Offset = "0xA330", VA = "0xA330")]
		private void RenderMessage()
		{
		/* --- GHIDRA: RenderMessage ---
		void Gameplay_Ad_EnergyRegenAd_Controller_EnergyRegenAdViewMediator__RenderMessage
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58847 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_EnergyRegenAdViewStateController_State__set_CurrentState__
		              );
		    DAT_ram_00a58847 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x18),2,
		             Method_UI_MonoBehaviourWithStates_EnergyRegenAdViewStateController_State__set_CurrentState__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06005591 RID: 21905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005591")]
		[Address(RVA = "0xA331", Offset = "0xA331", VA = "0xA331")]
		private void AdRewardedEvent()
		{
		/* --- GHIDRA: AdRewardedEvent ---
		void Gameplay_Ad_EnergyRegenAd_Controller_EnergyRegenAdViewMediator__AdRewardedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a58848 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementEvents__EnergyRegenAdPlacementController__EnergyRegenAdView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo);
		    DAT_ram_00a58848 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_00 = *(int **)(iVar2 + 0x18);
		  uVar3 = Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController__IsAdAvailable
		                    (param1[2],0);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f342b5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,
		                                Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo,0);
		code_r0x80f342b5:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,0,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06005592 RID: 21906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005592")]
		[Address(RVA = "0xA332", Offset = "0xA332", VA = "0xA332")]
		private void WatchButtonClickHandler()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Ad_EnergyRegenAd_Controller_EnergyRegenAdViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58845 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementEvents__EnergyRegenAdPlacementController__EnergyRegenAdView__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Ad_EnergyRegenAd_Controller_EnergyRegenAdViewMediator_WatchButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58845 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x10) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Ad_EnergyRegenAd_Controller_EnergyRegenAdViewMediator_WatchButtonClickHandler__
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
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x10) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Ad_EnergyRegenAd_Controller_EnergyRegenAdViewMediator_WatchButtonClickHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    Gameplay_Ad_EnergyRegenAd_Controller_EnergyRegenAdViewMediator__set_View(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Ad_EnergyRegenAd_Controller_EnergyRegenAdViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *piVar5;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58846 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementEvents__EnergyRegenAdPlacementController__EnergyRegenAdView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_EnergyRegenAdViewStateController_State__set_CurrentState__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_22944);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2522);
		    DAT_ram_00a58846 = '\x01';
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c)));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar3 + 0x18),1,
		             Method_UI_MonoBehaviourWithStates_EnergyRegenAdViewStateController_State__set_CurrentState__
		            );
		  uVar4 = Core_Gameplay_Managers_Ad_Placements_EnergyRegen_Model_EnergyRegenAdPlacementModel___ctor
		                    (param1[2],0);
		  uVar2 = 0x7ff80000;
		  uVar4 = Core_Extensions_Dict_ResourceSetExt__ToLocaleString(uVar4,NAN,0,StringLiteral_2556,0,0,0);
		  uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  piVar5 = *(int **)(iVar3 + 0x14);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param1_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2522,1,0,1,0,0,0,0);
		  param1_01 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_01,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_01,StringLiteral_22944,uVar4,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar4 = Core_GameLocalization__GetTranslation(param1_00,param1_01,0);
		  iVar3 = *piVar5;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar5,CONCAT44(uVar2,uVar4),*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

}
