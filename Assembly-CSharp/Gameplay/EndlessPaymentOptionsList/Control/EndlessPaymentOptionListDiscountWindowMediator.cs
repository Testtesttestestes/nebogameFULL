using System;
using Gameplay.EndlessPaymentOptionsList.Model;
using Gameplay.EndlessPaymentOptionsList.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.EndlessPaymentOptionsList.Control
{
	// Token: 0x0200084F RID: 2127
	[Token(Token = "0x200084F")]
	public class EndlessPaymentOptionListDiscountWindowMediator : AbstractViewMediator<EndlessPaymentOptionsListModel, EndlessPaymentOptionsListEvents, EndlessPaymentOptionsListController, EndlessPaymentOptionsListDiscountWindow>
	{
		// Token: 0x060031F6 RID: 12790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F6")]
		[Address(RVA = "0x824C", Offset = "0x824C", VA = "0x824C")]
		public EndlessPaymentOptionListDiscountWindowMediator(EndlessPaymentOptionsListModel model, EndlessPaymentOptionsListEvents events, EndlessPaymentOptionsListController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionListDiscountWindowMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57656 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__EndlessPaymentOptionsListController__EndlessPaymentOptionsListDiscountWindow__set_View__
		              );
		    DAT_ram_00a57656 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a57657 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionListDiscountWindowMediator_HandleConfirmButtonClickEvent__
		                );
		      Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		      DAT_ram_00a57657 = '\x01';
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(*(int *)(iVar2 + 0x48) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionListDiscountWindowMediator_HandleConfirmButtonClickEvent__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(param1_00,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionListDiscountWindowMediator__ResetView
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x170009DE RID: 2526
		// (set) Token: 0x060031F7 RID: 12791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009DE")]
		public override EndlessPaymentOptionsListDiscountWindow View
		{
			[Token(Token = "0x60031F7")]
			[Address(RVA = "0x824D", Offset = "0x824D", VA = "0x824D", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F8")]
		[Address(RVA = "0x824E", Offset = "0x824E", VA = "0x824E")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionListDiscountWindowMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a57658 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_EndlessPaymentOptionsListDiscountWindow_EndlessPaymentOptionsListDiscountWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionListDiscountWindowMediator_HandleConfirmButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57658 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar4 = *(int **)(iVar1 + 0x3c);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(uVar2,
		                       Method_UI_Windows_BaseWindow_EndlessPaymentOptionsListDiscountWindow_EndlessPaymentOptionsListDiscountWindowArgs__get_WindowArgs__
		                      );
		  uVar2 = Core_Extensions_Dict_EndlessPaymentOptionListDicExt__GetTitle
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x1c) + 8),0);
		  iVar1 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar4,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar4 = *(int **)(iVar1 + 0x40);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(uVar2,
		                       Method_UI_Windows_BaseWindow_EndlessPaymentOptionsListDiscountWindow_EndlessPaymentOptionsListDiscountWindowArgs__get_WindowArgs__
		                      );
		  uVar2 = Core_Extensions_Dict_EndlessPaymentOptionListDicExt__GetDiscountChanceTitle
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x1c) + 8),0);
		  iVar1 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar4,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x44),0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(uVar3,
		                       Method_UI_Windows_BaseWindow_EndlessPaymentOptionsListDiscountWindow_EndlessPaymentOptionsListDiscountWindowArgs__get_WindowArgs__
		                      );
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)*(byte *)(*(int *)(*(int *)(iVar1 + 0x1c) + 8) + 0x24),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x48) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionListDiscountWindowMediator_HandleConfirmButtonClickEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  iVar1 = *(int *)(iVar1 + 0x20);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F9")]
		[Address(RVA = "0x824F", Offset = "0x824F", VA = "0x824F")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionListDiscountWindowMediator__SetupView
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a57659 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_EndlessPaymentOptionsListDiscountWindow_EndlessPaymentOptionsListDiscountWindowArgs__get_WindowArgs__
		              );
		    DAT_ram_00a57659 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_8093(param1_00,
		                       Method_UI_Windows_BaseWindow_EndlessPaymentOptionsListDiscountWindow_EndlessPaymentOptionsListDiscountWindowArgs__get_WindowArgs__
		                      );
		  Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__TryBuy
		            (uVar1,*(undefined4 *)(iVar2 + 0x1c),0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_8093(uVar1,
		                       Method_UI_Windows_BaseWindow_EndlessPaymentOptionsListDiscountWindow_EndlessPaymentOptionsListDiscountWindowArgs__get_WindowArgs__
		                      );
		  Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionListDiscountWindowMediator__HandleConfirmButtonClickEvent
		            (param1,*(undefined4 *)(iVar2 + 0x1c),param1);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(uVar1,2,0);
		  return;
		}
		*/

		}

		// Token: 0x060031FA RID: 12794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FA")]
		[Address(RVA = "0x8250", Offset = "0x8250", VA = "0x8250")]
		private void HandleConfirmButtonClickEvent()
		{
		/* --- GHIDRA: HandleConfirmButtonClickEvent ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionListDiscountWindowMediator__HandleConfirmButtonClickEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5765a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__EndlessPaymentOptionsListController__EndlessPaymentOptionsListDiscountWindow__get_Model__
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
		    DAT_ram_00a5765a = '\x01';
		  }
		  piVar4 = *(int **)(param1[2] + 0x10);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x80dbf14c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80dbf14c:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe8);
		        goto code_r0x80dbf1ce;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,5);
		code_r0x80dbf1ce:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar5 = unnamed_function_1417
		                    (
		                    Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow_EndlessPaymentOptionsListWindowArgs_TypeInfo
		                    );
		  UI_Windows_BaseWindowArgs__Dispose(iVar5,0);
		  *(undefined4 *)(iVar5 + 0x1c) = param2;
		  *(undefined1 *)(iVar5 + 0xc) = 0;
		  *(undefined4 *)(iVar5 + 0x18) = uVar3;
		  *(undefined4 *)(iVar5 + 0x10) = 0xb;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_00,StringLiteral_12615,iVar5,
		             Method_UI_Windows_PopupController_Show_EndlessPaymentOptionsListWindow___);
		  return;
		}
		*/

		}

		// Token: 0x060031FB RID: 12795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FB")]
		[Address(RVA = "0x8251", Offset = "0x8251", VA = "0x8251")]
		private void ShowListWindow(EndlessPaymentOptionListData listData)
		{
		/* --- GHIDRA: ShowListWindow ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionListDiscountWindowMediator__ShowListWindow
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57ba3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractController_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__Dispose__
		              );
		    DAT_ram_00a57ba3 = '\x01';
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,
		             Method_MVC_AbstractController_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__Dispose__
		            );
		  if (*(int *)(param1 + 0x18) != 0) {
		    Utils_Timers_DelayedCall__DelayedCallAsync(*(int *)(param1 + 0x18),0);
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionListDiscountWindowMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57657 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionListDiscountWindowMediator_HandleConfirmButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57657 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(*(int *)(iVar1 + 0x48) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionListDiscountWindowMediator_HandleConfirmButtonClickEvent__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

}
