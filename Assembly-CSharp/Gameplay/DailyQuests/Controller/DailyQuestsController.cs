using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.DailyQuests.Events;
using Gameplay.DailyQuests.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.DailyQuests;
using ServicesNamespace;
using Utils;
using Utils.Accumulators;
using Utils.Timers;

namespace Gameplay.DailyQuests.Controller
{
	// Token: 0x02000888 RID: 2184
	[Token(Token = "0x2000888")]
	public class DailyQuestsController : AbstractController<DailyQuestsModel, DailyQuestEvents>, IDailyQuestProvider
	{
		// Token: 0x06003369 RID: 13161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003369")]
		[Address(RVA = "0x83A4", Offset = "0x83A4", VA = "0x83A4", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: <CheckQuestsForCompletion>b__29_0 ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController___CheckQuestsForCompletion_b__29_0
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57c7e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo);
		    DAT_ram_00a57c7e = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo);
		  **(undefined4 **)(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: Dispose ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  if (DAT_ram_00a57c67 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_DailyQuestsModel__DailyQuestEvents___ctor__);
		    DAT_ram_00a57c67 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param4,param5,
		             Method_MVC_AbstractController_DailyQuestsModel__DailyQuestEvents___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param2;
		  *(undefined4 *)(param1 + 0x1c) = param3;
		  return;
		}
		*/

		}

		// Token: 0x0600336A RID: 13162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600336A")]
		[Address(RVA = "0x83A5", Offset = "0x83A5", VA = "0x83A5")]
		public DailyQuestsController(QuestsTriggerObserver questsTriggerQuestsTriggerObserver, DailyQuestsService service, DailyQuestsModel model, DailyQuestEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *param2_00;
		  int *param1_00;
		  
		  if (DAT_ram_00a57c68 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController_HandleDictionariesChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_Controller_DailyQuestsController_RequestNewDailyQuests__
		              );
		    Mono_Security_ASN1__get_Item(&Utils_Timers_DelayedCall_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57c68 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestsController_RequestNewDailyQuests__,0)
		  ;
		  iVar3 = unnamed_function_1417(Utils_Timers_DelayedCall_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(iVar3,uVar2,0);
		  param1[9] = 0;
		  param1[8] = iVar3;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(int **)(iVar3 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestsController_HandleDictionariesChangedEvent__
		             ,0);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        param2_00 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e3d1a9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  param2_00 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,0);
		code_r0x80e3d1a9:
		  (**(code **)((ulonglong)*param2_00 * 4))(param1_00,uVar2,param2_00[1]);
		  Gameplay_DailyQuests_Controller_DailyQuestsController__RequestNewDailyQuests(param1,param2_00);
		  Gameplay_DailyQuests_Controller_DailyQuestsController__GetAllDailyQuestsServiceHandler
		            (param1,param2_00);
		  return;
		}
		*/

		}

		// Token: 0x0600336B RID: 13163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600336B")]
		[Address(RVA = "0x83A6", Offset = "0x83A6", VA = "0x83A6", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__HandleRun(int param1,undefined4 param2)
		
		{
		  Gameplay_DailyQuests_Controller_DailyQuestsController__HandleStop(param1,param1);
		  Utils_Timers_DelayedCall__DelayedCallAsync(*(undefined4 *)(param1 + 0x20),0);
		  return;
		}
		*/

		}

		// Token: 0x0600336C RID: 13164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600336C")]
		[Address(RVA = "0x83A7", Offset = "0x83A7", VA = "0x83A7", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__HandleStop
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  uint *puVar4;
		  int *param1_01;
		  
		  if (DAT_ram_00a57c69 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__remove_UpdateEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoDailyQuestsChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController_DailyQuestsChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController_HandleDictionariesChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController_TriggerChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57c69 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(iVar2 + 8),0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		                        );
		  Utils_Accumulators_AccumulatorBase___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___remove_UpdateEvent
		            (param1_00,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestsController_TriggerChangedEventHandler__
		             ,0);
		  UnityEngine_Events_InvokableCall_InputAction_CallbackContext___add_Delegate
		            (uVar3,param1_00,
		             Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__remove_UpdateEvent__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(int **)(iVar2 + 0xc);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestsController_HandleDictionariesChangedEvent__
		             ,0);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		        goto code_r0x80e3d421;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Dict_IDictProvider_TypeInfo,1);
		code_r0x80e3d421:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,puVar4[1]);
		  iVar2 = param1[7];
		  uVar3 = unnamed_function_1417(System_Action_ProtoDailyQuestsChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestsController_DailyQuestsChangedEventHandler__
		             ,0);
		  ServicesNamespace_DailyQuestsService__add_DailyQuestsChangedEvent(iVar2,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x0600336D RID: 13165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600336D")]
		[Address(RVA = "0x83A8", Offset = "0x83A8", VA = "0x83A8")]
		private void StopListen()
		{
		/* --- GHIDRA: StopListen ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__StopListen
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (param1[9] < 1) {
		    param1[9] = param1[9] + 1;
		    return;
		  }
		  if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    Gameplay_DailyQuests_Controller_DailyQuestsController__ValidateInit(param1,param1);
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

		// Token: 0x0600336E RID: 13166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600336E")]
		[Address(RVA = "0x83A9", Offset = "0x83A9", VA = "0x83A9")]
		private void ValidateInit()
		{
		/* --- GHIDRA: ValidateInit ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__ValidateInit
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57c6a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__add_UpdateEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoDailyQuestsChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController_DailyQuestsChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController_TriggerChangedEventHandler__
		              );
		    DAT_ram_00a57c6a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(iVar1 + 8),0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		                        );
		  Utils_Accumulators_AccumulatorBase___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___remove_UpdateEvent
		            (param1_00,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestsController_TriggerChangedEventHandler__
		             ,0);
		  UnityEngine_Events_InvokableCall_InputAction_CallbackContext___Invoke
		            (uVar2,param1_00,
		             Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__add_UpdateEvent__);
		  iVar1 = param1[7];
		  uVar2 = unnamed_function_1417(System_Action_ProtoDailyQuestsChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestsController_DailyQuestsChangedEventHandler__
		             ,0);
		  ServicesNamespace_DailyQuestsService__get_ServiceId(iVar1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600336F RID: 13167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600336F")]
		[Address(RVA = "0x83AA", Offset = "0x83AA", VA = "0x83AA")]
		private void StartListen()
		{
		/* --- GHIDRA: StartListen ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__StartListen
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_DailyQuests_Model_DailyQuestsModel__RemoveGoals(param1_00,param1);
		  Gameplay_DailyQuests_Controller_DailyQuestsController__RequestNewDailyQuests(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003370 RID: 13168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003370")]
		[Address(RVA = "0x83AB", Offset = "0x83AB", VA = "0x83AB")]
		private void DailyQuestsChangedEventHandler(ProtoDailyQuestsChangedEvt _)
		{
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003371")]
		[Address(RVA = "0x83AC", Offset = "0x83AC", VA = "0x83AC")]
		private void HandleDictionariesChangedEvent()
		{
		/* --- GHIDRA: HandleDictionariesChangedEvent ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__HandleDictionariesChangedEvent
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int param1_00;
		  undefined4 *puVar4;
		  
		  if (DAT_ram_00a57c6b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_DailyGoalDic__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_DailyQuestsDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_DailyQuestsDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_DailyGoalDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_DailyQuestsDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_DailyGoalDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController___c__TriggerChangedEventHandler_b__13_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController___c__TriggerChangedEventHandler_b__13_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo);
		    DAT_ram_00a57c6b = '\x01';
		  }
		  Gameplay_DailyQuests_Controller_DailyQuestsController__SetupBackTimeTimer(param1,param1);
		  iVar1 = Gameplay_DailyQuests_Controller_QuestsTriggerObserver___ctor
		                    (*(undefined4 *)(param1 + 0x18),param2,param1);
		  iVar3 = *(int *)(iVar1 + 8);
		  if (0 < *(int *)(iVar3 + 0x10)) {
		    if (*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo);
		    }
		    puVar4 = *(undefined4 **)
		              (Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x5c);
		    param1_00 = puVar4[1];
		    if (param1_00 == 0) {
		      if (*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x74) == 0)
		      {
		        func_ii_306000(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo);
		        puVar4 = *(undefined4 **)
		                  (Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x5c);
		      }
		      uVar2 = *puVar4;
		      param1_00 = unnamed_function_1417(System_Func_DailyQuestsDic__uint__TypeInfo);
		      System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                (param1_00,uVar2,
		                 Method_Gameplay_DailyQuests_Controller_DailyQuestsController___c__TriggerChangedEventHandler_b__13_0__
		                 ,0);
		      *(int *)(*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x5c) +
		              4) = param1_00;
		    }
		    uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                      (iVar3,param1_00,Method_System_Linq_Enumerable_Select_DailyQuestsDic__uint___)
		    ;
		    Gameplay_DailyQuests_Controller_DailyQuestsController__GetGoalsServiceHandler
		              (param1,uVar2,param1);
		  }
		  iVar1 = *(int *)(iVar1 + 0xc);
		  if (0 < *(int *)(iVar1 + 0x10)) {
		    if (*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo);
		    }
		    puVar4 = *(undefined4 **)
		              (Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x5c);
		    iVar3 = puVar4[2];
		    if (iVar3 == 0) {
		      if (*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x74) == 0)
		      {
		        func_ii_306000(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo);
		        puVar4 = *(undefined4 **)
		                  (Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x5c);
		      }
		      uVar2 = *puVar4;
		      iVar3 = unnamed_function_1417(System_Func_DailyGoalDic__uint__TypeInfo);
		      System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                (iVar3,uVar2,
		                 Method_Gameplay_DailyQuests_Controller_DailyQuestsController___c__TriggerChangedEventHandler_b__13_1__
		                 ,0);
		      *(int *)(*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x5c) +
		              8) = iVar3;
		    }
		    uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                      (iVar1,iVar3,Method_System_Linq_Enumerable_Select_DailyGoalDic__uint___);
		    Gameplay_DailyQuests_Controller_DailyQuestsController__TakeGoalRewardServiceHandler
		              (param1,uVar2,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003372 RID: 13170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003372")]
		[Address(RVA = "0x83AD", Offset = "0x83AD", VA = "0x83AD")]
		private void TriggerChangedEventHandler(IEnumerable<TriggerValue> changes, AccumulatorBase<int, TriggerValue> accumulator)
		{
		/* --- GHIDRA: TriggerChangedEventHandler ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__TriggerChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_DailyQuests_Model_DailyQuestsModel__RemoveGoals(param1_00,param1);
		  Gameplay_DailyQuests_Controller_DailyQuestsController__RequestNewDailyQuests(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003373 RID: 13171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003373")]
		[Address(RVA = "0x83AE", Offset = "0x83AE", VA = "0x83AE")]
		private void RequestNewDailyQuests()
		{
		/* --- GHIDRA: RequestNewDailyQuests ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__RequestNewDailyQuests
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57c6c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController_GetAllDailyQuestsServiceHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57c6c = '\x01';
		  }
		  uVar1 = ServicesNamespace_DailyQuestsService__GetQuests(*(undefined4 *)(param1 + 0x1c),1,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestsController_GetAllDailyQuestsServiceHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003374 RID: 13172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003374")]
		[Address(RVA = "0x83AF", Offset = "0x83AF", VA = "0x83AF")]
		private void RequestAllDailyQuests()
		{
		/* --- GHIDRA: RequestAllDailyQuests ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__RequestAllDailyQuests
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *param1_00;
		  int param1_01;
		  undefined4 *puVar3;
		  undefined4 param2_00;
		  byte local_1;
		  
		  if (DAT_ram_00a57c6d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_IDailyQuest__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_IDailyQuest__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDailyQuest__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_DailyQuests_ProtoGetQuestsAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController___c__GetAllDailyQuestsServiceHandler_b__16_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo);
		    DAT_ram_00a57c6d = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  iVar2 = param1[6];
		  if (DAT_ram_00a57c9d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Clear__);
		    DAT_ram_00a57c9d = '\x01';
		  }
		  System_Collections_Generic_HashSet___Il2CppFullySharedGenericType___AreEqualityComparersEqual
		            (*(undefined4 *)(iVar2 + 0x14),Method_System_Collections_Generic_HashSet_uint__Clear__);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_DailyQuests_ProtoGetQuestsAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_DailyQuests_ProtoGetQuestsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_DailyQuests_Model_DailyQuestsModel__PopulateGoals(uVar1,param1_00[3],param1);
		  local_1 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_DailyQuests_Controller_DailyQuestsController__CheckQuestsForCompletion
		            (param1,*(undefined4 *)(iVar2 + 0x14),&local_1,param1);
		  if (local_1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x18);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x14);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(*(int *)(iVar2 + 0x14) + 0xc) != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = Gameplay_DailyQuests_Model_DailyQuestsModel__GetQuestsByCategory(uVar1,param1);
		    Gameplay_DailyQuests_Controller_DailyQuestsController__GetApproximateProgress
		              (param1,uVar1,param1);
		  }
		  param1_01 = param1[6];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = *(undefined4 *)(iVar2 + 0x14);
		  if (*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)
		            (Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x5c);
		  iVar2 = puVar3[3];
		  if (iVar2 == 0) {
		    if (*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar3;
		    iVar2 = unnamed_function_1417(System_Func_IDailyQuest__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar2,param2_00,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController___c__GetAllDailyQuestsServiceHandler_b__16_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x5c) +
		            0xc) = iVar2;
		  }
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar1,iVar2,Method_System_Linq_Enumerable_Select_IDailyQuest__uint___);
		  Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c__DisplayClass9_0___HandleSetupView_b__0
		            (param1_01,uVar1,param1);
		  if (param1[9] < 1) {
		    param1[9] = param1[9] + 1;
		  }
		  else if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    Gameplay_DailyQuests_Controller_DailyQuestsController__ValidateInit(param1,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 8);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003375 RID: 13173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003375")]
		[Address(RVA = "0x83B0", Offset = "0x83B0", VA = "0x83B0")]
		private void GetAllDailyQuestsServiceHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetAllDailyQuestsServiceHandler ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__GetAllDailyQuestsServiceHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57c6e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController_GetAllGoalsServiceHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57c6e = '\x01';
		  }
		  uVar1 = ServicesNamespace_DailyQuestsService__GetQuests(*(undefined4 *)(param1 + 0x1c),2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestsController_GetAllGoalsServiceHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003376 RID: 13174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003376")]
		[Address(RVA = "0x83B1", Offset = "0x83B1", VA = "0x83B1")]
		private void RequestAllGoals()
		{
		/* --- GHIDRA: RequestAllGoals ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__RequestAllGoals
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *param1_00;
		  int param1_01;
		  undefined4 *puVar3;
		  undefined4 param2_00;
		  byte local_1;
		  
		  if (DAT_ram_00a57c6f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_IGoal__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_IGoal__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_DailyQuests_ProtoGetQuestsAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController___c__GetAllGoalsServiceHandler_b__18_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo);
		    DAT_ram_00a57c6f = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_DailyQuests_ProtoGetQuestsAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_DailyQuests_ProtoGetQuestsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_DailyQuests_Model_DailyQuestsModel__ResetDailyQuestsCategories(uVar1,param1_00[3],param1)
		  ;
		  local_1 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_DailyQuests_Controller_DailyQuestsController__CheckQuestsForCompletion
		            (param1,*(undefined4 *)(iVar2 + 0x18),&local_1,param1);
		  if (local_1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x18);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x14);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  param1_01 = param1[6];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = *(undefined4 *)(iVar2 + 0x18);
		  if (*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)
		            (Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x5c);
		  iVar2 = puVar3[4];
		  if (iVar2 == 0) {
		    if (*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar3;
		    iVar2 = unnamed_function_1417(System_Func_IGoal__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar2,param2_00,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController___c__GetAllGoalsServiceHandler_b__18_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x5c) +
		            0x10) = iVar2;
		  }
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar1,iVar2,Method_System_Linq_Enumerable_Select_IGoal__uint___);
		  Gameplay_DailyQuests_Controller_QuestsTriggerObserver__AddDailyQuestsToBlackList
		            (param1_01,uVar1,param1);
		  if (param1[9] < 1) {
		    param1[9] = param1[9] + 1;
		  }
		  else if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    Gameplay_DailyQuests_Controller_DailyQuestsController__ValidateInit(param1,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 8);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003377 RID: 13175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003377")]
		[Address(RVA = "0x83B2", Offset = "0x83B2", VA = "0x83B2")]
		private void GetAllGoalsServiceHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetAllGoalsServiceHandler ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__GetAllGoalsServiceHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57c70 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController_TakeDailyQuestRewardServiceHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a57c70 = '\x01';
		  }
		  uVar1 = ServicesNamespace_DailyQuestsService__GetQuests(*(undefined4 *)(param1 + 0x1c),param2,0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestsController_TakeDailyQuestRewardServiceHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_4 = param2;
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,uVar2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003378 RID: 13176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003378")]
		[Address(RVA = "0x83B3", Offset = "0x83B3", VA = "0x83B3")]
		public void TakeDailyQuestReward(uint questId)
		{
		/* --- GHIDRA: TakeDailyQuestReward ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__TakeDailyQuestReward
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int iVar6;
		  int *piVar7;
		  int *piVar8;
		  undefined4 uVar9;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a57c71 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_DailyQuestScope_DailyQuestEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedDailyQuestsErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    DAT_ram_00a57c71 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar7 = *(int **)(param2 + 0xc);
		  if (piVar7 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*piVar7 + 0x20) != *(int *)(DAT_ram_00a66958 + 0x20)) {
		    System_Activator__CreateInstance(piVar7,DAT_ram_00a66958);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar8 = *(int **)(param2 + 0x20);
		  puVar2 = (undefined4 *)func_ii_15774(piVar7);
		  uVar9 = *puVar2;
		  if ((piVar8 != (int *)0x0) && (Protocol_Common_ProtoDefaultAns_TypeInfo != *piVar8)) {
		    System_Activator__CreateInstance(piVar8,Protocol_Common_ProtoDefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar3 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (piVar8[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedDailyQuestsErrors___
		                    );
		  if (iVar3 == 0) {
		    iVar3 = *param1;
		    uVar4 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x100) * 4))
		                      (param1,*(undefined4 *)(iVar3 + 0x104));
		    piVar7 = (int *)Gameplay_DailyQuests_Model_DailyQuestsModel__AddGoals(uVar4,uVar9,iVar3);
		    uVar1 = 0;
		    iVar3 = *piVar7;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xf8);
		          goto code_r0x80e3faf4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar7,Gameplay_DailyQuests_Model_IQuest_TypeInfo,7);
		code_r0x80e3faf4:
		    (**(code **)((ulonglong)*puVar5 * 4))(piVar7,1,puVar5[1]);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x1c);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x20);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x18);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    piVar8 = *(int **)(iVar3 + 0x10);
		    iVar3 = *piVar8;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		          goto code_r0x80e3fc1b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80e3fc1b:
		    piVar8 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		    uVar1 = 0;
		    iVar3 = *piVar8;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x100);
		          goto code_r0x80e3fc9d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar8,Core_Application_IApp_TypeInfo,8);
		code_r0x80e3fc9d:
		    iVar3 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		    iVar3 = *(int *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x5c) + 8);
		    if (iVar3 != 0) {
		      iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar1 = 0;
		      piVar8 = *(int **)(iVar6 + 0x10);
		      iVar6 = *piVar8;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		            goto code_r0x80e3fd42;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80e3fd42:
		      uVar9 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		      iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param3_00 = *(undefined4 *)(iVar6 + 0x10);
		      uVar4 = unnamed_function_1417(Core_Events_Scopes_DailyQuestScope_DailyQuestEventArgs_TypeInfo)
		      ;
		      Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(uVar4,uVar9,param3_00,piVar7,0);
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),uVar4,*(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003379 RID: 13177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003379")]
		[Address(RVA = "0x83B4", Offset = "0x83B4", VA = "0x83B4")]
		private void TakeDailyQuestRewardServiceHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: TakeDailyQuestRewardServiceHandler ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__TakeDailyQuestRewardServiceHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57c72 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController_TakeGoalRewardServiceHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57c72 = '\x01';
		  }
		  uVar1 = ServicesNamespace_DailyQuestsService__TakeDailyQuestReward
		                    (*(undefined4 *)(param1 + 0x1c),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestsController_TakeGoalRewardServiceHandler__
		             ,0);
		  local_4 = param2;
		  param3_00 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,param3_00,
		                     Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600337A RID: 13178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600337A")]
		[Address(RVA = "0x83B5", Offset = "0x83B5", VA = "0x83B5")]
		public void TakeGoalReward(uint goalId)
		{
		/* --- GHIDRA: TakeGoalReward ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__TakeGoalReward
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int iVar6;
		  int *piVar7;
		  int *piVar8;
		  undefined4 uVar9;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a57c73 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedDailyQuestsErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_GoalsScope_GoalEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    DAT_ram_00a57c73 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar7 = *(int **)(param2 + 0xc);
		  if (piVar7 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*piVar7 + 0x20) != *(int *)(DAT_ram_00a66958 + 0x20)) {
		    System_Activator__CreateInstance(piVar7,DAT_ram_00a66958);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar8 = *(int **)(param2 + 0x20);
		  puVar2 = (undefined4 *)func_ii_15774(piVar7);
		  uVar9 = *puVar2;
		  if ((piVar8 != (int *)0x0) && (Protocol_Common_ProtoDefaultAns_TypeInfo != *piVar8)) {
		    System_Activator__CreateInstance(piVar8,Protocol_Common_ProtoDefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar3 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (piVar8[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedDailyQuestsErrors___
		                    );
		  if (iVar3 == 0) {
		    iVar3 = *param1;
		    uVar4 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x100) * 4))
		                      (param1,*(undefined4 *)(iVar3 + 0x104));
		    piVar7 = (int *)Gameplay_DailyQuests_Model_DailyQuestsModel__GetQuest(uVar4,uVar9,iVar3);
		    uVar1 = 0;
		    iVar3 = *piVar7;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xf8);
		          goto code_r0x80e3ff09;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar7,Gameplay_DailyQuests_Model_IQuest_TypeInfo,7);
		code_r0x80e3ff09:
		    (**(code **)((ulonglong)*puVar5 * 4))(piVar7,1,puVar5[1]);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x1c);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x20);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x18);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    piVar8 = *(int **)(iVar3 + 0x10);
		    iVar3 = *piVar8;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		          goto code_r0x80e40030;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80e40030:
		    piVar8 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		    uVar1 = 0;
		    iVar3 = *piVar8;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x100);
		          goto code_r0x80e400b2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar8,Core_Application_IApp_TypeInfo,8);
		code_r0x80e400b2:
		    iVar3 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		    iVar3 = *(int *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 8);
		    if (iVar3 != 0) {
		      iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar1 = 0;
		      piVar8 = *(int **)(iVar6 + 0x10);
		      iVar6 = *piVar8;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		            goto code_r0x80e40157;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80e40157:
		      uVar9 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		      iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param3_00 = *(undefined4 *)(iVar6 + 0x10);
		      uVar4 = unnamed_function_1417(Core_Events_Scopes_GoalsScope_GoalEventArgs_TypeInfo);
		      Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(uVar4,uVar9,param3_00,piVar7,0);
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),uVar4,*(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600337B RID: 13179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600337B")]
		[Address(RVA = "0x83B6", Offset = "0x83B6", VA = "0x83B6")]
		private void TakeGoalRewardServiceHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: TakeGoalRewardServiceHandler ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__TakeGoalRewardServiceHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57c74 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController_GetGoalsServiceHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57c74 = '\x01';
		  }
		  uVar1 = ServicesNamespace_DailyQuestsService__ServerEventHandler
		                    (*(undefined4 *)(param1 + 0x1c),2,param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestsController_GetGoalsServiceHandler__,0
		            );
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600337C RID: 13180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600337C")]
		[Address(RVA = "0x83B7", Offset = "0x83B7", VA = "0x83B7")]
		private void GetGoals(IEnumerable<uint> goalIds)
		{
		/* --- GHIDRA: GetGoals ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__GetGoals
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  int iVar3;
		  int param1_01;
		  undefined4 *puVar4;
		  int param1_02;
		  byte local_1;
		  
		  if (DAT_ram_00a57c75 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_ProtoGetQuestsAns_Types_UserQuest__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_ProtoGetQuestsAns_Types_UserQuest__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_DailyQuests_ProtoGetQuestsAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController___c__GetGoalsServiceHandler_b__24_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo);
		    DAT_ram_00a57c75 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_DailyQuests_ProtoGetQuestsAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_DailyQuests_ProtoGetQuestsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = Gameplay_DailyQuests_Model_DailyQuestsModel__AddDailyQuests(uVar1,param1_00[3],param1);
		  iVar3 = param1_00[3];
		  param1_01 = param1[6];
		  if (*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)
		            (Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x5c);
		  param1_02 = puVar4[5];
		  if (param1_02 == 0) {
		    if (*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo);
		      puVar4 = *(undefined4 **)
		                (Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar4;
		    param1_02 = unnamed_function_1417(System_Func_ProtoGetQuestsAns_Types_UserQuest__uint__TypeInfo)
		    ;
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_02,uVar2,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController___c__GetGoalsServiceHandler_b__24_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x5c) +
		            0x14) = param1_02;
		  }
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (iVar3,param1_02,
		                     Method_System_Linq_Enumerable_Select_ProtoGetQuestsAns_Types_UserQuest__uint___
		                    );
		  Gameplay_DailyQuests_Controller_QuestsTriggerObserver__AddDailyQuestsToBlackList
		            (param1_01,uVar2,param1);
		  local_1 = 0;
		  Gameplay_DailyQuests_Controller_DailyQuestsController__CheckQuestsForCompletion
		            (param1,uVar1,&local_1,param1);
		  if (local_1 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x18);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar3 = *(int *)(iVar3 + 0x14);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600337D RID: 13181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600337D")]
		[Address(RVA = "0x83B8", Offset = "0x83B8", VA = "0x83B8")]
		private void GetGoalsServiceHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetGoalsServiceHandler ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__GetGoalsServiceHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57c76 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController_GetDailyQuestsServiceHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57c76 = '\x01';
		  }
		  uVar1 = ServicesNamespace_DailyQuestsService__ServerEventHandler
		                    (*(undefined4 *)(param1 + 0x1c),1,param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestsController_GetDailyQuestsServiceHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600337E RID: 13182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600337E")]
		[Address(RVA = "0x83B9", Offset = "0x83B9", VA = "0x83B9")]
		private void GetDailyQuests(IEnumerable<uint> goalIds)
		{
		/* --- GHIDRA: GetDailyQuests ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__GetDailyQuests
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  int iVar3;
		  int param1_01;
		  undefined4 *puVar4;
		  int param1_02;
		  byte local_1;
		  
		  if (DAT_ram_00a57c77 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_ProtoGetQuestsAns_Types_UserQuest__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_ProtoGetQuestsAns_Types_UserQuest__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDailyQuest__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_DailyQuests_ProtoGetQuestsAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController___c__GetDailyQuestsServiceHandler_b__26_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo);
		    DAT_ram_00a57c77 = '\x01';
		  }
		  local_1 = 0;
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_DailyQuests_ProtoGetQuestsAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_DailyQuests_ProtoGetQuestsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = Gameplay_DailyQuests_Model_DailyQuestsModel__PopulateDailyQuests
		                    (uVar1,param1_00[3],param1);
		  iVar3 = param1_00[3];
		  param1_01 = param1[6];
		  if (*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)
		            (Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x5c);
		  param1_02 = puVar4[6];
		  if (param1_02 == 0) {
		    if (*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo);
		      puVar4 = *(undefined4 **)
		                (Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar4;
		    param1_02 = unnamed_function_1417(System_Func_ProtoGetQuestsAns_Types_UserQuest__uint__TypeInfo)
		    ;
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_02,uVar2,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController___c__GetDailyQuestsServiceHandler_b__26_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsController___c_TypeInfo + 0x5c) +
		            0x18) = param1_02;
		  }
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (iVar3,param1_02,
		                     Method_System_Linq_Enumerable_Select_ProtoGetQuestsAns_Types_UserQuest__uint___
		                    );
		  Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c__DisplayClass9_0___HandleSetupView_b__0
		            (param1_01,uVar2,param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(*(int *)(iVar3 + 0x14) + 0xc) != 0) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar2 = Gameplay_DailyQuests_Model_DailyQuestsModel__GetQuestsByCategory(uVar2,param1);
		    Gameplay_DailyQuests_Controller_DailyQuestsController__GetApproximateProgress
		              (param1,uVar2,param1);
		  }
		  local_1 = 0;
		  Gameplay_DailyQuests_Controller_DailyQuestsController__CheckQuestsForCompletion
		            (param1,uVar1,&local_1,param1);
		  if (local_1 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x18);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar3 = *(int *)(iVar3 + 0x14);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600337F RID: 13183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600337F")]
		[Address(RVA = "0x83BA", Offset = "0x83BA", VA = "0x83BA")]
		private void GetDailyQuestsServiceHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetDailyQuestsServiceHandler ---
		float Gameplay_DailyQuests_Controller_DailyQuestsController__GetDailyQuestsServiceHandler
		                (int *param1,int *param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  int *piVar5;
		  float fVar6;
		  longlong lVar7;
		  longlong lVar8;
		  longlong lVar9;
		  int *piVar10;
		  int iVar11;
		  int iVar12;
		  uint uVar13;
		  int local_10;
		  int **local_c;
		  int local_8;
		  int *local_4;
		  
		  lVar8 = 0;
		  lVar9 = 0;
		  fVar6 = 0.0;
		  if (DAT_ram_00a57c78 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_RestrictionInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RestrictionInfo__GetEnumerator__);
		    DAT_ram_00a57c78 = '\x01';
		  }
		  local_8 = 0;
		  iVar12 = *param2;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    uVar13 = 0;
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		          *(int *)(*(int *)(iVar12 + 0x58) + uVar13 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar13 * 8 + 4) * 8 + iVar12 + 0x138);
		        goto code_r0x80e4069a;
		      }
		      uVar13 = uVar13 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar13);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,Gameplay_DailyQuests_Model_IQuest_TypeInfo,0xf);
		code_r0x80e4069a:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (uVar2,
		                              Method_Google_Protobuf_Collections_RepeatedField_RestrictionInfo__GetEnumerator__
		                             );
		  local_10 = 0;
		  local_c = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar12 = *local_4;
		    if (*(ushort *)(iVar12 + 0xb6) != 0) {
		      uVar13 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar12 + 0x58) + uVar13 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		          puVar3 = (undefined4 *)(iVar12 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x80e40771;
		        }
		        uVar13 = uVar13 + 1;
		      } while (*(ushort *)(iVar12 + 0xb6) != uVar13);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e40adf:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e40ae7;
		    }
		code_r0x80e40771:
		    DAT_ram_009d3e38 = 0;
		    iVar12 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e40adf;
		    if (iVar12 == 0) {
		      iVar4 = 6;
		      iVar12 = 0;
		      goto code_r0x80e40b34;
		    }
		    iVar12 = *local_4;
		    if (*(ushort *)(iVar12 + 0xb6) != 0) {
		      uVar13 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar12 + 0x58) + uVar13 * 8);
		        if (System_Collections_Generic_IEnumerator_RestrictionInfo__TypeInfo == *piVar10) {
		          puVar3 = (undefined4 *)(iVar12 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x80e4085b;
		        }
		        uVar13 = uVar13 + 1;
		      } while (*(ushort *)(iVar12 + 0xb6) != uVar13);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_RestrictionInfo__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e40a77:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e40ae7;
		    }
		code_r0x80e4085b:
		    DAT_ram_009d3e38 = 0;
		    iVar12 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e40a77;
		    DAT_ram_009d3e38 = 0;
		    iVar11 = import::env::invoke_iii
		                       (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e40ae7;
		    }
		    piVar5 = *(int **)(iVar11 + 0x10);
		    iVar4 = *piVar5;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar13 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar4 + 0x58) + uVar13 * 8);
		        if (Core_Gameplay_IGame_TypeInfo == *piVar10) {
		          puVar3 = (undefined4 *)(piVar10[1] * 8 + iVar4 + 0x140);
		          goto code_r0x80e40975;
		        }
		        uVar13 = uVar13 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar13);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Core_Gameplay_IGame_TypeInfo,0x10);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e40a8b:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e40ae7;
		    }
		code_r0x80e40975:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e40a8b;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = func_ii_7112(uVar2,0);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e40ae7;
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x43,uVar2,0);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e40ae7;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiiii
		              (*(undefined4 *)(*piVar5 + 0x100),piVar5,*(undefined4 *)(iVar12 + 0xc),&local_8,
		               *(undefined4 *)(*piVar5 + 0x104));
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) break;
		    if (local_8 == 0) {
		      lVar7 = 0;
		    }
		    else {
		      lVar7 = *(longlong *)(local_8 + 0x10);
		    }
		    lVar8 = lVar8 + *(longlong *)(iVar12 + 0x10);
		    lVar9 = lVar9 + lVar7;
		  } while( true );
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e40ae7:
		  iVar12 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar12 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar12 = *piVar5;
		    iVar4 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_10 = iVar12;
		    import::env::invoke_v(0x123);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 != 1) {
		code_r0x80e40b34:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar13 = 0;
		        iVar11 = *local_4;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar13 * 8)) {
		              puVar1 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar13 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x80e40bac;
		            }
		            uVar13 = uVar13 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar13);
		        }
		        puVar1 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e40bac:
		        (**(code **)((ulonglong)*puVar1 * 4))(piVar5,puVar1[1]);
		      }
		      if (iVar12 == 0) {
		        if (((iVar4 == 0) ||
		            ((((iVar4 != 1 && (iVar4 != 2)) && (iVar4 != 3)) &&
		             (((iVar4 != 4 && (iVar4 != 5)) && (iVar4 == 6)))))) && (0 < lVar8)) {
		          fVar6 = (float)lVar9 / (float)lVar8;
		        }
		        return fVar6;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar12);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x44,&local_10);
		  iVar12 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar12 != 1) {
		    import::env::__resumeException(uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003380 RID: 13184 RVA: 0x0000A740 File Offset: 0x00008940
		[Token(Token = "0x6003380")]
		[Address(RVA = "0x83BB", Offset = "0x83BB", VA = "0x83BB")]
		private float GetApproximateProgress(IQuest dailyQuestData)
		{
		/* --- GHIDRA: GetApproximateProgress ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__GetApproximateProgress
		               (int param1,int param2,undefined4 param3)
		
		{
		  float fVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57c79 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6257);
		    DAT_ram_00a57c79 = '\x01';
		  }
		  if ((param2 != 0) && (fVar1 = func_ii_7103(param2,0), fVar1 != 0.0)) {
		    param1_00 = *(undefined4 *)(param1 + 0x20);
		    fVar1 = func_ii_7103(param2,0);
		    Utils_Timers_DelayedCall___ctor(param1_00,fVar1,0);
		    return;
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  func_ii_7830(StringLiteral_6257,0);
		  return;
		}
		*/

			return 0f;
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003381")]
		[Address(RVA = "0x83BC", Offset = "0x83BC", VA = "0x83BC")]
		private void SetupBackTimeTimer(BackTime backTime)
		{
		/* --- GHIDRA: SetupBackTimeTimer ---
		void Gameplay_DailyQuests_Controller_DailyQuestsController__SetupBackTimeTimer
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  byte local_1;
		  
		  if (DAT_ram_00a57c7a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsController__CheckQuestsForCompletion_b__29_0__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_IGoal___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_IGoal___);
		    Mono_Security_ASN1__get_Item(&System_Func_IGoal__bool__TypeInfo);
		    DAT_ram_00a57c7a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(undefined4 *)(iVar1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Func_IGoal__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestsController__CheckQuestsForCompletion_b__29_0__
		             ,0);
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (param1_00,uVar2,Method_System_Linq_Enumerable_Where_IGoal___);
		  iVar1 = func_ii_6295(uVar2,Method_System_Linq_Enumerable_ToArray_IGoal___);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_DailyQuests_Model_DailyQuestsModel__CreateGoal(uVar2,iVar1,param1);
		  local_1 = *(int *)(iVar1 + 0xc) != 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_DailyQuests_Controller_DailyQuestsController__CheckQuestsForCompletion
		            (param1,*(undefined4 *)(iVar1 + 0x14),&local_1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_DailyQuests_Controller_DailyQuestsController__CheckQuestsForCompletion
		            (param1,*(undefined4 *)(iVar1 + 0x18),&local_1,param1);
		  if (local_1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x18);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003382 RID: 13186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003382")]
		[Address(RVA = "0x83BD", Offset = "0x83BD", VA = "0x83BD")]
		private void CheckQuestsForCompletion()
		{
		/* --- GHIDRA: CheckQuestsForCompletion ---
		undefined4
		Gameplay_DailyQuests_Controller_DailyQuestsController__CheckQuestsForCompletion
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = Gameplay_DailyQuests_Model_DailyQuestsModel__AddGoals(uVar1,param2,param1);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: CheckQuestsForCompletion ---
		undefined4
		Gameplay_DailyQuests_Controller_DailyQuestsController__CheckQuestsForCompletion
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = Gameplay_DailyQuests_Model_DailyQuestsModel__AddGoals(uVar1,param2,param1);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06003383 RID: 13187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003383")]
		[Address(RVA = "0x83BE", Offset = "0x83BE", VA = "0x83BE")]
		private void CheckQuestsForCompletion(IEnumerable<IQuest> quests, ref bool activeCountChanged)
		{
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003384")]
		[Address(RVA = "0x83BF", Offset = "0x83BF", VA = "0x83BF", Slot = "12")]
		public IDailyQuest GetQuest(uint id)
		{
		/* --- GHIDRA: GetQuest ---
		uint Gameplay_DailyQuests_Controller_DailyQuestsController__GetQuest
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57c7c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IGoal_TypeInfo);
		    DAT_ram_00a57c7c = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(int **)(iVar2 + 0x10);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x160);
		        goto code_r0x80e40d0b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x80e40d0b:
		  uVar1 = 0;
		  param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  iVar2 = *param2;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Gameplay_DailyQuests_Model_IGoal_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		        goto code_r0x80e40d8f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Gameplay_DailyQuests_Model_IGoal_TypeInfo,1);
		code_r0x80e40d8f:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  param2_00 = *(undefined4 *)(iVar2 + 0x20);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = Core_Gameplay_Managers_Requirements_RequirementsManager__CheckRestriction
		                    (param1_00,param2_00,*(undefined4 *)(iVar2 + 8),0);
		  return uVar1 ^ 1;
		}
		*/

			return null;
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x0000A770 File Offset: 0x00008970
		[Token(Token = "0x6003386")]
		[Address(RVA = "0x1BC4", Offset = "0x1BC4", VA = "0x1BC4")]
		[CompilerGenerated]
		private bool <CheckQuestsForCompletion>g__RecalculateProgress|30_0(IQuest quest)
		{
			return default(bool);
		}

		// Token: 0x04001C0C RID: 7180
		[Token(Token = "0x4001C0C")]
		[FieldOffset(Offset = "0x18")]
		private readonly QuestsTriggerObserver _questsTriggerObserver;

		// Token: 0x04001C0D RID: 7181
		[Token(Token = "0x4001C0D")]
		[FieldOffset(Offset = "0x1C")]
		private readonly DailyQuestsService _dailyQuestsService;

		// Token: 0x04001C0E RID: 7182
		[Token(Token = "0x4001C0E")]
		[FieldOffset(Offset = "0x20")]
		private DelayedCall _delayedCall;

		// Token: 0x04001C0F RID: 7183
		[Token(Token = "0x4001C0F")]
		[FieldOffset(Offset = "0x24")]
		private int _initialRequestCount;
	}
}
