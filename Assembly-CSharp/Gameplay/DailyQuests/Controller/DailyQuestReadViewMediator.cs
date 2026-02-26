using System;
using Gameplay.DailyQuests.Events;
using Gameplay.DailyQuests.Model;
using Gameplay.DailyQuests.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.DailyQuests.Controller
{
	// Token: 0x02000887 RID: 2183
	[Token(Token = "0x2000887")]
	public class DailyQuestReadViewMediator : AbstractViewMediator<DailyQuestsModel, DailyQuestEvents, DailyQuestsController, DailyQuestReadView>
	{
		// Token: 0x0600335C RID: 13148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600335C")]
		[Address(RVA = "0x8397", Offset = "0x8397", VA = "0x8397", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator__Dispose
		               (int param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a57c5b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestReadView___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_QuestChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    DAT_ram_00a57c5b = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestReadView___ctor__
		            );
		  param1_01 = *(int **)(param2 + 0x20);
		  *(int **)(param1 + 0x1c) = param1_01;
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_QuestChangedEventHandler__
		             ,0);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e37693;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Gameplay_DailyQuests_Model_IQuest_TypeInfo,0);
		code_r0x80e37693:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_01,param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600335D RID: 13149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600335D")]
		[Address(RVA = "0x8398", Offset = "0x8398", VA = "0x8398")]
		public DailyQuestReadViewMediator(DailyQuestsModel model, DailyQuestEvents events, DailyQuestsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57c5c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestReadView__set_View__
		              );
		    DAT_ram_00a57c5c = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator__QuestChangedEventHandler
		              (param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000A3D RID: 2621
		// (set) Token: 0x0600335E RID: 13150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A3D")]
		public override DailyQuestReadView View
		{
			[Token(Token = "0x600335E")]
			[Address(RVA = "0x8399", Offset = "0x8399", VA = "0x8399", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (set) Token: 0x0600335F RID: 13151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A3E")]
		public override DailyQuestEvents Events
		{
			[Token(Token = "0x600335F")]
			[Address(RVA = "0x839A", Offset = "0x839A", VA = "0x839A", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003360 RID: 13152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003360")]
		[Address(RVA = "0x839B", Offset = "0x839B", VA = "0x839B")]
		private void ToMailButtonClickedEventHandler()
		{
		/* --- GHIDRA: ToMailButtonClickedEventHandler ---
		void Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator__ToMailButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06003361 RID: 13153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003361")]
		[Address(RVA = "0x839C", Offset = "0x839C", VA = "0x839C")]
		private void ActionButtonClickedEventHandler()
		{
		/* --- GHIDRA: ActionButtonClickedEventHandler ---
		void Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator__ActionButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57c5f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_DailyQuestReadView_State__set_CurrentState__);
		    DAT_ram_00a57c5f = '\x01';
		  }
		  Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator__TakeGoalReward(param1,param1);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1_00,3,
		             Method_UI_MonoBehaviourWithStates_DailyQuestReadView_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x06003362 RID: 13154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003362")]
		[Address(RVA = "0x839D", Offset = "0x839D", VA = "0x839D")]
		private void HandleTakeRewardFinishedEvent()
		{
		/* --- GHIDRA: HandleTakeRewardFinishedEvent ---
		void Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator__HandleTakeRewardFinishedEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57c60 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestReadView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IGoal_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IList_GameActivityDic_Types_URI__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Rounting_ILocatorRepository_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Rounting_ILocator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_GameActivityRouting_IRouter_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10979);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10978);
		    DAT_ram_00a57c60 = '\x01';
		  }
		  iVar6 = Gameplay_DailyQuests_Model_IGoal_TypeInfo;
		  local_4 = 0;
		  local_8 = (int *)0x0;
		  piVar2 = (int *)func_ii_1082(*(undefined4 *)(*(int *)(param1 + 8) + 0x20),
		                               Gameplay_DailyQuests_Model_IGoal_TypeInfo);
		  iVar4 = *piVar2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (iVar6 == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e3c923;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,iVar6,0);
		code_r0x80e3c923:
		  piVar2 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  uVar1 = 0;
		  iVar6 = *piVar2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_GameActivityDic_Types_URI__TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e3c9a7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,
		                                System_Collections_Generic_IList_GameActivityDic_Types_URI__TypeInfo
		                                ,0);
		code_r0x80e3c9a7:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,0,puVar3[1]);
		  uVar5 = *(undefined4 *)(iVar6 + 0x10);
		  if (*(int *)(System_Uri_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Uri_TypeInfo);
		  }
		  iVar4 = func_ii_16334(uVar5,0,&local_4,0);
		  if (iVar4 == 0) {
		    uVar5 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor
		                      (StringLiteral_10978,*(undefined4 *)(iVar6 + 0x10),0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar5,0);
		  }
		  else {
		    uVar1 = 0;
		    piVar2 = *(int **)(*(int *)(param1 + 8) + 0x10);
		    iVar4 = *piVar2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x2b0);
		          goto code_r0x80e3ca5a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,0x3e);
		code_r0x80e3ca5a:
		    piVar2 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		    uVar1 = 0;
		    iVar4 = *piVar2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_GameActivityRouting_IRouter_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e3cadc;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,Core_Gameplay_Managers_GameActivityRouting_IRouter_TypeInfo
		                                  ,0);
		code_r0x80e3cadc:
		    piVar2 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		    uVar5 = local_4;
		    uVar1 = 0;
		    iVar4 = *piVar2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Rounting_ILocatorRepository_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e3cb64;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,Core_Rounting_ILocatorRepository_TypeInfo,0);
		code_r0x80e3cb64:
		    iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,uVar5,&local_8,puVar3[1]);
		    uVar5 = local_4;
		    piVar2 = local_8;
		    if (iVar4 == 0) {
		      uVar5 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor
		                        (StringLiteral_10979,*(undefined4 *)(iVar6 + 0x10),0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      func_ii_7830(uVar5,0);
		    }
		    else {
		      uVar1 = 0;
		      iVar6 = *local_8;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (Core_Rounting_ILocator_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		            goto code_r0x80e3cbec;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(local_8,Core_Rounting_ILocator_TypeInfo,2);
		code_r0x80e3cbec:
		      (**(code **)((ulonglong)*puVar3 * 4))(piVar2,uVar5,puVar3[1]);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003363 RID: 13155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003363")]
		[Address(RVA = "0x839E", Offset = "0x839E", VA = "0x839E")]
		private void ShowTutorial()
		{
		/* --- GHIDRA: ShowTutorial ---
		void Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator__ShowTutorial
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *param3;
		  undefined4 param2_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57c61 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestReadView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    DAT_ram_00a57c61 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_01 = *(int **)(param1[2] + 0x20);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)
		         ) {
		        param3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x100);
		        goto code_r0x80e3cd2f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  param3 = (uint *)func_ii_1080(param1_01,Gameplay_DailyQuests_Model_IQuest_TypeInfo,8);
		code_r0x80e3cd2f:
		  param2_00 = (**(code **)((ulonglong)*param3 * 4))(param1_01,param3[1]);
		  Gameplay_DailyQuests_Controller_DailyQuestsController__GetAllGoalsServiceHandler
		            (param1_00,param2_00,param3);
		  return;
		}
		*/

		}

		// Token: 0x06003364 RID: 13156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003364")]
		[Address(RVA = "0x839F", Offset = "0x839F", VA = "0x839F")]
		private void TakeDailyQuestReward()
		{
		/* --- GHIDRA: TakeDailyQuestReward ---
		void Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator__TakeDailyQuestReward
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *param3;
		  undefined4 param2_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57c62 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestReadView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    DAT_ram_00a57c62 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_01 = *(int **)(param1[2] + 0x20);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)
		         ) {
		        param3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x100);
		        goto code_r0x80e3ceba;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  param3 = (uint *)func_ii_1080(param1_01,Gameplay_DailyQuests_Model_IQuest_TypeInfo,8);
		code_r0x80e3ceba:
		  param2_00 = (**(code **)((ulonglong)*param3 * 4))(param1_01,param3[1]);
		  Gameplay_DailyQuests_Controller_DailyQuestsController__TakeDailyQuestRewardServiceHandler
		            (param1_00,param2_00,param3);
		  return;
		}
		*/

		}

		// Token: 0x06003365 RID: 13157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003365")]
		[Address(RVA = "0x83A0", Offset = "0x83A0", VA = "0x83A0")]
		private void TakeGoalReward()
		{
		/* --- GHIDRA: TakeGoalReward ---
		void Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator__TakeGoalReward
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int *local_4;
		  
		  if (DAT_ram_00a57c63 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestReadView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_ShowTutorial__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_TakeDailyQuestReward__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_TakeGoalReward__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_DailyQuests_DailyQuestsAdPlacementManager_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IGoal_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    DAT_ram_00a57c63 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  uVar5 = *(undefined4 *)(param1[2] + 0x20);
		  iVar2 = func_ii_1082(uVar5,Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo);
		  if (iVar2 == 0) {
		    piVar6 = (int *)func_ii_1082(uVar5,Gameplay_DailyQuests_Model_IGoal_TypeInfo);
		    if (piVar6 != (int *)0x0) {
		      iVar2 = *param1;
		      uVar5 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x158) * 4))
		                        (param1,*(undefined4 *)(iVar2 + 0x15c));
		      Gameplay_DailyQuests_View_DailyQuestReadView__SetupTakeRewardView
		                (uVar5,piVar6,*(undefined4 *)(param1[2] + 8),iVar2);
		      iVar2 = *piVar6;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		              *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		            goto code_r0x80e3c4fa;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar6,Gameplay_DailyQuests_Model_IQuest_TypeInfo,4);
		code_r0x80e3c4fa:
		      iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		      iVar3 = unnamed_function_1417(System_Action_TypeInfo);
		      if (iVar2 == 0) {
		        UnityEngine_Events_UnityEvent__AddListener
		                  (iVar3,param1,
		                   Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_ShowTutorial__,
		                   0);
		      }
		      else {
		        UnityEngine_Events_UnityEvent__AddListener
		                  (iVar3,param1,
		                   Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_TakeGoalReward__
		                   ,0);
		      }
		      param1[6] = iVar3;
		    }
		  }
		  else {
		    iVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (iVar3,param1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_TakeDailyQuestReward__
		               ,0);
		    param1[6] = iVar3;
		    uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = 0;
		    Gameplay_DailyQuests_View_DailyQuestReadView__Awake
		              (uVar5,iVar2,*(undefined4 *)(param1[2] + 8),0);
		    piVar6 = *(int **)(param1[2] + 0x10);
		    iVar3 = *piVar6;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x268);
		          goto code_r0x80e3c42a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x35);
		code_r0x80e3c42a:
		    iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		    iVar3 = Core_Gameplay_Managers_Ad_Model_AbstractAdModel__TryGetAdPlacementData
		                      (*(undefined4 *)(iVar3 + 0x14),4,&local_4,0);
		    if (iVar3 != 0) {
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      if (local_4 != (int *)0x0) {
		        if (((uint)*(byte *)(*local_4 + 0xb8) <
		             (uint)*(byte *)(
		                            Core_Gameplay_Managers_Ad_Placements_DailyQuests_DailyQuestsAdPlacementManager_TypeInfo
		                            + 0xb8)) ||
		           (*(int *)(*(int *)(*local_4 + 100) +
		                     (uint)*(byte *)(
		                                    Core_Gameplay_Managers_Ad_Placements_DailyQuests_DailyQuestsAdPlacementManager_TypeInfo
		                                    + 0xb8) * 4 + -4) !=
		            Core_Gameplay_Managers_Ad_Placements_DailyQuests_DailyQuestsAdPlacementManager_TypeInfo)
		           ) {
		          System_Activator__CreateInstance
		                    (local_4,
		                     Core_Gameplay_Managers_Ad_Placements_DailyQuests_DailyQuestsAdPlacementManager_TypeInfo
		                    );
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      Gameplay_Ad_DailyQuestsAd_View_DailyQuestsAdView__get_LoadingGroup
		                (*(undefined4 *)(iVar3 + 0x4c),iVar2,local_4,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003366 RID: 13158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003366")]
		[Address(RVA = "0x83A1", Offset = "0x83A1", VA = "0x83A1")]
		private void QuestChangedEventHandler()
		{
		/* --- GHIDRA: QuestChangedEventHandler ---
		void Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator__QuestChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57c64 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_ActionButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_ToMailButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57c64 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x34) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_ActionButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x48) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_ToMailButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003367 RID: 13159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003367")]
		[Address(RVA = "0x83A2", Offset = "0x83A2", VA = "0x83A2")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57c65 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_ActionButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_ToMailButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57c65 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x34) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_ActionButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x48) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_ToMailButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator__TakeGoalReward(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003368 RID: 13160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003368")]
		[Address(RVA = "0x83A3", Offset = "0x83A3", VA = "0x83A3")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator__SetupView
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57c66 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_DailyQuestsModel__DailyQuestEvents__Dispose__);
		    DAT_ram_00a57c66 = '\x01';
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_DailyQuestsModel__DailyQuestEvents__Dispose__);
		  Gameplay_DailyQuests_Controller_QuestsTriggerObserver__GetImpactedQuests
		            (*(undefined4 *)(param1 + 0x18),param1);
		  return;
		}
		*/

		}

		// Token: 0x04001C0A RID: 7178
		[Token(Token = "0x4001C0A")]
		[FieldOffset(Offset = "0x18")]
		private Action ActionHandler;

		// Token: 0x04001C0B RID: 7179
		[Token(Token = "0x4001C0B")]
		[FieldOffset(Offset = "0x1C")]
		private IQuest _currentQuest;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57c5d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestReadView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_HandleTakeRewardFinishedEvent__
		              );
		    DAT_ram_00a57c5d = '\x01';
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
		               Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_HandleTakeRewardFinishedEvent__
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
		               Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_HandleTakeRewardFinishedEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x20) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x20) = piVar4, *piVar4 != iVar1))
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
		void Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57c5e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestReadView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_DailyQuestReadView_State__set_CurrentState__);
		    DAT_ram_00a57c5e = '\x01';
		  }
		  param1_00 = *(int **)(param1[2] + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x168);
		        goto code_r0x80e3c77c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x15);
		code_r0x80e3c77c:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  Core_Gameplay_Managers_GameEventsManager__SetView(uVar3,1,0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar3,2,Method_UI_MonoBehaviourWithStates_DailyQuestReadView_State__set_CurrentState__)
		  ;
		  return;
		}
		*/

}
