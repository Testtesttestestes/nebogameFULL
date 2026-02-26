using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Aprs.Events;
using Gameplay.Aprs.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Gameplay.Aprs.Controller
{
	// Token: 0x02000D72 RID: 3442
	[Token(Token = "0x2000D72")]
	public class AprsController : AbstractController<AprsModel, AprsEvents>
	{
		// Token: 0x06005455 RID: 21589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005455")]
		[Address(RVA = "0xA20B", Offset = "0xA20B", VA = "0xA20B", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Aprs_Controller_AprsController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5945f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_AprsModel__AprsEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_long___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5945f = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_long__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_long___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_AprsModel__AprsEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06005456 RID: 21590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005456")]
		[Address(RVA = "0xA20C", Offset = "0xA20C", VA = "0xA20C")]
		public AprsController(AprsModel model, AprsEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Aprs_Controller_AprsController___ctor(int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined8 uVar6;
		  longlong param2_00;
		  int iVar7;
		  int *piVar8;
		  uint uVar9;
		  undefined4 uVar10;
		  
		  if (DAT_ram_00a59460 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MedalInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_CultDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprsController_HandleDictProviderChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_Controller_AprsController_MedalAddedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_Controller_AprsController_MedalBuyEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprsController_MedalRemovedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprsController_UserCacheResultCallback__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprsController_UserOnOnUserCultChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprsController_UserOnOnUserGenderChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Cache_CacheResultCallback_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_ICache_ulong__UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_long__Add__);
		    Mono_Security_ASN1__get_Item(&ulong___TypeInfo);
		    DAT_ram_00a59460 = '\x01';
		  }
		  uVar6 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar6);
		  iVar7 = *(int *)(iVar1 + 8);
		  uVar6 = CONCAT44((int)((ulonglong)uVar6 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar6);
		  uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  if (iVar7 == *(int *)(iVar1 + 0x14)) {
		    uVar6 = CONCAT44(uVar5,*(undefined4 *)(*param1 + 0x104));
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar6);
		    iVar7 = *param1;
		    uVar6 = CONCAT44((int)((ulonglong)uVar6 >> 0x20),*(undefined4 *)(iVar7 + 0x104));
		    iVar1 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))(param1,uVar6);
		    uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    Gameplay_Aprs_Model_AprsModel__TryGetAprDataByAprId
		              (uVar4,*(undefined4 *)(*(int *)(iVar1 + 8) + 0x40),iVar7);
		    if (*(char *)((int)param1 + 9) == '\0') {
		      *(undefined1 *)((int)param1 + 9) = 1;
		      uVar6 = CONCAT44(uVar5,*(undefined4 *)(*param1 + 0x114));
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar6);
		      uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		      iVar1 = *(int *)(iVar1 + 8);
		      if (iVar1 != 0) {
		        uVar6 = CONCAT44(uVar5,*(undefined4 *)(iVar1 + 0x14));
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))(*(undefined4 *)(iVar1 + 0x20),uVar6);
		        uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		      }
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar1 = *piVar8;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8 + 4) * 8 + iVar1 + 0x130);
		          goto code_r0x81007d34;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar9);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x81007d34:
		    uVar6 = CONCAT44(uVar5,puVar3[1]);
		    iVar1 = (**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar6);
		    uVar4 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    iVar7 = *(int *)(iVar1 + 0x18);
		    uVar10 = *(undefined4 *)(iVar7 + 0x18);
		    uVar5 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar5,param1,Method_Gameplay_Aprs_Controller_AprsController_MedalRemovedEvent__,0)
		    ;
		    iVar1 = UnityEngine_UI_Image__set_sprite(uVar10,uVar5,0);
		    uVar5 = System_Action_uint__TypeInfo;
		    if (iVar1 == 0) {
		      *(undefined4 *)(iVar7 + 0x18) = 0;
		    }
		    else {
		      iVar2 = func_ii_1082(iVar1,System_Action_uint__TypeInfo);
		      if (iVar2 == 0) {
		        System_Activator__CreateInstance(iVar1,uVar5);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar7 + 0x18) = iVar2;
		      uVar5 = System_Action_uint__TypeInfo;
		      iVar7 = func_ii_1082(iVar1,System_Action_uint__TypeInfo);
		      if (iVar7 == 0) {
		        System_Activator__CreateInstance(iVar1,uVar5);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar1 = *piVar8;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8 + 4) * 8 + iVar1 + 0x130);
		          goto code_r0x81007e4e;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar9);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x81007e4e:
		    uVar6 = CONCAT44(uVar4,puVar3[1]);
		    iVar1 = (**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar6);
		    uVar4 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    iVar7 = *(int *)(iVar1 + 0x18);
		    uVar10 = *(undefined4 *)(iVar7 + 0x1c);
		    uVar5 = unnamed_function_1417(System_Action_MedalInfo__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar5,param1,Method_Gameplay_Aprs_Controller_AprsController_MedalAddedEvent__,0);
		    iVar1 = UnityEngine_UI_Image__set_sprite(uVar10,uVar5,0);
		    uVar5 = System_Action_MedalInfo__TypeInfo;
		    if (iVar1 == 0) {
		      *(undefined4 *)(iVar7 + 0x1c) = 0;
		    }
		    else {
		      iVar2 = func_ii_1082(iVar1,System_Action_MedalInfo__TypeInfo);
		      if (iVar2 == 0) {
		        System_Activator__CreateInstance(iVar1,uVar5);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar7 + 0x1c) = iVar2;
		      uVar5 = System_Action_MedalInfo__TypeInfo;
		      iVar7 = func_ii_1082(iVar1,System_Action_MedalInfo__TypeInfo);
		      if (iVar7 == 0) {
		        System_Activator__CreateInstance(iVar1,uVar5);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar1 = *piVar8;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8 + 4) * 8 + iVar1 + 0x130);
		          goto code_r0x81007f68;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar9);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x81007f68:
		    uVar6 = CONCAT44(uVar4,puVar3[1]);
		    iVar1 = (**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar6);
		    uVar4 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    iVar7 = *(int *)(iVar1 + 0x18);
		    uVar10 = *(undefined4 *)(iVar7 + 0x20);
		    uVar5 = unnamed_function_1417(System_Action_MedalInfo__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar5,param1,Method_Gameplay_Aprs_Controller_AprsController_MedalBuyEvent__,0);
		    iVar1 = UnityEngine_UI_Image__set_sprite(uVar10,uVar5,0);
		    uVar5 = System_Action_MedalInfo__TypeInfo;
		    if (iVar1 == 0) {
		      *(undefined4 *)(iVar7 + 0x20) = 0;
		    }
		    else {
		      iVar2 = func_ii_1082(iVar1,System_Action_MedalInfo__TypeInfo);
		      if (iVar2 == 0) {
		        System_Activator__CreateInstance(iVar1,uVar5);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar7 + 0x20) = iVar2;
		      uVar5 = System_Action_MedalInfo__TypeInfo;
		      iVar7 = func_ii_1082(iVar1,System_Action_MedalInfo__TypeInfo);
		      if (iVar7 == 0) {
		        System_Activator__CreateInstance(iVar1,uVar5);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    uVar6 = CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar6);
		    uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    piVar8 = *(int **)(iVar1 + 0xc);
		    uVar9 = 0;
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Aprs_Controller_AprsController_HandleDictProviderChangedEvent__,0);
		    iVar1 = *piVar8;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8)) {
		          puVar3 = (uint *)(iVar1 + *(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81008092;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar9);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar8,Core_Dict_IDictProvider_TypeInfo,0);
		code_r0x81008092:
		    uVar6 = CONCAT44(uVar5,uVar4);
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar6,puVar3[1]);
		    uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  }
		  else {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar1 = *piVar8;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8 + 4) * 8 + iVar1 + 0x158);
		          goto code_r0x8100813b;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar9);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x8100813b:
		    uVar6 = CONCAT44(uVar5,puVar3[1]);
		    iVar1 = (**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar6);
		    uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    piVar8 = *(int **)(iVar1 + 0x18);
		    uVar9 = 0;
		    uVar4 = unnamed_function_1417(Core_Cache_CacheResultCallback_UserData__TypeInfo);
		    Cysharp_Threading_Tasks_UniTaskCompletionSource__get_Task
		              (uVar4,param1,Method_Gameplay_Aprs_Controller_AprsController_UserCacheResultCallback__
		               ,0);
		    iVar1 = Mono_Security_ASN1Convert__ToOid(ulong___TypeInfo,1);
		    uVar6 = CONCAT44(uVar5,*(undefined4 *)(*param1 + 0x104));
		    iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar6);
		    uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    uVar6 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(iVar7 + 8),0);
		    *(undefined8 *)(iVar1 + 0x10) = uVar6;
		    iVar7 = *piVar8;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_Cache_ICache_ulong__UserData__TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8 + 4) * 8 + iVar7 + 200);
		          goto code_r0x81008212;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar8,Core_Cache_ICache_ulong__UserData__TypeInfo,1);
		code_r0x81008212:
		    uVar6 = CONCAT44(uVar5,uVar4);
		    param2_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar6,iVar1,puVar3[1]);
		    iVar1 = Method_System_Collections_Generic_List_long__Add__;
		    uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    if (0 < param2_00) {
		      iVar7 = param1[7];
		      *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		      uVar9 = *(uint *)(iVar7 + 0xc);
		      if (uVar9 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		        *(uint *)(iVar7 + 0xc) = uVar9 + 1;
		        *(longlong *)(*(int *)(iVar7 + 8) + uVar9 * 8 + 0x10) = param2_00;
		      }
		      else {
		        System_Collections_Generic_List_ulong___Contains
		                  (iVar7,param2_00,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		        uVar5 = (undefined4)((ulonglong)param2_00 >> 0x20);
		      }
		    }
		  }
		  uVar6 = CONCAT44(uVar5,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar6);
		  uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  uVar10 = *(undefined4 *)(iVar1 + 8);
		  uVar4 = unnamed_function_1417(System_Action_CultDic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Aprs_Controller_AprsController_UserOnOnUserCultChangedEvent__,0);
		  Core_Data_UserData__remove_OnUserAprChangedEvent(uVar10,uVar4,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(uVar5,*(undefined4 *)(*param1 + 0x104)));
		  uVar4 = *(undefined4 *)(iVar1 + 8);
		  uVar5 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar5,param1,
		             Method_Gameplay_Aprs_Controller_AprsController_UserOnOnUserGenderChangedEvent__,0);
		  Core_Data_UserData__remove_OnUserCultChangedEvent(uVar4,uVar5,0);
		  return;
		}
		*/

		}

		// Token: 0x06005457 RID: 21591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005457")]
		[Address(RVA = "0xA20D", Offset = "0xA20D", VA = "0xA20D", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Aprs_Controller_AprsController__HandleRun(int *param1,undefined4 param2)
		
		{
		  undefined8 in_i2q;
		  undefined8 param3;
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  uint *puVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int iVar8;
		  undefined4 uVar9;
		  int *piVar10;
		  uint uVar11;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  uVar7 = (undefined4)((ulonglong)in_i2q >> 0x20);
		  if (DAT_ram_00a59461 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MedalInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_CultDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprsController_HandleDictProviderChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_Controller_AprsController_MedalAddedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_Controller_AprsController_MedalBuyEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprsController_MedalRemovedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprsController_UserOnOnUserCultChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprsController_UserOnOnUserGenderChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Enumerator_long__Dispose__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_long__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_long__get_Current__);
		    Mono_Security_ASN1__get_Item(&Core_Cache_ICache_ulong__UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_long__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_long__GetEnumerator__);
		    DAT_ram_00a59461 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  param3 = CONCAT44(uVar7,Method_System_Collections_Generic_List_long__GetEnumerator__);
		  System_Collections_Generic_List_ulong___ForEach
		            (&local_30,param1[7],Method_System_Collections_Generic_List_long__GetEnumerator__);
		  local_8 = local_20;
		  local_10 = local_28;
		  local_30 = 0;
		  puStack_2c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    uVar7 = (undefined4)((ulonglong)param3 >> 0x20);
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2c8,&local_18,
		                       Method_System_Collections_Generic_List_Enumerator_long__MoveNext__);
		    param3 = local_8;
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810086f6;
		    }
		    if (iVar1 == 0) goto code_r0x8100874c;
		    if (DAT_ram_00a6456f == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&Core_Gameplay_Game_TypeInfo);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810086f6;
		      }
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8);
		        if (Core_Gameplay_IGame_TypeInfo == *piVar10) {
		          puVar2 = (undefined4 *)(piVar10[1] * 8 + iVar8 + 0x158);
		          goto code_r0x810085aa;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar4,
		                        Core_Gameplay_IGame_TypeInfo,0x13);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x810086da:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810086f6;
		    }
		code_r0x810085aa:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar2,piVar4,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810086da;
		    piVar4 = *(int **)(iVar8 + 0x18);
		    iVar8 = *piVar4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8);
		        if (Core_Cache_ICache_ulong__UserData__TypeInfo == *piVar10) {
		          puVar2 = (undefined4 *)(piVar10[1] * 8 + iVar8 + 0xd8);
		          goto code_r0x81008680;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar4,
		                        Core_Cache_ICache_ulong__UserData__TypeInfo,3);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x81008680:
		    DAT_ram_009d3e38 = 0;
		    unnamed_function_184070(*puVar2,piVar4,param3,puVar2[1]);
		    uVar7 = (undefined4)((ulonglong)param3 >> 0x20);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810086f6:
		  iVar8 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar1) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar1 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_30 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x8100874c:
		      DAT_ram_009d3e38 = 0;
		      iVar8 = param1[7];
		      *(undefined4 *)(iVar8 + 0xc) = 0;
		      *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		      iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      iVar1 = *(int *)(iVar8 + 8);
		      iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      if (iVar1 == *(int *)(iVar8 + 0x14)) {
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        uVar11 = 0;
		        piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar8 = *piVar4;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8)) {
		              puVar5 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8 + 4) * 8 + iVar8 +
		                               0x130);
		              goto code_r0x8100886a;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x8100886a:
		        iVar8 = (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		        iVar1 = *(int *)(iVar8 + 0x18);
		        uVar9 = *(undefined4 *)(iVar1 + 0x18);
		        uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		        func_ii_12322(uVar3,param1,
		                      Method_Gameplay_Aprs_Controller_AprsController_MedalRemovedEvent__,0);
		        iVar8 = func_ii_7048(uVar9,uVar3,0);
		        uVar3 = System_Action_uint__TypeInfo;
		        if (iVar8 == 0) {
		          *(undefined4 *)(iVar1 + 0x18) = 0;
		        }
		        else {
		          iVar6 = func_ii_1082(iVar8,System_Action_uint__TypeInfo);
		          if (iVar6 == 0) {
		            System_Activator__CreateInstance(iVar8,uVar3);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          *(int *)(iVar1 + 0x18) = iVar6;
		          uVar3 = System_Action_uint__TypeInfo;
		          iVar1 = func_ii_1082(iVar8,System_Action_uint__TypeInfo);
		          if (iVar1 == 0) {
		            System_Activator__CreateInstance(iVar8,uVar3);
		            do {
		              halt_trap();
		            } while( true );
		          }
		        }
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar8 = *piVar4;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar11 = 0;
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8)) {
		              puVar5 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8 + 4) * 8 + iVar8 +
		                               0x130);
		              goto code_r0x81008984;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x81008984:
		        iVar8 = (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		        iVar1 = *(int *)(iVar8 + 0x18);
		        uVar9 = *(undefined4 *)(iVar1 + 0x1c);
		        uVar3 = unnamed_function_1417(System_Action_MedalInfo__TypeInfo);
		        UnityEngine_UIElements_VisualElement__get_layout
		                  (uVar3,param1,Method_Gameplay_Aprs_Controller_AprsController_MedalAddedEvent__,0);
		        iVar8 = func_ii_7048(uVar9,uVar3,0);
		        uVar3 = System_Action_MedalInfo__TypeInfo;
		        if (iVar8 == 0) {
		          *(undefined4 *)(iVar1 + 0x1c) = 0;
		        }
		        else {
		          iVar6 = func_ii_1082(iVar8,System_Action_MedalInfo__TypeInfo);
		          if (iVar6 == 0) {
		            System_Activator__CreateInstance(iVar8,uVar3);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          *(int *)(iVar1 + 0x1c) = iVar6;
		          uVar3 = System_Action_MedalInfo__TypeInfo;
		          iVar1 = func_ii_1082(iVar8,System_Action_MedalInfo__TypeInfo);
		          if (iVar1 == 0) {
		            System_Activator__CreateInstance(iVar8,uVar3);
		            do {
		              halt_trap();
		            } while( true );
		          }
		        }
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar8 = *piVar4;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar11 = 0;
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8)) {
		              puVar5 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8 + 4) * 8 + iVar8 +
		                               0x130);
		              goto code_r0x81008a9e;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x81008a9e:
		        iVar8 = (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		        iVar1 = *(int *)(iVar8 + 0x18);
		        uVar9 = *(undefined4 *)(iVar1 + 0x20);
		        uVar3 = unnamed_function_1417(System_Action_MedalInfo__TypeInfo);
		        UnityEngine_UIElements_VisualElement__get_layout
		                  (uVar3,param1,Method_Gameplay_Aprs_Controller_AprsController_MedalBuyEvent__,0);
		        iVar8 = func_ii_7048(uVar9,uVar3,0);
		        uVar3 = System_Action_MedalInfo__TypeInfo;
		        if (iVar8 == 0) {
		          *(undefined4 *)(iVar1 + 0x20) = 0;
		        }
		        else {
		          iVar6 = func_ii_1082(iVar8,System_Action_MedalInfo__TypeInfo);
		          if (iVar6 == 0) {
		            System_Activator__CreateInstance(iVar8,uVar3);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          *(int *)(iVar1 + 0x20) = iVar6;
		          uVar3 = System_Action_MedalInfo__TypeInfo;
		          iVar1 = func_ii_1082(iVar8,System_Action_MedalInfo__TypeInfo);
		          if (iVar1 == 0) {
		            System_Activator__CreateInstance(iVar8,uVar3);
		            do {
		              halt_trap();
		            } while( true );
		          }
		        }
		        iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        piVar4 = *(int **)(iVar8 + 0xc);
		        uVar11 = 0;
		        uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		        UnityEngine_Events_UnityEvent__AddListener
		                  (uVar3,param1,
		                   Method_Gameplay_Aprs_Controller_AprsController_HandleDictProviderChangedEvent__,0
		                  );
		        iVar8 = *piVar4;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8)) {
		              puVar5 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8 + 4) * 8 + iVar8 + 200)
		              ;
		              goto code_r0x81008bc8;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar4,Core_Dict_IDictProvider_TypeInfo,1);
		code_r0x81008bc8:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar4,uVar3,CONCAT44(uVar7,puVar5[1]));
		      }
		      iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar3 = *(undefined4 *)(iVar8 + 8);
		      uVar7 = unnamed_function_1417(System_Action_CultDic__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar7,param1,
		                 Method_Gameplay_Aprs_Controller_AprsController_UserOnOnUserCultChangedEvent__,0);
		      Core_Data_UserData__add_OnUserCultChangedEvent(uVar3,uVar7,0);
		      iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar3 = *(undefined4 *)(iVar8 + 8);
		      uVar7 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar7,param1,
		                 Method_Gameplay_Aprs_Controller_AprsController_UserOnOnUserGenderChangedEvent__,0);
		      Core_Data_UserData__add_OnUserGenderChangedEvent(uVar3,uVar7,0);
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2c9,&local_30);
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
		*/

		}

		// Token: 0x06005458 RID: 21592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005458")]
		[Address(RVA = "0xA20E", Offset = "0xA20E", VA = "0xA20E", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Aprs_Controller_AprsController__HandleStop(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  undefined1 auStack_20 [8];
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59462 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__AprData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__AprData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__AprData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__AprData__GetEnumerator__
		              );
		    DAT_ram_00a59462 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(iVar1 + 0x1c),
		                     Method_System_Collections_Generic_Dictionary_uint__AprData__get_Values__);
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__AprData__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__AprData__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81008e6f;
		    }
		    if (iVar3 == 0) goto code_r0x81008ec5;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    iVar3 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2ca,uVar2,
		               *(undefined4 *)(iVar3 + 0xc),auStack_20);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81008e6f:
		      iVar1 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar3) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar3 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar3 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x81008ec5:
		          DAT_ram_009d3e38 = 0;
		          iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x114));
		          iVar1 = *(int *)(iVar1 + 0x1c);
		          if (iVar1 != 0) {
		            (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                      (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		          }
		          return;
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2cb,&local_18);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
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
		  }
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x81008e6f;
		}
		*/

		}

		// Token: 0x06005459 RID: 21593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005459")]
		[Address(RVA = "0xA20F", Offset = "0xA20F", VA = "0xA20F")]
		private void HandleDictProviderChangedEvent()
		{
		/* --- GHIDRA: HandleDictProviderChangedEvent ---
		void Gameplay_Aprs_Controller_AprsController__HandleDictProviderChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  undefined1 auStack_20 [8];
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59463 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__AprData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__AprData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__AprData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__AprData__GetEnumerator__
		              );
		    DAT_ram_00a59463 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(iVar1 + 0x1c),
		                     Method_System_Collections_Generic_Dictionary_uint__AprData__get_Values__);
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__AprData__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__AprData__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810090e7;
		    }
		    iVar1 = local_18;
		    if (iVar3 == 0) goto code_r0x81009130;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    iVar3 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2cc,uVar2,
		               *(undefined4 *)(iVar3 + 0xc),auStack_20);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810090e7:
		      iVar1 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar3) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar1 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar1;
		        import::env::invoke_v(0x123);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 != 1) {
		code_r0x81009130:
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 0) {
		            iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x114));
		            iVar1 = *(int *)(iVar1 + 0x18);
		            if (iVar1 != 0) {
		              (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                        (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		            }
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2cd,&local_18);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
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
		  }
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x810090e7;
		}
		*/

		}

		// Token: 0x0600545A RID: 21594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600545A")]
		[Address(RVA = "0xA210", Offset = "0xA210", VA = "0xA210")]
		private void UserOnOnUserGenderChangedEvent()
		{
		/* --- GHIDRA: UserOnOnUserGenderChangedEvent ---
		void Gameplay_Aprs_Controller_AprsController__UserOnOnUserGenderChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  undefined1 auStack_20 [8];
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59464 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__AprData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__AprData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__AprData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__AprData__GetEnumerator__
		              );
		    DAT_ram_00a59464 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(iVar1 + 0x1c),
		                     Method_System_Collections_Generic_Dictionary_uint__AprData__get_Values__);
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__AprData__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__AprData__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81009365;
		    }
		    iVar1 = local_18;
		    if (iVar3 == 0) goto code_r0x810093ae;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    iVar3 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2cc,uVar2,
		               *(undefined4 *)(iVar3 + 0xc),auStack_20);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81009365:
		      iVar1 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar3) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar1 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar1;
		        import::env::invoke_v(0x123);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 != 1) {
		code_r0x810093ae:
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 0) {
		            iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x114));
		            iVar1 = *(int *)(iVar1 + 0x18);
		            if (iVar1 != 0) {
		              (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                        (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		            }
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2ce,&local_18);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
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
		  }
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x81009365;
		}
		*/

		}

		// Token: 0x0600545B RID: 21595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600545B")]
		[Address(RVA = "0xA211", Offset = "0xA211", VA = "0xA211")]
		private void UserOnOnUserCultChangedEvent(CultDic obj)
		{
		/* --- GHIDRA: UserOnOnUserCultChangedEvent ---
		void Gameplay_Aprs_Controller_AprsController__UserOnOnUserCultChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a59465 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprsController_HandleApplyAprService__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a59465 = '\x01';
		  }
		  param1_00 = ServicesNamespace_ServicesService__BuyMedal(*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,Method_Gameplay_Aprs_Controller_AprsController_HandleApplyAprService__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x0600545C RID: 21596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600545C")]
		[Address(RVA = "0xA212", Offset = "0xA212", VA = "0xA212")]
		public void ApplyApr(uint medalId)
		{
		/* --- GHIDRA: ApplyApr ---
		void Gameplay_Aprs_Controller_AprsController__ApplyApr(int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  undefined4 uVar5;
		  int *param1_01;
		  
		  if (DAT_ram_00a59466 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoApplyMedalAprAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2580);
		    DAT_ram_00a59466 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Services_ProtoApplyMedalAprAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Services_ProtoApplyMedalAprAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (param1_00[4] < 0) {
		    if (param1_00[4] == -1) {
		      uVar5 = System_Uri___ctor(0);
		      uVar5 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar5,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2580,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar5,2,uVar4,0);
		      return;
		    }
		  }
		  else {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
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
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		          goto code_r0x810095c3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x810095c3:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		    uVar4 = func_ii_7730(*(undefined4 *)(*(int *)(iVar2 + 0x24) + 0x14),param1_00[3],
		                         Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		                        );
		    Core_Data_UserData__get_Apr(uVar5,uVar4,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600545D RID: 21597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600545D")]
		[Address(RVA = "0xA213", Offset = "0xA213", VA = "0xA213")]
		private void HandleApplyAprService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleApplyAprService ---
		void Gameplay_Aprs_Controller_AprsController__HandleApplyAprService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param4;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a59467 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AprsScope_AprsEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprData__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprData__get_Item__);
		    DAT_ram_00a59467 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                    (*(undefined4 *)(iVar1 + 0x1c),*(undefined4 *)(param2 + 0xc),
		                     Method_System_Collections_Generic_Dictionary_uint__AprData__ContainsKey__);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param4 = System_Collections_Generic_List_object___get_Item
		                       (*(undefined4 *)(iVar1 + 0x1c),*(undefined4 *)(param2 + 0xc),
		                        Method_System_Collections_Generic_Dictionary_uint__AprData__get_Item__);
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x54) + 8);
		    if (iVar1 != 0) {
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      param1_00 = unnamed_function_1417(Core_Events_Scopes_AprsScope_AprsEventArgs_TypeInfo);
		      Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData
		                (param1_00,param2_00,param3_00,param4,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600545E RID: 21598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600545E")]
		[Address(RVA = "0xA214", Offset = "0xA214", VA = "0xA214")]
		private void MedalBuyEvent(MedalInfo medalInfo)
		{
		/* --- GHIDRA: MedalBuyEvent ---
		void Gameplay_Aprs_Controller_AprsController__MedalBuyEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59468 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AprsScope_AprsEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprData__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11295);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27734);
		    DAT_ram_00a59468 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                    (*(undefined4 *)(iVar1 + 0x1c),*(undefined4 *)(param2 + 0xc),
		                     Method_System_Collections_Generic_Dictionary_uint__AprData__ContainsKey__);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar2 = System_Collections_Generic_List_object___get_Item
		                      (*(undefined4 *)(iVar1 + 0x1c),*(undefined4 *)(param2 + 0xc),
		                       Method_System_Collections_Generic_Dictionary_uint__AprData__get_Item__);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    func_ii_7746(uVar2,param2,*(undefined4 *)(iVar1 + 0xc),param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = System_Collections_Generic_List_object___get_Item
		                      (*(undefined4 *)(iVar1 + 0x1c),*(undefined4 *)(param2 + 0xc),
		                       Method_System_Collections_Generic_Dictionary_uint__AprData__get_Item__);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x14);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),iVar1,*(undefined4 *)(param2 + 0xc),
		                 *(undefined4 *)(iVar3 + 0x14));
		    }
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_11295,1,0,1,0,0,0,0);
		    uVar4 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar4,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    if (DAT_ram_00a5942a == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__)
		      ;
		      DAT_ram_00a5942a = '\x01';
		    }
		    uVar5 = func_ii_14054(*(undefined4 *)(*(int *)(iVar1 + 0x14) + 0x10),0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar4,StringLiteral_27734,uVar5,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    uVar2 = Core_GameLocalization__GetTranslation(uVar2,uVar4,0);
		    uVar4 = System_Uri___ctor(0);
		    uVar4 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar4,0);
		    uVar2 = UI_Toast_ToastController_ToastData__Create(0xb,uVar2,*(undefined4 *)(iVar1 + 0x1c),0);
		    UI_Toast_ToastController__OnReleaseToast(uVar4,uVar2,0);
		    iVar3 = System_Uri___ctor(0);
		    iVar3 = *(int *)(*(int *)(*(int *)(*(int *)(iVar3 + 0x38) + 0x10) + 0x54) + 0xc);
		    if (iVar3 != 0) {
		      uVar2 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      uVar5 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      uVar4 = unnamed_function_1417(Core_Events_Scopes_AprsScope_AprsEventArgs_TypeInfo);
		      Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(uVar4,uVar2,uVar5,iVar1,0);
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),uVar4,*(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600545F RID: 21599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600545F")]
		[Address(RVA = "0xA215", Offset = "0xA215", VA = "0xA215")]
		private void MedalAddedEvent(MedalInfo medalInfo)
		{
		/* --- GHIDRA: MedalAddedEvent ---
		void Gameplay_Aprs_Controller_AprsController__MedalAddedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a59469 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprData__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprData__get_Item__);
		    DAT_ram_00a59469 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                    (*(undefined4 *)(iVar1 + 0x1c),param2,
		                     Method_System_Collections_Generic_Dictionary_uint__AprData__ContainsKey__);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar2 = System_Collections_Generic_List_object___get_Item
		                      (*(undefined4 *)(iVar1 + 0x1c),param2,
		                       Method_System_Collections_Generic_Dictionary_uint__AprData__get_Item__);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Aprs_Model_AprData__GetCurrentMedal(uVar2,param2,*(undefined4 *)(iVar1 + 0xc),param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x14);
		    if (iVar1 != 0) {
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar2 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(iVar3 + 0x1c),param2,
		                         Method_System_Collections_Generic_Dictionary_uint__AprData__get_Item__);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),uVar2,param2,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005460 RID: 21600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005460")]
		[Address(RVA = "0xA216", Offset = "0xA216", VA = "0xA216")]
		private void MedalRemovedEvent(uint medalId)
		{
		/* --- GHIDRA: MedalRemovedEvent ---
		void Gameplay_Aprs_Controller_AprsController__MedalRemovedEvent
		               (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined8 uVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5946a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_UserData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_long__Remove__);
		    DAT_ram_00a5946a = '\x01';
		  }
		  System_Collections_Generic_List_long___IsCompatibleObject
		            (param1[7],param2,Method_System_Collections_Generic_List_long__Remove__);
		  uVar1 = CONCAT44((int)((ulonglong)param2 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar3 = System_Linq_Enumerable__Count_object_
		                    (param3,Method_System_Linq_Enumerable_First_UserData___);
		  Gameplay_Aprs_Model_AprsModel__TryGetAprDataByAprId
		            (param1_00,*(undefined4 *)(iVar3 + 0x40),param1);
		  if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x114)));
		    iVar3 = *(int *)(iVar3 + 8);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005461 RID: 21601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005461")]
		[Address(RVA = "0xA217", Offset = "0xA217", VA = "0xA217")]
		private void UserCacheResultCallback(long operationIndex, params UserData[] data)
		{
		}

		// Token: 0x06005462 RID: 21602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005462")]
		[Address(RVA = "0xA218", Offset = "0xA218", VA = "0xA218")]
		private void ValidateInit()
		{
		/* --- GHIDRA: ValidateInit ---
		void Gameplay_Aprs_Controller_AprsController__ValidateInit
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int param1_00;
		  
		  if (DAT_ram_00a5946b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AprsModel__AprsEvents__AprsController__AprsWindow___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Controller_Filters_AprAchievedFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Controller_Filters_AprOtherFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Controller_Filters_AprPriceFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Controller_Filters_AprSkillFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Controller_Filters_AprTitleFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAprFilter__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAprFilter___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAprFilter__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Predicate_AprData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprsViewMediator___c___ctor_b__2_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Controller_AprsViewMediator___c_TypeInfo);
		    DAT_ram_00a5946b = '\x01';
		  }
		  if (*(int *)(Gameplay_Aprs_Controller_AprsViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Aprs_Controller_AprsViewMediator___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Aprs_Controller_AprsViewMediator___c_TypeInfo + 0x5c);
		  param1_00 = puVar3[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_Aprs_Controller_AprsViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Aprs_Controller_AprsViewMediator___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_Aprs_Controller_AprsViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    param1_00 = unnamed_function_1417(System_Predicate_AprData__TypeInfo);
		    func_ii_7297(param1_00,uVar1,
		                 Method_Gameplay_Aprs_Controller_AprsViewMediator___c___ctor_b__2_0__,0);
		    *(int *)(*(int *)(Gameplay_Aprs_Controller_AprsViewMediator___c_TypeInfo + 0x5c) + 4) =
		         param1_00;
		  }
		  *(int *)(param1 + 0x1c) = param1_00;
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_AprsModel__AprsEvents__AprsController__AprsWindow___ctor__
		            );
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAprFilter__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAprFilter___ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar2 = unnamed_function_1417(Gameplay_Aprs_Controller_Filters_AprSkillFilter_TypeInfo);
		  func_ii_10812(uVar1,1,uVar2,
		                Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAprFilter__Add__
		               );
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(Gameplay_Aprs_Controller_Filters_AprPriceFilter_TypeInfo);
		  func_ii_10812(uVar2,3,uVar1,
		                Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAprFilter__Add__
		               );
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(Gameplay_Aprs_Controller_Filters_AprTitleFilter_TypeInfo);
		  func_ii_10812(uVar2,4,uVar1,
		                Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAprFilter__Add__
		               );
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(Gameplay_Aprs_Controller_Filters_AprOtherFilter_TypeInfo);
		  func_ii_10812(uVar2,2,uVar1,
		                Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAprFilter__Add__
		               );
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(Gameplay_Aprs_Controller_Filters_AprAchievedFilter_TypeInfo);
		  func_ii_10812(uVar2,5,uVar1,
		                Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAprFilter__Add__
		               );
		  return;
		}
		*/

		}

		// Token: 0x04002DAB RID: 11691
		[Token(Token = "0x4002DAB")]
		[FieldOffset(Offset = "0x18")]
		private ServicesService _servicesService;

		// Token: 0x04002DAC RID: 11692
		[Token(Token = "0x4002DAC")]
		[FieldOffset(Offset = "0x1C")]
		private List<long> _cacheOperationIndexes;
	}
}
