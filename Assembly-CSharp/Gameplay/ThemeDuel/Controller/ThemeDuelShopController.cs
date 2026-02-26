using System;
using System.Runtime.CompilerServices;
using Gameplay.Inventory.View;
using Gameplay.ThemeDuel.Events;
using Gameplay.ThemeDuel.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Themeduel;
using ServicesNamespace;
using UI;
using Utils;

namespace Gameplay.ThemeDuel.Controller
{
	// Token: 0x020004F3 RID: 1267
	[Token(Token = "0x20004F3")]
	public class ThemeDuelShopController : AbstractController<ThemeDuelModel, ThemeDuelEvents>
	{
		// Token: 0x06001E3D RID: 7741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E3D")]
		[Address(RVA = "0x6FBB", Offset = "0x6FBB", VA = "0x6FBB")]
		public ThemeDuelShopController(ThemeDuelModel model, ThemeDuelEvents events)
		{
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001E3F RID: 7743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057C")]
		public ProtoGetEventStoreItemsInfoAns StoreItemsInfo
		{
			[Token(Token = "0x6001E3E")]
			[Address(RVA = "0x6FBC", Offset = "0x6FBC", VA = "0x6FBC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E3F")]
			[Address(RVA = "0x6FBD", Offset = "0x6FBD", VA = "0x6FBD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E40")]
		[Address(RVA = "0x6FBE", Offset = "0x6FBE", VA = "0x6FBE")]
		public void GetEventStoreItemsInfo()
		{
		/* --- GHIDRA: GetEventStoreItemsInfo ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelShopController__GetEventStoreItemsInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a585f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Themeduel_ProtoGetEventStoreItemsInfoAns_TypeInfo);
		    DAT_ram_00a585f9 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Themeduel_ProtoGetEventStoreItemsInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Themeduel_ProtoGetEventStoreItemsInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1[8] = (int)param1_00;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E41")]
		[Address(RVA = "0x6FBF", Offset = "0x6FBF", VA = "0x6FBF")]
		private void OnGetEventStoreItemsInfo(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: OnGetEventStoreItemsInfo ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelShopController__OnGetEventStoreItemsInfo
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a585fa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ThemeDuelModel__ThemeDuelEvents__Dispose__);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuel_Controller_ThemeDuelShopController_PopupOnClose__);
		    DAT_ram_00a585fa = '\x01';
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_ThemeDuelModel__ThemeDuelEvents__Dispose__);
		  *(undefined4 *)(param1 + 0x20) = 0;
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 != 0) {
		    param1_00 = *(undefined4 *)(param1 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelShopController_PopupOnClose__,0);
		    UI_Windows_BaseWindow__add_onClose(param1_00,uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E42")]
		[Address(RVA = "0x6FC0", Offset = "0x6FC0", VA = "0x6FC0", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelShopController__Dispose
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  longlong lVar7;
		  uint uVar8;
		  
		  if (DAT_ram_00a585fb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_int__int___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEmptySlotsProcess__
		              );
		    Mono_Security_ASN1__get_Item(&UI_NotEnoughTdScoreWindow_NotEnoughTdScoreWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__int__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_NotEnoughTdScoreWindow___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuel_Controller_ThemeDuelShopController_PopupOnClose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelShopController___c__DisplayClass10_0__BuyShopItem_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ThemeDuel_Controller_ThemeDuelShopController___c__DisplayClass10_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_12655);
		    DAT_ram_00a585fb = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_ThemeDuel_Controller_ThemeDuelShopController___c__DisplayClass10_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0xc) = param2;
		  *(int **)(iVar1 + 8) = param1;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar8 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + iVar6 + 0x288);
		        goto code_r0x80f13082;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f13082:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar6 = *(int *)(iVar6 + 0x14);
		  if (DAT_ram_00a58587 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__GetValueOrDefault__);
		    DAT_ram_00a58587 = '\x01';
		  }
		  lVar7 = *(longlong *)(iVar6 + 0x20);
		  piVar5 = *(int **)(iVar1 + 0xc);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar8 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x80f1312f;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x80f1312f:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  if ((double)lVar7 < *(double *)(*(int *)(*(int *)(iVar6 + 0x74) + 0x24) + 0x28)) {
		    uVar3 = System_Uri___ctor(0);
		    uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar3,0);
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param1_00 = unnamed_function_1417(UI_NotEnoughTdScoreWindow_NotEnoughTdScoreWindowArgs_TypeInfo)
		    ;
		    UI_NotEnoughTdScoreWindow_NotEnoughTdScoreWindowArgs__get_DescriptionShort(param1_00,uVar4,0);
		    iVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                      (uVar3,StringLiteral_12655,param1_00,
		                       Method_UI_Windows_PopupController_Show_NotEnoughTdScoreWindow___);
		    param1[7] = iVar1;
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelShopController_PopupOnClose__,0);
		    UI_Windows_BaseWindow__get_IsActiveResourceBar(iVar1,uVar3,0);
		    return;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar8 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + iVar6 + 0x120);
		        goto code_r0x80f1326b;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80f1326b:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_object___ShowNotAvailableSlotsWindow
		                    (*(undefined4 *)(*(int *)(iVar6 + 0x14) + 0x20),1,3,
		                     Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEmptySlotsProcess__
		                    );
		  uVar4 = unnamed_function_1417(System_Action_OpToken_int__int___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,iVar1,
		             Method_Gameplay_ThemeDuel_Controller_ThemeDuelShopController___c__DisplayClass10_0__BuyShopItem_b__0__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar3,uVar4,0,Method_Utils_OpToken_int__int__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E43")]
		[Address(RVA = "0x6FC1", Offset = "0x6FC1", VA = "0x6FC1")]
		public void BuyShopItem(IArtifactView item)
		{
		/* --- GHIDRA: BuyShopItem ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelShopController__BuyShopItem
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a585fc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuel_Controller_ThemeDuelShopController_PopupOnClose__);
		    DAT_ram_00a585fc = '\x01';
		  }
		  if (*(char *)(*(int *)(param1 + 0x1c) + 0x54) != '\0') {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    iVar1 = Gameplay_ThemeDuelCombat_ThemeDuelCombat__Dispose
		                      (**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c),2,0,param1);
		    if (iVar1 != 0) {
		      uVar2 = System_Uri___ctor(0);
		      uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		      UI_Windows_PopupController__Close(uVar2,2,0);
		    }
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_ThemeDuel_Controller_ThemeDuelShopController_PopupOnClose__,0);
		  UI_Windows_BaseWindow__add_onClose(param1_00,uVar2,0);
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E44")]
		[Address(RVA = "0x6FC2", Offset = "0x6FC2", VA = "0x6FC2")]
		private void PopupOnClose()
		{
		/* --- GHIDRA: PopupOnClose ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelShopController__PopupOnClose
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  undefined4 param8;
		  undefined4 param1_00;
		  int *param1_01;
		  int *param1_02;
		  int *param1_03;
		  undefined4 param7;
		  undefined8 param4;
		  double dVar6;
		  undefined8 param6;
		  longlong param5;
		  uint uVar7;
		  
		  if (DAT_ram_00a585fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_ArtifactData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ThemeDuelScope_BuyItemEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedFromThemeDuelShop2UserErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Themeduel_ProtoBuyEventStoreItemAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9179);
		    DAT_ram_00a585fd = '\x01';
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
		  param1_02 = *(int **)(param2 + 0x20);
		  if ((param1_02 != (int *)0x0) &&
		     (Protocol_Themeduel_ProtoBuyEventStoreItemAns_TypeInfo != *param1_02)) {
		    System_Activator__CreateInstance
		              (param1_02,Protocol_Themeduel_ProtoBuyEventStoreItemAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_02[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedFromThemeDuelShop2UserErrors___
		                    );
		  if (iVar1 == 0) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_HourMinuteSep(uVar2,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9179,1,0,1,0,0,0,0);
		    UI_ConfirmationMessage_ConfirmationMessageController__set_DefaultDuration(uVar2,uVar3,0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar7 = 0;
		    param1_03 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar1 = *param1_03;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8 + 4) * 8 + iVar1 + 0x120);
		          goto code_r0x80f13547;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar7);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_03,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80f13547:
		    iVar1 = (**(code **)((ulonglong)*puVar4 * 4))(param1_03,puVar4[1]);
		    Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		              (*(undefined4 *)(iVar1 + 0x14),param1_02[4],
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    if (param1_01 != (int *)0x0) {
		      iVar1 = System_Uri___ctor(0);
		      iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x98) + 0x14);
		      if (iVar1 != 0) {
		        uVar2 = System_Uri___ctor(0);
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        uVar3 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        iVar5 = *(int *)(iVar5 + 0x14);
		        func_ii_7103(*(undefined4 *)(iVar5 + 0x34),0);
		        param4 = *(undefined8 *)(*(int *)(iVar5 + 0x10) + 0x10);
		        iVar5 = func_ii_7954(param1_01,0);
		        dVar6 = *(double *)(iVar5 + 0x28);
		        iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        iVar5 = *(int *)(iVar5 + 0x14);
		        if (DAT_ram_00a58587 == '\0') {
		          Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__GetValueOrDefault__);
		          DAT_ram_00a58587 = '\x01';
		        }
		        param6 = *(undefined8 *)(iVar5 + 0x20);
		        param7 = *(undefined4 *)(param1_01[0x1d] + 0x18);
		        if (ABS(dVar6) < 9.223372036854776e+18) {
		          param5 = (longlong)dVar6;
		        }
		        else {
		          param5 = -0x8000000000000000;
		        }
		        param8 = (**(code **)((ulonglong)*(uint *)(*param1_01 + 0xf8) * 4))
		                           (param1_01,*(undefined4 *)(*param1_01 + 0xfc));
		        param1_00 = unnamed_function_1417
		                              (Core_Events_Scopes_ThemeDuelScope_BuyItemEventArgs_TypeInfo);
		        Core_Events_Scopes_ThemeDuelScope_OpenWindowEventArgs__get_OpenReasonSource
		                  (param1_00,uVar2,uVar3,param4,param5,param6,param7,param8,0);
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                  (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E45")]
		[Address(RVA = "0x6FC3", Offset = "0x6FC3", VA = "0x6FC3")]
		private void OnBuyEventShopItem(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x04001073 RID: 4211
		[Token(Token = "0x4001073")]
		[FieldOffset(Offset = "0x18")]
		private readonly ThemeDuelService _themeDuelService;

		// Token: 0x04001074 RID: 4212
		[Token(Token = "0x4001074")]
		[FieldOffset(Offset = "0x1C")]
		private NotEnoughTdScoreWindow _popup;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_StoreItemsInfo ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelShopController__set_StoreItemsInfo
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a585f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelShopController_OnGetEventStoreItemsInfo__
		              );
		    DAT_ram_00a585f8 = '\x01';
		  }
		  if (param1[8] == 0) {
		    uVar2 = ServicesNamespace_ThemeDuelService__GetThemeDuelState(param1[6],0);
		    param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelShopController_OnGetEventStoreItemsInfo__
		               ,0);
		    uVar2 = ServicesNamespace_MainService__GetUserStats
		                      (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x14);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		      return;
		    }
		  }
		  return;
		}
		*/

}
