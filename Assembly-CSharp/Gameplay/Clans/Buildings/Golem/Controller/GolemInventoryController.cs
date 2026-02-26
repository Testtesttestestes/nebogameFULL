using System;
using Core.Data;
using Gameplay.Clans.Buildings.Golem.Events;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Inventory.Controller;
using Gameplay.Inventory.Controller.Middlewares;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Gameplay.Clans.Buildings.Golem.Controller
{
	// Token: 0x02000ADF RID: 2783
	[Token(Token = "0x2000ADF")]
	public class GolemInventoryController : InventoryBaseController<GolemInventoryModel, GolemInventoryEvents>
	{
		// Token: 0x0600430C RID: 17164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600430C")]
		[Address(RVA = "0x91C0", Offset = "0x91C0", VA = "0x91C0")]
		public GolemInventoryController(GolemInventoryModel model, GolemInventoryEvents events, InventoryActionsMiddlewareBase<GolemInventoryModel> middlewareActions, ClansService clanService, ServicesService servicesService, CraftService craftService)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController___ctor
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined8 param2_00;
		  int param1_01;
		  
		  if (DAT_ram_00a57a9e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController_GetGolemArtifactsResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57a9e = '\x01';
		  }
		  param1_01 = param1[9];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x58),0);
		  uVar2 = ServicesNamespace_ClansService__RepayCreditDebt(param1_01,param2_00,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController_GetGolemArtifactsResultHandler__
		             ,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600430D RID: 17165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600430D")]
		[Address(RVA = "0x91C1", Offset = "0x91C1", VA = "0x91C1")]
		private void RequestGolemArtifacts()
		{
		/* --- GHIDRA: RequestGolemArtifacts ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController__RequestGolemArtifacts
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined8 uVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int iVar3;
		  int *param1_01;
		  
		  if (DAT_ram_00a57a9f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    DAT_ram_00a57a9f = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Main_ProtoStackableChangesAns_TypeInfo != *param1_01))
		  {
		    System_Activator__CreateInstance(param1_01,Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = 0x7fffffff;
		  param2_00 = Gameplay_Inventory_Model_InventoryUtils__FillEmptySlots
		                        (param1_01[4],0x7fffffffffffffff,0);
		  uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  Gameplay_Inventory_Model_InventoryBaseModel__ParseSlotChanges(param1_00,param2_00,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x114)));
		  iVar3 = *(int *)(iVar3 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		            (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x0600430E RID: 17166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600430E")]
		[Address(RVA = "0x91C2", Offset = "0x91C2", VA = "0x91C2")]
		private void GetGolemArtifactsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetGolemArtifactsResultHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController__GetGolemArtifactsResultHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57aa0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoStackableChangesAns__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController_GolemSlotsChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__HandleRun__
		              );
		    DAT_ram_00a57aa0 = '\x01';
		  }
		  Gameplay_Inventory_Controller_InventoryBaseController_object__object___Equip
		            (param1,
		             Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__HandleRun__
		            );
		  param1_01 = *(undefined4 *)(param1 + 0x24);
		  param1_00 = unnamed_function_1417(System_Action_ProtoStackableChangesAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController_GolemSlotsChangedEventHandler__
		             ,0);
		  ServicesNamespace_ClansService__get_ServiceId(param1_01,param1_00,0);
		  Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController___ctor(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600430F RID: 17167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600430F")]
		[Address(RVA = "0x91C3", Offset = "0x91C3", VA = "0x91C3", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController__HandleRun
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57aa1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoStackableChangesAns__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController_GolemSlotsChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__HandleStop__
		              );
		    DAT_ram_00a57aa1 = '\x01';
		  }
		  Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleRun
		            (param1,
		             Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__HandleStop__
		            );
		  param1_01 = *(undefined4 *)(param1 + 0x24);
		  param1_00 = unnamed_function_1417(System_Action_ProtoStackableChangesAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController_GolemSlotsChangedEventHandler__
		             ,0);
		  ServicesNamespace_ClansService__add_GolemSlotsChangedEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004310 RID: 17168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004310")]
		[Address(RVA = "0x91C4", Offset = "0x91C4", VA = "0x91C4", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController__HandleStop
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57aa2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__ParseSlotChanges__
		              );
		    DAT_ram_00a57aa2 = '\x01';
		  }
		  Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		            (param1,*(undefined4 *)(param2 + 0x10),
		             Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__ParseSlotChanges__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004311 RID: 17169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004311")]
		[Address(RVA = "0x91C5", Offset = "0x91C5", VA = "0x91C5")]
		private void GolemSlotsChangedEventHandler(ProtoStackableChangesAns evt)
		{
		/* --- GHIDRA: GolemSlotsChangedEventHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController__GolemSlotsChangedEventHandler
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57aa3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController_SwapSlotsSuccessHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57aa3 = '\x01';
		  }
		  param1_00 = ServicesNamespace_ClansService__GetGolemArtifacts
		                        (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param2 + 0x7c),param3,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController_SwapSlotsSuccessHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06004312 RID: 17170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004312")]
		[Address(RVA = "0x91C6", Offset = "0x91C6", VA = "0x91C6", Slot = "16")]
		public override void RequestMoveItemTo(ArtifactData artifact, int slotId)
		{
		/* --- GHIDRA: RequestMoveItemTo ---
		undefined4
		Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController__RequestMoveItemTo
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57aa4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController_BuySlotHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_uint__ResourceSet___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Tuple_uint__ResourceSet__TypeInfo);
		    DAT_ram_00a57aa4 = '\x01';
		  }
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x118) * 4))
		                    (piVar1,param2,*(undefined4 *)(*piVar1 + 0x11c));
		  param1_00 = unnamed_function_1417(System_Tuple_uint__ResourceSet__TypeInfo);
		  UnityEngine_Purchasing_Default_Factory__Create
		            (param1_00,param2,uVar2,Method_System_Tuple_uint__ResourceSet___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  uVar2 = ServicesNamespace_ServicesService__GetAssistantsStatus(uVar2,param2,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController_BuySlotHandler__
		             ,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  uVar2 = DG_Tweening_TweenParams__SetId
		                    (uVar2,param1_00,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  return uVar2;
		}
		*/

		}

		// Token: 0x06004313 RID: 17171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004313")]
		[Address(RVA = "0x91C7", Offset = "0x91C7", VA = "0x91C7", Slot = "17")]
		public override OpToken<IMessage, object> BuySlots(uint quantity)
		{
		/* --- GHIDRA: BuySlots ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController__BuySlots
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  int iVar3;
		  int param2_00;
		  undefined4 uVar4;
		  undefined4 param3_00;
		  int *param1_00;
		  int *param1_01;
		  uint uVar5;
		  
		  if (DAT_ram_00a57aa5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors__ExpectedBuySlotErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_UserArtifact__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_UserArtifact___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_UserArtifact__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoBuyGolemSlotsAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_uint__ResourceSet__get_Item1__);
		    Mono_Security_ASN1__get_Item(&System_Tuple_uint__ResourceSet__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_UserArtifact_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9121);
		    DAT_ram_00a57aa5 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Services_ProtoBuyGolemSlotsAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Services_ProtoBuyGolemSlotsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar3 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_00[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors__ExpectedBuySlotErrors___
		                    );
		  if (iVar3 == 0) {
		    param1_01 = *(int **)(param2 + 0xc);
		    if (param1_01 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_01 + 0xb8) <
		           (uint)*(byte *)(System_Tuple_uint__ResourceSet__TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_01 + 100) +
		                   (uint)*(byte *)(System_Tuple_uint__ResourceSet__TypeInfo + 0xb8) * 4 + -4) !=
		          System_Tuple_uint__ResourceSet__TypeInfo)) {
		        System_Activator__CreateInstance(param1_01,System_Tuple_uint__ResourceSet__TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = unnamed_function_1417(System_Collections_Generic_List_UserArtifact__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (iVar3,Method_System_Collections_Generic_List_UserArtifact___ctor__);
		    if (param1_01[2] != 0) {
		      uVar2 = 0;
		      do {
		        param2_00 = unnamed_function_1417(Protocol_Main_UserArtifact_TypeInfo);
		        *(uint *)(param2_00 + 0xc) = param1_00[4] + uVar2;
		        iVar1 = Method_System_Collections_Generic_List_UserArtifact__Add__;
		        *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		        uVar5 = *(uint *)(iVar3 + 0xc);
		        if (uVar5 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		          *(uint *)(iVar3 + 0xc) = uVar5 + 1;
		          *(int *)(*(int *)(iVar3 + 8) + uVar5 * 4 + 0x10) = param2_00;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar3,param2_00,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38)
		                    );
		        }
		        uVar2 = uVar2 + 1;
		      } while (uVar2 < (uint)param1_01[2]);
		    }
		    Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		              (param1,iVar3,
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__ParseSlotChanges__
		              );
		    uVar4 = System_Uri___ctor(0);
		    uVar4 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar4,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9121,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar4,1,param3_00,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x1c);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004314")]
		[Address(RVA = "0x91C8", Offset = "0x91C8", VA = "0x91C8")]
		protected void BuySlotHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: BuySlotHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController__BuySlotHandler
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a57aa6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    DAT_ram_00a57aa6 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoStackableChangesAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (-1 < param1_00[3]) {
		    Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		              (param1,param1_00[4],
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__ParseSlotChanges__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004315 RID: 17173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004315")]
		[Address(RVA = "0x91C9", Offset = "0x91C9", VA = "0x91C9")]
		protected void SwapSlotsSuccessHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: SwapSlotsSuccessHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController__SwapSlotsSuccessHandler
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined8 param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57aa7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController_PutUserItemToGolemResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a57aa7 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x24);
		  param2_00 = func_ii_7957(param2,0);
		  uVar1 = ServicesNamespace_ClansService__SwapGolemSlots(uVar1,param2_00,param3,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController_PutUserItemToGolemResultHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  DG_Tweening_TweenParams__SetId
		            (uVar1,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  return;
		}
		*/

		}

		// Token: 0x06004316 RID: 17174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004316")]
		[Address(RVA = "0x91CA", Offset = "0x91CA", VA = "0x91CA")]
		private void PutUserItemToGolem(ArtifactData artifactData, int chestSlot)
		{
		/* --- GHIDRA: PutUserItemToGolem ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController__PutUserItemToGolem
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *param1_00;
		  int *piVar4;
		  int iVar5;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57aa8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_ArtifactData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_UserArtifact___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_UserArtifact_TypeInfo);
		    DAT_ram_00a57aa8 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoStackableChangesAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (-1 < param1_00[3]) {
		    piVar4 = *(int **)(param2 + 0xc);
		    if (piVar4 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar4 + 0xb8) < (uint)*(byte *)(Core_Data_ArtifactData_TypeInfo + 0xb8)
		          ) || (*(int *)(*(int *)(*piVar4 + 100) +
		                         (uint)*(byte *)(Core_Data_ArtifactData_TypeInfo + 0xb8) * 4 + -4) !=
		                Core_Data_ArtifactData_TypeInfo)) {
		        System_Activator__CreateInstance(piVar4,Core_Data_ArtifactData_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = unnamed_function_1417(Protocol_Main_UserArtifact_TypeInfo);
		    iVar5 = piVar4[0x1f];
		    *(undefined4 *)(iVar2 + 0x10) = 0;
		    *(int *)(iVar2 + 0xc) = iVar5;
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x120);
		          goto code_r0x80e1c409;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80e1c409:
		    iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    param1_01 = *(undefined4 *)(iVar5 + 0x14);
		    iVar5 = Mono_Security_ASN1Convert__ToOid(Protocol_Main_UserArtifact___TypeInfo,1);
		    *(int *)(iVar5 + 0x10) = iVar2;
		    Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		              (param1_01,iVar5,
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		              (param1,param1_00[4],
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__ParseSlotChanges__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004317 RID: 17175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004317")]
		[Address(RVA = "0x91CB", Offset = "0x91CB", VA = "0x91CB")]
		private void PutUserItemToGolemResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: PutUserItemToGolemResultHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController__PutUserItemToGolemResultHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57aa9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_int__int___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_GolemInventoryModel__StartResolveEmptySlotsProcess__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__int__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController___c__DisplayClass14_0__MoveItemToChest_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController___c__DisplayClass14_0_TypeInfo
		              );
		    DAT_ram_00a57aa9 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController___c__DisplayClass14_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  param1_00 = Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_object___ShowNotAvailableSlotsWindow
		                        (*(undefined4 *)(param1 + 0x20),1,2,
		                         Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_GolemInventoryModel__StartResolveEmptySlotsProcess__
		                        );
		  param1_01 = unnamed_function_1417(System_Action_OpToken_int__int___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param2_00,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController___c__DisplayClass14_0__MoveItemToChest_b__0__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_int__int__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06004318 RID: 17176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004318")]
		[Address(RVA = "0x91CC", Offset = "0x91CC", VA = "0x91CC", Slot = "15")]
		public override void MoveItemToChest(ArtifactData artifactData)
		{
		/* --- GHIDRA: MoveItemToChest ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController__MoveItemToChest
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57aaa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController_SellArtifactSuccessHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a57aaa = '\x01';
		  }
		  uVar1 = ServicesNamespace_ClansService__PutUserItemToGolem
		                    (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param2 + 0x7c),0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController_SellArtifactSuccessHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_4 = *(undefined4 *)(param2 + 0x7c);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  DG_Tweening_TweenParams__SetId(uVar1,uVar2,Method_Utils_OpToken_IMessage__object__SetCustomData__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06004319 RID: 17177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004319")]
		[Address(RVA = "0x91CD", Offset = "0x91CD", VA = "0x91CD", Slot = "18")]
		public override void SellItem(ArtifactData artifactData)
		{
		/* --- GHIDRA: SellItem ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController__SellItem
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a57aab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    DAT_ram_00a57aab = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoStackableChangesAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (-1 < param1_00[3]) {
		    Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		              (param1,param1_00[4],
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__ParseSlotChanges__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600431A RID: 17178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600431A")]
		[Address(RVA = "0x91CE", Offset = "0x91CE", VA = "0x91CE")]
		private void SellArtifactSuccessHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: SellArtifactSuccessHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController__SellArtifactSuccessHandler
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a57aac == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__RepairItemSuccessHandler_ExpectedClanBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57aac = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_02 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_02;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x230);
		        goto code_r0x80e1c710;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e1c710:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_02,puVar2[1]);
		  iVar3 = Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Handle
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x18) + 8),param2,0);
		  if (iVar3 != 0) {
		    param1_00 = ServicesNamespace_ServicesService__BuyGolemSlots
		                          (*(undefined4 *)(param1 + 0x28),param3,0);
		    param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_01,param1,
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__RepairItemSuccessHandler_ExpectedClanBillingErrors___
		               ,0);
		    ServicesNamespace_MainService__GetUserStats
		              (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600431B RID: 17179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600431B")]
		[Address(RVA = "0x91CF", Offset = "0x91CF", VA = "0x91CF", Slot = "19")]
		public override void RepairArtifact(ResourceSet price, params uint[] slotIds)
		{
		/* --- GHIDRA: RepairArtifact ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController__RepairArtifact
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a57aad == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__ReforgeItemResultHandler_ExpectedClanBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57aad = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_02 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_02;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x230);
		        goto code_r0x80e1c849;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e1c849:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_02,puVar2[1]);
		  iVar3 = Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Handle
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x18) + 8),param2,0);
		  if (iVar3 != 0) {
		    param1_00 = ServicesNamespace_ServicesService__RepairGolemItem
		                          (*(undefined4 *)(param1 + 0x28),param3,0);
		    param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_01,param1,
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__ReforgeItemResultHandler_ExpectedClanBillingErrors___
		               ,0);
		    ServicesNamespace_MainService__GetUserStats
		              (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600431C RID: 17180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600431C")]
		[Address(RVA = "0x91D0", Offset = "0x91D0", VA = "0x91D0", Slot = "20")]
		public override void ReforgeArtifact(ResourceSet price, uint slotId)
		{
		/* --- GHIDRA: ReforgeArtifact ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController__ReforgeArtifact
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined8 param5_00;
		  
		  if (DAT_ram_00a57aae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__DismantleArtifact__
		              );
		    DAT_ram_00a57aae = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param5_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x58),0);
		  Gameplay_Inventory_Controller_InventoryBaseController_object__object___ClearFresh
		            (param1,param2,param3,param4,param5_00,
		             Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__DismantleArtifact__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600431D RID: 17181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600431D")]
		[Address(RVA = "0x91D1", Offset = "0x91D1", VA = "0x91D1", Slot = "13")]
		public override void DismantleArtifact(ArtifactData artifactData, bool sellDrop = false, bool wholeStack = false)
		{
		}

		// Token: 0x040024F7 RID: 9463
		[Token(Token = "0x40024F7")]
		[FieldOffset(Offset = "0x24")]
		private ClansService _clansService;

		// Token: 0x040024F8 RID: 9464
		[Token(Token = "0x40024F8")]
		[FieldOffset(Offset = "0x28")]
		private ServicesService _servicesService;
	}
}
