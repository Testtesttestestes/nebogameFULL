using System;
using Gameplay.WorldAxis.ColossusInfo.Events;
using Gameplay.WorldAxis.ColossusInfo.Model;
using Gameplay.WorldAxis.ColossusInfo.View;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using ServicesNamespace;
using Utils;

namespace Gameplay.WorldAxis.ColossusInfo.Controller
{
	// Token: 0x02000330 RID: 816
	[Token(Token = "0x2000330")]
	public class ColossusTreasuryController : AbstractController<ColossusTreasuryModel, ColossusTreasuryEvents>
	{
		// Token: 0x060012BD RID: 4797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BD")]
		[Address(RVA = "0x64B7", Offset = "0x64B7", VA = "0x64B7")]
		public ColossusTreasuryController(ColossusTreasuryModel model, ColossusTreasuryEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController___ctor
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a58bf2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController_GetTreasuryOptionsResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a58bf2 = '\x01';
		  }
		  param1_02 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = ServicesNamespace_ColossusService__GetDollSkills
		                        (param1_02,
		                         *(undefined4 *)
		                          (*(int *)(*(int *)(*(int *)(iVar1 + 0xc) + 0x18) + 0x10) + 0xc),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController_GetTreasuryOptionsResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BE")]
		[Address(RVA = "0x64B8", Offset = "0x64B8", VA = "0x64B8")]
		public void GetTreasuryOptions()
		{
		/* --- GHIDRA: GetTreasuryOptions ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController__GetTreasuryOptions
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a58bf3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetTreasuryOptionsAns_TypeInfo);
		    DAT_ram_00a58bf3 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Colossus_ProtoGetTreasuryOptionsAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance
		              (param1_01,Protocol_Colossus_ProtoGetTreasuryOptionsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_WorldAxis_ColossusInfo_Model_ColossusTreasuryModel__set_Options
		            (param1_00,param1_01,param1);
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

		// Token: 0x060012BF RID: 4799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BF")]
		[Address(RVA = "0x64B9", Offset = "0x64B9", VA = "0x64B9")]
		private void GetTreasuryOptionsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetTreasuryOptionsResultHandler ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController__GetTreasuryOptionsResultHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  longlong lVar6;
		  uint uVar7;
		  
		  if (DAT_ram_00a58bf4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_int__int___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_GolemInventoryModel__StartResolveEmptySlotsProcess__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__int__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController___c__DisplayClass4_0__BuyTreasuryOption_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController___c__DisplayClass4_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_17776);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17778);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17784);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21424);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17777);
		    DAT_ram_00a58bf4 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController___c__DisplayClass4_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int **)(param2_00 + 8) = param1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar5 = *(int **)(*(int *)(iVar1 + 0xc) + 0xc);
		  iVar1 = *piVar5;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8 + 4) * 8 + iVar1 + 0xd0);
		        goto code_r0x80f87e3f;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar7);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80f87e3f:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar1 = Core_Extensions_Dict_DictExt__GetLongParameter(uVar3,StringLiteral_21424,0);
		  if (iVar1 == 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17778,1,0,1,0,0,0,0);
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17776,1,0,1,0,0,0,0);
		    UI_Windows_DialogWindow__Show(uVar3,uVar4,0);
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if ((*(int *)(*(int *)(*(int *)(iVar1 + 0xc) + 0x18) + 0x14) != 0) &&
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104)),
		     *(int *)(*(int *)(iVar1 + 8) + 0x68) != 0)) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar1 = *piVar5;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      uVar7 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8 + 4) * 8 + iVar1 + 0x230);
		          goto code_r0x80f87f93;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar7);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f87f93:
		    iVar1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    if (*(int *)(*(int *)(iVar1 + 0x10) + 0x20) != 0) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      lVar6 = *(longlong *)(*(int *)(*(int *)(*(int *)(iVar1 + 8) + 0x68) + 0x1c) + 0x10);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      if (lVar6 == *(longlong *)
		                    (*(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0xc) + 0x18) + 0x14) + 0x1c) + 0x10
		                    )) {
		        if (*(int *)(*(int *)(param2_00 + 0xc) + 0x1c) == 0) {
		          if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Core_GameLocalization_TypeInfo);
		          }
		          uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17778,1,0,1,0,0,0,0);
		          uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17784,1,0,1,0,0,0,0);
		          UI_Windows_DialogWindow__Show(uVar3,uVar4,0);
		          return;
		        }
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar1 = *piVar5;
		        if (*(ushort *)(iVar1 + 0xb6) != 0) {
		          uVar7 = 0;
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8)) {
		              puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8 + 4) * 8 + iVar1 + 0x238
		                               );
		              goto code_r0x80f88144;
		            }
		            uVar7 = uVar7 + 1;
		          } while (*(ushort *)(iVar1 + 0xb6) != uVar7);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x80f88144:
		        iVar1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		        uVar3 = Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_object___ShowNotAvailableSlotsWindow
		                          (*(undefined4 *)(*(int *)(iVar1 + 0x14) + 0x20),1,2,
		                           Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_GolemInventoryModel__StartResolveEmptySlotsProcess__
		                          );
		        uVar4 = unnamed_function_1417(System_Action_OpToken_int__int___TypeInfo);
		        UnityEngine_UIElements_VisualElement__get_layout
		                  (uVar4,param2_00,
		                   Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController___c__DisplayClass4_0__BuyTreasuryOption_b__0__
		                   ,0);
		        ServicesNamespace_MainService__GetUserStats
		                  (uVar3,uVar4,0,Method_Utils_OpToken_int__int__AddResultHandler__);
		        return;
		      }
		    }
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17778,1,0,1,0,0,0,0);
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17777,1,0,1,0,0,0,0);
		  UI_Windows_DialogWindow__Show(uVar3,uVar4,0);
		  return;
		}
		*/

		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C0")]
		[Address(RVA = "0x64BA", Offset = "0x64BA", VA = "0x64BA")]
		public void BuyTreasuryOption(TreasuryOptionListElement.TreasuryOptionListElementArgs args)
		{
		/* --- GHIDRA: BuyTreasuryOption ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController__BuyTreasuryOption
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58bf5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController_BuyTreasuryOptionResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a58bf5 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ColossusService__GetTreasuryOptions
		                    (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(param2 + 0x2c),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController_BuyTreasuryOptionResultHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  DG_Tweening_TweenParams__SetId
		            (uVar1,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  return;
		}
		*/

		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C1")]
		[Address(RVA = "0x64BB", Offset = "0x64BB", VA = "0x64BB")]
		private void ServiceBuyTreasuryItem(TreasuryOptionListElement.TreasuryOptionListElementArgs args)
		{
		/* --- GHIDRA: ServiceBuyTreasuryItem ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController__ServiceBuyTreasuryItem
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a58bf6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoBuyTreasuryItemAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_ColossusInfo_View_TreasuryOptionListElement_TreasuryOptionListElementArgs_TypeInfo
		              );
		    DAT_ram_00a58bf6 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Colossus_ProtoBuyTreasuryItemAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Colossus_ProtoBuyTreasuryItemAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors___
		                    );
		  if (iVar1 == 0) {
		    param1_01 = *(int **)(param2 + 0xc);
		    if (param1_01 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_01 + 0xb8) <
		           (uint)*(byte *)(
		                          Gameplay_WorldAxis_ColossusInfo_View_TreasuryOptionListElement_TreasuryOptionListElementArgs_TypeInfo
		                          + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_01 + 100) +
		                   (uint)*(byte *)(
		                                  Gameplay_WorldAxis_ColossusInfo_View_TreasuryOptionListElement_TreasuryOptionListElementArgs_TypeInfo
		                                  + 0xb8) * 4 + -4) !=
		          Gameplay_WorldAxis_ColossusInfo_View_TreasuryOptionListElement_TreasuryOptionListElementArgs_TypeInfo
		         )) {
		        System_Activator__CreateInstance
		                  (param1_01,
		                   Gameplay_WorldAxis_ColossusInfo_View_TreasuryOptionListElement_TreasuryOptionListElementArgs_TypeInfo
		                  );
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    param1_01[7] = param1_00[4];
		    HuaweiMobileServices_Ads_InstallReferrer_InstallReferrerStateCallbackListener_InstallReferrerStateCallbackListenerInterfaceWrapper___ctor
		              (param1_01,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C2")]
		[Address(RVA = "0x64BC", Offset = "0x64BC", VA = "0x64BC")]
		private void BuyTreasuryOptionResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: BuyTreasuryOptionResultHandler ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController__BuyTreasuryOptionResultHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  uint *puVar3;
		  int *param1_01;
		  
		  if (DAT_ram_00a58bf7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController_TreasuryBalanceChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_TypeInfo);
		    DAT_ram_00a58bf7 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar2 + 0x10) != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param1_01 = *(int **)(iVar2 + 0x10);
		    uVar1 = 0;
		    param1_00 = unnamed_function_1417
		                          (Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    Core_Data_InfoRows_CollectionRow___ctor
		              (param1_00,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController_TreasuryBalanceChangedEventHandler__
		               ,0);
		    iVar2 = *param1_01;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Data_Balance_IBalanceSource_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		          goto code_r0x80f887ca;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,Core_Data_Balance_IBalanceSource_TypeInfo,1);
		code_r0x80f887ca:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_01,param1_00,puVar3[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C3")]
		[Address(RVA = "0x64BD", Offset = "0x64BD", VA = "0x64BD", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController__HandleStop
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  uint *puVar3;
		  int *param1_01;
		  
		  if (DAT_ram_00a58bf8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController_TreasuryBalanceChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_TypeInfo);
		    DAT_ram_00a58bf8 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar2 + 0x10) != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param1_01 = *(int **)(iVar2 + 0x10);
		    uVar1 = 0;
		    param1_00 = unnamed_function_1417
		                          (Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    Core_Data_InfoRows_CollectionRow___ctor
		              (param1_00,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController_TreasuryBalanceChangedEventHandler__
		               ,0);
		    iVar2 = *param1_01;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Data_Balance_IBalanceSource_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80f888d0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,Core_Data_Balance_IBalanceSource_TypeInfo,0);
		code_r0x80f888d0:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_01,param1_00,puVar3[1]);
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

		// Token: 0x060012C4 RID: 4804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C4")]
		[Address(RVA = "0x64BE", Offset = "0x64BE", VA = "0x64BE", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController__HandleRun
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,param3,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C5")]
		[Address(RVA = "0x64BF", Offset = "0x64BF", VA = "0x64BF")]
		private void TreasuryBalanceChangedEventHandler(ResourceSet balance, ResourceSet delta)
		{
		}

		// Token: 0x04000A1E RID: 2590
		[Token(Token = "0x4000A1E")]
		[FieldOffset(Offset = "0x18")]
		private ColossusService _service;
	}
}
