using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Craft.Events;
using Gameplay.Craft.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Craft;
using ServicesNamespace;
using UI.Windows;
using Utils;

namespace Gameplay.Craft.Controller
{
	// Token: 0x020008C3 RID: 2243
	[Token(Token = "0x20008C3")]
	public class CraftController : AbstractController<CraftModel, Gameplay.Craft.Events.CraftEvents>
	{
		// Token: 0x060034B2 RID: 13490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B2")]
		[Address(RVA = "0x84DB", Offset = "0x84DB", VA = "0x84DB")]
		public CraftController(CraftModel model, Gameplay.Craft.Events.CraftEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Craft_Controller_CraftController___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int param2_00;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a63a2f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_int__int___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEmptySlotsProcess__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__int__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftController___c__DisplayClass4_0__TakeArtifacts_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Craft_Controller_CraftController___c__DisplayClass4_0_TypeInfo);
		    DAT_ram_00a63a2f = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Craft_Controller_CraftController___c__DisplayClass4_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 0xc) = param2;
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
		        goto code_r0x8232d001;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x8232d001:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_02,puVar2[1]);
		  param1_00 = Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_object___ShowNotAvailableSlotsWindow
		                        (*(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x20),
		                         *(undefined4 *)(*(int *)(param2_00 + 0xc) + 0xc),3,
		                         Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEmptySlotsProcess__
		                        );
		  param1_01 = unnamed_function_1417(System_Action_OpToken_int__int___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param2_00,
		             Method_Gameplay_Craft_Controller_CraftController___c__DisplayClass4_0__TakeArtifacts_b__0__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_int__int__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B3")]
		[Address(RVA = "0x84DC", Offset = "0x84DC", VA = "0x84DC")]
		public void TakeArtifacts(params ulong[] artifactIds)
		{
		/* --- GHIDRA: TakeArtifacts ---
		void Gameplay_Craft_Controller_CraftController__TakeArtifacts
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63a30 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_TakeArtifactResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a63a30 = '\x01';
		  }
		  uVar1 = ServicesNamespace_MainService__GetLastDrop(*(undefined4 *)(param1 + 0x1c),5,0,param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Craft_Controller_CraftController_TakeArtifactResultHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B4")]
		[Address(RVA = "0x84DD", Offset = "0x84DD", VA = "0x84DD")]
		private void RequestTakeArtifacts(ulong[] artifactIds)
		{
		/* --- GHIDRA: RequestTakeArtifacts ---
		void Gameplay_Craft_Controller_CraftController__RequestTakeArtifacts
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a63a31 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBuySlotErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    DAT_ram_00a63a31 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar4 = *(int **)(param2 + 0x20);
		  if ((piVar4 != (int *)0x0) && (Protocol_Main_ProtoStackableChangesAns_TypeInfo != *piVar4)) {
		    System_Activator__CreateInstance(piVar4,Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (piVar4[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBuySlotErrors___
		                    );
		  if (iVar2 == 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x150);
		          goto code_r0x8232d1ef;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x8232d1ef:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    iVar5 = **(int **)(iVar2 + 0x10);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x110) * 4))
		                      (*(int **)(iVar2 + 0x10),*(undefined4 *)(iVar5 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x18);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),5,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B5")]
		[Address(RVA = "0x84DE", Offset = "0x84DE", VA = "0x84DE")]
		private void TakeArtifactResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: TakeArtifactResultHandler ---
		void Gameplay_Craft_Controller_CraftController__TakeArtifactResultHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63a32 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactData____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_RequestSellArtifacts__);
		    DAT_ram_00a63a32 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_ArtifactData____TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Craft_Controller_CraftController_RequestSellArtifacts__,0);
		  UI_Windows_ConfirmSellUserArtifactWindow__HandleContent(param1_01,param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B6")]
		[Address(RVA = "0x84DF", Offset = "0x84DF", VA = "0x84DF")]
		public void SellArtifacts(params ArtifactData[] artifacts)
		{
		/* --- GHIDRA: SellArtifacts ---
		void Gameplay_Craft_Controller_CraftController__SellArtifacts
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int param1_00;
		  
		  if (DAT_ram_00a63a33 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_SellArtifactsResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_ArtifactData__ulong___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ulong___);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtifactData__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController___c__RequestSellArtifacts_b__8_0__)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_Controller_CraftController___c_TypeInfo);
		    DAT_ram_00a63a33 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  if (*(int *)(Gameplay_Craft_Controller_CraftController___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Craft_Controller_CraftController___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Craft_Controller_CraftController___c_TypeInfo + 0x5c);
		  param1_00 = puVar3[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_Craft_Controller_CraftController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Craft_Controller_CraftController___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_Craft_Controller_CraftController___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    param1_00 = unnamed_function_1417(System_Func_ArtifactData__ulong__TypeInfo);
		    func_ii_7542(param1_00,uVar1,
		                 Method_Gameplay_Craft_Controller_CraftController___c__RequestSellArtifacts_b__8_0__
		                 ,0);
		    *(int *)(*(int *)(Gameplay_Craft_Controller_CraftController___c_TypeInfo + 0x5c) + 4) =
		         param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                    (param2,param1_00,Method_System_Linq_Enumerable_Select_ArtifactData__ulong___);
		  uVar1 = System_Linq_Enumerable__ToArray_PlayerLoopSystem_
		                    (uVar1,Method_System_Linq_Enumerable_ToArray_ulong___);
		  uVar2 = ServicesNamespace_MainService__TakeArtifactFromDrop(uVar2,uVar1,0);
		  uVar1 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Craft_Controller_CraftController_SellArtifactsResultHandler__,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,uVar1,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B7")]
		[Address(RVA = "0x84E0", Offset = "0x84E0", VA = "0x84E0")]
		private void RequestSellArtifacts(params ArtifactData[] artifacts)
		{
		/* --- GHIDRA: RequestSellArtifacts ---
		void Gameplay_Craft_Controller_CraftController__RequestSellArtifacts
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  Gameplay_Craft_Controller_CraftController__GetUserProfessionsResultHandler(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B8")]
		[Address(RVA = "0x84E1", Offset = "0x84E1", VA = "0x84E1")]
		private void SellArtifactsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: SellArtifactsResultHandler ---
		void Gameplay_Craft_Controller_CraftController__SellArtifactsResultHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63a34 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_GetUserProfessionsResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a63a34 = '\x01';
		  }
		  uVar1 = ServicesNamespace_CraftService__ServerEventHandler(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Craft_Controller_CraftController_GetUserProfessionsResultHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B9")]
		[Address(RVA = "0x84E2", Offset = "0x84E2", VA = "0x84E2")]
		public void GetUserProfessions()
		{
		/* --- GHIDRA: GetUserProfessions ---
		void Gameplay_Craft_Controller_CraftController__GetUserProfessions
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a63a35 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Craft_ProtoGetUserProfessionsAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserProfession__get_Item__);
		    DAT_ram_00a63a35 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar6 = *(int **)(param2 + 0x20);
		  if ((piVar6 != (int *)0x0) && (Protocol_Craft_ProtoGetUserProfessionsAns_TypeInfo != *piVar6)) {
		    System_Activator__CreateInstance(piVar6,Protocol_Craft_ProtoGetUserProfessionsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (piVar6[3],0,
		                     Method_Google_Protobuf_Collections_RepeatedField_UserProfession__get_Item__);
		  *(int *)(iVar2 + 0x14) = iVar3;
		  if (DAT_ram_00a63a23 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a63a23 = '\x01';
		  }
		  piVar6 = *(int **)(iVar2 + 0x10);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd0);
		        goto code_r0x8232d60d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8232d60d:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar5 = Core_Extensions_Dict_DictExt__GetIsleAnimationDic(uVar5,*(undefined4 *)(iVar3 + 0xc),0);
		  *(undefined4 *)(iVar2 + 0x18) = uVar5;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x14);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060034BA RID: 13498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034BA")]
		[Address(RVA = "0x84E3", Offset = "0x84E3", VA = "0x84E3")]
		private void GetUserProfessionsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetUserProfessionsResultHandler ---
		void Gameplay_Craft_Controller_CraftController__GetUserProfessionsResultHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63a36 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftController_GetUserCraftSlotsInfoResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a63a36 = '\x01';
		  }
		  uVar1 = ServicesNamespace_CraftService__GetUserProfessions(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Craft_Controller_CraftController_GetUserCraftSlotsInfoResultHandler__,0
		            );
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060034BB RID: 13499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034BB")]
		[Address(RVA = "0x84E4", Offset = "0x84E4", VA = "0x84E4")]
		public void GetUserCraftSlotsInfo()
		{
		/* --- GHIDRA: GetUserCraftSlotsInfo ---
		void Gameplay_Craft_Controller_CraftController__GetUserCraftSlotsInfo
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a63a37 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Craft_ProtoGetUserCraftSlotsInfoAns_TypeInfo);
		    DAT_ram_00a63a37 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Craft_ProtoGetUserCraftSlotsInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Craft_ProtoGetUserCraftSlotsInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Craft_Controller_CraftController__UserBalanceChangedEventHandler
		            (param1,param1_00[3],param1_00);
		  return;
		}
		*/

		}

		// Token: 0x060034BC RID: 13500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034BC")]
		[Address(RVA = "0x84E5", Offset = "0x84E5", VA = "0x84E5")]
		private void GetUserCraftSlotsInfoResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetUserCraftSlotsInfoResultHandler ---
		void Gameplay_Craft_Controller_CraftController__GetUserCraftSlotsInfoResultHandler
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63a38 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_OpenCraftSlotResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a63a38 = '\x01';
		  }
		  uVar1 = ServicesNamespace_CraftService__DismantleArtifact(*(undefined4 *)(param1 + 0x18),param2,0)
		  ;
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,param3,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Craft_Controller_CraftController_OpenCraftSlotResultHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060034BD RID: 13501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034BD")]
		[Address(RVA = "0x84E6", Offset = "0x84E6", VA = "0x84E6")]
		public void OpenCraftSlot(uint slotId, Action callback)
		{
		/* --- GHIDRA: OpenCraftSlot ---
		void Gameplay_Craft_Controller_CraftController__OpenCraftSlot
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a63a39 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedOpenCraftSlotErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Craft_ProtoOpenCraftSlotAns_TypeInfo);
		    DAT_ram_00a63a39 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar2 = *(int **)(param2 + 0x20);
		  if ((piVar2 != (int *)0x0) && (Protocol_Craft_ProtoOpenCraftSlotAns_TypeInfo != *piVar2)) {
		    System_Activator__CreateInstance(piVar2,Protocol_Craft_ProtoOpenCraftSlotAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (piVar2[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedOpenCraftSlotErrors___
		                    );
		  if (iVar1 == 0) {
		    Gameplay_Craft_Controller_CraftController__UserBalanceChangedEventHandler
		              (param1,piVar2[4],param2);
		    piVar2 = *(int **)(param2 + 0xc);
		    if (piVar2 != (int *)0x0) {
		      if (System_Action_TypeInfo != *piVar2) {
		        System_Activator__CreateInstance(piVar2,System_Action_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      (**(code **)((ulonglong)(uint)piVar2[3] * 4))(piVar2[8],piVar2[5]);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060034BE RID: 13502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034BE")]
		[Address(RVA = "0x84E7", Offset = "0x84E7", VA = "0x84E7")]
		private void OpenCraftSlotResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: OpenCraftSlotResultHandler ---
		void Gameplay_Craft_Controller_CraftController__OpenCraftSlotResultHandler
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63a3a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_StartCraftResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_uint__uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Tuple_uint__uint__TypeInfo);
		    DAT_ram_00a63a3a = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Tuple_uint__uint__TypeInfo);
		  UnityEngine_Purchasing_Default_Factory__Create
		            (uVar1,param2,param3,Method_System_Tuple_uint__uint___ctor__);
		  uVar2 = ServicesNamespace_CraftService__OpenCraftSlot
		                    (*(undefined4 *)(param1 + 0x18),param2,param3,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Craft_Controller_CraftController_StartCraftResultHandler__,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar2,uVar1,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060034BF RID: 13503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034BF")]
		[Address(RVA = "0x84E8", Offset = "0x84E8", VA = "0x84E8")]
		public void StartCraft(uint schemeId, uint quantity)
		{
		/* --- GHIDRA: StartCraft ---
		void Gameplay_Craft_Controller_CraftController__StartCraft
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *piVar2;
		  int param5;
		  int param4;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a63a3b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_CraftScope_CraftEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedStartCraftErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Craft_ProtoStartCraftAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_uint__uint__get_Item1__);
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_uint__uint__get_Item2__);
		    Mono_Security_ASN1__get_Item(&System_Tuple_uint__uint__TypeInfo);
		    DAT_ram_00a63a3b = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar2 = *(int **)(param2 + 0x20);
		  if ((piVar2 != (int *)0x0) && (Protocol_Craft_ProtoStartCraftAns_TypeInfo != *piVar2)) {
		    System_Activator__CreateInstance(piVar2,Protocol_Craft_ProtoStartCraftAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (piVar2[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedStartCraftErrors___
		                    );
		  if (iVar1 == 0) {
		    Gameplay_Craft_Controller_CraftController__UserBalanceChangedEventHandler
		              (param1,piVar2[4],param2);
		    piVar2 = *(int **)(param2 + 0xc);
		    if (piVar2 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar2 + 0xb8) <
		           (uint)*(byte *)(System_Tuple_uint__uint__TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar2 + 100) +
		                   (uint)*(byte *)(System_Tuple_uint__uint__TypeInfo + 0xb8) * 4 + -4) !=
		          System_Tuple_uint__uint__TypeInfo)) {
		        System_Activator__CreateInstance(piVar2,System_Tuple_uint__uint__TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x78) + 8);
		    if (iVar1 != 0) {
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param5 = piVar2[3];
		      param4 = piVar2[2];
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      param1_00 = unnamed_function_1417(Core_Events_Scopes_CraftScope_CraftEventArgs_TypeInfo);
		      Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		                (param1_00,param2_00,param3_00,param4,param5,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C0")]
		[Address(RVA = "0x84E9", Offset = "0x84E9", VA = "0x84E9")]
		private void StartCraftResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: StartCraftResultHandler ---
		void Gameplay_Craft_Controller_CraftController__StartCraftResultHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63a3c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_CancelCraftResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a63a3c = '\x01';
		  }
		  uVar1 = ServicesNamespace_CraftService__StartCraft(*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Craft_Controller_CraftController_CancelCraftResultHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C1")]
		[Address(RVA = "0x84EA", Offset = "0x84EA", VA = "0x84EA")]
		public void CancelCraft(uint craftSlotId)
		{
		/* --- GHIDRA: CancelCraft ---
		void Gameplay_Craft_Controller_CraftController__CancelCraft
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  int *param1_00;
		  
		  if (DAT_ram_00a63a3d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Craft_ProtoCancelCraftAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4484);
		    DAT_ram_00a63a3d = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Craft_ProtoCancelCraftAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Craft_ProtoCancelCraftAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (param1_00[3] == -1) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4484,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,param3_00,0);
		    return;
		  }
		  Gameplay_Craft_Controller_CraftController__UserBalanceChangedEventHandler
		            (param1,param1_00[4],param1_00);
		  return;
		}
		*/

		}

		// Token: 0x060034C2 RID: 13506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C2")]
		[Address(RVA = "0x84EB", Offset = "0x84EB", VA = "0x84EB")]
		private void CancelCraftResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: CancelCraftResultHandler ---
		void Gameplay_Craft_Controller_CraftController__CancelCraftResultHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63a3e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_SpeedupCraftResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a63a3e = '\x01';
		  }
		  uVar1 = ServicesNamespace_CraftService__CancelCraft(*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Craft_Controller_CraftController_SpeedupCraftResultHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C3")]
		[Address(RVA = "0x84EC", Offset = "0x84EC", VA = "0x84EC")]
		public void SpeedupCraft(uint craftSlotId)
		{
		/* --- GHIDRA: SpeedupCraft ---
		void Gameplay_Craft_Controller_CraftController__SpeedupCraft
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  
		  if (DAT_ram_00a63a3f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Craft_ProtoSpeedupCraftAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4447);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4484);
		    DAT_ram_00a63a3f = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Craft_ProtoSpeedupCraftAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Craft_ProtoSpeedupCraftAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (param1_00[3] == -2) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4447,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		    return;
		  }
		  if (param1_00[3] != -1) {
		    Gameplay_Craft_Controller_CraftController__UserBalanceChangedEventHandler
		              (param1,param1_00[4],param1_00);
		    Gameplay_Craft_Controller_CraftController__SellArtifactsResultHandler(param1,param1_00);
		    return;
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4484,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C4")]
		[Address(RVA = "0x84ED", Offset = "0x84ED", VA = "0x84ED")]
		private void SpeedupCraftResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: SpeedupCraftResultHandler ---
		void Gameplay_Craft_Controller_CraftController__SpeedupCraftResultHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63a40 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_GetUserSchemesResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a63a40 = '\x01';
		  }
		  uVar1 = ServicesNamespace_CraftService__SpeedupCraft(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Craft_Controller_CraftController_GetUserSchemesResultHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C5")]
		[Address(RVA = "0x84EE", Offset = "0x84EE", VA = "0x84EE")]
		public void GetUserSchemes()
		{
		/* --- GHIDRA: GetUserSchemes ---
		void Gameplay_Craft_Controller_CraftController__GetUserSchemes
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a63a41 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Craft_ProtoGetUserSchemesAns_TypeInfo);
		    DAT_ram_00a63a41 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Craft_ProtoGetUserSchemesAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Craft_ProtoGetUserSchemesAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Craft_Model_CraftModel___ctor(param1_00,param1_01[3],param1);
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

		// Token: 0x060034C6 RID: 13510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C6")]
		[Address(RVA = "0x84EF", Offset = "0x84EF", VA = "0x84EF")]
		private void GetUserSchemesResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetUserSchemesResultHandler ---
		void Gameplay_Craft_Controller_CraftController__GetUserSchemesResultHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63a42 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_RemoveUserSchemeResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a63a42 = '\x01';
		  }
		  uVar1 = ServicesNamespace_CraftService__DismantleArtifactFromDrop
		                    (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(param2 + 0xc),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Craft_Controller_CraftController_RemoveUserSchemeResultHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C7")]
		[Address(RVA = "0x84F0", Offset = "0x84F0", VA = "0x84F0")]
		public void RemoveUserScheme(UserScheme scheme)
		{
		/* --- GHIDRA: RemoveUserScheme ---
		void Gameplay_Craft_Controller_CraftController__RemoveUserScheme
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63a43 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSchemeData__RemoveAll__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&System_Predicate_CraftSchemeData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftController___c__DisplayClass25_0__RemoveUserSchemeResultHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Craft_Controller_CraftController___c__DisplayClass25_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Craft_UserScheme_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a63a43 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Craft_Controller_CraftController___c__DisplayClass25_0_TypeInfo);
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  iVar1 = Protocol_Craft_UserScheme_TypeInfo;
		  piVar3 = *(int **)(param2 + 0x20);
		  if ((piVar3 != (int *)0x0) && (Protocol_Common_ProtoDefaultAns_TypeInfo != *piVar3)) {
		    System_Activator__CreateInstance(piVar3,Protocol_Common_ProtoDefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (piVar3[3] < 0) {
		    if (piVar3[3] == -1) {
		      Gameplay_Craft_Controller_CraftController__Unsubscribe(param1,param1);
		      return;
		    }
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    iVar1 = piVar3[4];
		    if (piVar3[4] == 0) {
		      iVar1 = StringLiteral_5;
		    }
		    Core_Application_App__get_ToastController(uVar2,2,iVar1,0);
		    return;
		  }
		  piVar3 = *(int **)(param2 + 0xc);
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2_00 + 8) = 0;
		  }
		  else if ((Protocol_Craft_UserScheme_TypeInfo != *piVar3) ||
		          (*(int **)(param2_00 + 8) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(undefined4 *)(iVar1 + 0xc);
		  uVar2 = unnamed_function_1417(System_Predicate_CraftSchemeData__TypeInfo);
		  func_ii_7297(uVar2,param2_00,
		               Method_Gameplay_Craft_Controller_CraftController___c__DisplayClass25_0__RemoveUserSchemeResultHandler_b__0__
		               ,0);
		  System_Collections_Generic_List_object___IsCompatibleObject
		            (param1_00,uVar2,Method_System_Collections_Generic_List_CraftSchemeData__RemoveAll__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x24);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2_00 + 8),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C8")]
		[Address(RVA = "0x84F1", Offset = "0x84F1", VA = "0x84F1")]
		private void RemoveUserSchemeResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C9")]
		[Address(RVA = "0x84F2", Offset = "0x84F2", VA = "0x84F2")]
		private void ProfessionChangedEventHandler(UserProfession profession)
		{
		/* --- GHIDRA: ProfessionChangedEventHandler ---
		void Gameplay_Craft_Controller_CraftController__ProfessionChangedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int param1_00;
		  undefined4 param2_01;
		  uint uVar5;
		  
		  if (DAT_ram_00a63a44 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_CraftSchemeData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CraftSchemeData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSchemeData__FindIndex__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSchemeData__RemoveAt__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSchemeData__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Predicate_CraftSchemeData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_Controller_CraftController___c__DisplayClass27_0__SchemeChangedEventHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Craft_Controller_CraftController___c__DisplayClass27_0_TypeInfo);
		    DAT_ram_00a63a44 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Craft_Controller_CraftController___c__DisplayClass27_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar4 = *(undefined4 *)(iVar1 + 0xc);
		  uVar2 = unnamed_function_1417(System_Predicate_CraftSchemeData__TypeInfo);
		  func_ii_7297(uVar2,param2_00,
		               Method_Gameplay_Craft_Controller_CraftController___c__DisplayClass27_0__SchemeChangedEventHandler_b__0__
		               ,0);
		  iVar1 = System_Collections_Generic_List_UsageHint___FindAll
		                    (uVar4,uVar2,Method_System_Collections_Generic_List_CraftSchemeData__FindIndex__
		                    );
		  if (*(int *)(*(int *)(param2_00 + 8) + 0x10) == 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    UnityEngine_TextCore_Glyph__set_atlasIndex
		              (*(undefined4 *)(iVar3 + 0xc),iVar1,
		               Method_System_Collections_Generic_List_CraftSchemeData__RemoveAt__);
		  }
		  else {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param1_00 = *(int *)(iVar3 + 0xc);
		    param2_01 = *(undefined4 *)(param2_00 + 8);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar2 = Gameplay_Craft_View_CraftSlotListElement__DisplayEmptySlot
		                      (uVar2,*(undefined4 *)(*(int *)(param2_00 + 8) + 0xc),param1);
		    uVar4 = unnamed_function_1417(Core_Data_CraftSchemeData_TypeInfo);
		    UnityEngine_Purchasing_Default_Factory__Create(uVar4,param2_01,uVar2,0);
		    iVar3 = Method_System_Collections_Generic_List_CraftSchemeData__Add__;
		    if (iVar1 < 0) {
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar5 = *(uint *)(param1_00 + 0xc);
		      if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		        *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		        *(undefined4 *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = uVar4;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,uVar4,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		      }
		    }
		    else {
		      System_Collections_Generic_List_UsageHint___get_Item
		                (param1_00,iVar1,uVar4,
		                 Method_System_Collections_Generic_List_CraftSchemeData__set_Item__);
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x24);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2_00 + 8),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060034CA RID: 13514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CA")]
		[Address(RVA = "0x84F3", Offset = "0x84F3", VA = "0x84F3")]
		private void SchemeChangedEventHandler(UserScheme scheme)
		{
		/* --- GHIDRA: SchemeChangedEventHandler ---
		void Gameplay_Craft_Controller_CraftController__SchemeChangedEventHandler
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  Gameplay_Craft_Controller_CraftController__UserBalanceChangedEventHandler
		            (param1,*(undefined4 *)(param2 + 0xc),param2);
		  return;
		}
		*/

		}

		// Token: 0x060034CB RID: 13515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CB")]
		[Address(RVA = "0x84F4", Offset = "0x84F4", VA = "0x84F4")]
		private void CraftSlotsChangedEventHandler(ProtoCraftSlotsChangedEvt evt)
		{
		/* --- GHIDRA: CraftSlotsChangedEventHandler ---
		void Gameplay_Craft_Controller_CraftController__CraftSlotsChangedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a63a45 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserScheme__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCraftSlotsChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_UserProfession__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_CraftSlotsChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_ProfessionChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_SchemeChangedEventHandler__);
		    DAT_ram_00a63a45 = '\x01';
		  }
		  if (*(char *)(param1 + 0x20) == '\0') {
		    *(undefined1 *)(param1 + 0x20) = 1;
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_UserProfession__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftController_ProfessionChangedEventHandler__,0);
		    ServicesNamespace_CraftService__get_ServiceId(uVar2,uVar1,0);
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_UserScheme__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftController_SchemeChangedEventHandler__,0);
		    ServicesNamespace_CraftService__remove_ProfessionChangedEvent(uVar2,uVar1,0);
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_ProtoCraftSlotsChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftController_CraftSlotsChangedEventHandler__,0);
		    ServicesNamespace_CraftService__remove_SchemeChangedEvent(uVar2,uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060034CC RID: 13516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CC")]
		[Address(RVA = "0x84F5", Offset = "0x84F5", VA = "0x84F5")]
		public void Subscribe()
		{
		/* --- GHIDRA: Subscribe ---
		void Gameplay_Craft_Controller_CraftController__Subscribe(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a63a46 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserScheme__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCraftSlotsChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_UserProfession__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_CraftSlotsChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_ProfessionChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_SchemeChangedEventHandler__);
		    DAT_ram_00a63a46 = '\x01';
		  }
		  if (*(char *)(param1 + 0x20) != '\0') {
		    *(undefined1 *)(param1 + 0x20) = 0;
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_UserProfession__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftController_ProfessionChangedEventHandler__,0);
		    ServicesNamespace_CraftService__add_ProfessionChangedEvent(uVar2,uVar1,0);
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_UserScheme__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftController_SchemeChangedEventHandler__,0);
		    ServicesNamespace_CraftService__add_SchemeChangedEvent(uVar2,uVar1,0);
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_ProtoCraftSlotsChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Craft_Controller_CraftController_CraftSlotsChangedEventHandler__,0);
		    ServicesNamespace_CraftService__add_CraftSlotsChangedEvent(uVar2,uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060034CD RID: 13517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CD")]
		[Address(RVA = "0x84F6", Offset = "0x84F6", VA = "0x84F6")]
		public void Unsubscribe()
		{
		/* --- GHIDRA: Unsubscribe ---
		undefined4
		Gameplay_Craft_Controller_CraftController__Unsubscribe(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int param1_01;
		  int param1_02;
		  uint uVar3;
		  
		  if (DAT_ram_00a63a47 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_6124);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3611);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4455);
		    DAT_ram_00a63a47 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_6124,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4455,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  param1_02 = *(int *)(param1_00 + 0x24);
		  param1_01 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_01,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3611,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_01 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_02 + 0x10) = *(int *)(param1_02 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_02 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_02 + 8) + 0xc)) {
		    *(uint *)(param1_02 + 0xc) = uVar3 + 1;
		    *(int *)(*(int *)(param1_02 + 8) + uVar3 * 4 + 0x10) = param1_01;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_02,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_00,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x060034CE RID: 13518 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034CE")]
		[Address(RVA = "0x84F7", Offset = "0x84F7", VA = "0x84F7")]
		private DialogWindow ShowSlotExpiredWindow()
		{
		/* --- GHIDRA: ShowSlotExpiredWindow ---
		void Gameplay_Craft_Controller_CraftController__ShowSlotExpiredWindow
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  if (*(int *)(param2 + 0x10) == 3) {
		    Gameplay_Craft_Controller_CraftController__GetUserProfessionsResultHandler(param1,param2);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CF")]
		[Address(RVA = "0x84F8", Offset = "0x84F8", VA = "0x84F8")]
		private void HandleAccountChangedEventService(AccountInfo info)
		{
		/* --- GHIDRA: HandleAccountChangedEventService ---
		void Gameplay_Craft_Controller_CraftController__HandleAccountChangedEventService
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a63a48 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AccountInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_HandleAccountChangedEventService__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_UserBalanceChangedEventHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a63a48 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  uVar2 = unnamed_function_1417(System_Action_AccountInfo__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Craft_Controller_CraftController_HandleAccountChangedEventService__,0);
		  ServicesNamespace_ServicesService__remove_AuchanBacklightChangedEvent(uVar1,uVar2,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = *(undefined4 *)(iVar3 + 8);
		  uVar1 = unnamed_function_1417(Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		  Core_Data_InfoRows_CollectionRow___ctor
		            (uVar1,param1,
		             Method_Gameplay_Craft_Controller_CraftController_UserBalanceChangedEventHandler__,0);
		  Core_Data_UserData__remove_OnUserInfoChangedEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D0")]
		[Address(RVA = "0x84F9", Offset = "0x84F9", VA = "0x84F9", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Craft_Controller_CraftController__HandleRun(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a63a49 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AccountInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_HandleAccountChangedEventService__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Controller_CraftController_UserBalanceChangedEventHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a63a49 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  uVar2 = unnamed_function_1417(System_Action_AccountInfo__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Craft_Controller_CraftController_HandleAccountChangedEventService__,0);
		  ServicesNamespace_ServicesService__add_AccountChangedEvent(uVar1,uVar2,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = *(undefined4 *)(iVar3 + 8);
		  uVar1 = unnamed_function_1417(Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		  Core_Data_InfoRows_CollectionRow___ctor
		            (uVar1,param1,
		             Method_Gameplay_Craft_Controller_CraftController_UserBalanceChangedEventHandler__,0);
		  Core_Data_UserData__add_BalanceChangedEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D1")]
		[Address(RVA = "0x84FA", Offset = "0x84FA", VA = "0x84FA", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Craft_Controller_CraftController__HandleStop
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x20);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D2")]
		[Address(RVA = "0x84FB", Offset = "0x84FB", VA = "0x84FB")]
		private void UserBalanceChangedEventHandler(ResourceSet balance, ResourceSet delta)
		{
		/* --- GHIDRA: UserBalanceChangedEventHandler ---
		void Gameplay_Craft_Controller_CraftController__UserBalanceChangedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a63a4a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_CraftScope_CraftSlotsEventArgs_TypeInfo);
		    DAT_ram_00a63a4a = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Craft_Model_CraftModel__SetProfession(uVar1,param2,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x1c);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  iVar2 = System_Uri___ctor(0);
		  iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x78) + 0xc);
		  if (iVar2 != 0) {
		    uVar1 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417(Core_Events_Scopes_CraftScope_CraftSlotsEventArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(param1_00,uVar1,param3_00,param2,0)
		    ;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1_00,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D3")]
		[Address(RVA = "0x84FC", Offset = "0x84FC", VA = "0x84FC")]
		private void SetCraftSlots(IList<UserCraftSlotInfo> slots)
		{
		/* --- GHIDRA: SetCraftSlots ---
		void Gameplay_Craft_Controller_CraftController__SetCraftSlots(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63a4b == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_Controller_CraftController___c_TypeInfo);
		    DAT_ram_00a63a4b = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Craft_Controller_CraftController___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Craft_Controller_CraftController___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04001CE3 RID: 7395
		[Token(Token = "0x4001CE3")]
		[FieldOffset(Offset = "0x18")]
		private CraftService _craftService;

		// Token: 0x04001CE4 RID: 7396
		[Token(Token = "0x4001CE4")]
		[FieldOffset(Offset = "0x1C")]
		private MainService _mainService;

		// Token: 0x04001CE5 RID: 7397
		[Token(Token = "0x4001CE5")]
		[FieldOffset(Offset = "0x20")]
		private bool _subscribed;
	}
}
