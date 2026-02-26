using System;
using System.Collections.Generic;
using Gameplay.Bank.Model;
using Gameplay.EndlessPaymentOptionsList.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Services;
using Utils;
using Utils.Accumulators;
using Utils.Timers;

namespace Gameplay.EndlessPaymentOptionsList.Control
{
	// Token: 0x02000850 RID: 2128
	[Token(Token = "0x2000850")]
	public class EndlessPaymentOptionsListController : AbstractController<EndlessPaymentOptionsListModel, EndlessPaymentOptionsListEvents>
	{
		// Token: 0x060031FC RID: 12796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FC")]
		[Address(RVA = "0x8252", Offset = "0x8252", VA = "0x8252", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: <HandleRun>b__4_0 ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController___HandleRun_b__4_0
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a57bae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__EndlessPaymentOptionsListController__EndlessPaymentOptionsListEntryPointView___ctor__
		              );
		    DAT_ram_00a57bae = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__EndlessPaymentOptionsListController__EndlessPaymentOptionsListEntryPointView___ctor__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: Dispose ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57ba4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractController_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_Timers_DelayedCall_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_HandleDiscountOffer__
		              );
		    DAT_ram_00a57ba4 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents___ctor__
		            );
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_HandleDiscountOffer__
		             ,0);
		  param1_01 = unnamed_function_1417(Utils_Timers_DelayedCall_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_01,param1_00,0);
		  *(undefined4 *)(param1 + 0x18) = param1_01;
		  return;
		}
		*/

		}

		// Token: 0x060031FD RID: 12797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FD")]
		[Address(RVA = "0x8253", Offset = "0x8253", VA = "0x8253")]
		public EndlessPaymentOptionsListController(EndlessPaymentOptionsListModel model, EndlessPaymentOptionsListEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController___ctor
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a57ba5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__remove_UpdateEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_BankOptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_HandleBankDoExchangeSuccessEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_HandleBillingBuyOptionSuccessEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_HandleDictChangeEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_HandleTriggersOnUpdateEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57ba5 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = *(int **)(iVar2 + 0xc);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_HandleDictChangeEvent__
		             ,0);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		        goto code_r0x80e2f27a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,1);
		code_r0x80e2f27a:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar6,uVar3,puVar4[1]);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar7 = *(int *)(*(int *)(iVar2 + 0x14) + 0x28);
		  uVar8 = *(undefined4 *)(iVar7 + 0x28);
		  uVar3 = unnamed_function_1417(System_Action_BankOptionData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_HandleBankDoExchangeSuccessEvent__
		             ,0);
		  iVar2 = func_ii_7048(uVar8,uVar3,0);
		  uVar3 = System_Action_BankOptionData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar7 + 0x28) = 0;
		  }
		  else {
		    iVar5 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x28) = iVar5;
		    uVar3 = System_Action_BankOptionData__TypeInfo;
		    iVar7 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar6 = *(int **)(iVar2 + 0x10);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x198);
		        goto code_r0x80e2f3a2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x1b);
		code_r0x80e2f3a2:
		  iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  iVar7 = *(int *)(iVar2 + 0x10);
		  uVar8 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_BankOptionData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_HandleBillingBuyOptionSuccessEvent__
		             ,0);
		  iVar2 = func_ii_7048(uVar8,uVar3,0);
		  uVar3 = System_Action_BankOptionData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		  }
		  else {
		    iVar5 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x1c) = iVar5;
		    uVar3 = System_Action_BankOptionData__TypeInfo;
		    iVar7 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(iVar2 + 8),0);
		  uVar8 = unnamed_function_1417
		                    (
		                    Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		                    );
		  Utils_Accumulators_AccumulatorBase___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___remove_UpdateEvent
		            (uVar8,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_HandleTriggersOnUpdateEvent__
		             ,0);
		  UnityEngine_Events_InvokableCall_InputAction_CallbackContext___add_Delegate
		            (uVar3,uVar8,
		             Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__remove_UpdateEvent__);
		  Utils_Timers_DelayedCall__SetDelay(param1[6],0);
		  return;
		}
		*/

		}

		// Token: 0x060031FE RID: 12798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FE")]
		[Address(RVA = "0x8254", Offset = "0x8254", VA = "0x8254", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__HandleStop
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  int local_4;
		  
		  if (DAT_ram_00a57ba6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__add_UpdateEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_BankOptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_PopupScheduleManager_Args_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_HandleBankDoExchangeSuccessEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_HandleBillingBuyOptionSuccessEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_HandleDictChangeEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_HandleTriggersOnUpdateEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_ShowDiscountOffer__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__HandleRun_b__4_0__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_bool____TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_PopupScheduleManager_ScheduleOpenWindow_EndlessPaymentOptionsListDiscountWindow___
		              );
		    DAT_ram_00a57ba6 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar7 = *(int **)(iVar2 + 0x10);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x208);
		        goto code_r0x80e2f5d0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x29);
		code_r0x80e2f5d0:
		  uVar1 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  iVar2 = unnamed_function_1417(Core_Gameplay_Managers_PopupScheduleManager_Args_TypeInfo);
		  UnityEngine_Purchasing_Default_WinProductDescription__set_title(iVar2,7,0);
		  *(undefined8 *)(iVar2 + 8) = 0x7fffffff;
		  uVar5 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar5,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_ShowDiscountOffer__
		             ,0);
		  *(undefined4 *)(iVar2 + 0x10) = uVar5;
		  local_4 = iVar2;
		  iVar2 = Mono_Security_ASN1Convert__ToOid(System_Func_bool____TypeInfo,1);
		  uVar5 = unnamed_function_1417(System_Func_bool__TypeInfo);
		  System_Func_BackgroundSize___Invoke
		            (uVar5,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__HandleRun_b__4_0__
		             ,0);
		  *(undefined4 *)(iVar2 + 0x10) = uVar5;
		  UI_Windows_PopupController__HasOpenWindow_object_
		            (uVar4,&local_4,iVar2,
		             Method_Core_Gameplay_Managers_PopupScheduleManager_ScheduleOpenWindow_EndlessPaymentOptionsListDiscountWindow___
		            );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar7 = *(int **)(iVar2 + 0xc);
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_HandleDictChangeEvent__
		             ,0);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e2f71e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Dict_IDictProvider_TypeInfo,0);
		code_r0x80e2f71e:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar4,puVar3[1]);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar8 = *(int *)(*(int *)(iVar2 + 0x14) + 0x28);
		  uVar5 = *(undefined4 *)(iVar8 + 0x28);
		  uVar4 = unnamed_function_1417(System_Action_BankOptionData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_HandleBankDoExchangeSuccessEvent__
		             ,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar5,uVar4,0);
		  uVar4 = System_Action_BankOptionData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar8 + 0x28) = 0;
		  }
		  else {
		    iVar6 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar8 + 0x28) = iVar6;
		    uVar4 = System_Action_BankOptionData__TypeInfo;
		    iVar8 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    if (iVar8 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar7 = *(int **)(iVar2 + 0x10);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x198);
		        goto code_r0x80e2f846;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x1b);
		code_r0x80e2f846:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  iVar8 = *(int *)(iVar2 + 0x10);
		  uVar5 = *(undefined4 *)(iVar8 + 0x1c);
		  uVar4 = unnamed_function_1417(System_Action_BankOptionData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_HandleBillingBuyOptionSuccessEvent__
		             ,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar5,uVar4,0);
		  uVar4 = System_Action_BankOptionData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar8 + 0x1c) = 0;
		  }
		  else {
		    iVar6 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar8 + 0x1c) = iVar6;
		    uVar4 = System_Action_BankOptionData__TypeInfo;
		    iVar8 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    if (iVar8 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar4 = Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(iVar2 + 8),0);
		  uVar5 = unnamed_function_1417
		                    (
		                    Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		                    );
		  Utils_Accumulators_AccumulatorBase___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___remove_UpdateEvent
		            (uVar5,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_HandleTriggersOnUpdateEvent__
		             ,0);
		  UnityEngine_Events_InvokableCall_InputAction_CallbackContext___Invoke
		            (uVar4,uVar5,
		             Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__add_UpdateEvent__);
		  Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__ValidateInit
		            (param1,uVar4);
		  return;
		}
		*/

		}

		// Token: 0x060031FF RID: 12799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FF")]
		[Address(RVA = "0x8255", Offset = "0x8255", VA = "0x8255", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__HandleRun
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x28) == 0) {
		    Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__ValidateInit
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003200 RID: 12800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003200")]
		[Address(RVA = "0x8256", Offset = "0x8256", VA = "0x8256")]
		private void HandleTriggersOnUpdateEvent(IEnumerable<TriggerValue> changes, AccumulatorBase<int, TriggerValue> accumulator)
		{
		}

		// Token: 0x06003201 RID: 12801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003201")]
		[Address(RVA = "0x8257", Offset = "0x8257", VA = "0x8257")]
		private void HandleBillingBuyOptionSuccessEvent(BankOptionData data)
		{
		/* --- GHIDRA: HandleBillingBuyOptionSuccessEvent ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__HandleBillingBuyOptionSuccessEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  local_4 = 0;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__TryGetCurrentList
		                    (param1_00,param2,&local_4,0);
		  if (iVar1 != 0) {
		    Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__TryToPlanDiscountOffer
		              (param1,local_4,auStack_10);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003202 RID: 12802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003202")]
		[Address(RVA = "0x8258", Offset = "0x8258", VA = "0x8258")]
		private void HandleBankDoExchangeSuccessEvent(BankOptionData data)
		{
		/* --- GHIDRA: HandleBankDoExchangeSuccessEvent ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__HandleBankDoExchangeSuccessEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x28) == 0) {
		    Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__ValidateInit
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003203 RID: 12803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003203")]
		[Address(RVA = "0x8259", Offset = "0x8259", VA = "0x8259")]
		private void HandleDictChangeEvent()
		{
		/* --- GHIDRA: HandleDictChangeEvent ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__HandleDictChangeEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  int iVar5;
		  int *param1_00;
		  
		  if (DAT_ram_00a57ba7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData__get_Count__);
		    DAT_ram_00a57ba7 = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__ReLink(uVar2,0);
		  iVar5 = *(int *)(iVar3 + 0xc);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(bool *)(iVar3 + 0x35) = 0 < iVar5;
		  if (0 < iVar5) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    param1_00 = *(int **)(iVar3 + 0x10);
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x208);
		          goto code_r0x80e2fc9e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x29);
		code_r0x80e2fc9e:
		    uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		    Core_Gameplay_Managers_PopupScheduleManager__UnScheduleOpenWindow(uVar2,1,0);
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar3 = *(int *)(iVar3 + 0x18);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003204 RID: 12804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003204")]
		[Address(RVA = "0x825A", Offset = "0x825A", VA = "0x825A")]
		private void HandleDiscountOffer()
		{
		/* --- GHIDRA: HandleDiscountOffer ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__HandleDiscountOffer
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *piVar4;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57ba8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListDiscountWindow_EndlessPaymentOptionsListDiscountWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_EndlessPaymentOptionsListDiscountWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12614);
		    DAT_ram_00a57ba8 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar4 = *(int **)(iVar2 + 0x10);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		        goto code_r0x80e2fdb6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80e2fdb6:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar1 = 0;
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe8);
		        goto code_r0x80e2fe38;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,5);
		code_r0x80e2fe38:
		  param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined4 *)(iVar2 + 0x28);
		  param1_01 = unnamed_function_1417
		                        (
		                        Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListDiscountWindow_EndlessPaymentOptionsListDiscountWindowArgs_TypeInfo
		                        );
		  Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListDiscountWindow___ctor
		            (param1_01,param2_00,param1,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_00,StringLiteral_12614,param1_01,
		             Method_UI_Windows_PopupController_Show_EndlessPaymentOptionsListDiscountWindow___);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined1 *)(iVar2 + 0x35) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06003205 RID: 12805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003205")]
		[Address(RVA = "0x825B", Offset = "0x825B", VA = "0x825B")]
		private void ShowDiscountOffer()
		{
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003206")]
		[Address(RVA = "0x825C", Offset = "0x825C", VA = "0x825C")]
		private void ValidateInit()
		{
		/* --- GHIDRA: ValidateInit ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__ValidateInit
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57ba9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_HandleGetEndlessPaymentOptionsService__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a57ba9 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  uVar1 = ServicesNamespace_ServicesService__RejectAdPlacement(uVar1,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_HandleGetEndlessPaymentOptionsService__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003207 RID: 12807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003207")]
		[Address(RVA = "0x825D", Offset = "0x825D", VA = "0x825D")]
		private void RequestOption()
		{
		/* --- GHIDRA: RequestOption ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__RequestOption
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a57baa == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoGetEndlessPaymentOptionsAns_TypeInfo);
		    DAT_ram_00a57baa = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Services_ProtoGetEndlessPaymentOptionsAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance
		              (param1_01,Protocol_Services_ProtoGetEndlessPaymentOptionsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__CreateCards
		            (param1_00,param1_01,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__SetInfo
		            (param1,param1);
		  if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 8);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003208 RID: 12808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003208")]
		[Address(RVA = "0x825E", Offset = "0x825E", VA = "0x825E")]
		private void HandleGetEndlessPaymentOptionsService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetEndlessPaymentOptionsService ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__HandleGetEndlessPaymentOptionsService
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__CreateCards
		            (param1_00,param2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__SetInfo
		            (param1,param1);
		  if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 8);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003209 RID: 12809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003209")]
		[Address(RVA = "0x825F", Offset = "0x825F", VA = "0x825F")]
		private void SetInfo(ProtoGetEndlessPaymentOptionsAns info)
		{
		/* --- GHIDRA: SetInfo ---
		undefined4
		Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__SetInfo
		          (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int local_4;
		  
		  if (DAT_ram_00a57bab == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData__get_Count__);
		    DAT_ram_00a57bab = '\x01';
		  }
		  local_4 = 0;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__GetCardForDisplay
		                    (uVar1,&local_4,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__ReLink(uVar1,0)
		    ;
		    if (*(int *)(iVar2 + 0xc) != 0) {
		      Utils_Timers_DelayedCall__SetDelay(param1[6],*(undefined4 *)(local_4 + 0xc),0);
		      return 1;
		    }
		  }
		  Utils_Timers_DelayedCall__SetDelay(param1[6],0);
		  return 0;
		}
		*/

		}

		// Token: 0x0600320A RID: 12810 RVA: 0x0000A398 File Offset: 0x00008598
		[Token(Token = "0x600320A")]
		[Address(RVA = "0x8260", Offset = "0x8260", VA = "0x8260")]
		private bool TryToPlanDiscountOffer()
		{
		/* --- GHIDRA: TryToPlanDiscountOffer ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__TryToPlanDiscountOffer
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57bac == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Last_CardData___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6841);
		    DAT_ram_00a57bac = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__GetCards(uVar1,0)
		  ;
		  Gameplay_EndlessPaymentOptionsList_Model_CardData__GetRewards(param2,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__SetInfo(uVar2,0);
		  iVar3 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                    (uVar1,Method_System_Linq_Enumerable_Last_CardData___);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_6841,param2,*(undefined4 *)(*(int *)(iVar3 + 0xc) + 0xc),0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar3 = *(int *)(iVar3 + 0x24);
		  if (iVar3 != 0) {
		    iVar4 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                      (uVar1,Method_System_Linq_Enumerable_Last_CardData___);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),param2,*(undefined4 *)(*(int *)(iVar4 + 0xc) + 0xc),
		               *(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600320B")]
		[Address(RVA = "0x8261", Offset = "0x8261", VA = "0x8261")]
		private void HandlePurchaseSuccess(CardData cardData)
		{
		/* --- GHIDRA: HandlePurchaseSuccess ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__HandlePurchaseSuccess
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__ValidateInit
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600320C RID: 12812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600320C")]
		[Address(RVA = "0x8262", Offset = "0x8262", VA = "0x8262")]
		public void UpdateOptions()
		{
		/* --- GHIDRA: UpdateOptions ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__UpdateOptions
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined1 *)(iVar1 + 0x34) = 1;
		  Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__ValidateInit
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600320D RID: 12813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600320D")]
		[Address(RVA = "0x8263", Offset = "0x8263", VA = "0x8263")]
		public void RequestForShow()
		{
		/* --- GHIDRA: RequestForShow ---
		undefined4
		Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__RequestForShow
		          (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = 0;
		  if ((*(char *)(param2 + 0x20) == '\0') && (*(int *)(*(int *)(param2 + 0xc) + 8) == 0)) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Bank_Controller_BankController__RequestActivePromotions
		              (*(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x24),*(undefined4 *)(param2 + 0x10),0);
		    uVar1 = 1;
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600320E RID: 12814 RVA: 0x0000A3B0 File Offset: 0x000085B0
		[Token(Token = "0x600320E")]
		[Address(RVA = "0x8264", Offset = "0x8264", VA = "0x8264")]
		public bool TryBuy(CardData data)
		{
		/* --- GHIDRA: TryBuy ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__TryBuy
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__get_IsDiscountEnabled
		            (param1_00,(uint)*(byte *)(*(int *)(param2 + 8) + 0x24),0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600320F RID: 12815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600320F")]
		[Address(RVA = "0x8265", Offset = "0x8265", VA = "0x8265")]
		public void ApplyDiscount(EndlessPaymentOptionListData listData)
		{
		/* --- GHIDRA: ApplyDiscount ---
		void Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__ApplyDiscount
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__get_IsDiscountEnabled
		            (uVar1,0,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  System_Runtime_Serialization_Formatters_Binary_ReadObjectInfo__ObjectEnd(uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003210 RID: 12816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003210")]
		[Address(RVA = "0x8266", Offset = "0x8266", VA = "0x8266")]
		public void Reset()
		{
		/* --- GHIDRA: Reset ---
		uint Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__Reset
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a57bad == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData__get_Count__);
		    DAT_ram_00a57bad = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(char *)(iVar1 + 0x35) == '\0') {
		    uVar2 = 0;
		  }
		  else {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__ReLink
		                      (param1_00,0);
		    uVar2 = (uint)(0 < *(int *)(iVar1 + 0xc));
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x04001B67 RID: 7015
		[Token(Token = "0x4001B67")]
		[FieldOffset(Offset = "0x18")]
		private DelayedCall _discountOfferInvoker;
	}
}
