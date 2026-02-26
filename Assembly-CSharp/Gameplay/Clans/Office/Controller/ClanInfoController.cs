using System;
using Core.Data;
using Gameplay.Clans.Controller;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Clans;
using Protocol.Common;
using ServicesNamespace;
using UI.Windows;
using Utils;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A66 RID: 2662
	[Token(Token = "0x2000A66")]
	public class ClanInfoController : AbstractController<ClanInfoModel, ClanInfoEvents>
	{
		// Token: 0x06003EE4 RID: 16100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE4")]
		[Address(RVA = "0x8DA0", Offset = "0x8DA0", VA = "0x8DA0")]
		public ClanInfoController(ClanInfoModel model, ClanInfoEvents events, ClansController clansController)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClanInfoController___ctor(int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int param1_01;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57fd6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanInfoController_GetIsleInfoResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ClanIsleCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57fd6 = '\x01';
		  }
		  iVar2 = param1[9];
		  local_4 = 1;
		  uVar1 = func_ii_1081(Protocol_ClanIsle_ClanIsleCommands_TypeInfo,&local_4);
		  iVar2 = Utils_CommandsRepository___ctor(iVar2,uVar1,0);
		  if (iVar2 != 0) {
		    param1_01 = param1[7];
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		    uVar1 = ServicesNamespace_ClanIsleService__ServerEventHandler
		                      (param1_01,*(undefined8 *)(iVar2 + 0x10),2,0);
		    param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanInfoController_GetIsleInfoResultHandler__
		               ,0);
		    uVar1 = ServicesNamespace_MainService__GetUserStats
		                      (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE5")]
		[Address(RVA = "0x8DA1", Offset = "0x8DA1", VA = "0x8DA1")]
		public void GetClanIsleInfo()
		{
		/* --- GHIDRA: GetClanIsleInfo ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__GetClanIsleInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  int iVar2;
		  int *param1_00;
		  undefined4 local_8;
		  int local_4;
		  
		  if (DAT_ram_00a57fd7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ClanIsleCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ProtoGetIsleInfoAns_TypeInfo);
		    DAT_ram_00a57fd7 = '\x01';
		  }
		  iVar2 = param1[9];
		  local_8 = 1;
		  uVar1 = func_ii_1081(Protocol_ClanIsle_ClanIsleCommands_TypeInfo,&local_8);
		  Utils_CommandsRepository__TryAdd(iVar2,uVar1,0);
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_ClanIsle_ProtoGetIsleInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_ClanIsle_ProtoGetIsleInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (param1_00[4] < 0) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    local_4 = param1_00[4];
		    param3_00 = func_ii_4443(&local_4,0);
		    Core_Application_App__get_ToastController(uVar1,2,param3_00,0);
		  }
		  else {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Clans_Office_Model_ClanInfoModel__get_FilterDatas(uVar1,param1_00[3],param1);
		    *(undefined1 *)((int)param1 + 9) = 1;
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

		// Token: 0x06003EE6 RID: 16102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE6")]
		[Address(RVA = "0x8DA2", Offset = "0x8DA2", VA = "0x8DA2")]
		private void GetIsleInfoResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetIsleInfoResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__GetIsleInfoResultHandler
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57fd8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanInfoController_GetMembersListResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57fd8 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ClansService__CancelRequestForJoin
		                    (*(undefined4 *)(param1 + 0x20),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanInfoController_GetMembersListResultHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE7")]
		[Address(RVA = "0x8DA3", Offset = "0x8DA3", VA = "0x8DA3")]
		public void GetMembersList(ulong clanId)
		{
		/* --- GHIDRA: GetMembersList ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__GetMembersList
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a57fd9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetMembersListAns_TypeInfo);
		    DAT_ram_00a57fd9 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Clans_ProtoGetMembersListAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Clans_ProtoGetMembersListAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Clans_Office_Model_ClanInfoModel__GetTabBarItemData(param1_00,param1_01[3],param1);
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

		// Token: 0x06003EE8 RID: 16104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE8")]
		[Address(RVA = "0x8DA4", Offset = "0x8DA4", VA = "0x8DA4")]
		private void GetMembersListResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetMembersListResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__GetMembersListResultHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a57fda == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanInfoController_RequestJoinClanResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4289);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4311);
		    DAT_ram_00a57fda = '\x01';
		  }
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  param1_00 = *(undefined4 *)(*(int *)(iVar2 + 0x30) + 0xc);
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  uVar4 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar3 = func_ii_6965(*(undefined4 *)(iVar2 + 8),0);
		  iVar2 = Gameplay_World_Model_ClanData__TryGetCultDic(param1_00,uVar3,0);
		  if (iVar2 != 0) {
		    param1_01 = param1[8];
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x104)));
		    uVar4 = ServicesNamespace_ClansService__GetClanVacanciesList
		                      (param1_01,
		                       *(undefined8 *)
		                        (*(int *)(*(int *)(*(int *)(iVar2 + 0x30) + 0xc) + 0x1c) + 0x10),0);
		    uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanInfoController_RequestJoinClanResultHandler__
		               ,0);
		    ServicesNamespace_MainService__GetUserStats
		              (uVar4,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    return;
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4311,1,0,1,0,0,0,0);
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4289,1,0,1,0,0,0,0);
		  UI_Windows_DialogWindow__Show(uVar4,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x06003EE9 RID: 16105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE9")]
		[Address(RVA = "0x8DA5", Offset = "0x8DA5", VA = "0x8DA5")]
		public void RequestJoinClan()
		{
		/* --- GHIDRA: RequestJoinClan ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__RequestJoinClan
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  undefined4 param3_00;
		  undefined4 param4;
		  
		  if (DAT_ram_00a57fdb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ClansScope_ClansEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedPutJoinRequestErrors___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Errors_Expected_Clans_ExpectedPutJoinRequestErrors_ExpectedPutJoinRequestErrorsArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoPutRequestForJoinAns_TypeInfo);
		    DAT_ram_00a57fdb = '\x01';
		  }
		  piVar5 = *(int **)(param2 + 0x20);
		  if ((piVar5 != (int *)0x0) && (Protocol_Clans_ProtoPutRequestForJoinAns_TypeInfo != *piVar5)) {
		    System_Activator__CreateInstance(piVar5,Protocol_Clans_ProtoPutRequestForJoinAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar6 = piVar5[4];
		  uVar2 = unnamed_function_1417
		                    (
		                    Core_Errors_Expected_Clans_ExpectedPutJoinRequestErrors_ExpectedPutJoinRequestErrorsArgs_TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(uVar2,iVar6,0);
		  iVar6 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (piVar5[3],0,uVar2,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedPutJoinRequestErrors___
		                    );
		  if (iVar6 == 0) {
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
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		          goto code_r0x80e8e4f3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e8e4f3:
		    iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    iVar7 = *(int *)(iVar6 + 0x14);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined8 *)(iVar7 + 0x10) = *(undefined8 *)(iVar6 + 0x10);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar6 = *(int *)(iVar6 + 0x20);
		    if (iVar6 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		                (*(undefined4 *)(iVar6 + 0x20),*(undefined4 *)(iVar6 + 0x14));
		    }
		    iVar6 = System_Uri___ctor(0);
		    iVar6 = *(int *)(*(int *)(*(int *)(*(int *)(iVar6 + 0x38) + 0x10) + 0x84) + 0xc);
		    if (iVar6 != 0) {
		      uVar2 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param4 = *(undefined4 *)(*(int *)(iVar7 + 0x30) + 0xc);
		      uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar4 = Gameplay_Clans_Office_Model_ClanInfoModel__CreateUserRatingSubFilters(uVar4,iVar6);
		      param1_00 = unnamed_function_1417(Core_Events_Scopes_ClansScope_ClansEventArgs_TypeInfo);
		      Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		                (param1_00,uVar2,param3_00,param4,uVar4,0);
		      (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		                (*(undefined4 *)(iVar6 + 0x20),param1_00,*(undefined4 *)(iVar6 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003EEA RID: 16106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EEA")]
		[Address(RVA = "0x8DA6", Offset = "0x8DA6", VA = "0x8DA6")]
		private void RequestJoinClanResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: RequestJoinClanResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__RequestJoinClanResultHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57fdc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanInfoController_CancelJoinRequestResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57fdc = '\x01';
		  }
		  param1_00 = ServicesNamespace_ClansService__PutRequestForJoin(*(undefined4 *)(param1 + 0x20),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanInfoController_CancelJoinRequestResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EEB")]
		[Address(RVA = "0x8DA7", Offset = "0x8DA7", VA = "0x8DA7")]
		public void CancelJoinRequest()
		{
		/* --- GHIDRA: CancelJoinRequest ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__CancelJoinRequest
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *piVar5;
		  int iVar6;
		  int local_4;
		  
		  if (DAT_ram_00a57fdd == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28682);
		    DAT_ram_00a57fdd = '\x01';
		  }
		  piVar5 = *(int **)(param2 + 0x20);
		  if ((piVar5 != (int *)0x0) && (Protocol_Common_ProtoDefaultAns_TypeInfo != *piVar5)) {
		    System_Activator__CreateInstance(piVar5,Protocol_Common_ProtoDefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (piVar5[3] < 0) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    local_4 = piVar5[3];
		    uVar3 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar3 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_28682,uVar3,piVar5[4],0);
		    Core_Application_App__get_ToastController(uVar2,2,uVar3,0);
		  }
		  else {
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
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		          goto code_r0x80e8e7db;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e8e7db:
		    iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		    *(undefined8 *)(*(int *)(iVar6 + 0x14) + 0x10) = 0;
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar6 = *(int *)(iVar6 + 0x24);
		    if (iVar6 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		                (*(undefined4 *)(iVar6 + 0x20),*(undefined4 *)(iVar6 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EEC")]
		[Address(RVA = "0x8DA8", Offset = "0x8DA8", VA = "0x8DA8")]
		private void CancelJoinRequestResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: CancelJoinRequestResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__CancelJoinRequestResultHandler
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar6;
		  int param1_02;
		  
		  if (DAT_ram_00a57fde == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanInfoController_ChangeClanInfoResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoCreateClanCmd_TypeInfo);
		    DAT_ram_00a57fde = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *param1_01;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x230);
		        goto code_r0x80e8e913;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e8e913:
		  uVar2 = CONCAT44(in_register_20000014,puVar3[1]);
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,uVar2);
		  uVar5 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  iVar6 = Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Handle
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x18) + 8),param5,0);
		  if (iVar6 != 0) {
		    iVar6 = unnamed_function_1417(Protocol_Clans_ProtoCreateClanCmd_TypeInfo);
		    Protocol_Clans_ProtoCreateClanCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar6,0);
		    Protocol_Clans_ProtoCreateClanCmd__get_Name(iVar6,param2,0);
		    Protocol_Clans_ProtoCreateClanCmd__get_Description(iVar6,param3,0);
		    *(undefined4 *)(iVar6 + 0x14) = param4;
		    param1_02 = param1[8];
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(uVar5,*(undefined4 *)(*param1 + 0x104)));
		    uVar5 = ServicesNamespace_ClansService__GetMembersList
		                      (param1_02,*(undefined8 *)(iVar4 + 0x10),iVar6,0);
		    param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanInfoController_ChangeClanInfoResultHandler__
		               ,0);
		    ServicesNamespace_MainService__GetUserStats
		              (uVar5,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003EED RID: 16109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EED")]
		[Address(RVA = "0x8DA9", Offset = "0x8DA9", VA = "0x8DA9")]
		public void ChangeClan(string name, string description, bool isFraction, ResourceSet price)
		{
		/* --- GHIDRA: ChangeClan ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__ChangeClan
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a57fdf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors__ExpectedCreateClanErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoChangeClanInfoAns_TypeInfo);
		    DAT_ram_00a57fdf = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Clans_ProtoChangeClanInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Clans_ProtoChangeClanInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_00[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors__ExpectedCreateClanErrors___
		                    );
		  if (iVar1 == 0) {
		    Gameplay_Clans_Office_Controller_ClanInfoController___ctor(param1,param1_00);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EEE")]
		[Address(RVA = "0x8DAA", Offset = "0x8DAA", VA = "0x8DAA")]
		private void ChangeClanInfoResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: ChangeClanInfoResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__ChangeClanInfoResultHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Clans_Office_Controller_ClanInfoController__LeaveClan(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06003EEF RID: 16111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EEF")]
		[Address(RVA = "0x8DAB", Offset = "0x8DAB", VA = "0x8DAB")]
		public void AppointHead(UserData user)
		{
		/* --- GHIDRA: AppointHead ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__AppointHead
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined8 param3_00;
		  int param1_01;
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a57fe0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanInfoController_AppointHeadResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a57fe0 = '\x01';
		  }
		  param1_01 = param1[8];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param2_00 = *(undefined8 *)(iVar1 + 0x10);
		  param3_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param2,0);
		  uVar2 = ServicesNamespace_ClansService__KickMember(param1_01,param2_00,param3_00,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanInfoController_AppointHeadResultHandler__,0
		            );
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  DG_Tweening_TweenParams__SetId
		            (uVar2,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  return;
		}
		*/

		}

		// Token: 0x06003EF0 RID: 16112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF0")]
		[Address(RVA = "0x8DAC", Offset = "0x8DAC", VA = "0x8DAC")]
		private void RequestAppointHead(UserData user)
		{
		/* --- GHIDRA: RequestAppointHead ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__RequestAppointHead
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param5;
		  undefined4 param1_00;
		  int *param1_01;
		  int *param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a57fe1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoAppointHeadAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_RequirementsWindow_RequirementsWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_UserData_TypeInfo);
		    DAT_ram_00a57fe1 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  param1_02 = *(int **)(param2 + 0xc);
		  if (param1_02 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_02 + 0xb8) < (uint)*(byte *)(Core_Data_UserData_TypeInfo + 0xb8))
		       || (*(int *)(*(int *)(*param1_02 + 100) +
		                    (uint)*(byte *)(Core_Data_UserData_TypeInfo + 0xb8) * 4 + -4) !=
		           Core_Data_UserData_TypeInfo)) {
		      System_Activator__CreateInstance(param1_02,Core_Data_UserData_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if ((param1_01 != (int *)0x0) && (Protocol_Clans_ProtoAppointHeadAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Clans_ProtoAppointHeadAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = param1_01[3];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar2 == -3) {
		    param5 = Gameplay_Clans_Model_ClansModel__TryGetBuilding(*(undefined4 *)(iVar1 + 0x24),0);
		    param1_00 = unnamed_function_1417(UI_Windows_RequirementsWindow_RequirementsWindowArgs_TypeInfo)
		    ;
		    UI_Windows_RequirementsWindow_RequirementsWindowArgs___ctor(param1_00,0,param1_02,0,param5,0,0);
		    UI_Windows_RequirementsWindow__HandleContent(param1_00,0);
		    return;
		  }
		  *(int **)(*(int *)(*(int *)(iVar1 + 8) + 0x68) + 0x14) = param1_02;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x2c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF1")]
		[Address(RVA = "0x8DAD", Offset = "0x8DAD", VA = "0x8DAD")]
		private void AppointHeadResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: AppointHeadResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__AppointHeadResultHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 param1_00;
		  int *param1_01;
		  int param1_02;
		  int iVar6;
		  
		  if (DAT_ram_00a57fe2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_ClanInfoController_AddVacancyResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a57fe2 = '\x01';
		  }
		  iVar6 = *param1;
		  uVar2 = CONCAT44(in_register_20000014,*(undefined4 *)(iVar6 + 0x104));
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x100) * 4))(param1,uVar2);
		  uVar5 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar3 = Gameplay_Clans_Office_Model_ClanInfoModel__PopulateMembers(uVar3,iVar6);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *param1_01;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x230);
		        goto code_r0x80e8f07a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e8f07a:
		  uVar2 = CONCAT44(uVar5,puVar4[1]);
		  iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar2);
		  uVar5 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  iVar6 = Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Handle
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x18) + 8),uVar3,0);
		  if (iVar6 != 0) {
		    param1_02 = param1[8];
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(uVar5,*(undefined4 *)(*param1 + 0x104)));
		    uVar5 = ServicesNamespace_ClansService__AppointHead(param1_02,*(undefined8 *)(iVar6 + 0x10),0);
		    param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanInfoController_AddVacancyResultHandler__,
		               0);
		    uVar5 = ServicesNamespace_MainService__GetUserStats
		                      (uVar5,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DG_Tweening_TweenParams__SetId
		              (uVar5,uVar3,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF2")]
		[Address(RVA = "0x8DAE", Offset = "0x8DAE", VA = "0x8DAE")]
		public void AddVacancy()
		{
		/* --- GHIDRA: AddVacancy ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__AddVacancy
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  undefined4 param3_00;
		  undefined4 param4;
		  int local_4;
		  
		  if (DAT_ram_00a57fe3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ClansScope_ClanIsleEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7482);
		    DAT_ram_00a57fe3 = '\x01';
		  }
		  piVar5 = *(int **)(param2 + 0x20);
		  if ((piVar5 != (int *)0x0) && (Protocol_Common_ProtoDefaultAns_TypeInfo != *piVar5)) {
		    System_Activator__CreateInstance(piVar5,Protocol_Common_ProtoDefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (piVar5[3] < 0) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    local_4 = piVar5[3];
		    uVar4 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar4 = func_ii_4419(StringLiteral_7482,uVar4,0);
		    Core_Application_App__get_ToastController(uVar2,2,uVar4,0);
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = *(int *)(*(int *)(iVar1 + 0x30) + 8);
		    *(int *)(iVar1 + 0x1c) = *(int *)(iVar1 + 0x1c) + 1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x30);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		    piVar5 = *(int **)(param2 + 0xc);
		    if ((piVar5 != (int *)0x0) && (Protocol_Common_ResourceSet_TypeInfo != *piVar5)) {
		      System_Activator__CreateInstance(piVar5,Protocol_Common_ResourceSet_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x84) + 0x1c);
		    if (iVar1 != 0) {
		      uVar2 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param4 = *(undefined4 *)(*(int *)(iVar3 + 0x30) + 8);
		      uVar4 = unnamed_function_1417(Core_Events_Scopes_ClansScope_ClanIsleEventArgs_TypeInfo);
		      Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		                (uVar4,uVar2,param3_00,param4,piVar5,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),uVar4,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF3")]
		[Address(RVA = "0x8DAF", Offset = "0x8DAF", VA = "0x8DAF")]
		private void AddVacancyResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: AddVacancyResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__AddVacancyResultHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57fe4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanInfoController_SetClanStateFlagsResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a57fe4 = '\x01';
		  }
		  param1_00 = param1[8];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  uVar2 = ServicesNamespace_ClansService__BuyAddPlace
		                    (param1_00,*(undefined8 *)(iVar1 + 0x10),param2,0);
		  uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanInfoController_SetClanStateFlagsResultHandler__
		             ,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_4 = param2;
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  DG_Tweening_TweenParams__SetId(uVar2,uVar3,Method_Utils_OpToken_IMessage__object__SetCustomData__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF4")]
		[Address(RVA = "0x8DB0", Offset = "0x8DB0", VA = "0x8DB0")]
		public void SetClanStateFlags(uint flags)
		{
		/* --- GHIDRA: SetClanStateFlags ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__SetClanStateFlags
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  int iVar2;
		  int *param1_00;
		  uint uVar3;
		  int iVar4;
		  
		  param1_00 = *(int **)(param2 + 0xc);
		  if (param1_00 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*param1_00 + 0x20) == *(int *)(DAT_ram_00a66958 + 0x20)) {
		    puVar1 = (uint *)func_ii_15774(param1_00);
		    uVar3 = *puVar1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = *(int *)(*(int *)(*(int *)(iVar2 + 0x30) + 0xc) + 0x1c);
		    iVar4 = 2;
		    if ((uVar3 & 2) == 0) {
		      iVar4 = -2;
		    }
		    *(int *)(iVar2 + 0x20) = *(int *)(iVar2 + 0x20) + iVar4;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x34);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,DAT_ram_00a66958);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003EF5 RID: 16117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF5")]
		[Address(RVA = "0x8DB1", Offset = "0x8DB1", VA = "0x8DB1")]
		private void SetClanStateFlagsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: SetClanStateFlagsResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__SetClanStateFlagsResultHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a57fe5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanInfoController_AddToTreasuryResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a57fe5 = '\x01';
		  }
		  param1_01 = param1[8];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  uVar2 = ServicesNamespace_ClansService__GetClanTreasury
		                    (param1_01,*(undefined8 *)(iVar1 + 0x10),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanInfoController_AddToTreasuryResultHandler__
		             ,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  uVar2 = DG_Tweening_TweenParams__SetId
		                    (uVar2,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003EF6 RID: 16118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF6")]
		[Address(RVA = "0x8DB2", Offset = "0x8DB2", VA = "0x8DB2")]
		public void AddToTreasury(ResourceSet resourceSet)
		{
		/* --- GHIDRA: AddToTreasury ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__AddToTreasury
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  undefined4 param3_00;
		  undefined4 param4;
		  
		  if (DAT_ram_00a57fe6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ClansScope_ClansEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoAddToTreasuryAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a57fe6 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar3 = *(int **)(param2 + 0x20);
		  if ((piVar3 != (int *)0x0) && (Protocol_Clans_ProtoAddToTreasuryAns_TypeInfo != *piVar3)) {
		    System_Activator__CreateInstance(piVar3,Protocol_Clans_ProtoAddToTreasuryAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (piVar3[3] == -0x14) {
		    func_ii_6929(param1,param2);
		    return;
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (piVar3[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		                    );
		  if (iVar1 == 0) {
		    piVar3 = *(int **)(param2 + 0xc);
		    if ((piVar3 != (int *)0x0) && (Protocol_Common_ResourceSet_TypeInfo != *piVar3)) {
		      System_Activator__CreateInstance(piVar3,Protocol_Common_ResourceSet_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x84) + 0x14);
		    if (iVar1 != 0) {
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param4 = *(undefined4 *)(*(int *)(iVar2 + 0x30) + 0xc);
		      param1_00 = unnamed_function_1417(Core_Events_Scopes_ClansScope_ClansEventArgs_TypeInfo);
		      Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		                (param1_00,param2_00,param3_00,param4,piVar3,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF7")]
		[Address(RVA = "0x8DB3", Offset = "0x8DB3", VA = "0x8DB3")]
		private void AddToTreasuryResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: AddToTreasuryResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__AddToTreasuryResultHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Clans_Controller_ClansController__UserInfoChangedEventHandler
		            (param1_00,*(undefined4 *)(*(int *)(iVar1 + 0x30) + 0xc),0);
		  return;
		}
		*/

		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF8")]
		[Address(RVA = "0x8DB4", Offset = "0x8DB4", VA = "0x8DB4")]
		public void DisbandClan()
		{
		/* --- GHIDRA: DisbandClan ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__DisbandClan(int param1,undefined4 param2)
		
		{
		  Gameplay_Clans_Controller_ClansController__KickMemberResultHandler
		            (*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x06003EF9 RID: 16121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF9")]
		[Address(RVA = "0x8DB5", Offset = "0x8DB5", VA = "0x8DB5")]
		public void LeaveClan()
		{
		/* --- GHIDRA: LeaveClan ---
		undefined4
		Gameplay_Clans_Office_Controller_ClanInfoController__LeaveClan
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 param3_00;
		  int param1_00;
		  int iVar7;
		  int *param1_01;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57fe8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
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
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanInfoController___c__DisplayClass27_0__ShowAppintHeadDialogWindow_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Controller_ClanInfoController___c__DisplayClass27_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25417);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4200);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25589);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4201);
		    DAT_ram_00a57fe8 = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_Clans_Office_Controller_ClanInfoController___c__DisplayClass27_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar2 + 0xc) = param2;
		  *(int **)(iVar2 + 8) = param1;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a57f87 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57f87 = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = *(int **)(iVar3 + 0xc);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80e8ebc4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e8ebc4:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(param1_01,puVar4[1]);
		  Core_Extensions_Dict_DictExt__GetBoolParameter(uVar5,StringLiteral_25417,0);
		  iVar3 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(iVar3,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4201,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar3 + 0x18) = uVar5;
		  uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4200,1,0,1,0,0,0,0);
		  iVar6 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  param3_00 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                        (*(undefined4 *)(iVar2 + 0xc),0);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_25589,param3_00,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar6 + 0x10) = local_8;
		  uVar5 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar5,iVar6,0);
		  *(undefined4 *)(iVar3 + 0x1c) = uVar5;
		  iVar6 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                    );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar6,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  param1_00 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_00,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar5 = UI_Windows_DialogWindow__get_WindowId(0);
		  *(undefined4 *)(param1_00 + 8) = uVar5;
		  iVar7 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar5 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar5,iVar2,
		             Method_Gameplay_Clans_Office_Controller_ClanInfoController___c__DisplayClass27_0__ShowAppintHeadDialogWindow_b__0__
		             ,0);
		  *(undefined4 *)(iVar7 + 8) = uVar5;
		  *(int *)(param1_00 + 0x14) = iVar7;
		  iVar2 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		  uVar1 = *(uint *)(iVar6 + 0xc);
		  if (uVar1 < *(uint *)(*(int *)(iVar6 + 8) + 0xc)) {
		    *(uint *)(iVar6 + 0xc) = uVar1 + 1;
		    *(int *)(*(int *)(iVar6 + 8) + uVar1 * 4 + 0x10) = param1_00;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar6,param1_00,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(iVar3 + 0x24) = iVar6;
		  uVar5 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (iVar3,0);
		  return uVar5;
		}
		*/

		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003EFA")]
		[Address(RVA = "0x1B12", Offset = "0x1B12", VA = "0x1B12")]
		public DialogWindow ShowFeeTooSmallDialogWindow()
		{
			return null;
		}

		// Token: 0x06003EFB RID: 16123 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003EFB")]
		[Address(RVA = "0x8DB6", Offset = "0x8DB6", VA = "0x8DB6")]
		public DialogWindow ShowAppintHeadDialogWindow(UserData user)
		{
		/* --- GHIDRA: ShowAppintHeadDialogWindow ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__ShowAppintHeadDialogWindow
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57fe9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUnregisterClanAns__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_ClanInfoController_ClanUnregisteredHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanInfoController_HandleUserBalanceChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanInfoController_UserLeftClanEventHandler__
		              );
		    DAT_ram_00a57fe9 = '\x01';
		  }
		  Gameplay_Clans_Office_Controller_ClanInfoController___ctor(param1,param1);
		  iVar2 = param1[8];
		  uVar1 = unnamed_function_1417(System_Action_ProtoUserLeftClanEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanInfoController_UserLeftClanEventHandler__,0
		            );
		  ServicesNamespace_ClansService__remove_TreasuryChangedEvent(iVar2,uVar1,0);
		  iVar2 = param1[8];
		  uVar1 = unnamed_function_1417(System_Action_ProtoUnregisterClanAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanInfoController_ClanUnregisteredHandler__,0)
		  ;
		  ServicesNamespace_ClansService__remove_ClanCreatedEvent(iVar2,uVar1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(undefined4 *)(iVar2 + 8);
		  uVar1 = unnamed_function_1417(Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		  Core_Data_InfoRows_CollectionRow___ctor
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanInfoController_HandleUserBalanceChangedEvent__
		             ,0);
		  Core_Data_UserData__remove_OnUserInfoChangedEvent(param1_00,uVar1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003EFC RID: 16124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EFC")]
		[Address(RVA = "0x8DB7", Offset = "0x8DB7", VA = "0x8DB7", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__HandleRun(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57fea == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUnregisterClanAns__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_ClanInfoController_ClanUnregisteredHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanInfoController_HandleUserBalanceChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanInfoController_UserLeftClanEventHandler__
		              );
		    DAT_ram_00a57fea = '\x01';
		  }
		  iVar2 = param1[8];
		  uVar1 = unnamed_function_1417(System_Action_ProtoUserLeftClanEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanInfoController_UserLeftClanEventHandler__,0
		            );
		  ServicesNamespace_ClansService__add_UserLeftClanEvent(iVar2,uVar1,0);
		  iVar2 = param1[8];
		  uVar1 = unnamed_function_1417(System_Action_ProtoUnregisterClanAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanInfoController_ClanUnregisteredHandler__,0)
		  ;
		  ServicesNamespace_ClansService__add_ClanUnregisteredEvent(iVar2,uVar1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(undefined4 *)(iVar2 + 8);
		  uVar1 = unnamed_function_1417(Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		  Core_Data_InfoRows_CollectionRow___ctor
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanInfoController_HandleUserBalanceChangedEvent__
		             ,0);
		  Core_Data_UserData__add_BalanceChangedEvent(param1_00,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EFD")]
		[Address(RVA = "0x8DB8", Offset = "0x8DB8", VA = "0x8DB8", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__HandleStop
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x3c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,param3,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EFE")]
		[Address(RVA = "0x8DB9", Offset = "0x8DB9", VA = "0x8DB9")]
		private void HandleUserBalanceChangedEvent(ResourceSet balance, ResourceSet delta)
		{
		/* --- GHIDRA: HandleUserBalanceChangedEvent ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__HandleUserBalanceChangedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  UI_Windows_PopupController__Close(uVar1,3,0);
		  return;
		}
		*/

		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EFF")]
		[Address(RVA = "0x8DBA", Offset = "0x8DBA", VA = "0x8DBA")]
		private void ClanUnregisteredHandler(ProtoUnregisterClanAns ans)
		{
		/* --- GHIDRA: ClanUnregisteredHandler ---
		void Gameplay_Clans_Office_Controller_ClanInfoController__ClanUnregisteredHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  longlong lVar4;
		  undefined4 param1_00;
		  longlong lVar5;
		  
		  if (DAT_ram_00a57feb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_ClanMemberListElement_ClanMemberListElementArgs__RemoveAll__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Predicate_ClanMemberListElement_ClanMemberListElementArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanInfoController___c__DisplayClass32_0__UserLeftClanEventHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Controller_ClanInfoController___c__DisplayClass32_0_TypeInfo);
		    DAT_ram_00a57feb = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Clans_Office_Controller_ClanInfoController___c__DisplayClass32_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 8) = param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar2 != 0) {
		    lVar5 = *(longlong *)(*(int *)(iVar1 + 8) + 0x10);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    lVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(iVar2 + 8),0);
		    if (lVar5 == lVar4) {
		      uVar3 = System_Uri___ctor(0);
		      uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar3,0);
		      UI_Windows_PopupController__Close(uVar3,3,0);
		      return;
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param1_00 = *(undefined4 *)(iVar2 + 0x34);
		    uVar3 = unnamed_function_1417
		                      (System_Predicate_ClanMemberListElement_ClanMemberListElementArgs__TypeInfo);
		    func_ii_7297(uVar3,iVar1,
		                 Method_Gameplay_Clans_Office_Controller_ClanInfoController___c__DisplayClass32_0__UserLeftClanEventHandler_b__0__
		                 ,0);
		    System_Collections_Generic_List_object___IsCompatibleObject
		              (param1_00,uVar3,
		               Method_System_Collections_Generic_List_ClanMemberListElement_ClanMemberListElementArgs__RemoveAll__
		              );
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x28);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F00")]
		[Address(RVA = "0x8DBB", Offset = "0x8DBB", VA = "0x8DBB")]
		private void UserLeftClanEventHandler(ProtoUserLeftClanEvt evt)
		{
		}

		// Token: 0x0400237C RID: 9084
		[Token(Token = "0x400237C")]
		[FieldOffset(Offset = "0x18")]
		public readonly ClansController ClansController;

		// Token: 0x0400237D RID: 9085
		[Token(Token = "0x400237D")]
		[FieldOffset(Offset = "0x1C")]
		private readonly ClanIsleService _clanIsleService;

		// Token: 0x0400237E RID: 9086
		[Token(Token = "0x400237E")]
		[FieldOffset(Offset = "0x20")]
		private readonly ClansService _clansService;

		// Token: 0x0400237F RID: 9087
		[Token(Token = "0x400237F")]
		[FieldOffset(Offset = "0x24")]
		private readonly CommandsRepository _commandsRepository;
	}
}
