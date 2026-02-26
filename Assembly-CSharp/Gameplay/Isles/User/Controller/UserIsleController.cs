using System;
using System.Collections;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Isles.Base.Controller;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.World.Events;
using Gameplay.World.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.World;
using ServicesNamespace;
using UnityEngine;
using Utils;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D3B RID: 3387
	[Token(Token = "0x2000D3B")]
	public class UserIsleController : BaseIsleController<UserIsleModel, UserIsleEvents>
	{
		// Token: 0x060052E0 RID: 21216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E0")]
		[Address(RVA = "0xA0B6", Offset = "0xA0B6", VA = "0xA0B6")]
		public UserIsleController(UserIsleModel model, UserIsleEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_User_Controller_UserIsleController___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5939a == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Queue_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17350);
		    DAT_ram_00a5939a = '\x01';
		  }
		  if (*(int *)(param1 + 0x28) != 0) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_17350,0);
		    return;
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Queue_uint__TypeInfo);
		  System_Collections_Generic_Queue_uint____ctor
		            (param1_00,param2,Method_System_Collections_Generic_Queue_uint___ctor__);
		  *(undefined4 *)(param1 + 0x28) = param1_00;
		  Gameplay_Isles_User_Controller_UserIsleController__CollectAllBonuses(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E1")]
		[Address(RVA = "0xA0B7", Offset = "0xA0B7", VA = "0xA0B7")]
		public void CollectAllBonuses(uint[] positionIds)
		{
		/* --- GHIDRA: CollectAllBonuses ---
		void Gameplay_Isles_User_Controller_UserIsleController__CollectAllBonuses
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  undefined8 param2_00;
		  int param1_01;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5939b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_uint___);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_uint__Dequeue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_Controller_UserIsleController_GetBonusServiceHandler__);
		    DAT_ram_00a5939b = '\x01';
		  }
		  iVar1 = System_Linq_Enumerable__Any_int_(param1[10],Method_System_Linq_Enumerable_Any_uint___);
		  if (iVar1 != 0) {
		    uVar2 = System_Collections_Generic_Queue_uint___Clear
		                      (param1[10],Method_System_Collections_Generic_Queue_uint__Dequeue__);
		    param1_01 = param1[7];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		    param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                          (*(undefined4 *)(iVar1 + 8),0);
		    uVar3 = ServicesNamespace_TreeService__BuyLicense(param1_01,param2_00,uVar2,0);
		    param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_Isles_User_Controller_UserIsleController_GetBonusServiceHandler__,0);
		    uVar3 = ServicesNamespace_MainService__GetUserStats
		                      (uVar3,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    local_4 = uVar2;
		    uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		    uVar2 = DG_Tweening_TweenParams__SetId
		                      (uVar3,uVar2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E2")]
		[Address(RVA = "0xA0B8", Offset = "0xA0B8", VA = "0xA0B8")]
		private void HandleBonusQueue()
		{
		/* --- GHIDRA: HandleBonusQueue ---
		void Gameplay_Isles_User_Controller_UserIsleController__HandleBonusQueue
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 param3_00;
		  undefined8 param5;
		  int param2_00;
		  int local_4;
		  
		  if (DAT_ram_00a5939c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedGetIsleBonusErrors___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Errors_Expected_ExpectedGetIsleBonusErrors_ExpectedGetIsleBonusErrorsArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_IsleScope_IsleBonusEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Tree_ProtoGetBonusAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__set_Item__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_Controller_UserIsleController_OnDiamondIsleFound__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9962);
		    DAT_ram_00a5939c = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Tree_ProtoGetBonusAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Tree_ProtoGetBonusAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar3 = *(int **)(param2 + 0xc);
		  if (piVar3 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*piVar3 + 0x20) == *(int *)(DAT_ram_00a66958 + 0x20)) {
		    piVar3 = (int *)func_ii_15774(piVar3);
		    iVar4 = *piVar3;
		    iVar5 = param1_01[3];
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Isles_User_Controller_UserIsleController_OnDiamondIsleFound__,0);
		    uVar2 = unnamed_function_1417
		                      (
		                      Core_Errors_Expected_ExpectedGetIsleBonusErrors_ExpectedGetIsleBonusErrorsArgs_TypeInfo
		                      );
		    Unity_Services_Core_Environments_Internal_Environments__get_Current(uVar2,uVar1,0);
		    iVar5 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                      (iVar5,uVar2,
		                       Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedGetIsleBonusErrors___
		                      );
		    if (iVar5 == 0) {
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param2_00 = iVar4 + -1;
		      if (param2_00 < *(int *)(*(int *)(*(int *)(iVar5 + 0x34) + 0x18) + 0xc)) {
		        iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        Google_Protobuf_Collections_RepeatedField_uint___get_IsReadOnly
		                  (*(undefined4 *)(*(int *)(iVar5 + 0x34) + 0x18),param2_00,0,
		                   Method_Google_Protobuf_Collections_RepeatedField_uint__set_Item__);
		      }
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      iVar5 = Gameplay_Isles_User_Model_UserIsleModel__get_OwnerId(uVar1,0);
		      if (iVar5 == 0) {
		        uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        Gameplay_Isles_User_Model_UserIsleModel__get_IsLicenceSpent(uVar1,1,0);
		        iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        Core_Data_UserData__get_LicenseCount
		                  (*(int *)(iVar5 + 0x48),*(int *)(*(int *)(iVar5 + 0x48) + 0x60) + -1,0);
		      }
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar5 = *(int *)(iVar5 + 0x40);
		      if (iVar5 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                  (*(undefined4 *)(iVar5 + 0x20),iVar4,*(undefined4 *)(iVar5 + 0x14));
		      }
		      Gameplay_Isles_User_Controller_UserIsleController__CollectAllBonuses(param1,param1);
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      if (*(char *)(iVar5 + 0x18) == '\0') {
		        iVar5 = System_Uri___ctor(0);
		        iVar5 = *(int *)(*(int *)(*(int *)(*(int *)(iVar5 + 0x38) + 0x10) + 0x3c) + 8);
		        if (iVar5 != 0) {
		          uVar1 = System_Uri___ctor(0);
		          if (DAT_ram_00a6456f == '\0') {
		            Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		            DAT_ram_00a6456f = '\x01';
		          }
		          param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		          uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		          uVar2 = Gameplay_Isles_User_Model_UserIsleModel__set_IsDiamondIsle(uVar2,0);
		          iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		          param5 = *(undefined8 *)(iVar4 + 0x10);
		          param1_00 = unnamed_function_1417
		                                (Core_Events_Scopes_IsleScope_IsleBonusEventArgs_TypeInfo);
		          Core_Events_Scopes_SchoolScope_SchoolEventArgs__get_OwnerId
		                    (param1_00,uVar1,param3_00,uVar2,param5,0);
		          (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                    (*(undefined4 *)(iVar5 + 0x20),param1_00,*(undefined4 *)(iVar5 + 0x14));
		        }
		      }
		    }
		    else {
		      local_4 = param1_01[3];
		      uVar1 = func_ii_1081(DAT_ram_00a66954,&local_4);
		      uVar1 = func_ii_4419(StringLiteral_9962,uVar1,0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		    }
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,DAT_ram_00a66958);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E3")]
		[Address(RVA = "0xA0B9", Offset = "0xA0B9", VA = "0xA0B9")]
		private void GetBonusServiceHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetBonusServiceHandler ---
		void Gameplay_Isles_User_Controller_UserIsleController__GetBonusServiceHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = Gameplay_Isles_User_Model_UserIsleModel__get_OwnerId(uVar1,0);
		  if (iVar2 == 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Isles_User_Model_UserIsleModel__get_IsLicenceSpent(uVar1,1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Core_Data_UserData__get_LicenseCount
		              (*(int *)(iVar2 + 0x48),*(int *)(*(int *)(iVar2 + 0x48) + 0x60) + -1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E4")]
		[Address(RVA = "0xA0BA", Offset = "0xA0BA", VA = "0xA0BA")]
		private void HandleLicenceSpent()
		{
		/* --- GHIDRA: HandleLicenceSpent ---
		void Gameplay_Isles_User_Controller_UserIsleController__HandleLicenceSpent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Isles_User_Model_UserIsleModel__get_IsDiamondIsle(uVar1,1,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = Gameplay_Isles_User_Model_UserIsleModel__get_OwnerId(uVar1,0);
		  if (iVar2 == 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Isles_User_Model_UserIsleModel__get_IsLicenceSpent(uVar1,1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Core_Data_UserData__get_LicenseCount
		              (*(int *)(iVar2 + 0x48),*(int *)(*(int *)(iVar2 + 0x48) + 0x60) + -1,0);
		  }
		  param1[10] = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x44);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E5")]
		[Address(RVA = "0xA0BB", Offset = "0xA0BB", VA = "0xA0BB")]
		private void OnDiamondIsleFound()
		{
		/* --- GHIDRA: OnDiamondIsleFound ---
		void Gameplay_Isles_User_Controller_UserIsleController__OnDiamondIsleFound
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5939d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_StartBuildingServiceHandler__
		              );
		    DAT_ram_00a5939d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if ((*(byte *)(iVar1 + 0x30) & 1) == 0) {
		    uVar2 = ServicesNamespace_WorldService__GetMonsterInfo(param1[6],param2,0);
		    uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Isles_User_Controller_UserIsleController_StartBuildingServiceHandler__
		               ,0);
		    uVar2 = ServicesNamespace_MainService__GetUserStats
		                      (uVar2,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    local_4 = param2;
		    uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		    uVar2 = DG_Tweening_TweenParams__SetId
		                      (uVar2,uVar3,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x30) = *(int *)(iVar1 + 0x30) + 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E6")]
		[Address(RVA = "0xA0BC", Offset = "0xA0BC", VA = "0xA0BC")]
		public void StartBuild(uint buildingTypeId)
		{
		/* --- GHIDRA: StartBuild ---
		void Gameplay_Isles_User_Controller_UserIsleController__StartBuild
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  undefined4 uVar4;
		  int *param1_01;
		  int param1_02;
		  undefined4 param2_00;
		  undefined4 param4;
		  undefined4 param5;
		  
		  if (DAT_ram_00a5939e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedRequirementsErrors__ExpectedBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoStartBuildingAns_TypeInfo);
		    DAT_ram_00a5939e = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(int *)(iVar1 + 0x30) = *(int *)(iVar1 + 0x30) + -1;
		  piVar3 = *(int **)(param2 + 0xc);
		  if (piVar3 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*piVar3 + 0x20) != *(int *)(DAT_ram_00a66958 + 0x20)) {
		    System_Activator__CreateInstance(piVar3,DAT_ram_00a66958);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  puVar2 = (undefined4 *)func_ii_15774(piVar3);
		  uVar4 = *puVar2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar3 = (int *)System_Collections_Generic_List_object___get_Item
		                            (*(undefined4 *)(iVar1 + 0x24),uVar4,
		                             Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                            );
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_World_ProtoStartBuildingAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_World_ProtoStartBuildingAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_02 = param1_01[3];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined4 *)(iVar1 + 8);
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x138) * 4))
		                    (piVar3,*(undefined4 *)(*piVar3 + 0x13c));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x128) * 4))
		                    (piVar3,*(undefined4 *)(*piVar3 + 300));
		  param4 = *(undefined4 *)(iVar1 + 0x18);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x128) * 4))
		                    (piVar3,*(undefined4 *)(*piVar3 + 300));
		  param5 = *(undefined4 *)(iVar1 + 0x14);
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo
		                        );
		  Unity_Services_Core_Internal_DependencyTree___ctor(param1_00,param2_00,uVar4,param4,param5,0);
		  Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		            (param1_02,param1_00,0,
		             Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedRequirementsErrors__ExpectedBillingErrors___
		            );
		  return;
		}
		*/

		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E7")]
		[Address(RVA = "0xA0BD", Offset = "0xA0BD", VA = "0xA0BD")]
		private void StartBuildingServiceHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: StartBuildingServiceHandler ---
		undefined4
		Gameplay_Isles_User_Controller_UserIsleController__StartBuildingServiceHandler
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 in_register_20000014;
		  int iVar2;
		  undefined4 uVar3;
		  undefined8 uVar4;
		  int param1_00;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5939f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_AccelerateBuildingServiceHandler__
		              );
		    DAT_ram_00a5939f = '\x01';
		  }
		  local_4 = 0;
		  uVar4 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar4);
		  uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  iVar2 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(iVar2 + 0x24),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__
		                    );
		  if ((iVar2 != 0) && (iVar2 = func_ii_8742(local_4,0), iVar2 != 0)) {
		    param1_00 = param1[6];
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x104)));
		    uVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(iVar2 + 8),0);
		    uVar1 = ServicesNamespace_WorldService__StartBuilding(param1_00,uVar4,param2,0);
		    uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Isles_User_Controller_UserIsleController_AccelerateBuildingServiceHandler__
		               ,0);
		    uVar1 = ServicesNamespace_MainService__GetUserStats
		                      (uVar1,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    local_8 = param2;
		    uVar3 = func_ii_1081(DAT_ram_00a66958,&local_8);
		    uVar1 = DG_Tweening_TweenParams__SetId
		                      (uVar1,uVar3,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		    uVar1 = 1;
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x0000F018 File Offset: 0x0000D218
		[Token(Token = "0x60052E8")]
		[Address(RVA = "0xA0BE", Offset = "0xA0BE", VA = "0xA0BE")]
		public bool TryAccelerateBuild(uint buildingTypeId)
		{
		/* --- GHIDRA: TryAccelerateBuild ---
		void Gameplay_Isles_User_Controller_UserIsleController__TryAccelerateBuild
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a593a0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoAccelerateBuildingAns_TypeInfo);
		    DAT_ram_00a593a0 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_World_ProtoAccelerateBuildingAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_World_ProtoAccelerateBuildingAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		            (param1_00[3],0,
		             Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E9")]
		[Address(RVA = "0xA0BF", Offset = "0xA0BF", VA = "0xA0BF")]
		private void AccelerateBuildingServiceHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: AccelerateBuildingServiceHandler ---
		void Gameplay_Isles_User_Controller_UserIsleController__AccelerateBuildingServiceHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a593a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_CancelBuildingServiceHandler__
		              );
		    DAT_ram_00a593a1 = '\x01';
		  }
		  uVar1 = ServicesNamespace_WorldService__AccelerateBuilding
		                    (*(undefined4 *)(param1 + 0x18),param2,0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_CancelBuildingServiceHandler__
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

		// Token: 0x060052EA RID: 21226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052EA")]
		[Address(RVA = "0xA0C0", Offset = "0xA0C0", VA = "0xA0C0")]
		public void CancelBuild(uint buildingTypeId)
		{
		/* --- GHIDRA: CancelBuild ---
		undefined4
		Gameplay_Isles_User_Controller_UserIsleController__CancelBuild
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  double param2_00;
		  
		  if (DAT_ram_00a593a2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a593a2 = '\x01';
		  }
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  uVar5 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  piVar3 = (int *)System_Collections_Generic_List_object___get_Item
		                            (*(undefined4 *)(iVar2 + 0x24),param2,
		                             Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                            );
		  uVar1 = CONCAT44(uVar5,*(undefined4 *)(*piVar3 + 0x13c));
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x138) * 4))(piVar3,uVar1);
		  uVar5 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar4 = Protocol_Common_ResourceSet___ctor(uVar4,0);
		  uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(uVar5,*(undefined4 *)(*param1 + 0x104)));
		  param2_00 = Gameplay_Isles_User_Model_UserIsleModel___ctor(uVar5,0);
		  uVar5 = Core_Extensions_Dict_ResourceSetExt__Round(uVar4,param2_00,0);
		  uVar5 = Core_Extensions_Dict_ResourceSetExt__SetValue(uVar5,0);
		  return uVar5;
		}
		*/

		}

		// Token: 0x060052EB RID: 21227 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60052EB")]
		[Address(RVA = "0xA0C1", Offset = "0xA0C1", VA = "0xA0C1")]
		public ResourceSet GetCancelImproveMoneyBack(uint buildingType)
		{
		/* --- GHIDRA: GetCancelImproveMoneyBack ---
		void Gameplay_Isles_User_Controller_UserIsleController__GetCancelImproveMoneyBack
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  undefined4 local_8;
		  int local_4;
		  
		  if (DAT_ram_00a593a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22975);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9963);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27891);
		    DAT_ram_00a593a3 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar3 = *(int **)(param2 + 0xc);
		  if (piVar3 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*piVar3 + 0x20) != *(int *)(DAT_ram_00a66958 + 0x20)) {
		    System_Activator__CreateInstance(piVar3,DAT_ram_00a66958);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  puVar1 = (undefined4 *)func_ii_15774(piVar3);
		  uVar4 = *puVar1;
		  piVar3 = *(int **)(param2 + 0x20);
		  if ((piVar3 != (int *)0x0) && (Protocol_Common_ProtoDefaultAns_TypeInfo != *piVar3)) {
		    System_Activator__CreateInstance(piVar3,Protocol_Common_ProtoDefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  local_4 = piVar3[3];
		  if (local_4 < 0) {
		    uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar2 = func_ii_4419(StringLiteral_22975,uVar2,0);
		    local_8 = uVar4;
		    uVar4 = func_ii_1081(DAT_ram_00a66958,&local_8);
		    uVar4 = func_ii_4419(StringLiteral_27891,uVar4,0);
		    uVar4 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (StringLiteral_9963,uVar2,uVar4,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar4,0);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052EC")]
		[Address(RVA = "0xA0C2", Offset = "0xA0C2", VA = "0xA0C2")]
		private void CancelBuildingServiceHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: CancelBuildingServiceHandler ---
		void Gameplay_Isles_User_Controller_UserIsleController__CancelBuildingServiceHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *param1_00;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a593a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingFinishedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoAnimationStartedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingStartedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoIsleMonsterFlewAwayEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserIsleBuildingViewChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingCanceledEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AccountInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingAcceleratedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserIsleDecorationAddedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserIsleDecorationRemovedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Action_ulong__WorldControllerEvents_MonsterChangeReason__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_Controller_UserIsleController_HandleAccountChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_IsleMonsterFlewAwayEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_Controller_UserIsleController_OnMonsterChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnAnimationStartedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnBuildingAcceleratedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnBuildingCanceledEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnBuildingFinishedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnBuildingStartedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnUserIsleDecorationAddedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnUserIsleDecorationRemovedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceUserIsleBuildingViewChangedEvent__
		              );
		    DAT_ram_00a593a4 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(int **)(iVar2 + 0x28);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x110);
		        goto code_r0x80ff3a9d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80ff3a9d:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  iVar6 = *(int *)(iVar2 + 0xc);
		  param1_01 = *(undefined4 *)(iVar6 + 0x20);
		  uVar4 = unnamed_function_1417
		                    (System_Action_ulong__WorldControllerEvents_MonsterChangeReason__TypeInfo);
		  System_Action_uint__uint___Invoke
		            (uVar4,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_OnMonsterChangedEvent__,0);
		  iVar2 = func_ii_7048(param1_01,uVar4,0);
		  uVar4 = System_Action_ulong__WorldControllerEvents_MonsterChangeReason__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar6 + 0x20) = 0;
		  }
		  else {
		    iVar5 = func_ii_1082(iVar2,
		                         System_Action_ulong__WorldControllerEvents_MonsterChangeReason__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar6 + 0x20) = iVar5;
		    uVar4 = System_Action_ulong__WorldControllerEvents_MonsterChangeReason__TypeInfo;
		    iVar6 = func_ii_1082(iVar2,
		                         System_Action_ulong__WorldControllerEvents_MonsterChangeReason__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = param1[6];
		  uVar4 = unnamed_function_1417(System_Action_ProtoBuildingStartedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnBuildingStartedEvent__
		             ,0);
		  ServicesNamespace_WorldService__add_BuildingStartedEvent(iVar2,uVar4,0);
		  iVar2 = param1[6];
		  uVar4 = unnamed_function_1417(System_Action_ProtoBuildingAcceleratedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnBuildingAcceleratedEvent__
		             ,0);
		  ServicesNamespace_WorldService__add_BuildingAcceleratedEvent(iVar2,uVar4,0);
		  iVar2 = param1[6];
		  uVar4 = unnamed_function_1417(System_Action_ProtoBuildingCanceledEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnBuildingCanceledEvent__
		             ,0);
		  ServicesNamespace_WorldService__add_BuildingCanceledEvent(iVar2,uVar4,0);
		  iVar2 = param1[6];
		  uVar4 = unnamed_function_1417(System_Action_ProtoBuildingFinishedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnBuildingFinishedEvent__
		             ,0);
		  ServicesNamespace_WorldService__add_BuildingFinishedEvent(iVar2,uVar4,0);
		  iVar2 = param1[6];
		  uVar4 = unnamed_function_1417(System_Action_ProtoUserIsleDecorationAddedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnUserIsleDecorationAddedEvent__
		             ,0);
		  ServicesNamespace_WorldService__add_UserIsleDecorationAddedEvent(iVar2,uVar4,0);
		  iVar2 = param1[6];
		  uVar4 = unnamed_function_1417(System_Action_ProtoUserIsleDecorationRemovedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnUserIsleDecorationRemovedEvent__
		             ,0);
		  ServicesNamespace_WorldService__add_UserIsleDecorationRemovedEvent(iVar2,uVar4,0);
		  iVar2 = param1[6];
		  uVar4 = unnamed_function_1417(System_Action_ProtoAnimationStartedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnAnimationStartedEvent__
		             ,0);
		  ServicesNamespace_WorldService__add_AnimationStartedEvent(iVar2,uVar4,0);
		  iVar2 = param1[6];
		  uVar4 = unnamed_function_1417(System_Action_ProtoUserIsleBuildingViewChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceUserIsleBuildingViewChangedEvent__
		             ,0);
		  ServicesNamespace_WorldService__add_UserIsleBuildingViewChangedEvent(iVar2,uVar4,0);
		  iVar2 = param1[6];
		  uVar4 = unnamed_function_1417(System_Action_ProtoIsleMonsterFlewAwayEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_IsleMonsterFlewAwayEventHandler__
		             ,0);
		  ServicesNamespace_WorldService__add_IsleMonsterFlewAwayEvent(iVar2,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar6 = *(int *)(iVar2 + 8);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar6 == *(int *)(iVar2 + 0x48)) {
		    iVar2 = param1[8];
		    uVar4 = unnamed_function_1417(System_Action_AccountInfo__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_Isles_User_Controller_UserIsleController_HandleAccountChangedEvent__,
		               0);
		    ServicesNamespace_ServicesService__add_AccountChangedEvent(iVar2,uVar4,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052ED RID: 21229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052ED")]
		[Address(RVA = "0xA0C3", Offset = "0xA0C3", VA = "0xA0C3", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Isles_User_Controller_UserIsleController__HandleStop(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *param1_00;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a593a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingFinishedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoAnimationStartedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingStartedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoIsleMonsterFlewAwayEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserIsleBuildingViewChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingCanceledEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AccountInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingAcceleratedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserIsleDecorationAddedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserIsleDecorationRemovedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Action_ulong__WorldControllerEvents_MonsterChangeReason__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_Controller_UserIsleController_HandleAccountChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_IsleMonsterFlewAwayEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_Controller_UserIsleController_OnMonsterChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnAnimationStartedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnBuildingAcceleratedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnBuildingCanceledEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnBuildingFinishedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnBuildingStartedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnUserIsleDecorationAddedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnUserIsleDecorationRemovedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceUserIsleBuildingViewChangedEvent__
		              );
		    DAT_ram_00a593a5 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(int **)(iVar2 + 0x28);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x110);
		        goto code_r0x80ff3e95;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80ff3e95:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  iVar6 = *(int *)(iVar2 + 0xc);
		  param1_01 = *(undefined4 *)(iVar6 + 0x20);
		  uVar4 = unnamed_function_1417
		                    (System_Action_ulong__WorldControllerEvents_MonsterChangeReason__TypeInfo);
		  System_Action_uint__uint___Invoke
		            (uVar4,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_OnMonsterChangedEvent__,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(param1_01,uVar4,0);
		  uVar4 = System_Action_ulong__WorldControllerEvents_MonsterChangeReason__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar6 + 0x20) = 0;
		  }
		  else {
		    iVar5 = func_ii_1082(iVar2,
		                         System_Action_ulong__WorldControllerEvents_MonsterChangeReason__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar6 + 0x20) = iVar5;
		    uVar4 = System_Action_ulong__WorldControllerEvents_MonsterChangeReason__TypeInfo;
		    iVar6 = func_ii_1082(iVar2,
		                         System_Action_ulong__WorldControllerEvents_MonsterChangeReason__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = param1[6];
		  uVar4 = unnamed_function_1417(System_Action_ProtoBuildingStartedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnBuildingStartedEvent__
		             ,0);
		  ServicesNamespace_WorldService__remove_BuildingCanceledEvent(iVar2,uVar4,0);
		  iVar2 = param1[6];
		  uVar4 = unnamed_function_1417(System_Action_ProtoBuildingAcceleratedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnBuildingAcceleratedEvent__
		             ,0);
		  ServicesNamespace_WorldService__get_ServiceId(iVar2,uVar4,0);
		  iVar2 = param1[6];
		  uVar4 = unnamed_function_1417(System_Action_ProtoBuildingCanceledEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnBuildingCanceledEvent__
		             ,0);
		  ServicesNamespace_WorldService__remove_BuildingFinishedEvent(iVar2,uVar4,0);
		  iVar2 = param1[6];
		  uVar4 = unnamed_function_1417(System_Action_ProtoBuildingFinishedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnBuildingFinishedEvent__
		             ,0);
		  ServicesNamespace_WorldService__remove_BuildingAcceleratedEvent(iVar2,uVar4,0);
		  iVar2 = param1[6];
		  uVar4 = unnamed_function_1417(System_Action_ProtoUserIsleDecorationAddedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnUserIsleDecorationAddedEvent__
		             ,0);
		  ServicesNamespace_WorldService__remove_UserIsleBuildingViewChangedEvent(iVar2,uVar4,0);
		  iVar2 = param1[6];
		  uVar4 = unnamed_function_1417(System_Action_ProtoUserIsleDecorationRemovedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnUserIsleDecorationRemovedEvent__
		             ,0);
		  ServicesNamespace_WorldService__remove_UserIsleDecorationAddedEvent(iVar2,uVar4,0);
		  iVar2 = param1[6];
		  uVar4 = unnamed_function_1417(System_Action_ProtoAnimationStartedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceOnAnimationStartedEvent__
		             ,0);
		  ServicesNamespace_WorldService__remove_UserAprChangedEvent(iVar2,uVar4,0);
		  iVar2 = param1[6];
		  uVar4 = unnamed_function_1417(System_Action_ProtoUserIsleBuildingViewChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_WorldServiceUserIsleBuildingViewChangedEvent__
		             ,0);
		  ServicesNamespace_WorldService__remove_IsleMonsterInfoChangedEvent(iVar2,uVar4,0);
		  iVar2 = param1[6];
		  uVar4 = unnamed_function_1417(System_Action_ProtoIsleMonsterFlewAwayEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleController_IsleMonsterFlewAwayEventHandler__
		             ,0);
		  ServicesNamespace_WorldService__remove_UserIsleDecorationRemovedEvent(iVar2,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar6 = *(int *)(iVar2 + 8);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar6 == *(int *)(iVar2 + 0x48)) {
		    iVar2 = param1[8];
		    uVar4 = unnamed_function_1417(System_Action_AccountInfo__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_Isles_User_Controller_UserIsleController_HandleAccountChangedEvent__,
		               0);
		    ServicesNamespace_ServicesService__remove_AuchanBacklightChangedEvent(iVar2,uVar4,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052EE RID: 21230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052EE")]
		[Address(RVA = "0xA0C4", Offset = "0xA0C4", VA = "0xA0C4", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Isles_User_Controller_UserIsleController__HandleRun
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x38) != 0) {
		    Gameplay_Isles_User_Controller_UserIsleController__WorldServiceOnUserIsleDecorationAddedEvent
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052EF RID: 21231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052EF")]
		[Address(RVA = "0xA0C5", Offset = "0xA0C5", VA = "0xA0C5")]
		private void HandleAccountChangedEvent(AccountInfo account)
		{
		/* --- GHIDRA: HandleAccountChangedEvent ---
		void Gameplay_Isles_User_Controller_UserIsleController__HandleAccountChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  longlong lVar2;
		  
		  lVar2 = *(longlong *)(param2 + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if ((lVar2 == *(longlong *)(iVar1 + 0x10)) &&
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104)), *(int *)(iVar1 + 0x34) != 0)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x34);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2 + 0x18),
		                 *(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052F0 RID: 21232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F0")]
		[Address(RVA = "0xA0C6", Offset = "0xA0C6", VA = "0xA0C6")]
		private void WorldServiceOnAnimationStartedEvent(ProtoAnimationStartedEvt evt)
		{
		/* --- GHIDRA: WorldServiceOnAnimationStartedEvent ---
		void Gameplay_Isles_User_Controller_UserIsleController__WorldServiceOnAnimationStartedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *param1_00;
		  int iVar7;
		  longlong lVar8;
		  uint uVar9;
		  
		  if (DAT_ram_00a593a6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a593a6 = '\x01';
		  }
		  lVar8 = *(longlong *)(param2 + 0x18);
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  if (lVar8 == *(longlong *)(iVar3 + 0x10)) {
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    if (*(int *)(iVar3 + 0x34) != 0) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar3 = *param1_00;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8 + 4) * 8 + iVar3 + 0x178);
		            goto code_r0x80ff45aa;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar9);
		      }
		      puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ff45aa:
		      uVar1 = CONCAT44(uVar2,puVar4[1]);
		      uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar1);
		      uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      uVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar5,0);
		      iVar3 = Core_Extensions_Dict_DictExt__GetUserBuildingTypeDic
		                        (uVar5,*(undefined4 *)(param2 + 0xc),0);
		      uVar5 = *(undefined4 *)(iVar3 + 0x10);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104)));
		      iVar3 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(iVar3 + 0x24),uVar5,
		                         Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                        );
		      *(undefined4 *)(iVar3 + 0x10) = *(undefined4 *)(param2 + 0xc);
		      Gameplay_World_Model_BaseBuildingData__get_AcceleratePrice
		                (iVar3,*(undefined4 *)(param2 + 0x10),0);
		      uVar2 = 0;
		      Gameplay_World_Model_BaseBuildingData___ctor(iVar3,0,0);
		      uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x114));
		      iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar1);
		      uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      iVar6 = *(int *)(iVar6 + 0x14);
		      if (iVar6 != 0) {
		        uVar1 = CONCAT44(uVar2,uVar5);
		        (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		                  (*(undefined4 *)(iVar6 + 0x20),uVar1,*(undefined4 *)(iVar6 + 0x14));
		        uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      }
		      iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104)));
		      iVar7 = *(int *)(iVar6 + 8);
		      iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      if (iVar7 == *(int *)(iVar6 + 0x48)) {
		        Gameplay_Isles_User_Controller_UserIsleController__IsleMonsterFlewAwayEventHandler
		                  (iVar3,iVar3,iVar3);
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F1")]
		[Address(RVA = "0xA0C7", Offset = "0xA0C7", VA = "0xA0C7")]
		private void WorldServiceOnBuildingFinishedEvent(ProtoBuildingFinishedEvt evt)
		{
		/* --- GHIDRA: WorldServiceOnBuildingFinishedEvent ---
		void Gameplay_Isles_User_Controller_UserIsleController__WorldServiceOnBuildingFinishedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  int iVar4;
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  longlong lVar5;
		  longlong lVar6;
		  undefined8 uVar7;
		  
		  if (DAT_ram_00a593a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_IsleScope_BuildingEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a593a7 = '\x01';
		  }
		  lVar5 = *(longlong *)(param2 + 0x10);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  if (lVar5 == *(longlong *)(iVar2 + 0x10)) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(int *)(iVar2 + 0x34) != 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar3 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(iVar2 + 0x24),*(undefined4 *)(param2 + 0xc),
		                         Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                        );
		      uVar1 = 0;
		      Gameplay_World_Model_BaseBuildingData___ctor(uVar3,0,0);
		      uVar7 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x114));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar7);
		      uVar1 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      iVar2 = *(int *)(iVar2 + 0x14);
		      if (iVar2 != 0) {
		        uVar7 = CONCAT44(uVar1,*(undefined4 *)(param2 + 0xc));
		        (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                  (*(undefined4 *)(iVar2 + 0x20),uVar7,*(undefined4 *)(iVar2 + 0x14));
		        uVar1 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      }
		      uVar7 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		      lVar6 = *(longlong *)(iVar2 + 0x10);
		      uVar7 = CONCAT44((int)((ulonglong)uVar7 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		      uVar1 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      lVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar2 + 0x48),0);
		      if (lVar6 == lVar5) {
		        iVar2 = System_Uri___ctor(0);
		        iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x3c) + 0x14);
		        if (iVar2 != 0) {
		          param2_00 = System_Uri___ctor(0);
		          if (DAT_ram_00a6456f == '\0') {
		            Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		            DAT_ram_00a6456f = '\x01';
		          }
		          param4 = *(undefined4 *)(param2 + 0xc);
		          param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		          uVar3 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(uVar3,0);
		          uVar7 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104));
		          iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		          uVar1 = (undefined4)((ulonglong)uVar7 >> 0x20);
		          uVar7 = *(undefined8 *)(iVar4 + 0x10);
		          param1_00 = unnamed_function_1417(Core_Events_Scopes_IsleScope_BuildingEventArgs_TypeInfo)
		          ;
		          Core_Events_Scopes_IsleScope_BuildingEventArgs__get_OwnerId
		                    (param1_00,param2_00,param3_00,param4,uVar3,uVar7,0);
		          (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                    (*(undefined4 *)(iVar2 + 0x20),CONCAT44(uVar1,param1_00),
		                     *(undefined4 *)(iVar2 + 0x14));
		        }
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F2")]
		[Address(RVA = "0xA0C8", Offset = "0xA0C8", VA = "0xA0C8")]
		private void WorldServiceOnBuildingCanceledEvent(ProtoBuildingCanceledEvt evt)
		{
		/* --- GHIDRA: WorldServiceOnBuildingCanceledEvent ---
		void Gameplay_Isles_User_Controller_UserIsleController__WorldServiceOnBuildingCanceledEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  int iVar4;
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  longlong lVar5;
		  longlong lVar6;
		  undefined8 uVar7;
		  
		  if (DAT_ram_00a593a8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_IsleScope_BuildingEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a593a8 = '\x01';
		  }
		  lVar5 = *(longlong *)(param2 + 0x20);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  if (lVar5 == *(longlong *)(iVar2 + 0x10)) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(int *)(iVar2 + 0x34) != 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar3 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(iVar2 + 0x24),*(undefined4 *)(param2 + 0xc),
		                         Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                        );
		      uVar7 = *(undefined8 *)(param2 + 0x18);
		      Gameplay_World_Model_BaseBuildingData___ctor(uVar3,uVar7,0);
		      uVar1 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      iVar2 = func_ii_8742(uVar3,0);
		      if (iVar2 == 0) {
		        iVar2 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(uVar3,0);
		        Gameplay_World_Model_BaseBuildingData__get_AcceleratePrice(uVar3,iVar2 + 1,0);
		      }
		      uVar7 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x114));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar7);
		      uVar1 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      iVar2 = *(int *)(iVar2 + 0x14);
		      if (iVar2 != 0) {
		        uVar7 = CONCAT44(uVar1,*(undefined4 *)(param2 + 0xc));
		        (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                  (*(undefined4 *)(iVar2 + 0x20),uVar7,*(undefined4 *)(iVar2 + 0x14));
		        uVar1 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      }
		      uVar7 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		      lVar6 = *(longlong *)(iVar2 + 0x10);
		      uVar7 = CONCAT44((int)((ulonglong)uVar7 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		      uVar1 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      lVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar2 + 0x48),0);
		      if (lVar6 == lVar5) {
		        iVar2 = System_Uri___ctor(0);
		        iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x3c) + 0x18);
		        if (iVar2 != 0) {
		          param2_00 = System_Uri___ctor(0);
		          if (DAT_ram_00a6456f == '\0') {
		            Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		            DAT_ram_00a6456f = '\x01';
		          }
		          param4 = *(undefined4 *)(param2 + 0xc);
		          param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		          uVar3 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(uVar3,0);
		          uVar7 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104));
		          iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		          uVar1 = (undefined4)((ulonglong)uVar7 >> 0x20);
		          uVar7 = *(undefined8 *)(iVar4 + 0x10);
		          param1_00 = unnamed_function_1417(Core_Events_Scopes_IsleScope_BuildingEventArgs_TypeInfo)
		          ;
		          Core_Events_Scopes_IsleScope_BuildingEventArgs__get_OwnerId
		                    (param1_00,param2_00,param3_00,param4,uVar3,uVar7,0);
		          (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                    (*(undefined4 *)(iVar2 + 0x20),CONCAT44(uVar1,param1_00),
		                     *(undefined4 *)(iVar2 + 0x14));
		        }
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F3")]
		[Address(RVA = "0xA0C9", Offset = "0xA0C9", VA = "0xA0C9")]
		private void WorldServiceOnBuildingAcceleratedEvent(ProtoBuildingAcceleratedEvt evt)
		{
		/* --- GHIDRA: WorldServiceOnBuildingAcceleratedEvent ---
		void Gameplay_Isles_User_Controller_UserIsleController__WorldServiceOnBuildingAcceleratedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  int iVar4;
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  longlong lVar5;
		  undefined8 uVar6;
		  
		  if (DAT_ram_00a593a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_IsleScope_BuildingEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a593a9 = '\x01';
		  }
		  lVar5 = *(longlong *)(param2 + 0x18);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  if (lVar5 == *(longlong *)(iVar2 + 0x10)) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(int *)(iVar2 + 0x34) != 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar3 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(iVar2 + 0x24),*(undefined4 *)(param2 + 0xc),
		                         Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                        );
		      uVar6 = *(undefined8 *)(param2 + 0x10);
		      Gameplay_World_Model_BaseBuildingData___ctor(uVar3,uVar6,0);
		      uVar6 = CONCAT44((int)((ulonglong)uVar6 >> 0x20),*(undefined4 *)(*param1 + 0x114));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar6);
		      uVar1 = (undefined4)((ulonglong)uVar6 >> 0x20);
		      iVar2 = *(int *)(iVar2 + 0x14);
		      if (iVar2 != 0) {
		        uVar6 = CONCAT44(uVar1,*(undefined4 *)(param2 + 0xc));
		        (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                  (*(undefined4 *)(iVar2 + 0x20),uVar6,*(undefined4 *)(iVar2 + 0x14));
		        uVar1 = (undefined4)((ulonglong)uVar6 >> 0x20);
		      }
		      uVar6 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar6);
		      uVar1 = (undefined4)((ulonglong)uVar6 >> 0x20);
		      lVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar2 + 0x48),0);
		      if (lVar5 == *(longlong *)(param2 + 0x18)) {
		        iVar2 = System_Uri___ctor(0);
		        iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x3c) + 0x10);
		        if (iVar2 != 0) {
		          param2_00 = System_Uri___ctor(0);
		          if (DAT_ram_00a6456f == '\0') {
		            Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		            DAT_ram_00a6456f = '\x01';
		          }
		          param4 = *(undefined4 *)(param2 + 0xc);
		          param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		          uVar3 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(uVar3,0);
		          uVar6 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104));
		          iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar6);
		          uVar1 = (undefined4)((ulonglong)uVar6 >> 0x20);
		          uVar6 = *(undefined8 *)(iVar4 + 0x10);
		          param1_00 = unnamed_function_1417(Core_Events_Scopes_IsleScope_BuildingEventArgs_TypeInfo)
		          ;
		          Core_Events_Scopes_IsleScope_BuildingEventArgs__get_OwnerId
		                    (param1_00,param2_00,param3_00,param4,uVar3,uVar6,0);
		          (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                    (*(undefined4 *)(iVar2 + 0x20),CONCAT44(uVar1,param1_00),
		                     *(undefined4 *)(iVar2 + 0x14));
		        }
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F4")]
		[Address(RVA = "0xA0CA", Offset = "0xA0CA", VA = "0xA0CA")]
		private void WorldServiceOnBuildingStartedEvent(ProtoBuildingStartedEvt evt)
		{
		/* --- GHIDRA: WorldServiceOnBuildingStartedEvent ---
		void Gameplay_Isles_User_Controller_UserIsleController__WorldServiceOnBuildingStartedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  longlong lVar9;
		  int *piVar10;
		  int iVar11;
		  uint uVar12;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar8 = 0;
		  if (DAT_ram_00a593aa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_UserBuildingInfo__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserBuildingInfo__GetEnumerator__);
		    DAT_ram_00a593aa = '\x01';
		  }
		  lVar9 = *(longlong *)(param2 + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if ((lVar9 == *(longlong *)(iVar1 + 0x10)) &&
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104)), *(int *)(iVar1 + 0x34) != 0)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = *(int *)(iVar1 + 0x34);
		    if (iVar1 != 0) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar12 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar12 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar12 * 8 + 4) * 8 + iVar6 + 0x178)
		            ;
		            goto code_r0x80ff4e46;
		          }
		          uVar12 = uVar12 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar12);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ff4e46:
		      uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		      iVar6 = Core_Extensions_Dict_DictExt__GetUserBuildingTypeDic
		                        (uVar3,*(undefined4 *)(param2 + 0x18),0);
		      iVar6 = *(int *)(iVar6 + 0x10);
		      local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                 (*(undefined4 *)(iVar1 + 0xc),
		                                  Method_Google_Protobuf_Collections_RepeatedField_UserBuildingInfo__GetEnumerator__
		                                 );
		      local_c = 0;
		      local_8 = &local_4;
		      do {
		        piVar5 = local_4;
		        iVar7 = *local_4;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar12 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar12 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		              puVar4 = (undefined4 *)(iVar7 + piVar10[1] * 8 + 0xc0);
		              goto code_r0x80ff4f3f;
		            }
		            uVar12 = uVar12 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar12);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80ff4f87:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ff509e:
		          iVar8 = global_1;
		          iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar8 == iVar7) {
		            piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		            iVar8 = *piVar5;
		            DAT_ram_009d3e38 = 0;
		            local_c = iVar8;
		            import::env::invoke_v(0x123);
		            iVar11 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            iVar7 = 0;
		            if (iVar11 != 1) goto code_r0x80ff50eb;
		            uVar3 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x290,&local_c);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 != 1) {
		            import::env::__resumeException(uVar3);
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
		code_r0x80ff4f3f:
		        DAT_ram_009d3e38 = 0;
		        iVar11 = import::env::invoke_iii(*puVar4,piVar5,puVar4[1]);
		        piVar5 = local_4;
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) goto code_r0x80ff4f87;
		        iVar7 = 6;
		        if (iVar11 == 0) goto code_r0x80ff50eb;
		        iVar7 = *local_4;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar12 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar12 * 8);
		            if (System_Collections_Generic_IEnumerator_UserBuildingInfo__TypeInfo == *piVar10) {
		              puVar4 = (undefined4 *)(iVar7 + piVar10[1] * 8 + 0xc0);
		              goto code_r0x80ff502a;
		            }
		            uVar12 = uVar12 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar12);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_Generic_IEnumerator_UserBuildingInfo__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80ff5096:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80ff509e;
		        }
		code_r0x80ff502a:
		        DAT_ram_009d3e38 = 0;
		        iVar11 = import::env::invoke_iii(*puVar4,piVar5,puVar4[1]);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) goto code_r0x80ff5096;
		      } while (*(int *)(*(int *)(iVar11 + 0x10) + 0xc) != iVar6);
		      *(undefined4 *)(iVar11 + 0xc) = *(undefined4 *)(param2 + 0x18);
		      *(undefined4 *)(iVar11 + 0x14) = *(undefined4 *)(param2 + 0x1c);
		      *(undefined4 *)(iVar11 + 0x18) = *(undefined4 *)(param2 + 0x20);
		      iVar7 = 6;
		code_r0x80ff50eb:
		      piVar5 = local_4;
		      if (local_4 != (int *)0x0) {
		        uVar12 = 0;
		        iVar11 = *local_4;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar12 * 8)) {
		              puVar2 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar12 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x80ff5163;
		            }
		            uVar12 = uVar12 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar12);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80ff5163:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      }
		      if (iVar8 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar7 == 0) ||
		         ((((iVar7 != 1 && (iVar7 != 2)) && (iVar7 != 3)) &&
		          (((iVar7 != 4 && (iVar7 != 5)) && (iVar7 == 6)))))) {
		        uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        Gameplay_Isles_User_Model_UserIsleModel__get_IsleInformation(uVar3,iVar1,0);
		        iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x114));
		        iVar8 = *(int *)(iVar8 + 0x3c);
		        if (iVar8 != 0) {
		          (**(code **)((ulonglong)*(uint *)(iVar8 + 0xc) * 4))
		                    (*(undefined4 *)(iVar8 + 0x20),iVar6,*(undefined4 *)(iVar8 + 0x14));
		        }
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F5")]
		[Address(RVA = "0xA0CB", Offset = "0xA0CB", VA = "0xA0CB")]
		private void WorldServiceUserIsleBuildingViewChangedEvent(ProtoUserIsleBuildingViewChangedEvt evt)
		{
		/* --- GHIDRA: WorldServiceUserIsleBuildingViewChangedEvent ---
		void Gameplay_Isles_User_Controller_UserIsleController__WorldServiceUserIsleBuildingViewChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x28);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F6")]
		[Address(RVA = "0xA0CC", Offset = "0xA0CC", VA = "0xA0CC")]
		private void IsleMonsterFlewAwayEventHandler(ProtoIsleMonsterFlewAwayEvt evt)
		{
		/* --- GHIDRA: IsleMonsterFlewAwayEventHandler ---
		void Gameplay_Isles_User_Controller_UserIsleController__IsleMonsterFlewAwayEventHandler
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a593ab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3706);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25096);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27734);
		    DAT_ram_00a593ab = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3706,1,0,1,0,0,0,0);
		  uVar2 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar2,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe8) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xec));
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar2,StringLiteral_27734,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  local_4 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(param2,0);
		  uVar3 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar2,StringLiteral_25096,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar1 = Core_GameLocalization__GetTranslation(uVar1,uVar2,0);
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		  Core_Application_App__get_ToastController(uVar2,8,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F7")]
		[Address(RVA = "0xA0CD", Offset = "0xA0CD", VA = "0xA0CD")]
		private void ShowCompleteBuildToast(BaseBuildingData buildingData)
		{
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F8")]
		[Address(RVA = "0xA0CE", Offset = "0xA0CE", VA = "0xA0CE")]
		private void RequestMonster()
		{
		/* --- GHIDRA: RequestMonster ---
		void Gameplay_Isles_User_Controller_UserIsleController__RequestMonster
		               (int *param1,longlong param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if ((*(longlong *)(iVar1 + 0x10) == param2) &&
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104)), *(int *)(iVar1 + 0x34) != 0)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x24);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param3,*(undefined4 *)(iVar1 + 0x14));
		    }
		    Gameplay_Isles_User_Controller_UserIsleController__OnMonsterChangedEvent(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F9")]
		[Address(RVA = "0xA0CF", Offset = "0xA0CF", VA = "0xA0CF")]
		private void OnMonsterChangedEvent(ulong ownerId, WorldControllerEvents.MonsterChangeReason reason)
		{
		/* --- GHIDRA: OnMonsterChangedEvent ---
		void Gameplay_Isles_User_Controller_UserIsleController__OnMonsterChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  float fVar2;
		  undefined4 uVar3;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x40) != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = *(int *)(*(int *)(iVar1 + 0x40) + 0x10);
		    if ((iVar1 != 0) && (fVar2 = func_ii_7103(iVar1,0), 0.0 < fVar2)) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      iVar1 = *(int *)(iVar1 + 0x40);
		      if (param1[9] != 0) {
		        func_ii_7950(param1[9],0);
		        param1[9] = 0;
		      }
		      uVar3 = *(undefined4 *)(iVar1 + 0x10);
		      if (DAT_ram_00a593ad == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Gameplay_Isles_User_Controller_UserIsleController__SetupMonsterTimerRoutine_d__35_TypeInfo
		                  );
		        DAT_ram_00a593ad = '\x01';
		      }
		      iVar1 = unnamed_function_1417
		                        (
		                        Gameplay_Isles_User_Controller_UserIsleController__SetupMonsterTimerRoutine_d__35_TypeInfo
		                        );
		      *(int **)(iVar1 + 0x14) = param1;
		      *(undefined4 *)(iVar1 + 8) = 0;
		      *(undefined4 *)(iVar1 + 0x10) = uVar3;
		      iVar1 = Utils_CoroutineSource__GetMono(iVar1,0);
		      param1[9] = iVar1;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052FA RID: 21242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052FA")]
		[Address(RVA = "0xA0D0", Offset = "0xA0D0", VA = "0xA0D0")]
		private void ValidateMonsterTimer()
		{
		/* --- GHIDRA: ValidateMonsterTimer ---
		void Gameplay_Isles_User_Controller_UserIsleController__ValidateMonsterTimer
		               (int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (*(int *)(param1 + 0x24) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x24),0);
		    *(undefined4 *)(param1 + 0x24) = 0;
		  }
		  uVar1 = *(undefined4 *)(param2 + 0x10);
		  if (DAT_ram_00a593ad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Isles_User_Controller_UserIsleController__SetupMonsterTimerRoutine_d__35_TypeInfo
		              );
		    DAT_ram_00a593ad = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Isles_User_Controller_UserIsleController__SetupMonsterTimerRoutine_d__35_TypeInfo
		                        );
		  *(int *)(param1_00 + 0x14) = param1;
		  *(undefined4 *)(param1_00 + 8) = 0;
		  *(undefined4 *)(param1_00 + 0x10) = uVar1;
		  uVar1 = Utils_CoroutineSource__GetMono(param1_00,0);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060052FB RID: 21243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052FB")]
		[Address(RVA = "0xA0D1", Offset = "0xA0D1", VA = "0xA0D1")]
		private void StartMonsterTimer(MonsterData monster)
		{
		/* --- GHIDRA: StartMonsterTimer ---
		uint Gameplay_Isles_User_Controller_UserIsleController__StartMonsterTimer
		               (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x24);
		  if (param1_00 != 0) {
		    func_ii_7950(param1_00,0);
		    *(undefined4 *)(param1 + 0x24) = 0;
		  }
		  return (uint)(param1_00 != 0);
		}
		*/

		}

		// Token: 0x060052FC RID: 21244 RVA: 0x0000F030 File Offset: 0x0000D230
		[Token(Token = "0x60052FC")]
		[Address(RVA = "0xA0D2", Offset = "0xA0D2", VA = "0xA0D2")]
		private bool TryStopMonsterTimer()
		{
		/* --- GHIDRA: TryStopMonsterTimer ---
		int Gameplay_Isles_User_Controller_UserIsleController__TryStopMonsterTimer
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a593ad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Isles_User_Controller_UserIsleController__SetupMonsterTimerRoutine_d__35_TypeInfo
		              );
		    DAT_ram_00a593ad = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Isles_User_Controller_UserIsleController__SetupMonsterTimerRoutine_d__35_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x060052FD RID: 21245 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60052FD")]
		[Address(RVA = "0xA0D3", Offset = "0xA0D3", VA = "0xA0D3")]
		private IEnumerator SetupMonsterTimerRoutine(BackTime backTime)
		{
		/* --- GHIDRA: SetupMonsterTimerRoutine ---
		void Gameplay_Isles_User_Controller_UserIsleController__SetupMonsterTimerRoutine
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a593ac == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a593ac = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(int **)(iVar2 + 0x28);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x110);
		        goto code_r0x80ff5308;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80ff5308:
		  param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  Core_Gameplay_Managers_WorldManager__KickMonsterFromCurrentIsle(param1_00,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060052FE RID: 21246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052FE")]
		[Address(RVA = "0xA0D4", Offset = "0xA0D4", VA = "0xA0D4")]
		private void OnTimerExpired()
		{
		/* --- GHIDRA: OnTimerExpired ---
		void Gameplay_Isles_User_Controller_UserIsleController__OnTimerExpired(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a593ae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_Controller_BaseIsleController_UserIsleModel__UserIsleEvents__Dispose__
		              );
		    DAT_ram_00a593ae = '\x01';
		  }
		  Gameplay_Isles_Base_Controller_BaseIsleController_object__object____ctor
		            (param1,
		             Method_Gameplay_Isles_Base_Controller_BaseIsleController_UserIsleModel__UserIsleEvents__Dispose__
		            );
		  if (*(int *)(param1 + 0x24) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x24),0);
		    *(undefined4 *)(param1 + 0x24) = 0;
		  }
		  *(undefined4 *)(param1 + 0x20) = 0;
		  *(undefined8 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060052FF RID: 21247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052FF")]
		[Address(RVA = "0xA0D5", Offset = "0xA0D5", VA = "0xA0D5", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Isles_User_Controller_UserIsleController__Dispose
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  longlong lVar7;
		  int iVar8;
		  int *piVar9;
		  uint uVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a593af == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__IndexOf__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__RemoveAt__)
		    ;
		    DAT_ram_00a593af = '\x01';
		  }
		  local_4 = (int *)0x0;
		  lVar7 = *(longlong *)(param2 + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (lVar7 != *(longlong *)(iVar1 + 0x10)) {
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x34) == 0) {
		    return;
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(param2 + 0x18),
		                              Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    do {
		      piVar5 = local_4;
		      iVar1 = *local_4;
		      if (*(ushort *)(iVar1 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		            puVar2 = (undefined4 *)(iVar1 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x80ff57a0;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80ff57ec:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ff5a18;
		      }
		code_r0x80ff57a0:
		      DAT_ram_009d3e38 = 0;
		      iVar1 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		      piVar5 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ff57ec;
		      if (iVar1 == 0) {
		        iVar4 = 5;
		        iVar1 = 0;
		        goto code_r0x80ff5a65;
		      }
		      iVar1 = *local_4;
		      if (*(ushort *)(iVar1 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8);
		          if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar9) {
		            puVar2 = (undefined4 *)(iVar1 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x80ff5897;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80ff5964:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ff5a18;
		      }
		code_r0x80ff5897:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ff5964;
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ff5a18;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x291,
		                         *(undefined4 *)(*(int *)(iVar4 + 0x34) + 0x40),uVar3,
		                         Method_Google_Protobuf_Collections_RepeatedField_uint__IndexOf__);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ff5a18;
		      }
		    } while (iVar4 < 0);
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ff5a18;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x292,
		               *(undefined4 *)(*(int *)(iVar8 + 0x34) + 0x40),iVar4,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__RemoveAt__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ff5a18:
		  iVar1 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar1 = *piVar5;
		    iVar4 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar1;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x80ff5a65:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar10 = 0;
		        iVar8 = *local_4;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8)) {
		              puVar6 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80ff5add;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		        }
		        puVar6 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80ff5add:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar4 != 0) &&
		         ((((iVar4 == 1 || (iVar4 == 2)) || (iVar4 == 3)) || ((iVar4 == 4 || (iVar4 != 5)))))) {
		        return;
		      }
		      local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                 (*(undefined4 *)(param2 + 0x18),
		                                  Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__
		                                 );
		      local_c = 0;
		      local_8 = &local_4;
		      do {
		        do {
		          piVar5 = local_4;
		          iVar1 = *local_4;
		          if (*(ushort *)(iVar1 + 0xb6) != 0) {
		            uVar10 = 0;
		            do {
		              piVar9 = (int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8);
		              if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		                puVar2 = (undefined4 *)(iVar1 + piVar9[1] * 8 + 0xc0);
		                goto code_r0x80ff5bfc;
		              }
		              uVar10 = uVar10 + 1;
		            } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar2 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                              System_Collections_IEnumerator_TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x80ff5de2:
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80ff5dea;
		          }
		code_r0x80ff5bfc:
		          DAT_ram_009d3e38 = 0;
		          iVar1 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		          piVar5 = local_4;
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80ff5de2;
		          if (iVar1 == 0) {
		            iVar1 = 0;
		            goto code_r0x80ff5e33;
		          }
		          iVar1 = *local_4;
		          if (*(ushort *)(iVar1 + 0xb6) != 0) {
		            uVar10 = 0;
		            do {
		              piVar9 = (int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8);
		              if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar9) {
		                puVar2 = (undefined4 *)(iVar1 + piVar9[1] * 8 + 0xc0);
		                goto code_r0x80ff5ce0;
		              }
		              uVar10 = uVar10 + 1;
		            } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar2 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                              System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x80ff5d6d:
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80ff5dea;
		          }
		code_r0x80ff5ce0:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80ff5d6d;
		          DAT_ram_009d3e38 = 0;
		          iVar4 = import::env::invoke_iii
		                            (*(undefined4 *)(*param1 + 0x110),param1,
		                             *(undefined4 *)(*param1 + 0x114));
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80ff5dea;
		          }
		          iVar1 = *(int *)(iVar4 + 0x30);
		        } while (iVar1 == 0);
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (*(undefined4 *)(iVar1 + 0xc),*(undefined4 *)(iVar1 + 0x20),uVar3,
		                   *(undefined4 *)(iVar1 + 0x14));
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar1 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ff5dea:
		      iVar1 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar1 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_c = iVar1;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		code_r0x80ff5e33:
		          piVar5 = local_4;
		          DAT_ram_009d3e38 = 0;
		          if (local_4 != (int *)0x0) {
		            uVar10 = 0;
		            iVar4 = *local_4;
		            if (*(ushort *)(iVar4 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar10 * 8)) {
		                  puVar6 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar10 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x80ff5eab;
		                }
		                uVar10 = uVar10 + 1;
		              } while (*(ushort *)(iVar4 + 0xb6) != uVar10);
		            }
		            puVar6 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80ff5eab:
		            (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		          }
		          if (iVar1 == 0) {
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x294,&local_c);
		      goto joined_r0x80ff5ef3;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x293,&local_c);
		joined_r0x80ff5ef3:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005300 RID: 21248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005300")]
		[Address(RVA = "0x1C9F", Offset = "0x1C9F", VA = "0x1C9F")]
		public void SetIsleInformation(ProtoGetUserIsleInfoAns.Types.IsleInformation isleInformation)
		{
		/* --- GHIDRA: SetIsleInformation ---
		int Gameplay_Isles_User_Controller_UserIsleController__SetIsleInformation
		              (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a58c8e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28178);
		    DAT_ram_00a58c8e = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x38);
		  if (iVar4 == 0) {
		    uVar1 = 0;
		    param1_00 = *(int **)(param1 + 0xc);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		          goto code_r0x80f94362;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f94362:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		    iVar4 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar3,StringLiteral_28178,0);
		    *(int *)(param1 + 0x38) = iVar4;
		  }
		  return iVar4;
		}
		*/

		}

		// Token: 0x06005301 RID: 21249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005301")]
		[Address(RVA = "0xA0D6", Offset = "0xA0D6", VA = "0xA0D6")]
		private void WorldServiceOnUserIsleDecorationRemovedEvent(ProtoUserIsleDecorationRemovedEvt evt)
		{
		/* --- GHIDRA: WorldServiceOnUserIsleDecorationRemovedEvent ---
		void Gameplay_Isles_User_Controller_UserIsleController__WorldServiceOnUserIsleDecorationRemovedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  longlong lVar7;
		  int iVar8;
		  int *piVar9;
		  uint uVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a593b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__IndexOf__);
		    DAT_ram_00a593b0 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  lVar7 = *(longlong *)(param2 + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (lVar7 != *(longlong *)(iVar1 + 0x10)) {
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x34) == 0) {
		    return;
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(param2 + 0x18),
		                              Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    do {
		      piVar5 = local_4;
		      iVar1 = *local_4;
		      if (*(ushort *)(iVar1 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		            puVar2 = (undefined4 *)(iVar1 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x80ff6099;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80ff60e5:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ff6311;
		      }
		code_r0x80ff6099:
		      DAT_ram_009d3e38 = 0;
		      iVar1 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		      piVar5 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ff60e5;
		      if (iVar1 == 0) {
		        iVar4 = 5;
		        iVar1 = 0;
		        goto code_r0x80ff635e;
		      }
		      iVar1 = *local_4;
		      if (*(ushort *)(iVar1 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8);
		          if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar9) {
		            puVar2 = (undefined4 *)(iVar1 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x80ff6190;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80ff625d:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ff6311;
		      }
		code_r0x80ff6190:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ff625d;
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ff6311;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x291,
		                         *(undefined4 *)(*(int *)(iVar4 + 0x34) + 0x40),uVar3,
		                         Method_Google_Protobuf_Collections_RepeatedField_uint__IndexOf__);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ff6311;
		      }
		    } while (-1 < iVar4);
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ff6311;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x295,
		               *(undefined4 *)(*(int *)(iVar4 + 0x34) + 0x40),uVar3,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ff6311:
		  iVar1 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar1 = *piVar5;
		    iVar4 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar1;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x80ff635e:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar10 = 0;
		        iVar8 = *local_4;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8)) {
		              puVar6 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80ff63d6;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		        }
		        puVar6 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80ff63d6:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar4 != 0) &&
		         ((((iVar4 == 1 || (iVar4 == 2)) || (iVar4 == 3)) || ((iVar4 == 4 || (iVar4 != 5)))))) {
		        return;
		      }
		      local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                 (*(undefined4 *)(param2 + 0x18),
		                                  Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__
		                                 );
		      local_c = 0;
		      local_8 = &local_4;
		      do {
		        do {
		          piVar5 = local_4;
		          iVar1 = *local_4;
		          if (*(ushort *)(iVar1 + 0xb6) != 0) {
		            uVar10 = 0;
		            do {
		              piVar9 = (int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8);
		              if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		                puVar2 = (undefined4 *)(iVar1 + piVar9[1] * 8 + 0xc0);
		                goto code_r0x80ff64f5;
		              }
		              uVar10 = uVar10 + 1;
		            } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar2 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                              System_Collections_IEnumerator_TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x80ff66db:
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80ff66e3;
		          }
		code_r0x80ff64f5:
		          DAT_ram_009d3e38 = 0;
		          iVar1 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		          piVar5 = local_4;
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80ff66db;
		          if (iVar1 == 0) {
		            iVar1 = 0;
		            goto code_r0x80ff672c;
		          }
		          iVar1 = *local_4;
		          if (*(ushort *)(iVar1 + 0xb6) != 0) {
		            uVar10 = 0;
		            do {
		              piVar9 = (int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8);
		              if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar9) {
		                puVar2 = (undefined4 *)(iVar1 + piVar9[1] * 8 + 0xc0);
		                goto code_r0x80ff65d9;
		              }
		              uVar10 = uVar10 + 1;
		            } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar2 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                              System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x80ff6666:
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80ff66e3;
		          }
		code_r0x80ff65d9:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80ff6666;
		          DAT_ram_009d3e38 = 0;
		          iVar4 = import::env::invoke_iii
		                            (*(undefined4 *)(*param1 + 0x110),param1,
		                             *(undefined4 *)(*param1 + 0x114));
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80ff66e3;
		          }
		          iVar1 = *(int *)(iVar4 + 0x2c);
		        } while (iVar1 == 0);
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (*(undefined4 *)(iVar1 + 0xc),*(undefined4 *)(iVar1 + 0x20),uVar3,
		                   *(undefined4 *)(iVar1 + 0x14));
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar1 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ff66e3:
		      iVar1 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar1 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_c = iVar1;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		code_r0x80ff672c:
		          piVar5 = local_4;
		          DAT_ram_009d3e38 = 0;
		          if (local_4 != (int *)0x0) {
		            uVar10 = 0;
		            iVar4 = *local_4;
		            if (*(ushort *)(iVar4 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar10 * 8)) {
		                  puVar6 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar10 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x80ff67a4;
		                }
		                uVar10 = uVar10 + 1;
		              } while (*(ushort *)(iVar4 + 0xb6) != uVar10);
		            }
		            puVar6 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80ff67a4:
		            (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		          }
		          if (iVar1 == 0) {
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x297,&local_c);
		      goto joined_r0x80ff67ec;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x296,&local_c);
		joined_r0x80ff67ec:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005302 RID: 21250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005302")]
		[Address(RVA = "0xA0D7", Offset = "0xA0D7", VA = "0xA0D7")]
		private void WorldServiceOnUserIsleDecorationAddedEvent(ProtoUserIsleDecorationAddedEvt evt)
		{
		/* --- GHIDRA: WorldServiceOnUserIsleDecorationAddedEvent ---
		void Gameplay_Isles_User_Controller_UserIsleController__WorldServiceOnUserIsleDecorationAddedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  uint *puVar6;
		  undefined4 param1_00;
		  int *param1_01;
		  uint uVar7;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  undefined4 local_4;
		  
		  iVar9 = 0;
		  iVar8 = 0;
		  if (DAT_ram_00a593b1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_SingleOrDefault_UserIsleAccountMarkerData___);
		    Mono_Security_ASN1__get_Item(&System_Func_UserIsleAccountMarkerData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_UserIsleAccountMarkerData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_UserIsleAccountMarkerData__Remove__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleController___c__DisplayClass41_0__ValidateAccountMarkers_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Isles_User_Controller_UserIsleController___c__DisplayClass41_0_TypeInfo);
		    DAT_ram_00a593b1 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = *(int *)(*(int *)(iVar1 + 0x4c) + 0xc);
		  if (0 < iVar1) {
		    do {
		      iVar2 = unnamed_function_1417
		                        (
		                        Gameplay_Isles_User_Controller_UserIsleController___c__DisplayClass41_0_TypeInfo
		                        );
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      *(undefined4 *)(iVar2 + 8) = *(undefined4 *)(*(int *)(iVar3 + 0x4c) + iVar9 * 4 + 0x10);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param1_00 = *(undefined4 *)(iVar3 + 0x50);
		      uVar4 = unnamed_function_1417(System_Func_UserIsleAccountMarkerData__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (uVar4,iVar2,
		                 Method_Gameplay_Isles_User_Controller_UserIsleController___c__DisplayClass41_0__ValidateAccountMarkers_b__0__
		                 ,0);
		      iVar3 = UI_SimpleIconValue__set_Value
		                        (param1_00,uVar4,
		                         Method_System_Linq_Enumerable_SingleOrDefault_UserIsleAccountMarkerData___)
		      ;
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar4 = func_ii_7504(*(undefined4 *)(iVar5 + 8),0);
		      param1_01 = *(int **)(iVar2 + 8);
		      iVar5 = *param1_01;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar7 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8);
		          if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo == *piVar10) {
		            puVar6 = (uint *)(piVar10[1] * 8 + iVar5 + 200);
		            goto code_r0x80ff42eb;
		          }
		          uVar7 = uVar7 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		      }
		      puVar6 = (uint *)func_ii_1080(param1_01,
		                                    Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1);
		code_r0x80ff42eb:
		      iVar5 = (**(code **)((ulonglong)*puVar6 * 4))(param1_01,puVar6[1]);
		      iVar5 = Core_Data_UserData__get_Accounts(uVar4,*(undefined4 *)(iVar5 + 0xc),&local_4,0);
		      if (iVar5 == 0) {
		        if (iVar3 != 0) {
		          iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		          func_ii_4876(*(undefined4 *)(iVar2 + 0x50),iVar3,
		                       Method_System_Collections_Generic_List_UserIsleAccountMarkerData__Remove__);
		code_r0x80ff43dc:
		          iVar8 = iVar8 + 1;
		        }
		      }
		      else if (iVar3 == 0) {
		        iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        iVar3 = *(int *)(iVar3 + 0x50);
		        uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        uVar4 = Gameplay_Isles_User_Model_UserIsleAccountMarkerData__set_Position
		                          (uVar4,*(undefined4 *)(iVar2 + 8),0);
		        iVar2 = Method_System_Collections_Generic_List_UserIsleAccountMarkerData__Add__;
		        *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		        uVar7 = *(uint *)(iVar3 + 0xc);
		        if (uVar7 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		          *(uint *)(iVar3 + 0xc) = uVar7 + 1;
		          *(undefined4 *)(*(int *)(iVar3 + 8) + uVar7 * 4 + 0x10) = uVar4;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar3,uVar4,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		        }
		        goto code_r0x80ff43dc;
		      }
		      iVar9 = iVar9 + 1;
		    } while (iVar9 != iVar1);
		    if (iVar8 != 0) {
		      iVar9 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar9 = *(int *)(iVar9 + 0x38);
		      if (iVar9 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar9 + 0xc) * 4))
		                  (*(undefined4 *)(iVar9 + 0x20),*(undefined4 *)(iVar9 + 0x14));
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005303 RID: 21251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005303")]
		[Address(RVA = "0xA0D8", Offset = "0xA0D8", VA = "0xA0D8")]
		private void ValidateAccountMarkers()
		{
		}

		// Token: 0x04002CFB RID: 11515
		[Token(Token = "0x4002CFB")]
		[FieldOffset(Offset = "0x18")]
		private WorldService _worldService;

		// Token: 0x04002CFC RID: 11516
		[Token(Token = "0x4002CFC")]
		[FieldOffset(Offset = "0x1C")]
		private TreeService _treeService;

		// Token: 0x04002CFD RID: 11517
		[Token(Token = "0x4002CFD")]
		[FieldOffset(Offset = "0x20")]
		private ServicesService _servicesService;

		// Token: 0x04002CFE RID: 11518
		[Token(Token = "0x4002CFE")]
		[FieldOffset(Offset = "0x24")]
		private Coroutine _monsterTimerCoroutine;

		// Token: 0x04002CFF RID: 11519
		[Token(Token = "0x4002CFF")]
		[FieldOffset(Offset = "0x28")]
		private Queue<uint> _isleBonusesToCollect;

		// Token: 0x02000D3C RID: 3388
		[Token(Token = "0x2000D3C")]
		public enum RequestFlag
		{
			// Token: 0x04002D01 RID: 11521
			[Token(Token = "0x4002D01")]
			UNKNOWN,
			// Token: 0x04002D02 RID: 11522
			[Token(Token = "0x4002D02")]
			START_BUILD
		}
	}
}
