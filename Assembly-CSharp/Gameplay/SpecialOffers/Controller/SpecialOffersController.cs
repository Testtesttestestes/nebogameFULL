using System;
using System.Collections.Generic;
using Gameplay.EndlessPaymentOptionsList.Model;
using Gameplay.SpecialOffers.Events;
using Gameplay.SpecialOffers.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Common;
using ServicesNamespace;
using Utils;
using Utils.Accumulators;
using Utils.Timers;

namespace Gameplay.SpecialOffers.Controller
{
	// Token: 0x0200050E RID: 1294
	[Token(Token = "0x200050E")]
	public class SpecialOffersController : OptionsOfferControllerBase<SpecialOffersModel, SpecialOffersEvents>
	{
		// Token: 0x06001ECE RID: 7886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECE")]
		[Address(RVA = "0x7035", Offset = "0x7035", VA = "0x7035")]
		public SpecialOffersController(SpecialOffersModel model, SpecialOffersEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersController___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58640 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_GetSpecialOfferResultHandler__
		              );
		    DAT_ram_00a58640 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ServicesService__BuyAccount(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_GetSpecialOfferResultHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECF")]
		[Address(RVA = "0x7036", Offset = "0x7036", VA = "0x7036")]
		public void GetSpecialOffer()
		{
		/* --- GHIDRA: GetSpecialOffer ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersController__GetSpecialOffer
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  float param2_00;
		  int *param1_01;
		  longlong param1_02;
		  
		  if (DAT_ram_00a58641 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoGetSpecialOfferAns_TypeInfo);
		    DAT_ram_00a58641 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Services_ProtoGetSpecialOfferAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Services_ProtoGetSpecialOfferAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = CONCAT44(in_register_20000004,param1);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (uVar1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  Gameplay_SpecialOffers_Model_SpecialOffersModel__RemoveOption(param1_00,param1_01[3],param1);
		  uVar1 = CONCAT44(uVar2,param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (uVar1,*(undefined4 *)(*param1 + 0x114));
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar3 = *(int *)(iVar3 + 0x14);
		  if (iVar3 != 0) {
		    uVar1 = CONCAT44(uVar2,*(undefined4 *)(iVar3 + 0x20));
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))(uVar1,*(undefined4 *)(iVar3 + 0x14));
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  }
		  param1_02 = *(longlong *)(param1_01 + 4);
		  if (param1_02 == 0) {
		    Gameplay_SpecialOffers_Controller_SpecialOffersController__GetSpecialOfferResultHandler
		              (param1,param1);
		  }
		  else {
		    if (DAT_ram_00a58643 == '\0') {
		      Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		      DAT_ram_00a58643 = '\x01';
		    }
		    iVar3 = param1[7];
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    param2_00 = Utils_StringUtils___cctor(param1_02,0);
		    uVar2 = (undefined4)((ulonglong)param1_02 >> 0x20);
		    Utils_Timers_DelayedCall___ctor(iVar3,param2_00,0);
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (CONCAT44(uVar2,param1),*(undefined4 *)(*param1 + 0x104));
		  *(undefined1 *)(iVar3 + 0x20) = 0;
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

		// Token: 0x06001ED0 RID: 7888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED0")]
		[Address(RVA = "0x7037", Offset = "0x7037", VA = "0x7037")]
		private void GetSpecialOfferResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetSpecialOfferResultHandler ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersController__GetSpecialOfferResultHandler
		               (int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58642 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Aggregate_BankOptionData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_DefaultIfEmpty_BankOptionData___);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_BankOptionData__BankOptionData__BankOptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersController___c__ScheduleExpiration_b__6_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SpecialOffers_Controller_SpecialOffersController___c_TypeInfo);
		    DAT_ram_00a58642 = '\x01';
		  }
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xf0) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0xf4));
		  uVar2 = System_Linq_Enumerable__Count___Il2CppFullySharedGenericType_
		                    (uVar2,Method_System_Linq_Enumerable_DefaultIfEmpty_BankOptionData___);
		  if (*(int *)(Gameplay_SpecialOffers_Controller_SpecialOffersController___c_TypeInfo + 0x74) == 0)
		  {
		    func_ii_306000(Gameplay_SpecialOffers_Controller_SpecialOffersController___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)
		            (Gameplay_SpecialOffers_Controller_SpecialOffersController___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[1];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_SpecialOffers_Controller_SpecialOffersController___c_TypeInfo + 0x74) == 0
		       ) {
		      func_ii_306000(Gameplay_SpecialOffers_Controller_SpecialOffersController___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Gameplay_SpecialOffers_Controller_SpecialOffersController___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar3;
		    iVar4 = unnamed_function_1417
		                      (System_Func_BankOptionData__BankOptionData__BankOptionData__TypeInfo);
		    System_Threading_Tasks_Task_object___get_Factory
		              (iVar4,param2_00,
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersController___c__ScheduleExpiration_b__6_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_SpecialOffers_Controller_SpecialOffersController___c_TypeInfo + 0x5c)
		            + 4) = iVar4;
		  }
		  iVar4 = UnityEngine_UIElements_EnumField__ProcessPointerDown_object_
		                    (uVar2,iVar4,Method_System_Linq_Enumerable_Aggregate_BankOptionData___);
		  if (iVar4 != 0) {
		    Utils_Timers_DelayedCall__SetDelay(param1[8],*(undefined4 *)(iVar4 + 0x58),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED1")]
		[Address(RVA = "0x7038", Offset = "0x7038", VA = "0x7038")]
		private void ScheduleExpiration()
		{
		/* --- GHIDRA: ScheduleExpiration ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersController__ScheduleExpiration
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  Gameplay_SpecialOffers_Controller_SpecialOffersController___ctor(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED2")]
		[Address(RVA = "0x7039", Offset = "0x7039", VA = "0x7039")]
		private void HandleExpiration()
		{
		/* --- GHIDRA: HandleExpiration ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersController__HandleExpiration
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  float param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58643 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a58643 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x1c);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = Utils_StringUtils___cctor(param2,0);
		  Utils_Timers_DelayedCall___ctor(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED3")]
		[Address(RVA = "0x703A", Offset = "0x703A", VA = "0x703A")]
		private void ScheduleNextRequest(ulong ms)
		{
		/* --- GHIDRA: ScheduleNextRequest ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersController__ScheduleNextRequest
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58644 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_CancelSpecialOfferResultHandler__
		              );
		    DAT_ram_00a58644 = '\x01';
		  }
		  param1_00 = ServicesNamespace_ServicesService__GetSpecialOffer
		                        (*(undefined4 *)(param1 + 0x18),param2,param3,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_CancelSpecialOfferResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED4")]
		[Address(RVA = "0x703B", Offset = "0x703B", VA = "0x703B")]
		public void CancelSpecialOffer(uint optionId, bool purchased)
		{
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED5")]
		[Address(RVA = "0x703C", Offset = "0x703C", VA = "0x703C")]
		private void CancelSpecialOfferResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: CancelSpecialOfferResultHandler ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersController__CancelSpecialOfferResultHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined1 *)(iVar1 + 0x20) = (undefined1)param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED6")]
		[Address(RVA = "0x703D", Offset = "0x703D", VA = "0x703D")]
		public void SetViewed(bool viewed)
		{
		/* --- GHIDRA: SetViewed ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersController__SetViewed
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int param1_00;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a58645 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__remove_UpdateEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_CardData__CardData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_HandleEndlessOptionsListBuySuccessEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_HandleEndlessOptionsListChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_HandleEndlessOptionsListTimeOutEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_UserOnOnTriggerChangedEventHandler__
		              );
		    DAT_ram_00a58645 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(iVar2 + 8),0);
		  uVar4 = unnamed_function_1417
		                    (
		                    Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		                    );
		  Utils_Accumulators_AccumulatorBase___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___remove_UpdateEvent
		            (uVar4,param1,
		             Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_UserOnOnTriggerChangedEventHandler__
		             ,0);
		  UnityEngine_Events_InvokableCall_InputAction_CallbackContext___add_Delegate
		            (uVar3,uVar4,
		             Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__remove_UpdateEvent__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = *(int **)(iVar2 + 0x10);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x298);
		        goto code_r0x80f17ba5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x3b);
		code_r0x80f17ba5:
		  iVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		  iVar7 = **(int **)(iVar2 + 0x14);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x110) * 4))
		                    (*(int **)(iVar2 + 0x14),*(undefined4 *)(iVar7 + 0x114));
		  uVar4 = *(undefined4 *)(iVar7 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_HandleEndlessOptionsListTimeOutEvent__
		             ,0);
		  piVar6 = (int *)func_ii_7048(uVar4,uVar3,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar6 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 0x18) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar6) ||
		          (*(int **)(iVar7 + 0x18) = piVar6, *piVar6 != iVar2)) {
		    System_Activator__CreateInstance(piVar6,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar6 = *(int **)(iVar2 + 0x10);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x298);
		        goto code_r0x80f17cc2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x3b);
		code_r0x80f17cc2:
		  iVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		  iVar7 = **(int **)(iVar2 + 0x14);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x110) * 4))
		                    (*(int **)(iVar2 + 0x14),*(undefined4 *)(iVar7 + 0x114));
		  uVar4 = *(undefined4 *)(iVar7 + 0x24);
		  uVar3 = unnamed_function_1417(System_Action_CardData__CardData__TypeInfo);
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		            (uVar3,param1,
		             Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_HandleEndlessOptionsListBuySuccessEvent__
		             ,0);
		  iVar2 = 0;
		  param1_00 = func_ii_7048(uVar4,uVar3,0);
		  uVar3 = System_Action_CardData__CardData__TypeInfo;
		  if ((param1_00 != 0) &&
		     (iVar2 = func_ii_1082(param1_00,System_Action_CardData__CardData__TypeInfo), iVar2 == 0)) {
		    System_Activator__CreateInstance(param1_00,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar7 + 0x24) = iVar2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = *(int **)(iVar2 + 0x10);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x298);
		        goto code_r0x80f17dc8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x3b);
		code_r0x80f17dc8:
		  iVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		  iVar7 = **(int **)(iVar2 + 0x14);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x110) * 4))
		                    (*(int **)(iVar2 + 0x14),*(undefined4 *)(iVar7 + 0x114));
		  uVar4 = *(undefined4 *)(iVar7 + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_HandleEndlessOptionsListChangedEvent__
		             ,0);
		  piVar6 = (int *)func_ii_7048(uVar4,uVar3,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar6 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar6) ||
		          (*(int **)(iVar7 + 0x14) = piVar6, *piVar6 != iVar2)) {
		    System_Activator__CreateInstance(piVar6,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Utils_Timers_DelayedCall__DelayedCallAsync(param1[7],0);
		  Utils_Timers_DelayedCall__DelayedCallAsync(param1[8],0);
		  return;
		}
		*/

		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED7")]
		[Address(RVA = "0x703E", Offset = "0x703E", VA = "0x703E", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersController__HandleStop
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int param1_00;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a58646 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__add_UpdateEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_CardData__CardData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_Timers_DelayedCall_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_GetSpecialOffer__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_HandleEndlessOptionsListBuySuccessEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_HandleEndlessOptionsListChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_HandleEndlessOptionsListTimeOutEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_HandleExpiration__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_UserOnOnTriggerChangedEventHandler__
		              );
		    DAT_ram_00a58646 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(iVar2 + 8),0);
		  uVar4 = unnamed_function_1417
		                    (
		                    Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		                    );
		  Utils_Accumulators_AccumulatorBase___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___remove_UpdateEvent
		            (uVar4,param1,
		             Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_UserOnOnTriggerChangedEventHandler__
		             ,0);
		  UnityEngine_Events_InvokableCall_InputAction_CallbackContext___Invoke
		            (uVar3,uVar4,
		             Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__add_UpdateEvent__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = *(int **)(iVar2 + 0x10);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x298);
		        goto code_r0x80f17fdb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x3b);
		code_r0x80f17fdb:
		  iVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		  iVar7 = **(int **)(iVar2 + 0x14);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x110) * 4))
		                    (*(int **)(iVar2 + 0x14),*(undefined4 *)(iVar7 + 0x114));
		  uVar4 = *(undefined4 *)(iVar7 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_HandleEndlessOptionsListTimeOutEvent__
		             ,0);
		  piVar6 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar3,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar6 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 0x18) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar6) ||
		          (*(int **)(iVar7 + 0x18) = piVar6, *piVar6 != iVar2)) {
		    System_Activator__CreateInstance(piVar6,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar6 = *(int **)(iVar2 + 0x10);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x298);
		        goto code_r0x80f180f8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x3b);
		code_r0x80f180f8:
		  iVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		  iVar7 = **(int **)(iVar2 + 0x14);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x110) * 4))
		                    (*(int **)(iVar2 + 0x14),*(undefined4 *)(iVar7 + 0x114));
		  uVar4 = *(undefined4 *)(iVar7 + 0x24);
		  uVar3 = unnamed_function_1417(System_Action_CardData__CardData__TypeInfo);
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		            (uVar3,param1,
		             Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_HandleEndlessOptionsListBuySuccessEvent__
		             ,0);
		  iVar2 = 0;
		  param1_00 = UnityEngine_UI_Image__set_sprite(uVar4,uVar3,0);
		  uVar3 = System_Action_CardData__CardData__TypeInfo;
		  if ((param1_00 != 0) &&
		     (iVar2 = func_ii_1082(param1_00,System_Action_CardData__CardData__TypeInfo), iVar2 == 0)) {
		    System_Activator__CreateInstance(param1_00,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar7 + 0x24) = iVar2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = *(int **)(iVar2 + 0x10);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x298);
		        goto code_r0x80f181fe;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x3b);
		code_r0x80f181fe:
		  iVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		  iVar7 = **(int **)(iVar2 + 0x14);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x110) * 4))
		                    (*(int **)(iVar2 + 0x14),*(undefined4 *)(iVar7 + 0x114));
		  uVar4 = *(undefined4 *)(iVar7 + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_HandleEndlessOptionsListChangedEvent__
		             ,0);
		  piVar6 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar3,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar6 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 0x14) = 0;
		  }
		  else if ((*piVar6 != System_Action_TypeInfo) ||
		          (*(int **)(iVar7 + 0x14) = piVar6, *piVar6 != iVar2)) {
		    System_Activator__CreateInstance(piVar6,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar3 = unnamed_function_1417(iVar2);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_GetSpecialOffer__,0);
		  iVar2 = unnamed_function_1417(Utils_Timers_DelayedCall_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(iVar2,uVar3,0);
		  param1[7] = iVar2;
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_SpecialOffers_Controller_SpecialOffersController_HandleExpiration__,0);
		  iVar2 = unnamed_function_1417(Utils_Timers_DelayedCall_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(iVar2,uVar3,0);
		  param1[8] = iVar2;
		  Gameplay_SpecialOffers_Controller_SpecialOffersController___ctor(param1,uVar3);
		  return;
		}
		*/

		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED8")]
		[Address(RVA = "0x703F", Offset = "0x703F", VA = "0x703F", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED9")]
		[Address(RVA = "0x7040", Offset = "0x7040", VA = "0x7040")]
		private void UserOnOnTriggerChangedEventHandler(IEnumerable<TriggerValue> changes, AccumulatorBase<int, TriggerValue> accumulator)
		{
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EDA")]
		[Address(RVA = "0x7041", Offset = "0x7041", VA = "0x7041")]
		private void HandleEndlessOptionsListChangedEvent()
		{
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EDB")]
		[Address(RVA = "0x7042", Offset = "0x7042", VA = "0x7042")]
		private void HandleEndlessOptionsListTimeOutEvent()
		{
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EDC")]
		[Address(RVA = "0x7043", Offset = "0x7043", VA = "0x7043")]
		private void HandleEndlessOptionsListBuySuccessEvent(CardData a, CardData b)
		{
		/* --- GHIDRA: HandleEndlessOptionsListBuySuccessEvent ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersController__HandleEndlessOptionsListBuySuccessEvent
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58647 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SpecialOffers_Controller_SpecialOffersController___c_TypeInfo);
		    DAT_ram_00a58647 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_SpecialOffers_Controller_SpecialOffersController___c_TypeInfo);
		  **(undefined4 **)(Gameplay_SpecialOffers_Controller_SpecialOffersController___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040010B7 RID: 4279
		[Token(Token = "0x40010B7")]
		[FieldOffset(Offset = "0x18")]
		private ServicesService _service;

		// Token: 0x040010B8 RID: 4280
		[Token(Token = "0x40010B8")]
		[FieldOffset(Offset = "0x1C")]
		private DelayedCall _delayedRequest;

		// Token: 0x040010B9 RID: 4281
		[Token(Token = "0x40010B9")]
		[FieldOffset(Offset = "0x20")]
		private DelayedCall _delayedExpiration;
	}
}
