using System;
using Gameplay.GameEvents.Model;
using Gameplay.GameEvents.Model.ActionsOnEvents;
using Gameplay.GameEvents.View;
using Il2CppDummyDll;
using MVC;
using UnityEngine.EventSystems;

namespace Gameplay.GameEvents.Control
{
	// Token: 0x020007DF RID: 2015
	[Token(Token = "0x20007DF")]
	public class GameEventReadViewMediator : AbstractViewMediator<GameEventsModel, GameEventsEvents, GameEventsController, GameEventReadView>
	{
		// Token: 0x06002F1E RID: 12062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F1E")]
		[Address(RVA = "0x7F8B", Offset = "0x7F8B", VA = "0x7F8B", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_GameEvents_Control_GameEventReadViewMediator__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a5750a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventReadView___ctor__
		              );
		    DAT_ram_00a5750a = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventReadView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F1F")]
		[Address(RVA = "0x7F8C", Offset = "0x7F8C", VA = "0x7F8C")]
		public GameEventReadViewMediator(GameEventsModel model, GameEventsEvents events, GameEventsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GameEvents_Control_GameEventReadViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 uVar7;
		  
		  uVar5 = 0;
		  if (DAT_ram_00a5750b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventReadView__get_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventReadView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_EventHandler_AbstractActionOnEvent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventReadViewMediator_HandleClickOnBackground__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventReadViewMediator_HandleOnActionTriggeredEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventReadViewMediator_HandleOnClickTakeRewardButton__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventReadViewMediator_HandleOnDropProcessCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5750b = '\x01';
		  }
		  iVar4 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1[5],0);
		  if (iVar4 != 0) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(*(int *)(iVar4 + 0x2c) + 0xb4);
		    uVar5 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar5,param1,
		               Method_Gameplay_GameEvents_Control_GameEventReadViewMediator_HandleOnClickTakeRewardButton__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar7,uVar5,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(iVar4 + 0x28);
		    uVar5 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar5,param1,
		               Method_Gameplay_GameEvents_Control_GameEventReadViewMediator_HandleOnDropProcessCompleteEvent__
		               ,0);
		    UI_Rewards_RewardsRender__add_OnDropProcessCompleteEvent(uVar7,uVar5,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = *(int *)(iVar4 + 0x30);
		    uVar5 = unnamed_function_1417(System_EventHandler_AbstractActionOnEvent__TypeInfo);
		    UnityEngine_Object__Instantiate_object_
		              (uVar5,param1,
		               Method_Gameplay_GameEvents_Control_GameEventReadViewMediator_HandleOnActionTriggeredEvent__
		               ,0);
		    if (DAT_ram_00a57483 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_EventHandler_AbstractActionOnEvent__TypeInfo);
		      DAT_ram_00a57483 = '\x01';
		    }
		    iVar3 = *(int *)(iVar4 + 0x18);
		    do {
		      iVar2 = 0;
		      iVar6 = func_ii_7048(iVar3,uVar5,0);
		      uVar7 = System_EventHandler_AbstractActionOnEvent__TypeInfo;
		      if ((iVar6 != 0) &&
		         (iVar2 = func_ii_1082(iVar6,System_EventHandler_AbstractActionOnEvent__TypeInfo),
		         iVar2 == 0)) {
		        System_Activator__CreateInstance(iVar6,uVar7);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = func_ii_4329(iVar4 + 0x18,iVar2,iVar3);
		      bVar1 = iVar2 != iVar3;
		      iVar3 = iVar2;
		    } while (bVar1);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = *(undefined4 *)(iVar4 + 0x38);
		    uVar7 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar7,param1,
		               Method_Gameplay_GameEvents_Control_GameEventReadViewMediator_HandleClickOnBackground__
		               ,0);
		    Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(uVar5,uVar7,0);
		  }
		  param1[5] = param2;
		  iVar4 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param2,0);
		  if (iVar4 != 0) {
		    Gameplay_GameEvents_Control_GameEventReadViewMediator__HandleGetReward(param1,uVar5);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(*(int *)(iVar4 + 0x2c) + 0xb4);
		    uVar5 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar5,param1,
		               Method_Gameplay_GameEvents_Control_GameEventReadViewMediator_HandleOnClickTakeRewardButton__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar7,uVar5,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(iVar4 + 0x28);
		    uVar5 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar5,param1,
		               Method_Gameplay_GameEvents_Control_GameEventReadViewMediator_HandleOnDropProcessCompleteEvent__
		               ,0);
		    UI_Rewards_RewardsContainer___ctor(uVar7,uVar5,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = *(int *)(iVar4 + 0x30);
		    uVar5 = unnamed_function_1417(System_EventHandler_AbstractActionOnEvent__TypeInfo);
		    UnityEngine_Object__Instantiate_object_
		              (uVar5,param1,
		               Method_Gameplay_GameEvents_Control_GameEventReadViewMediator_HandleOnActionTriggeredEvent__
		               ,0);
		    if (DAT_ram_00a57482 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_EventHandler_AbstractActionOnEvent__TypeInfo);
		      DAT_ram_00a57482 = '\x01';
		    }
		    iVar3 = *(int *)(iVar4 + 0x18);
		    do {
		      iVar2 = 0;
		      iVar6 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		      uVar7 = System_EventHandler_AbstractActionOnEvent__TypeInfo;
		      if ((iVar6 != 0) &&
		         (iVar2 = func_ii_1082(iVar6,System_EventHandler_AbstractActionOnEvent__TypeInfo),
		         iVar2 == 0)) {
		        System_Activator__CreateInstance(iVar6,uVar7);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = func_ii_4329(iVar4 + 0x18,iVar2,iVar3);
		      bVar1 = iVar2 != iVar3;
		      iVar3 = iVar2;
		    } while (bVar1);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar7 = *(undefined4 *)(iVar4 + 0x38);
		    uVar5 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar5,param1,
		               Method_Gameplay_GameEvents_Control_GameEventReadViewMediator_HandleClickOnBackground__
		               ,0);
		    Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(uVar7,uVar5,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000934 RID: 2356
		// (set) Token: 0x06002F20 RID: 12064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000934")]
		public override GameEventReadView View
		{
			[Token(Token = "0x6002F20")]
			[Address(RVA = "0x7F8D", Offset = "0x7F8D", VA = "0x7F8D", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000935 RID: 2357
		// (set) Token: 0x06002F21 RID: 12065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000935")]
		public override GameEventsEvents Events
		{
			[Token(Token = "0x6002F21")]
			[Address(RVA = "0x7F8E", Offset = "0x7F8E", VA = "0x7F8E", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F22")]
		[Address(RVA = "0x7F8F", Offset = "0x7F8F", VA = "0x7F8F")]
		private void HandleOnActionTriggeredEvent(object sender, AbstractActionOnEvent action)
		{
		/* --- GHIDRA: HandleOnActionTriggeredEvent ---
		void Gameplay_GameEvents_Control_GameEventReadViewMediator__HandleOnActionTriggeredEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5750d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventReadView__get_Model__
		              );
		    DAT_ram_00a5750d = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_GameEvents_Control_GameEventsController__GetReward
		            (param1_00,*(undefined4 *)(param1[2] + 0x34),param1);
		  return;
		}
		*/

		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F23")]
		[Address(RVA = "0x7F90", Offset = "0x7F90", VA = "0x7F90")]
		private void HandleOnDropProcessCompleteEvent()
		{
		/* --- GHIDRA: HandleOnDropProcessCompleteEvent ---
		void Gameplay_GameEvents_Control_GameEventReadViewMediator__HandleOnDropProcessCompleteEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_GameEvents_Control_GameEventReadViewMediator__DisplayArtifactReward(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F24")]
		[Address(RVA = "0x7F91", Offset = "0x7F91", VA = "0x7F91")]
		private void HandleOnClickTakeRewardButton()
		{
		/* --- GHIDRA: HandleOnClickTakeRewardButton ---
		void Gameplay_GameEvents_Control_GameEventReadViewMediator__HandleOnClickTakeRewardButton
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5750e == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_19433);
		    DAT_ram_00a5750e = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = Gameplay_GameEvents_Model_GameEventData__TryResetArtifactFromRewardCache
		                    (*(undefined4 *)(iVar1 + 0x40),&local_4,auStack_10);
		  if (iVar1 != 0) {
		    Core_ExternAppMethods__OpenPaymentWindow(local_4,StringLiteral_19433,0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F25")]
		[Address(RVA = "0x7F92", Offset = "0x7F92", VA = "0x7F92")]
		private void HandleClickOnBackground(PointerEventData obj)
		{
		/* --- GHIDRA: HandleClickOnBackground ---
		void Gameplay_GameEvents_Control_GameEventReadViewMediator__HandleClickOnBackground
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5750f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventReadView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_GameEventReadView_GameEventReadViewStates__set_CurrentState__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Count__);
		    DAT_ram_00a5750f = '\x01';
		  }
		  if ((*(int *)(param2 + 0x30) != 0) && (0 < *(int *)(*(int *)(param2 + 0x30) + 0xc))) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (uVar1,2,
		               Method_UI_MonoBehaviourWithStates_GameEventReadView_GameEventReadViewStates__set_CurrentState__
		              );
		    Gameplay_GameEvents_Control_GameEventReadViewMediator__HandleGetRewardCompleteEvent
		              (param1,param2,param1);
		    return;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_GameEvents_Control_GameEventsController__GetReward
		            (uVar1,*(undefined4 *)(param1[2] + 0x34),param1);
		  return;
		}
		*/

		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F26")]
		[Address(RVA = "0x7F93", Offset = "0x7F93", VA = "0x7F93")]
		private void HandleGetRewardCompleteEvent(GameEventData evt)
		{
		/* --- GHIDRA: HandleGetRewardCompleteEvent ---
		void Gameplay_GameEvents_Control_GameEventReadViewMediator__HandleGetRewardCompleteEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  int param1_01;
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 param2_00;
		  uint uVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57510 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Main_DropTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_object__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_object__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_RewardData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetDelay_Tweener___);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tweener___);
		    DAT_ram_00a57510 = '\x01';
		  }
		  param1_00 = Core_Data_RewardData___ctor(3,0);
		  param1_01 = unnamed_function_1417(System_Collections_Generic_List_object__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_01,Method_System_Collections_Generic_List_object___ctor__);
		  *(int *)(param1_00 + 0xc) = param1_01;
		  local_4 = 3;
		  uVar1 = func_ii_1081(Protocol_Main_DropTypes_TypeInfo,&local_4);
		  iVar2 = Method_System_Collections_Generic_List_object__Add__;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_01 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(param1_01 + 8) + uVar4 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  func_ii_6335(*(undefined4 *)(param1_00 + 0xc),*(undefined4 *)(param2 + 0x30),
		               Method_System_Collections_Generic_List_object__AddRange__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = *(undefined4 *)(iVar2 + 0x28);
		  piVar3 = (int *)Mono_Security_ASN1Convert__ToOid(Core_Data_RewardData___TypeInfo,1);
		  iVar2 = func_ii_1082(param1_00,*(undefined4 *)(*piVar3 + 0x20));
		  if (iVar2 == 0) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar3[4] = param1_00;
		  piVar3 = (int *)func_ii_7307(uVar1,piVar3,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xf0) * 4))(piVar3,*(undefined4 *)(*piVar3 + 0xf4));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = DG_Tweening_DOTweenModuleUI__DOHorizontalNormalizedPos
		                    (*(undefined4 *)(iVar2 + 0x3c),0.0,1.2,0,0);
		  uVar1 = DG_Tweening_DOTweenModuleUI__DOFade
		                    (uVar1,0.1,Method_DG_Tweening_TweenSettingsExtensions_SetDelay_Tweener___);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar2 + 0x3c),0);
		  DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		            (uVar1,param2_00,Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tweener___);
		  return;
		}
		*/

		}

		// Token: 0x06002F27 RID: 12071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F27")]
		[Address(RVA = "0x7F94", Offset = "0x7F94", VA = "0x7F94")]
		private void DisplayArtifactReward(GameEventData evt)
		{
		/* --- GHIDRA: DisplayArtifactReward ---
		void Gameplay_GameEvents_Control_GameEventReadViewMediator__DisplayArtifactReward
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57511 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventReadView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Count__);
		    DAT_ram_00a57511 = '\x01';
		  }
		  iVar1 = *(int *)(param1[2] + 0x34);
		  if ((*(int *)(iVar1 + 0x30) == 0) || (*(int *)(*(int *)(iVar1 + 0x30) + 0xc) < 1)) {
		    iVar1 = System_Collections_Generic_Dictionary_Enumerator_ulong__object___MoveNext
		                      (*(undefined4 *)(iVar1 + 0x1c),*(undefined4 *)(param1[2] + 0x44),0);
		    if (iVar1 == 0) {
		      param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		      iVar1 = *(int *)(param1[2] + 0x34);
		      local_4 = *(undefined4 *)(*(int *)(iVar1 + 0x24) + 0x24);
		      Core_Extensions_TransformExt__SetBottom(&local_4,4,0);
		      *(undefined4 *)(*(int *)(iVar1 + 0x24) + 0x24) = local_4;
		      Gameplay_GameEvents_Control_GameEventsController__HandleProcessEventService
		                (param1_00,iVar1,iVar1);
		      return;
		    }
		    iVar1 = *(int *)(param1[2] + 0x34);
		  }
		  Gameplay_GameEvents_Control_GameEventReadViewMediator__HandleClickOnBackground
		            (param1,iVar1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F28")]
		[Address(RVA = "0x7F95", Offset = "0x7F95", VA = "0x7F95")]
		private void HandleGetReward()
		{
		/* --- GHIDRA: HandleGetReward ---
		void Gameplay_GameEvents_Control_GameEventReadViewMediator__HandleGetReward
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57512 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventReadView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_GameEventReadView_GameEventReadViewStates__set_CurrentState__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__get_Count__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetDelay_Tweener___);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tweener___);
		    DAT_ram_00a57512 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = *(int *)(param1[2] + 0x34);
		  if (*(int *)(iVar1 + 0x40) != iVar5) {
		    *(int *)(iVar1 + 0x40) = iVar5;
		    Gameplay_GameEvents_View_GameEventReadView__set_Data(iVar1,param1);
		    iVar5 = *(int *)(param1[2] + 0x34);
		  }
		  if (*(int *)(*(int *)(*(int *)(iVar5 + 0x24) + 0x3c) + 0xc) < 1) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (uVar2,3,
		               Method_UI_MonoBehaviourWithStates_GameEventReadView_GameEventReadViewStates__set_CurrentState__
		              );
		  }
		  else {
		    local_4 = *(undefined4 *)(*(int *)(iVar5 + 0x24) + 0x24);
		    iVar1 = UnityEngine_InputForUI_PointerEvent_ButtonsState__Set(&local_4,4,0);
		    if (iVar1 == 0) {
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (uVar2,1,
		                 Method_UI_MonoBehaviourWithStates_GameEventReadView_GameEventReadViewStates__set_CurrentState__
		                );
		    }
		    else {
		      iVar1 = func_ii_6860(*(undefined4 *)(param1[2] + 0x34),param1);
		      if (iVar1 != 0) {
		        Gameplay_GameEvents_Control_GameEventReadViewMediator__DisplayArtifactReward(param1,param1);
		        return;
		      }
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (uVar2,3,
		                 Method_UI_MonoBehaviourWithStates_GameEventReadView_GameEventReadViewStates__set_CurrentState__
		                );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar1 + 0x28);
		  uVar4 = *(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x34) + 0x24) + 0x3c);
		  if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		  }
		  uVar4 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar4,0);
		  piVar3 = (int *)func_ii_7307(uVar2,uVar4,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xf0) * 4))(piVar3,*(undefined4 *)(*piVar3 + 0xf4));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = DG_Tweening_DOTweenModuleUI__DOHorizontalNormalizedPos
		                    (*(undefined4 *)(iVar1 + 0x3c),1.0,0.0,0,0);
		  uVar2 = DG_Tweening_DOTweenModuleUI__DOFade
		                    (uVar2,0.1,Method_DG_Tweening_TweenSettingsExtensions_SetDelay_Tweener___);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x3c),0);
		  DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		            (uVar2,uVar4,Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tweener___);
		  return;
		}
		*/

		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F29")]
		[Address(RVA = "0x7F96", Offset = "0x7F96", VA = "0x7F96")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_GameEvents_Control_GameEventReadViewMediator__SetupView(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57513 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_GameEventsModel__GameEventsEvents__Dispose__);
		    DAT_ram_00a57513 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  Utils_Timers_DelayedCall__DelayedCallAsync(*(undefined4 *)(param1 + 0x1c),0);
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_GameEventsModel__GameEventsEvents__Dispose__);
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_GameEvents_Control_GameEventReadViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5750c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventReadView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_GameEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventReadViewMediator_HandleGetRewardCompleteEvent__
		              );
		    DAT_ram_00a5750c = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x24);
		    uVar2 = unnamed_function_1417(System_Action_GameEventData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_GameEvents_Control_GameEventReadViewMediator_HandleGetRewardCompleteEvent__
		               ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_GameEventData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x24) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_GameEventData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x24) = iVar4;
		      uVar2 = System_Action_GameEventData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_GameEventData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x24);
		    uVar2 = unnamed_function_1417(System_Action_GameEventData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_GameEvents_Control_GameEventReadViewMediator_HandleGetRewardCompleteEvent__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_GameEventData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x24) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_GameEventData__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x24) = iVar4;
		    uVar2 = System_Action_GameEventData__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_GameEventData__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_GameEvents_Control_GameEventReadViewMediator__set_Events
		               (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  param2_00 = *(undefined4 *)(param3 + 0x10);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_GameEvents_Control_GameEventsController__GetReward(param1_00,param2_00,param1);
		  return;
		}
		*/

}
