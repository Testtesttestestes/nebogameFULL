using System;
using Gameplay.Clans.Buildings.Golem.Events;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Clans.Buildings.Golem.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Clans;
using UI;

namespace Gameplay.Clans.Buildings.Golem.Controller
{
	// Token: 0x02000ADD RID: 2781
	[Token(Token = "0x2000ADD")]
	public class GolemInfoViewMediator : AbstractViewMediator<GolemModel, GolemEvents, GolemController, GolemInfoWindow>
	{
		// Token: 0x060042FA RID: 17146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FA")]
		[Address(RVA = "0x91AE", Offset = "0x91AE", VA = "0x91AE")]
		public GolemInfoViewMediator(GolemModel model, GolemEvents events, GolemController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57a8f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__GolemEvents__GolemController__GolemInfoWindow__set_View__
		              );
		    DAT_ram_00a57a8f = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000D38 RID: 3384
		// (set) Token: 0x060042FB RID: 17147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D38")]
		public override GolemInfoWindow View
		{
			[Token(Token = "0x60042FB")]
			[Address(RVA = "0x91AF", Offset = "0x91AF", VA = "0x91AF", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060042FC RID: 17148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FC")]
		[Address(RVA = "0x91B0", Offset = "0x91B0", VA = "0x91B0")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  int iVar6;
		  longlong lVar7;
		  longlong lVar8;
		  undefined4 uVar9;
		  int *piVar10;
		  int iVar11;
		  int iVar12;
		  uint uVar13;
		  int *piVar14;
		  uint uVar15;
		  
		  if (DAT_ram_00a57a91 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__GolemEvents__GolemController__GolemInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_GolemEquipmentSlotConfig__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUnregisterClanAns__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentSlotConfig_GolemEquipmentSlotIds__get_EquipmentSlotId__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentSlotConfig_GolemEquipmentSlotIds__get_Slot__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_GolemEquipmentSlotConfig__GetSlots__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_GolemEquipmentSlotConfig__add_SlotClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_ArmoryButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_ChestButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_ClansServiceOnClanUnregisteredEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_ClansServiceOnUserLeftClanEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_EquipmentViewOnSlotClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_InfoButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_UpgradeButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_WarStatusButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountHandler_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClansService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57a91 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ClansService___);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar9 = *(undefined4 *)(*(int *)(iVar2 + 100) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_InfoButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar9,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar9 = *(undefined4 *)(iVar2 + 0x40);
		  uVar3 = unnamed_function_1417(System_Action_GolemEquipmentSlotConfig__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_EquipmentViewOnSlotClickedEventHandler__
		             ,0);
		  Gameplay_UserInfo_View_Equipment_BaseEquipmentView_object___SlotOnClickEvent
		            (uVar9,uVar3,
		             Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_GolemEquipmentSlotConfig__add_SlotClickedEvent__
		            );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar9 = *(undefined4 *)(iVar2 + 0x5c);
		  uVar3 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_ChestButtonClickedEventHandler__
		             ,0);
		  UI_IndexButtonBasic__get_CanvasGroup(uVar9,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar9 = *(undefined4 *)(iVar2 + 0x58);
		  uVar3 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_UpgradeButtonClickedEventHandler__
		             ,0);
		  UI_IndexButtonBasic__get_CanvasGroup(uVar9,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar9 = *(undefined4 *)(iVar2 + 0x54);
		  uVar3 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_WarStatusButtonClickedEventHandler__
		             ,0);
		  UI_IndexButtonBasic__get_CanvasGroup(uVar9,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar9 = *(undefined4 *)(iVar2 + 0x60);
		  uVar3 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_ArmoryButtonClickedEventHandler__
		             ,0);
		  UI_IndexButtonBasic__get_CanvasGroup(uVar9,uVar3,0);
		  uVar3 = unnamed_function_1417(System_Action_ProtoUserLeftClanEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_ClansServiceOnUserLeftClanEvent__
		             ,0);
		  ServicesNamespace_ClansService__remove_TreasuryChangedEvent(uVar1,uVar3,0);
		  uVar3 = unnamed_function_1417(System_Action_ProtoUnregisterClanAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_ClansServiceOnClanUnregisteredEvent__
		             ,0);
		  ServicesNamespace_ClansService__remove_ClanCreatedEvent(uVar1,uVar3,0);
		  lVar7 = Gameplay_World_Model_ClanData__set_ClanCultDic
		                    (*(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x10) + 0x10) + 0x30),0);
		  lVar8 = Core_Data_UserData___ctor(*(undefined4 *)(param1[2] + 8),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x5c),0);
		  uVar15 = (uint)(lVar7 == lVar8);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,uVar15,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x54),0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar10 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar10;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar13 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar13 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar13 * 8 + 4) * 8 + iVar2 + 0x230);
		        goto code_r0x80e1ae66;
		      }
		      uVar13 = uVar13 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar13);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar10,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e1ae66:
		  iVar2 = 0;
		  iVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar10,puVar4[1]);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(*(int *)(*(int *)(iVar5 + 0x10) + 0x20) != 0),0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar5 + 0x58),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,uVar15,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar5 + 0x60),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,uVar15,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = Gameplay_UserInfo_View_Equipment_BaseEquipmentView_object___Awake
		                    (*(undefined4 *)(iVar5 + 0x40),
		                     Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_GolemEquipmentSlotConfig__GetSlots__
		                    );
		  if (0 < *(int *)(iVar5 + 0xc)) {
		    do {
		      iVar11 = *(int *)(iVar5 + iVar2 * 4 + 0x10);
		      uVar3 = *(undefined4 *)(iVar11 + 0xc);
		      uVar1 = Gameplay_Clans_Buildings_Golem_Model_GolemModel__set_GolemSkills(param1[2],0);
		      UnityEngine_Object__op_Implicit(uVar3,uVar1,0);
		      iVar6 = Gameplay_Inventory_View_EquipmentSlotView__set_ArtifactViewArgs
		                        (*(undefined4 *)(iVar11 + 0xc),0);
		      piVar10 = *(int **)(param1[2] + 0xc);
		      iVar12 = *piVar10;
		      if (*(ushort *)(iVar12 + 0xb6) != 0) {
		        uVar15 = 0;
		        do {
		          piVar14 = (int *)(*(int *)(iVar12 + 0x58) + uVar15 * 8);
		          if (Core_Dict_IDictProvider_TypeInfo == *piVar14) {
		            puVar4 = (uint *)(piVar14[1] * 8 + iVar12 + 0xd0);
		            goto code_r0x80e1afaa;
		          }
		          uVar15 = uVar15 + 1;
		        } while (*(ushort *)(iVar12 + 0xb6) != uVar15);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar10,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e1afaa:
		      uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar10,puVar4[1]);
		      uVar1 = Core_Extensions_Dict_DictExt__GetAccountOptionsDicByOptionId
		                        (uVar1,*(undefined4 *)(iVar11 + 8),0);
		      uVar1 = Core_Extensions_Dict_UserSlotsDicExt__GetUserTitle(uVar1,0);
		      *(undefined4 *)(iVar6 + 0x28) = uVar1;
		      iVar2 = iVar2 + 1;
		    } while (iVar2 < *(int *)(iVar5 + 0xc));
		  }
		  iVar2 = *param1;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x148) * 4))
		                    (param1,*(undefined4 *)(iVar2 + 0x14c));
		  Gameplay_Clans_Buildings_Golem_Controller_GolemController___ctor(uVar1,iVar2);
		  piVar10 = *(int **)(param1[2] + 0x24);
		  if (piVar10 != (int *)0x0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = *(undefined4 *)(iVar2 + 0x58);
		    uVar15 = 0;
		    iVar2 = *piVar10;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Discounts_Model_IDiscountHandler_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar15 * 8)) {
		          puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar15 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e1b096;
		        }
		        uVar15 = uVar15 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar15);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar10,Gameplay_Discounts_Model_IDiscountHandler_TypeInfo,0);
		code_r0x80e1b096:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar10,uVar1,puVar4[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060042FD RID: 17149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FD")]
		[Address(RVA = "0x91B1", Offset = "0x91B1", VA = "0x91B1")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator__SetupView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1_00,3,0);
		  return;
		}
		*/

		}

		// Token: 0x060042FE RID: 17150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FE")]
		[Address(RVA = "0x91B2", Offset = "0x91B2", VA = "0x91B2")]
		private void ClansServiceOnClanUnregisteredEvent(ProtoUnregisterClanAns ans)
		{
		/* --- GHIDRA: ClansServiceOnClanUnregisteredEvent ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator__ClansServiceOnClanUnregisteredEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  longlong lVar1;
		  longlong lVar2;
		  
		  if (DAT_ram_00a57a92 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__GolemEvents__GolemController__GolemInfoWindow__get_Model__
		              );
		    DAT_ram_00a57a92 = '\x01';
		  }
		  lVar2 = *(longlong *)(param2 + 0x10);
		  lVar1 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(param1[2] + 8),0);
		  if (lVar2 == lVar1) {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1_00,3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060042FF RID: 17151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FF")]
		[Address(RVA = "0x91B3", Offset = "0x91B3", VA = "0x91B3")]
		private void ClansServiceOnUserLeftClanEvent(ProtoUserLeftClanEvt evt)
		{
		/* --- GHIDRA: ClansServiceOnUserLeftClanEvent ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator__ClansServiceOnUserLeftClanEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a57a93 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__GolemEvents__GolemController__GolemInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_ClanEquipment_View_ClanEquipmentWindow_ClanEquipmentWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_12685);
		    DAT_ram_00a57a93 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_WorldAxis_ClanEquipment_View_ClanEquipmentWindow_ClanEquipmentWindowArgs_TypeInfo
		                        );
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  iVar2 = *(int *)(param1 + 8);
		  *(undefined4 *)(param1_00 + 0x18) = *(undefined4 *)(iVar2 + 8);
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(iVar2 + 0x1c);
		  UI_Windows_PopupController__set_TopWindow(uVar1,StringLiteral_12685,param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004300 RID: 17152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004300")]
		[Address(RVA = "0x91B4", Offset = "0x91B4", VA = "0x91B4")]
		private void ArmoryButtonClickedEventHandler(IndexButtonBasic btn)
		{
		/* --- GHIDRA: ArmoryButtonClickedEventHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator__ArmoryButtonClickedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a57a94 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__GolemEvents__GolemController__GolemInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57a94 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x240);
		        goto code_r0x80e1b23e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x30);
		code_r0x80e1b23e:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_ClanWarsManager__GetGolemRestorePriceByLevel
		            (param1_00,*(undefined4 *)(param1 + 8),0);
		  return;
		}
		*/

		}

		// Token: 0x06004301 RID: 17153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004301")]
		[Address(RVA = "0x91B5", Offset = "0x91B5", VA = "0x91B5")]
		private void WarStatusButtonClickedEventHandler(IndexButtonBasic op)
		{
		/* --- GHIDRA: WarStatusButtonClickedEventHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator__WarStatusButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int param2_00;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined4 param1_02;
		  int *param1_03;
		  int iVar3;
		  
		  if (DAT_ram_00a57a95 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_ArtifactFilterDelegate_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__5040BDD3189631E842B21E138E6A6238786385C19CE5CE99C3ED6D605A5D5014
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator___c__DisplayClass9_0__EquipmentViewOnSlotClickedEventHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator___c__DisplayClass9_0_TypeInfo
		              );
		    DAT_ram_00a57a95 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator___c__DisplayClass9_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 8) = param2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_03 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_03;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x238);
		        goto code_r0x80e1b351;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_03,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x80e1b351:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_03,puVar2[1]);
		  param1_01 = Mono_Security_ASN1Convert__ToOid
		                        (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,3);
		  System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		            (param1_01,
		             Field__PrivateImplementationDetails__5040BDD3189631E842B21E138E6A6238786385C19CE5CE99C3ED6D605A5D5014
		             ,0);
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,1);
		  *(undefined4 *)(iVar3 + 0x10) = 0x22;
		  param1_02 = unnamed_function_1417
		                        (
		                        Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_ArtifactFilterDelegate_TypeInfo
		                        );
		  Gameplay_Inventory_View_Chest_InventoryChestWindowOptions___ctor
		            (param1_02,param2_00,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator___c__DisplayClass9_0__EquipmentViewOnSlotClickedEventHandler_b__0__
		             ,0);
		  Core_Gameplay_Managers_Inventory_GolemInventoryManager__Init
		            (param1_00,param1_01,iVar3,param1_02,0);
		  return;
		}
		*/

		}

		// Token: 0x06004302 RID: 17154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004302")]
		[Address(RVA = "0x91B6", Offset = "0x91B6", VA = "0x91B6")]
		private void EquipmentViewOnSlotClickedEventHandler(GolemEquipmentSlotConfig slotConfig)
		{
		/* --- GHIDRA: EquipmentViewOnSlotClickedEventHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator__EquipmentViewOnSlotClickedEventHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a57a96 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57a96 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x238);
		        goto code_r0x80e1b47d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x80e1b47d:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_Inventory_GolemInventoryManager__Init(param1_00,0,0,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004303 RID: 17155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004303")]
		[Address(RVA = "0x91B7", Offset = "0x91B7", VA = "0x91B7")]
		private void ChestButtonClickedEventHandler(IndexButtonBasic btn)
		{
		/* --- GHIDRA: ChestButtonClickedEventHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator__ChestButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = *param1;
		  if (*(char *)(*(int *)(iVar1 + 0x50) + 0x14) == '\0') {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x148) * 4))
		                          (param1,*(undefined4 *)(iVar2 + 0x14c));
		    Gameplay_Clans_Buildings_Golem_Controller_GolemController__GetGolemInfo(param1_00,param1);
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar2 + 0x15c));
		  Gameplay_UserInfo_View_BaseInfoBox__get_Visible(*(undefined4 *)(iVar1 + 0x50),0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004304 RID: 17156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004304")]
		[Address(RVA = "0x91B8", Offset = "0x91B8", VA = "0x91B8")]
		private void InfoButtonClickedEventHandler()
		{
		/* --- GHIDRA: InfoButtonClickedEventHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator__InfoButtonClickedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57a97 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__GolemEvents__GolemController__GolemInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_Golem_View_GolemWindow_GolemWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12586);
		    DAT_ram_00a57a97 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param4 = *(undefined4 *)(*(int *)(param1 + 8) + 0x1c);
		  param2_00 = *(undefined4 *)(*(int *)(param1 + 8) + 0x10);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Clans_Buildings_Golem_View_GolemWindow_GolemWindowArgs_TypeInfo);
		  Gameplay_Clans_Buildings_Golem_View_GolemWindow___ctor(param1_00,param2_00,3,param4,0);
		  UI_Windows_PopupController__set_TopWindow(uVar1,StringLiteral_12586,param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004305 RID: 17157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004305")]
		[Address(RVA = "0x91B9", Offset = "0x91B9", VA = "0x91B9")]
		private void UpgradeButtonClickedEventHandler(IndexButtonBasic btn)
		{
		/* --- GHIDRA: UpgradeButtonClickedEventHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator__UpgradeButtonClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57a98 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__GolemEvents__GolemController__GolemInfoWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_EquipmentChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_GolemSkillsRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_GolemUserInfoRequestedEventHandler__
		              );
		    DAT_ram_00a57a98 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_GolemUserInfoRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_GolemSkillsRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = *(int *)(iVar1 + 0x14);
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_EquipmentChangedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_GolemUserInfoRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_GolemSkillsRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = *(int *)(iVar1 + 0x14);
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_EquipmentChangedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000D39 RID: 3385
		// (set) Token: 0x06004306 RID: 17158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D39")]
		public override GolemEvents Events
		{
			[Token(Token = "0x6004306")]
			[Address(RVA = "0x91BA", Offset = "0x91BA", VA = "0x91BA", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004307")]
		[Address(RVA = "0x91BB", Offset = "0x91BB", VA = "0x91BB")]
		private void EquipmentChangedEventHandler()
		{
		/* --- GHIDRA: EquipmentChangedEventHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator__EquipmentChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57a9a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__GolemEvents__GolemController__GolemInfoWindow__get_Model__
		              );
		    DAT_ram_00a57a9a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  *(undefined4 *)(*(int *)(iVar1 + 0x50) + 0x2c) = *(undefined4 *)(param1[2] + 0x1c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  *(undefined4 *)(*(int *)(iVar1 + 0x50) + 0x30) = *(undefined4 *)(param1[2] + 0x20);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_UserInfo_View_BaseInfoBox__get_Visible(*(undefined4 *)(iVar1 + 0x50),1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004308 RID: 17160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004308")]
		[Address(RVA = "0x91BC", Offset = "0x91BC", VA = "0x91BC")]
		private void GolemSkillsRequestedEventHandler()
		{
		/* --- GHIDRA: GolemSkillsRequestedEventHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator__GolemSkillsRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param3;
		  int iVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57a9b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__GolemEvents__GolemController__GolemInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_GolemEquipmentSlotConfig__set_Artifacts__
		              );
		    DAT_ram_00a57a9b = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = *(undefined4 *)(param1[2] + 0x1c);
		  param3 = Gameplay_Isles_Clan_Model_ClanIsleModel__get_GolemHasShield
		                     (*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x10),0);
		  Gameplay_Clans_Buildings_Golem_View_GolemInfoWindow__get_GolemEquipmentView
		            (param1_00,param2_00,param3,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_UserInfo_View_Equipment_BaseEquipmentView_object___remove_SlotClickedEvent
		            (*(undefined4 *)(iVar1 + 0x40),*(undefined4 *)(*(int *)(param1[2] + 0x14) + 0x2c),
		             Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_GolemEquipmentSlotConfig__set_Artifacts__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004309 RID: 17161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004309")]
		[Address(RVA = "0x91BD", Offset = "0x91BD", VA = "0x91BD")]
		private void GolemUserInfoRequestedEventHandler()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57a90 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_GolemEquipmentSlotConfig__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUnregisterClanAns__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_GolemEquipmentSlotConfig__remove_SlotClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_ArmoryButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_ChestButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_ClansServiceOnClanUnregisteredEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_ClansServiceOnUserLeftClanEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_EquipmentViewOnSlotClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_InfoButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_UpgradeButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_WarStatusButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClansService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57a90 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  param1_00 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                        (Method_Core_Net_ServiceFactory_GetService_ClansService___);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 100) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_InfoButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x40);
		  uVar2 = unnamed_function_1417(System_Action_GolemEquipmentSlotConfig__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_EquipmentViewOnSlotClickedEventHandler__
		             ,0);
		  Gameplay_UserInfo_View_Equipment_BaseEquipmentView___Il2CppFullySharedGenericType___get_Artifacts
		            (uVar3,uVar2,
		             Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_GolemEquipmentSlotConfig__remove_SlotClickedEvent__
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x5c);
		  uVar2 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_ChestButtonClickedEventHandler__
		             ,0);
		  UI_IndexButtonBasic__add_ClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x58);
		  uVar2 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_UpgradeButtonClickedEventHandler__
		             ,0);
		  UI_IndexButtonBasic__add_ClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x54);
		  uVar2 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_WarStatusButtonClickedEventHandler__
		             ,0);
		  UI_IndexButtonBasic__add_ClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x60);
		  uVar2 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_ArmoryButtonClickedEventHandler__
		             ,0);
		  UI_IndexButtonBasic__add_ClickEvent(uVar3,uVar2,0);
		  uVar2 = unnamed_function_1417(System_Action_ProtoUserLeftClanEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_ClansServiceOnUserLeftClanEvent__
		             ,0);
		  ServicesNamespace_ClansService__add_UserLeftClanEvent(param1_00,uVar2,0);
		  uVar2 = unnamed_function_1417(System_Action_ProtoUnregisterClanAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_ClansServiceOnClanUnregisteredEvent__
		             ,0);
		  ServicesNamespace_ClansService__add_ClanUnregisteredEvent(param1_00,uVar2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57a99 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__GolemEvents__GolemController__GolemInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_GolemEquipmentSlotConfig__set_Artifacts__
		              );
		    DAT_ram_00a57a99 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_UserInfo_View_Equipment_BaseEquipmentView_object___remove_SlotClickedEvent
		            (*(undefined4 *)(iVar1 + 0x40),0,
		             Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_GolemEquipmentSlotConfig__set_Artifacts__
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_UserInfo_View_Equipment_BaseEquipmentView_object___remove_SlotClickedEvent
		            (*(undefined4 *)(iVar1 + 0x40),*(undefined4 *)(*(int *)(param1[2] + 0x14) + 0x2c),
		             Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_GolemEquipmentSlotConfig__set_Artifacts__
		            );
		  return;
		}
		*/

}
