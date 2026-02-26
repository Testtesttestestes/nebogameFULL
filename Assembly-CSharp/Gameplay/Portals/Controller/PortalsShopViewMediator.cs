using System;
using System.Collections.Generic;
using Gameplay.Inventory.View;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Gameplay.Portals.View.ShopTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using UI;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005E2 RID: 1506
	[Token(Token = "0x20005E2")]
	public class PortalsShopViewMediator : AbstractViewMediator<PortalsShopModel, PortalsEvents, PortalsShopController, PortalsShopView>, IHideableMediator
	{
		// Token: 0x0600245A RID: 9306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245A")]
		[Address(RVA = "0x75A8", Offset = "0x75A8", VA = "0x75A8")]
		public PortalsShopViewMediator(PortalsShopModel model, PortalsEvents events, PortalsShopController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_Controller_PortalsShopViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57d13 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsShopModel__PortalsEvents__PortalsShopController__PortalsShopView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsShopViewMediator_FiltersViewChangedEventHandler__
		              );
		    DAT_ram_00a57d13 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x30);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Portals_Controller_PortalsShopViewMediator_FiltersViewChangedEventHandler__
		               ,0);
		    UI_Filters_FiltersView__add_ChangedEvent(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Portals_Controller_PortalsShopViewMediator__Hide(param1,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x30);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Portals_Controller_PortalsShopViewMediator_FiltersViewChangedEventHandler__
		               ,0);
		    UI_Filters_FiltersView__get_PriceFilterButton(uVar3,uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x170006D5 RID: 1749
		// (set) Token: 0x0600245B RID: 9307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D5")]
		public override PortalsShopView View
		{
			[Token(Token = "0x600245B")]
			[Address(RVA = "0x75A9", Offset = "0x75A9", VA = "0x75A9", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245C")]
		[Address(RVA = "0x75AA", Offset = "0x75AA", VA = "0x75AA", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_Portals_Controller_PortalsShopViewMediator__Hide(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57d15 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsShopModel__PortalsEvents__PortalsShopController__PortalsShopView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IArtifactView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsShopViewMediator_BuyShopItem__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsShopViewMediator_GetStoreItemsHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsShopViewMediator_UserInfoChangedHandler__)
		    ;
		    DAT_ram_00a57d15 = '\x01';
		  }
		  uVar5 = *(undefined4 *)
		           (*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 4);
		  uVar1 = unnamed_function_1417(System_Action_IArtifactView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Portals_Controller_PortalsShopViewMediator_BuyShopItem__,0
		            );
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  uVar1 = System_Action_IArtifactView__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 4)
		         = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_IArtifactView__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 4) = iVar3
		    ;
		    uVar1 = System_Action_IArtifactView__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_IArtifactView__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar3 + 0x2c);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Portals_Controller_PortalsShopViewMediator_GetStoreItemsHandler__,0);
		  piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(iVar3 + 0x2c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar4) ||
		          (*(int **)(iVar3 + 0x2c) = piVar4, *piVar4 != iVar2)) {
		    System_Activator__CreateInstance(piVar4,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar3 + 0x28);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Portals_Controller_PortalsShopViewMediator_UserInfoChangedHandler__,0);
		  piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(iVar3 + 0x28) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar4) ||
		          (*(int **)(iVar3 + 0x28) = piVar4, *piVar4 != iVar2)) {
		    System_Activator__CreateInstance(piVar4,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Portals_Controller_PortalsShopController___ctor(uVar1,param1);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  Gameplay_Portals_Controller_PortalsShopViewMediator__PopupOnClose(param1,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(iVar2 + 0x34);
		  uVar1 = Gameplay_Portals_Model_PortalsShopModel__get_FilterType(param1[2],0);
		  UI_Filters_MetaFiltersView__set_FilterType(uVar5,0x20,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600245D RID: 9309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245D")]
		[Address(RVA = "0x75AB", Offset = "0x75AB", VA = "0x75AB")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Portals_Controller_PortalsShopViewMediator__SetupView
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  ulonglong uVar3;
		  int *param1_01;
		  int iVar4;
		  undefined4 param2_00;
		  uint uVar5;
		  
		  if (DAT_ram_00a57d16 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsShopModel__PortalsEvents__PortalsShopController__PortalsShopView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&UI_NotEnoughPortalsScoreWindow_NotEnoughPortalsScoreWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_NotEnoughPortalsScoreWindow___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsShopViewMediator_PopupOnClose__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12657);
		    DAT_ram_00a57d16 = '\x01';
		  }
		  param1_01 = *(int **)(param1[2] + 0xc);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar5 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0x290);
		        goto code_r0x80e4be5a;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80e4be5a:
		  uVar5 = 0;
		  iVar4 = (**(code **)((ulonglong)*puVar1 * 4))(param1_01,puVar1[1]);
		  uVar3 = Gameplay_Portals_Model_PortalsModel__set_EntryPointBackTime
		                    (*(undefined4 *)(iVar4 + 0x10),0);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80e4bee5;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x80e4bee5:
		  iVar4 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  if ((double)uVar3 < *(double *)(*(int *)(*(int *)(iVar4 + 0x74) + 0x24) + 0x28)) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		    param2_00 = *(undefined4 *)(param1[2] + 0x10);
		    param1_00 = unnamed_function_1417
		                          (UI_NotEnoughPortalsScoreWindow_NotEnoughPortalsScoreWindowArgs_TypeInfo);
		    UI_NotEnoughPortalsScoreWindow___ctor(param1_00,param2_00,0);
		    iVar4 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                      (uVar2,StringLiteral_12657,param1_00,
		                       Method_UI_Windows_PopupController_Show_NotEnoughPortalsScoreWindow___);
		    param1[6] = iVar4;
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Portals_Controller_PortalsShopViewMediator_PopupOnClose__,0);
		    UI_Windows_BaseWindow__get_IsActiveResourceBar(iVar4,uVar2,0);
		    return;
		  }
		  iVar4 = *param1;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x148) * 4))
		                    (param1,*(undefined4 *)(iVar4 + 0x14c));
		  Gameplay_Portals_Controller_PortalsShopController__OnGetStoreItemsInfo(uVar2,param2,iVar4);
		  return;
		}
		*/

		}

		// Token: 0x0600245E RID: 9310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245E")]
		[Address(RVA = "0x75AC", Offset = "0x75AC", VA = "0x75AC")]
		private void BuyShopItem(IArtifactView item)
		{
		/* --- GHIDRA: BuyShopItem ---
		void Gameplay_Portals_Controller_PortalsShopViewMediator__BuyShopItem(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57d17 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsShopViewMediator_PopupOnClose__);
		    DAT_ram_00a57d17 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Portals_Controller_PortalsShopViewMediator_PopupOnClose__,0);
		  UI_Windows_BaseWindow__add_onClose(param1_01,param1_00,0);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600245F RID: 9311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245F")]
		[Address(RVA = "0x75AD", Offset = "0x75AD", VA = "0x75AD")]
		private void PopupOnClose()
		{
		/* --- GHIDRA: PopupOnClose ---
		void Gameplay_Portals_Controller_PortalsShopViewMediator__PopupOnClose
		               (int *param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 param1_00;
		  uint uVar5;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57d18 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsShopModel__PortalsEvents__PortalsShopController__PortalsShopView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_UI_LayoutRebuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22116);
		    DAT_ram_00a57d18 = '\x01';
		  }
		  piVar3 = *(int **)(param1[2] + 0xc);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar5 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80e4ba03;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e4ba03:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  local_8 = Core_Extensions_Dict_DictExt__GetDoubleParameter(uVar2,StringLiteral_22116,0);
		  local_c = 1;
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar4 + 0x38);
		  uVar2 = Core_Extensions_Dict_PortalDicExt__GetAssetId
		                    (*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x3c),0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,uVar2,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar3 = *(int **)(iVar4 + 0x24);
		  uVar2 = UnityEngine_GameObject__SetActive(&local_8,0);
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		            (piVar3,uVar2,*(undefined4 *)(iVar4 + 0x2d4));
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar3 = *(int **)(iVar4 + 0x28);
		  uVar2 = func_ii_4443(&local_c,0);
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		            (piVar3,uVar2,*(undefined4 *)(iVar4 + 0x2d4));
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = func_ii_7305(*(undefined4 *)(iVar4 + 0x2c),0);
		  if (iVar4 != 0) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = *(undefined4 *)(iVar4 + 0x20);
		    if (*(int *)(UnityEngine_UI_LayoutRebuilder_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_UI_LayoutRebuilder_TypeInfo);
		    }
		    UnityEngine_UI_LayoutRebuilder__StripDisabledBehavioursFromList(uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002460 RID: 9312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002460")]
		[Address(RVA = "0x75AE", Offset = "0x75AE", VA = "0x75AE")]
		private void UpdateMessage()
		{
		/* --- GHIDRA: UpdateMessage ---
		void Gameplay_Portals_Controller_PortalsShopViewMediator__UpdateMessage
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57d19 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsShopModel__PortalsEvents__PortalsShopController__PortalsShopView__get_Model__
		              );
		    DAT_ram_00a57d19 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Portals_View_ShopTab_PortalsShopView__StopCurrentCoroutine
		            (param1_00,*(undefined4 *)(param1[2] + 0x14),0);
		  return;
		}
		*/

		}

		// Token: 0x06002461 RID: 9313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002461")]
		[Address(RVA = "0x75AF", Offset = "0x75AF", VA = "0x75AF")]
		private void UserInfoChangedHandler()
		{
		/* --- GHIDRA: UserInfoChangedHandler ---
		void Gameplay_Portals_Controller_PortalsShopViewMediator__UserInfoChangedHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param2_00;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57d1a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsShopModel__PortalsEvents__PortalsShopController__PortalsShopView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57d1a = '\x01';
		  }
		  param2_00 = *(undefined4 *)(param1[2] + 0x14);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Portals_View_ShopTab_PortalsShopView__StopCurrentCoroutine(uVar2,param2_00,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(int **)(param1[2] + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x290);
		        goto code_r0x80e4c11a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80e4c11a:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  Gameplay_Portals_View_ShopTab_PortalsShopView__Init(uVar2,*(undefined4 *)(iVar4 + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x06002462 RID: 9314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002462")]
		[Address(RVA = "0x75B0", Offset = "0x75B0", VA = "0x75B0")]
		private void GetStoreItemsHandler()
		{
		/* --- GHIDRA: GetStoreItemsHandler ---
		/* WARNING: Removing unreachable block (ram,0x80e4c8f0) */
		
		undefined4
		Gameplay_Portals_Controller_PortalsShopViewMediator__GetStoreItemsHandler
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 *puVar6;
		  int iVar7;
		  int *piVar8;
		  undefined4 param1_00;
		  int *piVar9;
		  int iVar10;
		  int *piVar11;
		  int local_44;
		  int **local_40;
		  int local_3c;
		  undefined1 *local_38;
		  int local_34;
		  undefined8 *puStack_30;
		  undefined8 local_2c;
		  int *local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57d1b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ShopItemData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArtikulTypeFilters__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArtikulTypeFilters__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ShopItemData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArtikulTypeFilters__get_Current__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ShopItemData__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ShopItemData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ShopItemData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtikulTypeFilters__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ShopItemData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtikulTypeFilters__get_Count__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtikulTypeFilters__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ShopItemData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__);
		    DAT_ram_00a57d1b = '\x01';
		  }
		  local_18 = 0;
		  local_20 = 0;
		  local_24 = (int *)0x0;
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(*(int *)(iVar4 + 0x30) + 0x38),6,
		                     Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		                    );
		  piVar9 = *(int **)(iVar4 + 0xc);
		  if (piVar9 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar9 + 0xb8) <
		         (uint)*(byte *)(System_Collections_Generic_List_ArtikulTypeFilters__TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar9 + 100) +
		                 (uint)*(byte *)(System_Collections_Generic_List_ArtikulTypeFilters__TypeInfo + 0xb8
		                                ) * 4 + -4) !=
		        System_Collections_Generic_List_ArtikulTypeFilters__TypeInfo)) {
		      System_Activator__CreateInstance
		                (piVar9,System_Collections_Generic_List_ArtikulTypeFilters__TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (piVar9[3] == 0) {
		    return param2;
		  }
		  iVar4 = unnamed_function_1417(System_Collections_Generic_List_ShopItemData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar4,Method_System_Collections_Generic_List_ShopItemData___ctor__);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_34,param2,Method_System_Collections_Generic_List_ShopItemData__GetEnumerator__);
		  local_8 = local_2c;
		  local_3c = 0;
		  local_38 = local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_ShopItemData__MoveNext__);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) break;
		    iVar10 = local_3c;
		    if (iVar5 == 0) goto code_r0x80e4c9f0;
		    DAT_ram_009d3e38 = 0;
		    iVar5 = local_8._4_4_;
		    System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		              (&local_34,piVar9,
		               Method_System_Collections_Generic_List_ArtikulTypeFilters__GetEnumerator__);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x80e4c9a9;
		    }
		    local_18 = local_2c;
		    local_20 = CONCAT44(puStack_30,local_34);
		    local_34 = 0;
		    puStack_30 = &local_20;
		    while( true ) {
		      DAT_ram_009d3e38 = 0;
		      iVar10 = import::env::invoke_iii
		                         (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_20,
		                          Method_System_Collections_Generic_List_Enumerator_ArtikulTypeFilters__MoveNext__
		                         );
		      if (DAT_ram_009d3e38 == 1) break;
		      iVar3 = 3;
		      if (iVar10 == 0) goto code_r0x80e4c8be;
		      DAT_ram_009d3e38 = 0;
		      piVar8 = (int *)import::env::invoke_iii
		                                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x55,
		                                 *(undefined4 *)(local_18._4_4_ + 0x18),
		                                 Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__
		                                );
		      if (DAT_ram_009d3e38 == 1) break;
		      local_44 = 0;
		      local_40 = &local_24;
		      local_24 = piVar8;
		      do {
		        piVar8 = local_24;
		        iVar10 = *local_24;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		              puVar6 = (undefined4 *)(iVar10 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x80e4c4d9;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar6 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_24,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e4c698;
		code_r0x80e4c4d9:
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_iii(*puVar6,piVar8,puVar6[1]);
		        piVar8 = local_24;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e4c698;
		        iVar3 = 9;
		        if (iVar10 == 0) {
		          bVar1 = false;
		          goto code_r0x80e4c732;
		        }
		        iVar10 = *local_24;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		            if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar11) {
		              puVar6 = (undefined4 *)(iVar10 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x80e4c5bf;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar6 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_24,
		                            System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e4c698;
		code_r0x80e4c5bf:
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iii(*puVar6,piVar8,puVar6[1]);
		        iVar10 = Method_System_Collections_Generic_List_ShopItemData__Add__;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e4c698;
		      } while (iVar7 != *(int *)(*(int *)(*(int *)(iVar5 + 0xc) + 0xc) + 0xc));
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      uVar2 = *(uint *)(iVar4 + 0xc);
		      if (*(uint *)(*(int *)(iVar4 + 8) + 0xc) <= uVar2) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar4,iVar5,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		        bVar1 = true;
		        if (DAT_ram_009d3e38 != 1) goto code_r0x80e4c732;
		code_r0x80e4c698:
		        DAT_ram_009d3e38 = 0;
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar10 == iVar3) {
		          piVar8 = (int *)import::env::__cxa_begin_catch(param1_00);
		          local_44 = *piVar8;
		          iVar3 = 0;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_v(0x123);
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          bVar1 = false;
		          if (iVar10 != 1) goto code_r0x80e4c732;
		          param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar10 = global_1;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x56,&local_44);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 != 1) goto code_r0x80e4c873;
		        goto code_r0x80e4ca48;
		      }
		      bVar1 = true;
		      *(uint *)(iVar4 + 0xc) = uVar2 + 1;
		      *(int *)(*(int *)(iVar4 + 8) + uVar2 * 4 + 0x10) = iVar5;
		code_r0x80e4c732:
		      piVar8 = *local_40;
		      if (piVar8 != (int *)0x0) {
		        iVar10 = *piVar8;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		            if (System_IDisposable_TypeInfo == *piVar11) {
		              puVar6 = (undefined4 *)(iVar10 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x80e4c7d2;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar6 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar8,
		                            System_IDisposable_TypeInfo,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x80e4c7d2:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii(*puVar6,piVar8,puVar6[1]);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x80e4c80e;
		        }
		        break;
		      }
		code_r0x80e4c80e:
		      if (local_44 != 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_44);
		        if (DAT_ram_009d3e38 == 1) break;
		        goto code_r0x80e4ca46;
		      }
		      if (((iVar3 != 0) &&
		          ((((iVar3 == 1 || (iVar3 == 2)) || (iVar3 == 3)) ||
		           ((((iVar3 == 4 || (iVar3 == 5)) || ((iVar3 == 6 || ((iVar3 == 7 || (iVar3 == 8)))))) ||
		            (iVar3 != 9)))))) || (iVar3 = 3, bVar1)) goto code_r0x80e4c8be;
		    }
		    DAT_ram_009d3e38 = 0;
		    param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar10 = global_1;
		code_r0x80e4c873:
		    iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar5 != iVar10) {
		code_r0x80e4c95e:
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x57,&local_34);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 != 1) goto code_r0x80e4c9a9;
		      goto code_r0x80e4ca48;
		    }
		    piVar8 = (int *)import::env::__cxa_begin_catch(param1_00);
		    local_34 = *piVar8;
		    iVar3 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x80e4c95e;
		    }
		code_r0x80e4c8be:
		    if (local_34 != 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_34);
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 != 1) {
		code_r0x80e4ca46:
		        do {
		          halt_trap();
		        } while( true );
		      }
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x80e4c9a9;
		    }
		    if ((iVar3 != 0) && (((iVar10 = local_3c, iVar3 == 1 || (iVar3 == 2)) || (iVar3 != 3))))
		    goto code_r0x80e4c9f0;
		  }
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar10 = global_1;
		code_r0x80e4c9a9:
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar10) {
		    piVar9 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar10 = *piVar9;
		    DAT_ram_009d3e38 = 0;
		    local_3c = iVar10;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x80e4c9f0:
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return iVar4;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar10);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x58,&local_3c);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 != 1) {
		    import::env::__resumeException(param1_00);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x80e4ca48:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002463 RID: 9315 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002463")]
		[Address(RVA = "0x75B1", Offset = "0x75B1", VA = "0x75B1")]
		private List<ShopItemData> FilterItems(List<ShopItemData> shopItems)
		{
		/* --- GHIDRA: FilterItems ---
		void Gameplay_Portals_Controller_PortalsShopViewMediator__FilterItems
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Portals_Controller_PortalsShopViewMediator__UserInfoChangedHandler(param1,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002464")]
		[Address(RVA = "0x75B2", Offset = "0x75B2", VA = "0x75B2")]
		private void FiltersViewChangedEventHandler()
		{
		/* --- GHIDRA: FiltersViewChangedEventHandler ---
		void Gameplay_Portals_Controller_PortalsShopViewMediator__FiltersViewChangedEventHandler
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  if (DAT_ram_00a57d1c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_PortalsTotalizatorModel__PortalsEvents___ctor__);
		    DAT_ram_00a57d1c = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_PortalsTotalizatorModel__PortalsEvents___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param4;
		  return;
		}
		*/

		}

		// Token: 0x04001400 RID: 5120
		[Token(Token = "0x4001400")]
		[FieldOffset(Offset = "0x18")]
		private NotEnoughPortalsScoreWindow _popup;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Portals_Controller_PortalsShopViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57d14 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IArtifactView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsShopViewMediator_BuyShopItem__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsShopViewMediator_GetStoreItemsHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsShopViewMediator_UserInfoChangedHandler__)
		    ;
		    DAT_ram_00a57d14 = '\x01';
		  }
		  uVar5 = *(undefined4 *)
		           (*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 4);
		  uVar1 = unnamed_function_1417(System_Action_IArtifactView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Portals_Controller_PortalsShopViewMediator_BuyShopItem__,0
		            );
		  iVar2 = func_ii_7048(uVar5,uVar1,0);
		  uVar1 = System_Action_IArtifactView__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 4)
		         = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_IArtifactView__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 4) = iVar3
		    ;
		    uVar1 = System_Action_IArtifactView__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_IArtifactView__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar2 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar3 + 0x2c);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Portals_Controller_PortalsShopViewMediator_GetStoreItemsHandler__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar1,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x2c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar3 + 0x2c) = piVar4, *piVar4 != iVar2)) {
		      System_Activator__CreateInstance(piVar4,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar3 + 0x28);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Portals_Controller_PortalsShopViewMediator_UserInfoChangedHandler__,0
		              );
		    piVar4 = (int *)func_ii_7048(uVar5,uVar1,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x28) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar3 + 0x28) = piVar4, *piVar4 != iVar2)) {
		      System_Activator__CreateInstance(piVar4,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		            (param1,0,*(undefined4 *)(*param1 + 0x144));
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

}
