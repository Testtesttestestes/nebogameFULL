using System;
using Gameplay.AccountLinker.Control;
using Gameplay.AccountLinker.ProgressSaver.Model;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Auth2;
using Protocol.Common;

namespace Gameplay.AccountLinker.ProgressSaver.Controller
{
	// Token: 0x02000E0F RID: 3599
	[Token(Token = "0x2000E0F")]
	public class ProgressSaverController : AbstractController<ProgressSaverModel, ProgressSaverEvents>
	{
		// Token: 0x060057AA RID: 22442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057AA")]
		[Address(RVA = "0xA51D", Offset = "0xA51D", VA = "0xA51D", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  if (DAT_ram_00a5893b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ProgressSaverModel__ProgressSaverEvents___ctor__);
		    DAT_ram_00a5893b = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param3,param4,
		             Method_MVC_AbstractController_ProgressSaverModel__ProgressSaverEvents___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param2;
		  return;
		}
		*/

		}

		// Token: 0x060057AB RID: 22443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057AB")]
		[Address(RVA = "0xA51E", Offset = "0xA51E", VA = "0xA51E")]
		public ProgressSaverController(AccountLinker accountLinker, ProgressSaverModel model, ProgressSaverEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5893c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSiteHelperSetEmailCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSiteHelperSetEmailErrorEvent__
		              );
		    DAT_ram_00a5893c = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSiteHelperSetEmailCompleteEvent__
		             ,0);
		  Gameplay_AccountLinker_Control_NebogameSiteHelper__add_SetEmailCompleteEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke
		            (uVar1,param1,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSiteHelperSetEmailErrorEvent__
		             ,0);
		  Gameplay_AccountLinker_Control_NebogameSiteHelper__add_SetEmailErrorEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060057AC RID: 22444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057AC")]
		[Address(RVA = "0xA51F", Offset = "0xA51F", VA = "0xA51F")]
		private void RemoveListenEventForSiteHelper()
		{
		/* --- GHIDRA: RemoveListenEventForSiteHelper ---
		int Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__RemoveListenEventForSiteHelper
		              (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5893d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		    DAT_ram_00a5893d = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x1c);
		  if (iVar1 == 0) {
		    iVar1 = unnamed_function_1417(Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		    *(int *)(param1 + 0x1c) = iVar1;
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x060057AD RID: 22445 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011EA")]
		private NebogameSiteHelper SiteHelper
		{
			[Token(Token = "0x60057AD")]
			[Address(RVA = "0xA520", Offset = "0xA520", VA = "0xA520")]
			get
			{
				return null;
			}
		}

		// Token: 0x060057AE RID: 22446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057AE")]
		[Address(RVA = "0xA521", Offset = "0xA521", VA = "0xA521", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__HandleStop
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a5893f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSigninTargetProviderStartedEvent__
		              );
		    DAT_ram_00a5893f = '\x01';
		  }
		  iVar2 = *(int *)param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                    ((int *)param1[6],*(undefined4 *)(iVar2 + 0x114));
		  param1_02 = *(undefined4 *)(iVar1 + 0x20);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSigninTargetProviderStartedEvent__
		             ,0);
		  param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_02,param1_00,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x20) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_01) ||
		          (*(int **)(iVar1 + 0x20) = param1_01, *param1_01 != iVar2)) {
		    System_Activator__CreateInstance(param1_01,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 8);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060057AF RID: 22447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057AF")]
		[Address(RVA = "0xA522", Offset = "0xA522", VA = "0xA522", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__HandleRun
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__HandleSiteHelperSetEmailCompleteEvent
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060057B0 RID: 22448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B0")]
		[Address(RVA = "0xA523", Offset = "0xA523", VA = "0xA523")]
		private void HandleSigninTargetProviderStartedEvent()
		{
		/* --- GHIDRA: HandleSigninTargetProviderStartedEvent ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__HandleSigninTargetProviderStartedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *param1_00;
		  
		  if (DAT_ram_00a58940 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedSetEmailErrors___
		              );
		    DAT_ram_00a58940 = '\x01';
		  }
		  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController___ctor(param1,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a58938 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IAuthDataProvider_TypeInfo);
		    DAT_ram_00a58938 = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = *(int **)(iVar2 + 0xc);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f4b5ff;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x80f4b5ff:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  *(undefined4 *)(iVar2 + 0x10) = 0;
		  UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		            (param2,0,
		             Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedSetEmailErrors___
		            );
		  return;
		}
		*/

		}

		// Token: 0x060057B1 RID: 22449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B1")]
		[Address(RVA = "0xA524", Offset = "0xA524", VA = "0xA524")]
		private void HandleSiteHelperSetEmailErrorEvent(int errorCode)
		{
		/* --- GHIDRA: HandleSiteHelperSetEmailErrorEvent ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__HandleSiteHelperSetEmailErrorEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58941 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_27652);
		    DAT_ram_00a58941 = '\x01';
		  }
		  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController___ctor(param1,param1);
		  Gameplay_AccountLinker_Control_AccountLinkerController__GetCurrentAprId
		            (param1[6],100,StringLiteral_27652,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060057B2 RID: 22450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B2")]
		[Address(RVA = "0xA525", Offset = "0xA525", VA = "0xA525")]
		private void HandleSiteHelperSetEmailCompleteEvent()
		{
		/* --- GHIDRA: HandleSiteHelperSetEmailCompleteEvent ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__HandleSiteHelperSetEmailCompleteEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a58942 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__uint__RepeatedField_string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleInvalidNickErrorEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleLinkageProcessSuccessEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSetUserSuccessEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSigninTargetProviderFailedEvent__
		              );
		    DAT_ram_00a58942 = '\x01';
		  }
		  iVar6 = **(int **)(param1 + 0x18);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(param1 + 0x18),*(undefined4 *)(iVar6 + 0x114));
		  uVar5 = *(undefined4 *)(iVar1 + 0x28);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSigninTargetProviderFailedEvent__
		             ,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  iVar6 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x28) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar3) ||
		          (*(int **)(iVar1 + 0x28) = piVar3, *piVar3 != iVar6)) {
		    System_Activator__CreateInstance(piVar3,iVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar6 = **(int **)(param1 + 0x18);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(param1 + 0x18),*(undefined4 *)(iVar6 + 0x114));
		  uVar5 = *(undefined4 *)(iVar6 + 0x38);
		  uVar2 = unnamed_function_1417(System_Action_string__uint__RepeatedField_string___TypeInfo);
		  System_Action_object__object__StringView___Invoke
		            (uVar2,param1,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleInvalidNickErrorEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_string__uint__RepeatedField_string___TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar6 + 0x38) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar1,System_Action_string__uint__RepeatedField_string___TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar6 + 0x38) = iVar4;
		    uVar2 = System_Action_string__uint__RepeatedField_string___TypeInfo;
		    iVar6 = func_ii_1082(iVar1,System_Action_string__uint__RepeatedField_string___TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar6 = **(int **)(param1 + 0x18);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(param1 + 0x18),*(undefined4 *)(iVar6 + 0x114));
		  uVar5 = *(undefined4 *)(iVar1 + 0x2c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleLinkageProcessSuccessEvent__
		             ,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  iVar6 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x2c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar3) ||
		          (*(int **)(iVar1 + 0x2c) = piVar3, *piVar3 != iVar6)) {
		    System_Activator__CreateInstance(piVar3,iVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar6 = **(int **)(param1 + 0x18);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(param1 + 0x18),*(undefined4 *)(iVar6 + 0x114));
		  uVar5 = *(undefined4 *)(iVar1 + 0x30);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSetUserSuccessEvent__
		             ,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  iVar6 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x30) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(iVar1 + 0x30) = piVar3, *piVar3 == iVar6)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar6);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060057B3 RID: 22451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B3")]
		[Address(RVA = "0xA526", Offset = "0xA526", VA = "0xA526")]
		private void StartAccountLinkerEvents()
		{
		/* --- GHIDRA: StartAccountLinkerEvents ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__StartAccountLinkerEvents
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a58943 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__uint__RepeatedField_string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleInvalidNickErrorEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleLinkageProcessSuccessEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSetUserSuccessEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSigninTargetProviderFailedEvent__
		              );
		    DAT_ram_00a58943 = '\x01';
		  }
		  iVar6 = **(int **)(param1 + 0x18);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(param1 + 0x18),*(undefined4 *)(iVar6 + 0x114));
		  uVar5 = *(undefined4 *)(iVar1 + 0x28);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSigninTargetProviderFailedEvent__
		             ,0);
		  piVar3 = (int *)func_ii_7048(uVar5,uVar2,0);
		  iVar6 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x28) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar3) ||
		          (*(int **)(iVar1 + 0x28) = piVar3, *piVar3 != iVar6)) {
		    System_Activator__CreateInstance(piVar3,iVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar6 = **(int **)(param1 + 0x18);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(param1 + 0x18),*(undefined4 *)(iVar6 + 0x114));
		  uVar5 = *(undefined4 *)(iVar6 + 0x38);
		  uVar2 = unnamed_function_1417(System_Action_string__uint__RepeatedField_string___TypeInfo);
		  System_Action_object__object__StringView___Invoke
		            (uVar2,param1,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleInvalidNickErrorEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_string__uint__RepeatedField_string___TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar6 + 0x38) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar1,System_Action_string__uint__RepeatedField_string___TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar6 + 0x38) = iVar4;
		    uVar2 = System_Action_string__uint__RepeatedField_string___TypeInfo;
		    iVar6 = func_ii_1082(iVar1,System_Action_string__uint__RepeatedField_string___TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar6 = **(int **)(param1 + 0x18);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(param1 + 0x18),*(undefined4 *)(iVar6 + 0x114));
		  uVar5 = *(undefined4 *)(iVar1 + 0x2c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleLinkageProcessSuccessEvent__
		             ,0);
		  piVar3 = (int *)func_ii_7048(uVar5,uVar2,0);
		  iVar6 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x2c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar3) ||
		          (*(int **)(iVar1 + 0x2c) = piVar3, *piVar3 != iVar6)) {
		    System_Activator__CreateInstance(piVar3,iVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar6 = **(int **)(param1 + 0x18);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(param1 + 0x18),*(undefined4 *)(iVar6 + 0x114));
		  uVar5 = *(undefined4 *)(iVar1 + 0x30);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSetUserSuccessEvent__
		             ,0);
		  piVar3 = (int *)func_ii_7048(uVar5,uVar2,0);
		  iVar6 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x30) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(iVar1 + 0x30) = piVar3, *piVar3 == iVar6)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar6);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060057B4 RID: 22452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B4")]
		[Address(RVA = "0xA527", Offset = "0xA527", VA = "0xA527")]
		private void StopAccountLinkerEvents()
		{
		/* --- GHIDRA: StopAccountLinkerEvents ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__StopAccountLinkerEvents
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58944 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController___c__DisplayClass14_0__HandleInvalidNickErrorEvent_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController___c__DisplayClass14_0_TypeInfo
		              );
		    DAT_ram_00a58944 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController___c__DisplayClass14_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0xc) = param3;
		  *(undefined4 *)(param2_00 + 8) = param1;
		  param1_00 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param2_00,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController___c__DisplayClass14_0__HandleInvalidNickErrorEvent_b__0__
		             ,0);
		  Gameplay_UserInfo_View_ExistNickResolverWindow__HandleConfirmButtonOnClickEvent
		            (param2,param4,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060057B5 RID: 22453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B5")]
		[Address(RVA = "0xA528", Offset = "0xA528", VA = "0xA528")]
		private void HandleInvalidNickErrorEvent(string nick, uint aprId, RepeatedField<string> nickVariants)
		{
		}

		// Token: 0x060057B6 RID: 22454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B6")]
		[Address(RVA = "0xA529", Offset = "0xA529", VA = "0xA529")]
		private void HandleSetUserSuccessEvent()
		{
		/* --- GHIDRA: HandleSetUserSuccessEvent ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__HandleSetUserSuccessEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__StartAccountLinkerEvents
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060057B7 RID: 22455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B7")]
		[Address(RVA = "0xA52A", Offset = "0xA52A", VA = "0xA52A")]
		private void HandleSigninTargetProviderFailedEvent()
		{
		/* --- GHIDRA: HandleSigninTargetProviderFailedEvent ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__HandleSigninTargetProviderFailedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__StartAccountLinkerEvents
		            (param1,param1);
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

		// Token: 0x060057B8 RID: 22456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B8")]
		[Address(RVA = "0xA52B", Offset = "0xA52B", VA = "0xA52B")]
		private void HandleLinkageProcessSuccessEvent()
		{
		/* --- GHIDRA: HandleLinkageProcessSuccessEvent ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__HandleLinkageProcessSuccessEvent
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a58945 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSiteHelperSetEmailCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSiteHelperSetEmailErrorEvent__
		              );
		    DAT_ram_00a58945 = '\x01';
		  }
		  if (DAT_ram_00a5893d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		    DAT_ram_00a5893d = '\x01';
		  }
		  iVar4 = param1[7];
		  if (iVar4 == 0) {
		    iVar4 = unnamed_function_1417(Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		    param1[7] = iVar4;
		  }
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSiteHelperSetEmailCompleteEvent__
		             ,0);
		  Gameplay_AccountLinker_Control_NebogameSiteHelper__remove_SetEmailErrorEvent(iVar4,uVar2,0);
		  if (DAT_ram_00a5893d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		    DAT_ram_00a5893d = '\x01';
		  }
		  iVar4 = param1[7];
		  if (iVar4 == 0) {
		    iVar4 = unnamed_function_1417(Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		    param1[7] = iVar4;
		  }
		  uVar2 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke
		            (uVar2,param1,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSiteHelperSetEmailErrorEvent__
		             ,0);
		  Gameplay_AccountLinker_Control_AccountLinkerViewMediator___c___HandleSetupView_b__7_0
		            (iVar4,uVar2,0);
		  if (DAT_ram_00a5893d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		    DAT_ram_00a5893d = '\x01';
		  }
		  iVar4 = param1[7];
		  if (iVar4 == 0) {
		    iVar4 = unnamed_function_1417(Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		    param1[7] = iVar4;
		  }
		  iVar4 = Gameplay_AccountLinker_Control_NebogameSiteHelper__InvokeOAuth(iVar4,param2,param3,0);
		  if (iVar4 == 0) {
		    if (DAT_ram_00a5893d == '\0') {
		      Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		      DAT_ram_00a5893d = '\x01';
		    }
		    iVar4 = param1[7];
		    if (iVar4 == 0) {
		      iVar4 = unnamed_function_1417(Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		      param1[7] = iVar4;
		    }
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSiteHelperSetEmailCompleteEvent__
		               ,0);
		    Gameplay_AccountLinker_Control_NebogameSiteHelper__add_SetEmailCompleteEvent(iVar4,uVar2,0);
		    if (DAT_ram_00a5893d == '\0') {
		      Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		      DAT_ram_00a5893d = '\x01';
		    }
		    iVar4 = param1[7];
		    if (iVar4 == 0) {
		      iVar4 = unnamed_function_1417(Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		      param1[7] = iVar4;
		    }
		    uVar2 = unnamed_function_1417(System_Action_int__TypeInfo);
		    System_Action_short___Invoke
		              (uVar2,param1,
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSiteHelperSetEmailErrorEvent__
		               ,0);
		    Gameplay_AccountLinker_Control_NebogameSiteHelper__add_SetEmailErrorEvent(iVar4,uVar2,0);
		    return;
		  }
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a58938 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IAuthDataProvider_TypeInfo);
		    DAT_ram_00a58938 = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = *(int **)(iVar4 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f4bbea;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x80f4bbea:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  *(undefined4 *)(iVar4 + 0x10) = param2;
		  return;
		}
		*/

		}

		// Token: 0x060057B9 RID: 22457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B9")]
		[Address(RVA = "0xA52C", Offset = "0xA52C", VA = "0xA52C")]
		public void SetEmailAndPassword(string email, string password)
		{
		/* --- GHIDRA: SetEmailAndPassword ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__SetEmailAndPassword
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a5893d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		    DAT_ram_00a5893d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  if (param1_00 == 0) {
		    param1_00 = unnamed_function_1417(Gameplay_AccountLinker_Control_NebogameSiteHelper_TypeInfo);
		    *(int *)(param1 + 0x1c) = param1_00;
		  }
		  Gameplay_AccountLinker_Control_NebogameSiteHelper__RequestSetEmailAndPass(param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060057BA RID: 22458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057BA")]
		[Address(RVA = "0xA52D", Offset = "0xA52D", VA = "0xA52D")]
		public void InvokeOAuth(Provider provider)
		{
		/* --- GHIDRA: InvokeOAuth ---
		undefined4
		Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__InvokeOAuth
		          (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  int *piVar5;
		  int iVar6;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58946 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_RefAccountInfo__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_RefAccountInfo__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_RefAccountInfo__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_RefAccountInfo__GetEnumerator__);
		    DAT_ram_00a58946 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar2 = *(int *)(param2 + 0xc);
		  if (0 < *(int *)(param2 + 0xc)) {
		    do {
		      iVar6 = *(int *)(param2 + (iVar2 + -1) * 4 + 0x10);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_20,*(undefined4 *)(*(int *)(iVar3 + 8) + 0x50),
		                 Method_System_Collections_Generic_List_RefAccountInfo__GetEnumerator__);
		      local_8 = local_18;
		      local_10 = CONCAT44(puStack_1c,local_20);
		      local_20 = 0;
		      puStack_1c = &local_10;
		      while( true ) {
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                           Method_System_Collections_Generic_List_Enumerator_RefAccountInfo__MoveNext__
		                          );
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) break;
		        if (iVar4 == 0) goto code_r0x80f4beec;
		        if (*(int *)(local_8._4_4_ + 0xc) == iVar6) {
		          DAT_ram_009d3e38 = 0;
		          return local_8._4_4_;
		        }
		      }
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		      iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar3 != iVar6) {
		code_r0x80f4beaf:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1da,&local_20);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		          import::env::__resumeException(param1_00);
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
		      piVar5 = (int *)import::env::__cxa_begin_catch(param1_00);
		      iVar6 = *piVar5;
		      DAT_ram_009d3e38 = 0;
		      local_20 = iVar6;
		      import::env::invoke_v(0x123);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_2();
		        goto code_r0x80f4beaf;
		      }
		      if (iVar6 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80f4beec:
		      DAT_ram_009d3e38 = 0;
		      bVar1 = 1 < iVar2;
		      iVar2 = iVar2 + -1;
		    } while (bVar1);
		  }
		  return 0;
		}
		*/

		}

		// Token: 0x060057BB RID: 22459 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60057BB")]
		[Address(RVA = "0xA52E", Offset = "0xA52E", VA = "0xA52E")]
		public RefAccountInfo GetAnyUserLinkedProvider(params Provider[] providers)
		{
			return null;
		}

		// Token: 0x04002F82 RID: 12162
		[Token(Token = "0x4002F82")]
		[FieldOffset(Offset = "0x18")]
		public readonly AccountLinker AccountLinker;

		// Token: 0x04002F83 RID: 12163
		[Token(Token = "0x4002F83")]
		[FieldOffset(Offset = "0x1C")]
		private NebogameSiteHelper _siteHelper;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SiteHelper ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__get_SiteHelper
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a5893e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSigninTargetProviderStartedEvent__
		              );
		    DAT_ram_00a5893e = '\x01';
		  }
		  iVar2 = **(int **)(param1 + 0x18);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                    (*(int **)(param1 + 0x18),*(undefined4 *)(iVar2 + 0x114));
		  param1_02 = *(undefined4 *)(iVar1 + 0x20);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_HandleSigninTargetProviderStartedEvent__
		             ,0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x20) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_01) ||
		          (*(int **)(iVar1 + 0x20) = param1_01, *param1_01 != iVar2)) {
		    System_Activator__CreateInstance(param1_01,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  return;
		}
		*/

}
