using System;
using System.Collections.Generic;
using Gameplay.Bank.Events;
using Gameplay.Bank.Model;
using Gameplay.Billing.Events;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Services;
using ServicesNamespace;
using Utils;
using Utils.Accumulators;

namespace Gameplay.Bank.Controller
{
	// Token: 0x02000C61 RID: 3169
	[Token(Token = "0x2000C61")]
	public class BankController : AbstractController<BankModel, BankEvents>
	{
		// Token: 0x06004D5A RID: 19802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5A")]
		[Address(RVA = "0x9B93", Offset = "0x9B93", VA = "0x9B93", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Bank_Controller_BankController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a597dc == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_BankModel__BankEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a597dc = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_BankModel__BankEvents___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param4;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06004D5B RID: 19803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5B")]
		[Address(RVA = "0x9B94", Offset = "0x9B94", VA = "0x9B94")]
		public BankController(BankModel model, BankEvents events, BillingEvents billingEvents)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Bank_Controller_BankController___ctor(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Bank_Controller_BankController__HandleRun(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004D5C RID: 19804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5C")]
		[Address(RVA = "0x9B95", Offset = "0x9B95", VA = "0x9B95", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Bank_Controller_BankController__HandleStop(undefined4 param1,undefined4 param2)
		
		{
		  Utils_CoroutineSource__StopCoroutine(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004D5D RID: 19805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5D")]
		[Address(RVA = "0x9B96", Offset = "0x9B96", VA = "0x9B96", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Bank_Controller_BankController__HandleRun(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *param1_00;
		  int iVar7;
		  
		  if (DAT_ram_00a597dd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__remove_UpdateEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPaymentRewardsChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BankOptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankController_BuyOptionCancelEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankController_BuyOptionErrorEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankController_BuyOptionPendingEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankController_BuyOptionSuccessEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankController_HandleDictChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankController_HandlePaymentRewardsChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankController_UserOnOnTriggerChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a597dd = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(int **)(iVar2 + 0xc);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_Gameplay_Bank_Controller_BankController_HandleDictChangedEvent__,0)
		  ;
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		        goto code_r0x810704fc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,1);
		code_r0x810704fc:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,puVar4[1]);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(iVar2 + 8),0);
		  uVar5 = unnamed_function_1417
		                    (
		                    Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		                    );
		  Utils_Accumulators_AccumulatorBase___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___remove_UpdateEvent
		            (uVar5,param1,
		             Method_Gameplay_Bank_Controller_BankController_UserOnOnTriggerChangedEvent__,0);
		  UnityEngine_Events_InvokableCall_InputAction_CallbackContext___add_Delegate
		            (uVar3,uVar5,
		             Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__remove_UpdateEvent__);
		  iVar7 = param1[6];
		  uVar5 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_BankOptionData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_Gameplay_Bank_Controller_BankController_BuyOptionSuccessEvent__,0);
		  iVar2 = func_ii_7048(uVar5,uVar3,0);
		  uVar3 = System_Action_BankOptionData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		  }
		  else {
		    iVar6 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x1c) = iVar6;
		    uVar5 = System_Action_BankOptionData__TypeInfo;
		    iVar7 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    uVar3 = System_Action_BankOptionData__TypeInfo;
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar7 = param1[6];
		  uVar5 = *(undefined4 *)(iVar7 + 0x18);
		  uVar3 = unnamed_function_1417(uVar3);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_Gameplay_Bank_Controller_BankController_BuyOptionErrorEvent__,0);
		  iVar2 = func_ii_7048(uVar5,uVar3,0);
		  uVar3 = System_Action_BankOptionData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar7 + 0x18) = 0;
		  }
		  else {
		    iVar6 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x18) = iVar6;
		    uVar5 = System_Action_BankOptionData__TypeInfo;
		    iVar7 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    uVar3 = System_Action_BankOptionData__TypeInfo;
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar7 = param1[6];
		  uVar5 = *(undefined4 *)(iVar7 + 0x20);
		  uVar3 = unnamed_function_1417(uVar3);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_Gameplay_Bank_Controller_BankController_BuyOptionCancelEvent__,0);
		  iVar2 = func_ii_7048(uVar5,uVar3,0);
		  uVar3 = System_Action_BankOptionData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar7 + 0x20) = 0;
		  }
		  else {
		    iVar6 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x20) = iVar6;
		    uVar5 = System_Action_BankOptionData__TypeInfo;
		    iVar7 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    uVar3 = System_Action_BankOptionData__TypeInfo;
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar7 = param1[6];
		  uVar5 = *(undefined4 *)(iVar7 + 0x24);
		  uVar3 = unnamed_function_1417(uVar3);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_Gameplay_Bank_Controller_BankController_BuyOptionPendingEvent__,0);
		  iVar2 = func_ii_7048(uVar5,uVar3,0);
		  uVar3 = System_Action_BankOptionData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar7 + 0x24) = 0;
		  }
		  else {
		    iVar6 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x24) = iVar6;
		    uVar3 = System_Action_BankOptionData__TypeInfo;
		    iVar7 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = param1[7];
		  uVar3 = unnamed_function_1417(System_Action_ProtoPaymentRewardsChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Bank_Controller_BankController_HandlePaymentRewardsChangedEvent__,0);
		  ServicesNamespace_ServicesService__add_PaymentRewardsChangedEvent(iVar2,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x06004D5E RID: 19806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5E")]
		[Address(RVA = "0x9B97", Offset = "0x9B97", VA = "0x9B97")]
		private void ResetEvents()
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Bank_Controller_BankController__ResetEvents(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *param1_00;
		  int iVar7;
		  
		  if (DAT_ram_00a597de == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__add_UpdateEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPaymentRewardsChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BankOptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankController_BuyOptionCancelEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankController_BuyOptionErrorEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankController_BuyOptionPendingEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankController_BuyOptionSuccessEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankController_HandleDictChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankController_HandlePaymentRewardsChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankController_UserOnOnTriggerChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a597de = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(int **)(iVar2 + 0xc);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_Gameplay_Bank_Controller_BankController_HandleDictChangedEvent__,0)
		  ;
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8107097e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,0);
		code_r0x8107097e:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,puVar4[1]);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(iVar2 + 8),0);
		  uVar5 = unnamed_function_1417
		                    (
		                    Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		                    );
		  Utils_Accumulators_AccumulatorBase___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___remove_UpdateEvent
		            (uVar5,param1,
		             Method_Gameplay_Bank_Controller_BankController_UserOnOnTriggerChangedEvent__,0);
		  UnityEngine_Events_InvokableCall_InputAction_CallbackContext___Invoke
		            (uVar3,uVar5,
		             Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__add_UpdateEvent__);
		  iVar7 = param1[6];
		  uVar5 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_BankOptionData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_Gameplay_Bank_Controller_BankController_BuyOptionSuccessEvent__,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		  uVar3 = System_Action_BankOptionData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		  }
		  else {
		    iVar6 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x1c) = iVar6;
		    uVar5 = System_Action_BankOptionData__TypeInfo;
		    iVar7 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    uVar3 = System_Action_BankOptionData__TypeInfo;
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar7 = param1[6];
		  uVar5 = *(undefined4 *)(iVar7 + 0x18);
		  uVar3 = unnamed_function_1417(uVar3);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_Gameplay_Bank_Controller_BankController_BuyOptionErrorEvent__,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		  uVar3 = System_Action_BankOptionData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar7 + 0x18) = 0;
		  }
		  else {
		    iVar6 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x18) = iVar6;
		    uVar5 = System_Action_BankOptionData__TypeInfo;
		    iVar7 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    uVar3 = System_Action_BankOptionData__TypeInfo;
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar7 = param1[6];
		  uVar5 = *(undefined4 *)(iVar7 + 0x20);
		  uVar3 = unnamed_function_1417(uVar3);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_Gameplay_Bank_Controller_BankController_BuyOptionCancelEvent__,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		  uVar3 = System_Action_BankOptionData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar7 + 0x20) = 0;
		  }
		  else {
		    iVar6 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x20) = iVar6;
		    uVar5 = System_Action_BankOptionData__TypeInfo;
		    iVar7 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    uVar3 = System_Action_BankOptionData__TypeInfo;
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar7 = param1[6];
		  uVar5 = *(undefined4 *)(iVar7 + 0x24);
		  uVar3 = unnamed_function_1417(uVar3);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_Gameplay_Bank_Controller_BankController_BuyOptionPendingEvent__,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		  uVar3 = System_Action_BankOptionData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar7 + 0x24) = 0;
		  }
		  else {
		    iVar6 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x24) = iVar6;
		    uVar3 = System_Action_BankOptionData__TypeInfo;
		    iVar7 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = param1[7];
		  uVar3 = unnamed_function_1417(System_Action_ProtoPaymentRewardsChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Bank_Controller_BankController_HandlePaymentRewardsChangedEvent__,0);
		  ServicesNamespace_ServicesService__remove_TransactionClosedEvent(iVar2,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x06004D5F RID: 19807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5F")]
		[Address(RVA = "0x9B98", Offset = "0x9B98", VA = "0x9B98")]
		private void SetupEvents()
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Bank_Controller_BankController__SetupEvents(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    Gameplay_Bank_Controller_BankController__ResetEvents(param1,param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 8);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004D60 RID: 19808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D60")]
		[Address(RVA = "0x9B99", Offset = "0x9B99", VA = "0x9B99")]
		private void HandleInit()
		{
		/* --- GHIDRA: HandleInit ---
		void Gameplay_Bank_Controller_BankController__HandleInit(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x24);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004D61 RID: 19809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D61")]
		[Address(RVA = "0x9B9A", Offset = "0x9B9A", VA = "0x9B9A")]
		private void HandleDictChangedEvent()
		{
		/* --- GHIDRA: HandleDictChangedEvent ---
		void Gameplay_Bank_Controller_BankController__HandleDictChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x24);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004D62 RID: 19810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D62")]
		[Address(RVA = "0x9B9B", Offset = "0x9B9B", VA = "0x9B9B")]
		private void UserOnOnTriggerChangedEvent(IEnumerable<TriggerValue> changes, AccumulatorBase<int, TriggerValue> accumulator)
		{
		/* --- GHIDRA: UserOnOnTriggerChangedEvent ---
		void Gameplay_Bank_Controller_BankController__UserOnOnTriggerChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param2_00;
		  int iVar2;
		  
		  param2_00 = *(undefined4 *)(param2 + 0xc);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Bank_Model_BankModel__GetOptionsByType(param1_00,param2_00,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  if (*(char *)(param2 + 0x10) != '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = *(int *)(iVar1 + 0x2c) + 1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (iVar2 != *(int *)(iVar1 + 0x2c)) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      *(int *)(iVar1 + 0x2c) = iVar2;
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar1 = *(int *)(iVar1 + 0x2c);
		      if (iVar1 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                  (*(undefined4 *)(iVar1 + 0x20),iVar2,*(undefined4 *)(iVar1 + 0x14));
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004D63 RID: 19811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D63")]
		[Address(RVA = "0x9B9C", Offset = "0x9B9C", VA = "0x9B9C")]
		private void HandlePaymentRewardsChangedEvent(ProtoPaymentRewardsChangedEvt msg)
		{
		}

		// Token: 0x06004D64 RID: 19812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D64")]
		[Address(RVA = "0x9B9D", Offset = "0x9B9D", VA = "0x9B9D")]
		private void BuyOptionPendingEvent(BankOptionData bankOptionData)
		{
		}

		// Token: 0x06004D65 RID: 19813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D65")]
		[Address(RVA = "0x9B9E", Offset = "0x9B9E", VA = "0x9B9E")]
		private void BuyOptionCancelEvent(BankOptionData bankOptionData)
		{
		/* --- GHIDRA: BuyOptionCancelEvent ---
		void Gameplay_Bank_Controller_BankController__BuyOptionCancelEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  *(undefined1 *)(param2 + 0x6d) = 0;
		  if (*(char *)(param2 + 0x6c) != '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x18);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004D66 RID: 19814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D66")]
		[Address(RVA = "0x9B9F", Offset = "0x9B9F", VA = "0x9B9F")]
		private void BuyOptionErrorEvent(BankOptionData bankOptionData)
		{
		/* --- GHIDRA: BuyOptionErrorEvent ---
		void Gameplay_Bank_Controller_BankController__BuyOptionErrorEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  *(undefined1 *)(param2 + 0x6d) = 1;
		  if (*(char *)(param2 + 0x6c) != '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x18);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004D67 RID: 19815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D67")]
		[Address(RVA = "0x9BA0", Offset = "0x9BA0", VA = "0x9BA0")]
		private void BuyOptionSuccessEvent(BankOptionData bankOptionData)
		{
		/* --- GHIDRA: BuyOptionSuccessEvent ---
		void Gameplay_Bank_Controller_BankController__BuyOptionSuccessEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  
		  if (DAT_ram_00a597df == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoEvaluatePaymentRewardsAns_TypeInfo);
		    DAT_ram_00a597df = '\x01';
		  }
		  *(undefined1 *)(param1 + 8) = 0;
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    Gameplay_Bank_Controller_BankController__ResetEvents(param1,param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 8);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Services_ProtoEvaluatePaymentRewardsAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance
		              (param1_01,Protocol_Services_ProtoEvaluatePaymentRewardsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = param1_01[3];
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Bank_Model_BankModel__GetOptionsByType(param1_00,iVar1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004D68 RID: 19816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D68")]
		[Address(RVA = "0x9BA1", Offset = "0x9BA1", VA = "0x9BA1")]
		private void HandleServiceEvaluatePaymentRewards(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceEvaluatePaymentRewards ---
		void Gameplay_Bank_Controller_BankController__HandleServiceEvaluatePaymentRewards
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a597e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoGetActivePromotionsAns_TypeInfo);
		    DAT_ram_00a597e0 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Services_ProtoGetActivePromotionsAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance
		              (param1_01,Protocol_Services_ProtoGetActivePromotionsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Bank_Model_BankModel__SetOptionRewards(param1_00,param1_01[3],param1);
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

		// Token: 0x06004D69 RID: 19817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D69")]
		[Address(RVA = "0x9BA2", Offset = "0x9BA2", VA = "0x9BA2")]
		private void HandleServiceGetActivePromotions(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceGetActivePromotions ---
		void Gameplay_Bank_Controller_BankController__HandleServiceGetActivePromotions
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *param1_01;
		  int *param1_02;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a597e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoGetOptionArtikulsAns_TypeInfo);
		    DAT_ram_00a597e1 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Services_ProtoGetOptionArtikulsAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Services_ProtoGetOptionArtikulsAns_TypeInfo)
		    ;
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_02 = *(int **)(param2 + 0xc);
		  if (param1_02 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*param1_02 + 0x20) == *(int *)(DAT_ram_00a66958 + 0x20)) {
		    puVar1 = (undefined4 *)func_ii_15774(param1_02);
		    param2_00 = *puVar1;
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Bank_Model_BankModel__SetActivePromotions(param1_00,param2_00,param1_01,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x20);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),param2_00,*(undefined4 *)(iVar2 + 0x14));
		    }
		    return;
		  }
		  System_Activator__CreateInstance(param1_02,DAT_ram_00a66958);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004D6A RID: 19818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D6A")]
		[Address(RVA = "0x9BA3", Offset = "0x9BA3", VA = "0x9BA3")]
		private void HandleServiceGetOptionArtikuls(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceGetOptionArtikuls ---
		void Gameplay_Bank_Controller_BankController__HandleServiceGetOptionArtikuls
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int *piVar7;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a597e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_BankOptionData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_BankScope_ExchangeEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedEndlessOptionsBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3535);
		    DAT_ram_00a597e2 = '\x01';
		  }
		  piVar6 = *(int **)(param2 + 0x20);
		  if ((piVar6 != (int *)0x0) && (Protocol_Common_ProtoDefaultAns_TypeInfo != *piVar6)) {
		    System_Activator__CreateInstance(piVar6,Protocol_Common_ProtoDefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (piVar6[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedEndlessOptionsBillingErrors___
		                    );
		  if (iVar2 == 0) {
		    piVar6 = *(int **)(param2 + 0xc);
		    if (piVar6 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar6 + 0xb8) <
		           (uint)*(byte *)(Gameplay_Bank_Model_BankOptionData_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar6 + 100) +
		                   (uint)*(byte *)(Gameplay_Bank_Model_BankOptionData_TypeInfo + 0xb8) * 4 + -4) !=
		          Gameplay_Bank_Model_BankOptionData_TypeInfo)) {
		        System_Activator__CreateInstance(piVar6,Gameplay_Bank_Model_BankOptionData_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x28);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),piVar6,*(undefined4 *)(iVar2 + 0x14));
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    piVar7 = *(int **)(iVar2 + 0x1c);
		    iVar2 = *piVar7;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		          goto code_r0x8107131a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8107131a:
		    piVar7 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		    uVar1 = 0;
		    iVar2 = *piVar7;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x100);
		          goto code_r0x8107139c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar7,Core_Application_IApp_TypeInfo,8);
		code_r0x8107139c:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		    iVar2 = *(int *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x48) + 8);
		    if (iVar2 != 0) {
		      uVar4 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      uVar5 = unnamed_function_1417(Core_Events_Scopes_BankScope_ExchangeEventArgs_TypeInfo);
		      Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(uVar5,uVar4,param3_00,piVar6,0);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),uVar5,*(undefined4 *)(iVar2 + 0x14));
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    piVar6 = *(int **)(iVar2 + 0x1c);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		          goto code_r0x810714a4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x810714a4:
		    piVar6 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    uVar1 = 0;
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xf0);
		          goto code_r0x81071526;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,6);
		code_r0x81071526:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3535,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar4,1,uVar5,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004D6B RID: 19819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D6B")]
		[Address(RVA = "0x9BA4", Offset = "0x9BA4", VA = "0x9BA4")]
		private void HandleDoExchangeService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleDoExchangeService ---
		void Gameplay_Bank_Controller_BankController__HandleDoExchangeService
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Bank_Model_BankModel__GetOptionsByType(param1_00,param2,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004D6C RID: 19820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D6C")]
		[Address(RVA = "0x9BA5", Offset = "0x9BA5", VA = "0x9BA5")]
		private void SetOptionsRewards(IList<OptionRewards> rewards)
		{
		/* --- GHIDRA: SetOptionsRewards ---
		void Gameplay_Bank_Controller_BankController__SetOptionsRewards(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a597e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankController_HandleServiceGetActivePromotions__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a597e4 = '\x01';
		  }
		  param1_00 = ServicesNamespace_ServicesService__GetOptionArtikuls(*(undefined4 *)(param1 + 0x1c),0)
		  ;
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Bank_Controller_BankController_HandleServiceGetActivePromotions__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06004D6D RID: 19821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D6D")]
		[Address(RVA = "0x1F10", Offset = "0x1F10", VA = "0x1F10")]
		public void RequestAvailableOptions()
		{
		}

		// Token: 0x06004D6E RID: 19822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D6E")]
		[Address(RVA = "0x9BA6", Offset = "0x9BA6", VA = "0x9BA6")]
		public void RequestActivePromotions()
		{
		/* --- GHIDRA: RequestActivePromotions ---
		void Gameplay_Bank_Controller_BankController__RequestActivePromotions
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a597e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankController_HandleDoExchangeService__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Billing_PurchaseProcess_IPurchaseProcess_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a597e5 = '\x01';
		  }
		  if (*(double *)(*(int *)(param2 + 0x18) + 8) <= 0.0) {
		    uVar3 = ServicesNamespace_ServicesService__GetPaymentData
		                      (param1[7],*(undefined4 *)(*(int *)(param2 + 0x38) + 0xc),0);
		    param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_Bank_Controller_BankController_HandleDoExchangeService__,0);
		    uVar3 = ServicesNamespace_MainService__GetUserStats
		                      (uVar3,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DG_Tweening_TweenParams__SetId
		              (uVar3,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar5 = 0;
		  piVar4 = *(int **)(iVar1 + 0x1c);
		  iVar1 = *piVar4;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar5 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar5 * 8 + 4) * 8 + iVar1 + 0x198);
		        goto code_r0x810716de;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar5);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x1b);
		code_r0x810716de:
		  iVar1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar5 = 0;
		  piVar4 = *(int **)(iVar1 + 0x14);
		  iVar1 = *piVar4;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Billing_PurchaseProcess_IPurchaseProcess_TypeInfo ==
		          *(int *)(*(int *)(iVar1 + 0x58) + uVar5 * 8)) {
		        puVar2 = (uint *)(iVar1 + *(int *)(*(int *)(iVar1 + 0x58) + uVar5 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81071763;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar5);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,
		                                Core_Gameplay_Managers_Billing_PurchaseProcess_IPurchaseProcess_TypeInfo
		                                ,0);
		code_r0x81071763:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar4,param2,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06004D6F RID: 19823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D6F")]
		[Address(RVA = "0x9BA7", Offset = "0x9BA7", VA = "0x9BA7")]
		public void BuyOption(BankOptionData bankOptionData)
		{
		/* --- GHIDRA: BuyOption ---
		void Gameplay_Bank_Controller_BankController__BuyOption(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a597e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankController_HandleServiceGetOptionArtikuls__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a597e6 = '\x01';
		  }
		  if (*(int *)(param2 + 0x60) == 0) {
		    uVar2 = ServicesNamespace_ServicesService__DoExchange
		                      (param1[7],*(undefined4 *)(*(int *)(param2 + 0x38) + 0xc),0);
		    uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_BankController_HandleServiceGetOptionArtikuls__,0);
		    uVar2 = ServicesNamespace_MainService__GetUserStats
		                      (uVar2,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    local_4 = *(undefined4 *)(*(int *)(param2 + 0x38) + 0xc);
		    uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		    DG_Tweening_TweenParams__SetId
		              (uVar2,uVar3,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x20);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(*(int *)(param2 + 0x38) + 0xc),
		                 *(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004D70 RID: 19824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D70")]
		[Address(RVA = "0x9BA8", Offset = "0x9BA8", VA = "0x9BA8")]
		public void GetOptionArtikuls(BankOptionData bankOptionData)
		{
		/* --- GHIDRA: GetOptionArtikuls ---
		void Gameplay_Bank_Controller_BankController__GetOptionArtikuls
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x2c) != param2) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x2c) = param2;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x2c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004D71 RID: 19825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D71")]
		[Address(RVA = "0x9BA9", Offset = "0x9BA9", VA = "0x9BA9")]
		public void SetEpNotifications(int value)
		{
		/* --- GHIDRA: SetEpNotifications ---
		void Gameplay_Bank_Controller_BankController__SetEpNotifications
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a597e7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__UserInterfaceView___ctor__
		              );
		    DAT_ram_00a597e7 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__UserInterfaceView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002A3A RID: 10810
		[Token(Token = "0x4002A3A")]
		[FieldOffset(Offset = "0x18")]
		private BillingEvents _billingEvents;

		// Token: 0x04002A3B RID: 10811
		[Token(Token = "0x4002A3B")]
		[FieldOffset(Offset = "0x1C")]
		private ServicesService _servicesService;

		// Token: 0x04002A3C RID: 10812
		[Token(Token = "0x4002A3C")]
		[FieldOffset(Offset = "0x20")]
		private bool _optionsRequestingNow;
	}
}
