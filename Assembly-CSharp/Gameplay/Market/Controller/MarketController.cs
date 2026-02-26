using System;
using System.Collections.Generic;
using Gameplay.Market.Events;
using Gameplay.Market.Model;
using Gameplay.Market.View;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Shop;
using ServicesNamespace;
using Utils;
using Utils.Timers;

namespace Gameplay.Market.Controller
{
	// Token: 0x02000633 RID: 1587
	[Token(Token = "0x2000633")]
	public class MarketController : AbstractController<MarketModel, MarketEvents>
	{
		// Token: 0x0600266E RID: 9838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266E")]
		[Address(RVA = "0x77A7", Offset = "0x77A7", VA = "0x77A7")]
		public MarketController(MarketModel model, MarketEvents events, ShopService service)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Market_Controller_MarketController___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a018 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Controller_MarketController_GetMarketArtifactsResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a5a018 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ShopService__GetArtifactMinPrice(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Market_Controller_MarketController_GetMarketArtifactsResultHandler__,0)
		  ;
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600266F RID: 9839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266F")]
		[Address(RVA = "0x77A8", Offset = "0x77A8", VA = "0x77A8")]
		private void GetMarketArtifacts()
		{
		/* --- GHIDRA: GetMarketArtifacts ---
		void Gameplay_Market_Controller_MarketController__GetMarketArtifacts
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a5a019 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ProtoGetMarketArtifactsAns_TypeInfo);
		    DAT_ram_00a5a019 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Shop_ProtoGetMarketArtifactsAns_TypeInfo != *param1_01)
		     ) {
		    System_Activator__CreateInstance(param1_01,Protocol_Shop_ProtoGetMarketArtifactsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Market_Model_MarketModel__EnableArtifactsFromCache(param1_00,param1_01,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a5a002 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Peek__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__get_Count__
		              );
		    DAT_ram_00a5a002 = '\x01';
		  }
		  if (*(int *)(*(int *)(iVar1 + 0x28) + 0xc) != 0) {
		    iVar1 = Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                      (*(int *)(iVar1 + 0x28),
		                       Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Peek__
		                      );
		    Utils_Timers_DelayedCall__SetDelay(param1[7],*(undefined4 *)(iVar1 + 0x10),0);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a5a003 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Peek__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__get_Count__
		              );
		    DAT_ram_00a5a003 = '\x01';
		  }
		  if (*(int *)(*(int *)(iVar1 + 0x2c) + 0xc) != 0) {
		    iVar1 = Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                      (*(int *)(iVar1 + 0x2c),
		                       Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Peek__
		                      );
		    Utils_Timers_DelayedCall__SetDelay(param1[8],*(undefined4 *)(iVar1 + 0xc),0);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    Gameplay_Market_Controller_MarketController__ScheduleNextAddition(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002670 RID: 9840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002670")]
		[Address(RVA = "0x77A9", Offset = "0x77A9", VA = "0x77A9")]
		private void GetMarketArtifactsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetMarketArtifactsResultHandler ---
		void Gameplay_Market_Controller_MarketController__GetMarketArtifactsResultHandler
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a01a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_Controller_MarketController_GetUserOtherMarketArtifactsResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a5a01a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a59ffd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__IList_MarketLotListElement_MarketLotListElementArgs___ContainsKey__
		              );
		    DAT_ram_00a59ffd = '\x01';
		  }
		  iVar1 = Google_Protobuf_Collections_RepeatedField_ulong___GetEnumerator
		                    (*(undefined4 *)(iVar1 + 0x10),param2,
		                     Method_System_Collections_Generic_Dictionary_ulong__IList_MarketLotListElement_MarketLotListElementArgs___ContainsKey__
		                    );
		  if (iVar1 == 0) {
		    uVar2 = ServicesNamespace_ShopService__GetMarketArtifacts(param1[6],param2,0);
		    uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Market_Controller_MarketController_GetUserOtherMarketArtifactsResultHandler__
		               ,0);
		    uVar2 = ServicesNamespace_MainService__GetUserStats
		                      (uVar2,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    local_8 = param2;
		    uVar3 = func_ii_1081(DAT_ram_00a66968,&local_8);
		    uVar2 = DG_Tweening_TweenParams__SetId
		                      (uVar2,uVar3,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (DAT_ram_00a59ffe == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_Dictionary_ulong__IList_MarketLotListElement_MarketLotListElementArgs___get_Item__
		                );
		      DAT_ram_00a59ffe = '\x01';
		    }
		    uVar2 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                      (*(undefined4 *)(iVar1 + 0x10),param2,
		                       Method_System_Collections_Generic_Dictionary_ulong__IList_MarketLotListElement_MarketLotListElementArgs___get_Item__
		                      );
		    *(undefined4 *)(iVar1 + 0x24) = uVar2;
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

		// Token: 0x06002671 RID: 9841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002671")]
		[Address(RVA = "0x77AA", Offset = "0x77AA", VA = "0x77AA")]
		public void GetUserOtherMarketArtifacts(ulong artifactId)
		{
		/* --- GHIDRA: GetUserOtherMarketArtifacts ---
		void Gameplay_Market_Controller_MarketController__GetUserOtherMarketArtifacts
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 *puVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *param1_01;
		  int *param1_02;
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a5a01b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ProtoGetUserOtherMarketArtifactsAns_TypeInfo);
		    DAT_ram_00a5a01b = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Shop_ProtoGetUserOtherMarketArtifactsAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance
		              (param1_01,Protocol_Shop_ProtoGetUserOtherMarketArtifactsAns_TypeInfo);
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
		  if (*(int *)(*param1_02 + 0x20) == *(int *)(DAT_ram_00a66968 + 0x20)) {
		    puVar1 = (undefined8 *)func_ii_15774(param1_02);
		    param2_00 = *puVar1;
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		    Gameplay_Market_Model_MarketModel__RemoveAddStackSorted(param1_00,param2_00,param1_01[3],param1)
		    ;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x18);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		    return;
		  }
		  System_Activator__CreateInstance(param1_02,DAT_ram_00a66968);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002672 RID: 9842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002672")]
		[Address(RVA = "0x77AB", Offset = "0x77AB", VA = "0x77AB")]
		private void GetUserOtherMarketArtifactsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetUserOtherMarketArtifactsResultHandler ---
		void Gameplay_Market_Controller_MarketController__GetUserOtherMarketArtifactsResultHandler
		               (undefined4 param1,undefined8 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int param2_00;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a5a01c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_int__int___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEmptySlotsProcess__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__int__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_Controller_MarketController___c__DisplayClass6_0__BuyMarketArtifact_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Market_Controller_MarketController___c__DisplayClass6_0_TypeInfo);
		    DAT_ram_00a5a01c = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Market_Controller_MarketController___c__DisplayClass6_0_TypeInfo);
		  *(undefined8 *)(param2_00 + 0x10) = param2;
		  *(undefined4 *)(param2_00 + 8) = param1;
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x811b3bd4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x811b3bd4:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_02,puVar2[1]);
		  param1_00 = Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_object___ShowNotAvailableSlotsWindow
		                        (*(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x20),1,3,
		                         Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEmptySlotsProcess__
		                        );
		  param1_01 = unnamed_function_1417(System_Action_OpToken_int__int___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param2_00,
		             Method_Gameplay_Market_Controller_MarketController___c__DisplayClass6_0__BuyMarketArtifact_b__0__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_int__int__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06002673 RID: 9843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002673")]
		[Address(RVA = "0x77AC", Offset = "0x77AC", VA = "0x77AC")]
		public void BuyMarketArtifact(ulong artifactId)
		{
		/* --- GHIDRA: BuyMarketArtifact ---
		void Gameplay_Market_Controller_MarketController__BuyMarketArtifact
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param3_00;
		  uint *puVar4;
		  int *param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a5a01d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedBuyArtifactErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ProtoBuyArtifactAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9179);
		    DAT_ram_00a5a01d = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Shop_ProtoBuyArtifactAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Shop_ProtoBuyArtifactAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_00[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedBuyArtifactErrors___
		                    );
		  if (iVar2 == 0) {
		    uVar3 = System_Uri___ctor(0);
		    uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9179,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar3,1,param3_00,0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *param1_01;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x120);
		          goto code_r0x811b3da3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x811b3da3:
		    iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(param1_01,puVar4[1]);
		    Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		              (*(undefined4 *)(iVar2 + 0x14),param1_00[4],
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002674 RID: 9844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002674")]
		[Address(RVA = "0x77AD", Offset = "0x77AD", VA = "0x77AD")]
		private void BuyMarketArtifactResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: BuyMarketArtifactResultHandler ---
		void Gameplay_Market_Controller_MarketController__BuyMarketArtifactResultHandler
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined1 auStack_10 [8];
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  local_8 = param3;
		  local_4 = param2;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Market_Model_MarketModel__GetOptionsLots(param1_00,&local_4,&local_8,auStack_10);
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

		// Token: 0x06002675 RID: 9845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002675")]
		[Address(RVA = "0x77AE", Offset = "0x77AE", VA = "0x77AE")]
		public void GetSimilarArtifacts(MarketLotListElement.MarketLotListElementArgs targetItem, IList<MarketLotListElement.MarketLotListElementArgs> availableLots)
		{
		/* --- GHIDRA: GetSimilarArtifacts ---
		void Gameplay_Market_Controller_MarketController__GetSimilarArtifacts
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined1 auStack_10 [8];
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  local_8 = param3;
		  local_4 = param2;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Market_Model_MarketModel__CacheOtherArtifacts(param1_00,&local_4,&local_8,auStack_10);
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

		// Token: 0x06002676 RID: 9846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002676")]
		[Address(RVA = "0x77AF", Offset = "0x77AF", VA = "0x77AF")]
		public void GetOptionsLots(MarketLotListElement.MarketLotListElementArgs targetItem, IList<MarketLotListElement.MarketLotListElementArgs> availableLots)
		{
		/* --- GHIDRA: GetOptionsLots ---
		void Gameplay_Market_Controller_MarketController__GetOptionsLots
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 local_4;
		  
		  local_4 = param2;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Market_Model_MarketModel__GetSimilarArtifacts(param1_00,&local_4,param1);
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

		// Token: 0x06002677 RID: 9847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002677")]
		[Address(RVA = "0x77B0", Offset = "0x77B0", VA = "0x77B0")]
		public void GetOtherOptionsArtifacts(IList<MarketLotListElement.MarketLotListElementArgs> availableLots)
		{
		/* --- GHIDRA: GetOtherOptionsArtifacts ---
		void Gameplay_Market_Controller_MarketController__GetOtherOptionsArtifacts
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a01e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_Timers_DelayedCall_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Controller_MarketController_HandleAddOption__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Controller_MarketController_HandleOptionExpired__);
		    DAT_ram_00a5a01e = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Gameplay_Market_Controller_MarketController_HandleAddOption__,0);
		  uVar2 = unnamed_function_1417(Utils_Timers_DelayedCall_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(uVar2,uVar1,0);
		  *(undefined4 *)(param1 + 0x20) = uVar2;
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Gameplay_Market_Controller_MarketController_HandleOptionExpired__,0
		            );
		  uVar2 = unnamed_function_1417(Utils_Timers_DelayedCall_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(uVar2,uVar1,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  Gameplay_Market_Controller_MarketController___ctor(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002678 RID: 9848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002678")]
		[Address(RVA = "0x77B1", Offset = "0x77B1", VA = "0x77B1", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Market_Controller_MarketController__HandleRun(int param1,undefined4 param2)
		
		{
		  Gameplay_Market_Controller_MarketController__SubscribeToServiceEvents(param1,param1);
		  ServicesNamespace_ShopService__BuyMarketArtifact(*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x06002679 RID: 9849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002679")]
		[Address(RVA = "0x77B2", Offset = "0x77B2", VA = "0x77B2", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Market_Controller_MarketController__HandleStop(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Market_Model_MarketModel__PopulateMarketArtifacts(param1_00,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a5a002 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Peek__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__get_Count__
		              );
		    DAT_ram_00a5a002 = '\x01';
		  }
		  if (*(int *)(*(int *)(iVar1 + 0x28) + 0xc) != 0) {
		    iVar1 = Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                      (*(int *)(iVar1 + 0x28),
		                       Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Peek__
		                      );
		    Utils_Timers_DelayedCall__SetDelay(param1[7],*(undefined4 *)(iVar1 + 0x10),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600267A RID: 9850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267A")]
		[Address(RVA = "0x77B3", Offset = "0x77B3", VA = "0x77B3")]
		private void HandleOptionExpired()
		{
		/* --- GHIDRA: HandleOptionExpired ---
		void Gameplay_Market_Controller_MarketController__HandleOptionExpired(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Market_Model_MarketModel__RemoveExpiredElements(param1_00,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a5a003 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Peek__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__get_Count__
		              );
		    DAT_ram_00a5a003 = '\x01';
		  }
		  if (*(int *)(*(int *)(iVar1 + 0x2c) + 0xc) != 0) {
		    iVar1 = Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                      (*(int *)(iVar1 + 0x2c),
		                       Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Peek__
		                      );
		    Utils_Timers_DelayedCall__SetDelay(param1[8],*(undefined4 *)(iVar1 + 0xc),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600267B RID: 9851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267B")]
		[Address(RVA = "0x77B4", Offset = "0x77B4", VA = "0x77B4")]
		private void HandleAddOption()
		{
		/* --- GHIDRA: HandleAddOption ---
		void Gameplay_Market_Controller_MarketController__HandleAddOption(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a5a002 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Peek__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__get_Count__
		              );
		    DAT_ram_00a5a002 = '\x01';
		  }
		  if (*(int *)(*(int *)(iVar1 + 0x28) + 0xc) != 0) {
		    iVar1 = Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                      (*(int *)(iVar1 + 0x28),
		                       Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Peek__
		                      );
		    Utils_Timers_DelayedCall__SetDelay(param1[7],*(undefined4 *)(iVar1 + 0x10),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600267C RID: 9852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267C")]
		[Address(RVA = "0x77B5", Offset = "0x77B5", VA = "0x77B5")]
		private void ScheduleNextExpiration()
		{
		/* --- GHIDRA: ScheduleNextExpiration ---
		void Gameplay_Market_Controller_MarketController__ScheduleNextExpiration
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a5a003 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Peek__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__get_Count__
		              );
		    DAT_ram_00a5a003 = '\x01';
		  }
		  if (*(int *)(*(int *)(iVar1 + 0x2c) + 0xc) != 0) {
		    iVar1 = Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                      (*(int *)(iVar1 + 0x2c),
		                       Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Peek__
		                      );
		    Utils_Timers_DelayedCall__SetDelay(param1[8],*(undefined4 *)(iVar1 + 0xc),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600267D RID: 9853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267D")]
		[Address(RVA = "0x77B6", Offset = "0x77B6", VA = "0x77B6")]
		private void ScheduleNextAddition()
		{
		/* --- GHIDRA: ScheduleNextAddition ---
		void Gameplay_Market_Controller_MarketController__ScheduleNextAddition(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a01f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoMarketArtifactsRemovedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoMarketArtifactsAddedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_Controller_MarketController_MarketArtifactsAddedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_Controller_MarketController_MarketArtifactsRemovedEventHandler__
		              );
		    DAT_ram_00a5a01f = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoMarketArtifactsAddedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Market_Controller_MarketController_MarketArtifactsAddedEventHandler__,0
		            );
		  ServicesNamespace_ShopService__remove_ArtifactMovedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoMarketArtifactsRemovedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Market_Controller_MarketController_MarketArtifactsRemovedEventHandler__
		             ,0);
		  ServicesNamespace_ShopService__remove_MarketArtifactsAddedEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600267E RID: 9854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267E")]
		[Address(RVA = "0x77B7", Offset = "0x77B7", VA = "0x77B7")]
		private void SubscribeToServiceEvents()
		{
		/* --- GHIDRA: SubscribeToServiceEvents ---
		void Gameplay_Market_Controller_MarketController__SubscribeToServiceEvents
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a020 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoMarketArtifactsRemovedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoMarketArtifactsAddedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_Controller_MarketController_MarketArtifactsAddedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_Controller_MarketController_MarketArtifactsRemovedEventHandler__
		              );
		    DAT_ram_00a5a020 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoMarketArtifactsAddedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Market_Controller_MarketController_MarketArtifactsAddedEventHandler__,0
		            );
		  ServicesNamespace_ShopService__add_MarketArtifactsAddedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoMarketArtifactsRemovedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Market_Controller_MarketController_MarketArtifactsRemovedEventHandler__
		             ,0);
		  ServicesNamespace_ShopService__add_MarketArtifactsRemovedEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600267F RID: 9855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267F")]
		[Address(RVA = "0x77B8", Offset = "0x77B8", VA = "0x77B8")]
		private void UnsubscribeFromServiceEvents()
		{
		/* --- GHIDRA: UnsubscribeFromServiceEvents ---
		void Gameplay_Market_Controller_MarketController__UnsubscribeFromServiceEvents
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a021 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Array_Empty_MarketLotListElement_MarketLotListElementArgs___);
		    DAT_ram_00a5a021 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  local_4 = *(undefined4 *)(param2 + 0xc);
		  uVar1 = Gameplay_Market_Model_MarketModel__GetRandomOptionsArtifacts(uVar1,&local_4,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar4 = Method_System_Array_Empty_MarketLotListElement_MarketLotListElementArgs___;
		  iVar2 = *(int *)(iVar2 + 0x20);
		  if (iVar2 != 0) {
		    iVar3 = *(int *)(Method_System_Array_Empty_MarketLotListElement_MarketLotListElementArgs___ +
		                    0x1c);
		    if (iVar3 == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference
		                (Method_System_Array_Empty_MarketLotListElement_MarketLotListElementArgs___);
		      iVar3 = *(int *)(iVar4 + 0x1c);
		    }
		    iVar3 = *(int *)(iVar3 + 8);
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      iVar3 = func_ii_1079(iVar3);
		    }
		    if (*(int *)(iVar3 + 0x74) == 0) {
		      func_ii_306000(iVar3);
		    }
		    iVar4 = *(int *)(*(int *)(iVar4 + 0x1c) + 8);
		    if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		      iVar4 = func_ii_1079(iVar4);
		    }
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),**(undefined4 **)(iVar4 + 0x5c),uVar1,
		               *(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002680 RID: 9856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002680")]
		[Address(RVA = "0x77B9", Offset = "0x77B9", VA = "0x77B9")]
		private void MarketArtifactsRemovedEventHandler(ProtoMarketArtifactsRemovedEvt evt)
		{
		/* --- GHIDRA: MarketArtifactsRemovedEventHandler ---
		void Gameplay_Market_Controller_MarketController__MarketArtifactsRemovedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a022 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Array_Empty_MarketLotListElement_MarketLotListElementArgs___);
		    DAT_ram_00a5a022 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = Gameplay_Market_Model_MarketModel__RemoveArtifacts
		                    (uVar1,*(undefined4 *)(param2 + 0xc),param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar4 = Method_System_Array_Empty_MarketLotListElement_MarketLotListElementArgs___;
		  iVar2 = *(int *)(iVar2 + 0x20);
		  if (iVar2 != 0) {
		    iVar3 = *(int *)(Method_System_Array_Empty_MarketLotListElement_MarketLotListElementArgs___ +
		                    0x1c);
		    if (iVar3 == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference
		                (Method_System_Array_Empty_MarketLotListElement_MarketLotListElementArgs___);
		      iVar3 = *(int *)(iVar4 + 0x1c);
		    }
		    iVar3 = *(int *)(iVar3 + 8);
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      iVar3 = func_ii_1079(iVar3);
		    }
		    if (*(int *)(iVar3 + 0x74) == 0) {
		      func_ii_306000(iVar3);
		    }
		    iVar4 = *(int *)(*(int *)(iVar4 + 0x1c) + 8);
		    if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		      iVar4 = func_ii_1079(iVar4);
		    }
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar1,**(undefined4 **)(iVar4 + 0x5c),
		               *(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002681 RID: 9857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002681")]
		[Address(RVA = "0x77BA", Offset = "0x77BA", VA = "0x77BA")]
		private void MarketArtifactsAddedEventHandler(ProtoMarketArtifactsAddedEvt evt)
		{
		}

		// Token: 0x0400150F RID: 5391
		[Token(Token = "0x400150F")]
		[FieldOffset(Offset = "0x18")]
		private readonly ShopService _shopService;

		// Token: 0x04001510 RID: 5392
		[Token(Token = "0x4001510")]
		[FieldOffset(Offset = "0x1C")]
		private DelayedCall _removeTimer;

		// Token: 0x04001511 RID: 5393
		[Token(Token = "0x4001511")]
		[FieldOffset(Offset = "0x20")]
		private DelayedCall _addTimer;
	}
}
