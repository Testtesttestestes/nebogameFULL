using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Inventory.View.Chest;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Cave;
using Protocol.Common;
using ServicesNamespace;
using Utils;

namespace Gameplay.Cave
{
	// Token: 0x02000B2B RID: 2859
	[Token(Token = "0x2000B2B")]
	public class CaveController : AbstractController<CaveModel, CaveEvents>
	{
		// Token: 0x0600457D RID: 17789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600457D")]
		[Address(RVA = "0x9421", Offset = "0x9421", VA = "0x9421")]
		public CaveController(CaveModel model, CaveEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Cave_CaveController___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  int *param1_00;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5795d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGetCaveInfoAns__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Cave_CaveController_BuildingStateChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Cave_CaveController_HandleServiceEventNewMonsterInCave__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CaveService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5795d = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 8);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  iVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CaveService___);
		  param1[6] = iVar2;
		  uVar3 = unnamed_function_1417(System_Action_ProtoGetCaveInfoAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_Gameplay_Cave_CaveController_HandleServiceEventNewMonsterInCave__,0
		            );
		  ServicesNamespace_BossService___ctor(iVar2,uVar3,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x110);
		        goto code_r0x80e0786e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80e0786e:
		  iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		  iVar6 = *(int *)(*(int *)(*(int *)(iVar2 + 0x14) + 0x20) + 0xc);
		  param1_01 = *(undefined4 *)(iVar6 + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar3,param1,Method_Gameplay_Cave_CaveController_BuildingStateChangedEvent__,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(param1_01,uVar3,0);
		  uVar3 = System_Action_uint__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar6 + 0x14) = 0;
		  }
		  else {
		    iVar5 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar6 + 0x14) = iVar5;
		    uVar3 = System_Action_uint__TypeInfo;
		    iVar6 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Gameplay_Cave_CaveController__BuildingStateChangedEvent(param1,iVar2);
		  Gameplay_Cave_CaveController__HandleCaveState(param1,iVar2);
		  return;
		}
		*/

		}

		// Token: 0x0600457E RID: 17790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600457E")]
		[Address(RVA = "0x9422", Offset = "0x9422", VA = "0x9422", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Cave_CaveController__HandleRun(undefined4 param1,int param2,undefined4 param3)
		
		{
		  if (param2 == 5) {
		    Gameplay_Cave_CaveController__BuildingStateChangedEvent(param1,5);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600457F RID: 17791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600457F")]
		[Address(RVA = "0x9423", Offset = "0x9423", VA = "0x9423")]
		private void BuildingStateChangedEvent(uint buildingType)
		{
		/* --- GHIDRA: BuildingStateChangedEvent ---
		void Gameplay_Cave_CaveController__BuildingStateChangedEvent(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a5795e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5795e = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x80e079e9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80e079e9:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)
		                      (*(int *)(*(int *)(*(int *)(iVar6 + 0x14) + 0x20) + 0x10) + 0x24),5,
		                     Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                    );
		  uVar3 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(uVar3,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80e07ab4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e07ab4:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetShopLevelDic(uVar4,uVar3,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x1f8);
		        goto code_r0x80e07b6e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80e07b6e:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar7 = **(int **)(iVar6 + 0x14);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                    (*(int **)(iVar6 + 0x14),*(undefined4 *)(iVar7 + 0x104));
		  uVar3 = Gameplay_Accounts_Model_Data_BattleAccount__GetTurnTimeout
		                    (*(undefined4 *)(iVar6 + 0x28),uVar3,0);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar6 + 0x18) = uVar3;
		  return;
		}
		*/

		}

		// Token: 0x06004580 RID: 17792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004580")]
		[Address(RVA = "0x9424", Offset = "0x9424", VA = "0x9424")]
		private void ValidateSearchPrice()
		{
		/* --- GHIDRA: ValidateSearchPrice ---
		void Gameplay_Cave_CaveController__ValidateSearchPrice(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param2 + 0xc) == param1[8]) {
		    param1[8] = 0;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined1 *)(iVar1 + 0x10) = 1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x18);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		      return;
		    }
		  }
		  else {
		    Gameplay_Cave_CaveController__OnSearchCaveAns
		              (param1,0,*(int *)(param2 + 0xc),*(undefined4 *)(param2 + 0x14),1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004581 RID: 17793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004581")]
		[Address(RVA = "0x9425", Offset = "0x9425", VA = "0x9425")]
		private void HandleServiceEventNewMonsterInCave(ProtoGetCaveInfoAns msg)
		{
		/* --- GHIDRA: HandleServiceEventNewMonsterInCave ---
		void Gameplay_Cave_CaveController__HandleServiceEventNewMonsterInCave(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a5795f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGetCaveInfoAns__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Cave_CaveController_BuildingStateChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Cave_CaveController_HandleServiceEventNewMonsterInCave__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5795f = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x80e08082;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80e08082:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = *(int *)(*(int *)(*(int *)(iVar5 + 0x14) + 0x20) + 0xc);
		  uVar7 = *(undefined4 *)(iVar6 + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar3,param1,Method_Gameplay_Cave_CaveController_BuildingStateChangedEvent__,0);
		  iVar5 = func_ii_7048(uVar7,uVar3,0);
		  uVar3 = System_Action_uint__TypeInfo;
		  if (iVar5 == 0) {
		    *(undefined4 *)(iVar6 + 0x14) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar5,System_Action_uint__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar5,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar6 + 0x14) = iVar4;
		    uVar3 = System_Action_uint__TypeInfo;
		    iVar6 = func_ii_1082(iVar5,System_Action_uint__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar5,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar7 = *(undefined4 *)(param1 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_ProtoGetCaveInfoAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_Gameplay_Cave_CaveController_HandleServiceEventNewMonsterInCave__,0
		            );
		  ServicesNamespace_CaveService__add_NewMonsterInCave(uVar7,uVar3,0);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06004582 RID: 17794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004582")]
		[Address(RVA = "0x9426", Offset = "0x9426", VA = "0x9426", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Cave_CaveController__HandleStop(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57960 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Cave_CaveCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Cave_CaveController_OnSearchCaveAns__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57960 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x1c);
		  local_4 = 1;
		  uVar1 = func_ii_1081(Protocol_Cave_CaveCommands_TypeInfo,&local_4);
		  iVar2 = Utils_CommandsRepository___ctor(uVar3,uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = ServicesNamespace_CaveService__ServerEventHandler(*(undefined4 *)(param1 + 0x18),0);
		    uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,Method_Gameplay_Cave_CaveController_OnSearchCaveAns__,0);
		    ServicesNamespace_MainService__GetUserStats
		              (uVar1,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004583 RID: 17795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004583")]
		[Address(RVA = "0x9427", Offset = "0x9427", VA = "0x9427")]
		public void RequestSearchCave()
		{
		/* --- GHIDRA: RequestSearchCave ---
		void Gameplay_Cave_CaveController__RequestSearchCave(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57961 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Cave_CaveCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_RewardInfo___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedCaveErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Cave_ProtoSearchCaveAns_TypeInfo);
		    DAT_ram_00a57961 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x1c);
		  local_4 = 1;
		  uVar1 = func_ii_1081(Protocol_Cave_CaveCommands_TypeInfo,&local_4);
		  Utils_CommandsRepository__TryAdd(param1_00,uVar1,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Cave_ProtoSearchCaveAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Cave_ProtoSearchCaveAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_01[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedCaveErrors___
		                    );
		  if (iVar2 == 0) {
		    uVar1 = System_Linq_Enumerable__Select_object__object_
		                      (param1_01[4],Method_System_Linq_Enumerable_ToList_RewardInfo___);
		    Gameplay_Cave_CaveController__OnSearchCaveAns
		              (param1,uVar1,param1_01[5],param1_01[7],0,param1_01);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004584 RID: 17796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004584")]
		[Address(RVA = "0x9428", Offset = "0x9428", VA = "0x9428")]
		private void OnSearchCaveAns(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: OnSearchCaveAns ---
		void Gameplay_Cave_CaveController__OnSearchCaveAns
		               (int *param1,undefined4 param2,int param3,undefined4 param4,int param5,
		               undefined4 param6)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57962 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_MonsterData_TypeInfo);
		    DAT_ram_00a57962 = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80e07dac;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e07dac:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar4 = Core_Extensions_Dict_DictExt__GetDismantleInfoDic(uVar4,param3,&local_4,0);
		  *(char *)(iVar2 + 0x1c) = (char)uVar4;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (param3 == 0) {
		    *(undefined4 *)(iVar2 + 0xc) = param2;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(iVar2 + 0x14) = 0;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined1 *)(iVar2 + 0x10) = 0;
		  }
		  else {
		    *(undefined4 *)(iVar2 + 0xc) = 0;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		          goto code_r0x80e07eab;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e07eab:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    if (*(int *)(Core_Data_MonsterData_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Data_MonsterData_TypeInfo);
		    }
		    uVar4 = Core_Data_MonsterData__Create(param3,param4,uVar4,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar4;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(char *)(iVar2 + 0x10) = (char)param5;
		    if (param5 == 0) {
		      param1[8] = param3;
		    }
		  }
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

		// Token: 0x06004585 RID: 17797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004585")]
		[Address(RVA = "0x9429", Offset = "0x9429", VA = "0x9429")]
		private void HandleCaveState(List<RewardInfo> rewards, uint monsterId, IList<ArtikulStackSize> monsterArtikuls, bool monsterStatusConfirmed)
		{
		/* --- GHIDRA: HandleCaveState ---
		void Gameplay_Cave_CaveController__HandleCaveState(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57963 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Cave_CaveController_OnCaveInfoAns__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57963 = '\x01';
		  }
		  param1_00 = ServicesNamespace_CaveService__SearchCave(*(undefined4 *)(param1 + 0x18),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,Method_Gameplay_Cave_CaveController_OnCaveInfoAns__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06004586 RID: 17798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004586")]
		[Address(RVA = "0x942A", Offset = "0x942A", VA = "0x942A")]
		private void GetCaveInfo()
		{
		/* --- GHIDRA: GetCaveInfo ---
		void Gameplay_Cave_CaveController__GetCaveInfo(undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a57964 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Cave_ProtoGetCaveInfoAns_TypeInfo);
		    DAT_ram_00a57964 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Cave_ProtoGetCaveInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Cave_ProtoGetCaveInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Cave_CaveController__OnSearchCaveAns(param1,0,param1_00[3],param1_00[5],1,param1_00);
		  return;
		}
		*/

		}

		// Token: 0x06004587 RID: 17799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004587")]
		[Address(RVA = "0x942B", Offset = "0x942B", VA = "0x942B")]
		private void OnCaveInfoAns(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: OnCaveInfoAns ---
		void Gameplay_Cave_CaveController__OnCaveInfoAns(undefined4 param1,int param2,undefined4 param3)
		
		{
		  Gameplay_Cave_CaveController__OnSearchCaveAns
		            (param1,0,*(undefined4 *)(param2 + 0xc),*(undefined4 *)(param2 + 0x14),1,param2);
		  return;
		}
		*/

		}

		// Token: 0x06004588 RID: 17800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004588")]
		[Address(RVA = "0x942C", Offset = "0x942C", VA = "0x942C")]
		private void OnGetCaveInfo(ProtoGetCaveInfoAns msg)
		{
		/* --- GHIDRA: OnGetCaveInfo ---
		void Gameplay_Cave_CaveController__OnGetCaveInfo(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57965 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ArenaCombat_Model_ArenaCombatModel_AttackRequestedMonster_TypeInfo);
		    DAT_ram_00a57965 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_01 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = unnamed_function_1417
		                        (Gameplay_ArenaCombat_Model_ArenaCombatModel_AttackRequestedMonster_TypeInfo
		                        );
		  Gameplay_ArenaCombat_Model_ArenaCombatModel_AttackRequestedMonster__get_FromCave
		            (param1_00,param2_00,0);
		  Gameplay_ArenaCombat_ArenaCombat__Dispose(param1_01,param1_00,0);
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

		// Token: 0x06004589 RID: 17801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004589")]
		[Address(RVA = "0x942D", Offset = "0x942D", VA = "0x942D")]
		public void AttackMonster(MonsterData monster)
		{
		/* --- GHIDRA: AttackMonster ---
		void Gameplay_Cave_CaveController__AttackMonster(int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57966 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Cave_CaveController_HandleMonsterKickService__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_WorldService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_WorldCommands_TypeInfo);
		    DAT_ram_00a57966 = '\x01';
		  }
		  iVar2 = param1[7];
		  local_4 = 0xc;
		  uVar1 = func_ii_1081(Protocol_World_WorldCommands_TypeInfo,&local_4);
		  iVar2 = Utils_CommandsRepository___ctor(iVar2,uVar1,0);
		  if (iVar2 != 0) {
		    if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		    }
		    uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                      (Method_Core_Net_ServiceFactory_GetService_WorldService___);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		    uVar1 = ServicesNamespace_WorldService__AttackMonster
		                      (uVar1,0,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x14) + 8) + 0xc),0);
		    param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,Method_Gameplay_Cave_CaveController_HandleMonsterKickService__,0);
		    uVar1 = ServicesNamespace_MainService__GetUserStats
		                      (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600458A RID: 17802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600458A")]
		[Address(RVA = "0x942E", Offset = "0x942E", VA = "0x942E")]
		public void KickMonster()
		{
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600458B")]
		[Address(RVA = "0x942F", Offset = "0x942F", VA = "0x942F")]
		private void AttackSuccessHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: AttackSuccessHandler ---
		void Gameplay_Cave_CaveController__AttackSuccessHandler(int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int iVar4;
		  int *piVar5;
		  int param4;
		  undefined4 param3_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57967 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedKickMonsterErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_CombatScope_KickMonsterEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoKickMonsterAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_WorldCommands_TypeInfo);
		    DAT_ram_00a57967 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  iVar4 = param1[7];
		  local_4 = 0xc;
		  uVar2 = func_ii_1081(Protocol_World_WorldCommands_TypeInfo,&local_4);
		  Utils_CommandsRepository__TryAdd(iVar4,uVar2,0);
		  piVar5 = *(int **)(param2 + 0x20);
		  if ((piVar5 != (int *)0x0) && (Protocol_World_ProtoKickMonsterAns_TypeInfo != *piVar5)) {
		    System_Activator__CreateInstance(piVar5,Protocol_World_ProtoKickMonsterAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		            (piVar5[3],0,
		             Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedKickMonsterErrors___
		            );
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param4 = *(int *)(iVar4 + 0x14);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar4 + 0x14) = 0;
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined1 *)(iVar4 + 0x1c) = 0;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar5;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x220);
		        goto code_r0x80e086e3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80e086e3:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  Gameplay_Inventory_View_EquipmentSlotView__set_ArtifactData(*(undefined4 *)(iVar4 + 0x18),8,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar4 = *(int *)(iVar4 + 0x14);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),*(undefined4 *)(iVar4 + 0x14));
		  }
		  if (param4 != 0) {
		    iVar4 = System_Uri___ctor(0);
		    iVar4 = *(int *)(*(int *)(*(int *)(*(int *)(iVar4 + 0x38) + 0x10) + 0x2c) + 0x14);
		    if (iVar4 != 0) {
		      uVar2 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      param1_00 = unnamed_function_1417
		                            (Core_Events_Scopes_CombatScope_KickMonsterEventArgs_TypeInfo);
		      Core_Events_Scopes_SchoolScope_SchoolEventArgs__get_OwnerId
		                (param1_00,uVar2,param3_00,param4,0,0);
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (*(undefined4 *)(iVar4 + 0x20),param1_00,*(undefined4 *)(iVar4 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600458C RID: 17804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600458C")]
		[Address(RVA = "0x9430", Offset = "0x9430", VA = "0x9430")]
		private void HandleMonsterKickService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleMonsterKickService ---
		void Gameplay_Cave_CaveController__HandleMonsterKickService(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int param3;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a57968 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_ArtifactFilterDelegate_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Cave_CaveController_FilterCaveArtifacts__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57968 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x80e08899;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80e08899:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_02,puVar2[1]);
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,2);
		  *(undefined8 *)(iVar3 + 0x10) = 0x500000001;
		  param3 = Mono_Security_ASN1Convert__ToOid
		                     (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,1);
		  *(undefined4 *)(param3 + 0x10) = 1;
		  param1_01 = unnamed_function_1417
		                        (
		                        Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_ArtifactFilterDelegate_TypeInfo
		                        );
		  Gameplay_Inventory_View_Chest_InventoryChestWindowOptions___ctor
		            (param1_01,0,Method_Gameplay_Cave_CaveController_FilterCaveArtifacts__,0);
		  Core_Gameplay_Managers_Inventory_InventoryManager__DismantleArtifact
		            (param1_00,iVar3,param3,param1_01,0);
		  return;
		}
		*/

		}

		// Token: 0x0600458D RID: 17805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600458D")]
		[Address(RVA = "0x9431", Offset = "0x9431", VA = "0x9431")]
		public void OpenInventory()
		{
		/* --- GHIDRA: OpenInventory ---
		uint Gameplay_Cave_CaveController__OpenInventory(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  uint *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint uVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  int param1_01;
		  int param2_01;
		  
		  param2_01 = 0;
		  if (DAT_ram_00a57969 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Cave_CaveController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__IndexOf__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtikulTypeFilters__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtikulTypeFilters__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    DAT_ram_00a57969 = '\x01';
		  }
		  if (**(int **)(Gameplay_Cave_CaveController_TypeInfo + 0x5c) == 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar4 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar4 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar4 * 8 + 4) * 8 + iVar5 + 0x178);
		          goto code_r0x80e08a1b;
		        }
		        uVar4 = uVar4 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar4);
		    }
		    puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e08a1b:
		    uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		    uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		    iVar5 = Core_Extensions_Dict_DictExt__GetGameFiledGems(uVar2,0x40,0);
		    uVar2 = unnamed_function_1417(System_Collections_Generic_List_uint__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (uVar2,Method_System_Collections_Generic_List_uint___ctor__);
		    **(undefined4 **)(Gameplay_Cave_CaveController_TypeInfo + 0x5c) = uVar2;
		    if (0 < *(int *)(iVar5 + 0xc)) {
		      do {
		        param2_00 = 0;
		        iVar3 = System_Linq_Enumerable__ToList_object_
		                          (iVar5,param2_01,
		                           Method_System_Collections_Generic_List_ArtikulTypeFilters__get_Item__);
		        iVar6 = *(int *)(iVar3 + 0x18);
		        if (0 < *(int *)(iVar6 + 0xc)) {
		          do {
		            uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                              (iVar6,param2_00,
		                               Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		            iVar6 = Method_System_Collections_Generic_List_uint__Add__;
		            param1_01 = **(int **)(Gameplay_Cave_CaveController_TypeInfo + 0x5c);
		            *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		            uVar4 = *(uint *)(param1_01 + 0xc);
		            if (uVar4 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		              *(uint *)(param1_01 + 0xc) = uVar4 + 1;
		              *(undefined4 *)(*(int *)(param1_01 + 8) + uVar4 * 4 + 0x10) = uVar2;
		            }
		            else {
		              System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                        (param1_01,uVar2,
		                         *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		            }
		            param2_00 = param2_00 + 1;
		            iVar6 = *(int *)(iVar3 + 0x18);
		          } while (param2_00 < *(int *)(iVar6 + 0xc));
		        }
		        param2_01 = param2_01 + 1;
		      } while (param2_01 < *(int *)(iVar5 + 0xc));
		    }
		  }
		  uVar4 = func_ii_8100(**(undefined4 **)(Gameplay_Cave_CaveController_TypeInfo + 0x5c),
		                       *(undefined4 *)(*(int *)(param1 + 0xc) + 0xc),
		                       Method_System_Collections_Generic_List_uint__IndexOf__);
		  return (uVar4 ^ 0xffffffff) >> 0x1f;
		}
		*/

		}

		// Token: 0x0600458E RID: 17806 RVA: 0x0000D128 File Offset: 0x0000B328
		[Token(Token = "0x600458E")]
		[Address(RVA = "0x9432", Offset = "0x9432", VA = "0x9432")]
		public static bool FilterCaveArtifacts(ArtifactData artifactData)
		{
		/* --- GHIDRA: FilterCaveArtifacts ---
		undefined4 Gameplay_Cave_CaveController__FilterCaveArtifacts(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  
		  if (DAT_ram_00a5796a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Contains_RewardTypes___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Cave_RewardBehaviourManager_TypeInfo);
		    DAT_ram_00a5796a = '\x01';
		  }
		  if (*(int *)(Gameplay_Cave_RewardBehaviourManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Cave_RewardBehaviourManager_TypeInfo);
		  }
		  iVar4 = *(int *)(**(int **)(Gameplay_Cave_RewardBehaviourManager_TypeInfo + 0x5c) + 0xc);
		  if (0 < iVar4) {
		    iVar1 = 0;
		    do {
		      if (*(int *)(Gameplay_Cave_RewardBehaviourManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Cave_RewardBehaviourManager_TypeInfo);
		      }
		      piVar5 = *(int **)(**(int **)(Gameplay_Cave_RewardBehaviourManager_TypeInfo + 0x5c) +
		                         iVar1 * 4 + 0x10);
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xe0) * 4))
		                        (piVar5,*(undefined4 *)(*piVar5 + 0xe4));
		      iVar3 = Core_Data_RewardData__get_RewardId
		                        (uVar2,*(undefined4 *)(param1 + 0xc),
		                         Method_System_Linq_Enumerable_Contains_RewardTypes___);
		      if (iVar3 != 0) {
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xe8) * 4))
		                          (piVar5,**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c),param1,
		                           *(undefined4 *)(*piVar5 + 0xec));
		        return uVar2;
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar4);
		  }
		  return 0;
		}
		*/

			return default(bool);
		}

		// Token: 0x04002604 RID: 9732
		[Token(Token = "0x4002604")]
		[FieldOffset(Offset = "0x18")]
		private CaveService _caveService;

		// Token: 0x04002605 RID: 9733
		[Token(Token = "0x4002605")]
		[FieldOffset(Offset = "0x1C")]
		private CommandsRepository _commandsRepository;

		// Token: 0x04002606 RID: 9734
		[Token(Token = "0x4002606")]
		[FieldOffset(Offset = "0x20")]
		private uint _waitingConfirmationMonsterId;

		// Token: 0x04002607 RID: 9735
		[Token(Token = "0x4002607")]
		[FieldOffset(Offset = "0x24")]
		private UserInventoryChestWindow _inventoryChestWindow;

		// Token: 0x04002608 RID: 9736
		[Token(Token = "0x4002608")]
		[FieldOffset(Offset = "0x0")]
		private static List<uint> _caveArtikulTypes;
	}
}
