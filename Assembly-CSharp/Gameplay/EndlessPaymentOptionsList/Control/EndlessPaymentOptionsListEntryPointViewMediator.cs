using System;
using Gameplay.EndlessPaymentOptionsList.Model;
using Gameplay.EndlessPaymentOptionsList.View;
using Il2CppDummyDll;
using MVC;
using UI;

namespace Gameplay.EndlessPaymentOptionsList.Control
{
	// Token: 0x02000851 RID: 2129
	[Token(Token = "0x2000851")]
	public class EndlessPaymentOptionsListEntryPointViewMediator : AbstractViewMediator<EndlessPaymentOptionsListModel, EndlessPaymentOptionsListEvents, EndlessPaymentOptionsListController, EndlessPaymentOptionsListEntryPointView>
	{
		// Token: 0x06003212 RID: 12818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003212")]
		[Address(RVA = "0x8268", Offset = "0x8268", VA = "0x8268")]
		public EndlessPaymentOptionsListEntryPointViewMediator(EndlessPaymentOptionsListModel model, EndlessPaymentOptionsListEvents events, EndlessPaymentOptionsListController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57baf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__EndlessPaymentOptionsListController__EndlessPaymentOptionsListEntryPointView__set_View__
		              );
		    DAT_ram_00a57baf = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator__SetupView
		              (param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator__HandleOptionsListTimeOutEvent
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x170009DF RID: 2527
		// (set) Token: 0x06003213 RID: 12819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009DF")]
		public override EndlessPaymentOptionsListEntryPointView View
		{
			[Token(Token = "0x6003213")]
			[Address(RVA = "0x8269", Offset = "0x8269", VA = "0x8269", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (set) Token: 0x06003214 RID: 12820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E0")]
		public override EndlessPaymentOptionsListEvents Events
		{
			[Token(Token = "0x6003214")]
			[Address(RVA = "0x826A", Offset = "0x826A", VA = "0x826A", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003215")]
		[Address(RVA = "0x826B", Offset = "0x826B", VA = "0x826B")]
		private void HandleOptionsRequestedEvent()
		{
		/* --- GHIDRA: HandleOptionsRequestedEvent ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator__HandleOptionsRequestedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator__ResetView
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003216 RID: 12822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003216")]
		[Address(RVA = "0x826C", Offset = "0x826C", VA = "0x826C")]
		private void HandleBuySuccessEvent(CardData a, CardData b)
		{
		/* --- GHIDRA: HandleBuySuccessEvent ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator__HandleBuySuccessEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator__ResetView
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003217 RID: 12823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003217")]
		[Address(RVA = "0x826D", Offset = "0x826D", VA = "0x826D")]
		private void HandleOptionsListTimeOutEvent()
		{
		/* --- GHIDRA: HandleOptionsListTimeOutEvent ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator__HandleOptionsListTimeOutEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57bb2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__EndlessPaymentOptionsListController__EndlessPaymentOptionsListEntryPointView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator_HandleClickEvent__
		              );
		    DAT_ram_00a57bb2 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListDiscountWindow_EndlessPaymentOptionsListDiscountWindowArgs___ctor
		                    (uVar1,0);
		  param1_00 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator_HandleClickEvent__
		             ,0);
		  UI_IndexButtonBasic__get_CanvasGroup(uVar1,param1_00,0);
		  iVar2 = Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator__ResetView
		                    (param1,param1);
		  if (iVar2 != 0) {
		    iVar2 = param1[2];
		    iVar4 = *(int *)(iVar2 + 0x38) + 1;
		    *(int *)(iVar2 + 0x38) = iVar4;
		    iVar3 = *(int *)(iVar2 + 0x18);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x14),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,(uint)(iVar4 % iVar3 == 0),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003218 RID: 12824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003218")]
		[Address(RVA = "0x826E", Offset = "0x826E", VA = "0x826E")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator__SetupView
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57bb3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator_HandleClickEvent__
		              );
		    DAT_ram_00a57bb3 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListDiscountWindow_EndlessPaymentOptionsListDiscountWindowArgs___ctor
		                    (uVar1,0);
		  param1_00 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator_HandleClickEvent__
		             ,0);
		  UI_IndexButtonBasic__add_ClickEvent(uVar1,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003219 RID: 12825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003219")]
		[Address(RVA = "0x826F", Offset = "0x826F", VA = "0x826F")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		undefined4
		Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator__ResetView
		          (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  float fVar2;
		  undefined4 uVar3;
		  int local_4;
		  
		  if (DAT_ram_00a57bb4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__EndlessPaymentOptionsListController__EndlessPaymentOptionsListEntryPointView__get_Model__
		              );
		    DAT_ram_00a57bb4 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__get_LastList
		                    (param1[2],0);
		  if (iVar1 != 0) {
		    Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__GetCardForDisplay
		              (param1[2],&local_4,0);
		    fVar2 = func_ii_7103(*(undefined4 *)(local_4 + 0xc),0);
		    if (0.0 < fVar2) {
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (uVar3,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,1,0);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      UI_Elements_RightPanel_TitleWithLevel__set_Level
		                (*(undefined4 *)(iVar1 + 0x10),*(undefined4 *)(local_4 + 0xc),0);
		      return 1;
		    }
		  }
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar3,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,0,0);
		  return 0;
		}
		*/

		}

		// Token: 0x0600321A RID: 12826 RVA: 0x0000A3E0 File Offset: 0x000085E0
		[Token(Token = "0x600321A")]
		[Address(RVA = "0x8270", Offset = "0x8270", VA = "0x8270")]
		private bool TryShowEntryPoint()
		{
		/* --- GHIDRA: TryShowEntryPoint ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator__TryShowEntryPoint
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  param1_01 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                               (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1_01 + 0x100) * 4))
		                    (param1_01,*(undefined4 *)(*param1_01 + 0x104));
		  *(undefined1 *)(iVar1 + 0x34) = 1;
		  Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__ValidateInit
		            (param1_01,param1_01);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600321B RID: 12827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600321B")]
		[Address(RVA = "0x8271", Offset = "0x8271", VA = "0x8271")]
		private void HandleClickEvent(IndexButtonBasic obj)
		{
		/* --- GHIDRA: HandleClickEvent ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator__HandleClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  undefined4 param3;
		  undefined4 param1_01;
		  int *piVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57bb5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__EndlessPaymentOptionsListController__EndlessPaymentOptionsListEntryPointView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow_EndlessPaymentOptionsListWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_EndlessPaymentOptionsListWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12615);
		    DAT_ram_00a57bb5 = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__GetCardForDisplay
		                    (param1[2],&local_4,0);
		  if (iVar2 != 0) {
		    uVar1 = 0;
		    piVar4 = *(int **)(param1[2] + 0x10);
		    iVar2 = *piVar4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		          goto code_r0x80e309c4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80e309c4:
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    uVar1 = 0;
		    iVar2 = *piVar4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe8);
		          goto code_r0x80e30a46;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,5);
		code_r0x80e30a46:
		    param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    param2_00 = local_4;
		    param3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x14c));
		    param1_01 = unnamed_function_1417
		                          (
		                          Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow_EndlessPaymentOptionsListWindowArgs_TypeInfo
		                          );
		    Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow___ctor
		              (param1_01,param2_00,param3,0,0);
		    Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		              (param1_00,StringLiteral_12615,param1_01,
		               Method_UI_Windows_PopupController_Show_EndlessPaymentOptionsListWindow___);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600321C RID: 12828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600321C")]
		[Address(RVA = "0x8272", Offset = "0x8272", VA = "0x8272")]
		private void ShowListWindow()
		{
		/* --- GHIDRA: ShowListWindow ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator__ShowListWindow
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a57bb6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__EndlessPaymentOptionsListController__EndlessPaymentOptionsListWindow___ctor__
		              );
		    DAT_ram_00a57bb6 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__EndlessPaymentOptionsListController__EndlessPaymentOptionsListWindow___ctor__
		            );
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a57bb0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__EndlessPaymentOptionsListController__EndlessPaymentOptionsListEntryPointView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_CardData__CardData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator_HandleBuySuccessEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator_HandleOptionsListTimeOutEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator_HandleOptionsRequestedEvent__
		              );
		    DAT_ram_00a57bb0 = '\x01';
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
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator_HandleOptionsRequestedEvent__
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
		    uVar6 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator_HandleOptionsListTimeOutEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x24);
		    iVar1 = 0;
		    uVar3 = unnamed_function_1417(System_Action_CardData__CardData__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator_HandleBuySuccessEvent__
		               ,0);
		    iVar5 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_CardData__CardData__TypeInfo;
		    if ((iVar5 != 0) &&
		       (iVar1 = func_ii_1082(iVar5,System_Action_CardData__CardData__TypeInfo), iVar1 == 0)) {
		      System_Activator__CreateInstance(iVar5,uVar3);
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
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator_HandleOptionsRequestedEvent__
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
		    uVar6 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator_HandleOptionsListTimeOutEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x24);
		    iVar1 = 0;
		    uVar3 = unnamed_function_1417(System_Action_CardData__CardData__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator_HandleBuySuccessEvent__
		               ,0);
		    iVar5 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_CardData__CardData__TypeInfo;
		    if ((iVar5 != 0) &&
		       (iVar1 = func_ii_1082(iVar5,System_Action_CardData__CardData__TypeInfo), iVar1 == 0)) {
		      System_Activator__CreateInstance(iVar5,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar2 + 0x24) = iVar1;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator__set_Events
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57bb1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__EndlessPaymentOptionsListController__EndlessPaymentOptionsListEntryPointView__get_Model__
		              );
		    DAT_ram_00a57bb1 = '\x01';
		  }
		  if (*(char *)(*(int *)(param1 + 8) + 0x34) != '\0') {
		    *(undefined1 *)(*(int *)(param1 + 8) + 0x34) = 0;
		    Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator__HandleClickEvent
		              (param1,param1);
		  }
		  Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator__ResetView
		            (param1,param1);
		  return;
		}
		*/

}
