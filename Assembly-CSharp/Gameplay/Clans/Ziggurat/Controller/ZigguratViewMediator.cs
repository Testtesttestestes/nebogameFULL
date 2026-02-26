using System;
using System.Runtime.CompilerServices;
using Gameplay.Clans.Buildings.Ziggurat.View;
using Gameplay.Isles.Clan.Controller;
using Gameplay.Isles.Clan.Events;
using Gameplay.Isles.Clan.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Clans;
using UI;

namespace Gameplay.Clans.Ziggurat.Controller
{
	// Token: 0x02000AA9 RID: 2729
	[Token(Token = "0x2000AA9")]
	public class ZigguratViewMediator : AbstractViewMediator<ClanIsleModel, ClanIsleEvents, ClanIsleController, ZigguratWindow>
	{
		// Token: 0x060041DB RID: 16859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DB")]
		[Address(RVA = "0x908F", Offset = "0x908F", VA = "0x908F")]
		public ZigguratViewMediator(ClanIsleModel model, ClanIsleEvents events, ClanIsleController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a577df == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ZigguratWindow__set_View__
		              );
		    DAT_ram_00a577df = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000CF6 RID: 3318
		// (set) Token: 0x060041DC RID: 16860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF6")]
		public override ZigguratWindow View
		{
			[Token(Token = "0x60041DC")]
			[Address(RVA = "0x9090", Offset = "0x9090", VA = "0x9090", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DD")]
		[Address(RVA = "0x9091", Offset = "0x9091", VA = "0x9091")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int param1_01;
		  int *param1_02;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a577e1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ZigguratWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUnregisterClanAns__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BaseBuildingData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountHandler_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_MainBuildingView_ClanIsle__get_BuildingItems__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClansService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_ClansServiceOnClanUnregisteredEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_ClansServiceOnUserLeftClanEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_InClanButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_ItemOnActionButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_ItemOnClickedEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_RepairButtonClickedEventHandler__
		              );
		    DAT_ram_00a577e1 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  param1_00 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                        (Method_Core_Net_ServiceFactory_GetService_ClansService___);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(iVar2 + 0x48);
		  uVar3 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_InClanButtonClickedEventHandler__
		             ,0);
		  UI_IndexButtonBasic__get_CanvasGroup(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x54) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_RepairButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x40) + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      param1_01 = *(int *)(iVar2 + iVar6 * 4 + 0x10);
		      uVar3 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(param1[2] + 0x24),*(undefined4 *)(param1_01 + 0x38),
		                         Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                        );
		      UI_Windows_Buildings_BaseBuildingItemView__OnDestroy
		                (param1_01,uVar3,*(undefined4 *)(*(int *)(param1[2] + 0x30) + 0x14),
		                 *(undefined4 *)(param1[2] + 8),0);
		      uVar3 = unnamed_function_1417(System_Action_BaseBuildingData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,
		                 Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_ItemOnActionButtonClickedEvent__
		                 ,0);
		      UI_Windows_Buildings_BaseBuildingItemView__get_Price(param1_01,uVar3,0);
		      uVar3 = unnamed_function_1417(System_Action_BaseBuildingData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,
		                 Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_ItemOnClickedEvent__
		                 ,0);
		      UI_Windows_Buildings_BaseBuildingItemView__remove_ActionButtonClickedEvent(param1_01,uVar3,0);
		      param1_02 = *(int **)(param1[2] + 0x20);
		      if (param1_02 != (int *)0x0) {
		        iVar7 = *param1_02;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		            if (Gameplay_Discounts_Model_IDiscountHandler_TypeInfo == *piVar8) {
		              puVar4 = (uint *)(iVar7 + piVar8[1] * 8 + 0xc0);
		              goto code_r0x80de0587;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar4 = (uint *)func_ii_1080(param1_02,Gameplay_Discounts_Model_IDiscountHandler_TypeInfo,0
		                                     );
		code_r0x80de0587:
		        (**(code **)((ulonglong)*puVar4 * 4))(param1_02,param1_01,puVar4[1]);
		      }
		      iVar6 = iVar6 + 1;
		    } while (iVar6 < *(int *)(iVar2 + 0xc));
		  }
		  uVar3 = unnamed_function_1417(System_Action_ProtoUserLeftClanEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_ClansServiceOnUserLeftClanEvent__
		             ,0);
		  ServicesNamespace_ClansService__remove_TreasuryChangedEvent(param1_00,uVar3,0);
		  uVar3 = unnamed_function_1417(System_Action_ProtoUnregisterClanAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_ClansServiceOnClanUnregisteredEvent__
		             ,0);
		  ServicesNamespace_ClansService__remove_ClanCreatedEvent(param1_00,uVar3,0);
		  Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator__ItemOnActionButtonClickedEvent
		            (param1,uVar3);
		  return;
		}
		*/

		}

		// Token: 0x060041DE RID: 16862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DE")]
		[Address(RVA = "0x9092", Offset = "0x9092", VA = "0x9092")]
		private void SetupView()
		{
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DF")]
		[Address(RVA = "0x9093", Offset = "0x9093", VA = "0x9093")]
		private void ClansServiceOnClanUnregisteredEvent(ProtoUnregisterClanAns ans)
		{
		/* --- GHIDRA: ClansServiceOnClanUnregisteredEvent ---
		void Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator__ClansServiceOnClanUnregisteredEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  longlong lVar1;
		  longlong lVar2;
		  
		  if (DAT_ram_00a577e2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ZigguratWindow__get_Model__
		              );
		    DAT_ram_00a577e2 = '\x01';
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

		// Token: 0x060041E0 RID: 16864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E0")]
		[Address(RVA = "0x9094", Offset = "0x9094", VA = "0x9094")]
		private void ClansServiceOnUserLeftClanEvent(ProtoUserLeftClanEvt evt)
		{
		/* --- GHIDRA: ClansServiceOnUserLeftClanEvent ---
		void Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator__ClansServiceOnUserLeftClanEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Isles_Clan_Controller_ClanIsleController__CancelBuild(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E1")]
		[Address(RVA = "0x9095", Offset = "0x9095", VA = "0x9095")]
		private void RepairButtonClickedEventHandler()
		{
		/* --- GHIDRA: RepairButtonClickedEventHandler ---
		void Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator__RepairButtonClickedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a577e3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ZigguratWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a577e3 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x230);
		        goto code_r0x80de0bd0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80de0bd0:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))
		                        (param1_01,CONCAT44(in_register_20000014,puVar2[1]));
		  Core_Gameplay_Managers_ClansManager__DissociateClanFromUser
		            (param1_00,
		             *(undefined8 *)(*(int *)(*(int *)(*(int *)(param1 + 8) + 0x30) + 0x1c) + 0x10),0,0);
		  return;
		}
		*/

		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E2")]
		[Address(RVA = "0x9096", Offset = "0x9096", VA = "0x9096")]
		private void InClanButtonClickedEventHandler(IndexButtonBasic _)
		{
		/* --- GHIDRA: InClanButtonClickedEventHandler ---
		void Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator__InClanButtonClickedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a577e4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ZigguratWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a577e4 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x80de0cbc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80de0cbc:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,CONCAT44(in_register_20000014,puVar2[1]));
		  param2_00 = *(undefined8 *)(param1[2] + 0x10);
		  piVar5 = (int *)Gameplay_World_Model_WorldModel__GetUserIsle
		                            (*(undefined4 *)(iVar6 + 0x14),param2_00,0);
		  uVar4 = (undefined4)((ulonglong)param2_00 >> 0x20);
		  uVar3 = UnityEngine_AndroidJavaObject___GetRawObject(param2,0);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x118) * 4))
		                    (piVar5,CONCAT44(uVar4,uVar3),*(undefined4 *)(*piVar5 + 0x11c));
		  if (iVar6 != 0) {
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(uVar4,2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060041E3 RID: 16867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E3")]
		[Address(RVA = "0x9097", Offset = "0x9097", VA = "0x9097")]
		private void ItemOnClickedEvent(BaseBuildingData buildingData)
		{
		/* --- GHIDRA: ItemOnClickedEvent ---
		void Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator__ItemOnClickedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int param2_00;
		  int iVar2;
		  float fVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  double param3_00;
		  int *piVar7;
		  int iVar8;
		  uint uVar9;
		  undefined4 uVar10;
		  
		  if (DAT_ram_00a577e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator___c__DisplayClass10_0__ItemOnActionButtonClickedEvent_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator___c__DisplayClass10_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_25458);
		    DAT_ram_00a577e5 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator___c__DisplayClass10_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int **)(param2_00 + 8) = param1;
		  iVar2 = func_ii_8742(param2,0);
		  if (iVar2 == 0) {
		    uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c)));
		    uVar10 = *(undefined4 *)(param2_00 + 0xc);
		    uVar6 = UnityEngine_AndroidJavaObject___GetRawObject(uVar10,0);
		    Gameplay_Isles_Clan_Controller_ClanIsleController__SetIsleInformation(uVar5,uVar10,uVar6,0);
		    return;
		  }
		  iVar2 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding
		                    (*(undefined4 *)(param2_00 + 0xc),0);
		  fVar3 = func_ii_7103(*(undefined4 *)(*(int *)(param2_00 + 0xc) + 0x14),0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 + iVar8 + 0x178);
		        goto code_r0x80de0e3d;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80de0e3d:
		  uVar1 = CONCAT44(in_register_20000014,puVar4[1]);
		  uVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,uVar1);
		  uVar5 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar6 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar6,0);
		  param3_00 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar6,StringLiteral_25458,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar6 = 3;
		  if (iVar2 == 0) {
		    uVar6 = 2;
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + iVar2 + 0x230);
		        goto code_r0x80de0f06;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80de0f06:
		  iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,CONCAT44(uVar5,puVar4[1]));
		  uVar10 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x18) + 8);
		  uVar5 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar5,param2_00,
		             Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator___c__DisplayClass10_0__ItemOnActionButtonClickedEvent_b__0__
		             ,0);
		  UI_Windows_ConfirmAccelerateWindow__Show(uVar6,(double)fVar3,param3_00,uVar10,uVar5,0);
		  return;
		}
		*/

		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E4")]
		[Address(RVA = "0x9098", Offset = "0x9098", VA = "0x9098")]
		private void ItemOnActionButtonClickedEvent(BaseBuildingData clanBuildingData)
		{
		/* --- GHIDRA: ItemOnActionButtonClickedEvent ---
		void Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator__ItemOnActionButtonClickedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  uint *puVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a577e6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ZigguratWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_MainBuildingView_ClanIsle__get_IsleBg__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_MainBuildingView_ClanIsle__get_TreeBg__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18576);
		    DAT_ram_00a577e6 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar7 = *(undefined4 *)(*(int *)(iVar2 + 0x40) + 0x14);
		  uVar3 = Gameplay_Isles_Clan_Model_ClanIsleModel__GetCancelImproveMoneyBack(param1[2],0);
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (uVar7,uVar3,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar7 = *(undefined4 *)(*(int *)(iVar2 + 0x40) + 0x18);
		  piVar4 = (int *)System_Collections_Generic_List_object___get_Item
		                            (*(undefined4 *)(param1[2] + 0x24),1,
		                             Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                            );
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x108) * 4))
		                    (piVar4,*(undefined4 *)(*piVar4 + 0x10c));
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar7,uVar3,0);
		  iVar2 = Gameplay_World_Model_ClanData__get_IsRightHandClan(*(undefined4 *)(param1[2] + 0x30),0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar2 == 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(iVar5 + 0x5c),0,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x44),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    return;
		  }
		  uVar1 = 0;
		  uVar3 = *(undefined4 *)(iVar5 + 0x44);
		  piVar4 = *(int **)(param1[2] + 0x1c);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		        goto code_r0x80de0778;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80de0778:
		  uVar7 = (**(code **)((ulonglong)*puVar6 * 4))(piVar4,puVar6[1]);
		  uVar7 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar7,StringLiteral_18576,0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar3,uVar7,0);
		  iVar5 = *param1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar5 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x44),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,1,0);
		  Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator__BuildingStateChangedEventHandler
		            (param1,iVar5);
		  return;
		}
		*/

		}

		// Token: 0x060041E5 RID: 16869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E5")]
		[Address(RVA = "0x9099", Offset = "0x9099", VA = "0x9099")]
		private void HandleZigguratState()
		{
		/* --- GHIDRA: HandleZigguratState ---
		void Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator__HandleZigguratState
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  uint *puVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a577e7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ZigguratWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_BuildingStateChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_HandleZigguratState__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_IsleInformationChangedEventHandler__
		              );
		    DAT_ram_00a577e7 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar8 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,
		                  Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_BuildingStateChangedEventHandler__
		                  ,0);
		    iVar4 = func_ii_7048(uVar8,uVar3,0);
		    uVar3 = System_Action_uint__TypeInfo;
		    if (iVar4 == 0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar4,System_Action_uint__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar4,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar2 + 0x14) = iVar5;
		      uVar3 = System_Action_uint__TypeInfo;
		      iVar2 = func_ii_1082(iVar4,System_Action_uint__TypeInfo);
		      if (iVar2 == 0) {
		        System_Activator__CreateInstance(iVar4,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar8 = *(undefined4 *)(iVar4 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_IsleInformationChangedEventHandler__
		               ,0);
		    piVar6 = (int *)func_ii_7048(uVar8,uVar3,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar6 == (int *)0x0) {
		      *(undefined4 *)(iVar4 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar6) ||
		            (*(int **)(iVar4 + 0x1c) = piVar6, *piVar6 != iVar2)) {
		      System_Activator__CreateInstance(piVar6,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar7 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x230);
		          goto code_r0x80de1192;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar7 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80de1192:
		    iVar2 = (**(code **)((ulonglong)*puVar7 * 4))(piVar6,puVar7[1]);
		    iVar4 = *(int *)(iVar2 + 0x14);
		    uVar8 = *(undefined4 *)(iVar4 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_HandleZigguratState__,
		               0);
		    piVar6 = (int *)func_ii_7048(uVar8,uVar3,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar6 == (int *)0x0) {
		      *(undefined4 *)(iVar4 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar6) ||
		            (*(int **)(iVar4 + 0x14) = piVar6, *piVar6 != iVar2)) {
		      System_Activator__CreateInstance(piVar6,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar8 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,
		                  Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_BuildingStateChangedEventHandler__
		                  ,0);
		    iVar4 = UnityEngine_UI_Image__set_sprite(uVar8,uVar3,0);
		    uVar3 = System_Action_uint__TypeInfo;
		    if (iVar4 == 0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar4,System_Action_uint__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar4,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar2 + 0x14) = iVar5;
		      uVar3 = System_Action_uint__TypeInfo;
		      iVar2 = func_ii_1082(iVar4,System_Action_uint__TypeInfo);
		      if (iVar2 == 0) {
		        System_Activator__CreateInstance(iVar4,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar8 = *(undefined4 *)(iVar4 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_IsleInformationChangedEventHandler__
		               ,0);
		    piVar6 = (int *)UnityEngine_UI_Image__set_sprite(uVar8,uVar3,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar6 == (int *)0x0) {
		      *(undefined4 *)(iVar4 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar6) ||
		            (*(int **)(iVar4 + 0x1c) = piVar6, *piVar6 != iVar2)) {
		      System_Activator__CreateInstance(piVar6,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar7 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x230);
		          goto code_r0x80de13bb;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar7 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80de13bb:
		    iVar2 = (**(code **)((ulonglong)*puVar7 * 4))(piVar6,puVar7[1]);
		    iVar4 = *(int *)(iVar2 + 0x14);
		    uVar8 = *(undefined4 *)(iVar4 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_HandleZigguratState__,
		               0);
		    piVar6 = (int *)UnityEngine_UI_Image__set_sprite(uVar8,uVar3,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar6 == (int *)0x0) {
		      *(undefined4 *)(iVar4 + 0x14) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar6) || (*(int **)(iVar4 + 0x14) = piVar6, *piVar6 != iVar2))
		    {
		      System_Activator__CreateInstance(piVar6,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000CF7 RID: 3319
		// (set) Token: 0x060041E6 RID: 16870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF7")]
		public override ClanIsleEvents Events
		{
			[Token(Token = "0x60041E6")]
			[Address(RVA = "0x909A", Offset = "0x909A", VA = "0x909A", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060041E7 RID: 16871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E7")]
		[Address(RVA = "0x909B", Offset = "0x909B", VA = "0x909B")]
		private void IsleInformationChangedEventHandler()
		{
		/* --- GHIDRA: IsleInformationChangedEventHandler ---
		void Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator__IsleInformationChangedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param3_00;
		  undefined4 uVar2;
		  int local_4;
		  
		  if (DAT_ram_00a577e9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ZigguratWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_ClanBuildingTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_MainBuildingView_ClanIsle__GetBuildingView__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18800);
		    DAT_ram_00a577e9 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param3_00 = UI_Windows_Buildings_MainBuildingView2___Il2CppFullySharedGenericType____ctor
		                          (*(undefined4 *)(iVar1 + 0x40),param2,
		                           Method_UI_Windows_Buildings_MainBuildingView_ClanIsle__GetBuildingView__)
		    ;
		    local_4 = param2;
		    uVar2 = func_ii_1081(Protocol_Consts_ClanBuildingTypes_TypeInfo,&local_4);
		    uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_18800,uVar2,param3_00,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		    iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param3_00,0);
		    if (iVar1 != 0) {
		      uVar2 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(param1[2] + 0x24),param2,
		                         Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                        );
		      UI_Windows_Buildings_BaseBuildingItemView__OnDestroy
		                (param3_00,uVar2,*(undefined4 *)(*(int *)(param1[2] + 0x30) + 0x14),
		                 *(undefined4 *)(param1[2] + 8),0);
		    }
		    if (param2 == 1) {
		      Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator__ItemOnActionButtonClickedEvent
		                (param1,param1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E8")]
		[Address(RVA = "0x909C", Offset = "0x909C", VA = "0x909C")]
		private void BuildingStateChangedEventHandler(uint buildingType)
		{
		/* --- GHIDRA: BuildingStateChangedEventHandler ---
		void Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator__BuildingStateChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  longlong lVar4;
		  longlong lVar5;
		  int *param1_00;
		  int param2_00;
		  undefined4 uVar6;
		  uint uVar7;
		  
		  if (DAT_ram_00a577ea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ZigguratWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4203);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4204);
		    DAT_ram_00a577ea = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar1 + 0x5c),1,0);
		  lVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(*(int *)(param1[2] + 0x30) + 0x14),0);
		  lVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(param1[2] + 8),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (lVar4 != lVar5) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(iVar1 + 0x50),0,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x4c);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4203,1,0,1,0,0,0,0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar6,uVar3,0);
		    return;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar1 + 0x50),1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(iVar1 + 0x4c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4204,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar6,uVar3,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar7 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar1 = *param1_00;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8 + 4) * 8 + iVar1 + 0x230);
		        goto code_r0x80de09af;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar7);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80de09af:
		  iVar1 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  param2_00 = *(int *)(*(int *)(iVar1 + 0x10) + 0x18);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(param2_00 + 0xc);
		  uVar3 = *(undefined4 *)(iVar1 + 0x58);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar6 = Core_Money_Money__op_Explicit(uVar6,0);
		  UI_Price_Price__SetColor(uVar3,param2_00,uVar6,0);
		  return;
		}
		*/

		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E9")]
		[Address(RVA = "0x909D", Offset = "0x909D", VA = "0x909D")]
		[CompilerGenerated]
		private void <HandleZigguratState>g__HandleTitledList|11_0()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a577e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUnregisterClanAns__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BaseBuildingData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_MainBuildingView_ClanIsle__get_BuildingItems__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClansService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_ClansServiceOnClanUnregisteredEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_ClansServiceOnUserLeftClanEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_InClanButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_ItemOnActionButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_ItemOnClickedEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_RepairButtonClickedEventHandler__
		              );
		    DAT_ram_00a577e0 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  iVar1 = 0;
		  param1_00 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                        (Method_Core_Net_ServiceFactory_GetService_ClansService___);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar2 + 0x48);
		  uVar3 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_InClanButtonClickedEventHandler__
		             ,0);
		  UI_IndexButtonBasic__add_ClickEvent(uVar4,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(*(int *)(iVar2 + 0x54) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_RepairButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar4,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x40) + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      uVar4 = *(undefined4 *)(iVar2 + iVar1 * 4 + 0x10);
		      uVar3 = unnamed_function_1417(System_Action_BaseBuildingData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,
		                 Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_ItemOnActionButtonClickedEvent__
		                 ,0);
		      UI_Windows_Buildings_BaseBuildingItemView__add_ActionButtonClickedEvent(uVar4,uVar3,0);
		      uVar3 = unnamed_function_1417(System_Action_BaseBuildingData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,
		                 Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_ItemOnClickedEvent__
		                 ,0);
		      UI_Windows_Buildings_BaseBuildingItemView__add_ClickedEvent(uVar4,uVar3,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  uVar3 = unnamed_function_1417(System_Action_ProtoUserLeftClanEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_ClansServiceOnUserLeftClanEvent__
		             ,0);
		  ServicesNamespace_ClansService__add_UserLeftClanEvent(param1_00,uVar3,0);
		  uVar3 = unnamed_function_1417(System_Action_ProtoUnregisterClanAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator_ClansServiceOnClanUnregisteredEvent__
		             ,0);
		  ServicesNamespace_ClansService__add_ClanUnregisteredEvent(param1_00,uVar3,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 param2_00;
		  int param1_00;
		  int *param1_01;
		  int iVar3;
		  uint *param2_01;
		  int iVar4;
		  int *piVar5;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a577e8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ZigguratWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountHandler_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_MainBuildingView_ClanIsle__get_BuildingItems__);
		    DAT_ram_00a577e8 = '\x01';
		  }
		  param2_01 = (uint *)*param1;
		  iVar2 = (**(code **)((ulonglong)param2_01[0x56] * 4))(param1,param2_01[0x57]);
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x40) + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      param1_00 = *(int *)(iVar2 + iVar3 * 4 + 0x10);
		      param2_00 = System_Collections_Generic_List_object___get_Item
		                            (*(undefined4 *)(param1[2] + 0x24),*(undefined4 *)(param1_00 + 0x38),
		                             Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                            );
		      UI_Windows_Buildings_BaseBuildingItemView__OnDestroy
		                (param1_00,param2_00,*(undefined4 *)(*(int *)(param1[2] + 0x30) + 0x14),
		                 *(undefined4 *)(param1[2] + 8),0);
		      param1_01 = *(int **)(param1[2] + 0x20);
		      if (param1_01 == (int *)0x0) {
		        param2_01 = (uint *)0x0;
		      }
		      else {
		        iVar4 = *param1_01;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar5 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		            if (Gameplay_Discounts_Model_IDiscountHandler_TypeInfo == *piVar5) {
		              param2_01 = (uint *)(iVar4 + piVar5[1] * 8 + 0xc0);
		              goto code_r0x80de159b;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        param2_01 = (uint *)func_ii_1080(param1_01,
		                                         Gameplay_Discounts_Model_IDiscountHandler_TypeInfo,0);
		code_r0x80de159b:
		        (**(code **)((ulonglong)*param2_01 * 4))(param1_01,param1_00,param2_01[1]);
		      }
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < *(int *)(iVar2 + 0xc));
		  }
		  Gameplay_Clans_Ziggurat_Controller_ZigguratViewMediator__ItemOnActionButtonClickedEvent
		            (param1,param2_01);
		  return;
		}
		*/

}
