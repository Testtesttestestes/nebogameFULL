using System;
using Core.Gameplay.Managers.Ad.Placements.BattleFinish.Controller;
using Core.Gameplay.Managers.Ad.Placements.BattleFinish.Events;
using Core.Gameplay.Managers.Ad.Placements.BattleFinish.Model;
using Gameplay.Ad.BattleFinishAd.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Ad.BattleFinishAd.Controller
{
	// Token: 0x02000DB8 RID: 3512
	[Token(Token = "0x2000DB8")]
	public class BattleFinishAdViewMediator : AbstractCozyViewMediator<BattleFinishAdPlacementModel, BattleFinishAdPlacementEvents, BattleFinishAdPlacementController, BattleFinishAdView>
	{
		// Token: 0x060055B9 RID: 21945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055B9")]
		[Address(RVA = "0xA359", Offset = "0xA359", VA = "0xA359")]
		public BattleFinishAdViewMediator(BattleFinishAdView view, BattleFinishAdPlacementModel model, BattleFinishAdPlacementEvents events, BattleFinishAdPlacementController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Ad_BattleFinishAd_Controller_BattleFinishAdViewMediator___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a58858 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Ad_BattleFinishAd_Controller_BattleFinishAdViewMediator_HandleAdRewardedEvent__
		              );
		    DAT_ram_00a58858 = '\x01';
		  }
		  param1_02 = *(undefined4 *)(param2 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Ad_BattleFinishAd_Controller_BattleFinishAdViewMediator_HandleAdRewardedEvent__
		             ,0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  param2_00 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x18) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_01) &&
		     (*(int **)(param2 + 0x18) = param1_01, *param1_01 == param2_00)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060055BA RID: 21946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055BA")]
		[Address(RVA = "0xA35A", Offset = "0xA35A", VA = "0xA35A", Slot = "21")]
		protected override void ResetEvents(BattleFinishAdPlacementEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Ad_BattleFinishAd_Controller_BattleFinishAdViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a58859 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Ad_BattleFinishAd_Controller_BattleFinishAdViewMediator_HandleAdRewardedEvent__
		              );
		    DAT_ram_00a58859 = '\x01';
		  }
		  param1_02 = *(undefined4 *)(param2 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Ad_BattleFinishAd_Controller_BattleFinishAdViewMediator_HandleAdRewardedEvent__
		             ,0);
		  param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_02,param1_00,0);
		  param2_00 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x18) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_01) &&
		     (*(int **)(param2 + 0x18) = param1_01, *param1_01 == param2_00)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060055BB RID: 21947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055BB")]
		[Address(RVA = "0xA35B", Offset = "0xA35B", VA = "0xA35B", Slot = "22")]
		protected override void SetupEvents(BattleFinishAdPlacementEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Ad_BattleFinishAd_Controller_BattleFinishAdViewMediator__SetupEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5885a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Ad_BattleFinishAd_Controller_BattleFinishAdViewMediator_WatchButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5885a = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param2 + 0x14) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Ad_BattleFinishAd_Controller_BattleFinishAdViewMediator_WatchButtonClickHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060055BC RID: 21948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055BC")]
		[Address(RVA = "0xA35C", Offset = "0xA35C", VA = "0xA35C", Slot = "23")]
		protected override void ResetView(BattleFinishAdView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Ad_BattleFinishAd_Controller_BattleFinishAdViewMediator__ResetView
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5885b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Ad_BattleFinishAd_Controller_BattleFinishAdViewMediator_WatchButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5885b = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param2 + 0x14) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Ad_BattleFinishAd_Controller_BattleFinishAdViewMediator_WatchButtonClickHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  Gameplay_Ad_BattleFinishAd_Controller_BattleFinishAdViewMediator__HandleAdRewardedEvent
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060055BD RID: 21949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055BD")]
		[Address(RVA = "0xA35D", Offset = "0xA35D", VA = "0xA35D", Slot = "24")]
		protected override void SetupView(BattleFinishAdView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Ad_BattleFinishAd_Controller_BattleFinishAdViewMediator__SetupView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5885c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_BattleFinishAdViewState_State__set_CurrentState__)
		    ;
		    DAT_ram_00a5885c = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x18),1,
		             Method_UI_MonoBehaviourWithStates_BattleFinishAdViewState_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x060055BE RID: 21950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055BE")]
		[Address(RVA = "0xA35E", Offset = "0xA35E", VA = "0xA35E")]
		private void HandleAdRewardedEvent()
		{
		/* --- GHIDRA: HandleAdRewardedEvent ---
		void Gameplay_Ad_BattleFinishAd_Controller_BattleFinishAdViewMediator__HandleAdRewardedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  double dVar2;
		  int iVar3;
		  undefined4 param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5885d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_ArtifactInfo___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		    DAT_ram_00a5885d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = *(int *)(iVar1 + 0x20);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar3 != 0) {
		    iVar1 = System_Linq_Enumerable__Count_object_
		                      (*(undefined4 *)
		                        (*(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x20) + 0xc) + 0x20) + 8) +
		                        0x10),Method_System_Linq_Enumerable_First_ArtifactInfo___);
		    param1_00 = *(undefined4 *)(iVar1 + 0x18);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = Core_Data_ArtikulDataCustom__SetCurrentDurability
		                      (param1_00,*(undefined4 *)(*(int *)(iVar3 + 0x20) + 0x10),0);
		    dVar2 = func_ii_7527(*(undefined4 *)(*(int *)(iVar1 + 0x20) + 0xc),1,
		                         Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		    if (ABS(dVar2) < 2147483648.0) {
		      iVar1 = (int)dVar2;
		    }
		    else {
		      iVar1 = -0x80000000;
		    }
		    *(int *)(iVar3 + 0x38) = iVar1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = **(int **)(iVar1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x138) * 4))
		              (*(int **)(iVar1 + 0x10),iVar3,*(undefined4 *)(iVar4 + 0x13c));
		    return;
		  }
		  iVar3 = **(int **)(iVar1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x138) * 4))
		            (*(int **)(iVar1 + 0x10),0,*(undefined4 *)(iVar3 + 0x13c));
		  return;
		}
		*/

		}

		// Token: 0x060055BF RID: 21951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055BF")]
		[Address(RVA = "0xA35F", Offset = "0xA35F", VA = "0xA35F")]
		private void RenderReward()
		{
		/* --- GHIDRA: RenderReward ---
		void Gameplay_Ad_BattleFinishAd_Controller_BattleFinishAdViewMediator__RenderReward
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param3;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int local_4;
		  
		  if (DAT_ram_00a5885e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattleFinishAdPlacementModel__BattleFinishAdPlacementEvents__BattleFinishAdPlacementController__BattleFinishAdView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ArtifactDrop_Control_IArtifactDrop_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__get_Count__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2523);
		    DAT_ram_00a5885e = '\x01';
		  }
		  local_4 = 0;
		  piVar4 = *(int **)(param1[2] + 0x10);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_ArtifactDrop_Control_IArtifactDrop_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x80f358c4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Gameplay_ArtifactDrop_Control_IArtifactDrop_TypeInfo,4);
		code_r0x80f358c4:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,1,&local_4,puVar2[1]);
		  if ((iVar5 == 0) || (*(int *)(*(int *)(local_4 + 0xc) + 0xc) < 1)) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    piVar4 = *(int **)(iVar5 + 0x18);
		    uVar1 = 0;
		    uVar3 = Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController__IsAdAvailable
		                      (param1[2],0);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80f35af6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo
		                                  ,0);
		code_r0x80f35af6:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar4,uVar3,0,puVar2[1]);
		  }
		  else {
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
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		          goto code_r0x80f3598c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f3598c:
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    uVar1 = 0;
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xf0);
		          goto code_r0x80f35a0e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,6);
		code_r0x80f35a0e:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3 = func_ii_7508(StringLiteral_2523,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar3,0xd,param3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060055C0 RID: 21952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C0")]
		[Address(RVA = "0xA360", Offset = "0xA360", VA = "0xA360")]
		private void WatchButtonClickHandler()
		{
		/* --- GHIDRA: WatchButtonClickHandler ---
		undefined4
		Gameplay_Ad_BattleFinishAd_Controller_BattleFinishAdViewMediator__WatchButtonClickHandler
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5885f == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12556);
		    DAT_ram_00a5885f = '\x01';
		  }
		  return StringLiteral_12556;
		}
		*/

		}
	}
}
