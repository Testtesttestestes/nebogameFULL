using System;
using Core.Data;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Inventory.Controller.Middlewares;
using Gameplay.Inventory.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Main;
using ServicesNamespace;
using UI.Windows;
using Utils;

namespace Gameplay.Inventory.Controller
{
	// Token: 0x020006B8 RID: 1720
	[Token(Token = "0x20006B8")]
	public class InventoryController : InventoryBaseController<InventoryModel, InventoryEvents>
	{
		// Token: 0x060029A8 RID: 10664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029A8")]
		[Address(RVA = "0x7A5E", Offset = "0x7A5E", VA = "0x7A5E", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Inventory_Controller_InventoryController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7,undefined4 param8,undefined4 param9)
		
		{
		  if (DAT_ram_00a5a16d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents___ctor__
		              );
		    DAT_ram_00a5a16d = '\x01';
		  }
		  Gameplay_Inventory_Controller_InventoryBaseController_object__object___RepairItemSuccessHandler_object_
		            (param1,param2,param3,param5,param8,
		             Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents___ctor__
		            );
		  *(undefined4 *)(param1 + 0x2c) = param4;
		  *(undefined4 *)(param1 + 0x28) = param7;
		  *(undefined4 *)(param1 + 0x24) = param6;
		  return;
		}
		*/

		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029A9")]
		[Address(RVA = "0x7A5F", Offset = "0x7A5F", VA = "0x7A5F")]
		public InventoryController(InventoryModel model, InventoryEvents events, DismantleMiddleware dismantleMiddleware, InventoryActionsMiddlewareBase<InventoryModel> middlewareActions, MainService mainService, ServicesService servicesService, CraftService craftService)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_Controller_InventoryController___ctor(int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined8 param2_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a16e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoInventoryChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__HandleRun__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryController_HandleGetUserArtifactsRequest__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_Controller_InventoryController_OnInventoryChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a5a16e = '\x01';
		  }
		  Gameplay_Inventory_Controller_InventoryBaseController_object__object___Equip
		            (param1,
		             Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__HandleRun__
		            );
		  iVar2 = param1[9];
		  uVar1 = unnamed_function_1417(System_Action_ProtoInventoryChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Inventory_Controller_InventoryController_OnInventoryChangedEvent__,0);
		  ServicesNamespace_MainService__remove_DictionariesUpdatedEvent(iVar2,uVar1,0);
		  param1_01 = param1[9];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar2 + 8),0);
		  uVar1 = ServicesNamespace_MainService__GetClientState(param1_01,param2_00,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Inventory_Controller_InventoryController_HandleGetUserArtifactsRequest__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060029AA RID: 10666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029AA")]
		[Address(RVA = "0x7A60", Offset = "0x7A60", VA = "0x7A60", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Inventory_Controller_InventoryController__HandleRun(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a16f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoInventoryChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__HandleStop__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_Controller_InventoryController_OnInventoryChangedEvent__);
		    DAT_ram_00a5a16f = '\x01';
		  }
		  Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleRun
		            (param1,
		             Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__HandleStop__
		            );
		  param1_01 = *(undefined4 *)(param1 + 0x24);
		  param1_00 = unnamed_function_1417(System_Action_ProtoInventoryChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Inventory_Controller_InventoryController_OnInventoryChangedEvent__,0);
		  ServicesNamespace_MainService__add_InventoryChangedEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060029AB RID: 10667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029AB")]
		[Address(RVA = "0x7A61", Offset = "0x7A61", VA = "0x7A61", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Inventory_Controller_InventoryController__HandleStop
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5a170 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    DAT_ram_00a5a170 = '\x01';
		  }
		  if (*(longlong *)(param2 + 0x10) == 0) {
		    Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		              (param1,*(undefined4 *)(param2 + 0xc),
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x060029AC RID: 10668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029AC")]
		[Address(RVA = "0x7A62", Offset = "0x7A62", VA = "0x7A62")]
		private void OnInventoryChangedEvent(ProtoInventoryChangedEvt evt)
		{
		/* --- GHIDRA: OnInventoryChangedEvent ---
		void Gameplay_Inventory_Controller_InventoryController__OnInventoryChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  undefined4 param3_00;
		  longlong lVar6;
		  int *piVar7;
		  int iVar8;
		  undefined8 uVar9;
		  int *piVar10;
		  int iVar11;
		  uint uVar12;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a171 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerable_ProtoGetUserArtifactsAns_Types_UserArtifact__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_ProtoGetUserArtifactsAns_Types_UserArtifact__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetUserArtifactsAns_TypeInfo);
		    DAT_ram_00a5a171 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar7 = *(int **)(param2 + 0x20);
		  if ((piVar7 != (int *)0x0) && (Protocol_Main_ProtoGetUserArtifactsAns_TypeInfo != *piVar7)) {
		    System_Activator__CreateInstance(piVar7,Protocol_Main_ProtoGetUserArtifactsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar8 = piVar7[4];
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  if (DAT_ram_00a5a141 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		    DAT_ram_00a5a141 = '\x01';
		  }
		  if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		  }
		  iVar11 = *(int *)(*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c) + 4);
		  lVar6 = Gameplay_Inventory_Model_InventoryBaseModel__TryGetFitSlotId(uVar1,iVar11);
		  lVar6 = lVar6 + (iVar11 + -1);
		  piVar7 = (int *)Gameplay_Inventory_Model_InventoryModel___c__DisplayClass7_0___GetArtifactsToTakeoffForHorde_b__0
		                            (iVar8,lVar6,iVar11);
		  iVar8 = *param1;
		  uVar9 = CONCAT44((int)((ulonglong)lVar6 >> 0x20),*(undefined4 *)(iVar8 + 0x104));
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x100) * 4))(param1,uVar9);
		  uVar1 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  Gameplay_Inventory_Model_InventoryBaseModel__SetArtifact(uVar2,piVar7,iVar8);
		  uVar12 = 0;
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_ProtoGetUserArtifactsAns_Types_UserArtifact__TypeInfo
		          == *(int *)(*(int *)(iVar8 + 0x58) + uVar12 * 8)) {
		        puVar3 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar12 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811d7801;
		      }
		      uVar12 = uVar12 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar12);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,
		                                System_Collections_Generic_IEnumerable_ProtoGetUserArtifactsAns_Types_UserArtifact__TypeInfo
		                                ,0);
		code_r0x811d7801:
		  uVar9 = CONCAT44(uVar1,puVar3[1]);
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar9);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    do {
		      piVar7 = local_4;
		      uVar1 = (undefined4)((ulonglong)uVar9 >> 0x20);
		      iVar8 = *local_4;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar12 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar12 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		            puVar4 = (undefined4 *)(iVar8 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x811d78c2;
		          }
		          uVar12 = uVar12 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar12);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x811d7b5d:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811d7b78;
		      }
		code_r0x811d78c2:
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		      piVar7 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811d7b5d;
		      if (iVar8 == 0) {
		        iVar8 = 0;
		        goto code_r0x811d7bc1;
		      }
		      iVar8 = *local_4;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar12 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar12 * 8);
		          if (System_Collections_Generic_IEnumerator_ProtoGetUserArtifactsAns_Types_UserArtifact__TypeInfo
		              == *piVar10) {
		            puVar4 = (undefined4 *)(iVar8 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x811d799c;
		          }
		          uVar12 = uVar12 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar12);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_ProtoGetUserArtifactsAns_Types_UserArtifact__TypeInfo
		                          ,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x811d7b70:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811d7b78;
		      }
		code_r0x811d799c:
		      DAT_ram_009d3e38 = 0;
		      uVar9 = CONCAT44(uVar1,piVar7);
		      iVar8 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		      uVar1 = (undefined4)((ulonglong)uVar9 >> 0x20);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811d7b70;
		    } while (*(char *)(iVar8 + 0x14) == '\0');
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811d7b78;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811d7b78;
		    }
		    uVar9 = *(undefined8 *)(*(int *)(iVar8 + 0x10) + 0x10);
		    if (DAT_ram_00a5a14b == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (0x7ff,&
		                       Method_System_Collections_Generic_CollectionExtensions_GetValueOrDefault_ulong__ArtifactData___
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_00a5a14b = '\x01';
		    }
		    DAT_ram_009d3e38 = 0;
		    param3_00 = unnamed_function_184070
		                          (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x26e,
		                           *(undefined4 *)(iVar5 + 0x28),uVar9,
		                           Method_System_Collections_Generic_CollectionExtensions_GetValueOrDefault_ulong__ArtifactData___
		                          );
		    iVar8 = DAT_ram_009d3e38;
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    uVar9 = CONCAT44(uVar1,uVar2);
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x26f,uVar2,param3_00,1,iVar8);
		    uVar1 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811d7b78:
		  iVar8 = global_1;
		  iVar11 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar11) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar8 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar8;
		    import::env::invoke_v(0x123);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 != 1) {
		code_r0x811d7bc1:
		      piVar7 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar12 = 0;
		        iVar11 = *local_4;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar12 * 8)) {
		              puVar3 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar12 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x811d7c39;
		            }
		            uVar12 = uVar12 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar12);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x811d7c39:
		        uVar9 = CONCAT44(uVar1,puVar3[1]);
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar9);
		        uVar1 = (undefined4)((ulonglong)uVar9 >> 0x20);
		      }
		      if (iVar8 == 0) {
		        iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                          (param1,CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x114)));
		        iVar8 = *(int *)(iVar8 + 8);
		        (**(code **)((ulonglong)*(uint *)(iVar8 + 0xc) * 4))
		                  (*(undefined4 *)(iVar8 + 0x20),*(undefined4 *)(iVar8 + 0x14));
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x270,&local_c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
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

		// Token: 0x060029AD RID: 10669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029AD")]
		[Address(RVA = "0x7A63", Offset = "0x7A63", VA = "0x7A63")]
		protected void HandleGetUserArtifactsRequest(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetUserArtifactsRequest ---
		void Gameplay_Inventory_Controller_InventoryController__HandleGetUserArtifactsRequest
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a172 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryController_SellArtifactSuccessHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a5a172 = '\x01';
		  }
		  uVar1 = ServicesNamespace_MainService__GetUserArtifacts
		                    (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param2 + 0x7c),0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Inventory_Controller_InventoryController_SellArtifactSuccessHandler__,0
		            );
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_4 = *(undefined4 *)(param2 + 0x7c);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,uVar2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060029AE RID: 10670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029AE")]
		[Address(RVA = "0x7A64", Offset = "0x7A64", VA = "0x7A64", Slot = "18")]
		public override void SellItem(ArtifactData artifactData)
		{
		/* --- GHIDRA: SellItem ---
		void Gameplay_Inventory_Controller_InventoryController__SellItem
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a173 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__RepairItemSuccessHandler_ExpectedBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a5a173 = '\x01';
		  }
		  param1_00 = ServicesNamespace_ServicesService__GetActivePromotions
		                        (*(undefined4 *)(param1 + 0x28),param3,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__RepairItemSuccessHandler_ExpectedBillingErrors___
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x060029AF RID: 10671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029AF")]
		[Address(RVA = "0x7A65", Offset = "0x7A65", VA = "0x7A65", Slot = "19")]
		public override void RepairArtifact(ResourceSet price, params uint[] slotIds)
		{
		/* --- GHIDRA: RepairArtifact ---
		void Gameplay_Inventory_Controller_InventoryController__RepairArtifact
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a174 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_Controller_InventoryController_RestoreUserItemHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a5a174 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ServicesService__RepairUserItem(*(undefined4 *)(param1 + 0x28),param2,0)
		  ;
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Inventory_Controller_InventoryController_RestoreUserItemHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_4 = param2;
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  DG_Tweening_TweenParams__SetId(uVar1,uVar2,Method_Utils_OpToken_IMessage__object__SetCustomData__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B0")]
		[Address(RVA = "0x7A66", Offset = "0x7A66", VA = "0x7A66")]
		public void RestoreItem(uint slotId)
		{
		/* --- GHIDRA: RestoreItem ---
		void Gameplay_Inventory_Controller_InventoryController__RestoreItem
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a175 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ReforgeItemResultHandler_ExpectedBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a5a175 = '\x01';
		  }
		  param1_00 = ServicesNamespace_ServicesService__RestoreUserItem
		                        (*(undefined4 *)(param1 + 0x28),param3,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ReforgeItemResultHandler_ExpectedBillingErrors___
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B1")]
		[Address(RVA = "0x7A67", Offset = "0x7A67", VA = "0x7A67", Slot = "20")]
		public override void ReforgeArtifact(ResourceSet price, uint slotId)
		{
		/* --- GHIDRA: ReforgeArtifact ---
		void Gameplay_Inventory_Controller_InventoryController__ReforgeArtifact
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5a176 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoRestoreUserItemAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2645);
		    DAT_ram_00a5a176 = '\x01';
		  }
		  piVar4 = *(int **)(param2 + 0x20);
		  if ((piVar4 != (int *)0x0) && (Protocol_Services_ProtoRestoreUserItemAns_TypeInfo != *piVar4)) {
		    System_Activator__CreateInstance(piVar4,Protocol_Services_ProtoRestoreUserItemAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (piVar4[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		                    );
		  if (iVar1 == 0) {
		    piVar4 = *(int **)(param2 + 0xc);
		    if (piVar4 == (int *)0x0) {
		      System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(*piVar4 + 0x20) != *(int *)(DAT_ram_00a66958 + 0x20)) {
		      System_Activator__CreateInstance(piVar4,DAT_ram_00a66958);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    puVar2 = (undefined4 *)func_ii_15774(piVar4);
		    uVar5 = *puVar2;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (DAT_ram_00a5a14c == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_CollectionExtensions_GetValueOrDefault_int__ArtifactData___
		                );
		      DAT_ram_00a5a14c = '\x01';
		    }
		    uVar5 = Spine_Collections_CollectionExtensions__ToOrderedDictionary___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                      (*(undefined4 *)(iVar1 + 0xc),uVar5,
		                       Method_System_Collections_Generic_CollectionExtensions_GetValueOrDefault_int__ArtifactData___
		                      );
		    uVar3 = System_Uri___ctor(0);
		    uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param2_00 = func_ii_7508(StringLiteral_2645,1,0,1,0,0,0,0);
		    uVar5 = UI_Toast_ToastController_ToastData__GetUiResourceIdByTheme(3,param2_00,uVar5,0);
		    UI_Toast_ToastController__OnReleaseToast(uVar3,uVar5,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B2")]
		[Address(RVA = "0x7A68", Offset = "0x7A68", VA = "0x7A68")]
		private void RestoreUserItemHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: RestoreUserItemHandler ---
		void Gameplay_Inventory_Controller_InventoryController__RestoreUserItemHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int param1_00;
		  int param2_01;
		  
		  if (DAT_ram_00a5a177 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__HandleSuccessDismantle__
		              );
		    DAT_ram_00a5a177 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  param2_01 = *(int *)(param2 + 8);
		  param2_00 = Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware__ShowRecipeLearnedWindow
		                        (param1_00,param2_01,param1_00);
		  if ((ulonglong)*(uint *)(*(int *)(param2_01 + 0xc) + 0xc) == (longlong)*(int *)(param1_00 + 0x18))
		  {
		    Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware___ctor
		              (param1_00,param2_00,*(undefined4 *)(param2_01 + 8),*(undefined4 *)(param1_00 + 8),
		               param1_00);
		    return;
		  }
		  if (*(int *)(param1_00 + 0x10) != 0) {
		    UI_ConfirmationMessage_ConfirmationMessageController__set_DefaultDuration
		              (*(int *)(param1_00 + 0x10),param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B3")]
		[Address(RVA = "0x7A69", Offset = "0x7A69", VA = "0x7A69", Slot = "14")]
		protected override void HandleSuccessDismantle(InventoryController.DismantleArtifactVO dismantleInformation)
		{
		/* --- GHIDRA: HandleSuccessDismantle ---
		void Gameplay_Inventory_Controller_InventoryController__HandleSuccessDismantle
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  int local_4;
		  
		  if (DAT_ram_00a5a178 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9769);
		    DAT_ram_00a5a178 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Common_ProtoDefaultAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Common_ProtoDefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  local_4 = param1_00[3];
		  uVar1 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_9769,uVar1,param1_00[4],0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B4")]
		[Address(RVA = "0x7A6A", Offset = "0x7A6A", VA = "0x7A6A")]
		private void SellArtifactSuccessHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: SellArtifactSuccessHandler ---
		void Gameplay_Inventory_Controller_InventoryController__SellArtifactSuccessHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5a179 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ShowNotAvailableSlotsWindow__
		              );
		    DAT_ram_00a5a179 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a5a144 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__get_Item__);
		    DAT_ram_00a5a144 = '\x01';
		  }
		  if (*(int *)(*(int *)(iVar1 + 0x30) + 0xc) < 1) {
		    iVar2 = -1;
		  }
		  else {
		    iVar2 = System_Linq_Enumerable__ToList_object_
		                      (*(int *)(iVar1 + 0x30),0,
		                       Method_System_Collections_Generic_List_int__get_Item__);
		  }
		  if (0 < *(int *)(*(int *)(iVar1 + 0x34) + 0xc)) {
		    System_Linq_Enumerable__ToList_object_
		              (*(int *)(iVar1 + 0x34),0,Method_System_Collections_Generic_List_int__get_Item__);
		  }
		  if (iVar2 < 0) {
		    Gameplay_Inventory_Controller_InventoryBaseController_object__object___ParseSlotChanges
		              (param1,1,
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ShowNotAvailableSlotsWindow__
		              );
		    return;
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		            (param1,param2,iVar2,*(undefined4 *)(*param1 + 0x144));
		  return;
		}
		*/

		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B5")]
		[Address(RVA = "0x7A6B", Offset = "0x7A6B", VA = "0x7A6B")]
		public void MoveItemToBag(ArtifactData artifact)
		{
		/* --- GHIDRA: MoveItemToBag ---
		void Gameplay_Inventory_Controller_InventoryController__MoveItemToBag
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a17a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_Controller_InventoryController_SwapSlotsSuccessHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a5a17a = '\x01';
		  }
		  uVar1 = ServicesNamespace_MainService__Ping
		                    (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param2 + 0x7c),param3,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Inventory_Controller_InventoryController_SwapSlotsSuccessHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B6")]
		[Address(RVA = "0x7A6C", Offset = "0x7A6C", VA = "0x7A6C", Slot = "16")]
		public override void RequestMoveItemTo(ArtifactData artifact, int slotId)
		{
		/* --- GHIDRA: RequestMoveItemTo ---
		void Gameplay_Inventory_Controller_InventoryController__RequestMoveItemTo
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 param1_00;
		  undefined8 param2_00;
		  int param1_01;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  System_Collections_Generic_CollectionExtensions__GetValueOrDefault_ulong__object_
		            (param1_00,param2,param3,param1);
		  param1_01 = param1[9];
		  param2_00 = func_ii_7957(param2,0);
		  ServicesNamespace_MainService__SetUserId(param1_01,param2_00,param3,0);
		  Utils_Accumulators_CallAccumulator___ctor(param1[7],0);
		  return;
		}
		*/

		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B7")]
		[Address(RVA = "0x7A6D", Offset = "0x7A6D", VA = "0x7A6D")]
		public void SetArtifactFavorite(ArtifactData artifactData, bool favorite)
		{
		/* --- GHIDRA: SetArtifactFavorite ---
		void Gameplay_Inventory_Controller_InventoryController__SetArtifactFavorite
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a17b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryController_MergeArtifactResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a5a17b = '\x01';
		  }
		  uVar1 = ServicesNamespace_MainService__SetMedalsVisibility
		                    (*(undefined4 *)(param1 + 0x24),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Inventory_Controller_InventoryController_MergeArtifactResultHandler__,0
		            );
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B8")]
		[Address(RVA = "0x7A6E", Offset = "0x7A6E", VA = "0x7A6E")]
		public void MergeAllStackableItems(uint slotId)
		{
		/* --- GHIDRA: MergeAllStackableItems ---
		void Gameplay_Inventory_Controller_InventoryController__MergeAllStackableItems
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  int param1_02;
		  undefined4 param3_00;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a5a17c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Errors_Expected_ExpectedStackableChangesErrors_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Errors_Expected_ExpectedItemErrors_ErrorArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedStackableChangesErrors__ExpectedItemErrors___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    DAT_ram_00a5a17c = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Main_ProtoStackableChangesAns_TypeInfo != *param1_01))
		  {
		    System_Activator__CreateInstance(param1_01,Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_02 = param1_01[3];
		  local_1 = 1;
		  param2_00 = func_ii_1081(Core_Errors_Expected_ExpectedStackableChangesErrors_Action_TypeInfo,
		                           &local_1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param3_00 = *(undefined4 *)(iVar1 + 0x54);
		  param1_00 = unnamed_function_1417(Core_Errors_Expected_ExpectedItemErrors_ErrorArgs_TypeInfo);
		  UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor(param1_00,param1,param3_00,1,0);
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_02,param2_00,param1_00,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedStackableChangesErrors__ExpectedItemErrors___
		                    );
		  if (iVar1 == 0) {
		    Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		              (param1,param1_01[4],
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B9")]
		[Address(RVA = "0x7A6F", Offset = "0x7A6F", VA = "0x7A6F")]
		private void MergeArtifactResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: MergeArtifactResultHandler ---
		void Gameplay_Inventory_Controller_InventoryController__MergeArtifactResultHandler
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a17d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryController_SplitArtifactResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a5a17d = '\x01';
		  }
		  uVar1 = ServicesNamespace_MainService__MergeAllStackableItems
		                    (*(undefined4 *)(param1 + 0x24),param2,param3,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Inventory_Controller_InventoryController_SplitArtifactResultHandler__,0
		            );
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060029BA RID: 10682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BA")]
		[Address(RVA = "0x7A70", Offset = "0x7A70", VA = "0x7A70")]
		public void SplitArtifact(uint slotId, uint quantity)
		{
		/* --- GHIDRA: SplitArtifact ---
		void Gameplay_Inventory_Controller_InventoryController__SplitArtifact
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  int param1_02;
		  undefined4 param3_00;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a5a17e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Errors_Expected_ExpectedStackableChangesErrors_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Errors_Expected_ExpectedItemErrors_ErrorArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedStackableChangesErrors__ExpectedItemErrors___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    DAT_ram_00a5a17e = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Main_ProtoStackableChangesAns_TypeInfo != *param1_01))
		  {
		    System_Activator__CreateInstance(param1_01,Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_02 = param1_01[3];
		  local_1 = 2;
		  param2_00 = func_ii_1081(Core_Errors_Expected_ExpectedStackableChangesErrors_Action_TypeInfo,
		                           &local_1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param3_00 = *(undefined4 *)(iVar1 + 0x54);
		  param1_00 = unnamed_function_1417(Core_Errors_Expected_ExpectedItemErrors_ErrorArgs_TypeInfo);
		  UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor(param1_00,param1,param3_00,1,0);
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_02,param2_00,param1_00,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedStackableChangesErrors__ExpectedItemErrors___
		                    );
		  if (iVar1 == 0) {
		    Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		              (param1,param1_01[4],
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x060029BB RID: 10683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BB")]
		[Address(RVA = "0x7A71", Offset = "0x7A71", VA = "0x7A71")]
		private void SplitArtifactResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: SplitArtifactResultHandler ---
		undefined4
		Gameplay_Inventory_Controller_InventoryController__SplitArtifactResultHandler
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a17f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_Controller_InventoryController_BuySlotHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_uint__ResourceSet___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Tuple_uint__ResourceSet__TypeInfo);
		    DAT_ram_00a5a17f = '\x01';
		  }
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x118) * 4))
		                    (piVar1,param2,*(undefined4 *)(*piVar1 + 0x11c));
		  param1_00 = unnamed_function_1417(System_Tuple_uint__ResourceSet__TypeInfo);
		  UnityEngine_Purchasing_Default_Factory__Create
		            (param1_00,param2,uVar2,Method_System_Tuple_uint__ResourceSet___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  uVar2 = ServicesNamespace_ServicesService__ServerEventHandler(uVar2,param2,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Inventory_Controller_InventoryController_BuySlotHandler__,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  uVar2 = DG_Tweening_TweenParams__SetId
		                    (uVar2,param1_00,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  return uVar2;
		}
		*/

		}

		// Token: 0x060029BC RID: 10684 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60029BC")]
		[Address(RVA = "0x7A72", Offset = "0x7A72", VA = "0x7A72", Slot = "17")]
		public override OpToken<IMessage, object> BuySlots(uint quantity)
		{
		/* --- GHIDRA: BuySlots ---
		void Gameplay_Inventory_Controller_InventoryController__BuySlots
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int param5;
		  int param4;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5a180 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_InventoryScope_BuySlotEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedBuySlotErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoBuySlotsAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_uint__ResourceSet__get_Item1__);
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_uint__ResourceSet__get_Item2__);
		    Mono_Security_ASN1__get_Item(&System_Tuple_uint__ResourceSet__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9121);
		    DAT_ram_00a5a180 = '\x01';
		  }
		  piVar4 = *(int **)(param2 + 0x20);
		  if ((piVar4 != (int *)0x0) && (Protocol_Services_ProtoBuySlotsAns_TypeInfo != *piVar4)) {
		    System_Activator__CreateInstance(piVar4,Protocol_Services_ProtoBuySlotsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (piVar4[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedBuySlotErrors___
		                    );
		  if (iVar1 == 0) {
		    Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		              (param1,piVar4[4],
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9121,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar2,1,uVar3,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x1c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		    piVar4 = *(int **)(param2 + 0xc);
		    if (piVar4 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar4 + 0xb8) <
		           (uint)*(byte *)(System_Tuple_uint__ResourceSet__TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar4 + 100) +
		                   (uint)*(byte *)(System_Tuple_uint__ResourceSet__TypeInfo + 0xb8) * 4 + -4) !=
		          System_Tuple_uint__ResourceSet__TypeInfo)) {
		        System_Activator__CreateInstance(piVar4,System_Tuple_uint__ResourceSet__TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x40) + 8);
		    if (iVar1 != 0) {
		      uVar2 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param5 = piVar4[3];
		      param4 = piVar4[2];
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      uVar3 = unnamed_function_1417(Core_Events_Scopes_InventoryScope_BuySlotEventArgs_TypeInfo);
		      Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		                (uVar3,uVar2,param3_00,param4,param5,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),uVar3,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BD")]
		[Address(RVA = "0x7A73", Offset = "0x7A73", VA = "0x7A73")]
		protected void BuySlotHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: BuySlotHandler ---
		/* WARNING: Removing unreachable block (ram,0x811d92fa) */
		
		void Gameplay_Inventory_Controller_InventoryController__BuySlotHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  int *piVar6;
		  int iVar7;
		  int iVar8;
		  undefined8 param3_00;
		  int *piVar9;
		  uint uVar10;
		  int local_10;
		  int **local_c;
		  undefined1 local_5;
		  int *local_4;
		  
		  if (DAT_ram_00a5a181 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Errors_Expected_ExpectedStackableChangesErrors_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedStackableChangesErrors___
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_UserSlot__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_UserArtifact__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_UserArtifact___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_UserArtifact__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoSwapSlotsAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserSlot__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_UserArtifact_TypeInfo);
		    DAT_ram_00a5a181 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar6 = *(int **)(param2 + 0x20);
		  if ((piVar6 != (int *)0x0) && (Protocol_Main_ProtoSwapSlotsAns_TypeInfo != *piVar6)) {
		    System_Activator__CreateInstance(piVar6,Protocol_Main_ProtoSwapSlotsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar7 = piVar6[3];
		  local_5 = 0;
		  uVar1 = func_ii_1081(Core_Errors_Expected_ExpectedStackableChangesErrors_Action_TypeInfo,&local_5)
		  ;
		  iVar7 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (iVar7,uVar1,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedStackableChangesErrors___
		                    );
		  if (iVar7 != 0) {
		    return;
		  }
		  iVar7 = unnamed_function_1417(System_Collections_Generic_List_UserArtifact__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar7,Method_System_Collections_Generic_List_UserArtifact___ctor__);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (piVar6[4],
		                              Method_Google_Protobuf_Collections_RepeatedField_UserSlot__GetEnumerator__
		                             );
		  local_10 = 0;
		  local_c = &local_4;
		code_r0x811d901a:
		  do {
		    piVar6 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x811d90ae;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811d93e7:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811d93ef;
		    }
		code_r0x811d90ae:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar2,piVar6,puVar2[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811d93e7;
		    if (iVar8 == 0) {
		      iVar8 = 7;
		      goto code_r0x811d943c;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8);
		        if (System_Collections_Generic_IEnumerator_UserSlot__TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x811d9194;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_UserSlot__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811d9305:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811d93ef;
		    }
		code_r0x811d9194:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar2,piVar6,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811d9305;
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811d93ef;
		    }
		    param3_00 = *(undefined8 *)(iVar8 + 0x10);
		    if (DAT_ram_00a5a14b == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (0x7ff,&
		                       Method_System_Collections_Generic_CollectionExtensions_GetValueOrDefault_ulong__ArtifactData___
		                );
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_00a5a14b = '\x01';
		        goto code_r0x811d9261;
		      }
		code_r0x811d9319:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811d93ef;
		    }
		code_r0x811d9261:
		    DAT_ram_009d3e38 = 0;
		    iVar4 = unnamed_function_184070
		                      (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x26e,
		                       *(undefined4 *)(iVar3 + 0x28),param3_00,
		                       Method_System_Collections_Generic_CollectionExtensions_GetValueOrDefault_ulong__ArtifactData___
		                      );
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811d9319;
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Protocol_Main_UserArtifact_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811d93ef;
		    }
		    if (iVar4 == 0) {
		      uVar1 = 0;
		    }
		    else {
		      uVar1 = *(undefined4 *)(iVar4 + 0x74);
		    }
		    *(undefined4 *)(iVar3 + 0x10) = uVar1;
		    *(undefined4 *)(iVar3 + 0xc) = *(undefined4 *)(iVar8 + 0xc);
		    iVar8 = Method_System_Collections_Generic_List_UserArtifact__Add__;
		    *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		    uVar10 = *(uint *)(iVar7 + 0xc);
		    if (uVar10 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		      *(uint *)(iVar7 + 0xc) = uVar10 + 1;
		      *(int *)(*(int *)(iVar7 + 8) + uVar10 * 4 + 0x10) = iVar3;
		      goto code_r0x811d901a;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar7,iVar3,
		               *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar8 != 1);
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811d93ef:
		  iVar8 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar4) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar1);
		    local_10 = *piVar6;
		    iVar8 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x811d943c:
		      DAT_ram_009d3e38 = 0;
		      piVar6 = *local_c;
		      if (piVar6 != (int *)0x0) {
		        uVar10 = 0;
		        iVar4 = *piVar6;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar10 * 8)) {
		              puVar5 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x811d94b7;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar10);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x811d94b7:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		      }
		      if (local_10 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_10);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar8 != 0) {
		        if (iVar8 == 1) {
		          return;
		        }
		        if (iVar8 == 2) {
		          return;
		        }
		        if (iVar8 == 3) {
		          return;
		        }
		        if (iVar8 == 4) {
		          return;
		        }
		        if (iVar8 == 5) {
		          return;
		        }
		        if (iVar8 == 6) {
		          return;
		        }
		        if (iVar8 != 7) {
		          return;
		        }
		      }
		      Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		                (param1,iVar7,
		                 Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		                );
		      return;
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x272,&local_10);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 != 1) {
		    import::env::__resumeException(uVar1);
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

		// Token: 0x060029BE RID: 10686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BE")]
		[Address(RVA = "0x7A74", Offset = "0x7A74", VA = "0x7A74")]
		protected void SwapSlotsSuccessHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: SwapSlotsSuccessHandler ---
		void Gameplay_Inventory_Controller_InventoryController__SwapSlotsSuccessHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a182 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_int__int___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEmptySlotsProcess__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__int__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryController___c__DisplayClass27_0__MoveItemToChest_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_Controller_InventoryController___c__DisplayClass27_0_TypeInfo);
		    DAT_ram_00a5a182 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Inventory_Controller_InventoryController___c__DisplayClass27_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  param1_00 = Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_object___ShowNotAvailableSlotsWindow
		                        (*(undefined4 *)(param1 + 0x20),1,2,
		                         Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEmptySlotsProcess__
		                        );
		  param1_01 = unnamed_function_1417(System_Action_OpToken_int__int___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param2_00,
		             Method_Gameplay_Inventory_Controller_InventoryController___c__DisplayClass27_0__MoveItemToChest_b__0__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_int__int__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x060029BF RID: 10687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BF")]
		[Address(RVA = "0x7A75", Offset = "0x7A75", VA = "0x7A75", Slot = "15")]
		public override void MoveItemToChest(ArtifactData artifactData)
		{
		/* --- GHIDRA: MoveItemToChest ---
		void Gameplay_Inventory_Controller_InventoryController__MoveItemToChest
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a5a183 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__DismantleArtifact__
		              );
		    DAT_ram_00a5a183 = '\x01';
		  }
		  Gameplay_Inventory_Controller_InventoryBaseController_object__object___ClearFresh
		            (param1,param2,param3,param4,0,
		             Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__DismantleArtifact__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C0")]
		[Address(RVA = "0x7A76", Offset = "0x7A76", VA = "0x7A76", Slot = "13")]
		public override void DismantleArtifact(ArtifactData artifactData, bool sellDrop = false, bool wholeStack = false)
		{
		/* --- GHIDRA: DismantleArtifact ---
		undefined4
		Gameplay_Inventory_Controller_InventoryController__DismantleArtifact
		          (undefined4 param1,undefined4 param2,int param3,int *param4,undefined4 param5)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  uint uVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a5a184 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
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
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryController___c__DisplayClass29_0__ShowRecipeLearnedWindow_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_Controller_InventoryController___c__DisplayClass29_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3613);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4476);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26332);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4489);
		    DAT_ram_00a5a184 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Inventory_Controller_InventoryController___c__DisplayClass29_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 8) = 0;
		  iVar8 = *param4;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar7 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar7 * 8 + 4) * 8 + iVar8 + 0xd0);
		        goto code_r0x811d976e;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar7);
		  }
		  puVar2 = (uint *)func_ii_1080(param4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811d976e:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param4,puVar2[1]);
		  iVar8 = Core_Extensions_Dict_DictExt__GetDiscountsDic
		                    (uVar3,*(undefined4 *)(*(int *)(param3 + 0x10) + 0xc),0);
		  if (iVar8 != 0) {
		    iVar8 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (*(undefined4 *)(iVar8 + 0x18),0,
		                       Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__get_Item__);
		    uVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (*(undefined4 *)(iVar8 + 0x10),0,
		                       Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		    *(undefined4 *)(iVar1 + 8) = uVar3;
		  }
		  iVar8 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(iVar8,0);
		  *(undefined4 *)(iVar8 + 0x18) = param2;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4476,1,0,1,0,0,0,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  param3_00 = Core_Extensions_Dict_DictExt__GetArtikul(*(undefined4 *)(param3 + 0x10),0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_26332,param3_00,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar3 = Core_GameLocalization__GetTranslation(uVar3,param1_00,0);
		  *(undefined4 *)(iVar8 + 0x1c) = uVar3;
		  iVar6 = *(int *)(iVar8 + 0x24);
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar4,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3613,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 8) = uVar3;
		  iVar5 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		  uVar7 = *(uint *)(iVar6 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(iVar6 + 8) + 0xc)) {
		    *(uint *)(iVar6 + 0xc) = uVar7 + 1;
		    *(int *)(*(int *)(iVar6 + 8) + uVar7 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar6,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		  }
		  iVar6 = *(int *)(iVar8 + 0x24);
		  iVar5 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar5,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4489,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar5 + 8) = uVar3;
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar3,iVar1,
		             Method_Gameplay_Inventory_Controller_InventoryController___c__DisplayClass29_0__ShowRecipeLearnedWindow_b__0__
		             ,0);
		  *(undefined4 *)(iVar4 + 8) = uVar3;
		  *(int *)(iVar5 + 0x14) = iVar4;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		  uVar7 = *(uint *)(iVar6 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(iVar6 + 8) + 0xc)) {
		    *(uint *)(iVar6 + 0xc) = uVar7 + 1;
		    *(int *)(*(int *)(iVar6 + 8) + uVar7 * 4 + 0x10) = iVar5;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar6,iVar5,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar3 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (iVar8,0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60029C1")]
		[Address(RVA = "0x7A77", Offset = "0x7A77", VA = "0x7A77")]
		public DialogWindow ShowRecipeLearnedWindow(string title, ArtikulDicWrapper artikul, IDictProvider dictProvider)
		{
			return null;
		}

		// Token: 0x04001721 RID: 5921
		[Token(Token = "0x4001721")]
		[FieldOffset(Offset = "0x24")]
		private MainService _mainService;

		// Token: 0x04001722 RID: 5922
		[Token(Token = "0x4001722")]
		[FieldOffset(Offset = "0x28")]
		private ServicesService _servicesService;

		// Token: 0x04001723 RID: 5923
		[Token(Token = "0x4001723")]
		[FieldOffset(Offset = "0x2C")]
		private DismantleMiddleware _dismantleMiddleware;

		// Token: 0x020006B9 RID: 1721
		[Token(Token = "0x20006B9")]
		public class DismantleArtifactVO
		{
			// Token: 0x060029C2 RID: 10690 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60029C2")]
			[Address(RVA = "0x7A78", Offset = "0x7A78", VA = "0x7A78")]
			public DismantleArtifactVO(ArtifactData artifact)
			{
			}

			// Token: 0x04001724 RID: 5924
			[Token(Token = "0x4001724")]
			[FieldOffset(Offset = "0x8")]
			public readonly ArtifactData Artifact;

			// Token: 0x04001725 RID: 5925
			[Token(Token = "0x4001725")]
			[FieldOffset(Offset = "0xC")]
			public bool SellDrop;

			// Token: 0x04001726 RID: 5926
			[Token(Token = "0x4001726")]
			[FieldOffset(Offset = "0xD")]
			public bool WholeStack;
		}
	}
}
