using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.SquadTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Clans;
using Protocol.Common;
using UI.Windows;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A79 RID: 2681
	[Token(Token = "0x2000A79")]
	public class SquadViewMediator : AbstractViewMediator<SquadModel, SquadEvents, SquadController, SquadView>, IHideableMediator
	{
		// Token: 0x06003FDB RID: 16347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FDB")]
		[Address(RVA = "0x8E95", Offset = "0x8E95", VA = "0x8E95")]
		public SquadViewMediator(SquadModel model, SquadEvents events, SquadController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_SquadViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a576c1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SquadModel__SquadEvents__SquadController__SquadView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__SquadListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator_CrossButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator_JoinButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator_RentButtonClickedEventHandler__
		              );
		    DAT_ram_00a576c1 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_MemberSlotView__SquadListElement__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator_JoinButtonClickedEventHandler__
		               ,0);
		    Gameplay_Clans_Office_View_SquadTab_SquadView__add_JoinButtonClickedEvent(uVar1,uVar3,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_MemberSlotView__SquadListElement__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator_CrossButtonClickedEventHandler__
		               ,0);
		    Gameplay_Clans_Office_View_SquadTab_SquadView__add_CrossButtonClickedEvent(uVar1,uVar3,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator_RentButtonClickedEventHandler__
		               ,0);
		    Gameplay_Clans_Office_View_SquadTab_SquadView__add_RentButtonClickedEvent(uVar1,uVar3,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_MemberSlotView__SquadListElement__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator_JoinButtonClickedEventHandler__
		               ,0);
		    Gameplay_Clans_Office_View_SquadTab_SquadListElement___ctor(uVar1,uVar3,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_MemberSlotView__SquadListElement__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator_CrossButtonClickedEventHandler__
		               ,0);
		    Gameplay_Clans_Office_View_SquadTab_SquadView__remove_JoinButtonClickedEvent(uVar1,uVar3,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator_RentButtonClickedEventHandler__
		               ,0);
		    Gameplay_Clans_Office_View_SquadTab_SquadView__remove_CrossButtonClickedEvent(uVar1,uVar3,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UnityEngine_UI_Toggle__get_isOn(*(undefined4 *)(iVar2 + 0x38),0,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    Gameplay_Clans_Office_Controller_SquadViewMediator__set_View(param1,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    if (*(char *)(*(int *)(iVar2 + 0x1c) + 9) != '\0') {
		      Gameplay_Clans_Office_Controller_SquadViewMediator__UpdateSeasonInfo(param1,param1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000CAB RID: 3243
		// (set) Token: 0x06003FDC RID: 16348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAB")]
		public override SquadView View
		{
			[Token(Token = "0x6003FDC")]
			[Address(RVA = "0x8E96", Offset = "0x8E96", VA = "0x8E96", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003FDD RID: 16349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FDD")]
		[Address(RVA = "0x8E97", Offset = "0x8E97", VA = "0x8E97")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_Controller_SquadViewMediator__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param2_00;
		  
		  if (DAT_ram_00a576c3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SquadModel__SquadEvents__SquadController__SquadView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SquadModel_PartyData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ColossusPartiesInfoDic__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ColossusPartiesInfoDic__get_Item__)
		    ;
		    DAT_ram_00a576c3 = '\x01';
		  }
		  param2_00 = *(int *)(*(int *)(*(int *)(param1 + 8) + 0x18) + 0xc);
		  iVar1 = Gameplay_Clans_Office_Model_ClassModel___c___PopulateSpells_b__29_1
		                    (*(int *)(param1 + 8),0);
		  if (param2_00 < *(int *)(*(int *)(iVar1 + 0x200) + 0xc)) {
		    iVar1 = Gameplay_Clans_Office_Model_ClassModel___c___PopulateSpells_b__29_1
		                      (*(undefined4 *)(param1 + 8),0);
		    iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (*(undefined4 *)(iVar1 + 0x200),param2_00,
		                       Method_Google_Protobuf_Collections_RepeatedField_ColossusPartiesInfoDic__get_Item__
		                      );
		    Gameplay_Clans_Office_Controller_SquadViewMediator__Hide
		              (param1,*(undefined4 *)(iVar1 + 0x14),param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FDE")]
		[Address(RVA = "0x8E98", Offset = "0x8E98", VA = "0x8E98")]
		private void RentButtonClickedEventHandler()
		{
		/* --- GHIDRA: RentButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_SquadViewMediator__RentButtonClickedEventHandler
		               (int *param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a576c4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SquadModel__SquadEvents__SquadController__SquadView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MemberSlotView_State__get_CurrentState__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9094);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17815);
		    DAT_ram_00a576c4 = '\x01';
		  }
		  iVar1 = Gameplay_Clans_Office_View_SquadTab_MemberSlotView__set_PartySlot(param2,0);
		  if ((iVar1 != 0) && (*(int *)(param2 + 0x18) != 4)) {
		    iVar1 = param1[2];
		    if (*(char *)(*(int *)(iVar1 + 0x10) + 0x20) == '\0') {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9094,1,0,1,0,0,0,0);
		      param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17815,1,0,1,0,0,0,0);
		      UI_Windows_DialogWindow__Show(uVar2,param2_00,0);
		      return;
		    }
		    if (*(int *)(param2 + 0x48) == 0) {
		      if (DAT_ram_00a576c5 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_MVC_AbstractViewMediator_SquadModel__SquadEvents__SquadController__SquadView__get_Model__
		                  );
		        Mono_Security_ASN1__get_Item
		                  (&Method_System_Collections_Generic_List_SquadModel_ColossusPartySlot__get_Count__
		                  );
		        DAT_ram_00a576c5 = '\x01';
		        iVar1 = param1[2];
		      }
		      iVar3 = *(int *)(*(int *)(*(int *)(param3 + 0x3c) + 0xc) + 0xc);
		      if ((iVar3 < *(int *)(*(int *)(iVar1 + 0x14) + 0xc)) &&
		         (iVar1 = *(int *)(*(int *)(iVar1 + 0x14) + iVar3 * 4 + 0x10), iVar1 != 0)) {
		        Gameplay_Clans_Office_Controller_SquadViewMediator__ShowRentPartyDialogWindow
		                  (param1,*(undefined4 *)(*(int *)(param3 + 0x40) + 0xc),
		                   *(undefined4 *)(iVar1 + 0x10),iVar1);
		        return;
		      }
		    }
		    else {
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		      Gameplay_Clans_Office_Controller_SquadController__GetPartyInfoResultHandler
		                (uVar2,*(undefined4 *)(*(int *)(*(int *)(param3 + 0x3c) + 0x10) + 0xc),
		                 *(undefined4 *)(*(int *)(*(int *)(param2 + 0x48) + 0x10) + 0xc),param2);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003FDF RID: 16351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FDF")]
		[Address(RVA = "0x8E99", Offset = "0x8E99", VA = "0x8E99")]
		private void JoinButtonClickedEventHandler(MemberSlotView slot, SquadListElement squad)
		{
		/* --- GHIDRA: JoinButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_SquadViewMediator__JoinButtonClickedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a576c5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SquadModel__SquadEvents__SquadController__SquadView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SquadModel_ColossusPartySlot__get_Count__);
		    DAT_ram_00a576c5 = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(*(int *)(param2 + 0x3c) + 0xc) + 0xc);
		  iVar2 = *(int *)(*(int *)(param1 + 8) + 0x14);
		  if ((iVar1 < *(int *)(iVar2 + 0xc)) && (iVar1 = *(int *)(iVar2 + iVar1 * 4 + 0x10), iVar1 != 0)) {
		    Gameplay_Clans_Office_Controller_SquadViewMediator__ShowRentPartyDialogWindow
		              (param1,*(undefined4 *)(*(int *)(param2 + 0x40) + 0xc),*(undefined4 *)(iVar1 + 0x10),
		               param2);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003FE0 RID: 16352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE0")]
		[Address(RVA = "0x8E9A", Offset = "0x8E9A", VA = "0x8E9A")]
		private void ShowBuySlotDialogWindow(SquadListElement squad)
		{
		/* --- GHIDRA: ShowBuySlotDialogWindow ---
		void Gameplay_Clans_Office_Controller_SquadViewMediator__ShowBuySlotDialogWindow
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_SquadController__GetPartyInfoResultHandler(param1_00,0,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE1")]
		[Address(RVA = "0x8E9B", Offset = "0x8E9B", VA = "0x8E9B")]
		private void CrossButtonClickedEventHandler(MemberSlotView slot, SquadListElement squad)
		{
		/* --- GHIDRA: CrossButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_SquadViewMediator__CrossButtonClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a576c6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SquadModel__SquadEvents__SquadController__SquadView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClansService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_SquadViewMediator_InitEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator_PartyInfoRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_SquadViewMediator_SlotsChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_SquadViewMediator_UpdateSeasonInfo__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_SquadViewMediator_UserLeftClanEventHandler__
		              );
		    DAT_ram_00a576c6 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  param1_00 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                        (Method_Core_Net_ServiceFactory_GetService_ClansService___);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator_PartyInfoRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator_SlotsChangedEventHandler__,
		               0);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = *(int *)(iVar1 + 0x14);
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator_InitEventHandler__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = *(int *)(iVar1 + 0x18);
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator_UpdateSeasonInfo__,0);
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
		    uVar3 = unnamed_function_1417(System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator_UserLeftClanEventHandler__,
		               0);
		    ServicesNamespace_ClansService__add_UserLeftClanEvent(param1_00,uVar3,0);
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator_PartyInfoRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator_SlotsChangedEventHandler__,
		               0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = *(int *)(iVar1 + 0x14);
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator_InitEventHandler__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = *(int *)(iVar1 + 0x18);
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator_UpdateSeasonInfo__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
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
		    uVar3 = unnamed_function_1417(System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator_UserLeftClanEventHandler__,
		               0);
		    ServicesNamespace_ClansService__remove_TreasuryChangedEvent(param1_00,uVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000CAC RID: 3244
		// (set) Token: 0x06003FE2 RID: 16354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAC")]
		public override SquadEvents Events
		{
			[Token(Token = "0x6003FE2")]
			[Address(RVA = "0x8E9C", Offset = "0x8E9C", VA = "0x8E9C", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE3")]
		[Address(RVA = "0x8E9D", Offset = "0x8E9D", VA = "0x8E9D")]
		private void UserLeftClanEventHandler(ProtoUserLeftClanEvt evt)
		{
		/* --- GHIDRA: UserLeftClanEventHandler ---
		void Gameplay_Clans_Office_Controller_SquadViewMediator__UserLeftClanEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a576c8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SquadModel__SquadEvents__SquadController__SquadView__get_Model__
		              );
		    DAT_ram_00a576c8 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x3c);
		  param2_00 = Gameplay_WorldAxis_Model_WorldAxisModel__set_SeasonActive
		                        (*(undefined4 *)(param1[2] + 0x10),0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(iVar1 + 0x40),*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x1c),0);
		  return;
		}
		*/

		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE4")]
		[Address(RVA = "0x8E9E", Offset = "0x8E9E", VA = "0x8E9E")]
		private void UpdateSeasonInfo()
		{
		/* --- GHIDRA: UpdateSeasonInfo ---
		void Gameplay_Clans_Office_Controller_SquadViewMediator__UpdateSeasonInfo
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  undefined4 param1_00;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a576c9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SquadModel__SquadEvents__SquadController__SquadView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21978);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17819);
		    DAT_ram_00a576c9 = '\x01';
		  }
		  local_4 = Core_Extensions_ClanInfoExt__GetHonorRating
		                      (*(undefined4 *)
		                        (*(int *)(*(int *)(*(int *)(param1[2] + 0xc) + 0x30) + 8) + 0x10),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x2c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17819,1,0,1,0,0,0,0);
		  iVar1 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  param3 = func_ii_4443(&local_4,0);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_21978,param3,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar1 + 0x10) = local_10;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar1,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003FE5 RID: 16357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE5")]
		[Address(RVA = "0x8E9F", Offset = "0x8E9F", VA = "0x8E9F")]
		private void InitEventHandler()
		{
		/* --- GHIDRA: InitEventHandler ---
		void Gameplay_Clans_Office_Controller_SquadViewMediator__InitEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  int param1_02;
		  undefined8 local_8;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a576ca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SquadModel__SquadEvents__SquadController__SquadView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21216);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17788);
		    DAT_ram_00a576ca = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(iVar1 + 0x24);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param1_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17788,1,0,1,0,0,0,0);
		  iVar1 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  param2_00 = StringLiteral_21216;
		  param1_02 = *(int *)(*(int *)(param1[2] + 0x10) + 0x24);
		  if (param1_02 != 0) {
		    uVar2 = Core_Extensions_Dict_DiscountsDicExt__GetDiscountDescription(param1_02,0);
		  }
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,param2_00,uVar2,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar1 + 0x10) = local_8;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (param1_00,iVar1,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_01,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003FE6 RID: 16358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE6")]
		[Address(RVA = "0x8EA0", Offset = "0x8EA0", VA = "0x8EA0")]
		private void UpdateDollInfo()
		{
		/* --- GHIDRA: UpdateDollInfo ---
		void Gameplay_Clans_Office_Controller_SquadViewMediator__UpdateDollInfo
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a576cb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SquadModel__SquadEvents__SquadController__SquadView__get_Model__
		              );
		    DAT_ram_00a576cb = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = Gameplay_Clans_Office_Model_ClassModel___c___PopulateSpells_b__29_1(param1[2],0);
		  iVar2 = param1[2];
		  Gameplay_Clans_Office_View_SquadTab_SquadView__ToggleObjects
		            (param1_00,*(undefined4 *)(iVar1 + 0x200),*(undefined4 *)(iVar2 + 0x18),
		             *(undefined4 *)(iVar2 + 0x14),*(undefined4 *)(iVar2 + 0x1c),0);
		  Gameplay_Clans_Office_Controller_SquadViewMediator__PartyInfoRequestedEventHandler(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE7")]
		[Address(RVA = "0x8EA1", Offset = "0x8EA1", VA = "0x8EA1")]
		private void SlotsChangedEventHandler()
		{
		/* --- GHIDRA: SlotsChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_SquadViewMediator__SlotsChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a576cc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SquadModel__SquadEvents__SquadController__SquadView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SquadModel_PartyData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_SquadView_State__set_CurrentState__);
		    DAT_ram_00a576cc = '\x01';
		  }
		  if (*(int *)(*(int *)(param1[2] + 0x18) + 0xc) == 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (uVar1,2,Method_UI_MonoBehaviourWithStates_SquadView_State__set_CurrentState__);
		    return;
		  }
		  Gameplay_Clans_Office_Controller_SquadViewMediator__PartyInfoRequestedEventHandler(param1,param1);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar1,1,Method_UI_MonoBehaviourWithStates_SquadView_State__set_CurrentState__);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Gameplay_Clans_Office_Model_ClassModel___c___PopulateSpells_b__29_1(param1[2],0);
		  iVar3 = param1[2];
		  Gameplay_Clans_Office_View_SquadTab_SquadView__ToggleObjects
		            (uVar1,*(undefined4 *)(iVar2 + 0x200),*(undefined4 *)(iVar3 + 0x18),
		             *(undefined4 *)(iVar3 + 0x14),*(undefined4 *)(iVar3 + 0x1c),0);
		  return;
		}
		*/

		}

		// Token: 0x06003FE8 RID: 16360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE8")]
		[Address(RVA = "0x8EA2", Offset = "0x8EA2", VA = "0x8EA2")]
		private void PartyInfoRequestedEventHandler()
		{
		/* --- GHIDRA: PartyInfoRequestedEventHandler ---
		void Gameplay_Clans_Office_Controller_SquadViewMediator__PartyInfoRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int param1_00;
		  undefined8 local_18;
		  undefined8 local_10;
		  int local_8;
		  int local_4;
		  
		  if (DAT_ram_00a576cd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SquadModel__SquadEvents__SquadController__SquadView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Count_SquadModel_ColossusPartySlot___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_SquadModel_PartyData___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_SelectMany_SquadModel_PartyData__SquadModel_ColossusPartySlot___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToArray_SquadModel_ColossusPartySlot___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Where_SquadModel_ColossusPartySlot___);
		    Mono_Security_ASN1__get_Item(&System_Func_SquadModel_PartyData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_SquadModel_PartyData__IEnumerable_SquadModel_ColossusPartySlot___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_SquadModel_ColossusPartySlot__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator___c__UpdateSquadInfo_b__16_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator___c__UpdateSquadInfo_b__16_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator___c__UpdateSquadInfo_b__16_2__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21978);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17813);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17789);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2084);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2183);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17812);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27362);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17816);
		    DAT_ram_00a576cd = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  uVar2 = *(undefined4 *)(param1[2] + 0x18);
		  if (*(int *)(Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[2];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar3;
		    iVar4 = unnamed_function_1417(System_Func_SquadModel_PartyData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar4,uVar5,
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator___c__UpdateSquadInfo_b__16_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo + 0x5c) + 8) =
		         iVar4;
		  }
		  iVar4 = System_Func_object__bool____ctor
		                    (uVar2,iVar4,
		                     Method_System_Linq_Enumerable_FirstOrDefault_SquadModel_PartyData___);
		  if (iVar4 == 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17816,1,0,1,0,0,0,0);
		    uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (StringLiteral_2183,uVar2,StringLiteral_2084,0);
		  }
		  else {
		    uVar2 = Core_Extensions_Dict_OptionsMenuButtonExt__GetIcon(*(undefined4 *)(iVar4 + 8),0);
		  }
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(iVar4 + 0x28);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17789,1,0,1,0,0,0,0);
		  iVar4 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_27362,uVar2,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar4 + 0x10) = local_10;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar1,iVar4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar5,uVar2,0);
		  uVar2 = *(undefined4 *)(param1[2] + 0x18);
		  if (*(int *)(Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[3];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar3;
		    iVar4 = unnamed_function_1417
		                      (
		                      System_Func_SquadModel_PartyData__IEnumerable_SquadModel_ColossusPartySlot___TypeInfo
		                      );
		    System_Linq_Enumerable__Where_object_
		              (iVar4,uVar5,
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator___c__UpdateSquadInfo_b__16_1__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo + 0x5c) + 0xc)
		         = iVar4;
		  }
		  uVar2 = System_Linq_Enumerable__SelectMany_ValueTuple_object__object___object_
		                    (uVar2,iVar4,
		                     Method_System_Linq_Enumerable_SelectMany_SquadModel_PartyData__SquadModel_ColossusPartySlot___
		                    );
		  iVar4 = func_ii_6295(uVar2,Method_System_Linq_Enumerable_ToArray_SquadModel_ColossusPartySlot___);
		  if (*(int *)(Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo + 0x5c);
		  param1_00 = puVar3[4];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar3;
		    param1_00 = unnamed_function_1417(System_Func_SquadModel_ColossusPartySlot__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (param1_00,uVar2,
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator___c__UpdateSquadInfo_b__16_2__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo + 0x5c) + 0x10
		            ) = param1_00;
		  }
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (iVar4,param1_00,
		                     Method_System_Linq_Enumerable_Where_SquadModel_ColossusPartySlot___);
		  local_4 = func_ii_6330(uVar2,Method_System_Linq_Enumerable_Count_SquadModel_ColossusPartySlot___);
		  local_8 = *(int *)(iVar4 + 0xc) - local_4;
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar4 + 0x30);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17812,1,0,1,0,0,0,0);
		  iVar4 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  uVar1 = func_ii_4443(&local_4,0);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_21978,uVar1,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar4 + 0x10) = local_10;
		  uVar5 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar5,iVar4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar5,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = *(undefined4 *)(iVar4 + 0x34);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17813,1,0,1,0,0,0,0);
		  iVar4 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  uVar5 = func_ii_4443(&local_8,0);
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_21978,uVar5,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar4 + 0x10) = local_18;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE9")]
		[Address(RVA = "0x8EA3", Offset = "0x8EA3", VA = "0x8EA3")]
		private void UpdateSquadInfo()
		{
		/* --- GHIDRA: UpdateSquadInfo ---
		void Gameplay_Clans_Office_Controller_SquadViewMediator__UpdateSquadInfo
		               (int *param1,undefined4 param2)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		            (param1,0,*(undefined4 *)(*param1 + 0x144));
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x160) * 4))
		            (param1,0,*(undefined4 *)(*param1 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x06003FEA RID: 16362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FEA")]
		[Address(RVA = "0x8EA4", Offset = "0x8EA4", VA = "0x8EA4", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		undefined4
		Gameplay_Clans_Office_Controller_SquadViewMediator__Hide
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 param3_00;
		  int iVar5;
		  int param1_01;
		  uint uVar6;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a576ce == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SquadModel__SquadEvents__SquadController__SquadView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator___c__DisplayClass18_0__ShowRentPartyDialogWindow_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Controller_SquadViewMediator___c__DisplayClass18_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4107);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26445);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17818);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17817);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17814);
		    DAT_ram_00a576ce = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Clans_Office_Controller_SquadViewMediator___c__DisplayClass18_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0xc) = param2;
		  *(int *)(iVar1 + 8) = param1;
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Explicit(param2,0);
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17818,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar3;
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17817,1,0,1,0,0,0,0);
		  iVar4 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  param3_00 = Core_Extensions_Dict_ResourceSetExt__ToNullableResourceSet
		                        (uVar2,NAN,0,StringLiteral_2556,0,0,0);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_26445,param3_00,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar4 + 0x10) = local_8;
		  uVar3 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar3,iVar4,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar3;
		  param1_01 = *(int *)(param1_00 + 0x24);
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar4,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17814,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 8) = uVar3;
		  iVar5 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  *(undefined4 *)(iVar5 + 8) = uVar2;
		  *(undefined4 *)(iVar5 + 0xc) = *(undefined4 *)(*(int *)(param1 + 8) + 0x1c);
		  *(int *)(iVar4 + 0x10) = iVar5;
		  iVar5 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar2,iVar1,
		             Method_Gameplay_Clans_Office_Controller_SquadViewMediator___c__DisplayClass18_0__ShowRentPartyDialogWindow_b__0__
		             ,0);
		  *(undefined4 *)(iVar5 + 8) = uVar2;
		  *(int *)(iVar4 + 0x14) = iVar5;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar6 = *(uint *)(param1_01 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar6 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar5 = *(int *)(param1_00 + 0x24);
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar4,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4107,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar5 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(iVar5 + 8) + uVar6 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar5,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_00,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x06003FEB RID: 16363 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003FEB")]
		[Address(RVA = "0x8EA5", Offset = "0x8EA5", VA = "0x8EA5")]
		private DialogWindow ShowRentPartyDialogWindow(ResourceSet price)
		{
		/* --- GHIDRA: ShowRentPartyDialogWindow ---
		undefined4
		Gameplay_Clans_Office_Controller_SquadViewMediator__ShowRentPartyDialogWindow
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 param3_00;
		  int iVar5;
		  int param1_01;
		  uint uVar6;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a576cf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SquadModel__SquadEvents__SquadController__SquadView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator___c__DisplayClass19_0__ShowBuyPartySlotDialogWindow_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Controller_SquadViewMediator___c__DisplayClass19_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17821);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4107);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26445);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17822);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17820);
		    DAT_ram_00a576cf = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Clans_Office_Controller_SquadViewMediator___c__DisplayClass19_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param3;
		  *(undefined4 *)(iVar1 + 0xc) = param2;
		  *(int *)(iVar1 + 8) = param1;
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Explicit(param3,0);
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17822,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar3;
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17821,1,0,1,0,0,0,0);
		  iVar4 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  param3_00 = Core_Extensions_Dict_ResourceSetExt__ToNullableResourceSet
		                        (uVar2,NAN,0,StringLiteral_2556,0,0,0);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_26445,param3_00,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar4 + 0x10) = local_8;
		  uVar3 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar3,iVar4,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar3;
		  param1_01 = *(int *)(param1_00 + 0x24);
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar4,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17820,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 8) = uVar3;
		  iVar5 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  *(undefined4 *)(iVar5 + 8) = uVar2;
		  *(undefined4 *)(iVar5 + 0xc) = *(undefined4 *)(*(int *)(param1 + 8) + 0x1c);
		  *(int *)(iVar4 + 0x10) = iVar5;
		  iVar5 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar2,iVar1,
		             Method_Gameplay_Clans_Office_Controller_SquadViewMediator___c__DisplayClass19_0__ShowBuyPartySlotDialogWindow_b__0__
		             ,0);
		  *(undefined4 *)(iVar5 + 8) = uVar2;
		  *(int *)(iVar4 + 0x14) = iVar5;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar6 = *(uint *)(param1_01 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar6 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar5 = *(int *)(param1_00 + 0x24);
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar4,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4107,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar5 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(iVar5 + 8) + uVar6 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar5,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_00,0);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06003FEC RID: 16364 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003FEC")]
		[Address(RVA = "0x8EA6", Offset = "0x8EA6", VA = "0x8EA6")]
		private DialogWindow ShowBuyPartySlotDialogWindow(uint partyId, ResourceSet price)
		{
		/* --- GHIDRA: ShowBuyPartySlotDialogWindow ---
		void Gameplay_Clans_Office_Controller_SquadViewMediator__ShowBuyPartySlotDialogWindow
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a576d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo);
		    DAT_ram_00a576d0 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Clans_Office_Controller_SquadViewMediator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return null;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Office_Controller_SquadViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  char cVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a576c2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SquadModel__SquadEvents__SquadController__SquadView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_SquadView_State__set_CurrentState__);
		    DAT_ram_00a576c2 = '\x01';
		  }
		  if (DAT_ram_00a576c8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SquadModel__SquadEvents__SquadController__SquadView__get_Model__
		              );
		    DAT_ram_00a576c8 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar2 + 0x3c);
		  uVar3 = Gameplay_WorldAxis_Model_WorldAxisModel__set_SeasonActive
		                    (*(undefined4 *)(param1[2] + 0x10),0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(iVar2 + 0x40),*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x1c),0);
		  cVar1 = *(char *)(*(int *)(param1[2] + 0x10) + 0x20);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (cVar1 == '\0') {
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (uVar3,2,Method_UI_MonoBehaviourWithStates_SquadView_State__set_CurrentState__);
		    return;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar3,1,Method_UI_MonoBehaviourWithStates_SquadView_State__set_CurrentState__);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_SquadController__HandleStop(uVar3,param1);
		  Gameplay_Clans_Office_Controller_SquadViewMediator__InitEventHandler(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Clans_Office_Controller_SquadViewMediator__set_Events
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a576c7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SquadModel__SquadEvents__SquadController__SquadView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_SquadModel_PartyData___);
		    Mono_Security_ASN1__get_Item(&System_Func_SquadModel_PartyData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_SquadViewMediator___c__DisplayClass10_0__UserLeftClanEventHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Controller_SquadViewMediator___c__DisplayClass10_0_TypeInfo);
		    DAT_ram_00a576c7 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Clans_Office_Controller_SquadViewMediator___c__DisplayClass10_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1[2] + 0x18);
		  uVar2 = unnamed_function_1417(System_Func_SquadModel_PartyData__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,
		             Method_Gameplay_Clans_Office_Controller_SquadViewMediator___c__DisplayClass10_0__UserLeftClanEventHandler_b__0__
		             ,0);
		  iVar1 = Newtonsoft_Json_Utilities_ReflectionUtils__IsOverridenGenericMember
		                    (param1_00,uVar2,Method_System_Linq_Enumerable_Any_SquadModel_PartyData___);
		  if (iVar1 != 0) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    Gameplay_Clans_Office_Controller_SquadController__HandleStop(uVar2,param1);
		  }
		  return;
		}
		*/

}
