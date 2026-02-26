using System;
using Gameplay.Inventory.View;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005E0 RID: 1504
	[Token(Token = "0x20005E0")]
	public class PortalsShopController : AbstractController<PortalsShopModel, PortalsEvents>
	{
		// Token: 0x06002453 RID: 9299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002453")]
		[Address(RVA = "0x75A1", Offset = "0x75A1", VA = "0x75A1")]
		public PortalsShopController(PortalsShopModel model, PortalsEvents events, PortalsService portalsService)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_Controller_PortalsShopController___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57d0d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsShopController_OnGetStoreItemsInfo__);
		    DAT_ram_00a57d0d = '\x01';
		  }
		  uVar1 = ServicesNamespace_PortalsService__GetBetsHistory(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Portals_Controller_PortalsShopController_OnGetStoreItemsInfo__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002454 RID: 9300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002454")]
		[Address(RVA = "0x75A2", Offset = "0x75A2", VA = "0x75A2")]
		public void GetStoreItemsInfo()
		{
		/* --- GHIDRA: GetStoreItemsInfo ---
		void Gameplay_Portals_Controller_PortalsShopController__GetStoreItemsInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 param2_00;
		  undefined4 uVar4;
		  uint *puVar5;
		  int iVar6;
		  int *piVar7;
		  int *piVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57d0e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ArtifactItem__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ShopItemData__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoGetArtifactItemsInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactItem__GetEnumerator__);
		    DAT_ram_00a57d0e = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = *(int *)(iVar2 + 0x14);
		  iVar6 = *(int *)(iVar2 + 0xc);
		  *(undefined4 *)(iVar2 + 0xc) = 0;
		  *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		  if (0 < iVar6) {
		    func_ii_2064(*(undefined4 *)(iVar2 + 8),0,iVar6,0);
		  }
		  piVar7 = *(int **)(param2 + 0x20);
		  if ((piVar7 != (int *)0x0) && (Protocol_Portal_ProtoGetArtifactItemsInfoAns_TypeInfo != *piVar7))
		  {
		    System_Activator__CreateInstance(piVar7,Protocol_Portal_ProtoGetArtifactItemsInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (piVar7[3],
		                              Method_Google_Protobuf_Collections_RepeatedField_ArtifactItem__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar7 = local_4;
		    iVar2 = *local_4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar2 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80e4aaee;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e4aca2:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e4acaa;
		    }
		code_r0x80e4aaee:
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    piVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e4aca2;
		    if (iVar2 == 0) {
		      iVar2 = 0;
		      goto code_r0x80e4acf3;
		    }
		    iVar2 = *local_4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_ArtifactItem__TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar2 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80e4abc8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ArtifactItem__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e4ac84:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e4acaa;
		    }
		code_r0x80e4abc8:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e4ac84;
		    DAT_ram_009d3e38 = 0;
		    param2_00 = import::env::invoke_iii
		                          (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104))
		    ;
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e4acaa;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x53,param2_00,uVar4,0);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar2 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e4acaa:
		  iVar2 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar2 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar2;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x80e4acf3:
		      piVar7 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar6 = *local_4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar5 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e4ad6b;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar5 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e4ad6b:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar7,puVar5[1]);
		      }
		      if (iVar2 == 0) {
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x114));
		        iVar2 = *(int *)(iVar2 + 0x2c);
		        if (iVar2 != 0) {
		          (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                    (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x54,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002455 RID: 9301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002455")]
		[Address(RVA = "0x75A3", Offset = "0x75A3", VA = "0x75A3")]
		private void OnGetStoreItemsInfo(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: OnGetStoreItemsInfo ---
		void Gameplay_Portals_Controller_PortalsShopController__OnGetStoreItemsInfo
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int param2_00;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a57d0f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_int__int___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEmptySlotsProcess__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__int__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsShopController___c__DisplayClass4_0__BuyShopItem_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Portals_Controller_PortalsShopController___c__DisplayClass4_0_TypeInfo);
		    DAT_ram_00a57d0f = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Portals_Controller_PortalsShopController___c__DisplayClass4_0_TypeInfo
		                        );
		  *(int **)(param2_00 + 0x18) = param2;
		  *(int **)(param2_00 + 8) = param1;
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80e4aee8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x80e4aee8:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  *(undefined8 *)(param2_00 + 0x10) =
		       *(undefined8 *)(*(int *)(*(int *)(iVar3 + 0x74) + 0x24) + 0x28);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  param1_02 = *(int **)(iVar3 + 0xc);
		  iVar3 = *param1_02;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x80e4af8b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80e4af8b:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_02,puVar2[1]);
		  param1_00 = Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_object___ShowNotAvailableSlotsWindow
		                        (*(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x20),1,3,
		                         Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEmptySlotsProcess__
		                        );
		  param1_01 = unnamed_function_1417(System_Action_OpToken_int__int___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param2_00,
		             Method_Gameplay_Portals_Controller_PortalsShopController___c__DisplayClass4_0__BuyShopItem_b__0__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_int__int__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06002456 RID: 9302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002456")]
		[Address(RVA = "0x75A4", Offset = "0x75A4", VA = "0x75A4")]
		public void BuyShopItem(IArtifactView item)
		{
		/* --- GHIDRA: BuyShopItem ---
		void Gameplay_Portals_Controller_PortalsShopController__BuyShopItem
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  undefined4 param8;
		  undefined4 param1_00;
		  undefined8 param6;
		  int *param1_01;
		  int *piVar6;
		  int *param1_02;
		  int param1_03;
		  undefined4 param7;
		  longlong param5;
		  uint uVar7;
		  
		  if (DAT_ram_00a57d10 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_ArtifactData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_PortalsScope_BuyItemEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedPortalBuyArtifactItemErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoBuyArtifactItemAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9179);
		    DAT_ram_00a57d10 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0xc);
		  if (param1_01 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_01 + 0xb8) <
		         (uint)*(byte *)(Core_Data_ArtifactData_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_01 + 100) +
		                 (uint)*(byte *)(Core_Data_ArtifactData_TypeInfo + 0xb8) * 4 + -4) !=
		        Core_Data_ArtifactData_TypeInfo)) {
		      System_Activator__CreateInstance(param1_01,Core_Data_ArtifactData_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  piVar6 = *(int **)(param2 + 0x20);
		  if ((piVar6 != (int *)0x0) && (Protocol_Portal_ProtoBuyArtifactItemAns_TypeInfo != *piVar6)) {
		    System_Activator__CreateInstance(piVar6,Protocol_Portal_ProtoBuyArtifactItemAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (piVar6[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedPortalBuyArtifactItemErrors___
		                    );
		  if (iVar1 == 0) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_HourMinuteSep(uVar2,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9179,1,0,1,0,0,0,0);
		    UI_ConfirmationMessage_ConfirmationMessageController__set_DefaultDuration(uVar2,uVar3,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param1_02 = *(int **)(iVar1 + 0xc);
		    iVar1 = *param1_02;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      uVar7 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8 + 4) * 8 + iVar1 + 0x120);
		          goto code_r0x80e4b19e;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar7);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80e4b19e:
		    iVar1 = (**(code **)((ulonglong)*puVar4 * 4))(param1_02,puVar4[1]);
		    Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		              (*(undefined4 *)(iVar1 + 0x14),piVar6[4],
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    if (param1_01 != (int *)0x0) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      piVar6 = *(int **)(iVar1 + 0xc);
		      iVar1 = *piVar6;
		      if (*(ushort *)(iVar1 + 0xb6) != 0) {
		        uVar7 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8 + 4) * 8 + iVar1 + 0x290);
		            goto code_r0x80e4b252;
		          }
		          uVar7 = uVar7 + 1;
		        } while (*(ushort *)(iVar1 + 0xb6) != uVar7);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80e4b252:
		      iVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		      param1_03 = *(int *)(iVar1 + 0x10);
		      iVar1 = System_Uri___ctor(0);
		      iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x9c) + 0x14);
		      if (iVar1 != 0) {
		        uVar2 = System_Uri___ctor(0);
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        uVar7 = *(uint *)(*(int *)(param1_03 + 0x10) + 0xc);
		        uVar3 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar5 = func_ii_7954(param1_01,0);
		        if (ABS(*(double *)(iVar5 + 0x28)) < 9.223372036854776e+18) {
		          param5 = (longlong)*(double *)(iVar5 + 0x28);
		        }
		        else {
		          param5 = -0x8000000000000000;
		        }
		        param6 = Gameplay_Portals_Model_PortalsModel__set_EntryPointBackTime(param1_03,0);
		        param7 = *(undefined4 *)(param1_01[0x1d] + 0x18);
		        param8 = (**(code **)((ulonglong)*(uint *)(*param1_01 + 0xf8) * 4))
		                           (param1_01,*(undefined4 *)(*param1_01 + 0xfc));
		        param1_00 = unnamed_function_1417(Core_Events_Scopes_PortalsScope_BuyItemEventArgs_TypeInfo)
		        ;
		        Core_Events_Scopes_ThemeDuelScope_OpenWindowEventArgs__get_OpenReasonSource
		                  (param1_00,uVar2,uVar3,(ulonglong)uVar7,param5,param6,param7,param8,0);
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                  (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002457 RID: 9303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002457")]
		[Address(RVA = "0x75A5", Offset = "0x75A5", VA = "0x75A5")]
		private void OnBuyEventShopItem(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x040013FC RID: 5116
		[Token(Token = "0x40013FC")]
		[FieldOffset(Offset = "0x18")]
		private readonly PortalsService _portalsService;
	}
}
