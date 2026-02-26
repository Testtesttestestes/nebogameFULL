using System;
using Gameplay.AccountLinker.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Auth2;
using ServicesNamespace;
using Utils;

namespace Gameplay.AccountLinker.Control
{
	// Token: 0x02000E19 RID: 3609
	[Token(Token = "0x2000E19")]
	public class AccountLinkerController : AbstractController<AccountLinkerModel, AccountLinkerEvents>
	{
		// Token: 0x060057F8 RID: 22520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057F8")]
		[Address(RVA = "0xA56A", Offset = "0xA56A", VA = "0xA56A", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: <HandleOtpTokenGen>b__22_1 ---
		void Gameplay_AccountLinker_Control_AccountLinkerController___HandleOtpTokenGen_b__22_1
		               (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined1 auStack_8 [8];
		  
		  if (DAT_ram_00a63b83 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGameRestart_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_RegisterV2_Control_IRegistration_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerController___c__DisplayClass29_0__StartRegisterProcess_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_AccountLinker_Control_AccountLinkerController___c__DisplayClass29_0_TypeInfo
		              );
		    DAT_ram_00a63b83 = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_AccountLinker_Control_AccountLinkerController___c__DisplayClass29_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar2 + 8) = param2;
		  *(int **)(iVar2 + 0xc) = param1;
		  iVar6 = *param1;
		  if (*(int *)(param3 + 0xc) == 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                      (param1,*(undefined4 *)(iVar6 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x2c);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(int *)(iVar2 + 8) != 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      piVar4 = *(int **)(iVar2 + 0x38);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      uVar7 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar2 = *piVar4;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGameRestart_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x82360833;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGameRestart_TypeInfo,0);
		code_r0x82360833:
		      (**(code **)((ulonglong)*puVar3 * 4))(auStack_8,piVar4,uVar7,puVar3[1]);
		    }
		  }
		  else {
		    iVar6 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x100) * 4))
		                      (param1,*(undefined4 *)(iVar6 + 0x104));
		    if (*(int *)(iVar6 + 0x28) == 0) {
		      if (*(int *)(param3 + 0xc) == 0x66 || *(int *)(param3 + 0xc) == 1) {
		        iVar6 = param1[6];
		        uVar7 = *(undefined4 *)(*(int *)(iVar2 + 8) + 0xc);
		        if (DAT_ram_00a63c4b == '\0') {
		          Mono_Security_ASN1__get_Item(&Localization_Culture_Culture_TypeInfo);
		          DAT_ram_00a63c4b = '\x01';
		        }
		        piVar4 = (int *)Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__GetBase64ZipContent
		                                  (*(undefined4 *)
		                                    (*(int *)(Localization_Culture_Culture_TypeInfo + 0x5c) + 4),0);
		        uVar5 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xf8) * 4))
		                          (piVar4,*(undefined4 *)(*piVar4 + 0xfc));
		        uVar7 = ServicesNamespace_Auth2Service__ServerEventHandler(iVar6,uVar7,uVar5,0);
		        uVar5 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		        UnityEngine_UIElements_VisualElement__get_layout
		                  (uVar5,iVar2,
		                   Method_Gameplay_AccountLinker_Control_AccountLinkerController___c__DisplayClass29_0__StartRegisterProcess_b__1__
		                   ,0);
		        uVar7 = ServicesNamespace_MainService__GetUserStats
		                          (uVar7,uVar5,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		        Utils_OpTokenRepository__TryGet(param1[3],uVar7,0);
		      }
		      else {
		        if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		          func_ii_306000(OKG_Logs_Debug_TypeInfo);
		        }
		        func_ii_7109(param3,0);
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x114));
		        iVar2 = *(int *)(iVar2 + 0x28);
		        (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                  (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		      }
		    }
		    else {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar1 = 0;
		      uVar7 = *(undefined4 *)(param3 + 0xc);
		      piVar4 = *(int **)(iVar2 + 0x28);
		      iVar2 = *piVar4;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (Gameplay_RegisterV2_Control_IRegistration_TypeInfo ==
		              *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		            goto code_r0x823608ea;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_RegisterV2_Control_IRegistration_TypeInfo,1);
		code_r0x823608ea:
		      (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar7,puVar3[1]);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar2 = *(int *)(iVar2 + 0x28);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		/* --- GHIDRA: <HandleOtpTokenGen>b__22_0 ---
		void Gameplay_AccountLinker_Control_AccountLinkerController___HandleOtpTokenGen_b__22_0
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  Core_Application_Managers_PlatformSigninManager__get_IsTargetSignin
		            (param1,*(undefined8 *)(param3 + 0x18),param3);
		  return;
		}
		*/

		/* --- GHIDRA: <HandleLoggedUserUserInfoUpdated>b__15_0 ---
		void Gameplay_AccountLinker_Control_AccountLinkerController___HandleLoggedUserUserInfoUpdated_b__15_0
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_24;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63b82 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AccountLinkerController___HandleOtpTokenGen_b__22_0_d___
		              );
		    DAT_ram_00a63b82 = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_38,0);
		  local_1c = local_30;
		  local_28 = 0xffffffff;
		  local_24 = local_38;
		  local_14 = param3;
		  local_10 = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_AbstractPrefetchManager__FetchRequiredInternal_d__15_
		            (&local_24,&local_28,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AccountLinkerController___HandleOtpTokenGen_b__22_0_d___
		            );
		  return;
		}
		*/

		/* --- GHIDRA: <RunSetUserIdAfterAppendRefAccount>b__14_0 ---
		void Gameplay_AccountLinker_Control_AccountLinkerController___RunSetUserIdAfterAppendRefAccount_b__14_0
		               (int *param1,undefined8 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a63b81 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Model_LinkerUser_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LinkerUser__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LinkerUser___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_LinkerUser__TypeInfo);
		    DAT_ram_00a63b81 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_LinkerUser__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,Method_System_Collections_Generic_List_LinkerUser___ctor__);
		  *(undefined4 *)(iVar1 + 0x18) = uVar2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = *(undefined4 *)(iVar1 + 8);
		  iVar3 = unnamed_function_1417(Gameplay_AccountLinker_Model_LinkerUser_TypeInfo);
		  *(undefined4 *)(iVar3 + 0xc) = uVar2;
		  Gameplay_AccountLinker_Control_AccountLinkerController__RequestTokenGen(param1,iVar3,uVar2);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = Method_System_Collections_Generic_List_LinkerUser__Add__;
		  iVar4 = *(int *)(iVar4 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar4 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(iVar4 + 8) + uVar6 * 4 + 0x10) = iVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  if (0 < *(int *)(param3 + 0xc)) {
		    iVar1 = 0;
		    do {
		      uVar2 = *(undefined4 *)(param3 + iVar1 * 4 + 0x10);
		      iVar4 = unnamed_function_1417(Gameplay_AccountLinker_Model_LinkerUser_TypeInfo);
		      *(undefined4 *)(iVar4 + 0xc) = uVar2;
		      Gameplay_AccountLinker_Control_AccountLinkerController__RequestTokenGen(param1,iVar4,uVar2);
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      iVar3 = Method_System_Collections_Generic_List_LinkerUser__Add__;
		      iVar5 = *(int *)(iVar5 + 0x18);
		      *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		      uVar6 = *(uint *)(iVar5 + 0xc);
		      if (uVar6 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		        *(uint *)(iVar5 + 0xc) = uVar6 + 1;
		        *(int *)(*(int *)(iVar5 + 8) + uVar6 * 4 + 0x10) = iVar4;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (iVar5,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(param3 + 0xc));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		/* --- GHIDRA: Dispose ---
		int Gameplay_AccountLinker_Control_AccountLinkerController__Dispose(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63b69 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		    DAT_ram_00a63b69 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x20);
		  if (iVar1 == 0) {
		    iVar1 = unnamed_function_1417(Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		    *(int *)(param1 + 0x20) = iVar1;
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x060057F9 RID: 22521 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011F3")]
		private NebogameSiteHelper SiteHelper
		{
			[Token(Token = "0x60057F9")]
			[Address(RVA = "0xA56B", Offset = "0xA56B", VA = "0xA56B")]
			get
			{
				return null;
			}
		}

		// Token: 0x060057FA RID: 22522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057FA")]
		[Address(RVA = "0xA56C", Offset = "0xA56C", VA = "0xA56C")]
		private void RemoveListenEventForSiteHelper()
		{
		/* --- GHIDRA: RemoveListenEventForSiteHelper ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__RemoveListenEventForSiteHelper
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a63b6b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_AccountLinkerModel__AccountLinkerEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_Auth2Service___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Control_SigninTracker_TypeInfo);
		    DAT_ram_00a63b6b = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_AccountLinkerModel__AccountLinkerEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_Auth2Service___);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
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
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x8235e546;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8235e546:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xf8);
		        goto code_r0x8235e5c8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,7);
		code_r0x8235e5c8:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  param1_00 = unnamed_function_1417(Gameplay_AccountLinker_Control_SigninTracker_TypeInfo);
		  Gameplay_AccountLinker_Control_NebogameSiteHelper__RequestSetEmailAndPass_d__9__SetStateMachine
		            (param1_00,uVar2,param3,uVar2);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x060057FB RID: 22523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057FB")]
		[Address(RVA = "0xA56D", Offset = "0xA56D", VA = "0xA56D")]
		public AccountLinkerController(AccountLinkerModel model, AccountLinkerEvents events)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_AccountLinker_Control_AccountLinkerController___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *param1_00;
		  
		  if (DAT_ram_00a63b6c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_RegisterV2_Control_IRegistration_TypeInfo);
		    DAT_ram_00a63b6c = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar5 = *(int *)(iVar2 + 8);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar5 != 0) {
		    uVar4 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                      (*(undefined4 *)(iVar2 + 8),0);
		    return uVar4;
		  }
		  uVar1 = 0;
		  param1_00 = *(int **)(iVar2 + 0x28);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Gameplay_RegisterV2_Control_IRegistration_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8235e766;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Gameplay_RegisterV2_Control_IRegistration_TypeInfo,0);
		code_r0x8235e766:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  return *(undefined4 *)(iVar2 + 0x1c);
		}
		*/

		}

		// Token: 0x060057FC RID: 22524 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60057FC")]
		[Address(RVA = "0xA56E", Offset = "0xA56E", VA = "0xA56E")]
		public string GetCurrentNick()
		{
		/* --- GHIDRA: GetCurrentNick ---
		undefined4
		Gameplay_AccountLinker_Control_AccountLinkerController__GetCurrentNick
		          (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int iVar4;
		  int *piVar5;
		  
		  if (DAT_ram_00a63b6d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Gameplay_RegisterV2_Control_IRegistration_TypeInfo);
		    DAT_ram_00a63b6d = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar4 = *(int *)(iVar2 + 8);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar4 == 0) {
		    uVar1 = 0;
		    piVar5 = *(int **)(iVar2 + 0x28);
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Gameplay_RegisterV2_Control_IRegistration_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8235e85f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Gameplay_RegisterV2_Control_IRegistration_TypeInfo,0);
		code_r0x8235e85f:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    piVar5 = (int *)(iVar2 + 0x28);
		  }
		  else {
		    piVar5 = (int *)(*(int *)(*(int *)(iVar2 + 8) + 0x38) + 0x10);
		  }
		  return *(undefined4 *)(*piVar5 + 0xc);
		}
		*/

			return null;
		}

		// Token: 0x060057FD RID: 22525 RVA: 0x0000FA80 File Offset: 0x0000DC80
		[Token(Token = "0x60057FD")]
		[Address(RVA = "0xA56F", Offset = "0xA56F", VA = "0xA56F")]
		public uint GetCurrentAprId()
		{
		/* --- GHIDRA: GetCurrentAprId ---
		undefined4
		Gameplay_AccountLinker_Control_AccountLinkerController__GetCurrentAprId
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int param1_00;
		  int param1_01;
		  uint uVar3;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a63b6e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RefAccountInfo__Add__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_RefAccountInfo_TypeInfo);
		    DAT_ram_00a63b6e = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if ((iVar2 != 0) && (*(int *)(iVar2 + 8) != 0)) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param1_01 = *(int *)(*(int *)(iVar2 + 8) + 0x50);
		    param1_00 = unnamed_function_1417(Protocol_Common_RefAccountInfo_TypeInfo);
		    Protocol_Common_RefAccountInfo__pb__Google_Protobuf_IMessage_get_Descriptor(param1_00,0);
		    *(undefined4 *)(param1_00 + 0xc) = param2;
		    Protocol_Common_RefAccountInfo__get_RefNick(param1_00,param3,0);
		    iVar2 = Method_System_Collections_Generic_List_RefAccountInfo__Add__;
		    uVar1 = 1;
		    *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		    uVar3 = *(uint *)(param1_01 + 0xc);
		    if (uVar3 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		      *(uint *)(param1_01 + 0xc) = uVar3 + 1;
		      *(int *)(*(int *)(param1_01 + 8) + uVar3 * 4 + 0x10) = param1_00;
		      return 1;
		    }
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,param1_00,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  return uVar1;
		}
		*/

			return 0U;
		}

		// Token: 0x060057FE RID: 22526 RVA: 0x0000FA98 File Offset: 0x0000DC98
		[Token(Token = "0x60057FE")]
		[Address(RVA = "0xA570", Offset = "0xA570", VA = "0xA570")]
		public bool TryAddRefAccount(Provider provider, string refNick)
		{
		/* --- GHIDRA: TryAddRefAccount ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__TryAddRefAccount
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63b6f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerController_HandleLoggedUserUserInfoUpdated__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a63b6f = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x140);
		        goto code_r0x8235ea47;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8235ea47:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = *(int *)(iVar4 + 0x10);
		  param1_01 = *(undefined4 *)(iVar5 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerController_HandleLoggedUserUserInfoUpdated__
		             ,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(param1_01,param1_00,0);
		  iVar4 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar3) ||
		          (*(int **)(iVar5 + 0x14) = piVar3, *piVar3 != iVar4)) {
		    System_Activator__CreateInstance(piVar3,iVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x140);
		        goto code_r0x8235eb59;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8235eb59:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  Gameplay_User_Controller_UserController__HandleGetOwnClanInfoService
		            (*(undefined4 *)(iVar4 + 0x18),0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060057FF RID: 22527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057FF")]
		[Address(RVA = "0xA571", Offset = "0xA571", VA = "0xA571")]
		private void RunResolveUsersProcess()
		{
		/* --- GHIDRA: RunResolveUsersProcess ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__RunResolveUsersProcess
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  uint *puVar3;
		  int *param1_01;
		  
		  if (DAT_ram_00a63b71 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerController__RunSetUserIdAfterAppendRefAccount_b__14_0__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ILoggedUserIdSetter_TypeInfo);
		    DAT_ram_00a63b71 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(int **)(iVar2 + 0x34);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerController__RunSetUserIdAfterAppendRefAccount_b__14_0__
		             ,0);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_ILoggedUserIdSetter_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8235ed70;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_Managers_ILoggedUserIdSetter_TypeInfo,0);
		code_r0x8235ed70:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_01,param2,param1_00,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x06005800 RID: 22528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005800")]
		[Address(RVA = "0x488A", Offset = "0x488A", VA = "0x488A")]
		private void RunSetUserIdAfterSync(ulong userId)
		{
		}

		// Token: 0x06005801 RID: 22529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005801")]
		[Address(RVA = "0xA572", Offset = "0xA572", VA = "0xA572")]
		private void RunSetUserIdAfterAppendRefAccount(ulong userId)
		{
		/* --- GHIDRA: RunSetUserIdAfterAppendRefAccount ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__RunSetUserIdAfterAppendRefAccount
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined8 uVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  undefined4 uVar8;
		  uint uVar9;
		  
		  if (DAT_ram_00a63b72 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerController_HandleLoggedUserUserInfoUpdated__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerController__HandleLoggedUserUserInfoUpdated_b__15_0__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_CacheResultCallback_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_ICache_ulong__UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a63b72 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar9 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x8235ee62;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8235ee62:
		  uVar4 = CONCAT44(in_register_20000014,puVar2[1]);
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar4);
		  uVar1 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  iVar7 = *(int *)(iVar6 + 0x10);
		  uVar8 = *(undefined4 *)(iVar7 + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerController_HandleLoggedUserUserInfoUpdated__
		             ,0);
		  piVar5 = (int *)func_ii_7048(uVar8,uVar3,0);
		  iVar6 = System_Action_TypeInfo;
		  if (piVar5 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar5) ||
		          (*(int **)(iVar7 + 0x14) = piVar5, *piVar5 != iVar6)) {
		    System_Activator__CreateInstance(piVar5,iVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar4);
		  uVar1 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  if (*(int *)(*(int *)(*(int *)(iVar6 + 8) + 0x54) + 0xc) == 0) {
		    iVar7 = *param1;
		    iVar6 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                      (param1,CONCAT44(uVar1,*(undefined4 *)(iVar7 + 0x104)));
		    uVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(iVar6 + 8),0);
		    Gameplay_AccountLinker_Control_AccountLinkerController__RunResolveUsersProcess
		              (param1,uVar4,iVar7);
		    return;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8 + 4) * 8 + iVar6 + 0x158);
		        goto code_r0x8235ef95;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x8235ef95:
		  uVar4 = CONCAT44(uVar1,puVar2[1]);
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar4);
		  uVar1 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  piVar5 = *(int **)(iVar6 + 0x18);
		  uVar9 = 0;
		  uVar3 = unnamed_function_1417(Core_Cache_CacheResultCallback_UserData__TypeInfo);
		  Cysharp_Threading_Tasks_UniTaskCompletionSource__get_Task
		            (uVar3,param1,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerController__HandleLoggedUserUserInfoUpdated_b__15_0__
		             ,0);
		  uVar4 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar4);
		  uVar1 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar8 = *(undefined4 *)(*(int *)(iVar6 + 8) + 0x54);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Cache_ICache_ulong__UserData__TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x8235f059;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Cache_ICache_ulong__UserData__TypeInfo,1);
		code_r0x8235f059:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar5,CONCAT44(uVar1,uVar3),uVar8,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06005802 RID: 22530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005802")]
		[Address(RVA = "0xA573", Offset = "0xA573", VA = "0xA573")]
		private void HandleLoggedUserUserInfoUpdated()
		{
		/* --- GHIDRA: HandleLoggedUserUserInfoUpdated ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__HandleLoggedUserUserInfoUpdated
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63b73 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerController_HandleOtpCodeGetService__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a63b73 = '\x01';
		  }
		  uVar1 = ServicesNamespace_Auth2Service__Login(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerController_HandleOtpCodeGetService__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpTokenRepository__TryGet(*(undefined4 *)(param1 + 0xc),uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06005803 RID: 22531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005803")]
		[Address(RVA = "0xA574", Offset = "0xA574", VA = "0xA574")]
		private void RequestCodeGet()
		{
		/* --- GHIDRA: RequestCodeGet ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__RequestCodeGet
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63b74 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerController_HandleOtpTokenGenService__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a63b74 = '\x01';
		  }
		  uVar1 = ServicesNamespace_Auth2Service__OTPCodeGet(*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerController_HandleOtpTokenGenService__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpTokenRepository__TryGet(*(undefined4 *)(param1 + 0xc),uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06005804 RID: 22532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005804")]
		[Address(RVA = "0xA575", Offset = "0xA575", VA = "0xA575")]
		private void RequestTokenGen(string code)
		{
		/* --- GHIDRA: RequestTokenGen ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__RequestTokenGen
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a63b75 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerController_HandleGetUserSkillsService__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a63b75 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(param2 + 0xc),0);
		  uVar1 = ServicesNamespace_MainService__ServerEventHandler(uVar1,param2_00,0);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerController_HandleGetUserSkillsService__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06005805 RID: 22533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005805")]
		[Address(RVA = "0xA576", Offset = "0xA576", VA = "0xA576")]
		private void RequestUserSkills(LinkerUser user)
		{
		/* --- GHIDRA: RequestUserSkills ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__RequestUserSkills
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63b76 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_27652);
		    DAT_ram_00a63b76 = '\x01';
		  }
		  Gameplay_AccountLinker_Control_AccountLinkerController__GetCurrentAprId
		            (param1,100,StringLiteral_27652,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x24);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06005806 RID: 22534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005806")]
		[Address(RVA = "0xA577", Offset = "0xA577", VA = "0xA577")]
		private void HandleSetEmailAndPasswordSuccess()
		{
		/* --- GHIDRA: HandleSetEmailAndPasswordSuccess ---
		/* WARNING: Removing unreachable block (ram,0x8235f38e) */
		
		void Gameplay_AccountLinker_Control_AccountLinkerController__HandleSetEmailAndPasswordSuccess
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int *param1_00;
		  int *param1_01;
		  uint uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a63b77 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Model_LinkerUser_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetUserSkillsAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_UserSkillsData_TypeInfo);
		    DAT_ram_00a63b77 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoGetUserSkillsAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoGetUserSkillsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = *(int **)(param2 + 0xc);
		  iVar1 = unnamed_function_1417(Core_Data_UserSkillsData_TypeInfo);
		  param2_00 = Core_Extensions_Dict_ProtoCastExt__ToUserInfo(param1_00,0);
		  Core_Data_UserSkillsData__get_RawData(iVar1,param2_00,0);
		  iVar2 = Gameplay_UserInfo_Model_UserInfoModel__get_ExperienceProgress
		                    (*(undefined4 *)(iVar1 + 0x18),0);
		  iVar1 = Gameplay_AccountLinker_Model_LinkerUser_TypeInfo;
		  uVar3 = (uint)*(byte *)(Gameplay_AccountLinker_Model_LinkerUser_TypeInfo + 0xb8);
		  iVar4 = *param1_01;
		  if (((uVar3 <= *(byte *)(iVar4 + 0xb8)) &&
		      (*(int *)(*(int *)(iVar4 + 100) + uVar3 * 4 + -4) ==
		       Gameplay_AccountLinker_Model_LinkerUser_TypeInfo)) &&
		     (param1_01[2] = iVar2, *(int *)(*(int *)(iVar4 + 100) + uVar3 * 4 + -4) == iVar1)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_01,iVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005807 RID: 22535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005807")]
		[Address(RVA = "0xA578", Offset = "0xA578", VA = "0xA578")]
		private void HandleGetUserSkillsService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetUserSkillsService ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__HandleGetUserSkillsService
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a63b78 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_OTPTokenGenCmd_Types_Ans_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    DAT_ram_00a63b78 = '\x01';
		  }
		  Utils_OpTokenRepository__Add(*(undefined4 *)(param1 + 0xc),param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Auth2_OTPTokenGenCmd_Types_Ans_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Auth2_OTPTokenGenCmd_Types_Ans_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_AccountLinker_Control_AccountLinkerController__HandleOtpTokenGenService
		            (param1,param1_00,param1_00);
		  return;
		}
		*/

		}

		// Token: 0x06005808 RID: 22536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005808")]
		[Address(RVA = "0xA579", Offset = "0xA579", VA = "0xA579")]
		private void HandleOtpTokenGenService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleOtpTokenGenService ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__HandleOtpTokenGenService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 param4;
		  int *param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a63b79 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerController__HandleOtpTokenGen_b__22_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Action_LoggedManager_LoginCallbackInvoker__LoginCmd_Types_Ans__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ILoginProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_IPlatformSigninProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AuthScope_SyncAccountEventArgs_TypeInfo);
		    DAT_ram_00a63b79 = '\x01';
		  }
		  iVar6 = *param1;
		  if (*(int *)(param2 + 0xc) == 1) {
		    iVar6 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                      (param1,*(undefined4 *)(iVar6 + 0x114));
		    iVar6 = *(int *)(iVar6 + 0x34);
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		              (*(undefined4 *)(iVar6 + 0x20),*(undefined4 *)(param2 + 0xc),
		               *(undefined4 *)(iVar6 + 0x14));
		    return;
		  }
		  iVar6 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x100) * 4))
		                    (param1,*(undefined4 *)(iVar6 + 0x104));
		  *(int *)(iVar6 + 0x24) = param2;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_object___AccountLinkerController___c__DisplayClass30_0___RequestSetResolvedUserId_b__1_d_
		                    (uVar2,param1);
		  iVar6 = System_Uri___ctor(0);
		  iVar6 = *(int *)(*(int *)(*(int *)(*(int *)(iVar6 + 0x38) + 0x10) + 8) + 0x20);
		  if (iVar6 != 0) {
		    uVar4 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param4 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    uVar5 = unnamed_function_1417(Core_Events_Scopes_AuthScope_SyncAccountEventArgs_TypeInfo);
		    Core_Events_Scopes_AuthScope_RegistrationRequestEventArgs___ctor(uVar5,uVar2,uVar4,param4,0);
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		              (*(undefined4 *)(iVar6 + 0x20),uVar5,*(undefined4 *)(iVar6 + 0x14));
		  }
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar6 + 8) != 0) {
		    Gameplay_AccountLinker_Control_AccountLinkerController__TryAddRefAccount(param1,param1);
		    return;
		  }
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(int **)(iVar6 + 0x2c);
		  uVar1 = 0;
		  iVar6 = System_Uri___ctor(0);
		  param1_01 = *(int **)(*(int *)(iVar6 + 0x54) + 0xc);
		  iVar6 = *param1_01;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Application_Managers_IPlatformSigninProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8235f604;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Application_Managers_IPlatformSigninProvider_TypeInfo
		                                ,0);
		code_r0x8235f604:
		  uVar1 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  uVar5 = unnamed_function_1417
		                    (System_Action_LoggedManager_LoginCallbackInvoker__LoginCmd_Types_Ans__TypeInfo)
		  ;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		            (uVar5,param1,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerController__HandleOtpTokenGen_b__22_0__
		             ,0);
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_ILoginProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x8235f6a9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_Managers_ILoginProvider_TypeInfo,1);
		code_r0x8235f6a9:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar4,uVar2,uVar5,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x06005809 RID: 22537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005809")]
		[Address(RVA = "0xA57A", Offset = "0xA57A", VA = "0xA57A")]
		private void HandleOtpTokenGen(OTPTokenGenCmd.Types.Ans msg)
		{
		/* --- GHIDRA: HandleOtpTokenGen ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__HandleOtpTokenGen
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a63b7a == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_OTPCodeGetCmd_Types_Ans_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    DAT_ram_00a63b7a = '\x01';
		  }
		  Utils_OpTokenRepository__Add(param1[3],param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Auth2_OTPCodeGetCmd_Types_Ans_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Auth2_OTPCodeGetCmd_Types_Ans_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(undefined4 *)(iVar1 + 0x20);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(int *)(iVar1 + 0x20) = param1_00[4];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                    (param1_01,*(undefined4 *)(iVar1 + 0x20),0);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar1 + 0x14);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar1 + 0x20),
		               *(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600580A RID: 22538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600580A")]
		[Address(RVA = "0xA57B", Offset = "0xA57B", VA = "0xA57B")]
		private void HandleOtpCodeGetService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleOtpCodeGetService ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__HandleOtpCodeGetService
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  Gameplay_AccountLinker_Control_AccountLinkerController__get_SiteHelper(param1,param1);
		  if (DAT_ram_00a63b76 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_27652);
		    DAT_ram_00a63b76 = '\x01';
		  }
		  Gameplay_AccountLinker_Control_AccountLinkerController__GetCurrentAprId
		            (param1,100,StringLiteral_27652,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x24);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x0600580B RID: 22539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600580B")]
		[Address(RVA = "0xA57C", Offset = "0xA57C", VA = "0xA57C")]
		private void HandleSiteHelperSetEmailCompleteEvent()
		{
		/* --- GHIDRA: HandleSiteHelperSetEmailCompleteEvent ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__HandleSiteHelperSetEmailCompleteEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  Gameplay_AccountLinker_Control_AccountLinkerController__get_SiteHelper(param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x0600580C RID: 22540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600580C")]
		[Address(RVA = "0xA57D", Offset = "0xA57D", VA = "0xA57D")]
		private void HandleSiteHelperSetEmailErrorEvent(int errorCode)
		{
		/* --- GHIDRA: HandleSiteHelperSetEmailErrorEvent ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__HandleSiteHelperSetEmailErrorEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_AccountLinker_Control_AccountLinkerController__HandleLoggedUserUserInfoUpdated
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600580D RID: 22541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600580D")]
		[Address(RVA = "0xA57E", Offset = "0xA57E", VA = "0xA57E")]
		public void RequestGetCode()
		{
		/* --- GHIDRA: RequestGetCode ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__RequestGetCode
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_AccountLinker_Control_AccountLinkerController__RequestCodeGet(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x0600580E RID: 22542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600580E")]
		[Address(RVA = "0xA57F", Offset = "0xA57F", VA = "0xA57F")]
		public void RequestSetCode(string code)
		{
		/* --- GHIDRA: RequestSetCode ---
		undefined4
		Gameplay_AccountLinker_Control_AccountLinkerController__RequestSetCode
		          (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param2_00;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int *piVar5;
		  
		  if (DAT_ram_00a63b7b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_PlatformSigninProviderCallback_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerController___c__DisplayClass28_0__TryRequestSigninToTargetProvider_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_AccountLinker_Control_AccountLinkerController___c__DisplayClass28_0_TypeInfo
		              );
		    DAT_ram_00a63b7b = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_AccountLinker_Control_AccountLinkerController___c__DisplayClass28_0_TypeInfo
		                        );
		  *(int **)(param2_00 + 8) = param1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined1 *)(iVar2 + 0x40) = 1;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar5;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		        goto code_r0x8235f99a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8235f99a:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  *(undefined4 *)(param2_00 + 0xc) = uVar4;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x20);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  uVar1 = 0;
		  piVar5 = *(int **)(param2_00 + 0xc);
		  iVar2 = *piVar5;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x128);
		        goto code_r0x8235fa52;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Application_IApp_TypeInfo,0xd);
		code_r0x8235fa52:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  param1_00 = unnamed_function_1417
		                        (Core_Application_Managers_PlatformSigninProviderCallback_TypeInfo);
		  Core_Application_Managers_NotificationManager__InitChannels
		            (param1_00,param2_00,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerController___c__DisplayClass28_0__TryRequestSigninToTargetProvider_b__0__
		             ,0);
		  Core_Application_Managers_PlatformSigninManager__CompleteSignin(uVar4,param1_00,0);
		  return 1;
		}
		*/

		}

		// Token: 0x0600580F RID: 22543 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
		[Token(Token = "0x600580F")]
		[Address(RVA = "0xA580", Offset = "0xA580", VA = "0xA580")]
		public bool TryRequestSigninToTargetProvider()
		{
		/* --- GHIDRA: TryRequestSigninToTargetProvider ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__TryRequestSigninToTargetProvider
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  uint *puVar3;
		  int *param1_01;
		  
		  if (DAT_ram_00a63b7c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerController__StartRegisterProcess_b__29_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Action_LoggedManager_RegisterCallbackInvoker__RegisterCmd_Types_Ans__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_IRegistrationProvider_TypeInfo);
		    DAT_ram_00a63b7c = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(int **)(iVar2 + 0x30);
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Action_LoggedManager_RegisterCallbackInvoker__RegisterCmd_Types_Ans__TypeInfo
		                        );
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		            (param1_00,param1,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerController__StartRegisterProcess_b__29_0__
		             ,0);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_IRegistrationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x823594a5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_Managers_IRegistrationProvider_TypeInfo,0);
		code_r0x823594a5:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_01,param2,param3,param1_00,puVar3[1]);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005810 RID: 22544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005810")]
		[Address(RVA = "0xA581", Offset = "0xA581", VA = "0xA581")]
		public void StartRegisterProcess(string nick, uint aprId)
		{
		/* --- GHIDRA: StartRegisterProcess ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__StartRegisterProcess
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param4;
		  undefined4 param1_00;
		  longlong lVar5;
		  longlong lVar6;
		  undefined8 uVar7;
		  int *param1_01;
		  undefined4 param5;
		  uint uVar8;
		  
		  if (DAT_ram_00a63b7d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ILoggedUserIdSetter_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AuthScope_SyncAccountEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerController___c__DisplayClass30_0__RequestSetResolvedUserId_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_AccountLinker_Control_AccountLinkerController___c__DisplayClass30_0_TypeInfo
		              );
		    DAT_ram_00a63b7d = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_AccountLinker_Control_AccountLinkerController___c__DisplayClass30_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0xc) = param2;
		  *(int **)(iVar1 + 8) = param1;
		  uVar7 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		  uVar4 = (undefined4)((ulonglong)uVar7 >> 0x20);
		  lVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar2 + 8),0);
		  lVar6 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar1 + 0xc) + 0xc),0);
		  if (lVar5 == lVar6) {
		    iVar2 = System_Uri___ctor(0);
		    iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 8) + 0x24);
		    if (iVar2 != 0) {
		      uVar7 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(*(int *)(iVar1 + 0xc) + 0xc),0);
		      uVar4 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(*(int *)(iVar1 + 0xc) + 0xc),0);
		      param4 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param5 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      param1_00 = unnamed_function_1417(Core_Events_Scopes_AuthScope_SyncAccountEventArgs_TypeInfo);
		      Core_Events_Scopes_AuthScope_SyncAccountEventArgs___ctor
		                (param1_00,uVar7,uVar4,param4,param5,0);
		      uVar7 = CONCAT44((int)((ulonglong)uVar7 >> 0x20),param1_00);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),uVar7,*(undefined4 *)(iVar2 + 0x14));
		      uVar4 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x114)));
		    iVar1 = *(int *)(iVar1 + 0x30);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    return;
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x104)));
		  param1_01 = *(int **)(iVar2 + 0x34);
		  uVar8 = 0;
		  uVar7 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar1 + 0xc) + 0xc),0);
		  uVar4 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,iVar1,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerController___c__DisplayClass30_0__RequestSetResolvedUserId_b__0__
		             ,0);
		  iVar1 = *param1_01;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_ILoggedUserIdSetter_TypeInfo ==
		          *(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8)) {
		        puVar3 = (uint *)(iVar1 + *(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8235de94;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar8);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_Managers_ILoggedUserIdSetter_TypeInfo,0);
		code_r0x8235de94:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_01,uVar7,uVar4,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x06005811 RID: 22545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005811")]
		[Address(RVA = "0xA582", Offset = "0xA582", VA = "0xA582")]
		public void RequestSetResolvedUserId(LinkerUser userWrapper)
		{
		/* --- GHIDRA: RequestSetResolvedUserId ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__RequestSetResolvedUserId
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a63b7e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19433);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a63b7e = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x8235fb5b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8235fb5b:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetResourceSetParameter(uVar3,StringLiteral_5,0);
		  Core_ExternAppMethods__OpenPaymentWindow(uVar3,StringLiteral_19433,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06005812 RID: 22546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005812")]
		[Address(RVA = "0xA583", Offset = "0xA583", VA = "0xA583")]
		public void OpenPageHowGetCodeFromWebSite()
		{
		/* --- GHIDRA: OpenPageHowGetCodeFromWebSite ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__OpenPageHowGetCodeFromWebSite
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63b69 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		    DAT_ram_00a63b69 = '\x01';
		  }
		  if (*(int *)(param1 + 0x20) == 0) {
		    uVar1 = unnamed_function_1417(Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		    *(undefined4 *)(param1 + 0x20) = uVar1;
		  }
		  if (DAT_ram_00a63bae == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1689);
		    DAT_ram_00a63bae = '\x01';
		  }
		  local_4 = param2;
		  uVar1 = func_ii_4443(&local_4,0);
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_1689,uVar1,0);
		  if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Application_TypeInfo);
		  }
		  UnityEngine_Application__get_cloudProjectId(uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06005813 RID: 22547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005813")]
		[Address(RVA = "0xA584", Offset = "0xA584", VA = "0xA584")]
		public void InvokeOAuth(Provider provider)
		{
		/* --- GHIDRA: InvokeOAuth ---
		int Gameplay_AccountLinker_Control_AccountLinkerController__InvokeOAuth
		              (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int param1_00;
		  int iVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a63b7f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerController_HandleSiteHelperSetEmailCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerController_HandleSiteHelperSetEmailErrorEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63b7f = '\x01';
		  }
		  if (DAT_ram_00a63b69 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		    DAT_ram_00a63b69 = '\x01';
		  }
		  iVar7 = *(int *)(param1 + 0x20);
		  if (iVar7 == 0) {
		    iVar7 = unnamed_function_1417(Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		    *(int *)(param1 + 0x20) = iVar7;
		  }
		  uVar4 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke
		            (uVar4,param1,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerController_HandleSiteHelperSetEmailErrorEvent__
		             ,0);
		  if (DAT_ram_00a63ba9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a63ba9 = '\x01';
		  }
		  iVar8 = *(int *)(iVar7 + 8);
		  do {
		    iVar3 = 0;
		    iVar5 = UnityEngine_UI_Image__set_sprite(iVar8,uVar4,0);
		    uVar2 = System_Action_int__TypeInfo;
		    if ((iVar5 != 0) && (iVar3 = func_ii_1082(iVar5,System_Action_int__TypeInfo), iVar3 == 0)) {
		      System_Activator__CreateInstance(iVar5,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = func_ii_4329(iVar7 + 8,iVar3,iVar8);
		    bVar1 = iVar3 != iVar8;
		    iVar8 = iVar3;
		  } while (bVar1);
		  if (DAT_ram_00a63b69 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		    DAT_ram_00a63b69 = '\x01';
		  }
		  iVar7 = *(int *)(param1 + 0x20);
		  if (iVar7 == 0) {
		    iVar7 = unnamed_function_1417(Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		    *(int *)(param1 + 0x20) = iVar7;
		  }
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerController_HandleSiteHelperSetEmailCompleteEvent__
		             ,0);
		  if (DAT_ram_00a63bab == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63bab = '\x01';
		  }
		  iVar8 = *(int *)(iVar7 + 0xc);
		  do {
		    piVar6 = (int *)UnityEngine_UI_Image__set_sprite(iVar8,uVar4,0);
		    if ((piVar6 != (int *)0x0) && (System_Action_TypeInfo != *piVar6)) {
		      System_Activator__CreateInstance(piVar6,System_Action_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = func_ii_4329(iVar7 + 0xc,piVar6,iVar8);
		    bVar1 = iVar3 != iVar8;
		    iVar8 = iVar3;
		  } while (bVar1);
		  if (DAT_ram_00a63b69 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		    DAT_ram_00a63b69 = '\x01';
		  }
		  iVar7 = *(int *)(param1 + 0x20);
		  if (iVar7 == 0) {
		    iVar7 = unnamed_function_1417(Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		    *(int *)(param1 + 0x20) = iVar7;
		  }
		  iVar7 = Gameplay_AccountLinker_Control_NebogameSiteHelper__InvokeOAuth(iVar7,param2,param3,iVar7);
		  if (iVar7 == 0) {
		    if (DAT_ram_00a63b69 == '\0') {
		      Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		      DAT_ram_00a63b69 = '\x01';
		    }
		    iVar8 = *(int *)(param1 + 0x20);
		    if (iVar8 == 0) {
		      iVar8 = unnamed_function_1417(Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		      *(int *)(param1 + 0x20) = iVar8;
		    }
		    uVar4 = unnamed_function_1417(System_Action_int__TypeInfo);
		    System_Action_short___Invoke
		              (uVar4,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerController_HandleSiteHelperSetEmailErrorEvent__
		               ,0);
		    if (DAT_ram_00a63baa == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		      DAT_ram_00a63baa = '\x01';
		    }
		    iVar3 = *(int *)(iVar8 + 8);
		    do {
		      iVar5 = 0;
		      param1_00 = func_ii_7048(iVar3,uVar4,0);
		      uVar2 = System_Action_int__TypeInfo;
		      if ((param1_00 != 0) &&
		         (iVar5 = func_ii_1082(param1_00,System_Action_int__TypeInfo), iVar5 == 0)) {
		        System_Activator__CreateInstance(param1_00,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar5 = func_ii_4329(iVar8 + 8,iVar5,iVar3);
		      bVar1 = iVar5 != iVar3;
		      iVar3 = iVar5;
		    } while (bVar1);
		    if (DAT_ram_00a63b69 == '\0') {
		      Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		      DAT_ram_00a63b69 = '\x01';
		    }
		    iVar8 = *(int *)(param1 + 0x20);
		    if (iVar8 == 0) {
		      iVar8 = unnamed_function_1417(Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		      *(int *)(param1 + 0x20) = iVar8;
		    }
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerController_HandleSiteHelperSetEmailCompleteEvent__
		               ,0);
		    if (DAT_ram_00a63bac == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      DAT_ram_00a63bac = '\x01';
		    }
		    iVar3 = *(int *)(iVar8 + 0xc);
		    do {
		      piVar6 = (int *)func_ii_7048(iVar3,uVar4,0);
		      if ((piVar6 != (int *)0x0) && (System_Action_TypeInfo != *piVar6)) {
		        System_Activator__CreateInstance(piVar6,System_Action_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar5 = func_ii_4329(iVar8 + 0xc,piVar6,iVar3);
		      bVar1 = iVar5 != iVar3;
		      iVar3 = iVar5;
		    } while (bVar1);
		  }
		  return iVar7;
		}
		*/

		}

		// Token: 0x06005814 RID: 22548 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
		[Token(Token = "0x6005814")]
		[Address(RVA = "0xA585", Offset = "0xA585", VA = "0xA585")]
		public bool SetEmailAndPass(string email, string password)
		{
		/* --- GHIDRA: SetEmailAndPass ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__SetEmailAndPass
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(char *)(iVar1 + 0x40) != '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Core_Application_Managers_PlatformSigninManager__Commit(*(undefined4 *)(iVar1 + 0x3c),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined1 *)(iVar1 + 0x40) = 0;
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005815 RID: 22549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005815")]
		[Address(RVA = "0xA586", Offset = "0xA586", VA = "0xA586", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__HandleStop
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a63b80 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_RegisterV2_Control_IRegistration_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    DAT_ram_00a63b80 = '\x01';
		  }
		  piVar4 = *(int **)(param2 + 0x20);
		  if ((piVar4 != (int *)0x0) && (Protocol_Common_ProtoDefaultAns_TypeInfo != *piVar4)) {
		    System_Activator__CreateInstance(piVar4,Protocol_Common_ProtoDefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (-1 < piVar4[3]) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x2c);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    piVar4 = *(int **)(iVar2 + 0x28);
		    if (piVar4 != (int *)0x0) {
		      uVar1 = 0;
		      iVar2 = *piVar4;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (Gameplay_RegisterV2_Control_IRegistration_TypeInfo ==
		              *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		            goto code_r0x823603f0;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_RegisterV2_Control_IRegistration_TypeInfo,2);
		code_r0x823603f0:
		      (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x04002FAC RID: 12204
		[Token(Token = "0x4002FAC")]
		public const string TEMP_REF_NICK = "temp_for_this_session";

		// Token: 0x04002FAD RID: 12205
		[Token(Token = "0x4002FAD")]
		[FieldOffset(Offset = "0x18")]
		private Auth2Service _authService;

		// Token: 0x04002FAE RID: 12206
		[Token(Token = "0x4002FAE")]
		[FieldOffset(Offset = "0x1C")]
		private SigninTracker _signinTracker;

		// Token: 0x04002FAF RID: 12207
		[Token(Token = "0x4002FAF")]
		[FieldOffset(Offset = "0x20")]
		private NebogameSiteHelper _siteHelper;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SiteHelper ---
		void Gameplay_AccountLinker_Control_AccountLinkerController__get_SiteHelper
		               (int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int iVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  int param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a63b6a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerController_HandleSiteHelperSetEmailCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerController_HandleSiteHelperSetEmailErrorEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63b6a = '\x01';
		  }
		  iVar5 = *(int *)(param1 + 0x20);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerController_HandleSiteHelperSetEmailCompleteEvent__
		             ,0);
		  if (DAT_ram_00a63bac == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63bac = '\x01';
		  }
		  iVar2 = *(int *)(iVar5 + 0xc);
		  while ((param1_00 = (int *)func_ii_7048(iVar2,uVar3,0), param1_00 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_00))) {
		    iVar4 = func_ii_4329(iVar5 + 0xc,param1_00,iVar2);
		    bVar1 = iVar4 == iVar2;
		    iVar2 = iVar4;
		    if (bVar1) {
		      iVar5 = *(int *)(param1 + 0x20);
		      uVar3 = unnamed_function_1417(System_Action_int__TypeInfo);
		      System_Action_short___Invoke
		                (uVar3,param1,
		                 Method_Gameplay_AccountLinker_Control_AccountLinkerController_HandleSiteHelperSetEmailErrorEvent__
		                 ,0);
		      if (DAT_ram_00a63baa == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		        DAT_ram_00a63baa = '\x01';
		      }
		      iVar2 = *(int *)(iVar5 + 8);
		      while( true ) {
		        iVar4 = 0;
		        param1_01 = func_ii_7048(iVar2,uVar3,0);
		        param2_00 = System_Action_int__TypeInfo;
		        if ((param1_01 != 0) &&
		           (iVar4 = func_ii_1082(param1_01,System_Action_int__TypeInfo), iVar4 == 0)) break;
		        iVar4 = func_ii_4329(iVar5 + 8,iVar4,iVar2);
		        bVar1 = iVar4 == iVar2;
		        iVar2 = iVar4;
		        if (bVar1) {
		          return;
		        }
		      }
		      System_Activator__CreateInstance(param1_01,param2_00);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(param1_00,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
