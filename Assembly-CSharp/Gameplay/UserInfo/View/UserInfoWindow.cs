using System;
using System.Collections.Generic;
using Core.Data;
using Core.MVC.Interfaces;
using Gameplay.UserInfo.Control;
using Gameplay.UserInfo.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x02000405 RID: 1029
	[Token(Token = "0x2000405")]
	public class UserInfoWindow : ClosableBaseWindow<UserInfoWindow.UserInfoWindowArgs>
	{
		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001834 RID: 6196 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000448")]
		public override string WindowId
		{
			[Token(Token = "0x6001834")]
			[Address(RVA = "0x69E8", Offset = "0x69E8", VA = "0x69E8", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001835")]
		[Address(RVA = "0x69E9", Offset = "0x69E9", VA = "0x69E9", Slot = "22")]
		protected override void OnShow(UserInfoWindow.UserInfoWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_UserInfo_View_UserInfoWindow__OnShow(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  undefined4 param1_00;
		  int iVar6;
		  int *piVar7;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a598f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_UserInfoWindow_UserInfoWindowArgs__OnClose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IViewMediator__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IViewMediator__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IViewMediator__get_Current__);
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IViewMediator__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IViewMediator__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_View_UserInfoWindow_HandleUserViewOnReadyEvent__);
		    DAT_ram_00a598f8 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar5 = *(int *)(param1 + 0x40);
		  param1_00 = *(undefined4 *)(iVar5 + 8);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Gameplay_UserInfo_View_UserInfoWindow_HandleUserViewOnReadyEvent__,
		             0);
		  piVar3 = (int *)func_ii_7048(param1_00,uVar2,0);
		  iVar6 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar3) || (*(int **)(iVar5 + 8) = piVar3, *piVar3 != iVar6))
		  {
		    System_Activator__CreateInstance(piVar3,iVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x44),0);
		  iVar6 = **(int **)(param1 + 0x44);
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0xe8) * 4))
		            (*(int **)(param1 + 0x44),*(undefined4 *)(iVar6 + 0xec));
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x4c),
		             Method_System_Collections_Generic_List_IViewMediator__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_IViewMediator__MoveNext__);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8108bce1;
		    }
		    if (iVar5 == 0) goto code_r0x8108bd37;
		    piVar3 = local_8._4_4_;
		    iVar6 = *local_8._4_4_;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x8108bc84;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8._4_4_,
		                        Core_MVC_Interfaces_IViewMediator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x8108bc84:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(*puVar4,piVar3,puVar4[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8108bce1:
		  iVar6 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar5) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar5 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar5;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar5 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x8108bd37:
		      DAT_ram_009d3e38 = 0;
		      iVar6 = **(int **)(param1 + 0x48);
		      (**(code **)((ulonglong)*(uint *)(iVar6 + 0xe8) * 4))
		                (*(int **)(param1 + 0x48),*(undefined4 *)(iVar6 + 0xec));
		      iVar6 = *(int *)(param1 + 0x4c);
		      iVar5 = *(int *)(iVar6 + 0xc);
		      *(undefined4 *)(iVar6 + 0xc) = 0;
		      *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		      if (0 < iVar5) {
		        func_ii_2064(*(undefined4 *)(iVar6 + 8),0,iVar5,0);
		      }
		      *(undefined4 *)(param1 + 0x48) = 0;
		      *(undefined8 *)(param1 + 0x40) = 0;
		      UI_Windows_ClosableBaseWindow_object___OnClickBack
		                (param1,
		                 Method_UI_Windows_ClosableBaseWindow_UserInfoWindow_UserInfoWindowArgs__OnClose__);
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x36,&local_18);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001836 RID: 6198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001836")]
		[Address(RVA = "0x69EA", Offset = "0x69EA", VA = "0x69EA", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001837")]
		[Address(RVA = "0x69EB", Offset = "0x69EB", VA = "0x69EB")]
		private void HandleUserViewOnReadyEvent()
		{
		/* --- GHIDRA: HandleUserViewOnReadyEvent ---
		void Gameplay_UserInfo_View_UserInfoWindow__HandleUserViewOnReadyEvent(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a598f9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_UserInfoWindow_UserInfoWindowArgs__get_WindowArgs__);
		    DAT_ram_00a598f9 = '\x01';
		  }
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_UserInfoWindow_UserInfoWindowArgs__get_WindowArgs__
		                      );
		  if (*(int *)(iVar1 + 0x1c) == 1) {
		    UnityEngine_Events_UnityEvent__GetDelegate
		              (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x3c) + 0x38) + 0xb4),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001838")]
		[Address(RVA = "0x69EC", Offset = "0x69EC", VA = "0x69EC")]
		private void ShowDependentView()
		{
		/* --- GHIDRA: ShowDependentView ---
		void Gameplay_UserInfo_View_UserInfoWindow__ShowDependentView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int iVar7;
		  undefined4 uVar8;
		  uint uVar9;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a598fa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IViewMediator__Add__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInfo_Control_UserEquipmentViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInfo_Control_UserInfoController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInfo_UserInfoEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInfo_Model_UserInfoModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInfo_Control_UserInfoViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_View_UserInfoWindow_HandleUserViewOnReadyEvent__);
		    DAT_ram_00a598fa = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Gameplay_UserInfo_UserInfoEvents_TypeInfo);
		  *(int *)(param1 + 0x40) = iVar1;
		  uVar6 = *(undefined4 *)(iVar1 + 8);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Gameplay_UserInfo_View_UserInfoWindow_HandleUserViewOnReadyEvent__,
		             0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		  iVar7 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar3) || (*(int **)(iVar1 + 8) = piVar3, *piVar3 != iVar7))
		  {
		    System_Activator__CreateInstance(piVar3,iVar7);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar3;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x8108b1a3;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8108b1a3:
		  uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar3;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x8108b24f;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8108b24f:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		  uVar6 = *(undefined4 *)(iVar7 + 0x14);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar8 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  uVar5 = unnamed_function_1417(Gameplay_UserInfo_Model_UserInfoModel_TypeInfo);
		  Gameplay_UserInfo_Model_UserInfoModel__Dispose(uVar5,uVar2,param2,uVar6,uVar8,uVar6);
		  *(undefined4 *)(param1 + 0x48) = uVar5;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  uVar6 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  uVar5 = *(undefined4 *)(param1 + 0x40);
		  uVar8 = *(undefined4 *)(param1 + 0x48);
		  iVar7 = unnamed_function_1417(Gameplay_UserInfo_Control_UserInfoController_TypeInfo);
		  if (DAT_ram_00a59916 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_UserInfoModel__UserInfoEvents___ctor__);
		    DAT_ram_00a59916 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (iVar7,uVar8,uVar5,Method_MVC_AbstractController_UserInfoModel__UserInfoEvents___ctor__)
		  ;
		  *(undefined4 *)(iVar7 + 0x1c) = uVar6;
		  *(undefined4 *)(iVar7 + 0x18) = uVar2;
		  *(int *)(param1 + 0x44) = iVar7;
		  iVar1 = *(int *)(param1 + 0x4c);
		  uVar6 = *(undefined4 *)(param1 + 0x3c);
		  uVar5 = *(undefined4 *)(param1 + 0x48);
		  uVar8 = *(undefined4 *)(param1 + 0x40);
		  uVar2 = unnamed_function_1417(Gameplay_UserInfo_Control_UserInfoViewMediator_TypeInfo);
		  if (DAT_ram_00a59937 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView___ctor__
		              );
		    DAT_ram_00a59937 = '\x01';
		  }
		  MVC_AbstractCozyViewMediator_object__object__object__object____ctor
		            (uVar2,uVar6,uVar5,uVar8,iVar7,
		             Method_MVC_AbstractCozyViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView___ctor__
		            );
		  iVar7 = Method_System_Collections_Generic_List_IViewMediator__Add__;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  uVar9 = *(uint *)(iVar1 + 0xc);
		  if (uVar9 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		    *(uint *)(iVar1 + 0xc) = uVar9 + 1;
		    *(undefined4 *)(*(int *)(iVar1 + 8) + uVar9 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar1,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		  }
		  uVar6 = *(undefined4 *)(param1 + 0x44);
		  uVar5 = *(undefined4 *)(param1 + 0x40);
		  uVar8 = *(undefined4 *)(param1 + 0x48);
		  iVar7 = *(int *)(param1 + 0x4c);
		  param2_00 = *(undefined4 *)(*(int *)(param1 + 0x3c) + 0x20);
		  uVar2 = unnamed_function_1417(Gameplay_UserInfo_Control_UserEquipmentViewMediator_TypeInfo);
		  if (DAT_ram_00a59907 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserEquipmentView___ctor__
		              );
		    DAT_ram_00a59907 = '\x01';
		  }
		  MVC_AbstractCozyViewMediator_object__object__object__object____ctor
		            (uVar2,param2_00,uVar8,uVar5,uVar6,
		             Method_MVC_AbstractCozyViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserEquipmentView___ctor__
		            );
		  iVar1 = Method_System_Collections_Generic_List_IViewMediator__Add__;
		  *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		  uVar9 = *(uint *)(iVar7 + 0xc);
		  if (uVar9 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		    *(uint *)(iVar7 + 0xc) = uVar9 + 1;
		    *(undefined4 *)(*(int *)(iVar7 + 8) + uVar9 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar7,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x44),0);
		  return;
		}
		*/

		}

		// Token: 0x06001839 RID: 6201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001839")]
		[Address(RVA = "0x69ED", Offset = "0x69ED", VA = "0x69ED")]
		private void CreateMVC(UserData user)
		{
		/* --- GHIDRA: CreateMVC ---
		void Gameplay_UserInfo_View_UserInfoWindow__CreateMVC(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a598fb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_UserInfoWindow_UserInfoWindowArgs___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IViewMediator___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IViewMediator__TypeInfo);
		    DAT_ram_00a598fb = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_IViewMediator__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_IViewMediator___ctor__);
		  *(undefined4 *)(param1 + 0x4c) = param1_00;
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_UserInfoWindow_UserInfoWindowArgs___ctor__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x0600183A RID: 6202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600183A")]
		[Address(RVA = "0x69EE", Offset = "0x69EE", VA = "0x69EE")]
		public UserInfoWindow()
		{
		}

		// Token: 0x04000CEC RID: 3308
		[Token(Token = "0x4000CEC")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/UserInfo/UserInfoWindow";

		// Token: 0x04000CED RID: 3309
		[Token(Token = "0x4000CED")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private UserInfoView _userInfoView;

		// Token: 0x04000CEE RID: 3310
		[Token(Token = "0x4000CEE")]
		[FieldOffset(Offset = "0x40")]
		private UserInfoEvents _events;

		// Token: 0x04000CEF RID: 3311
		[Token(Token = "0x4000CEF")]
		[FieldOffset(Offset = "0x44")]
		private UserInfoController _controller;

		// Token: 0x04000CF0 RID: 3312
		[Token(Token = "0x4000CF0")]
		[FieldOffset(Offset = "0x48")]
		private UserInfoModel _model;

		// Token: 0x04000CF1 RID: 3313
		[Token(Token = "0x4000CF1")]
		[FieldOffset(Offset = "0x4C")]
		private readonly List<IViewMediator> _mediators;

		// Token: 0x02000406 RID: 1030
		[Token(Token = "0x2000406")]
		public enum DependentView
		{
			// Token: 0x04000CF3 RID: 3315
			[Token(Token = "0x4000CF3")]
			NOTHING,
			// Token: 0x04000CF4 RID: 3316
			[Token(Token = "0x4000CF4")]
			EDIT_WINDOW
		}

		// Token: 0x02000407 RID: 1031
		[Token(Token = "0x2000407")]
		public class UserInfoWindowArgs : BaseWindowArgs
		{
			// Token: 0x0600183B RID: 6203 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600183B")]
			[Address(RVA = "0x69EF", Offset = "0x69EF", VA = "0x69EF")]
			public UserInfoWindowArgs(UserData user)
			{
			}

			// Token: 0x04000CF5 RID: 3317
			[Token(Token = "0x4000CF5")]
			[FieldOffset(Offset = "0x18")]
			public readonly UserData User;

			// Token: 0x04000CF6 RID: 3318
			[Token(Token = "0x4000CF6")]
			[FieldOffset(Offset = "0x1C")]
			public UserInfoWindow.DependentView Dependent;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_UserInfo_View_UserInfoWindow__get_WindowId
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a598f7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_UserInfoWindow_UserInfoWindowArgs__OnShow__);
		    DAT_ram_00a598f7 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_UserInfoWindow_UserInfoWindowArgs__OnShow__);
		  Gameplay_UserInfo_View_UserInfoWindow__ShowDependentView
		            (param1,*(undefined4 *)(param2 + 0x18),param2);
		  return;
		}
		*/

}
