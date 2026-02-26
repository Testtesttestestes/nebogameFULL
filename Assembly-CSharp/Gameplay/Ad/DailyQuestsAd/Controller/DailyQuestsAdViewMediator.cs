using System;
using System.Collections;
using Core.Gameplay.Managers.Ad.Placements.DailyQuests.Controller;
using Core.Gameplay.Managers.Ad.Placements.DailyQuests.Events;
using Core.Gameplay.Managers.Ad.Placements.DailyQuests.Model;
using Gameplay.Ad.DailyQuestsAd.View;
using Gameplay.DailyQuests.Model;
using Il2CppDummyDll;
using MVC;
using UnityEngine;

namespace Gameplay.Ad.DailyQuestsAd.Controller
{
	// Token: 0x02000DB0 RID: 3504
	[Token(Token = "0x2000DB0")]
	public class DailyQuestsAdViewMediator : AbstractViewMediator<DailyQuestsAdPlacementModel, DailyQuestsAdPlacementEvents, DailyQuestsAdPlacementController, DailyQuestsAdView>
	{
		// Token: 0x06005598 RID: 21912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005598")]
		[Address(RVA = "0xA338", Offset = "0xA338", VA = "0xA338")]
		public DailyQuestsAdViewMediator(DailyQuestsAdPlacementModel model, DailyQuestsAdPlacementEvents events, DailyQuestsAdPlacementController controller, IDailyQuest dailyQuest)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  
		  if (DAT_ram_00a5884b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementEvents__DailyQuestsAdPlacementController__DailyQuestsAdView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator_DailyQuestChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator_WatchButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5884b = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar2,0);
		  if (iVar3 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = *(undefined4 *)(*(int *)(iVar3 + 0x10) + 0xb4);
		    uVar1 = 0;
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar2,param1,
		               Method_Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator_WatchButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar5,uVar2,0);
		    piVar6 = (int *)param1[8];
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator_DailyQuestChangedEventHandler__
		               ,0);
		    iVar3 = *piVar6;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 200);
		          goto code_r0x80f345ca;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Gameplay_DailyQuests_Model_IQuest_TypeInfo,1);
		code_r0x80f345ca:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar6,uVar2,puVar4[1]);
		    if (param1[6] != 0) {
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      func_ii_20511(uVar2,param1[6],0);
		      param1[6] = 0;
		    }
		  }
		  param1[5] = param2;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar2,0);
		  if (iVar3 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = *(undefined4 *)(*(int *)(iVar3 + 0x10) + 0xb4);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar2,param1,
		               Method_Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator_WatchButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar2,0);
		    piVar6 = (int *)param1[8];
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator_DailyQuestChangedEventHandler__
		               ,0);
		    iVar3 = *piVar6;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80f3470b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Gameplay_DailyQuests_Model_IQuest_TypeInfo,0);
		code_r0x80f3470b:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar6,uVar2,puVar4[1]);
		    Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator__ValidateState(param1,puVar4);
		    if (param1[6] == 0) {
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      if (DAT_ram_00a5884f == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator__ValidateRoutine_d__11_TypeInfo
		                  );
		        DAT_ram_00a5884f = '\x01';
		      }
		      iVar3 = unnamed_function_1417
		                        (
		                        Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator__ValidateRoutine_d__11_TypeInfo
		                        );
		      *(int **)(iVar3 + 0x10) = param1;
		      *(undefined4 *)(iVar3 + 8) = 0;
		      iVar3 = UnityEngine_MonoBehaviour__StartCoroutine(uVar2,iVar3,0);
		      param1[6] = iVar3;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17001164 RID: 4452
		// (set) Token: 0x06005599 RID: 21913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001164")]
		public override DailyQuestsAdView View
		{
			[Token(Token = "0x6005599")]
			[Address(RVA = "0xA339", Offset = "0xA339", VA = "0xA339", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17001165 RID: 4453
		// (set) Token: 0x0600559A RID: 21914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001165")]
		public override DailyQuestsAdPlacementEvents Events
		{
			[Token(Token = "0x600559A")]
			[Address(RVA = "0xA33A", Offset = "0xA33A", VA = "0xA33A", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600559B RID: 21915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600559B")]
		[Address(RVA = "0xA33B", Offset = "0xA33B", VA = "0xA33B")]
		private void ValidateState()
		{
		/* --- GHIDRA: ValidateState ---
		void Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator__ValidateState
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  uint *puVar2;
		  uint uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5884d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    DAT_ram_00a5884d = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  param1_00 = (int *)param1[8];
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar3 = 0;
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar3 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar3 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x80f3483a;
		      }
		      uVar3 = uVar3 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar3);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Gameplay_DailyQuests_Model_IQuest_TypeInfo,4);
		code_r0x80f3483a:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,uVar3 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600559C RID: 21916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600559C")]
		[Address(RVA = "0xA33C", Offset = "0xA33C", VA = "0xA33C")]
		private void DailyQuestChangedEventHandler()
		{
		/* --- GHIDRA: DailyQuestChangedEventHandler ---
		void Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator__DailyQuestChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a5884e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementEvents__DailyQuestsAdPlacementController__DailyQuestsAdView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo);
		    DAT_ram_00a5884e = '\x01';
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
		        goto code_r0x80f34b37;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,
		                                Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo,0);
		code_r0x80f34b37:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,0,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600559D RID: 21917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600559D")]
		[Address(RVA = "0xA33D", Offset = "0xA33D", VA = "0xA33D")]
		private void WatchButtonClickedEventHandler()
		{
		/* --- GHIDRA: WatchButtonClickedEventHandler ---
		int Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator__WatchButtonClickedEventHandler
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5884f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator__ValidateRoutine_d__11_TypeInfo
		              );
		    DAT_ram_00a5884f = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator__ValidateRoutine_d__11_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x0600559E RID: 21918 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600559E")]
		[Address(RVA = "0xA33E", Offset = "0xA33E", VA = "0xA33E")]
		private IEnumerator ValidateRoutine()
		{
			return null;
		}

		// Token: 0x04002E57 RID: 11863
		[Token(Token = "0x4002E57")]
		[FieldOffset(Offset = "0x18")]
		private Coroutine _validateRoutine;

		// Token: 0x04002E58 RID: 11864
		[Token(Token = "0x4002E58")]
		[FieldOffset(Offset = "0x1C")]
		private bool _adAvailable;

		// Token: 0x04002E59 RID: 11865
		[Token(Token = "0x4002E59")]
		[FieldOffset(Offset = "0x20")]
		private readonly IDailyQuest _dailyQuest;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5884c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementEvents__DailyQuestsAdPlacementController__DailyQuestsAdView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator_ValidateState__
		              );
		    DAT_ram_00a5884c = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator_ValidateState__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator_ValidateState__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1))
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


		/* --- GHIDRA: set_Events ---
		void Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (param1[6] == 0) {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (DAT_ram_00a5884f == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator__ValidateRoutine_d__11_TypeInfo
		                );
		      DAT_ram_00a5884f = '\x01';
		    }
		    iVar1 = unnamed_function_1417
		                      (
		                      Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator__ValidateRoutine_d__11_TypeInfo
		                      );
		    *(int **)(iVar1 + 0x10) = param1;
		    *(undefined4 *)(iVar1 + 8) = 0;
		    iVar1 = UnityEngine_MonoBehaviour__StartCoroutine(param1_00,iVar1,0);
		    param1[6] = iVar1;
		  }
		  return;
		}
		*/

}
