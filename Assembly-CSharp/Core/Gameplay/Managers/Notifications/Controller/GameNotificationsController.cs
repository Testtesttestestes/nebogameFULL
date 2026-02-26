using System;
using System.Collections.Generic;
using Core.Gameplay.Managers.Notifications.Controller.Schedulers;
using Core.Gameplay.Managers.Notifications.Events;
using Core.Gameplay.Managers.Notifications.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Core.Gameplay.Managers.Notifications.Controller
{
	// Token: 0x020011B2 RID: 4530
	[Token(Token = "0x20011B2")]
	public class GameNotificationsController : AbstractController<GameNotificationsModel, GameNotificationsEvents>
	{
		// Token: 0x06006B99 RID: 27545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B99")]
		[Address(RVA = "0xB693", Offset = "0xB693", VA = "0xB693")]
		public GameNotificationsController(GameNotificationsModel model, GameNotificationsEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Notifications_Controller_GameNotificationsController___ctor
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a689 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractController_GameNotificationsModel__GameNotificationsEvents__Dispose__
		              );
		    DAT_ram_00a5a689 = '\x01';
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,
		             Method_MVC_AbstractController_GameNotificationsModel__GameNotificationsEvents__Dispose__
		            );
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06006B9A RID: 27546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B9A")]
		[Address(RVA = "0xB694", Offset = "0xB694", VA = "0xB694", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Gameplay_Managers_Notifications_Controller_GameNotificationsController__Dispose
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a68a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Controller_GameNotificationsController_HandleGetGroupsService__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a5a68a = '\x01';
		  }
		  uVar1 = ServicesNamespace_NotifierService__get_ServiceId(*(undefined4 *)(param1 + 0x1c),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_Notifications_Controller_GameNotificationsController_HandleGetGroupsService__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06006B9B RID: 27547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B9B")]
		[Address(RVA = "0xB695", Offset = "0xB695", VA = "0xB695", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		/* WARNING: Removing unreachable block (ram,0x81250aef) */
		/* WARNING: Removing unreachable block (ram,0x8125121e) */
		
		void Core_Gameplay_Managers_Notifications_Controller_GameNotificationsController__HandleRun
		               (int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int param2_00;
		  int iVar7;
		  uint uVar8;
		  int *piVar9;
		  int iVar10;
		  int *piVar11;
		  int local_50;
		  undefined8 *local_4c;
		  int local_48;
		  int **local_44;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  int *local_4;
		  
		  if (DAT_ram_00a5a68b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_NotificationGroupData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Notifications_Controller_Schedulers_BuildingUpgradedLocalNotificationScheduler_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Notifications_Controller_Schedulers_CraftLocalNotificationScheduler_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Notifications_Controller_Schedulers_EnergyRegenLocalNotificationScheduler_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_NotificationCategoryData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_NotificationGroupData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AbstractBaseNotificationScheduler__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_NotificationGroupData__MoveNext__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AbstractBaseNotificationScheduler__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_NotificationCategoryData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AbstractBaseNotificationScheduler__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_NotificationCategoryData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_NotificationGroupData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Controller_GameNotificationsController_OnGroupEnabledChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_LocalNotificationScheduleDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractBaseNotificationScheduler__Add__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_AbstractBaseNotificationScheduler__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_NotificationGroupData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_NotificationCategoryData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Notifications_Controller_Schedulers_ManufactureLocalNotificationScheduler_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_LocalNotificationScheduleDic__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Notifications_Controller_Schedulers_RetentionNotificationScheduler_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Notifications_Controller_Schedulers_SpellLeanedLocalNotificationScheduler_TypeInfo
		              );
		    DAT_ram_00a5a68b = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  local_30 = 0;
		  local_38 = 0;
		  iVar7 = param1[6];
		  uVar2 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_Notifications_Controller_Schedulers_EnergyRegenLocalNotificationScheduler_TypeInfo
		                    );
		  iVar10 = Method_System_Collections_Generic_List_AbstractBaseNotificationScheduler__Add__;
		  *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		  uVar8 = *(uint *)(iVar7 + 0xc);
		  if (uVar8 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		    *(uint *)(iVar7 + 0xc) = uVar8 + 1;
		    *(undefined4 *)(*(int *)(iVar7 + 8) + uVar8 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar7,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		  }
		  iVar7 = param1[6];
		  uVar2 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_Notifications_Controller_Schedulers_SpellLeanedLocalNotificationScheduler_TypeInfo
		                    );
		  iVar10 = Method_System_Collections_Generic_List_AbstractBaseNotificationScheduler__Add__;
		  *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		  uVar8 = *(uint *)(iVar7 + 0xc);
		  if (uVar8 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		    *(uint *)(iVar7 + 0xc) = uVar8 + 1;
		    *(undefined4 *)(*(int *)(iVar7 + 8) + uVar8 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar7,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		  }
		  iVar7 = param1[6];
		  uVar2 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_Notifications_Controller_Schedulers_BuildingUpgradedLocalNotificationScheduler_TypeInfo
		                    );
		  iVar10 = Method_System_Collections_Generic_List_AbstractBaseNotificationScheduler__Add__;
		  *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		  uVar8 = *(uint *)(iVar7 + 0xc);
		  if (uVar8 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		    *(uint *)(iVar7 + 0xc) = uVar8 + 1;
		    *(undefined4 *)(*(int *)(iVar7 + 8) + uVar8 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar7,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		  }
		  iVar7 = param1[6];
		  uVar2 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler_TypeInfo
		                    );
		  iVar10 = Method_System_Collections_Generic_List_AbstractBaseNotificationScheduler__Add__;
		  *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		  uVar8 = *(uint *)(iVar7 + 0xc);
		  if (uVar8 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		    *(uint *)(iVar7 + 0xc) = uVar8 + 1;
		    *(undefined4 *)(*(int *)(iVar7 + 8) + uVar8 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar7,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		  }
		  iVar7 = param1[6];
		  uVar2 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_Notifications_Controller_Schedulers_ManufactureLocalNotificationScheduler_TypeInfo
		                    );
		  iVar10 = Method_System_Collections_Generic_List_AbstractBaseNotificationScheduler__Add__;
		  *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		  uVar8 = *(uint *)(iVar7 + 0xc);
		  if (uVar8 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		    *(uint *)(iVar7 + 0xc) = uVar8 + 1;
		    *(undefined4 *)(*(int *)(iVar7 + 8) + uVar8 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar7,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		  }
		  iVar7 = param1[6];
		  uVar2 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_Notifications_Controller_Schedulers_CraftLocalNotificationScheduler_TypeInfo
		                    );
		  iVar10 = Method_System_Collections_Generic_List_AbstractBaseNotificationScheduler__Add__;
		  *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		  uVar8 = *(uint *)(iVar7 + 0xc);
		  if (uVar8 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		    *(uint *)(iVar7 + 0xc) = uVar8 + 1;
		    *(undefined4 *)(*(int *)(iVar7 + 8) + uVar8 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar7,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar8 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar8 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar8 * 8 + 4) * 8 + iVar10 + 0x178);
		        goto code_r0x81250877;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar8);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81250877:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar9,puVar3[1]);
		  iVar10 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(iVar10 + 0x2b8),
		                              Method_Google_Protobuf_Collections_RepeatedField_LocalNotificationScheduleDic__GetEnumerator__
		                             );
		  local_48 = 0;
		  local_44 = &local_4;
		code_r0x812508e3:
		  do {
		    piVar9 = local_4;
		    iVar10 = *local_4;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar8 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		          puVar4 = (undefined4 *)(iVar10 + piVar11[1] * 8 + 0xc0);
		          goto code_r0x81250977;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar8);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81250bab:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81250bb3;
		    }
		code_r0x81250977:
		    DAT_ram_009d3e38 = 0;
		    iVar10 = import::env::invoke_iii(*puVar4,piVar9,puVar4[1]);
		    piVar9 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81250bab;
		    if (iVar10 == 0) goto code_r0x81250bfc;
		    iVar10 = *local_4;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar8 * 8);
		        if (System_Collections_Generic_IEnumerator_LocalNotificationScheduleDic__TypeInfo ==
		            *piVar11) {
		          puVar4 = (undefined4 *)(iVar10 + piVar11[1] * 8 + 0xc0);
		          goto code_r0x81250a54;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar8);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_LocalNotificationScheduleDic__TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81250b97:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81250bb3;
		    }
		code_r0x81250a54:
		    DAT_ram_009d3e38 = 0;
		    iVar10 = import::env::invoke_iii(*puVar4,piVar9,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81250b97;
		    iVar6 = param1[6];
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Core_Gameplay_Managers_Notifications_Controller_Schedulers_RetentionNotificationScheduler_TypeInfo
		                      );
		    if (DAT_ram_009d3e38 == 1) break;
		    *(int *)(iVar7 + 0x10) = iVar10;
		    *(undefined **)(iVar7 + 0x18) = &DAT_ram_000f4240 + *(int *)(iVar10 + 0xc);
		    iVar10 = Method_System_Collections_Generic_List_AbstractBaseNotificationScheduler__Add__;
		    *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar6 + 0xc);
		    if (uVar8 < *(uint *)(*(int *)(iVar6 + 8) + 0xc)) {
		      *(uint *)(iVar6 + 0xc) = uVar8 + 1;
		      *(int *)(*(int *)(iVar6 + 8) + uVar8 * 4 + 0x10) = iVar7;
		      goto code_r0x812508e3;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar6,iVar7,
		               *(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81250bb3:
		  iVar10 = global_1;
		  iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar10 == iVar7) {
		    piVar9 = (int *)import::env::__cxa_begin_catch(uVar2);
		    local_48 = *piVar9;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 != 1) {
		code_r0x81250bfc:
		      DAT_ram_009d3e38 = 0;
		      piVar9 = *local_44;
		      if (piVar9 != (int *)0x0) {
		        uVar8 = 0;
		        iVar10 = *piVar9;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar8 * 8)) {
		              puVar3 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar8 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x81250c77;
		            }
		            uVar8 = uVar8 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar8);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar9,System_IDisposable_TypeInfo,0);
		code_r0x81250c77:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar9,puVar3[1]);
		      }
		      if (local_48 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_48);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_48,param1[6],
		                 Method_System_Collections_Generic_List_AbstractBaseNotificationScheduler__GetEnumerator__
		                );
		      local_10 = local_40;
		      local_18 = CONCAT44(local_44,local_48);
		      local_48 = 0;
		      local_44 = (int **)&local_18;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_18,
		                           Method_System_Collections_Generic_List_Enumerator_AbstractBaseNotificationScheduler__MoveNext__
		                          );
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81250e3b;
		        }
		        if (iVar7 == 0) goto code_r0x81250e91;
		        DAT_ram_009d3e38 = 0;
		        uVar2 = local_10._4_4_;
		        uVar5 = import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 799,0);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81250e3b;
		        }
		        if (DAT_ram_00a6456f == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&Core_Gameplay_Game_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_00a6456f = '\x01';
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x318,uVar2,uVar5,
		                   **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c),
		                   **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c));
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81250e3b:
		      iVar10 = global_1;
		      iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar10 == iVar7) {
		        piVar9 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar7 = *piVar9;
		        DAT_ram_009d3e38 = 0;
		        local_48 = iVar7;
		        import::env::invoke_v(0x123);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 != 1) {
		          if (iVar7 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x81250e91:
		          DAT_ram_009d3e38 = 0;
		          iVar10 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                             (param1,*(undefined4 *)(*param1 + 0x104));
		          System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                    (&local_48,*(undefined4 *)(iVar10 + 0xc),
		                     Method_System_Collections_Generic_List_NotificationCategoryData__GetEnumerator__
		                    );
		          local_20 = local_40;
		          local_28 = CONCAT44(local_44,local_48);
		          local_50 = 0;
		          local_4c = &local_28;
		          do {
		            DAT_ram_009d3e38 = 0;
		            iVar7 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_28,
		                               Method_System_Collections_Generic_List_Enumerator_NotificationCategoryData__MoveNext__
		                              );
		            iVar10 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 == 1) {
		              uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar10 = global_1;
		              goto code_r0x812512cf;
		            }
		            if (iVar7 == 0) goto code_r0x81251323;
		            DAT_ram_009d3e38 = 0;
		            System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                      (&local_48,*(undefined4 *)(local_20._4_4_ + 0xc),
		                       Method_System_Collections_Generic_List_NotificationGroupData__GetEnumerator__
		                      );
		            iVar10 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 == 1) {
		              uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar10 = global_1;
		              goto code_r0x812512cf;
		            }
		            local_30 = local_40;
		            local_38 = CONCAT44(local_44,local_48);
		            local_48 = 0;
		            local_44 = (int **)&local_38;
		            while( true ) {
		              DAT_ram_009d3e38 = 0;
		              iVar10 = import::env::invoke_iii
		                                 (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_38,
		                                  Method_System_Collections_Generic_List_Enumerator_NotificationGroupData__MoveNext__
		                                 );
		              if (DAT_ram_009d3e38 == 1) break;
		              if (iVar10 == 0) {
		                iVar10 = 0;
		                goto code_r0x812511f2;
		              }
		              DAT_ram_009d3e38 = 0;
		              iVar10 = local_30._4_4_;
		              uVar2 = import::env::invoke_ii
		                                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                 System_Action_NotificationGroupData__TypeInfo);
		              if (DAT_ram_009d3e38 == 1) break;
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar2,param1,
		                         Method_Core_Gameplay_Managers_Notifications_Controller_GameNotificationsController_OnGroupEnabledChangedEvent__
		                         ,0);
		              if (DAT_ram_009d3e38 == 1) break;
		              if (DAT_ram_00a5a683 == '\0') {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vi(0x7ff,&System_Action_NotificationGroupData__TypeInfo);
		                if (DAT_ram_009d3e38 == 1) break;
		                DAT_ram_00a5a683 = '\x01';
		              }
		              iVar7 = *(int *)(iVar10 + 0xc);
		              do {
		                DAT_ram_009d3e38 = 0;
		                iVar6 = import::env::invoke_iiii
		                                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 5,iVar7,uVar2,0
		                                  );
		                uVar5 = System_Action_NotificationGroupData__TypeInfo;
		                if (DAT_ram_009d3e38 == 1) goto code_r0x812511a0;
		                if (iVar6 == 0) {
		                  param2_00 = 0;
		                }
		                else {
		                  DAT_ram_009d3e38 = 0;
		                  param2_00 = import::env::invoke_iii
		                                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,
		                                         iVar6,System_Action_NotificationGroupData__TypeInfo);
		                  if (DAT_ram_009d3e38 == 1) goto code_r0x812511a0;
		                  if (param2_00 == 0) {
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_vii
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar6,uVar5);
		                    if (DAT_ram_009d3e38 == 1) goto code_r0x812511a0;
		                    goto code_r0x81251399;
		                  }
		                }
		                DAT_ram_009d3e38 = 0;
		                iVar6 = func_ii_4329(iVar10 + 0xc,param2_00,iVar7);
		                if (DAT_ram_009d3e38 == 1) goto code_r0x812511a0;
		                bVar1 = iVar7 != iVar6;
		                iVar7 = iVar6;
		              } while (bVar1);
		            }
		code_r0x812511a0:
		            DAT_ram_009d3e38 = 0;
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar10 = global_1;
		            iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		            if (iVar10 != iVar7) {
		code_r0x81251274:
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_ii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x319,&local_48);
		              iVar7 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar7 == 1) goto code_r0x812513d2;
		              goto code_r0x812512cf;
		            }
		            piVar9 = (int *)import::env::__cxa_begin_catch(uVar2);
		            iVar10 = *piVar9;
		            DAT_ram_009d3e38 = 0;
		            local_48 = iVar10;
		            import::env::invoke_v(0x123);
		            iVar7 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar7 == 1) {
		              uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar10 = global_1;
		              goto code_r0x81251274;
		            }
		code_r0x812511f2:
		          } while (iVar10 == 0);
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar10);
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 != 1) {
		code_r0x81251399:
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar10 = global_1;
		code_r0x812512cf:
		          iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar7 == iVar10) {
		            piVar9 = (int *)import::env::__cxa_begin_catch(uVar2);
		            iVar7 = *piVar9;
		            DAT_ram_009d3e38 = 0;
		            local_50 = iVar7;
		            import::env::invoke_v(0x123);
		            iVar10 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 != 1) {
		              if (iVar7 == 0) {
		code_r0x81251323:
		                DAT_ram_009d3e38 = 0;
		                iVar10 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                                   (param1,*(undefined4 *)(*param1 + 0x114));
		                iVar10 = *(int *)(iVar10 + 8);
		                if (iVar10 != 0) {
		                  (**(code **)((ulonglong)*(uint *)(iVar10 + 0xc) * 4))
		                            (*(undefined4 *)(iVar10 + 0x20),*(undefined4 *)(iVar10 + 0x14));
		                }
		                return;
		              }
		              System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		              goto code_r0x81251399;
		            }
		            uVar2 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x31a,&local_50);
		          goto joined_r0x8125138e;
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x31b,&local_48);
		      goto joined_r0x8125138e;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x317,&local_48);
		joined_r0x8125138e:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x812513d2:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006B9C RID: 27548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B9C")]
		[Address(RVA = "0xB696", Offset = "0xB696", VA = "0xB696")]
		private void InitSchedulers()
		{
		/* --- GHIDRA: InitSchedulers ---
		void Core_Gameplay_Managers_Notifications_Controller_GameNotificationsController__InitSchedulers
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  uint *param2_00;
		  undefined4 param1_00;
		  int *piVar5;
		  int iVar6;
		  undefined4 param3_00;
		  int *piVar7;
		  int iVar8;
		  undefined4 local_10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a68c == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Notifier_GetGroupsCmd_Types_Ans_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_BaseEventBusEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_GroupSettings__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_GroupSettings__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8436);
		    DAT_ram_00a5a68c = '\x01';
		  }
		  piVar5 = *(int **)(param2 + 0x20);
		  if ((piVar5 != (int *)0x0) && (Protocol_Notifier_GetGroupsCmd_Types_Ans_TypeInfo != *piVar5)) {
		    System_Activator__CreateInstance(piVar5,Protocol_Notifier_GetGroupsCmd_Types_Ans_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (piVar5[3],
		                              Method_Google_Protobuf_Collections_RepeatedField_GroupSettings__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x81251643:
		  do {
		    do {
		      do {
		        piVar5 = local_4;
		        iVar6 = *local_4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		              puVar2 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		              goto code_r0x812516db;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = (uint *)0x0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x81251727:
		          DAT_ram_009d3e38 = (uint *)0x0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81251a27;
		        }
		code_r0x812516db:
		        DAT_ram_009d3e38 = (uint *)0x0;
		        iVar6 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		        piVar5 = local_4;
		        if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x81251727;
		        if (iVar6 == 0) {
		          iVar6 = 5;
		          iVar4 = 0;
		          param2_00 = DAT_ram_009d3e38;
		          goto code_r0x81251a74;
		        }
		        iVar6 = *local_4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_GroupSettings__TypeInfo == *piVar7) {
		              puVar2 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		              goto code_r0x812517d6;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = (uint *)0x0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_Generic_IEnumerator_GroupSettings__TypeInfo,0);
		        if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x81251904:
		          DAT_ram_009d3e38 = (uint *)0x0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81251a27;
		        }
		code_r0x812517d6:
		        DAT_ram_009d3e38 = (uint *)0x0;
		        iVar6 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		        if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x81251904;
		        DAT_ram_009d3e38 = (uint *)0x0;
		        uVar3 = import::env::invoke_iii
		                          (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104))
		        ;
		        iVar4 = (int)DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = (uint *)0x0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81251a27;
		        }
		        DAT_ram_009d3e38 = (uint *)0x0;
		        iVar8 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x31c,uVar3,
		                           *(undefined4 *)(iVar6 + 0xc),*(undefined4 *)(iVar6 + 0xc));
		        iVar4 = (int)DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = (uint *)0x0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81251a27;
		        }
		        if (iVar8 == 0) {
		          local_10 = *(undefined4 *)(iVar6 + 0xc);
		          DAT_ram_009d3e38 = (uint *)0x0;
		          uVar3 = import::env::invoke_iii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66958
		                             ,&local_10);
		          iVar6 = (int)DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = (uint *)0x0;
		          if (iVar6 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81251a27;
		          }
		          DAT_ram_009d3e38 = (uint *)0x0;
		          uVar3 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1c0,
		                             StringLiteral_8436,uVar3,0);
		          if (DAT_ram_009d3e38 != (uint *)0x1) {
		            if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		              DAT_ram_009d3e38 = (uint *)0x0;
		              import::env::invoke_vi
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                         OKG_Logs_Debug_TypeInfo);
		              if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x81251a1f;
		            }
		            DAT_ram_009d3e38 = (uint *)0x0;
		            import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x310,uVar3,0)
		            ;
		            if (DAT_ram_009d3e38 != (uint *)0x1) goto code_r0x81251643;
		          }
		code_r0x81251a1f:
		          DAT_ram_009d3e38 = (uint *)0x0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81251a27;
		        }
		      } while (*(char *)(iVar6 + 0x10) == *(char *)(iVar8 + 0x10));
		      *(char *)(iVar8 + 0x10) = *(char *)(iVar6 + 0x10);
		      iVar6 = *(int *)(iVar8 + 0xc);
		    } while (iVar6 == 0);
		    DAT_ram_009d3e38 = (uint *)0x0;
		    import::env::invoke_viii
		              (*(undefined4 *)(iVar6 + 0xc),*(undefined4 *)(iVar6 + 0x20),iVar8,
		               *(undefined4 *)(iVar6 + 0x14));
		    iVar6 = (int)DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = (uint *)0x0;
		  } while (iVar6 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81251a27:
		  iVar6 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar4 = *piVar5;
		    iVar6 = 0;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    local_c = iVar4;
		    import::env::invoke_v(0x123);
		    param2_00 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    if (param2_00 != (uint *)0x1) {
		code_r0x81251a74:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = (uint *)0x0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar8 = *local_4;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              param2_00 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                  0xc0);
		              goto code_r0x81251aec;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        param2_00 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81251aec:
		        (**(code **)((ulonglong)*param2_00 * 4))(piVar5,param2_00[1]);
		      }
		      if (iVar4 == 0) {
		        if ((iVar6 == 0) ||
		           ((((iVar6 != 1 && (iVar6 != 2)) && (iVar6 != 3)) && ((iVar6 != 4 && (iVar6 == 5)))))) {
		          Core_Gameplay_Managers_Notifications_Controller_GameNotificationsController__HandleRun
		                    (param1,param2_00);
		          iVar6 = System_Uri___ctor(0);
		          iVar6 = *(int *)(*(int *)(*(int *)(*(int *)(iVar6 + 0x38) + 0x10) + 0x8c) + 0x14);
		          if (iVar6 != 0) {
		            uVar3 = System_Uri___ctor(0);
		            if (DAT_ram_00a6456f == '\0') {
		              Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		              DAT_ram_00a6456f = '\x01';
		            }
		            param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		            param1_00 = unnamed_function_1417(Core_Events_BaseEventBusEventArgs_TypeInfo);
		            Core_Application_Managers_Connection_ServerConnectionDelay__ResetAll
		                      (param1_00,uVar3,param3_00,0);
		            (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		                      (*(undefined4 *)(iVar6 + 0x20),param1_00,*(undefined4 *)(iVar6 + 0x14));
		          }
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = (uint *)0x0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x31d,&local_c);
		  iVar6 = (int)DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = (uint *)0x0;
		  if (iVar6 != 1) {
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

		// Token: 0x06006B9D RID: 27549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B9D")]
		[Address(RVA = "0xB697", Offset = "0xB697", VA = "0xB697")]
		private void HandleGetGroupsService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetGroupsService ---
		void Core_Gameplay_Managers_Notifications_Controller_GameNotificationsController__HandleGetGroupsService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  undefined4 uVar8;
		  uint uVar9;
		  undefined4 param3_00;
		  int *piVar10;
		  undefined1 local_d;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a68d == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Notifier_GroupSettings_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GroupSettings__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GroupSettings___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_GroupSettings__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Events_Scopes_NotificationScope_NotificationSettingsEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24251);
		    DAT_ram_00a5a68d = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(*(int *)(param2 + 8) + 0x1c),
		                              Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    do {
		      piVar5 = local_4;
		      iVar1 = *local_4;
		      if (*(ushort *)(iVar1 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		            puVar2 = (undefined4 *)(iVar1 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x81251d74;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar1 + 0xb6) != uVar9);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x81251dc0:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81251f56;
		      }
		code_r0x81251d74:
		      DAT_ram_009d3e38 = 0;
		      iVar1 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		      piVar5 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81251dc0;
		      if (iVar1 == 0) {
		        iVar4 = 7;
		        iVar1 = 0;
		        goto code_r0x81251fa3;
		      }
		      iVar1 = *local_4;
		      if (*(ushort *)(iVar1 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8);
		          if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar10) {
		            puVar2 = (undefined4 *)(iVar1 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x81251e69;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar1 + 0xb6) != uVar9);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x81251ef6:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81251f56;
		      }
		code_r0x81251e69:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81251ef6;
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x110),param1,*(undefined4 *)(*param1 + 0x114));
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81251f56;
		      }
		      iVar1 = *(int *)(iVar4 + 0x18);
		    } while (iVar1 == 0);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(iVar1 + 0xc),*(undefined4 *)(iVar1 + 0x20),uVar3,
		               *(undefined4 *)(iVar1 + 0x14));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81251f56:
		  iVar1 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar1 = *piVar5;
		    iVar4 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar1;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x81251fa3:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar9 = 0;
		        iVar7 = *local_4;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8)) {
		              puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x8125201b;
		            }
		            uVar9 = uVar9 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		        }
		        puVar6 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x8125201b:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (iVar1 == 0) {
		        if ((iVar4 == 0) ||
		           ((((iVar4 != 1 && (iVar4 != 2)) && (iVar4 != 3)) &&
		            (((iVar4 != 4 && (iVar4 != 5)) && ((iVar4 != 6 && (iVar4 == 7)))))))) {
		          iVar4 = unnamed_function_1417(System_Collections_Generic_List_GroupSettings__TypeInfo);
		          Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		                    (iVar4,1,Method_System_Collections_Generic_List_GroupSettings___ctor__);
		          iVar7 = unnamed_function_1417(Protocol_Notifier_GroupSettings_TypeInfo);
		          *(undefined4 *)(iVar7 + 0xc) = *(undefined4 *)(*(int *)(param2 + 8) + 0xc);
		          *(undefined1 *)(iVar7 + 0x10) = *(undefined1 *)(param2 + 0x10);
		          iVar1 = Method_System_Collections_Generic_List_GroupSettings__Add__;
		          *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		          uVar9 = *(uint *)(iVar4 + 0xc);
		          if (uVar9 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		            *(uint *)(iVar4 + 0xc) = uVar9 + 1;
		            *(int *)(*(int *)(iVar4 + 8) + uVar9 * 4 + 0x10) = iVar7;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (iVar4,iVar7,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		          }
		          ServicesNamespace_NotifierService__GetGroups(param1[7],iVar4,0);
		          iVar1 = System_Uri___ctor(0);
		          iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x8c) + 0x10);
		          if (iVar1 != 0) {
		            uVar3 = System_Uri___ctor(0);
		            if (DAT_ram_00a6456f == '\0') {
		              Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		              DAT_ram_00a6456f = '\x01';
		            }
		            param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		            uVar8 = unnamed_function_1417
		                              (
		                              Core_Events_Scopes_NotificationScope_NotificationSettingsEventArgs_TypeInfo
		                              );
		            Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData
		                      (uVar8,uVar3,param3_00,param2,0);
		            (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                      (*(undefined4 *)(iVar1 + 0x20),uVar8,*(undefined4 *)(iVar1 + 0x14));
		          }
		          uVar3 = Core_Extensions_Dict_NotificationCategoryDicExt__GetTitle
		                            (*(undefined4 *)(param2 + 8),0);
		          local_d = *(undefined1 *)(param2 + 0x10);
		          uVar8 = func_ii_1081(DAT_ram_00a66944,&local_d);
		          uVar3 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                            (StringLiteral_24251,uVar3,uVar8,0);
		          if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		            func_ii_306000(OKG_Logs_Debug_TypeInfo);
		          }
		          System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		        }
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
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x31e,&local_c);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006B9E RID: 27550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B9E")]
		[Address(RVA = "0xB698", Offset = "0xB698", VA = "0xB698")]
		private void OnGroupEnabledChangedEvent(NotificationGroupData group)
		{
		/* --- GHIDRA: OnGroupEnabledChangedEvent ---
		/* WARNING: Removing unreachable block (ram,0x812527eb) */
		
		void Core_Gameplay_Managers_Notifications_Controller_GameNotificationsController__OnGroupEnabledChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param3;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int param2_00;
		  int iVar6;
		  int local_48;
		  undefined8 *local_44;
		  int local_40;
		  undefined8 *puStack_3c;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a68e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_NotificationGroupData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_NotificationCategoryData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_NotificationGroupData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AbstractBaseNotificationScheduler__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_NotificationGroupData__MoveNext__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AbstractBaseNotificationScheduler__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_NotificationCategoryData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AbstractBaseNotificationScheduler__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_NotificationCategoryData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_NotificationGroupData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Controller_GameNotificationsController_OnGroupEnabledChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractBaseNotificationScheduler__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_AbstractBaseNotificationScheduler__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_NotificationGroupData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_NotificationCategoryData__GetEnumerator__);
		    DAT_ram_00a5a68e = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  local_30 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_40,param1[6],
		             Method_System_Collections_Generic_List_AbstractBaseNotificationScheduler__GetEnumerator__
		            );
		  local_8 = local_38;
		  local_40 = 0;
		  puStack_3c = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_AbstractBaseNotificationScheduler__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812523d7;
		    }
		    if (iVar2 == 0) goto code_r0x8125242d;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 799,local_8._4_4_,iVar6);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar6 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x812523d7:
		  iVar6 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_40 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x8125242d:
		      DAT_ram_009d3e38 = 0;
		      iVar6 = param1[6];
		      iVar2 = *(int *)(iVar6 + 0xc);
		      *(undefined4 *)(iVar6 + 0xc) = 0;
		      *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		      if (0 < iVar2) {
		        func_ii_2064(*(undefined4 *)(iVar6 + 8),0,iVar2,0);
		      }
		      iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_40,*(undefined4 *)(iVar6 + 0xc),
		                 Method_System_Collections_Generic_List_NotificationCategoryData__GetEnumerator__);
		      local_18 = local_38;
		      local_20 = CONCAT44(puStack_3c,local_40);
		      local_48 = 0;
		      local_44 = &local_20;
		      while( true ) {
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_20,
		                           Method_System_Collections_Generic_List_Enumerator_NotificationCategoryData__MoveNext__
		                          );
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) break;
		        if (iVar2 == 0) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        DAT_ram_009d3e38 = 0;
		        System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                  (&local_40,*(undefined4 *)(local_18._4_4_ + 0xc),
		                   Method_System_Collections_Generic_List_NotificationGroupData__GetEnumerator__);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar6 = global_1;
		          goto code_r0x812528a2;
		        }
		        local_28 = local_38;
		        local_30 = CONCAT44(puStack_3c,local_40);
		        local_40 = 0;
		        puStack_3c = &local_30;
		        while( true ) {
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_30,
		                             Method_System_Collections_Generic_List_Enumerator_NotificationGroupData__MoveNext__
		                            );
		          if (DAT_ram_009d3e38 == 1) break;
		          if (iVar6 == 0) {
		            iVar2 = 5;
		            iVar6 = 0;
		            goto code_r0x812527bf;
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar6 = local_28._4_4_;
		          uVar3 = import::env::invoke_ii
		                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                             System_Action_NotificationGroupData__TypeInfo);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar3,param1,
		                     Method_Core_Gameplay_Managers_Notifications_Controller_GameNotificationsController_OnGroupEnabledChangedEvent__
		                     ,0);
		          if (DAT_ram_009d3e38 == 1) break;
		          if (DAT_ram_00a5a684 == '\0') {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi(0x7ff,&System_Action_NotificationGroupData__TypeInfo);
		            if (DAT_ram_009d3e38 == 1) break;
		            DAT_ram_00a5a684 = '\x01';
		          }
		          iVar2 = *(int *)(iVar6 + 0xc);
		          do {
		            DAT_ram_009d3e38 = 0;
		            iVar5 = import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_00001b87 + 2,iVar2,uVar3,0);
		            param3 = System_Action_NotificationGroupData__TypeInfo;
		            if (DAT_ram_009d3e38 == 1) goto code_r0x81252769;
		            if (iVar5 == 0) {
		              param2_00 = 0;
		            }
		            else {
		              DAT_ram_009d3e38 = 0;
		              param2_00 = import::env::invoke_iii
		                                    (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar5,
		                                     System_Action_NotificationGroupData__TypeInfo);
		              if (DAT_ram_009d3e38 == 1) goto code_r0x81252769;
		              if (param2_00 == 0) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar5,param3);
		                if (DAT_ram_009d3e38 != 1) goto code_r0x81252937;
		                goto code_r0x81252769;
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            iVar5 = func_ii_4329(iVar6 + 0xc,param2_00,iVar2);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x81252769;
		            bVar1 = iVar2 != iVar5;
		            iVar2 = iVar5;
		          } while (bVar1);
		        }
		code_r0x81252769:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar6 = global_1;
		        iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar6 != iVar2) {
		code_r0x8125284c:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 800,&local_40);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 1) goto code_r0x812528a2;
		          goto code_r0x81252976;
		        }
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar6 = *piVar4;
		        iVar2 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_40 = iVar6;
		        import::env::invoke_v(0x123);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar6 = global_1;
		          goto code_r0x8125284c;
		        }
		code_r0x812527bf:
		        if (iVar6 != 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar6);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar6 = global_1;
		            goto code_r0x812528a2;
		          }
		          goto code_r0x81252937;
		        }
		        if (iVar2 != 0) {
		          if (iVar2 == 1) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          if (iVar2 == 2) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          if (iVar2 == 3) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          if (iVar2 == 4) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          if (iVar2 != 5) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		        }
		      }
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar6 = global_1;
		code_r0x812528a2:
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar2 == iVar6) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar2 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_48 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) {
		          if (iVar2 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		code_r0x81252937:
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x321,&local_48);
		      goto joined_r0x8125292c;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x322,&local_40);
		joined_r0x8125292c:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x81252976:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006B9F RID: 27551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B9F")]
		[Address(RVA = "0xB699", Offset = "0xB699", VA = "0xB699", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x040038CE RID: 14542
		[Token(Token = "0x40038CE")]
		[FieldOffset(Offset = "0x18")]
		private List<AbstractBaseNotificationScheduler> _schedulers;

		// Token: 0x040038CF RID: 14543
		[Token(Token = "0x40038CF")]
		[FieldOffset(Offset = "0x1C")]
		private NotifierService _notifierService;
	}
}
