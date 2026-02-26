using System;
using Gameplay.EndlessPaymentOptionsList.Model;
using Gameplay.EndlessPaymentOptionsList.View;
using Il2CppDummyDll;
using MVC;
using UnityEngine.EventSystems;

namespace Gameplay.EndlessPaymentOptionsList.Control
{
	// Token: 0x02000852 RID: 2130
	[Token(Token = "0x2000852")]
	public class EndlessPaymentOptionsListWindowMediator : AbstractViewMediator<EndlessPaymentOptionsListModel, EndlessPaymentOptionsListEvents, EndlessPaymentOptionsListController, EndlessPaymentOptionsListWindow>
	{
		// Token: 0x0600321D RID: 12829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600321D")]
		[Address(RVA = "0x8273", Offset = "0x8273", VA = "0x8273")]
		public EndlessPaymentOptionsListWindowMediator(EndlessPaymentOptionsListModel model, EndlessPaymentOptionsListEvents events, EndlessPaymentOptionsListController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57bb7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__EndlessPaymentOptionsListController__EndlessPaymentOptionsListWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_CardData__CardData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator_HandleBuySuccessEvent__
		              );
		    DAT_ram_00a57bb7 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x24);
		    iVar1 = 0;
		    uVar3 = unnamed_function_1417(System_Action_CardData__CardData__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator_HandleBuySuccessEvent__
		               ,0);
		    iVar4 = func_ii_7048(uVar5,uVar3,0);
		    uVar3 = System_Action_CardData__CardData__TypeInfo;
		    if ((iVar4 != 0) &&
		       (iVar1 = func_ii_1082(iVar4,System_Action_CardData__CardData__TypeInfo), iVar1 == 0)) {
		      System_Activator__CreateInstance(iVar4,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar2 + 0x24) = iVar1;
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x24);
		    iVar1 = 0;
		    uVar3 = unnamed_function_1417(System_Action_CardData__CardData__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator_HandleBuySuccessEvent__
		               ,0);
		    iVar4 = UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    uVar3 = System_Action_CardData__CardData__TypeInfo;
		    if ((iVar4 != 0) &&
		       (iVar1 = func_ii_1082(iVar4,System_Action_CardData__CardData__TypeInfo), iVar1 == 0)) {
		      System_Activator__CreateInstance(iVar4,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar2 + 0x24) = iVar1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x170009E1 RID: 2529
		// (set) Token: 0x0600321E RID: 12830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E1")]
		public override EndlessPaymentOptionsListEvents Events
		{
			[Token(Token = "0x600321E")]
			[Address(RVA = "0x8274", Offset = "0x8274", VA = "0x8274", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (set) Token: 0x0600321F RID: 12831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E2")]
		public override EndlessPaymentOptionsListWindow View
		{
			[Token(Token = "0x600321F")]
			[Address(RVA = "0x8275", Offset = "0x8275", VA = "0x8275", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003220")]
		[Address(RVA = "0x8276", Offset = "0x8276", VA = "0x8276")]
		private void HandleBuySuccessEvent(CardData removeData, CardData addData)
		{
		/* --- GHIDRA: HandleBuySuccessEvent ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator__HandleBuySuccessEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57bb9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator_HandleOptionClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator_HandleWindowCloseEvent__
		              );
		    DAT_ram_00a57bb9 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__get_IsFullscreenWindow
		                    (uVar1,0);
		  uVar2 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator_HandleOptionClickEvent__
		             ,0);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(uVar1,uVar2,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  func_ii_14558(*(undefined4 *)(*(int *)(iVar3 + 0x60) + 0xb4),0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator_HandleWindowCloseEvent__
		             ,0);
		  UI_Windows_BaseWindow__add_onClose(uVar1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003221 RID: 12833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003221")]
		[Address(RVA = "0x8277", Offset = "0x8277", VA = "0x8277")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57bba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__EndlessPaymentOptionsListController__EndlessPaymentOptionsListWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_EndlessPaymentOptionsListWindow_EndlessPaymentOptionsListWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator_HandleOptionClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator_HandleWindowCloseEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator_ShowDiscountsForDBG__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_EndlessPaymentOptionListTitleLayoutView_States__set_CurrentState__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57bba = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = 2;
		  if (*(char *)(param1[2] + 0x2c) == '\0') {
		    uVar3 = 1;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x5c),uVar3,
		             Method_UI_MonoBehaviourWithStates_EndlessPaymentOptionListTitleLayoutView_States__set_CurrentState__
		            );
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(uVar2,
		                       Method_UI_Windows_BaseWindow_EndlessPaymentOptionsListWindow_EndlessPaymentOptionsListWindowArgs__get_WindowArgs__
		                      );
		  uVar2 = Core_Extensions_Dict_EffectDictExt__GetDescription
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x1c) + 8),0);
		  Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__PlayBuyAndShift
		            (uVar3,uVar2,0);
		  if (DAT_ram_00a57bbd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__EndlessPaymentOptionsListController__EndlessPaymentOptionsListWindow__get_Model__
		              );
		    DAT_ram_00a57bbd = '\x01';
		  }
		  uVar3 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__GetCards
		                    (param1[2],0);
		  uVar2 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__ReLink
		                    (param1[2],0);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__OnShow
		            (param1_00,uVar3,uVar2,0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__get_IsFullscreenWindow
		                    (uVar3,0);
		  uVar2 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator_HandleOptionClickEvent__
		             ,0);
		  Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x60),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,(uint)(*(char *)(param1[2] + 0x2c) == '\0'),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x60) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator_ShowDiscountsForDBG__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar3,0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator_HandleWindowCloseEvent__
		             ,0);
		  UI_Windows_BaseWindow__get_IsActiveResourceBar(uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003222 RID: 12834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003222")]
		[Address(RVA = "0x8278", Offset = "0x8278", VA = "0x8278")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator__SetupView
		               (int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57bbb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__EndlessPaymentOptionsListController__EndlessPaymentOptionsListWindow__get_Model__
		              );
		    DAT_ram_00a57bbb = '\x01';
		  }
		  if (*(char *)(param1[2] + 0x2c) != '\0') {
		    piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x14c));
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                      (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		    Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__get_IsDiscountEnabled
		              (uVar2,0,0);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                      (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		    System_Runtime_Serialization_Formatters_Binary_ReadObjectInfo__ObjectEnd(uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003223 RID: 12835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003223")]
		[Address(RVA = "0x8279", Offset = "0x8279", VA = "0x8279")]
		private void HandleWindowCloseEvent()
		{
		/* --- GHIDRA: HandleWindowCloseEvent ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator__HandleWindowCloseEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param3;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 param1_00;
		  int *piVar6;
		  int local_4;
		  
		  if (DAT_ram_00a57bbc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow_EndlessPaymentOptionsListWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_EndlessPaymentOptionsListWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12615);
		    DAT_ram_00a57bbc = '\x01';
		  }
		  local_4 = 0;
		  param3 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(uVar2,2,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param3 + 0x100) * 4))
		                    (param3,*(undefined4 *)(*param3 + 0x104));
		  iVar3 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__GetCardForDisplay
		                    (uVar2,&local_4,0);
		  iVar4 = local_4;
		  if (iVar3 != 0) {
		    uVar1 = 0;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param3 + 0x100) * 4))
		                      (param3,*(undefined4 *)(*param3 + 0x104));
		    Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__get_IsDiscountEnabled
		              (uVar2,(uint)*(byte *)(*(int *)(iVar4 + 8) + 0x24),0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param3 + 0x100) * 4))
		                      (param3,*(undefined4 *)(*param3 + 0x104));
		    piVar6 = *(int **)(iVar4 + 0x10);
		    iVar4 = *piVar6;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		          goto code_r0x80e312ae;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80e312ae:
		    piVar6 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		    uVar1 = 0;
		    iVar4 = *piVar6;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		          goto code_r0x80e31330;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,5);
		code_r0x80e31330:
		    uVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		    iVar4 = local_4;
		    param1_00 = unnamed_function_1417
		                          (
		                          Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow_EndlessPaymentOptionsListWindowArgs_TypeInfo
		                          );
		    Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow___ctor
		              (param1_00,iVar4,param3,0xb,0);
		    Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		              (uVar2,StringLiteral_12615,param1_00,
		               Method_UI_Windows_PopupController_Show_EndlessPaymentOptionsListWindow___);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003224 RID: 12836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003224")]
		[Address(RVA = "0x827A", Offset = "0x827A", VA = "0x827A")]
		private void ShowDiscountsForDBG()
		{
		/* --- GHIDRA: ShowDiscountsForDBG ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator__ShowDiscountsForDBG
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 param3;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57bbd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__EndlessPaymentOptionsListController__EndlessPaymentOptionsListWindow__get_Model__
		              );
		    DAT_ram_00a57bbd = '\x01';
		  }
		  param2_00 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__GetCards
		                        (param1[2],0);
		  param3 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__ReLink
		                     (param1[2],0);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__OnShow
		            (param1_00,param2_00,param3,0);
		  return;
		}
		*/

		}

		// Token: 0x06003225 RID: 12837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003225")]
		[Address(RVA = "0x827B", Offset = "0x827B", VA = "0x827B")]
		private void DisplayItems()
		{
		/* --- GHIDRA: DisplayItems ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator__DisplayItems
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  int *local_4;
		  
		  if (DAT_ram_00a57bbe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_GameObject_TryGetComponent_EndlessPaymentOptionView___);
		    DAT_ram_00a57bbe = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar1 = func_ii_8014(*(undefined4 *)(param2 + 0x1c),&local_4,
		                       Method_UnityEngine_GameObject_TryGetComponent_EndlessPaymentOptionView___);
		  if (iVar1 != 0) {
		    piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x14c));
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*local_4 + 0x130) * 4))
		                      (local_4,*(undefined4 *)(*local_4 + 0x134));
		    if ((*(char *)(iVar1 + 0x20) == '\0') && (*(int *)(*(int *)(iVar1 + 0xc) + 8) == 0)) {
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                        (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		      Gameplay_Bank_Controller_BankController__RequestActivePromotions
		                (*(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x24),*(undefined4 *)(iVar1 + 0x10),0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003226 RID: 12838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003226")]
		[Address(RVA = "0x827C", Offset = "0x827C", VA = "0x827C")]
		private void HandleOptionClickEvent(PointerEventData data)
		{
		/* --- GHIDRA: HandleOptionClickEvent ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator__HandleOptionClickEvent
		               (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (param3 == 0) {
		    Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__PlayBuyAndShiftRoutine
		              (param1_00,param2,0);
		    return;
		  }
		  Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__PlayBuy
		            (param1_00,param2,param3,0);
		  return;
		}
		*/

		}

		// Token: 0x06003227 RID: 12839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003227")]
		[Address(RVA = "0x827D", Offset = "0x827D", VA = "0x827D")]
		private void HandleProcessPurchased(CardData removeData, CardData addData)
		{
		/* --- GHIDRA: HandleProcessPurchased ---
		uint Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator__HandleProcessPurchased
		               (int param1,undefined4 param2)
		
		{
		  float fVar1;
		  uint uVar2;
		  
		  if (DAT_ram_00a57bbf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_CombatModel__CombatEvents__DuelCombatController__DuelCombatViewMediator__OneOnOneCombatView__get_AwaitBackTime__
		              );
		    DAT_ram_00a57bbf = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    fVar1 = func_ii_7103(*(int *)(param1 + 0x14),0);
		    uVar2 = (uint)(0.0 < fVar1);
		  }
		  return uVar2;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57bb8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__EndlessPaymentOptionsListController__EndlessPaymentOptionsListWindow__set_View__
		              );
		    DAT_ram_00a57bb8 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator__HandleBuySuccessEvent
		              (param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator__ResetView
		              (param1,param1);
		  }
		  return;
		}
		*/

}
