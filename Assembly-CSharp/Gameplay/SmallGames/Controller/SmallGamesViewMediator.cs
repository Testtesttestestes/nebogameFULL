using System;
using System.Collections;
using Gameplay.SmallGames.Events;
using Gameplay.SmallGames.Model;
using Gameplay.SmallGames.View;
using Il2CppDummyDll;
using MVC;
using Protocol.SmallGames;
using UnityEngine;

namespace Gameplay.SmallGames.Controller
{
	// Token: 0x02000540 RID: 1344
	[Token(Token = "0x2000540")]
	public class SmallGamesViewMediator : AbstractViewMediator<SmallGamesModel, Gameplay.SmallGames.Events.SmallGamesEvents, SmallGamesController, SmallGamesWindow>
	{
		// Token: 0x0600202B RID: 8235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600202B")]
		[Address(RVA = "0x7190", Offset = "0x7190", VA = "0x7190")]
		public SmallGamesViewMediator(SmallGamesModel model, Gameplay.SmallGames.Events.SmallGamesEvents events, SmallGamesController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a582ef == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__SmallGamesWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_AttemptsCountChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_ChangedTabEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_SpinButtonClickEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_TakeButtonClickEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_WinningCombinationsButtonClickEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a582ef = '\x01';
		  }
		  if (param1[7] != 0) {
		    func_ii_7950(param1[7],0);
		    param1[7] = 0;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    func_ii_14558(*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x44) + 0x10) + 0xb4),0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x44);
		    uVar1 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar1,param1,
		                  Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_AttemptsCountChangedEventHandler__
		                  ,0);
		    Gameplay_SmallGames_View_SpinButtonView__add_AttemptsCountChangedEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x48) + 0x10) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_TakeButtonClickEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x54);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_ChangedTabEventHandler__
		               ,0);
		    UI_Tabs_TabBar__add_ChangeEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x58) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_WinningCombinationsButtonClickEventHandler__
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
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x44) + 0x10) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_SpinButtonClickEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x44);
		    uVar1 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar1,param1,
		                  Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_AttemptsCountChangedEventHandler__
		                  ,0);
		    Gameplay_SmallGames_View_SmallGamesWindow_SmallGamesWindowArgs___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x48) + 0x10) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_TakeButtonClickEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x54);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_ChangedTabEventHandler__
		               ,0);
		    UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x58) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_WinningCombinationsButtonClickEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    Gameplay_SmallGames_Controller_SmallGamesViewMediator__VisitRegisteredEventHandler
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x170005E2 RID: 1506
		// (set) Token: 0x0600202C RID: 8236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E2")]
		public override SmallGamesWindow View
		{
			[Token(Token = "0x600202C")]
			[Address(RVA = "0x7191", Offset = "0x7191", VA = "0x7191", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (set) Token: 0x0600202D RID: 8237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E3")]
		public override Gameplay.SmallGames.Events.SmallGamesEvents Events
		{
			[Token(Token = "0x600202D")]
			[Address(RVA = "0x7192", Offset = "0x7192", VA = "0x7192", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600202E")]
		[Address(RVA = "0x7193", Offset = "0x7193", VA = "0x7193")]
		private void TakeButtonClickEventHandler()
		{
		/* --- GHIDRA: TakeButtonClickEventHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator__TakeButtonClickEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a582f1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__SmallGamesWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_uint__ArtifactData___get_Count__);
		    DAT_ram_00a582f1 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Collections_Generic_Dictionary_int__object___get_Count
		            (*(undefined4 *)(*(int *)(iVar1 + 0x48) + 0x1c),
		             *(undefined4 *)(*(int *)(param1[2] + 0x18) + 0xc),0);
		  return;
		}
		*/

		}

		// Token: 0x0600202F RID: 8239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600202F")]
		[Address(RVA = "0x7194", Offset = "0x7194", VA = "0x7194")]
		private void HandleNotificationsCountChanged(int count)
		{
		/* --- GHIDRA: HandleNotificationsCountChanged ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator__HandleNotificationsCountChanged
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a582f2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__SmallGamesWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_SlotMachineType__Dictionary_uint__WinCombinationDic___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_WinningCombinationsWindow___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_SmallGames_View_WinningCombinationsWindow_WinningCombinationsWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_12669);
		    DAT_ram_00a582f2 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  param1_00 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_01 = unnamed_function_1417
		                        (
		                        Gameplay_SmallGames_View_WinningCombinationsWindow_WinningCombinationsWindowArgs_TypeInfo
		                        );
		  UI_Windows_BaseWindowArgs__Dispose(param1_01,0);
		  uVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 0x1c),
		                     *(undefined4 *)(*(int *)(param1 + 8) + 0x38),
		                     Method_System_Collections_Generic_Dictionary_SlotMachineType__Dictionary_uint__WinCombinationDic___get_Item__
		                    );
		  *(undefined4 *)(param1_01 + 0x18) = uVar1;
		  iVar2 = *(int *)(param1 + 8);
		  uVar1 = *(undefined4 *)(iVar2 + 0x38);
		  *(undefined4 *)(param1_01 + 0x1c) = uVar1;
		  if (DAT_ram_00a582ab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_SlotMachineType__SlotMachineDic__get_Item__
		              );
		    DAT_ram_00a582ab = '\x01';
		    uVar1 = *(undefined4 *)(iVar2 + 0x38);
		  }
		  uVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(iVar2 + 0x24),uVar1,
		                     Method_System_Collections_Generic_Dictionary_SlotMachineType__SlotMachineDic__get_Item__
		                    );
		  *(undefined4 *)(param1_01 + 0x20) = uVar1;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_00,StringLiteral_12669,param1_01,
		             Method_UI_Windows_PopupController_Show_WinningCombinationsWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06002030 RID: 8240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002030")]
		[Address(RVA = "0x7195", Offset = "0x7195", VA = "0x7195")]
		private void WinningCombinationsButtonClickEventHandler()
		{
		/* --- GHIDRA: WinningCombinationsButtonClickEventHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator__WinningCombinationsButtonClickEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  char cVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a582f3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__SmallGamesWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_uint__ArtifactData___get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_RewardsStorageWindow___);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SmallGames_View_RewardsStorageWindow_RewardsStorageWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13841);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12666);
		    DAT_ram_00a582f3 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Collections_Generic_Dictionary_int__object___get_Count
		            (*(undefined4 *)(*(int *)(iVar2 + 0x48) + 0x1c),
		             *(undefined4 *)(*(int *)(param1[2] + 0x18) + 0xc),0);
		  if ((char)param1[6] != '\0') {
		    *(undefined1 *)(param1 + 6) = 0;
		    cVar1 = *(char *)(*(int *)(*(int *)(param1[2] + 0x14) + 8) + 0x1c);
		    uVar3 = System_Uri___ctor(0);
		    if (cVar1 == '\0') {
		      uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13841,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar3,1,uVar4,0);
		    }
		    else {
		      uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar3,0);
		      iVar2 = unnamed_function_1417
		                        (
		                        Gameplay_SmallGames_View_RewardsStorageWindow_RewardsStorageWindowArgs_TypeInfo
		                        );
		      Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar2,0);
		      uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		      *(undefined4 *)(iVar2 + 0x18) = uVar4;
		      Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                (uVar3,StringLiteral_12666,iVar2,
		                 Method_UI_Windows_PopupController_Show_RewardsStorageWindow___);
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_SmallGames_View_SlotWheelsView__StopSpin(*(undefined4 *)(iVar2 + 0x60),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002031 RID: 8241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002031")]
		[Address(RVA = "0x7196", Offset = "0x7196", VA = "0x7196")]
		private void LastDropRequestedEventHandler()
		{
		/* --- GHIDRA: LastDropRequestedEventHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator__LastDropRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a582f4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__SmallGamesWindow__get_Model__
		              );
		    DAT_ram_00a582f4 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x54),0);
		  if (*(int *)(iVar1 + 0x14) != *(int *)(param1[2] + 0x38)) {
		    Gameplay_SmallGames_Controller_SmallGamesViewMediator__ChangedTabEventHandler
		              (param1,*(int *)(iVar1 + 0x14),param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002032 RID: 8242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002032")]
		[Address(RVA = "0x7197", Offset = "0x7197", VA = "0x7197")]
		private void ChangedTabEventHandler()
		{
		/* --- GHIDRA: ChangedTabEventHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator__ChangedTabEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a582f5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__SmallGamesWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a582f5 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar1 + 0x60);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_SmallGames_View_SlotWheelsView__StopSpin(*(undefined4 *)(iVar1 + 0x60),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar1 + 0x60),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,0,0);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = Gameplay_SmallGames_View_SmallGamesWindow__set_CurrentSlotWheelsView(uVar2,param2,0);
		  *(undefined4 *)(iVar1 + 0x60) = uVar2;
		  *(undefined4 *)(param1[2] + 0x38) = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_SmallGames_View_SlotWheelsView__OnDestroy(*(undefined4 *)(iVar1 + 0x60),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x60),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  Gameplay_SmallGames_Controller_SmallGamesViewMediator__SetupView(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002033 RID: 8243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002033")]
		[Address(RVA = "0x7198", Offset = "0x7198", VA = "0x7198")]
		private void SelectCurrentSlotWheels(SlotMachineType type)
		{
		/* --- GHIDRA: SelectCurrentSlotWheels ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator__SelectCurrentSlotWheels
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a582f6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__SmallGamesWindow__get_Model__
		              );
		    DAT_ram_00a582f6 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 8);
		  if (DAT_ram_00a582aa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_SlotMachineType__uint__set_Item__);
		    DAT_ram_00a582aa = '\x01';
		  }
		  System_Collections_Generic_Dictionary_Int32Enum__uint___get_Values
		            (*(undefined4 *)(iVar1 + 0x28),*(undefined4 *)(iVar1 + 0x38),param2,
		             Method_System_Collections_Generic_Dictionary_SlotMachineType__uint__set_Item__);
		  Gameplay_SmallGames_Controller_SmallGamesViewMediator__UpdateCasino(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002034 RID: 8244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002034")]
		[Address(RVA = "0x7199", Offset = "0x7199", VA = "0x7199")]
		private void AttemptsCountChangedEventHandler(uint attemptsCount)
		{
		/* --- GHIDRA: AttemptsCountChangedEventHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator__AttemptsCountChangedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_SmallGames_Controller_SmallGamesViewMediator__UpdateSpinButtonView(param1,param1);
		  Gameplay_SmallGames_Controller_SmallGamesViewMediator__UpdateCasino(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002035 RID: 8245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002035")]
		[Address(RVA = "0x719A", Offset = "0x719A", VA = "0x719A")]
		private void FreeAttemptsRequestedEventHandler()
		{
		/* --- GHIDRA: FreeAttemptsRequestedEventHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator__FreeAttemptsRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a582f7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__SmallGamesWindow__get_Model__
		              );
		    DAT_ram_00a582f7 = '\x01';
		  }
		  iVar2 = param1[2];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x24);
		  if (DAT_ram_00a582aa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_SlotMachineType__uint__set_Item__);
		    DAT_ram_00a582aa = '\x01';
		  }
		  System_Collections_Generic_Dictionary_Int32Enum__uint___get_Values
		            (*(undefined4 *)(iVar2 + 0x28),*(undefined4 *)(iVar2 + 0x38),uVar3,
		             Method_System_Collections_Generic_Dictionary_SlotMachineType__uint__set_Item__);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar1 = param1[2];
		  param2_00 = *(undefined4 *)(iVar1 + 0x38);
		  uVar3 = param2_00;
		  if (DAT_ram_00a582a9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_SlotMachineType__uint__get_Item__);
		    DAT_ram_00a582a9 = '\x01';
		    uVar3 = *(undefined4 *)(iVar1 + 0x38);
		  }
		  uVar3 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(iVar1 + 0x28),uVar3,
		                     Method_System_Collections_Generic_Dictionary_SlotMachineType__uint__get_Item__)
		  ;
		  Gameplay_SmallGames_Controller_SmallGamesController__GetJackpotInfoResultHandler
		            (param1_00,param2_00,uVar3,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x10),0,0);
		  return;
		}
		*/

		}

		// Token: 0x06002036 RID: 8246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002036")]
		[Address(RVA = "0x719B", Offset = "0x719B", VA = "0x719B")]
		private void SpinButtonClickEventHandler()
		{
		/* --- GHIDRA: SpinButtonClickEventHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator__SpinButtonClickEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  int iVar4;
		  
		  if (DAT_ram_00a582f8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__SmallGamesWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_SmallGames_View_SlotWheelsView_StopSpin__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_WheelsStoppedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_13847);
		    DAT_ram_00a582f8 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (param2 != 0) {
		    Gameplay_SmallGames_View_SlotWheelsView__Init
		              (*(undefined4 *)(iVar1 + 0x60),*(undefined4 *)(*(int *)(param1[2] + 0x3c) + 0x10),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar1 + 0x60);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_WheelsStoppedEventHandler__
		               ,0);
		    Gameplay_SmallGames_View_RewardsStorageWindow_RewardsStorageWindowArgs___ctor(uVar3,uVar2,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar1 + 0x60);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param2_00 = *(undefined4 *)(iVar1 + 0x60);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param2_00,Method_Gameplay_SmallGames_View_SlotWheelsView_StopSpin__,0);
		    Gameplay_SmallGames_View_SlotWheelsView__StartSpinning(uVar3,uVar2,StringLiteral_13847,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = param1[2];
		    uVar2 = 2;
		    if (*(int *)(iVar4 + 0x38) != 1) {
		      uVar2 = 4;
		    }
		    Gameplay_SmallGames_View_SmallGamesResourceRenderer__Init
		              (*(undefined4 *)(iVar1 + 0x40),*(undefined4 *)(iVar4 + 0x40),uVar2,
		               *(undefined4 *)(iVar4 + 0x10),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		  }
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x10),1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002037 RID: 8247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002037")]
		[Address(RVA = "0x719C", Offset = "0x719C", VA = "0x719C")]
		private void WheelResultReceivedEventHandler(bool success)
		{
		/* --- GHIDRA: WheelResultReceivedEventHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator__WheelResultReceivedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a582f9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__SmallGamesWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_SpinButtonClickEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_WheelsStoppedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_13844);
		    DAT_ram_00a582f9 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x60);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_WheelsStoppedEventHandler__
		             ,0);
		  Gameplay_SmallGames_View_SlotWheelsView__add_WheelsStoppedSpinningEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_SmallGames_View_RewardsDisplay__get_RedCounter
		            (*(undefined4 *)(iVar1 + 0x48),*(undefined4 *)(*(int *)(param1[2] + 0x3c) + 0x18),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x10),1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x60);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_SpinButtonClickEventHandler__
		             ,0);
		  Gameplay_SmallGames_View_SlotWheelsView__StartSpinning(uVar3,uVar2,StringLiteral_13844,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1[2] + 0x3c) + 0x18);
		  if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		  }
		  iVar1 = Core_Extensions_Dict_RewardInfoExt__ToRewardDataArray(uVar2,9,0);
		  if (iVar1 != 0) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    Gameplay_SmallGames_Controller_SmallGamesController___ctor(uVar2,param1);
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_SmallGames_Controller_SmallGamesController__GetFreeAttempts
		            (uVar2,*(undefined4 *)(param1[2] + 0x38),param1);
		  return;
		}
		*/

		}

		// Token: 0x06002038 RID: 8248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002038")]
		[Address(RVA = "0x719D", Offset = "0x719D", VA = "0x719D")]
		private void WheelsStoppedEventHandler()
		{
		/* --- GHIDRA: WheelsStoppedEventHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator__WheelsStoppedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a582fa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__SmallGamesWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_SlotMachineType__SmallGamesModel_JackpotInfo__TryGetValue__
		              );
		    DAT_ram_00a582fa = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(param1[2] + 0x20),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_SlotMachineType__SmallGamesModel_JackpotInfo__TryGetValue__
		                    );
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_SmallGames_View_JackpotInfoView___ctor
		              (*(undefined4 *)(iVar1 + 0x3c),param2,&local_4,*(undefined4 *)(param1[2] + 0x10),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002039 RID: 8249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002039")]
		[Address(RVA = "0x719E", Offset = "0x719E", VA = "0x719E")]
		private void LastJackpotRequestedEventHandler(SlotMachineType type)
		{
		/* --- GHIDRA: LastJackpotRequestedEventHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator__LastJackpotRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param3;
		  
		  if (DAT_ram_00a582fb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__SmallGamesWindow__get_Model__
		              );
		    DAT_ram_00a582fb = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = param1[2];
		  param3 = 2;
		  if (*(int *)(iVar2 + 0x38) != 1) {
		    param3 = 4;
		  }
		  Gameplay_SmallGames_View_SmallGamesResourceRenderer__Init
		            (*(undefined4 *)(iVar1 + 0x40),*(undefined4 *)(iVar2 + 0x40),param3,
		             *(undefined4 *)(iVar2 + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x0600203A RID: 8250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203A")]
		[Address(RVA = "0x719F", Offset = "0x719F", VA = "0x719F")]
		private void JackpotRequestedEventHandler()
		{
		/* --- GHIDRA: JackpotRequestedEventHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator__JackpotRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_SmallGames_Controller_SmallGamesController__GetFreeAttempts(uVar1,1,param1);
		  Gameplay_SmallGames_Controller_SmallGamesController__GetFreeAttempts(uVar1,2,param1);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_SmallGames_Controller_SmallGamesController__HandleRegisterVisit(uVar1,param1);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_SmallGames_Controller_SmallGamesController__GetLastJackpotInfoResultHandler(uVar1,param1)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x0600203B RID: 8251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203B")]
		[Address(RVA = "0x71A0", Offset = "0x71A0", VA = "0x71A0")]
		private void VisitRegisteredEventHandler()
		{
		/* --- GHIDRA: VisitRegisteredEventHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator__VisitRegisteredEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int param2_00;
		  uint uVar5;
		  
		  if (DAT_ram_00a582fc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__SmallGamesWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TabBarItemData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_TabBarItemData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_SmallGames_SlotMachineType___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_SmallGames_SlotMachineType_var);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13836);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13842);
		    DAT_ram_00a582fc = '\x01';
		  }
		  uVar2 = Protocol_SmallGames_SlotMachineType_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  iVar1 = 0;
		  uVar2 = func_ii_2734(uVar2,0);
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  iVar3 = System_Enum__GetUnderlyingType(uVar2,0);
		  uVar2 = Protocol_SmallGames_SlotMachineType___TypeInfo;
		  if ((iVar3 != 0) &&
		     (iVar1 = func_ii_1082(iVar3,Protocol_SmallGames_SlotMachineType___TypeInfo), iVar1 == 0)) {
		    System_Activator__CreateInstance(iVar3,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar3 = *(int *)(iVar1 + 0xc);
		  if (0 < iVar3) {
		    iVar4 = 0;
		    do {
		      param2_00 = *(int *)(iVar1 + iVar4 * 4 + 0x10);
		      if (param2_00 != 0) {
		        uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        uVar2 = Gameplay_SmallGames_View_SmallGamesWindow__set_CurrentSlotWheelsView
		                          (uVar2,param2_00,0);
		        uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (uVar2,0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar2,0,0);
		        iVar3 = *(int *)(iVar1 + 0xc);
		      }
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < iVar3);
		  }
		  iVar1 = unnamed_function_1417(System_Collections_Generic_List_TabBarItemData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar1,Method_System_Collections_Generic_List_TabBarItemData___ctor__);
		  iVar3 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  *(undefined4 *)(iVar3 + 0x14) = 1;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13836,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar3 + 0x10) = uVar2;
		  iVar4 = Method_System_Collections_Generic_List_TabBarItemData__Add__;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar1 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		    *(uint *)(iVar1 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar1 + 8) + uVar5 * 4 + 0x10) = iVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar1,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		  }
		  iVar4 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  *(undefined4 *)(iVar4 + 0x14) = 2;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13842,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 0x10) = uVar2;
		  iVar3 = Method_System_Collections_Generic_List_TabBarItemData__Add__;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar1 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		    *(uint *)(iVar1 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar1 + 8) + uVar5 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar1,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Tabs_TabBar__HandleSelected(*(undefined4 *)(iVar3 + 0x54),iVar1,0);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    iVar3 = 0;
		    do {
		      iVar4 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,iVar3,
		                         Method_System_Collections_Generic_List_TabBarItemData__get_Item__);
		      if (*(int *)(iVar4 + 0x14) == *(int *)(param1[2] + 0x38)) {
		        Gameplay_SmallGames_Controller_SmallGamesViewMediator__ChangedTabEventHandler
		                  (param1,*(int *)(iVar4 + 0x14),iVar1);
		        iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		                  (*(undefined4 *)(iVar1 + 0x54),iVar3,0,0);
		        break;
		      }
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < *(int *)(iVar1 + 0xc));
		  }
		  iVar1 = *param1;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(iVar1 + 0x14c));
		  Gameplay_SmallGames_Controller_SmallGamesController__SellAllDrop(uVar2,iVar1);
		  return;
		}
		*/

		}

		// Token: 0x0600203C RID: 8252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203C")]
		[Address(RVA = "0x71A1", Offset = "0x71A1", VA = "0x71A1")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator__SetupView(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param2_00;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a582fd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__SmallGamesWindow__get_Model__
		              );
		    DAT_ram_00a582fd = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_SmallGames_Controller_SmallGamesController__GetFreeAttempts
		            (uVar1,*(undefined4 *)(param1[2] + 0x38),param1);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_SmallGames_Controller_SmallGamesController__GetLastJackpotInfoResultHandler(uVar1,param1)
		  ;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = *(undefined4 *)(iVar2 + 0x44);
		  iVar3 = param1[2];
		  iVar4 = 0x2c;
		  iVar2 = *(int *)(iVar3 + 0x38);
		  if (iVar2 != 1) {
		    iVar4 = 0x30;
		  }
		  iVar4 = *(int *)(*(int *)(iVar3 + iVar4) + 0xc);
		  if (iVar4 == 0) {
		    if (DAT_ram_00a582a9 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_SlotMachineType__uint__get_Item__);
		      DAT_ram_00a582a9 = '\x01';
		      iVar2 = *(int *)(iVar3 + 0x38);
		    }
		    iVar4 = GAFInternal_Reader_GAFReader__OpenTag
		                      (*(undefined4 *)(iVar3 + 0x28),iVar2,
		                       Method_System_Collections_Generic_Dictionary_SlotMachineType__uint__get_Item__
		                      );
		  }
		  Gameplay_SmallGames_View_SpinButtonView__get_AttemptsCount(uVar1,iVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = *(undefined4 *)(iVar2 + 0x44);
		  iVar2 = param1[2];
		  if (DAT_ram_00a582ab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_SlotMachineType__SlotMachineDic__get_Item__
		              );
		    DAT_ram_00a582ab = '\x01';
		  }
		  param2_00 = GAFInternal_Reader_GAFReader__OpenTag
		                        (*(undefined4 *)(iVar2 + 0x24),*(undefined4 *)(iVar2 + 0x38),
		                         Method_System_Collections_Generic_Dictionary_SlotMachineType__SlotMachineDic__get_Item__
		                        );
		  Gameplay_SmallGames_View_SpinButtonView__OnDestroy(uVar1,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600203D RID: 8253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203D")]
		[Address(RVA = "0x71A2", Offset = "0x71A2", VA = "0x71A2")]
		private void UpdateCasino()
		{
		/* --- GHIDRA: UpdateCasino ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator__UpdateCasino
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  double param2_00;
		  int iVar6;
		  
		  if (DAT_ram_00a582fe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__SmallGamesWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a582fe = '\x01';
		  }
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar4 = *(undefined4 *)(iVar3 + 0x44);
		  iVar5 = param1[2];
		  iVar6 = 0x2c;
		  iVar3 = *(int *)(iVar5 + 0x38);
		  if (iVar3 != 1) {
		    iVar6 = 0x30;
		  }
		  iVar6 = *(int *)(*(int *)(iVar5 + iVar6) + 0xc);
		  if (iVar6 == 0) {
		    if (DAT_ram_00a582a9 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_SlotMachineType__uint__get_Item__);
		      DAT_ram_00a582a9 = '\x01';
		      iVar3 = *(int *)(iVar5 + 0x38);
		    }
		    iVar6 = GAFInternal_Reader_GAFReader__OpenTag
		                      (*(undefined4 *)(iVar5 + 0x28),iVar3,
		                       Method_System_Collections_Generic_Dictionary_SlotMachineType__uint__get_Item__
		                      );
		  }
		  Gameplay_SmallGames_View_SpinButtonView__get_AttemptsCount(uVar4,iVar6,0);
		  iVar3 = param1[2];
		  if (DAT_ram_00a582ab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_SlotMachineType__SlotMachineDic__get_Item__
		              );
		    DAT_ram_00a582ab = '\x01';
		  }
		  iVar3 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(iVar3 + 0x24),*(undefined4 *)(iVar3 + 0x38),
		                     Method_System_Collections_Generic_Dictionary_SlotMachineType__SlotMachineDic__get_Item__
		                    );
		  uVar4 = *(undefined4 *)(iVar3 + 0x18);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar4 = Core_Money_Money__op_Explicit(uVar4,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x15c)));
		  param2_00 = (double)*(uint *)(*(int *)(iVar3 + 0x44) + 0x24);
		  uVar4 = Core_Money_Money__op_Subtraction(uVar4,param2_00,0);
		  uVar1 = CONCAT44((int)((ulonglong)param2_00 >> 0x20),*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  UI_Price_Price__SetColor
		            (*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x44) + 0x10) + 0xb8),
		             *(undefined4 *)(param1[2] + 8),uVar4,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x15c)));
		  iVar5 = 0x2c;
		  if (*(int *)(param1[2] + 0x38) != 1) {
		    iVar5 = 0x30;
		  }
		  Gameplay_SmallGames_View_SpinButtonView__Init
		            (*(undefined4 *)(iVar3 + 0x44),(uint)(*(int *)(*(int *)(param1[2] + iVar5) + 0xc) != 0),
		             0);
		  return;
		}
		*/

		}

		// Token: 0x0600203E RID: 8254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203E")]
		[Address(RVA = "0x71A3", Offset = "0x71A3", VA = "0x71A3")]
		private void UpdateSpinButtonView()
		{
		/* --- GHIDRA: UpdateSpinButtonView ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator__UpdateSpinButtonView
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  float fVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined8 uVar6;
		  longlong lVar7;
		  longlong param3;
		  
		  if (DAT_ram_00a582ff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__SmallGamesWindow__get_Model__
		              );
		    DAT_ram_00a582ff = '\x01';
		  }
		  if (param1[7] != 0) {
		    func_ii_7950(param1[7],0);
		    param1[7] = 0;
		  }
		  iVar1 = 0x2c;
		  if (*(int *)(param1[2] + 0x38) != 1) {
		    iVar1 = 0x30;
		  }
		  iVar3 = *(int *)(*(int *)(param1[2] + iVar1) + 0x10);
		  uVar6 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar6);
		  uVar4 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar1 + 0x50),(uint)(iVar3 != 0),0);
		  if (iVar3 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x15c)));
		    uVar4 = *(undefined4 *)(iVar1 + 0x4c);
		    iVar1 = param1[2];
		    if (DAT_ram_00a582ab == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_Dictionary_SlotMachineType__SlotMachineDic__get_Item__
		                );
		      DAT_ram_00a582ab = '\x01';
		    }
		    iVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                      (*(undefined4 *)(iVar1 + 0x24),*(undefined4 *)(iVar1 + 0x38),
		                       Method_System_Collections_Generic_Dictionary_SlotMachineType__SlotMachineDic__get_Item__
		                      );
		    uVar6 = *(undefined8 *)(iVar1 + 0x20);
		    iVar1 = param1[2];
		    uVar5 = *(undefined4 *)(iVar1 + 0x38);
		    if (DAT_ram_00a582ac == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime__get_Item__
		                );
		      DAT_ram_00a582ac = '\x01';
		    }
		    uVar5 = GAFInternal_Reader_GAFReader__OpenTag
		                      (*(undefined4 *)(iVar1 + 0x34),uVar5,
		                       Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime__get_Item__
		                      );
		    fVar2 = func_ii_7103(uVar5,0);
		    if (fVar2 < 1.8446744e+19 && 0.0 <= fVar2) {
		      lVar7 = (longlong)fVar2;
		    }
		    else {
		      lVar7 = 0;
		    }
		    if (ABS(fVar2) < 9.223372e+18) {
		      param3 = (longlong)fVar2;
		    }
		    else {
		      param3 = -0x8000000000000000;
		    }
		    if (0.0 <= fVar2) {
		      param3 = lVar7;
		    }
		    UI_Elements_ProgressBars_ProgressBarWithTimer__TimerComplete(uVar4,uVar6,param3,0);
		    iVar1 = param1[2];
		    uVar4 = *(undefined4 *)(iVar1 + 0x38);
		    if (DAT_ram_00a582ac == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime__get_Item__
		                );
		      DAT_ram_00a582ac = '\x01';
		    }
		    uVar4 = GAFInternal_Reader_GAFReader__OpenTag
		                      (*(undefined4 *)(iVar1 + 0x34),uVar4,
		                       Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime__get_Item__
		                      );
		    fVar2 = func_ii_7103(uVar4,0);
		    if (0.0 < fVar2) {
		      iVar1 = param1[2];
		      uVar4 = *(undefined4 *)(iVar1 + 0x38);
		      if (DAT_ram_00a582ac == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime__get_Item__
		                  );
		        DAT_ram_00a582ac = '\x01';
		      }
		      uVar4 = GAFInternal_Reader_GAFReader__OpenTag
		                        (*(undefined4 *)(iVar1 + 0x34),uVar4,
		                         Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime__get_Item__
		                        );
		      fVar2 = func_ii_7103(uVar4,0);
		      if (DAT_ram_00a58300 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Gameplay_SmallGames_Controller_SmallGamesViewMediator__NextFreeSpinRoutine_d__30_TypeInfo
		                  );
		        DAT_ram_00a58300 = '\x01';
		      }
		      iVar1 = unnamed_function_1417
		                        (
		                        Gameplay_SmallGames_Controller_SmallGamesViewMediator__NextFreeSpinRoutine_d__30_TypeInfo
		                        );
		      *(int **)(iVar1 + 0x14) = param1;
		      *(undefined4 *)(iVar1 + 8) = 0;
		      *(float *)(iVar1 + 0x10) = fVar2;
		      iVar1 = Utils_CoroutineSource__GetMono(iVar1,0);
		      param1[7] = iVar1;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600203F RID: 8255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203F")]
		[Address(RVA = "0x71A4", Offset = "0x71A4", VA = "0x71A4")]
		private void UpdateTimer()
		{
		/* --- GHIDRA: UpdateTimer ---
		int Gameplay_SmallGames_Controller_SmallGamesViewMediator__UpdateTimer
		              (undefined4 param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58300 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_SmallGames_Controller_SmallGamesViewMediator__NextFreeSpinRoutine_d__30_TypeInfo
		              );
		    DAT_ram_00a58300 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_SmallGames_Controller_SmallGamesViewMediator__NextFreeSpinRoutine_d__30_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(float *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06002040 RID: 8256 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002040")]
		[Address(RVA = "0x71A5", Offset = "0x71A5", VA = "0x71A5")]
		private IEnumerator NextFreeSpinRoutine(float backtime)
		{
		/* --- GHIDRA: NextFreeSpinRoutine ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator__NextFreeSpinRoutine
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58301 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__SmallGamesWindow__Dispose__
		              );
		    DAT_ram_00a58301 = '\x01';
		  }
		  if (*(int *)(param1 + 0x1c) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x1c),0);
		    *(undefined4 *)(param1 + 0x1c) = 0;
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__SmallGamesWindow__Dispose__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002041")]
		[Address(RVA = "0x71A6", Offset = "0x71A6", VA = "0x71A6", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x0400119B RID: 4507
		[Token(Token = "0x400119B")]
		private const string LOCALIZATION_SPIN = "SMALL_GAMES/SPIN";

		// Token: 0x0400119C RID: 4508
		[Token(Token = "0x400119C")]
		private const string LOCALIZATION_STOP = "SMALL_GAMES/STOP";

		// Token: 0x0400119D RID: 4509
		[Token(Token = "0x400119D")]
		private const string LOCALIZATION_DIAMONDS = "SMALL_GAMES/DIAMONDS";

		// Token: 0x0400119E RID: 4510
		[Token(Token = "0x400119E")]
		private const string LOCALIZATION_ONYXES = "SMALL_GAMES/ONYXES";

		// Token: 0x0400119F RID: 4511
		[Token(Token = "0x400119F")]
		private const string LOCALIZATION_NO_ITEMS = "SMALL_GAMES/NO_ITEMS";

		// Token: 0x040011A0 RID: 4512
		[Token(Token = "0x40011A0")]
		[FieldOffset(Offset = "0x18")]
		private bool _takeButtonClicked;

		// Token: 0x040011A1 RID: 4513
		[Token(Token = "0x40011A1")]
		[FieldOffset(Offset = "0x1C")]
		private Coroutine _nextFreeSpinRoutine;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a582f0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__SmallGamesWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_SlotMachineType__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_FreeAttemptsRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_HandleNotificationsCountChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_JackpotRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_LastDropRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_LastJackpotRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_VisitRegisteredEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_WheelResultReceivedEventHandler__
		              );
		    DAT_ram_00a582f0 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_VisitRegisteredEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_JackpotRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_SlotMachineType__TypeInfo);
		    System_Action_int___Invoke
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_LastJackpotRequestedEventHandler__
		               ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_SlotMachineType__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_SlotMachineType__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar5;
		      uVar3 = System_Action_SlotMachineType__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_SlotMachineType__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_bool__TypeInfo);
		    System_Action_AsyncGPUReadbackRequest___Invoke
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_WheelResultReceivedEventHandler__
		               ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_bool__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_bool__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar5;
		      uVar3 = System_Action_bool__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_bool__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_FreeAttemptsRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x24) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x28);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_LastDropRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x28) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x28) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x34);
		    uVar3 = unnamed_function_1417(System_Action_int__TypeInfo);
		    System_Action_short___Invoke
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_HandleNotificationsCountChanged__
		               ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_int__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x34) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_int__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x34) = iVar5;
		      uVar3 = System_Action_int__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_int__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_VisitRegisteredEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_JackpotRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_SlotMachineType__TypeInfo);
		    System_Action_int___Invoke
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_LastJackpotRequestedEventHandler__
		               ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_SlotMachineType__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_SlotMachineType__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar5;
		      uVar3 = System_Action_SlotMachineType__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_SlotMachineType__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_bool__TypeInfo);
		    System_Action_AsyncGPUReadbackRequest___Invoke
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_WheelResultReceivedEventHandler__
		               ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_bool__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_bool__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar5;
		      uVar3 = System_Action_bool__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_bool__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_FreeAttemptsRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x24) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x28);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_LastDropRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x28) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x28) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x34);
		    uVar3 = unnamed_function_1417(System_Action_int__TypeInfo);
		    System_Action_short___Invoke
		              (uVar3,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesViewMediator_HandleNotificationsCountChanged__
		               ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_int__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x34) = 0;
		      return;
		    }
		    iVar5 = func_ii_1082(iVar2,System_Action_int__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x34) = iVar5;
		    uVar3 = System_Action_int__TypeInfo;
		    iVar1 = func_ii_1082(iVar2,System_Action_int__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_SmallGames_Controller_SmallGamesViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  *(undefined1 *)(param1 + 6) = 1;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_SmallGames_Controller_SmallGamesController___ctor(param1_00,param1);
		  return;
		}
		*/

}
